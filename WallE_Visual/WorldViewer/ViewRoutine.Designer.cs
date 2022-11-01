namespace WallE_Visual.WorldViewer
{
    partial class ViewRoutineForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRoutineForm));
            this.pnlRutineView = new System.Windows.Forms.Panel();
            this.rutView = new WallE_Visual.RutViews();
            this.gboxControlsList = new System.Windows.Forms.GroupBox();
            this.cboxList = new System.Windows.Forms.ComboBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ofileLoadRut = new System.Windows.Forms.OpenFileDialog();
            this.tTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.tbarZoom = new System.Windows.Forms.TrackBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaRutinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblRutName = new System.Windows.Forms.Label();
            this.pnlRutineView.SuspendLayout();
            this.gboxControlsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRutineView
            // 
            this.pnlRutineView.AutoScroll = true;
            this.pnlRutineView.Controls.Add(this.rutView);
            this.pnlRutineView.Location = new System.Drawing.Point(8, 75);
            this.pnlRutineView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRutineView.Name = "pnlRutineView";
            this.pnlRutineView.Size = new System.Drawing.Size(774, 625);
            this.pnlRutineView.TabIndex = 0;
            // 
            // rutView
            // 
            this.rutView.AutoSize = true;
            this.rutView.BackColor = System.Drawing.Color.Transparent;
            this.rutView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutView.IsReadOnly = false;
            this.rutView.Location = new System.Drawing.Point(0, 0);
            this.rutView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rutView.Name = "rutView";
            this.rutView.Size = new System.Drawing.Size(860, 764);
            this.rutView.TabIndex = 0;
            // 
            // gboxControlsList
            // 
            this.gboxControlsList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gboxControlsList.Controls.Add(this.cboxList);
            this.gboxControlsList.Controls.Add(this.lblList);
            this.gboxControlsList.Controls.Add(this.btnAdd);
            this.gboxControlsList.Controls.Add(this.btnDelete);
            this.gboxControlsList.Controls.Add(this.btnLoad);
            this.gboxControlsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxControlsList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxControlsList.ForeColor = System.Drawing.SystemColors.Window;
            this.gboxControlsList.Location = new System.Drawing.Point(12, 708);
            this.gboxControlsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxControlsList.Name = "gboxControlsList";
            this.gboxControlsList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxControlsList.Size = new System.Drawing.Size(837, 102);
            this.gboxControlsList.TabIndex = 1;
            this.gboxControlsList.TabStop = false;
            this.gboxControlsList.Text = "Список определений";
            // 
            // cboxList
            // 
            this.cboxList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxList.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxList.FormattingEnabled = true;
            this.cboxList.Location = new System.Drawing.Point(194, 38);
            this.cboxList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxList.Name = "cboxList";
            this.cboxList.Size = new System.Drawing.Size(231, 30);
            this.cboxList.TabIndex = 4;
            this.cboxList.SelectedIndexChanged += new System.EventHandler(this.cboxList_SelectedIndexChanged);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(80, 41);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(80, 22);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "Список:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(588, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 65);
            this.btnAdd.TabIndex = 2;
            this.tTipInfo.SetToolTip(this.btnAdd, "Añadir la rutina que se muestra a la lista. Si la rutina esta en la lista no pasa" +
        " nada.");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(758, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 71);
            this.btnDelete.TabIndex = 1;
            this.tTipInfo.SetToolTip(this.btnDelete, "Borrar la rutina mostrada.");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(674, 29);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 65);
            this.btnLoad.TabIndex = 0;
            this.tTipInfo.SetToolTip(this.btnLoad, "Cargar un rutina de un .txt");
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ofileLoadRut
            // 
            this.ofileLoadRut.Filter = "Text File| *txt";
            this.ofileLoadRut.Multiselect = true;
            this.ofileLoadRut.Title = "Подпрограммы загрузки";
            // 
            // tTipInfo
            // 
            this.tTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tTipInfo.ToolTipTitle = "Información";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblZoom.Location = new System.Drawing.Point(788, 591);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(60, 22);
            this.lblZoom.TabIndex = 0;
            this.lblZoom.Text = "Zoom:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMin.Location = new System.Drawing.Point(791, 546);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(50, 22);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "1.0x";
            // 
            // tbarZoom
            // 
            this.tbarZoom.LargeChange = 1;
            this.tbarZoom.Location = new System.Drawing.Point(788, 209);
            this.tbarZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbarZoom.Maximum = 4;
            this.tbarZoom.Minimum = 1;
            this.tbarZoom.Name = "tbarZoom";
            this.tbarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarZoom.Size = new System.Drawing.Size(69, 301);
            this.tbarZoom.TabIndex = 0;
            this.tbarZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarZoom.Value = 4;
            this.tbarZoom.Scroll += new System.EventHandler(this.tbarZoom_Scroll);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMax.Location = new System.Drawing.Point(791, 164);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(50, 22);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "4.0x";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaRutinaToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(16, 20);
            this.opcionesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nuevaRutinaToolStripMenuItem
            // 
            this.nuevaRutinaToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nuevaRutinaToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaRutinaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.nuevaRutinaToolStripMenuItem.Name = "nuevaRutinaToolStripMenuItem";
            this.nuevaRutinaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevaRutinaToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.nuevaRutinaToolStripMenuItem.Text = "Nueva Rutina";
            this.nuevaRutinaToolStripMenuItem.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exportarToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.AutoToolTip = true;
            this.ayudaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(16, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Seleccione la dirección donde desea guardar el .txt resultante de exportar la rut" +
    "ina.";
            // 
            // lblRutName
            // 
            this.lblRutName.AutoSize = true;
            this.lblRutName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRutName.Location = new System.Drawing.Point(310, 39);
            this.lblRutName.Name = "lblRutName";
            this.lblRutName.Size = new System.Drawing.Size(82, 24);
            this.lblRutName.TabIndex = 6;
            this.lblRutName.Text = "label1";
            // 
            // ViewRoutineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(854, 814);
            this.Controls.Add(this.lblRutName);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.tbarZoom);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.gboxControlsList);
            this.Controls.Add(this.pnlRutineView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewRoutineForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор определений";
            this.pnlRutineView.ResumeLayout(false);
            this.pnlRutineView.PerformLayout();
            this.gboxControlsList.ResumeLayout(false);
            this.gboxControlsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRutineView;
        private System.Windows.Forms.GroupBox gboxControlsList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofileLoadRut;
        private System.Windows.Forms.ComboBox cboxList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip tTipInfo;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TrackBar tbarZoom;
        private System.Windows.Forms.Label lblMax;
        private RutViews rutView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaRutinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label lblRutName;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}