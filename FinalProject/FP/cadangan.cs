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
    public partial class cadangan : UserControl
    {
        public cadangan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        mydb db = new mydb();
        private void cadangan_Load(object sender, EventArgs e)
        {
             //INI UNTUK KETIKA PROGRAM DIRUN DATABASE SUDAH TERBACA
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Get(1,"select * from dt_user where id= (select MAX(id) from dt_user)");
            MessageBox.Show("Token Anda adalah 777777", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
         int increament;
        private void btnBayar_Click(object sender, EventArgs e)
        {
           
            if(txtToken.Text == "777777" && increament == 0)
            {
                increament++;
                MessageBox.Show("Selamat, Pembayaran anda telah berhasil!","Berhasil",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtToken.Text == "777777" && increament > 0)
            {
                MessageBox.Show("Maaf, Anda Sudah Membayar!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Maaf, Token Anda Salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
