namespace teqBlog.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BlogPosts",
                c => new
                    {
                        BlogPostID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 4000),
                        Body = c.String(maxLength: 4000),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogPostID);
            
            CreateTable(
                "Photos",
                c => new
                    {
                        PhotoID = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 4000),
                        BlogPostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhotoID)
                .ForeignKey("BlogPosts", t => t.BlogPostID, cascadeDelete: true)
                .Index(t => t.BlogPostID);
            
        }
        
        public override void Down()
        {
            DropIndex("Photos", new[] { "BlogPostID" });
            DropForeignKey("Photos", "BlogPostID", "BlogPosts");
            DropTable("Photos");
            DropTable("BlogPosts");
        }
    }
}
