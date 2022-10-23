Firm F = new Firm();
Firm A = new Firm();
//var people = new List<Person>();
F.sotrudnik.Add(new Sotr("Oleg", "Big", "Urievich", "Tehnic", "38097465", "Oleg@gmail.com", "1300"));
F.sotrudnik.Add(new Sotr("Oleg2", "Big", "Urievich", "Manager", "38097465", "Oleg@gmail.com", "999"));
F.sotrudnik.Add(new Sotr("Da", "Big", "Urievich", "MANAGER", "38097465", "Oleg@gmail.com", "900"));

F.people.Add(new Person("Step", "1999", "IT", "Alesha", "Izi", "Popovich", "100", "London 55", F.sotrudnik));

A.sotrudnik.Add(new Sotr("11", "Big", "Urievich", "Manager", "38097465", "Oleg@gmail.com", "900"));
A.sotrudnik.Add(new Sotr("111", "Big", "Urievich", "Tehnic", "38097465", "Oleg@gmail.com", "1300"));
//F.sotrudnik.Add(new Sotr("11111", "Big", "Urievich", "Tehnic", "38097465", "Oleg@gmail.com", "1300$"));

F.people.Add(new Person("MonoBank", "1993", "Bank", "Vasya", "Silniy", "Olegovich", "125", "Alo 3", A.sotrudnik));

//F.people.Add(new Person("Lepistok", "1993", "Marketing", "Irina", "Shekowa", "Olegovna", "45", "Privet 10"));
//F.people.Add(new Person("FoodMacDonald's", "1994", "Еда", "Denis", "White", "Sergeevich", "300", "Alo 3"));
//F.people.Add(new Person("MafiyaFood", "1991", "Еда", "Oleg", "Last", "Olegovich", "301", "London 32"));
//F.people.Add(new Person("WhiteFlower", "1999", "Prom", "Sergey", "BlackJack", "Valentinovich", "33", " Dnipro 1"));
//F.people.Add(new Person("WhitePig", "1999", "Prom", "Sergey", "Jack", "Valentinovich", "33", " Dnipro 1"));
Console.WriteLine("Вывод всех фирм");
Console.WriteLine();
F.PrintAll();
Console.WriteLine();
Console.WriteLine("Название фирм у которых в названии есть слово Food");
Console.WriteLine();
F.PrintFood();
Console.WriteLine();
Console.WriteLine("Название фирм у которых профиль Marketing");
Console.WriteLine();
F.PrintMarketing();
Console.WriteLine();
Console.WriteLine("Название фирм у которых профиль Marketing или IT");
Console.WriteLine();
F.PrintMarketing();
F.PrintIT();
Console.WriteLine();
Console.WriteLine("Название фирм у которых больше 100 сотрудников");
Console.WriteLine();
F.PrintBigFirm();
Console.WriteLine();
Console.WriteLine("Название фирм у которых кол-во сотрудников от 100 до 300");
Console.WriteLine();
F.PrintBigFirm100300();
Console.WriteLine();
Console.WriteLine("Фирмы, находящиеся в Лондоне");
Console.WriteLine();
F.PrintFirmInLondon();
Console.WriteLine();
Console.WriteLine("Фирмы,с фамилией директора White");
F.PrintFirmWhiteFam();
Console.WriteLine();
Console.WriteLine("Фирмы с названием White и фамилией директора Black");
F.PrintBlackWgite();
Console.WriteLine();
Console.WriteLine("Вывод всех сотрудников фирмы Step");
F.PrintAllSotr();
Console.WriteLine();
Console.WriteLine("Вывод всех сотрудников фирмы Step у которых зарплата выше 1000$");
F.PrintBigMoney();
Console.WriteLine();
Console.WriteLine("Вывод всех менеджероу всех фирм");
F.PrintManagerAllFirm();
class Firm
{
    public string[] mas = new string[100];
    public List<Person> people = new List<Person>();
    public List<Sotr> sotrudnik = new List<Sotr>();
    public string NameFirm;
    public string DateFirm;
    public string ProfBuss;
    public string FirstNDir;
    public string SecondNDir;
    public string LastNDir;
    public string kolSotr;
    public string adress;
    public void Massise()
    {
        
    }
    public Firm()
    {

    }
    public Firm(string nameFirm, string dateFirm, string profBuss, string firstNDir, string secondNDir, string lastNDir, string KolSotr, string Adress)
    {
        NameFirm = nameFirm;
        DateFirm = dateFirm;
        ProfBuss = profBuss;
        FirstNDir = firstNDir;
        SecondNDir = secondNDir;
        LastNDir = lastNDir;
        kolSotr = KolSotr;
        adress = Adress;
    }
    public void PrintAll()
    {
        var sortPeople = from pers in people
                         orderby pers.NameFirm
                         select pers;
        foreach(var pers in sortPeople)
        {
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress +" }");
            foreach (var pers2 in pers.sotrudnik)
            {
                Console.WriteLine(pers2 + " ");
               
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        
       
    }
    public void PrintFood()
    {
        var Food = from pers in people
                   where pers.NameFirm.ToLower().Contains("food")
                   orderby pers.NameFirm
                   select pers;
        foreach(var pers in Food)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintMarketing()
    {
        var Mark = from pers in people
                   where pers.ProfBuss.ToLower().Contains("marketing")
                   orderby pers.ProfBuss
                   select pers;
        foreach(var pers in Mark)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintIT()
    {
        var IT = from pers in people
                 where pers.ProfBuss.ToLower().Contains("it")
                 orderby pers.ProfBuss
                 select pers;
        foreach(var pers in IT)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintBigFirm()
    {
        var Big = from pers in people
                  where Convert.ToInt32(pers.kolSotr) > 100
                  select pers;
        foreach(var pers in Big)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintBigFirm100300()
    {
        var Big = from pers in people
                  where Convert.ToInt32(pers.kolSotr) >= 100 && Convert.ToInt32(pers.kolSotr) <= 300
                  select pers;
        foreach (var pers in Big)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintFirmInLondon()
    {
        var Lon = from pers in people
                  where pers.adress.ToLower().Contains("london")
                  select pers;
        foreach (var pers in Lon)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintFirmWhiteFam()
    {
        var Lon = from pers in people
                  where pers.SecondNDir.ToLower().Contains("white")
                  select pers;
        foreach (var pers in Lon)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintBlackWgite()
    {
        var BW = from pers in people
                 where pers.NameFirm.ToLower().Contains("white") && pers.SecondNDir.ToLower().Contains("black")
                 select pers;
        foreach (var pers in BW)
        {
            Console.WriteLine(pers + " ");
        }
    }
    public void PrintAllSotr()
    {
        var allSotr = from pers in people
                      where pers.NameFirm.ToLower() == "monobank"
                      select pers;
        foreach (var pers in allSotr)
        {
            foreach (var pers2 in pers.sotrudnik)
            {
                Console.WriteLine(pers2 + " ");
            }
        }
    }
    public void PrintBigMoney()
    {
        var allSotr = from pers in people
                      where pers.NameFirm.ToLower() == "monobank"
                      select pers;
        foreach (var pers in allSotr)
        {
            var money = from pers2 in sotrudnik
                        where Convert.ToInt32(pers2.Dengi) > 1000
                        select pers2;
            foreach (var pers2 in pers.sotrudnik)
            {
                
                Console.WriteLine(pers2 + " ");
            }
        }
    }
    public void PrintManagerAllFirm()
    {

        //var allSotr = from pers in people
                      //where pers.NameFirm.ToLower() == "step"
                      //select pers;
        var money = from pers2 in sotrudnik
                    where pers2.Doljnost == "manager"
                    select pers2;
        //foreach (var pers in allSotr)
        //{
            
            foreach (var pers2 in money)
            {
                Console.WriteLine(pers2 + " ");
            }
        //}

        //var allSotr = from pers in people
        //              where pers.NameFirm.ToLower() == "step"
        //              select pers;
        //foreach (var pers in allSotr)
        //{
        //    foreach (var pers2 in pers.sotrudnik)
        //    {
        //        Console.WriteLine(pers2 + " ");
        //    }
        //}

    }
}
record class Person(string NameFirm, string DateFirm, string ProfBuss, string FirstNDir, string SecondNDir, string LastNDir, string kolSotr, string adress, List<Sotr> sotrudnik);
record class Sotr(string FistName, string SecondName, string LastName, string Doljnost, string Telefon, string Email, string Dengi);