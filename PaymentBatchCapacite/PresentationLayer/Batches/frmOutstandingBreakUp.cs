using Syncfusion.DocIO;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Data;

using Syncfusion.WinForms.Controls;
using System.Globalization;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.DataGrid.Enums;
 
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.DataGridConverter;
using System.IO;
 
using Syncfusion.Windows.Forms;
 

namespace PaymentBatchCapacite
{
    public partial class frmOutstandingBreakUp : Form
    {
        int batchCode;
        string  batchNo;
        string who;
        string batchType;
        PayBatchClass pb = new PayBatchClass();

        public frmOutstandingBreakUp(int batchID,string batchNumber,string batchProcess, string partyCode)
        {
            InitializeComponent();
            batchCode = batchID;
            batchNo = batchNumber;
            who = partyCode;
            batchType = batchProcess;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabOutstanding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmOutstandingBreakUp_Load(object sender, EventArgs e)
        {
           
            this.tabOutstanding.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            txtProjectName.Text = Convert.ToString(pb.GetProjectOfBatch(batchCode));
            if (batchType=="CREDITORS")
            {
                txtPartyCategory.Text = "Supplier";
                txtPartyName.Text = Convert.ToString(pb.GetSupplier(who));
            }
            else
            {
                txtPartyCategory.Text = "Sub Contractor";
                txtPartyName.Text = Convert.ToString(pb.GetSubContractor(who));
            }
            DataSet projectOustanding = pb.GetProjectOutstanding(batchCode, batchNo, who);
            this.gridProjectOutstanding.ThemeName = "Office2016Black";

            gridProjectOutstanding.DataSource = projectOustanding.Tables[0];

            gridProjectOutstanding.Columns[5].Format = "c";
            gridProjectOutstanding.Columns[6].Format = "c";
            gridProjectOutstanding.Columns[7].Format = "c";


            DataSet cilOutstanding = pb.GetCILOutstanding(who, txtPartyCategory.Text);
            this.gridCIL.ShowBusyIndicator = true;
            gridCIL.DataSource = cilOutstanding.Tables[0];
            gridCIL.Columns[2].Format = "c";
            this.gridCIL.ThemeName = "Office2016DarkGray";


            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "TotalOutstanding";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "{Sum:c}";
            summaryColumn1.MappingName = "OUTSTANDING";

            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);
            this.gridCIL.TableSummaryRows.Add(tableSummaryRow1);

            GridTableSummaryRow tableSummaryRow2 = new GridTableSummaryRow();
            tableSummaryRow2.Name = "TableSummary";
            tableSummaryRow2.ShowSummaryInRow = false;

            GridSummaryColumn summaryColumn2 = new GridSummaryColumn();
            summaryColumn2.Name = "BatchTotal";
            summaryColumn2.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn2.Format = "{Sum:c}";
            summaryColumn2.MappingName = "PAIDTHISPERIOD";
            tableSummaryRow2.SummaryColumns.Add(summaryColumn2);
            this.gridProjectOutstanding.TableSummaryRows.Add(tableSummaryRow2);

        }

        private void gridProjectOutstanding_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
           
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.PaleTurquoise;
                else
                    e.Style.BackColor = Color.Snow;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridCIL_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.Beige;
            else
                e.Style.BackColor = Color.GreenYellow;

        }
    }
}
