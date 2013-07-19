using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Encoder
{
    public partial class Form1 : Form
    {
        class EncodingVM
        {
            public Encoding Encoding{ get; set;}
            public string Name {get; set;}
        }
        public Form1()
        {
            InitializeComponent();
        }

        EncodingVM[] encodings;

        private void Form1_Load(object sender, EventArgs e)
        {
            encodings = new EncodingVM[]  {
                new EncodingVM { Encoding = Encoding.Default,  Name = "Default (Win-1251?)" },
                new EncodingVM { Encoding = Encoding.UTF8, Name  = "UTF-8" },
                new EncodingVM { Encoding = Encoding.Unicode, Name = "UTF-16"},
                new EncodingVM { Encoding = Encoding.GetEncoding(1251), Name = "Win-1251"},
                new EncodingVM { Encoding = Encoding.BigEndianUnicode, Name = "UTF-16 BE"}
                };

            sourceEncodingsCmbx.DataSource = encodings;
            encodedEncodingsCmbx.BindingContext = new System.Windows.Forms.BindingContext();
            encodedEncodingsCmbx.DataSource = encodings;
            sourceEncodingsCmbx.DisplayMember = encodedEncodingsCmbx.DisplayMember = "Name";
            sourceEncodingsCmbx.ValueMember = encodedEncodingsCmbx.ValueMember = "Encoding";
            //
            sourceDataTextBox.Text = 
                WebUtility.HtmlDecode(@"&#1056;&#1169;&#1057;&#1026;&#1057;&#1107;&#1056");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedEncoding = (Encoding) sourceEncodingsCmbx.SelectedValue;
            var targetEncoding = (Encoding) encodedEncodingsCmbx.SelectedValue;

            var bytes = selectedEncoding.GetBytes(sourceDataTextBox.Text);
            //показываем байты исходника
            sourceBytesTextBox.Text = bytesToStr(bytes);
                
            var resultBytes = Encoding.Convert(selectedEncoding, targetEncoding, bytes);
            encodedBytesTextBox.Text = bytesToStr(resultBytes);
            var resultString = targetEncoding.GetString(bytes);
            //отображаем результат
            encodedDataTextbox.Text = resultString;
        }

        string bytesToStr(byte[] bytes)
        {
            StringBuilder sb=  new StringBuilder();

            if( bytes.Length == 0)
                return "";

            sb.Append( bytes[0]);
            for (int i = 1; i < bytes.Length; i++)
            {
                sb.Append(" ");
                sb.Append(bytes[i]);
            }

            return sb.ToString();
        }
    }
}
