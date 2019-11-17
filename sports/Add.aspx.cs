using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class sports_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }
    }

    /// <summary>
    /// 添加日常运动量
    ///</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
       //设置Sql
         StringBuilder strSql = new StringBuilder();
         strSql.Append(@"insert into Sports ( lname,sdate,squan ) ");
        strSql.Append(@" values (@lname,@sdate,@squan)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@lname", SqlDbType.VarChar,50),
            new SqlParameter("@sdate", SqlDbType.VarChar,50),
            new SqlParameter("@squan", SqlDbType.Int,4)        };

        parameters[0].Value = Session["bh"].ToString();
        parameters[1].Value =txt_sdate.Text;
        parameters[2].Value =int.Parse (txt_squan.Text);

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);


        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Add.aspx");
    }

    
}

