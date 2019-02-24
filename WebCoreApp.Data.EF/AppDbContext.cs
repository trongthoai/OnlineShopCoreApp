using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using WebCoreApp.Data.EF.Extensions;
using WebCoreApp.Data.EF.Configurations;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebCoreApp.Data.Interfaces;

namespace WebCoreApp.Data.EF
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,Guid>
    {

    }
}
