namespace Presentation
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PositionLbl = new System.Windows.Forms.Label();
            this.FullnameLbl = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.BornYearLbl = new System.Windows.Forms.Label();
            this.AccessLevelLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.AccessLevelLbl);
            this.panel1.Controls.Add(this.BornYearLbl);
            this.panel1.Controls.Add(this.PositionLbl);
            this.panel1.Controls.Add(this.FullnameLbl);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 320);
            this.panel1.TabIndex = 0;
            // 
            // PositionLbl
            // 
            this.PositionLbl.AutoSize = true;
            this.PositionLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLbl.ForeColor = System.Drawing.Color.White;
            this.PositionLbl.Location = new System.Drawing.Point(15, 74);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Size = new System.Drawing.Size(133, 22);
            this.PositionLbl.TabIndex = 2;
            this.PositionLbl.Text = "PositionLabel";
            // 
            // FullnameLbl
            // 
            this.FullnameLbl.AutoSize = true;
            this.FullnameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLbl.ForeColor = System.Drawing.Color.White;
            this.FullnameLbl.Location = new System.Drawing.Point(15, 34);
            this.FullnameLbl.Name = "FullnameLbl";
            this.FullnameLbl.Size = new System.Drawing.Size(144, 22);
            this.FullnameLbl.TabIndex = 1;
            this.FullnameLbl.Text = "WelcomeLabel";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.Location = new System.Drawing.Point(207, 258);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(47, 50);
            this.LogoutBtn.TabIndex = 0;
            this.LogoutBtn.TabStop = false;
            this.LogoutBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(113)))));
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(113)))));
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Cyan;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(274, -17);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(496, 362);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(574, 320);
            this.shapeContainer2.TabIndex = 1;
            this.shapeContainer2.TabStop = false;
            // 
            // BornYearLbl
            // 
            this.BornYearLbl.AutoSize = true;
            this.BornYearLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornYearLbl.ForeColor = System.Drawing.Color.White;
            this.BornYearLbl.Location = new System.Drawing.Point(15, 114);
            this.BornYearLbl.Name = "BornYearLbl";
            this.BornYearLbl.Size = new System.Drawing.Size(86, 22);
            this.BornYearLbl.TabIndex = 3;
            this.BornYearLbl.Text = "BYLabel";
            // 
            // AccessLevelLbl
            // 
            this.AccessLevelLbl.AutoSize = true;
            this.AccessLevelLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessLevelLbl.ForeColor = System.Drawing.Color.White;
            this.AccessLevelLbl.Location = new System.Drawing.Point(15, 154);
            this.AccessLevelLbl.Name = "AccessLevelLbl";
            this.AccessLevelLbl.Size = new System.Drawing.Size(85, 22);
            this.AccessLevelLbl.TabIndex = 4;
            this.AccessLevelLbl.Text = "ALLabel";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(15, 194);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(103, 22);
            this.DateLbl.TabIndex = 5;
            this.DateLbl.Text = "DateLabel";
            // 
            // MinBtn
            // 
            this.MinBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinBtn.Image")));
            this.MinBtn.Location = new System.Drawing.Point(12, 268);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(43, 40);
            this.MinBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinBtn.TabIndex = 6;
            this.MinBtn.TabStop = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.PictureBox LogoutBtn;
        private System.Windows.Forms.Label FullnameLbl;
        private System.Windows.Forms.Label PositionLbl;
        private System.Windows.Forms.Label BornYearLbl;
        private System.Windows.Forms.Label AccessLevelLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.PictureBox MinBtn;
    }
}