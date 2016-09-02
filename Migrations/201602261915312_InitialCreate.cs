namespace ControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataRegs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        typeWork = c.String(),
                        siteWork = c.String(),
                        detailsWork = c.String(),
                        dateWork = c.String(),
                        timeStartWork = c.String(),
                        timeFinishWork = c.String(),
                        timeWorked = c.String(),
                        earned = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataRegs");
        }
    }
}
