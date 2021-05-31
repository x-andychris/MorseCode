using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCode
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToMorseCode_Click(object sender, EventArgs e)
        {
            morseCode mc = new morseCode();
            txtBox2.Text = mc.ToMorse(txtBox.Text);
        }

        private void btnFromMorseCode_Click(object sender, EventArgs e)
        {
            morseCode mc = new morseCode();
            txtBox2.Text = mc.FromMorse(txtBox.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        public void changeBackColor(string color) {
            if (color == "Red") {
                colorPanel.BackColor = Color.Red;
            }
            else if (color == "Blue") {
                colorPanel.BackColor = Color.Blue;
            }
            
        }
        private void boxDisplayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxDisplayMethod.Text == "Light") {
                //foreach (char ch in txtBox2.Text)
                //{
                //    if (ch == '.')
                //    {
                //        changeBackColor("Red");
                //        System.Threading.Thread.Sleep(1000);
                //        changeBackColor("Red");
                //    }
                //    else if (ch == '_')
                //    {
                //        changeBackColor("Blue");
                //        System.Threading.Thread.Sleep(1000);
                //    }
                //    else if (ch == '-')
                //    {
                //        System.Threading.Thread.Sleep(1500);
                //    }
                //    else if (ch == ' ')
                //    {
                //        System.Threading.Thread.Sleep(2000);
                //    }
                //    else { }
                //}
                //colorPanel.BackColor = Color.White;
            }
            else if (boxDisplayMethod.Text == "Sound") {
                morseCode mc = new morseCode();
                mc.playMorseCode(txtBox2.Text);
            }
            else if (boxDisplayMethod.Text == "") { }
        }
    }
    public class morseCode {
        static string covMorse, tempMorse;

        public string ToMorse(string phrase) 
        {
            tempMorse = "";

            foreach (char ch in phrase) { 
                if (ch == ' ') {
                    tempMorse += "|";
                } else {
                    string ch2 = ch.ToString().ToLower();
                    tempMorse += "" + changeCharToMorse(Convert.ToChar(ch2)) + " ";
                }
            }

            return tempMorse;
        }

        public string FromMorse(string phrase)
        {
            tempMorse = "";
            string temp = "";
            foreach (char ch in phrase)
            {
                if (ch == '|')
                {
                    tempMorse += " ";
                }
                else
                {
                    if (ch == ' ')
                    {
                        tempMorse += "" + changeMorseToChar(temp);
                        temp = "";
                    }
                    else {
                        temp += ""+ch;
                    }
                }
            }

            return tempMorse;
        }

        public void playMorseCode(string phrase) {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\User\Documents\Visual Studio 2012\MorseCode\MorseCode\Bleep-SoundBible.com-1927126940.wav");
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(@"C:\Users\User\Documents\Visual Studio 2012\MorseCode\MorseCode\Censor Beep-SoundBible.com-250233510.wav");
            foreach (char ch in phrase)
            {
                if (ch == '.') {
                    player.PlaySync();
                }
                else if (ch == '-')
                {
                    player2.PlaySync();
                }
                else if (ch == ' ')
                {
                    System.Threading.Thread.Sleep(700);
                }
                else if (ch == '|')
                {
                    System.Threading.Thread.Sleep(1000);
                }
                else { }
            }
        }

        public string changeCharToMorse(char character)
        {
            covMorse = "";
            switch (character)
            {
                case 'a':
                    covMorse = ".-";
                    break;
                case 'b':
                    covMorse = "-...";
                    break;
                case 'c':
                    covMorse = "-.-.";
                    break;
                case 'd':
                    covMorse = "-..";
                    break;
                case 'e':
                    covMorse = ".";
                    break;
                case 'f':
                    covMorse = "..-.";
                    break;
                case 'g':
                    covMorse = "--.";
                    break;
                case 'h':
                    covMorse = "....";
                    break;
                case 'i':
                    covMorse = "..";
                    break;
                case 'j':
                    covMorse = ".---";
                    break;
                case 'k':
                    covMorse = "-.-";
                    break;
                case 'l':
                    covMorse = ".-..";
                    break;
                case 'm':
                    covMorse = "--";
                    break;
                case 'n':
                    covMorse = "-.";
                    break;
                case 'o':
                    covMorse = "---";
                    break;
                case 'p':
                    covMorse = ".--.";
                    break;
                case 'q':
                    covMorse = "--.-";
                    break;
                case 'r':
                    covMorse = ".-.";
                    break;
                case 's':
                    covMorse = "...";
                    break;
                case 't':
                    covMorse = "-";
                    break;
                case 'u':
                    covMorse = "..-";
                    break;
                case 'v':
                    covMorse = "...-";
                    break;
                case 'w':
                    covMorse = ".--";
                    break;
                case 'x':
                    covMorse = "-..-";
                    break;
                case 'y':
                    covMorse = "-.--";
                    break;
                case 'z':
                    covMorse = "--..";
                    break;
                case '1':
                    covMorse = ".----";
                    break;
                case '2':
                    covMorse = "..---";
                    break;
                case '3':
                    covMorse = "...--";
                    break;
                case '4':
                    covMorse = "....-";
                    break;
                case '5':
                    covMorse = ".....";
                    break;
                case '6':
                    covMorse = "-....";
                    break;
                case '7':
                    covMorse = "--...";
                    break;
                case '8':
                    covMorse = "---..";
                    break;
                case '9':
                    covMorse = "----.";
                    break;
                case '0':
                    covMorse = "-----";
                    break;
                case '.':
                    covMorse = ".-.-.-";
                    break;
                case ',':
                    covMorse = "--..--";
                    break;
                case '?':
                    covMorse = "..--..";
                    break;
                case '/':
                    covMorse = "-..-.";
                    break;
                case '@':
                    covMorse = ".--.-.";
                    break;
                default:
                    covMorse = "";
                    break;
            }
            return covMorse;
        }

        public string changeMorseToChar(string character)
        {
            covMorse = "";
            switch (character)
            {
                case ".-":
                    covMorse = "a";
                    break;
                case "-...":
                    covMorse = "b";
                    break;
                case "-.-.":
                    covMorse = "c";
                    break;
                case "-..":
                    covMorse = "d";
                    break;
                case ".":
                    covMorse = "e";
                    break;
                case "..-.":
                    covMorse = "f";
                    break;
                case "--.":
                    covMorse = "g";
                    break;
                case "....":
                    covMorse = "h";
                    break;
                case "..":
                    covMorse = "i";
                    break;
                case ".---":
                    covMorse = "j";
                    break;
                case "-.-":
                    covMorse = "k";
                    break;
                case ".-..":
                    covMorse = "l";
                    break;
                case "--":
                    covMorse = "m";
                    break;
                case "-.":
                    covMorse = "n";
                    break;
                case "---":
                    covMorse = "o";
                    break;
                case ".--.":
                    covMorse = "p";
                    break;
                case "--.-":
                    covMorse = "q";
                    break;
                case ".-.":
                    covMorse = "r";
                    break;
                case "...":
                    covMorse = "s";
                    break;
                case "-":
                    covMorse = "t";
                    break;
                case "..-":
                    covMorse = "u";
                    break;
                case "...-":
                    covMorse = "v";
                    break;
                case ".--":
                    covMorse = "w";
                    break;
                case "-..-":
                    covMorse = "x";
                    break;
                case "-.--":
                    covMorse = "y";
                    break;
                case "--..":
                    covMorse = "z";
                    break;
                case ".----":
                    covMorse = "1";
                    break;
                case "..---":
                    covMorse = "2";
                    break;
                case "...--":
                    covMorse = "3";
                    break;
                case "....-":
                    covMorse = "4";
                    break;
                case ".....":
                    covMorse = "5";
                    break;
                case "-....":
                    covMorse = "6";
                    break;
                case "--...":
                    covMorse = "7";
                    break;
                case "---..":
                    covMorse = "8";
                    break;
                case "----.":
                    covMorse = "9";
                    break;
                case "-----":
                    covMorse = "0";
                    break;
                case ".-.-.-":
                    covMorse = ".";
                    break;
                case "--..--":
                    covMorse = ",";
                    break;
                case "..--..":
                    covMorse = "?";
                    break;
                case "-..-.":
                    covMorse = "/";
                    break;
                case ".--.-.":
                    covMorse = "@";
                    break;
                default:
                    covMorse = "";
                    break;
            }
            return covMorse;
        }

        string[,] morseLibrary = new string[41, 2]{ { "a", "._" }, { "b", "_..." }, { "c", "_._." }, { "d", "_.." }, 
                                              { "e", "." }, { "f", ".._." }, { "g", "__." }, { "h", "...." },
                                              { "i", ".." }, { "j", ".___" }, { "k", "_._" }, { "l", "._.." },
                                              { "m", "__" }, { "n", "_." }, { "o", "___" }, { "p", ".__." }, 
                                              { "q", "__._" }, { "r", "._." }, { "s", "..." }, { "t", "_" },
                                              { "u", ".._" }, { "v", "..._" }, { "w", ".__" }, { "x", "_.._" },
                                              { "y", "_.__" }, { "z", "__.." }, { "1", ".____" }, { "2", "..___" },
                                              { "3", "...__" }, { "4", "...._" }, { "5", "....." }, { "6", "_...." },
                                              { "7", "__..." }, { "8", "___.." }, { "9", "____." }, { "0", "_____" },
                                              { ".", "._._._" }, { ",", "__..__" }, { "?", "..__.." }, { "/", "_.._." },
                                              { "@", ".__._." }};
        public string changeCharToMorseXX(char character)
        {
            covMorse = "";
            switch (character)
            {
                case 'a':
                    covMorse = "1";
                    break;
                case 'b':
                    covMorse = "2";
                    break;
                case 'c':
                    covMorse = "3";
                    break;
                case 'd':
                    covMorse = "4";
                    break;
                case 'e':
                    covMorse = "5";
                    break;
                case 'f':
                    covMorse = "6";
                    break;
                case 'g':
                    covMorse = "7";
                    break;
                case 'h':
                    covMorse = "8";
                    break;
                case 'i':
                    covMorse = "9";
                    break;
                case 'j':
                    covMorse = "10";
                    break;
                case 'k':
                    covMorse = "11";
                    break;
                case 'l':
                    covMorse = "12";
                    break;
                case 'm':
                    covMorse = "13";
                    break;
                case 'n':
                    covMorse = "14";
                    break;
                case 'o':
                    covMorse = "15";
                    break;
                case 'p':
                    covMorse = "16";
                    break;
                case 'q':
                    covMorse = "17";
                    break;
                case 'r':
                    covMorse = "18";
                    break;
                case 's':
                    covMorse = "19";
                    break;
                case 't':
                    covMorse = "20";
                    break;
                case 'u':
                    covMorse = "21";
                    break;
                case 'v':
                    covMorse = "22";
                    break;
                case 'w':
                    covMorse = "23";
                    break;
                case 'x':
                    covMorse = "24";
                    break;
                case 'y':
                    covMorse = "25";
                    break;
                case 'z':
                    covMorse = "26";
                    break;
                case '1':
                    covMorse = "27";
                    break;
                case '2':
                    covMorse = "28";
                    break;
                case '3':
                    covMorse = "29";
                    break;
                case '4':
                    covMorse = "30";
                    break;
                case '5':
                    covMorse = "31";
                    break;
                case '6':
                    covMorse = "32";
                    break;
                case '7':
                    covMorse = "33";
                    break;
                case '8':
                    covMorse = "34";
                    break;
                case '9':
                    covMorse = "35";
                    break;
                case '0':
                    covMorse = "36";
                    break;
                case '.':
                    covMorse = "37";
                    break;
                case ',':
                    covMorse = "38";
                    break;
                case '?':
                    covMorse = "39";
                    break;
                case '/':
                    covMorse = "40";
                    break;
                case '@':
                    covMorse = "41";
                    break;
            }
            return covMorse;
        }
    }
}
