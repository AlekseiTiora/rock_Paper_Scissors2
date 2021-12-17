using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        Button btn;
        Button btn2;
        Button btn3;
        PictureBox pb;
        public Form1()
        {
            this.Height = 700;//высота
            this.Width = 900;//ширина
            this.Text = "Rock_Paper_Scissors";//загловок формы
            this.BackgroundImage = new Bitmap(@"../../img/fon.jpg"); //картина фона формы

            MainMenu menu = new MainMenu();
            MenuItem menuFile = new MenuItem("Настройки");
            menuFile.MenuItems.Add("Teema", new EventHandler(menuFile_Tema_Select));
            menu.MenuItems.Add(menuFile);
            this.Menu = menu;


            btn = new Button();
            btn.BackColor = Color.White;
            btn.Text = "mängi botiga ";
            btn.Location = new Point(Top = 380, 80);
            btn.Size = new Size(100,100);
            btn.Click += Btn_Click;



            btn3 = new Button();
            btn3.BackColor = Color.White;
            btn3.Text = "määrused";
            btn3.Location = new Point(Top = 380, 430);
            btn3.Size = new Size(90, 90);
            btn3.Click += Btn3_Click;





            //pictureBox
            pb = new PictureBox();
            pb.Size = new Size(200, 200);
            pb.Location = new Point(320, 200);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.ImageLocation = ("../../img/igra.png");



            this.Controls.Add(pb);
            this.Controls.Add(btn3);

            this.Controls.Add(btn);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Võitja selgitatakse välja järgmiste reeglite järgi: Paber võidab kivi (paber keerab ümber kivi). Kivi lööb kääre (kivi tuhmub või lõhub käärid). Käärid peksid paberit (käärid lõikasid paberit).", "määrused");
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

        private void Btn2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}