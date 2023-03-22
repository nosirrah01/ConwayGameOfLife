using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConwayLogicLibrary
{
    public class Cell
    {
        private bool isLive;

        public bool IsLive
        {
            get { return isLive; }
            set { isLive = value; }
        }

        public Cell()
        {
            isLive = false;
        }
        
        public Cell(bool isLive)
        {
            this.isLive = isLive;
        }

        public override bool Equals(object obj)
        {
            if (isLive == ((Cell)obj).isLive)
                return true;
            else
                return false;
        }

        public void ApplyRulesToCell(bool? n1, bool? n2, bool? n3, bool? n4, bool? n5, bool? n6, bool? n7, bool? n8)
        {
            /* Any live cell with fewer than two live neighbours dies, as if by underpopulation.
             * Any live cell with two or three live neighbours lives on to the next generation.
             * Any live cell with more than three live neighbours dies, as if by overpopulation.
             * Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
             */
            bool?[] neighborLiveValues = new bool?[] { n1, n2, n3, n4, n5, n6, n7, n8 };
            int AliveNeighborCount = GetAliveNeighborCount(neighborLiveValues);
            DoRuleLogic(AliveNeighborCount);
        }

        private void DoRuleLogic(int AliveNeighborCount)
        {
            switch (AliveNeighborCount)
            {
                case 0:
                    isLive = false;
                    break;
                case 1:
                    isLive = false;
                    break;
                case 3:
                    isLive = true;
                    break;
                case 4:
                    isLive = false;
                    break;
                case 5:
                    isLive = false;
                    break;
                case 6:
                    isLive = false;
                    break;
                case 7:
                    isLive = false;
                    break;
                case 8:
                    isLive = false;
                    break;
            }
        }

        private static int GetAliveNeighborCount(bool?[] neighborLiveValues)
        {
            int AliveNeighborCount = 0;
            for (int i = 0; i < neighborLiveValues.Length; i++)
                if (neighborLiveValues[i] == true)
                    AliveNeighborCount++;
            return AliveNeighborCount;
        }

        public void ApplyRulesToCell(bool n1, bool n2, bool n3, bool n4, bool n5)
        {
            bool?[] neighborLiveValues = new bool?[] { n1, n2, n3, n4, n5 };
            int AliveNeighborCount = GetAliveNeighborCount(neighborLiveValues);
            DoRuleLogic(AliveNeighborCount);
        }

        public void ApplyRulesToCell(bool n1, bool n2, bool n3)
        {
            bool?[] neighborLiveValues = new bool?[] { n1, n2, n3 };
            int AliveNeighborCount = GetAliveNeighborCount(neighborLiveValues);
            DoRuleLogic(AliveNeighborCount);
        }
    }
}
