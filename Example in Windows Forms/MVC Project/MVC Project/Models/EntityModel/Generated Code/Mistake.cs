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
    
    public partial class Mistake
    {

        public Mistake()
        {
            this.NewRelDbs = new HashSet<NewRelDb>();
        }
        public int MistakeNo { get; set; }
        public int ArticleNo { get; set; }
        public long UserId { get; set; }
        public string MistakeDescription { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<NewRelDb> NewRelDbs { get; set; }
    }
}