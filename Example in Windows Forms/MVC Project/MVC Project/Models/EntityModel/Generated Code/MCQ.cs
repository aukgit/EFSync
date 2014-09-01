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
    
    public partial class MCQ
    {
        public MCQ()
        {
            this.LearningPiles = new HashSet<LearningPile>();
            this.MCQTAKENs = new HashSet<MCQTAKEN>();
            this.Questions = new HashSet<Question>();
        }
    
        public int QuestionSetNo { get; set; }
        public int ArticleNo { get; set; }
        public System.TimeSpan TimeLinit { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual ICollection<LearningPile> LearningPiles { get; set; }
        public virtual ICollection<MCQTAKEN> MCQTAKENs { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
