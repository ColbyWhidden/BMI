using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {

        static void Main(string[] args)
        {
            int tWeight = 50;
            float tHeight = 1.565F;
            float tBmi = tWeight / tHeight;

            int cWeight = 68;
            float cHeight = 1.55F;
            float cBmi = cWeight / cHeight;

            int bWeight = 61;
            float bHeight = 1.41F;
            float bBmi = bWeight / bHeight;

            Console.Write("Hello world!" + System.Environment.NewLine);

            // System.Environment.NewLine lets us send the next text lines to a new line ... duh

            Console.WriteLine("Tom's height is " + tHeight + " and his weight is " + tWeight + " BMI is: " + tBmi);
            Console.WriteLine("Colby's height is " + cHeight + " and his weight is " + cWeight + " BMI is: " + cBmi);
            Console.WriteLine("Blakes's height is " + bHeight + " and his weight is " + bWeight + " BMI is: " + bBmi);
            Console.ReadLine();


        }
    }
}
