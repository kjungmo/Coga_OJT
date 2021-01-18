using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDynamicSize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { style = Style.Sneakers, color = "Black" });
            shoeCloset.Add(new Shoe() { style = Style.Clogs, color = "Brown" });
            shoeCloset.Add(new Shoe() { style = Style.Wingtips, color = "Black" });
            shoeCloset.Add(new Shoe() { style = Style.Loafers, color = "White" });
            shoeCloset.Add(new Shoe() { style = Style.Loafers, color = "Red" });
            shoeCloset.Add(new Shoe() { style = Style.Sneakers, color = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.style = Style.Flipflops;
                shoe.color = "Orange";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[3];
            Shoe firstShoe = shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if(shoeCloset.Contains(firstShoe))
                Console.WriteLine("That's surprising.");
        }
    }
}
