using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    public interface IGold
    {
        //Property will store the gold
        //public int startingGold { get; set; }
        //public int maxGold { get; set; }

        //Method to modify the gold
        public void ModifyGold(int amount);
        public Action<int> OnModifyGold();
    }
}
