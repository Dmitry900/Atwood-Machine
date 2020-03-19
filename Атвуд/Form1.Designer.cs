namespace Atwood
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Disk_mass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.PauseBottom = new System.Windows.Forms.Button();
			this.ResetBottom = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Massbody2 = new System.Windows.Forms.TextBox();
			this.Massbody1 = new System.Windows.Forms.TextBox();
			this.StartBottom = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Main_Height = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.TimerLabel = new System.Windows.Forms.Label();
			this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main_Height)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.Disk_mass);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.PauseBottom);
			this.groupBox1.Controls.Add(this.ResetBottom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Massbody2);
			this.groupBox1.Controls.Add(this.Massbody1);
			this.groupBox1.Controls.Add(this.StartBottom);
			this.groupBox1.Location = new System.Drawing.Point(732, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 151);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// Disk_mass
			// 
			this.Disk_mass.Location = new System.Drawing.Point(171, 67);
			this.Disk_mass.Name = "Disk_mass";
			this.Disk_mass.Size = new System.Drawing.Size(100, 20);
			this.Disk_mass.TabIndex = 9;
			this.Disk_mass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Disk_mass_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Блок, кг";
			// 
			// PauseBottom
			// 
			this.PauseBottom.Enabled = false;
			this.PauseBottom.Location = new System.Drawing.Point(90, 101);
			this.PauseBottom.Name = "PauseBottom";
			this.PauseBottom.Size = new System.Drawing.Size(100, 31);
			this.PauseBottom.TabIndex = 7;
			this.PauseBottom.Text = "Пауза";
			this.PauseBottom.UseVisualStyleBackColor = true;
			this.PauseBottom.Click += new System.EventHandler(this.PauseBottom_Click);
			// 
			// ResetBottom
			// 
			this.ResetBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResetBottom.Location = new System.Drawing.Point(9, 101);
			this.ResetBottom.Name = "ResetBottom";
			this.ResetBottom.Size = new System.Drawing.Size(75, 31);
			this.ResetBottom.TabIndex = 6;
			this.ResetBottom.Text = "Сброс";
			this.ResetBottom.UseVisualStyleBackColor = true;
			this.ResetBottom.Click += new System.EventHandler(this.ResetBottom_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Груз 2, кг";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Груз 1, кг";
			// 
			// Massbody2
			// 
			this.Massbody2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Massbody2.Location = new System.Drawing.Point(171, 40);
			this.Massbody2.MaxLength = 9;
			this.Massbody2.Name = "Massbody2";
			this.Massbody2.Size = new System.Drawing.Size(100, 20);
			this.Massbody2.TabIndex = 3;
			this.Massbody2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Massbody2_KeyPress);
			// 
			// Massbody1
			// 
			this.Massbody1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Massbody1.Location = new System.Drawing.Point(171, 10);
			this.Massbody1.MaxLength = 9;
			this.Massbody1.Name = "Massbody1";
			this.Massbody1.Size = new System.Drawing.Size(100, 20);
			this.Massbody1.TabIndex = 2;
			this.Massbody1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Massbody1_KeyPress);
			// 
			// StartBottom
			// 
			this.StartBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.StartBottom.Location = new System.Drawing.Point(196, 101);
			this.StartBottom.Name = "StartBottom";
			this.StartBottom.Size = new System.Drawing.Size(75, 31);
			this.StartBottom.TabIndex = 1;
			this.StartBottom.Text = "Пуск";
			this.StartBottom.UseVisualStyleBackColor = true;
			this.StartBottom.Click += new System.EventHandler(this.StartBottom_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.pictureBox1.Location = new System.Drawing.Point(731, 400);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(289, 270);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// AnT
			// 
			this.AnT.AccumBits = ((byte)(0));
			this.AnT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AnT.AutoCheckErrors = false;
			this.AnT.AutoFinish = false;
			this.AnT.AutoMakeCurrent = true;
			this.AnT.AutoSize = true;
			this.AnT.AutoSwapBuffers = true;
			this.AnT.BackColor = System.Drawing.Color.Black;
			this.AnT.ColorBits = ((byte)(32));
			this.AnT.DepthBits = ((byte)(16));
			this.AnT.Location = new System.Drawing.Point(-8, 28);
			this.AnT.Name = "AnT";
			this.AnT.Size = new System.Drawing.Size(733, 642);
			this.AnT.StencilBits = ((byte)(0));
			this.AnT.TabIndex = 2;
			this.AnT.Load += new System.EventHandler(this.AnT_Load);
			this.AnT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseDown);
			this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
			this.AnT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseUp);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(1, 1);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// помощьToolStripMenuItem
			// 
			this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
			this.помощьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.помощьToolStripMenuItem.Text = "Справка";
			// 
			// timer1
			// 
			this.timer1.Interval = 17;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// Main_Height
			// 
			this.Main_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Main_Height.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Main_Height.Location = new System.Drawing.Point(741, 251);
			this.Main_Height.Maximum = 300;
			this.Main_Height.Minimum = 30;
			this.Main_Height.Name = "Main_Height";
			this.Main_Height.Size = new System.Drawing.Size(262, 45);
			this.Main_Height.TabIndex = 4;
			this.Main_Height.Value = 80;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(741, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Высота установки(от 3 до 30 метров):\r\n";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(741, 314);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Нынешняя высота: 8";
			// 
			// timer2
			// 
			this.timer2.Interval = 10;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// TimerLabel
			// 
			this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TimerLabel.AutoSize = true;
			this.TimerLabel.BackColor = System.Drawing.Color.White;
			this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimerLabel.Location = new System.Drawing.Point(182, 473);
			this.TimerLabel.Name = "TimerLabel";
			this.TimerLabel.Size = new System.Drawing.Size(16, 17);
			this.TimerLabel.TabIndex = 7;
			this.TimerLabel.Text = "0";
			this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TimerLabel.Visible = false;
			// 
			// графикиToolStripMenuItem
			// 
			this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
			this.графикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.графикиToolStripMenuItem.Text = "Графики";
			this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1021, 671);
			this.Controls.Add(this.TimerLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Main_Height);
			this.Controls.Add(this.AnT);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Виртуальная лаборатоная работа:  машина Атвуда";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main_Height)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Massbody2;
        private System.Windows.Forms.TextBox Massbody1;
        private System.Windows.Forms.Button StartBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetBottom;
        private System.Windows.Forms.TrackBar Main_Height;
        private System.Windows.Forms.Button PauseBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Disk_mass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label TimerLabel;
		private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
	}
}

