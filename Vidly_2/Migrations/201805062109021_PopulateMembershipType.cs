namespace Vidly_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountFee) VALUES (0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountFee) VALUES (30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountFee) VALUES (90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountFee) VALUES (300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
