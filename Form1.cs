using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toneWizzard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Drop down combo box function that determines which notes and scales to display
        /// ********Perhaps there is a "better" way to assign scales to their listed index*********
        /// </summary>
        /// <param name="sender">'Factory' supplied argument object</param>
        /// <param name="e"> 'Factory' supplied argument variable</param>

        private void comboBoxRootNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBoxRootNote.SelectedIndex)
            {

                case 0:
                    C();
                    break;

                case 1:
                    Cs();
                    break;

                case 2:
                    Db();
                    break;

                case 3:
                    D();
                    break;

                case 4:
                    Ds();
                    break;

                case 5:
                    Eb();
                    break;

                case 6:
                    E();
                    break;

                case 7:
                    F();
                    break;

                case 8:
                    Fs();
                    break;

                case 9:
                    Gb();
                    break;

                case 10:
                    G();
                    break;

                case 11:
                    Gs();
                    break;

                case 12:
                    Ab();
                    break;

                case 13:
                    A();
                    break;

                case 14:
                    As();
                    break;

                case 15:
                    Bb();
                    break;

                case 16:
                    B();
                    break;

            }
        }


        /// <summary>
        /// The Wiz is the function that brokers the scale's notes info passed-in to display to the interface
        /// </summary>
        /// <param name="w">Passed-in Scale array argument containing all note assignments</param>
        /// <param name="i">Passed-in Hajor harmonized scale argument array</param>
        /// <param name="z">Passed-in Minor scale argument array</param>

       public void Wiz(string[] w, string[] i, string[] z)
        {
            textBoxLThird.Text = w[1];
            textBoxUThird.Text = w[2];
            textBoxNHarm1.Text = w[0];
            textBoxNHarm2.Text = w[2];
            textBoxNHarm3.Text = w[3];
            textBoxRelativeMinor.Text = w[4];
            textBoxMs1.Text = i[0];
            textBoxMs2.Text = i[1];
            textBoxMs3.Text = i[2];
            textBoxMs4.Text = i[3];
            textBoxMs5.Text = i[4];
            textBoxMs6.Text = i[5];
            textBoxMs7.Text = i[6];
            textBoxMs8.Text = i[7];
            textBoxMinS1.Text = z[0];
            textBoxMinS2.Text = z[1];
            textBoxMinS3.Text = z[2];
            textBoxMinS4.Text = z[3];
            textBoxMinS5.Text = z[4];
            textBoxMinS6.Text = z[5];
            textBoxMinS7.Text = z[6];
            textBoxMinS8.Text = z[7];
        }

        
        /// <summary>
        /// Declared scale vectors section of code containing scales' information
        /// </summary>                                      ///////////////////////////////////////////
        //SOLVED!                                           //                                       //
        private void C()                                    //     Scale Functions Layout Guide      //                                     
        {                                                   //                                       //
            string[] c = new string[7];                     ///////////////////////////////////////////
            c[0] = "C";                                     // Tonic                                 //
            c[1] = "A";                                     // Lower Third                           //
            c[2] = "Em";                                    // Upper Third                           //
            c[3] = "G";                                     // Fifth                                 //
            c[4] = "Am";                                    // Relative Minor                        //
            c[5] = "C + Dm + Em + F + G + Am + Bdm + C";    // Harmonic Major Scale                  //
            string[] maSc = c[5].Split('+');                //   (I ii iii IV V vi vii[Diminished])  //
            c[6] = "C + D + Eb + F + G + Ab + Bb + C";      // Minor Scale                           //
            string[] miSc = c[6].Split('+');                ///////////////////////////////////////////

            Wiz(c, maSc, miSc);
        }
        
        private void Cs()
        {
            string[] cs = new string[7];
            cs[0] = "C#";
            cs[1] = "A#";
            cs[2] = "F";
            cs[3] = "G#";
            cs[4] = "A#m";
            cs[5] = "C# + D#m + Fm + F# + G# + A#m + Cdm + C#";
            string[] maSc = cs[5].Split('+');
            cs[6] = "C# + D# + E + F# + G# + A + B + C#";
            string[] miSc = cs[6].Split('+');

            Wiz(cs, maSc, miSc);

        }
        
        private void Db()
        {
            string[] d = new string[7];
            d[0] = "Db";
            d[1] = "Bb";
            d[2] = "F";
            d[3] = "Ab";
            d[4] = "Bbm";
            d[5] = "Db + Ebm + Fm + Gb + Ab + Bbm + Cdm + Db";
            string[] maSc = d[5].Split('+');
            d[6] = "Db + Eb + Fb + Gb + Ab + A + B + Db";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
       
        private void D()
        {
            string[] d = new string[7];
            d[0] = "D";
            d[1] = "B";
            d[2] = "F";
            d[3] = "A";
            d[4] = "Bm";
            d[5] = "D + Em + F#m + G + A + Bm + C#dm + D";
            string[] maSc = d[5].Split('+');
            d[6] = "D + E + F + G + A + Bb + C + D";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
       
        private void Ds()
        {
            string[] d = new string[7];
            d[0] = "D#";
            d[1] = "C";
            d[2] = "G";
            d[3] = "A#";
            d[4] = "Cm";
            d[5] = "D# + Fm + Gm + D# + A# + Cm + C#dm + D#";
            string[] maSc = d[5].Split('+');
            d[6] = "D# + F + F# + G# + A# + B + C# + D#";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
       
        private void Eb()
        {
            string[] d = new string[7];
            d[0] = "Eb";
            d[1] = "C";
            d[2] = "G";
            d[3] = "Bb";
            d[4] = "Cm";
            d[5] = "Eb + Fm + Gm + Ab + Bb + Cm + Ddm + Eb";
            string[] maSc = d[5].Split('+');
            d[6] = "Eb + F + Gb + Ab + Bb + B + Db + Eb";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void E()
        {
            string[] d = new string[7];
            d[0] = "E";
            d[1] = "C#";
            d[2] = "G#";
            d[3] = "B";
            d[4] = "C#m";
            d[5] = "E + F#m + G#m + A + B + C#m + D#dm + E";
            string[] maSc = d[5].Split('+');
            d[6] = "E + F# + G + A + B + C + D + E";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void F()
        {
            string[] d = new string[7];
            d[0] = "F";
            d[1] = "D";
            d[2] = "A";
            d[3] = "C";
            d[4] = "Dm";
            d[5] = "F + Gm + Am + Bb + C + Dm + Edm + F";
            string[] maSc = d[5].Split('+');
            d[6] = "F + G + Ab + Bb + C + Db + Eb + F";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void Fs()
        {
            string[] d = new string[7];
            d[0] = "F#";
            d[1] = "D#";
            d[2] = "A#";
            d[3] = "C#";
            d[4] = "D#m";
            d[5] = "F# + G#m + A#m + B + C# + D#m + Fdm + F#";
            string[] maSc = d[5].Split('+');
            d[6] = "F# + G# + A + B + C# + D + E + F#";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void Gb()
        {
            string[] d = new string[7];
            d[0] = "Gb";
            d[1] = "Eb";
            d[2] = "Bb";
            d[3] = "Db";
            d[4] = "Ebm";
            d[5] = "Gb + Abm + Bbm + B + Db + Ebm + Fdm + Gb";
            string[] maSc = d[5].Split('+');
            d[6] = "Gb + Ab + A + B + Db + D + E + Gb";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void G()
        {
            string[] d = new string[7];
            d[0] = "G";
            d[1] = "E";
            d[2] = "B";
            d[3] = "D";
            d[4] = "Em";
            d[5] = "G + Am + Bm + C + D + Em + F#dm + G";
            string[] maSc = d[5].Split('+');
            d[6] = "G + A + Bb + C + D + Eb + F + G";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
       
        private void Gs()
        {
            string[] d = new string[7];
            d[0] = "G#";
            d[1] = "F";
            d[2] = "C";
            d[3] = "D#";
            d[4] = "Fm";
            d[5] = "G# + A#m + Cm + C# + D# + Fm + Gdm + G#";
            string[] maSc = d[5].Split('+');
            d[6] = "G# + A# + B + C# + D# + E + F# + G#";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void Ab()
        {
            string[] d = new string[7];
            d[0] = "Ab";
            d[1] = "F";
            d[2] = "C";
            d[3] = "Eb";
            d[4] = "Fm";
            d[5] = "Ab + Bbm + Cm + Db + Eb + Fm + Gdm + Ab";
            string[] maSc = d[5].Split('+');
            d[6] = "Ab + Bb + Cb + Db + Eb + E + Gb + Ab";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }

           
        private void A()
        {
            string[] d = new string[7];
            d[0] = "A";
            d[1] = "F#";
            d[2] = "C#";
            d[3] = "E";
            d[4] = "F#m";
            d[5] = "A + Bm + C#m + D + E + F#m + G#dm + A";
            string[] maSc = d[5].Split('+');
            d[6] = "A + B + C + D + E + F + G + A";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void As()
        {
            string[] d = new string[7];
            d[0] = "A#";
            d[1] = "G";
            d[2] = "D";
            d[3] = "F";
            d[4] = "Gm";
            d[5] = "A# + Cm + Dm + D# + F + Gm + Adm + A#";
            string[] maSc = d[5].Split('+');
            d[6] = "A# + C + C# + D# + F + F# + B# + A#";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void Bb()
        {
            string[] d = new string[7];
            d[0] = "Bb";
            d[1] = "G";
            d[2] = "D";
            d[3] = "F";
            d[4] = "Gm";
            d[5] = "Bb + Cm + Dm + Eb + F + Gm + Adm + Bb";
            string[] maSc = d[5].Split('+');
            d[6] = "Bb + C + Db + Eb + F + Gb + Ab + Bb";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }
        
        private void B()
        {
            string[] d = new string[7];
            d[0] = "B";
            d[1] = "G#";
            d[2] = "D#";
            d[3] = "F#";
            d[4] = "G#";
            d[5] = "B + C#m + D#m + E + F# + G#m + A#dm + B";
            string[] maSc = d[5].Split('+');
            d[6] = "B + C# + D + E + F# + G + A + B";
            string[] miSc = d[6].Split('+');

            Wiz(d, maSc, miSc);

        }

       
    }
 
}
