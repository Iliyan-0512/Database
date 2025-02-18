using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using entitiFrameworkWithMysql.Data.Models;
using Pomelo.EntityFrameworkCore.MySql;

class Program
{
    static void Main(string[] args)
    {


        var memberOptionsBuilder = new DbContextOptionsBuilder<MemberContext>();
        memberOptionsBuilder.UseMySql("server=localhost;database=book;user=root;password=113119Ii",
            ServerVersion.AutoDetect("server=localhost;database=book;user=root;password=113119Ii"));

        using (var memberContext = new MemberContext(memberOptionsBuilder.Options))
        {
            var newMember = new Member
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "jodwhndoe@gmail.bg",
                PhoneNumber = "0313341242"
            };
            memberContext.Members.Add(newMember);
            memberContext.SaveChanges();
            Console.WriteLine("Member added successfully.");
        }
    }

}


