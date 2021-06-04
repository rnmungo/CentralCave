using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.CentralCave.Services
{
    public sealed class LanguageManager
    {
        #region Singleton
        private readonly static LanguageManager _instance = new LanguageManager();

        public static LanguageManager Current
        {
            get
            {
                return _instance;
            }
        }

        private LanguageManager() { }
        #endregion

        public string Translate(string key)
        {
            string word = key;
            string cultureCode = Thread.CurrentThread.CurrentUICulture.Name;

            using (StreamReader streamReader = new StreamReader(string.Format(@"I18n\idioma.{0}", cultureCode)))
            {
                while (!streamReader.EndOfStream)
                {
                    string linea = streamReader.ReadLine();
                    string[] keyValuePair = linea.Split(':');

                    if (keyValuePair[0].ToLower() == key.ToLower())
                    {
                        word = keyValuePair[1];
                        break;
                    }
                }
            }

            return word;
        }
    }
}
