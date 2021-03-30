using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Currency_Converter
{
    class Currency_List
    {
        public Dictionary<string, CurrencyData> results;
        public CurrencyData get_Currency_By_ID(string id)
        {
            return results[id];
        }
        public CurrencyData get_Currency_By_Index(int index)
        {
            return results.ElementAt(index).Value;
        }
        public CurrencyData[] ToArray()
        {
            return results.Values.ToArray();
        }
        public static Currency_List Deserialize(string data)
        {
            return JsonConvert.DeserializeObject<Currency_List>(data);
        }
    }
    class CurrencyData
    {
        public string currencyName;
        public string currencySymbol;
        public string id;
    }
}
