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
    
    public partial class character_ticket
    {
        public long ticket_id { get; set; }
        public long guid { get; set; }
        public string ticket_text { get; set; }
        public string response_text { get; set; }
        public System.DateTime ticket_lastchange { get; set; }
    }
}