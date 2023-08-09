using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "arls",
                columns: table => new
                {
                    Id_Arl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arls", x => x.Id_Arl);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    Id_Brand = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Brand1 = table.Column<int>(type: "int", nullable: true),
                    Namebrand = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.Id_Brand);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePais = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.IdPais);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "diagnosticmechanic",
                columns: table => new
                {
                    Id_DiagMechanic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cc_Mechanic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosticmechanic", x => x.Id_DiagMechanic);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "eps",
                columns: table => new
                {
                    Id_Eps = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eps", x => x.Id_Eps);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "providers",
                columns: table => new
                {
                    Id_Provider = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameCompany = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_providers", x => x.Id_Provider);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rols",
                columns: table => new
                {
                    Id_Rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rols", x => x.Id_Rol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "servicefee",
                columns: table => new
                {
                    Id_ServiceFee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fee_Porcent = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicefee", x => x.Id_ServiceFee);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "specialities",
                columns: table => new
                {
                    Id_Speciality = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialities", x => x.Id_Speciality);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    Id_State = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.Id_State);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "telephones",
                columns: table => new
                {
                    Id_Telephone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telephones", x => x.Id_Telephone);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "typepersons",
                columns: table => new
                {
                    Id_typePerson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typepersons", x => x.Id_typePerson);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    Id_Region = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRegion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Pais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.Id_Region);
                    table.ForeignKey(
                        name: "FK_regions_countries_Id_Pais",
                        column: x => x.Id_Pais,
                        principalTable: "countries",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "summaryfails",
                columns: table => new
                {
                    Id_Fails = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_DiagM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_summaryfails", x => x.Id_Fails);
                    table.ForeignKey(
                        name: "FK_summaryfails_diagnosticmechanic_Id_DiagM",
                        column: x => x.Id_DiagM,
                        principalTable: "diagnosticmechanic",
                        principalColumn: "Id_DiagMechanic",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "squareparts",
                columns: table => new
                {
                    Id_SquareParts = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Nit = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_squareparts", x => x.Id_SquareParts);
                    table.ForeignKey(
                        name: "FK_squareparts_providers_Id_Nit",
                        column: x => x.Id_Nit,
                        principalTable: "providers",
                        principalColumn: "Id_Provider",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rolemployes",
                columns: table => new
                {
                    Id_RolEmploye = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Rol = table.Column<int>(type: "int", nullable: false),
                    Id_Employe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolemployes", x => x.Id_RolEmploye);
                    table.ForeignKey(
                        name: "FK_rolemployes_rols_Id_Employe",
                        column: x => x.Id_Employe,
                        principalTable: "rols",
                        principalColumn: "Id_Rol",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    Id_Service = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_ServiceFee = table.Column<int>(type: "int", nullable: false),
                    Id_RepairOrder = table.Column<int>(type: "int", nullable: false),
                    totalvalue = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.Id_Service);
                    table.ForeignKey(
                        name: "FK_services_servicefee_Id_ServiceFee",
                        column: x => x.Id_ServiceFee,
                        principalTable: "servicefee",
                        principalColumn: "Id_ServiceFee",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "typecontacts",
                columns: table => new
                {
                    Id_TypeContact = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Telephone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typecontacts", x => x.Id_TypeContact);
                    table.ForeignKey(
                        name: "FK_typecontacts_telephones_Id_Telephone",
                        column: x => x.Id_Telephone,
                        principalTable: "telephones",
                        principalColumn: "Id_Telephone",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id_City = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameCity = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Region = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id_City);
                    table.ForeignKey(
                        name: "FK_cities_regions_Id_Region",
                        column: x => x.Id_Region,
                        principalTable: "regions",
                        principalColumn: "Id_Region");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contactconfiguration",
                columns: table => new
                {
                    id_contconfig = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Person = table.Column<int>(type: "int", nullable: false),
                    Id_TypeContact = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactconfiguration", x => x.id_contconfig);
                    table.ForeignKey(
                        name: "FK_contactconfiguration_typecontacts_Id_TypeContact",
                        column: x => x.Id_TypeContact,
                        principalTable: "typecontacts",
                        principalColumn: "Id_TypeContact",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orderservices",
                columns: table => new
                {
                    Id_OrderService = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DelyveryDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Id_City = table.Column<int>(type: "int", nullable: false),
                    Id_Vehicle = table.Column<int>(type: "int", nullable: false),
                    Id_Inspeccion = table.Column<int>(type: "int", nullable: false),
                    Id_State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderservices", x => x.Id_OrderService);
                    table.ForeignKey(
                        name: "FK_orderservices_cities_Id_City",
                        column: x => x.Id_City,
                        principalTable: "cities",
                        principalColumn: "Id_City",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderservices_state_Id_State",
                        column: x => x.Id_State,
                        principalTable: "state",
                        principalColumn: "Id_State",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Cc_Person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamePerson = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastNamePerson = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_TypePerson = table.Column<int>(type: "int", nullable: false),
                    Id_Contact = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Cc_Person);
                    table.ForeignKey(
                        name: "FK_Persons_contactconfiguration_Id_Contact",
                        column: x => x.Id_Contact,
                        principalTable: "contactconfiguration",
                        principalColumn: "id_contconfig",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_typepersons_Id_TypePerson",
                        column: x => x.Id_TypePerson,
                        principalTable: "typepersons",
                        principalColumn: "Id_typePerson",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "repairorders",
                columns: table => new
                {
                    Id_RepairOrder = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_DiagnosticMechanic = table.Column<int>(type: "int", nullable: false),
                    Id_OrderService = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repairorders", x => x.Id_RepairOrder);
                    table.ForeignKey(
                        name: "FK_repairorders_diagnosticmechanic_Id_DiagnosticMechanic",
                        column: x => x.Id_DiagnosticMechanic,
                        principalTable: "diagnosticmechanic",
                        principalColumn: "Id_DiagMechanic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_repairorders_orderservices_Id_OrderService",
                        column: x => x.Id_OrderService,
                        principalTable: "orderservices",
                        principalColumn: "Id_OrderService",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    Id_Address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nameneigborhood = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TypeWay = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuadranPrefix = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberWay = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameVenereableWay = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberPlate = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Pa = table.Column<int>(type: "int", nullable: false),
                    Id_CityA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.Id_Address);
                    table.ForeignKey(
                        name: "FK_addresses_Persons_Id_Pa",
                        column: x => x.Id_Pa,
                        principalTable: "Persons",
                        principalColumn: "Cc_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_addresses_cities_Id_CityA",
                        column: x => x.Id_CityA,
                        principalTable: "cities",
                        principalColumn: "Id_City",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employe",
                columns: table => new
                {
                    id_employe = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_PE = table.Column<int>(type: "int", nullable: true),
                    Id_Speciality = table.Column<int>(type: "int", nullable: false),
                    Id_Arl = table.Column<int>(type: "int", nullable: false),
                    Id_Eps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employe", x => x.id_employe);
                    table.ForeignKey(
                        name: "FK_employe_Persons_Id_PE",
                        column: x => x.Id_PE,
                        principalTable: "Persons",
                        principalColumn: "Cc_Person");
                    table.ForeignKey(
                        name: "FK_employe_arls_Id_Arl",
                        column: x => x.Id_Arl,
                        principalTable: "arls",
                        principalColumn: "Id_Arl",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employe_diagnosticmechanic_id_employe",
                        column: x => x.id_employe,
                        principalTable: "diagnosticmechanic",
                        principalColumn: "Id_DiagMechanic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employe_eps_Id_Eps",
                        column: x => x.Id_Eps,
                        principalTable: "eps",
                        principalColumn: "Id_Eps",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employe_rolemployes_id_employe",
                        column: x => x.id_employe,
                        principalTable: "rolemployes",
                        principalColumn: "Id_RolEmploye",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employe_specialities_Id_Speciality",
                        column: x => x.Id_Speciality,
                        principalTable: "specialities",
                        principalColumn: "Id_Speciality",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vehicle",
                columns: table => new
                {
                    Id_Vehicle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codplate = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    yearModel = table.Column<DateTime>(type: "date", nullable: false),
                    Id_Brand = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    Id_Person = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle", x => x.Id_Vehicle);
                    table.ForeignKey(
                        name: "FK_vehicle_Persons_Id_Person",
                        column: x => x.Id_Person,
                        principalTable: "Persons",
                        principalColumn: "Cc_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicle_brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brand",
                        principalColumn: "Id_Brand");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    Id_Bill = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_RepairOrder = table.Column<int>(type: "int", nullable: false),
                    TotalCostParts = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalService = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.Id_Bill);
                    table.ForeignKey(
                        name: "FK_bills_repairorders_Id_RepairOrder",
                        column: x => x.Id_RepairOrder,
                        principalTable: "repairorders",
                        principalColumn: "Id_RepairOrder",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "relpartsorder",
                columns: table => new
                {
                    Id_Relserviceorder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_RepairOrder = table.Column<int>(type: "int", nullable: false),
                    Id_SquareParts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relpartsorder", x => x.Id_Relserviceorder);
                    table.ForeignKey(
                        name: "FK_relpartsorder_repairorders_Id_RepairOrder",
                        column: x => x.Id_RepairOrder,
                        principalTable: "repairorders",
                        principalColumn: "Id_RepairOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relpartsorder_squareparts_Id_SquareParts",
                        column: x => x.Id_SquareParts,
                        principalTable: "squareparts",
                        principalColumn: "Id_SquareParts",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "relserviceorder",
                columns: table => new
                {
                    Id_Relserviceorder = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_RepairOrder = table.Column<int>(type: "int", nullable: false),
                    Id_Service = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relserviceorder", x => x.Id_Relserviceorder);
                    table.ForeignKey(
                        name: "FK_relserviceorder_repairorders_Id_RepairOrder",
                        column: x => x.Id_RepairOrder,
                        principalTable: "repairorders",
                        principalColumn: "Id_RepairOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relserviceorder_services_Id_Service",
                        column: x => x.Id_Service,
                        principalTable: "services",
                        principalColumn: "Id_Service",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inspeccion",
                columns: table => new
                {
                    Id_Inspeccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderServiceId = table.Column<int>(type: "int", nullable: true),
                    DateofEntry = table.Column<DateTime>(type: "date", nullable: false),
                    Diagnosticustomer = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Vehicle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspeccion", x => x.Id_Inspeccion);
                    table.ForeignKey(
                        name: "FK_inspeccion_orderservices_OrderServiceId",
                        column: x => x.OrderServiceId,
                        principalTable: "orderservices",
                        principalColumn: "Id_OrderService");
                    table.ForeignKey(
                        name: "FK_inspeccion_vehicle_Id_Vehicle",
                        column: x => x.Id_Vehicle,
                        principalTable: "vehicle",
                        principalColumn: "Id_Vehicle",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cabine",
                columns: table => new
                {
                    Id_cabine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Inspeccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cabine", x => x.Id_cabine);
                    table.ForeignKey(
                        name: "FK_cabine_inspeccion_Id_Inspeccion",
                        column: x => x.Id_Inspeccion,
                        principalTable: "inspeccion",
                        principalColumn: "Id_Inspeccion",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doors",
                columns: table => new
                {
                    Id_Door = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fowardleft = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Backdoorleft = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fowardright = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Backdoorright = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Trunk = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hood = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Inspeccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doors", x => x.Id_Door);
                    table.ForeignKey(
                        name: "FK_doors_inspeccion_Id_Inspeccion",
                        column: x => x.Id_Inspeccion,
                        principalTable: "inspeccion",
                        principalColumn: "Id_Inspeccion",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "radio",
                columns: table => new
                {
                    Id_Radio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameBrand = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Cabine = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_radio", x => x.Id_Radio);
                    table.ForeignKey(
                        name: "FK_radio_cabine_Id_Cabine",
                        column: x => x.Id_Cabine,
                        principalTable: "cabine",
                        principalColumn: "Id_cabine",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "upholstery",
                columns: table => new
                {
                    Id_upholstery = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ceiling = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    seating = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    carpet = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    others = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Cabine = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_upholstery", x => x.Id_upholstery);
                    table.ForeignKey(
                        name: "FK_upholstery_cabine_Id_Cabine",
                        column: x => x.Id_Cabine,
                        principalTable: "cabine",
                        principalColumn: "Id_cabine",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_addresses_Id_CityA",
                table: "addresses",
                column: "Id_CityA");

            migrationBuilder.CreateIndex(
                name: "IX_addresses_Id_Pa",
                table: "addresses",
                column: "Id_Pa");

            migrationBuilder.CreateIndex(
                name: "IX_bills_Id_RepairOrder",
                table: "bills",
                column: "Id_RepairOrder");

            migrationBuilder.CreateIndex(
                name: "IX_cabine_Id_Inspeccion",
                table: "cabine",
                column: "Id_Inspeccion");

            migrationBuilder.CreateIndex(
                name: "IX_cities_Id_Region",
                table: "cities",
                column: "Id_Region");

            migrationBuilder.CreateIndex(
                name: "IX_contactconfiguration_Id_TypeContact",
                table: "contactconfiguration",
                column: "Id_TypeContact");

            migrationBuilder.CreateIndex(
                name: "IX_doors_Id_Inspeccion",
                table: "doors",
                column: "Id_Inspeccion");

            migrationBuilder.CreateIndex(
                name: "IX_employe_Id_Arl",
                table: "employe",
                column: "Id_Arl");

            migrationBuilder.CreateIndex(
                name: "IX_employe_Id_Eps",
                table: "employe",
                column: "Id_Eps");

            migrationBuilder.CreateIndex(
                name: "IX_employe_Id_PE",
                table: "employe",
                column: "Id_PE");

            migrationBuilder.CreateIndex(
                name: "IX_employe_Id_Speciality",
                table: "employe",
                column: "Id_Speciality");

            migrationBuilder.CreateIndex(
                name: "IX_inspeccion_Id_Vehicle",
                table: "inspeccion",
                column: "Id_Vehicle");

            migrationBuilder.CreateIndex(
                name: "IX_inspeccion_OrderServiceId",
                table: "inspeccion",
                column: "OrderServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_orderservices_Id_City",
                table: "orderservices",
                column: "Id_City");

            migrationBuilder.CreateIndex(
                name: "IX_orderservices_Id_State",
                table: "orderservices",
                column: "Id_State");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Id_Contact",
                table: "Persons",
                column: "Id_Contact");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Id_TypePerson",
                table: "Persons",
                column: "Id_TypePerson");

            migrationBuilder.CreateIndex(
                name: "IX_radio_Id_Cabine",
                table: "radio",
                column: "Id_Cabine");

            migrationBuilder.CreateIndex(
                name: "IX_regions_Id_Pais",
                table: "regions",
                column: "Id_Pais");

            migrationBuilder.CreateIndex(
                name: "IX_relpartsorder_Id_RepairOrder",
                table: "relpartsorder",
                column: "Id_RepairOrder");

            migrationBuilder.CreateIndex(
                name: "IX_relpartsorder_Id_SquareParts",
                table: "relpartsorder",
                column: "Id_SquareParts");

            migrationBuilder.CreateIndex(
                name: "IX_relserviceorder_Id_RepairOrder",
                table: "relserviceorder",
                column: "Id_RepairOrder");

            migrationBuilder.CreateIndex(
                name: "IX_relserviceorder_Id_Service",
                table: "relserviceorder",
                column: "Id_Service");

            migrationBuilder.CreateIndex(
                name: "IX_repairorders_Id_DiagnosticMechanic",
                table: "repairorders",
                column: "Id_DiagnosticMechanic");

            migrationBuilder.CreateIndex(
                name: "IX_repairorders_Id_OrderService",
                table: "repairorders",
                column: "Id_OrderService");

            migrationBuilder.CreateIndex(
                name: "IX_rolemployes_Id_Employe",
                table: "rolemployes",
                column: "Id_Employe");

            migrationBuilder.CreateIndex(
                name: "IX_services_Id_ServiceFee",
                table: "services",
                column: "Id_ServiceFee");

            migrationBuilder.CreateIndex(
                name: "IX_squareparts_Id_Nit",
                table: "squareparts",
                column: "Id_Nit");

            migrationBuilder.CreateIndex(
                name: "IX_summaryfails_Id_DiagM",
                table: "summaryfails",
                column: "Id_DiagM");

            migrationBuilder.CreateIndex(
                name: "IX_typecontacts_Id_Telephone",
                table: "typecontacts",
                column: "Id_Telephone");

            migrationBuilder.CreateIndex(
                name: "IX_upholstery_Id_Cabine",
                table: "upholstery",
                column: "Id_Cabine");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_BrandId",
                table: "vehicle",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_Id_Person",
                table: "vehicle",
                column: "Id_Person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "doors");

            migrationBuilder.DropTable(
                name: "employe");

            migrationBuilder.DropTable(
                name: "radio");

            migrationBuilder.DropTable(
                name: "relpartsorder");

            migrationBuilder.DropTable(
                name: "relserviceorder");

            migrationBuilder.DropTable(
                name: "summaryfails");

            migrationBuilder.DropTable(
                name: "upholstery");

            migrationBuilder.DropTable(
                name: "arls");

            migrationBuilder.DropTable(
                name: "eps");

            migrationBuilder.DropTable(
                name: "rolemployes");

            migrationBuilder.DropTable(
                name: "specialities");

            migrationBuilder.DropTable(
                name: "squareparts");

            migrationBuilder.DropTable(
                name: "repairorders");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "cabine");

            migrationBuilder.DropTable(
                name: "rols");

            migrationBuilder.DropTable(
                name: "providers");

            migrationBuilder.DropTable(
                name: "diagnosticmechanic");

            migrationBuilder.DropTable(
                name: "servicefee");

            migrationBuilder.DropTable(
                name: "inspeccion");

            migrationBuilder.DropTable(
                name: "orderservices");

            migrationBuilder.DropTable(
                name: "vehicle");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "brand");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "contactconfiguration");

            migrationBuilder.DropTable(
                name: "typepersons");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "typecontacts");

            migrationBuilder.DropTable(
                name: "telephones");
        }
    }
}
