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
            this.editarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.verPropiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxProperties = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.añadirColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.editarObjetoToolStripMenuItem,
            this.eliminarObjetoToolStripMenuItem,
            this.toolStripSeparator2,
            this.verPropiedadesToolStripMenuItem,
            this.toolStripSeparator1,
            this.añadirColumnaToolStripMenuItem,
            this.insertarFilaToolStripMenuItem,
            this.eliminarColumnaToolStripMenuItem,
            this.eliminarFilaToolStripMenuItem});
            this.conMenuOptions.Name = "contextMenuStrip1";
            this.conMenuOptions.Size = new System.Drawing.Size(268, 305);
            this.conMenuOptions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenuOptions_Opening);
            // 
            // addObjToolStripMenuItem
            // 
            this.addObjToolStripMenuItem.Name = "addObjToolStripMenuItem";
            this.addObjToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.addObjToolStripMenuItem.Text = "Добавить объект";
            this.addObjToolStripMenuItem.Click += new System.EventHandler(this.añadirObjetoToolStripMenuItem_Click);
            // 
            // editarObjetoToolStripMenuItem
            // 
            this.editarObjetoToolStripMenuItem.Name = "editarObjetoToolStripMenuItem";
            this.editarObjetoToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.editarObjetoToolStripMenuItem.Text = "Редактировать объект";
            this.editarObjetoToolStripMenuItem.Click += new System.EventHandler(this.editarObjetoToolStripMenuItem_Click);
            // 
            // eliminarObjetoToolStripMenuItem
            // 
            this.eliminarObjetoToolStripMenuItem.Name = "eliminarObjetoToolStripMenuItem";
            this.eliminarObjetoToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.eliminarObjetoToolStripMenuItem.Text = "Удалить объект";
            this.eliminarObjetoToolStripMenuItem.Click += new System.EventHandler(this.eliminarObjetoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // verPropiedadesToolStripMenuItem
            // 
            this.verPropiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tboxProperties});
            this.verPropiedadesToolStripMenuItem.Name = "verPropiedadesToolStripMenuItem";
            this.verPropiedadesToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.verPropiedadesToolStripMenuItem.Text = "Посмотреть свойства";
            this.verPropiedadesToolStripMenuItem.MouseHover += new System.EventHandler(this.verCaracteristicasToolStripMenuItem_MouseHover);
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
            // añadirColumnaToolStripMenuItem
            // 
            this.añadirColumnaToolStripMenuItem.Name = "añadirColumnaToolStripMenuItem";
            this.añadirColumnaToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.añadirColumnaToolStripMenuItem.Text = "Вставить столбец";
            this.añadirColumnaToolStripMenuItem.Click += new System.EventHandler(this.añadirColumnaToolStripMenuItem_Click);
            // 
            // insertarFilaToolStripMenuItem
            // 
            this.insertarFilaToolStripMenuItem.Name = "insertarFilaToolStripMenuItem";
            this.insertarFilaToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.insertarFilaToolStripMenuItem.Text = "Вставить строку";
            this.insertarFilaToolStripMenuItem.Click += new System.EventHandler(this.insertarFilaToolStripMenuItem_Click);
            // 
            // eliminarColumnaToolStripMenuItem
            // 
            this.eliminarColumnaToolStripMenuItem.Name = "eliminarColumnaToolStripMenuItem";
            this.eliminarColumnaToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.eliminarColumnaToolStripMenuItem.Text = "Удалить столбец";
            this.eliminarColumnaToolStripMenuItem.Click += new System.EventHandler(this.eliminarColumnaToolStripMenuItem_Click);
            // 
            // eliminarFilaToolStripMenuItem
            // 
            this.eliminarFilaToolStripMenuItem.Name = "eliminarFilaToolStripMenuItem";
            this.eliminarFilaToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.eliminarFilaToolStripMenuItem.Text = "Удалить строку";
            this.eliminarFilaToolStripMenuItem.Click += new System.EventHandler(this.eliminarFilaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem editarObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verPropiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tboxProperties;
        private System.Windows.Forms.ToolTip toolTipPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem añadirColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarFilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
    }
}
