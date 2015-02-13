using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySqlDAL
{
    public class tisDAL
    {
        public void msg(System.Web.UI.Page page, string msg)
        {
            Common.MessageAlert.Alert(page, msg);
        }
    }
}
