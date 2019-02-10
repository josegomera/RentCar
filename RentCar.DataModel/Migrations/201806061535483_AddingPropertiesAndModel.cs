namespace RentCar.DataModel.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPropertiesAndModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientPreferredContactMediums",
                c => new
                    {
                        FuelTypeId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        PreferredContactMedium = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedDate = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(),
                        IsDisabled = c.Boolean(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ClientPreferredContactMedium_IsDeleted", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.FuelTypeId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            AddColumn("dbo.Clients", "Phone", c => c.String());
            AddColumn("dbo.Clients", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Employees", "Phone", c => c.String());
            AddColumn("dbo.Employees", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientPreferredContactMediums", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientPreferredContactMediums", new[] { "ClientId" });
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "Phone");
            DropColumn("dbo.Clients", "Email");
            DropColumn("dbo.Clients", "Phone");
            DropTable("dbo.ClientPreferredContactMediums",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ClientPreferredContactMedium_IsDeleted", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
