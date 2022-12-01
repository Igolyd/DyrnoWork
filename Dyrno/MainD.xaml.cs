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

namespace Dyrno
{
    /// <summary>
    /// Логика взаимодействия для MainD.xaml
    /// </summary>
    public partial class MainD : Page
    {
        public MainD()
        {
            InitializeComponent();
        }

        private void DetailGrid_Loaded(object sender, RoutedEventArgs e)
        {
            int a = 0;
            List<Detail> details = new List<Detail>(3);
            details.Add(new Detail("Иван", "Сидоров", 12,11,10,20,11));
            details.Add(new Detail("Джейк", "Мурков", 11,13,21,22,11));
            details.Add(new Detail("Равиль", "Задыров", 15,16,18,12,21));
            details.Add(new Detail("Ольга", "Лавра", 11,11,11,21,20));
            detailGrid.ItemsSource = details;
        }

        private void Total_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Detail
    {
        public Detail(string FirstN, string SecondN, int Mon, int Tue, int Web, int Thu, int Fri)
        {
            this.FirstName = FirstN;
            this.SecondName = SecondN;
            this.Mon = Mon;
            this.Tue = Tue;
            this.Wed = Web;
            this.Thu = Thu;
            this.Fri = Fri;

            TotalCount();
        }
        public void TotalCount()
        {
            this.Total = this.Mon + this.Tue + this.Wed + this.Thu + this.Fri;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Mon { get; set; }
        public int Tue { get; set; }

        public int Wed { get; set; }

        public int Thu { get; set; }
        public int Fri { get; set; }
        public int Total { get; set; }
    }
}
