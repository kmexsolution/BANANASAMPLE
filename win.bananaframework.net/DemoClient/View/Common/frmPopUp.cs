using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.Common
{

    public partial class frmPopUp : DemoClient.Controllers.BasePopupForm
    {
        string _Sql = string.Empty;
        string _SqlText = string.Empty;
        string[] _params = new string[5];
        public DataRow dRow { get; set; }

        public frmPopUp(String _sql, String _searchText)
        {
            InitializeComponent();
            _Sql = _sql;
            _txtSearch.Text = _searchText;            
        }

        public frmPopUp(String _sql, String _searchText, params String[] Params)
        {
            InitializeComponent();
            _Sql = _sql;
            _txtSearch.Text = _searchText;
            _params = Params;            
        }

        void setSQL(String _sql)
        {
            _SqlText = "";
            if (_sql == "MDLMST")
            {
                _SqlText += "SELECT mdl_cd, mdl_nm, dev_dt, mass_dt, use_yn                 ";
                _SqlText += "  FROM MDLMST                                                  ";
                _SqlText += " WHERE mdl_cd like '%" + _txtSearch.Text + "%'                 ";
                _SqlText += "    OR mdl_nm like '%" + _txtSearch.Text + "%'                 ";
            }
            else if (_sql == "MOLMST")
            {
                _SqlText += "SELECT a.mol_no, a.mol_cd, a.mol_nm, a.mol_bano, a.mol_ba_yb       ";
                _SqlText += "     , b.loc_nm, c.cust_nm, a.mol_hori, a.mol_vert, a.mol_high     ";
                _SqlText += "     , a.mol_wht, a.mol_type, a.crt_dt, a.dst_dt                   ";
                _SqlText += "  FROM MOLMST a                                                  ";
                _SqlText += "  JOIN LOCMST b on a.loc_cd = b.loc_cd                           ";
                _SqlText += "  JOIN CSTMST c on a.cust_cd = c.cust_cd                         ";
                _SqlText += " WHERE a.mol_cd like '%" + _txtSearch.Text + "%'                 ";
                _SqlText += "    OR a.mol_no like '%" + _txtSearch.Text + "%'                 ";
                _SqlText += "    OR a.mol_nm like '%" + _txtSearch.Text + "%'                 ";
            }
            else if (_sql == "WHSMST")
            {
                _SqlText += "SELECT wh_cd, wh_nm, str_dt, end_dt FROM WHSMST        ";
                _SqlText += " WHERE wh_cd like '%" + _txtSearch.Text + "%'          ";
                _SqlText += "    OR wh_nm like '%" + _txtSearch.Text + "%'          ";
            }
            else if (_sql == "LOCMST")
            {
                _SqlText += "SELECT a.wh_cd , b.wh_nm                                    ";
                _SqlText += "     , a.loc_cd, a.loc_nm, a.str_dt                        ";
                _SqlText += "  FROM LOCMST a JOIN WHSMST b on a.wh_cd = b.wh_cd         ";
                _SqlText += " WHERE (a.loc_cd like '%" + _txtSearch.Text + "%'          ";
                _SqlText += "    OR a.loc_nm like '%" + _txtSearch.Text + "%')          ";
                _SqlText += "   AND a.wh_cd = '" + _params[0] + "'                      ";
                _SqlText += "   AND a.use_yn = 'Y'                                      ";
            }
            else if (_sql == "CUST_I")
            {
                _SqlText += "SELECT * FROM CSTMST";
                _SqlText += " WHERE cust_cd like '%" + _txtSearch.Text + "%'";
                _SqlText += "    OR cust_nm like '%" + _txtSearch.Text + "%'";
            }
            else if (_sql == "CUST_O")
            {
                _SqlText += "SELECT * FROM CSTMST";
                _SqlText += " WHERE cust_cd like '%" + _txtSearch.Text + "%'";
                _SqlText += "    OR cust_nm like '%" + _txtSearch.Text + "%'";
            }
            else if (_sql == "PNO_USE")
            {
                _SqlText += "SELECT * FROM PNOMST       ";
                _SqlText += " WHERE end_dt is null      ";
                _SqlText += "   AND (p_name like '%" + _txtSearch.Text + "%'     ";
                _SqlText += "    OR  p_no like '%" + _txtSearch.Text + "%')     ";
            }
            else if (_sql == "PRCMST")
            {
                _SqlText += "SELECT * FROM PRCMST";
                _SqlText += " WHERE use_yn = 'Y' AND (proc_cd like '%'+'" + _txtSearch.Text + "'+'%'";
                _SqlText += "    OR proc_nm like '%'+'" + _txtSearch.Text + "'+'%')";
            }
            else if (_Sql == "PNOMST")
            {
                _SqlText += "SELECT * FROM PNOMST";
                _SqlText += " WHERE p_no like '%'+'" + _txtSearch.Text + "'+'%'";
                _SqlText += "    OR p_name like '%'+'" + _txtSearch.Text + "'+'%'";
            }
            else if (_Sql == "LINPRC")
            {
                _SqlText += "SELECT a.line_cd,b.line_nm,a.proc_cd,c.proc_nm FROM LINPRC a";
                _SqlText += " INNER JOIN LINMST b ON b.line_cd = a.line_cd";
                _SqlText += " INNER JOIN PRCMST c ON c.proc_cd = a.proc_cd";
                _SqlText += " WHERE a.use_yn = 'Y' AND (a.line_cd like '%'+'" + _txtSearch.Text + "'+'%'";
                _SqlText += "    OR b.line_nm like '%'+'" + _txtSearch.Text + "'+'%')";
            }

        }

        void setCaption(String _sql)
        {

            String sql_text = "";
            sql_text += "SELECT seq, text FROM POPTTL       \r\n";
            sql_text += " WHERE pop_cd = '" + _sql + "'     \r\n";
            sql_text += " ORDER BY seq                      \r\n";
            DataTable _dt = base.GetDataTable(sql_text);

            int i = 0;
            foreach (DataRow drow in _dt.Rows)
            {
                gridView1.Columns[i].Caption = drow["text"].ToString();
                i++;
            }
        }

        private void frmPopUp_Load(object sender, EventArgs e)
        {
            string s_text = '%' + _txtSearch.Text + '%';

            DataTable _dt01 = base.GetDataTable("P_comPOPSQL", _Sql, s_text, _params[0], _params[1], _params[2], _params[3], _params[4]);
            gPopup.DataSource = _dt01;
            setCaption(_Sql);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                DataRow _row = gridView1.GetFocusedDataRow();
                dRow = _row;
                // OK 반환
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            setSQL(_Sql);
            DataTable _dt01 = base.GetDataTable(_SqlText);
            gPopup.DataSource = _dt01;

        }


        private void _btnSearchAll_Click(object sender, EventArgs e)
        {
            _txtSearch.Text = "";
            setSQL(_Sql);
            DataTable _dt01 = base.GetDataTable(_SqlText);
            gPopup.DataSource = _dt01;
        }

    }
}
