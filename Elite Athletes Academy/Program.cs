using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Elite_Athletes_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            string RaceType;
            int NumLanes;

            List<double> FourLanes = new List<double>();
            FourLanes.Add (0);
            FourLanes.Add(0);
            FourLanes.Add(0);
            FourLanes.Add(0);

            List<double> FiveLanes = new List<double>();
            FiveLanes.Add(0);
            FiveLanes.Add(0);
            FiveLanes.Add(0);
            FiveLanes.Add(0);
            FiveLanes.Add(0);

            List<double> SixLanes = new List<double>();
            SixLanes.Add(0);
            SixLanes.Add(0);
            SixLanes.Add(0);
            SixLanes.Add(0);
            SixLanes.Add(0);
            SixLanes.Add(0);

            List<double> SevenLanes = new List<double>();
            SevenLanes.Add(0);
            SevenLanes.Add(0);
            SevenLanes.Add(0);
            SevenLanes.Add(0);
            SevenLanes.Add(0);
            SevenLanes.Add(0);
            SevenLanes.Add(0);

            List<double> EightLanes = new List<double>();
            EightLanes.Add(0);
            EightLanes.Add(0);
            EightLanes.Add(0);
            EightLanes.Add(0);
            EightLanes.Add(0);
            EightLanes.Add(0);
            EightLanes.Add(0);
            EightLanes.Add(0);

            Console.WriteLine("# 100 Metre Elite Athletes Times #");

            Console.WriteLine("Was this a Male or Female Race? :");
            RaceType = Console.ReadLine().ToLower();
            while (RaceType != "male" || RaceType != "female")
            {
                Console.WriteLine("Please Re-Enter :");
                RaceType = Console.ReadLine().ToLower();
                
                if (RaceType == "male")
                {
                    break;
                }
                if (RaceType == "female")
                {
                    break;

                }
            }

            Console.WriteLine("How Many Lanes in the Race (Min: 4, Max:8) :");
            NumLanes = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (NumLanes < 4)
                {
                    Console.WriteLine("Invalid Lane Amount. Please Re-Enter:");
                    NumLanes = Convert.ToInt32(Console.ReadLine());
                }
                else if (NumLanes > 8)
                {
                    Console.WriteLine("Invalid Lane Amount. Please Re-Enter:");
                    NumLanes = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Please Input the Lane Times for Each Lane to Two D.P (Example: 1.00)");
            
            
                
            if (NumLanes == 4)
            {
                Console.WriteLine("Lane 1");
                FourLanes[0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 2");
                FourLanes[1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 3");
                FourLanes[2] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 4");
                FourLanes[3] = Convert.ToDouble(Console.ReadLine());

                for (int x = 0; x < NumLanes; x++)
                {
                    Console.WriteLine("Lane " +  (x+1) + " Time: " + FourLanes[x]);
                    if (RaceType == "male" && FourLanes[x] < 9.58)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's World Record Time");
                    }
                    else if (RaceType == "male" && FourLanes[x] < 9.86)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's European Record Time");
                    }
                    else if (RaceType == "male" && FourLanes[x] < 9.87)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's British Record Time");
                    }

                    if (RaceType == "female" && FourLanes[x] < 10.49)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's World Record Time");
                    }
                    else if (RaceType == "male" && FourLanes[x] < 10.73)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's European Record Time");
                    }
                    else if (RaceType == "male" && FourLanes[x] < 10.99)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's British Record Time");
                    }
                }



                Console.WriteLine("In Fastest to Slowest Time to Finish: ");

                FourLanes.Sort();
                foreach (double value in FourLanes)
                {

                    Console.WriteLine("Time: " + value);
                }
            }
            else if (NumLanes == 5)
            {
                Console.WriteLine("Lane 1");
                FiveLanes[0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 2");
                FiveLanes[1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 3");
                FiveLanes[2] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 4");
                FiveLanes[3] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 5");
                FiveLanes[4] = Convert.ToDouble(Console.ReadLine());

                for (int x = 0; x < NumLanes; x++)
                {
                    Console.WriteLine("Lane " + (x + 1) + " Time: " + FiveLanes[x]);

                    if (RaceType == "male" && FiveLanes[x] < 9.58)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's World Record Time");
                    }
                    else if (RaceType == "male" && FiveLanes[x] < 9.86)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's European Record Time");
                    }
                    else if (RaceType == "male" && FiveLanes[x] < 9.87)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's British Record Time");
                    }

                    if (RaceType == "female" && FiveLanes[x] < 10.49)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's World Record Time");
                    }
                    else if (RaceType == "male" && FiveLanes[x] < 10.73)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's European Record Time");
                    }
                    else if (RaceType == "male" && FiveLanes[x] < 10.99)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's British Record Time");
                    }
                }

                Console.WriteLine("In Fastest to Slowest Time to Finish: ");

                FiveLanes.Sort();
                foreach (double value in FiveLanes)
                {

                    Console.WriteLine("Time: " + value);
                }
            }
            else if (NumLanes == 6)
            {
                Console.WriteLine("Lane 1");
                SixLanes[0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 2");
                SixLanes[1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 3");
                SixLanes[2] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 4");
                SixLanes[3] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 5");
                SixLanes[4] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 6");
                SixLanes[5] = Convert.ToDouble(Console.ReadLine());

                for (int x = 0; x < NumLanes; x++)
                {
                    Console.WriteLine("Lane " + (x + 1) + " Time: " + SixLanes[x]);

                    if (RaceType == "male" && SixLanes[x] < 9.58)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's World Record Time");
                    }
                    else if (RaceType == "male" && SixLanes[x] < 9.86)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's European Record Time");
                    }
                    else if (RaceType == "male" && SixLanes[x] < 9.87)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's British Record Time");
                    }

                    if (RaceType == "female" && SixLanes[x] < 10.49)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's World Record Time");
                    }
                    else if (RaceType == "male" && SixLanes[x] < 10.73)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's European Record Time");
                    }
                    else if (RaceType == "male" && SixLanes[x] < 10.99)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's British Record Time");
                    }
                }

                Console.WriteLine("In Fastest to Slowest Time to Finish: ");

                SixLanes.Sort();
                foreach (double value in SixLanes)
                {

                    Console.WriteLine("Time: " + value);
                }
            }
            else if (NumLanes == 7)
            {
                Console.WriteLine("Lane 1");
                SevenLanes[0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 2");
                SevenLanes[1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 3");
                SevenLanes[2] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 4");
                SevenLanes[3] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 5");
                SevenLanes[4] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 6");
                SevenLanes[5] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 7");
                SevenLanes[6] = Convert.ToDouble(Console.ReadLine());

                for (int x = 0; x < NumLanes; x++)
                {
                    Console.WriteLine("Lane " + (x + 1) + " Time: " + SevenLanes[x]);

                    if (RaceType == "male" && SevenLanes[x] < 9.58)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's World Record Time");
                    }
                    else if (RaceType == "male" && SevenLanes[x] < 9.86)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's European Record Time");
                    }
                    else if (RaceType == "male" && SevenLanes[x] < 9.87)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's British Record Time");
                    }

                    if (RaceType == "female" && SevenLanes[x] < 10.49)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's World Record Time");
                    }
                    else if (RaceType == "male" && SevenLanes[x] < 10.73)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's European Record Time");
                    }
                    else if (RaceType == "male" && SevenLanes[x] < 10.99)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's British Record Time");
                    }
                }

                Console.WriteLine("In Fastest to Slowest Time to Finish: ");

                SevenLanes.Sort();
                foreach (double value in SevenLanes)
                {

                    Console.WriteLine("Time: " + value);
                }
            }
            else if (NumLanes == 8)
            {
                Console.WriteLine("Lane 1");
                EightLanes[0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 2");
                EightLanes[1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 3");
                EightLanes[2] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 4");
                EightLanes[3] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 5");
                EightLanes[4] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 6");
                EightLanes[5] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 7");
                EightLanes[6] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lane 8");
                EightLanes[7] = Convert.ToDouble(Console.ReadLine());

                for (int x = 0; x < NumLanes; x++)
                {
                    Console.WriteLine("Lane " + (x+1) + " Time: " + EightLanes[x]);

                    if (RaceType == "male" && EightLanes[x] < 9.58)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's World Record Time");
                    }
                    else if (RaceType == "male" && EightLanes[x] < 9.86)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's European Record Time");
                    }
                    else if (RaceType == "male" && EightLanes[x] < 9.87)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Men's British Record Time");
                    }

                    if (RaceType == "female" && EightLanes[x] < 10.49)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's World Record Time");
                    }
                    else if (RaceType == "male" && EightLanes[x] < 10.73)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's European Record Time");
                    }
                    else if (RaceType == "male" && EightLanes[x] < 10.99)
                    {
                        Console.WriteLine("Lane" + x + "Broke the Women's British Record Time");
                    }
                }

                Console.WriteLine("In Fastest to Slowest Time to Finish: ");

                EightLanes.Sort();
                foreach (double value in EightLanes)
                {

                    Console.WriteLine("Time: " + value);
                }
            }

            


            

            Console.ReadKey();
        }
    }
}
