﻿namespace WallE_Visual.WorldViewer
{
    partial class AddObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObjectForm));
            this.lblShape = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboxShape = new System.Windows.Forms.ComboBox();
            this.cboxSize = new System.Windows.Forms.ComboBox();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.cboxDirection = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShape
            // 
            this.lblShape.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShape.AutoSize = true;
            this.lblShape.BackColor = System.Drawing.Color.Transparent;
            this.lblShape.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShape.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShape.Location = new System.Drawing.Point(13, 30);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(94, 24);
            this.lblShape.TabIndex = 0;
            this.lblShape.Text = "Объект:";
            this.lblShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSize.Location = new System.Drawing.Point(13, 91);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(94, 24);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Размер:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColor.Location = new System.Drawing.Point(13, 152);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(70, 24);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Цвет:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxShape
            // 
            this.cboxShape.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxShape.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxShape.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxShape.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxShape.FormattingEnabled = true;
            this.cboxShape.Location = new System.Drawing.Point(173, 30);
            this.cboxShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxShape.Name = "cboxShape";
            this.cboxShape.Size = new System.Drawing.Size(167, 28);
            this.cboxShape.TabIndex = 3;
            this.cboxShape.SelectedValueChanged += new System.EventHandler(this.cBoxShape_SelectedValueChanged);
            // 
            // cboxSize
            // 
            this.cboxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxSize.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSize.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxSize.FormattingEnabled = true;
            this.cboxSize.Location = new System.Drawing.Point(173, 92);
            this.cboxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxSize.Name = "cboxSize";
            this.cboxSize.Size = new System.Drawing.Size(167, 28);
            this.cboxSize.TabIndex = 4;
            // 
            // cboxColor
            // 
            this.cboxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxColor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxColor.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxColor.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Location = new System.Drawing.Point(173, 152);
            this.cboxColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(167, 28);
            this.cboxColor.TabIndex = 5;
            // 
            // lblDirection
            // 
            this.lblDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirection.AutoSize = true;
            this.lblDirection.BackColor = System.Drawing.Color.Transparent;
            this.lblDirection.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDirection.Location = new System.Drawing.Point(13, 209);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(154, 24);
            this.lblDirection.TabIndex = 6;
            this.lblDirection.Text = "Направление:";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxDirection
            // 
            this.cboxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDirection.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxDirection.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDirection.ForeColor = System.Drawing.SystemColors.Window;
            this.cboxDirection.FormattingEnabled = true;
            this.cboxDirection.Location = new System.Drawing.Point(173, 209);
            this.cboxDirection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxDirection.Name = "cboxDirection";
            this.cboxDirection.Size = new System.Drawing.Size(167, 28);
            this.cboxDirection.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(77, 265);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 38);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // AddObjectForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(352, 316);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cboxDirection);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.cboxColor);
            this.Controls.Add(this.cboxSize);
            this.Controls.Add(this.cboxShape);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblShape);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddObjectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить объект";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddObjectForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboxShape;
        private System.Windows.Forms.ComboBox cboxSize;
        private System.Windows.Forms.ComboBox cboxColor;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.ComboBox cboxDirection;
        private System.Windows.Forms.Button btnCreate;
    }
}