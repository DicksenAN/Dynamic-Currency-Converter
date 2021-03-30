using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Live_Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currency_List();
        }

        private void currency_List()
        {
            API_Requester Currency_List_Request = new API_Requester("https://free.currconv.com/api/v7/currencies?apiKey=30a5d63eb394342ec55e");
            Currency_List currency_List = Currency_List.Deserialize(Currency_List_Request.Response_Sender_Getter());

            CurrencyData[] datas = currency_List.ToArray();
            foreach (CurrencyData currency in datas)
            {
                FromComboBox.Items.Add(currency.id);
                ToComboBox.Items.Add(currency.id);
            }
        }

        public static double Exchange(string from, string to, string date)
        {
            string url;
            url = "https://free.currencyconverterapi.com/api/v6/" 
                + "convert?q=" + from + "_" + to + "&compact=y&date="
                + date + "&apiKey=30a5d63eb394342ec55e";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            string jsonString;
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return JObject.Parse(jsonString).First.First["val"].First.ToObject<double>();
        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                ConvertedAmountLabel.Text = "Converted Amount : PLEASE INSERT AN AMOUNT";
                
            }
            else
            {
                if(string.IsNullOrEmpty(FromComboBox.Text) || string.IsNullOrEmpty(ToComboBox.Text))
                {
                    ConvertedAmountLabel.Text = "Converted Amount : PLEASE CHOOSE THE TO AND FROM CURRENCY";
                }
                else
                {
                    double amount = Convert.ToDouble(textBox1.Text);
                    double exchange_rate = Exchange(FromComboBox.Text, 
                        ToComboBox.Text, dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    amount = amount * exchange_rate;

                    ConvertedAmountLabel.Text = "Converted Amount : " + Convert.ToString(amount);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertedAmountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
