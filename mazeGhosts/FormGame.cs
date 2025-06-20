using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace mazeGhosts
{
    public partial class FormGame : Form
    {
        //переменные
        Player player;
        Field field;
        DateTime time = new DateTime(0);
        Random rnd = new Random();
        int level = -1;
        List<Ghost> ghosts = new List<Ghost>();
        char[,] map;
        
    private void buttonRules_Click(object sender, EventArgs e)//правила
        {
            StreamReader reader = new StreamReader("Data/Rules.txt");
            MessageBox.Show(reader.ReadLine(), "Правила игры");
        }

        private void buttonTop_Click(object sender, EventArgs e)//рейтинг
        {
            FormTop formTop = new FormTop();
            formTop.ShowDialog();
        }

        private void TimeTimer_Tick(object sender, EventArgs e)//время
        {
            time = time.AddSeconds(1);//+1 секунда
            TimeLabel.Text = time.ToString("mm:ss");
        }

        private void timerGhost1_Tick(object sender, EventArgs e)//движение призраков
        {
            foreach (Ghost ghost in ghosts)
            {
                ghost.MoveRandomly();
                if (ghost.CaughtPlayer(player.X, player.Y))
                {
                    GameOver();
                    return;
                }
            }

            if (player.CheckWin())
            {
                WinGame();
            }
            else
            {
                labelScore.Text = "Ваш счет: " + player.Score.ToString();
            }
        }

        void NewGame()//обновление игры
        {
            time = new DateTime(0);
            TimeTimer.Enabled = true;
            timerGhost1.Enabled = true;

            map = field.LoadMapFromFile($"levels/lvl{level}.txt");
            field.CreateField(map);
            field.DrawField(map);

            player.X = 1;
            player.Y = 1;

            player.Initialize(map);
            foreach (var ghost in ghosts)
            {
                ghost.Initialize(map);
            }

            labelLvl.Text = $"Уровень {level}\nСоберите {field.count} звезд, чтобы победить.";
            labelScore.Text = "Ваш счет: 0";
        }

        private void dataGridViewMaze_KeyDown(object sender, KeyEventArgs e)//движение игрока
        {
            
            int newX = player.X;
            int newY = player.Y;

            switch (e.KeyCode)
            {
                case Keys.Down: newY++; break;
                case Keys.Up: newY--; break;
                case Keys.Left: newX--; break;
                case Keys.Right: newX++; break;
                default: return;
            }
            
            player.Move(newX, newY);
            labelScore.Text = "Ваш счет: " + player.Score.ToString();


            foreach (var ghost in ghosts)
            {
                if (ghost.CaughtPlayer(player.X, player.Y))
                {
                    GameOver();
                    return;
                }
            }

            if (player.CheckWin())
            {
                WinGame();
            }
        }
        void WinGame()
        {
            timerGhost1.Enabled = false;
            TimeTimer.Enabled = false;
            FormUser formUser = new FormUser();
            formUser.level = level;
            formUser.time = time.ToString("mm:ss");
            this.Close();
            formUser.ShowDialog();
        }

        void GameOver()
        {
            timerGhost1.Enabled = false;
            TimeTimer.Enabled = false;
            var res = MessageBox.Show("Хотите начать сначала?", "Тебя поймали(", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                this.Close();
            else
                NewGame();
        }

        public FormGame()
        {
            InitializeComponent();

        }

        public FormGame(int level)//возвращение уровня из FormLevel
        {
            this.level = level;
            InitializeComponent();

            // Инициализация игрового поля
            field = new Field("Images/wall.jpg", "Images/floor.png", "Images/point.png");
            field.Location = new Point(10, 10);
            Controls.Add(field); 

            // Загрузка карты
            char[,] map = field.LoadMapFromFile($"levels/lvl{level}.txt");
            field.CreateField(map); // Передаем загруженную карту
            field.DrawField(map);

            // Создание игрока и призраков
            player = new Player(field, "Images/player.png", 1, 1);
            player.Initialize(map);

            ghosts.Add(new Ghost(field, "Images/ghost1.png", 1, 18));
            ghosts.Add(new Ghost(field, "Images/ghost2.png", 18, 1));
            ghosts.Add(new Ghost(field, "Images/ghost3.png", 18, 18));

            labelScore.Location = new Point(850, 300);
            TimeLabel.Location = new Point(970, 350);
            TLabel.Location = new Point(850, 350);
            buttonRules.Location = new Point(850, 400);
            buttonTop.Location = new Point(850, 450);
            labelLvl.Location = new Point(850, 250);
            this.Height = 900;
            this.Width = 1300;

            field.KeyDown += dataGridViewMaze_KeyDown;

            // Начало игры
            NewGame();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            /*
            //загрузка изображений
            wall=Bitmap.FromFile("Images/wall.jpg");
            floor= Bitmap.FromFile("Images/floor.png");
            player= Bitmap.FromFile("Images/player.png");
            ghost1= Bitmap.FromFile("Images/ghost1.png");
            ghost2 = Bitmap.FromFile("Images/ghost2.png");
            ghost3 = Bitmap.FromFile("Images/ghost3.png");
            point = Bitmap.FromFile("Images/point.png");
            labelLvl.Text = "Уровень " + level.ToString() + "\n" + "Соберите " + field.count.ToString() + " звезд, чтобы победить.";
            //загрузка уровня
            field = LoadLevelFromFile($"levels/lvl{level}.txt");
            labelLvl.Text = "Уровень " + level.ToString() + "\n" + "Соберите " + count1.ToString() + " звезд, чтобы победить.";

            //создание поля
            CreateField(field);
            ShowField(field);*/

            //постановка визуала
            /*labelScore.Location = new Point(850, 300);
            TimeLabel.Location = new Point(970, 350);
            TLabel.Location = new Point(850, 350);
            buttonRules.Location = new Point(850,400);
            buttonTop.Location = new Point(850, 450);
            labelLvl.Location = new Point(850, 250);


            field = new Field("Images/wall.jpg", "Images/floor.png", "Images/point.png");
            this.Height = 900;
            this.Width = 1300;
            //создание игрока и призраков
            player = new Player("Images/wall.jpg", "Images/floor.png", "Images/point.png", "Images/player.png", 1, 1);
            ghosts = new List<Ghost>
            {
                new Ghost( "Images/wall.jpg", "Images/floor.png",
                         "Images/point.png", "Images/ghost1.png", 1, 18),
                new Ghost( "Images/wall.jpg", "Images/floor.png",
                         "Images/point.png", "Images/ghost2.png", 18, 1),
                new Ghost( "Images/wall.jpg", "Images/floor.png",
                         "Images/point.png", "Images/ghost3.png", 18, 18)
            };

            NewGame();*/
        }
    }
}
