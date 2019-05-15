using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_ControleXF.Model;

namespace App_ControleXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.ActivityIndicatorPage());
            IsPresented = false;
        }
        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.ProgressBarPage());
            IsPresented = false;
        }
        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.BoxViewPage());
            IsPresented = false;
        }
        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.LabelPage());
            IsPresented = false;
        }
        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.ButtonPage());
            IsPresented = false;
        }
        private void GoEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.EntryEditorPage());
            IsPresented = false;
        }
        private void GoDatePickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.DatePickerPage());
            IsPresented = false;
        }
        private void GoTimePickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.TimePickerPage());
            IsPresented = false;
        }
        private void GoPickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.PickerPage());
            IsPresented = false;
        }
        private void GoSearchBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.SearchBarPage());
            IsPresented = false;
        }
        private void GoSliderStepperBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.SliderStepperPage());
            IsPresented = false;
        }
        private void GoSwitchPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.SwitchPage());
            IsPresented = false;
        }
        private void GoImagePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.ImagePage());
            IsPresented = false;
        }
        private void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.ListViewPage());
            IsPresented = false;
        }
        private void GoTableViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.TableViewPage());
            IsPresented = false;
        }
        private void GoWebViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Model.WebViewPage());
            IsPresented = false;
        }
    }
}