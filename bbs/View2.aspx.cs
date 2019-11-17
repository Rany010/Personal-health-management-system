using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

public partial class bbs_Show : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化话题
            chushi();
            bind();
        }
    }

    // 绑定话题讨论
    private void bind()
    {
        string where = " where bid="+Request.QueryString["id"];

        GridView1.DataSource = DbHelperSQL.Query("select * from bbsView " + where + " order by id desc");
        GridView1.DataBind();

    }

    /// <summary>
    /// 分页事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }

    // 搜索
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        bind();
    }

    /// <summary>
    /// 初始化话题
    ///</summary>
    protected void chushi()
    {
        //判断url传递的id是否为null
        if (Request.QueryString["id"] != null)
        {

            string sql="";
            sql="select * from bbs where bid="+ Request.QueryString["id"];
            //根据编号得到相应的记录
            SqlDataReader sdr = DbHelperSQL.ExecuteReader(sql);
            if (sdr.Read())
            {
                lblbid.Text = sdr["bid"].ToString();
                lbltitle.Text = sdr["title"].ToString();
                lblmemo.Text = sdr["memo"].ToString();
                lblatime.Text = sdr["atime"].ToString();
            }

        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Manage2.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (elm1.Value=="")
        {
            MessageBox.Show(this, "请输入回复内容");
        }

        string pic = "";

        if (Session["qx"].ToString()== "专家")
        {
            pic = DbHelperSQL.GetSingle("select pic from doctor where dno='" + Session["bh"].ToString() + "' ").ToString();
        }
        else
        {
            pic = DbHelperSQL.GetSingle("select pic from users where lname='" + Session["bh"].ToString() + "' ").ToString();
        }

        //设置Sql
        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"insert into BbsView ( bid,vmemo,vtime,lname,sf,pic ) ");
        strSql.Append(@" values (@bid,@vmemo,@vtime,@lname,@sf,@pic)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@bid", SqlDbType.Int,4),
            new SqlParameter("@vmemo", SqlDbType.NText,50000),
            new SqlParameter("@vtime", SqlDbType.DateTime,8),
            new SqlParameter("@lname", SqlDbType.VarChar,50),
            new SqlParameter("@sf", SqlDbType.VarChar,50),
            new SqlParameter("@pic", SqlDbType.VarChar,50)        };

        parameters[0].Value = Request.QueryString["id"];
        parameters[1].Value = elm1.Value;
        parameters[2].Value = DateTime.Now;
        parameters[3].Value = Session["bh"].ToString();
        parameters[4].Value = Session["qx"].ToString();
        parameters[5].Value = pic;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        elm1.Value = "";

        chushi();

        bind();

        MessageBox.Show(this, "操作成功");

    }
}

