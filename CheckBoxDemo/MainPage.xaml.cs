using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace CheckBoxDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnItalic(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Italic;
            }
        }
        void OnBold(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Bold;
            }
        }
        void OnUnderline(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.TextDecorations |= TextDecorations.Underline;
            }
            else
            {
                label.TextDecorations &= ~TextDecorations.Underline;
            }
        }
        void OnStrikethrough(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.TextDecorations |= TextDecorations.Strikethrough;
            }
            else
            {
                label.TextDecorations &= ~TextDecorations.Strikethrough;
            }
        }
    }
}
