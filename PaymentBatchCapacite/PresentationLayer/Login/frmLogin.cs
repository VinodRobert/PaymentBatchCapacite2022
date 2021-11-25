using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentBatchCapacite
{
    public partial class frmLogin : Form
    {

        PayBatchClass pb = new PayBatchClass();
        DataSet dsProjectList;
        DataSet dsPrevilagedMenus;



        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll()
        {
            txtPWD.Text = "";
            txtUserID.Text = "";
            rdExternal.Checked = false;
            rdLan.Checked = true;
            rdLan.Enabled = true;
            rdExternal.Enabled = true;
          
            rdLan.Checked = true;
            rdExternal.Checked = false;
        }



        private void LoginProcess()
        {
            string _userID;
            string _pwd;
            int _success;
            if (rdLan.Checked == true )
                GlobalVariables.connectedBy = 0;
            if (rdExternal.Checked==true )
                GlobalVariables.connectedBy = 1;
          

            DataSet _ds;
            _userID = Convert.ToString(txtUserID.Text).Trim();
            _pwd = Convert.ToString(txtPWD.Text).Trim();
            _ds = pb.Login(_userID, _pwd);
            _success = Convert.ToInt16(_ds.Tables[0].Rows.Count);
            if (_success != 1)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(this, "Invalid UserID or Password/ Not Registered", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }
            else
            {
                rdExternal.Enabled = false;
                rdLan.Enabled = false;
                
                GlobalVariables.UserRole = Convert.ToInt16(_ds.Tables[0].Rows[0][3]);
                GlobalVariables.UserName = Convert.ToString(_ds.Tables[0].Rows[0][1]);
                GlobalVariables.UserID = Convert.ToString(txtUserID.Text).Trim();
                GlobalVariables.UploadingRights = Convert.ToInt16(_ds.Tables[0].Rows[0][4]);
                frmMain _main = new frmMain();
                _main.Show();
            }
        }


        List<Project> GetData()
        {
            // DisplayMember is used to display just the long name of each state.
            List<Project> ProjectList = new List<Project>();
            int borgID;
            string borgName;
            for (int i = 0; i <= dsProjectList.Tables[0].Rows.Count - 1; i++)
            {
                borgID = Convert.ToInt16(dsProjectList.Tables[0].Rows[i][0]);
                borgName = Convert.ToString(dsProjectList.Tables[0].Rows[i][1]);
                ProjectList.Add(new Project(borgID, borgName));
            }
            return ProjectList;
        }




    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( (txtUserID.Text=="") || (txtPWD.Text=="") )
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(this, "Check Your Entries", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                ResetAll();
                return;
            }

            if (btnLogin.Text == "Login")
                LoginProcess();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
