using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(
                    new Pie
                    {
                        Name = "Apple Pie",
                        Price = 12.95M,
                        ShortDescription = "Our famous apple pies!",
                        LongDescription = "Icing carrot cake jelly-o cheesecake."
                    },
                     new Pie
                     {
                         Name = "Blueberry Cheese Cake",
                         Price = 18.95M,
                         ShortDescription = "You'll love it!",
                         LongDescription = "Icing carrot cake jelly-o cheesecake."
                     },
                      new Pie
                      {
                          Name = "Cheese Cake",
                          Price = 18.95M,
                          ShortDescription = "Plain cheese cake. Plain pleasure.",
                          LongDescription = "Icing carrot cake jelly-o cheesecake."
                      },
                       new Pie
                       {
                           Name = "Cherry Pie",
                           Price = 15.95M,
                           ShortDescription = "A summer classic!",
                           LongDescription = "Icing carrot cake jelly-o cheesecake."
                       },
                        new Pie
                        {
                            Name = "Christmas Apple Pie",
                            Price = 13.95M,
                            ShortDescription = "Happy holidays with this pie!",
                            LongDescription = "Icing carrot cake jelly-o cheesecake."
                        },
                        new Pie
                        {
                            Name = "Cranberry Pie",
                            Price = 17.95M,
                            ShortDescription = "A Christmas favorite",
                            LongDescription = "Icing carrot cake jelly-o cheesecake. "
                        },
                        new Pie
                        {
                            Name = "Peach Pie",
                            Price = 15.95M,
                            ShortDescription = "Sweet as peach",
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll."
                        },
                        new Pie
                        {
                            Name = "Pumpkin Pie",
                            Price = 12.95M,
                            ShortDescription = "Our Halloween favorite",
                            LongDescription = "Icing carrot cake jelly-o cheesecake."
                        },
                        new Pie
                        {
                            Name = "Rhubarb Pie",
                            Price = 15.95M,
                            ShortDescription = "My God, so sweet!",
                            LongDescription = "Icing carrot cake jelly-o cheesecake. "
                        },
                        new Pie
                        {
                            Name = "Strawberry Pie",
                            Price = 15.95M,
                            ShortDescription = "Our delicious strawberry pie!",
                            LongDescription = "Icing carrot cake jelly-o cheesecake."
                        }


                    );
            }
            context.SaveChanges();

        }
    }
}

