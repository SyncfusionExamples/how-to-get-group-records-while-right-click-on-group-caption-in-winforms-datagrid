﻿using Syncfusion.WinForms.DataGrid;

namespace SfDataGridDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.txtDisplayRecords = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfDataGrid.Location = new System.Drawing.Point(12, 12);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.RowHeight = 21;
            this.sfDataGrid.Size = new System.Drawing.Size(760, 273);
            this.sfDataGrid.TabIndex = 1;
            // 
            // txtDisplayRecords
            // 
            this.txtDisplayRecords.Location = new System.Drawing.Point(166, 303);
            this.txtDisplayRecords.Multiline = true;
            this.txtDisplayRecords.Name = "txtDisplayRecords";
            this.txtDisplayRecords.Size = new System.Drawing.Size(403, 105);
            this.txtDisplayRecords.TabIndex = 2;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 445);
            this.Controls.Add(this.txtDisplayRecords);
            this.Controls.Add(this.sfDataGrid);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SfDataGridDemo";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region API Definition

        private SfDataGrid sfDataGrid;
        #endregion

        private System.Windows.Forms.TextBox txtDisplayRecords;
    }
}

