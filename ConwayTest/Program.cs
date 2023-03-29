using ClassLibrary1;
using ConwayLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // note: default console app seems to be 120 columns and 30 rows, but gonna do 29 cause it has cursor line at bottom line

            Cell[,] cells = new Cell[29, 120];
            for (int row = 0; row < cells.GetLength(0); row++)
                for (int col = 0; col < cells.GetLength(1); col++)
                {
                    var cell = new Cell();
                    cell.IsLive = RandomCellLife();
                    cells[row, col] = cell;
                }
        
            //cells[0,1].IsLive = true;
            //cells[1,2].IsLive = true;
            //cells[2,0].IsLive = true;
            //cells[2,1].IsLive = true;
            //cells[2,2].IsLive = true;
            Grid grid = new Grid(cells);
            State state = new State(grid);

            //PrintCurrentGameState(state);

            
            while (true)
            {
                PrintCurrentGameState(state);
                //Console.WriteLine("test");

                System.Threading.Thread.Sleep(100);
                state.UpdateToNextState();
                Console.Clear();
            }
            
            /*
            Console.WriteLine(Class1.DoSomeLogicTest(1,2));
            Console.WriteLine("▓");
            Console.WriteLine("▒");
            Console.WriteLine("░");
            */
            /*
            for (int i = 0; i < 120; i++)
            {
                Console.Write("0");
            }
            */
            /*
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("0");
            }
            */
            Console.ReadLine();
        }

        private static bool RandomCellLife()
        {
            long tick = DateTime.Now.Ticks;
            Random rand = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            bool randomBool = rand.Next(2) == 0;

            return randomBool;
        }

        private static void PrintCurrentGameState(State state)
        {

            for (int row = 0; row < state.CurrentGrid.CellMatrix.GetLength(0); row++)
            {
                string rowText = "";
                for (int col = 0; col < state.CurrentGrid.CellMatrix.GetLength(1); col++)
                {
                    rowText += (state.CurrentGrid.CellMatrix[row, col].IsLive) ? '0' : '.';
                    //if (state.CurrentGrid.CellMatrix[row, col].IsLive)
                    //{
                    //    //Console.Write('▓');
                    //    Console.Write('0');
                    //}
                    //else
                    //{
                    //    //Console.Write(' ');
                    //    Console.Write('.');
                    //}

                }
                Console.WriteLine(rowText);

            }

        }
    }
}
