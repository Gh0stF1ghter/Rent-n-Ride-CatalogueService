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
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

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
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("c5aebbda-44d9-4ddc-8544-521aec01812f"), "Jessyca51@gmail.com", "Jarvis", "Smitham", "1-374-792-9051 x2835" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("58c5c112-9e6b-4415-afb6-4ee4e600284b"), "Porsche" },
                    { new Guid("60c2cc48-eab7-4943-a3af-57eb865a7bd7"), "Bentley" },
                    { new Guid("6e19f0ed-9464-463b-90bd-de3bc8709bda"), "Volkswagen" },
                    { new Guid("bb7ea001-6e01-41bb-a55f-f694d34439c5"), "Audi" },
                    { new Guid("e33c997f-098c-4a50-8248-ddbd287aa698"), "Polestar" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "ModelNameId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("02016f0c-a577-4f0e-add9-3fd4916fdd7b"), 0, new Guid("bc7f894f-d198-4ef5-af37-e394da7a037d"), null, 3931, "68NZLY56SQXS55621", 2880.5196802347532, 1, 2 },
                    { new Guid("02224568-e5ed-4ab5-a95c-c8331f0151ce"), 2, new Guid("462ed1d7-4c19-4572-a2eb-3366a2e4693a"), null, 1931, "46RR02BA3ZP783434", 2929.1543324730865, 1, 4 },
                    { new Guid("08bac291-dae6-41da-96ba-017280fa8652"), 0, new Guid("647aabef-d596-449f-8634-ca7f3ad5ebb6"), null, 3405, "YUTWIUN0GCIP64836", 3171.902940874244, 1, 5 },
                    { new Guid("0cbb9318-c83d-4efe-909b-c7e9c1a71cee"), 3, new Guid("647aabef-d596-449f-8634-ca7f3ad5ebb6"), null, 1585, "71PDB49CKKSK64710", 3834.7154933561405, 1, 0 },
                    { new Guid("0f5f61c1-795d-4fba-adfb-5688ba43daee"), 1, new Guid("e432c58f-2712-4e67-aed0-0f2c9364cf34"), null, 4227, "PK73YT10URJ713211", 730.14516983759881, 1, 0 },
                    { new Guid("1106c07b-24a7-46b6-8e1b-79689c34c4e1"), 3, new Guid("ec21adfd-abfa-47bd-a5e7-410bd87e8f9e"), null, 5444, "1XKUG9E6UHKZ30502", 861.84863483008667, 3, 1 },
                    { new Guid("11b2a283-5c68-430f-9133-7adaf57602b1"), 1, new Guid("57a68423-673c-4c63-9067-9f0565474917"), null, 9772, "4PVUCT12J1WG76936", 741.35558741584782, 2, 4 },
                    { new Guid("12fe8064-f7fb-4ee4-a0e0-885da9e7b160"), 3, new Guid("1332b9aa-8cf2-4c67-a0f2-93e7a9f1f34e"), null, 8349, "XX4G9D6K8ZDH98413", 3419.7878252440332, 2, 1 },
                    { new Guid("132c75cc-b8c8-4404-a14b-45e549a781bd"), 1, new Guid("98860bd4-682b-4930-a481-81e59e612aa0"), null, 759, "IV9ZAENTH1MI41177", 301.94562489851319, 0, 5 },
                    { new Guid("152100e2-c979-4e50-88bf-ff49b3319c53"), 1, new Guid("72b7ecb9-76f8-4f92-926f-42a419d25c93"), null, 7726, "O294V078K1TW68004", 2410.0551568841606, 1, 4 },
                    { new Guid("172f9abd-7822-4156-86d0-8557a4cffaca"), 0, new Guid("d78e8a63-167a-4323-b92d-c16cbca7ac27"), null, 2078, "N0GDTS5DG1FI76401", 2064.9979373842893, 3, 2 },
                    { new Guid("1b7ef0e2-e839-4009-ad5e-2763e4ec1d36"), 0, new Guid("72b7ecb9-76f8-4f92-926f-42a419d25c93"), null, 5983, "DZKV7GLK1YLE68997", 1361.2449044836519, 0, 5 },
                    { new Guid("1ebe8a6c-0f7c-4f69-87ff-8db988a2b54e"), 3, new Guid("462ed1d7-4c19-4572-a2eb-3366a2e4693a"), null, 7373, "OFEARUHBHTA294631", 1495.3656024495599, 2, 1 },
                    { new Guid("21d79491-01f5-4b86-bbb5-77786cbb2382"), 0, new Guid("0724e700-bbe8-4079-9f17-e2c09b21dcfb"), null, 4644, "4UM29MIEG9E164983", 1920.6084478762159, 0, 5 },
                    { new Guid("21efec8f-8c8f-4a77-9d41-4ffa3da992d5"), 0, new Guid("5c8603db-1cf4-47a0-a02b-8164425ccace"), null, 5888, "EVTJSJECRVRA75804", 593.22683076907379, 3, 3 },
                    { new Guid("2789bb72-1e65-447b-b353-93c6973a6a0e"), 2, new Guid("c2c3070c-ddd5-4470-9f20-23c3d37f667e"), null, 1314, "YSAB1AL3ZJV320478", 2304.5141174069122, 0, 5 },
                    { new Guid("289b1228-cdba-4465-8347-75fa66c2fe16"), 0, new Guid("462ed1d7-4c19-4572-a2eb-3366a2e4693a"), null, 1299, "NPXU7LTZ5NQY50818", 3232.6175407059709, 2, 3 },
                    { new Guid("29136aed-8253-40b4-9d21-3e4654785097"), 3, new Guid("6db7c681-c188-4d29-ac1a-024b537c0973"), null, 352, "2QFKL8Z6WQOA14436", 386.45881252793237, 1, 3 },
                    { new Guid("2a4aaff4-28fc-4a18-abd0-ef158e8b85f2"), 3, new Guid("0a35ff90-4efc-4422-9612-76e03974a2f6"), null, 5710, "HEV349J90NL718472", 2709.0207344426799, 3, 1 },
                    { new Guid("2e038396-a028-40b4-a8e0-4d2ecece4388"), 2, new Guid("88632cc1-1779-4579-8d2c-9fde553fce74"), null, 9523, "QDNNGHVUV2WC66858", 1133.7264180792677, 1, 2 },
                    { new Guid("314c741e-9539-4c37-bef2-111c70ad4f8e"), 1, new Guid("5c8603db-1cf4-47a0-a02b-8164425ccace"), null, 5415, "H3JEJ7HLZFGD82968", 2441.3741835011269, 1, 3 },
                    { new Guid("354e65f6-4caf-4719-81e7-f13d75b3729d"), 3, new Guid("6db7c681-c188-4d29-ac1a-024b537c0973"), null, 8253, "IIQ3D858IPVK94928", 1221.092747293432, 0, 5 },
                    { new Guid("36b7d125-ad91-446b-a6e5-432cb5e30024"), 1, new Guid("c174c72c-c49d-463e-b98f-7b0c802b0e96"), null, 9084, "W306ALROQLLR87907", 2052.2071805437076, 2, 4 },
                    { new Guid("3798bc0d-408e-43a9-909b-32fdf6623b6e"), 3, new Guid("f0a371df-2456-4543-8c2b-fc299a2e200e"), null, 3800, "6DUWMF3BU5MJ25176", 2946.4222984079875, 3, 1 },
                    { new Guid("3af3b33b-f0fa-4a9c-8a21-2f8422988764"), 2, new Guid("4301d396-bbe4-49c3-b12c-8a5688b4e2fe"), null, 2205, "SIGQX7BXTIFW65100", 3662.545548116128, 2, 2 },
                    { new Guid("3ca1931f-0793-4749-be09-369e9f548a57"), 0, new Guid("bfb570cb-387f-4e43-a39a-017daea04fe7"), null, 3360, "JITB5TRVNRKD59866", 3917.8231446319851, 2, 4 },
                    { new Guid("423d704d-71fe-448e-ba68-91703a29fb93"), 1, new Guid("5c8603db-1cf4-47a0-a02b-8164425ccace"), null, 5821, "YWUYLUPIFRAM29462", 2495.7119213079177, 0, 2 },
                    { new Guid("4337700a-1686-469b-9810-5d5e98ce1e05"), 2, new Guid("72b7ecb9-76f8-4f92-926f-42a419d25c93"), null, 9151, "WS84EVDFRDHL90517", 1155.7275733963525, 2, 4 },
                    { new Guid("43cbe8c2-2fdf-4492-8570-e77abfa3636a"), 0, new Guid("5e57c9b9-b1b1-43a2-a487-f99a4e1b4592"), null, 9986, "6SUWZGWXRSA052353", 3148.2448216470143, 0, 1 },
                    { new Guid("4415269b-66aa-4685-9237-9c6bbbaa8990"), 3, new Guid("88b6181a-e2f1-4533-a3c7-ca4f1ae6c330"), null, 1607, "6O97IZVSRYNV75732", 567.14686417467215, 0, 0 },
                    { new Guid("46a6e7c4-7e86-49c1-8be6-54dc20d11e00"), 1, new Guid("1332b9aa-8cf2-4c67-a0f2-93e7a9f1f34e"), null, 8229, "EM6KU48K4IXO71389", 1454.6270757777363, 1, 4 },
                    { new Guid("477e4711-ef10-46f2-acb6-a1125048d095"), 2, new Guid("88632cc1-1779-4579-8d2c-9fde553fce74"), null, 8441, "C7L61CO8KDOG25207", 3316.7837718700939, 1, 2 },
                    { new Guid("4c4980fb-e1af-4686-87d6-24a9505f5842"), 3, new Guid("88632cc1-1779-4579-8d2c-9fde553fce74"), null, 6653, "EWY1OOIE64T023689", 1210.965201330403, 3, 4 },
                    { new Guid("4cbe4f2a-4bbe-49cd-9832-5c9e5b3e1971"), 1, new Guid("57a68423-673c-4c63-9067-9f0565474917"), null, 2260, "95NWBYIWRTUL88327", 3827.9302014537384, 3, 3 },
                    { new Guid("4cfad2e1-5de5-4384-af6a-6b387c4ab61f"), 1, new Guid("e432c58f-2712-4e67-aed0-0f2c9364cf34"), null, 3251, "CQYPQ17LAGT766317", 1054.7465773959461, 1, 1 },
                    { new Guid("50d2f3ed-8f4d-4937-9f7f-cf40aa31c861"), 1, new Guid("ec21adfd-abfa-47bd-a5e7-410bd87e8f9e"), null, 1306, "3XNFV6IM2XTG27146", 410.59217539317291, 3, 1 },
                    { new Guid("53a2471a-32ce-45be-963e-e5b7e2a99fa7"), 0, new Guid("0a35ff90-4efc-4422-9612-76e03974a2f6"), null, 6948, "VXPPR2RV35QM28156", 3180.2481389966861, 3, 5 },
                    { new Guid("558b0365-4e26-4bc9-ab7e-244faec60060"), 3, new Guid("c174c72c-c49d-463e-b98f-7b0c802b0e96"), null, 9718, "70PLE6O5X4FB60322", 3778.4605133821051, 1, 4 },
                    { new Guid("55f2074f-5382-493b-a996-84a8ca5b37b8"), 3, new Guid("98860bd4-682b-4930-a481-81e59e612aa0"), null, 3649, "J1BIS42LFRUK68049", 2964.7214020071274, 0, 4 },
                    { new Guid("5c2b1e32-6686-4f83-8e6e-1606517aabdc"), 2, new Guid("bfb570cb-387f-4e43-a39a-017daea04fe7"), null, 7206, "23NG2P6K43KW84272", 3129.3534300201409, 0, 5 },
                    { new Guid("5c599e10-a41d-46c8-bd4e-5a040ba454d0"), 3, new Guid("5e57c9b9-b1b1-43a2-a487-f99a4e1b4592"), null, 941, "7J5ECIWSDTVU43725", 212.8154657229739, 3, 3 },
                    { new Guid("5e606ca0-e45f-47fa-8b6f-7174ad44abe5"), 1, new Guid("dda0c099-f6e8-4891-aaa0-1b82138597ad"), null, 3162, "60PXFGBAAVKC66848", 155.5103290625338, 0, 4 },
                    { new Guid("60ca1a37-b6b8-48bf-a5a9-1b68aaa9281b"), 1, new Guid("bfb570cb-387f-4e43-a39a-017daea04fe7"), null, 2881, "CIUYG4X8WIBV54077", 2218.678820173051, 0, 4 },
                    { new Guid("6397ed85-9f1b-4f4b-99fa-81c12ecaed48"), 3, new Guid("88b6181a-e2f1-4533-a3c7-ca4f1ae6c330"), null, 5720, "85UPVNDBXNH095226", 1775.3547203875978, 1, 5 },
                    { new Guid("63fcd55f-f54c-46ad-bdbc-bc751edf8b4c"), 1, new Guid("50e24ab0-ce48-4d11-bd10-26e9f8d98f0c"), null, 2584, "X6STTDTTETUC68527", 3838.2504659962096, 2, 1 },
                    { new Guid("6633ddd6-d01c-4a15-8ef5-dd87cd26e0c2"), 2, new Guid("0724e700-bbe8-4079-9f17-e2c09b21dcfb"), null, 8741, "HIF0DERRH4Z744620", 650.45999106179931, 3, 5 },
                    { new Guid("66c711f0-f027-42b5-a367-7bd6c7db3db0"), 0, new Guid("c174c72c-c49d-463e-b98f-7b0c802b0e96"), null, 4136, "DZZ8BH49H4QQ92518", 3627.9434431998716, 1, 0 },
                    { new Guid("68a339fd-ace8-4ae0-884b-74405f0a18ab"), 2, new Guid("0a35ff90-4efc-4422-9612-76e03974a2f6"), null, 9367, "WHU7CNO86YWD88841", 3811.2480486943268, 1, 4 },
                    { new Guid("68b5bdfc-6b01-42fb-b16a-f0e40509e182"), 2, new Guid("ec21adfd-abfa-47bd-a5e7-410bd87e8f9e"), null, 3505, "PRFZ87EGBTOL73372", 2295.4007136315859, 2, 0 },
                    { new Guid("692956cc-fee1-4336-8ef5-2e51e7d1e45a"), 2, new Guid("4301d396-bbe4-49c3-b12c-8a5688b4e2fe"), null, 9923, "27VLEVSCA5R149459", 1774.7945668619752, 3, 5 },
                    { new Guid("69510daa-7c56-45df-84e3-c11224491158"), 1, new Guid("bfb570cb-387f-4e43-a39a-017daea04fe7"), null, 3622, "ETIUINQEW3IY86449", 3479.0016175871569, 3, 2 },
                    { new Guid("6aba9b73-0595-4196-9f7c-f714d045c771"), 0, new Guid("50e24ab0-ce48-4d11-bd10-26e9f8d98f0c"), null, 3827, "8ZVW1Z5410UX21494", 3669.9500623477243, 2, 4 },
                    { new Guid("6ee44403-5b6c-46de-9f64-a381b813cd18"), 3, new Guid("1332b9aa-8cf2-4c67-a0f2-93e7a9f1f34e"), null, 4788, "2J7QVAK20IHV40068", 3782.5775193418217, 0, 2 },
                    { new Guid("719062ca-84d3-4935-ae1a-ee63e70ac4a2"), 2, new Guid("98860bd4-682b-4930-a481-81e59e612aa0"), null, 6327, "RT1XQ1QRTDPV61471", 3761.210981067672, 0, 1 },
                    { new Guid("71b5f992-b507-455c-b8f1-04b012448cf2"), 3, new Guid("c2c3070c-ddd5-4470-9f20-23c3d37f667e"), null, 3721, "LN5O29XXSBRC86193", 448.41044587287547, 2, 0 },
                    { new Guid("7550637b-175c-4dad-9f01-c9b2ce2785ac"), 3, new Guid("88b6181a-e2f1-4533-a3c7-ca4f1ae6c330"), null, 4000, "R3MWW3WPZPZI44626", 1458.2918360464269, 0, 4 },
                    { new Guid("78272efa-de4d-45e5-9022-3d18fb55d0ec"), 1, new Guid("6db7c681-c188-4d29-ac1a-024b537c0973"), null, 7717, "FB0KQ5PLEYR237715", 2201.3012343422702, 3, 3 },
                    { new Guid("7cb4e5dc-96e8-492c-8bfb-8dbfb784bc3c"), 3, new Guid("d78e8a63-167a-4323-b92d-c16cbca7ac27"), null, 2753, "GYI8FQU9TTO134488", 1032.5213977442506, 0, 0 },
                    { new Guid("7f5fd278-332e-4bc2-8494-70bccb50ddff"), 0, new Guid("e432c58f-2712-4e67-aed0-0f2c9364cf34"), null, 9051, "Q6VRAGDW2XA124792", 2689.2210242409851, 2, 1 },
                    { new Guid("86729864-793b-483b-9a7c-7c0716e429af"), 1, new Guid("c2c3070c-ddd5-4470-9f20-23c3d37f667e"), null, 480, "03631K1MJILV89313", 1204.2306236101838, 3, 5 },
                    { new Guid("8817ff32-5f86-4985-8704-7d8f0426f7b1"), 0, new Guid("a36a97d8-4026-4db3-ba3e-cab18046c3ea"), null, 8710, "TVJHJPMS58QP27130", 2005.6742507506935, 2, 5 },
                    { new Guid("891871c7-ac95-41f8-be54-8da1356580a3"), 2, new Guid("0724e700-bbe8-4079-9f17-e2c09b21dcfb"), null, 1340, "F4S8OSU66IZR68799", 3527.2867818644127, 2, 5 },
                    { new Guid("89ec2912-dfe3-43b5-af81-da168aa38fcc"), 1, new Guid("88b6181a-e2f1-4533-a3c7-ca4f1ae6c330"), null, 7396, "UBFX3AVWJ1OL48750", 3920.7949486870307, 1, 1 },
                    { new Guid("92a39b70-0d27-4582-b255-0ddc9b39bc53"), 0, new Guid("bfb570cb-387f-4e43-a39a-017daea04fe7"), null, 156, "Z9U8YARZEXZX85085", 3440.2307458104733, 2, 4 },
                    { new Guid("9316b814-bdbe-4b6b-a497-1f90c3419925"), 2, new Guid("462ed1d7-4c19-4572-a2eb-3366a2e4693a"), null, 8707, "N8VIBO01YWSB20914", 912.97224019781277, 3, 0 },
                    { new Guid("93382c74-7bb2-461c-b246-ecb37abfd8f5"), 2, new Guid("5c8603db-1cf4-47a0-a02b-8164425ccace"), null, 749, "EEP7QMYLXLT848219", 2816.4060542625934, 0, 2 },
                    { new Guid("96e21e3c-fabc-4c60-82d3-0cdbd8bd94a4"), 1, new Guid("88632cc1-1779-4579-8d2c-9fde553fce74"), null, 1264, "M60N5S0TZWX958870", 2493.9629562836408, 1, 5 },
                    { new Guid("97e52b68-1a66-4064-bb12-6ad5b242bac3"), 3, new Guid("647aabef-d596-449f-8634-ca7f3ad5ebb6"), null, 7077, "XPDTH54RPPPV15519", 802.8121746145855, 2, 1 },
                    { new Guid("992e475c-e6fb-4b98-ac8d-94cec95bbf96"), 2, new Guid("98860bd4-682b-4930-a481-81e59e612aa0"), null, 5777, "J6Q2BTZ75PTA78394", 1073.4217214782709, 0, 3 },
                    { new Guid("9a18854e-99b7-4a1c-8a92-c4bc41fda7db"), 0, new Guid("bc7f894f-d198-4ef5-af37-e394da7a037d"), null, 9282, "3D83O4XBMUUQ56287", 2689.0613170180945, 2, 3 },
                    { new Guid("9ccd2bff-8833-4855-b67a-8bc7096a4e84"), 1, new Guid("462ed1d7-4c19-4572-a2eb-3366a2e4693a"), null, 7212, "A36LCROPSTN644433", 3024.082094386456, 3, 5 },
                    { new Guid("a210b75d-5c41-4893-8f62-a3599cda5192"), 0, new Guid("57a68423-673c-4c63-9067-9f0565474917"), null, 3419, "87R8O9CKJBLD24825", 746.7931201628237, 0, 4 },
                    { new Guid("a390d4f1-9b6a-4035-9e9c-88a8d43d38b1"), 3, new Guid("72b7ecb9-76f8-4f92-926f-42a419d25c93"), null, 2795, "064GHIAM41N030283", 3010.2116751615645, 0, 4 },
                    { new Guid("a3d729c7-63b0-4c89-b057-91d7265032bd"), 0, new Guid("5e57c9b9-b1b1-43a2-a487-f99a4e1b4592"), null, 6706, "GPRK5GYMQ7B733859", 3996.4496536742777, 1, 0 },
                    { new Guid("a5b315b7-581e-4e1d-8384-9ac707174fad"), 0, new Guid("c2c3070c-ddd5-4470-9f20-23c3d37f667e"), null, 2195, "VLIXVOXD2ZEF47826", 1965.2229983631985, 0, 3 },
                    { new Guid("a646ad98-31a7-41e3-bb74-72769510dedf"), 1, new Guid("6db7c681-c188-4d29-ac1a-024b537c0973"), null, 7795, "42T9F2T05ZO968172", 530.70520862582907, 1, 1 },
                    { new Guid("a80cac89-5326-4b27-8be0-5a6500a237b0"), 3, new Guid("98860bd4-682b-4930-a481-81e59e612aa0"), null, 6948, "L9SBMZ2Y04UE13354", 2552.7484795084742, 0, 1 },
                    { new Guid("a8297195-4dae-47f2-8f8b-e1a7710fd0dd"), 3, new Guid("1332b9aa-8cf2-4c67-a0f2-93e7a9f1f34e"), null, 8069, "EQ80PK81GAFN81312", 588.13207764374192, 0, 1 },
                    { new Guid("af2f17c3-c66d-429e-bdcc-57077fb7c9c7"), 2, new Guid("4301d396-bbe4-49c3-b12c-8a5688b4e2fe"), null, 332, "V30UVQJLU1QN52317", 1508.8127604942929, 2, 4 },
                    { new Guid("b03016b1-82c1-4b28-8686-8366642b339f"), 0, new Guid("dda0c099-f6e8-4891-aaa0-1b82138597ad"), null, 4937, "5KH8MIJGH1PH33501", 3957.4243383043668, 3, 0 },
                    { new Guid("b0c4cf82-c0eb-4bb2-b20f-ad53f0a589ae"), 2, new Guid("647aabef-d596-449f-8634-ca7f3ad5ebb6"), null, 6656, "1BC2UWOHECOF29309", 950.29643640449888, 3, 0 },
                    { new Guid("b215754e-bd07-454f-a376-47cf3c47cb0c"), 3, new Guid("e432c58f-2712-4e67-aed0-0f2c9364cf34"), null, 9513, "G8DB2Y4OCZSS41805", 2971.3189985801373, 0, 0 },
                    { new Guid("b3f4a3f2-aa0d-44a5-a793-309fdc630c37"), 1, new Guid("d78e8a63-167a-4323-b92d-c16cbca7ac27"), null, 5196, "2VJEFCIM8YE693931", 3115.7279906571416, 3, 0 },
                    { new Guid("b568a9cb-5a77-499a-b3ea-2f386a567d2d"), 3, new Guid("5c8603db-1cf4-47a0-a02b-8164425ccace"), null, 8884, "SCJ6G4ISNATQ14017", 1946.6836780830679, 0, 5 },
                    { new Guid("b5b06b7c-8a20-4c7f-b0f8-9e4169102cb8"), 1, new Guid("c2c3070c-ddd5-4470-9f20-23c3d37f667e"), null, 8472, "EQ0KDYCKN9N962271", 776.47953414805249, 1, 3 },
                    { new Guid("b5b2b0b3-d6f7-4bf7-b2cc-9dbcb59a6b69"), 1, new Guid("5e57c9b9-b1b1-43a2-a487-f99a4e1b4592"), null, 2658, "GTTWXPP30VZ899749", 2869.1196946400923, 2, 3 },
                    { new Guid("ba421643-7b70-4634-b2bd-9ffa5dc64b5d"), 3, new Guid("0724e700-bbe8-4079-9f17-e2c09b21dcfb"), null, 1406, "IZI338TYVCIU29294", 1420.2577381910346, 0, 3 },
                    { new Guid("bb48518d-cdfe-4ff2-b457-c9e6861b212e"), 1, new Guid("4301d396-bbe4-49c3-b12c-8a5688b4e2fe"), null, 9955, "ZDLEAS594PFS29276", 660.42445577568299, 0, 1 },
                    { new Guid("be65a1fc-ce5b-4c56-aaa2-c8a6fccdb06e"), 0, new Guid("6db7c681-c188-4d29-ac1a-024b537c0973"), null, 1432, "U4BK8YY6FSDT90882", 2029.8185006509043, 3, 3 },
                    { new Guid("c05332ca-5c1e-482d-83a9-47178d3e9725"), 0, new Guid("50e24ab0-ce48-4d11-bd10-26e9f8d98f0c"), null, 1289, "B24N7PM42TSZ43814", 3701.9761568508084, 2, 4 },
                    { new Guid("c0c752c9-a46f-4023-a5bf-a73cb564527d"), 1, new Guid("647aabef-d596-449f-8634-ca7f3ad5ebb6"), null, 2495, "76RGXSOV3OSQ99260", 1781.6781766189572, 3, 2 },
                    { new Guid("c0e98a07-0d98-40c8-9c2d-d184483e0b95"), 1, new Guid("57a68423-673c-4c63-9067-9f0565474917"), null, 323, "3EOMKKLMNZGT61421", 601.73971988299877, 2, 0 },
                    { new Guid("c12a50e5-2a38-4c7e-b89f-e0b23eba0b20"), 2, new Guid("d78e8a63-167a-4323-b92d-c16cbca7ac27"), null, 10000, "MSLSG6Y8E6I792908", 1434.8163083207576, 0, 3 },
                    { new Guid("c136516a-017f-488b-a16a-9debecf3174c"), 3, new Guid("f0a371df-2456-4543-8c2b-fc299a2e200e"), null, 4622, "6HA6RDJLVXJN74455", 3751.8102894066456, 0, 1 },
                    { new Guid("c22c475e-67ea-480d-a828-f41f468462ad"), 2, new Guid("ec21adfd-abfa-47bd-a5e7-410bd87e8f9e"), null, 6285, "BMRRWLE1BARZ13904", 1861.3762631200179, 2, 4 },
                    { new Guid("c2e0604d-b7e9-474d-9a28-ef71976bc20c"), 2, new Guid("bc7f894f-d198-4ef5-af37-e394da7a037d"), null, 4448, "68K43P5Z93EI49173", 2204.5753223525676, 2, 4 },
                    { new Guid("c3bc470f-0e8b-4fac-918a-23f2399f2053"), 2, new Guid("f0a371df-2456-4543-8c2b-fc299a2e200e"), null, 3994, "1JGRLBC10TZ250579", 2453.9214669062403, 0, 5 },
                    { new Guid("c579a156-a4e9-4db3-830a-3ea5a53aace7"), 1, new Guid("a36a97d8-4026-4db3-ba3e-cab18046c3ea"), null, 6482, "6ZBQ01VK2GPF64058", 2275.2512698065384, 3, 3 },
                    { new Guid("c9cbdfc5-a05a-45fc-96d5-dc2f8af1f3a6"), 2, new Guid("88b6181a-e2f1-4533-a3c7-ca4f1ae6c330"), null, 1929, "WTPD4OFZF9VJ64294", 1343.4059013735323, 0, 1 },
                    { new Guid("ca1b8f24-9207-4a3a-bdfb-6dc44a1047f2"), 1, new Guid("0a35ff90-4efc-4422-9612-76e03974a2f6"), null, 2493, "W210N4OEH7XD74031", 2676.7310546055869, 1, 5 },
                    { new Guid("ca2dd45c-ac50-4dcb-8281-d050be16a234"), 3, new Guid("0a35ff90-4efc-4422-9612-76e03974a2f6"), null, 8922, "7QG0ET57MKJG31361", 1057.9457994399736, 0, 0 },
                    { new Guid("ca3a1f98-5c2a-4662-9eb2-4370fcaa0cc8"), 1, new Guid("d78e8a63-167a-4323-b92d-c16cbca7ac27"), null, 6318, "F4BN5M77VKYQ39126", 3929.8589886019745, 1, 4 },
                    { new Guid("d7812b21-eba9-431a-a8d9-0b84319c9503"), 3, new Guid("a36a97d8-4026-4db3-ba3e-cab18046c3ea"), null, 315, "3YPDTHQRKAII66049", 1602.5041135580259, 1, 4 },
                    { new Guid("dca2adad-0bf6-491c-bc53-aa00d17387b8"), 2, new Guid("c174c72c-c49d-463e-b98f-7b0c802b0e96"), null, 7464, "1KOC263P8EXI58687", 3497.8207029109881, 0, 4 },
                    { new Guid("dd44bae9-cdd3-4853-a700-42e8f913db7c"), 2, new Guid("50e24ab0-ce48-4d11-bd10-26e9f8d98f0c"), null, 6334, "NAPBSO2O1NWQ95744", 3360.2423481550504, 2, 5 },
                    { new Guid("de527ef4-5333-4313-aeac-b896fb295ff8"), 0, new Guid("bc7f894f-d198-4ef5-af37-e394da7a037d"), null, 1819, "ICS5XKQWTCHA91189", 1220.798464795497, 3, 2 },
                    { new Guid("df6d930c-37fb-4373-907e-dad479b100b6"), 2, new Guid("f0a371df-2456-4543-8c2b-fc299a2e200e"), null, 4900, "APOA8O72JUTH63440", 1026.8619073420682, 1, 0 },
                    { new Guid("e17b6af0-e482-4db6-9808-e05e747c00d4"), 0, new Guid("4301d396-bbe4-49c3-b12c-8a5688b4e2fe"), null, 1721, "PBU3U88Z54XB36520", 3247.3175657638913, 3, 2 },
                    { new Guid("e4a78be6-02ae-4a84-8b78-083d6b9bd438"), 1, new Guid("e432c58f-2712-4e67-aed0-0f2c9364cf34"), null, 3594, "G24IAL7OHXFZ19424", 3671.4790723464239, 1, 2 },
                    { new Guid("e6e1aa03-cb9e-46d3-b63d-be07b0a3b28b"), 3, new Guid("bc7f894f-d198-4ef5-af37-e394da7a037d"), null, 9118, "ODQFNNU4TMBH47676", 823.52757597363757, 2, 1 },
                    { new Guid("e72b7322-7c5e-456c-9d62-ff83d2194861"), 1, new Guid("88632cc1-1779-4579-8d2c-9fde553fce74"), null, 5321, "DBAOARH1CSBK47003", 3085.2133975238526, 1, 2 },
                    { new Guid("e8d9c08f-15b6-41b6-a4c3-bce0727466ce"), 1, new Guid("dda0c099-f6e8-4891-aaa0-1b82138597ad"), null, 2209, "NQ91BP37V5WC12302", 679.46550167558325, 3, 3 },
                    { new Guid("e8ff642a-7925-4cb6-81e1-5de4c87e549d"), 2, new Guid("0724e700-bbe8-4079-9f17-e2c09b21dcfb"), null, 5709, "B7VRWO9H9QG850235", 2959.9787482858678, 3, 3 },
                    { new Guid("ec29f468-94ed-43a3-9330-23dfd2a4a33c"), 3, new Guid("f0a371df-2456-4543-8c2b-fc299a2e200e"), null, 1349, "F2NTEHPYROXL72966", 2760.1280350597049, 1, 4 },
                    { new Guid("eee41d51-4ade-4ab6-b637-648ba22851f0"), 1, new Guid("1332b9aa-8cf2-4c67-a0f2-93e7a9f1f34e"), null, 6042, "RVRXEA8ZJYIR17063", 3625.4445470832939, 1, 5 },
                    { new Guid("efc45ba4-b9f7-4433-a204-fcd40cd7ad53"), 2, new Guid("50e24ab0-ce48-4d11-bd10-26e9f8d98f0c"), null, 608, "STLNV01VMFW741064", 2478.8666061101399, 1, 5 },
                    { new Guid("f0d30711-3359-4cce-b461-868899f1ef42"), 0, new Guid("dda0c099-f6e8-4891-aaa0-1b82138597ad"), null, 2072, "P4H43SZB1YJZ82455", 1528.1656324110038, 0, 4 },
                    { new Guid("f355f804-38c6-4b47-95d0-391cd1f6213e"), 0, new Guid("72b7ecb9-76f8-4f92-926f-42a419d25c93"), null, 2738, "U07MGJPQSYZ293344", 2254.5330279178247, 0, 5 },
                    { new Guid("f4d8ed60-1def-455b-8216-3fe8dcad8551"), 1, new Guid("5e57c9b9-b1b1-43a2-a487-f99a4e1b4592"), null, 3802, "VMOC6H2J41ZV97476", 2441.9335316123456, 1, 4 },
                    { new Guid("f7310c54-92e0-4571-bad1-2302c0254819"), 3, new Guid("a36a97d8-4026-4db3-ba3e-cab18046c3ea"), null, 4738, "5CLM7HF475O817615", 1733.8694126213829, 3, 3 },
                    { new Guid("f7365d5d-c996-4ade-aad0-d861187a3694"), 2, new Guid("a36a97d8-4026-4db3-ba3e-cab18046c3ea"), null, 6163, "F2AR5F714KWT23177", 3159.7157189542245, 3, 0 },
                    { new Guid("fa03ad51-ab21-4d7d-bc8c-d4f2a80ab138"), 0, new Guid("c174c72c-c49d-463e-b98f-7b0c802b0e96"), null, 1188, "830SHX0OFPR848579", 2232.5118349552613, 2, 5 },
                    { new Guid("faec0425-94f7-4ad0-8485-724cc04cc7a3"), 3, new Guid("dda0c099-f6e8-4891-aaa0-1b82138597ad"), null, 9290, "O5Q2IOHK38FK45893", 3407.8655459180259, 2, 3 },
                    { new Guid("fb394bfd-ace1-4bea-9fe6-1f04e315f25e"), 2, new Guid("ec21adfd-abfa-47bd-a5e7-410bd87e8f9e"), null, 9040, "JBPPD1PBFPX339345", 3339.0652024513947, 3, 3 },
                    { new Guid("fc478c97-f232-45f6-bc68-b5389a4c9339"), 2, new Guid("57a68423-673c-4c63-9067-9f0565474917"), null, 1928, "HVMQB9JGAIUZ42564", 1231.6055893021837, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("104e2c82-b906-4f90-be62-add9013bb3ca"), new Guid("c5aebbda-44d9-4ddc-8544-521aec01812f"), new DateTime(2024, 5, 27, 8, 44, 52, 22, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 1, 23, 11, 48, 56, 964, DateTimeKind.Utc).AddTicks(7619), new Guid("11b2a283-5c68-430f-9133-7adaf57602b1") },
                    { new Guid("1aa4fecb-c7bd-4e29-b79e-560bb656c913"), new Guid("c5aebbda-44d9-4ddc-8544-521aec01812f"), new DateTime(2024, 2, 28, 20, 9, 12, 351, DateTimeKind.Utc).AddTicks(5644), new DateTime(2023, 6, 24, 14, 41, 26, 922, DateTimeKind.Utc).AddTicks(5122), new Guid("314c741e-9539-4c37-bef2-111c70ad4f8e") },
                    { new Guid("55cf98a8-9065-48d0-8d01-cfff7c9fbaa4"), new Guid("c5aebbda-44d9-4ddc-8544-521aec01812f"), new DateTime(2023, 6, 24, 21, 20, 27, 191, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 5, 1, 21, 49, 14, 200, DateTimeKind.Utc).AddTicks(186), new Guid("de527ef4-5333-4313-aeac-b896fb295ff8") },
                    { new Guid("8c3274ac-dc36-4bd7-b1d6-c09020491952"), new Guid("c5aebbda-44d9-4ddc-8544-521aec01812f"), new DateTime(2024, 2, 4, 18, 0, 48, 314, DateTimeKind.Utc).AddTicks(1028), new DateTime(2024, 4, 11, 17, 50, 18, 264, DateTimeKind.Utc).AddTicks(387), new Guid("c05332ca-5c1e-482d-83a9-47178d3e9725") },
                    { new Guid("af802c8d-58ed-42e4-adef-dd8dc9068a02"), new Guid("c5aebbda-44d9-4ddc-8544-521aec01812f"), new DateTime(2023, 7, 13, 6, 49, 45, 147, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 3, 27, 12, 34, 54, 32, DateTimeKind.Utc).AddTicks(9357), new Guid("c12a50e5-2a38-4c7e-b89f-e0b23eba0b20") }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0724e700-bbe8-4079-9f17-e2c09b21dcfb"), new Guid("58c5c112-9e6b-4415-afb6-4ee4e600284b"), "Malibu" },
                    { new Guid("0a35ff90-4efc-4422-9612-76e03974a2f6"), new Guid("60c2cc48-eab7-4943-a3af-57eb865a7bd7"), "ATS" },
                    { new Guid("1332b9aa-8cf2-4c67-a0f2-93e7a9f1f34e"), new Guid("58c5c112-9e6b-4415-afb6-4ee4e600284b"), "Wrangler" },
                    { new Guid("4301d396-bbe4-49c3-b12c-8a5688b4e2fe"), new Guid("58c5c112-9e6b-4415-afb6-4ee4e600284b"), "Golf" },
                    { new Guid("462ed1d7-4c19-4572-a2eb-3366a2e4693a"), new Guid("60c2cc48-eab7-4943-a3af-57eb865a7bd7"), "Sentra" },
                    { new Guid("50e24ab0-ce48-4d11-bd10-26e9f8d98f0c"), new Guid("e33c997f-098c-4a50-8248-ddbd287aa698"), "Model T" },
                    { new Guid("57a68423-673c-4c63-9067-9f0565474917"), new Guid("58c5c112-9e6b-4415-afb6-4ee4e600284b"), "Durango" },
                    { new Guid("5c8603db-1cf4-47a0-a02b-8164425ccace"), new Guid("6e19f0ed-9464-463b-90bd-de3bc8709bda"), "Mercielago" },
                    { new Guid("5e57c9b9-b1b1-43a2-a487-f99a4e1b4592"), new Guid("60c2cc48-eab7-4943-a3af-57eb865a7bd7"), "Altima" },
                    { new Guid("647aabef-d596-449f-8634-ca7f3ad5ebb6"), new Guid("6e19f0ed-9464-463b-90bd-de3bc8709bda"), "Explorer" },
                    { new Guid("6db7c681-c188-4d29-ac1a-024b537c0973"), new Guid("6e19f0ed-9464-463b-90bd-de3bc8709bda"), "PT Cruiser" },
                    { new Guid("72b7ecb9-76f8-4f92-926f-42a419d25c93"), new Guid("e33c997f-098c-4a50-8248-ddbd287aa698"), "Camry" },
                    { new Guid("88632cc1-1779-4579-8d2c-9fde553fce74"), new Guid("6e19f0ed-9464-463b-90bd-de3bc8709bda"), "Roadster" },
                    { new Guid("88b6181a-e2f1-4533-a3c7-ca4f1ae6c330"), new Guid("60c2cc48-eab7-4943-a3af-57eb865a7bd7"), "Malibu" },
                    { new Guid("98860bd4-682b-4930-a481-81e59e612aa0"), new Guid("6e19f0ed-9464-463b-90bd-de3bc8709bda"), "Element" },
                    { new Guid("a36a97d8-4026-4db3-ba3e-cab18046c3ea"), new Guid("bb7ea001-6e01-41bb-a55f-f694d34439c5"), "CX-9" },
                    { new Guid("bc7f894f-d198-4ef5-af37-e394da7a037d"), new Guid("60c2cc48-eab7-4943-a3af-57eb865a7bd7"), "ATS" },
                    { new Guid("bfb570cb-387f-4e43-a39a-017daea04fe7"), new Guid("bb7ea001-6e01-41bb-a55f-f694d34439c5"), "Silverado" },
                    { new Guid("c174c72c-c49d-463e-b98f-7b0c802b0e96"), new Guid("e33c997f-098c-4a50-8248-ddbd287aa698"), "Wrangler" },
                    { new Guid("c2c3070c-ddd5-4470-9f20-23c3d37f667e"), new Guid("bb7ea001-6e01-41bb-a55f-f694d34439c5"), "Model 3" },
                    { new Guid("d78e8a63-167a-4323-b92d-c16cbca7ac27"), new Guid("e33c997f-098c-4a50-8248-ddbd287aa698"), "F-150" },
                    { new Guid("dda0c099-f6e8-4891-aaa0-1b82138597ad"), new Guid("bb7ea001-6e01-41bb-a55f-f694d34439c5"), "Grand Caravan" },
                    { new Guid("e432c58f-2712-4e67-aed0-0f2c9364cf34"), new Guid("bb7ea001-6e01-41bb-a55f-f694d34439c5"), "1" },
                    { new Guid("ec21adfd-abfa-47bd-a5e7-410bd87e8f9e"), new Guid("58c5c112-9e6b-4415-afb6-4ee4e600284b"), "Colorado" },
                    { new Guid("f0a371df-2456-4543-8c2b-fc299a2e200e"), new Guid("e33c997f-098c-4a50-8248-ddbd287aa698"), "Camry" }
                });

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
