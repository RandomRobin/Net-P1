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

            while (quit is false){

                
                Console.Write(tic.Board());
               

                String input = Console.ReadLine();

                if (input == "quit")
                {
                    Environment.Exit(0);
                }

               else  if (input == "new")
                {
                    tic.Reset();
           
                }

                else if (input == "1")
                {
                    tic.ChooseCell(0);
                }

                else if (input == "2")
                {
                    tic.ChooseCell(1);
                }

                else if (input == "3")
                {
                    tic.ChooseCell(2);
                }

                else if (input == "4")
                {
                    tic.ChooseCell(3);
                }

                else if (input == "5")
                {
                    tic.ChooseCell(4);
                }

               else if (input == "6")
                {
                    tic.ChooseCell(5);
                }

               else if (input == "7")
                {
                    tic.ChooseCell(6);
                }

                else if (input == "8")
                {
                    tic.ChooseCell(7);
                }

                else if (input == "9")
                {
                    tic.ChooseCell(8);
                }


                Console.WriteLine("\nType a number from 1-9, new or quit\nStatus:" + tic.getStatus().ToString());

            }
        }
      
        
    }
}
