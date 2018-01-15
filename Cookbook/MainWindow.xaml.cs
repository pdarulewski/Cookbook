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

namespace Cookbook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFindRecipeByIngredientsWindow(object sender, RoutedEventArgs e)
        {
            Console.Out.WriteLine("\"Find Recipe By Ingredients\" CLICKED!");
            FindRecipeByIngredientsWindow findRecipeByIngredientsWindow = new FindRecipeByIngredientsWindow();
            findRecipeByIngredientsWindow.Show();
        }

        private void OpenFindRecipeByTitleWindow(object sender, RoutedEventArgs e)
        {
            Console.Out.WriteLine("\"Find Recipe By Title\" CLICKED!");
            FindRecipeByTitleWindow findRecipeByTitleWindow = new FindRecipeByTitleWindow();
            findRecipeByTitleWindow.Show();
        }

        private void OpenAddRecipeWindow(object sender, RoutedEventArgs e)
        {
            Console.Out.WriteLine("\"Add new recipe\" CLICKED!");
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.Show();
        }
    }
}
