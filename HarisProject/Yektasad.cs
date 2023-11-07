using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarisProject
{
    public class Yektasad: INumber
    {
        public string convert()
        {
            throw new NotImplementedException();
        }

        public string Yek_ta_sad(int n)
        {
            string str = "";

            while (n != 0)
            {
                if (n == 1)
                {
                    str = str + " yek";
                    n = 0;
                }

                else if (n == 2)
                {
                    str = str + " do";
                    n = 0;
                }

                else if (n == 3)
                {
                    str = str + " se";
                    n = 0;
                }

                else if (n == 4)
                {
                    str = str + " chahar";
                    n = 0;
                }

                else if (n == 5)
                {
                    str = str + " pang";
                    n = 0;
                }

                else if (n == 6)
                {
                    str = str + " shish";
                    n = 0;
                }

                else if (n == 7)
                {
                    str = str + " haft";
                    n = 0;
                }

                else if (n == 8)
                {
                    str = str + " hasht";
                    n = 0;
                }

                else if (n == 9)
                {
                    str = str + " noh";
                    n = 0;
                }

                else if (n == 10)
                {
                    str = str + " dah";
                    n = 0;
                }

                else if (n == 11)
                {
                    str = str + " yazdah";
                    n = 0;
                }

                else if (n == 12)
                {
                    str = str + " davazdah";
                    n = 0;
                }

                else if (n == 13)
                {
                    str = str + " sizdah";
                    n = 0;
                }

                else if (n == 14)
                {
                    str = str + " chahardah";
                    n = 0;
                }

                else if (n == 15)
                {
                    str = str + " panzdah";
                    n = 0;
                }

                else if (n == 16)
                {
                    str = str + " shanzdah";
                    n = 0;
                }

                else if (n == 17)
                {
                    str = str + " hefdah";
                    n = 0;
                }

                else if (n == 18)
                {
                    str = str + " hegdah";
                    n = 0;
                }

                else if (n == 19)
                {
                    str = str + " nozdah";
                    n = 0;
                }

                else if (n >= 20 && n < 30)
                {
                    str = str + " bist";
                    n = n - 20;
                    //string a = str + "o" + n;
                }

                else if (n >= 30 && n < 40)
                {
                    str = str + " si";
                    n = n - 30;
                }

                else if (n >= 40 && n < 50)
                {
                    str = str + " chehel";
                    n = n - 40;
                }

                else if (n >= 50 && n < 60)
                {
                    str = str + " panjah";
                    n = n - 50;
                }

                else if (n >= 60 && n < 70)
                {
                    str = str + " shast";
                    n = n - 60;
                }

                else if (n >= 70 && n < 80)
                {
                    str = str + " haftad";
                    n = n - 70;
                }

                else if (n >= 80 && n < 90)
                {
                    str = str + " hashtad";
                    n = n - 80;
                }

                else if (n >= 90 && n < 100)
                {
                    str = str + " navad";
                    n = n - 90;
                }

                else if (n >= 100 &&  n < 200)
                {
                    str = str + " sad";
                    n = n - 100;
                }

                else if (n >= 200 && n < 300)
                {
                    str = str + " dvist";
                    n = n - 200;
                }

                else if (n >= 300 && n < 400)
                {
                    str = str + " sisad";
                    n = n - 300;
                }

                else if (n >= 400 && n < 500)
                {
                    str = str + " chaharsad";
                    n = n - 400;
                }

                else if (n >= 500 && n < 600)
                {
                    str = str + " pansad";
                    n = n - 500;
                }

                else if (n >= 600 && n < 700)
                {
                    str = str + " shishsad";
                    n = n - 600;
                }

                else if (n >= 700 && n < 800)
                {
                    str = str + " haftsad";
                    n = n - 700;
                }

                else if (n >= 800 && n < 900)
                {
                    str = str + " hashtsad";
                    n = n - 800;
                }

                else if (n >= 900 && n < 10000)
                {
                    str = str + " nohsad";
                    n = n - 900;
                }
            }
            return str;
        }
    }
}
