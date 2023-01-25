using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.FP
{
    public partial class Pembayaran : UserControl
    {
        public Pembayaran()
        {
            InitializeComponent();
        }
        private void Pembayaran_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=bioskop");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from dt_user where (select MAX(id) from dt_user) ", con);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listSeat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
