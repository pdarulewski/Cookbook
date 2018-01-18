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
    /// <summary>
    /// Interaction logic for RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        //public string title;
        //public string description;
        //public string ingredients;
        //public int portions;
        //public int time;
        //public int difficulty;
        //public string preparation;

        public RecipeWindow(string title, string description, string ingredients, int portions, int time, int difficulty, string preparation)
        {
            InitializeComponent();
            Title.Text = title;
            Ingredients.Text = ingredients;
            PortionsTimeDifficulty.Text = "Portions: " + portions + Environment.NewLine + "Time: " + time + Environment.NewLine + "Difficulty: " + difficulty;
            Description.Text = description;
            PreparationText.Text = preparation;
            
        }
    }
}
