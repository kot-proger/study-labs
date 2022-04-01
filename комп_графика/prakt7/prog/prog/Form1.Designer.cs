
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
            this.components = new System.ComponentModel.Container();
            this.canvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figute_choice = new System.Windows.Forms.ToolStripMenuItem();
            this.stripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.canvas.Location = new System.Drawing.Point(11, 27);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(848, 536);
            this.canvas.StencilBits = ((byte)(0));
            this.canvas.TabIndex = 0;
            this.canvas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.canvas_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figute_choice,
            this.materialToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figute_choice
            // 
            this.figute_choice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripToolStripMenuItem});
            this.figute_choice.Name = "figute_choice";
            this.figute_choice.Size = new System.Drawing.Size(52, 20);
            this.figute_choice.Text = "Figure";
            // 
            // stripToolStripMenuItem
            // 
            this.stripToolStripMenuItem.Name = "stripToolStripMenuItem";
            this.stripToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stripToolStripMenuItem.Text = "Reset";
            this.stripToolStripMenuItem.Click += new System.EventHandler(this.stripToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\nRotate on timer - R\r\n";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ambientToolStripMenuItem,
            this.diffuseToolStripMenuItem,
            this.specularToolStripMenuItem,
            this.emissionToolStripMenuItem});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.yToolStripMenuItem,
            this.zToolStripMenuItem});
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yToolStripMenuItem.Text = "Y";
            this.yToolStripMenuItem.Click += new System.EventHandler(this.yToolStripMenuItem_Click);
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zToolStripMenuItem.Text = "Z";
            this.zToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // ambientToolStripMenuItem
            // 
            this.ambientToolStripMenuItem.Name = "ambientToolStripMenuItem";
            this.ambientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ambientToolStripMenuItem.Text = "Ambient";
            this.ambientToolStripMenuItem.Click += new System.EventHandler(this.ambientToolStripMenuItem_Click);
            // 
            // diffuseToolStripMenuItem
            // 
            this.diffuseToolStripMenuItem.Name = "diffuseToolStripMenuItem";
            this.diffuseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diffuseToolStripMenuItem.Text = "Diffuse";
            this.diffuseToolStripMenuItem.Click += new System.EventHandler(this.diffuseToolStripMenuItem_Click);
            // 
            // specularToolStripMenuItem
            // 
            this.specularToolStripMenuItem.Name = "specularToolStripMenuItem";
            this.specularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.specularToolStripMenuItem.Text = "Specular";
            this.specularToolStripMenuItem.Click += new System.EventHandler(this.specularToolStripMenuItem_Click);
            // 
            // emissionToolStripMenuItem
            // 
            this.emissionToolStripMenuItem.Name = "emissionToolStripMenuItem";
            this.emissionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emissionToolStripMenuItem.Text = "Emission";
            this.emissionToolStripMenuItem.Click += new System.EventHandler(this.emissionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 626);
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
        private System.Windows.Forms.ToolStripMenuItem stripToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffuseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
    }
}

