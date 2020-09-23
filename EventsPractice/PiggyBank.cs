using System;
using System.Collections.Generic;
using System.Text;

namespace EventsPractice
{
    public delegate void TakeDelegate(int value);

    class PiggyBank
    {
        public event TakeDelegate takeEvent;

        private int _money;

        public int Money
        {
            get { return _money; }
            set
            {
                _money = value;
                takeEvent(_money);
            }
        }


    }
}
