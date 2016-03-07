using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Csharpstringsassessment
{
  public  class NewViolin
    {//Set fields
    public int rnd;
    public int track, count, enjoy, notenjoy;
    public  int lesson = 2;
    public string ScreechText = "";
    public bool TakeLesson = false;
       
        SoundPlayer My_Violin = new SoundPlayer(Resource1._25454__freqman__violin_tuning);
        

        public void SelectMusic()
        {//create the random generator (I think)
            Random myRandom = new Random();
            rnd = myRandom.Next(1, 6);
            track = 0;
            count = 0;
           }

        public void GetTrack(int trackid)
        {//assign all the different tracks to a single number to make it easier to use them - though the term 'trackid' is not used
            switch (trackid)
            {
                case 1:

                    trackid = 1;
                    SoundPlayer My_Violin1 = new SoundPlayer(Resource1.Track1);
                    break;

                case 2:

                    trackid = 2;
                    SoundPlayer My_Violin2 = new SoundPlayer(Resource1.Track2);
                    break;

                case 3:

                    trackid = 3;
                    SoundPlayer My_Violin3 = new SoundPlayer(Resource1.Track3);
                    break;

                case 4:

                    trackid = 4;
                    SoundPlayer My_Violin4 = new SoundPlayer(Resource1.Track4);
                    break;

                case 5:

                    trackid = 5;
                    SoundPlayer My_Violin5 = new SoundPlayer(Resource1.Track5);
                    break;

                case 6:

                    trackid = 6;
                    SoundPlayer My_Violin6 = new SoundPlayer(Resource1.Track6);
                    break;
                 }
        }

        public void Take_Lesson()
        {  //if there are available lessons (and the button is clicked) 
          if (lesson > 0)
            {
                lesson --;//take one lesson away 
                TakeLesson = true;
                }
            else // there are no lessons
            {
                TakeLesson = false;
            }
        }
    }
}

