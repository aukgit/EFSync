using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonCountryParsing
{
    class DevMVCSetup
    {
        public DevMVCSetup()
        {
             //testmailer.why@gmail.com 
            DevMVCComponent.Config.ApplicationName = "Testing Country";
            DevMVCComponent.Config.AdminEmail = "testmailer.why@gmail.com";
            DevMVCComponent.Config.DeveloperEmail = "testmailer.why@gmail.com";
            DevMVCComponent.Config.Assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //Configure this with add a sender email.
            DevMVCComponent.Starter.Mailer = new DevMVCComponent.Mailers.GmailConfig("testmailer.why@gmail.com","asdf1234@");
     
        }
    }
}
