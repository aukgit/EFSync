//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Project.Models.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class NotificationSeen
    {
        public byte NotiSeenNo { get; set; }
        public long UserId { get; set; }
        public string Display { get; set; }
    
        public virtual User User { get; set; }
    }
}