using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HarisProject
{
    public class Number: Yektasad
    {
        public string convert(int n)
        {
            string str = "";

            while (n != 0)
            {
                if (n >= 1 && n < 1000)
                {
                    str = str + Yek_ta_sad(n);
                    n = 0;
                }

                if (n >= 1000 &&  n < 1000000)
                {
                    str = str + Yek_ta_sad(n / 1000);
                    str = str + " hezar";
                    n = n % 1000;
                }

                if (n >= 1000000 && n < 1000000000)
                {
                    str = str + Yek_ta_sad(n / 1000000);
                    str = str + " milion";
                    n = n % 1000000;
                }

                if (n >= 1000000000 && n < 1000000000000)
                {
                    str = str + Yek_ta_sad(n / 1000000000);
                    str = str + " miliard";
                    n = n % 1000000000;
                }



                //else if (n >= 100 && n < 1000)
                //{
                //    str = str + Yek_ta_sad(n/100);
                //    str = str + " " + "sad";
                //    n = n % 100;
                //}

                //else if (n >= 1000 && n < 10000)
                //{
                //    str = str + Yek_ta_sad(n / 1000);
                //    str = str + " " + "hezar";
                //    n = n % 1000;
                //}

                //else if (n >= 10000 && n < 100000)
                //{
                //    str = str + Yek_ta_sad(n / 1000);
                //    str = str + "hezar";
                //    n = n % 1000;
                //}

                //else if (n >= 100000 && n < 1000000)
                //{
                //    str = str + Yek_ta_sad(n / 100000);
                //    str = str + "hezar";
                //    n = n % 100000;
                //}

                //else if (n >= 1000000 && n < 10000000)
                //{
                //    str = str + Yek_ta_sad(n / 1000000);
                //    str = str + " " + "milion";
                //    n = n % 1000000;
                //}

                //else if (n >= 10000000 && n < 100000000)
                //{
                //    str = str + Yek_ta_sad(n / 1000000);
                //    str = str + " " + "milion";
                //    n = n % 1000000;
                //}

                //else if (n >= 100000000 && n < 1000000000)
                //{
                //    str = str + Yek_ta_sad(n / 100000000);
                //    str = str + " " + "milion";
                //    n = n % 100000000;
                //}
            }

            return (str);
        }

        
    }
}
