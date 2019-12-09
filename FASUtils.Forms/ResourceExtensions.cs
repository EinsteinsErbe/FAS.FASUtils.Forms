using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FASUtils.Forms
{
    public static class ResourceExtensions
    {
        public static void AddControl(this Resource resource, Control control)
        {
            resource.StateChanged += (s, e) =>
            {
                Color col;
                switch (e.State)
                {
                    case ConnectState.CONNECTING: col = ColorPalette.WARN; break;
                    case ConnectState.CONNECTED: col = ColorPalette.GOOD; break;
                    default: col = ColorPalette.BAD; break; 
                }

                control.Invoke(new Action(() =>
                {
                    control.BackColor = col;
                    control.Text = e.Message;
                }));
            };
        }
    }
}
