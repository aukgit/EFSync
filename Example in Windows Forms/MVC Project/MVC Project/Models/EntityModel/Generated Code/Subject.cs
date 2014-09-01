
namespace MVC_Project.Models.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Subject
    {
        public Subject()
        {
            this.Chapters = new HashSet<Chapter>();
        }
    
        public int SubjectID { get; set; }
        [StringLength(100)]
        [DisplayName("Hello")]        
        public string SubjectName { get; set; }

        public int xy { get; set; }
        [ForeignKey("SubjectId")]
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
