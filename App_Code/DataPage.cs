using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web;


    public class DataPage
    {
        #region 通用分页pagelist
        /// <summary>
        /// 通用分页
        /// </summary>
        /// <param name="pageszie">每页显示数量</param>
        /// <param name="pageindex">当前第几页</param>
        /// <param name="tablename">表名</param>
        /// <param name="field">查询字段名</param>
        ///  <param name="keyfield">主键</param>
        ///  <param name="strwhere">查询条件</param>
        /// <param name="sort">排序字段</param>
        /// <param name="recordcount">返回记录总数</param>
        public DataSet pagelist(int pageszie, int pageindex, string tablename, string field, string keyfiled, string strwhere, string sort, out int recordcount)
        {
            if (field == "")
            {
                field = " * ";
            }
            if (strwhere == "")
            {
                strwhere = " 1=1 ";
            }
            
            string strSql1 = "select count(*) from " + tablename + " where " + strwhere;
            Object obj = DbHelperSQL.GetSingle(strSql1.ToString());
            recordcount = obj == null ? 0 : Convert.ToInt32(obj.ToString());
            if (pageindex > 1)
            {
                strwhere += " and " + keyfiled + " not in (select top " + pageszie * (pageindex - 1) + " " + keyfiled + " from " + tablename + " where " + strwhere + " order by " + sort + ")";
            }
            string strSql = "select top " + pageszie + " " + field + " from " + tablename + " where " + strwhere + " order by " + sort;

            return DbHelperSQL.Query(strSql.ToString());

        }
        public string getPage(int curPage, int maxPage, string foreUrl)
        {
            string herf = "";

            if (foreUrl.IndexOf("?") < 0)
            {
                foreUrl = foreUrl + "?";
            }
            else
            {
                foreUrl = foreUrl + "&";
            }
            int pstart = curPage - 3;
            int pend = curPage + 3;

            if (pstart < 1) pstart = 1;
            if (pend > maxPage) pend = maxPage;

            if (curPage > 1)
            {
                if (curPage == 2)
                {
                    herf = herf + "<a href=\"" + foreUrl + "\">上一页</a>";
                }
                else
                {
                    herf = herf + "<a href=\"" + foreUrl + "page=" + (curPage - 1).ToString() + "\">上一页</a>";
                }
            }
            else
            {
                herf += "<span>上一页</span>";
            }
            if (pstart > 2)
            {
                herf = herf + "<a href=\"" + foreUrl + "\">1</a>";
                herf = herf + "...";
            }
            for (int step = pstart; step <= pend; step++)
            {
                if (step == 1)
                {
                    if (step == curPage)
                    {
                        herf = herf + "<a href=\"" + foreUrl + "\" class=\"current\">" + step.ToString() + "</a>";
                    }
                    else
                    {
                        herf = herf + "<a href=\"" + foreUrl + "\">" + step.ToString() + "</a>";
                    }
                }
                else
                {
                    if (step == curPage)
                    {
                        herf = herf + "<a href=\"" + foreUrl + "page=" + step + "\" class=\"current\">" + step.ToString() + "</a>";
                    }
                    else
                    {
                        herf = herf + "<a href=\"" + foreUrl + "page=" + step + "\">" + step.ToString() + "</a>";
                    }
                }

            }
            if (pend < maxPage - 1)
            {
                herf = herf + "...";
                herf = herf + "<a href=\"" + foreUrl + "page=" + maxPage + "\">" + maxPage + "</a>";
            }
            if (curPage < maxPage)
            {

                herf = herf + "<a href=\"" + foreUrl + "page=" + (curPage + 1).ToString() + "\">下一页</a>";

            }
            else
            {
                herf += "<span>下一页</span>";
            }
            // herf = herf.Replace("/page/0", "");
            return herf;
        }
        #endregion

    

     
        public string fl_up(System.Web.UI.WebControls.FileUpload f1, string lj)
        {
            string str = "";
            if (f1.HasFile)
            {

                 string tp = f1.PostedFile.FileName.Substring(f1.PostedFile.FileName.LastIndexOf("."));
                 string fileContentType = tp.ToLower();
                if (fileContentType == ".jpg" || fileContentType == ".gif" || fileContentType == ".png")
                {
                    
                    string fileName = DateTime.Now.ToString("yyyyMMddhhmmssfff") + "B" + tp; // 文件名称 
                    string webFilePath = lj + fileName;
                    string fpts = lj;
                    if (!System.IO.Directory.Exists(fpts)) //如果目录不存在，创建
                    {
                        System.IO.Directory.CreateDirectory(fpts);
                    }
                    while (System.IO.File.Exists(webFilePath))
                    {
                        Int64 llj = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddhhmmssfff")) + 1;
                        fileName = llj.ToString() + "B" + tp;
                        webFilePath = fpts + fileName;
                    }
                    try
                    {
                        f1.SaveAs(webFilePath); // 使用 SaveAs 方法保存文件 
                        str = fileName;
                    }
                    catch (Exception )
                    {
                        str = "0";
                    }
                }
                else
                {
                    str = "1";
                }
            }
            return str;
        }


    


    }

