using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class doctor_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }
    }

    /// <summary>
    /// 添加专家
    ///</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
        //验证是否已经存在
        if (DbHelperSQL.Exists("select count(*) from doctor where dno='" + txt_dno.Text + "'"))
        {
            MessageBox.Show(this, "该专家编号已存在，请重新输入！");
            return;
        }

       //设置Sql
         StringBuilder strSql = new StringBuilder();
         strSql.Append(@"insert into Doctor ( dno,pass,dname,sex,age,pic,cname,job,tel,memo ) ");
        strSql.Append(@" values (@dno,@pass,@dname,@sex,@age,@pic,@cname,@job,@tel,@memo)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@dno", SqlDbType.VarChar,50),
            new SqlParameter("@pass", SqlDbType.VarChar,50),
            new SqlParameter("@dname", SqlDbType.VarChar,50),
            new SqlParameter("@sex", SqlDbType.VarChar,10),
            new SqlParameter("@age", SqlDbType.VarChar,10),
            new SqlParameter("@pic", SqlDbType.VarChar,50),
            new SqlParameter("@cname", SqlDbType.VarChar,50),
            new SqlParameter("@job", SqlDbType.VarChar,50),
            new SqlParameter("@tel", SqlDbType.VarChar,50),
            new SqlParameter("@memo", SqlDbType.VarChar,500)        };

        parameters[0].Value =txt_dno.Text;
        parameters[1].Value =txt_pass.Text;
        parameters[2].Value =txt_dname.Text;
        parameters[3].Value =rtsex.SelectedValue;
        parameters[4].Value =txt_age.Text;


        string addrpic ="";
        if (fppic.HasFile)
        {
            string name = this.fppic.PostedFile.FileName;
            int i = name.LastIndexOf('.');
            string extname = name.Substring(i);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            string path =  filename + extname;
            string savePath = Server.MapPath(@"..\uploads\" + filename + extname);
            fppic.PostedFile.SaveAs(savePath);
            addrpic = path;
        }

        parameters[5].Value =addrpic;
        parameters[6].Value =txt_cname.Text;
        parameters[7].Value =rdljob.SelectedValue;
        parameters[8].Value =txt_tel.Text;
        parameters[9].Value =txt_memo.Text;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);


        MessageBox.ShowAndRedirect(this, "操作成功，请返回!", "Add.aspx");
    }

    
}

