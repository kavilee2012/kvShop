using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
   public class BLLHelpcate
    {
       public int insert(Model.Helpcate mh)
       {
           DALHelpcateDAL dh = new DALHelpcateDAL();
           int result = dh.insert(mh);
           return result;
       }
       public MySqlDataReader sqldatareader(Model.Helpcate mh)
       {
           DALHelpcateDAL dh = new DALHelpcateDAL();
           MySqlDataReader sdr = dh.mySqlDataReader(mh);
           return sdr;
       }
       public int _delete(Model.Helpcate mh)
       {
           DALHelpcateDAL dh = new DALHelpcateDAL();
           int result = dh._delete(mh);
           return result;
       }
       public int update(Model.Helpcate mh)
       {
           DALHelpcateDAL dh = new DALHelpcateDAL();
           int result = dh.update(mh);
           return result;
      }

       public DataSet select()
       {

           DALHelpcateDAL dh = new DALHelpcateDAL();
           return dh.select();
       }

       public DataSet select(int cateid)
       {
           DALHelpcateDAL dh = new DALHelpcateDAL();
           return dh.select(cateid);
       }
    }
    
}
