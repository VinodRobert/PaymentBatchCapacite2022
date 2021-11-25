using System.Globalization;

using System.Windows.Forms;
 
namespace PaymentBatchCapacite
{
    partial class frmTackMyBatch
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            this.batchGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnPrint = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.batchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // batchGrid
            // 
            this.batchGrid.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Initiator ";
            gridTextColumn1.MappingName = "InitiatorName";
            gridTextColumn1.Width = 100D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Process";
            gridTextColumn2.MappingName = "BatchProcess";
            gridTextColumn2.Width = 125D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowSorting = false;
            gridTextColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn3.HeaderText = "#";
            gridTextColumn3.MappingName = "BatchNo";
            gridTextColumn3.Width = 40D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.AllowGrouping = false;
            gridTextColumn4.AllowSorting = false;
            gridTextColumn4.HeaderText = "Notes";
            gridTextColumn4.MappingName = "Narration";
            gridTextColumn4.Width = 85D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Project";
            gridTextColumn5.MappingName = "BSBorgName";
            gridTextColumn5.Width = 205D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.AllowGrouping = false;
            gridTextColumn6.HeaderText = "Party";
            gridTextColumn6.MappingName = "PartyCode";
            gridTextColumn6.Width = 120D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Party Name";
            gridTextColumn7.MappingName = "PartyName";
            gridTextColumn7.Width = 300D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.HeaderText = "Amount";
            gridNumericColumn1.MappingName = "BatchOutstanding";
            gridNumericColumn1.Width = 120D;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "Current Custodian";
            gridTextColumn8.MappingName = "CurrentOwnerName";
            gridTextColumn8.Width = 200D;
            gridTextColumn9.HeaderText = "Submitted By";
            gridTextColumn9.MappingName = "SubmittedBy";
            gridTextColumn9.Width = 150D;
            gridDateTimeColumn1.HeaderText = "Time Stamp";
            gridDateTimeColumn1.MappingName = "LandedTime";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.FullDateTime;
            gridDateTimeColumn1.Width = 135D;
            this.batchGrid.Columns.Add(gridTextColumn1);
            this.batchGrid.Columns.Add(gridTextColumn2);
            this.batchGrid.Columns.Add(gridTextColumn3);
            this.batchGrid.Columns.Add(gridTextColumn4);
            this.batchGrid.Columns.Add(gridTextColumn5);
            this.batchGrid.Columns.Add(gridTextColumn6);
            this.batchGrid.Columns.Add(gridTextColumn7);
            this.batchGrid.Columns.Add(gridNumericColumn1);
            this.batchGrid.Columns.Add(gridTextColumn8);
            this.batchGrid.Columns.Add(gridTextColumn9);
            this.batchGrid.Columns.Add(gridDateTimeColumn1);
            this.batchGrid.Location = new System.Drawing.Point(13, 46);
            this.batchGrid.Name = "batchGrid";
            this.batchGrid.PreviewRowHeight = 35;
            this.batchGrid.ShowBusyIndicator = true;
            this.batchGrid.ShowGroupDropArea = true;
            this.batchGrid.ShowRowHeader = true;
            this.batchGrid.Size = new System.Drawing.Size(1459, 582);
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
            // frmTackMyBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 629);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.batchGrid);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTackMyBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Payment Batch | Track My Open Batches";
            this.Load += new System.EventHandler(this.frmBatchAwaitingApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid batchGrid;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnPrint;
    }
}