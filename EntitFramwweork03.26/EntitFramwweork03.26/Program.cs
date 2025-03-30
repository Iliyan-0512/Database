using System.ComponentModel.Design;
using EntitFramwweork03._26.data;
using EntitFramwweork03._26.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

internal class Program
{
    private static void Main(string[] args)
    {
        EnterNumberForMesseges();
        int number;

        do
        {
           
        } while (!int.TryParse(Console.ReadLine(), out number));
        while (number != 0)
        {
            Menu(number);

            do
            {
               
            } while (!int.TryParse(Console.ReadLine(), out number));
        }



    }
    private static void CreateThesis()
    {
        try
        {
            using (var dbContext = new AppDbContext())
            {
                Console.WriteLine("Enter name of author");
                string nameOfAuthor = Console.ReadLine();
                Console.WriteLine("Enter name of supervisor");
                string nameOfSupervisor = Console.ReadLine();
                Console.WriteLine("Enter degree");
                string nameOfDegree = Console.ReadLine();
                Console.WriteLine("Enter name of title");
                string nameOfTitle = Console.ReadLine();
                var author = new Person { Name = nameOfAuthor };
                var supervisor = new Person { Name = nameOfSupervisor };
                var degree = new Degree { Name = nameOfDegree };
                var thesis = new Thesis
                {
                    Author = author,
                    Supervisor = supervisor,
                    Degree = degree,
                    Title = nameOfTitle
                };
                dbContext.Theses.Add(thesis);
                dbContext.SaveChanges();

            }
        }
        catch (Exception ex)
        {

            throw;
        }

    }
    public static void Menu(int chose)
    {
        

        if (chose == 1)
        {
            Addpeople();
        }
        else if (chose == 2)
        {
            ShowPeople();
        }
        else if (chose == 3)
        {
            ShowTheses();
        }
        else if (chose == 4)
        {
            CreateThesis();
        }
        else if (chose == 5)
        {
            ShowAllThesis();
        }
        EnterNumberForMesseges();



    }

    private static void EnterNumberForMesseges()
    {
        Console.WriteLine("Enter number");
        Console.WriteLine("0-Exit");
        Console.WriteLine("1-Add people");
        Console.WriteLine("2-Show how many people have in database");
        Console.WriteLine("3-Show how many theses have in database");
        Console.WriteLine("4-Create thesis");
        Console.WriteLine("5-Show all thesis in database");
    }

    private static void Addpeople()
    {
        using (var dbContex = new AppDbContext())
        {
            Console.Write("Enter person's name ");
            string name = Console.ReadLine();
            var author = new Person { Name = name };

            dbContex.People.Add(author);
            dbContex.SaveChanges();
            Console.WriteLine("Successful");
        }
    }

    private static void ShowAllThesis()
    {
        using (var dbContex = new AppDbContext())
        {
            var theses = dbContex.Theses
                .Include(t => t.Author)
                .Include(t => t.Supervisor)
                .ToList();
            foreach (var t in theses)
            {
                Console.WriteLine(($"{t.Title} - Author: {t.Author.Name}, Supervisor: {t.Supervisor.Name}"));
            }

        }
    }
    private static void ShowTheses()
    {
        using (var dbContex = new AppDbContext())
        {
            int count = dbContex.Theses.Count();
            Console.WriteLine($"In our database have {count} theses");
        }
    }

    private static void ShowPeople()
    {
        using (var dbContex = new AppDbContext())
        {
            int count = dbContex.People.Count();
            Console.WriteLine($"In our database have {count} people");
        }
    }
}