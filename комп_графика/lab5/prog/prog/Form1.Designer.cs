
namespace prog
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figute_choice = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set_fig = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AccumBits = ((byte)(0));
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.AutoCheckErrors = false;
            this.canvas.AutoFinish = false;
            this.canvas.AutoMakeCurrent = true;
            this.canvas.AutoSwapBuffers = true;
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.ColorBits = ((byte)(32));
            this.canvas.DepthBits = ((byte)(16));
            this.canvas.Location = new System.Drawing.Point(12, 27);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1122, 486);
            this.canvas.StencilBits = ((byte)(0));
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.canvas_keydown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figute_choice,
            this.set_fig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figute_choice
            // 
            this.figute_choice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.figute_choice.Name = "figute_choice";
            this.figute_choice.Size = new System.Drawing.Size(52, 23);
            this.figute_choice.Text = "Figure";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // set_fig
            // 
            this.set_fig.Items.AddRange(new object[] {
            "A",
            "B"});
            this.set_fig.Name = "set_fig";
            this.set_fig.Size = new System.Drawing.Size(121, 23);
            this.set_fig.Text = "Select figure";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "WASD - движение\r\nRF - поворот\r\nQE - масштабирование\r\n\r\nZX - вращение фигуры А вок" +
    "руг В \r\nV - \"ZX\" в цикле\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl canvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figute_choice;
        private System.Windows.Forms.ToolStripComboBox set_fig;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

