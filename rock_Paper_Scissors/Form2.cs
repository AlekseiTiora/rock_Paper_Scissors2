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

        static string[] picturesplayer = { "kivi.png", "kaarid.png", "paber.png" };
        static string[] picturesbot = { "kivi.png", "kaarid.png", "paber.png" };
        public Random rnd = new Random();

        TextBox txt;
        Label lbl_p;
        Label lbl_bot;
        Label lbl2;
        Label lbl3;
        PictureBox pb;
        PictureBox pb1;
        RadioButton rdb;
        RadioButton rdb2;
        RadioButton rdb3;
        Button btn2;

        public int numb;
        public Form2()
        {
            this.Size = new Size(500, 500);
            this.Text = "Rock_Paper_Scissors";
            this.BackgroundImage = new Bitmap(@"../../img/fon.jpg"); //картина фона формы

            MainMenu menu = new MainMenu();
            MenuItem menuFile = new MenuItem("Настройки");
            menuFile.MenuItems.Add("Teema", new EventHandler(menuFile_Tema_Select));
            menu.MenuItems.Add(menuFile);
            this.Menu = menu;

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
            lbl_p.Location = new Point(170, 70);
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

            lbl2 = new Label();
            lbl2.Text = "0";
            lbl2.Size = new Size(50, 50);//Size
            lbl2.Location = new Point(530, 140); //x,y


            lbl3 = new Label();
            lbl3.Text = "0";
            lbl3.Size = new Size(50, 50);//Size
            lbl3.Location = new Point(170, 140); //x,y



            pb = new PictureBox();
            pb.ImageLocation = "../../img/vopros.jpg";
            pb.Size = new Size(200, 200);
            pb.Location = new Point(500, 200);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pb1 = new PictureBox();
            pb1.ImageLocation = "../../img/vopros.jpg";
            pb1.Size = new Size(200, 200);
            pb1.Location = new Point(100, 200);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;

            btn2 = new Button();
            btn2.Text = "Start";//text
            btn2.Location = new Point(300, 500);//x,y
            btn2.Height = 60;
            btn2.Width = 180;
            btn2.Click += Btn2_Click;

            rdb = new RadioButton();
            rdb.Height = 30;
            rdb.Width = 130;
            rdb.Location = new Point(70, 500);
            rdb.Text = "Kivi";
            rdb.Click += Rdb_Click1;

            //RadioButton2
            rdb2 = new RadioButton();
            rdb2.Height = 30;
            rdb2.Width = 130;
            rdb2.Location = new Point(70, 550);
            rdb2.Text = "Kärid";
            rdb2.Click += Rdb2_Click1;

            //RadioButton3
            rdb3 = new RadioButton();
            rdb3.Height = 30;
            rdb3.Width = 130;
            rdb3.Location = new Point(70, 600);
            rdb3.Text = "Paber";
            rdb3.Click += Rdb3_Click1;






            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            this.Controls.Add(btn);

        }


        int cshetplayer = 0;
        int cshetbot = 0;
        private void Btn2_Click(object sender, EventArgs e)
        {
            int randombot = rnd.Next(1, 4);

            if (randombot == 1)
            {

                pb.Image = Image.FromFile(@"..\..\img\" + picturesbot[0]);

            }
            else if (randombot == 2)
            {

                pb.Image = Image.FromFile(@"..\..\img\" + picturesbot[1]);
            }
            else if (randombot == 3)
            {

                pb.Image = Image.FromFile(@"..\..\img\" + picturesbot[2]);
            }


            if (rdb.Checked == true && randombot == 2 || rdb2.Checked == true && randombot == 3 || rdb3.Checked == true && randombot == 1)
            {
                cshetplayer++;
                string podcet = cshetplayer.ToString();

                lbl3.Text = "";
                lbl3.Text = podcet;
                if (cshetplayer == 3)
                {





                    var answer = MessageBox.Show("Sina" + " võitis . Restart?", "messagebox", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }

                }

            }
            else if (randombot == 1 && rdb2.Checked == true || randombot == 2 && rdb3.Checked == true || randombot == 3 && rdb.Checked == true)
            {
                cshetbot++;
                string podcetbot = picturesbot.ToString();

                lbl2.Text = "";
                lbl2.Text = podcetbot;
                if (cshetbot == 3)
                {

                    var answer = MessageBox.Show("Bot võitis . Restart?", "messagebox", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }


                }
            }
        }
        

        private void Rdb3_Click1(object sender, EventArgs e)
        {
            pb1.Image = Image.FromFile(@"..\..\img\" + picturesplayer[2]);
        }

        private void Rdb2_Click1(object sender, EventArgs e)
        {
           pb1.Image = Image.FromFile(@"..\..\img\" + picturesplayer[1]);
        }

        private void Rdb_Click1(object sender, EventArgs e)
        {
           pb1.Image = Image.FromFile(@"..\..\img\" + picturesplayer[0]);
        }

        int scetcik = 0;
        private void menuFile_Tema_Select(object sender, EventArgs e)
        {
            scetcik++;
            if (scetcik == 1)
            {
                this.BackgroundImage = new Bitmap(@"../../img/fon2.png");

            }
            else if (scetcik == 2)
            {
                this.BackgroundImage = new Bitmap(@"../../img/fon.jpg");
                scetcik = 0;
            }
        }

        private void Btn3_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void Btn2_MouseClick(object sender, MouseEventArgs e)
        {
         
            
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
            this.Controls.Add(pb);
            this.Controls.Add(pb1);
            this.Controls.Add(btn2);
            this.Controls.Add(rdb);
            this.Controls.Add(rdb2);
            this.Controls.Add(rdb3);
            




        }
        private void Lbl_p_TextChanged(object sender, EventArgs e)
        {
            Size size_p = TextRenderer.MeasureText(lbl_p.Text, lbl_p.Font);
            lbl_p.Size = new Size(size_p.Width, size_p.Height);
        }
    }
}