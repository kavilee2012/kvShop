using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;

namespace BLL
{
   public class fathercate
    {
       public int insert(Model.fathercate mym)
       {
           fathercateDAL dal = new fathercateDAL();
           return dal.insert(mym);
       }
       public DataSet dataset()
       {
           fathercateDAL dal = new fathercateDAL();
           return dal.dataset();
       }
       public int update(Model.fathercate mym)
       {
           fathercateDAL dal = new fathercateDAL();
           return dal.update(mym);
       }
       public int delete(int f_id)
       {
           fathercateDAL dal = new fathercateDAL();
           return dal.delete(f_id);
       }
    }
    
}
