using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace Reversi
{
    [Serializable]
    class Gra
    {
        int waitTime = 1000;
        Plansza plansza;
        Si comp;
        int player = 0;
        int player2 = 0;
        bool token = true;
        bool siPlays;
        public bool gameEnded = false;
        public bool sound = true;
        SoundBox soundBox;
        int winner = 0;
        public Gra(bool duel, int difficulty, SoundBox sB, bool s)
        {
            sound = s;
            soundBox = sB;
            player = 2;
            siPlays = !duel;
            player2 = 1;
            plansza = new Plansza(difficulty, duel, soundBox, sound);
            comp = new Si(1);           
            plansza.Analyze();
         
        }
        
        public void Step(Point coordinates, Label black, Label white, PictureBox pictureBox1, Label turnLabel, Label endLabel,PictureBox blockPictureBox)
        {
            if (siPlays)
            {
                if (plansza.Place(coordinates, player, waitTime, pictureBox1))
                {
                    winner = plansza.Scores(black, white);
                    if (winner > 0)
                        GameEnd(turnLabel,endLabel,soundBox,pictureBox1);
                    plansza.Analyze();
                    pictureBox1.Refresh();
                    if (!plansza.MoveAvailable(1) && !plansza.MoveAvailable(2))
                        BlockGameEnded(turnLabel,endLabel,soundBox,pictureBox1);
                    if (plansza.MoveAvailable(1))
                    {
                        turnLabel.Text = "AI turn";
                        turnLabel.Refresh();

                        Thread.Sleep(waitTime);
                        comp.Move(plansza, pictureBox1, waitTime);
                        winner = plansza.Scores(black, white);
                        if (winner > 0)
                            GameEnd(turnLabel,endLabel,soundBox,pictureBox1);
                        plansza.Analyze();
                        pictureBox1.Refresh();
                        while (plansza.MoveAvailable(2) != true && plansza.MoveAvailable(1) == true)
                        {
                            turnLabel.Text = "Player blocked";
                            turnLabel.Refresh();

                            Thread.Sleep(waitTime);
                            comp.Move(plansza, pictureBox1, waitTime);
                            winner = plansza.Scores(black, white);
                            if (winner > 0)
                                GameEnd(turnLabel,endLabel,soundBox,pictureBox1);
                            plansza.Analyze();
                            pictureBox1.Refresh();
                        }

                    }
                    else
                        turnLabel.Text = "AI blocked";
                    turnLabel.Text = "Player's turn";
                }
                else
                {
                    if (sound)
                        soundBox.errorPlayer.Play();
                    blockPictureBox.Visible = true;
                    blockPictureBox.Refresh();
                    Thread.Sleep(waitTime/2);
                    blockPictureBox.Visible=false;
                }
                    
            }
            else
            {
                if (token)
                {
                    if (plansza.Place(coordinates, player, waitTime, pictureBox1))
                    {
                        plansza.Analyze();
                        pictureBox1.Refresh();
                        winner = plansza.Scores(black, white);
                        if (winner > 0)
                            GameEnd(turnLabel,endLabel,soundBox,pictureBox1);
                        if (!plansza.MoveAvailable(1) && !plansza.MoveAvailable(2))
                            BlockGameEnded(turnLabel, endLabel, soundBox, pictureBox1);
                        if (plansza.MoveAvailable(1))
                        {
                            turnLabel.Text = "White's turn";
                            token = !token;
                        }
                        else
                            turnLabel.Text = "White blocked";
                    }
                    else
                    {
                        if (sound)
                            soundBox.errorPlayer.Play();
                        blockPictureBox.Visible = true;
                        blockPictureBox.Refresh();
                        Thread.Sleep(waitTime/2);
                        blockPictureBox.Visible = false;
                    }
                    
                }
                else
                {
                    if (plansza.Place(coordinates, player2, waitTime, pictureBox1))
                    {
                        plansza.Analyze();
                        pictureBox1.Refresh();
                        winner = plansza.Scores(black, white);
                        if (winner > 0)
                            GameEnd(turnLabel, endLabel,soundBox,pictureBox1);
                        if (!plansza.MoveAvailable(1) && !plansza.MoveAvailable(2))
                            BlockGameEnded(turnLabel, endLabel, soundBox, pictureBox1);
                        if (plansza.MoveAvailable(2))
                        {
                            turnLabel.Text = "Black's turn";
                            token = !token;
                        }
                        else
                            turnLabel.Text = "Black blocked";
                        
                        
                    }
                    else
                    {
                        if(sound)
                            soundBox.errorPlayer.Play();
                        blockPictureBox.Visible = true;
                        blockPictureBox.Refresh();
                        Thread.Sleep(waitTime/2);
                        blockPictureBox.Visible = false;
                    }
                        
                }
            }
            plansza.Analyze();
            pictureBox1.Refresh();

        }

        public void Paint(Graphics g, int gWidth, int gHeight)
        {
            plansza.Print(g, gWidth, gHeight, token);
        }

        public void SoundSetter(bool s)
        {
            sound = s;
            plansza.sound = s;
        }
        private void GameEnd(Label turnLabel, Label endLabel,SoundBox soundBox,PictureBox pictureBox1)
        {
            pictureBox1.Visible = false;
            endLabel.Visible = true;
            turnLabel.Text = "Game over";
            gameEnded = true;
            if(siPlays)
            {
                if(winner==2)
                {
                    endLabel.Text = "You win!";
                    if (sound)
                        soundBox.winnerPlayer.Play();
                }
                else if(winner == 1)
                {
                    endLabel.Text = "You lose!";
                    if (sound)
                        soundBox.loserPlayer.Play();
                }
                else
                {
                    endLabel.Text = "Draw!";
                    if (sound)
                        soundBox.errorPlayer.Play();

                }
            }
            else
            {
                if(winner==2)
                {
                    endLabel.Text = "Black wins!";
                    if (sound)
                        soundBox.winnerPlayer.Play();
                }
                else if(winner==1)
                {
                    endLabel.Text = "White wins!";
                    if (sound)
                        soundBox.winnerPlayer.Play();
                }
                else
                {
                    endLabel.Text = "Draw!";
                    if (sound)
                        soundBox.errorPlayer.Play();
                }
            }
        }
        
        public void SoundBoxSetter(SoundBox sb)
        {
            soundBox = sb;
            plansza.soundBox = sb;           
        }
        public void LabelsLoad(Label black, Label white, Label turn)
        {
            turn.Text = "Game loaded!";
            plansza.Scores(black, white);
        }
        private void BlockGameEnded(Label turnLabel, Label endLabel, SoundBox soundBox, PictureBox pictureBox1)
        {
            gameEnded = true;
            int temp1 = 0, temp2 = 0;
            for(int i=0;i<plansza.Board.GetLength(0);i++)
            {
                for(int j=0;j<plansza.Board.GetLength(1);j++)
                {
                    if (plansza.Board[i, j] == 1)
                        temp1++;
                    if (plansza.Board[i, j] == 2)
                        temp2++;
                }
            }
            if (temp1 > temp2)
                winner = 1;
            else if (temp2 > temp1)
                winner = 2;
            else
                winner = 3;
            GameEnd(turnLabel, endLabel, soundBox, pictureBox1);
        }
    }
}
