using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    public interface IHealth
    {
        public void ModifyHealth(int amount);
        public Action<int> OnModifyHealth();
    }
}
