using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClipShare.DataAccess.Data
{
    public  static class ContextInitializer
    {
        public static void initialize(Context context)
        {
            if (context.Database.GetPendingMigrations().Count() > 0)
            {
                context.Database.Migrate();
            }
        }
    }
}
