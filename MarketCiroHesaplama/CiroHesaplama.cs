using ClosedXML.Excel;
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

namespace MarketCiroHesaplama
{
    public partial class CiroRaporlama : Form
    {
        string sqlCiro = @"Select 
        [Sube Kodu] = t1.sube_kodu
        ,[Sube Adı] =  t2.sube_adi
        ,[Sube Ciro] = t1.ciro
        ,[Tarih] = Convert(datetime, t1.tarih, 101)

        from tbl_Ciro t1

        INNER JOIN tbl_Sube t2

        ON t1.sube_kodu = t2.id";
        string conString = "server =.; database=OZPAS;integrated security = true";
        SqlConnection con = new SqlConnection("server =.;database=OZPAS;integrated security=true");
        SqlCommand cmd;
        public CiroRaporlama()
        {
            InitializeComponent();
            comboboxDoldur();
            subeAdi.SelectedIndex = 0;
            idBul();
            dgCiro.DataSource = GetDataTable(conString, sqlCiro);
            gridDuzenle(dgCiro);
        }

        public void comboboxDoldur()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Sube";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                subeAdi.Items.Add(dr["sube_adi"]);
            }
            con.Close();
        }

        public int idBul()
        {
            string sql = "select id from tbl_Sube WHERE sube_adi = '" + subeAdi.SelectedItem.ToString() + "'";


            int id = int.Parse(GetDataTable(conString, sql).Rows[0][0].ToString());
            return id;
        }


        public DataTable GetDataTable(string ConnectionString, string SQL)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public void textboxKontrol()
        {
            if (dgCiro.CurrentRow.Cells[1].Value.ToString() == null)
            {
                subeAdi.SelectedItem = "";
            }
            else
            {
                subeAdi.SelectedItem = dgCiro.CurrentRow.Cells[1].Value.ToString();
            }

            if (dgCiro.CurrentRow.Cells[2].Value.ToString() == null)
            {
                ciroText.Text = "";
            }
            else
            {
                ciroText.Text = dgCiro.CurrentRow.Cells[2].Value.ToString();
            }

        }

        private void subeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            idBul();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {

            string sql = @"INSERT INTO tbl_Ciro
                        (sube_kodu,ciro,tarih)
                        VALUES
                        (" + idBul() + ",CAST(" + ciroText.Text.Replace(',', '.') + " AS float),Convert(nvarchar,'" + DateTime.Now.ToString() + "',101))";

            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            ciroText.Text = "";
            subeAdi.SelectedIndex = 0;

            MessageBox.Show("Ciro Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgCiro.DataSource = GetDataTable(conString, sqlCiro);

        }

        public void gridDuzenle(DataGridView dg)
        {
            dg.RowHeadersVisible = false;  // DataGrid başlangıçtaki boşluğu silme
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // DataGrid genişliğine göre sütun genişliklerini ayarlama.
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // DataGrid tıklandığında full row seçili hale getir.
            dg.AllowUserToAddRows = false; //Datagrid'deki en alttaki satırı gizle.
        }

        private void dgCiro_SelectionChanged(object sender, EventArgs e)
        {
            textboxKontrol();
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dgCiro.CurrentRow.Cells[3].Value.ToString().Substring(0, 10));


            string sql = @"UPDATE tbl_Ciro
            SET ciro = CAST(" + ciroText.Text.Replace(',', '.') + " AS float)" +
            "WHERE sube_kodu IN (select id from tbl_Sube WHERE sube_adi = '" + subeAdi.SelectedItem.ToString() + "')" +
            "AND tarih = '" + dt.ToString("yyyy/MM/dd") + "'";

            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            ciroText.Text = "";
            subeAdi.SelectedIndex = 0;

            MessageBox.Show("Ciro Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgCiro.DataSource = GetDataTable(conString, sqlCiro);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dgCiro.CurrentRow.Cells[3].Value.ToString().Substring(0, 10));
            string sql = @"DELETE FROM tbl_Ciro 
            WHERE sube_kodu IN(select id from tbl_Sube WHERE sube_adi = '" + subeAdi.SelectedItem.ToString() + "')" +
            "AND tarih = '" + dt.ToString("yyyy/MM/dd") + "'";

            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            ciroText.Text = "";
            subeAdi.SelectedIndex = 0;

            MessageBox.Show("Ciro Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgCiro.DataSource = GetDataTable(conString, sqlCiro);
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Excel 2007|*.xlsx";
            sv.Title = "Excel Kaydet";
            sv.ShowDialog();
            if (sv.FileName != "")
            {
                string fileName = sv.FileName;

                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Ciro Rapor");
                    ws.Row(1).Cell(1).InsertTable(GetDataTable(conString, sqlCiro));
                    wb.SaveAs(sv.FileName);
                    wb.Dispose();
                    MessageBox.Show("Excel Başarıyla Oluşturuldu\n\n" + sv.FileName, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
