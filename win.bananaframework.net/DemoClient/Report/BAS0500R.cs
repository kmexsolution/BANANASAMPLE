using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DemoClient.Report
{
    public partial class BAS0500R : DevExpress.XtraReports.UI.XtraReport
    {
        public BAS0500R(DataTable dt)
        {
            InitializeComponent();
            this.DataSource = dt;
            this.maincode.DataBindings.Add("Text", dt, "MAIN_CODE");
            this.codename.DataBindings.Add("Text", dt, "CODE_NAME");
            this.systemyn.DataBindings.Add("Text", dt, "SYSTEMYN");
            this.xrBarCode1.DataBindings.Add("Text", dt, "MAIN_CODE");
            this.systemyn.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge;
            this.systemyn.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Value;
        }

    }
}
