namespace PaymentBatchCapacite
{
    partial class frmOutstandingBreakUp
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
        private void InitializeComponent()
        {
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.tabOutstanding = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabProject = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridProjectOutstanding = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabCIL = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridCIL = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtPartyName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPartyCategory = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtProjectName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOutstanding)).BeginInit();
            this.tabOutstanding.SuspendLayout();
            this.tabProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectOutstanding)).BeginInit();
            this.tabCIL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(419, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(298, 29);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Outstanding Breakup";
            // 
            // tabOutstanding
            // 
            this.tabOutstanding.ActiveTabColor = System.Drawing.Color.Fuchsia;
            this.tabOutstanding.BeforeTouchSize = new System.Drawing.Size(1059, 515);
            this.tabOutstanding.Controls.Add(this.tabProject);
            this.tabOutstanding.Controls.Add(this.tabCIL);
            this.tabOutstanding.Location = new System.Drawing.Point(30, 121);
            this.tabOutstanding.Name = "tabOutstanding";
            this.tabOutstanding.Size = new System.Drawing.Size(1059, 515);
            this.tabOutstanding.TabIndex = 1;
            this.tabOutstanding.SelectedIndexChanged += new System.EventHandler(this.tabOutstanding_SelectedIndexChanged);
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.gridProjectOutstanding);
            this.tabProject.Image = null;
            this.tabProject.ImageSize = new System.Drawing.Size(20, 20);
            this.tabProject.Location = new System.Drawing.Point(1, 33);
            this.tabProject.Name = "tabProject";
            this.tabProject.ShowCloseButton = true;
            this.tabProject.Size = new System.Drawing.Size(1056, 481);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Project Outstanding";
            this.tabProject.ThemesEnabled = false;
            // 
            // gridProjectOutstanding
            // 
            this.gridProjectOutstanding.AccessibleName = "Table";
            this.gridProjectOutstanding.AllowEditing = false;
            this.gridProjectOutstanding.AllowFiltering = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Trans Group";
            gridTextColumn1.MappingName = "TRANGRP";
            gridTextColumn1.Width = 100D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Trans ID";
            gridTextColumn2.MappingName = "TRANSID";
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Trans. Date";
            gridDateTimeColumn1.MappingName = "PDATE";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 100D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Invoice #";
            gridTextColumn3.MappingName = "TRANSREFEXT";
            gridTextColumn3.Width = 120D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Trans Type";
            gridTextColumn4.MappingName = "TRANSTYPE";
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.HeaderText = "Bill Amount";
            gridNumericColumn1.MappingName = "CREDIT";
            gridNumericColumn1.Width = 120D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.HeaderText = "Paid To Date";
            gridNumericColumn2.MappingName = "PAIDTODATE";
            gridNumericColumn2.Width = 120D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.HeaderText = "Batch Amount";
            gridNumericColumn3.MappingName = "PAIDTHISPERIOD";
            gridNumericColumn3.Width = 140D;
            this.gridProjectOutstanding.Columns.Add(gridTextColumn1);
            this.gridProjectOutstanding.Columns.Add(gridTextColumn2);
            this.gridProjectOutstanding.Columns.Add(gridDateTimeColumn1);
            this.gridProjectOutstanding.Columns.Add(gridTextColumn3);
            this.gridProjectOutstanding.Columns.Add(gridTextColumn4);
            this.gridProjectOutstanding.Columns.Add(gridNumericColumn1);
            this.gridProjectOutstanding.Columns.Add(gridNumericColumn2);
            this.gridProjectOutstanding.Columns.Add(gridNumericColumn3);
            this.gridProjectOutstanding.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridProjectOutstanding.Location = new System.Drawing.Point(26, 17);
            this.gridProjectOutstanding.Name = "gridProjectOutstanding";
            this.gridProjectOutstanding.PreviewRowHeight = 35;
            this.gridProjectOutstanding.Size = new System.Drawing.Size(997, 450);
            this.gridProjectOutstanding.Style.RowHeaderStyle.Font.Bold = true;
            this.gridProjectOutstanding.Style.RowHeaderStyle.Font.Facename = "Arial";
            this.gridProjectOutstanding.Style.RowHeaderStyle.TextColor = System.Drawing.Color.Blue;
            this.gridProjectOutstanding.TabIndex = 0;
            this.gridProjectOutstanding.Text = "sfDataGrid1";
            this.gridProjectOutstanding.QueryCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventHandler(this.gridProjectOutstanding_QueryCellStyle);
            // 
            // tabCIL
            // 
            this.tabCIL.Controls.Add(this.gridCIL);
            this.tabCIL.Image = null;
            this.tabCIL.ImageSize = new System.Drawing.Size(20, 20);
            this.tabCIL.Location = new System.Drawing.Point(1, 33);
            this.tabCIL.Name = "tabCIL";
            this.tabCIL.ShowCloseButton = true;
            this.tabCIL.Size = new System.Drawing.Size(1056, 481);
            this.tabCIL.TabIndex = 2;
            this.tabCIL.Text = "CIL Outstanding";
            this.tabCIL.ThemesEnabled = false;
            // 
            // gridCIL
            // 
            this.gridCIL.AccessibleName = "Table";
            gridTextColumn5.HeaderText = "Org ID";
            gridTextColumn5.MappingName = "ORGID";
            gridTextColumn5.Width = 120D;
            gridTextColumn6.HeaderText = "Project Name";
            gridTextColumn6.MappingName = "PROJECTNAME";
            gridTextColumn6.Width = 400D;
            gridNumericColumn4.HeaderText = "Outstanding Amount";
            gridNumericColumn4.MappingName = "OUTSTANDING";
            gridNumericColumn4.Width = 200D;
            this.gridCIL.Columns.Add(gridTextColumn5);
            this.gridCIL.Columns.Add(gridTextColumn6);
            this.gridCIL.Columns.Add(gridNumericColumn4);
            this.gridCIL.Location = new System.Drawing.Point(149, 47);
            this.gridCIL.Name = "gridCIL";
            this.gridCIL.PreviewRowHeight = 35;
            this.gridCIL.Size = new System.Drawing.Size(813, 405);
            this.gridCIL.TabIndex = 0;
            this.gridCIL.Text = "sfDataGrid1";
            this.gridCIL.QueryCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventHandler(this.gridCIL_QueryCellStyle);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(31, 49);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(66, 20);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Party:";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(611, 49);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(74, 20);
            this.autoLabel3.TabIndex = 3;
            this.autoLabel3.Text = "Projet:";
            // 
            // txtPartyName
            // 
            this.txtPartyName.BeforeTouchSize = new System.Drawing.Size(45, 28);
            this.txtPartyName.Location = new System.Drawing.Point(104, 46);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(488, 28);
            this.txtPartyName.TabIndex = 4;
            this.txtPartyName.Text = "PartyName";
            // 
            // txtPartyCategory
            // 
            this.txtPartyCategory.BeforeTouchSize = new System.Drawing.Size(45, 28);
            this.txtPartyCategory.Location = new System.Drawing.Point(104, 76);
            this.txtPartyCategory.Name = "txtPartyCategory";
            this.txtPartyCategory.Size = new System.Drawing.Size(488, 28);
            this.txtPartyCategory.TabIndex = 5;
            this.txtPartyCategory.Text = "PartyName";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BeforeTouchSize = new System.Drawing.Size(45, 28);
            this.txtProjectName.Location = new System.Drawing.Point(691, 46);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(399, 28);
            this.txtProjectName.TabIndex = 6;
            this.txtProjectName.Text = "PartyName";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(991, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmOutstandingBreakUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 648);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtPartyCategory);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.tabOutstanding);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOutstandingBreakUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outstanding | BreakUp";
            this.Load += new System.EventHandler(this.frmOutstandingBreakUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabOutstanding)).EndInit();
            this.tabOutstanding.ResumeLayout(false);
            this.tabProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectOutstanding)).EndInit();
            this.tabCIL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabOutstanding;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabProject;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabCIL;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridProjectOutstanding;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPartyName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPartyCategory;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProjectName;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridCIL;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}