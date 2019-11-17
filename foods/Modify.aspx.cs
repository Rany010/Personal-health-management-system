using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class foods_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化膳食搭配
            chushi();
        }
    }

    /// <summary>
    /// 初始化膳食搭配
    /// </summary>
    protected void chushi()
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"select * from foods where id=" + Request.QueryString["id"] );

        //根据编号得到相应的记录
        DataSet ds = DbHelperSQL.Query(strSql.ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_fdate.Text = ds.Tables[0].Rows[0]["fdate"].ToString();
            ddlftype.SelectedValue=ds.Tables[0].Rows[0]["ftype"].ToString();
            txt_memo.Text = ds.Tables[0].Rows[0]["memo"].ToString();
            txt_ftime.Text = ds.Tables[0].Rows[0]["ftime"].ToString();
        }
    }

    /// <summary>
    /// 编辑膳食搭配
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //更新   
        StringBuilder strSql = new StringBuilder();

        strSql.Append("update foods set ");
        strSql.Append("fdate = @fdate,");
        strSql.Append("ftype = @ftype,");
        strSql.Append("memo = @memo,");
        strSql.Append("ftime = @ftime");
        strSql.Append("  where id=@id");
        int id = int.Parse(Request.QueryString["id"]);

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@fdate", SqlDbType.VarChar,50),
                    new SqlParameter("@ftype", SqlDbType.VarChar,50),
                    new SqlParameter("@memo", SqlDbType.VarChar,500),
                    new SqlParameter("@ftime", SqlDbType.VarChar,50)  };
              parameters[0].Value =id;
              parameters[1].Value = txt_fdate.Text;
              parameters[2].Value =ddlftype.SelectedValue;
              parameters[3].Value = txt_memo.Text;
              parameters[4].Value = txt_ftime.Text;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Manage.aspx");
    }



    
}

