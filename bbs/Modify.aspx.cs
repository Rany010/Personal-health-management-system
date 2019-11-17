using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class bbs_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化话题
            chushi();
        }
    }

    /// <summary>
    /// 初始化话题
    /// </summary>
    protected void chushi()
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"select * from bbs where bid=" + Request.QueryString["id"] );

        //根据编号得到相应的记录
        DataSet ds = DbHelperSQL.Query(strSql.ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_title.Text = ds.Tables[0].Rows[0]["title"].ToString();
            elm1.Value= ds.Tables[0].Rows[0]["memo"].ToString();
        }
    }

    /// <summary>
    /// 编辑话题
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //更新   
        StringBuilder strSql = new StringBuilder();

        strSql.Append("update bbs set ");
        strSql.Append("title = @title,");
        strSql.Append("memo = @memo");
        strSql.Append("  where bid=@bid");
        int bid = int.Parse(Request.QueryString["id"]);

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@bid", SqlDbType.Int,4),
                    new SqlParameter("@title", SqlDbType.VarChar,50),
                    new SqlParameter("@memo", SqlDbType.NText,50000)  };
              parameters[0].Value =bid;
              parameters[1].Value = txt_title.Text;
              parameters[2].Value =elm1.Value;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Manage.aspx");
    }



    
}

