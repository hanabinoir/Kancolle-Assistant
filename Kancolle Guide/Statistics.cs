using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kancolle_Assistant
{
    class Statistics
    {
        private string hp, firepower, armor, torpedo, evasion, aa, 
            aircraft, asw, speed, los, range, luck, 
            No, shipname, buildtime, shipclass, shiptype;
        
        public string HP
        {
            set { hp = value; }
            get { return hp; }
        }

        public string FIREPOWER
        {
            set { firepower = value; }
            get { return firepower; }
        }

        public string ARMOR
        {
            set { armor = value; }
            get { return armor; }
        }

        public string TORPEDO
        {
            set { torpedo = value; }
            get { return torpedo; }
        }

        public string EVASION
        {
            set { evasion = value; }
            get { return evasion; }
        }

        public string AA
        {
            set { aa = value; }
            get { return aa; }
        }

        public string AIRCRAFT
        {
            set { aircraft = value; }
            get { return aircraft; }
        }

        public string ASW
        {
            set { asw = value; }
            get { return asw; }
        }

        public string SPEED
        {
            set { speed = value; }
            get { return speed; }
        }

        public string LOS
        {
            set { los = value; }
            get { return los; }
        }

        public string RANGE
        {
            set { range = value; }
            get { return range; }
        }

        public string LUCK
        {
            set { luck = value; }
            get { return luck; }
        }

        public string BUILDTIME
        {
            set { buildtime = value; }
            get { return buildtime; }
        }

        public string NUM
        {
            set { No = value; }
            get { return No; }
        }

        public string SHIP_NAME
        {
            set { shipname = value; }
            get { return shipname; }
        }

        public string SHIPCLASS
        {
            set { shipclass = value; }
            get { return shipclass; }
        }

        public string SHIPTYPE
        {
            set { shiptype = value; }
            get { return shiptype; }
        }
    }
}
