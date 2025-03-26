using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitFramwweork03._26.Model
{
    public class Thesis
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Person Author { get; set; }
        public int SupervistorId { get; set; }

        public Person Supervistor { get; set; }
        public string Title { get; set; }
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }
    }
}
