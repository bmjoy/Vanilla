﻿namespace Vanilla.World.Game.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.Xna.Framework;

    using Vanilla.Core.IO;
    using Vanilla.Core.Logging;
    using Vanilla.Database.Character.Models;
    using Vanilla.Database.World.Models;
    using Vanilla.World.Game.Entity.Constants;
    using Vanilla.World.Game.Entity.Object.GameObject;
    using Vanilla.World.Game.Entity.Object.Unit.Creature;
    using Vanilla.World.Game.Entity.Object.Unit.Player;
    using Vanilla.World.Network;

    public class EntityManager
    {
        private readonly VanillaWorld vanillaWorld;

        private readonly Dictionary<ulong, PlayerEntity> playerEntities = new Dictionary<ulong, PlayerEntity>();
        private readonly Dictionary<ulong, CreatureEntity> creatureEntities = new Dictionary<ulong, CreatureEntity>();
        private readonly Dictionary<ulong, GameObjectEntity> gameObjectEntities = new Dictionary<ulong, GameObjectEntity>();

        protected IRepository<Creature> CreatureDatabase { get { return vanillaWorld.WorldDatabase.GetRepository<Creature>(); } }
        protected IRepository<GameObject> GameObjectDatabase { get { return vanillaWorld.WorldDatabase.GetRepository<GameObject>(); } }

        public EntityManager(VanillaWorld vanillaWorld)
        {
            this.vanillaWorld = vanillaWorld;
        }

        public List<ISubscribable> GetEntitiesInRadius(Vector3 location, float radius)
        {
            var start = DateTime.Now;

            var entities = new List<ISubscribable>();
            var radiusSquared = radius * radius;

            entities.AddRange(from entity in this.playerEntities where (Vector3.DistanceSquared(location, entity.Value.Location.Position)) < radiusSquared select entity.Value);
            entities.AddRange(from entity in this.creatureEntities where (Vector3.DistanceSquared(location, entity.Value.Location.Position)) < radiusSquared select entity.Value);
            entities.AddRange(from entity in this.gameObjectEntities where (Vector3.DistanceSquared(location, entity.Value.Location.Position)) < radiusSquared select entity.Value);

            var creatures = CreatureDatabase.Where(creature => Math.Pow(location.X - creature.PositionX, 2) + Math.Pow(location.Y - creature.PositionY, 2) < radiusSquared);
            var gameObjects = GameObjectDatabase.Where(gameObject => Math.Pow(location.X - gameObject.PositionX, 2) + Math.Pow(location.Y - gameObject.PositionY, 2) < radiusSquared);

            entities.AddRange((from creature in creatures where !this.creatureEntities.ContainsKey((ulong)creature.GUID) select this.AddCreatureEntity(creature)));
            entities.AddRange((from gameObject in gameObjects where !this.gameObjectEntities.ContainsKey((ulong)gameObject.GUID) select this.AddGameObjectEntity(gameObject)));

            var end = (DateTime.Now - start).Milliseconds;
            Log.Print(LogType.Debug, "Time took :" + end);

            return entities;
        }

        public CreatureEntity AddCreatureEntity(Creature creature)
        {
            ObjectGUID guid = new ObjectGUID((ulong)creature.GUID, (TypeID)9); //right type?
            CreatureEntity creatureEntity = new CreatureEntity(guid, creature);
            creatureEntities.Add(guid.RawGUID, creatureEntity);
            creatureEntity.Setup();
            return creatureEntity;
        }

        public GameObjectEntity AddGameObjectEntity(GameObject gameObject)
        {
            ObjectGUID guid = new ObjectGUID((ulong)gameObject.GUID, (TypeID)21); //right type?
            GameObjectEntity gameObjectEntity = new GameObjectEntity(guid, gameObject);
            gameObjectEntities.Add(guid.RawGUID, gameObjectEntity);
            gameObjectEntity.Setup();
            return gameObjectEntity;
        }

        public PlayerEntity AddPlayerEntity(Character character, WorldSession session)
        {
            ObjectGUID guid = new ObjectGUID((ulong)character.GUID, (TypeID)25);
            PlayerEntity playerEntity = new PlayerEntity(guid, character, session);
            playerEntities.Add(guid.RawGUID, playerEntity);
            playerEntity.Setup();
            return playerEntity;
        }

        public void RemoveGameObjectEntity(PlayerEntity playerEntity)
        {
            RemoveGameObjectEntity(playerEntity.ObjectGUID.RawGUID);
        }

        public void RemoveGameObjectEntity(ulong guid)
        {
            gameObjectEntities.Remove(guid);
        }

        public void RemovePlayerEntity(PlayerEntity playerEntity)
        {
            RemovePlayerEntity(playerEntity.ObjectGUID.RawGUID);
        }

        public void RemovePlayerEntity(ulong guid)
        {
            playerEntities.Remove(guid);
        }

    }
}