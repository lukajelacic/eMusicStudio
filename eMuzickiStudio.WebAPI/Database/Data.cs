using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Database
{
    public class Data
    {
        public static void Seed(_150192V1Context context)
        {

            context.Database.Migrate();
        }
    }
}
