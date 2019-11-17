using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class foods_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }
    }

    /// <summary>
    /// 添加膳食搭配
    ///</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
       //设置Sql
         StringBuilder strSql = new StringBuilder();
         strSql.Append(@"insert into Foods ( lname,fdate,ftype,memo,ftime ) ");
        strSql.Append(@" values (@lname,@fdate,@ftype,@memo,@ftime)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@lname", SqlDbType.VarChar,50),
            new SqlParameter("@fdate", SqlDbType.VarChar,50),
            new SqlParameter("@ftype", SqlDbType.VarChar,50),
            new SqlParameter("@memo", SqlDbType.VarChar,500),
            new SqlParameter("@ftime", SqlDbType.VarChar,50)        };

        parameters[0].Value = Session["bh"].ToString();
        parameters[1].Value =txt_fdate.Text;
        parameters[2].Value =ddlftype.SelectedValue;
        parameters[3].Value =txt_memo.Text;
        parameters[4].Value =txt_ftime.Text;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);


        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Add.aspx");
    }

    
}

