//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cfs.Web.Incidents.NR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HighRisk
    {
        public long highRiskClientId { get; set; }
        public string clientId { get; set; }
        public Nullable<int> systemId { get; set; }
        public string clientName { get; set; }
        public System.DateTime dateAdded { get; set; }
        public Nullable<System.DateTime> dateRemoved { get; set; }
        public string clientComments { get; set; }
        public long addedById { get; set; }
        public string addedByName { get; set; }
        public System.DateTime addedStamp { get; set; }
        public Nullable<long> modifiedById { get; set; }
        public string modifiedByName { get; set; }
        public Nullable<System.DateTime> modifiedStamp { get; set; }
    }
}
