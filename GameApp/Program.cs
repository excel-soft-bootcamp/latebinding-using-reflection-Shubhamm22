using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Word Guess Game");

            string message = string.Format("Enter Your Choice {0}->Basic , {1}->Intermediate ,{2}->Advanced", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);// 1->Basic,2->Intermediate
            Options _choice = default;


            int attempts = 3;
            for (int i = 0; i <= attempts; i++)
            {
                do
                {


                    string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
                    Console.WriteLine(displayMessage);

                    _choice = (Options)Int32.Parse(Console.ReadLine());



                    switch (_choice)
                    {

                        case Options.BASIC:
                            Console.WriteLine("Basic Level");
                            BasicMode _basicMode = new BasicMode();
                            _basicMode.Load(@"C:\Users\shubham.m\Downloads\download\BasicLevelLib.dll", "BasicLevelLib.BasicLevelType", "Play");
                            break;
                        case Options.INTERMEDIATE:
                            Console.WriteLine("Intermediate Level");
                            IntermediateMode _intermediateMode = new IntermediateMode();
                            _intermediateMode.Load(@"C:\Users\shubham.m\Downloads\download\IntermediateLevelLib.dll", "IntermediateLevelLib.IntermediateLevelType", "Start", "Shubham");

                            break;
                        case Options.ADVANCED:
                            Console.WriteLine("Advanced Level");
                            AdvancedMode _advanceMode = new AdvancedMode();
                            _advanceMode.Load(@"C:\Users\shubham.m\Downloads\download\AdvancedLevelLib.dll", "AdvancedLevelLib.AdvancedLevelType", "Begin", "Shubham", 50);

                            break;
                        default:
                            Console.WriteLine("Invalid Input");

                            break;

                    }
                    attempts--;
                    break;

                } while (_choice != Options.BASIC && _choice != Options.INTERMEDIATE && _choice != Options.ADVANCED);
            }
        }
    }
}

