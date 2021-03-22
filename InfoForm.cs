using System.Windows.Forms;

namespace Polygons
{
    public partial class InfoForm : Form
    {
        /*
         *  Standard constructor of any form.
         *  
         */
        public InfoForm()
        {
            InitializeComponent();
        }

        /*
         *  This constructor receives a polygon to obtain its information.
         *  
         */
        public InfoForm(Polygon polygon) : this()
        {
            lblPolygon.Text = " Class: " + polygon.GetType().Name;
            lblSides.Text = " Sides: " + polygon.Sides;
            lblArea.Text = " Area: " + polygon.Area;
            lblPerimeter.Text = " Perimeter: " + polygon.Perimeter;
            lblCentroid.Text = " Centroid: " + polygon.Centroid.ToString();
            lblColor.Text = " Color: " + polygon.FillColor.ToString();
            ShowDialog();
        }

        /*
         *  This method closes the form.
         */
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
