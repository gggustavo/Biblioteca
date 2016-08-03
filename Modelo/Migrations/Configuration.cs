namespace Modelo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Modelo.Context>
    {
        //Enable-Migrations

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Biblioteca";
        }

        protected override void Seed(Modelo.Context context)
        {          
            base.Seed(context);
        }
    }
}
