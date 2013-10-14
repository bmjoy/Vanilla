using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace Vanilla.Character.Database.Models
{

	    [Table("character_social", Schema="characters")]

    public partial class character_social
    {
 
        [Column("guid")] 
		        public long guid { get; set; }
 
        [Column("friend")] 
		        public long friend { get; set; }
 
        [Column("flags")] 
		        public bool flags { get; set; }
    }
}