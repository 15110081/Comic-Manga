using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class splashscreen : Form
    {
        List<Color> colors = new List<Color>();
        public splashscreen()
        {
            colors.Add(Color.FromArgb(0,158,71));
            InitializeComponent();
        }
    }
}
