using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
///StringHelper 的摘要说明
/// </summary>
public class StringHelper
{
    public StringHelper()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    #region 取得固定长度的字符串(按单字节截取)
    /**/
    /// <summary>
    /// 取得固定长度的字符串(按单字节截取)。
    /// </summary>
    /// <param name="source">源字符串</param>
    /// <param name="resultLength">截取长度</param>
    /// <returns></returns>
    #endregion
    public static string SubString(string source, int resultLength)
    {

        //判断字符串长度是否大于截断长度
        if (System.Text.Encoding.Default.GetByteCount(source) > resultLength)
        {
            //判断字串是否为空
            if (source == null)
            {
                return "";
            }

            //初始化
            int i = 0, j = 0;

            //为汉字或全脚符号长度加2否则加1
            foreach (char newChar in source)
            {
                if ((int)newChar > 127)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }
                if (i > resultLength)
                {
                    source = source.Substring(0, j)+"...";
                    break;
                }
                j++;
            }
        }
        return source;
    }

    /// <summary>
    /// 去除HTML标记
    /// </summary>
    public static string ReplaceHtml(string html)
    {
        string StrNohtml = System.Text.RegularExpressions.Regex.Replace(html, "<[^>]+>", "");
        StrNohtml = System.Text.RegularExpressions.Regex.Replace(StrNohtml, "&[^;]+;", "");
        return StrNohtml;
    }

    /// <summary>
    /// 截取HTML字符串
    /// </summary>
    public static string SubStringHtml(string html, int resultLength)
    {
        string StrNohtml = ReplaceHtml(html);
        return SubString(StrNohtml,resultLength);
    }

}