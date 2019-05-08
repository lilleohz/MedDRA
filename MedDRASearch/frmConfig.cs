using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedDRASearch
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {            
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DBUtility.ConfigHelper.DBConn dc = new DBUtility.ConfigHelper.DBConn();
            dc.Server = txtServer.Text;
            dc.Port = txtPort.Text;
            dc.Database = cbbDatabases.Text;
            dc.UID = txtUID.Text;
            dc.PWD = txtPWD.Text;
            DBUtility.ConfigHelper.WriteDBConfig(Application.StartupPath + "\\Config.xml", dc);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            DBUtility.ConfigHelper.DBConn dc = DBUtility.ConfigHelper.GetDBConfig(Application.StartupPath + "\\Config.xml");
            txtServer.Text = dc.Server;
            txtPort.Text = dc.Port;
            txtUID.Text = dc.UID;
            txtPWD.Text = dc.PWD;
            cbbDatabases.Text = dc.Database;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connstring = "Server=";
            connstring += txtServer.Text;
            connstring += ";Port=" + txtPort.Text;
            connstring += ";Database=" + cbbDatabases.Text;
            connstring += ";UID=" + txtUID.Text;
            connstring += ";PWD=" + txtPWD.Text;

            this.Cursor = Cursors.WaitCursor;
            if (DBUtility.DbHelperMySQL.ServerTest(connstring))
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("数据库连接正常！", "MedDRASearch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("数据库连接不上！", "MedDRASearch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbDatabases_DropDown(object sender, EventArgs e)
        {
            string connstring = "Server=";
            connstring += txtServer.Text;
            connstring += ";Port=" + txtPort.Text;
            connstring += ";UID=" + txtUID.Text;
            connstring += ";PWD=" + txtPWD.Text;

            cbbDatabases.Items.Clear();

            Cursor = Cursors.WaitCursor;
            List<string> dbsl = DBUtility.DbHelperMySQL.DatabaseList(connstring);
            foreach (string dbname in dbsl)
            {
                cbbDatabases.Items.Add(dbname);
            }
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
