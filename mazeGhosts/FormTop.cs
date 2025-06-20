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
    public partial class FormTop : Form
    {
        public FormTop()
        {
            InitializeComponent();
        }
        List<List<string>> sortTop(string[] lvl, string[] name, string[] time)
        {
            List<List<string>> data = new List<List<string>>();
            for (int i = 0; i < lvl.Length; i++)
            {
                data[i][0] = lvl[i];
                data[i][1] = name[i];
                data[i][2] = time[i];
            }
            data.Sort((a, b) => a[0].CompareTo(b[2]));
            return data;
        }
        private void FormTop_Load(object sender, EventArgs e)
        {
            string[] levels = new string[20];
            string[] names = new string[20];
            string[] time = new string[20];
            int length = 0;
            StreamReader sr = new StreamReader("Top.txt");
            try
            {
                //считывание данных из файла
                for (int i = 0; i < 20; i++)
                {

                    string[] temp = sr.ReadLine().Split('|');
                    levels[i] = temp[0];
                    names[i] = temp[1];
                    time[i] = temp[2];
                    length++;

                }
                sr.Close();
            }
            catch
            { }
            finally
            {
                //запись в ListView
                //List<List<string>> data = sortTop(levels, names, time);
                for (int i = 0; i < length; i++)
                {
                    //ListViewItem item = new ListViewItem(new string[] {data[i][0], data[i][1], data[i][2]});
                    ListViewItem item = new ListViewItem(new string[] { levels[i], names[i], time[i]});
                    listViewScores.Items.Add(item);
                }


                listViewScores.Sorting = SortOrder.Ascending;//сортировка по возрастанию
            }
        }
    }   
}
