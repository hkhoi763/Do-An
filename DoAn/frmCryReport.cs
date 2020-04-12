//
// frmCryReport
//	
// Form dành cho repor
// 
// Tác giả: Nguyên Khôi
//

using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DoAn.DAO;
using DoAn.BUS;

namespace DoAn
{
    public partial class frmCryReport : Form
    {
        readonly DataProvider provider;
        public int _maHDB;
        public string _tenKH;
        public string _tenNV;
        public DateTime _ngLap;
        public string _tongTien;

        public frmCryReport()
        {
            InitializeComponent();
            provider = new DataProvider();
        }

        //
        // Phương thức event form load
        //
        private void FCryReport_Load(object sender, EventArgs e)
        {
            ReportDocument objrep = new CrystalReport1();
            provider.Connect();

            List<ChiTietHDBan> list = new ChiTietHDBanBUS().LoadHD();
            objrep.SetDataSource(list);
            rv.ReportSource = objrep;
            rv.Refresh();

            ParameterDiscreteValue pdv1 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdv2 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdv3 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdv4 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdv5 = new ParameterDiscreteValue();
            pdv1.Value = _maHDB;
            pdv2.Value = _tenKH;
            pdv3.Value = _tenNV;
            pdv4.Value = _ngLap;
            pdv5.Value = _tongTien;

            ParameterValues pv1 = new ParameterValues();
            ParameterValues pv2 = new ParameterValues();
            ParameterValues pv3 = new ParameterValues();
            ParameterValues pv4 = new ParameterValues();
            ParameterValues pv5 = new ParameterValues();
            pv1.Add(pdv1);
            pv2.Add(pdv2);
            pv3.Add(pdv3);
            pv4.Add(pdv4);
            pv5.Add(pdv5);

            objrep.DataDefinition.ParameterFields["MaHD"].ApplyCurrentValues(pv1);
            objrep.DataDefinition.ParameterFields["TenKH"].ApplyCurrentValues(pv2);
            objrep.DataDefinition.ParameterFields["TenNV"].ApplyCurrentValues(pv3);
            objrep.DataDefinition.ParameterFields["NgLap"].ApplyCurrentValues(pv4);
            objrep.DataDefinition.ParameterFields["TT"].ApplyCurrentValues(pv5);

            provider.Disconnect();

            try
            {
                objrep.ExportToDisk(ExportFormatType.PortableDocFormat, "D:\\Report.pdf");
            }
            catch
            {
                MessageBox.Show("In hoá đơn không thành công");
            }
        }
    }
}
