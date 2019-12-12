using System;
using System.Windows.Forms;

namespace MetroFramework.Controls
{
    public partial class TreeViewV2 : TreeView
    {
        public TreeViewV2()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            // Suppress WM_LBUTTONDBLCLK
            if (m.Msg == 0x203) { m.Result = IntPtr.Zero; }
            else base.WndProc(ref m);
        }
    }
}
