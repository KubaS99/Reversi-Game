using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi
{
    [Serializable]
    class Si
    {
        int playerNum;

        public int PlayerNum
        {
            get { return playerNum; }
        }

        public Si(int player)
        {
            playerNum = player;
        }

        private int BestChoice(int[,] board, int x, int y)
        {
            int iter = 0;
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
                        if (board[currX, currY] == playerNum || board[currX, currY] == 0 || board[currX, currY] > 2)
                            break;

                        if (board[currX, currY] == (playerNum % 2) + 1)
                            board[currX, currY] = 8;

                        currX += dX;
                        currY += dY;
                    }
                    if (currX >= 0 && currX <= 7 && currY >= 0 && currY <= 7)
                    {
                        if (board[currX, currY] == playerNum)
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
                                iter++;
                                board[i, j] = (playerNum % 2) + 1;

                            }
                            if (!legal && board[i, j] == 8)
                            {
                                board[i, j] = (playerNum % 2) + 1;
                            }

                        }
                    }

                }
            }
            return iter;



        }
        public void Move(Plansza plansza,PictureBox pictureBox1,int waitTime)
        {
            int max = 0, tempI = 0, tempJ = 0, possibleMax = 0;
            for (int i = 0; i < plansza.Board.GetLength(0); i++)
            {
                for (int j = 0; j < plansza.Board.GetLength(0); j++)
                {
                    if (plansza.Board[i, j] == playerNum + 2 || plansza.Board[i,j] == 5)
                    {
                        possibleMax = BestChoice(plansza.Board, i, j);
                        if (possibleMax > max)
                        {
                            tempI = i; tempJ = j;
                            max = possibleMax;
                        }
                    }
                    
                }
            }
            if(max!=0)
                plansza.SiPlace(tempI, tempJ, playerNum,waitTime,pictureBox1);
        }
    }
}
