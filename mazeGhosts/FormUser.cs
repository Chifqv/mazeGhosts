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
    public partial class FormUser : Form
    {
        public int level;
        public string time;
        StreamWriter sw;
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //регистрация пользователя в файл
            
            string name = textBoxUsername.Text;
            
            sw.WriteLine(level + "|" + name + "|" + time);
            sw.Close();
            this.Hide();
            FormTop formTop = new FormTop();
            formTop.ShowDialog();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            sw = new StreamWriter("Top.txt", true);
        }
    }
}
