using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandwrittenCrypt_金鑰產生器_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 產生金鑰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            for (int iiiii = 0; iiiii <= 2; iiiii++)
            {
                if (1 + 1 == 2)
                {
                    bool check = true;
                    int number = 0;
                    int[] numbercheck = new int[256];
                    for (int i = 0; i <= 255; i++)
                    { numbercheck[i] = 800; }
                    int rancolor;
                   // Random ran = new Random();
                    string str = "";
                    string bgr;
                    while (number < 256)
                    {
                        Random ran = new Random(Guid.NewGuid().GetHashCode());
                        check = false;
                        rancolor = ran.Next(0, 255 + 1);
                        for (int i = 0; i <= 255; i++)
                        {
                            if (numbercheck[i] == rancolor)
                            {
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            bgr = Convert.ToString(rancolor);
                            if (rancolor < 100) { bgr = "0" + bgr; }
                            if (rancolor < 10) { bgr = "0" + bgr; }
                            str = str + bgr;
                            numbercheck[number] = rancolor;
                            number += 1;
                        }
                    }
                    TextBox1.Text = TextBox1.Text + str;
                }
            }
            for (int iiiii = 0; iiiii <= 2; iiiii++)
            {
                if (1 + 1 == 2)
                {
                    bool check = true;
                    int number = 0;
                    int[] numbercheck = new int[256];
                    for (int i = 0; i <= 255; i++)
                    { numbercheck[i] = 800; }
                    int rancolor;
                  //  Random ran = new Random();
                    string str = "";
                    string bgr;
                    while (number < 256)
                    {
                        check = false;
                        Random ran = new Random(Guid.NewGuid().GetHashCode());
                        rancolor = ran.Next(0, 255 + 1);
                        for (int i = 0; i <= 255; i++)
                        {
                            if (numbercheck[i] == rancolor)
                            {
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            bgr = Convert.ToString(rancolor);
                            if (rancolor < 100) { bgr = "0" + bgr; }
                            if (rancolor < 10) { bgr = "0" + bgr; }
                            str = str + bgr;
                            numbercheck[number] = rancolor;
                            number += 1;
                        }
                    }
                    TextBox2.Text = TextBox2.Text + str;
                }
            }




        }

        private void 複製金鑰AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TextBox1.Text);
        }

        private void 複製金鑰BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TextBox2.Text);
        }
    }
}
