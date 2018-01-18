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
        static Filter filter;

        public FindRecipeByTitleWindow()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void SearchByTitle(object sender, RoutedEventArgs e)
        {
            string input = SearchBox.Text;
            ArrayList NewRecipes = new ArrayList(filter.findRecipeByTitle(input));
            RecipesList.ItemsSource = NewRecipes; 
        }

        private void OpenRecipeWindow(object sender, RoutedEventArgs e)
        {
            ListViewItem Item = (ListViewItem)sender;
            string RecipeTitle = (String)Item.Content;
            // First (and only) recipe with the clicked title
            Recipe r = (filter.findRecipeByTitle(RecipeTitle))[0];

            List<Ingredient> listIngredients = r.Ingredients;
            String ingredientsString = "";
            foreach (Ingredient i in listIngredients)
            {
                ingredientsString += (i + Environment.NewLine);
            }
            RecipeWindow rw = new RecipeWindow(r.Title, r.Description, ingredientsString, r.Portions, r.CookingTime.Hours, r.Difficulty, r.Text);
            rw.Show();
        }
}
}
