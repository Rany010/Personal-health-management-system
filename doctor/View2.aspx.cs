using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class doctor_Show : System.Web.UI.Page
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
    ///</summary>
    protected void chushi()
    {
        //判断url传递的id是否为null
        if (Request.QueryString["id"] != null)
        {

            string sql="";
            sql="select * from doctor where dno='"+ Request.QueryString["id"]+"'";
            //根据编号得到相应的记录
            SqlDataReader sdr = DbHelperSQL.ExecuteReader(sql);
            if (sdr.Read())
            {
                lbldno.Text = sdr["dno"].ToString();
                lbldname.Text = sdr["dname"].ToString();
                lblsex.Text = sdr["sex"].ToString();
                lblage.Text = sdr["age"].ToString();
                if (sdr["pic"].ToString() != "" && sdr["pic"].ToString().Length > 3)
                {
                    imgpic.ImageUrl = "../uploads/" + sdr["pic"].ToString();
                }
                lblcname.Text = sdr["cname"].ToString();
                lbljob.Text = sdr["job"].ToString();
                lbltel.Text = sdr["tel"].ToString();
                lblmemo.Text = sdr["memo"].ToString();
            }

        }
    }
}

