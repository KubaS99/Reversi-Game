using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi
{
    [Serializable]
    public partial class Form1 : Form
    {
        Gra game;
        SoundBox soundBox = new SoundBox();
        bool sound = true;

        public Form1()
        {
            InitializeComponent();
            soundBox.themePlayer.Play();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            game.Paint(e.Graphics, pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            game.Step(coordinates, blackLabel, whiteLabel, pictureBox1,turnLabel,endLabel,blockPictureBox);
            if(game.gameEnded)
            {
                saveButton.Visible = false;
                loadButton.Visible = false;
                turnLabel.Text = "Game over!";
            }
           

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(easyRadio.Checked==true)
                game = new Gra(twoPlayerRadio.Checked,1,soundBox,sound);
            else if(mediumRadio.Checked==true)
                game = new Gra(twoPlayerRadio.Checked, 2,soundBox,sound);
            else
                game = new Gra(twoPlayerRadio.Checked, 3,soundBox,sound);

            if (compRadio.Checked == true)
                turnLabel.Text = "Player's turn";
            else
                turnLabel.Text = "Black's turn";
            soundBox.themePlayer.Stop();
            pictureBox2.Visible = false;
            titleLabel.Visible = false;
            gameModeBox.Visible = false;
            difficultyBox.Visible = false;
            playButton.Visible = false;
            exitButton.Visible = false;
            pictureBox1.Visible = true;
            saveButton.Visible = true;
            loadButton.Visible = true;
        }



        private void linkLabel1_Click(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Reversi");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void soundPictureBox_Click(object sender, EventArgs e)
        {
            sound = false;
            noSoundPictureBox.Visible = true;
            try
            {
                game.SoundSetter(sound);
            }
            catch
            {

            }
            soundPictureBox.Visible = false;
            soundBox.themePlayer.Stop();
        }

        private void noSpeakerPictureBox_Click(object sender, EventArgs e)
        {
            sound = true;
            noSoundPictureBox.Visible = false;
            soundPictureBox.Visible = true;
            try
            {
                game.SoundSetter(sound);
            }
            catch
            {

            }
            if(difficultyBox.Visible==true)
                soundBox.themePlayer.Play();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            soundBox.themePlayer.Play();
            pictureBox2.Visible = true;
            titleLabel.Visible = true;
            gameModeBox.Visible = true;
            difficultyBox.Visible = true;
            playButton.Visible = true;
            exitButton.Visible = true;
            endLabel.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult r = saveFileDialog1.ShowDialog();
            if(r==DialogResult.OK)
            {
                // game.SaveGame(saveFileDialog1.FileName);
                GameSave(saveFileDialog1.FileName);
            }
            turnLabel.Text = "Game saved!";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if(r==DialogResult.OK)
            {
                // game.LoadGame(openFileDialog1.FileName);
                GameLoad(openFileDialog1.FileName);
            }
            game.SoundBoxSetter(soundBox);
            if(game.sound)
            {
                noSoundPictureBox.Visible = false;
                soundPictureBox.Visible = true;
            }
            else
            {
                noSoundPictureBox.Visible = true;
                soundPictureBox.Visible = false;
            }
            game.LabelsLoad(blackLabel, whiteLabel, turnLabel);
            pictureBox1.Refresh();
        }
        private void GameSave(string fileName)
        {
           
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, game);
           
            stream.Close();
        }
        private void GameLoad(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();     
                game = (Gra)bFormatter.Deserialize(stream);
                
                stream.Close();
            }
            catch
            {
                MessageBox.Show("Nieprawidłowy plik zapisu!");
            }
        }
    }

}
