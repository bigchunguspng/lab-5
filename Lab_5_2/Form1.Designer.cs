using System.ComponentModel;
using System.Windows.Forms;

namespace Lab_5_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            height_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            radius1_in = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            radius2_in = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            volume_label = new System.Windows.Forms.Label();
            area_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            slant_in = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // height_in
            // 
            height_in.Location = new System.Drawing.Point(221, 30);
            height_in.Name = "height_in";
            height_in.Size = new System.Drawing.Size(48, 20);
            height_in.TabIndex = 0;
            height_in.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter cone parameters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "h:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "r1:";
            // 
            // radius1_in
            // 
            radius1_in.Location = new System.Drawing.Point(221, 56);
            radius1_in.Name = "radius1_in";
            radius1_in.Size = new System.Drawing.Size(48, 20);
            radius1_in.TabIndex = 3;
            radius1_in.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "r2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radius2_in
            // 
            radius2_in.Location = new System.Drawing.Point(221, 82);
            radius2_in.Name = "radius2_in";
            radius2_in.Size = new System.Drawing.Size(48, 20);
            radius2_in.TabIndex = 5;
            radius2_in.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_5_2.Properties.Resources.CroppedCone_svg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Lab_5_2.Properties.Resources._800px_Stozek_schemat_svg;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // volume_label
            // 
            volume_label.AutoSize = true;
            volume_label.Location = new System.Drawing.Point(209, 152);
            volume_label.Name = "volume_label";
            volume_label.Size = new System.Drawing.Size(45, 13);
            volume_label.TabIndex = 9;
            volume_label.Text = "Volume:";
            // 
            // area_label
            // 
            area_label.AutoSize = true;
            area_label.Location = new System.Drawing.Point(196, 175);
            area_label.Name = "area_label";
            area_label.Size = new System.Drawing.Size(58, 13);
            area_label.TabIndex = 10;
            area_label.Text = "Base area:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "s:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slant_in
            // 
            slant_in.Location = new System.Drawing.Point(221, 108);
            slant_in.Name = "slant_in";
            slant_in.Size = new System.Drawing.Size(48, 20);
            slant_in.TabIndex = 11;
            slant_in.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 359);
            this.Controls.Add(label5);
            this.Controls.Add(slant_in);
            this.Controls.Add(area_label);
            this.Controls.Add(volume_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(radius2_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(radius1_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(height_in);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        public static TextBox height_in;
        public static TextBox radius1_in;
        public static TextBox radius2_in;
        public static Label volume_label;
        public static Label area_label;
        public static TextBox slant_in;
    }
}