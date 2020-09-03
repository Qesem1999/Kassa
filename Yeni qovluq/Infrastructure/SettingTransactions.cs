using BeinPos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Infrastructure
{
    class SettingTransactions : ISettingTransactions
    {
        public Settings Get()
        {
            string line, json = "";
            StreamReader file = new StreamReader(@"settings.json");

            while ((line = file.ReadLine()) != null)
            {
                json += line;
            }
            file.Close();
            Settings set = JsonConvert.DeserializeObject<Settings>(json);

            return set;
            
        }

        public void Set(Settings setting)
        {
            try
            {
                File.Delete(@"settings.json");
                File.AppendAllText(@"settings.json", JsonConvert.SerializeObject(setting));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
