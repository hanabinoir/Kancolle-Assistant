using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kancolle_Guide
{
    class Statistics
    {
        private string hp, armor;
        
        public string HP
        {
            set { hp = value; }
            get { return hp; }
        }

        public string ARMOR
        {
            set { armor = value; }
            get { return armor; }
        }
    }
}
