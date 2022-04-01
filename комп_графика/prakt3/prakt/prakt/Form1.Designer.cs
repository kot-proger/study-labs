
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
            this.MoveButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.x_move = new System.Windows.Forms.TextBox();
            this.y_move = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rotate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rotate_angle = new System.Windows.Forms.TextBox();
            this.Mirror_X = new System.Windows.Forms.Button();
            this.Mirror_Y = new System.Windows.Forms.Button();
            this.ScaleButton = new System.Windows.Forms.Button();
            this.scale_x_box = new System.Windows.Forms.TextBox();
            this.scale_y_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(12, 41);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(75, 23);
            this.MoveButton.TabIndex = 1;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.Move_Click);
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
            // x_move
            // 
            this.x_move.Location = new System.Drawing.Point(39, 70);
            this.x_move.Name = "x_move";
            this.x_move.Size = new System.Drawing.Size(48, 23);
            this.x_move.TabIndex = 3;
            this.x_move.Text = "0";
            // 
            // y_move
            // 
            this.y_move.Location = new System.Drawing.Point(39, 99);
            this.y_move.Name = "y_move";
            this.y_move.Size = new System.Drawing.Size(48, 23);
            this.y_move.TabIndex = 4;
            this.y_move.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(12, 128);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(75, 23);
            this.Rotate.TabIndex = 7;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rotate angle";
            // 
            // rotate_angle
            // 
            this.rotate_angle.Location = new System.Drawing.Point(12, 172);
            this.rotate_angle.Name = "rotate_angle";
            this.rotate_angle.Size = new System.Drawing.Size(73, 23);
            this.rotate_angle.TabIndex = 9;
            this.rotate_angle.Text = "0";
            // 
            // Mirror_X
            // 
            this.Mirror_X.Location = new System.Drawing.Point(8, 288);
            this.Mirror_X.Name = "Mirror_X";
            this.Mirror_X.Size = new System.Drawing.Size(75, 23);
            this.Mirror_X.TabIndex = 10;
            this.Mirror_X.Text = "Mirror X";
            this.Mirror_X.UseVisualStyleBackColor = true;
            this.Mirror_X.Click += new System.EventHandler(this.Mirror_X_Click);
            // 
            // Mirror_Y
            // 
            this.Mirror_Y.Location = new System.Drawing.Point(8, 317);
            this.Mirror_Y.Name = "Mirror_Y";
            this.Mirror_Y.Size = new System.Drawing.Size(75, 23);
            this.Mirror_Y.TabIndex = 11;
            this.Mirror_Y.Text = "Mirror Y";
            this.Mirror_Y.UseVisualStyleBackColor = true;
            this.Mirror_Y.Click += new System.EventHandler(this.Mirror_Y_Click);
            // 
            // ScaleButton
            // 
            this.ScaleButton.Location = new System.Drawing.Point(10, 201);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(75, 23);
            this.ScaleButton.TabIndex = 12;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.Click += new System.EventHandler(this.Scale_Click);
            // 
            // scale_x_box
            // 
            this.scale_x_box.Location = new System.Drawing.Point(39, 230);
            this.scale_x_box.Name = "scale_x_box";
            this.scale_x_box.Size = new System.Drawing.Size(44, 23);
            this.scale_x_box.TabIndex = 14;
            this.scale_x_box.Text = "1";
            // 
            // scale_y_box
            // 
            this.scale_y_box.Location = new System.Drawing.Point(39, 259);
            this.scale_y_box.Name = "scale_y_box";
            this.scale_y_box.Size = new System.Drawing.Size(44, 23);
            this.scale_y_box.TabIndex = 15;
            this.scale_y_box.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 650);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.rotate_angle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x_move);
            this.Controls.Add(this.Mirror_X);
            this.Controls.Add(this.scale_y_box);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.y_move);
            this.Controls.Add(this.Mirror_Y);
            this.Controls.Add(this.scale_x_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleButton);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Canvas";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox x_move;
        private System.Windows.Forms.TextBox y_move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rotate_angle;
        private System.Windows.Forms.Button Mirror_X;
        private System.Windows.Forms.Button Mirror_Y;
        private System.Windows.Forms.Button ScaleButton;
        private System.Windows.Forms.TextBox scale_x_box;
        private System.Windows.Forms.TextBox scale_y_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

