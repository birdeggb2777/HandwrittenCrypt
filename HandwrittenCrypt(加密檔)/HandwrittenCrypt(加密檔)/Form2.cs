using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
namespace HandwrittenCrypt_加密檔_
{
    public partial class Form2 : Form
    {
        public string str1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image imagea = pictureBox1.Image;
            int rgbnumber = 0;
            byte[] b0 = new byte[256];
            byte[] g0 = new byte[256];
            byte[] r0 = new byte[256];
            try
            {
                for (int i = 0; i <= 255; i++)
                {
                    b0[i] = Convert.ToByte(str1.Substring(rgbnumber, 3));
                    rgbnumber += 3;
                   
                }

                for (int i = 0; i <= 255; i++)
                {
                    g0[i] = Convert.ToByte(str1.Substring(rgbnumber, 3));
                    rgbnumber += 3; 
                }
                for (int i = 0; i <= 255; i++)
                {
                    r0[i] = Convert.ToByte(str1.Substring(rgbnumber, 3));
                    rgbnumber += 3;
                }
            }
            catch
            {
                MessageBox.Show(Convert.ToString(0000));
                return;
            }
            int[] r1 = new int[256];
            int[] g1 = new int[256];
            int[] b1 = new int[256];
            int[] r2 = new int[256];
            int[] g2 = new int[256];
            int[] b2 = new int[256];
            int[] rr1 = new int[256];
            int[] gg1 = new int[256];
            int[] bb1 = new int[256];
            int[] rr2 = new int[256];
            int[] gg2 = new int[256];
            int[] bb2 = new int[256];


            try
            {
                checked
                {
                    Bitmap MyNewBmp = new Bitmap(imagea);
                    Bitmap MyNewBmp2 = new Bitmap(imagea);
                    Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
                    BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, MyNewBmp.PixelFormat);
                    IntPtr MyPtr = MyBmpData.Scan0;
                    int MyByteCount = MyBmpData.Stride * MyNewBmp.Height;
                    byte[] MyNewColor = new byte[MyByteCount];
                    Marshal.Copy(MyPtr, MyNewColor, 0, MyByteCount);
                    //////////////////////////////////////
                    Rectangle MyRec2 = new Rectangle(0, 0, MyNewBmp2.Width, MyNewBmp2.Height);
                    BitmapData MyBmpData2 = MyNewBmp2.LockBits(MyRec2, ImageLockMode.ReadWrite, MyNewBmp2.PixelFormat);
                    IntPtr MyPtr2 = MyBmpData2.Scan0;
                    int MyByteCount2 = MyBmpData2.Stride * MyNewBmp2.Height;
                    byte[] MyNewColor2 = new byte[MyByteCount2];
                    Marshal.Copy(MyPtr2, MyNewColor2, 0, MyByteCount2);
                    ////////////////////////////
                    for (int k = 0; k < MyByteCount; k += 4)
                    {
                        b1[MyNewColor[k]] += 1;
                        g1[MyNewColor[k + 1]] += 1;
                        r1[MyNewColor[k + 2]] += 1;
                    }
                    int max_value = 0;
                    for (int ii = 0; ii <= 255; ii++)
                    {
                        max_value = 0;
                        for (int i = 0; i <= 255; i++)
                        {
                            if (max_value < r1[i])
                            {
                                max_value = r1[i];
                            }
                        }
                        for (int i = 0; i <= 255; i++)
                        {
                            if (r1[i] == max_value)
                            {
                                if (r1[i] == 0)
                                {
                                    r1[i] = -10;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                                rr1[ii] = i;
                                r1[i] = -5;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    for (int ii = 0; ii <= 255; ii++)
                    {
                        max_value = 0;
                        for (int i = 0; i <= 255; i++)
                        {
                            if (max_value < g1[i])
                            {
                                max_value = g1[i];
                            }
                        }
                        for (int i = 0; i <= 255; i++)
                        {
                            if (g1[i] == max_value)
                            {
                                if (g1[i] == 0)
                                {
                                    g1[i] = -10;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                                gg1[ii] = i;
                                g1[i] = -5;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    for (int ii = 0; ii <= 255; ii++)
                    {
                        max_value = 0;
                        for (int i = 0; i <= 255; i++)
                        {
                            if (max_value < b1[i])
                            {
                                max_value = b1[i];
                            }
                        }
                        for (int i = 0; i <= 255; i++)
                        {
                            if (b1[i] == max_value)
                            {
                                if (b1[i] == 0)
                                {
                                    b1[i] = -10;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                                bb1[ii] = i;
                                b1[i] = -5;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    for (int n = 0; n < MyByteCount; n += 4)
                    {
                       MyNewColor[n] = b0[MyNewColor[n]];
                        MyNewColor[n + 1] = g0[MyNewColor[n + 1]];
                        MyNewColor[n + 2] = r0[MyNewColor[n + 2]];
                        MyNewColor[n + 3] = 255;
                    }
                    for (int k = 0; k < MyByteCount; k += 4)
                    {
                        b2[MyNewColor[k]] += 1;
                        g2[MyNewColor[k + 1]] += 1;
                        r2[MyNewColor[k + 2]] += 1;
                    }
                    max_value = 0;
                    for (int ii = 0; ii <= 255; ii++)
                    {
                        max_value = 0;
                        for (int i = 0; i <= 255; i++)
                        {
                            if (max_value < r2[i])
                            {
                                max_value = r2[i];
                            }
                        }
                        for (int i = 0; i <= 255; i++)
                        {
                            if (r2[i] == max_value)
                            {
                                if (r2[i] == 0)
                                {
                                    r2[i] = -10;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                                rr2[ii] = i;
                                r2[i] = -5;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    for (int ii = 0; ii <= 255; ii++)
                    {
                        max_value = 0;
                        for (int i = 0; i <= 255; i++)
                        {
                            if (max_value < g2[i])
                            {
                                max_value = g2[i];
                            }
                        }
                        for (int i = 0; i <= 255; i++)
                        {
                            if (g2[i] == max_value)
                            {
                                if (g2[i] == 0)
                                {
                                    g2[i] = -10;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                                gg2[ii] = i;
                                g2[i] = -5;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    for (int ii = 0; ii <= 255; ii++)
                    {
                        max_value = 0;
                        for (int i = 0; i <= 255; i++)
                        {
                            if (max_value < b2[i])
                            {
                                max_value = b2[i];
                            }
                        }
                        for (int i = 0; i <= 255; i++)
                        {
                            if (b2[i] == max_value)
                            {
                                if (b2[i] == 0)
                                {
                                    b2[i] = -10;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                                bb2[ii] = i;
                                b2[i] = -5;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    /*  byte[] convertrgb = new byte[(MyByteCount / 4)*3];
                      byte[] convertrgb2 = new byte[(MyByteCount / 4) * 3];
                      int convertcheck = 0;
                      for (int n = 0; n < MyByteCount; n += 4)
                      {
                          convertrgb[convertcheck] = MyNewColor[n];
                          convertrgb2[convertcheck] = MyNewColor[n];
                          convertcheck += 1;
                          convertrgb[convertcheck] = MyNewColor[n+1];
                          convertrgb2[convertcheck] = MyNewColor[n + 1];
                          convertcheck += 1;
                          convertrgb[convertcheck] = MyNewColor[n+2];
                          convertrgb2[convertcheck] = MyNewColor[n + 2];
                          convertcheck += 1;
                       }

                      int he = Height - rr2[1] - 1;
                      for (int i = 0; i < Width; i++)
                      {
                          for (int k = 0; k < he; k++)
                          {
                              convertrgb[he + i * he - k] = convertrgb[he + i * he - k];
                              convertrgb[(he + i * he - k)+Width*Height] = convertrgb2[he + i * he - k + Width * Height];
                              convertrgb[(he + i * he - k) + Width * Height + Width * Height] = convertrgb2[he + i * he - k + Width * Height + Width * Height];
                           }
                      }
                      */
                    Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                    MyNewBmp.UnlockBits(MyBmpData);
                    Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                    MyNewBmp2.UnlockBits(MyBmpData2);
                    imagea = MyNewBmp;
                }
            }
            catch
            {
            }
            try
            {
                checked
                {
                    Bitmap MyNewBmp = new Bitmap(imagea);
                    Bitmap MyNewBmp2 = new Bitmap(imagea);
                    Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
                    BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, MyNewBmp.PixelFormat);
                    IntPtr MyPtr = MyBmpData.Scan0;
                    int MyByteCount = MyBmpData.Stride * MyNewBmp.Height;
                    byte[] MyNewColor = new byte[MyByteCount];
                    Marshal.Copy(MyPtr, MyNewColor, 0, MyByteCount);
                    //////////////////////////////////////
                    Rectangle MyRec2 = new Rectangle(0, 0, MyNewBmp2.Width, MyNewBmp2.Height);
                    BitmapData MyBmpData2 = MyNewBmp2.LockBits(MyRec2, ImageLockMode.ReadWrite, MyNewBmp2.PixelFormat);
                    IntPtr MyPtr2 = MyBmpData2.Scan0;
                    int MyByteCount2 = MyBmpData2.Stride * MyNewBmp2.Height;
                    byte[] MyNewColor2 = new byte[MyByteCount2];
                    Marshal.Copy(MyPtr2, MyNewColor2, 0, MyByteCount2);
                    int wi = MyNewBmp.Width;
                    int he = MyNewBmp.Height;
                   if (wi > he)
                    {
                        he = MyNewBmp.Height - bb2[0];
                        for (int i = 0; i <= wi - 4; i++)
                        {
                            for (int k = 0; k <= he * 4 - 4; k += 4)
                            {
                                MyNewColor[k + i * he * 4] = MyNewColor2[he * 4 + i * he * 4 - k];
                            }
                        }
                        he = MyNewBmp.Height - gg2[0];
                        for (int i = 0; i <= wi - 4; i++)
                        {
                            for (int k = 0; k <= he * 4 - 4; k += 4)
                            {
                                MyNewColor[k + i * he * 4 + 1] = MyNewColor2[he * 4 + i * he * 4 - k + 1];
                            }
                        }
                        he = MyNewBmp.Height - rr2[0];
                        for (int i = 0; i <= wi - 4; i++)
                        {
                            for (int k = 0; k <= he * 4 - 4; k += 4)
                            {
                                MyNewColor[k + i * he * 4 + 2] = MyNewColor2[he * 4 + i * he * 4 - k + 2];
                            }
                        }
                    }
                    else
                    {
                        he = MyNewBmp.Width - bb2[0];
                        for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                        {
                            for (int k = 0; k <= he * 4-4; k += 4)
                            {
                                MyNewColor[k + i * he * 4] = MyNewColor2[he * 4 + i * he * 4 - k];
                            }
                        }
                        he = MyNewBmp.Width - gg2[0];
                        for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                        {
                            for (int k = 0; k <= he * 4 - 4; k += 4)
                            {
                                MyNewColor[k + i * he * 4 + 1] = MyNewColor2[he * 4 + i * he * 4 - k + 1];
                            }
                        }
                        he = MyNewBmp.Width - rr2[0];
                        for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                        {
                            for (int k = 0; k <= he * 4 - 4; k += 4)
                            {
                                MyNewColor[k + i * he * 4 + 2] = MyNewColor2[he * 4 + i * he * 4 - k + 2];
                            }
                        }
                    }
                    Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                    MyNewBmp.UnlockBits(MyBmpData);
                    Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                    MyNewBmp2.UnlockBits(MyBmpData2);
                    imagea = MyNewBmp;
                }
            }
            catch
            {
            }
            try
            {
                Bitmap bmp = new Bitmap(imagea);
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                imagea = bmp;
            }
            catch
            {
            }
            try
            {
                Bitmap MyNewBmp = new Bitmap(imagea);
                Bitmap MyNewBmp2 = new Bitmap(imagea);
                Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
                BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, MyNewBmp.PixelFormat);
                IntPtr MyPtr = MyBmpData.Scan0;
                int MyByteCount = MyBmpData.Stride * MyNewBmp.Height;
                byte[] MyNewColor = new byte[MyByteCount];
                Marshal.Copy(MyPtr, MyNewColor, 0, MyByteCount);
                //////////////////////////////////////
                Rectangle MyRec2 = new Rectangle(0, 0, MyNewBmp2.Width, MyNewBmp2.Height);
                BitmapData MyBmpData2 = MyNewBmp2.LockBits(MyRec2, ImageLockMode.ReadWrite, MyNewBmp2.PixelFormat);
                IntPtr MyPtr2 = MyBmpData2.Scan0;
                int MyByteCount2 = MyBmpData2.Stride * MyNewBmp2.Height;
                byte[] MyNewColor2 = new byte[MyByteCount2];
                Marshal.Copy(MyPtr2, MyNewColor2, 0, MyByteCount2);
                ////////////////////////////
                int wi = MyNewBmp.Width;
                int he = MyNewBmp.Height;
                if (wi > he)
                {
                    he = MyNewBmp.Height -bb1[0];
                    for (int i = 0; i <= wi-4 ; i++)
                    {
                        for (int k = 0; k <= he * 4-4 ; k += 4)
                        {
                            MyNewColor[k + i * he * 4] = MyNewColor2[he * 4 + i * he * 4 - k];
                        }
                    }
                    he = MyNewBmp.Height - gg1[0];
                    for (int i = 0; i <= wi-4 ; i++)
                    {
                        for (int k = 0; k <= he * 4 -4; k += 4)
                        {
                            MyNewColor[k + i * he * 4 + 1] = MyNewColor2[he * 4 + i * he * 4 - k + 1];
                        }
                    }
                    he = MyNewBmp.Height - rr1[0];
                    for (int i = 0; i <= wi -4; i++)
                    {
                        for (int k = 0; k <= he * 4 -4; k += 4)
                        {
                            MyNewColor[k + i * he * 4 + 2] = MyNewColor2[he * 4 + i * he * 4 - k + 2];
                        }
                    }
                }
                else
                {
                    he = MyNewBmp.Width - bb1[0];
                    for (int i = 0; i <= MyNewBmp.Height -4; i++)
                    {
                        for (int k = 0; k <= he * 4 -4; k += 4)
                        {
                            MyNewColor[k + i * he * 4] = MyNewColor2[he * 4 + i * he * 4 - k];
                        }
                    }
                    he = MyNewBmp.Width -gg1[0];
                    for (int i = 0; i <= MyNewBmp.Height -4; i++)
                    {
                        for (int k = 0; k <= he * 4 -4; k += 4)
                        {
                            MyNewColor[k + i * he * 4 + 1] = MyNewColor2[he * 4 + i * he * 4 - k + 1];
                        }
                    }
                    he = MyNewBmp.Width - rr1[0];
                    for (int i = 0; i <= MyNewBmp.Height -4; i++)
                    {
                        for (int k = 0; k <= he * 4-4 ; k += 4)
                        {
                            MyNewColor[k + i * he * 4 + 2] = MyNewColor2[he * 4 + i * he * 4 - k + 2];
                        }
                    }
                }
                Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                MyNewBmp.UnlockBits(MyBmpData);
                Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                MyNewBmp2.UnlockBits(MyBmpData2);
                imagea = MyNewBmp;
            }
            catch
            {
            }
            try
            {
                Bitmap bmp = new Bitmap(imagea);
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                imagea = bmp;
            }
            catch
            {
            }
            pictureBox1.Image = imagea;
        }
        private void 輸出圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image c = default(Image);
            c = pictureBox1.Image;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "圖片檔 (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                c.Save(saveFileDialog.FileName);
            }
        }
    }
}