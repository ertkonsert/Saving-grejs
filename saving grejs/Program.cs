using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace saving_grejs
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your stats yo we're playing dnd.");
            Character myChar = new Character();
            
            System.Console.WriteLine("What's your strength?");
            string str = Console.ReadLine();
            bool convert = int.TryParse(str, out myChar.str);
            while(convert == false || myChar.str > 20 || myChar.str < 10)
            {
                System.Console.WriteLine("Nah man it's gotta be a number between 10 and 20, them's the rules bro.");
                str = Console.ReadLine();
                convert = int.TryParse(str, out myChar.str);
            }
            
            System.Console.WriteLine("What's your dexterity?");
            string dex = Console.ReadLine();
            convert = int.TryParse(dex, out myChar.dex);
            while(convert == false || myChar.dex > 20 || myChar.dex < 10)
            {
                System.Console.WriteLine("Nah man it's gotta be a number between 10 and 20, them's the rules bro.");
                dex = Console.ReadLine();
                convert = int.TryParse(dex, out myChar.dex);
            }

            System.Console.WriteLine("What's your constitution?");
            string con = Console.ReadLine();
            convert = int.TryParse(con, out myChar.con);
            while(convert == false || myChar.con > 20 || myChar.con < 10)
            {
                System.Console.WriteLine("Nah man it's gotta be a number between 10 and 20, them's the rules bro.");
                con = Console.ReadLine();
                convert = int.TryParse(con, out myChar.con);
            }

            System.Console.WriteLine("What's your intelligence?");
            string intelligence = Console.ReadLine();
            convert = int.TryParse(intelligence, out myChar.intelligence);
            while(convert == false || myChar.intelligence > 20 || myChar.intelligence < 10)
            {
                System.Console.WriteLine("Nah man it's gotta be a number between 10 and 20, them's the rules bro.");
                intelligence = Console.ReadLine();
                convert = int.TryParse(intelligence, out myChar.intelligence);
            }
            
            System.Console.WriteLine("What's your wisdom?");
            string wis = Console.ReadLine();
            convert = int.TryParse(wis, out myChar.wis);
            while(convert == false || myChar.wis > 20 || myChar.wis < 10)
            {
                System.Console.WriteLine("Nah man it's gotta be a number between 10 and 20, them's the rules bro.");
                wis = Console.ReadLine();
                convert = int.TryParse(wis, out myChar.wis);
            }

            System.Console.WriteLine("What's your charisma?");
            string cha = Console.ReadLine();
            convert = int.TryParse(cha, out myChar.cha);
            while(convert == false || myChar.cha > 20 || myChar.cha < 10)
            {
                System.Console.WriteLine("Nah man it's gotta be a number between 10 and 20, them's the rules bro.");
                cha = Console.ReadLine();
                convert = int.TryParse(cha, out myChar.cha);
            }

            System.Console.WriteLine(str + ", " + dex + ", " + con + ", " + intelligence + ", " + wis + ", " + cha);

            XmlSerializer characterSerializer = new XmlSerializer(typeof(Character));


            Console.ReadLine();



        }
    }
}
