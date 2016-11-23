using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using System.Net.Http;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace FUCKMS
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {


            //using (HttpClient client = new HttpClient())
            //{

            //    var kvp = new List<KeyValuePair<string, string>>
            //        {
            //    new KeyValuePair<string,string>("userName", "2014012590"),
            //    new KeyValuePair<string,string>("userPwd", "MDcyNDE5"),
            //    new KeyValuePair<string,string>("serviceTypeHIDE", ""),
            //    new KeyValuePair<string,string>("serviceType", ""),
            //    new KeyValuePair<string,string>("userurl", ""),
            //    new KeyValuePair<string,string>("userip", ""),
            //    new KeyValuePair<string,string>("basip", ""),
            //    new KeyValuePair<string,string>("language", "Chinese"),
            //    new KeyValuePair<string,string>("usermac", "null"),
            //    new KeyValuePair<string,string>("wlannasid", ""),
            //    new KeyValuePair<string,string>("wlanssid", ""),
            //    new KeyValuePair<string, string>("entrance", "null"),
            //    new KeyValuePair<string, string>("loginVerifyCode", ""),
            //    new KeyValuePair<string, string>("userDynamicPwddd", ""),
            //    new KeyValuePair<string, string>("customPageId", "100"),
            //    new KeyValuePair<string, string>("pwdMode", "0"),
            //    new KeyValuePair<string, string>("portalProxyIP", "219.245.192.20"),
            //    new KeyValuePair<string, string>("portalProxyPort", "50200"),
            //    new KeyValuePair<string, string>("dcPwdNeedEncrypt", "1"),
            //    new KeyValuePair<string, string>("assignIpType", "0"),
            //    new KeyValuePair<string, string>("appRootUrl", "http%3A%2F%2F219.245.192.20%3A8080%2Fportal%2F"),
            //    new KeyValuePair<string, string>("manualUrl", ""),
            //    new KeyValuePair<string, string>("manualUrlEncryptKey", "")
            //        };
            //    Uri url = new Uri("http://219.245.192.20:8080/portal/pws?t=li");

            //}
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            string plainstring = input.Text;
            UWPencode en = new UWPencode(plainstring);
            output.Text = en.en();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            string plainstring = input.Text;
            UWPencode en = new UWPencode(plainstring);
            if (time.Text != "")
                output.Text = en.de(time.Text);
        }
    }
}
