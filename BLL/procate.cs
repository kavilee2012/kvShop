using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;

namespace BLL
{
   public class procate
    {
       public int insert(Model.procate model1)
       {
           procateDAL dal = new procateDAL();
           int result= dal.Insert(model1);
           return result;
       }
       public DataSet dataset()
       {
           procateDAL dal = new procateDAL();
           return dal.dataset();
       }
       public DataSet data_set()
       {
           procateDAL dal = new procateDAL();
           return dal.data_set();
       }
       public string select_name(int cate_id)
       {
           procateDAL dal = new procateDAL();
           return dal.select_name(cate_id);
       }
       public int num(int f_id)
       {
           procateDAL dal = new procateDAL();
           return dal.num(f_id);

       }
       public int update(Model.procate mym)
       {
           procateDAL dal = new procateDAL();
           return dal.update(mym);
       }
       public int dalete(int cate_id)
       {
           procateDAL dal = new procateDAL();
           return dal.delete(cate_id);
       }
       public DataSet data_f(int f_cateid)
       {
           procateDAL dal = new procateDAL();
           return dal.data_f(f_cateid);
       }


    }
}
