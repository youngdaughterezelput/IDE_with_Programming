namespace WallE_Visual.WorldViewer
{
    partial class WorldViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.conMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addObjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxProperties = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addColumnColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipPosition = new System.Windows.Forms.ToolTip(this.components);
            this.pboxWorld = new System.Windows.Forms.PictureBox();
            this.conMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // conMenuOptions
            // 
            this.conMenuOptions.BackColor = System.Drawing.SystemColors.Info;
            this.conMenuOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObjToolStripMenuItem,
            this.editObjetoToolStripMenuItem,
            this.dropObjetoToolStripMenuItem,
            this.toolStripSeparator2,
            this.characterToolStripMenuItem,
            this.toolStripSeparator1,
            this.addColumnColumnaToolStripMenuItem,
            this.addRowToolStripMenuItem,
            this.dropColumnToolStripMenuItem,
            this.dropRowsToolStripMenuItem});
            this.conMenuOptions.Name = "contextMenuStrip1";
            this.conMenuOptions.Size = new System.Drawing.Size(268, 272);
            this.conMenuOptions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenuOptions_Opening);
            // 
            // addObjToolStripMenuItem
            // 
            this.addObjToolStripMenuItem.Name = "addObjToolStripMenuItem";
            this.addObjToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.addObjToolStripMenuItem.Text = "Добавить объект";
            this.addObjToolStripMenuItem.Click += new System.EventHandler(this.addObjToolStripMenuItem_Click);
            // 
            // editObjetoToolStripMenuItem
            // 
            this.editObjetoToolStripMenuItem.Name = "editObjetoToolStripMenuItem";
            this.editObjetoToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.editObjetoToolStripMenuItem.Text = "Редактировать объект";
            this.editObjetoToolStripMenuItem.Click += new System.EventHandler(this.editObjetoToolStripMenuItem_Click);
            // 
            // dropObjetoToolStripMenuItem
            // 
            this.dropObjetoToolStripMenuItem.Name = "dropObjetoToolStripMenuItem";
            this.dropObjetoToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.dropObjetoToolStripMenuItem.Text = "Удалить объект";
            this.dropObjetoToolStripMenuItem.Click += new System.EventHandler(this.dropObjetoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tboxProperties});
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.characterToolStripMenuItem.Text = "Посмотреть свойства";
            this.characterToolStripMenuItem.MouseHover += new System.EventHandler(this.characterToolStripMenuItem_MouseHover);
            // 
            // tboxProperties
            // 
            this.tboxProperties.BackColor = System.Drawing.SystemColors.Info;
            this.tboxProperties.Enabled = false;
            this.tboxProperties.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxProperties.Name = "tboxProperties";
            this.tboxProperties.ReadOnly = true;
            this.tboxProperties.Size = new System.Drawing.Size(100, 31);
            this.tboxProperties.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // addColumnColumnaToolStripMenuItem
            // 
            this.addColumnColumnaToolStripMenuItem.Name = "addColumnColumnaToolStripMenuItem";
            this.addColumnColumnaToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.addColumnColumnaToolStripMenuItem.Text = "Вставить столбец";
            this.addColumnColumnaToolStripMenuItem.Click += new System.EventHandler(this.addColumnColumnaToolStripMenuItem_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.addRowToolStripMenuItem.Text = "Вставить строку";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // dropColumnToolStripMenuItem
            // 
            this.dropColumnToolStripMenuItem.Name = "dropColumnToolStripMenuItem";
            this.dropColumnToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.dropColumnToolStripMenuItem.Text = "Удалить столбец";
            this.dropColumnToolStripMenuItem.Click += new System.EventHandler(this.dropColumnToolStripMenuItem_Click);
            // 
            // dropRowsToolStripMenuItem
            // 
            this.dropRowsToolStripMenuItem.Name = "dropRowsToolStripMenuItem";
            this.dropRowsToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.dropRowsToolStripMenuItem.Text = "Удалить строку";
            this.dropRowsToolStripMenuItem.Click += new System.EventHandler(this.dropRowsToolStripMenuItem_Click);
            // 
            // toolTipPosition
            // 
            this.toolTipPosition.IsBalloon = true;
            this.toolTipPosition.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPosition.ToolTipTitle = "Poisicion";
            // 
            // pboxWorld
            // 
            this.pboxWorld.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxWorld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWorld.ContextMenuStrip = this.conMenuOptions;
            this.pboxWorld.InitialImage = null;
            this.pboxWorld.Location = new System.Drawing.Point(0, 0);
            this.pboxWorld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxWorld.Name = "pboxWorld";
            this.pboxWorld.Size = new System.Drawing.Size(1006, 827);
            this.pboxWorld.TabIndex = 0;
            this.pboxWorld.TabStop = false;
            this.pboxWorld.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxWorld_Paint);
            this.pboxWorld.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxWorld_MouseDown);
            // 
            // WorldViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pboxWorld);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorldViewer";
            this.Size = new System.Drawing.Size(1009, 831);
            this.conMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorld;
        private System.Windows.Forms.ContextMenuStrip conMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem addObjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tboxProperties;
        private System.Windows.Forms.ToolTip toolTipPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addColumnColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropRowsToolStripMenuItem;
    }
}
