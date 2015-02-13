using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
   public  class BLLhelp
    {
       public int insert(Help help)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
          return  DALhelpDAL.inserthelp(help);
       }

       public DataSet select(int pageindex, int pagesize, string table)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.select(pageindex, pagesize, table);
       }

       public int delete(Help help)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.delete(help);
       }

       public int update(Help help)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.update(help);
       
       }

       public MySqlDataReader readinfo(Help help)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.readinfo(help);
       }
       public int resultCount()
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
         return   DALhelpDAL.resultCount();
       }

       public int searchResult(Help help)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.searchResult(help);
           
       }

       public DataSet ds_search(int pageindex, int pagesize, string table, int cateid)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.ds_search(pageindex, pagesize, table, cateid);
       
       }

       public DataSet _selectAll(int cateid)
       {

           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL._selectAll(cateid);
       }


       public DataSet cj_ds(int cateid)
       {
           DALhelpDAL dal = new DALhelpDAL();
           return dal.cj_ds(cateid);
       }

       public DataSet selectAll()
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
         return  DALhelpDAL.selectAll();
       }

       public DataSet selectAll(int id)
       {
           DALhelpDAL DALhelpDAL = new DALhelpDAL();
           return DALhelpDAL.selectAll(id);
       
       }
   }
}
