
namespace mazeGhosts
{
    partial class FormTop
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
            this.listViewScores = new System.Windows.Forms.ListView();
            this.columnHeaderLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewScores
            // 
            this.listViewScores.BackColor = System.Drawing.Color.LightCyan;
            this.listViewScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLevel,
            this.columnHeaderUserName,
            this.columnHeaderScore});
            this.listViewScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewScores.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewScores.HideSelection = false;
            this.listViewScores.Location = new System.Drawing.Point(0, 0);
            this.listViewScores.Name = "listViewScores";
            this.listViewScores.Size = new System.Drawing.Size(453, 588);
            this.listViewScores.TabIndex = 2;
            this.listViewScores.UseCompatibleStateImageBehavior = false;
            this.listViewScores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLevel
            // 
            this.columnHeaderLevel.Text = "Уровень";
            this.columnHeaderLevel.Width = 150;
            // 
            // columnHeaderScore
            // 
            this.columnHeaderScore.Text = "Время";
            this.columnHeaderScore.Width = 100;
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "Имя";
            this.columnHeaderUserName.Width = 200;
            // 
            // FormTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 588);
            this.Controls.Add(this.listViewScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTop";
            this.Text = "Рейтинг";
            this.Load += new System.EventHandler(this.FormTop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewScores;
        private System.Windows.Forms.ColumnHeader columnHeaderLevel;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderScore;
    }
}