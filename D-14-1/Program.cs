using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace D_14_1
{
    internal class Program
    {
        public class Person
        {
            public string förnamn;
            public string efternamn;
            public string telefonnummer;
            public string adress;

            public void Print()
            {
                Console.Write($"Namn: {förnamn} {efternamn}\n\tTelefon: {telefonnummer}\n\tAdress: {adress}\n");
            }
            public Person() 
            {
            
            }
            public Person(string fnamn, string enamn, string tnr, string adr)
            {
                förnamn = fnamn;
                efternamn = enamn;
                telefonnummer = tnr;
                adress = adr;
            }

        }
        public class Land
        {
            public string namn, styre, huvudstad, invånare;
            public Land() { }
            public Land(string n, string s, string h, string i)
            {
                namn = n;
                styre = s;
                huvudstad = h;
                invånare = i;
            }
            public void Print()
            {
                Console.WriteLine($"{namn}\t{styre}\t{huvudstad}\t{invånare}");
            }
        }
        public static void Print(Person p)
        {

            Console.Write($"Namn: {p.förnamn} {p.efternamn}\n\tTelefon: {p.telefonnummer}\n\tAdress: {p.adress}\n");
        }
        static void Main(string[] args)
        {
            Person arne = new Person { förnamn = "Arne", efternamn = "Svensson", telefonnummer = "013-113 13 13", adress = "Datasvängen 23" };
            Person berith = new Person("Berith", "Qvist", "014-114 14 14", "Telegränd 45");
            Person caesar = new Person() { förnamn = "Caesar", efternamn = "Augustus", telefonnummer = "091-432 87 65", adress = "Optikervägen 10" };

            Console.Write($"Namn: {arne.förnamn} {arne.efternamn}\n\tTelefon: {arne.telefonnummer}\n\tAdress: {arne.adress}\n");
            Print(berith);
            caesar.Print();

            Person[] people = new Person[3]
            {
                new Person(){ förnamn = "David", efternamn = "A:sson", telefonnummer = "010-666 420 69", adress = "Hjälpgatan 1" },
                new Person("Echo", "Bravo", "010-721 118 714 226", "Revinge"),
                new Person() {förnamn = "Foxtrot", efternamn = "Bravo", telefonnummer = "Fat Lady", adress = "Grozky Pomorskwij" }
            };

            foreach (Person person in people) { person.Print(); }

            Land Sverige = new Land("Sverige", "monarki", "Stockholm", "10512820");
            Land Tyskland = new Land("Tyskland", "republik", "Berlin", "83783902");
            Land sanMarino = new Land("San Marino", "republik", "San Marino", "33600");

            Sverige.Print();
            Tyskland.Print();
            sanMarino.Print();

            //Array.ForEach(länder, land => land.Print());

            Land[] länder = new Land[7]
            {
                Sverige,
                Tyskland,
                sanMarino,
                new Land("Danmark", "monarki", "Köpenhamn", "5928364"),
                new Land("Italien", "repugblik", "Rom", "58853482"),
                new Land("Tjeckien", "republik", "Prag", "10551219"),
                new Land("Rumänien", "republik", "Bukarest", "19760314")
            };
            
    }
}