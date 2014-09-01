using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSyncWithDatabase.Module
{
    class DataInitalizer
    {
        public ClientProjectParse ClientProjectParser { get; set; }
        public static List<SpecificProjectSetting> SpecificProjectInformations { get; set; }

        public static GlobalSettingInformation GlobalSettings { get; set; }
        public DataInitalizer()
        {
            ClientProjectParser = new ClientProjectParse();
            

        }

        public GlobalSettingInformation GetGlobalSetting() { 
            //read from file.
            string filetext = File.ReadAllText("");
            GlobalSettings = JsonConvert.DeserializeObject<GlobalSettingInformation>(filetext);
            return GlobalSettings;
        }
    }
}
