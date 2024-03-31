using SOUKTCHAD.Models;

namespace SOUKTCHAD.Data
{
    public class AppDbSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScop = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScop.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //CINAMA
                if (!context.PRODUCTS.Any())
                {
                    context.PRODUCTS.AddRange(new List<PRODUCT>()
                    {
                        new PRODUCT
                        {
                            Name="VEST",
                            PhotoURL1="https://www.google.com/url?sa=i&url=https%3A%2F%2Fjacksonholeoriginals.com%2Fproduct%2Fms-original-down-vest%2F&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAE",
                            PhotoURL2="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.sa%2F-%2Fen%2FCOOFANDY-Casual-Business-Formal-Waistcoat%2Fdp%2FB076KD9Q1D&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAJ",
                            PhotoURL3="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.moncler.com%2Fen-us%2Fmen%2Fouterwear%2Fvests&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAU",
                            Price= 100,
                            Description="FOR MEN",
                            Sex="MEN",
                            CATIGORYID=1,
                        },
                        new PRODUCT
                        {
                            Name="VEST",
                            PhotoURL1="https://www.google.com/url?sa=i&url=https%3A%2F%2Fjacksonholeoriginals.com%2Fproduct%2Fms-original-down-vest%2F&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAE",
                            PhotoURL2="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.sa%2F-%2Fen%2FCOOFANDY-Casual-Business-Formal-Waistcoat%2Fdp%2FB076KD9Q1D&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAJ",
                            PhotoURL3="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.moncler.com%2Fen-us%2Fmen%2Fouterwear%2Fvests&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAU",
                            Price= 100,
                            Description="FOR MEN",
                            Sex="MEN",
                            CATIGORYID=2,
                        },
                        new PRODUCT
                        {
                            Name="VEST",
                            PhotoURL1="https://www.google.com/url?sa=i&url=https%3A%2F%2Fjacksonholeoriginals.com%2Fproduct%2Fms-original-down-vest%2F&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAE",
                            PhotoURL2="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.sa%2F-%2Fen%2FCOOFANDY-Casual-Business-Formal-Waistcoat%2Fdp%2FB076KD9Q1D&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAJ",
                            PhotoURL3="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.moncler.com%2Fen-us%2Fmen%2Fouterwear%2Fvests&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAU",
                            Price= 100,
                            Description="FOR MEN",
                            Sex="MEN",
                            CATIGORYID=3,
                        },
                        new PRODUCT
                        {
                            Name="VEST",
                            PhotoURL1="https://www.google.com/url?sa=i&url=https%3A%2F%2Fjacksonholeoriginals.com%2Fproduct%2Fms-original-down-vest%2F&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAE",
                            PhotoURL2="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.sa%2F-%2Fen%2FCOOFANDY-Casual-Business-Formal-Waistcoat%2Fdp%2FB076KD9Q1D&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAJ",
                            PhotoURL3="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.moncler.com%2Fen-us%2Fmen%2Fouterwear%2Fvests&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAU",
                            Price= 100,
                            Description="FOR MEN",
                            Sex="MEN",
                            CATIGORYID=4,
                        },
                        new PRODUCT
                        {
                            Name="VEST",
                            PhotoURL1="https://www.google.com/url?sa=i&url=https%3A%2F%2Fjacksonholeoriginals.com%2Fproduct%2Fms-original-down-vest%2F&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAE",
                            PhotoURL2="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.sa%2F-%2Fen%2FCOOFANDY-Casual-Business-Formal-Waistcoat%2Fdp%2FB076KD9Q1D&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAJ",
                            PhotoURL3="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.moncler.com%2Fen-us%2Fmen%2Fouterwear%2Fvests&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAU",
                            Price= 100,
                            Description="FOR MEN",
                            Sex="MEN",
                            CATIGORYID=6,
                        },
                        new PRODUCT
                        {
                            Name="VEST",
                            PhotoURL1="https://www.google.com/url?sa=i&url=https%3A%2F%2Fjacksonholeoriginals.com%2Fproduct%2Fms-original-down-vest%2F&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAE",
                            PhotoURL2="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.sa%2F-%2Fen%2FCOOFANDY-Casual-Business-Formal-Waistcoat%2Fdp%2FB076KD9Q1D&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAJ",
                            PhotoURL3="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.moncler.com%2Fen-us%2Fmen%2Fouterwear%2Fvests&psig=AOvVaw0eL5Rn-7t-JzC8_gtm8yqY&ust=1711992927311000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDf0eOEn4UDFQAAAAAdAAAAABAU",
                            Price= 100,
                            Description="FOR MEN",
                            Sex="MEN",
                            CATIGORYID=5,
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.CATIGORYS.Any())
                {
                    context.CATIGORYS.AddRange(new List<CATIGORY>()
                    {
                        new CATIGORY
                        {
                            Name="ABAYA"
                        },
                        new CATIGORY
                        {
                            Name="T-SHIRT"
                        },
                        new CATIGORY
                        {
                            Name="D'JALABIYA"
                        },
                        new CATIGORY
                        {
                            Name="SHADDAH"
                        },
                        new CATIGORY
                        {
                            Name="LAFFAH"
                        },
                        new CATIGORY
                        {
                            Name="TARHA"
                        },
                        new CATIGORY
                        {
                            Name="TAGIYA"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
