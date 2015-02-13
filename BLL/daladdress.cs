using System;
using System.Collections.Generic;

using System.Text;
using System.Data ;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
   public  class daladdress
    {
       public MySqlDataReader drad(Model.address aa)
       {
           dalaaddressDAL dll = new  dalaaddressDAL ();
           return dll.drad(aa);
       }
       public int upad(Model.address aa)
       {
           dalaaddressDAL ad = new  dalaaddressDAL ();
           return ad.upad(aa);
           
       }
       public int upada(Model.address aa)
       {
           address dala = new address();
           return dala.insert(aa);
       }
       public int addre(Model.address aa)
       {
           dalaaddressDAL dal = new  dalaaddressDAL ();
           return dal.addre(aa);
       }
       public int inserid(Model.address aa)
       {
           dalaaddressDAL daa = new dalaaddressDAL();
           return daa.insert(aa);
       }
       public MySqlDataReader dra(Model.address aa)
       {
           dalaaddressDAL dsa = new dalaaddressDAL();
           return dsa.adr(aa);
       }
    }
}
