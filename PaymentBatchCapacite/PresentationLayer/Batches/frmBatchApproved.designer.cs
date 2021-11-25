using System.Globalization;

using System.Windows.Forms;
 
namespace PaymentBatchCapacite
{
    partial class frmBatchApproved
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            this.batchGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnPrint = new Syncfusion.WinForms.Controls.SfButton();
            this.DataPager = new Syncfusion.WinForms.DataPager.SfDataPager();
            this.txtMonths = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.cmbPaymentMode = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbProjects = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbBanks = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblGridHeader = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.batchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanks)).BeginInit();
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
            gridTextColumn2.HeaderText = "DetailID";
            gridTextColumn2.MappingName = "DetailID";
            gridTextColumn2.Visible = false;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Process";
            gridTextColumn3.MappingName = "BatchProcess";
            gridTextColumn3.Width = 150D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowGrouping = false;
            gridTextColumn4.AllowSorting = false;
            gridTextColumn4.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn4.HeaderText = "#";
            gridTextColumn4.MappingName = "BatchNo";
            gridTextColumn4.Width = 48D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.AllowSorting = false;
            gridTextColumn5.HeaderText = "Notes";
            gridTextColumn5.MappingName = "Narration";
            gridTextColumn5.Width = 100D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Project";
            gridTextColumn6.MappingName = "BSBorgName";
            gridTextColumn6.Width = 250D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.AllowGrouping = false;
            gridTextColumn7.HeaderText = "Party";
            gridTextColumn7.MappingName = "PartyCode";
            gridTextColumn7.Width = 120D;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "Party Name";
            gridTextColumn8.MappingName = "PartyName";
            gridTextColumn8.Width = 300D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            gridNumericColumn1.HeaderText = "Approved Amount";
            gridNumericColumn1.MappingName = "BatchOutstanding";
            gridNumericColumn1.Width = 140D;
            gridCheckBoxColumn1.AllowCheckBoxOnHeader = true;
            gridCheckBoxColumn1.HeaderText = "Selected";
            gridCheckBoxColumn1.MappingName = "Selected";
            this.batchGrid.Columns.Add(gridTextColumn1);
            this.batchGrid.Columns.Add(gridTextColumn2);
            this.batchGrid.Columns.Add(gridTextColumn3);
            this.batchGrid.Columns.Add(gridTextColumn4);
            this.batchGrid.Columns.Add(gridTextColumn5);
            this.batchGrid.Columns.Add(gridTextColumn6);
            this.batchGrid.Columns.Add(gridTextColumn7);
            this.batchGrid.Columns.Add(gridTextColumn8);
            this.batchGrid.Columns.Add(gridNumericColumn1);
            this.batchGrid.Columns.Add(gridCheckBoxColumn1);
            this.batchGrid.Location = new System.Drawing.Point(13, 79);
            this.batchGrid.Name = "batchGrid";
            this.batchGrid.PreviewRowHeight = 35;
            this.batchGrid.ShowBusyIndicator = true;
            this.batchGrid.ShowGroupDropArea = true;
            this.batchGrid.ShowRowHeader = true;
            this.batchGrid.Size = new System.Drawing.Size(1447, 514);
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
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Location = new System.Drawing.Point(1151, 13);
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
            this.btnCancel.Location = new System.Drawing.Point(1361, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.Style.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleName = "Button";
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.FocusRectangleVisible = true;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.Location = new System.Drawing.Point(1256, 12);
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
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(882, 607);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(73, 17);
            this.lblPage.TabIndex = 7;
            this.lblPage.Text = "Page size";
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbPaymentMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentMode.ForeColor = System.Drawing.Color.Firebrick;
            this.cmbPaymentMode.Location = new System.Drawing.Point(945, 13);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(191, 32);
            this.cmbPaymentMode.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentMode.Style.EditorStyle.ForeColor = System.Drawing.Color.Firebrick;
            this.cmbPaymentMode.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentMode.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPaymentMode.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentMode.TabIndex = 8;
            this.cmbPaymentMode.Text = "Select Payment Mode";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DisplayMember = "ProjectName";
            this.cmbProjects.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbProjects.ForeColor = System.Drawing.Color.Red;
            this.cmbProjects.Location = new System.Drawing.Point(13, 13);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(480, 32);
            this.cmbProjects.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbProjects.Style.EditorStyle.ForeColor = System.Drawing.Color.Red;
            this.cmbProjects.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbProjects.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProjects.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbProjects.TabIndex = 9;
            this.cmbProjects.Text = "Select Project";
            this.cmbProjects.ValueMember = "ProjectID";
            this.cmbProjects.SelectedValueChanged += new System.EventHandler(this.cmbProjects_SelectedValueChanged);
            // 
            // cmbBanks
            // 
            this.cmbBanks.DisplayMember = "BankName";
            this.cmbBanks.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbBanks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbBanks.ForeColor = System.Drawing.Color.Olive;
            this.cmbBanks.Location = new System.Drawing.Point(499, 13);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(440, 32);
            this.cmbBanks.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbBanks.Style.EditorStyle.ForeColor = System.Drawing.Color.Olive;
            this.cmbBanks.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbBanks.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBanks.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbBanks.TabIndex = 10;
            this.cmbBanks.Text = "Select Bank";
            this.cmbBanks.ValueMember = "BankID";
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblGridHeader.Location = new System.Drawing.Point(13, 52);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(536, 20);
            this.lblGridHeader.TabIndex = 11;
            this.lblGridHeader.Text = "List of Approved Batches - Select Bank & Payment Mode ";
            // 
            // frmBatchApproved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 629);
            this.Controls.Add(this.lblGridHeader);
            this.Controls.Add(this.cmbBanks);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.cmbPaymentMode);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.DataPager);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.batchGrid);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchApproved";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Payment Batch | Approved Batch";
            this.Load += new System.EventHandler(this.frmBatchAwaitingApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid batchGrid;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnPrint;
        private Syncfusion.WinForms.DataPager.SfDataPager DataPager;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtMonths;
        private Label lblPage;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPaymentMode;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProjects;
        private Syncfusion.WinForms.ListView.SfComboBox cmbBanks;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblGridHeader;
    }
}