using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Setter
    {
        private int amountOfThounsandBanknote;
        private int amountOfFiveHundredBanknote;
        private int amountOfHundredBanknote;
        private int amountOfTwentyBanknote;
        private int totalMoney;
        private int thousand;
        private int fiveHundred;
        private int hundred;
        private int twenty;

        public int AmountOfThousandBanknote
        {
            get
            {
                return amountOfThounsandBanknote;
            }
            set
            {
                if (value >= 0)
                    amountOfThounsandBanknote = value;
            }
        }

        public int AmountOfFiveHundredBanknote
        {
            get
            {
                return amountOfFiveHundredBanknote;
            }
            set
            {
                amountOfFiveHundredBanknote = value;
            }
        }

        public int AmountOfHundredBanknote
        {
            get
            {
                return amountOfHundredBanknote;
            }
            set
            {
                amountOfHundredBanknote = value;
            }
        }

        public int AmountOfTwentyBanknote
        {
            get
            {
                return amountOfTwentyBanknote;
            }
            set
            {
                amountOfTwentyBanknote = value;
            }
        }

        public int TotalMoney
        {
            get
            {
                return totalMoney;
            }
            set
            {
                totalMoney = AmountOfThousandBanknote * 1000 +
                             AmountOfFiveHundredBanknote * 500 +
                             AmountOfHundredBanknote * 100 +
                             AmountOfTwentyBanknote * 20;
            }
        }

        public int Thousand
        {
            get
            {
                return thousand;
            }
            set
            {
                thousand = value;
            }
        }

        public int FiveHundred
        {
            get
            {
                return fiveHundred;
            }
            set
            {
                fiveHundred = value;
            }
        }

        public int Hundred
        {
            get
            {
                return hundred;
            }
            set
            {
                hundred = value;
            }
        }

        public int Twenty
        {
            get
            {
                return twenty;
            }
            set
            {
                twenty = value;
            }
        }
    }
}
