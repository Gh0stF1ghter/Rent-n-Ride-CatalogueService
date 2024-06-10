using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModels_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlateNumber = table.Column<string>(type: "text", nullable: false),
                    Odo = table.Column<int>(type: "integer", nullable: false),
                    RentCost = table.Column<double>(type: "double precision", nullable: false),
                    VehicleType = table.Column<int>(type: "integer", nullable: false),
                    VehicleState = table.Column<int>(type: "integer", nullable: false),
                    FuelType = table.Column<int>(type: "integer", nullable: false),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModelNameId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModels_ModelNameId",
                        column: x => x.ModelNameId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleClientHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClientHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClientHistories_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleClientHistories_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5b008041-4df4-40cb-8f00-ffc29eb8e685"), "Aston Martin" },
                    { new Guid("5dca51c2-3d93-40a6-afee-790ea3899860"), "Tesla" },
                    { new Guid("776d28bd-ae6c-476f-a321-cdc3ea00931c"), "Volkswagen" },
                    { new Guid("c62868c4-71c9-4ad2-82a9-618b38c80d1a"), "Bugatti" },
                    { new Guid("d454f765-c807-4a60-b1db-cff88e460d26"), "Land Rover" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "ModelNameId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("03731d14-a113-4878-bd23-516cf03d63de"), 2, new Guid("5e31aefa-72fe-4c11-af0e-11ba1054a28c"), null, 4577, "86RERA0W3BCY28910", 920.80160399828276, 0, 0 },
                    { new Guid("04c2e71f-7bda-4b77-9800-dd46186d8af5"), 3, new Guid("3f5be685-5eed-4ec0-ab9d-76ac35ee83b3"), null, 1224, "WADB27I9PDMZ95536", 3414.8072275115856, 3, 5 },
                    { new Guid("074e09fe-f404-415a-bceb-79c8a12cc1e4"), 1, new Guid("3f5be685-5eed-4ec0-ab9d-76ac35ee83b3"), null, 9072, "ZICD6NEO3VWL52643", 1933.3001468361665, 3, 5 },
                    { new Guid("0a02b8ce-a88c-4c5b-8eb5-e65a598eff13"), 0, new Guid("c7af8e4e-e164-4000-ab19-d8b9f9948143"), null, 176, "S6R4IBKA90P627399", 1738.7444190723797, 1, 5 },
                    { new Guid("0b38e02d-9872-4fdd-9521-7e7ba22f234b"), 3, new Guid("711c26ab-454c-4542-915e-2a70a92082e1"), null, 2454, "O4J1DN0ONDMK66032", 2549.2322100576034, 0, 3 },
                    { new Guid("0f3dd8f5-b482-44b4-af75-368421d06813"), 1, new Guid("f3007318-1810-4ee3-a2b2-dc2e14eb7d7f"), null, 8676, "HW7RG63G7YHE74402", 574.13337307729898, 2, 5 },
                    { new Guid("0fae6ceb-7114-4b3d-bd17-8c8d38f0cbd3"), 0, new Guid("685dd1a8-63a7-4a12-968e-bbc4a92ff173"), null, 7123, "WOLS0RYD05M521624", 1926.9386387511379, 2, 5 },
                    { new Guid("125ce4f3-c8bd-4072-9bae-c367df805948"), 0, new Guid("3b105b75-df01-4291-b368-49ef36ab365b"), null, 5607, "2RUMDKG3X0H512946", 2623.5382566469684, 1, 1 },
                    { new Guid("1375232d-b8ac-47c5-b099-4a354fa7ad52"), 1, new Guid("e638d14f-c8cf-450c-84e7-4c9c22647d92"), null, 2496, "VBHWD0DV81GW26846", 3019.6246043665133, 1, 3 },
                    { new Guid("13bd14fa-1615-46bc-8cd9-281d7b74adba"), 2, new Guid("0ba19463-601f-4438-918d-21d7ef7189f2"), null, 6830, "F0NYUC1SO4M915984", 1253.6758685411041, 0, 2 },
                    { new Guid("1a816388-8715-49ce-9508-bfe74b7290e0"), 1, new Guid("0ba19463-601f-4438-918d-21d7ef7189f2"), null, 5479, "Z3ZF5NJI37SQ24105", 2957.8072887964536, 3, 3 },
                    { new Guid("207a8da1-dca0-4d8a-95ab-502f9f9d2214"), 2, new Guid("207bea9b-026f-4512-98e0-ff4f01a2b537"), null, 7654, "DWY27KFDZUH062966", 2901.9360663332886, 1, 4 },
                    { new Guid("24879055-6eab-400f-8d8b-18a6c7ed8317"), 0, new Guid("f3007318-1810-4ee3-a2b2-dc2e14eb7d7f"), null, 9359, "Y5O0S9VSAQS244012", 2999.8341627167711, 2, 5 },
                    { new Guid("24bd0ce0-e7e8-4b68-ae57-b818bf924693"), 2, new Guid("b67f3a5a-a2fe-4085-8fe4-b18b2a61ba85"), null, 3580, "C987V3FA35O227772", 513.48295415859866, 1, 4 },
                    { new Guid("25c63b54-e029-4428-9df1-d6390452c05a"), 1, new Guid("17922849-ee18-4bb9-bc2e-cdc6649bb81f"), null, 9555, "LFUP8XJH3BWP22504", 982.18073119116332, 0, 2 },
                    { new Guid("25e39f6c-6011-4a4d-a24d-da7a8e6204a3"), 1, new Guid("96c398f5-b93d-4a0e-9066-46883793da29"), null, 8862, "T695V27LU7R773242", 3859.6455887920019, 2, 0 },
                    { new Guid("2af79e3e-6032-48fc-b619-67aa598ceef4"), 2, new Guid("3b105b75-df01-4291-b368-49ef36ab365b"), null, 5151, "X9KP9XHG1YFZ81438", 3211.2033982121638, 2, 4 },
                    { new Guid("2d3f0fee-aea8-4664-98a9-29e40e71bcf1"), 2, new Guid("60aca9ff-aac9-4040-9391-55df28873388"), null, 2560, "XO5VP048GFD174823", 3184.9345533321803, 1, 1 },
                    { new Guid("2d6b42d6-4a42-4dcc-8a60-b35046d131fa"), 3, new Guid("3f5be685-5eed-4ec0-ab9d-76ac35ee83b3"), null, 5273, "JXQYD5S4U0Y498347", 3287.1381140424064, 3, 2 },
                    { new Guid("30bae98c-62a4-4fea-a26d-bc042a5d869f"), 1, new Guid("4cd4ea74-1140-4632-b22b-2e0b7f2b4cbc"), null, 7484, "D0SBGX62DSS627260", 3885.0910593443123, 0, 0 },
                    { new Guid("325ce76d-2c54-4045-9dc3-389e9274cbb5"), 1, new Guid("e638d14f-c8cf-450c-84e7-4c9c22647d92"), null, 7612, "7ZACNALKBYM675490", 855.22809781323144, 0, 2 },
                    { new Guid("329e7cd8-e745-4bb3-8116-97fe79e29d75"), 0, new Guid("3f5be685-5eed-4ec0-ab9d-76ac35ee83b3"), null, 9207, "1702KZXDB7NP11950", 3763.1003701946693, 2, 1 },
                    { new Guid("415d2638-1d4d-4b06-a3aa-00292fe6881c"), 0, new Guid("1b6e905d-273e-4a7d-898f-b9462d72aceb"), null, 2876, "9RZ7UZEZIMN543692", 3523.4327253721176, 3, 1 },
                    { new Guid("41eccc68-25fc-4d7c-ba92-7e692e386507"), 0, new Guid("045a0660-c667-467d-a9f5-218b94917cb7"), null, 7354, "ABCRTV8N7PL548223", 2784.2563311290814, 1, 4 },
                    { new Guid("41fadc85-9745-4a76-b3fb-c323648a4c75"), 3, new Guid("9d2f620d-cede-4633-98f3-30660305b572"), null, 6564, "YC2HGVNF02WA31910", 2651.8790049287886, 0, 2 },
                    { new Guid("421dc1c6-4868-4d87-8171-9b3cda5c2f02"), 2, new Guid("711c26ab-454c-4542-915e-2a70a92082e1"), null, 9234, "ZWPB3E9PBAVF40731", 3078.685562707466, 0, 1 },
                    { new Guid("427771a3-0630-4895-b3ae-a000424df521"), 0, new Guid("ef3bfa56-4a8b-4508-b364-8c8799f66aff"), null, 3768, "WG6QJYHU9MG164401", 328.35382994430915, 0, 5 },
                    { new Guid("44d61d08-95c1-455f-9599-89232f878654"), 3, new Guid("c7af8e4e-e164-4000-ab19-d8b9f9948143"), null, 4341, "FOSLBZDAOPYS49327", 198.90810767547111, 0, 3 },
                    { new Guid("4d28809f-c983-4924-8f5a-0a459e7a336f"), 3, new Guid("73bf3011-edfc-46f1-b57b-2172cee60638"), null, 6736, "I1NQGQ5483DU23142", 1068.7894367972963, 1, 3 },
                    { new Guid("4e8f83b0-b6ab-4d0b-86e9-245a208a6581"), 1, new Guid("b67f3a5a-a2fe-4085-8fe4-b18b2a61ba85"), null, 312, "YQNP3L52F5O713013", 2929.6524546411647, 2, 1 },
                    { new Guid("51223408-98c5-4896-b3e1-4722ae936e7f"), 0, new Guid("045a0660-c667-467d-a9f5-218b94917cb7"), null, 6210, "G0ZREWV8F0WR20473", 3191.5864154152396, 3, 5 },
                    { new Guid("51f619eb-cc26-48fc-b4cf-cd74c596eb91"), 3, new Guid("0ba19463-601f-4438-918d-21d7ef7189f2"), null, 1036, "16UJLYRNVDD226194", 3642.2225130218148, 2, 5 },
                    { new Guid("522e30d3-294d-4792-941c-5d2b0252d248"), 2, new Guid("3b105b75-df01-4291-b368-49ef36ab365b"), null, 9304, "MZKGXHY7UWJP30469", 2270.8134118284688, 1, 1 },
                    { new Guid("544aeca0-1af7-481e-9b61-97b8cc8a4e92"), 3, new Guid("e638d14f-c8cf-450c-84e7-4c9c22647d92"), null, 8496, "0NXXD0ARMSRN87579", 3371.4293554519463, 3, 3 },
                    { new Guid("54ef6742-a18d-40ab-b4dd-d0c73d6264c4"), 0, new Guid("480bb511-60c3-4426-a4a1-b4b1eed47149"), null, 6752, "QLMOPCLSJLU612224", 2240.8635574109021, 1, 4 },
                    { new Guid("55cf63cd-18e6-4b5c-bae5-033fce711892"), 0, new Guid("1307a9fa-ee92-4a6a-b364-0dc149f9ccab"), null, 8421, "BGC893Y5D5WZ49562", 2931.1304547289778, 0, 4 },
                    { new Guid("560d8cc0-32b1-4b43-8348-9e968ea42824"), 1, new Guid("17922849-ee18-4bb9-bc2e-cdc6649bb81f"), null, 4956, "FLI7PD57Y1VT32924", 731.24447812648236, 3, 0 },
                    { new Guid("59feb581-d5bc-48c2-8d75-fa99d4b83907"), 3, new Guid("e638d14f-c8cf-450c-84e7-4c9c22647d92"), null, 7069, "GM7YDIY3ACHG41159", 2982.2890109524342, 2, 1 },
                    { new Guid("5b9f440a-b721-4047-839c-c7d469fcfe33"), 1, new Guid("9d2f620d-cede-4633-98f3-30660305b572"), null, 6481, "0YV5NTBZWPJM56432", 1535.3085269773578, 3, 2 },
                    { new Guid("5d72ff4c-a924-446e-9ed5-7883e88adc16"), 3, new Guid("5e31aefa-72fe-4c11-af0e-11ba1054a28c"), null, 9643, "NNCTXKI7BYEU57305", 1450.0993247842766, 1, 0 },
                    { new Guid("60877357-f5f1-4346-935d-a4cb92283785"), 1, new Guid("5e31aefa-72fe-4c11-af0e-11ba1054a28c"), null, 9895, "2XQU8F59NFPU41391", 3896.5926346559859, 2, 0 },
                    { new Guid("631e0698-21fb-4792-88a5-9d1936041f85"), 3, new Guid("685dd1a8-63a7-4a12-968e-bbc4a92ff173"), null, 1097, "QO84U9NSC0CU18614", 1515.1645624887394, 2, 1 },
                    { new Guid("65d28c10-fbbf-492b-85b5-5e1ff5ef21ce"), 1, new Guid("480bb511-60c3-4426-a4a1-b4b1eed47149"), null, 1444, "3XCMBAT59TY271159", 1159.4950588010049, 1, 1 },
                    { new Guid("67354298-8ecc-4711-a2d0-a08e6665cf32"), 0, new Guid("1307a9fa-ee92-4a6a-b364-0dc149f9ccab"), null, 4756, "ZXQR6GVG58RB26492", 2833.4910316943751, 3, 3 },
                    { new Guid("6f10e726-6b7f-4954-93d5-1acf7c0fc8a5"), 3, new Guid("9d2f620d-cede-4633-98f3-30660305b572"), null, 433, "0OG59Y5OWFBB47702", 3485.3123787761829, 0, 5 },
                    { new Guid("719d9a94-6396-46c2-bccb-f37e5850e368"), 3, new Guid("5e31aefa-72fe-4c11-af0e-11ba1054a28c"), null, 4915, "K3858ZH6WTWT60257", 2046.2989254449683, 1, 3 },
                    { new Guid("7262521e-02d0-46de-a145-f38039dbc46e"), 1, new Guid("73bf3011-edfc-46f1-b57b-2172cee60638"), null, 6634, "D8UZ5S98L0DP77162", 2758.6538148296409, 0, 4 },
                    { new Guid("739f4191-cb88-4b19-b585-f65b2535e441"), 0, new Guid("4cd4ea74-1140-4632-b22b-2e0b7f2b4cbc"), null, 5540, "9E1ED91KSAGC50321", 3654.276539796193, 1, 4 },
                    { new Guid("76a629b8-58ed-469a-917e-6680f1c23c7f"), 0, new Guid("96c398f5-b93d-4a0e-9066-46883793da29"), null, 3045, "F0CUWGIGX2Y164001", 1554.7048440151732, 2, 2 },
                    { new Guid("78c04003-030d-4f4e-93db-07daa2f97aff"), 2, new Guid("ef3bfa56-4a8b-4508-b364-8c8799f66aff"), null, 2478, "J1FLTGPFD1KI55681", 1746.1340860738721, 1, 0 },
                    { new Guid("7babc78f-9ae3-4922-b739-4fc4789a6e8d"), 3, new Guid("60aca9ff-aac9-4040-9391-55df28873388"), null, 7565, "W0ZXHL7MLSCX42387", 2143.8614546465451, 1, 5 },
                    { new Guid("7bbd2432-5ca9-4189-8ec2-685f619eb736"), 0, new Guid("207bea9b-026f-4512-98e0-ff4f01a2b537"), null, 118, "8ZGB2AAK5LYQ19981", 596.84747687107665, 2, 1 },
                    { new Guid("81e18285-870b-403d-bdfd-879ac4612df0"), 1, new Guid("9d2f620d-cede-4633-98f3-30660305b572"), null, 6577, "ID4UE1PAEKO050763", 1423.1924897213632, 2, 1 },
                    { new Guid("852e5b35-8a47-4ea4-912e-8a35ad1950a2"), 1, new Guid("4cd4ea74-1140-4632-b22b-2e0b7f2b4cbc"), null, 8036, "T3CW8L8LGZNF40195", 3218.492434978562, 1, 3 },
                    { new Guid("8569824e-e474-4425-856f-501b6f79792e"), 1, new Guid("53e9f479-9973-43b8-a5cd-90625c7eabc5"), null, 1919, "MCB45WAV1MWO72086", 826.39754475018856, 2, 1 },
                    { new Guid("879c06e9-35fa-47a5-ac0d-4370e3cec618"), 1, new Guid("fda150a7-4b1d-4953-8768-80896ec8631f"), null, 5875, "F1MBQ2VWQTID16281", 3843.9054279411207, 2, 2 },
                    { new Guid("8ea7d4c0-a523-4999-97f7-60db1dfadb5c"), 0, new Guid("1b6e905d-273e-4a7d-898f-b9462d72aceb"), null, 9979, "EGZVOXZAG2VD85447", 1481.0709757315565, 3, 3 },
                    { new Guid("9102199f-d8fb-427e-a7bd-2414cab3105d"), 2, new Guid("1b6e905d-273e-4a7d-898f-b9462d72aceb"), null, 8213, "PKS9XTXUZ1KE69388", 3998.4984059727349, 2, 2 },
                    { new Guid("92a35967-5fdf-4ff7-83a2-978a3669b153"), 1, new Guid("045a0660-c667-467d-a9f5-218b94917cb7"), null, 3632, "BVGB5HWQABAA24820", 266.6718167658978, 0, 3 },
                    { new Guid("94095dc1-9fb8-43e2-ab35-2ab081072887"), 0, new Guid("f3007318-1810-4ee3-a2b2-dc2e14eb7d7f"), null, 4422, "9RN8C7H3IJIF76822", 1024.4767899987105, 1, 2 },
                    { new Guid("94d0da35-2ca9-48d0-9e42-432b388d5982"), 0, new Guid("c7af8e4e-e164-4000-ab19-d8b9f9948143"), null, 2310, "7B2ENPP2HNVT32683", 1664.4524928159774, 3, 1 },
                    { new Guid("96d7eda1-4502-4764-a2f7-2db676fa571b"), 1, new Guid("f3007318-1810-4ee3-a2b2-dc2e14eb7d7f"), null, 6645, "FCP4BI2PJRPC86150", 3486.9123650528713, 0, 3 },
                    { new Guid("974a2fdd-5ed2-40aa-8ff8-5b3f74892b9f"), 0, new Guid("fda150a7-4b1d-4953-8768-80896ec8631f"), null, 9411, "E2ANHS79UUAU29941", 3556.468228538025, 0, 0 },
                    { new Guid("97bdb137-6f24-4a37-940f-5c32ebad9377"), 1, new Guid("711c26ab-454c-4542-915e-2a70a92082e1"), null, 2803, "BGE6MSZS4EJN52234", 3807.5736378027736, 2, 4 },
                    { new Guid("98f40651-0ace-44fc-a7ee-12f5668db53e"), 1, new Guid("0f06ad73-2b3c-4b8c-8f42-b9354331746a"), null, 1507, "LQMJ17UY1SVI92581", 3043.7465444721602, 0, 1 },
                    { new Guid("9a7ff4a3-6c56-4b7f-8690-80beb29d6b28"), 3, new Guid("480bb511-60c3-4426-a4a1-b4b1eed47149"), null, 8416, "3D0OQR7DASOS94824", 1791.6767311796493, 0, 0 },
                    { new Guid("9af18c7c-1cbb-46e9-9be0-fdc945cd0b39"), 3, new Guid("1307a9fa-ee92-4a6a-b364-0dc149f9ccab"), null, 6308, "K0V37423PCUD76565", 906.9755518995546, 0, 1 },
                    { new Guid("a02ecf19-58c6-456a-86ba-5245fc51b5e5"), 0, new Guid("ef3bfa56-4a8b-4508-b364-8c8799f66aff"), null, 5249, "NX2O3BG3DSVO98086", 3993.4870160639866, 3, 2 },
                    { new Guid("a11d7714-4740-40d8-a988-1671bef7acef"), 3, new Guid("60aca9ff-aac9-4040-9391-55df28873388"), null, 362, "LV28PWADGAJZ24047", 352.55275029797463, 0, 2 },
                    { new Guid("a18fe4be-8d4b-4062-ac21-3a1951cdb210"), 0, new Guid("60aca9ff-aac9-4040-9391-55df28873388"), null, 5352, "SE485FWEJLRJ85961", 3000.0827988233987, 3, 2 },
                    { new Guid("a42ef64e-4ab9-412a-a73b-f15d0392763e"), 0, new Guid("53e9f479-9973-43b8-a5cd-90625c7eabc5"), null, 5956, "6UZ9I26X30MN61221", 1193.8248733587798, 1, 4 },
                    { new Guid("a5af9161-fb9a-4f64-8ed7-77334ce50540"), 3, new Guid("480bb511-60c3-4426-a4a1-b4b1eed47149"), null, 5925, "BQ2AGIUGE8I089108", 2147.9898288236591, 3, 3 },
                    { new Guid("a79ca995-706c-4dd0-a115-03e0c6bac38f"), 2, new Guid("685dd1a8-63a7-4a12-968e-bbc4a92ff173"), null, 291, "0FF1ODELZ0S890883", 3330.1715833008529, 0, 4 },
                    { new Guid("a8b6a695-63ed-42f1-99b8-536578f190b4"), 2, new Guid("3f5be685-5eed-4ec0-ab9d-76ac35ee83b3"), null, 7688, "24B3R65O6YPP17508", 2193.8275760033976, 3, 3 },
                    { new Guid("ab6e7c94-f4cf-4824-a165-bc0cd0cf8901"), 2, new Guid("045a0660-c667-467d-a9f5-218b94917cb7"), null, 2801, "J1K7RLRKWTPA80457", 798.97899923769523, 2, 1 },
                    { new Guid("b41258a6-7b9f-48e2-b422-d1373c67a34b"), 1, new Guid("1b6e905d-273e-4a7d-898f-b9462d72aceb"), null, 4015, "1FBH0FFILHQ696717", 2361.9559861493999, 1, 0 },
                    { new Guid("b4be3b67-fe66-41a4-8ef5-ed9bd22925b9"), 0, new Guid("4cd4ea74-1140-4632-b22b-2e0b7f2b4cbc"), null, 9277, "Y73XI7BXYNNS60006", 3481.0955700905165, 2, 0 },
                    { new Guid("b533a733-4300-4b7d-9959-ddef9134f33a"), 1, new Guid("96c398f5-b93d-4a0e-9066-46883793da29"), null, 4612, "AUL9XGEKOPFQ21960", 724.5328908453539, 3, 4 },
                    { new Guid("b813cf38-b260-4b60-b72f-53e12be74aa0"), 2, new Guid("53e9f479-9973-43b8-a5cd-90625c7eabc5"), null, 3825, "K67VWRVHPTHP12896", 2357.9096282830551, 2, 2 },
                    { new Guid("ba541ce7-0ef4-44ab-adca-ea4d7143b148"), 2, new Guid("1307a9fa-ee92-4a6a-b364-0dc149f9ccab"), null, 272, "VBW7O65B1LPP15178", 3632.5208386978384, 0, 5 },
                    { new Guid("bc2db9d5-da5a-40e9-b671-24cfb2b20a33"), 0, new Guid("4cd4ea74-1140-4632-b22b-2e0b7f2b4cbc"), null, 3671, "F54WFWYLW5NZ11799", 378.76980393262204, 3, 4 },
                    { new Guid("bdbc9283-be4f-48df-ac30-0ab4232b5389"), 2, new Guid("0f06ad73-2b3c-4b8c-8f42-b9354331746a"), null, 9307, "L1NXCRQIY4AL26835", 3085.5994566783834, 2, 1 },
                    { new Guid("be613724-a2e7-46e8-93ec-4d973443fe39"), 3, new Guid("3b105b75-df01-4291-b368-49ef36ab365b"), null, 769, "5TZBOXCEYXTF23506", 1618.8292636736353, 2, 1 },
                    { new Guid("c0d9ec23-4d32-44e4-84ce-a7ea91c67137"), 1, new Guid("ef3bfa56-4a8b-4508-b364-8c8799f66aff"), null, 7045, "CAVGHRF5I2FV56606", 3698.5342667667373, 1, 3 },
                    { new Guid("c4ed8612-f1d0-46c9-bcca-54cf55c5b7a3"), 0, new Guid("685dd1a8-63a7-4a12-968e-bbc4a92ff173"), null, 6190, "R1L1308AJGJO90896", 1037.1510423281936, 0, 1 },
                    { new Guid("c5ba0f52-b471-42d4-ace8-af8a0967b022"), 3, new Guid("fda150a7-4b1d-4953-8768-80896ec8631f"), null, 1143, "623LO97SJ8SD98758", 1388.7965230039263, 0, 0 },
                    { new Guid("c619557b-ccc2-4399-8d07-eb6dce5d8a0d"), 0, new Guid("17922849-ee18-4bb9-bc2e-cdc6649bb81f"), null, 177, "42771DYR9UO250924", 3623.9777516894619, 3, 0 },
                    { new Guid("c691251f-e6f5-4186-a090-15f7faf2cd60"), 1, new Guid("53e9f479-9973-43b8-a5cd-90625c7eabc5"), null, 8990, "2JFMZ987L3TZ34989", 1666.3880638761057, 0, 1 },
                    { new Guid("c7523284-6409-4274-b289-b7872ddf849f"), 1, new Guid("96c398f5-b93d-4a0e-9066-46883793da29"), null, 6408, "XZ4TZU7PHLS889366", 2931.1471014519834, 1, 4 },
                    { new Guid("c7f116ec-606b-46c2-9d15-47a4d925dcf8"), 0, new Guid("711c26ab-454c-4542-915e-2a70a92082e1"), null, 7567, "XU1Z2578BVR682115", 3144.417811752975, 2, 3 },
                    { new Guid("c965bcb4-a504-4e01-83fa-d219090a118b"), 0, new Guid("96c398f5-b93d-4a0e-9066-46883793da29"), null, 2163, "GZP4SSBUMVUB68310", 161.62017887243178, 2, 5 },
                    { new Guid("c9e6e757-197b-4111-b737-88ed60fe643d"), 3, new Guid("fda150a7-4b1d-4953-8768-80896ec8631f"), null, 3475, "Q7K0UK346NOC17388", 3210.1648674100634, 2, 0 },
                    { new Guid("cc487a21-e721-4758-9464-68155e833552"), 3, new Guid("17922849-ee18-4bb9-bc2e-cdc6649bb81f"), null, 8874, "8VN3SO0QR9HW37218", 1567.9255105231121, 1, 5 },
                    { new Guid("cc517a5d-c18c-471f-a577-8461a304fa4f"), 0, new Guid("53e9f479-9973-43b8-a5cd-90625c7eabc5"), null, 5121, "GPXV9B8K2NTV79075", 3829.3632267147586, 0, 4 },
                    { new Guid("d0e8c6cc-6e94-42ba-8798-bec6d7d35b58"), 1, new Guid("207bea9b-026f-4512-98e0-ff4f01a2b537"), null, 532, "NMOE2XA3R4PZ74463", 3129.6258845432344, 0, 5 },
                    { new Guid("d21f403c-71d6-4661-988b-740965bc85b5"), 0, new Guid("0f06ad73-2b3c-4b8c-8f42-b9354331746a"), null, 119, "Z0NVXS192VV437111", 589.22028646876788, 1, 5 },
                    { new Guid("d2ac00a2-c424-4031-ae7d-5884037feb6f"), 1, new Guid("73bf3011-edfc-46f1-b57b-2172cee60638"), null, 7228, "NHUM2HOVPSQY19631", 3091.1669457989328, 3, 2 },
                    { new Guid("d2bbc9cd-2463-4e39-91b0-2d8c8dc6e0d5"), 1, new Guid("b67f3a5a-a2fe-4085-8fe4-b18b2a61ba85"), null, 3251, "MXLCT7KD22KW59622", 1063.1398231841963, 1, 2 },
                    { new Guid("d4be7b45-e0fb-46ec-8a41-b97e89d7009b"), 3, new Guid("3b105b75-df01-4291-b368-49ef36ab365b"), null, 3725, "0HE6RVK6L4EN62472", 2068.5998523767553, 3, 1 },
                    { new Guid("d65c5123-13a9-4d6c-81e7-30d0944e730e"), 0, new Guid("0ba19463-601f-4438-918d-21d7ef7189f2"), null, 9534, "RNBTDZWUL4X347151", 2720.3915311977535, 2, 0 },
                    { new Guid("db106bbe-2460-4a88-bcee-e23ef136851e"), 2, new Guid("1307a9fa-ee92-4a6a-b364-0dc149f9ccab"), null, 3014, "N46OAGPPQZG936017", 3747.3817730490578, 0, 5 },
                    { new Guid("dc2b26dc-ea31-40b5-8352-942ff7330cb4"), 0, new Guid("17922849-ee18-4bb9-bc2e-cdc6649bb81f"), null, 8004, "KPPV71SYZ4R517309", 3838.8994256990891, 0, 2 },
                    { new Guid("de755ef7-5a5a-4c14-ae20-c98844521e13"), 3, new Guid("045a0660-c667-467d-a9f5-218b94917cb7"), null, 4082, "F2Z99RSY3NV854136", 3364.9554346951354, 3, 3 },
                    { new Guid("de79f9b4-29fd-48fc-9077-4e68b5ed7403"), 1, new Guid("1b6e905d-273e-4a7d-898f-b9462d72aceb"), null, 7463, "IGHI2KWSCNPN24505", 3949.3047000777365, 0, 0 },
                    { new Guid("e08b653d-ed5d-48a7-b6a0-20a0b54f8d3e"), 0, new Guid("b67f3a5a-a2fe-4085-8fe4-b18b2a61ba85"), null, 5429, "NZXDBUB7TLFX47324", 3976.4259236595271, 2, 2 },
                    { new Guid("e155cc83-379e-45ad-987a-f10a08ec28bd"), 3, new Guid("c7af8e4e-e164-4000-ab19-d8b9f9948143"), null, 6824, "XWS60NL0U0ED53537", 2222.6173921477207, 3, 0 },
                    { new Guid("e16882c2-3218-447e-a572-c0cd05a030bf"), 1, new Guid("c7af8e4e-e164-4000-ab19-d8b9f9948143"), null, 9176, "OIOINCFPXKIG31743", 1925.3782783598947, 2, 3 },
                    { new Guid("e498387a-0011-4591-8038-5793702a477d"), 3, new Guid("207bea9b-026f-4512-98e0-ff4f01a2b537"), null, 9367, "SQGXWNFLNUNM25769", 313.89020985654224, 0, 5 },
                    { new Guid("e6ef63ba-f333-490a-96d8-06c0877e6f57"), 2, new Guid("5e31aefa-72fe-4c11-af0e-11ba1054a28c"), null, 5918, "IS40T9VP7IE790020", 1547.1072552505486, 1, 0 },
                    { new Guid("e767a355-7d62-41d2-817a-e1d697bc98fb"), 3, new Guid("711c26ab-454c-4542-915e-2a70a92082e1"), null, 180, "XXTUYEN9LPBS87038", 1724.5586425428137, 0, 0 },
                    { new Guid("ea4d6c5c-200e-457f-b684-955df22e7102"), 2, new Guid("0f06ad73-2b3c-4b8c-8f42-b9354331746a"), null, 1679, "K8LG1F0P7EXR51136", 3846.9966189113384, 2, 2 },
                    { new Guid("eb5bccb7-8d44-4b74-84cd-72af59159e7f"), 1, new Guid("207bea9b-026f-4512-98e0-ff4f01a2b537"), null, 5033, "7S3E6CTASRPR67112", 1935.5544671244968, 0, 3 },
                    { new Guid("ec20d206-6794-4a34-af73-c671ee3d52b1"), 1, new Guid("ef3bfa56-4a8b-4508-b364-8c8799f66aff"), null, 675, "WONMXYKOB8NA96699", 3673.2493689726643, 3, 3 },
                    { new Guid("ec620545-aecc-489b-9c2b-d9d2bb75f7d6"), 0, new Guid("0f06ad73-2b3c-4b8c-8f42-b9354331746a"), null, 7488, "V0PPCF715DAX70212", 3056.430267150402, 0, 5 },
                    { new Guid("ee515fd3-5d59-42d9-9cd8-62c9032584d2"), 1, new Guid("fda150a7-4b1d-4953-8768-80896ec8631f"), null, 1333, "RCXW1JBVECQZ81693", 3577.2689417802139, 3, 2 },
                    { new Guid("eff218db-9f91-44e2-9546-f7eb9d8f47bb"), 1, new Guid("f3007318-1810-4ee3-a2b2-dc2e14eb7d7f"), null, 6642, "QQE6KCZAOFSM84913", 3272.3301054964804, 0, 5 },
                    { new Guid("eff3f9ce-4728-4896-a996-84987a162377"), 1, new Guid("b67f3a5a-a2fe-4085-8fe4-b18b2a61ba85"), null, 4300, "2IF697THITA433008", 1540.0478001242222, 3, 5 },
                    { new Guid("f056a844-b6e6-4461-afc4-69d0db703276"), 0, new Guid("e638d14f-c8cf-450c-84e7-4c9c22647d92"), null, 8980, "KU4913GFR5Q196704", 2023.312049665758, 2, 3 },
                    { new Guid("f500dd57-f32c-4e17-bd60-e15ba182817c"), 1, new Guid("73bf3011-edfc-46f1-b57b-2172cee60638"), null, 3312, "AJC49BYEO1GD89619", 2692.9511487564919, 1, 4 },
                    { new Guid("f64995df-e18f-4f8d-a9d0-80ad744f8b7a"), 3, new Guid("685dd1a8-63a7-4a12-968e-bbc4a92ff173"), null, 1154, "UVMQA06VG3GS12953", 2520.8405355979976, 0, 3 },
                    { new Guid("f93bd62b-de24-439d-b846-b86741be0623"), 0, new Guid("0ba19463-601f-4438-918d-21d7ef7189f2"), null, 503, "7MNNR0Z8OENH59455", 3925.337429266775, 3, 4 },
                    { new Guid("f996c0e2-5f90-4385-9468-5383c6eccf98"), 3, new Guid("9d2f620d-cede-4633-98f3-30660305b572"), null, 4832, "K0VILEF65MCV67363", 1741.4995694378238, 2, 1 },
                    { new Guid("fb4d5825-5545-4cd9-99aa-6f29e9a51f08"), 1, new Guid("73bf3011-edfc-46f1-b57b-2172cee60638"), null, 7643, "APEYXPJ0P0RS83024", 1326.7975448476566, 1, 4 },
                    { new Guid("fd0a6109-6ace-405c-8f6a-fdc146d5b638"), 1, new Guid("60aca9ff-aac9-4040-9391-55df28873388"), null, 9405, "U55IBZTQ00M929309", 2364.3258750182104, 3, 4 },
                    { new Guid("feb3b8d0-424f-4dce-a8bd-6b8b08502b70"), 0, new Guid("480bb511-60c3-4426-a4a1-b4b1eed47149"), null, 6365, "X6OA3YVB8BJ824139", 3774.4625797916024, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("053d0480-9181-4381-9614-662a6fbec0e9"), "Yoshiko46@yahoo.com", "Nicholas", "Hane", "1-313-819-0222", new Guid("879c06e9-35fa-47a5-ac0d-4370e3cec618") },
                    { new Guid("0644896b-4bf2-4002-8d93-283389af02ae"), "Carissa.Abbott@gmail.com", "Seth", "Quitzon", "738.644.0712 x15805", new Guid("e08b653d-ed5d-48a7-b6a0-20a0b54f8d3e") },
                    { new Guid("07c9b4b9-20e2-4146-beff-28decafbeedc"), "Judd.Kemmer@hotmail.com", "Karlie", "Hodkiewicz", "912.262.9320", new Guid("329e7cd8-e745-4bb3-8116-97fe79e29d75") },
                    { new Guid("0b144bff-f703-4828-aef8-d2f091048a51"), "Anya95@yahoo.com", "Clovis", "Gusikowski", "1-924-883-6715 x1419", new Guid("55cf63cd-18e6-4b5c-bae5-033fce711892") },
                    { new Guid("0dfd3233-e825-4b92-8e5d-0ca2a3977bfa"), "Dameon39@yahoo.com", "Elisha", "Ondricka", "654.228.8892 x864", new Guid("f93bd62b-de24-439d-b846-b86741be0623") },
                    { new Guid("1241e588-ea38-4321-8ac2-3d7e2866ad82"), "Thad_Koch83@yahoo.com", "Carlee", "Nikolaus", "1-590-960-5305 x9226", new Guid("c691251f-e6f5-4186-a090-15f7faf2cd60") },
                    { new Guid("13f89e41-f555-4284-bcbb-45de6ed408d6"), "Ryley88@hotmail.com", "Lowell", "Hintz", "1-974-555-9292", new Guid("074e09fe-f404-415a-bceb-79c8a12cc1e4") },
                    { new Guid("14231614-aefa-4b57-8c11-a997a2d7cc16"), "Christophe64@yahoo.com", "Gunnar", "Schamberger", "1-390-286-3721 x77950", new Guid("41eccc68-25fc-4d7c-ba92-7e692e386507") },
                    { new Guid("14e40a2e-4c56-4ba5-a150-f21a23950e1c"), "Angelo_Ernser@yahoo.com", "Ellis", "Morar", "(481) 434-9489", new Guid("ba541ce7-0ef4-44ab-adca-ea4d7143b148") },
                    { new Guid("152a97e4-3cd5-4aa2-b5cd-32cabdfb9f2b"), "Dovie_Balistreri5@yahoo.com", "Jerrold", "Halvorson", "(603) 824-8929", new Guid("e498387a-0011-4591-8038-5793702a477d") },
                    { new Guid("1807bb73-2ff6-44cb-b1e1-da817cc174c9"), "Tia_Ward@hotmail.com", "Michele", "Doyle", "726.551.2873 x60778", new Guid("be613724-a2e7-46e8-93ec-4d973443fe39") },
                    { new Guid("1af5cb59-e058-46be-9fca-c1e9649ea9d6"), "Eleonore_Dach22@hotmail.com", "Alba", "Dickens", "(209) 639-5458 x045", new Guid("c9e6e757-197b-4111-b737-88ed60fe643d") },
                    { new Guid("1b2f68d1-feca-47e1-b605-836ee473774c"), "Litzy.Erdman@hotmail.com", "Leann", "Waelchi", "1-447-737-6809 x1885", new Guid("65d28c10-fbbf-492b-85b5-5e1ff5ef21ce") },
                    { new Guid("1b663253-6ad5-4916-a0f2-0b8c038b5afe"), "Oda_Lehner20@yahoo.com", "Rod", "Wilderman", "(792) 739-8748 x6103", new Guid("eff3f9ce-4728-4896-a996-84987a162377") },
                    { new Guid("21be73d3-2293-4bd6-8a4f-c9f2e3eca845"), "Summer_Wisozk@hotmail.com", "Calista", "Connelly", "1-537-670-8406", new Guid("30bae98c-62a4-4fea-a26d-bc042a5d869f") },
                    { new Guid("2207c5cf-91b6-4712-93cd-d14ae0fbc347"), "Orval65@gmail.com", "Ben", "Treutel", "349.753.5691", new Guid("51223408-98c5-4896-b3e1-4722ae936e7f") },
                    { new Guid("2479f2cd-23fc-42db-8c2f-8d9b0f7478af"), "Americo75@gmail.com", "Mable", "Parker", "568-592-5823 x0734", new Guid("d65c5123-13a9-4d6c-81e7-30d0944e730e") },
                    { new Guid("25d4f511-a176-4124-93f9-7d7dc1df46f9"), "Alejandra.Jones73@yahoo.com", "Cleo", "Moore", "1-330-712-7619 x249", new Guid("427771a3-0630-4895-b3ae-a000424df521") },
                    { new Guid("29798595-17e0-4ce8-9d58-cc59db906e45"), "Felicita.Mayer46@hotmail.com", "Ezra", "Cruickshank", "210.344.6350 x13331", new Guid("c5ba0f52-b471-42d4-ace8-af8a0967b022") },
                    { new Guid("2b411db1-b4bb-4805-86b5-68b6361d255a"), "Nicholas.Nikolaus93@hotmail.com", "Jeffery", "Dibbert", "1-847-589-2204 x24327", new Guid("9a7ff4a3-6c56-4b7f-8690-80beb29d6b28") },
                    { new Guid("2c635672-513e-45d7-b52b-c65b0f9bdaf3"), "Bernardo3@hotmail.com", "Mina", "Heidenreich", "365.384.8218 x53543", new Guid("fb4d5825-5545-4cd9-99aa-6f29e9a51f08") },
                    { new Guid("303e073b-390d-444a-9829-67f0bb263342"), "Keely.White66@hotmail.com", "Ines", "Sanford", "295.946.6223 x47051", new Guid("e16882c2-3218-447e-a572-c0cd05a030bf") },
                    { new Guid("3062cc59-318b-45cb-99aa-4bf441c84484"), "Amber85@hotmail.com", "Paxton", "Abshire", "1-958-977-8359 x16962", new Guid("a02ecf19-58c6-456a-86ba-5245fc51b5e5") },
                    { new Guid("308705db-77fd-45f5-a30d-bdd6597ec16f"), "Fred19@gmail.com", "Ciara", "Farrell", "457-455-0638 x8444", new Guid("5d72ff4c-a924-446e-9ed5-7883e88adc16") },
                    { new Guid("32203620-622a-404e-ad7b-740bbced2f8b"), "Vaughn_Lowe@hotmail.com", "Webster", "Rosenbaum", "309.205.0611 x48538", new Guid("c7523284-6409-4274-b289-b7872ddf849f") },
                    { new Guid("331a3844-cb8b-40b0-a304-d9e6c98156fb"), "Samir77@gmail.com", "Hattie", "Sporer", "715-404-6667 x913", new Guid("41fadc85-9745-4a76-b3fb-c323648a4c75") },
                    { new Guid("36f04c25-ee83-4b17-be75-63add74ca148"), "Connor59@gmail.com", "Velda", "Bashirian", "523-221-2317", new Guid("78c04003-030d-4f4e-93db-07daa2f97aff") },
                    { new Guid("37858e10-0f36-40e3-9e58-b8212cf0f8b7"), "Felix55@yahoo.com", "Jermaine", "Bins", "754-824-0953", new Guid("f056a844-b6e6-4461-afc4-69d0db703276") },
                    { new Guid("38efd438-db0b-4828-950e-2cb0318a7ef6"), "Herbert.McKenzie@hotmail.com", "Leann", "Block", "1-344-561-5654 x940", new Guid("415d2638-1d4d-4b06-a3aa-00292fe6881c") },
                    { new Guid("3a4b3c64-38b2-4d79-a64a-b9872eacc5d5"), "Arne_Marks98@yahoo.com", "Eunice", "Hansen", "1-431-238-3475 x35336", new Guid("d4be7b45-e0fb-46ec-8a41-b97e89d7009b") },
                    { new Guid("3bea81bb-f18b-413a-bb1a-5b101106258a"), "Myriam.Berge@hotmail.com", "Taya", "Welch", "874-349-8036", new Guid("c4ed8612-f1d0-46c9-bcca-54cf55c5b7a3") },
                    { new Guid("3c31a684-1eb8-4109-aab2-7b0d389883e6"), "Teagan.Mayer43@hotmail.com", "Theresia", "Hauck", "1-610-360-8994 x311", new Guid("98f40651-0ace-44fc-a7ee-12f5668db53e") },
                    { new Guid("3f574d66-49d7-4443-9014-4574798237c1"), "Leonard14@gmail.com", "Dante", "Mayer", "973-562-7402", new Guid("1375232d-b8ac-47c5-b099-4a354fa7ad52") },
                    { new Guid("413cf537-86c3-4618-a1c1-93df056a5cc3"), "Yesenia.Schaefer61@yahoo.com", "Annie", "Heidenreich", "955.757.8406 x75047", new Guid("7babc78f-9ae3-4922-b739-4fc4789a6e8d") },
                    { new Guid("424c438a-2a1d-4544-aa67-35c4827f3c5d"), "Annetta24@hotmail.com", "Kaela", "Cummings", "285-342-7075 x4911", new Guid("207a8da1-dca0-4d8a-95ab-502f9f9d2214") },
                    { new Guid("46e7e385-119d-43cf-822f-106d34c2f826"), "Colin.Towne@hotmail.com", "Marlene", "Padberg", "601.591.3281", new Guid("325ce76d-2c54-4045-9dc3-389e9274cbb5") },
                    { new Guid("46f9ed61-6e9b-4ea6-9040-dec720990f3d"), "Dillan.Batz@hotmail.com", "Graham", "Torphy", "705.620.4118 x3282", new Guid("f996c0e2-5f90-4385-9468-5383c6eccf98") },
                    { new Guid("46fa881c-81d5-4051-8ef7-f23f6255a69d"), "Gisselle.Roob4@hotmail.com", "Gloria", "Stokes", "1-648-984-6056 x44663", new Guid("bc2db9d5-da5a-40e9-b671-24cfb2b20a33") },
                    { new Guid("4a654da1-f4ea-4646-91d9-eb985b0b182b"), "Marjory70@yahoo.com", "Onie", "Ledner", "1-245-316-6842", new Guid("9af18c7c-1cbb-46e9-9be0-fdc945cd0b39") },
                    { new Guid("4cad2b26-187d-4ee6-b188-fb82d0bd8ad7"), "Israel.Runolfsson@yahoo.com", "Torrance", "Christiansen", "(403) 867-3342 x2396", new Guid("719d9a94-6396-46c2-bccb-f37e5850e368") },
                    { new Guid("4e949009-619d-4cd3-8fd1-b991baf4b43e"), "Barbara8@yahoo.com", "Mellie", "Windler", "(209) 320-7713", new Guid("b813cf38-b260-4b60-b72f-53e12be74aa0") },
                    { new Guid("4fc91f70-eb37-42f2-bf5b-3f1e28791b4e"), "Jamir67@yahoo.com", "Francesca", "Hilpert", "219-423-5030 x540", new Guid("de755ef7-5a5a-4c14-ae20-c98844521e13") },
                    { new Guid("54e2acde-a239-4860-ba60-9cea3d8ea7b3"), "Martina_Durgan@gmail.com", "Roman", "Marks", "(214) 424-9352 x782", new Guid("631e0698-21fb-4792-88a5-9d1936041f85") },
                    { new Guid("5589822d-7868-4275-95a2-3e2075e77079"), "Ida11@hotmail.com", "Brendon", "Corwin", "1-981-791-4607", new Guid("24879055-6eab-400f-8d8b-18a6c7ed8317") },
                    { new Guid("5686b29e-9079-4715-a3f2-14e0ff8eac1e"), "America48@yahoo.com", "Odie", "Thompson", "746-926-8846", new Guid("2d3f0fee-aea8-4664-98a9-29e40e71bcf1") },
                    { new Guid("5761f53a-497f-46fa-a09f-a7bf33e8f569"), "Beverly.Lakin@gmail.com", "Eddie", "Wilkinson", "1-539-592-8544", new Guid("a18fe4be-8d4b-4062-ac21-3a1951cdb210") },
                    { new Guid("576e657a-bb3f-474a-8b23-c4767f60ee78"), "Shea.Prosacco@yahoo.com", "Lou", "Ernser", "1-953-986-0873", new Guid("c965bcb4-a504-4e01-83fa-d219090a118b") },
                    { new Guid("57bb4c3c-264c-42b1-9c23-ce363eb33ec0"), "Mckenna_Turcotte8@yahoo.com", "Freddy", "Homenick", "1-479-747-0739 x90906", new Guid("4e8f83b0-b6ab-4d0b-86e9-245a208a6581") },
                    { new Guid("65f72ac0-7763-4179-9352-4a86e4cd2308"), "Mose.Friesen19@hotmail.com", "Gina", "Dickinson", "913.499.9106", new Guid("b41258a6-7b9f-48e2-b422-d1373c67a34b") },
                    { new Guid("66be0d89-df24-49af-bb19-34063bd5977c"), "Jaiden_Smitham60@hotmail.com", "Myles", "Gutkowski", "479-346-4854 x137", new Guid("c619557b-ccc2-4399-8d07-eb6dce5d8a0d") },
                    { new Guid("682a1a12-d828-4bb7-81f9-b93744b6785b"), "Laury_Koelpin@gmail.com", "Jeffrey", "Graham", "1-501-829-0472 x37718", new Guid("db106bbe-2460-4a88-bcee-e23ef136851e") },
                    { new Guid("6c1cea71-3e72-48b9-9653-fe1e263fbb0c"), "Libby92@yahoo.com", "Giuseppe", "Koch", "(395) 465-2811", new Guid("51f619eb-cc26-48fc-b4cf-cd74c596eb91") },
                    { new Guid("6e101ac0-7545-4c00-b809-34c55b0abdde"), "Wilhelm_Huels62@hotmail.com", "Leda", "Ebert", "222-735-6105 x7848", new Guid("97bdb137-6f24-4a37-940f-5c32ebad9377") },
                    { new Guid("743efa8d-6f92-4f8f-a4bf-2a0ca5153034"), "Faye.Hamill@hotmail.com", "Letha", "Hegmann", "1-262-248-9257", new Guid("125ce4f3-c8bd-4072-9bae-c367df805948") },
                    { new Guid("74e5e484-8bc4-47ad-bec7-dd67d1a021fa"), "Marcelo_Marquardt55@hotmail.com", "Gay", "Dach", "481.396.2566", new Guid("54ef6742-a18d-40ab-b4dd-d0c73d6264c4") },
                    { new Guid("77628584-901e-4e34-932b-f1723e4fdd90"), "Orin69@yahoo.com", "Mckenna", "Blanda", "1-869-882-3844 x675", new Guid("24bd0ce0-e7e8-4b68-ae57-b818bf924693") },
                    { new Guid("785af701-e309-40c4-abb9-0a768e377a00"), "Jaeden_Reichert60@gmail.com", "Sherwood", "Bosco", "1-788-724-9117 x211", new Guid("dc2b26dc-ea31-40b5-8352-942ff7330cb4") },
                    { new Guid("79bd45cb-0b96-4d9c-8de2-cc157bf25b3c"), "Dangelo.Denesik@gmail.com", "Aliyah", "Johnson", "859-665-4941", new Guid("852e5b35-8a47-4ea4-912e-8a35ad1950a2") },
                    { new Guid("7e4072fb-ce13-40f3-8d15-469923713ff0"), "Arnold.Feeney@yahoo.com", "Scarlett", "Cronin", "509-705-0053", new Guid("1a816388-8715-49ce-9508-bfe74b7290e0") },
                    { new Guid("7ece2cb1-7438-4041-8262-ff1f66e4b7c6"), "Andres27@hotmail.com", "Yoshiko", "Gusikowski", "437.744.6089", new Guid("eb5bccb7-8d44-4b74-84cd-72af59159e7f") },
                    { new Guid("80184fde-3a01-4225-8a91-adc4fd240298"), "Terrance_Ritchie@gmail.com", "Dimitri", "Littel", "1-220-843-6254 x42331", new Guid("67354298-8ecc-4711-a2d0-a08e6665cf32") },
                    { new Guid("807fda43-a853-4f89-80c9-f941e8defb32"), "Sarina.Waters@hotmail.com", "Orville", "O'Conner", "1-412-561-0836 x22004", new Guid("eff218db-9f91-44e2-9546-f7eb9d8f47bb") },
                    { new Guid("853697de-ad5f-44db-9e28-12ebc4d1494c"), "Mikel_Haag39@hotmail.com", "Destinee", "Wisoky", "(356) 688-7039 x679", new Guid("ea4d6c5c-200e-457f-b684-955df22e7102") },
                    { new Guid("8a30f413-c60d-435b-89d7-4e5e23471516"), "Lenora_Flatley78@gmail.com", "Sincere", "Beer", "(588) 686-7141", new Guid("94095dc1-9fb8-43e2-ab35-2ab081072887") },
                    { new Guid("8b12a395-b184-4f8b-80e6-ec34a3b6e059"), "Urban12@yahoo.com", "Leilani", "Jones", "1-472-720-0767 x883", new Guid("94d0da35-2ca9-48d0-9e42-432b388d5982") },
                    { new Guid("8d0da9ff-3c9f-49a2-9f5d-612b2486ecb2"), "Keven_Johnson20@yahoo.com", "Vella", "Hagenes", "(270) 375-8745 x090", new Guid("13bd14fa-1615-46bc-8cd9-281d7b74adba") },
                    { new Guid("9175082e-f231-419a-b3d9-b7d547354076"), "Henri.Stracke62@yahoo.com", "Wallace", "Hammes", "1-811-251-4665 x342", new Guid("76a629b8-58ed-469a-917e-6680f1c23c7f") },
                    { new Guid("9181bd81-b085-44c4-861b-9601a8c0a537"), "Chelsey_Rempel@hotmail.com", "Asha", "Hyatt", "1-958-836-8511 x0344", new Guid("522e30d3-294d-4792-941c-5d2b0252d248") },
                    { new Guid("91cba8f2-e700-440d-998f-94412d486a18"), "Liana.Gleichner@yahoo.com", "Maritza", "Kutch", "636.456.4409", new Guid("7262521e-02d0-46de-a145-f38039dbc46e") },
                    { new Guid("96afeb2e-9a0f-44a9-add6-1e3054b8def2"), "Everett.Parisian@yahoo.com", "Sylvester", "Quitzon", "823.743.5699 x6698", new Guid("cc517a5d-c18c-471f-a577-8461a304fa4f") },
                    { new Guid("9a0c3f70-0b9e-4dbe-a1e1-ced2f9464ee0"), "Vicente.Gorczany67@gmail.com", "Boris", "Hudson", "777-477-2348 x6096", new Guid("f500dd57-f32c-4e17-bd60-e15ba182817c") },
                    { new Guid("9e3879df-2a56-4081-bb9c-d09714b4f33a"), "Kurt_Sauer96@yahoo.com", "Ardella", "Huel", "818-638-1480", new Guid("4d28809f-c983-4924-8f5a-0a459e7a336f") },
                    { new Guid("9e9e91a5-40b5-4f1e-a294-e842a047415d"), "Kadin_Purdy6@gmail.com", "Violet", "Bode", "331-451-2177", new Guid("a8b6a695-63ed-42f1-99b8-536578f190b4") },
                    { new Guid("9f8cf994-4377-48dc-8816-8e3e4fabc8e5"), "Bessie48@gmail.com", "Sherman", "Mueller", "1-433-592-2430 x928", new Guid("2d6b42d6-4a42-4dcc-8a60-b35046d131fa") },
                    { new Guid("9ff6eb08-370e-41a9-a4be-7c2658eb62b9"), "Angie_Ankunding@hotmail.com", "Eden", "Reichel", "1-704-792-0676 x898", new Guid("0fae6ceb-7114-4b3d-bd17-8c8d38f0cbd3") },
                    { new Guid("a1f381ab-398d-4c75-8ef8-66e1501d76bb"), "Rex_Nolan91@gmail.com", "Trent", "Hilll", "(816) 544-8099 x7117", new Guid("92a35967-5fdf-4ff7-83a2-978a3669b153") },
                    { new Guid("a67eb54f-9179-4027-a2a0-3c80de3c0d09"), "Cordie97@yahoo.com", "Jakayla", "Runolfsson", "(651) 795-8145 x06857", new Guid("b4be3b67-fe66-41a4-8ef5-ed9bd22925b9") },
                    { new Guid("a7b86708-1ccf-4ce1-aa41-6850dc05f079"), "Priscilla.Gutmann@gmail.com", "Jerad", "Lesch", "(399) 215-4674 x2310", new Guid("de79f9b4-29fd-48fc-9077-4e68b5ed7403") },
                    { new Guid("a87aec4d-45fb-4114-a27c-dbde669dba03"), "Garett_Anderson@yahoo.com", "Yadira", "Kerluke", "426-720-9587", new Guid("b533a733-4300-4b7d-9959-ddef9134f33a") },
                    { new Guid("a8b506d1-d78f-4254-8898-da2076171e03"), "Deontae28@yahoo.com", "Jefferey", "Gerhold", "424-928-1184 x8616", new Guid("81e18285-870b-403d-bdfd-879ac4612df0") },
                    { new Guid("aa103799-4329-4d92-98e5-7b5703cf9b2b"), "Brisa.OConnell27@yahoo.com", "Dagmar", "Casper", "446.764.3100", new Guid("7bbd2432-5ca9-4189-8ec2-685f619eb736") },
                    { new Guid("abfad951-e9de-4c69-b845-9d3e1cc47676"), "Delia26@yahoo.com", "Vance", "Ryan", "1-596-284-8142", new Guid("25e39f6c-6011-4a4d-a24d-da7a8e6204a3") },
                    { new Guid("ac702a69-96ab-46fc-9fa3-0456092d7c2c"), "Kameron.King@yahoo.com", "Ryley", "Kunze", "(611) 664-6676", new Guid("5b9f440a-b721-4047-839c-c7d469fcfe33") },
                    { new Guid("adc96a08-4173-42d5-a1e3-51316f91d9a3"), "Daphne.Beer@yahoo.com", "Andy", "Gutkowski", "(726) 455-1325 x569", new Guid("c0d9ec23-4d32-44e4-84ce-a7ea91c67137") },
                    { new Guid("b0361180-f947-409c-a011-c5a1fc2f6e62"), "Zella67@hotmail.com", "Lois", "Hahn", "776.512.4533", new Guid("e155cc83-379e-45ad-987a-f10a08ec28bd") },
                    { new Guid("b0e9e2db-0e1d-4a86-8459-428ccd3e038d"), "Verona19@yahoo.com", "Vicenta", "Quigley", "855-961-9816", new Guid("421dc1c6-4868-4d87-8171-9b3cda5c2f02") },
                    { new Guid("b15ba714-32a4-45df-ba00-523a6a120315"), "Jerel.Quitzon30@hotmail.com", "Wilton", "Weissnat", "(260) 223-4626 x832", new Guid("feb3b8d0-424f-4dce-a8bd-6b8b08502b70") },
                    { new Guid("b20bbe7f-bc94-4e63-8534-a36b928f5e98"), "Ardith.Barrows0@hotmail.com", "Bianka", "Upton", "1-841-863-8511 x02728", new Guid("d2bbc9cd-2463-4e39-91b0-2d8c8dc6e0d5") },
                    { new Guid("b30111b4-61e8-4d0b-b2ed-fd02e0ca6194"), "Leanna75@hotmail.com", "Araceli", "Powlowski", "391.224.4227 x84575", new Guid("60877357-f5f1-4346-935d-a4cb92283785") },
                    { new Guid("b3348e54-8163-408f-8d57-07ea375fbc37"), "Michale78@yahoo.com", "Ezra", "Shields", "1-980-351-1873 x82717", new Guid("6f10e726-6b7f-4954-93d5-1acf7c0fc8a5") },
                    { new Guid("b5c248f7-9f6a-406d-be02-ae6ddc16426d"), "Carter4@gmail.com", "Vaughn", "Gusikowski", "1-242-424-4421 x532", new Guid("d21f403c-71d6-4661-988b-740965bc85b5") },
                    { new Guid("b9fd892b-b099-4c71-ad39-60fe9e57af40"), "Rod15@gmail.com", "Malvina", "Koepp", "(799) 470-6667 x296", new Guid("0f3dd8f5-b482-44b4-af75-368421d06813") },
                    { new Guid("bc8eedc8-3f0d-418a-9029-c952cab31302"), "Janiya_Anderson@yahoo.com", "Eileen", "Kreiger", "(749) 390-4216", new Guid("a5af9161-fb9a-4f64-8ed7-77334ce50540") },
                    { new Guid("bf9cc1e4-c194-47ae-91d6-4383b5340d87"), "Oral2@yahoo.com", "Jarrett", "Hickle", "(422) 367-5347", new Guid("d2ac00a2-c424-4031-ae7d-5884037feb6f") },
                    { new Guid("bfb2bd19-bef6-4f46-aa83-c61aac52bc87"), "Allie.Pagac@gmail.com", "Ellis", "Wiegand", "818.354.3686 x597", new Guid("544aeca0-1af7-481e-9b61-97b8cc8a4e92") },
                    { new Guid("c2b95b4a-4a1b-48a1-8eaa-a5506f6d6d55"), "Noemi_Reichel@yahoo.com", "Melba", "Hills", "766.477.0894 x9117", new Guid("9102199f-d8fb-427e-a7bd-2414cab3105d") },
                    { new Guid("c42a1252-d758-4a44-8ac2-8e67b861e9d3"), "Emelie_Wisozk@gmail.com", "Citlalli", "Jacobs", "373-256-7093 x6199", new Guid("8569824e-e474-4425-856f-501b6f79792e") },
                    { new Guid("c782ebe7-232e-4a8f-89fc-0cb49eeb639c"), "Silas.OConner6@gmail.com", "Justina", "Dibbert", "402-477-9903", new Guid("a79ca995-706c-4dd0-a115-03e0c6bac38f") },
                    { new Guid("c90deb8d-d7fc-4998-981b-5ee41a3f78a4"), "Marcelle.Kunze@gmail.com", "Oliver", "Corwin", "(550) 960-2973 x52599", new Guid("fd0a6109-6ace-405c-8f6a-fdc146d5b638") },
                    { new Guid("cb84f251-6452-4dc5-89ed-7be7a1ccdb43"), "Julio.Runte73@yahoo.com", "Catalina", "Gislason", "625.699.6188", new Guid("0b38e02d-9872-4fdd-9521-7e7ba22f234b") },
                    { new Guid("cd56f6f2-8d2b-4ec3-99c9-bdf2e5263bc0"), "Fletcher82@hotmail.com", "Pattie", "Adams", "316-921-6223", new Guid("a11d7714-4740-40d8-a988-1671bef7acef") },
                    { new Guid("d050e9c0-08c2-4b39-a1c2-70b755f6072e"), "Monserrat16@yahoo.com", "Kyra", "Leffler", "860.235.3318 x46851", new Guid("e6ef63ba-f333-490a-96d8-06c0877e6f57") },
                    { new Guid("d20e6efc-8107-4509-9c73-f1ded42f03ac"), "Malinda31@yahoo.com", "Luisa", "Quigley", "790-875-2397", new Guid("ec20d206-6794-4a34-af73-c671ee3d52b1") },
                    { new Guid("d38a3538-f1e3-47ef-b528-a07c97d79861"), "Karlie.Kemmer@yahoo.com", "Roy", "Wilderman", "698.505.1102", new Guid("ab6e7c94-f4cf-4824-a165-bc0cd0cf8901") },
                    { new Guid("d7551197-74ec-4dcb-860a-36bfae58e45d"), "Augustine_Bins14@hotmail.com", "Edythe", "Breitenberg", "(593) 419-6174 x130", new Guid("c7f116ec-606b-46c2-9d15-47a4d925dcf8") },
                    { new Guid("d7ed1d23-5f22-43e0-81a5-cb9399a7b260"), "Etha.Mills@yahoo.com", "Megane", "Balistreri", "1-479-967-9236 x9011", new Guid("03731d14-a113-4878-bd23-516cf03d63de") },
                    { new Guid("dc9eccb6-c255-478e-953b-a391ca392aa5"), "Tatum0@hotmail.com", "Suzanne", "Herman", "883-340-6263", new Guid("ee515fd3-5d59-42d9-9cd8-62c9032584d2") },
                    { new Guid("dd80ea07-9dcb-4ae7-9eb4-8a3305e5ac1a"), "Rosalia_Jast@gmail.com", "Vito", "Kovacek", "(421) 386-2660 x80613", new Guid("0a02b8ce-a88c-4c5b-8eb5-e65a598eff13") },
                    { new Guid("e0b27554-8824-486f-b6da-414528c72410"), "Ken_Pagac@yahoo.com", "Cristopher", "Marvin", "214-745-6542 x250", new Guid("44d61d08-95c1-455f-9599-89232f878654") },
                    { new Guid("e20c85ae-5231-4d4f-92ab-c682858ae21e"), "Roma89@yahoo.com", "Rigoberto", "Rowe", "815.886.4960", new Guid("96d7eda1-4502-4764-a2f7-2db676fa571b") },
                    { new Guid("e2ab9d25-9fe8-482b-a97a-09971bf9612c"), "Amari.Nikolaus@yahoo.com", "Lon", "Kshlerin", "(382) 349-3081 x55018", new Guid("8ea7d4c0-a523-4999-97f7-60db1dfadb5c") },
                    { new Guid("e3dd3a50-5a84-4939-bce5-7d419054908b"), "Juanita_Skiles@hotmail.com", "Blaze", "Hintz", "1-320-722-8841 x13367", new Guid("25c63b54-e029-4428-9df1-d6390452c05a") },
                    { new Guid("e444d217-ab75-41bd-bb4f-da7f331de127"), "Romaine_Prohaska83@yahoo.com", "Lucienne", "Lemke", "1-566-621-8334 x488", new Guid("cc487a21-e721-4758-9464-68155e833552") },
                    { new Guid("e70054b3-45d6-465b-95e4-629b95c55c03"), "Mariah_Kuhn@gmail.com", "Ariane", "Howell", "297.715.7703", new Guid("04c2e71f-7bda-4b77-9800-dd46186d8af5") },
                    { new Guid("eb9ee5ab-a97e-4f00-b46d-f8f498b873f6"), "Ismael77@yahoo.com", "Madelynn", "Douglas", "1-704-868-8533", new Guid("bdbc9283-be4f-48df-ac30-0ab4232b5389") },
                    { new Guid("ec838c5d-b4d7-4364-9f04-61f5cefbd21c"), "Christina.Barrows@yahoo.com", "Blake", "Lesch", "718.863.5673 x544", new Guid("ec620545-aecc-489b-9c2b-d9d2bb75f7d6") },
                    { new Guid("ecfc8752-39c2-48dd-ba48-983b89b7b1e9"), "Jacinthe_Goyette37@hotmail.com", "Linnie", "Ferry", "(291) 556-3422", new Guid("2af79e3e-6032-48fc-b619-67aa598ceef4") },
                    { new Guid("eee610c4-37b7-44f1-a1ff-aa98951c32bb"), "Green_Ankunding0@gmail.com", "Calista", "Heller", "669-997-9170", new Guid("f64995df-e18f-4f8d-a9d0-80ad744f8b7a") },
                    { new Guid("f00abbdc-6a28-4182-839a-f9df41fb8d55"), "Ollie86@gmail.com", "Raymond", "Mayer", "950-243-2516 x822", new Guid("d0e8c6cc-6e94-42ba-8798-bec6d7d35b58") },
                    { new Guid("f06674ef-5c4c-4365-8e03-e3acdf894b77"), "Christelle31@hotmail.com", "Heather", "McDermott", "(420) 829-8244 x7716", new Guid("a42ef64e-4ab9-412a-a73b-f15d0392763e") },
                    { new Guid("f0fc0943-9d61-4e3a-b277-0cbe2fc2892c"), "Madison.Hauck58@yahoo.com", "Cloyd", "Sawayn", "1-346-721-8239 x2188", new Guid("974a2fdd-5ed2-40aa-8ff8-5b3f74892b9f") },
                    { new Guid("f24b50f3-9225-4f90-8026-5417067143c6"), "Madonna54@hotmail.com", "Leif", "Schultz", "(869) 922-3091 x854", new Guid("739f4191-cb88-4b19-b585-f65b2535e441") },
                    { new Guid("f549f435-9b92-4da5-a7df-f9173ec5c48a"), "Maximo62@gmail.com", "Kelley", "Ebert", "(855) 388-3236 x17079", new Guid("e767a355-7d62-41d2-817a-e1d697bc98fb") },
                    { new Guid("f7727778-9bcd-4bd7-b022-98007cebf194"), "Chasity17@gmail.com", "Rebekah", "Kshlerin", "1-338-616-2145", new Guid("560d8cc0-32b1-4b43-8348-9e968ea42824") },
                    { new Guid("f8b310cd-6422-4a9e-af56-b0ddc094b21a"), "Tate22@yahoo.com", "Nya", "Howe", "687.662.2184", new Guid("59feb581-d5bc-48c2-8d75-fa99d4b83907") }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("045a0660-c667-467d-a9f5-218b94917cb7"), new Guid("776d28bd-ae6c-476f-a321-cdc3ea00931c"), "Element" },
                    { new Guid("0ba19463-601f-4438-918d-21d7ef7189f2"), new Guid("5dca51c2-3d93-40a6-afee-790ea3899860"), "Countach" },
                    { new Guid("0f06ad73-2b3c-4b8c-8f42-b9354331746a"), new Guid("c62868c4-71c9-4ad2-82a9-618b38c80d1a"), "Mustang" },
                    { new Guid("1307a9fa-ee92-4a6a-b364-0dc149f9ccab"), new Guid("776d28bd-ae6c-476f-a321-cdc3ea00931c"), "Fortwo" },
                    { new Guid("17922849-ee18-4bb9-bc2e-cdc6649bb81f"), new Guid("5b008041-4df4-40cb-8f00-ffc29eb8e685"), "Spyder" },
                    { new Guid("1b6e905d-273e-4a7d-898f-b9462d72aceb"), new Guid("5dca51c2-3d93-40a6-afee-790ea3899860"), "Model T" },
                    { new Guid("207bea9b-026f-4512-98e0-ff4f01a2b537"), new Guid("776d28bd-ae6c-476f-a321-cdc3ea00931c"), "XC90" },
                    { new Guid("3b105b75-df01-4291-b368-49ef36ab365b"), new Guid("5b008041-4df4-40cb-8f00-ffc29eb8e685"), "Jetta" },
                    { new Guid("3f5be685-5eed-4ec0-ab9d-76ac35ee83b3"), new Guid("5b008041-4df4-40cb-8f00-ffc29eb8e685"), "Sentra" },
                    { new Guid("480bb511-60c3-4426-a4a1-b4b1eed47149"), new Guid("d454f765-c807-4a60-b1db-cff88e460d26"), "CX-9" },
                    { new Guid("4cd4ea74-1140-4632-b22b-2e0b7f2b4cbc"), new Guid("c62868c4-71c9-4ad2-82a9-618b38c80d1a"), "Fortwo" },
                    { new Guid("53e9f479-9973-43b8-a5cd-90625c7eabc5"), new Guid("5b008041-4df4-40cb-8f00-ffc29eb8e685"), "Camaro" },
                    { new Guid("5e31aefa-72fe-4c11-af0e-11ba1054a28c"), new Guid("776d28bd-ae6c-476f-a321-cdc3ea00931c"), "V90" },
                    { new Guid("60aca9ff-aac9-4040-9391-55df28873388"), new Guid("c62868c4-71c9-4ad2-82a9-618b38c80d1a"), "Challenger" },
                    { new Guid("685dd1a8-63a7-4a12-968e-bbc4a92ff173"), new Guid("5dca51c2-3d93-40a6-afee-790ea3899860"), "Cruze" },
                    { new Guid("711c26ab-454c-4542-915e-2a70a92082e1"), new Guid("c62868c4-71c9-4ad2-82a9-618b38c80d1a"), "Wrangler" },
                    { new Guid("73bf3011-edfc-46f1-b57b-2172cee60638"), new Guid("5b008041-4df4-40cb-8f00-ffc29eb8e685"), "Sentra" },
                    { new Guid("96c398f5-b93d-4a0e-9066-46883793da29"), new Guid("d454f765-c807-4a60-b1db-cff88e460d26"), "Colorado" },
                    { new Guid("9d2f620d-cede-4633-98f3-30660305b572"), new Guid("776d28bd-ae6c-476f-a321-cdc3ea00931c"), "Durango" },
                    { new Guid("b67f3a5a-a2fe-4085-8fe4-b18b2a61ba85"), new Guid("d454f765-c807-4a60-b1db-cff88e460d26"), "Impala" },
                    { new Guid("c7af8e4e-e164-4000-ab19-d8b9f9948143"), new Guid("c62868c4-71c9-4ad2-82a9-618b38c80d1a"), "911" },
                    { new Guid("e638d14f-c8cf-450c-84e7-4c9c22647d92"), new Guid("d454f765-c807-4a60-b1db-cff88e460d26"), "Camry" },
                    { new Guid("ef3bfa56-4a8b-4508-b364-8c8799f66aff"), new Guid("5dca51c2-3d93-40a6-afee-790ea3899860"), "Explorer" },
                    { new Guid("f3007318-1810-4ee3-a2b2-dc2e14eb7d7f"), new Guid("5dca51c2-3d93-40a6-afee-790ea3899860"), "Challenger" },
                    { new Guid("fda150a7-4b1d-4953-8768-80896ec8631f"), new Guid("d454f765-c807-4a60-b1db-cff88e460d26"), "Volt" }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("3bb6a6c5-0756-453d-b5a9-0fe8e82f1c7c"), new Guid("0dfd3233-e825-4b92-8e5d-0ca2a3977bfa"), new DateTime(2024, 4, 8, 16, 22, 15, 899, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 10, 14, 13, 32, 3, 622, DateTimeKind.Utc).AddTicks(3664), new Guid("2d3f0fee-aea8-4664-98a9-29e40e71bcf1") },
                    { new Guid("53b20d90-b59e-4086-885d-8be15a06d9ab"), new Guid("91cba8f2-e700-440d-998f-94412d486a18"), new DateTime(2024, 3, 2, 16, 46, 8, 527, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 11, 22, 3, 18, 44, 17, DateTimeKind.Utc).AddTicks(9930), new Guid("a5af9161-fb9a-4f64-8ed7-77334ce50540") },
                    { new Guid("6063f0f8-eac9-4794-ae56-b42c09d83a07"), new Guid("07c9b4b9-20e2-4146-beff-28decafbeedc"), new DateTime(2024, 3, 6, 6, 2, 29, 288, DateTimeKind.Utc).AddTicks(9358), new DateTime(2024, 3, 18, 14, 47, 25, 274, DateTimeKind.Utc).AddTicks(9882), new Guid("1a816388-8715-49ce-9508-bfe74b7290e0") },
                    { new Guid("b229cbfd-e9bd-46cf-9445-3c346790cc4d"), new Guid("a87aec4d-45fb-4114-a27c-dbde669dba03"), new DateTime(2023, 7, 15, 14, 5, 21, 567, DateTimeKind.Utc).AddTicks(3855), new DateTime(2024, 4, 16, 13, 25, 7, 417, DateTimeKind.Utc).AddTicks(9685), new Guid("a42ef64e-4ab9-412a-a73b-f15d0392763e") },
                    { new Guid("fc87a268-aaf6-4c34-a3de-54a4a8c9171c"), new Guid("e3dd3a50-5a84-4939-bce5-7d419054908b"), new DateTime(2023, 10, 5, 14, 45, 7, 358, DateTimeKind.Utc).AddTicks(6079), new DateTime(2023, 8, 2, 3, 30, 13, 973, DateTimeKind.Utc).AddTicks(1259), new Guid("03731d14-a113-4878-bd23-516cf03d63de") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_VehicleId",
                table: "Clients",
                column: "VehicleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClientHistories_ClientId",
                table: "VehicleClientHistories",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClientHistories_VehicleId",
                table: "VehicleClientHistories",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_ManufacturerId",
                table: "VehicleModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelNameId",
                table: "Vehicles",
                column: "ModelNameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleClientHistories");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
