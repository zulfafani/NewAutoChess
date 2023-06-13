using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    public interface ILevel
    {
        //Property will store the level
        //public int startingLevel { get; set; }
        //public int maxLevel { get; set; }

        //Method to modify the level
        public void ModifyLevel(int amount);
        public Action<int> OnModifyLevel();
        public void AmountUnitDeployed();
    }
}
