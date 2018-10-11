namespace TallerApis.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publicaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        FechaPublicacion = c.String(nullable: false),
                        MeGusta = c.Int(nullable: false),
                        MeDiGusta = c.Int(nullable: false),
                        VecesCompartido = c.Int(nullable: false),
                        EsPrivada = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publicaciones");
        }
    }
}
