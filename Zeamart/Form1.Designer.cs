namespace Zeamart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ID = new TextBox();
            label3 = new Label();
            Nama = new TextBox();
            label4 = new Label();
            Stok = new TextBox();
            label5 = new Label();
            Harga = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            ImageText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(359, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(730, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 64;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.DataPropertyName = "Nama Produk";
            Column2.HeaderText = "Nama Produk";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 144;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "Stok";
            Column3.HeaderText = "Stok";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 83;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.DataPropertyName = "Harga";
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 96;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.DataPropertyName = "Picture";
            Column5.HeaderText = "Picture";
            Column5.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 111);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // Add
            // 
            Add.BackColor = Color.PaleTurquoise;
            Add.ForeColor = SystemColors.ActiveCaptionText;
            Add.Location = new Point(358, 549);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += button1_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.PaleTurquoise;
            Update.ForeColor = SystemColors.ActiveCaptionText;
            Update.Location = new Point(482, 549);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 3;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += button2_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.PaleTurquoise;
            Delete.ForeColor = SystemColors.ActiveCaptionText;
            Delete.Location = new Point(604, 549);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(446, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(642, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(358, 123);
            label1.Name = "label1";
            label1.Size = new Size(80, 35);
            label1.TabIndex = 7;
            label1.Text = "Search";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 132);
            label2.Name = "label2";
            label2.Size = new Size(35, 35);
            label2.TabIndex = 8;
            label2.Text = "Id";
            label2.Click += label2_Click;
            // 
            // ID
            // 
            ID.BorderStyle = BorderStyle.FixedSingle;
            ID.Location = new Point(21, 171);
            ID.Name = "ID";
            ID.Size = new Size(310, 31);
            ID.TabIndex = 9;
            ID.TextChanged += ID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(20, 207);
            label3.Name = "label3";
            label3.Size = new Size(149, 35);
            label3.TabIndex = 10;
            label3.Text = "Nama Produk";
            label3.Click += label3_Click;
            // 
            // Nama
            // 
            Nama.BorderStyle = BorderStyle.FixedSingle;
            Nama.Location = new Point(21, 245);
            Nama.Name = "Nama";
            Nama.Size = new Size(310, 31);
            Nama.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(24, 281);
            label4.Name = "label4";
            label4.Size = new Size(59, 35);
            label4.TabIndex = 12;
            label4.Text = "Stok";
            label4.Click += label4_Click;
            // 
            // Stok
            // 
            Stok.BorderStyle = BorderStyle.FixedSingle;
            Stok.Location = new Point(21, 319);
            Stok.Name = "Stok";
            Stok.Size = new Size(310, 31);
            Stok.TabIndex = 13;
            Stok.TextChanged += Stok_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 355);
            label5.Name = "label5";
            label5.Size = new Size(76, 35);
            label5.TabIndex = 14;
            label5.Text = "Harga";
            label5.Click += label5_Click;
            // 
            // Harga
            // 
            Harga.BorderStyle = BorderStyle.FixedSingle;
            Harga.Location = new Point(21, 393);
            Harga.Name = "Harga";
            Harga.Size = new Size(310, 31);
            Harga.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(20, 468);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(20, 428);
            label6.Name = "label6";
            label6.Size = new Size(86, 35);
            label6.TabIndex = 17;
            label6.Text = "Picture";
            // 
            // ImageText
            // 
            ImageText.Location = new Point(21, 470);
            ImageText.Name = "ImageText";
            ImageText.Size = new Size(309, 31);
            ImageText.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1119, 620);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(Harga);
            Controls.Add(label5);
            Controls.Add(Stok);
            Controls.Add(label4);
            Controls.Add(Nama);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(ImageText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Add;
        private Button Update;
        private Button Delete;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox ID;
        private Label label3;
        private TextBox Nama;
        private Label label4;
        private TextBox Stok;
        private Label label5;
        private TextBox Harga;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox ImageText;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
    }
}