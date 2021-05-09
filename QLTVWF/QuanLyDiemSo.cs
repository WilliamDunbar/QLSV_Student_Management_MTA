using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVWF
{
     public partial class QuanLyDiemSo : Form
     {
          public QuanLyDiemSo()
          {
               InitializeComponent();
          }

          SqlConnection connection;
          SqlCommand command;
          SqlDataAdapter adapter;
          System.Data.DataTable dataDiem = new System.Data.DataTable();

          public static string lop;
          public static string khoa;
          public static bool status;



          void LoadDSDiem(string lop, string khoa)
          {
               command = connection.CreateCommand();
               command.CommandText = 
                    $"select id,Name,ChuyenCan,GiuaKi,CuoiKi from SinhVien left join DiemThanhPhan on id=IdSV where Class='{lop}' and khoa='{khoa}'";
               adapter = new SqlDataAdapter(command);
               dataDiem.Clear();
               adapter.Fill(dataDiem);
               DSDSdatagridview.DataSource = dataDiem;

               chuyencanTxtBox.Enabled = false;
               thuongxuyentxb.Enabled = false;
               cuoikyTxtBox.Enabled = false;
          }

          private void QuanLyDiemSo_Load(object sender, EventArgs e)
          {
                    Model data = new Model();
                    connection = data.getConnect();
                    connection.Open();
                    lop = DSlop2ComboBox.Text;
          }

          private void KhoaTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
          {
               if (e.Node.Name == "K52" || e.Node.Name == "K53" || e.Node.Name == "K54" || e.Node.Name == "K55")
               {
                    khoa = e.Node.Name;
                    LoadDSDiem(DSlop2ComboBox.Text, khoa);
               }
          }

          private void DSDSdatagridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               int i = e.RowIndex;
               suadiemButton.Enabled = true;
               luudiemButton.Enabled = false;
               chuyencanTxtBox.Enabled = false;
               thuongxuyentxb.Enabled = false;
               cuoikyTxtBox.Enabled = false;
               tongkettxtBox.Enabled = false;
               chuyencanTxtBox.Text = DSDSdatagridview.Rows[i].Cells[2].Value.ToString();
               thuongxuyentxb.Text = DSDSdatagridview.Rows[i].Cells[3].Value.ToString();
               cuoikyTxtBox.Text = DSDSdatagridview.Rows[i].Cells[4].Value.ToString();
               tongkettxtBox.Text = ((float.Parse(chuyencanTxtBox.Text) + (float.Parse(thuongxuyentxb.Text) * 3) + (float.Parse(cuoikyTxtBox.Text) * 6))/10).ToString() ;
          }

          private void DSlop2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
          {
               ComboBox cb = sender as ComboBox;
               chuyencanTxtBox.Enabled = false;
               thuongxuyentxb.Enabled = false;
               cuoikyTxtBox.Enabled = false;
               LoadDSDiem(cb.Text, khoa);
          }

          private void suadiemButton_Click(object sender, EventArgs e)
          {
               suadiemButton.Enabled = false;
               luudiemButton.Enabled = true;
               chuyencanTxtBox.Enabled = true;
               thuongxuyentxb.Enabled = true;
               cuoikyTxtBox.Enabled = true;
               tongkettxtBox.Enabled = false;
          }

          private void luudiemButton_Click(object sender, EventArgs e)
          {
               int i = DSDSdatagridview.CurrentRow.Index;
               chuyencanTxtBox.Enabled = false;
               thuongxuyentxb.Enabled = false;
               cuoikyTxtBox.Enabled = false;
               suadiemButton.Enabled = true;
               luudiemButton.Enabled = false;
               command = connection.CreateCommand();
               command.CommandText = $"update DiemThanhPhan set ChuyenCan={float.Parse(chuyencanTxtBox.Text)}, GiuaKi={float.Parse(thuongxuyentxb.Text)}, CuoiKi={float.Parse(cuoikyTxtBox.Text)} where IdSV='{DSDSdatagridview.Rows[i].Cells[0].Value.ToString()}' ";
               command.ExecuteNonQuery();
               LoadDSDiem(DSlop2ComboBox.Text, khoa);
               MessageBox.Show("Sửa điểm thành công");
          }

          private void thuongxuyentxb_Validating(object sender, CancelEventArgs e)
          {
               Regex invalidCharsRegex = new Regex(@"^[0-9.-]+$");
               string text = thuongxuyentxb.Text;
               bool result = invalidCharsRegex.IsMatch(text);
               float diem;
               float.TryParse(text, out diem);

               if (result == false || diem <= 0 || diem >= 10)
               {
                    e.Cancel = true;
                    chuyencanTxtBox.Focus();
                    errorProvider1.SetError(thuongxuyentxb, "Mời nhập lại");
               }
               else
               {

                    errorProvider1.Clear();

               }
          }

          private void chuyencanTxtBox_Validating(object sender, CancelEventArgs e)
          {
               Regex invalidCharsRegex = new Regex(@"^[0-9.-]+$");
               string text = chuyencanTxtBox.Text;
               bool result = invalidCharsRegex.IsMatch(text);
            float diem;
            float.TryParse(text, out diem);
            if (result == false || diem <= 0 || diem >= 10)
               {
                    e.Cancel = true;
                    chuyencanTxtBox.Focus();
                    errorProvider1.SetError(chuyencanTxtBox, "Mời bạn nhập lại");
               }
               else
               {

                    errorProvider1.Clear();

               }
          }

          private void cuoikyTxtBox_Validating(object sender, CancelEventArgs e)
          {
               Regex invalidCharsRegex = new Regex(@"^[0-9.-]+$");
               string text = cuoikyTxtBox.Text;
               bool result = invalidCharsRegex.IsMatch(text);
            float diem;
            float.TryParse(text, out diem);
            if (result == false || diem <= 0 || diem >= 10)
            {
                    e.Cancel = true;
                    chuyencanTxtBox.Focus();
                    errorProvider1.SetError(cuoikyTxtBox, "Mời bạn nhập lại");
               }
               else
               {

                    errorProvider1.Clear();

               }
          }

     }
}
