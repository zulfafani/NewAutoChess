using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    public interface IPoint
    {
        //Property will store the point
        //public int startingPoint { get; set; }
        //public int endPoint { get; set; }

        //Method to modify the point
        public void ModifyPoint(int amount);
        public Action<int> OnModifyPoint();
        public void CheckPoint(int result);

    }
}
