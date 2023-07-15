using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Note_Registration_System.Properties;

namespace Note_Registration_System
{
    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public string number;

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-K0B0HR9\SQLEXPRESS;Initial Catalog=DbNoteReg;Integrated Security=True");

        //Data Source=DESKTOP-K0B0HR9\SQLEXPRESS;Initial Catalog=DbNoteReg;Integrated Security=True
        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            LblNumber.Text = number;
            if (number=="7446")
            {
                this.BackgroundImage = Properties.Resources.fatiht;
                player.SoundLocation = "Fatih Terim-Gangstas Paradise.wav";
                player.Play();
            }
            _connection.Open();
            SqlCommand _command = new SqlCommand("Select * From Tbl_Lesson where STDNUMBER=@p1", _connection);
            _command.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = _command.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblExam1.Text = dr[4].ToString();
                LblExam2.Text = dr[5].ToString();
                LblExam3.Text = dr[6].ToString();
                LblAverage.Text = dr[7].ToString();
                LblSituation.Text = dr[8].ToString();
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void LblAverage_Click(object sender, EventArgs e)
        {

        }
    }
}
