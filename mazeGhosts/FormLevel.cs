using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazeGhosts
{
    public partial class FormLevel : Form
    {
        public FormLevel()
        {
            InitializeComponent();
        }

        private void buttonLevel1_Click(object sender, EventArgs e)
        {
            CreateGame(1);
        }

        private void buttonLevel2_Click(object sender, EventArgs e)
        {
            CreateGame(2);
        }

        private void buttonLevel3_Click(object sender, EventArgs e)
        {
            CreateGame(3);
        }
        //передача уровня в FormGame
        private void CreateGame(int level)
        {
            FormGame game = new FormGame(level);
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void buttonRuls_Click(object sender, EventArgs e)//правила
        {
            StreamReader reader = new StreamReader("Data/Rules.txt");
            MessageBox.Show(reader.ReadLine(),"Правила игры");
        }

        private void buttonTop_Click(object sender, EventArgs e)//рейтинг
        {
            FormTop formTop = new FormTop();
            formTop.ShowDialog();

        }
    }
}
