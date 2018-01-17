using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Cookbook
{
    class CookbookDao
    {
        string CookbookConnectionString;

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipeList = new List<Recipe>();

            CookbookConnectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(CookbookConnectionString))
            {
                string oString = "SELECT * FROM Recipe";
                SqlCommand cmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    
                    while (oReader.Read())
                    {
                      // (string Title, string Description,
                      // string Text, List<Ingredient> Ingredients, int Portions,
                      // TimeSpan CookingTime, Image Image, int Difficulty,
                      // string Events, string Category, string Type)
                        List<Ingredient> ingredientsList = new List<Ingredient>();
                        string ingredients = oReader["Ingredient"].ToString();
                        string[] tokens = ingredients.Split(new[] { ", " }, StringSplitOptions.None);
                        foreach(string token in tokens)
                        {
                            ingredientsList.Add(new Ingredient(token));
                        }
                        Image img = null;
                        recipeList.Add(new Recipe(oReader["Title"].ToString(), oReader["Description"].ToString(),
                            oReader["Text"].ToString(), ingredientsList, Int32.Parse(oReader["Portions"].ToString()),
                            (TimeSpan)oReader["CookingTime"], img, Int32.Parse(oReader["Difficulty"].ToString()),
                            oReader["Event"].ToString(), oReader["Category"].ToString(), oReader["Type"].ToString()));
                    }
                    myConnection.Close();
                }
            }
            Console.WriteLine(recipeList);
            return recipeList;
        }

        public bool AddRecipe(Recipe recipe)
        {
            return true;
        }

        public bool UpdateRecipe(Recipe recipe)
        {
            return true;
        }

        public bool RemoveRecipe(Recipe recipe)
        {
            return true;
        }


    }
}
