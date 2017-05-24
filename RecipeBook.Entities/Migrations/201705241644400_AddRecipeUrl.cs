namespace RecipeBook.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecipeUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipe", "OriginalRecipeUrl", c => c.String());
            AddColumn("dbo.Recipe", "OriginalRecipeNotes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipe", "OriginalRecipeNotes");
            DropColumn("dbo.Recipe", "OriginalRecipeUrl");
        }
    }
}
