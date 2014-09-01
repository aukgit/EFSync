
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSyncWithDatabase.Module
{
    public class CSharpClassPropertyType
    {
        public string PropertyName { get; set; }
        public string TypeName { get; set; }

        public List<CSharpAnnotationType> Annotations { get; set; }
    }
}
