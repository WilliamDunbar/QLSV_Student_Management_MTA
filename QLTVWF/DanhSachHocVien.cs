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
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;

namespace QLTVWF
{
     public partial class DanhSachHocVien : Form
     {

          SqlConnection connection;
          SqlCommand command;
          SqlDataAdapter adapter;
          System.Data.DataTable dataSV = new System.Data.DataTable();
          System.Data.DataTable dataSV1 = new System.Data.DataTable();
          System.Data.DataTable dataDiem = new System.Data.DataTable();

          public static string lop;
          public static string khoa;
          public static bool status;


          public DanhSachHocVien()
          {
               InitializeComponent();
          }

          void LoadDSSV(string lop, string khoa)
          {
               command = connection.CreateCommand();
               command.CommandText = command.CommandText = $"select *from SinhVien  where Class='{lop}' and Khoa='{khoa}'";
               adapter = new SqlDataAdapter(command);
               dataSV.Clear();
               adapter.Fill(dataSV);
               DSHVdatagridview.DataSource = dataSV;

               hotenTxtBox.Enabled = false;
               idhocvienTxtBox.Enabled = false;
               lopCombobox.Enabled = false;
               diachiTxtBox.Enabled = false;
               ngaysinhDateTimePicker2.Enabled = false;
          }

          void LoadDanhSachSV_TimKiem(string lop, String Khoa, string timKiem)
          {
               command = connection.CreateCommand();
               command.CommandText = $"select *from SinhVien where Class='{lop}' and Khoa='{Khoa}' and (Id like '%'+'{timKiem}'+'%' or Name like '%'+'{timKiem}'+'%' ) ";
               adapter = new SqlDataAdapter(command);
               dataSV.Clear();
               adapter.Fill(dataSV);
               DSHVdatagridview.DataSource = dataSV;
          }

          private void DanhSachHocVien_Load(object sender, EventArgs e)
          {
               
               Model data = new Model();
               connection = data.getConnect();
               connection.Open();
               lop = DSLop1ComboBox.Text;
          }

          private void KhoaTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
          {
               if (e.Node.Name == "K52" || e.Node.Name == "K53" || e.Node.Name == "K54" || e.Node.Name == "K55")
               {
                    khoa = e.Node.Name;
                    LoadDSSV(DSLop1ComboBox.Text, khoa);
               }
          }

          private void DSLop1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
          {
               ComboBox cb = sender as ComboBox;
               hotenTxtBox.Enabled = false;
               idhocvienTxtBox.Enabled = false;
               lopCombobox.Enabled = false;
               diachiTxtBox.Enabled = false;
               ngaysinhDateTimePicker2.Enabled = false;
               lop = cb.Text;
               LoadDSSV(cb.Text, khoa);
          }

          private void DSHVdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int i = e.RowIndex;

               ThemButton1.Enabled = true;
               SuaButton1.Enabled = true;
               XoaButton1.Enabled = true;
               LuuButton1.Enabled = false;
               InButton1.Enabled = true;
               hotenTxtBox.Enabled = false;
               idhocvienTxtBox.Enabled = false;
               lopCombobox.Enabled = false;
               diachiTxtBox.Enabled = false;
               ngaysinhDateTimePicker2.Enabled = false;
               //Binding dữ liệu
               hotenTxtBox.Text = DSHVdatagridview.Rows[i].Cells[1].Value.ToString();
               idhocvienTxtBox.Text = DSHVdatagridview.Rows[i].Cells[0].Value.ToString();
               lopCombobox.Text = DSHVdatagridview.Rows[i].Cells[2].Value.ToString();
               diachiTxtBox.Text = DSHVdatagridview.Rows[i].Cells[4].Value.ToString();
               ngaysinhDateTimePicker2.Text =(DSHVdatagridview.Rows[i].Cells[3].Value.ToString());
          }

          private void ThemButton1_Click(object sender, EventArgs e)
          {
               status = true;
               hotenTxtBox.Text = "";
               idhocvienTxtBox.Text = "";
               diachiTxtBox.Text = "";
               lopCombobox.Text = "";
               ngaysinhDateTimePicker2.Text = "";
               //Enable field
               ThemButton1.Enabled = false;
               SuaButton1.Enabled = false;
               XoaButton1.Enabled = false;
               LuuButton1.Enabled = true;
               InButton1.Enabled = false;
               cancelButton.Enabled = true;
               hotenTxtBox.Enabled = true;
               idhocvienTxtBox.Enabled = true;
               lopCombobox.Enabled = true;
               diachiTxtBox.Enabled = true;
               ngaysinhDateTimePicker2.Enabled = true;

          }

          private void SuaButton1_Click(object sender, EventArgs e)
          {
               ThemButton1.Enabled = true;
               SuaButton1.Enabled = true;
               XoaButton1.Enabled = true;
               LuuButton1.Enabled = true;
               InButton1.Enabled = true;
               cancelButton.Enabled = true;
               hotenTxtBox.Enabled = true;
               idhocvienTxtBox.Enabled = true;
               lopCombobox.Enabled = true;
               diachiTxtBox.Enabled = true;
               ngaysinhDateTimePicker2.Enabled = true;
          }

          private void XoaButton1_Click(object sender, EventArgs e)
          {
               command = connection.CreateCommand();
               command.CommandText = $"delete DiemThanhPhan where IdSV='{idhocvienTxtBox.Text}'";
               command.ExecuteNonQuery();
               command = connection.CreateCommand();
               command.CommandText = $"delete SinhVien where id='{idhocvienTxtBox.Text}'";
               command.ExecuteNonQuery();
               LoadDSSV(DSLop1ComboBox.Text, khoa);
               MessageBox.Show("Xóa thành công");
          }

          private void LuuButton1_Click(object sender, EventArgs e)
          {
               ThemButton1.Enabled = true;
               SuaButton1.Enabled = true;
               XoaButton1.Enabled = true;
               LuuButton1.Enabled = true;
               InButton1.Enabled = true;
               cancelButton.Enabled = true;
               hotenTxtBox.Enabled = false;
               idhocvienTxtBox.Enabled = false;
               lopCombobox.Enabled = false;
               diachiTxtBox.Enabled = false;
               ngaysinhDateTimePicker2.Enabled = false;
               if(status == true)
               {
                    try
                    {
                         command.CommandText = $"insert into SinhVien values" +
                              $"('{idhocvienTxtBox.Text}','{hotenTxtBox.Text}','{lopCombobox.Text}','{ngaysinhDateTimePicker2.Text}','{diachiTxtBox.Text}','{khoa}') ";
                         command.ExecuteNonQuery();
                         command = connection.CreateCommand();
                         command.CommandText = $"insert into DiemThanhPhan(IdSV) values('{idhocvienTxtBox.Text}') ";
                         command.ExecuteNonQuery();
                         MessageBox.Show("Thêm thành công sinh viên");
                    }
                    catch
               {
                    MessageBox.Show("Sinh viên đã tồn tại !");
                    hotenTxtBox.Enabled = true;
                    idhocvienTxtBox.Enabled = true;
                    lopCombobox.Enabled = true;
                    diachiTxtBox.Enabled = true;
                    ngaysinhDateTimePicker2.Enabled = true;
               }
          }
               else
               {
                    command = connection.CreateCommand();
                    command.CommandText = $"update SinhVien set Name=" +
                         $"'{hotenTxtBox.Text}',Class='{lopCombobox.Text}',DateOfBirth='{ngaysinhDateTimePicker2.Text}',Address='{diachiTxtBox.Text}' where id='{idhocvienTxtBox.Text}'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sua thanh cong");
               }
               LoadDSSV(DSLop1ComboBox.Text, khoa);
          }

          private void InButton1_Click(object sender, EventArgs e)
          {
               ReportForm rp = new ReportForm();
               rp.ShowDialog();
          }

          private void hotenTxtBox_Validating(object sender, CancelEventArgs e)
          {
               Regex invalidCharsRegex = new Regex(@"^[a-zA-Z\s ]*$");
               string text = hotenTxtBox.Text;
               bool result = invalidCharsRegex.IsMatch(text);
               if (result == false)
               {
                    e.Cancel = true;
                    hotenTxtBox.Focus();
                    errorProvider2.SetError(hotenTxtBox, "Chỉ gồm chữ và khoảng trắng");
               }
               else
               {
                    errorProvider2.Clear();
               }
               
          }

          private void diachiTxtBox_Validating(object sender, CancelEventArgs e)
          {
               Regex invalidCharsRegex = new Regex(@"^[a-zA-Z\s ]*$");
               string text = diachiTxtBox.Text;
               bool result = invalidCharsRegex.IsMatch(text);
               if (result == false)
               {
                    e.Cancel = true;
                    diachiTxtBox.Focus();
                    errorProvider2.SetError(diachiTxtBox, "Chỉ gồm chữ và khoảng trắng");
               }
               else
               {
                    errorProvider2.Clear();
               }
          }

          private void idhocvienTxtBox_Validating(object sender, CancelEventArgs e)
          {
               Regex invalidCharsRegex = new Regex(@"^[a-zA-Z0-9\s ]*$");
               string text = idhocvienTxtBox.Text;
               bool result = invalidCharsRegex.IsMatch(text);
               if (result == false)
               {
                    e.Cancel = true;
                    idhocvienTxtBox.Focus();
                    errorProvider2.SetError(idhocvienTxtBox, "Chỉ gồm chữ, số và khoảng trắng");
               }
               else
               {
                    errorProvider2.Clear();
               }
          }

          private void cancelButton_Click(object sender, EventArgs e)
          {
               LoadDSSV(lop, khoa);
          }
     }
}
