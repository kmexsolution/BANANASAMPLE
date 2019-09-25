using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using DevExpress.Utils;
using DevExpress.Export;
namespace DemoClient.Controls
{
    public partial class NewGrid : UserControl
    {
        public NewGrid()
        {
            DevExpress.Data.Helpers.IsDesignModeHelper.BypassDesignModeAlterationDetection = true;
            
            InitializeComponent();
                        
            //멀티선택인지 아닌지 설정
            gridView1.OptionsSelection.MultiSelect = true;

            //여러 셀 또는 행을 선택할 수 있는지 여부를 지정하는 값을 제공합니다.
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

            
            GridOptionsClipboard optclip = gridView1.OptionsClipboard;
            //최종 사용자가 선택한 행과 셀을 클립 보드에 복사 할 수 있는지 여부를 가져 오거나 설정합니다.
            optclip.AllowCopy = DefaultBoolean.True;

            //서식 복사 기능을 사용
            
            optclip.ClipboardMode = ClipboardMode.Formatted;
            optclip.AllowTxtFormat = DefaultBoolean.True;
            optclip.AllowRtfFormat = DefaultBoolean.True;
            optclip.AllowHtmlFormat = DefaultBoolean.True;
            optclip.AllowExcelFormat = DefaultBoolean.True;
            optclip.AllowCsvFormat = DefaultBoolean.True;

            //서식이 지정된 데이터가 확장 된 행 / 노드와 축소 된 행 / 노드 모두에서 복사되는지 여부를 가져 오거나 설정합니다.
            optclip.CopyCollapsedData = DefaultBoolean.True;

            /*붙여 넣기를 사용
             * append: 데이터를 붙여 넣을 때 클립 보드 값이있는 새 행이 컨트롤에 추가됩니다.
             *         바운드 컨트롤의 경우 새 행이 데이터 소스에 추가되고 컨트롤이 업데이트됩니다.
             *         데이터 소스는 새 행 추가를 지원해야합니다.
             *         그렇지 않으면 붙여 넣기 작업이 실패합니다.
             * 
             * update: 붙여 넣은 데이터가 왼쪽 위 모서리가 현재 포커스가있는 셀인 사각형 셀 블록을 업데이트합니다.
             *         초점이 맞춰진 열의 왼쪽에있는 열의 셀은 업데이트되지 않습니다.
             */
            optclip.PasteMode = PasteMode.Update;
            
            //신규 추가 그리드 위치 지정 (bottom,none,top)
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            
            //그룹 패널 켜기/끄기 true/false
            gridView1.OptionsView.ShowGroupPanel = false;

            // UseEmbeddedNavigator의 속성 값이 true이면 그리드 하단 좌측에 데이터 네비게이터를 표시한다.
            gridView1.GridControl.UseEmbeddedNavigator = true;
            
            //그리드 가로길이가 화면밖으로 늘어날수 있게 해줌
            gridView1.OptionsView.ColumnAutoWidth = false;
           
            //컬럼헤더 가운데 정렬.
            foreach (DevExpress.XtraGrid.Columns.GridColumn gvc in gridView1.Columns)
            {
                gvc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            // The PopupMenuShowing event fires each time a context menu is about to be displayed.
            //  You can handle the event to manage the popup menu's items
            gridView1.PopupMenuShowing += (s, e) => {
                // Add a custom item to the column header menu
                if (e.Menu != null)
                {
                    EventHandler customItemClick = null;
                    DXMenuItem customItem = new DXMenuItem("CustomItem");
                    customItemClick = (sender, ea) => {
                        customItem.Click -= customItemClick;
                        //your code here
                        //int rowHandle = 
                        //gridView1.AddNewRow();

                    };
                    customItem.Click += customItemClick;
                    e.Menu.Items.Add(customItem);
                }
            };




        }
    }
}
