using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_Paper_Scissors
{
    public partial class Form2 : Form
    {
        Button btn;
        Button btn2;
        Button btn3;
        TextBox txt;
        Label lbl_p;
        Label lbl_bot;
        RadioButton rb;
        RadioButton rb2;
        RadioButton rb3;
        PictureBox pb;
        public int numb;
        public Form2()
        {
            this.Size = new Size(500, 500);
            this.Text = "Rock_Paper_Scissors";
            this.BackgroundImage = new Bitmap(@"../../img/fon.jpg"); //картина фона формы

            Label lbl = new Label();
            lbl.Text = "kirjuta oma nickName:";
            lbl.Location = new Point(190, 70);
            lbl.Size = new Size(125, 15);
            lbl.BackColor = Color.White;

            txt = new TextBox();
            txt.Location = new Point(125, 90);
            txt.Size = new Size(250, 30);

            Button btn = new Button();
            btn.Size = new Size(150, 30);
            btn.Location = new Point(170, 120);
            btn.Text = "Edasi";
            btn.Click += Btn_Click;

            lbl_p = new Label();
            lbl_p.Location = new Point(240, 70);
            lbl_p.Font = new Font("Arial", 22, FontStyle.Bold);
            lbl_p.BackColor = Color.White;
            lbl_p.ForeColor = Color.Black;
            lbl_p.TextChanged += Lbl_p_TextChanged;

            lbl_bot = new Label();
            lbl_bot.Text = "BOT";
            lbl_bot.Location = new Point(560, 70);
            lbl_bot.Size = new Size(100, 30);
            lbl_bot.Font = new Font("Arial", 20, FontStyle.Bold);
            lbl_bot.BackColor = Color.White;
            lbl_bot.ForeColor = Color.Black;

            rb = new RadioButton();
            rb.Image = Image.FromFile(@"../../img/kivi.png");
            rb.Location = new Point(50,120);
            rb.Size = new Size(200, 200);

            rb2 = new RadioButton();
            rb2.Image = Image.FromFile(@"../../img/paber.png");
            rb2.Location = new Point(50, 350);
            rb2.Size = new Size(200, 200);

            rb3 = new RadioButton();
            rb3.Image = Image.FromFile(@"../../img/kaarid.png");
            rb3.Location = new Point(50, 570);
            rb3.Size = new Size(200, 200);

            pb = new PictureBox();
            pb.ImageLocation = "../../img/vopros.jpg";
            pb.Size = new Size(200, 200);
            pb.Location = new Point(500, 200);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            btn2 = new Button();
            btn2.Location = new Point(600, 500);
            btn2.Size = new Size(100, 50);
            btn2.Text = "Alusta";
            btn2.MouseClick += Btn2_MouseClick; ;

            List<string> list = new List<string>();

            list.Add("kivi.png");
            list.Add("paber.png");
            list.Add("kaarid.png");

            Random rnd = new Random();

            int num = rnd.Next(3);
            
            btn3 = new Button();
            btn3.Location = new Point(300, 500);
            btn3.Size = new Size(100, 50);
            btn3.MouseClick += Btn3_MouseClick;
            btn3.Text = "Bot liigub";


            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            this.Controls.Add(btn);
        }

        private void Btn3_MouseClick(object sender, MouseEventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            List<string> lists = new List<string>();

            lists.Add("kivi.png");
            lists.Add("paber.png");
            lists.Add("kaarid.png");
            Random rand = new Random();

            numb = rand.Next(3);
            pb.ImageLocation = ($"../../images/{lists[numb]}");
            btn2.Hide();
            if (rb.Checked)
            {
                rb2.Hide();
                rb3.Hide();
            }
            else if (rb2.Checked)
            {
                rb.Hide();
                rb3.Hide();
            }
            else if (rb3.Checked)
            {
                rb2.Hide();
                rb.Hide();
            }

        }

        private void Btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (rb.Checked == true && numb == 1 || rb2.Checked == true && numb == 2 || rb3.Checked == true && numb == 0)
            {

                var answer = MessageBox.Show(
                "Sina võitis " + numb.ToString(),
                "Sõnum",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    Form2 op = new Form2();
                    op.Show();
                    op.WindowState = FormWindowState.Minimized;
                    op.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }


            }
            else if (rb.Checked == true && numb == 0 || rb2.Checked == true && numb == 1 || rb3.Checked == true && numb == 2)
            {
                var answer = MessageBox.Show(
                "Ничья" + numb.ToString(),
                "Sõnum",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    Form2 op = new Form2();
                    op.Show();
                    op.WindowState = FormWindowState.Minimized;
                    op.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }

            }
            else
            {
                var answer = MessageBox.Show(
                "Sa kaotasid, bot võitis",
                "Sõnum",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    Form2 op = new Form2();
                    op.Show();
                    op.WindowState = FormWindowState.Minimized;
                    op.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }


            }
        }



        private void Rb_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            List<string> list = new List<string>();  // List of random NickName
            list.Add("draken");
            list.Add("maiky");


            Random rnd = new Random();
            int numb = rnd.Next(list.Count);



            using (StreamWriter writer = new StreamWriter(@"../../player.txt"))  // Write file using StreamWriter
            {
                writer.WriteLine(txt.Text);
            }

            this.Size = new Size(900, 900);

            string readText = File.ReadAllText(@"../../player.txt");  // Read file 
            if (String.IsNullOrEmpty(txt.Text))
            {
                lbl_p.Text = list[numb];
            }
            else
            {
                lbl_p.Text = readText;
            }

            this.Controls.Add(lbl_p);
            this.Controls.Add(lbl_bot);
            this.Controls.Add(rb);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);
            this.Controls.Add(pb);
            this.Controls.Add(btn3);
            this.Controls.Add(btn2);


        }
        private void Lbl_p_TextChanged(object sender, EventArgs e)
        {
            Size size_p = TextRenderer.MeasureText(lbl_p.Text, lbl_p.Font);
            lbl_p.Size = new Size(size_p.Width, size_p.Height);
        }
    }
}