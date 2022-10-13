using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegue
{
    internal class TicTac
    {
        public event EventHandler OnTic;

        private Timer timer;
        private int i;

        public int GetI() => i;

        public TicTac()
        {
            timer = new Timer(o =>
            {
                i++;
                if (OnTic != null)
                    OnTic(this, new EventArgs());
            },null,0,2000);
        }
    }
}
