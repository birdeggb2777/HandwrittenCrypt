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
namespace HandwrittenCrypt_解密檔_
{
    public partial class Form1 : Form
    {
        Image imagea;
        Image imageb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void 解密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.TextLength != 2304 || TextBox2.TextLength != 2304 )
                {
                    checked
                    {
                        byte checka = 0;
                        checka += 255;
                        checka += 255;
                    }
                }
            }
            catch
            {
                MessageBox.Show("金鑰格式錯誤");
                return;
            }
            try
            {
                if ( imagea == null || imageb == null || imagea.Size!=imageb.Size)
                {
                    checked
                    {
                        byte checka = 0;
                        checka += 255;
                        checka += 255;
                    }
                }
            }
            catch
            {
                MessageBox.Show("圖片未正確放入");
                return;
            }
            try
            {
                string str1 = TextBox1.Text;
                string str2 = TextBox2.Text;
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
                try
                {
                    Bitmap bmp = new Bitmap(imagea);
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    imagea = bmp;
                }
                catch
                {
                    MessageBox.Show("1");
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
                        byte[] rchange1 = new byte[256];
                        byte[] rchange2 = new byte[256];
                        for (int iii = 0; iii <= 255; iii++)
                        {
                            rchange1[iii] = r0[iii];
                            rchange2[rchange1[iii]] = Convert.ToByte(iii);
                        }
                        byte[] gchange1 = new byte[256];
                        byte[] gchange2 = new byte[256];
                        for (int iiii = 0; iiii <= 255; iiii++)
                        {
                            gchange1[iiii] = g0[iiii];
                            gchange2[gchange1[iiii]] = Convert.ToByte(iiii);
                        }
                        byte[] bchange1 = new byte[256];
                        byte[] bchange2 = new byte[256];
                        for (int iiiii = 0; iiiii <= 255; iiiii++)
                        {
                            bchange1[iiiii] = b0[iiiii];
                            bchange2[bchange1[iiiii]] = Convert.ToByte(iiiii);
                        }
                        for (int n = 0; n < MyByteCount; n += 4)
                        {
                            MyNewColor[n] = bchange2[bchange1[bchange2[MyNewColor[n]]]];
                            MyNewColor[n + 1] = gchange2[gchange1[gchange2[MyNewColor[n + 1]]]];
                            MyNewColor[n + 2] = rchange2[rchange1[rchange2[MyNewColor[n + 2]]]];
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
                        Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                        MyNewBmp.UnlockBits(MyBmpData);
                        Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                        MyNewBmp2.UnlockBits(MyBmpData2);
                        imagea = MyNewBmp;
                        PictureBox1.Image = imagea;
                    }
                }
                catch
                {
                    MessageBox.Show("3");
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
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Height -gg2[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Height -rr2[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        else
                        {
                            he = MyNewBmp.Width - bb2[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Width -gg2[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Width - rr2[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
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
                    MessageBox.Show("4");
                }
                try
                {
                    Bitmap bmp = new Bitmap(imagea);
                    bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    imagea = bmp;
                }
                catch
                {
                    MessageBox.Show("2");
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
                        ////////////////////////////
                        int wi = MyNewBmp.Width;
                        int he = MyNewBmp.Height;
                    if (wi > he)
                        {
                            he = MyNewBmp.Height - bb1[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Height - gg1[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Height - rr1[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        else
                        {
                            he = MyNewBmp.Width - bb1[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Width -gg1[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Width - rr1[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                        MyNewBmp.UnlockBits(MyBmpData);
                        Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                        MyNewBmp2.UnlockBits(MyBmpData2);
                        imagea = MyNewBmp;
                       // PictureBox1.Image = imagea;
                    }
                }
                catch
                {
                    MessageBox.Show("3");
                }
            }
            catch
            {

            }


















            try
            {
                string str1 = TextBox1.Text;
                string str2 = TextBox2.Text;
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
                try
                {
                    Bitmap bmp = new Bitmap(imageb);
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    imageb = bmp;
                }
                catch
                {
                    MessageBox.Show("1");
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
                        Bitmap MyNewBmp = new Bitmap(imageb);
                        Bitmap MyNewBmp2 = new Bitmap(imageb);
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
                        byte[] rchange1 = new byte[256];
                        byte[] rchange2 = new byte[256];
                        for (int iii = 0; iii <= 255; iii++)
                        {
                            rchange1[iii] = r0[iii];
                            rchange2[rchange1[iii]] = Convert.ToByte(iii);
                        }
                        byte[] gchange1 = new byte[256];
                        byte[] gchange2 = new byte[256];
                        for (int iiii = 0; iiii <= 255; iiii++)
                        {
                            gchange1[iiii] = g0[iiii];
                            gchange2[gchange1[iiii]] = Convert.ToByte(iiii);
                        }
                        byte[] bchange1 = new byte[256];
                        byte[] bchange2 = new byte[256];
                        for (int iiiii = 0; iiiii <= 255; iiiii++)
                        {
                            bchange1[iiiii] = b0[iiiii];
                            bchange2[bchange1[iiiii]] = Convert.ToByte(iiiii);
                        }
                        for (int n = 0; n < MyByteCount; n += 4)
                        {
                            MyNewColor[n] = bchange2[bchange1[bchange2[MyNewColor[n]]]];
                            MyNewColor[n + 1] = gchange2[gchange1[gchange2[MyNewColor[n + 1]]]];
                            MyNewColor[n + 2] = rchange2[rchange1[rchange2[MyNewColor[n + 2]]]];
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
                        Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                        MyNewBmp.UnlockBits(MyBmpData);
                        Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                        MyNewBmp2.UnlockBits(MyBmpData2);
                        imageb = MyNewBmp;
                        PictureBox1.Image = imageb;
                    }
                }
                catch
                {
                    MessageBox.Show("3");
                }














                try
                {
                    checked
                    {
                        Bitmap MyNewBmp = new Bitmap(imageb);
                        Bitmap MyNewBmp2 = new Bitmap(imageb);
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
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Height -gg2[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Height - rr2[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        else
                        {
                            he = MyNewBmp.Width -bb2[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Width -gg2[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Width - rr2[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                        MyNewBmp.UnlockBits(MyBmpData);
                        Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                        MyNewBmp2.UnlockBits(MyBmpData2);
                        imageb = MyNewBmp;
                    }
                }
                catch
                {
                    MessageBox.Show("4");
                }
                try
                {
                    Bitmap bmp = new Bitmap(imageb);
                    bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    imageb = bmp;
                }
                catch
                {
                    MessageBox.Show("2");
                }
                try
                {
                    checked
                    {
                        Bitmap MyNewBmp = new Bitmap(imageb);
                        Bitmap MyNewBmp2 = new Bitmap(imageb);
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
                            he = MyNewBmp.Height - bb1[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Height - gg1[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Height - rr1[0];
                            for (int i = 0; i <= wi - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        else
                        {
                            he = MyNewBmp.Width - bb1[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k] = MyNewColor2[k + i * he * 4];
                                }
                            }
                            he = MyNewBmp.Width -gg1[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 1] = MyNewColor2[k + i * he * 4 + 1];
                                }
                            }
                            he = MyNewBmp.Width -rr1[0];
                            for (int i = 0; i <= MyNewBmp.Height - 4; i++)
                            {
                                for (int k = 0; k <= he * 4 - 4; k += 4)
                                {
                                    MyNewColor[he * 4 + i * he * 4 - k + 2] = MyNewColor2[k + i * he * 4 + 2];
                                }
                            }
                        }
                        Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                        MyNewBmp.UnlockBits(MyBmpData);
                        Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                        MyNewBmp2.UnlockBits(MyBmpData2);
                        imageb = MyNewBmp;
                       // PictureBox1.Image = imageb;
                    }
                }
                catch
                {
                    MessageBox.Show("3");
                }
            }
            catch
            {

            }
            try
            {
                
                Bitmap MyNewBmp = new Bitmap(imagea);
                Bitmap MyNewBmp2 = new Bitmap(imageb);
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
                int bgr;
                for (int n = 0; n < MyByteCount; n += 4)
                {
                    bgr = MyNewColor[n] + MyNewColor2[n];
                    if (bgr > 255) { bgr = 255; }
                    MyNewColor[n] = Convert.ToByte(bgr);
                    bgr = MyNewColor[n+1] + MyNewColor2[n+1];
                    if (bgr > 255) { bgr = 255; }
                    MyNewColor[n+1] = Convert.ToByte(bgr);
                    bgr = MyNewColor[n+2] + MyNewColor2[n+2];
                    if (bgr > 255) { bgr = 255; }
                    MyNewColor[n+2] = Convert.ToByte(bgr);
                }
                for (int n = 0; n < MyByteCount; n += 4)
                {
                    if (MyNewColor[n] ==254) { MyNewColor[n] = 0; }
                    else { MyNewColor[n] = 255; }
                   if (MyNewColor[n+1] == 254) { MyNewColor[n+1] = 0; }
                   else { MyNewColor[n+1] = 255; }
                   if (MyNewColor[n+2] == 254) { MyNewColor[n+2] = 0; }
                   else { MyNewColor[n+2] = 255; }
                }
                Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
                MyNewBmp.UnlockBits(MyBmpData);
                Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
                MyNewBmp2.UnlockBits(MyBmpData2);
                imagea = MyNewBmp;
                PictureBox1.Image = MyNewBmp ;
            
            }
            catch
            {
                MessageBox.Show("132");
            }
        }

        private void 載入圖片AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "圖片檔 (*.png;*.jpg;*.bmp;*.gif;*.tif)|*.png;*.jpg;*.bmp;*.gif;*.tif";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap a = new Bitmap(OpenFileDialog1.FileName);
                imagea = a;
            }
        }

        private void 載入圖片BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "圖片檔 (*.png;*.jpg;*.bmp;*.gif;*.tif)|*.png;*.jpg;*.bmp;*.gif;*.tif";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(OpenFileDialog1.FileName);
                imageb = b;
            }
        }
    }
}
