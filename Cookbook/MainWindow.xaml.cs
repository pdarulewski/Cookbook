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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CookbookDao dao = new CookbookDao();
            List<Recipe> list = new List<Recipe>();
            list = dao.GetAllRecipes();
            InitializeComponent();
        }

        private void OpenFindRecipeByIngredientsWindow(object sender, RoutedEventArgs e)
        {
            FindRecipeByIngredientsWindow findRecipeByIngredientsWindow = new FindRecipeByIngredientsWindow();
            findRecipeByIngredientsWindow.Show();
        }

        private void OpenFindRecipeByTitleWindow(object sender, RoutedEventArgs e)
        {
            FindRecipeByTitleWindow findRecipeByTitleWindow = new FindRecipeByTitleWindow();
            findRecipeByTitleWindow.Show();
        }

        private void OpenAddRecipeWindow(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.Show();
        }
    }
}
