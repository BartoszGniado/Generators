using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            xxx = rnd.Next() % 3;
            //    frstPxl = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        Bitmap bitmap;
        Color frstPxl;
        Noiz nnn;
        Noiz nnnn;
        Noiz nn;
        Noiz nn4;
        Noiz nn1;
        Noiz nn2;
        Noiz nn3;
        Noiz nnnnn;
        int w,h;
        int r, g, b;
        Random rnd = new Random();
        private void pictureBox1_Clickll(object sender, EventArgs e)
        {
            nnn = new Noiz(rnd.Next() % 99);
            nnnn = new Noiz(rnd.Next() % 99);
            nn = new Noiz((rnd.Next() % 99) - 20);
            nn1 = new Noiz(rnd.Next(99));
            nn2 = new Noiz(rnd.Next(99));
            nn3 = new Noiz(rnd.Next(99));
            nn4 = new Noiz(rnd.Next(99));
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int srW = pictureBox1.Width / 2;
            int srH = pictureBox1.Height / 2;
            bitmap.SetPixel(srW, srH, Color.FromArgb(255, 255, 255));
            bitmap.SetPixel(srW, srH+1, Color.FromArgb(255, 255, 255));
            bitmap.SetPixel(srW, srH-1, Color.FromArgb(255, 255, 255));
            #region fory
            for (w = srW + 1; w < pictureBox1.Width; w++)
                bitmap.SetPixel(w, srH, Color.FromArgb(
                                                    // 255,255,255
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).R),
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).G),
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).B)
                                                    ));
            for (w = srW - 1; w > 0; w--)
                bitmap.SetPixel(w, srH, Color.FromArgb(
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).R),
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).G),
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).B)
                                                    ));

            for (w = srW + 1; w < pictureBox1.Width; w++)
            {
                bitmap.SetPixel(w, srH + 1, Color.FromArgb(
                                                    // 255,255,255
                                                    (nn.DoTheThing(bitmap.GetPixel(w - 1, srH - 1).R) + nn.DoTheThing(bitmap.GetPixel(w - 1, srH).R)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w - 1, srH - 1).G) + nn.DoTheThing(bitmap.GetPixel(w - 1, srH).G)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w - 1, srH - 1).B) + nn.DoTheThing(bitmap.GetPixel(w - 1, srH).B)) / 2
                                                    ));
                bitmap.SetPixel(w, srH - 1, Color.FromArgb(
                                                    // 255,255,255
                                                    (nn.DoTheThing(bitmap.GetPixel(w - 1, srH + 1).R) + nn.DoTheThing(bitmap.GetPixel(w - 1, srH).R)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w - 1, srH + 1).G) + nn.DoTheThing(bitmap.GetPixel(w - 1, srH).G)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w - 1, srH + 1).B) + nn.DoTheThing(bitmap.GetPixel(w - 1, srH).B)) / 2
                                                    ));
            }
            for (w = srW - 1; w > 0; w--)
            {
                bitmap.SetPixel(w, srH + 1, Color.FromArgb(
                                                    (nn.DoTheThing(bitmap.GetPixel(w + 1, srH - 1).R) + nn.DoTheThing(bitmap.GetPixel(w + 1, srH).R)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w + 1, srH - 1).G) + nn.DoTheThing(bitmap.GetPixel(w + 1, srH).G)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w + 1, srH - 1).B) + nn.DoTheThing(bitmap.GetPixel(w + 1, srH).B)) / 2
                                                    ));
                bitmap.SetPixel(w, srH - 1, Color.FromArgb(
                                                    (nn.DoTheThing(bitmap.GetPixel(w + 1, srH + 1).R) + nn.DoTheThing(bitmap.GetPixel(w + 1, srH).R)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w + 1, srH + 1).G) + nn.DoTheThing(bitmap.GetPixel(w + 1, srH).G)) / 2,
                                                    (nn.DoTheThing(bitmap.GetPixel(w + 1, srH + 1).B) + nn.DoTheThing(bitmap.GetPixel(w + 1, srH).B)) / 2
                                                    ));
            }
            
                
            #endregion fory


            for (h = srH - 2; h > 0; h--)
                for (w = pictureBox1.Width - 9; w > 9; w--)
                {

                    bitmap.SetPixel(w, h, Color.FromArgb(
                               (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + rnd.Next(3) + 1).R) + nn1.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + rnd.Next(3) + 1).R)) / 2,
                                (nn4.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + rnd.Next(3) + 1).G) + nn2.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + rnd.Next(3) + 1).G)) / 2,
                                 (nn4.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + rnd.Next(3) + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + rnd.Next(3) + 1).B)) / 2
                            //   r, g, b
                            ));
                }

            for (h = srH + 2; h < pictureBox1.Height; h++)
                for (w = 9; w < pictureBox1.Width - 9; w++)
                    bitmap.SetPixel(w, h, Color.FromArgb(

                                     (nn3.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - rnd.Next(3) - 1).R) + nn1.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - rnd.Next(3) - 1).R)) / 2,
                                     (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - rnd.Next(3) - 1).G) + nn2.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - rnd.Next(3) - 1).G)) / 2,
                                     (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - rnd.Next(3) - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - rnd.Next(3) - 1).B)) / 2
                                                        ));

            pictureBox1.Image = bitmap;
            bitmap.Save("bity.jpg");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nnn = new Noiz(rnd.Next() % 88 +11);
            nnnn = new Noiz(rnd.Next() % 88 + 11);
            nn = new Noiz(rnd.Next() % 88 + 11);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int srW = pictureBox1.Width / 2;
            int srH = pictureBox1.Height / 2;
            int r, x, y;
            int alf;
            double wsp22 = 14;
            //for (h = 0; h < pictureBox1.Height; h++)
            //    for (w = 0; w < pictureBox1.Width; w++)
            //        bitmap.SetPixel(w, h, Color.Black);
            bitmap.SetPixel(srW, srH, Color.FromArgb(1,1,1));
            #region fory

            for (r = 1; r < 7; r++)
                for (alf = 0; alf < 77; alf++)
                {
                    x = srW + (int)(Math.Sin((alf / 77.0) * 2 * Math.PI) * r);
                    y = srH + (int)(Math.Cos((alf / 77.0) * 2 * Math.PI) * r);
                    bitmap.SetPixel(x, y, Color.FromArgb(
                        11,11,11
                        ));
                }
            #endregion fory
            
          //  x1 = 22;
            int r1 = 13;

            for (r = 6; r < srH - 5; r++)
                for (alf = 0; alf < wsp22 * r; alf++)
                {
                    int x1 = rnd.Next(22);
                    int x2 = rnd.Next(7);
               //     x2 = 0;
                    x = srW + (int)(Math.Sin((alf / (wsp22 * r)) * 2 * Math.PI) * r);
                    y = srH + (int)(Math.Cos((alf / (wsp22 * r)) * 2 * Math.PI) * r);
                    int xt  = srW + (int)(Math.Sin(((alf + (x1-x2)) / (wsp22 * r)) * 2 * Math.PI) * (r - 4 - rnd.Next(3)));
                    int yt  = srH + (int)(Math.Cos(((alf + (x1 - x2)) / (wsp22 * r)) * 2 * Math.PI) * (r - 4 - rnd.Next(3)));
                    int xt1 = srW + (int)(Math.Sin(((alf + (x1 - x2)) / (wsp22 * r)) * 2 * Math.PI) * (r - 4 - rnd.Next(3)));
                    int yt1 = srH + (int)(Math.Cos(((alf + (x1 - x2)) / (wsp22 * r)) * 2 * Math.PI) * (r - 4 - rnd.Next(3)));
                    

                    bitmap.SetPixel(x, y, Color.FromArgb(
                                (nnn.DoTheThing(bitmap.GetPixel(xt, yt).R) + nn.DoTheThing(bitmap.GetPixel(xt1, yt1).R)) / 2,
                                (nnnn.DoTheThing(bitmap.GetPixel(xt, yt).G)+ nnn.DoTheThing(bitmap.GetPixel(xt1, yt1).G)) / 2,
                                (nn.DoTheThing(bitmap.GetPixel(xt, yt).B)+ nnnn.DoTheThing(bitmap.GetPixel(xt1, yt1).B)) / 2
                        ));
                }

            //for (h = srH - 1; h > 0; h--)
            //    for (w = pictureBox1.Width - 9; w > 9; w--)
            //    {

            //        bitmap.SetPixel(w, h, Color.FromArgb(
            //                   (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).R) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).R)) / 2,
            //                    (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).G) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).G)) / 2,
            //                     (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).B)) / 2
            //                //   r, g, b
            //                ));
            //    }

            //for (h = srH + 1; h < pictureBox1.Height ; h++)
            //    for (w = 9; w < pictureBox1.Width - 9; w++)
            //        bitmap.SetPixel(w, h, Color.FromArgb(

            //                                           (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).R) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).R)) / 2,
            //                                           (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).G) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).G)) / 2,
            //                                           (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).B)) / 2
            //                                            ));

            pictureBox1.Image = bitmap;
            bitmap.Save("bity.jpg");
        }
        private void pictureBox1_Click3(object sender, EventArgs e)
        {
            nnn = new Noiz(rnd.Next() % 99);
            nnnn = new Noiz(rnd.Next() % 99);
            nn = new Noiz((rnd.Next() % 99) - 20);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int srW = pictureBox1.Width / 2;
            int srH = pictureBox1.Height / 2;
            bitmap.SetPixel(srW, srH, Color.FromArgb(255, 255, 255));
            #region fory
            for (w = srW + 1; w < pictureBox1.Width; w++)
                bitmap.SetPixel(w, srH, Color.FromArgb(
                                                    // 255,255,255
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).R),
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).G),
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).B)
                                                    ));
            for (w = srW - 1; w > 0; w--)
                bitmap.SetPixel(w, srH, Color.FromArgb(
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).R),
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).G),
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).B)
                                                    ));
            #endregion fory


            for (h = srH - 1; h > 0; h--)
                for (w = pictureBox1.Width - 9; w > 9; w--)
                {

                    bitmap.SetPixel(w, h, Color.FromArgb(
                               (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).R) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).R)) / 2,
                                (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).G) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).G)) / 2,
                                 (nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h + 1).B)) / 2
                            //   r, g, b
                            ));
                }

            for (h = srH + 1; h < pictureBox1.Height; h++)
                for (w = 9; w < pictureBox1.Width - 9; w++)
                    bitmap.SetPixel(w, h, Color.FromArgb(

                                                       (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).R) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).R)) / 2,
                                                       (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).G) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).G)) / 2,
                                                       (nnnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + rnd.Next(7) - 3, h - 1).B)) / 2
                                                        ));

            pictureBox1.Image = bitmap;
            bitmap.Save("bity.jpg");
        }
        private void pictureBox1_Click2(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int srW = pictureBox1.Width / 2;
            int srH = pictureBox1.Height / 2;
            bitmap.SetPixel(srW, srH, Color.FromArgb(255, 255, 255));
            for (w = srW + 1; w < pictureBox1.Width; w++)
                bitmap.SetPixel(w, srH, Color.FromArgb(
                                                    // 255,255,255
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).R),
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).G),
                                                    nn.DoTheThing(bitmap.GetPixel(w - 1, srH).B)
                                                    ));
            for (h = srH + 1; h < pictureBox1.Height; h++)
                bitmap.SetPixel(srW, h, Color.FromArgb(
                                                    nnn.DoTheThing(bitmap.GetPixel(srW, h - 1).R),
                                                    nnn.DoTheThing(bitmap.GetPixel(srW, h - 1).G),
                                                    nnn.DoTheThing(bitmap.GetPixel(srW, h - 1).B)
                                                    ));
            for (w = srW - 1; w > 0; w--)
                bitmap.SetPixel(w, srH, Color.FromArgb(
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).R),
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).G),
                                                    nn.DoTheThing(bitmap.GetPixel(w + 1, srH).B)
                                                    ));
            for (h = srH - 1; h > 0; h--)
                bitmap.SetPixel(srW, h, Color.FromArgb(
                                                    nnn.DoTheThing(bitmap.GetPixel(srW, h + 1).R),
                                                    nnn.DoTheThing(bitmap.GetPixel(srW, h + 1).G),
                                                    nnn.DoTheThing(bitmap.GetPixel(srW, h + 1).B)
                                                    ));



            //for (w = srW + 1; w < pictureBox1.Width; w++)
            //    for (h = srH + 1; h < pictureBox1.Height; h++)
            //        bitmap.SetPixel(w, h, Color.FromArgb(
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h - 1).R) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).R)) / 2,
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h - 1).G) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).G)) / 2,
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).B)) / 2
            //                                            ));
            //for (w = srW - 1; w > 0; w--)
            //    for (h = srH - 1; h > 0; h--)
            //        bitmap.SetPixel(w, h, Color.FromArgb(
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h + 1).R) + nnn.DoTheThing(bitmap.GetPixel(w + 1, h).R)) / 2,
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h + 1).G) + nnn.DoTheThing(bitmap.GetPixel(w + 1, h).G)) / 2,
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + 1, h).B)) / 2
            //                                            ));

            //for (w = srW + 1; w < pictureBox1.Width; w++)
            //    for (h = srH - 1; h > 1; h--)
            //    {
            //        bitmap.SetPixel(w, h, Color.FromArgb(
            //               ( nnn.DoTheThing(bitmap.GetPixel(w - 1, h - 1).R) + nnn.DoTheThing(bitmap.GetPixel(w - 2, h-2).R)) / 2,
            //               ( nnn.DoTheThing(bitmap.GetPixel(w - 1, h - 1).G) + nnn.DoTheThing(bitmap.GetPixel(w - 2, h - 2).G)) / 2,
            //               ( nnn.DoTheThing(bitmap.GetPixel(w - 1, h - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w - 2, h - 2).B)) / 2
            //                ));
            //    }
            for (h = srH - 1; h > 0; h--)
                for (w = pictureBox1.Width - 3; w > 2; w--)
                {

                    //     r = (nnn.DoTheThing(bitmap.GetPixel(w + 1, h + 1).R) + nnn.DoTheThing(bitmap.GetPixel(w + 2, h + 2).R)) / 2;//  + (int)bitmap.GetPixel(w, h).R ;
                    //     g = (nnn.DoTheThing(bitmap.GetPixel(w + 1, h + 1).G) + nnn.DoTheThing(bitmap.GetPixel(w + 2, h + 2).G)) / 2;//+ (int)bitmap.GetPixel(w, h).G ;
                    //     b = (nnn.DoTheThing(bitmap.GetPixel(w + 1, h + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w + 2, h + 2).B)) / 2;//+ (int)bitmap.GetPixel(w, h).B ;

                    //r = r / 3;
                    //g = g / 3;
                    //b = b / 3;
                    //if (r > 255) r = 255;
                    //if (r < 0) r = 0;
                    //if (g > 255) g = 255;
                    //if (g < 0) g = 0;
                    //if (b > 255) b = 255;
                    //if (b < 0) b = 0;
                    bitmap.SetPixel(w, h, Color.FromArgb(
                               (nnn.DoTheThing(bitmap.GetPixel(w + 1, h + 1).R) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h + 1).R)) / 2,
                                (nnn.DoTheThing(bitmap.GetPixel(w + 1, h + 1).G) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h + 1).G)) / 2,
                                 (nnn.DoTheThing(bitmap.GetPixel(w + 1, h + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h + 1).B)) / 2
                            //   r, g, b
                            ));
                }


            //for (w = srW + 1; w < pictureBox1.Width; w++)
            //    for (h = srH - 1; h > 0; h--)
            //        bitmap.SetPixel(w, h, Color.FromArgb(
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h + 1).R) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).R)) / 2,
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h + 1).G) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).G)) / 2,
            //                                           (nnn.DoTheThing(bitmap.GetPixel(w, h + 1).B) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).B)) / 2
            //                                            ));

            for (h = srH + 1; h < pictureBox1.Height - 1; h++)
                for (w = 2; w < pictureBox1.Width - 2; w++)
                    bitmap.SetPixel(w, h, Color.FromArgb(

                                                       (nnnn.DoTheThing(bitmap.GetPixel(w + 1, h - 1).R) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h - 1).R)) / 2,
                                                       (nnnn.DoTheThing(bitmap.GetPixel(w + 1, h - 1).G) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h - 1).G)) / 2,
                                                       (nnnn.DoTheThing(bitmap.GetPixel(w + 1, h - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h - 1).B)) / 2
                                                        ));

            pictureBox1.Image = bitmap;
            bitmap.Save("bity.jpg");
        }
        private void pictureBox1_Click1(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitmap.SetPixel(0, 0, Color.FromArgb(255, 255,255));
            for (w = 1; w < pictureBox1.Width; w++)
                bitmap.SetPixel(w, 0, Color.FromArgb(
                                                    nnn.DoTheThing(bitmap.GetPixel(w - 1, 0).R),
                                                    nnn.DoTheThing(bitmap.GetPixel(w - 1, 0).G),
                                                    nnn.DoTheThing(bitmap.GetPixel(w - 1, 0).B)
                                                    ));
            for (h = 1; h < pictureBox1.Height; h++)
                bitmap.SetPixel(0, h, Color.FromArgb(
                                                    nnn.DoTheThing(bitmap.GetPixel( 0 , h - 1 ).R),
                                                    nnn.DoTheThing(bitmap.GetPixel( 0 , h - 1 ).G),
                                                    nnn.DoTheThing(bitmap.GetPixel( 0 , h - 1 ).B)
                                                    ));
            for (w = 1; w < pictureBox1.Width; w++)
                for (h = 1; h < pictureBox1.Height; h++)
                    bitmap.SetPixel(w, h, Color.FromArgb(
                                                       (nnn.DoTheThing(bitmap.GetPixel(w, h - 1).R) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).R)) / 2 ,
                                                       (nnn.DoTheThing(bitmap.GetPixel(w, h - 1).G) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).G)) / 2 ,
                                                       (nnn.DoTheThing(bitmap.GetPixel(w, h - 1).B) + nnn.DoTheThing(bitmap.GetPixel(w - 1, h).B)) / 2  
                                                        ));
            pictureBox1.Image = bitmap;
            bitmap.Save("bity.jpg");
        }

        int xxx = 255;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //for (w = 0; w < pictureBox1.Width; w++)
            //    for (h = 0; h < pictureBox1.Height; h++)
            //    {
            //        bitmap.SetPixel(w, h, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            //    }
            //pictureBox1.Image = bitmap;
           
            xxx = nnn.DoTheThing(xxx);
            label1.Text = xxx.ToString();
        }
    }
}
