
namespace MVC_Project.Models.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chapter
    {
        public Chapter()
        {
            this.Topics = new HashSet<Topic>();
        }
    
        public short ChapterNumber { get; set; }
        public string ChapterName { get; set; }
        public int SubjectId { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
