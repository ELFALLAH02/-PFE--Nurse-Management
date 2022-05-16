
namespace _PFE__Nurse_Management
{
    partial class basecontroladd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderThickness = 5;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(35, 22);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 30;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(893, 541);
            this.guna2Shapes1.TabIndex = 0;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            this.guna2Shapes1.Click += new System.EventHandler(this.guna2Shapes1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(65, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 495);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // basecontroladd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "basecontroladd";
            this.Size = new System.Drawing.Size(964, 573);
            this.Load += new System.EventHandler(this.basecontroladd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Panel panel1;
    }
}
