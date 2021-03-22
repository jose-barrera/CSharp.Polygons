
namespace Polygons
{
    partial class InfoForm
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
            this.lblPolygon = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCentroid = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPolygon
            // 
            this.lblPolygon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolygon.ForeColor = System.Drawing.Color.Green;
            this.lblPolygon.Location = new System.Drawing.Point(0, 0);
            this.lblPolygon.Name = "lblPolygon";
            this.lblPolygon.Size = new System.Drawing.Size(370, 30);
            this.lblPolygon.TabIndex = 0;
            this.lblPolygon.Text = "Class: ";
            this.lblPolygon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Green;
            this.lblArea.Location = new System.Drawing.Point(0, 60);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(370, 30);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.ForeColor = System.Drawing.Color.Green;
            this.lblPerimeter.Location = new System.Drawing.Point(0, 90);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(370, 30);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "Perimeter:";
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSides
            // 
            this.lblSides.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSides.ForeColor = System.Drawing.Color.Green;
            this.lblSides.Location = new System.Drawing.Point(0, 30);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(370, 30);
            this.lblSides.TabIndex = 3;
            this.lblSides.Text = "Sides:";
            this.lblSides.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.Green;
            this.lblColor.Location = new System.Drawing.Point(0, 150);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(370, 30);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCentroid
            // 
            this.lblCentroid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCentroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroid.ForeColor = System.Drawing.Color.Green;
            this.lblCentroid.Location = new System.Drawing.Point(0, 120);
            this.lblCentroid.Name = "lblCentroid";
            this.lblCentroid.Size = new System.Drawing.Size(370, 30);
            this.lblCentroid.TabIndex = 5;
            this.lblCentroid.Text = "Centroid:";
            this.lblCentroid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(149, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 239);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCentroid);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.lblPolygon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Polygon Information";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPolygon;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCentroid;
        private System.Windows.Forms.Button btnOk;
    }
}