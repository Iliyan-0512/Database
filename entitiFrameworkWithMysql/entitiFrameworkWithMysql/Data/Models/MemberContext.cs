using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace entitiFrameworkWithMysql.Data.Models
{
    public class MemberContext:DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options)
            :base(options) { }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Member> Members { get; set; }

        public void AddMember(Member member)
        {
            Members.Add(member);
            SaveChanges();
        }
    }
}
