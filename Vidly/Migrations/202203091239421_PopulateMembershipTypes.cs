namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            // Seeding the DB with MembershipTypes
            // Pay as you go
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate)" +
                "VALUES (1, 0, 0, 0)");
            // Monthly
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate)" +
                "VALUES (2, 30, 1, 10)");
            // Quartly
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate)" +
                "VALUES (3, 90, 3, 15)");
            // Yearly 
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate)" +
                "VALUES (4, 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
