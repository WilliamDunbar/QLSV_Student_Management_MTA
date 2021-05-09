using Microsoft.Reporting.WinForms;
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

namespace QLTVWF
{
     public partial class ReportForm : Form
     {

          SqlConnection connection;
          SqlCommand command;
          SqlDataAdapter adapter;

          public ReportForm()
          {
               InitializeComponent();
          }

          void LoadDiemSinhVien(string lop, string khoa)
          {
               command = connection.CreateCommand();
               command.CommandText = $"select *from DiemSinhVien where Class='{lop}' and Khoa='{khoa}'";
               adapter = new SqlDataAdapter(command);
               DataTable dt = new DataTable();
               adapter.Fill(dt);
               ReportDataSource rds = new ReportDataSource("DataSet", dt);
               reportViewer1.LocalReport.ReportPath = @"D:\NNLT2\QLTVWF\QLTVWF\Report.rdlc";
               reportViewer1.LocalReport.DataSources.Clear();
               reportViewer1.LocalReport.DataSources.Add(rds);
               this.reportViewer1.RefreshReport();
          }

          private void ReportForm_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'QL_SinhVienDataSet.DiemSinhVien' table. You can move, or remove it, as needed.
               this.DiemSinhVienTableAdapter.Fill(this.QL_SinhVienDataSet.DiemSinhVien);
               Model data = new Model();
               connection = data.getConnect();
               connection.Open();
               LoadDiemSinhVien(DanhSachHocVien.lop, DanhSachHocVien.khoa);
          }
     }
}
