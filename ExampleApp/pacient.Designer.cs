namespace ExampleApp
{
    partial class pacient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button vnesiNovPacient;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pacient));
            this.label2 = new System.Windows.Forms.Label();
            this.prikaziPacient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matBroj = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vrmt = new System.Windows.Forms.DateTimePicker();
            this.vreme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kolicinaLek = new System.Windows.Forms.TextBox();
            this.izdajRecept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.sitepacienti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            vnesiNovPacient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vnesiNovPacient
            // 
            vnesiNovPacient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vnesiNovPacient.BackgroundImage")));
            vnesiNovPacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            vnesiNovPacient.FlatAppearance.BorderSize = 0;
            vnesiNovPacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            vnesiNovPacient.Location = new System.Drawing.Point(153, 81);
            vnesiNovPacient.Name = "vnesiNovPacient";
            vnesiNovPacient.Size = new System.Drawing.Size(110, 33);
            vnesiNovPacient.TabIndex = 8;
            vnesiNovPacient.UseVisualStyleBackColor = true;
            vnesiNovPacient.Click += new System.EventHandler(this.vnesiNovPacient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Постоечки пациент";
            // 
            // prikaziPacient
            // 
            this.prikaziPacient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prikaziPacient.BackgroundImage")));
            this.prikaziPacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prikaziPacient.FlatAppearance.BorderSize = 0;
            this.prikaziPacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziPacient.Location = new System.Drawing.Point(338, 295);
            this.prikaziPacient.Name = "prikaziPacient";
            this.prikaziPacient.Size = new System.Drawing.Size(100, 36);
            this.prikaziPacient.TabIndex = 7;
            this.prikaziPacient.UseVisualStyleBackColor = true;
            this.prikaziPacient.Click += new System.EventHandler(this.prikaziPacient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Внеси ЕМБГ";
            // 
            // matBroj
            // 
            this.matBroj.Location = new System.Drawing.Point(257, 232);
            this.matBroj.Name = "matBroj";
            this.matBroj.Size = new System.Drawing.Size(181, 20);
            this.matBroj.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vrmt
            // 
            this.vrmt.Location = new System.Drawing.Point(677, 299);
            this.vrmt.Name = "vrmt";
            this.vrmt.Size = new System.Drawing.Size(200, 20);
            this.vrmt.TabIndex = 24;
            // 
            // vreme
            // 
            this.vreme.AutoSize = true;
            this.vreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vreme.Location = new System.Drawing.Point(676, 267);
            this.vreme.Name = "vreme";
            this.vreme.Size = new System.Drawing.Size(209, 20);
            this.vreme.TabIndex = 23;
            this.vreme.Text = "Времетраење на терапија";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(962, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Количина";
            // 
            // kolicinaLek
            // 
            this.kolicinaLek.Location = new System.Drawing.Point(966, 154);
            this.kolicinaLek.Name = "kolicinaLek";
            this.kolicinaLek.Size = new System.Drawing.Size(142, 20);
            this.kolicinaLek.TabIndex = 21;
            this.kolicinaLek.Text = "2x1";
            // 
            // izdajRecept
            // 
            this.izdajRecept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("izdajRecept.BackgroundImage")));
            this.izdajRecept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.izdajRecept.FlatAppearance.BorderSize = 0;
            this.izdajRecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izdajRecept.Location = new System.Drawing.Point(1065, 295);
            this.izdajRecept.Name = "izdajRecept";
            this.izdajRecept.Size = new System.Drawing.Size(101, 36);
            this.izdajRecept.TabIndex = 20;
            this.izdajRecept.UseVisualStyleBackColor = true;
            this.izdajRecept.Click += new System.EventHandler(this.izdajRecept_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(679, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Име на лек:";
            // 
            // lek
            // 
            this.lek.Location = new System.Drawing.Point(680, 154);
            this.lek.Name = "lek";
            this.lek.Size = new System.Drawing.Size(163, 20);
            this.lek.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(962, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Датум до:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(679, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Датум од:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(966, 238);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(200, 20);
            this.datumDo.TabIndex = 15;
            // 
            // datumOd
            // 
            this.datumOd.Location = new System.Drawing.Point(677, 238);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(200, 20);
            this.datumOd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(670, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Издади нов рецепт";
            // 
            // sitepacienti
            // 
            this.sitepacienti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sitepacienti.BackgroundImage")));
            this.sitepacienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sitepacienti.FlatAppearance.BorderSize = 0;
            this.sitepacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sitepacienti.Location = new System.Drawing.Point(153, 295);
            this.sitepacienti.Name = "sitepacienti";
            this.sitepacienti.Size = new System.Drawing.Size(110, 36);
            this.sitepacienti.TabIndex = 26;
            this.sitepacienti.UseVisualStyleBackColor = true;
            this.sitepacienti.Click += new System.EventHandler(this.sitepacienti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sitepacienti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vrmt);
            this.Controls.Add(this.vreme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kolicinaLek);
            this.Controls.Add(this.izdajRecept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(vnesiNovPacient);
            this.Controls.Add(this.prikaziPacient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matBroj);
            this.MaximizeBox = false;
            this.Name = "pacient";
            this.Text = "pacient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prikaziPacient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matBroj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker vrmt;
        private System.Windows.Forms.Label vreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kolicinaLek;
        private System.Windows.Forms.Button izdajRecept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sitepacienti;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}