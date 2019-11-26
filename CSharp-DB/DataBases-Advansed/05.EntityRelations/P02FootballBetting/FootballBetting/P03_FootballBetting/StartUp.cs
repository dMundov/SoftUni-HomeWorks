namespace P03_FootballBetting
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data;
    using System;
    
    class StarttUp
    {
        public static void Main()
        {
            using var db = new FootballBettingContext();

            db.Database.Migrate();
        }
    }
}
