using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Checker
    {
        public bool isRightInput(string input)
        {
            int num;
            return int.TryParse(input, out num);
        }

        public bool isEnoughAmountOfMoney(int amount)
        {
            Setter setter = new Setter();
            return amount <= setter.TotalMoney;
        }
    }
}
