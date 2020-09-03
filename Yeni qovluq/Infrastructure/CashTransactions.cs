using BeinPos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Infrastructure
{
    class CashTransactions : ICashTransactions
    {
        public string Server = "https://pos.bein.az/";

        public Cash Get(string token)
        {
            try
            {
                using (var client = new WebClient())
                {

                    var values = new NameValueCollection();
                    client.Headers.Add("Token", token);


                    var response = client.UploadValues(Server + "getcash.php", values);
                    var responseString = Encoding.Default.GetString(response);

                    var result = JsonConvert.DeserializeObject<ResponseCash>(responseString);


                    if (result.Headers.ResponseStatus != "0")
                    {
                        return null;
                    }

                    return result.Body;

                }

            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}
