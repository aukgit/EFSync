using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSyncWithDatabase.Module
{
    class SpecificProjectInformation
    {

        public string  ProjectName { get; set; }
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// total path
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// D:\
        /// </summary>
        public string LocationDrive { get; set; }

        /// <summary>
        /// Relative path, web.config
        /// </summary>
        public string WebConfigRelativePath { get; set; }

        public string ProjectDatabaseContexts { get; set; }
        /// <summary>
        /// Relative path to database locations
        /// </summary>
        public string[] ProjectDatabases { get; set; }

        public string[] ConnectionStringsInWebConfig { get; set; }

        public string CurrentlyWorkingConnectionString { get; set; }

        /// <summary>
        /// path, projectName_EFSyncDevOrg.json
        /// </summary>
        public string ProjetSpecificInformationSavedFileLog { get; set; }

        public void CreateProject(string projectName)
        {
            this.ProjectName = projectName;

        }


    }
}
