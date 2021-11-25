using System.Globalization;

using System.Windows.Forms;
 
namespace PaymentBatchCapacite
{
    partial class frmBatchAwaitingApproval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
       
        private void InitializeComponent()
        {
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBatchAwaitingApproval));
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.batchGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnPrint = new Syncfusion.WinForms.Controls.SfButton();
            this.DataPager = new Syncfusion.WinForms.DataPager.SfDataPager();
            this.txtMonths = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.batchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // batchGrid
            // 
            this.batchGrid.AccessibleName = "Table";
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "BatchID";
            gridTextColumn1.MappingName = "BatchID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Process";
            gridTextColumn2.MappingName = "BatchProcess";
            gridTextColumn2.Width = 100D;
            gridButtonColumn1.AllowDefaultButtonText = false;
            gridButtonColumn1.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.DefaultButtonText = "";
            gridButtonColumn1.HeaderText = "#";
            gridButtonColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridButtonColumn1.Image")));
            gridButtonColumn1.ImageSize = new System.Drawing.Size(16, 16);
            gridButtonColumn1.MappingName = "BatchNo";
            gridButtonColumn1.Width = 60D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowSorting = false;
            gridTextColumn3.HeaderText = "Notes";
            gridTextColumn3.MappingName = "Narration";
            gridTextColumn3.Width = 95D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Project";
            gridTextColumn4.MappingName = "BSBorgName";
            gridTextColumn4.Width = 150D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.HeaderText = "Party";
            gridTextColumn5.MappingName = "PartyCode";
            gridTextColumn5.Width = 90D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Party Name";
            gridTextColumn6.MappingName = "PartyName";
            gridTextColumn6.Width = 200D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            gridNumericColumn1.HeaderText = "Batch Amount";
            gridNumericColumn1.MappingName = "BatchOutstanding";
            gridNumericColumn1.Width = 140D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.AllowGrouping = false;
            gridNumericColumn2.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            gridNumericColumn2.HeaderText = "CIL Outstanding";
            gridNumericColumn2.MappingName = "CILOutstanding";
            gridNumericColumn2.Width = 130D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.AllowGrouping = false;
            gridNumericColumn3.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            gridNumericColumn3.HeaderText = "Project Outstanding";
            gridNumericColumn3.MappingName = "ProjectOutstanding";
            gridNumericColumn3.Width = 120D;
            gridNumericColumn4.AllowEditing = false;
            gridNumericColumn4.AllowFiltering = true;
            gridNumericColumn4.AllowGrouping = false;
            gridNumericColumn4.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            gridNumericColumn4.HeaderText = "GST Outstanding";
            gridNumericColumn4.MappingName = "GSTOutstanding";
            gridNumericColumn4.Width = 120D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Owner";
            gridTextColumn7.MappingName = "BatchOwner";
            gridTextColumn7.Width = 100D;
            gridCheckBoxColumn1.AllowCheckBoxOnHeader = true;
            gridCheckBoxColumn1.HeaderText = "Select";
            gridCheckBoxColumn1.MappingName = "Selected";
            gridCheckBoxColumn1.Width = 80D;
            gridTextColumn8.HeaderText = "DetailID";
            gridTextColumn8.MappingName = "DetailID";
            gridTextColumn8.Visible = false;
            gridTextColumn8.Width = 0D;
            this.batchGrid.Columns.Add(gridTextColumn1);
            this.batchGrid.Columns.Add(gridTextColumn2);
            this.batchGrid.Columns.Add(gridButtonColumn1);
            this.batchGrid.Columns.Add(gridTextColumn3);
            this.batchGrid.Columns.Add(gridTextColumn4);
            this.batchGrid.Columns.Add(gridTextColumn5);
            this.batchGrid.Columns.Add(gridTextColumn6);
            this.batchGrid.Columns.Add(gridNumericColumn1);
            this.batchGrid.Columns.Add(gridNumericColumn2);
            this.batchGrid.Columns.Add(gridNumericColumn3);
            this.batchGrid.Columns.Add(gridNumericColumn4);
            this.batchGrid.Columns.Add(gridTextColumn7);
            this.batchGrid.Columns.Add(gridCheckBoxColumn1);
            this.batchGrid.Columns.Add(gridTextColumn8);
            this.batchGrid.Location = new System.Drawing.Point(13, 47);
            this.batchGrid.Name = "batchGrid";
            this.batchGrid.PreviewRowHeight = 35;
            this.batchGrid.ShowBusyIndicator = true;
            this.batchGrid.ShowGroupDropArea = true;
            this.batchGrid.ShowRowHeader = true;
            this.batchGrid.Size = new System.Drawing.Size(1447, 546);
            this.batchGrid.Style.HeaderStyle.Font.Bold = true;
            this.batchGrid.Style.HeaderStyle.TextColor = System.Drawing.Color.Blue;
            this.batchGrid.Style.TableSummaryRowStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.batchGrid.Style.TableSummaryRowStyle.Font.Facename = "Segoe UI";
            this.batchGrid.Style.TableSummaryRowStyle.Font.Size = 8.5F;
            this.batchGrid.Style.TableSummaryRowStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.batchGrid.Style.TableSummaryRowStyle.TextColor = System.Drawing.Color.Red;
            this.batchGrid.TabIndex = 0;
            this.batchGrid.Text = "sfDataGrid1";
            this.batchGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.batchGrid_AutoGeneratingColumn);
            this.batchGrid.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.batchGrid_DrawCell);
            this.batchGrid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.batchGrid_QueryRowStyle);
            this.batchGrid.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.batchGrid_CellButtonClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Location = new System.Drawing.Point(1217, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 28);
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(1318, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.Style.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(13, 13);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(317, 20);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "Batches Waiting For Submission";
            this.autoLabel1.ThemeStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleName = "Button";
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.FocusRectangleVisible = true;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.Location = new System.Drawing.Point(1115, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 28);
            this.btnPrint.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.Style.FocusedForeColor = System.Drawing.Color.DarkRed;
            this.btnPrint.Style.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Excel";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DataPager
            // 
            this.DataPager.AccessibleName = "DataPager";
            this.DataPager.CanOverrideStyle = true;
            this.DataPager.DisplayMode = ((Syncfusion.WinForms.DataPager.Enums.PageDisplayMode)((((Syncfusion.WinForms.DataPager.Enums.PageDisplayMode.First | Syncfusion.WinForms.DataPager.Enums.PageDisplayMode.Last) 
            | Syncfusion.WinForms.DataPager.Enums.PageDisplayMode.Previous) 
            | Syncfusion.WinForms.DataPager.Enums.PageDisplayMode.Next)));
            this.DataPager.Location = new System.Drawing.Point(460, 596);
            this.DataPager.Name = "DataPager";
            this.DataPager.ShowNavigationTextBox = true;
            this.DataPager.Size = new System.Drawing.Size(356, 28);
            this.DataPager.TabIndex = 5;
            this.DataPager.Text = "sfDataPager1";
            // 
            // txtMonths
            // 
            this.txtMonths.BeforeTouchSize = new System.Drawing.Size(45, 28);
            this.txtMonths.IntegerValue = ((long)(15));
            this.txtMonths.Location = new System.Drawing.Point(831, 596);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(45, 28);
            this.txtMonths.TabIndex = 6;
            this.txtMonths.Text = "15";
            this.txtMonths.TextChanged += new System.EventHandler(this.txtMonths_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(882, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Page size";
            // 
            // frmBatchAwaitingApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.DataPager);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.batchGrid);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchAwaitingApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Payment Batch | Awaiting Approval";
            this.Load += new System.EventHandler(this.frmBatchAwaitingApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid batchGrid;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnPrint;
        private Syncfusion.WinForms.DataPager.SfDataPager DataPager;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtMonths;
        private Label label1;
    }
}