//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vanilla.Character.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class character_inventory
    {
        public long guid { get; set; }
        public long bag { get; set; }
        public byte slot { get; set; }
        public long item { get; set; }
        public long item_template { get; set; }
    }
}
