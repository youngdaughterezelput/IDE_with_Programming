﻿namespace WallE_Visual.WorldViewer
{
    partial class HelpViewProc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpViewProc));
            this.rtboxHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtboxHelp
            // 
            this.rtboxHelp.AcceptsTab = true;
            this.rtboxHelp.BackColor = System.Drawing.SystemColors.GrayText;
            this.rtboxHelp.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtboxHelp.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtboxHelp.Location = new System.Drawing.Point(12, 13);
            this.rtboxHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtboxHelp.Name = "rtboxHelp";
            this.rtboxHelp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtboxHelp.ShortcutsEnabled = false;
            this.rtboxHelp.ShowSelectionMargin = true;
            this.rtboxHelp.Size = new System.Drawing.Size(316, 405);
            this.rtboxHelp.TabIndex = 0;
            this.rtboxHelp.Text = resources.GetString("rtboxHelp.Text");
            // 
            // HelpViewRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(330, 424);
            this.Controls.Add(this.rtboxHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HelpViewRoutine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "~Помощь.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtboxHelp;
    }
}