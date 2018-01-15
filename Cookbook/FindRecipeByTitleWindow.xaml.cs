using System;
using System.Collections;
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

namespace Cookbook
{
    public partial class FindRecipeByTitleWindow : Window
    {
        public FindRecipeByTitleWindow()
        {
            InitializeComponent();
        }

        private void SearchByTitle(object sender, RoutedEventArgs e)
        {
            Console.Out.WriteLine("\"SEARCH\" CLICKED!");

            string input = SearchBox.Text;
            Console.Out.WriteLine("user input: " + input);

            // Zamiast new ArrayList trzeba wyszukać listę przepisów zawierających input w tytule
            ArrayList NewRecipes = new ArrayList();
            NewRecipes.Add("Znaleziony przepis " + input);
            NewRecipes.Add("Znaleziony drugi przepis " + input);
            NewRecipes.Add("Znaleziony trzeci przepis " + input);
            RecipesList.ItemsSource = NewRecipes; 
        }
}
}
