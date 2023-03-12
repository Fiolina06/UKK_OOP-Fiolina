using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Zeamart
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = Conn.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {

            InitializeComponent();
        }

        public DataTable getData()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Hero", conn))
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(conn, "SET @id :=0; Update hero SET id = @id := (@id+1); " +
                "ALTER TABLE hero AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void fillDataTabel()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 150;
            dataGridView1.DataSource = getData();
            Column1.DataPropertyName = "ID";
            Column2.DataPropertyName = "Nama";
            Column3.DataPropertyName = "Stok";
            Column4.DataPropertyName = "harga";
            Column5.DataPropertyName = "Image";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataTabel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e) //delete
        {
            string query = "DELETE FROM hero WHERE ID='" + this.ID.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully delleted!");
            conn.Close();
            resetIncrement();
            fillDataTabel();
        }

        private void button2_Click(object sender, EventArgs e) //edit
        {
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "UPDATE hero SET Nama=@Nama, Stok=@Stok, harga= @harga , Image=@Image WHERE ID=@ID";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", this.ID.Text);
            cmd.Parameters.AddWithValue("@Nama", this.Nama.Text);
            cmd.Parameters.AddWithValue("@Stok", this.Stok.Text);
            cmd.Parameters.AddWithValue("@Harga", this.Harga.Text);
            cmd.Parameters.AddWithValue("@Image", img);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record has been successfully");
            conn.Close();
            fillDataTabel();
        }



        private void button1_Click(object sender, EventArgs e) //add
        {
            // Convert image to byte array

            if (pictureBox2.Image != null)
            {
                try
                {
                    // Convert image to byte array
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    string query = "INSERT INTO `hero`(`Nama`, `Stok`, `harga`,`Image`) VALUES (@Nama, @Stok, @Harga, @Image)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    resetIncrement();

                    // Add parameters and values to command
                    cmd.Parameters.AddWithValue("@ID", this.ID.Text);
                    cmd.Parameters.AddWithValue("@Nama", this.Nama.Text);
                    cmd.Parameters.AddWithValue("@Stok", this.Stok.Text);
                    cmd.Parameters.AddWithValue("@Harga", this.Harga.Text);
                    cmd.Parameters.AddWithValue("@Image", img);

                    // Execute query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully saved");
                    conn.Close();
                    fillDataTabel();
                    //File.Copy(ImageText.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox2.ImageLocation));//rest of the code to insert data into the MySQL database table
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            ID.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            Nama.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            Stok.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            Harga.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox2.Image = Image.FromStream(ms);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //search
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM hero WHERE CONCAT (ID, Nama, Stok, harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //search 
        {
            searchData(textBox1.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stok_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;) | *.jpg;*.jpeg;*.png;*.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openfd.FileName);
            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}