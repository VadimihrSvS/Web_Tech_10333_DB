using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_WT_Data.Entities;

public class ApplicationUser : IdentityUser
{
    public byte[] AvatarImage { get; set; }
}
