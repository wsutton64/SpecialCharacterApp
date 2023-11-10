using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialCharacterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void charClickEvent(object sender, EventArgs e)
        {
            Control clickedLabel = (Control)sender;
            // Console.WriteLine(clickedLabel.Text);
            Clipboard.SetText(clickedLabel.Text);
        }
    }
}
