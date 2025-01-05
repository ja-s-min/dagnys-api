using System.Text.Json;
using dagnys_api.Entities;

namespace dagnys_api.Data;

        public static class Seed
        {
    
            public static async Task LoadProducts(DataContext context)
            {
            var options = new JsonSerializerOptions{
                PropertyNameCaseInsensitive = true
            };

            if(context.Products.Any()) return;

            var json = File.ReadAllText("Data/json/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json, options);

            if(products is not null && products.Count > 0){
                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }
        }


          public static async Task LoadSupplier(DataContext context)
            {
            var options = new JsonSerializerOptions{
                PropertyNameCaseInsensitive = true
            };

            if(context.Suppliers.Any()) return;

            var json = File.ReadAllText("Data/json/suppliers.json");
            var suppliers = JsonSerializer.Deserialize<List<Supplier>>(json, options);

            if(suppliers is not null && suppliers.Count > 0){
                await context.Suppliers.AddRangeAsync(suppliers);
                await context.SaveChangesAsync();
            }
        }

         public static async Task LoadRecipe(DataContext context)
            {
            var options = new JsonSerializerOptions{
                PropertyNameCaseInsensitive = true
            };

            if(context.Recipes.Any()) return;

            var json = File.ReadAllText("Data/json/recipes.json");
            var recipes = JsonSerializer.Deserialize<List<Recipe>>(json, options);

            if(recipes is not null && recipes.Count > 0){
                await context.Recipes.AddRangeAsync(recipes);
                await context.SaveChangesAsync();
            }
        }
    }
    
