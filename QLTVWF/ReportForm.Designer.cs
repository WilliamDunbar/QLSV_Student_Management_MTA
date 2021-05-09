
namespace QLTVWF
{
     partial class ReportForm
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
               this.components = new System.ComponentModel.Container();
               Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
               this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
               this.QL_SinhVienDataSet = new QLTVWF.QL_SinhVienDataSet();
               this.DiemSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.DiemSinhVienTableAdapter = new QLTVWF.QL_SinhVienDataSetTableAdapters.DiemSinhVienTableAdapter();
               ((System.ComponentModel.ISupportInitialize)(this.QL_SinhVienDataSet)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.DiemSinhVienBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // reportViewer1
               // 
               this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
               reportDataSource2.Name = "DataSet";
               reportDataSource2.Value = this.DiemSinhVienBindingSource;
               this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
               this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTVWF.Report.rdlc";
               this.reportViewer1.Location = new System.Drawing.Point(0, 0);
               this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.reportViewer1.Name = "reportViewer1";
               this.reportViewer1.ServerReport.BearerToken = null;
               this.reportViewer1.Size = new System.Drawing.Size(1800, 878);
               this.reportViewer1.TabIndex = 1;
               // 
               // QL_SinhVienDataSet
               // 
               this.QL_SinhVienDataSet.DataSetName = "QL_SinhVienDataSet";
               this.QL_SinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // DiemSinhVienBindingSource
               // 
               this.DiemSinhVienBindingSource.DataMember = "DiemSinhVien";
               this.DiemSinhVienBindingSource.DataSource = this.QL_SinhVienDataSet;
               // 
               // DiemSinhVienTableAdapter
               // 
               this.DiemSinhVienTableAdapter.ClearBeforeFill = true;
               // 
               // ReportForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1800, 878);
               this.Controls.Add(this.reportViewer1);
               this.Name = "ReportForm";
               this.Text = "Report";
               this.Load += new System.EventHandler(this.ReportForm_Load);
               ((System.ComponentModel.ISupportInitialize)(this.QL_SinhVienDataSet)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.DiemSinhVienBindingSource)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
          private System.Windows.Forms.BindingSource DiemSinhVienBindingSource;
          private QL_SinhVienDataSet QL_SinhVienDataSet;
          private QL_SinhVienDataSetTableAdapters.DiemSinhVienTableAdapter DiemSinhVienTableAdapter;
     }
}