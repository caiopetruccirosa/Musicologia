using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class UserIP
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public IPAddress IP { get; private set; }

        public UserIP(int id, string username, string ip)
        {
            if (username == null || username.Trim() == "")
                throw new Exception("Username nulo");

            if (ip == null || ip.Trim() == "")
                throw new Exception("IP nulo");

            if (IPAddress.TryParse(ip, out IPAddress address))
                this.IP = address;
            else
                throw new Exception("IP invalido");

            this.Id = id;
            this.Username = username;
        }
    }
}
