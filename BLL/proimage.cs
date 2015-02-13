using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
   public  class proimage
    {
       public int insert(Model.proimage myb)
       {
           proimageDAL dal = new proimageDAL();
           return dal.Insert(myb);
       }
       public int selectid(Model.proimage myb)
       {
           proimageDAL dal = new proimageDAL();
           return dal.selectid(myb);
       }
       public DataSet select_sizeid(string myb)
       {

           proimageDAL dal = new proimageDAL();
           return dal.select_sizeid(myb);
 
       }
       public int delete(string mym)
       {
           proimageDAL dal = new proimageDAL();
           return dal.delete(mym);
       }
       public int delete_1(string mym)
       {
           proimageDAL dal = new proimageDAL();
           return dal.delect_1(mym);
       }
       public MySqlDataReader image_update(string size_id)
       {
           proimageDAL dal = new proimageDAL();
           return dal.image_update(size_id);

       }
       public int upimage(Model.proimage mym)
       {
           proimageDAL dal = new proimageDAL();
           return dal.upimage(mym);
       }
       public DataSet select_color(string mym)
       {
           proimageDAL dal = new proimageDAL();
           return dal.select_color(mym);
       }
       public MySqlDataReader s_imageurl(string size_id)
       {
           proimageDAL dal = new proimageDAL();
           return dal.s_imageurl(size_id);
       }

       //

       public MySqlDataReader drim(Model.proimage aa)
       {
           proimageDAL da = new proimageDAL();
           return da.dsim(aa);
       }
    }
}
