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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btJocNou_Click(object sender, EventArgs e) //functia actionata la click-ul butonului de joc nou 
        {
            frmJoc f = new frmJoc(); //se creeaza o copie a ferestrei de joc nou
            this.Hide(); //se ascunde fereastra curenta
            f.ShowDialog(); //se afiseaza copia creata
            this.Close(); //se inchide fereastra curenta
        }

        private void btInstr_Click(object sender, EventArgs e) //functia actionata la click-ul butonului de instructiuni
        {
            frmInstr i = new frmInstr(); //se creeaza o copie a ferestrei de instructiuni
            this.Hide(); //se ascunde fereastra curenta
            i.ShowDialog(); //se afiseaza copia creata
            this.Close(); //se inchide fereastra curenta
        }

        private void btIesire_Click(object sender, EventArgs e) //functia actionata la click-ul butonului de inchidere joc
        {
            Application.Exit(); //comanda de inchidere a aplicatiei
        }
    }
}
