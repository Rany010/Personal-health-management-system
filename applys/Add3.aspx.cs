using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class suggest_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化建议
            chushi();
        }
    }

    /// <summary>
    /// 初始化建议
    /// </summary>
    protected void chushi()
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"select * from suggest where lname='" + Request.QueryString["id"]+"' and dno='"+ Session["bh"].ToString()+ "' and stype='运动建议' ");

        //根据编号得到相应的记录
        DataSet ds = DbHelperSQL.Query(strSql.ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            elm1.Value = ds.Tables[0].Rows[0]["memo"].ToString();
        }
    }

    /// <summary>
    /// 添加建议
    ///</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
       //设置Sql
         StringBuilder strSql = new StringBuilder();
         strSql.Append(@"insert into Suggest ( lname,stype,memo,dno,atime ) ");
        strSql.Append(@" values (@lname,@stype,@memo,@dno,@atime)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@lname", SqlDbType.VarChar,50),
            new SqlParameter("@stype", SqlDbType.VarChar,50),
            new SqlParameter("@memo", SqlDbType.NText,50000),
            new SqlParameter("@dno", SqlDbType.VarChar,50),
            new SqlParameter("@atime", SqlDbType.DateTime,8)        };

        parameters[0].Value =Request.QueryString["id"];
        parameters[1].Value = "运动建议";
        parameters[2].Value = elm1.Value;
        parameters[3].Value = Session["bh"].ToString();
        parameters[4].Value =DateTime.Now;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);


        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Manage3.aspx");
    }

    
}

