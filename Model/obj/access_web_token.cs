using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maticsoft.Model
{
    public class access_web_token
    {
        public access_web_token()
		{}
		#region Model

        private string _access_token;
        private string _expires_in;
        private string _refresh_token;
        private string _openid;
        private string _scope;

        public string access_token
        {
            set { _access_token = value; }
            get { return _access_token; }
        }

        public string expires_in
        {
            set { _expires_in = value; }
            get { return _expires_in; }
        }

        public string refresh_token
        {
            set { _refresh_token = value; }
            get { return _refresh_token; }
        }

        public string openid
        {
            set { _openid = value; }
            get { return _openid; }
        }

        public string scope
        {
            set { _scope = value; }
            get { return _scope; }
        }
		
		#endregion Model
    }
}
