using Syncfusion.Windows.Forms;
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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stripBatchAwaitingApproval_Click(object sender, EventArgs e)
        {
            //frmBatchAwaitingApproval batchAwaitingApproval = new frmBatchAwaitingApproval();
            //batchAwaitingApproval.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attachProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.UserRole == 0)
            {
                //frmPayBatchProjects PayBatchProjects = new frmPayBatchProjects();
                //PayBatchProjects.Show();
            }
            else
            {
                attachProjectsToolStripMenuItem.Visible = false;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.Show("Not Authorized", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void attachUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.UserRole == 0)
            {
                //frmPayBatchUsers PayBatchUsers = new frmPayBatchUsers();
                //PayBatchUsers.Show();
            }
            else
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.Show("Not Authorized", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void userProjectLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GlobalVariables.UserRole == 0)
            ////{
            ////    frmProjectUsers ProjectUsers = new frmProjectUsers();
            ////    ProjectUsers.Show();
            //}
            //else
            //{
            //    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
            //    MessageBoxAdv.Show("Not Authorized", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GlobalVariables.UserRole == 0)
            //{
            //    frmPayBatchBanks PayBatchBanks = new frmPayBatchBanks();
            //    PayBatchBanks.Show();
            //}
            //else
            //{
            //    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
            //    MessageBoxAdv.Show("Not Authorized", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void approvalLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GlobalVariables.UserRole == 0)
            //{
            //    frmApprovelLevels ApprovalLevels = new frmApprovelLevels();
            //    ApprovalLevels.Show();
            //}
            //else
            //{
            //    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
            //    MessageBoxAdv.Show("Not Authorized", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            statusStripLabel1.Text = "User Name : " + Convert.ToString(GlobalVariables.UserName).Trim();
            if (GlobalVariables.UserRole == 0)
            {
                attachProjectsToolStripMenuItem.Visible = true;
                attachUsersToolStripMenuItem.Visible = true;
                userProjectLinkToolStripMenuItem.Visible = true;
                banksToolStripMenuItem.Visible = true;
                approvalLevelsToolStripMenuItem.Visible = true;
            }
            else
            {
                attachProjectsToolStripMenuItem.Visible = false;
                attachUsersToolStripMenuItem.Visible = false;
                userProjectLinkToolStripMenuItem.Visible = false;
                banksToolStripMenuItem.Visible = false;
                approvalLevelsToolStripMenuItem.Visible = false;
            }

            if (GlobalVariables.UploadingRights == 1)
            {
                utilityToolStripMenuItem.Visible = true;
            }
            else
            {
                utilityToolStripMenuItem.Visible = false;
            }
        }

        private void approvedBatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GlobalVariables.UserRole == 1)
            //{
            //    frmBatchApproved BatchApproved = new frmBatchApproved();
            //    BatchApproved.Show();
            //}
            //else
            //{
            //    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
            //    MessageBoxAdv.Show("Not Authorized", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRTGS f = new frmRTGS();
            //f.Show();
        }

        private void prepareRTGSLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRTGS rtgs = new frmRTGS();
            //rtgs.Show();
        }

        private void trackMyBatch_Click(object sender, EventArgs e)
        {
            //frmTackMyBatch trackBatch = new frmTackMyBatch();
            //trackBatch.Show();
        }

        private void uTRFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReadUTRFile readUTR = new frmReadUTRFile();
            //readUTR.Show();
        }

        private void uploadGSTDetails_Click(object sender, EventArgs e)
        {
            //frmReadGST readGST = new frmReadGST();
            //readGST.Show();
        }

        private void gstOutstandingToolStrip_Click(object sender, EventArgs e)
        {
            //frmGSTReport gstReport = new frmGSTReport();
            //gstReport.Show();
        }

        private void postRTGSEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmApproveRTGS approveRTGS = new frmApproveRTGS();
            //approveRTGS.Show();
        }

        private void uploadSupplierBankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReadSupplier readSupplier = new frmReadSupplier();
            //readSupplier.Show();
        }

        private void beneficiaryBankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmBeneficiaryBankDetails beneficiaryBankDetails = new frmBeneficiaryBankDetails();
            //beneficiaryBankDetails.Show();
        }

        private void uploadSubContractorBankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReadSubContractor readSubContractor = new frmReadSubContractor();
            //readSubContractor.Show();
        }

        private void gSTOutstandingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGSTFile gstFile = new frmGSTFile();
            //gstFile.Show();
        }

         
        private void eXCELTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTemplates templates = new frmTemplates();
            //templates.Show();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUpdateIFSC updateIFSC = new frmUpdateIFSC();
            //updateIFSC.Show();
        }
    }
}
