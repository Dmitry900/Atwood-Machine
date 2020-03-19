using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using Атвуд;

namespace Atwood.Prog
{
   class AtwoodCalc
   {
      static float v = 0;
      static float v_angle = 0;
      static float g = 9.8f;
      public static float[] Compute(float m1, float m2, float md, bool reset, Form2 form2)
      {
         float []data= new float[2];
         float acc = (m1 - m2) * g / (m1 + m2 + md / (2));
         data[0] = v/60 + acc  / (60 * 60 * 2); //изменение коорд. за один фрейм
         data[1] = float.Parse("" + (v_angle / 60 + acc / (60 * 60 * 2 * 1)) * 180 / Math.PI);//изменение угла за фрейм
         if (reset)
         {
            v = 0;
            v_angle = 0;
         }
         else
         {
            v = v + acc / 60;
            v_angle += acc / (1 * 60);
			form2.GR(1 / 60, Math.Abs(v), m1, m2);
         }


         return data;
      }   
   }
}

    
