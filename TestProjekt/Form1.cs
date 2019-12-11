using FASUtils;
using FASUtils.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connectable.INTERNET.AddControl(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlState.RunTask(button1, () => Connectable.INTERNET.Check().Wait());
        }
    }
}
