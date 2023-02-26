using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        List<string> verses = new List<string>();

        verses.Add("D&C 84 35: And also all they who receive this priesthood receive me, saith the Lord; ");
        verses.Add("D&C 84 36: For he that receiveth my servants receiveth me;");
        verses.Add("D&C 84 37: And he that receiveth me receiveth my Father;");
        Random v = new Random();
        int verse = v.Next(verses.Count());
        string randVerse = verses[verse];


        while (true){
            Console.WriteLine("What verses do you want to add? ((none, nohting, no) to stop) "); 
            string scripQuestion = Console.ReadLine();

            if (scripQuestion.ToLower() == "no" || scripQuestion.ToLower() == "none" || scripQuestion.ToLower() == "nothing"){
                break;
            }
            else{
                Console.WriteLine("What's the reference of the scripture? ");
                string refer = Console.ReadLine();
                string[] referParts = refer.Split(' ');
                string referBook = referParts[0];
                string referNumbers = referParts[1];
                string[] referParts2 = referNumbers.Split(' ');
                int referChapter = int.Parse(referParts[1]);
                string referVerse = referParts[2];
                string[] referParts3 = referNumbers.Split('-');
                int referStartVerse = int.Parse(referParts3[0]);
                int referEndVerse = int.Parse(referParts3[1]);
 
                Reference refere1 = new Reference(referBook, referChapter, referStartVerse);
                Reference refere2 = new Reference(referBook, referChapter, referStartVerse, referEndVerse);
                Scripture scripture1 = new Scripture(refere1, verses);
                Scripture scripture2 = new Scripture(refere2, verses);

                scripture1.Display();
            }
            verses.Add(scripQuestion);

        }

    }
}

// I tried to get it to where the user could add their scriptures they wanted.