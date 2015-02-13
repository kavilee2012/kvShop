using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
   public class downlist
    {
       public int downloadadd(Model.downlist md)
       {
           downlistDAL dd = new downlistDAL();
           return dd.downloadadd(md);
       }
       public int update(Model.downlist md)
       {
           downlistDAL dd = new downlistDAL();
           return dd.update(md);
       }
       public MySqlDataReader datareader(Model.downlist md)
       {
           downlistDAL dd=new downlistDAL();
           return dd.datareader(md);
       }
       public int _delete(Model.downlist md)
       {
           downlistDAL dd = new downlistDAL();
           return dd._delete(md);

       }
       public int click(Model.downlist md)
       {
           downlistDAL dd = new downlistDAL();
           return dd.click(md);
       }
    }
}
