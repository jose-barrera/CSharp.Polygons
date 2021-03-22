using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polygons
{
    public partial class MainForm : Form
    {
        #region INTERNAL FIELDS

        private List<Point> vertices;
        private List<Polygon> polygons;

        #endregion

        #region GENERAL BEHAVIOUR

        /*
         *  Standar constructor for any form.
         *  
         */
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         *  This method handles the actions needed when loading the form.
         *  
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Creates the lists used in the program.
            this.vertices = new List<Point>();
            this.polygons = new List<Polygon>();

            updateControls();
        }

        /*
         *  This method handles mouse movement to indicate the user where
         *  is in the canvas.
         *  
         */
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblMousePosition.Text = "(" + e.X + " , " + e.Y + ")";
        }

        /*
         *  This method handles double click to define a vertex to build a
         *  polygon.
         *  
         */
        private void pnlCanvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.vertices.Add(new Point(e.X, e.Y));
            lstVertices.Items.Add(new ListViewItem("(" + e.X + "," + e.Y + ")"));
            pnlCanvas.Refresh();
            updateControls();
        }

        /*
         *  This method handles the actions necessary for paint the canvas and its
         *  graphic elements.
         *  
         */
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Canvas to paint
            Graphics g = e.Graphics;
            // Painting of build polygons
            foreach (Polygon p in polygons)
            {
                g.FillPolygon(new SolidBrush(p.FillColor), p.Vertices);
            }
            // Painting of defined line segments
            Pen pen = new Pen(Color.DarkOliveGreen);
            for (int i = 0; i < this.vertices.Count - 1; i++)
            {
                g.DrawLine(pen, 
                    this.vertices[i].X, this.vertices[i].Y, 
                    this.vertices[i + 1].X, this.vertices[i + 1].Y);
            }
        }

        /*
         *  This method display an information form when the user double click
         *  on a polygon from built polygons list.
         *  
         */
        private void lstPolygons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lstPolygons.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            if (item != null)
            {
                new InfoForm(this.polygons[item.Index]);
                lstPolygons.SelectedItems.Clear();
            }
        }

        /*
         *  This method Updates the form controls according the number of vertices the user establishes.
         *  
         *  a) With 0 or 1 vertices, no polygon can be created.
         *  b) With 2 vertices, some specific polygons can be created.
         *  c) With 3 or more vertices, a closed polygon can be created.
         *  
         */
        private void updateControls()
        {
            btnBuildRectangle.Enabled = this.vertices.Count == 2;
            btnBuildSquare.Enabled = this.vertices.Count == 2;
            btnBuildPentagon.Enabled = this.vertices.Count == 2;
            btnBuildHexagon.Enabled = this.vertices.Count == 2;
            btnBuildHeptagon.Enabled = this.vertices.Count == 2;
            btnBuildOctagon.Enabled = this.vertices.Count == 2;
            btnBuildDecagon.Enabled = this.vertices.Count == 2;
            btnBuildDodecagon.Enabled = this.vertices.Count == 2;
            btnBuildPolygon.Enabled = this.vertices.Count >= 3;
            btnTranslateUp.Enabled = this.polygons.Count > 0;
            btnTranslateDown.Enabled = this.polygons.Count > 0;
            btnTranslateLeft.Enabled = this.polygons.Count > 0;
            btnTranslateRight.Enabled = this.polygons.Count > 0;
            btnRotateCW.Enabled = this.polygons.Count > 0;
            btnRotateCCW.Enabled = this.polygons.Count > 0;
            btnClearLastVertex.Enabled = this.lstVertices.Items.Count > 0;
            btnClearVertices.Enabled = this.lstVertices.Items.Count > 0;
            btnClearLastPolygon.Enabled = this.lstPolygons.Items.Count > 0;
            btnClearPolygons.Enabled = this.lstPolygons.Items.Count > 0;
        }

        #endregion

        #region POLYGONS BUILDING

        /*
         *  This method build a convex closed polygons using all vertices
         *  defined by the user.
         *  
         */
        private void btnBuildPolygon_Click(object sender, EventArgs e)
        {
            Polygon p = new Polygon(this.vertices);
            this.polygons.Add(p);
            this.lstPolygons.Items.Add("Polygon (" + p.Sides + ")");
            // Clear vertices in memory and in visual controls
            this.vertices.Clear();
            lstVertices.Items.Clear();
            // Refresh the canvas
            pnlCanvas.Refresh();
            // Update controls
            updateControls();
        }

        /*
         *  This method handles several buttons click event, to build specific
         *  types of polygons.
         *  
         */
        private void btnBuildSpecificPolygon_Click(object sender, EventArgs e)
        {
            // Build the object from the class selected
            Button button = (Button)sender;
            switch(button.Text)
            {
                case "Rectangle": 
                    this.polygons.Add(new Rectangle(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Rectangle");
                    break;
                case "Square": 
                    this.polygons.Add(new Square(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Square");
                    break;
                case "Pentagon": 
                    this.polygons.Add(new PentagonR(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Pentagon (R)");
                    break;
                case "Hexagon": 
                    this.polygons.Add(new HexagonR(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Hexagon (R)");
                    break;
                case "Heptagon": 
                    this.polygons.Add(new HeptagonR(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Heptagon (R)");
                    break;
                case "Octagon": 
                    this.polygons.Add(new OctagonR(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Octagon (R)");
                    break;
                case "Decagon": 
                    this.polygons.Add(new DecagonR(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Decagon (R)");
                    break;
                case "Dodecagon": 
                    this.polygons.Add(new DodecagonR(this.vertices[0], this.vertices[1]));
                    this.lstPolygons.Items.Add("Dodecagon (R)");
                    break;
            }
            // Clear vertices in memory and in visual controls
            this.vertices.Clear();
            lstVertices.Items.Clear();
            // Refresh the canvas
            pnlCanvas.Refresh();
            // Update controls
            updateControls();
        }

        #endregion

        #region TRANSLATION BUTTONS

        /*
         *  Moves all polygons 1 pixel up.
         *  
         */
        private void btnTranslateUp_Click(object sender, EventArgs e)
        {
            foreach (Polygon p in this.polygons)
            {
                p.Translate(0, -1);
            }
            pnlCanvas.Refresh();
        }

        /*
         *  Moves all polygons 1 pixel down.
         *  
         */
        private void btnTranslateDown_Click(object sender, EventArgs e)
        {
            foreach (Polygon p in this.polygons)
            {
                p.Translate(0, 1);
            }
            pnlCanvas.Refresh();
        }

        /*
         *  Moves all polygons 1 pixel left.
         *  
         */
        private void btnTranslateLeft_Click(object sender, EventArgs e)
        {
            foreach (Polygon p in this.polygons)
            {
                p.Translate(-1, 0);
            }
            pnlCanvas.Refresh();
        }

        /*
         *  Moves all polygons 1 pixel right.
         *  
         */
        private void btnTranslateRight_Click(object sender, EventArgs e)
        {
            foreach (Polygon p in this.polygons)
            {
                p.Translate(1, 0);
            }
            pnlCanvas.Refresh();
        }

        #endregion

        #region ROTATION BUTTONS

        /*
         *  Rotates all polygons 1 degree clockwise.
         *  
         */
        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            foreach (Polygon p in this.polygons)
            {
                p.Rotate(-1);
            }
            pnlCanvas.Refresh();
        }

        /*
         *  Rotates all polygons 1 degree clockwise.
         *  
         */
        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            foreach (Polygon p in this.polygons)
            {
                p.Rotate(1);
            }
            pnlCanvas.Refresh();
        }

        #endregion

        #region LISTS HANDLING

        /*
         *  This method handles the button to clear last entered vertex.
         *  
         */
        private void btnClearLastVertex_Click(object sender, EventArgs e)
        {
            this.vertices.RemoveAt(this.vertices.Count - 1);
            lstVertices.Items.RemoveAt(this.lstVertices.Items.Count - 1);
            pnlCanvas.Refresh();
            updateControls();
        }

        /*
         *  This method handles the button to clear all working vertices.
         *  
         */
        private void btnClearVertices_Click(object sender, EventArgs e)
        {
            this.vertices.Clear();
            lstVertices.Items.Clear();
            pnlCanvas.Refresh();
            updateControls();
        }

        /*
         *  This method handles the button to clear last built polygon.
         *  
         */
        private void btnClearLastPolygon_Click(object sender, EventArgs e)
        {
            this.polygons.RemoveAt(this.polygons.Count - 1);
            lstPolygons.Items.RemoveAt(this.lstPolygons.Items.Count - 1);
            pnlCanvas.Refresh();
            updateControls();
        }

        /*
         *  This method handles the button to clear all working polygons.
         *  
         */
        private void btnClearPolygons_Click(object sender, EventArgs e)
        {
            this.polygons.Clear();
            lstPolygons.Items.Clear();
            pnlCanvas.Refresh();
            updateControls();
        }

        #endregion
    }
}
