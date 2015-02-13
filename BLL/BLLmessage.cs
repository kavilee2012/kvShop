using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
    public class BLLmessage
    {
        public int post(message mes)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.post(mes);
        }

        public DataSet select(int pageindex, int pagesize, string table)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.select(pageindex ,pagesize,table);
        }

        public DataSet messelect(int pageindex, int pagesize, string table, string title)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.messelect(pageindex, pagesize, table,title);
        
        }


        public int mes_select(string title)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.mes_select(title);
        }


        public int message_state()
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.message_state();
        }





        public DataSet h_select(int pageindex, int pagesize, string table)
        {

            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.h_select(pageindex, pagesize, table);

        }

        public int messageCount()
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.messageCount();
        }



        public int reply(message mes)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.reply(mes);
        }

        public MySqlDataReader readmessage(message mes)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.readmessage(mes);
        }

        public int delete(message mes)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.delete(mes);
        }

        public int update(message mes)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.update(mes);

        }

        public int p_update(message mes)
        {
            DALmessageDAL DALmessageDAL = new DALmessageDAL();
            return DALmessageDAL.p_update(mes);
        
        }
    }
}
