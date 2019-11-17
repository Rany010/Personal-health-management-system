using System;
using System.Text;

/// <summary>
/// </summary>
public class MessageBox
{
    private MessageBox()
    {
    }

    /// <summary>
    /// ��ʾ��Ϣ��ʾ�Ի���
    /// </summary>
    /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
    /// <param name="msg">��ʾ��Ϣ</param>
    public static void Show(System.Web.UI.Page page, string msg)
    {
        page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>alert('" + msg.ToString() + "');</script>");
    }

    /// <summary>
    /// �ؼ���� ��Ϣȷ����ʾ��
    /// </summary>
    /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
    /// <param name="msg">��ʾ��Ϣ</param>
    public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
    {
        //Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");
        Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
    }

    /// <summary>
    /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
    /// </summary>
    /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
    /// <param name="msg">��ʾ��Ϣ</param>
    /// <param name="url">��ת��Ŀ��URL</param>
    public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
    {
        //Response.Write("<script>alert('�ʻ����ͨ��������ȥΪ��ҵ��ֵ��');window.location=\"" + pageurl + "\"</script>");
        page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>alert('" + msg + "');window.location=\"" + url + "\"</script>");


    }
    /// <summary>
    /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
    /// </summary>
    /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
    /// <param name="msg">��ʾ��Ϣ</param>
    /// <param name="url">��ת��Ŀ��URL</param>
    public static void ShowAndRedirects(System.Web.UI.Page page, string msg, string url)
    {
        StringBuilder Builder = new StringBuilder();
        Builder.Append("<script language='javascript' defer>");
        Builder.AppendFormat("alert('{0}');", msg);
        Builder.AppendFormat("top.location.href='{0}'", url);
        Builder.Append("</script>");
        page.ClientScript.RegisterStartupScript(page.GetType(), "message", Builder.ToString());

    }

    /// <summary>
    /// ����Զ���ű���Ϣ
    /// </summary>
    /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
    /// <param name="script">����ű�</param>
    public static void ResponseScript(System.Web.UI.Page page, string script)
    {
        page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>" + script + "</script>");

    }


    /// <summary>
    /// ִ���Զ���ű���Ϣ
    /// </summary>
    /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
    /// <param name="script">����ű�</param>
    public static void RunScript(System.Web.UI.Page page, string script)
    {
        page.Response.Write("<script>" + script + "</script>");
    }

}

