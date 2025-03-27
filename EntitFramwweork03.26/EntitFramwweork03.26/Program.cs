using System.ComponentModel.Design;
using EntitFramwweork03._26.data;
using EntitFramwweork03._26.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

internal class Program
{
    private static void Main(string[] args)
    {
        string choose = Console.ReadLine();
        int.TryParse(choose, out int number);
        do
        {
            choose=Console.ReadLine();
        } while (!int.TryParse(choose, out number));


        Menu(5);
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
                    Supervistor = supervisor,
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
        Console.WriteLine("Enter number");
        Console.WriteLine("1-Add people");
        Console.WriteLine("2-Show how many people have in database");
        Console.WriteLine("3-Show how many theses have in database");
        Console.WriteLine("4-Create thesis");
        Console.WriteLine("5-Show all thesis in database");


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
            Showtheses();
        }
        else if (chose == 4)
        {
            CreateThesis();
        }
        else if (chose == 5)
        {
            ShowAllThesis();
        }

        static void Addpeople()
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
    }

    private static void ShowAllThesis()
    {
        using (var dbContex = new AppDbContext())
        {
            var theses = dbContex.Theses
                .Include(t => t.Author)
                .Include(t => t.Supervistor)
                .ToList();
            foreach (var t in theses)
            {
                Console.WriteLine(($"{t.Title} - Author: {t.Author.Name}, Supervisor: {t.Supervistor.Name}"));
            }

        }
    }
    private static void Showtheses()
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