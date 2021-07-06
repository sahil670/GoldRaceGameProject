using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldRaceGameProject
{
   public class Contestant
    {
        Random run = new Random();
        public int amt;
        public int race;
        public int bet=0;
        public int budgt;
        public int rslt(int win) {
            if (bet == win)
            {
                return budgt + amt;
            }
            else {
                return budgt - amt;
            }
        }
        public int runner() {
            
            return run.Next(1, 50);
        }
    }
}
