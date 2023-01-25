using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject.FP
{
    
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
           
            
        }

       
        private void Beranda_Load(object sender, EventArgs e)
        {
            
        }

        private void pemesanan1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
