using EntitFramwweork03._26.data;
using EntitFramwweork03._26.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        CreateThesis();
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
}