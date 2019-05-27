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
    public partial class Form1 : Form
    {
        public Bitmap pic2;
        public Image pic3;
        int X = 0;
        int Y = 0;
        int x2 = 0;
        int y2 = 0;
        int redpen=0;
        int greenpen=0;
        int bluepen=0;
        bool pencheck = false;
        public string str1;
        public string str2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Bitmap resultBitmap = new Bitmap(1200, 800);
            pictureBox1.Image = resultBitmap;
            Bitmap MyNewBmp = (Bitmap)pictureBox1.Image;
            byte[] MyInvertColor = new byte[256];
            for (int n = 0; n < 255; n++)
                MyInvertColor[n] = (byte)(255 - n);
            Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
            BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, MyNewBmp.PixelFormat);
            IntPtr MyPtr = MyBmpData.Scan0;
            int MyByteCount = MyBmpData.Stride * MyNewBmp.Height;
            byte[] MyNewColor = new byte[MyByteCount];
            Marshal.Copy(MyPtr, MyNewColor, 0, MyByteCount);
            for (int n = 0; n < MyByteCount; n += 3)
            {
                MyNewColor[n] = MyInvertColor[MyNewColor[n]];
                MyNewColor[n + 1] = MyInvertColor[MyNewColor[n + 1]];
                MyNewColor[n + 2] = MyInvertColor[MyNewColor[n + 2]];
            }
            Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
            MyNewBmp.UnlockBits(MyBmpData);
            pictureBox1.Image = resultBitmap;
            pictureBox2.Image = pictureBox1.Image;
        }
        private void picturebox1_Mousedown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            Random ran = new Random();
            int rancolor;
            rancolor = ran.Next(0, 255 + 1);
            if (rancolor > 127) { redpen = 255;}
            else { redpen = 0; }
            rancolor = ran.Next(0, 255 + 1);
            if (rancolor > 127) { greenpen = 255; }
            else { greenpen = 0; }
            rancolor = ran.Next(0, 255 + 1);
            if (rancolor > 127) { bluepen = 255; }
            else { bluepen = 0; }
            if (redpen ==255 && bluepen ==255 && greenpen == 255) {redpen = 0;greenpen = 0;bluepen = 0; }
            pencheck = true;
        }
        private void picturebox1_Mousemove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pencheck == true)
            {
                x2 = e.X;
                y2 = e.Y;
                try { Image pic1s = pictureBox1.Image;
                Bitmap drawImage = new Bitmap(pic1s, pic1s.Width, pic1s.Height);
                Graphics g = Graphics.FromImage(drawImage);
               Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 0), 20);
                myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(myPen, X, Y, x2, y2);
                g.Dispose();
                pictureBox1.Image = drawImage;
                }
                catch
                {
                }
                try
                {
                    Image pic1s = pictureBox2.Image;
                    Bitmap drawImage = new Bitmap(pic1s, pic1s.Width, pic1s.Height);
                    Graphics g = Graphics.FromImage(drawImage);
                    Pen myPen = new Pen(Color.FromArgb(255, redpen , greenpen , bluepen ), 20);
                    myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(myPen, X, Y, x2, y2);
                    g.Dispose();
                    pictureBox2.Image = drawImage;
                }
                catch
                {
                }
                X = e.X;
                Y = e.Y;
                pictureBox1.Refresh();
                pictureBox2.Refresh();
            }
        }
        private void picturebox1_Mouseup(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pencheck = false;
        }
        private void 加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.TextLength != 2304 || textBox2.TextLength != 2304)
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
            str1 = textBox1.Text;
            str2 = textBox1.Text;
            Bitmap MyNewBmp = new Bitmap(pictureBox2.Image);
            Bitmap MyNewBmp2 = new Bitmap(pictureBox2.Image);
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
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int rancolor;
            byte b, g, r, bb, gg, rr;
            for (int n = 0; n < MyByteCount; n += 4)
            {
                if (MyNewColor[n] > 127) { MyNewColor[n] = 255;}
                else { MyNewColor[n] = 254;}
                if (MyNewColor[n+1] > 127) { MyNewColor[n+1] = 255; }
                else { MyNewColor[n+1] = 254; }
                if (MyNewColor[n+2] > 127) { MyNewColor[n+2] = 255; }
                else { MyNewColor[n+2] = 254; }
            }
                for (int n = 0; n < MyByteCount; n += 4)
            {
                rancolor = ran.Next(0, MyNewColor[n] + 1);
                b = Convert.ToByte(rancolor);
                rancolor = ran.Next(0, MyNewColor[n + 1] + 1);
                g = Convert.ToByte(rancolor);
                rancolor = ran.Next(0, MyNewColor[n + 2] + 1);
                r = Convert.ToByte(rancolor);
                bb = MyNewColor[n];
                gg = MyNewColor[n + 1];
                rr = MyNewColor[n + 2];
                MyNewColor2[n] = Convert.ToByte(bb - b);
                MyNewColor2[n + 1] = Convert.ToByte(gg - g);
                MyNewColor2[n + 2] = Convert.ToByte(rr - r);
                MyNewColor[n] = b;
                MyNewColor[n + 1] = g;
                MyNewColor[n + 2] = r;
            }
            Marshal.Copy(MyNewColor, 0, MyPtr, MyByteCount);
            MyNewBmp.UnlockBits(MyBmpData);
            Marshal.Copy(MyNewColor2, 0, MyPtr2, MyByteCount2);
            MyNewBmp2.UnlockBits(MyBmpData2);
            pic2 = MyNewBmp;
            pic3 = MyNewBmp2;
            Form2 f2 = new Form2();
            f2.pictureBox1.Image = MyNewBmp;
            f2.str1 = str1;
            f2.Show();
            Form3 f3 = new Form3();
            f3.pictureBox1.Image = MyNewBmp2;
            f3.str2 = str2;
            f3.Show();
        }
    }
}
