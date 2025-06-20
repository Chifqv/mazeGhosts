namespace mazeGhosts
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerGhost1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TLabel = new System.Windows.Forms.Label();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.labelLvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(367, 50);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(345, 63);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Ваш счет";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerGhost1
            // 
            this.timerGhost1.Enabled = true;
            this.timerGhost1.Interval = 1000;
            this.timerGhost1.Tick += new System.EventHandler(this.timerGhost1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TimeLabel.Location = new System.Drawing.Point(533, 15);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(107, 39);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00:00";
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TLabel.Location = new System.Drawing.Point(371, 15);
            this.TLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(135, 39);
            this.TLabel.TabIndex = 4;
            this.TLabel.Text = "Время:";
            // 
            // TimeTimer
            // 
            this.TimeTimer.Enabled = true;
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // buttonRules
            // 
            this.buttonRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRules.Location = new System.Drawing.Point(379, 117);
            this.buttonRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(147, 47);
            this.buttonRules.TabIndex = 5;
            this.buttonRules.Text = "Правила";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTop.Location = new System.Drawing.Point(379, 172);
            this.buttonTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(147, 50);
            this.buttonTop.TabIndex = 6;
            this.buttonTop.Text = "Рейтинг";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // labelLvl
            // 
            this.labelLvl.AutoSize = true;
            this.labelLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLvl.Location = new System.Drawing.Point(379, 251);
            this.labelLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLvl.Name = "labelLvl";
            this.labelLvl.Size = new System.Drawing.Size(0, 36);
            this.labelLvl.TabIndex = 7;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(721, 373);
            this.Controls.Add(this.labelLvl);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.TLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.labelScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerGhost1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TLabel;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Label labelLvl;
    }
}

