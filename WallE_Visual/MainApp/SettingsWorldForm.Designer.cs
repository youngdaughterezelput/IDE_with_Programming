namespace WallE_Visual
{
    partial class SettingsWorldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWorldForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripAddWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripRestartWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWorldConfig = new System.Windows.Forms.Panel();
            this.wViewConfig = new WallE_Visual.WorldViewer.WorldViewer();
            this.tbarZoom = new System.Windows.Forms.TrackBar();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblMinZoom = new System.Windows.Forms.Label();
            this.lblMaxZoom = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlWorldConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ссToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1030, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ссToolStripMenuItem
            // 
            this.ссToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripAddWorld,
            this.menuToolStripRestartWorld,
            this.toolStripSeparator1,
            this.simularToolStripMenuItem});
            this.ссToolStripMenuItem.Name = "ссToolStripMenuItem";
            this.ссToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.ссToolStripMenuItem.Text = "Настроить";
            this.ссToolStripMenuItem.ToolTipText = "Варианты настройки мира";
            // 
            // menuToolStripAddWorld
            // 
            this.menuToolStripAddWorld.Name = "menuToolStripAddWorld";
            this.menuToolStripAddWorld.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuToolStripAddWorld.Size = new System.Drawing.Size(353, 34);
            this.menuToolStripAddWorld.Text = "&Создать новую карту";
            this.menuToolStripAddWorld.Click += new System.EventHandler(this.menuToolStripAddWorld_Click);
            // 
            // menuToolStripRestartWorld
            // 
            this.menuToolStripRestartWorld.Name = "menuToolStripRestartWorld";
            this.menuToolStripRestartWorld.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuToolStripRestartWorld.Size = new System.Drawing.Size(353, 34);
            this.menuToolStripRestartWorld.Text = "&Перезапустить мир";
            this.menuToolStripRestartWorld.Click += new System.EventHandler(this.menuToolStripRestartWorld_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(350, 6);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.simularToolStripMenuItem.Text = "&Запустить";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // pnlWorldConfig
            // 
            this.pnlWorldConfig.AutoScroll = true;
            this.pnlWorldConfig.Controls.Add(this.wViewConfig);
            this.pnlWorldConfig.Location = new System.Drawing.Point(7, 41);
            this.pnlWorldConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWorldConfig.Name = "pnlWorldConfig";
            this.pnlWorldConfig.Size = new System.Drawing.Size(1020, 838);
            this.pnlWorldConfig.TabIndex = 1;
            // 
            // wViewConfig
            // 
            this.wViewConfig.AutoSize = true;
            this.wViewConfig.BackColor = System.Drawing.Color.Transparent;
            this.wViewConfig.IsReadOnly = false;
            this.wViewConfig.Location = new System.Drawing.Point(8, 6);
            this.wViewConfig.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.wViewConfig.Name = "wViewConfig";
            this.wViewConfig.Size = new System.Drawing.Size(1135, 1039);
            this.wViewConfig.SizePiece = 64F;
            this.wViewConfig.TabIndex = 0;
            // 
            // tbarZoom
            // 
            this.tbarZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbarZoom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbarZoom.LargeChange = 1;
            this.tbarZoom.Location = new System.Drawing.Point(322, 891);
            this.tbarZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbarZoom.Maximum = 4;
            this.tbarZoom.Minimum = 1;
            this.tbarZoom.Name = "tbarZoom";
            this.tbarZoom.Size = new System.Drawing.Size(454, 69);
            this.tbarZoom.TabIndex = 2;
            this.tbarZoom.TickFrequency = 4;
            this.tbarZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarZoom.Value = 1;
            this.tbarZoom.Scroll += new System.EventHandler(this.tbarZoom_Scroll);
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(117, 910);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(90, 25);
            this.lblZoom.TabIndex = 3;
            this.lblZoom.Text = "Zoom: ";
            // 
            // lblMinZoom
            // 
            this.lblMinZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinZoom.AutoSize = true;
            this.lblMinZoom.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinZoom.Location = new System.Drawing.Point(246, 911);
            this.lblMinZoom.Name = "lblMinZoom";
            this.lblMinZoom.Size = new System.Drawing.Size(75, 23);
            this.lblMinZoom.TabIndex = 4;
            this.lblMinZoom.Text = " 1.0x";
            // 
            // lblMaxZoom
            // 
            this.lblMaxZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMaxZoom.AutoSize = true;
            this.lblMaxZoom.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxZoom.Location = new System.Drawing.Point(800, 911);
            this.lblMaxZoom.Name = "lblMaxZoom";
            this.lblMaxZoom.Size = new System.Drawing.Size(62, 23);
            this.lblMaxZoom.TabIndex = 5;
            this.lblMaxZoom.Text = "4.0x";
            // 
            // SettingsWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 961);
            this.Controls.Add(this.lblMaxZoom);
            this.Controls.Add(this.lblMinZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.tbarZoom);
            this.Controls.Add(this.pnlWorldConfig);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка мира~";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsWorldForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlWorldConfig.ResumeLayout(false);
            this.pnlWorldConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripAddWorld;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWorldConfig;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripRestartWorld;
        private WorldViewer.WorldViewer wViewConfig;
        private System.Windows.Forms.TrackBar tbarZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lblMinZoom;
        private System.Windows.Forms.Label lblMaxZoom;
    }
}