namespace ControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zipcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataRegs", "zipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataRegs", "zipCode");
        }
    }
}
