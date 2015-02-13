using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
   public   class collect
    {
       public DataSet  drco(int a,int b, Model.collect aa)
       {
           collectDAL dalc = new collectDAL();
           return dalc.drco(a,b,aa);
       }
       public int insert(Model.collect aa)
       {
           collectDAL dac = new collectDAL();
           return dac.inser(aa);
       }
       public int insertc(Model.collect aa)
       {
           collectDAL dalcd = new collectDAL();
           return dalcd.inser(aa);
       }
       public int depo(Model.collect aa)
       {
           collectDAL dalc = new collectDAL();
           return dalc.deco(aa);
       }
       public int count(Model.collect aa)
       {
           collectDAL dao = new collectDAL();
           return dao.count(aa);
       }
       public int insertco(Model.collect aa)
       {
           collectDAL dcd = new collectDAL();
           return dcd.inserc(aa);
       }
       public MySqlDataReader drsco(Model.collect aa)
       {
           collectDAL das = new collectDAL();
           return das.drcopr(aa);
       }
    }
   //public class product
   //{
   //    public DataSet drpo(Model.product aa)
   //    {
   //        DAL.product dalp = new DAL.product();
   //        return dalp.drpo(aa);
   //    }
   //    public MySqlDataReader drpr(Model.product aa)
   //    {
   //        DAL.product dalps = new DAL.product();
   //        return dalps.drpr(aa);
   //    }
   //    public MySqlDataReader drim(Model.product aa)
   //    {
   //        DAL.product dalpdd = new DAL.product();
   //        return dalpdd.drima(aa);
   //    }
       
   //}
   //public class proimage
   //{
   //    public MySqlDataReader drim(Model.proimage aa)
   //    {
   //        DAL.proimage da = new DAL.proimage();
   //        return da.dsim(aa);
   //    }
   //}
}
