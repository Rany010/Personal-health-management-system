  using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.SqlClient;

public partial class doctor_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            bind();
        }
    }

    // 绑定专家
    private void bind()
    {       
        string where = " where 1=1 ";

        if (txt_dno.Text != "")
        {
            where += " and dno like '%" + txt_dno.Text + "%' ";
        }

        if (txt_dname.Text != "")
        {
            where += " and dname like '%" + txt_dname.Text + "%' ";
        }

        if (txt_cname.Text != "")
        {
            where += " and cname like '%" + txt_cname.Text + "%' ";
        }



        GridView1.DataSource = DbHelperSQL.Query("select * from doctor " + where + " order by dno desc");
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
    
    //删除专家
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string idlist = "'";
        bool BxsChkd = false;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox ChkBxItem = (CheckBox)GridView1.Rows[i].FindControl("DeleteThis");
            if (ChkBxItem != null && ChkBxItem.Checked)
            {
                BxsChkd = true;
                if (GridView1.DataKeys[i].Value != null)
                {
                    idlist += GridView1.DataKeys[i].Value.ToString() + "','";
                }
            }
        }
        if (BxsChkd)
        {
            idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            DbHelperSQL.ExecuteSql("delete from doctor where dno in(" + idlist + ")");
            bind();
        }
        else 
        {
            MessageBox.Show(this,"请选择要删除的项！");
            return;
        }
    }

    //全选
    protected void btnAll_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox ChkBxItem = (CheckBox)GridView1.Rows[i].FindControl("DeleteThis");
            ChkBxItem.Checked = true;
        }
    }

    //反选
    protected void btnUn_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox ChkBxItem = (CheckBox)GridView1.Rows[i].FindControl("DeleteThis");
            if ( ChkBxItem.Checked)
            {
                ChkBxItem.Checked = false;
            }
            else
            {
                ChkBxItem.Checked = true;
            }
        }
    }





    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lk = (LinkButton)sender;

        //验证是否已经存在
        if (DbHelperSQL.Exists("select count(*) from applys where dno='" + lk.CommandName + "' and lname='"+ Session["bh"].ToString()+"' "))
        {
            MessageBox.Show(this, "请求失败，您已经请求过此专家了！");
            return;
        }

        //设置Sql
        StringBuilder strSql = new StringBuilder();
        strSql.Append(@"insert into Applys ( lname,dno,atime ) ");
        strSql.Append(@" values (@lname,@dno,@atime)");

        //设置参数
        SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@lname", SqlDbType.VarChar,50),
            new SqlParameter("@dno", SqlDbType.VarChar,50),
            new SqlParameter("@atime", SqlDbType.DateTime,8)        };

        parameters[0].Value = Session["bh"].ToString();
        parameters[1].Value = lk.CommandName;
        parameters[2].Value = DateTime.Now;

        //提交到数据库
        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        MessageBox.Show(this, "请求成功，请等待专家的处理");

    }
}

