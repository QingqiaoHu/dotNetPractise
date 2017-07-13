using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXguitusaipao
{
    class Program
    {
        public static void Main(string[] args)
        {
            Running run = new Running();
            run.Run();
            Console.ReadLine();
        }
    }

    class Turtle {
        private int turtlePosition = 1;
        Random r;

        public Turtle()
        {
            r = new Random();
        }

        public int GetPosition()
        {
            int num = r.Next(10);
            switch (num)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    turtlePosition += 3;
                    break;
                case 5:
                case 6:
                case 7:
                    turtlePosition = turtlePosition - 6 > 0 ? turtlePosition - 6 : 0;
                    break;
                case 8:
                case 9:
                    turtlePosition += 1;
                    break; 
            }
            return turtlePosition;
        }
    }
    class Rabbit
    {
        private int rabbitPosition = 1;
        Random r;

        public Rabbit()
        {
            r = new Random();
        }

        public int GetPosition()
        {
            int num = r.Next(10);
            switch (num)
            {
                case 0:
                case 1:
                    break;
                case 2:
                case 3:
                    rabbitPosition += 9;
                    break;
                case 4:
                    rabbitPosition = rabbitPosition - 12 > 0 ? rabbitPosition - 12 : 0;
                    break;
                case 5:
                case 6:
                case 7:
                    rabbitPosition += 1;
                    break;
                case 8:
                case 9:
                    rabbitPosition = rabbitPosition - 2 > 0 ? rabbitPosition - 2 : 0;
                    break;               
            }
            return rabbitPosition;
        }
    }
    class Running
    {
        private Turtle T = new Turtle();
        private Rabbit R = new Rabbit();
        public void Run()
        {
            Console.WriteLine("On your mark");
            Console.WriteLine("Set");
            Console.WriteLine("Bang");
            int tPos = T.GetPosition();
            int rPos = R.GetPosition();
            while (tPos <= 70 && rPos <= 70)
            {
                Display(tPos, rPos);
                tPos = T.GetPosition();
                rPos = R.GetPosition();
                System.Threading.Thread.Sleep(1000);
            }
            if (tPos >= 70)
            {
                Console.WriteLine("T wins");
            } else
            {
                Console.WriteLine("R wins");
            }
        }

        private void Display(int tPos, int rPos)
        {
            char[] ch = new char[70];
            for (int i = 0; i < 70; i++)
            {
                if (i == tPos && rPos == i)
                {
                    ch[i - 1] = 'O';
                    ch[i] = 'U';
                    ch[i + 1] = 'C';
                    ch[i + 2] = 'H';
                } else if (i == tPos)
                {
                    ch[i] = 'T';
                } else if (i == rPos)
                {
                    ch[i] = 'R';
                } else if (i == 69)
                {
                    ch[i] = '|';
                }
            }
            String result = new string(ch);
            Console.WriteLine(result);
        }
    }
}
