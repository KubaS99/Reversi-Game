using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Reversi
{
    [Serializable]
    class Plansza
    {
        int boardWidth = 8, boardHeigth = 8;
        int whiteScore = 0, blackScore = 0;
        private int[,] board;
        int gameMode=0;
        bool duel;
        public bool sound = true;
        public SoundBox soundBox;

        public int[,] Board
        {
            get { return board; }
        }
        public Plansza(bool test)
        {

            board = new int[boardWidth, boardHeigth];
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeigth; j++)
                {
                    board[i, j] = 0;
                }
            }
            board[3, 3] = 1;
            board[4, 4] = 1;
            board[3, 4] = 2;
            board[3, 5] = 2;
            board[4, 3] = 2;

        }
        public Plansza(int difficulty, bool isDuel, SoundBox sB, bool s)
        {
            sound = s;
            soundBox = sB;
            board = new int[boardWidth, boardHeigth];
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeigth; j++)
                {
                    board[i, j] = 0;
                }
            }
            board[3, 3] = 1;
            board[4, 4] = 1;
            board[3, 4] = 2;
            board[4, 3] = 2;

            gameMode = difficulty;
            duel = isDuel;
        }
        public void Print(Graphics g, int gWidth, int gHeigth,bool token)
        {
            int squareWidth = gWidth / boardWidth;
            int squareHeigth = gHeigth / boardHeigth;
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeigth; j++)
                {
                    g.FillRectangle(new SolidBrush(Color.Green), squareWidth * i + 1, squareHeigth * j + 1, squareWidth - 1, squareHeigth - 1);
                    if (board[i, j] == 3)
                    {
                        if(gameMode ==1 || (gameMode==2 && token == false))
                        g.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Blue)), squareWidth * i + 1, squareHeigth * j + 1, squareWidth - 1, squareHeigth - 1);

                    }
                    if (board[i, j] == 4)
                    {
                        if(gameMode == 1 || (gameMode == 2 && token == true))
                        g.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Red)), squareWidth * i + 1, squareHeigth * j + 1, squareWidth - 1, squareHeigth - 1);

                    }
                    if (board[i, j] == 5 && gameMode < 3)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Purple)), squareWidth * i + 1, squareHeigth * j + 1, squareWidth - 1, squareHeigth - 1);

                    }
                    if (board[i, j] == 1)
                    {
                        //g.FillEllipse(new SolidBrush(Color.White), squareWidth * i + (squareWidth / 8), (squareHeigth * j) + (squareHeigth / 8), squareWidth / 2, squareHeigth / 2);
                        g.FillEllipse(new SolidBrush(Color.White), squareWidth * i + (squareWidth * (float)0.1), (squareHeigth * j) + (squareHeigth * (float)0.1), squareWidth - (squareWidth * (float)0.2), squareHeigth - (squareHeigth * (float)0.2));
                        g.DrawEllipse(new Pen(Color.Black), squareWidth * i + (squareWidth * (float)0.1), (squareHeigth * j) + (squareHeigth * (float)0.1), squareWidth - (squareWidth * (float)0.2), squareHeigth - (squareHeigth * (float)0.2));
                        g.DrawEllipse(new Pen(Color.Black), squareWidth * i + (squareWidth * (float)0.2), (squareHeigth * j) + (squareHeigth * (float)0.2), squareWidth - (squareWidth * (float)0.4), squareHeigth - (squareHeigth * (float)0.4));
                        g.DrawEllipse(new Pen(Color.Black), squareWidth * i + (squareWidth * (float)0.3), (squareHeigth * j) + (squareHeigth * (float)0.3), squareWidth - (squareWidth * (float)0.6), squareHeigth - (squareHeigth * (float)0.6));
                        g.DrawEllipse(new Pen(Color.Black), squareWidth * i + (squareWidth * (float)0.4), (squareHeigth * j) + (squareHeigth * (float)0.4), squareWidth - (squareWidth * (float)0.8), squareHeigth - (squareHeigth * (float)0.8));
                    }
                    if (board[i, j] == 2)
                    {
                        //g.FillEllipse(new SolidBrush(Color.Black), squareWidth * i + (squareWidth / 8), (squareHeigth * j) + (squareHeigth / 8), squareWidth / 2, squareHeigth / 2);
                        g.FillEllipse(new SolidBrush(Color.Black), squareWidth * i + (squareWidth * (float)0.1), (squareHeigth * j) + (squareHeigth * (float)0.1), squareWidth - (squareWidth * (float)0.2), squareHeigth - (squareHeigth * (float)0.2));
                        g.DrawEllipse(new Pen(Color.Gray), squareWidth * i + (squareWidth * (float)0.1), (squareHeigth * j) + (squareHeigth * (float)0.1), squareWidth - (squareWidth * (float)0.2), squareHeigth - (squareHeigth * (float)0.2));
                        g.DrawEllipse(new Pen(Color.Gray), squareWidth * i + (squareWidth * (float)0.2), (squareHeigth * j) + (squareHeigth * (float)0.2), squareWidth - (squareWidth * (float)0.4), squareHeigth - (squareHeigth * (float)0.4));
                        g.DrawEllipse(new Pen(Color.Gray), squareWidth * i + (squareWidth * (float)0.3), (squareHeigth * j) + (squareHeigth * (float)0.3), squareWidth - (squareWidth * (float)0.6), squareHeigth - (squareHeigth * (float)0.6));
                        g.DrawEllipse(new Pen(Color.Gray), squareWidth * i + (squareWidth * (float)0.4), (squareHeigth * j) + (squareHeigth * (float)0.4), squareWidth - (squareWidth * (float)0.8), squareHeigth - (squareHeigth * (float)0.8));
                    }

                }
            }
        }
        public bool Place(Point coordinates, int player, int waitTime, PictureBox pictureBox1)
        {
            int x = coordinates.X;
            int y = coordinates.Y;
            x /= (pictureBox1.Width/8); y /= (pictureBox1.Height/8);
            if (board[x, y] == player + 2 || board[x,y] == 5)
            {
                if(sound)
                    soundBox.placePlayer.Play();
                board[x, y] = player;
                pictureBox1.Refresh();
                Thread.Sleep(waitTime);
                if(sound)
                    soundBox.reversePlayer.Play();
                Reverse(player, x, y);
                return true;
            }
            return false;

        }
        public void SiPlace(int x, int y, int player, int waitTime,PictureBox pictureBox1)
        {
            if(sound)
                soundBox.placePlayer.Play();
            board[x, y] = player;
            pictureBox1.Refresh();
            Thread.Sleep(waitTime);
            if(sound)
                soundBox.reversePlayer.Play();
            Reverse(player, x, y);
        }
        public int Scores(Label black, Label white)
        {
            whiteScore = 0; blackScore = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                        whiteScore++;
                    if (board[i, j] == 2)
                        blackScore++;
                }
            }
            black.Text = "Black: " + blackScore;
            white.Text = "White: " + whiteScore;
            black.Refresh();white.Refresh();
            if (whiteScore + blackScore == 64)
            {
                if (whiteScore > blackScore)
                    return 1;
                else if (blackScore > whiteScore)
                    return 2;
                else
                    return 3;
            }
            return 0;
        }
        private void Reverse(int player, int x, int y)
        {
            bool legal;
            for (int dX = -1; dX < 2; ++dX)
            {
                for (int dY = -1; dY < 2; ++dY)
                {
                    int currX = x + dX;
                    int currY = y + dY;
                    legal = false;
                    if (dX == 0 && dY == 0)
                        continue;

                    while (currX >= 0 && currX <= 7 && currY >= 0 && currY <= 7)
                    {
                        if (board[currX, currY] == player || board[currX, currY] == 0 || board[currX, currY] > 2)
                            break;

                        if (board[currX, currY] == (player % 2) + 1)
                            board[currX, currY] = 8;

                        currX += dX;
                        currY += dY;
                    }
                    if (currX >= 0 && currX <= 7 && currY >= 0 && currY <= 7)
                    {
                        if (board[currX, currY] == player)
                        {
                            legal = true;
                        }
                    }

                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            if (legal && board[i, j] == 8)
                            {
                                board[i, j] = player;
                            }
                            if (!legal && board[i, j] == 8)
                            {
                                board[i, j] = (player % 2) + 1;
                            }

                        }
                    }

                }
            }


        }
        private bool MovePossible(int player, int x, int y)
        {
            if (board[x, y] != 0)
                return false;
            bool enemyPassed;
            for (int dX = -1; dX < 2; ++dX)
            {
                for (int dY = -1; dY < 2; ++dY)
                {
                    int currX = x + dX;
                    int currY = y + dY;
                    enemyPassed = false;
                    if (dX == 0 && dY == 0)
                        continue;

                    while (currX >= 0 && currX <= 7 && currY >= 0 && currY <= 7)
                    {
                        if (board[currX, currY] == player || board[currX, currY] == 0 || board[currX, currY] > 2)
                            break;

                        if (board[currX, currY] == (player % 2) + 1)
                        {
                            enemyPassed = true;

                        }
                        currX += dX;
                        currY += dY;
                    }
                    if (currX >= 0 && currX <= 7 && currY >= 0 && currY <= 7)
                    {
                        if (enemyPassed == true && board[currX, currY] == player)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void Analyze()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] > 2)
                        board[i, j] = 0;
                }
            }
            bool move1; bool move2;
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeigth; j++)
                {
                    move1 = MovePossible(1, i, j);
                    move2 = MovePossible(2, i, j);
                    if (move1)
                        board[i, j] = 3;
                    if (move2)
                        board[i, j] = 4;
                    if (move1 && move2)
                        board[i, j] = 5;

                }
            }

        }
        public bool MoveAvailable(int player)
        {
            for(int i=0;i<boardWidth;i++)
            {
                for(int j=0; j<boardHeigth;j++)
                {
                    if (board[i, j] == player + 2 || board[i, j] == 5)
                        return true;
                }
            }
            return false;
        }
    }
}
