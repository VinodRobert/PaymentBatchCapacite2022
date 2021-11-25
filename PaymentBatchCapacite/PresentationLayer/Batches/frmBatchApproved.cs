using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
 
using System.Globalization;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.DataGridConverter;
using System.IO;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace PaymentBatchCapacite
{
    public partial class frmBatchApproved : Form
    {
        PayBatchClass pb = new PayBatchClass();
        string batchOwner;
        string batchStatus;
        DataSet dsApprovedBatches;
        List<ApprovedPaymentBatch> list;
        List<ApprovedPaymentBatch> PaymentBatchList;
        PaymentBatch myBatch;
        int RTGSID;
        bool noBatchForSubmission;    

        public frmBatchApproved()
        {
            InitializeComponent();
            this.Location = new Point(20, 90);
        }

        List<ApprovedPaymentBatch> GetOpenBatches()
        {
            string filterExpression;
            string projectSelected = Convert.ToString(cmbProjects.Text).Trim();
            filterExpression = "BSORGNAME='" + projectSelected + "'";
            System.Data.DataRow[] rowsFiltered = dsApprovedBatches.Tables[0].Select(filterExpression);
            PaymentBatchList = new List<ApprovedPaymentBatch>();
            int batchID;
            string processName;
            string batchNo;
            string narration;
            string bsBorgName;
            string partyCode;
            string partyName;
            decimal batchOutstanding;
            decimal cilOutstanding;
          
            bool selected;
            int detailID;
            for (int i = 0; i <= rowsFiltered.Count() - 1; i++)
            {
                batchID = Convert.ToInt16(rowsFiltered[i][0]);
                detailID = Convert.ToInt16(rowsFiltered[i][1]);  
                processName = Convert.ToString(rowsFiltered[i][2]);
                batchNo = Convert.ToString(rowsFiltered[i][3]);
                narration = Convert.ToString(rowsFiltered[i][4]);
                bsBorgName = Convert.ToString(rowsFiltered[i][5]);
                partyCode = Convert.ToString(rowsFiltered[i][6]);
                partyName = Convert.ToString(rowsFiltered[i][7]);
                batchOutstanding = Convert.ToDecimal(rowsFiltered[i][8]);
             
                selected = Convert.ToBoolean(rowsFiltered[i][9]);
                
                PaymentBatchList.Add(new ApprovedPaymentBatch(selected,batchID,detailID,processName,batchNo,narration,bsBorgName,partyCode,partyName,batchOutstanding));
            }
            return PaymentBatchList;
        }

        private void LoadPaymentModes()
        {
            List<string> listPaymentModes  = new List<string>();
            listPaymentModes.Add("Manual RTGS");
            listPaymentModes.Add("Cheque Mode");
            listPaymentModes.Add("Web API");
            cmbPaymentMode.DataSource = listPaymentModes;
            cmbPaymentMode.Visible = true;
            cmbPaymentMode.Enabled = true;
        }

        private void ResetAll()
        {
            batchGrid.Visible = false;
            btnPrint.Enabled = false;
            btnSubmit.Enabled = false;
            cmbPaymentMode.Enabled = false;
            cmbBanks.Enabled = false;
            cmbProjects.Enabled = false;
            DataPager.Visible = false;
            txtMonths.Visible = false;
            lblPage.Visible = false;
            lblGridHeader.Visible = false;
            rtgsPanel.Visible = false;
        }

        private void LoadProjects()
        {
            List<Project> listProjects = new List<Project>();
            string projectName;
            int projectID;
            for (int i = 0; i <= dsApprovedBatches.Tables[1].Rows.Count - 1; i++)
            {
                projectName = Convert.ToString(dsApprovedBatches.Tables[1].Rows[i][1]);
                projectID = Convert.ToInt32(dsApprovedBatches.Tables[1].Rows[i][0]);
                listProjects.Add(new Project(projectID, projectName));
            }
            cmbProjects.DataSource = listProjects;
            cmbProjects.Enabled = true;
            cmbProjects.Visible = true;
        }

        private void LoadBanks()
        {
            List<PBBanks> listBanks = new List<PBBanks>();
            string bankName;
            int bankID;
            string filterExpression;
            int borgSelected = Convert.ToInt32(cmbProjects.SelectedValue);
            filterExpression = "BORGID=" + Convert.ToString(borgSelected).Trim();
            System.Data.DataRow[] rowsFiltered = dsApprovedBatches.Tables[2].Select(filterExpression);

            for (int i=0;i<=rowsFiltered.Count()-1;i++)
            {
                bankName = Convert.ToString(rowsFiltered[i][2]);
                bankID = Convert.ToInt32(rowsFiltered[i][1]);
                listBanks.Add(new PBBanks(bankID, bankName));
            }
            cmbBanks.DataSource = listBanks;
            cmbBanks.Enabled = true;
            cmbBanks.Visible = true;

            
        }

        private void frmBatchAwaitingApproval_Load(object sender, EventArgs e)
        {
            ResetAll();
            batchOwner = Convert.ToString(GlobalVariables.UserID);
            batchStatus = "A";
            

            dsApprovedBatches = pb.GetBatches(batchOwner, batchStatus);
            int maxRows = dsApprovedBatches.Tables[0].Rows.Count;
            if (maxRows == 0)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(this, "No Approved Batches For Action  !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
            
               
                LoadProjects();

              
            }
        }


        private void LoadGrid()
        {
            
            list = GetOpenBatches();
       
            var data = list;
             
            batchGrid.Columns[7].Format = "c";
            batchGrid.Columns[8].Format = "c";
            
            this.batchGrid.ThemeName = "Office2019Colorful";

            this.DataPager.Style.PageButtonStyle.BackColor = Color.LightSeaGreen;
         //   this.DataPager.Style.PageButtonStyle.FocusedBackColor = Color.Silver;
            DataPager.DataSource = list;
            DataPager.PageSize =15;
            batchGrid.DataSource = DataPager.PagedSource;
            batchGrid.Refresh();


          //  Verdana, 10.2pt

            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Bottom;
            

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "BatchTotal";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "{Sum:c}";
             
            summaryColumn1.MappingName = "BatchOutstanding";
            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);


            GridSummaryColumn summaryColumn2 = new GridSummaryColumn();
            summaryColumn2.Name = "CILTotal";
            summaryColumn2.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn2.Format = "{Sum:c}";
            summaryColumn2.MappingName = "CILOutstanding";
            tableSummaryRow1.SummaryColumns.Add(summaryColumn2);

            GridSummaryColumn summaryColumn3 = new GridSummaryColumn();
            summaryColumn3.Name = "ProjectTotal";
            summaryColumn3.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn3.Format = "{Sum:c}";
            summaryColumn3.MappingName = "ProjectOutstanding";
            tableSummaryRow1.SummaryColumns.Add(summaryColumn3);


            GridSummaryColumn summaryColumn4 = new GridSummaryColumn();
            summaryColumn4.Name = "GSTTotal";
            summaryColumn4.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn4.Format = "{Sum:c}";
            summaryColumn4.MappingName = "GSTOutstanding";
            tableSummaryRow1.SummaryColumns.Add(summaryColumn4);


            this.batchGrid.TableSummaryRows.Add(tableSummaryRow1);


            GridSummaryRow groupSummaryRow1 = new GridSummaryRow();
            groupSummaryRow1.Name = "Total";
            groupSummaryRow1.ShowSummaryInRow = true;
            groupSummaryRow1.Title = "Total";

            // Creates the GridSummaryColumn.
            GridSummaryColumn summaryColumn5 = new GridSummaryColumn();
            summaryColumn5.Name = "BatchTotal";
            summaryColumn5.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn5.Format = "{Sum:c}";
            summaryColumn5.MappingName = " BatchOutstanding ";

            // Adds the GridSummaryColumn in SummaryColumns collection.
            groupSummaryRow1.SummaryColumns.Add(summaryColumn5);

            // Adds the summary row in the GroupSummaryRows collection.
            this.batchGrid.GroupSummaryRows.Add(groupSummaryRow1);

            NumberFormatInfo numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.CurrencyDecimalDigits = 0;
            numberFormat.CurrencyGroupSizes = new int[] { };
            batchGrid.Visible = true;
            lblGridHeader.Visible = true; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = false;

            cmbPaymentMode.Enabled = false;
            cmbProjects.Enabled = false;
            cmbBanks.Enabled = false;


            if (  (cmbProjects.Text=="Select Project") || (cmbBanks.Text=="Select Bank") || (cmbPaymentMode.Text =="Select Payment Mode") )
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(this, "Check Your Selections", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                btnSubmit.Enabled = true;
                return;

            }
            if (cmbPaymentMode.Text == "Manual RTGS")
            {
                int bankID = Convert.ToInt32(cmbBanks.SelectedValue);
                string loginID = Convert.ToString(GlobalVariables.UserID);
                int borgID = Convert.ToInt32(cmbProjects.SelectedValue);
                DataSet openWallet = pb.CheckWhetherOpenWalletsExists(loginID, borgID, bankID);
                RTGSID = Convert.ToInt16(openWallet.Tables[0].Rows[0]["RTGSID"]);
                string rtgdsNumber = Convert.ToString(openWallet.Tables[0].Rows[0]["RTGSNUMBER"]);
                DateTime rtgsDate = Convert.ToDateTime(openWallet.Tables[0].Rows[0]["RTGSDATE"]);
                int existingCount = Convert.ToInt16(openWallet.Tables[1].Rows[0][0]);
                
              
            }
        
        }

        private void batchGrid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }

        private void batchGrid_DrawCell(object sender, DrawCellEventArgs e)
        {
            if (batchGrid.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }

            if (e.DataRow.RowType == RowType.TableSummaryRow)
            {
                double result;
                double.TryParse((e.DataRow.RowData as SummaryRecordEntry).SummaryValues[0].AggregateValues.ElementAt(0).Value.ToString(), out result);
                if (result > 10000)
                    e.Style.BackColor = Color.Beige;
                else
                    e.Style.BackColor = Color.Bisque;
            }

            if (e.DataRow.RowType == RowType.HeaderRow)
            {
                e.Style.BackColor = Color.DarkBlue;
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var options = new ExcelExportingOptions();
            options.ExcludeColumns.Add("BatchID");
            options.ExcludeColumns.Add("Selected");
            options.ExcelVersion = ExcelVersion.Excel2013;
            var excelEngine = batchGrid.ExportToExcel(batchGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created workbook.
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                if (MessageBoxAdv.Show(this.batchGrid, "Do you want to view the workbook?", "Workbook has been created",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }

        }

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {
            int pageSize = Convert.ToInt16(txtMonths.Text);
            DataPager.PageSize = pageSize;
            batchGrid.DataSource = DataPager.PagedSource;
            batchGrid.Refresh();
        }

        private void batchGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
          
                e.Column.HeaderText = "AutoGenerated";
                e.Column.HeaderStyle.BackColor = Color.LightSkyBlue;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProjects_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProjects.Text == "Select Project")
            {

            }
            else
            {
                LoadBanks();
                LoadPaymentModes();
                LoadGrid();
                btnSubmit.Enabled = true;
                btnPrint.Enabled = true;
            }
        }

        private void btnSubmitRTGS_Click(object sender, EventArgs e)
        {
            string answer = Convert.ToString(txtRTGSConfirm.Text).ToUpper();
            int borgID = Convert.ToInt32(cmbProjects.SelectedValue);
            int bankID = Convert.ToInt32(cmbBanks.SelectedValue);
            string loginID = Convert.ToString(GlobalVariables.UserID);
            int sucessRTGSWallet;
            int selectedParties;
            string partyCode;
            int haveBankAccountDetails;
            int failedDueToNoBankDetails;

            string warningMessage;
            failedDueToNoBankDetails = 0;

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            if (answer == "YES")
            {
                int maxRow = list.Count;
                int batchID;
                int detailID;
                bool selection;

                selectedParties = 0;
                for (int i = 0; i <= maxRow - 1; i++)
                {
                    var dataLine = list[i];
                    selection = Convert.ToBoolean(dataLine.Selected);
                    if (selection == true)
                    {
                        selectedParties = selectedParties + 1;
                        batchID = Convert.ToInt32(dataLine.BatchID);
                        detailID = Convert.ToInt32(dataLine.DetailID);
                        partyCode = Convert.ToString(dataLine.PartyCode);
                        haveBankAccountDetails = pb.CheckHaveBankAccountDetails(partyCode);
                        if (haveBankAccountDetails == 0)
                        {
                            partyCode = Convert.ToString(dataLine.PartyCode);
                            warningMessage = "Party :" + Convert.ToString(partyCode) + "  Is not Having Any Beneficiary Bank Details";
                            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                            MessageBoxAdv.Show(this, warningMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            failedDueToNoBankDetails = 1;
                        }
                        if (failedDueToNoBankDetails==1)
                        {
                            return;
                        }
                        sucessRTGSWallet = pb.UpdateRTGSWallet(RTGSID,  detailID);
                    }
                }

                if (selectedParties ==0 )
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show(this, "No Parties Selected ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(this, "Success !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void rtgsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
