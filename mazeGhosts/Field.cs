using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace mazeGhosts
{
    public class Field:DataGridView
    {
        public char[,] map;
        protected Image wallImage;
        public Image floorImage;
        public Image pointImage;
        public int count;
        protected int widthColumn = 40;

        public Field(string wallPath, string floorPath, string pointPath)
        {
            wallImage = Bitmap.FromFile(wallPath);
            floorImage = Bitmap.FromFile(floorPath);
            pointImage = Bitmap.FromFile(pointPath);

            InitializeGridSettings();
        }
        private void InitializeGridSettings()
        {
            RowTemplate.Resizable = DataGridViewTriState.True;
            RowTemplate.Height = widthColumn;
            ColumnHeadersVisible = false;
            RowHeadersVisible = false;
            AllowUserToAddRows = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            ScrollBars = ScrollBars.None;
        }
        public char[,] LoadMapFromFile(string filename)//загрузка карты из файла
        {
            StreamReader reader = new StreamReader(filename);
            string[] temp = reader.ReadLine().Split();
            int rows = Convert.ToInt32(temp[0]);
            int cols = Convert.ToInt32(temp[1]);
            map = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string s = reader.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    map[i, j] = s[j];
                    if (s[j] == '1')
                    {
                        count++;
                    }
                }
            }
            reader.Close();
            return map;
        }

        public void CreateField(char[,] data)//создание поля
        {
            //Width = (data.GetLength(1) + 1) * (widthColumn) - 35;
            // Height = (data.GetLength(0) + 1) * (widthColumn);

            Width = (map.GetLength(1)) * 40;
            Height = (map.GetLength(0)) * 40;

            Columns.Clear();
            for (int i = 0; i < map.GetLength(1); i++)
            {
                var column = new DataGridViewImageColumn();
                column.Width = 40;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                Columns.Add(column);
            }

            RowCount = map.GetLength(0);
        }

        public void DrawField(char[,] data)//отрисовка поля
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    switch (data[i, j])
                    {
                        case 'x':
                            Rows[i].Cells[j].Value = wallImage;
                            break;
                        case '0':
                            Rows[i].Cells[j].Value = floorImage;
                            break;
                        case '1':
                            Rows[i].Cells[j].Value = pointImage;
                            break;
                    }
                }
            }
        }

        public bool IsValidCell(int x, int y)//можно ли ходить(проверка на края лабиринта)
        {
            if (x < 0 || y < 0 || x >= map.GetLength(1) || y >= map.GetLength(0))
                return false;
            return map[y, x] != 'x';
        }

        public int CountPoints()//подсчет очков
        {
            int count1 = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == '1') count1++;
                }
            }
            return count1;
        }
    }

    public class Player
    {
        private Field gameField;
        private Image playerImage;
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get; private set; }
        private int totalPoints;//очки которые нужно собрать игроку


        public Player(Field field, string playerPath, int startX, int startY)
        {
            gameField = field;
            playerImage = Bitmap.FromFile(playerPath);
            X = startX;
            Y = startY;
            Score = 0;
        }

        public void Initialize(char[,] mapData)
        {
            gameField.map = mapData;
            totalPoints = gameField.CountPoints();
            gameField[X, Y].Value = playerImage;
        }

        public void Move(int newX, int newY)
        {
            if (!gameField.IsValidCell(newX, newY)) return;

            // обновление карты
            if (gameField.map[Y, X] == '1')
                gameField[X, Y].Value = gameField.pointImage;
            else
                gameField[X, Y].Value = gameField.floorImage;

            // позиция игрока
            X = newX;
            Y = newY;

            // счет
            if (gameField.map[Y, X] == '1')
            {
                gameField.map[Y, X] = '0';
                Score += 10;
            }

            // отрисовка
            gameField[X, Y].Value = playerImage;
        }


        public bool CheckWin()//проерка победы
        {
            return Score == totalPoints * 10;
        }
    }
    public class Ghost
    {
        private Field gameField;
        private Image ghostImage;
        public int X { get; private set; }
        public int Y { get; private set; }
        private Random rnd = new Random();

        public Ghost(Field field, string ghostPath, int startX, int startY)
        {
            gameField = field;
            ghostImage = Bitmap.FromFile(ghostPath);
            X = startX;
            Y = startY;
        }

        public void Initialize(char[,] mapData)//отрисовка
        {
            gameField.map = mapData;
            gameField[X, Y].Value = ghostImage;
        }

        public void MoveRandomly()//движение рандомно
        {
            int direction = rnd.Next(4);
            int newX = X, newY = Y;

            switch (direction)
            {
                case 0: newX--; break; // лево
                case 1: newX++; break; // право
                case 2: newY--; break; // вверх
                case 3: newY++; break; // вниз
            }

            if (!gameField.IsValidCell(newX, newY)) return;

            // обновление поля
            if (gameField.map[Y, X] == '1')
                gameField[X, Y].Value = gameField.pointImage;
            else
                gameField[X, Y].Value = gameField.floorImage;

            // движение
            X = newX;
            Y = newY;

            //отрисовка
            gameField[X, Y].Value = ghostImage;
        }
        public bool CaughtPlayer(int playerX, int playerY)//проверка на поражение игрока
        {
            return X == playerX && Y == playerY;
        }
    }
}
