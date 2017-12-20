using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleBook01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookPage : ContentPage
	{
		public BookPage ()
		{
			InitializeComponent ();

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            this.listView.ItemsSource = Enumerable.Range(0, 100).Select(n => $"aaa");
        }
	}
}