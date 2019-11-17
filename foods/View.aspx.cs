using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class foods_Show : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化膳食搭配
            chushi();
        }
    }

    /// <summary>
    /// 初始化膳食搭配
    ///</summary>
    protected void chushi()
    {
        //判断url传递的id是否为null
        if (Request.QueryString["id"] != null)
        {

            string sql="";
            sql="select * from foods where id="+ Request.QueryString["id"];
            //根据编号得到相应的记录
            SqlDataReader sdr = DbHelperSQL.ExecuteReader(sql);
            if (sdr.Read())
            {
                lblid.Text = sdr["id"].ToString();
                lbllname.Text = sdr["lname"].ToString();
                lblfdate.Text = sdr["fdate"].ToString();
                lblftype.Text = sdr["ftype"].ToString();
                lblmemo.Text = sdr["memo"].ToString();
                lblftime.Text = sdr["ftime"].ToString();
            }

        }
    }
}

