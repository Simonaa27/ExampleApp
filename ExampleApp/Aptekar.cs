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
    public partial class Aptekar : Form
    {
        public Aptekar()
        {
            InitializeComponent();
        }
        public int id;
        private void button1_Click(object sender, EventArgs e)
        {
            string prebaruvanString, kolona;
            if ((matBroj.Text != "") || (zdrLegitimacija.Text != ""))
            {
                if (matBroj.Text != "")
                {
                    kolona = "id_pacienti";
                    prebaruvanString = matBroj.Text;
                }
                else
                {
                    kolona = "zdr_legitimacija";
                    prebaruvanString = zdrLegitimacija.Text;
                }
                DBConnect connection = new DBConnect();
                connection.openConnection();
                string upit = "SELECT * FROM proba_apteka.pacienti WHERE " + kolona + " = '" + prebaruvanString + "'";
                id = connection.Search(upit);
                if (id != 0)
                {
                    upit = "SELECT id_recept AS РеденБрој, id_pacient AS ЕМБГ, ime_p AS Име, prezime_p AS Презиме, zdr_legitimacija AS ЗдравственаЛегитимација, lek AS Лек, doza AS Доза, datum_od AS ДатумОд, datum_do AS ДатумДо, vremetraenje AS Времетраење FROM pacienti, recept WHERE pacienti.id_pacienti = recept.id_pacient AND pacienti.id_pacienti = '" + id + "'";
                    object dt = connection.select(upit);
                    dataGridView1.DataSource = dt;
                }
                else MessageBox.Show("Нема пациент со таков податок!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string upit = "";

            DBConnect connection = new DBConnect();
            connection.openConnection();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id_recept = Convert.ToInt32(row.Cells[0].Value);
                DateTime datum_do = Convert.ToDateTime(row.Cells[7].Value);
                DateTime vremetranje = Convert.ToDateTime(row.Cells[9].Value);
                int result = DateTime.Compare(datum_do, vremetranje);
                if (result > 0 || result == 0)
                {
                    upit = "DELETE FROM recept WHERE id_pacient = '" + id + "' AND id_recept = '" + id_recept + "'";
                    connection.Delete(upit);
                    connection.closeConnection();
                    MessageBox.Show("Завршена терапија!");
                }
                else
                {
                    upit = "UPDATE recept SET datum_od = DATE_ADD(datum_od, INTERVAL 1 MONTH), datum_do = DATE_ADD(datum_do, INTERVAL 1 MONTH)  WHERE id_pacient = '" + id + "'AND id_recept = '" + id_recept + "'";
                    //Text = upit;
                    connection.openConnection();
                    connection.Update(upit);
                    connection.closeConnection();
                    MessageBox.Show("Издаден лек!");
                }
                upit = "SELECT id_recept AS РеденБрој, id_pacient AS ЕМБГ, ime_p AS Име, prezime_p AS Презиме, zdr_legitimacija AS ЗдравственаЛегитимација, lek AS Лек, doza AS Доза, datum_od AS ДатумОд, datum_do AS ДатумДо, vremetraenje AS Времетраење FROM pacienti, recept WHERE pacienti.id_pacienti = recept.id_pacient AND pacienti.id_pacienti = '" + id + "'";
                object dt = connection.select(upit);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
