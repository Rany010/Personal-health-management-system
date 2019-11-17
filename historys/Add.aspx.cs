using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class historys_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }
    }

    /// <summary>
    /// 添加病历
    ///</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
       //设置Sql
         StringBuilder strSql = new StringBuilder();
         strSql.Append(@"insert into Historys ( lname,odate,hname,doctor,chuf,qdate,atime ) ");
        strSql.Append(@" values (@lname,@odate,@hname,@doctor,@chuf,@qdate,@atime)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@lname", SqlDbType.VarChar,50),
            new SqlParameter("@odate", SqlDbType.VarChar,50),
            new SqlParameter("@hname", SqlDbType.VarChar,50),
            new SqlParameter("@doctor", SqlDbType.VarChar,50),
            new SqlParameter("@chuf", SqlDbType.VarChar,500),
            new SqlParameter("@qdate", SqlDbType.VarChar,50),
            new SqlParameter("@atime", SqlDbType.DateTime,8)        };

        parameters[0].Value = Session["bh"].ToString();
        parameters[1].Value =txt_odate.Text;
        parameters[2].Value =txt_hname.Text;
        parameters[3].Value =txt_doctor.Text;
        parameters[4].Value =txt_chuf.Text;
        parameters[5].Value =txt_qdate.Text;
        parameters[6].Value =DateTime.Now;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);


        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Add.aspx");
    }

    
}

