
namespace Polygons
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.lstPolygons = new System.Windows.Forms.ListView();
            this.btnClearLastPolygon = new System.Windows.Forms.Button();
            this.btnClearPolygons = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearVertices = new System.Windows.Forms.Button();
            this.btnClearLastVertex = new System.Windows.Forms.Button();
            this.lstVertices = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMousePosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.btnTranslateRight = new System.Windows.Forms.Button();
            this.btnTranslateLeft = new System.Windows.Forms.Button();
            this.btnTranslateDown = new System.Windows.Forms.Button();
            this.btnBuildDodecagon = new System.Windows.Forms.Button();
            this.btnBuildDecagon = new System.Windows.Forms.Button();
            this.btnBuildOctagon = new System.Windows.Forms.Button();
            this.btnBuildHexagon = new System.Windows.Forms.Button();
            this.btnBuildHeptagon = new System.Windows.Forms.Button();
            this.btnBuildPentagon = new System.Windows.Forms.Button();
            this.btnBuildSquare = new System.Windows.Forms.Button();
            this.btnBuildPolygon = new System.Windows.Forms.Button();
            this.btnTranslateUp = new System.Windows.Forms.Button();
            this.btnBuildRectangle = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidebar.Controls.Add(this.lstPolygons);
            this.sidebar.Controls.Add(this.btnClearLastPolygon);
            this.sidebar.Controls.Add(this.btnClearPolygons);
            this.sidebar.Controls.Add(this.label3);
            this.sidebar.Controls.Add(this.btnClearVertices);
            this.sidebar.Controls.Add(this.btnClearLastVertex);
            this.sidebar.Controls.Add(this.lstVertices);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.lblMousePosition);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Location = new System.Drawing.Point(886, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(170, 796);
            this.sidebar.TabIndex = 1;
            // 
            // lstPolygons
            // 
            this.lstPolygons.BackColor = System.Drawing.Color.DarkKhaki;
            this.lstPolygons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPolygons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPolygons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPolygons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lstPolygons.HideSelection = false;
            this.lstPolygons.Location = new System.Drawing.Point(0, 493);
            this.lstPolygons.MultiSelect = false;
            this.lstPolygons.Name = "lstPolygons";
            this.lstPolygons.Size = new System.Drawing.Size(166, 239);
            this.lstPolygons.TabIndex = 9;
            this.lstPolygons.UseCompatibleStateImageBehavior = false;
            this.lstPolygons.View = System.Windows.Forms.View.List;
            this.lstPolygons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPolygons_MouseDoubleClick);
            // 
            // btnClearLastPolygon
            // 
            this.btnClearLastPolygon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearLastPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLastPolygon.Location = new System.Drawing.Point(0, 732);
            this.btnClearLastPolygon.Name = "btnClearLastPolygon";
            this.btnClearLastPolygon.Size = new System.Drawing.Size(166, 30);
            this.btnClearLastPolygon.TabIndex = 5;
            this.btnClearLastPolygon.Text = "Clear Last Polygon";
            this.btnClearLastPolygon.UseVisualStyleBackColor = true;
            this.btnClearLastPolygon.Click += new System.EventHandler(this.btnClearLastPolygon_Click);
            // 
            // btnClearPolygons
            // 
            this.btnClearPolygons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearPolygons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPolygons.Location = new System.Drawing.Point(0, 762);
            this.btnClearPolygons.Name = "btnClearPolygons";
            this.btnClearPolygons.Size = new System.Drawing.Size(166, 30);
            this.btnClearPolygons.TabIndex = 4;
            this.btnClearPolygons.Text = "Clear Polygons";
            this.btnClearPolygons.UseVisualStyleBackColor = true;
            this.btnClearPolygons.Click += new System.EventHandler(this.btnClearPolygons_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(0, 443);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(166, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "Polygons";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnClearVertices
            // 
            this.btnClearVertices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVertices.Location = new System.Drawing.Point(0, 413);
            this.btnClearVertices.Name = "btnClearVertices";
            this.btnClearVertices.Size = new System.Drawing.Size(166, 30);
            this.btnClearVertices.TabIndex = 6;
            this.btnClearVertices.Text = "Clear Vertices";
            this.btnClearVertices.UseVisualStyleBackColor = true;
            this.btnClearVertices.Click += new System.EventHandler(this.btnClearVertices_Click);
            // 
            // btnClearLastVertex
            // 
            this.btnClearLastVertex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearLastVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLastVertex.Location = new System.Drawing.Point(0, 383);
            this.btnClearLastVertex.Name = "btnClearLastVertex";
            this.btnClearLastVertex.Size = new System.Drawing.Size(166, 30);
            this.btnClearLastVertex.TabIndex = 7;
            this.btnClearLastVertex.Text = "Clear Last Vertex";
            this.btnClearLastVertex.UseVisualStyleBackColor = true;
            this.btnClearLastVertex.Click += new System.EventHandler(this.btnClearLastVertex_Click);
            // 
            // lstVertices
            // 
            this.lstVertices.BackColor = System.Drawing.Color.DarkKhaki;
            this.lstVertices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVertices.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVertices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lstVertices.HideSelection = false;
            this.lstVertices.Location = new System.Drawing.Point(0, 133);
            this.lstVertices.MultiSelect = false;
            this.lstVertices.Name = "lstVertices";
            this.lstVertices.Size = new System.Drawing.Size(166, 250);
            this.lstVertices.TabIndex = 2;
            this.lstVertices.UseCompatibleStateImageBehavior = false;
            this.lstVertices.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 97);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vertices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMousePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMousePosition.ForeColor = System.Drawing.Color.Green;
            this.lblMousePosition.Location = new System.Drawing.Point(0, 36);
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Padding = new System.Windows.Forms.Padding(5);
            this.lblMousePosition.Size = new System.Drawing.Size(166, 61);
            this.lblMousePosition.TabIndex = 1;
            this.lblMousePosition.Text = "(x , y)";
            this.lblMousePosition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mouse Position";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(886, 723);
            this.pnlCanvas.TabIndex = 2;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDoubleClick);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Goldenrod;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnRotateCCW, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRotateCW, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTranslateRight, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTranslateLeft, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTranslateDown, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildDodecagon, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildDecagon, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildOctagon, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildHexagon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildHeptagon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildPentagon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildSquare, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildPolygon, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTranslateUp, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuildRectangle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 723);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 73);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRotateCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCCW.Location = new System.Drawing.Point(679, 41);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(104, 27);
            this.btnRotateCCW.TabIndex = 21;
            this.btnRotateCCW.Text = "Rotate CCW";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRotateCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCW.Location = new System.Drawing.Point(679, 5);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(104, 27);
            this.btnRotateCW.TabIndex = 20;
            this.btnRotateCW.Text = "Rotate CW";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // btnTranslateRight
            // 
            this.btnTranslateRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranslateRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslateRight.Location = new System.Drawing.Point(607, 41);
            this.btnTranslateRight.Name = "btnTranslateRight";
            this.btnTranslateRight.Size = new System.Drawing.Size(64, 27);
            this.btnTranslateRight.TabIndex = 19;
            this.btnTranslateRight.Text = "Right";
            this.btnTranslateRight.UseVisualStyleBackColor = true;
            this.btnTranslateRight.Click += new System.EventHandler(this.btnTranslateRight_Click);
            // 
            // btnTranslateLeft
            // 
            this.btnTranslateLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranslateLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslateLeft.Location = new System.Drawing.Point(535, 41);
            this.btnTranslateLeft.Name = "btnTranslateLeft";
            this.btnTranslateLeft.Size = new System.Drawing.Size(64, 27);
            this.btnTranslateLeft.TabIndex = 18;
            this.btnTranslateLeft.Text = "Left";
            this.btnTranslateLeft.UseVisualStyleBackColor = true;
            this.btnTranslateLeft.Click += new System.EventHandler(this.btnTranslateLeft_Click);
            // 
            // btnTranslateDown
            // 
            this.btnTranslateDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranslateDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslateDown.Location = new System.Drawing.Point(607, 5);
            this.btnTranslateDown.Name = "btnTranslateDown";
            this.btnTranslateDown.Size = new System.Drawing.Size(64, 27);
            this.btnTranslateDown.TabIndex = 17;
            this.btnTranslateDown.Text = "Down";
            this.btnTranslateDown.UseVisualStyleBackColor = true;
            this.btnTranslateDown.Click += new System.EventHandler(this.btnTranslateDown_Click);
            // 
            // btnBuildDodecagon
            // 
            this.btnBuildDodecagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildDodecagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildDodecagon.Location = new System.Drawing.Point(311, 40);
            this.btnBuildDodecagon.Name = "btnBuildDodecagon";
            this.btnBuildDodecagon.Size = new System.Drawing.Size(114, 28);
            this.btnBuildDodecagon.TabIndex = 16;
            this.btnBuildDodecagon.Text = "Dodecagon";
            this.btnBuildDodecagon.UseVisualStyleBackColor = true;
            this.btnBuildDodecagon.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildDecagon
            // 
            this.btnBuildDecagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildDecagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildDecagon.Location = new System.Drawing.Point(311, 5);
            this.btnBuildDecagon.Name = "btnBuildDecagon";
            this.btnBuildDecagon.Size = new System.Drawing.Size(114, 27);
            this.btnBuildDecagon.TabIndex = 15;
            this.btnBuildDecagon.Text = "Decagon";
            this.btnBuildDecagon.UseVisualStyleBackColor = true;
            this.btnBuildDecagon.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildOctagon
            // 
            this.btnBuildOctagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildOctagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildOctagon.Location = new System.Drawing.Point(209, 40);
            this.btnBuildOctagon.Name = "btnBuildOctagon";
            this.btnBuildOctagon.Size = new System.Drawing.Size(94, 28);
            this.btnBuildOctagon.TabIndex = 14;
            this.btnBuildOctagon.Text = "Octagon";
            this.btnBuildOctagon.UseVisualStyleBackColor = true;
            this.btnBuildOctagon.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildHexagon
            // 
            this.btnBuildHexagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildHexagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildHexagon.Location = new System.Drawing.Point(107, 40);
            this.btnBuildHexagon.Name = "btnBuildHexagon";
            this.btnBuildHexagon.Size = new System.Drawing.Size(94, 28);
            this.btnBuildHexagon.TabIndex = 13;
            this.btnBuildHexagon.Text = "Hexagon";
            this.btnBuildHexagon.UseVisualStyleBackColor = true;
            this.btnBuildHexagon.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildHeptagon
            // 
            this.btnBuildHeptagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildHeptagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildHeptagon.Location = new System.Drawing.Point(209, 5);
            this.btnBuildHeptagon.Name = "btnBuildHeptagon";
            this.btnBuildHeptagon.Size = new System.Drawing.Size(94, 27);
            this.btnBuildHeptagon.TabIndex = 12;
            this.btnBuildHeptagon.Text = "Heptagon";
            this.btnBuildHeptagon.UseVisualStyleBackColor = true;
            this.btnBuildHeptagon.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildPentagon
            // 
            this.btnBuildPentagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildPentagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildPentagon.Location = new System.Drawing.Point(107, 5);
            this.btnBuildPentagon.Name = "btnBuildPentagon";
            this.btnBuildPentagon.Size = new System.Drawing.Size(94, 27);
            this.btnBuildPentagon.TabIndex = 11;
            this.btnBuildPentagon.Text = "Pentagon";
            this.btnBuildPentagon.UseVisualStyleBackColor = true;
            this.btnBuildPentagon.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildSquare
            // 
            this.btnBuildSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildSquare.Location = new System.Drawing.Point(5, 40);
            this.btnBuildSquare.Name = "btnBuildSquare";
            this.btnBuildSquare.Size = new System.Drawing.Size(94, 28);
            this.btnBuildSquare.TabIndex = 10;
            this.btnBuildSquare.Text = "Square";
            this.btnBuildSquare.UseVisualStyleBackColor = true;
            this.btnBuildSquare.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // btnBuildPolygon
            // 
            this.btnBuildPolygon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildPolygon.Location = new System.Drawing.Point(433, 5);
            this.btnBuildPolygon.Name = "btnBuildPolygon";
            this.tableLayoutPanel1.SetRowSpan(this.btnBuildPolygon, 2);
            this.btnBuildPolygon.Size = new System.Drawing.Size(94, 63);
            this.btnBuildPolygon.TabIndex = 9;
            this.btnBuildPolygon.Text = "Close Polygon";
            this.btnBuildPolygon.UseVisualStyleBackColor = true;
            this.btnBuildPolygon.Click += new System.EventHandler(this.btnBuildPolygon_Click);
            // 
            // btnTranslateUp
            // 
            this.btnTranslateUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTranslateUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslateUp.Location = new System.Drawing.Point(535, 5);
            this.btnTranslateUp.Name = "btnTranslateUp";
            this.btnTranslateUp.Size = new System.Drawing.Size(64, 27);
            this.btnTranslateUp.TabIndex = 8;
            this.btnTranslateUp.Text = "Up";
            this.btnTranslateUp.UseVisualStyleBackColor = true;
            this.btnTranslateUp.Click += new System.EventHandler(this.btnTranslateUp_Click);
            // 
            // btnBuildRectangle
            // 
            this.btnBuildRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildRectangle.Location = new System.Drawing.Point(5, 5);
            this.btnBuildRectangle.Name = "btnBuildRectangle";
            this.btnBuildRectangle.Size = new System.Drawing.Size(94, 27);
            this.btnBuildRectangle.TabIndex = 7;
            this.btnBuildRectangle.Text = "Rectangle";
            this.btnBuildRectangle.UseVisualStyleBackColor = true;
            this.btnBuildRectangle.Click += new System.EventHandler(this.btnBuildSpecificPolygon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 796);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.sidebar);
            this.Name = "MainForm";
            this.Text = "Polygon Visualizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label lblMousePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ListView lstVertices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuildDodecagon;
        private System.Windows.Forms.Button btnBuildDecagon;
        private System.Windows.Forms.Button btnBuildOctagon;
        private System.Windows.Forms.Button btnBuildHexagon;
        private System.Windows.Forms.Button btnBuildHeptagon;
        private System.Windows.Forms.Button btnBuildPentagon;
        private System.Windows.Forms.Button btnBuildSquare;
        private System.Windows.Forms.Button btnBuildPolygon;
        private System.Windows.Forms.Button btnTranslateUp;
        private System.Windows.Forms.Button btnBuildRectangle;
        private System.Windows.Forms.Button btnTranslateDown;
        private System.Windows.Forms.Button btnTranslateLeft;
        private System.Windows.Forms.Button btnTranslateRight;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnClearLastVertex;
        private System.Windows.Forms.Button btnClearVertices;
        private System.Windows.Forms.Button btnClearLastPolygon;
        private System.Windows.Forms.Button btnClearPolygons;
        private System.Windows.Forms.ListView lstPolygons;
        private System.Windows.Forms.Label label3;
    }
}

