namespace EntitFramwweork03._26.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Thesis> AuthoredTheses;
        public ICollection<Thesis> SupervisedTheses;

    }
}
