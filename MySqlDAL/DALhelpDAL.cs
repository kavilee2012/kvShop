using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Model;

namespace MySqlDAL
{
    public class DALhelpDAL
    {
        public int inserthelp(Help help)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into help values(@title,@content,@cateid)");

            MySqlParameter[] pra = {
                                new MySqlParameter("@title",MySqlDbType.VarChar,50),
                                new MySqlParameter("@content",MySqlDbType.VarChar,0),
                                new MySqlParameter("@cateid",MySqlDbType.Int32)
                               };
            pra[0].Value = help.Title;
            pra[1].Value = help.Content;
            pra[2].Value = help.Cateid;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);

        }

        public DataSet select(int pageindex, int pagesize, string table)
        {
            string sqlstr = "select * from help order by _cateid asc";

            DataSet ds = DBHelperMySQL.PagedataSet(sqlstr, pageindex, pagesize, table);
            return ds;

        }

        public int delete(Help help)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from help where _id=@id");

            MySqlParameter[] pra = {
                                new MySqlParameter("@id",MySqlDbType.Int32)
                                
                                };

            pra[0].Value = help.ID;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);

        }

        public int update(Help help)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update help set _title=@title,_content=@content where _id=@id");

            MySqlParameter[] pra = { 
                                new MySqlParameter("@title",MySqlDbType.VarChar,50),
                                new MySqlParameter("@content",MySqlDbType.VarChar,0),
                                new MySqlParameter("id",MySqlDbType.Int32)
                                };
            pra[0].Value = help.Title;
            pra[1].Value = help.Content;
            pra[2].Value = help.ID;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);

        }

        public MySqlDataReader readinfo(Help help)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from help where _id=@id");

            MySqlParameter[] pra = { 
                                new  MySqlParameter("@id",MySqlDbType.Int32)
                                
                                };

            pra[0].Value = help.ID;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), pra);

        }

        public int resultCount()
        {

            string sqlstr = "select count(*) from help ";
            int result;
            if (DBHelperMySQL.ExecuteScalar(sqlstr) == null)
            {
                result = 0;

            }
            else
            {
                result = (int)DBHelperMySQL.ExecuteScalar(sqlstr);
            }
            return result;
        }



        public int searchResult(Help help)
        {
            string sqlstr = "select count(*) from help where _cateid=" + help.Cateid + "";
            int result;
            if (DBHelperMySQL.ExecuteScalar(sqlstr) == null)
            {
                result = 0;

            }
            else
            {
                result = (int)DBHelperMySQL.ExecuteScalar(sqlstr);
            }
            return result;
        }


        public DataSet ds_search(int pageindex, int pagesize, string table, int cateid)
        {

            string sqlstr = "select * from help where _cateid=" + cateid + " ";

            DataSet ds = DBHelperMySQL.PagedataSet(sqlstr, pageindex, pagesize, table);
            return ds;

        }

        public DataSet selectAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from help where _cateid=" + 1 + "");

            return DBHelperMySQL.Query(sql.ToString());
        }


        public DataSet _selectAll(int cateid)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select * from help where _cateid=" + cateid + " order by _id desc limit 3");

            return DBHelperMySQL.Query(sql.ToString());

        }

        public DataSet cj_ds(int cateid)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select * from help where _cateid=" + cateid + " order by _id desc limit 7");

            return DBHelperMySQL.Query(sql.ToString());
        }

        public DataSet selectAll(int cateid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select  * from help where _cateid=" + cateid + " order by _id desc limit 8");

            return DBHelperMySQL.Query(sql.ToString());

        }
    }
}
