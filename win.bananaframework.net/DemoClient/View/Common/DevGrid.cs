using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.Export;

namespace DemoClient.Controllers
{
    public partial class DevGrid : Control
    {
        public DevGrid()
        {
            InitializeComponent();
            //붙여넣기
            PasteMode.Update.ToString();
            /* 위치 Run Dginer -> OptionClipBoard
             * AllowCopy = True, ClipboardMode = Formatted, AllowTxtFormat = True,
             *  AllowRtfFormat = True, AllowHtmlFormat = True, AllowExcelFormat = True,
             *   AllowCsvFormat = True, CopyCollapsedData = True, PasteMode = Update
             */
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
