using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace ConsultaSolicitudes.Libs
{
    static class Verifica
    {
        public static bool hayInternet(){
            Ping Pings = new Ping();
            int timeout = 5;

            try
            {
                if (Pings.Send("google.com", timeout).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                return false;                
            }
        }
    }
}
