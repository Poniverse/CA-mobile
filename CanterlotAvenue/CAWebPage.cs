using System;
using Xamarin.Forms;

namespace CanterlotAvenue
{
    public class CAWebPage : ContentPage
    {
        public CAWebPage()
        {
            Label header = new Label
            {
                Text = "Canterlot Avenue",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://development.canterlotavenue.com/login/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView
                }
            };
        }
    }
}