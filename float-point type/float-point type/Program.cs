using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_point_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // The varaible ( Float - double - Decimal ) المتغيرات الاساسية
            // اعلي وادني قيمة للفلوت
            float flmin = float.MinValue;
            float flmax = float.MaxValue;
            // امر الطباعة عادة يكون مثل الكود ادناة
            Console.WriteLine("\n The Float :!!! \n min value = {0}\n max value = {1}", flmin, flmax);
            // اعلي وادني قيمة للدبل
            double dlmin = double.MinValue;
            double dlmax = double.MaxValue;
            Console.WriteLine("\n The Double :!!! \n min value = {0}\n max value = {1}", dlmin, dlmax);
            // اعلي وادني قيمة للديسميول
            decimal dcmin = decimal.MinValue;
            decimal dcmax = decimal.MaxValue;
            Console.WriteLine("\n The Decimal :!!! \n min value = {0}\n max value = {1}", dcmin, dcmax);


            // مثال علي السبب الذي يجعل مبرمجي البرامج المحاسبية يفضلون استخدام الديسيمول

            float flvar = 1F / 3;
            double dlvar = 1D / 3;
            decimal dcvar = 1M / 3;

            Console.WriteLine("\n float value = {0} \n double value = {1} \n decimal value = {2}", flvar, dlvar, dcvar);    
            
            // معرفة قيمة الاحرف الجاركتر الكبيرة والصغيرة
            // character value - big & small :
            Console.WriteLine("\n The Txet ( Char - String ):-");

            int charmin = char.MinValue;
            int charmax = char.MaxValue;
            // lehg d,qp hojghtm rdlm hg[hv;jv hg;fdv ,hgwydv
            char myvar = 'A';
            int myvarvalue = 'A';
            int myvarvalue2 = 'a'; 
            Console.WriteLine("\n Char min = {0}\n Char max = {1}\n My Character = {2}\n my char (A) number is = {3}\n my small char (a) number = {4}", charmin, charmax, myvar, myvarvalue, myvarvalue2 );

            // قيم كل الحروف الكبيرة والتي كما نلاحظ تبدا بالرقم 65 وتنتهي بالرقم 90
            Console.WriteLine("\n The big Character Value :-");

            int Avalue = 'A'; int Bvalue = 'B'; int Cvalue = 'C'; int Dvalue = 'D'; int Evalue = 'E'; int Fvalue = 'F'; int Gvalue = 'G';
            int Hvalue = 'H'; int Ivalue = 'I'; int Jvalue = 'J'; int Kvalue = 'K'; int Lvalue = 'L'; int Mvalue = 'M'; int Nvalue = 'N';
            int Ovalue = 'O'; int Pvalue = 'P'; int Qvalue = 'Q'; int Rvalue = 'R'; int Svalue = 'S'; int Tvalue = 'U'; int Uvalue = 'U';
            int Vvalue = 'V'; int Wvalue = 'W'; int Xvalue = 'X'; int Yvalue = 'Y'; int Zvalue = 'Z';
            Console.WriteLine("\n A value is = {0}\n B value is = {1}\n C value is = {2}\n D value is = {3}\n E value is = {4}\n F value is = {5}\n G value is = {6}\n H value is = {7}\n I value is = {8}\n J value is = {9}\n K value is = {10}\n L value is = {11}\n M value is = {12}\n N value is = {13}\n O value is = {14}\n P value is = {15}\n Q value is = {16}\n R value is = {17}\n S value is = {18}\n T value is = {19}\n U value is = {20}\n V value is = {21}\n W value is = {22}\n X value is = {23}\n Y value is = {24}\n Z value is = {25}", Avalue, Bvalue, Cvalue, Dvalue, Evalue, Fvalue, Gvalue, Hvalue, Ivalue, Jvalue, Kvalue, Lvalue, Mvalue, Nvalue, Ovalue, Pvalue, Qvalue, Rvalue, Svalue, Tvalue, Uvalue, Vvalue, Wvalue, Xvalue, Yvalue, Zvalue  );

            // قيم كل الحروف الصغيرة والتي كما نلاحظ تبدا من الرقم 97 وتنتهي بالرقم 122
            Console.WriteLine("\n The Small Character Value :-");

            int avalue = 'a'; int bvalue = 'b'; int cvalue = 'c'; int dvalue = 'd'; int evalue = 'e'; int fvalue = 'f'; int gvalue = 'g';
            int hvalue = 'h'; int ivalue = 'i'; int jvalue = 'j'; int kvalue = 'k'; int lvalue = 'l'; int mvalue = 'm'; int nvalue = 'n';
            int ovalue = 'o'; int pvalue = 'p'; int qvalue = 'q'; int rvalue = 'r'; int svalue = 's'; int tvalue = 't'; int uvalue = 'u';
            int vvalue = 'v'; int wvalue = 'w'; int xvalue = 'x'; int yvalue = 'y'; int zvalue = 'z';
            Console.WriteLine("\n a value is = {0}\n b value is = {1}\n c value is = {2}\n d value is = {3}\n e value is = {4}\n f value is = {5}\n g value is = {6}\n h value is = {7}\n i value is = {8}\n j value is = {9}\n k value is = {10}\n l value is = {11}\n m value is = {12}\n n value is = {13}\n o value is = {14}\n p value is = {15}\n q value is = {16}\n r value is = {17}\n s value is = {18}\n t value is = {19}\n u value is = {20}\n v value is = {21}\n w value is = {22}\n x value is = {23}\n y value is = {24}\n z value is = {25}", avalue, bvalue, cvalue, dvalue, evalue, fvalue, gvalue, hvalue, ivalue, jvalue, kvalue, lvalue, mvalue, nvalue, ovalue, pvalue, qvalue, rvalue, svalue, tvalue, uvalue, vvalue, wvalue, xvalue, yvalue, zvalue);

            // متغير السترينج او السلسلة 
            // the String Varaible codes :-
            string mystring = "Hi this is my string number one (^_o)";
            Console.WriteLine("\n The massage = {0}", mystring);

            // متغير البوليان وهو متغير يستخدم في تحديد القيمة صح او خطأ
            // Boolean varaible :-
            bool mybool = true;
            bool mybool2 = false;
            Console.WriteLine("\n my boolean value 1 is = {0}\n my boolean value 2 is = {1}", mybool , mybool2 );

            Console.ReadKey();

        }
    }
}
