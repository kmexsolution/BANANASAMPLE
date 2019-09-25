using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DemoClient.View.Common
{
    public partial class mngPOPSQL : DemoClient.Controllers.BaseForm
    {
        public mngPOPSQL()
        {
            InitializeComponent();
        }

        private void mngPOPSQL_Load(object sender, EventArgs e)
        {
            String sql_text = "";
            sql_text += "SELECT pop_cd, pop_sql FROM POPSQL             ";            
            sql_text += " WHERE pop_cd like '%" + s_txtPOPCD.Text + "%'";
            sql_text += "   AND pop_sql like '%" + s_txtPOPSQL.Text + "%'";
            DataTable _dt = base.GetDataTable(sql_text);
            g10.DataSource = _dt;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_CD.Text = gridView1.GetFocusedRowCellValue("pop_cd").ToString();
            txt_SQL.Text = gridView1.GetFocusedRowCellValue("pop_sql").ToString();
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            String sql_text = "";
            sql_text += "SELECT pop_cd, pop_sql FROM POPSQL             ";
            sql_text += " WHERE pop_cd like '%" + s_txtPOPCD.Text + "%'";
            sql_text += "   AND pop_sql like '%" + s_txtPOPSQL.Text + "%'";
            DataTable _dt = base.GetDataTable(sql_text);
            g10.DataSource = _dt;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (txt_CD.Text == "")
            {
                MessageBox.Show("PopUp 코드를 입력하십시오.");
                txt_CD.Focus();
                return;
            }
            if (txt_SQL.Text == "")
            {
                MessageBox.Show("PopUp 쿼리를 입력하십시오.");
                txt_SQL.Focus();
                return;
            }

            String sql_text = "";
            sql_text += "SELECT 0 FROM POPSQL             ";
            sql_text += " WHERE pop_cd  = '" + txt_CD.Text + "'";
            DataSet dSet = base.GetDataSet(sql_text);
            if (dSet.Tables[0].Rows.Count == 0)
            {
                sql_text = "";
                sql_text += "INSERT INTO POPSQL              ";
                sql_text += "VALUES ( @pop_cd, @pop_sql)     ";
                sql_text = sql_text.Replace("@pop_cd", "'" + txt_CD.Text + "'");
                sql_text = sql_text.Replace("@pop_sql", "'" + txt_SQL.Text + "'");
                base.ExecuteNonQuery(sql_text);

            }
            else
            {
                sql_text = "";
                sql_text += "UPDATE POPSQL               ";
                sql_text += "   SET pop_sql = @pop_sql   ";
                sql_text += " WHERE pop_cd = @pop_cd     ";
                sql_text = sql_text.Replace("@pop_cd", "'" + txt_CD.Text + "'");
                sql_text = sql_text.Replace("@pop_sql", "'" + txt_SQL.Text + "'");
                base.ExecuteNonQuery(sql_text);

            }      
                

        }

        private void txt_CD_TextChanged(object sender, EventArgs e)
        {
            txt_SQL.Clear();
        }
    }
}
