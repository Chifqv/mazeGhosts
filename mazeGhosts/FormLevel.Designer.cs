namespace mazeGhosts
{
    partial class FormLevel
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
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonRuls = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevel1.Location = new System.Drawing.Point(130, 125);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(181, 54);
            this.buttonLevel1.TabIndex = 0;
            this.buttonLevel1.Text = "Level 1";
            this.buttonLevel1.UseVisualStyleBackColor = true;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.buttonLevel2.Location = new System.Drawing.Point(130, 194);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(181, 54);
            this.buttonLevel2.TabIndex = 1;
            this.buttonLevel2.Text = "Level 2";
            this.buttonLevel2.UseVisualStyleBackColor = true;
            this.buttonLevel2.Click += new System.EventHandler(this.buttonLevel2_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.buttonLevel3.Location = new System.Drawing.Point(130, 264);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(181, 52);
            this.buttonLevel3.TabIndex = 2;
            this.buttonLevel3.Text = "Level 3";
            this.buttonLevel3.UseVisualStyleBackColor = true;
            this.buttonLevel3.Click += new System.EventHandler(this.buttonLevel3_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(88, 78);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 33);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Выберите уровень";
            // 
            // labelHello
            // 
            this.labelHello.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic);
            this.labelHello.Location = new System.Drawing.Point(12, -8);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(404, 86);
            this.labelHello.TabIndex = 4;
            this.labelHello.Text = "Добро пожаловать в игру \"Лабиринтик\"!";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRuls
            // 
            this.buttonRuls.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRuls.Location = new System.Drawing.Point(130, 364);
            this.buttonRuls.Name = "buttonRuls";
            this.buttonRuls.Size = new System.Drawing.Size(181, 30);
            this.buttonRuls.TabIndex = 5;
            this.buttonRuls.Text = "Правила";
            this.buttonRuls.UseVisualStyleBackColor = true;
            this.buttonRuls.Click += new System.EventHandler(this.buttonRuls_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.buttonTop.Location = new System.Drawing.Point(130, 401);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(181, 31);
            this.buttonTop.TabIndex = 6;
            this.buttonTop.Text = "Рейтинг";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // FormLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(428, 472);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonRuls);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLevel3);
            this.Controls.Add(this.buttonLevel2);
            this.Controls.Add(this.buttonLevel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLevel";
            this.Text = "Лабиринтик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonRuls;
        private System.Windows.Forms.Button buttonTop;
    }
}