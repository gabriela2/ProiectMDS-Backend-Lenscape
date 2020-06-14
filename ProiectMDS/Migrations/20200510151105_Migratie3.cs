using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMDS.Migrations
{
    public partial class Migratie3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaEchipament_Comenzi_ComenziId",
                table: "ComandaEchipament");

            migrationBuilder.DropForeignKey(
                name: "FK_ComandaEchipament_Echipament_EchipamentId",
                table: "ComandaEchipament");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Client_ClientId",
                table: "Comenzi");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Magazin_MagazinId",
                table: "Comenzi");

            migrationBuilder.DropForeignKey(
                name: "FK_Echipament_Producator_ProducatorId",
                table: "Echipament");

            migrationBuilder.DropForeignKey(
                name: "FK_EchipamentCategorie_Categorie_CategorieId",
                table: "EchipamentCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_EchipamentCategorie_Echipament_EchipamentId",
                table: "EchipamentCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_MagazinEchipament_Echipament_EchipamentId",
                table: "MagazinEchipament");

            migrationBuilder.DropForeignKey(
                name: "FK_MagazinEchipament_Magazin_MagazinId",
                table: "MagazinEchipament");

            migrationBuilder.DropColumn(
                name: "IdEchipament",
                table: "MagazinEchipament");

            migrationBuilder.DropColumn(
                name: "IdMagazin",
                table: "MagazinEchipament");

            migrationBuilder.DropColumn(
                name: "IdCategorie",
                table: "EchipamentCategorie");

            migrationBuilder.DropColumn(
                name: "IdEchipament",
                table: "EchipamentCategorie");

            migrationBuilder.DropColumn(
                name: "IdProducator",
                table: "Echipament");

            migrationBuilder.DropColumn(
                name: "IdClient",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "IdMagazin",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "IdComenzi",
                table: "ComandaEchipament");

            migrationBuilder.DropColumn(
                name: "IdEchipament",
                table: "ComandaEchipament");

            migrationBuilder.RenameColumn(
                name: "ProducatorId",
                table: "Producator",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MagazinEchipamentId",
                table: "MagazinEchipament",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MagazinId",
                table: "Magazin",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EchipamentCategorieId",
                table: "EchipamentCategorie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EchipamentId",
                table: "Echipament",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ComenziId",
                table: "Comenzi",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ComandaEchipamentId",
                table: "ComandaEchipament",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdTip",
                table: "Client",
                newName: "TipId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Client",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Categorie",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "MagazinId",
                table: "MagazinEchipament",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EchipamentId",
                table: "MagazinEchipament",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EchipamentId",
                table: "EchipamentCategorie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategorieId",
                table: "EchipamentCategorie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProducatorId",
                table: "Echipament",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MagazinId",
                table: "Comenzi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Comenzi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EchipamentId",
                table: "ComandaEchipament",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComenziId",
                table: "ComandaEchipament",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaEchipament_Comenzi_ComenziId",
                table: "ComandaEchipament",
                column: "ComenziId",
                principalTable: "Comenzi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaEchipament_Echipament_EchipamentId",
                table: "ComandaEchipament",
                column: "EchipamentId",
                principalTable: "Echipament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Client_ClientId",
                table: "Comenzi",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Magazin_MagazinId",
                table: "Comenzi",
                column: "MagazinId",
                principalTable: "Magazin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Echipament_Producator_ProducatorId",
                table: "Echipament",
                column: "ProducatorId",
                principalTable: "Producator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EchipamentCategorie_Categorie_CategorieId",
                table: "EchipamentCategorie",
                column: "CategorieId",
                principalTable: "Categorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EchipamentCategorie_Echipament_EchipamentId",
                table: "EchipamentCategorie",
                column: "EchipamentId",
                principalTable: "Echipament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MagazinEchipament_Echipament_EchipamentId",
                table: "MagazinEchipament",
                column: "EchipamentId",
                principalTable: "Echipament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MagazinEchipament_Magazin_MagazinId",
                table: "MagazinEchipament",
                column: "MagazinId",
                principalTable: "Magazin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaEchipament_Comenzi_ComenziId",
                table: "ComandaEchipament");

            migrationBuilder.DropForeignKey(
                name: "FK_ComandaEchipament_Echipament_EchipamentId",
                table: "ComandaEchipament");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Client_ClientId",
                table: "Comenzi");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Magazin_MagazinId",
                table: "Comenzi");

            migrationBuilder.DropForeignKey(
                name: "FK_Echipament_Producator_ProducatorId",
                table: "Echipament");

            migrationBuilder.DropForeignKey(
                name: "FK_EchipamentCategorie_Categorie_CategorieId",
                table: "EchipamentCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_EchipamentCategorie_Echipament_EchipamentId",
                table: "EchipamentCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_MagazinEchipament_Echipament_EchipamentId",
                table: "MagazinEchipament");

            migrationBuilder.DropForeignKey(
                name: "FK_MagazinEchipament_Magazin_MagazinId",
                table: "MagazinEchipament");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producator",
                newName: "ProducatorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MagazinEchipament",
                newName: "MagazinEchipamentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Magazin",
                newName: "MagazinId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EchipamentCategorie",
                newName: "EchipamentCategorieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Echipament",
                newName: "EchipamentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comenzi",
                newName: "ComenziId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ComandaEchipament",
                newName: "ComandaEchipamentId");

            migrationBuilder.RenameColumn(
                name: "TipId",
                table: "Client",
                newName: "IdTip");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Client",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categorie",
                newName: "CategorieId");

            migrationBuilder.AlterColumn<int>(
                name: "MagazinId",
                table: "MagazinEchipament",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EchipamentId",
                table: "MagazinEchipament",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdEchipament",
                table: "MagazinEchipament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMagazin",
                table: "MagazinEchipament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "EchipamentId",
                table: "EchipamentCategorie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CategorieId",
                table: "EchipamentCategorie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdCategorie",
                table: "EchipamentCategorie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEchipament",
                table: "EchipamentCategorie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProducatorId",
                table: "Echipament",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdProducator",
                table: "Echipament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MagazinId",
                table: "Comenzi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Comenzi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdClient",
                table: "Comenzi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMagazin",
                table: "Comenzi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "EchipamentId",
                table: "ComandaEchipament",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ComenziId",
                table: "ComandaEchipament",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdComenzi",
                table: "ComandaEchipament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEchipament",
                table: "ComandaEchipament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaEchipament_Comenzi_ComenziId",
                table: "ComandaEchipament",
                column: "ComenziId",
                principalTable: "Comenzi",
                principalColumn: "ComenziId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaEchipament_Echipament_EchipamentId",
                table: "ComandaEchipament",
                column: "EchipamentId",
                principalTable: "Echipament",
                principalColumn: "EchipamentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Client_ClientId",
                table: "Comenzi",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Magazin_MagazinId",
                table: "Comenzi",
                column: "MagazinId",
                principalTable: "Magazin",
                principalColumn: "MagazinId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Echipament_Producator_ProducatorId",
                table: "Echipament",
                column: "ProducatorId",
                principalTable: "Producator",
                principalColumn: "ProducatorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EchipamentCategorie_Categorie_CategorieId",
                table: "EchipamentCategorie",
                column: "CategorieId",
                principalTable: "Categorie",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EchipamentCategorie_Echipament_EchipamentId",
                table: "EchipamentCategorie",
                column: "EchipamentId",
                principalTable: "Echipament",
                principalColumn: "EchipamentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MagazinEchipament_Echipament_EchipamentId",
                table: "MagazinEchipament",
                column: "EchipamentId",
                principalTable: "Echipament",
                principalColumn: "EchipamentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MagazinEchipament_Magazin_MagazinId",
                table: "MagazinEchipament",
                column: "MagazinId",
                principalTable: "Magazin",
                principalColumn: "MagazinId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
