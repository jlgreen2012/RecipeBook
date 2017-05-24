namespace RecipeBook.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IngredientNotes = c.String(),
                        GroceryNotes = c.String(),
                        Unit = c.Double(nullable: false),
                        Measurement = c.Int(nullable: false),
                        IngredientSetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IngredientSet", t => t.IngredientSetId)
                .Index(t => t.IngredientSetId);
            
            CreateTable(
                "dbo.IngredientSet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Recipe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipe", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        CookingNotes = c.String(),
                        DishType = c.Int(nullable: false),
                        HealthLevel = c.Int(nullable: false),
                        MinutesToPrep = c.Int(nullable: false),
                        MinutesToCook = c.Int(nullable: false),
                        DifficultyLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HealthLevel = c.Int(nullable: false),
                        DateAdded = c.DateTime(),
                        DateLastCooked = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MealRecipe",
                c => new
                    {
                        MealId = c.Int(nullable: false),
                        RecipeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MealId, t.RecipeId })
                .ForeignKey("dbo.Meal", t => t.MealId, cascadeDelete: true)
                .ForeignKey("dbo.Recipe", t => t.RecipeId, cascadeDelete: true)
                .Index(t => t.MealId)
                .Index(t => t.RecipeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MealRecipe", "RecipeId", "dbo.Recipe");
            DropForeignKey("dbo.MealRecipe", "MealId", "dbo.Meal");
            DropForeignKey("dbo.IngredientSet", "Recipe_Id", "dbo.Recipe");
            DropForeignKey("dbo.Ingredient", "IngredientSetId", "dbo.IngredientSet");
            DropIndex("dbo.MealRecipe", new[] { "RecipeId" });
            DropIndex("dbo.MealRecipe", new[] { "MealId" });
            DropIndex("dbo.IngredientSet", new[] { "Recipe_Id" });
            DropIndex("dbo.Ingredient", new[] { "IngredientSetId" });
            DropTable("dbo.MealRecipe");
            DropTable("dbo.Meal");
            DropTable("dbo.Recipe");
            DropTable("dbo.IngredientSet");
            DropTable("dbo.Ingredient");
        }
    }
}
