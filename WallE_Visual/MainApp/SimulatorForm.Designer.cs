namespace WallE_Visual.MainApp
{
    partial class SimulatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorForm));
            this.pnlWorld = new System.Windows.Forms.Panel();
            this.gbosControls = new System.Windows.Forms.GroupBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.tboxNumberRound = new System.Windows.Forms.TextBox();
            this.lblNumberRound = new System.Windows.Forms.Label();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlRut = new System.Windows.Forms.Panel();
            this.mStripOptions = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsWorldSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingWorldStandartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTipGuide = new System.Windows.Forms.ToolTip(this.components);
            this.wEConsole = new WallE_Visual.Wall_E_Console();
            this.rutView = new WallE_Visual.RutViews();
            this.wView = new WallE_Visual.WorldViewer.WorldViewer();
            this.pnlWorld.SuspendLayout();
            this.gbosControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTime)).BeginInit();
            this.pnlRut.SuspendLayout();
            this.mStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorld
            // 
            this.pnlWorld.AutoScroll = true;
            this.pnlWorld.Controls.Add(this.wView);
            this.pnlWorld.Location = new System.Drawing.Point(11, 45);
            this.pnlWorld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWorld.Name = "pnlWorld";
            this.pnlWorld.Size = new System.Drawing.Size(1012, 838);
            this.pnlWorld.TabIndex = 0;
            // 
            // gbosControls
            // 
            this.gbosControls.BackColor = System.Drawing.SystemColors.Control;
            this.gbosControls.Controls.Add(this.lblSeconds);
            this.gbosControls.Controls.Add(this.nUpDownTime);
            this.gbosControls.Controls.Add(this.lblTime);
            this.gbosControls.Controls.Add(this.tboxNumberRound);
            this.gbosControls.Controls.Add(this.lblNumberRound);
            this.gbosControls.Controls.Add(this.rbtnNo);
            this.gbosControls.Controls.Add(this.rbtnYes);
            this.gbosControls.Controls.Add(this.lblErrors);
            this.gbosControls.Controls.Add(this.btnDebug);
            this.gbosControls.Controls.Add(this.btnAdvance);
            this.gbosControls.Controls.Add(this.btnPause);
            this.gbosControls.Controls.Add(this.btnPlay);
            this.gbosControls.Controls.Add(this.btnStop);
            this.gbosControls.Location = new System.Drawing.Point(11, 896);
            this.gbosControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbosControls.Name = "gbosControls";
            this.gbosControls.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbosControls.Size = new System.Drawing.Size(1007, 92);
            this.gbosControls.TabIndex = 1;
            this.gbosControls.TabStop = false;
            this.gbosControls.Text = "Панель контроля";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(593, 52);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(21, 20);
            this.lblSeconds.TabIndex = 12;
            this.lblSeconds.Text = "с.";
            // 
            // nUpDownTime
            // 
            this.nUpDownTime.DecimalPlaces = 1;
            this.nUpDownTime.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nUpDownTime.Location = new System.Drawing.Point(524, 51);
            this.nUpDownTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUpDownTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nUpDownTime.Name = "nUpDownTime";
            this.nUpDownTime.ReadOnly = true;
            this.nUpDownTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUpDownTime.Size = new System.Drawing.Size(62, 26);
            this.nUpDownTime.TabIndex = 11;
            this.nUpDownTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipGuide.SetToolTip(this.nUpDownTime, "Время между выполненными шагами");
            this.nUpDownTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nUpDownTime.ValueChanged += new System.EventHandler(this.nUpDownTime_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(512, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(188, 20);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Время моделирования:";
            // 
            // tboxNumberRound
            // 
            this.tboxNumberRound.BackColor = System.Drawing.SystemColors.Control;
            this.tboxNumberRound.Cursor = System.Windows.Forms.Cursors.No;
            this.tboxNumberRound.Enabled = false;
            this.tboxNumberRound.Location = new System.Drawing.Point(889, 51);
            this.tboxNumberRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNumberRound.Name = "tboxNumberRound";
            this.tboxNumberRound.ReadOnly = true;
            this.tboxNumberRound.Size = new System.Drawing.Size(57, 26);
            this.tboxNumberRound.TabIndex = 9;
            // 
            // lblNumberRound
            // 
            this.lblNumberRound.AutoSize = true;
            this.lblNumberRound.Location = new System.Drawing.Point(885, 19);
            this.lblNumberRound.Name = "lblNumberRound";
            this.lblNumberRound.Size = new System.Drawing.Size(42, 20);
            this.lblNumberRound.TabIndex = 8;
            this.lblNumberRound.Text = "Шаг:";
            this.toolTipGuide.SetToolTip(this.lblNumberRound, "Ronda actual");
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Checked = true;
            this.rbtnNo.Location = new System.Drawing.Point(782, 52);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(64, 24);
            this.rbtnNo.TabIndex = 7;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "Нет";
            this.toolTipGuide.SetToolTip(this.rbtnNo, "Симулятор закроется, если есть ошибки");
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(703, 52);
            this.rbtnYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(55, 24);
            this.rbtnYes.TabIndex = 6;
            this.rbtnYes.Text = "Да";
            this.toolTipGuide.SetToolTip(this.rbtnYes, "Симулятор не закроется, даже если есть ошибки");
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(711, 19);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(73, 20);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "Ошибки:";
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.Transparent;
            this.btnDebug.BackgroundImage = global::WallE_Visual.Properties.Resources.debug;
            this.btnDebug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebug.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Location = new System.Drawing.Point(22, 19);
            this.btnDebug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(66, 66);
            this.btnDebug.TabIndex = 4;
            this.toolTipGuide.SetToolTip(this.btnDebug, "Дебаг");
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvance.BackgroundImage = global::WallE_Visual.Properties.Resources.advance1;
            this.btnAdvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdvance.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvance.Location = new System.Drawing.Point(423, 19);
            this.btnAdvance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(66, 66);
            this.btnAdvance.TabIndex = 3;
            this.toolTipGuide.SetToolTip(this.btnAdvance, "Перейти к следующему шагу");
            this.btnAdvance.UseVisualStyleBackColor = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::WallE_Visual.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(323, 19);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(66, 66);
            this.btnPause.TabIndex = 2;
            this.toolTipGuide.SetToolTip(this.btnPause, "Пауза");
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::WallE_Visual.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(224, 19);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(66, 66);
            this.btnPlay.TabIndex = 1;
            this.toolTipGuide.SetToolTip(this.btnPlay, "Старт");
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::WallE_Visual.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(123, 19);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 66);
            this.btnStop.TabIndex = 0;
            this.toolTipGuide.SetToolTip(this.btnStop, "Вернуть мир в изначальное состояние");
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlRut
            // 
            this.pnlRut.AutoScroll = true;
            this.pnlRut.Controls.Add(this.rutView);
            this.pnlRut.Location = new System.Drawing.Point(1030, 382);
            this.pnlRut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRut.Name = "pnlRut";
            this.pnlRut.Size = new System.Drawing.Size(768, 612);
            this.pnlRut.TabIndex = 2;
            // 
            // mStripOptions
            // 
            this.mStripOptions.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.mStripOptions.Location = new System.Drawing.Point(0, 0);
            this.mStripOptions.Name = "mStripOptions";
            this.mStripOptions.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mStripOptions.Size = new System.Drawing.Size(1810, 36);
            this.mStripOptions.TabIndex = 4;
            this.mStripOptions.Text = "Папки";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("folderToolStripMenuItem.Image")));
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(36, 32);
            this.folderToolStripMenuItem.ToolTipText = "Повторная настройка симуляции";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsWorldSizeToolStripMenuItem,
            this.settingWorldStandartToolStripMenuItem});
            this.optionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionToolStripMenuItem.Image")));
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(36, 32);
            this.optionToolStripMenuItem.ToolTipText = "Изменить размер.";
            // 
            // settingsWorldSizeToolStripMenuItem
            // 
            this.settingsWorldSizeToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.trackbar;
            this.settingsWorldSizeToolStripMenuItem.Name = "settingsWorldSizeToolStripMenuItem";
            this.settingsWorldSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.settingsWorldSizeToolStripMenuItem.Size = new System.Drawing.Size(431, 34);
            this.settingsWorldSizeToolStripMenuItem.Text = "&Настроить размер мира";
            this.settingsWorldSizeToolStripMenuItem.Click += new System.EventHandler(this.settingsWorldSizeToolStripMenuItem_Click);
            // 
            // settingWorldStandartToolStripMenuItem
            // 
            this.settingWorldStandartToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.trackbar;
            this.settingWorldStandartToolStripMenuItem.Name = "settingWorldStandartToolStripMenuItem";
            this.settingWorldStandartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.settingWorldStandartToolStripMenuItem.Size = new System.Drawing.Size(431, 34);
            this.settingWorldStandartToolStripMenuItem.Text = "&Настроить стандартный размер";
            this.settingWorldStandartToolStripMenuItem.Click += new System.EventHandler(this.settingWorldStandartToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.btnAdvance_Click);
            // 
            // toolTipGuide
            // 
            this.toolTipGuide.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGuide.ToolTipTitle = "Посказка:";
            // 
            // wEConsole
            // 
            this.wEConsole.AutoSize = true;
            this.wEConsole.BackColor = System.Drawing.Color.Transparent;
            this.wEConsole.Location = new System.Drawing.Point(1032, 45);
            this.wEConsole.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.wEConsole.Name = "wEConsole";
            this.wEConsole.Size = new System.Drawing.Size(767, 316);
            this.wEConsole.TabIndex = 5;
            // 
            // rutView
            // 
            this.rutView.AutoSize = true;
            this.rutView.BackColor = System.Drawing.Color.Transparent;
            this.rutView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutView.IsReadOnly = true;
            this.rutView.Location = new System.Drawing.Point(0, -4);
            this.rutView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rutView.Name = "rutView";
            this.rutView.Size = new System.Drawing.Size(860, 764);
            this.rutView.TabIndex = 0;
            // 
            // wView
            // 
            this.wView.AutoSize = true;
            this.wView.BackColor = System.Drawing.Color.Transparent;
            this.wView.IsReadOnly = false;
            this.wView.Location = new System.Drawing.Point(0, 0);
            this.wView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.wView.Name = "wView";
            this.wView.Size = new System.Drawing.Size(1135, 1039);
            this.wView.SizePiece = 64F;
            this.wView.TabIndex = 0;
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1810, 1010);
            this.Controls.Add(this.wEConsole);
            this.Controls.Add(this.pnlRut);
            this.Controls.Add(this.gbosControls);
            this.Controls.Add(this.pnlWorld);
            this.Controls.Add(this.mStripOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStripOptions;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SimulatorForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simulador";
            this.pnlWorld.ResumeLayout(false);
            this.pnlWorld.PerformLayout();
            this.gbosControls.ResumeLayout(false);
            this.gbosControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTime)).EndInit();
            this.pnlRut.ResumeLayout(false);
            this.pnlRut.PerformLayout();
            this.mStripOptions.ResumeLayout(false);
            this.mStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorld;
        private WorldViewer.WorldViewer wView;
        private System.Windows.Forms.GroupBox gbosControls;
        private System.Windows.Forms.Panel pnlRut;
        private RutViews rutView;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.MenuStrip mStripOptions;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsWorldSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingWorldStandartToolStripMenuItem;
        private System.Windows.Forms.TextBox tboxNumberRound;
        private System.Windows.Forms.Label lblNumberRound;
        private System.Windows.Forms.NumericUpDown nUpDownTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSeconds;
        private Wall_E_Console wEConsole;
        private System.Windows.Forms.ToolTip toolTipGuide;
    }
}