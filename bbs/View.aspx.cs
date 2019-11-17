using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class bbs_Show : System.Web.UI.Page
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
}

