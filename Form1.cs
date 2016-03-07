using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Csharpstringsassessment
{
    public partial class Form1 : Form
    {//All the soundplayer tracks have to be here so that they load in enough time to play at the appropriate time
        private NewViolin MyNewViolin = new NewViolin();
        SoundPlayer My_ViolinTuning = new SoundPlayer(Resource1._25454__freqman__violin_tuning);
        SoundPlayer My_Violin1 = new SoundPlayer(Resource1.Track1);
        SoundPlayer My_Violin2 = new SoundPlayer(Resource1.Track2);
        SoundPlayer My_Violin3 = new SoundPlayer(Resource1.Track3);
        SoundPlayer My_Violin4 = new SoundPlayer(Resource1.Track4);
        SoundPlayer My_Violin5 = new SoundPlayer(Resource1.Track5);
        SoundPlayer My_Violin6 = new SoundPlayer(Resource1.Track6);
        SoundPlayer My_ViolinScreech = new SoundPlayer(Resource1.Screech);

        public Form1()
        {
            InitializeComponent();
          // MyNewViolin.NewViolinInstructions();
          //not needed as I changed from a message box (the text for which was in the New Violin class but which I have deleted) to a label
        }
         
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        //Loaded to try using videos
        }
        //and so we begin.  Each button enables and disables different buttons. picture boxes, labels and textboxes as well as playing different music clips.  'Tune' = 'Load'
        private void btnTune_Click(object sender, EventArgs e)
        {
            My_ViolinTuning.Play();
            tmrSoundStop.Enabled = true;
            pbCharlie.Enabled = true;
            btnReset.Visible = false;
            lblInstructions.Visible = false;
        }
        //'Select' = 'Spin' and calls the method from the NewViolin class.  
    private void btnSelect_Click(object sender, EventArgs e)
        {
           MyNewViolin.SelectMusic();
            tbxCharlie.Text = "Do you want to send Charlie to a lesson?  If so, press the 'Take Lesson' button. When you have decided, click 'Play'.";
        btnTune.Visible = false;
        btnPlay.Visible = true;
        btnLesson.Visible = true;
        }
        //'Play' = 'Fire'
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayScreech();
        }
        //We wrote this method for unit testing but so far I haven't managed to get it to work!
        public void PlayScreech()
        {//once the select button has been used, the tracks are enabled - as is the gif file.  Once all tracks have played, the play button disappears.
        btnSelect.Visible = false;
            pbCharlie.Enabled = true;
            //count through the different tracks
            MyNewViolin.count ++;
         if (MyNewViolin.count <= 5)
            {
               btnPlay.Visible = true;
            }
            else
            {
               btnPlay.Visible = false;
            }
         //To show on the title bar which number the random is to make it easier to try buttons.
            //this.Text = MyNewViolin.count.ToString() + " " +
            //            MyNewViolin.rnd.ToString();

            GetTrack(MyNewViolin.count);
            //The random feature comes into play and if it matches the number being played and a lesson hasn't been taken then all sorts of things happen and the game is over
             if ((MyNewViolin.count == MyNewViolin.rnd) && (MyNewViolin.TakeLesson == false))
            { 
                My_ViolinScreech.Play();
                tbxFinish.Visible = true;
              MyNewViolin.ScreechText = "Ouch, totally deafened.  No more music. Watch silent movies instead!";

                lblCharlie.Text = MyNewViolin.ScreechText;
                lblCharlie.Visible = true;
                btnPlay.Visible = false;
                btnTune.Visible = false;
                btnSelect.Visible = false;
                btnLesson.Visible = false;
                tbxCharlie.Text = " ";
                tbxCharlie.Visible = false;
                lblEnjoy.Visible = true;
                //Add in the scoring component.  Add a counter to the enjoy/not enjoy labels
                MyNewViolin.notenjoy++;
                lblNotEnjoy.Text = MyNewViolin.notenjoy.ToString();
                lblNotEnjoy.Visible = true;
                LblWin.Visible = true;
                lblLose.Visible = true;
                btnLessonLeft.Visible = false;
                tmrScreech.Enabled = true;
            }
             //resets the lesson for the next track
            MyNewViolin.TakeLesson = false;
        }
        //The following are the methods for all the different tracks and their timers with various different texts, picture boxes, text messages etc.
        private void tmrScreech_Tick(object sender, EventArgs e)
        {
            My_ViolinScreech.Stop();
            pbCharlie.Enabled = false;
            pbCharlie.Visible = false;
            PbGoodbye.Visible = true;
          lblCharlie.Text = "Goodbye Charlie";
            btnReset.Visible = true;
            tmrScreech.Enabled = false;
            tbxCharlie.Text = " ";
        }
        private void tmrSoundStop_Tick(object sender, EventArgs e)
        {
            My_ViolinTuning.Stop();
            pbCharlie.Enabled = false;
           tbxCharlie.Text = "Charlie has tuned up and is ready to play.  To listen to his playing press the 'Select Music' button";
            tmrSoundStop.Enabled = false;
            btnSelect.Visible = true;
            //btnSelect.Enabled = true;
        }
        
        public void GetTrack(int trackid)
        {
            switch (trackid)

            {
                case 1:
                    My_Violin1.Play();
                    tmrViolin1.Enabled = true;
                    pbCharlie.Enabled = true;
             break;
                case 2:
                    My_Violin2.Play();
                    tmrViolin2.Enabled = true;
                    break;
                case 3:
                    My_Violin3.Play();
                    tmrViolin3.Enabled = true;
                    break;
                case 4:
                    My_Violin4.Play();
                    tmrViolin4.Enabled = true;
                    break;
                case 5:
                    My_Violin5.Play();
                    tmrViolin5.Enabled = true;
                    break;
                case 6:
                    My_Violin6.Play();
                    tmrViolin6.Enabled = true;
                    break;
            }
        }
        private void tmrViolin1_Tick(object sender, EventArgs e)
        {
            My_Violin1.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "Try another piece.";
            tmrViolin1.Enabled = false;
        }
        private void tmrViolin2_Tick(object sender, EventArgs e)
        {
            My_Violin2.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "Try another tune.";
            tmrViolin2.Enabled = false;
        }
        private void tmrViolin3_Tick(object sender, EventArgs e)
        {
            My_Violin3.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "Try another.";
            tmrViolin3.Enabled = false;
        }
        private void tmrViolin4_Tick(object sender, EventArgs e)
        {
            My_Violin4.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "And another.";
            tmrViolin4.Enabled = false;
        }

        private void tmrViolin5_Tick(object sender, EventArgs e)
        {
            My_Violin5.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "One more!";
            tmrViolin5.Enabled = false;
        }

        private void tmrViolin6_Tick(object sender, EventArgs e)
        {//Final message and removal of buttons except to play again
            My_Violin6.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "Well done Charlie, a 'classy' practice session. Thanks.";
            btnLesson.Visible = false;
            btnLessonLeft.Visible = false;
            btnReset.Visible = true;
           tmrViolin6.Enabled = false; pbCharlie.Enabled = false;
            pbCharlie.Visible = false;
            PbGoodbye.Visible = true;
            lblEnjoy.Visible = true;
            MyNewViolin.enjoy ++;
            lblEnjoy.Text = MyNewViolin.enjoy.ToString();
            lblNotEnjoy.Visible = true;
            LblWin.Visible = true;
            lblLose.Visible = true;
        }
        private void btnLesson_Click(object sender, EventArgs e)
        //Initially to stop the button being available so that no more lessons could be taken but that problem got sorted. I liked the change of buttons anyway.
        {
            MyNewViolin.Take_Lesson();
            btnLessonLeft.Visible = true;
            btnLesson.Visible = false;
        }

        private void btnLessonLeft_Click(object sender, EventArgs e)
        {
            MyNewViolin.Take_Lesson();
            btnLessonLeft.Visible = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {//Resets everything back to the beginning 

            btnTune.Visible = true;
            PbGoodbye.Visible = false;
            pbCharlie.Visible = true;
            lblCharlie.Visible = false;
            My_ViolinTuning.Stop();
            pbCharlie.Enabled = false;
            tbxCharlie.Text = "Charlie has tuned up and is ready to play.  To listen to his playing press the 'Select Music' button";
            tmrSoundStop.Enabled = false;
            pbCharlie.Enabled = false;
            btnReset.Visible = false;
            tbxCharlie.Text = " ";
            tbxCharlie.Visible = true;
            lblEnjoy.Visible = false;
            lblNotEnjoy.Visible = false;
        }
    }
}




