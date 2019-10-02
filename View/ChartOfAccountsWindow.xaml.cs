using EisDatabase.Api;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Unity;

namespace EisView
{
    /// <summary>
    /// Логика взаимодействия для ChartOfAccountsWindow.xaml
    /// </summary>
    public partial class ChartOfAccountsWindow : Window
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        private readonly IChartOfAccountsRepository ChartOfAccountsRepository;

        public ChartOfAccountsWindow(IChartOfAccountsRepository chartOfAccountsRepository)
        {
            InitializeComponent();

            ChartOfAccountsRepository = chartOfAccountsRepository;
        }

        public void LoadDataGrid()
        {
            dataGrid.ItemsSource = ChartOfAccountsRepository.GetAll();
            dataGrid.AutoGeneratingColumn += DataGridAnswers_AutoGeneratingColumn;
        }

        private void DataGridAnswers_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Id":
                    e.Column.Header = "Id";
                    break;

                case "Number":
                    e.Column.Header = "Номер счета";
                    break;

                case "Name":
                    e.Column.Header = "Название";
                    break;

                case "SubcontoOne":
                    e.Column.Header = "Номер субконто 1";
                    break;

                case "SubcontoTwo":
                    e.Column.Header = "Номер субконто 2";
                    break;

                case "SubcontoThree":
                    e.Column.Header = "Номер субконто 3";
                    break;
            }
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = Container.Resolve<MainWindow>();
            window.Show();
            Close();
        }
    }
}
