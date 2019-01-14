using System;
using System.Data;
using System.Windows.Forms;

namespace DbConnector
{
    public partial class Form1 : Form
    {
        private DbType dbtype;
        private string dbServerName;
        private string dbName;
        private string dbPort;
        private string dbUser;
        private string dbPassword;

        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
        }

        private void sqlServerBt_Click(object sender, EventArgs e)
        {
            SetSetting();
            try
            {
                var dbConnector = new DbConnector(dbtype).GetDbInstance(dbServerName, dbPort, dbName, dbUser, dbPassword);
                dbConnector.Open();

                var sql = "";
                switch (dbTypeCb.SelectedItem.ToString())
                {
                    case "mysql":
                        sql = "select * from test";
                        break;
                    case "sqlserver":
                        sql = "select * from Person.Person";
                        break;
                }
                showDgv.DataSource = dbConnector.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                var errorStr = ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine;
                MessageBox.Show(errorStr);
                logger.Error(errorStr);
            }
        }

        private void SetSetting()
        {
            switch (dbTypeCb.SelectedIndex)
            {
                case 0:
                    dbtype = DbType.mysql;
                    break;
                case 1:
                    dbtype = DbType.sqlserver;
                    break;
            }
            this.dbServerName = serverNameTb.Text.Trim();
            this.dbName = dbNameTb.Text.Trim();
            this.dbPort = dbPortCb.SelectedItem.ToString().Trim();
            this.dbUser = userTb.Text.Trim();
            this.dbPassword = passwordTb.Text.Trim();
        }
    }
}
