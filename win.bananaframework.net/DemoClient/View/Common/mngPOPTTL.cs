using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.Common
{
    public partial class mngPOPTTL : DemoClient.Controllers.BaseForm
    {
        public mngPOPTTL()
        {
            InitializeComponent();
        }

        private void mngPOPTTL_Load(object sender, EventArgs e)
        {
            select_sql();
        }

        void select_sql()
        {
            String sql_text = "";
            sql_text += "SELECT pop_cd, count(seq) ttl_cnt             ";
            sql_text += " WHERE pop_cd like '%" + s_txtPOPCD.Text + "%'";
            sql_text += " GROUP BY pop_cd";
            DataTable _dt = base.GetDataTable(sql_text);
            g10.DataSource = _dt;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            String sql_text = "";
            sql_text += "SELECT seq, text FROM POPTTL       ";
            sql_text += " WHERE pop_cd = '" + gridView1.GetFocusedRowCellValue("pop_cd").ToString() + "'";
            sql_text += " ORDER BY seq                      ";
            DataTable _dt = base.GetDataTable(sql_text);
            g20.DataSource = _dt;
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            select_sql();
            g20.DataSource = null;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount - 1; i++)
            {
                if (gridView1.GetRowCellDisplayText(i, "seq").ToString() != "" || gridView1.GetRowCellDisplayText(i, "text").ToString() != "")
                {
                    if (gridView1.GetRowCellDisplayText(i, "seq").ToString() == "")
                    {
                        MessageBox.Show("순번을 입력하십시오.");
                        return;
                    }

                    if (gridView1.GetRowCellDisplayText(i, "text").ToString() == "")
                    {
                        MessageBox.Show("타이틀을 입력하십시오.");
                        return;
                    }
                }

            }
            
            try
            {
                base.BeginTransaction();
                String pop_code = gridView1.GetFocusedRowCellValue("pop_cd").ToString();
                DataTable dt = g20.DataSource as DataTable;
                String sql_text = "";
                String seq_no = "";
                String text = "";
                String seq_old = "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dRow = dt.Rows[i];

                    if (dt.Rows[i].RowState.ToString() == "Deleted")
                    {
                        seq_old = dRow["seq_old", DataRowVersion.Original].ToString();

                        sql_text += "DELETE FROM POPTTL                         \n";
                        sql_text += " WHERE pop_cd = '" + pop_code + "'         \n";
                        sql_text += "   AND seq = " + seq_old + "               \n";

                        if (seq_old != "")
                        {
                            base.ExecuteNonQuery(sql_text);
                        }
                    }
                    else if (dt.Rows[i].RowState.ToString() != "Unchanged")
                    {
                        text = dRow["text"].ToString();
                        seq_no = dRow["seq"].ToString();
                        if (dt.Rows[i].RowState.ToString() == "Added")
                        {                            
                            sql_text += "INSERT INTO POPTTL                             \r\n";                        
                            sql_text += " VALUES( @pop_cd, @seq, @text )                \r\n";
                            sql_text = sql_text.Replace("@pop_cd", pop_code);
                            sql_text = sql_text.Replace("@seq", seq_no);
                            sql_text = sql_text.Replace("@text", text);                            
                        }
                        if (dt.Rows[i].RowState.ToString() == "Modified")
                        {
                            seq_old = dRow["seq_old"].ToString();
                            sql_text += "UPDATE POPTTL                  \r\n";
                            sql_text += "   SET seq = @seq              \r\n";
                            sql_text += "     , text = @text            \r\n";
                            sql_text += " WHERE pop_cd = @pop_cd        \r\n";
                            sql_text += "   AND seq = @seq_old          \r\n";
                            sql_text = sql_text.Replace("@pop_cd", pop_code);
                            sql_text = sql_text.Replace("@seq", seq_no);
                            sql_text = sql_text.Replace("@text", text);
                            sql_text = sql_text.Replace("@seq_old", seq_old);

                        }
                        base.ExecuteNonQuery(sql_text);
                    }
                }

                base.CommitTransaction();

                MessageBox.Show("저장 하였습니다.");
                select_sql();

            }
            catch (Exception err)
            {
                base.RollbackTransaction();
                MessageBox.Show(err.Message);
            }
            


        }
    }
}
