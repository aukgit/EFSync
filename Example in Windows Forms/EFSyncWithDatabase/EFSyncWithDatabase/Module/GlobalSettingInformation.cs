using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSyncWithDatabase.Module
{
    class GlobalSettingInformation
    {
        public int ProjectCount { get; set; }
        public string ListOfProjects { get; set; }
        public string SQLServerInstanceName { get; set; }
        public string SQLServerAltInstanceName { get; set; }
    }
}
