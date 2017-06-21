
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phones.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Models.PhonesContext(
                serviceProvider.GetRequiredService<DbContextOptions<Models.PhonesContext>>()))
            {
               
                foreach (var phone in context.Phone)
                {
                   context.Phone.Remove(phone);
                }
                context.SaveChanges();

                 if (context.Phone.Any())
                {
                    return;
                }

                context.Phone.AddRange(
                    new Models.Phone
                    {
                        Color = "Teal",
                        Model = "iPhone 5s",
                        Size = "6\"",
                        CameraPix = 3,
                        Mfg = "Apple",
                        Price = 29.99M,
                        OS = "iOS",
                        Condition = "Refurbished",
                        Release = DateTime.Parse("05/01/2010")
                    },
                    new Models.Phone
                    {
                        Color = "Black",
                        Model = "Galaxy 6",
                        Size = "7\"",
                        CameraPix = 5,
                        Mfg = "Samsung",
                        Price = 149.99M,
                        OS = "Android",
                        Condition = "new",
                        Release = DateTime.Parse("07/01/2012")
                    },
                    new Models.Phone
                    {
                        Color = "Black",
                        Model = "Galaxy",
                        Size = "7\"",
                        CameraPix=12,    
                        Mfg = "Samsung",
                        Price=9.99M,
                        OS = "Windows",
                        Condition="Exploded",
                        Release =DateTime.Parse("09/01/2015")
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
