using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
   public class Helpcate
    {
       public int insert(Model.Helpcate mh)
       {
           HelpcateDAL dh = new HelpcateDAL();
           int result = dh.insert(mh);
           return result;
       }
       public MySqlDataReader sqlDataReader(Model.Helpcate mh)
       {
           HelpcateDAL dh = new HelpcateDAL();
           MySqlDataReader sdr = dh.MySqlDataReader(mh);
           return sdr;
       }
       public int _delete(Model.Helpcate mh)
       {
           HelpcateDAL dh = new HelpcateDAL();
           int result = dh._delete(mh);
           return result;
       }
       public int update(Model.Helpcate mh)
       {
           HelpcateDAL dh = new HelpcateDAL();
           int result = dh.update(mh);
           return result;
      }
       //public void define()
       //{
       //    Model.Helpcate mh = new Model.Helpcate();
       //    mh.ID = Convert.ToInt32(Request.QueryString["uid"]);
           
       //}
    }
    
}
