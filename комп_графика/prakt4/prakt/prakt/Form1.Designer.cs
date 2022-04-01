
namespace prakt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.Rotate_X = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rotate_angle = new System.Windows.Forms.TextBox();
            this.Mirror_X = new System.Windows.Forms.Button();
            this.Mirror_Y = new System.Windows.Forms.Button();
            this.Rotate_Y = new System.Windows.Forms.Button();
            this.Rotate_Z = new System.Windows.Forms.Button();
            this.Mirror_Z = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1187, 650);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(12, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Rotate_X
            // 
            this.Rotate_X.Location = new System.Drawing.Point(12, 41);
            this.Rotate_X.Name = "Rotate_X";
            this.Rotate_X.Size = new System.Drawing.Size(75, 23);
            this.Rotate_X.TabIndex = 7;
            this.Rotate_X.Text = "Rotate_X";
            this.Rotate_X.UseVisualStyleBackColor = true;
            this.Rotate_X.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rotate angle";
            // 
            // rotate_angle
            // 
            this.rotate_angle.Location = new System.Drawing.Point(12, 143);
            this.rotate_angle.Name = "rotate_angle";
            this.rotate_angle.Size = new System.Drawing.Size(73, 23);
            this.rotate_angle.TabIndex = 9;
            this.rotate_angle.Text = "0";
            // 
            // Mirror_X
            // 
            this.Mirror_X.Location = new System.Drawing.Point(10, 172);
            this.Mirror_X.Name = "Mirror_X";
            this.Mirror_X.Size = new System.Drawing.Size(75, 23);
            this.Mirror_X.TabIndex = 10;
            this.Mirror_X.Text = "Mirror XoY";
            this.Mirror_X.UseVisualStyleBackColor = true;
            this.Mirror_X.Click += new System.EventHandler(this.Mirror_X_Click);
            // 
            // Mirror_Y
            // 
            this.Mirror_Y.Location = new System.Drawing.Point(10, 201);
            this.Mirror_Y.Name = "Mirror_Y";
            this.Mirror_Y.Size = new System.Drawing.Size(75, 23);
            this.Mirror_Y.TabIndex = 11;
            this.Mirror_Y.Text = "Mirror YoZ";
            this.Mirror_Y.UseVisualStyleBackColor = true;
            this.Mirror_Y.Click += new System.EventHandler(this.Mirror_Y_Click);
            // 
            // Rotate_Y
            // 
            this.Rotate_Y.Location = new System.Drawing.Point(12, 70);
            this.Rotate_Y.Name = "Rotate_Y";
            this.Rotate_Y.Size = new System.Drawing.Size(75, 23);
            this.Rotate_Y.TabIndex = 18;
            this.Rotate_Y.Text = "Rotate_Y";
            this.Rotate_Y.UseVisualStyleBackColor = true;
            this.Rotate_Y.Click += new System.EventHandler(this.Rotate_Y_Click);
            // 
            // Rotate_Z
            // 
            this.Rotate_Z.Location = new System.Drawing.Point(12, 99);
            this.Rotate_Z.Name = "Rotate_Z";
            this.Rotate_Z.Size = new System.Drawing.Size(75, 23);
            this.Rotate_Z.TabIndex = 19;
            this.Rotate_Z.Text = "Rotate_Z";
            this.Rotate_Z.UseVisualStyleBackColor = true;
            this.Rotate_Z.Click += new System.EventHandler(this.Rotate_Z_Click);
            // 
            // Mirror_Z
            // 
            this.Mirror_Z.Location = new System.Drawing.Point(10, 230);
            this.Mirror_Z.Name = "Mirror_Z";
            this.Mirror_Z.Size = new System.Drawing.Size(75, 23);
            this.Mirror_Z.TabIndex = 24;
            this.Mirror_Z.Text = "Mirror ZoX";
            this.Mirror_Z.UseVisualStyleBackColor = true;
            this.Mirror_Z.Click += new System.EventHandler(this.Mirror_Z_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Mirr+proect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mirror_Z);
            this.Controls.Add(this.Rotate_Z);
            this.Controls.Add(this.Rotate_Y);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.rotate_angle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mirror_X);
            this.Controls.Add(this.Rotate_X);
            this.Controls.Add(this.Mirror_Y);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Canvas";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Rotate_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rotate_angle;
        private System.Windows.Forms.Button Mirror_X;
        private System.Windows.Forms.Button Mirror_Y;
        private System.Windows.Forms.Button Rotate_Y;
        private System.Windows.Forms.Button Rotate_Z;
        private System.Windows.Forms.Button Mirror_Z;
        private System.Windows.Forms.Button button1;
    }
}

