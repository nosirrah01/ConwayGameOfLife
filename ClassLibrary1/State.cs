using ConwayLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class State
    {
        public Grid CurrentGrid { get; set; }
        public Grid NextGrid { get; set; }

        public State(Grid currentGrid)
        {
            CurrentGrid = currentGrid;
            NextGrid = currentGrid.GenerateNextGrid();
        }

        public void UpdateToNextState()
        {
            CurrentGrid = NextGrid;
            NextGrid = CurrentGrid.GenerateNextGrid();
        }
    }
}
