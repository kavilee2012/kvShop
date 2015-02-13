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
    public class BLLadmin
    {
        public MySqlDataReader checkAdmin(admin admin)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.checkAdmin(admin);
        }

        public int insertAdmin(admin admin)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.insertAdmin(admin);
        }
        public int deleteAdmin(admin admin)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.deleteAdmin(admin);
        }

        public DataSet selectAdmin(int pageindex, int pagesize, string table)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.selectAdmin();
        }
        public int updateAdmin(admin admin)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.updateAdmin(admin);
        }
        public MySqlDataReader readAdmin(admin admin)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.readAdmin(admin);

        }
        public MySqlDataReader _login(admin admin)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL._login(admin);
        }
        //public DataSet searchAdmin(admin admin)
        //{
        //    DALadminDAL DALadminDAL = new DALadminDAL();
        //    return DALadminDAL.searchAdmin(admin);
        //}

        public DataSet adminlist(int pageindex, int pagesize, string table)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            DataSet ds = DALadminDAL.adminlist(pageindex, pagesize, table);
            return ds;
        }

        public int admin()
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.admin();
        }

        public int s_admin(string name)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            return DALadminDAL.s_admin(name);
        
        }

        public DataSet S_admin(int pageindex, int pagesize, string table, string name)
        {
            DALadminDAL DALadminDAL = new DALadminDAL();
            DataSet ds = DALadminDAL.S_admin(pageindex, pagesize, table,name);
            return ds;
        }


     

        
    }
}
