using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Model;

namespace MySqlDAL
{
    public class DALmessageDAL
    {
        public int post(message mes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into message(_title,_content,_ip) values(@title,@content,@ip)");

            MySqlParameter[] pra = { 
                               new MySqlParameter("@title",MySqlDbType.VarChar,50),
                               new MySqlParameter("@content",MySqlDbType.VarChar,250),
                               new MySqlParameter("@ip",MySqlDbType.VarChar,50)
                               };
            pra[0].Value = mes.title;
            pra[1].Value = mes.content;
            pra[2].Value = mes.ip;


            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);
        }

        public DataSet select(int pageindex, int pagesize, string table)
        {
            //StringBuilder sql = new StringBuilder();
            //sql.Append("select * from message where _state=" + 1 + "");
            //return DBHelperMySQL.Query(sql.ToString());

            string sql = "select * from message where _state=" + 1 + "";
            DataSet ds = DBHelperMySQL.PagedataSet(sql, pageindex, pagesize, table);
            return ds;

        }

        public DataSet messelect(int pageindex, int pagesize, string table, string title)
        {
            string sql = "select * from message where _title like '%" + title + "%'";
            DataSet ds = DBHelperMySQL.PagedataSet(sql, pageindex, pagesize, table);
            return ds;

        }

        public int mes_select(string title)
        {

            string sqlstr = "select count(*) from message where _title like '%" + title + "%' ";
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


        public int message_state()
        {
            string sqlstr = "select count(*) from message where _state=" + 1 + " ";
            object result =DBHelperMySQL.ExecuteScalar(sqlstr);
            if (result == null)
            {
                return 0;
            }
            else
            {
                return int.Parse(result.ToString());
            }
        }



        public DataSet h_select(int pageindex, int pagesize, string table)
        {
            string sql = "select * from message";
            DataSet ds = DBHelperMySQL.PagedataSet(sql, pageindex, pagesize, table);
            return ds;

        }

        public int messageCount()
        {
            string sqlstr = "select count(*) from message ";
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






        public int reply(message mes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update message set _reply=@reply,_state=@state where _id=@id");

            MySqlParameter[] pra = { 
                               new MySqlParameter("@reply",MySqlDbType.VarChar,200),
                               new MySqlParameter("@state",MySqlDbType.Int32),
                               new MySqlParameter("@id",MySqlDbType.Int32)
                               
                               };

            pra[0].Value = mes.reply;
            pra[1].Value = mes.state;
            pra[2].Value = mes.id;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);

        }

        public MySqlDataReader readmessage(message mes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from message where _id=@id");

            MySqlParameter[] pra = {                                 
                                 new MySqlParameter("@id",MySqlDbType.Int32)                                 
                                 };
            pra[0].Value = mes.id;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), pra);
        }


        public int delete(message mes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from message where _id=@id");

            MySqlParameter[] pra = { 
                               new MySqlParameter("@id",MySqlDbType.Int32)
                               };
            pra[0].Value = mes.id;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);

        }

        public int update(message mes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update message set _title=@title,_content=@content,_ip=@ip where _id=@id");

            MySqlParameter[] pra = { 
                               new MySqlParameter("@title",MySqlDbType.VarChar,50),
                               new MySqlParameter("@content",MySqlDbType.VarChar,250),
                               new MySqlParameter("@ip",MySqlDbType.VarChar,50),
                               new MySqlParameter("@id",MySqlDbType.Int32)
                               
                               };
            pra[0].Value = mes.title;
            pra[1].Value = mes.content;
            pra[2].Value = mes.ip;
            pra[3].Value = mes.id;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);
        }

        public int p_update(message mes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update message set _state=@state where _id=@id");

            MySqlParameter[] pra = { 
                                 
                                     new MySqlParameter("@state",MySqlDbType.Int32),
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            pra[0].Value = mes.state;
            pra[1].Value = mes.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), pra);
        }


    }
}
