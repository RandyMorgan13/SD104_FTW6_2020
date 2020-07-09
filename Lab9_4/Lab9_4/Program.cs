using System;
using System.IO;
using System.Text;

namespace Lab9_4
    { 
    class Heading
    {
            string open = "<h1>";
            string close = "</h1>";
            public string CreateHeading(string text)
            {
            string heading = string.Concat(open, text, close, "");
            return heading;
            }
    }

    class UnorderedList
    {
            string open = "<ul>";
            string close = "</ul>";

            public string CreateListItem(string text)
            {
            string open = "<li>";
            string close = "</li>";
            string listItem = string.Concat(open, text, close,"");
            return listItem;
            }
            public StringBuilder CreateList(string[] listItems)
            {
            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
            sb.Append(item);
            }
            sb.Append(close);
            return sb;
            }

    }

    class Program
    {
            static void Main(string[] args)
            {
            string filename = "C://weblogs//9_4Lab.html";
            Heading heading = new Heading();
            UnorderedList list = new UnorderedList();
            StringBuilder SB = new StringBuilder();
            Console.WriteLine("Enter your heading here please");
            string headerElement = heading.CreateHeading(Console.ReadLine());
            string[] listItems = new string[3];
            for (int i = 0; i < listItems.Length; i++)
            {
            Console.WriteLine("Alright, Now add 1 of 3 list elements");
            listItems[i] = list.CreateListItem(Console.ReadLine());
            }
            StringBuilder listElement = list.CreateList(listItems);
            SB.Append(headerElement);
            SB.Append(listElement.ToString());
            File.AppendAllText(filename, SB.ToString());
        }
    }
}

