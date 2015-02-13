using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
   public class product
    {
       public int insert(Model.product mym)
       {
           productDAL dal = new productDAL();
           return dal.Insert(mym);
       }
       public DataSet dataset()
       {
           productDAL dal = new productDAL();
           return dal.dataset();
       }
       public int delete_id(Model.product mym)
       {
           productDAL dal = new productDAL();
           return dal.delete_id(mym);
       }
       public DataSet select_title(Model.product mym)
       {
           productDAL dal = new productDAL();
           return dal.select_title(mym);

       
       }
       public string select_imageid(Model.product mym)
       {
           productDAL dal = new productDAL();
           return dal.select_imageid(mym);
       }
       public MySqlDataReader selectupdate(int mym)
       {
           productDAL dal = new productDAL();
           return dal.selectupdate(mym);
       }
       public int update(Model.product mym)
       {
           productDAL dal = new productDAL();
           return dal.update(mym);
       }
       public int num(int cateid)
       {
           productDAL dal = new productDAL();
           return dal.num(cateid);
       }

       //

       public DataSet drpo(Model.product aa)
       {
           productDAL dalp = new productDAL();
           return dalp.drpo(aa);
       }
       public MySqlDataReader drpr(Model.product aa)
       {
           productDAL dalps = new productDAL();
           return dalps.drpr(aa);
       }
       public MySqlDataReader drim(Model.product aa)
       {
           productDAL dalpdd = new productDAL();
           return dalpdd.drima(aa);
       }
       //


       public int num_cateid(int cateid)
       {
           productDAL dal = new productDAL();
           return dal.num_cateid(cateid);
       }
       public DataSet p_dataset(int cateid, int pageindex, int pagesize, string table)
       {
           productDAL dal = new productDAL();
           return dal.p_dateset(cateid, pageindex, pagesize, table);
       }

       public DataSet getProductDS(string sql)
       {
           productDAL dal = new productDAL();
           return dal.getProductDS(sql);
       }
    }

}
