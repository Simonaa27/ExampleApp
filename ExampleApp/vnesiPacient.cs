using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class vnesiPacient : Form
    {
        public vnesiPacient()
        {
            InitializeComponent();
        }

        private void vnesiInfoPacient_Click(object sender, EventArgs e)
        {
            try
            {

                DBConnect connection = new DBConnect();
                connection.openConnection();
                string upit = "INSERT INTO pacienti(id_pacienti, id_maticen_doktor, ime_p, prezime_p, broj_karton, zdr_legitimacija) VALUES ('" + matBroj.Text + "','" + LoginInfo.doktor_id + "','" + imePacient.Text + "','" + prezimePacient.Text + "','" + brojKarton.Text + "','" + zdravstvenaLegitimacija.Text + "')";
                connection.Insert(upit);
                connection.closeConnection();
                MessageBox.Show("Внесен пациент!");

            }

            catch
            {
                MessageBox.Show("Грешка при внесување!");
            }
        }

        private void vnesiPacient_Load(object sender, EventArgs e)
        {

        }
    }
}
