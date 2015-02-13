using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlDAL;

namespace BLL
{
    public  class userBLL
    {
        public MySqlDataReader  login(Model.user aa)
        {
            userDAL dalus = new userDAL();
            return dalus.login(aa); 
        }
        public MySqlDataReader lo(Model.user aa)
        {
            userDAL da = new userDAL();
            return da.lo(aa);
        }
        public int insert(Model.user aa)
        {
            userDAL dalu = new userDAL();
            return dalu.insert(aa);
        }
        public DataSet  pan(Model.user aa)
        {
            userDAL daluss = new userDAL();
            return daluss.pan(aa);
        }
        public MySqlDataReader pp(Model.user aa)
        {
            userDAL dal = new userDAL();
            return dal.dd(aa);
        }
        public MySqlDataReader drs(Model.user aa)
        {
            userDAL dsd = new userDAL();
            return dsd.drs(aa);
        }
        public int upus(Model.user aa)
        {
            userDAL ds = new userDAL();
            return ds.upd(aa);
        }
        public int upwd(Model.user aa)
        {
            userDAL dalll = new userDAL();
            return dalll.upwd(aa);
        }
        public int upad(Model.address aa)
        {
            address dala = new address();
            return dala.insert(aa);
        }
        public MySqlDataReader drid(Model.user aa)
        {
            userDAL da = new userDAL();
            return da.drid(aa);
        }
        public MySqlDataReader drp(Model.user aa)
        {
            userDAL dals = new userDAL();
            return dals.drpw(aa);
        }
        public int update(Model.user aa)
        {
            userDAL dalu = new userDAL();
            return dalu.update(aa);
        }
        public MySqlDataReader drti(Model.user aa)
        {
            userDAL ds = new userDAL();
            return ds.drti(aa);
        }

    }
    public class oredr
    {
        public DataSet dspor(int a,int b,Model.order aa)
        {
            order dalo = new order();
            return dalo.dsor(a,b,aa);
        }
        public DataSet dspor1(Model.order aa)
        {
            order dal = new order();
            return dal.dsmai(aa);
        }
        //查看某条订单
        //public DataSet kanor(int a,int b,string c, Model.order aa)
        //{
        //    DAL.order daloo = new DAL.order();
        //    return daloo.kandi(a,b,c,aa);
        //}

        //public int countcha(Model.order aa)
        //{
        //    DAL.order dalorr = new DAL.order();
        //    return dalorr.countcha(aa);
        //}

        //public MySqlDataReader dror(Model.order aa)
        //{
        //    DAL.order daorde = new DAL.order();
        //    return daorde.drorf(aa);
        //}
        public int deor(Model.order aa)
        {
            order deo = new order();
            return deo.deo(aa);
        }
        public int count(Model.order aa)
        {
            order dalk = new order();
            return dalk.coun(aa);
        }

    }
}
