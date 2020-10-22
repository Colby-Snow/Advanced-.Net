using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CheapLoansDisplay
{
    /// <summary>
    /// Interaction logic for DisplayLoans.xaml
    /// </summary>
    public partial class DisplayLoans : Page
    {
        public DisplayLoans()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string jsonData;


            //instantiate a proxy object in order to expose methods
            localhost.LoanService myService = new localhost.LoanService();

            if (String.IsNullOrEmpty(NameTB.Text))
            {
                jsonData = myService.GetAllLoans();
            }
            else
            {
                jsonData = myService.GetLoanByCustomer(NameTB.Text);
            }

            //clear data grid
            LoansDisplayGrid.DataContext = null;

            //make sure json data had customers before attempting to build data grid
            if (!jsonData.Contains("No such customer") && !jsonData.Contains("Table empty"))
            {
                //convert Json formatted data so it can be displayed in data grid,
                //then assign to data grid
                var result = JsonConvert.DeserializeObject<List<LoansModel>>(jsonData);

                LoansDisplayGrid.ItemsSource = result;
            }
        }
    }
}
