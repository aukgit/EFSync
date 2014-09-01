using EFSyncWithDatabase.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSyncWithDatabase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataInitalizer dataInitalizer = new DataInitalizer();

            DataInitalizer.SpecificProjectSettings = new List<SpecificProjectSetting>(dataInitalizer.GetGlobalSetting().ProjectCount);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
