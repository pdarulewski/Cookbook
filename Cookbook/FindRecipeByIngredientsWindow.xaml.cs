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
    public partial class FindRecipeByIngredientsWindow : Window
    {
        static ArrayList InputIngredients;
        static string ingredients;
        static StringBuilder sb;
        static Filter filter;

        public FindRecipeByIngredientsWindow()
        {
            InitializeComponent();
            filter = new Filter();
            InputIngredients = new ArrayList();
            ingredients = "";
            sb = new StringBuilder();
            sb.Append("Chosen keywords: ");
        }

        public void SearchByIngredients(object sender, RoutedEventArgs e)
        {
            List<string> listToFilter = new List<string>();
            foreach (string s in InputIngredients)
                {
                    listToFilter.Add(s);
                }
            
            ArrayList NewRecipes = new ArrayList(filter.findRecipeByTag(listToFilter));
            listBox.ItemsSource = NewRecipes; 
        }

        public void AddIngredient(object sender, RoutedEventArgs e)
        {
            string input = TextBox.Text;

            int listIndex = InputIngredients.IndexOf(input);
            if (listIndex < 0)
            {
                InputIngredients.Add(input);

                sb.Append(input).Append(", ");
                ingredients = sb.ToString();
            }
            IngredientsString.Content = sb.ToString();
        }

        public void RemoveIngredient(object sender, RoutedEventArgs e)
        {
            string input = TextBox.Text;

            int listIndex = InputIngredients.IndexOf(input);
            //if ingredient exists
            if (listIndex >= 0)
            {
                InputIngredients.RemoveAt(listIndex);

                int ind = ingredients.IndexOf(input);
                sb.Remove(ind, input.Length + 2);
                ingredients = sb.ToString();
            }
            IngredientsString.Content = sb.ToString();
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
