using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
