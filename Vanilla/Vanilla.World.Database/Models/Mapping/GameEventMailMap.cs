namespace Vanilla.World.Database.Models.Mapping
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class GameEventMailMap : EntityTypeConfiguration<GameEventMail>
    {
        public GameEventMailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Event, raceMask = t.RaceMask, quest = t.Quest });

            // Properties
            this.Property(t => t.Event)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceMask)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quest)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        }
    }
}