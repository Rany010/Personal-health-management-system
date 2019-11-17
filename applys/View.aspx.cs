using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class applys_Show : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //初始化请求
            chushi();
        }
    }

    /// <summary>
    /// 初始化请求
    ///</summary>
    protected void chushi()
    {
        //判断url传递的id是否为null
        if (Request.QueryString["id"] != null)
        {

            string sql="";
            sql="select * from applys a left join  users b on a.lname=b.lname where id="+ Request.QueryString["id"];
            //根据编号得到相应的记录
            SqlDataReader sdr = DbHelperSQL.ExecuteReader(sql);
            if (sdr.Read())
            {
                lblid.Text = sdr["id"].ToString();
                lbllname.Text = sdr["lname"].ToString();
                lbldno.Text = sdr["dno"].ToString();
                lblatime.Text = sdr["atime"].ToString();

                lbluname.Text = sdr["uname"].ToString();
                lblsex.Text = sdr["sex"].ToString();
                lblage.Text = sdr["age"].ToString();
                lblxiex.Text = sdr["xiex"].ToString();
                lblheights.Text = sdr["heights"].ToString();
                lblheavy.Text = sdr["heavy"].ToString();
                if (sdr["pic"].ToString() != "" && sdr["pic"].ToString().Length > 3)
                {
                    imgpic.ImageUrl = "../uploads/" + sdr["pic"].ToString();
                }
                lbltel.Text = sdr["tel"].ToString();
            }

        }
    }
}

