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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LNew.DataBase;

namespace LNew.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public List<Product> prod { get; set; }
        public List<ProductType> types { get; set; }
        public List<Sorting> sortings { get; set; }
        public MainPage()
        {
            InitializeComponent();
            prod = BdConnection.connection.Product.ToList();
            types =BdConnection.connection.ProductType.ToList();
            types.Insert(0, new ProductType {  Id = 0, Name = "Все типы"});
            cbFiltr.ItemsSource = types;
            cbFiltr.DisplayMemberPath = "Name";

            sortings = new List<Sorting>()
            {
                new Sorting() {Id=0, Name ="Пусто"},
                new Sorting() {Id=1, Name="Минимальная стоимость по убыванию"},
                new Sorting() {Id=2, Name="Минимальная стоимость апо возростанию"},
                new Sorting() {Id=3, Name="Наименование по убыванию"},
                new Sorting() {Id=4, Name="Наименование по возростанию"},
                new Sorting() {Id=5, Name="Номер цеха по убыванию"},
                new Sorting() {Id=6, Name="Номер цеха по возростанию"},
            };

            cbSort.ItemsSource = sortings;
            cbSort.DisplayMemberPath = "Name";
            this.DataContext = this;
        }

        private void lvProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public class Sorting
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void btnADD_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
