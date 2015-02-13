using System;
using System.Collections.Generic;

using System.Text;


namespace BLL
{
   public  class tisBLL
   {
       public void msg(System.Web.UI.Page page, string msg)
       {
           MySqlDAL.tisDAL dal = new MySqlDAL.tisDAL();
          dal.msg(page, msg);
       }
    }
}
