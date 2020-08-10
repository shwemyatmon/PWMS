using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context,ILoggerFactory loggerFactory){
            try{
                if(!context.Units.Any()){
                    var unitData = File.ReadAllText("../Infrastructure/Data/SeedData/Unit.json");
                    var units = JsonSerializer.Deserialize<List<Unit>>(unitData);

                    foreach(var item in units){
                        context.Units.Add(item);

                    }
                    await context.SaveChangesAsync();
                }

                 if(!context.Products.Any()){
                    var productData = File.ReadAllText("../Infrastructure/Data/SeedData/ProductList.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productData);

                    foreach(var item in products){
                        context.Products.Add(item);

                    }
                    await context.SaveChangesAsync();
                }

                if(!context.ProductPrices.Any()){
                    var productPriceData = File.ReadAllText("../Infrastructure/Data/SeedData/ProductPrice.json");
                    var productPrices = JsonSerializer.Deserialize<List<ProductPrice>>(productPriceData);

                    foreach(var item in productPrices){
                        context.ProductPrices.Add(item);

                    }
                    await context.SaveChangesAsync();
                }

            }
            catch(Exception ex){
                   var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                   logger.LogError(ex.Message);
            }
        }
        
    }
}