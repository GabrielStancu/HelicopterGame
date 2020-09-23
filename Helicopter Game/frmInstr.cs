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
    public partial class frmInstr : Form
    {
        public frmInstr()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e) //functia actionata de click-ul butonului de meniu principal
        {
            frmMain m = new frmMain(); //se creeaza o noua copie a ferestrei de meniu principal
            this.Hide(); //se ascunde fereastra curenta
            m.ShowDialog(); //se afiseaza fereastra creeata
            this.Close(); //se inchide fereastra curenta 
        }
    }
}
