namespace DrugstoreSchool2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES(1,'Thuốc Đau Đầu')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES(2,'Thuốc Đau Dạ Dày')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES(3,'Thuốc Mát Gan')");
        }
        
        public override void Down()
        {
        }
    }
}
