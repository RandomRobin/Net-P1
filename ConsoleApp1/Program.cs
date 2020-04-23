using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeEngine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean quit = false;
            TicTacToe tic = new TicTacToe();
            tic.Reset();
            Console.WriteLine("Type a number from 1-9, new or quit\nStatus:" + tic.getStatus().ToString());

            while (quit is false) {

                Console.Write(tic.Board());

          
                String input = Console.ReadLine();

                switch (input) {
                    case "quit":
                        Environment.Exit(0);
                        break;

                    case "new":
                        tic.Reset();
                        break;

                    case "1":
                        tic.ChooseCell(0);
                        break;

                    case "2":
                        tic.ChooseCell(1);
                        break;

                    case "3":
                        tic.ChooseCell(2);
                        break;

                    case "4":
                        tic.ChooseCell(3);
                        break;

                    case "5":
                        tic.ChooseCell(4);
                        break;

                    case "6":
                        tic.ChooseCell(5);
                        break;

                    case "7":
                        tic.ChooseCell(6);
                        break;

                    case "8":
                        tic.ChooseCell(7);
                        break;

                    case "9":
                        tic.ChooseCell(8);
                        break;

                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }

                Console.WriteLine("\nType a number from 1-9, new or quit\nStatus:" + tic.getStatus().ToString());

            }
        }
      
        
    }
}
