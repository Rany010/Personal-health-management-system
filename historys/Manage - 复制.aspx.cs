  using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class historys_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnDelete.Attributes.Add("onclick", "return confirm(\"你确认要删除吗？\")");

            bind();
        }
    }

    // 绑定病历
    private void bind()
    {       
        string where = " where 1=1 ";

        if (txt_lname.Text != "")
        {
            where += " and lname like '%" + txt_lname.Text + "%' ";
        }



        GridView1.DataSource = DbHelperSQL.Query("select * from historys " + where + " order by id desc");
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
    
    //删除病历
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string idlist = "";
        bool BxsChkd = false;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox ChkBxItem = (CheckBox)GridView1.Rows[i].FindControl("DeleteThis");
            if (ChkBxItem != null && ChkBxItem.Checked)
            {
                BxsChkd = true;
                if (GridView1.DataKeys[i].Value != null)
                {
                    idlist += GridView1.DataKeys[i].Value.ToString() + ",";
                }
            }
        }
        if (BxsChkd)
        {
            idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            DbHelperSQL.ExecuteSql("delete from historys where id in(" + idlist + ")");
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




}

