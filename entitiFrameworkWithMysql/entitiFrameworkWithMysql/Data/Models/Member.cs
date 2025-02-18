using System;
using System.Collections.Generic;

namespace entitiFrameworkWithMysql.Data.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateOnly? MembershipDate { get; set; }
}
