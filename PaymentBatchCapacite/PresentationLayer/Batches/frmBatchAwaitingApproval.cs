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
    public partial class frmBatchAwaitingApproval : Form
    {
        PayBatchClass pb = new PayBatchClass();
        string batchOwner;
        string batchStatus;
        DataSet dsOpenBatches;
        List<PaymentBatch> list;
        List<PaymentBatch> PaymentBatchList;
        PaymentBatch myBatch;
        bool noBatchForSubmission;    

        public frmBatchAwaitingApproval()
        {
            InitializeComponent();
            this.Location = new Point(20, 90);
        }

        List<PaymentBatch> GetOpenBatches()
        {
      
            PaymentBatchList = new List<PaymentBatch>();
            int batchID;
            string processName;
            string batchNo;
            string narration;
            string bsBorgName;
            string partyCode;
            string partyName;
            decimal batchOutstanding;
            decimal cilOutstanding;
            decimal projectOutstanding;
            decimal gstOustanding;
            string batchOwer;
            bool selected;
            int detailID;
            for (int i = 0; i <= dsOpenBatches.Tables[0].Rows.Count - 1; i++)
            {
                batchID = Convert.ToInt16(dsOpenBatches.Tables[0].Rows[i][0]);
                detailID = Convert.ToInt16(dsOpenBatches.Tables[0].Rows[i][1]);  
                processName = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][2]);
                batchNo = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][3]);
                narration = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][4]);
                bsBorgName = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][5]);
                partyCode = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][6]);
                partyName = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][7]);
                batchOutstanding = Convert.ToDecimal(dsOpenBatches.Tables[0].Rows[i][8]);
                cilOutstanding = Convert.ToDecimal(dsOpenBatches.Tables[0].Rows[i][9]);
                projectOutstanding = Convert.ToDecimal(dsOpenBatches.Tables[0].Rows[i][10]);
                gstOustanding = Convert.ToDecimal(dsOpenBatches.Tables[0].Rows[i][11]);
                batchOwer = Convert.ToString(dsOpenBatches.Tables[0].Rows[i][12]);
                selected = Convert.ToBoolean(dsOpenBatches.Tables[0].Rows[i][13]);
                
                PaymentBatchList.Add(new PaymentBatch(selected,batchID,detailID,processName,batchNo,narration,bsBorgName,partyCode,partyName,batchOutstanding,cilOutstanding,projectOutstanding,gstOustanding,batchOwer));
            }
            return PaymentBatchList;
        }


        private void frmBatchAwaitingApproval_Load(object sender, EventArgs e)
        {
            batchOwner = Convert.ToString(GlobalVariables.UserID);

            
            batchStatus = "O";
            

            dsOpenBatches = pb.GetBatches(batchOwner, batchStatus);
            int maxRows = dsOpenBatches.Tables[0].Rows.Count;
            if (maxRows == 0)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(this, "No Batches For Submission  !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LoadGrid();
            }
        }


        private void LoadGrid()
        {
            
            list = GetOpenBatches();
       
            var data = list;
             
            batchGrid.Columns[7].Format = "c";
            batchGrid.Columns[8].Format = "c";
            batchGrid.Columns[9].Format = "c";
            batchGrid.Columns[10].Format = "c";
            this.batchGrid.ThemeName = "Office2019Colorful";

            this.DataPager.Style.PageButtonStyle.BackColor = Color.LightSeaGreen;
         //   this.DataPager.Style.PageButtonStyle.FocusedBackColor = Color.Silver;
            DataPager.DataSource = list;
            DataPager.PageSize =15;
            batchGrid.DataSource = DataPager.PagedSource;
            batchGrid.Refresh();

            batchGrid.FrozenColumnCount = 13;

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
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = false;
            int maxRow = list.Count;
            int batchID;
            int detailID;
            string partyCode;
            bool selection;
            int success;
            int unlock;


            if (GlobalVariables.UserRole == 1)
            {
                for (int ii = 0; ii <= maxRow - 1; ii++)
                {
                    var singleLine = list[ii];
                    selection = Convert.ToBoolean(singleLine.Selected);
                    if (selection == false)
                    {
                        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                        MessageBoxAdv.Show(this, "You Have To Tick All. Unticked Items Must be Removed Before Submitting ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        btnCancel.Enabled = true;
                        btnPrint.Enabled = true;
                        btnSubmit.Enabled = true;
                        return;
                    }
                }
            }


            for (int i = 0; i <= maxRow - 1; i++)
            {
                var dataLine = list[i];
                selection = Convert.ToBoolean(dataLine.Selected);
                if (selection == true)
                {
                    batchID = Convert.ToInt32(dataLine.BatchID);
                    detailID = Convert.ToInt32(dataLine.DetailID);
                    partyCode = Convert.ToString(dataLine.PartyCode);
                    success = pb.ChangeBatchStatus(batchID, detailID,partyCode);
                }
                else
                {
                    batchID = Convert.ToInt32(dataLine.BatchID);
                    unlock = pb.UnlockBatch(batchID);
                }
            }

          
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show(this, "Success !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
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

        private void batchGrid_CellButtonClick(object sender, CellButtonClickEventArgs e)
        {
           


            var selectedItem = batchGrid.SelectedItems[0];
            var batchID = (selectedItem as PaymentBatch).BatchID;
            var partyCode = (selectedItem as PaymentBatch).PartyCode;
            var batchNumber = (selectedItem as PaymentBatch).BatchNo;
            var batchType = (selectedItem as PaymentBatch).BatchProcess;
            frmOutstandingBreakUp outstandingBreakUp = new frmOutstandingBreakUp(batchID,batchNumber,batchType,partyCode);
            outstandingBreakUp.Show();
        }
    }
}
