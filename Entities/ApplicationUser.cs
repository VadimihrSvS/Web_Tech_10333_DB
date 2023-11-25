using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab_WT_Data.Entities;

public class ApplicationUser : IdentityUser
{
    [AllowNull]
    public byte[] AvatarImage { get; set; } = null!;
}
