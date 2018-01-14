using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Cookbook
{
    class CookbookDao
    {
        SqlConnection connection;
        string CookbookConnectionString;

        public CookbookDao()
        {
            CookbookConnectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;
            using (connection = new SqlConnection(CookbookConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELEC * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);
            }
                

        }

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            return recipes;
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
