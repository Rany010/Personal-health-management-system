using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class historys_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化病历
            chushi();
        }
    }

    /// <summary>
    /// 初始化病历
    /// </summary>
    protected void chushi()
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"select * from historys where id=" + Request.QueryString["id"] );

        //根据编号得到相应的记录
        DataSet ds = DbHelperSQL.Query(strSql.ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_odate.Text = ds.Tables[0].Rows[0]["odate"].ToString();
            txt_hname.Text = ds.Tables[0].Rows[0]["hname"].ToString();
            txt_doctor.Text = ds.Tables[0].Rows[0]["doctor"].ToString();
            txt_chuf.Text = ds.Tables[0].Rows[0]["chuf"].ToString();
            txt_qdate.Text = ds.Tables[0].Rows[0]["qdate"].ToString();
        }
    }

    /// <summary>
    /// 编辑病历
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //更新   
        StringBuilder strSql = new StringBuilder();

        strSql.Append("update historys set ");
        strSql.Append("odate = @odate,");
        strSql.Append("hname = @hname,");
        strSql.Append("doctor = @doctor,");
        strSql.Append("chuf = @chuf,");
        strSql.Append("qdate = @qdate");
        strSql.Append("  where id=@id");
        int id = int.Parse(Request.QueryString["id"]);

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@odate", SqlDbType.VarChar,50),
                    new SqlParameter("@hname", SqlDbType.VarChar,50),
                    new SqlParameter("@doctor", SqlDbType.VarChar,50),
                    new SqlParameter("@chuf", SqlDbType.VarChar,500),
                    new SqlParameter("@qdate", SqlDbType.VarChar,50)  };
              parameters[0].Value =id;
              parameters[1].Value = txt_odate.Text;
              parameters[2].Value = txt_hname.Text;
              parameters[3].Value = txt_doctor.Text;
              parameters[4].Value = txt_chuf.Text;
              parameters[5].Value = txt_qdate.Text;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Manage.aspx");
    }



    
}

