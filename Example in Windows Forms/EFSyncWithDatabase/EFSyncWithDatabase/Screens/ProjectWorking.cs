using JsonCountryParsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSyncWithDatabase
{
    public partial class ProjectWorking : Form
    {
        public ProjectWorking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevMVCSetup mvcSetup = new DevMVCSetup();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //data source=(LocalDB)\v11.0;attachdbfilename='|DataDirectory|\exam2.mdf';integrated security=True;MultipleActiveResultSets=True;
            string dbAliasName = "Working1";
            string sqlConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Working\Developers Organism\Projects\DevBlog\Project Assingments\Example in Windows Forms\MVC Project\MVC Project\App_Data\exam2.mdf'; Initial Catalog='" + dbAliasName + "';Integrated Security=True;Connect Timeout=30";
            string AlterStr = "ALTER DATABASE " + dbAliasName + " SET OFFLINE WITH ROLLBACK IMMEDIATE";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("", conn);
            adp.SelectCommand.CommandText = "Select * from subject where 1=2";

            adp.Fill(dt);
            adp.SelectCommand.CommandText = AlterStr;
            adp.SelectCommand.ExecuteNonQuery();
            adp.SelectCommand.CommandText ="sys.sp_detach_db Working1";
            adp.SelectCommand.ExecuteNonQuery();


            conn.Close();
      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("This is an error");
            }
            catch (Exception ex)
            {
                DevMVCComponent.Starter.HanldeError.HandleBy(ex, "button2_Click");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpecificProjectSetting sps = new SpecificProjectSetting();
            sps.ShowDialog();

        }
    }
}
