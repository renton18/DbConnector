using System;
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
                var dbConnector = new DbConnector(DbType.MYSQL, dbServerName, dbPort, dbName, dbUser, dbPassword);
                dbConnector.connector.Open();
                var sql = "select * from test";
                showDgv.DataSource = dbConnector.connector.ExecuteQuery(sql);
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
                    dbtype = DbType.MYSQL;
                    break;
                case 1:
                    dbtype = DbType.SQLSERVER;
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
