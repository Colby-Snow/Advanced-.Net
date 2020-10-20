using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace CheapLoansWPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["LoansConnectionString"].ConnectionString);
            connectionString.Open();

            SqlCommand cmd = new SqlCommand("SelectAllProcedure", connectionString) { CommandType = System.Data.CommandType.StoredProcedure };
            
            cmd.ExecuteNonQuery();
            connectionString.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable("Loans");
            da.Fill(dataTable);

            LoansDisplayGrid.ItemsSource = dataTable.DefaultView;
            
        }
    }
}
