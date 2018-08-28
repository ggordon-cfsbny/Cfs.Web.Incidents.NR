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
    
    public partial class IncidentDetail
    {
        public long incidentDetailId { get; set; }
        public long incidentId { get; set; }
        public string incidentDetails { get; set; }
        public string childActivity { get; set; }
        public string protectiveActions { get; set; }
        public string eventLocation { get; set; }
        public Nullable<double> harmLevel { get; set; }
        public Nullable<double> riskLevel { get; set; }
        public string contactInfo { get; set; }
        public string incidentComments { get; set; }
        public bool internInvolved { get; set; }
        public bool volunteerInvolved { get; set; }
        public bool visitorInvolved { get; set; }
        public bool otherInvolved { get; set; }
        public string otherInvolvedDetails { get; set; }
        public string adminComments { get; set; }
        public bool adminDebrief { get; set; }
    }
}
