using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSyncWithDatabase.Module
{
    class FileSyncInformation
    {
        public string[] ListOfClassFiles { get; set; }
        public DateTime[] ListOfClassFilesCurrentModifiedDate { get; set; }
        public DateTime[] ListOfClassFilesLastModifiedDate { get; set; }

        public List<string> UnSyncedFiles { get; set; }

     
        public bool Sync(string classFilename)
        {
            //if file is not synced then have to make those sync by prompting user or 
            //adding new fields from db 
            //or adding new field to db.
        }

        public void UpdateFileModifiedDates(){
            //only update
            //ListOfClassFilesCurrentModifiedDate
        }

        public bool CheckIfSynced()
        {
            //linq comparison
            UpdateFileModifiedDates();
            //then comparison.

        }
        
    }
}
