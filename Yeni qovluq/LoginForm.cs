using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeinPos.Application.Models;


namespace BeinPos
{
    public partial class LoginForm : Form
    {
        public string Server;
        public string Token;
        public LoginForm(string server)
        {
            Server = server;
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (var client = new WebClient())
                {

                    var values = new NameValueCollection();
                    values["login"] = "satici@bein";
                    values["password"] = "010203";

                    var response = client.UploadValues(Server + "login.php", values);
                    var responseString = Encoding.Default.GetString(response);

                    var result = JsonConvert.DeserializeObject<ResponseLogin>(responseString);


                    if (result.Headers.ResponseStatus != "0")
                    {
                        return;
                    }

                    Token =  result.Body;

                }

            }
            catch (Exception)
            {
                return;
            }
        }

       
    }

    class ResponseLogin
    {
        public Header Headers { get; set; }
        public string Body { get; set; }
    }
}
