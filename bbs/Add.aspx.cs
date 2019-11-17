using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class bbs_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }
    }

    /// <summary>
    /// 添加话题
    ///</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
       //设置Sql
         StringBuilder strSql = new StringBuilder();
         strSql.Append(@"insert into Bbs ( title,memo,atime ) ");
        strSql.Append(@" values (@title,@memo,@atime)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@title", SqlDbType.VarChar,50),
            new SqlParameter("@memo", SqlDbType.NText,50000),
            new SqlParameter("@atime", SqlDbType.DateTime,8)        };

        parameters[0].Value =txt_title.Text;
        parameters[1].Value = elm1.Value;
        parameters[2].Value =DateTime.Now;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);


        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Add.aspx");
    }

    
}

