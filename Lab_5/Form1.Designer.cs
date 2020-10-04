namespace Lab_5 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            picture = new System.Windows.Forms.PictureBox();
            x_in = new System.Windows.Forms.TextBox();
            y_in = new System.Windows.Forms.TextBox();
            a_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.draw_button = new System.Windows.Forms.Button();
            A_point = new System.Windows.Forms.Label();
            B_point = new System.Windows.Forms.Label();
            C_point = new System.Windows.Forms.Label();
            D_point = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            picture.BackColor = System.Drawing.SystemColors.ControlText;
            picture.Dock = System.Windows.Forms.DockStyle.Bottom;
            picture.Location = new System.Drawing.Point(0, 95);
            picture.Name = "picture";
            picture.Size = new System.Drawing.Size(719, 458);
            picture.TabIndex = 0;
            picture.TabStop = false;
            picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // x_in
            // 
            x_in.Location = new System.Drawing.Point(45, 34);
            x_in.Name = "x_in";
            x_in.Size = new System.Drawing.Size(48, 20);
            x_in.TabIndex = 1;
            // 
            // y_in
            // 
            y_in.Location = new System.Drawing.Point(120, 34);
            y_in.Name = "y_in";
            y_in.Size = new System.Drawing.Size(48, 20);
            y_in.TabIndex = 2;
            // 
            // a_in
            // 
            a_in.Location = new System.Drawing.Point(205, 34);
            a_in.Name = "a_in";
            a_in.Size = new System.Drawing.Size(104, 20);
            a_in.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter coordinates of square:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter the side length:";
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(315, 32);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(48, 23);
            this.draw_button.TabIndex = 8;
            this.draw_button.Text = "Draw";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // A_point
            // 
            A_point.AutoSize = true;
            A_point.Location = new System.Drawing.Point(397, 10);
            A_point.Name = "A_point";
            A_point.Size = new System.Drawing.Size(35, 13);
            A_point.TabIndex = 9;
            A_point.Text = "A(_,_)";
            // 
            // B_point
            // 
            B_point.AutoSize = true;
            B_point.Location = new System.Drawing.Point(462, 10);
            B_point.Name = "B_point";
            B_point.Size = new System.Drawing.Size(35, 13);
            B_point.TabIndex = 10;
            B_point.Text = "B(_,_)";
            // 
            // C_point
            // 
            C_point.AutoSize = true;
            C_point.Location = new System.Drawing.Point(397, 62);
            C_point.Name = "C_point";
            C_point.Size = new System.Drawing.Size(35, 13);
            C_point.TabIndex = 11;
            C_point.Text = "C(_,_)";
            // 
            // D_point
            // 
            D_point.AutoSize = true;
            D_point.Location = new System.Drawing.Point(462, 62);
            D_point.Name = "D_point";
            D_point.Size = new System.Drawing.Size(36, 13);
            D_point.TabIndex = 12;
            D_point.Text = "D(_,_)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 553);
            this.Controls.Add(D_point);
            this.Controls.Add(C_point);
            this.Controls.Add(B_point);
            this.Controls.Add(A_point);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);           
            this.Controls.Add(this.label1);
            this.Controls.Add(a_in);
            this.Controls.Add(y_in);
            this.Controls.Add(x_in);
            this.Controls.Add(picture);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button draw_button;
        public static System.Windows.Forms.PictureBox picture;
        public static System.Windows.Forms.TextBox x_in;
        public static System.Windows.Forms.TextBox y_in;
        public static System.Windows.Forms.TextBox a_in;
        public static System.Windows.Forms.Label A_point;
        public static System.Windows.Forms.Label B_point;
        public static System.Windows.Forms.Label C_point;
        public static System.Windows.Forms.Label D_point;
    }
}

