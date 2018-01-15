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

        public FindRecipeByIngredientsWindow()
        {
            InitializeComponent();
            InputIngredients = new ArrayList();
            ingredients = "";
            sb = new StringBuilder();
            sb.Append("Chosen ingredients: ");
        }

        public void SearchByIngredients(object sender, RoutedEventArgs e)
        {
            // Zamiast new ArrayList trzeba wyszukać listę przepisów zawierających składniki z InputIngredients
            ArrayList NewRecipes = new ArrayList();
            string ingr = sb.ToString();
            ingr = ingr.Substring(20);
            NewRecipes.Add("Znaleziony przepis z " + ingr);
            NewRecipes.Add("Znaleziony drugi przepis z " + ingr);
            NewRecipes.Add("Znaleziony trzeci przepis z " + ingr);
            listBox.ItemsSource = NewRecipes; 
        }

        public void AddIngredient(object sender, RoutedEventArgs e)
        {
            string input = TextBox.Text;
            sb.Append(input).Append(", ");
            ingredients = sb.ToString();
            IngredientsString.Content = sb.ToString();
        }

        public void RemoveIngredient(object sender, RoutedEventArgs e)
        {
            string input = TextBox.Text;
            int ind = ingredients.IndexOf(input);
            sb.Remove(ind, input.Length+2);
            ingredients = sb.ToString();
            IngredientsString.Content = sb.ToString();
        }
    }
}
