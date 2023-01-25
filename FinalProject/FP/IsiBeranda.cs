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
using System.Xml.Linq;


namespace FinalProject.FP
{
    
    public partial class IsiBeranda : UserControl
    {
        
        public IsiBeranda()
        {
            InitializeComponent();
        }
        string[] judul = { "spiderman", "Mencuri Raden Saleh", "One Piece Film: Red", "Puss in Boots: The Last Wish", "Us", "Ngeri-Ngeri Sedap", "Shutter Island", "Matrix", "The Maze Runner", "Everything Everywhere All at Once", "Boku no Pico", "Avatar The Way of Water" };
        string[] genre = { "Action", "Action", "Animation", "Animation", "Horor", "Comedy", "Mystery", "Sci-fi", "Action", "Adventure", "Fantasy", "Sci-fi" };
        string[] durasi = { "90 menit", "154 menit", "115 menit", "102 menit", "116 menit", "114 menit", "138 menit", "136 menit", "113 menit", "139 menit", "1000 menit", "192 menit" };
        public void data(int x)
        {
            pemesanan1.Show();
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=bioskop");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into dt_user (film,genre,durasi) values (@film,@genre,@durasi)", con);
            cmd.Parameters.AddWithValue("@film", judul[x]);
            cmd.Parameters.AddWithValue("@genre", genre[x]);
            cmd.Parameters.AddWithValue("@durasi", durasi[x]);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int para;
        private void IsiBeranda_Load(object sender, EventArgs e)
        {

            pemesanan1.Hide();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
     
        private void btnfilm2_Click(object sender, EventArgs e)
        {
            data(1);
        }

        private void btnfilm3_Click(object sender, EventArgs e)
        {
            data(2);
        }

        private void btnfilm4_Click(object sender, EventArgs e)
        {
            data(3);
        }

        private void btnfilm5_Click(object sender, EventArgs e)
        {
            data(4);
        }

        private void btnfilm6_Click(object sender, EventArgs e)
        {
            data(5);
        }

        private void btnfilm7_Click(object sender, EventArgs e)
        {
            data(6);
        }

        private void btnfilm8_Click(object sender, EventArgs e)
        {
            data(7);
        }

        private void btnfilm9_Click(object sender, EventArgs e)
        {
            data(8);
        }

        private void btnfilm10_Click(object sender, EventArgs e)
        {
            data(9);
        }

        private void btnfilm11_Click(object sender, EventArgs e)
        {
            data(10);
        }

        private void btnfilm12_Click(object sender, EventArgs e)
        {
            data(11);
        }
        private void btnfilm(object sender, EventArgs e)
        {
            data(0);
            


        }

        private void pemesanan1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
