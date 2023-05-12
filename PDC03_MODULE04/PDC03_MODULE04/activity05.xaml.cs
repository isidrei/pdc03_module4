using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;


        public activity05()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null) 
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }


        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name = "Stephanie Basilio",
                Age = 31,
                Occupation="Mananangal",
                Country="Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Frankie Capuno",
                Age = 27,
                Occupation = "Grilled Balut Vendor",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Isidrei Musni",
                Age = 99,
                Occupation = "Drug lord",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Berto Batumbakal",
                Age = 45,
                Occupation = "Kaldag King",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Jobert Dela Cruz",
                Age = 51,
                Occupation = "Prayer Leader",
                Country = "Philippines"
            });
        }
    }
}