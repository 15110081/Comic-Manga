using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class page_Ratings : UserControl
    {
        public page_Ratings()
        {
            InitializeComponent();
        }

        private void page_Ratings_Load(object sender, EventArgs e)
        {
            chart1.Series["Rating"].Points.Add(1000);
            chart1.Series["Rating"].Points[0].Color = Color.Red;
            chart1.Series["Rating"].Points[0].AxisLabel = "Conan";
            chart1.Series["Rating"].Points[0].LegendText = "Conan";
            chart1.Series["Rating"].Points[0].Label = "1000";

            chart1.Series["Rating"].Points.Add(2634);
            chart1.Series["Rating"].Points[1].Color = Color.AliceBlue;
            chart1.Series["Rating"].Points[1].AxisLabel = "Fairy Tail";
            chart1.Series["Rating"].Points[1].LegendText = "Fairy Tail ";
            chart1.Series["Rating"].Points[1].Label = "2634";

            chart1.Series["Rating"].Points.Add(1236);
            chart1.Series["Rating"].Points[2].Color = Color.DarkCyan;
            chart1.Series["Rating"].Points[2].AxisLabel = "Doremon";
            chart1.Series["Rating"].Points[2].LegendText = "Doremon";
            chart1.Series["Rating"].Points[2].Label = "1236";


            chart1.Series["Rating"].Points.Add(6433);
            chart1.Series["Rating"].Points[3].Color = Color.WhiteSmoke;
            chart1.Series["Rating"].Points[3].AxisLabel = "Yaiba";
            chart1.Series["Rating"].Points[3].LegendText = "Yaiba";
            chart1.Series["Rating"].Points[3].Label = "1000";


            chart1.Series["Rating"].Points.Add(2526);
            chart1.Series["Rating"].Points[4].Color = Color.Violet;
            chart1.Series["Rating"].Points[4].AxisLabel = "Ket Gioi Su";
            chart1.Series["Rating"].Points[4].LegendText = "Ket Gioi Su";
            chart1.Series["Rating"].Points[4].Label = "1000";


            chart1.Series["Rating"].Points.Add(9234);
            chart1.Series["Rating"].Points[5].Color = Color.Olive;
            chart1.Series["Rating"].Points[5].AxisLabel = "DragonBall";
            chart1.Series["Rating"].Points[5].LegendText = "DragonBall";
            chart1.Series["Rating"].Points[5].Label = "1000";


            chart1.Series["Rating"].Points.Add(5235);
            chart1.Series["Rating"].Points[6].Color = Color.Navy;
            chart1.Series["Rating"].Points[6].AxisLabel = "Onepunch";
            chart1.Series["Rating"].Points[6].LegendText = "Onepunch";
            chart1.Series["Rating"].Points[6].Label = "5235";


            chart1.Series["Rating"].Points.Add(10000);
            chart1.Series["Rating"].Points[7].Color = Color.Sienna;
            chart1.Series["Rating"].Points[7].AxisLabel = "Naruto";
            chart1.Series["Rating"].Points[7].LegendText = "Naruto";
            chart1.Series["Rating"].Points[7].Label = "10000";


            chart1.Series["Rating"].Points.Add(1234);
            chart1.Series["Rating"].Points[8].Color = Color.Tomato;
            chart1.Series["Rating"].Points[8].AxisLabel = "Doi quan nhi nho";
            chart1.Series["Rating"].Points[8].LegendText = "Doi quan nhi nho";
            chart1.Series["Rating"].Points[8].Label = "1234";


            chart1.Series["Rating"].Points.Add(4562);
            chart1.Series["Rating"].Points[9].Color = Color.Bisque;
            chart1.Series["Rating"].Points[9].AxisLabel = "Than Dong Dat Viet";
            chart1.Series["Rating"].Points[9].LegendText = "Than Dong Dat Viet";
            chart1.Series["Rating"].Points[9].Label = "4562";


            //chart1.Series["Rating"].Points.Add(1000);
            //chart1.Series["Rating"].Points[10].Color = Color.Red;
            //chart1.Series["Rating"].Points[10].AxisLabel = "Conan";
            //chart1.Series["Rating"].Points[10].LegendText = "Conan";
            //chart1.Series["Rating"].Points[10].Label = "1000";




        }
    }
}
