using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodeDB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter.Fill(tabel);
            LisaPilt.DataSource = tabel;
            connect.Close();
        }
        private void ClearData()
        {
            Id = 0;
            Toode.Text = "";
            Kogus.Text = "";
            Hinne.Text = "";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
            // TODO: This line of code loads data into the 'toodedDataSet.Toodetable' table. You can move, or remove it, as needed.
            //this.toodetableTableAdapter.Fill(this.toodedDataSet.Toodetable);

        //}

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (Toode.Text!="" && Kogus.Text!="" && Hinne.Text!="")
            {
                command = new SqlCommand("insert into Toodetable(Toodenimetus, Kogus,Hind) values (@toode,@kogus,@hind)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@toode", Toode.Text);
                command.Parameters.AddWithValue("@kogus", Kogus.Text);
                command.Parameters.AddWithValue("@hind", Hinne.Text.Replace(",","."));
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Amdmed on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Toode.Text != "" && Kogus.Text != "" && Hinne.Text != "")
            {
                command = new SqlCommand("UPDATE Toodetable SET Toodenimetus=@toode, Kogus=@kogus,Hind=@hind WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toode.Text);
                command.Parameters.AddWithValue("@kogus", Kogus.Text);
                command.Parameters.AddWithValue("@hind", Hinne.Text.Replace(",", "."));
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on uuendatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(LisaPilt.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toode.Text = LisaPilt.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("delete Toodetable where ID=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Andmed on eemaldatud");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void btnPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg;*.webp)|*.jpeg;*.bmp;*.png;*.jpg;*.webp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = Toode.Text +"_"+Id;
                save.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg;*.webp)|*.jpeg;*.bmp;*.png;*.jpg;*.webp";
                save.ShowDialog();
            }
        }
    }
}
