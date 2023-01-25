using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Pkcs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FinalProject.FP
{
    public partial class Pemesanan : UserControl
    {
        public Pemesanan()
        {
            InitializeComponent();
        }
        int[] Seat = new int[28];


        int p;
        string[] pesan = new string[7];
        string seat;
        string gabungarray;




        private void Pemesanan_Load(object sender, EventArgs e)
        {

            /*
            mydb db = new mydb();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM `film` WHERE `id`=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = command;
            */

            //cmd.Parameters.AddWithValue("@id", id);

            //cmd.Parameters.AddWithValue("@hari", hari);
            //cmd.Parameters.Add("@usn", MySqlDbType.Int32).Value;
            //cmd.ExecuteReader(0);
            cadangan1.Hide();

            for (int i = 0; i < 28; i++)
            {
                Seat[i] = 2;
            }






        }
        public void update_harga()
        { p = 0;
            for (int i = 0; i < 6; i++)
            {
                if (pesan[i] !=null)
                {
                    p++;
                }
            }
            gabungarray = string.Join(" ", pesan);
            //gabungarray = string.Concat(pesan);
            seat = gabungarray;
            Lblseat.Text = seat;
            LblHarga.Text = Convert.ToString(p * 45000);
        }
       
        private void isiBeranda1_Load(object sender, EventArgs e)
        {

        }

        private void btnseat1_Click_1(object sender, EventArgs e)
        {
            btnseat1.ForeColor = Color.Black;
            if (Seat[0] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] !=null && j<=5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "A1";
                    Seat[0]++;
                    btnseat1.BackColor = Color.White;
                }
                else
                {
                    //ga berubah

                }
                j=0;

            }//yg udah hidup
            else 
            {
                
                int j = 0;
                while (pesan[j] != "A1" && j <= 5)
                {
                    
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat1.BackColor = Color.DarkRed;
                    btnseat1.ForeColor = Color.White;
                    Seat[0]++;

                }
            }





            update_harga();
           
            

        }

        private void btnseat2_Click(object sender, EventArgs e)
        {

            /*
            Seat[1]++;
            if (Seat[1] % 2 == 1 && p < 6)
            {
                btnseat2.BackColor = Color.White;
                p++;
                pesan[Convert.ToInt32(p)] = "A2 ";
            }
            else if (p >= 6 && Seat[1] % 2 == 1)
            {
                Seat[1]++;
                //penuh
            }
            else if (p >= 6 && Seat[1] % 2 == 0)
            {
                btnseat2.BackColor = Color.DarkRed;
                pesan[Convert.ToInt32(p)] = "";
                p--;
                
            }
          
            else
            {
                btnseat2.BackColor = Color.DarkRed;
                pesan[Convert.ToInt32(p)] = "";
                p--;
                
            }*/
            btnseat2.ForeColor = Color.Black;
            if (Seat[1] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = "A2";
                    btnseat2.BackColor = Color.White;
                    Seat[1]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "A2" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = null;
                    btnseat2.ForeColor= Color.White;
                    btnseat2.BackColor = Color.DarkRed;
                    Seat[1]++;

                }
            }
            update_harga();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
        }

        private void btnseat3_Click(object sender, EventArgs e)
        {
            btnseat3.ForeColor= Color.Black;
            if (Seat[2] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = "A3";
                    btnseat3.BackColor = Color.White;
                    Seat[2]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "A3" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = null;
                    btnseat3.ForeColor = Color.White;
                    btnseat3.BackColor = Color.DarkRed;
                    Seat[2]++;

                }
            }
            update_harga();

        }

        private void btnseat4_Click(object sender, EventArgs e)
        {
            btnseat4.ForeColor = Color.Black;
            if (Seat[3] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = "A4";
                    btnseat4.BackColor = Color.White;
                    Seat[3]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "A4" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = null;
                    btnseat4.ForeColor = Color.White;
                    btnseat4.BackColor = Color.DarkRed;
                    Seat[3]++;

                }
            }
            update_harga();
        }

        private void btnseat5_Click(object sender, EventArgs e)
        {
            btnseat5.ForeColor = Color.Black;
            if (Seat[4] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = "A5";
                    btnseat5.BackColor = Color.White;
                    Seat[4]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "A5" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = null;
                    btnseat5.ForeColor = Color.White;
                    btnseat5.BackColor = Color.DarkRed;
                    Seat[4]++;

                }
            }
            update_harga();
        }

        private void btnseat6_Click(object sender, EventArgs e)
        {
            btnseat6.ForeColor = Color.Black;
            if (Seat[5] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = "A6";
                    btnseat6.BackColor = Color.White;
                    Seat[5]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "A6" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = null;
                    btnseat6.ForeColor = Color.White;
                    btnseat6.BackColor = Color.DarkRed;
                    Seat[5]++;

                }
            }
            update_harga();
        }

        private void btnseat7_Click(object sender, EventArgs e)
        {
            btnseat7.ForeColor = Color.Black;
            if (Seat[6] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j ] = "A7";
                    btnseat7.BackColor = Color.White;
                    Seat[6]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "A7" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat7.ForeColor = Color.White;
                    btnseat7.BackColor = Color.DarkRed;
                    Seat[6]++;

                }
            }
            update_harga();
        }

        private void btnseat14_Click(object sender, EventArgs e)
        {
            btnseat14.ForeColor = Color.Black;
            if (Seat[7] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B1";
                    btnseat14.BackColor = Color.White;
                    Seat[7]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B1" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat14.ForeColor = Color.White;
                    btnseat14.BackColor = Color.DarkRed;
                    Seat[7]++;

                }
            }
            update_harga();
        }

        private void btnseat13_Click(object sender, EventArgs e)
        {
            btnseat13.ForeColor = Color.Black;
            if (Seat[8] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B2";
                    btnseat13.BackColor = Color.White;
                    Seat[8]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B2" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat13.ForeColor = Color.White;
                    btnseat13.BackColor = Color.DarkRed;
                    Seat[8]++;

                }
            }
            update_harga();
        }

        private void btnseat12_Click(object sender, EventArgs e)
        {
            btnseat12.ForeColor = Color.Black;
            if (Seat[9] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B3";
                    btnseat12.BackColor = Color.White;
                    Seat[9]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B3" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat12.ForeColor = Color.White;
                    btnseat12.BackColor = Color.DarkRed;
                    Seat[9]++;

                }
            }
            update_harga();
        }

        private void btnseat11_Click(object sender, EventArgs e)
        {
            btnseat11.ForeColor = Color.Black;
            if (Seat[10] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B4";
                    btnseat11.BackColor = Color.White;
                    Seat[10]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B4" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat11.ForeColor = Color.White;
                    btnseat11.BackColor = Color.DarkRed;
                    Seat[10]++;

                }
            }
            update_harga();
        }

        private void btnseat10_Click(object sender, EventArgs e)
        {
            btnseat10.ForeColor = Color.Black;
            if (Seat[11] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B5";
                    btnseat10.BackColor = Color.White;
                    Seat[11]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B5" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat10.ForeColor = Color.White;
                    btnseat10.BackColor = Color.DarkRed;
                    Seat[11]++;

                }
            }
            update_harga();
        }

        private void btnseat9_Click(object sender, EventArgs e)
        {
            btnseat9.ForeColor = Color.Black;
            if (Seat[12] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B6";
                    btnseat9.BackColor = Color.White;
                    Seat[12]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B6" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat9.ForeColor = Color.White;
                    btnseat9.BackColor = Color.DarkRed;
                    Seat[12]++;

                }
            }
            update_harga();
        }

        private void btnseat8_Click(object sender, EventArgs e)
        {
            btnseat8.ForeColor = Color.Black;
            if (Seat[13] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "B7";
                    btnseat8.BackColor = Color.White;
                    Seat[13]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "B7" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat8.ForeColor = Color.White;
                    btnseat8.BackColor = Color.DarkRed;
                    Seat[13]++;

                }
            }
            update_harga();
        }

        private void btnseat15_Click(object sender, EventArgs e)
        {
            btnseat15.ForeColor = Color.Black;
            if (Seat[14] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C1";
                    btnseat15.BackColor = Color.White;
                    Seat[14]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C1" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat15.ForeColor = Color.White;
                    btnseat15.BackColor = Color.DarkRed;
                    Seat[14]++;

                }
            }
            update_harga();
        }

        private void btnseat16_Click(object sender, EventArgs e)
        {
            btnseat16.ForeColor = Color.Black;
            if (Seat[15] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C2";
                    btnseat16.BackColor = Color.White;
                    Seat[15]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C2" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat16.ForeColor = Color.White;
                    btnseat16.BackColor = Color.DarkRed;
                    Seat[15]++;

                }
            }
            update_harga();
        }

        private void btnseat17_Click(object sender, EventArgs e)
        {
            btnseat17.ForeColor = Color.Black;
            if (Seat[16] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C3";
                    btnseat17.BackColor = Color.White;
                    Seat[16]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C3" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat17.ForeColor = Color.White;
                    btnseat17.BackColor = Color.DarkRed;
                    Seat[16]++;

                }
            }
            update_harga();
        }

        private void btnseat18_Click(object sender, EventArgs e)
        {
            btnseat18.ForeColor = Color.Black;
            if (Seat[17] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C4";
                    btnseat18.BackColor = Color.White;
                    Seat[17]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C4" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat18.ForeColor = Color.White;
                    btnseat18.BackColor = Color.DarkRed;
                    Seat[17]++;

                }
            }
            update_harga();
        }

        private void btnseat19_Click(object sender, EventArgs e)
        {
            btnseat19.ForeColor = Color.Black;
            if (Seat[18] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C5";
                    btnseat19.BackColor = Color.White;
                    Seat[18]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C5" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat19.ForeColor = Color.White;
                    btnseat19.BackColor = Color.DarkRed;
                    Seat[18]++;

                }
            }
            update_harga();
        }

        private void btnseat20_Click(object sender, EventArgs e)
        {
            btnseat20.ForeColor = Color.Black;
            if (Seat[19] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C6";
                    btnseat20.BackColor = Color.White;
                    Seat[19]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C6" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat20.ForeColor = Color.White;
                    btnseat20.BackColor = Color.DarkRed;
                    Seat[19]++;

                }
            }
            update_harga();
        }

        private void btnseat21_Click(object sender, EventArgs e)
        {
            btnseat21.ForeColor = Color.Black;
            if (Seat[20] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "C7";
                    btnseat21.BackColor = Color.White;
                    Seat[20]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "C7" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat21.ForeColor = Color.White;
                    btnseat21.BackColor = Color.DarkRed;
                    Seat[20]++;

                }
            }
            update_harga();
        }

        private void btnseat28_Click(object sender, EventArgs e)
        {
            btnseat28.ForeColor = Color.Black;
            if (Seat[21] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D1";
                    btnseat28.BackColor = Color.White;
                    Seat[21]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D1" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat28.ForeColor = Color.White;
                    btnseat28.BackColor = Color.DarkRed;
                    Seat[21]++;

                }
            }
            update_harga();
        }

        private void btnseat27_Click(object sender, EventArgs e)
        {
            btnseat27.ForeColor = Color.Black;
            if (Seat[22] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D2";
                    btnseat27.BackColor = Color.White;
                    Seat[22]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D2" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat27.ForeColor = Color.White;
                    btnseat27.BackColor = Color.DarkRed;
                    Seat[22]++;

                }
            }
            update_harga();
        }

        private void btnseat26_Click(object sender, EventArgs e)
        {
            btnseat26.ForeColor = Color.Black;
            if (Seat[23] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D3";
                    btnseat26.BackColor = Color.White;
                    Seat[23]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D3" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat26.ForeColor = Color.White;
                    btnseat26.BackColor = Color.DarkRed;
                    Seat[23]++;

                }
            }
            update_harga();
        }

        private void btnseat25_Click(object sender, EventArgs e)
        {
            btnseat25.ForeColor = Color.Black;
            if (Seat[24] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D4";
                    btnseat25.BackColor = Color.White;
                    Seat[24]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D4" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat25.ForeColor = Color.White;
                    btnseat25.BackColor = Color.DarkRed;
                    Seat[24]++;

                }
            }
            update_harga();
        }

        private void btnseat24_Click(object sender, EventArgs e)
        {
            btnseat24.ForeColor = Color.Black;
            if (Seat[25] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D5";
                    btnseat24.BackColor = Color.White;
                    Seat[25]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D5" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat24.ForeColor = Color.White;
                    btnseat24.BackColor = Color.DarkRed;
                    Seat[25]++;

                }
            }
            update_harga();
        }

        private void btnseat23_Click(object sender, EventArgs e)
        {
            btnseat23.ForeColor = Color.Black;
            if (Seat[26] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D6";
                    btnseat23.BackColor = Color.White;
                    Seat[26]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D6" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat23.ForeColor = Color.White;
                    btnseat23.BackColor = Color.DarkRed;
                    Seat[26]++;

                }
            }
            update_harga();
        }

        private void btnseat22_Click(object sender, EventArgs e)
        {
            btnseat22.ForeColor = Color.Black;
            if (Seat[27] % 2 == 0)
            {
                int j = 0;
                while (pesan[j] != null && j <= 5)
                {
                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = "D7";
                    btnseat22.BackColor = Color.White;
                    Seat[27]++;
                }
                else
                {
                    //ga berubah

                }
                j = 0;

            }//yg udah hidup
            else
            {
                int j = 0;
                while (pesan[j] != "D7" && j <= 5)
                {

                    j++;
                }
                if (j != 6)
                {
                    pesan[j] = null;
                    btnseat22.ForeColor = Color.White;
                    btnseat22.BackColor = Color.DarkRed;
                    Seat[27]++;

                }
            }
            update_harga();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string tgl, room, jam;
        int harga;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadangan1_Load(object sender, EventArgs e)
        {

        }

        private void cadangan1_Load_1(object sender, EventArgs e)
        {

        }

        private void TanggalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
      

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            harga = p * 45000;
            jam = JamTayangCB.Text;
            tgl = TanggalCB.Text;
            room=StudioCB.Text ;
            //string seet = (pesan[0] + pesan[1]+ pesan[2]+ pesan[3]+ pesan[4]+ pesan[5]+ pesan[6]);
            //var gabungArray = string.Join(" ", pesan);
            if (seat == null && tgl == "" && jam == "" && room == "")
            {
                MessageBox.Show("Pesanan anda belum lengkap", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (seat != null)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=bioskop");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update dt_user set tgl=@tgl,room=@room,jam=@jam ,seet=@seet, harga=@harga where id=(select MAX(id) from dt_user )", con);
                cmd.Parameters.AddWithValue("@tgl", tgl);
                cmd.Parameters.AddWithValue("@room", room);
                cmd.Parameters.AddWithValue("@jam", jam);
                cmd.Parameters.AddWithValue("@seet", gabungarray);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.ExecuteNonQuery();
                con.Close();
                cadangan1.Show();
            }
        }
    }
}
