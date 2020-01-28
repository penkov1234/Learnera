namespace Learnera.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Learnera.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Learnera.Models.ApplicationDbContext context)
        {

            //1007
            var pres = context.presentantions.Where(p => p.Id == 1007).FirstOrDefault();
            context.slides.AddOrUpdate(s => s.ImageUrl,
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/1.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/2.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/3.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/4.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/5.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/6.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/7.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/8.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/9.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P1/10.jpg", Presentation = pres }

            );

            //1008
            pres = context.presentantions.Where(p => p.Id == 1008).FirstOrDefault();
            context.slides.AddOrUpdate(s => s.ImageUrl,
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/1.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/2.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/3.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/4.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/5.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/6.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/7.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/8.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/9.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/10.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/11.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/12.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/13.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/14.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/15.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/16.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/17.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/18.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/19.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/20.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/21.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/22.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/23.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/24.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/25.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/26.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/27.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/28.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/29.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/30.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/31.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/32.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/33.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/34.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/35.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/36.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/37.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/38.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/39.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/40.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/41.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/42.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/43.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/44.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/45.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/46.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/47.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/48.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/49.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/50.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/51.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/52.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/53.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/54.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/55.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/56.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/57.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/58.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/59.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/60.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/61.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/62.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/63.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/64.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/65.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/66.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/67.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/68.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/P2/69.jpg", Presentation = pres }


            );


            //1009
            pres = context.presentantions.Where(p => p.Id == 1009).FirstOrDefault();
            context.slides.AddOrUpdate(s => s.ImageUrl,
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/1.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/2.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/3.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/4.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/5.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/6.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/7.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/8.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/9.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/10.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/11.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/12.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/13.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/14.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/15.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/16.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/17.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/18.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/19.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/20.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/21.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/22.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/23.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/24.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/25.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/26.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/27.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/28.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/29.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/30.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/31.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/32.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/33.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/34.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/35.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/36.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/37.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/38.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/39.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/40.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/41.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/42.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A1/43.jpg", Presentation = pres }


            );


            //1010
            pres = context.presentantions.Where(p => p.Id == 1010).FirstOrDefault();
            context.slides.AddOrUpdate(s => s.ImageUrl,
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/1.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/2.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/3.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/4.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/5.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/6.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/7.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/8.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/9.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/10.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/11.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/12.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/13.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/14.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/15.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/16.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/17.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/18.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/19.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/20.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/21.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/22.jpg", Presentation = pres },
                new Models.Slide { ImageUrl = "../../Content/Slides/IT/A2/23.jpg", Presentation = pres }


            );


        }
    }
}
