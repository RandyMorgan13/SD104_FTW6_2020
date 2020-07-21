using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Lab11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            SakilaContext sakila = new SakilaContext();
            Film war1917 = new Film("1917", "2019 War Drama By Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
            Film joker = new Film("Joker", "Oscar-Nominated SuperHero Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
            Film starwars = new Film("Star Wars: The Rise of SkyWalker", "Ruin Your Childhood in 3 hours", "2019", 3, 4.99m, 202, 21.99m, "PG-13");

            sakila.Film.Add(war1917);  
            sakila.Film.Add(joker);  
            sakila.Film.Add(starwars); 
            sakila.SaveChanges();

            Film[] allfilms = sakila.Film.ToArray();
          
            var newfilms = allfilms.Where(x => x.release_year == "2019");

            StringBuilder html = new StringBuilder();
            html.Append("<html>\n");
            html.Append("<head>");
            html.Append("<title>Sakila New Films</title>\n");
            html.Append("</head>\n");
            html.Append("<body\n");
            html.Append("<h1> New Films Coming to a Theater near You!</h1>\n");
            html.Append("<ul>\n");
            foreach (var film in newfilms)
            {
            html.Append("<li>");
            html.Append(film.title + " " + film.description);
            html.Append("</li>");
            }

            html.Append("</ul>\n");
            html.Append("</body>\n");
            html.Append("</html>\n");

            string htmlFile = "C:\\output\\newfilms.html";
            File.WriteAllText(htmlFile, html.ToString());
        }
    }
}