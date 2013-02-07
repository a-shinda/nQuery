using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace nQueryLib.UI
{
    public interface InQueryOpacity
    {
        void CallInvokePaintBackground(Control ctrl, PaintEventArgs p);
        void CallInvokePaint(Control ctrl, PaintEventArgs p);
    }
}
