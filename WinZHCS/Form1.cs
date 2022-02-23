using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ivony.Data;
using WinZHCS.Model;

namespace WinZHCS
{
    public partial class sxct : Form
    {
        ConfigModel config = null;
        public sxct()
        {
            InitializeComponent();
            config = ConfigModel.Config;
            initializeForm(config);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnRegister.Enabled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string serverValue = this.textBoxServer.Text;
            string userName = this.textBoxUser.Text;
            string passWord = this.textBoxPwd.Text;
            Db.UseDatabase(SqlServerDb.Connect($"Data Source = {serverValue};Initial Catalog = sxct;User Id = {userName};Password = {passWord};"));

            Db.T($"IF OBJECT_ID(N'[dbo].[Test1]') IS NOT NULL DROP TABLE [dbo].[Test1]").ExecuteNonQuery();
            Db.T($@"
            CREATE TABLE [dbo].[Test1]
            ( 
                [ID] INT NOT NULL IDENTITY,
                [Name] NVARCHAR(50) NOT NULL , 
                [Content] NTEXT NULL, 
                [XmlContent] XML NULL,
                [Index] INT NOT NULL, 
                CONSTRAINT [PK_Test1] PRIMARY KEY ([ID]) 
            )").ExecuteNonQuery();
        }

        private void initializeForm(ConfigModel config)
        {
            this.textBoxServer.Text = config.ServerName;
            this.textBoxUser.Text = config.UserName;
            this.textBoxPwd.Text = config.PassWord;
        }
    }
}
