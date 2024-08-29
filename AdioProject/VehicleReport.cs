using AdioProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdioProject
{
    public partial class VehicleReport : Form
    {
        List<VehicleViewModels> _list;
        public VehicleReport(List<VehicleViewModels>list)
        {
            InitializeComponent();
            _list=list;
        }

        private void VehicleReport_Load(object sender, EventArgs e)
        {
            RptVehicleInfo rpt = new RptVehicleInfo();
            rpt.SetDataSource(_list);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }
    }
}
