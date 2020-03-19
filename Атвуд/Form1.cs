using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Атвуд;

namespace Atwood
{
   public partial class Form1 : Form
   {

		Camera cam = new Camera();
		Form2 form2;
		private void InitGL()
      {

         Glut.glutInit();
         float r = 188.0f / 255;
         float g = 210.0f / 255;
         float b = 238.0f / 255;
         Gl.glClearColor(r, g, b, 0.0f);
         Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
         Gl.glViewport(0, 0, AnT.Width, AnT.Height);
         Gl.glMatrixMode(Gl.GL_PROJECTION);
         Gl.glLoadIdentity();

         Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
         //cam.Position_Camera(0, 2, -15, 0, 0, 6, 1, 0, 1);
         cam.Position_Camera(-2.7f, 8.64f, 15.1f, 0, 3, 0, 0, 1, 0);
         Gl.glMatrixMode(Gl.GL_MODELVIEW); Gl.glLoadIdentity();
         Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

         Gl.glEnable(Gl.GL_DEPTH_TEST);
         Gl.glEnable(Gl.GL_LIGHTING);
         Gl.glEnable(Gl.GL_LIGHT0);
         Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
         Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
         Gl.glEnable(Gl.GL_BLEND);
         Gl.glEnable(Gl.GL_LINE_SMOOTH);
         Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, new float[] { 0.5f, 0.5f, 0.5f, 1.0f });


         // Вот тут в инициализации 
         // укажем начальную позицию камеры, взгляда и вертикального вектора.
      }
      float[] MatrixColorOX = { 1, 0, 0, 1 };
      float[] MatrixColorOY = { 0, 1, 0, 1 };
      float[] MatrixColorOZ = { 0, 1, 0, 1 };
      float[] MatrixOXOYColor = { 1, 1, 1, 1 };
      public void LoadTexture(Bitmap textureImage, bool flip)
      {
         if (flip)
         {
            textureImage.RotateFlip(RotateFlipType.Rotate180FlipX);
         }
         Rectangle rectangle = new Rectangle(0, 0, textureImage.Width, textureImage.Height);
         BitmapData bitmapData = textureImage.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
         Gl.glBindTexture(Gl.GL_TEXTURE_2D, 1);
         Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)Gl.GL_RGB8, textureImage.Width, textureImage.Height, 0, Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitmapData.Scan0);
         Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, (int)Gl.GL_LINEAR);
         Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, (int)Gl.GL_LINEAR);
         if (bitmapData != null)
         {
            textureImage.UnlockBits(bitmapData);
         }
      }
      private void DrawGrid(int x)
      {

         // x - количество или длина сетки, quad_size - размер клетки 
         Gl.glPushMatrix(); // Рисуем оси координат, цвет объявлен в самом начале


         Gl.glPopMatrix();
         //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
         LoadTexture(new Bitmap("table.bmp"), true);

         Gl.glEnable(Gl.GL_TEXTURE_2D);

         Gl.glColor3f(1, 1, 1);
         Gl.glBegin(Gl.GL_QUADS);
         Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixOXOYColor);


         Gl.glTexCoord3f(-x, 0, -x); Gl.glVertex3f(-x, 0, -x);
         Gl.glTexCoord3f(x, 0, -x); Gl.glVertex3f(x, 0, -x);
         Gl.glTexCoord3f(x, 0, x); Gl.glVertex3f(x, 0, x);
         Gl.glTexCoord3f(-x, 0, x); Gl.glVertex3f(-x, 0, x);

         Gl.glEnd();

      }

      float[] color = { 1, 0, 1, 1 }, shininess = { 30 };

      Atwood_machine Atwood_machine;
      float Mainheight = 8, Leftheight = 4, Rightheight = 4, angle = 0;
      private void Draw()
      {

         Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
         Gl.glLoadIdentity();

         // установка порта вывода в соответствии с размерами элемента anT 
         Gl.glViewport(0, 0, AnT.Width, AnT.Height);
         // настройка проекции 
         Gl.glMatrixMode(Gl.GL_PROJECTION);
         Gl.glLoadIdentity();
         Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
         cam.Look();
         DrawGrid(10);

         Gl.glMatrixMode(Gl.GL_MODELVIEW);
         Gl.glLoadIdentity();
         // настройка параметров OpenGL для визуализации 

         Gl.glPushMatrix();
         Gl.glTranslated(0, 0, -1);
         Gl.glRotated(0, 0, 0, 0);
         // рисуем цилиндр с помощью библиотеки FreeGLUT
         Atwood_machine.instalation.Height = Mainheight;
         Atwood_machine.Left_rope.Height = Leftheight;
         Atwood_machine.Right_rope.Height = Rightheight;
         Atwood_machine.disk.Angle = angle;

         Gl.glColor3d(1, 1, 255);
         Atwood_machine.Draw();

         Gl.glPopMatrix();
         Gl.glFlush();
         AnT.Invalidate();

      }
      public Form1()
      {
         InitializeComponent();
         AnT.InitializeContexts();
         timer1.Enabled = true;
		}

		
		bool b = false;

      private void Massbody1_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = false;
         if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            return;
         if (e.KeyChar == '.')
            e.KeyChar = ',';
         if (e.KeyChar == ',' && Massbody1.Text.Length != 8)
         {
            if (Massbody1.Text.IndexOf(',') != -1)
               e.Handled = true;
            return;
         }
         if (Char.IsControl(e.KeyChar))
         {
            if (e.KeyChar == (char)Keys.Back)
            {
               e.Handled = false;
               return;
            };
            if (e.KeyChar == (char)Keys.Enter)
               Massbody2.Focus();
         }
         e.Handled = true;
      }


      private void Massbody2_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = false;
         if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            return;
         if (e.KeyChar == '.')
            e.KeyChar = ',';
         if (e.KeyChar == ',' && Massbody2.Text.Length != 8)
         {
            if (Massbody2.Text.IndexOf(',') != -1)
               e.Handled = true;
            return;
         }

         if (Char.IsControl(e.KeyChar))
         {
            if (e.KeyChar == (char)Keys.Back)
            {
               e.Handled = false;
               return;
            };
            if (e.KeyChar == (char)Keys.Enter)
               Disk_mass.Focus();
         }
         e.Handled = true;
      }


      private void Disk_mass_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = false;
         if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            return;
         if (e.KeyChar == '.')
            e.KeyChar = ',';
         if (e.KeyChar == ',' && Disk_mass.Text.Length != 8)
         {
            if (Disk_mass.Text.IndexOf(',') != -1)
               e.Handled = true;
            return;
         }
         if (Char.IsControl(e.KeyChar))
         {
            if (e.KeyChar == (char)Keys.Back)
            {
               e.Handled = false;
               return;
            };
            if (e.KeyChar == (char)Keys.Enter)
               StartBottom.Focus();
         }
         e.Handled = true;
      }
      private void AnT_Load(object sender, EventArgs e)
      {
         InitGL();
         Atwood_machine = new Atwood_machine(1, 2, 5, (float)Main_Height.Value / 10);
         Draw();
      }

      private void Form1_SizeChanged(object sender, EventArgs e)
      {
         Control control = (Control)sender;
         control.Size = new Size(control.Size.Width, control.Size.Height);
         Draw();

      }
      bool mouseRotate, mouseScale, mouseMove = false;
      int myMouseYcoord, myMouseXcoord, myMouseXcoordVar, myMouseYcoordVar;



      float rot_cam_X;



      private void AnT_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
            mouseRotate = true;
         // Если нажата левая кнопка мыши
         if (e.Button == MouseButtons.Middle)
            mouseMove = true;
         if (e.Button == MouseButtons.Right)
            mouseScale = true;
         // Если нажата средняя кнопка мыши 
         myMouseYcoord = e.X;
         // Передаем в нашу глобальную переменную позицию мыши по Х 
         myMouseXcoord = e.Y;
      }

      private void AnT_MouseUp(object sender, MouseEventArgs e)
      {
         mouseRotate = false;
         mouseMove = false;
         mouseScale = false;
      }


      float[] DtDf = new float[2];

      private void StartBottom_Click(object sender, EventArgs e)
      {
         timer2.Start();
         StartBottom.Enabled = false;
         PauseBottom.Enabled = true;
         TimerLabel.Visible = true;
         if (Massbody1.Text == "" || Massbody2.Text == "" || Disk_mass.Text == "")
         {
            MessageBox.Show("Введите все необходимые данные."
                            , "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
            StartBottom.Enabled = true;
            PauseBottom.Enabled = false;
         }
         else
         {
            Atwood_machine.Right_body.Mass = float.Parse(Massbody1.Text);
            Atwood_machine.Leftt_body.Mass = float.Parse(Massbody2.Text);
            Atwood_machine.disk.Mass = float.Parse(Disk_mass.Text);

            DtDf = Prog.AtwoodCalc.Compute(Atwood_machine.Right_body.Mass,
                                            Atwood_machine.Leftt_body.Mass,
                                            Atwood_machine.disk.Mass,
                                            true, form2);

            b = true;
            if (Leftheight >= Atwood_machine.instalation.Height - 1.1)
            {
               Leftheight = Atwood_machine.instalation.Height - 1.1005f;
               Rightheight = Atwood_machine.instalation.Height - Leftheight;

            }
            else
            {
               if (Rightheight >= Atwood_machine.instalation.Height - 1.1)
               {
                  Rightheight = Atwood_machine.instalation.Height - 1.1005f;
                  Leftheight = Atwood_machine.instalation.Height - Rightheight;

               }
            }
         }
         form2 = new Form2(this);

      }
   
      private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			form2.Show();
		}

		private void ResetBottom_Click(object sender, EventArgs e)
      {

         //Main_Height.Value = 80;
         //label4.Text = "Нынешняя высота: 8";
         StartBottom.Enabled = true;
         PauseBottom.Enabled = false;
         timer2.Enabled = false;
         TimerLabel.Visible = false;
         TimerLabel.Text = "0";
         PauseBottom.Text = "Пауза";
         isPaused = false;
         Main_Height.Enabled = true;
         Rightheight = Atwood_machine.instalation.Height / 2;
         Leftheight = Atwood_machine.instalation.Height / 2;
         angle = 0;
         t = 0.0f;
         b = false;

      }
      bool isPaused = false;
      private void PauseBottom_Click(object sender, EventArgs e)
      {
         if (!isPaused)
         {
            b = false;
            timer2.Enabled = false;
            PauseBottom.Text = "Продолжить";
            isPaused = true;
         }
         else
         {
            b = true;
            PauseBottom.Text = "Пауза";
            timer2.Enabled = true;
            isPaused = false;
         }
      }

      private void timer1_Tick_1(object sender, EventArgs e)
      {


         mouse_Events();
         cam.update();
         if (b)
         {
            Main_Height.Enabled = false;
            if (Leftheight < Atwood_machine.instalation.Height - 1.1 && Rightheight < Atwood_machine.instalation.Height - 1.1)
            {
               DtDf = Prog.AtwoodCalc.Compute(Atwood_machine.Right_body.Mass,
                                               Atwood_machine.Leftt_body.Mass,
                                               Atwood_machine.disk.Mass,
                                               false, form2);
               Leftheight = Leftheight - DtDf[0];
               Rightheight = Rightheight + DtDf[0];

               angle += DtDf[1];
               if (angle >= 360)
                  angle -= 360;

            }
            else timer2.Enabled = false;

         }
         else
         {
            if (Mainheight != (float)Main_Height.Value / 10)
            {
               Mainheight = (float)Main_Height.Value / 10;
               Rightheight = Mainheight / 2;
               Leftheight = Mainheight / 2;
               label4.Text = "Нынешняя высота: " + Mainheight;
            }
         }

         Draw();
      }

      float t = 0.0f;
      private void timer2_Tick(object sender, EventArgs e)
      {

         if (timer2.Enabled == true)
         {
            t += 0.01f;
            TimerLabel.Text = $"{t:f2} сек.";
         }

      }
      private void AnT_MouseMove(object sender, MouseEventArgs e)
      {
         myMouseXcoordVar = e.Y;
         myMouseYcoordVar = e.X;

      }

      private void mouse_Events()
      {
         if (mouseRotate == true) // Если нажата левая кнопка мыши 
         {
            AnT.Cursor = System.Windows.Forms.Cursors.SizeAll;
            //меняем указатель 
            cam.Rotate_Position((float)(myMouseYcoordVar - myMouseYcoord), 0, 1, 0);
            // крутим камеру, в моем случае вид у нее от третьего лица 
            rot_cam_X = rot_cam_X + (myMouseXcoordVar - myMouseXcoord);
            if ((rot_cam_X > -40) && (rot_cam_X < 40))
               cam.upDown(((float)(myMouseXcoordVar - myMouseXcoord)) / 10);
            else rot_cam_X = rot_cam_X - (myMouseXcoordVar - myMouseXcoord);
            myMouseYcoord = myMouseYcoordVar;
            myMouseXcoord = myMouseXcoordVar;
         }
         else if (mouseMove == true)
         {
            AnT.Cursor = System.Windows.Forms.Cursors.SizeAll;
            cam.Strafe(-((float)(myMouseXcoordVar - myMouseXcoord)) / 50);
            //myMouseYcoord = myMouseYcoordVar;
            myMouseXcoord = myMouseXcoordVar;
         }
         else if (mouseScale == true)
         {
            AnT.Cursor = System.Windows.Forms.Cursors.SizeAll;
            cam.Scale(((float)(myMouseXcoordVar - myMouseXcoord)) / 50);
            //myMouseYcoord = myMouseYcoordVar;
            myMouseXcoord = myMouseXcoordVar;
         }
         else AnT.Cursor = System.Windows.Forms.Cursors.Default; // возвращаем курсор 

      }
      private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {

      }
   }
}
