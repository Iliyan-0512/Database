using System.ComponentModel.Design;
using EntitFramwweork03._26.data;
using EntitFramwweork03._26.Model;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        
        CreateThesis();
        Menu(2);
    }
    private static void CreateThesis()
    {
        try
        {
            using (var dbContext = new AppDbContext())
            {
                var author = new Person { Name = "Iliyan Manov" };
                var supervisor = new Person { Name = "Georgi Petov" };
                var degree = new Degree { Name = "BSc" };
                var thesis = new Thesis
                {
                    Author = author,
                    Supervistor = supervisor,
                    Degree = degree,
                    Title = "ala bala"


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
        Console.WriteLine("3-Show how manu book have in database");
        
        
        if (chose==1)
        {
            using (var dbContex = new AppDbContext())
            {
                Console.Write("Enter person's name ");
                string name = Console.ReadLine();
                var author = new Person { Name=name };
               
                dbContex.People.Add(author);
                dbContex.SaveChanges();
                Console.WriteLine("Successful");
            }
        }
        else if (chose==2)
        {
            using (var dbContex = new AppDbContext())
            {
                    int count=dbContex.People.Count();
                Console.WriteLine($"In our database have {count}");
            }
        }
    }
}