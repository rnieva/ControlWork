namespace ControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpaid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataRegs", "paid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataRegs", "paid");
        }
    }
}
