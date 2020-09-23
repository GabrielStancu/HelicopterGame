using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helicopter_Game
{
    public partial class frmJoc : Form
    {
        //setam cateva variabile globale, este bine ca acestea sa fie setate la inceput, sa fie vizibile si usor de modificat la urmatoarele compilari
        bool goUp; //variabila care permite deplasarea in sus
        bool goDown; //variabila care permite deplasarea in jos
        bool shot = false; //variabila care determina daca jucatorul a tras vreun glont
        int score = 0; //variabila care tine scorul jucatorului
        int speed = 8; //variabila care determina viteza de deplasare a obstacolelor si a inamicilor (extraterestrilor)
        Random rand = new Random(); //clasa care genereaza numere random
        int playerSpeed = 7; //variabila care determina viteza de deplasare a jucatorului
        int index; //variabila care determina imaginea utilizata pentru inamici (extraterestri)

        public frmJoc()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e) //eveniment care are loc daca se apasa vreo tasta
        {
            if (e.KeyCode == Keys.Up) //daca se apasa sageata sus
            {
                goUp = true; //variabila devine true => jucatorul urca
            }

            if (e.KeyCode == Keys.Down) //daca se apasa sageata jos
            {
                goDown = true; //variabila devine true => jucatorul coboara
            }

            if (e.KeyCode == Keys.Space && shot == false) //daca se apasa space si shot = false (jucatorul nu a mai tras un glont si arma este incarcata)
            {
                makeBullet(); //se apeleaza functia de creare de glont
                shot = true; //shot = true => arma trebuie sa se incarce ca sa putem trage din nou
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e) //functie care are loc cand o tasta inceteaza sa fie apasata
        {
            if (e.KeyCode == Keys.Up) //daca nu se mai apasa sageata sus
            {
                goUp = false; //jucatorul nu mai urca
            }

            if(e.KeyCode == Keys.Down) //daca nu se mai apasa sageata jos
            {
                goDown = false; //jucatorul nu mai coboara
            }

            if(shot == true) //daca nu se mai apasa space
            {
                shot = false; // arma este incarcata
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e) //functia care are loc o data la 20 de miimi de secunda (din timer)
        {
            pbPillar1.Left -= speed; //obstacolul 1 se apropie cu speed = 8 pixeli de partea stanga a ecranului
            pbPillar2.Left -= speed; //obstacolul 2 se apropie cu speed = 8 pixeli de partea stanga a ecranului
            pbUfo.Left -= speed; //inamicul se apropie cu speed = 8 pixeli de partea stanga a ecranului
            label1.Text = "Score: " + score; //se actualizeaza scorul

            if (goUp && pbPlayer.Top > 0) //daca sageata sus este apasata si jucatorul nu a iesit din ecran
            {
                pbPlayer.Top -= playerSpeed; //jucatorul se apropie de partea de sus a ecranului cu playerSpeed = 8 pixeli
            }

            if (goDown && pbPlayer.Top < this.Height - pbPlayer.Height) //daca sageata jos este apasata si jucatorul nu a iesit din ecran
            {
                pbPlayer.Top += playerSpeed; //jucatorul se apropie de partea de jos a ecranului cu playerSpeed = 8 pixeli
            }

            if (pbPillar1.Left < -150) //daca obstacolul 1 a iesit prin partea stanga a ecranului, el va fi reincarcat in partea dreapta pentru a fi din nou evitat de jucator
            {
                pbPillar1.Left = 900;
            }

            if (pbPillar2.Left < -150) //daca obstacolul 2 a iesit prin partea stanga a ecranului, el va fi reincarcat in partea dreapta pentru a fi din nou evitat de jucator
            {
                pbPillar2.Left = 1000;
            }

            if (pbUfo.Left < -5 || //un inamic a iesit prin partea stanga a ecranului, neffind omorat
                pbPlayer.Bounds.IntersectsWith(pbUfo.Bounds) || //player-ul s-a lovit de un inamic
                pbPlayer.Bounds.IntersectsWith(pbPillar1.Bounds) || //player-ul s-a lovit de obstacolul 1
                pbPlayer.Bounds.IntersectsWith(pbPillar2.Bounds)) //player-ul s-a lovit de obstacolul 2
            {
                gameTimer.Stop(); //oprim timer-ul
                MessageBox.Show("Joc incheiat, ai omorat " + score + " UFO-uri."); //mesaj

                frmMain m = new frmMain(); //restart joc, creem o noua copie a ferestrei de meniu principal
                this.Hide(); //ascundem fereastra curenta
                m.ShowDialog(); //afisam copia ferestrei
                this.Close();  //inchidem fereastra curenta
            }

            foreach (Control x in this.Controls) //parcurgem controalele cu un for 
            {
                if (x is PictureBox && x.Tag != null) //daca avem control de tip pictureBox si tag-ul lui nu este NULL
                {
                    if (x.Tag.ToString() == "bullet") //daca are tag-ul "bullet" => este glont
                    {
                        x.Left += 15; //locatia lui creste cu 15 pixeli

                        if(x.Left > 900) //daca glontul a iesit prin partea dreapta e cranului
                        {
                            this.Controls.Remove(x); //eliminam glontul (eliberam memorie)
                            x.Dispose();
                        }

                        if (x.Bounds.IntersectsWith(pbUfo.Bounds)) //daca glontul a lovit un inamic
                        {
                            score += 1; //scorul creste
                            this.Controls.Remove(x); //eliminam glontul (eliberam memorie)
                            x.Dispose();

                            pbUfo.Left = 1000; //resetam pozitia urmatorului inamic
                            pbUfo.Top = rand.Next(70, 330) - pbUfo.Height; //determinam random inaltimea la care va aparea urmatorul inamic
                            changeUFO(); //apelam functia cu care schimbam imaginea inamicului
                        }
                    }
                }
            }
        }

        private void changeUFO() //functia cu care schimbam imaginea inamicului
        {
            index += 1; //crestem index-ul cu 1 

            if(index > 3) //index > 3 => error, setam inapoi pe 1 deoarece avem doar 3 imagini
            {
                index = 1;
            }

            switch (index) //swicth, la fel ca un if, am folosit pentru a adauga mai multe lucruri in proiect :)
            {
                case 1: //index = 1 => folosim prima imagine
                    pbUfo.Image = Properties.Resources.alien1;
                    break; //pentru a nu pierde timpul cu verificarea celorlalte cazuri
                case 2: //index = 2 => folosim a doua imagine
                    pbUfo.Image = Properties.Resources.alien2;
                    break;
                case 3: //index = 3 => folosim a treia imagine
                    pbUfo.Image = Properties.Resources.alien3;
                    break;
            }
        }

        private void makeBullet() //functia care creaza glontul
        {
            PictureBox bullet = new PictureBox(); //creem un nou pictureBox care va reprezenta glontul
            bullet.BackColor = Color.DarkOrange; //culoarea glontului
            bullet.Height = 5; // inaltime
            bullet.Width = 10; //latime
            bullet.Left = pbPlayer.Left + pbPlayer.Width; //pozitia initiala a glontului pe axa Ox
            bullet.Top = pbPlayer.Top + pbPlayer.Height / 2; //pozitia initiala a glontului pe axa Oy
            bullet.Tag = "bullet"; //setam tag-ul pe "bullet" pentru a-l putea folosi in functia din timer de mai sus (tag-ul este o eticheta a controlului, o proprietate optionala de diferentiere a controalelor)
            this.Controls.Add(bullet); //adaugam glontul in fereastra, adica in joc
        }
    }
}
