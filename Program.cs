Firm F = new Firm();
Firm A = new Firm();
Firm B = new Firm();
Firm C = new Firm();
Firm Q = new Firm();
Firm S = new Firm();
Firm O = new Firm();

F.sotrudnik.Add(new Sotr("Oleg", "Big", "Urievich", "Tehnic", "23097465", "Oleg@gmail.com", "1200"));
F.sotrudnik.Add(new Sotr("Oleg2", "Big", "Urievich", "Manager", "38097465", "dior@gmail.com", "999"));
F.sotrudnik.Add(new Sotr("Da", "Big", "Urievich", "MANAGER", "38097465", "Oleg@gmail.com", "900"));
F.people.Add(new Person("Step", "1999", "IT", "Alesha", "Izi", "Popovich", "100", "London 55", F.sotrudnik));

A.sotrudnik.Add(new Sotr("11", "Big", "Urievich", "Manager", "38097465", "diOleg@gmail.com", "900"));
A.sotrudnik.Add(new Sotr("111", "Big", "Urievich", "Tehnic", "23097465", "Oleg@gmail.com", "1300"));
A.sotrudnik.Add(new Sotr("Andrey", "Big", "Urievich", "Manager", "38097465", "Oleg@gmail.com", "2500"));
F.people.Add(new Person("MonoBank", "1993", "Bank", "Vasya", "Silniy", "Olegovich", "125", "Alo 3", A.sotrudnik));

B.sotrudnik.Add(new Sotr("Vasya", "Big", "Urievich", "Tehnic", "23097465", "Vasya@gmail.com", "999"));
B.sotrudnik.Add(new Sotr("Lionel", "Big", "Urievich", "Manager", "38097465", "Lionel@gmail.com", "1001"));
F.people.Add(new Person("Lepistok", "1993", "Marketing", "Irina", "Shekowa", "Olegovna", "45", "Privet 10", B.sotrudnik));

C.sotrudnik.Add(new Sotr("Vitya", "Big", "Urievich", "Tehnic", "33097465", "Vasya33@gmail.com", "888"));
C.sotrudnik.Add(new Sotr("Lionel", "BigSmall", "Urievich", "Uborshik", "38097465", "Lionel23@gmail.com", "777"));
F.people.Add(new Person("FoodMacDonald's", "1994", "Еда", "Denis", "White", "Sergeevich", "300", "Alo 3", C.sotrudnik));

Q.sotrudnik.Add(new Sotr("Slavik", "Big", "Urievich", "Tehnic", "33097465", "diSlavik33@gmail.com", "10000"));
Q.sotrudnik.Add(new Sotr("Alyona", "BigSmall", "Urievich", "Manager", "38097465", "Alyona77@gmail.com", "3000"));
F.people.Add(new Person("MafiyaFood", "1991", "Еда", "Oleg", "Last", "Olegovich", "301", "London 32", Q.sotrudnik));

S.sotrudnik.Add(new Sotr("Uriy", "Urik", "Urievich", "Manager", "33097465", "diUriy777@gmail.com", "100000000"));
S.sotrudnik.Add(new Sotr("Alyona", "BigSmall", "Urievich", "Manager", "38097465", "Alyona77@gmail.com", "3000"));
F.people.Add(new Person("WhiteFlower", "1999", "Prom", "Sergey", "BlackJack", "Valentinovich", "33", " Dnipro 1", S.sotrudnik));

O.sotrudnik.Add(new Sotr("Radomir", "Grow", "Radomirovich", "Manager", "33097465", "diUriy777@gmail.com", "1000"));
O.sotrudnik.Add(new Sotr("Sergey", "BigSmall", "Sergeevich", "Manager", "38097465", "diSerg77@gmail.com", "7777"));
F.people.Add(new Person("WhitePig", "1999", "Prom", "Sergey", "Jack", "Valentinovich", "33", " Dnipro 1",O.sotrudnik));

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
Console.WriteLine("Вывод всех сотрудников фирмы Monobank");
F.PrintAllSotr();
Console.WriteLine();
Console.WriteLine("Вывод всех сотрудников фирмы Monobank у которых зарплата выше 1000$");
F.PrintBigMoney();
Console.WriteLine();
Console.WriteLine("Вывод всех менеджероу всех фирм");
F.PrintManagerAllFirm();
Console.WriteLine();
Console.WriteLine("Вывод всех сотрудников, чей телефон начинается с 23");
Console.WriteLine();
F.PrintManager23Telef();
Console.WriteLine();
Console.WriteLine("Вывод сотрудников, чей эмейл начинается с di");
F.PrintManagerEmailDI();
Console.WriteLine();
Console.WriteLine("Вывод всех Lionel's");
Console.WriteLine();
F.PrintManagerNameLionel();
class Firm
{
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
    public Firm()
    {

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
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
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
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
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
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
        }
    }
    public void PrintBigFirm()
    {
        var Big = from pers in people
                  where Convert.ToInt32(pers.kolSotr) > 100
                  select pers;
        foreach(var pers in Big)
        {
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
        }
    }
    public void PrintBigFirm100300()
    {
        var Big = from pers in people
                  where Convert.ToInt32(pers.kolSotr) >= 100 && Convert.ToInt32(pers.kolSotr) <= 300
                  select pers;
        foreach (var pers in Big)
        {
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
        }
    }
    public void PrintFirmInLondon()
    {
        var Lon = from pers in people
                  where pers.adress.ToLower().Contains("london")
                  select pers;
        foreach (var pers in Lon)
        {
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
        }
    }
    public void PrintFirmWhiteFam()
    {
        var Lon = from pers in people
                  where pers.SecondNDir.ToLower().Contains("white")
                  select pers;
        foreach (var pers in Lon)
        {
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
        }
    }
    public void PrintBlackWgite()
    {
        var BW = from pers in people
                 where pers.NameFirm.ToLower().Contains("white") && pers.SecondNDir.ToLower().Contains("black")
                 select pers;
        foreach (var pers in BW)
        {
            Console.WriteLine("Firm { " + pers.NameFirm + " " + pers.DateFirm + " " + pers.ProfBuss + " " + pers.FirstNDir + " " + pers.SecondNDir + " " + pers.LastNDir + " " + pers.kolSotr + " " + pers.adress + " }");
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
       foreach(var pers in allSotr)
       {
            var money = from pers2 in pers.sotrudnik
                       where Convert.ToInt32(pers2.Dengi) > 1000
                       select pers2;

            foreach (var pers2 in money)
            {
                 Console.WriteLine(pers2 + " ");
            }
        }
    }
    public void PrintManagerAllFirm()
    {
        var allSotr = from pers in people
                      select pers;
        foreach(var pers in allSotr)
        {
            var money = from pers2 in pers.sotrudnik
                        where pers2.Doljnost.ToLower() == "manager"
                        select pers2;
            foreach(var pers2 in money)
            {
                Console.WriteLine(pers2 + " ");
            }
        }
    }
    public void PrintManager23Telef()
    {
        var allSotr = from pers in people
                      select pers;
        foreach (var pers in allSotr)
        {
            var money = from pers2 in pers.sotrudnik
                        where pers2.Telefon[0] == '2' && pers2.Telefon[1]=='3'
                        select pers2;
            foreach (var pers2 in money)
            {
                Console.WriteLine(pers2 + " ");
            }
        }
    }
    public void PrintManagerEmailDI()
    {
        var allSotr = from pers in people
                      select pers;
        foreach (var pers in allSotr)
        {
            var money = from pers2 in pers.sotrudnik
                        where Convert.ToString(pers2.Email[0]).ToLower() == "d" && Convert.ToString(pers2.Email[1]).ToLower() == "i"
                        select pers2;
            foreach (var pers2 in money)
            {
                Console.WriteLine(pers2 + " ");
            }
        }
    }
    public void PrintManagerNameLionel()
    {
        var allSotr = from pers in people
                      select pers;
        foreach (var pers in allSotr)
        {
            var money = from pers2 in pers.sotrudnik
                        where pers2.FistName.ToLower()=="lionel"
                        select pers2;
            foreach (var pers2 in money)
            {
                Console.WriteLine(pers2 + " ");
            }
        }
    }
}
record class Person(string NameFirm, string DateFirm, string ProfBuss, string FirstNDir, string SecondNDir, string LastNDir, string kolSotr, string adress, List<Sotr> sotrudnik);
record class Sotr(string FistName, string SecondName, string LastName, string Doljnost, string Telefon, string Email, string Dengi);