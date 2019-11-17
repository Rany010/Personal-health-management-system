using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public partial class doctor_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化专家
            chushi();
        }
    }

    /// <summary>
    /// 初始化专家
    /// </summary>
    protected void chushi()
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"select * from doctor where dno='" + Session["bh"].ToString() + "'");

        //根据编号得到相应的记录
        DataSet ds = DbHelperSQL.Query(strSql.ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_dno.Text = ds.Tables[0].Rows[0]["dno"].ToString();
            txt_dname.Text = ds.Tables[0].Rows[0]["dname"].ToString();
            rtsex.SelectedValue=ds.Tables[0].Rows[0]["sex"].ToString();
            txt_age.Text = ds.Tables[0].Rows[0]["age"].ToString();
            Labelpic.Text = ds.Tables[0].Rows[0]["pic"].ToString();
            if (Labelpic.Text != "" && Labelpic.Text.Length > 3)
            {
               Imagepic.ImageUrl = "../uploads/" + Labelpic.Text;
               Imagepic.Visible = true;
             }
            txt_cname.Text = ds.Tables[0].Rows[0]["cname"].ToString();
            rdljob.SelectedValue=ds.Tables[0].Rows[0]["job"].ToString();
            txt_tel.Text = ds.Tables[0].Rows[0]["tel"].ToString();
            txt_memo.Text = ds.Tables[0].Rows[0]["memo"].ToString();
        }
    }

    /// <summary>
    /// 编辑专家
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //更新   
        StringBuilder strSql = new StringBuilder();

        strSql.Append("update doctor set ");
        strSql.Append("dname = @dname,");
        strSql.Append("sex = @sex,");
        strSql.Append("age = @age,");
        strSql.Append("pic = @pic,");
        strSql.Append("cname = @cname,");
        strSql.Append("job = @job,");
        strSql.Append("tel = @tel,");
        strSql.Append("memo = @memo");
        strSql.Append("  where dno=@dno");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@dno", SqlDbType.VarChar,50),
                            new SqlParameter("@dname", SqlDbType.VarChar,50),
                    new SqlParameter("@sex", SqlDbType.VarChar,10),
                    new SqlParameter("@age", SqlDbType.VarChar,10),
                    new SqlParameter("@pic", SqlDbType.VarChar,50),
                    new SqlParameter("@cname", SqlDbType.VarChar,50),
                    new SqlParameter("@job", SqlDbType.VarChar,50),
                    new SqlParameter("@tel", SqlDbType.VarChar,50),
                    new SqlParameter("@memo", SqlDbType.VarChar,500)  };
              parameters[0].Value = txt_dno.Text;
              parameters[1].Value = txt_dname.Text;
              parameters[2].Value =rtsex.SelectedValue;
              parameters[3].Value = txt_age.Text;

        string addrpic =Labelpic.Text;
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
              parameters[4].Value =addrpic;
              parameters[5].Value = txt_cname.Text;
              parameters[6].Value =rdljob.SelectedValue;
              parameters[7].Value = txt_tel.Text;
              parameters[8].Value = txt_memo.Text;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        MessageBox.Show(this, "操作成功，请返回!");
    }



    
}

