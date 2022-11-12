﻿namespace WallE_Visual.MainApp
{
    partial class AddWorldForm
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorldForm));
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nUpColumns = new System.Windows.Forms.NumericUpDown();
            this.nUpRows = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpRows)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(81, 101);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(83, 29);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRows.Location = new System.Drawing.Point(41, 25);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(37, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Ряды:";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColumns.Location = new System.Drawing.Point(23, 56);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(55, 13);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Столбцы:";
            // 
            // nUpColumns
            // 
            this.nUpColumns.BackColor = System.Drawing.SystemColors.GrayText;
            this.nUpColumns.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpColumns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nUpColumns.Location = new System.Drawing.Point(106, 53);
            this.nUpColumns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nUpColumns.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUpColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpColumns.Name = "nUpColumns";
            this.nUpColumns.Size = new System.Drawing.Size(48, 20);
            this.nUpColumns.TabIndex = 3;
            this.nUpColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpColumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpColumns.ValueChanged += new System.EventHandler(this.nUpColumns_ValueChanged);
            // 
            // nUpRows
            // 
            this.nUpRows.BackColor = System.Drawing.SystemColors.GrayText;
            this.nUpRows.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nUpRows.Location = new System.Drawing.Point(106, 23);
            this.nUpRows.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nUpRows.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUpRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpRows.Name = "nUpRows";
            this.nUpRows.Size = new System.Drawing.Size(48, 20);
            this.nUpRows.TabIndex = 2;
            this.nUpRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpRows.ValueChanged += new System.EventHandler(this.nUpRows_ValueChanged);
            // 
            // AddWorldForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(241, 156);
            this.Controls.Add(this.nUpRows);
            this.Controls.Add(this.nUpColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.btnAccept);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddWorldForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый мир";
            ((System.ComponentModel.ISupportInitialize)(this.nUpColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nUpColumns;
        private System.Windows.Forms.NumericUpDown nUpRows;
    }
}