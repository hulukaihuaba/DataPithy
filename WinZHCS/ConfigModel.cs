using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinZHCS.Model
{
    public class ConfigModel
    {
        static ConfigModel config;
        public static ConfigModel Config
        {
            get
            {
                Load();
                return config;
            }
        }

        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }


        private static ConfigModel Load()
        {
            if (config == null)
            {
                string json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Config\\config");
                config = JsonConvert.DeserializeObject<ConfigModel>(json);
            }
            return config;
        }
        public static bool Save(ConfigModel config)
        {
            try
            {
                ConfigModel.config = config;
                string json = JsonConvert.SerializeObject(ConfigModel.config);
                StreamWriter streamWriter = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "Config\\config");
                streamWriter.Write(json);
                streamWriter.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
