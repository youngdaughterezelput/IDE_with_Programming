namespace WallE_Visual.WorldViewer
{
    partial class EditObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditObject));
            this.lblSize = new System.Windows.Forms.Label();
            this.cboxSize = new System.Windows.Forms.ComboBox();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboxDirection = new System.Windows.Forms.ComboBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblWallEObjects = new System.Windows.Forms.Label();
            this.btnEdited = new System.Windows.Forms.Button();
            this.btnEditRut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSize.Location = new System.Drawing.Point(44, 46);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(94, 24);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Размер:";
            // 
            // cboxSize
            // 
            this.cboxSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxSize.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSize.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxSize.FormattingEnabled = true;
            this.cboxSize.Location = new System.Drawing.Point(151, 41);
            this.cboxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxSize.Name = "cboxSize";
            this.cboxSize.Size = new System.Drawing.Size(136, 29);
            this.cboxSize.TabIndex = 1;
            // 
            // cboxColor
            // 
            this.cboxColor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxColor.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxColor.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Location = new System.Drawing.Point(151, 96);
            this.cboxColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(136, 29);
            this.cboxColor.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblColor.Location = new System.Drawing.Point(50, 101);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(70, 24);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Цвет:";
            // 
            // cboxDirection
            // 
            this.cboxDirection.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxDirection.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDirection.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxDirection.FormattingEnabled = true;
            this.cboxDirection.Location = new System.Drawing.Point(174, 151);
            this.cboxDirection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxDirection.Name = "cboxDirection";
            this.cboxDirection.Size = new System.Drawing.Size(136, 29);
            this.cboxDirection.TabIndex = 5;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.BackColor = System.Drawing.Color.Transparent;
            this.lblDirections.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDirections.Location = new System.Drawing.Point(14, 152);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(154, 24);
            this.lblDirections.TabIndex = 4;
            this.lblDirections.Text = "Направление:";
            // 
            // lblWallEObjects
            // 
            this.lblWallEObjects.AutoSize = true;
            this.lblWallEObjects.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallEObjects.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWallEObjects.Location = new System.Drawing.Point(44, 11);
            this.lblWallEObjects.Name = "lblWallEObjects";
            this.lblWallEObjects.Size = new System.Drawing.Size(0, 24);
            this.lblWallEObjects.TabIndex = 7;
            // 
            // btnEdited
            // 
            this.btnEdited.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEdited.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdited.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEdited.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdited.Location = new System.Drawing.Point(266, 202);
            this.btnEdited.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdited.Name = "btnEdited";
            this.btnEdited.Size = new System.Drawing.Size(50, 55);
            this.btnEdited.TabIndex = 0;
            this.btnEdited.UseVisualStyleBackColor = false;
            this.btnEdited.Click += new System.EventHandler(this.btnEdited_Click);
            // 
            // btnEditRut
            // 
            this.btnEditRut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEditRut.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnEditRut.FlatAppearance.BorderSize = 4;
            this.btnEditRut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRut.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRut.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditRut.Location = new System.Drawing.Point(19, 202);
            this.btnEditRut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditRut.Name = "btnEditRut";
            this.btnEditRut.Size = new System.Drawing.Size(158, 55);
            this.btnEditRut.TabIndex = 8;
            this.btnEditRut.Text = "Определить";
            this.btnEditRut.UseVisualStyleBackColor = false;
            this.btnEditRut.Click += new System.EventHandler(this.btnEditRut_Click);
            // 
            // EditObject
            // 
            this.AcceptButton = this.btnEdited;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(323, 265);
            this.Controls.Add(this.btnEditRut);
            this.Controls.Add(this.lblWallEObjects);
            this.Controls.Add(this.btnEdited);
            this.Controls.Add(this.cboxDirection);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.cboxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboxSize);
            this.Controls.Add(this.lblSize);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditObject";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редактор объекта.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboxSize;
        private System.Windows.Forms.ComboBox cboxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboxDirection;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnEdited;
        private System.Windows.Forms.Label lblWallEObjects;
        private System.Windows.Forms.Button btnEditRut;
    }
}