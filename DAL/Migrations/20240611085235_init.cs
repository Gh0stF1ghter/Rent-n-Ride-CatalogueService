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
                values: new object[] { new Guid("620e1326-bd16-474c-ba79-16356640f3a8"), "Milo.Botsford33@gmail.com", "Bette", "Barton", "1-209-931-9131 x886" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a2e3d429-9c44-4cc8-94c7-57f11b0848ac"), "Porsche" },
                    { new Guid("c0300098-2a0f-4ab5-b987-74af75739d8f"), "Honda" },
                    { new Guid("c114a801-3f6d-4eb0-9a60-8e31a5039589"), "Maserati" },
                    { new Guid("da266208-001c-4ada-ad4f-96978db63c94"), "Rolls Royce" },
                    { new Guid("fb42c12c-595b-4760-9d0b-f7bcf36d367d"), "Dodge" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "ModelNameId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("00a04a8c-d571-48f4-a77e-f36b98aaf02d"), 3, new Guid("3b07cda8-76d4-4989-bf35-07092bf9a35c"), null, 3535, "8LM6BBVXFPKG75996", 1490.7600270925757, 2, 4 },
                    { new Guid("05e48f36-49c6-4c7d-ae3b-1379d52760df"), 0, new Guid("8b66b146-b82e-4057-a343-a49e8fca8269"), null, 2106, "MJ9LEJJ190C363219", 1978.9778969493589, 2, 4 },
                    { new Guid("070e1c1d-5c63-4f15-8239-80b60d084d23"), 2, new Guid("fa5e1095-f059-4672-b7e8-cef2bb2c9098"), null, 6456, "RJH753WXW0O488661", 2641.6658812010351, 2, 1 },
                    { new Guid("07aa72ef-bca8-4d4b-bbd1-3de776ad50bc"), 3, new Guid("0cf5ccd2-f87e-4026-8d13-ebbb023c9be6"), null, 5118, "QP9L9VZWXLNM84817", 1597.0541317258915, 0, 0 },
                    { new Guid("09a29a83-25ae-4193-b4c5-59ef66789322"), 3, new Guid("6c3295fd-474b-4269-84ac-cf60439fbbe9"), null, 4604, "XL9UPYRS8RKE65356", 1939.1321656701823, 2, 1 },
                    { new Guid("0b749eb8-58a2-4d1f-95b1-64bc9fe5cba2"), 1, new Guid("24a8daaf-8337-459d-b365-125bc0a5554f"), null, 598, "UQGOV0WMECOY43231", 3635.498519060814, 0, 2 },
                    { new Guid("0c1c03dd-c19d-4195-aeca-04751c67cdd3"), 1, new Guid("d80c6e25-4af7-4c49-97ca-58fa1f3f9e39"), null, 8822, "6QFZMH1VIYWO45604", 156.25753726330609, 0, 4 },
                    { new Guid("0cdefbf4-0007-4d72-a701-ef7442fba331"), 1, new Guid("d80c6e25-4af7-4c49-97ca-58fa1f3f9e39"), null, 6300, "M5008EQTD9KG23920", 2286.896023983863, 3, 5 },
                    { new Guid("100b7e97-5060-4799-b69b-56b710148293"), 2, new Guid("6c3295fd-474b-4269-84ac-cf60439fbbe9"), null, 5524, "1ME6RFPMNZOL61663", 3617.6797943490178, 2, 0 },
                    { new Guid("11826336-14cb-4814-9f97-cd07aee2792f"), 3, new Guid("3d60ff96-9955-40f4-9fec-8101045a3365"), null, 9627, "7WYQ2UDCQ8S729873", 3064.0080884434601, 2, 2 },
                    { new Guid("11ea5c62-b25e-4b9a-ab59-ff7b03a1e4a6"), 1, new Guid("9eb8a33e-0351-4be0-9f4b-2ce6398fd703"), null, 6498, "EF6XZXGOU1G728575", 307.98316771867701, 2, 0 },
                    { new Guid("12649ecb-e49f-4e3d-a84a-94a88b8e26f7"), 3, new Guid("acea193c-79ff-490a-b56b-3eea1c5c9216"), null, 9402, "V7ZAWQCYDVCV41550", 870.45853545001614, 3, 4 },
                    { new Guid("13e4a11e-ead7-4322-9e5d-447075cbe09e"), 2, new Guid("c148e18a-88b1-446d-be26-212243cdffb7"), null, 8027, "4BX68E7M46BE59910", 2022.9649864584626, 1, 4 },
                    { new Guid("16a3e8a6-21ec-4c94-ab06-997218188151"), 0, new Guid("3b07cda8-76d4-4989-bf35-07092bf9a35c"), null, 5200, "4XOSVZ2GEKVN96514", 859.47673476129614, 1, 5 },
                    { new Guid("18385aa3-b59d-43d7-afc4-ee33ee36e9e9"), 0, new Guid("599a7abb-6894-4d72-98a4-26e359262fab"), null, 9069, "J8DXAE8VP3BI59616", 3943.2708959579354, 1, 1 },
                    { new Guid("186522b6-26c7-4d66-ba7a-568231e772ef"), 3, new Guid("3fdc8922-31d4-4f81-a804-29aba5c78600"), null, 2391, "Y718Y7O1MLG086679", 3582.9712118987982, 3, 0 },
                    { new Guid("191eeaab-980c-4f31-ac56-1d3d6f8c584c"), 0, new Guid("acea193c-79ff-490a-b56b-3eea1c5c9216"), null, 4653, "11TWF0IWB2LG27531", 2343.9848786960765, 0, 2 },
                    { new Guid("1a71c3fe-eb53-4190-9c22-2c148bfae794"), 2, new Guid("3e8f4dc1-850d-4b56-9f79-eb3bfd8e2c1c"), null, 5073, "6KZQ5VAEKLAR76955", 262.12617774841362, 1, 0 },
                    { new Guid("1c429dd3-4928-4c01-86b0-b47123fa3787"), 2, new Guid("3b07cda8-76d4-4989-bf35-07092bf9a35c"), null, 4457, "P0M70OTPTMCG23261", 3346.8026703228852, 0, 3 },
                    { new Guid("1d259bba-0f40-4393-afa4-135c787607d4"), 2, new Guid("9eb8a33e-0351-4be0-9f4b-2ce6398fd703"), null, 4138, "PKLB52QUJEJI34478", 2445.5318650653271, 1, 4 },
                    { new Guid("2176da9e-ee14-472f-a64f-e1d029bddf40"), 1, new Guid("98648004-1d56-44cf-ad84-24b8eeb6ed20"), null, 4967, "IKOCNJQTLKNH26513", 1899.9188987968473, 3, 5 },
                    { new Guid("2434822d-f404-46ab-a670-d6cffff72f24"), 1, new Guid("599a7abb-6894-4d72-98a4-26e359262fab"), null, 264, "RV1UTU87B0NO69655", 1040.3018346513875, 0, 5 },
                    { new Guid("26cb3558-d8e2-4c0a-91d1-2ebbd6531ccb"), 1, new Guid("0db382d2-09a9-44a3-9751-a87c3d450cca"), null, 8124, "5SDY2GWF2AJV41262", 3218.3110492415767, 0, 2 },
                    { new Guid("275e809e-77ae-4516-bbad-2c198e27860b"), 2, new Guid("64611803-bcef-4bf8-8132-fee42ebd2d55"), null, 4093, "6R96YP2FJLE230861", 3480.5379752108256, 1, 0 },
                    { new Guid("283a58de-39b7-4fb8-8473-f4f221dd4df0"), 2, new Guid("d80c6e25-4af7-4c49-97ca-58fa1f3f9e39"), null, 6998, "1UYG6AI3IRFW60135", 1117.2577036075099, 3, 1 },
                    { new Guid("29ee4b9d-d10e-4e7a-96c5-74d3b05d5ffc"), 1, new Guid("64611803-bcef-4bf8-8132-fee42ebd2d55"), null, 2950, "ERHIOKVSH0PR99783", 2081.1253646544114, 3, 3 },
                    { new Guid("2a529d90-1905-49af-b54f-d849c15b5756"), 1, new Guid("02b35ef0-01cd-4d8a-9b19-3f1e24ee155c"), null, 5892, "61CQ21PHJEQB84728", 2360.4493733266804, 1, 0 },
                    { new Guid("2d2b5b55-6ecb-473c-96e2-7ae460296aa2"), 2, new Guid("1e62b078-df9d-4b57-b963-e071b9729821"), null, 4171, "G7ZHPFSD60EE56944", 3811.0146292437871, 2, 2 },
                    { new Guid("32579633-7b96-4a6e-bf0a-1bd82d361e08"), 1, new Guid("98648004-1d56-44cf-ad84-24b8eeb6ed20"), null, 9390, "DDV3WGCVSBR621126", 1417.7165334625208, 3, 0 },
                    { new Guid("338cb5c2-06dc-407d-af4b-7fa2444ad8b4"), 1, new Guid("d36a0d38-25e1-44da-bfdc-2354fcee7ee3"), null, 6010, "LFY26L7R3OSR56944", 2079.3187614863918, 3, 1 },
                    { new Guid("35ba11d0-5296-494e-87a9-bc2d7235989f"), 3, new Guid("1e62b078-df9d-4b57-b963-e071b9729821"), null, 8355, "6T3OPWVCZHVI38238", 2702.4004507984887, 2, 4 },
                    { new Guid("379f55f8-f99e-4a8b-a166-9bcf3d893a90"), 3, new Guid("5a57d85e-6ad8-4ad1-9365-6a88076d5da5"), null, 7781, "IZE06PB7IMEB89726", 361.34840582819538, 2, 4 },
                    { new Guid("37b04e06-b8d0-478c-8157-fb58e30c3a84"), 0, new Guid("3d60ff96-9955-40f4-9fec-8101045a3365"), null, 629, "PAS3GT83M5CX18379", 2938.9659038900782, 1, 1 },
                    { new Guid("3b2f312b-9c00-407c-b6c4-85f57b06fd78"), 0, new Guid("9eb8a33e-0351-4be0-9f4b-2ce6398fd703"), null, 6782, "D8EZZSRNNAPK55329", 3239.2241011309416, 1, 5 },
                    { new Guid("3e5ba169-c5f7-45e7-926d-95edaab459fe"), 3, new Guid("c148e18a-88b1-446d-be26-212243cdffb7"), null, 3671, "JVL9YYAMYTNK37515", 152.10833898870916, 2, 0 },
                    { new Guid("3f203177-c264-4511-99ce-e18f4b11edf4"), 0, new Guid("599a7abb-6894-4d72-98a4-26e359262fab"), null, 182, "UIRZ0M1TX3AE71489", 3878.9434551483496, 1, 5 },
                    { new Guid("4aa8e619-7693-46ec-9edb-cccc6212fc1e"), 0, new Guid("23b61a3c-ce67-4d25-8177-da9c7f8f43ae"), null, 4891, "PH8KCTA47HKI81501", 2896.0013046541035, 3, 5 },
                    { new Guid("4b3bae51-ebec-4440-afe3-782376e92883"), 2, new Guid("d8c337a9-c89d-41e1-8c1f-4bee38c64ec1"), null, 1293, "UBSE6ND1N0OJ80265", 245.64447733619608, 3, 3 },
                    { new Guid("4e0cf3be-7f28-4461-bf51-a18d5d828df4"), 0, new Guid("6c3295fd-474b-4269-84ac-cf60439fbbe9"), null, 7034, "JPPM8NPYM3JT25511", 2458.5095205294774, 1, 1 },
                    { new Guid("4f08f1fe-18a8-46a5-bedd-ce757fbdce49"), 2, new Guid("fa5e1095-f059-4672-b7e8-cef2bb2c9098"), null, 2717, "Y85IQQFL94PC64968", 2363.8227909476655, 0, 1 },
                    { new Guid("519768bc-91f2-43d7-9a51-2574ddeb3cb6"), 2, new Guid("0cf5ccd2-f87e-4026-8d13-ebbb023c9be6"), null, 660, "4H8LDHRPNTI457201", 2418.5535448430005, 0, 0 },
                    { new Guid("537b287f-affc-47dd-aa2b-0f71ea3de567"), 1, new Guid("3fdc8922-31d4-4f81-a804-29aba5c78600"), null, 9766, "YR3FFZSWKYQ444783", 713.07114407357813, 2, 0 },
                    { new Guid("541cfb64-1f2e-4828-bb8b-ebb93b8e38a4"), 3, new Guid("6c3295fd-474b-4269-84ac-cf60439fbbe9"), null, 5996, "W09P7SD5R0I517259", 1844.0447221336351, 2, 3 },
                    { new Guid("5494750d-7d36-4a46-8924-991c4af88fb3"), 1, new Guid("d8c337a9-c89d-41e1-8c1f-4bee38c64ec1"), null, 8452, "7DTHOIM9HQIB51188", 1025.3419589040475, 1, 1 },
                    { new Guid("5efe115d-aad0-489a-b8fe-8932890d602f"), 1, new Guid("1e62b078-df9d-4b57-b963-e071b9729821"), null, 3312, "FZP5IEBVTLAI82925", 1262.4197680288567, 1, 1 },
                    { new Guid("5f09567d-c009-4d6b-9b6b-36e338b2e95a"), 3, new Guid("5a57d85e-6ad8-4ad1-9365-6a88076d5da5"), null, 8063, "GYYNAAGK3FVC84726", 203.04529528220894, 1, 2 },
                    { new Guid("5fe10317-edac-442e-b4a0-5ff2e1df8395"), 0, new Guid("d36a0d38-25e1-44da-bfdc-2354fcee7ee3"), null, 3860, "G4OJBPPKA8TH54762", 3711.4968648426157, 2, 0 },
                    { new Guid("606ebb88-ff1a-4f3a-b943-3fc95f82f9d9"), 2, new Guid("d36a0d38-25e1-44da-bfdc-2354fcee7ee3"), null, 5880, "QVRME0GSBMN888418", 3696.333324100317, 0, 3 },
                    { new Guid("6300ca68-436b-4987-8d53-dce55688d7c7"), 2, new Guid("6c3295fd-474b-4269-84ac-cf60439fbbe9"), null, 4893, "2B6RB34BA2AY93581", 2719.8724181549042, 1, 3 },
                    { new Guid("685ea0ce-1ef5-40c6-be6a-089a07b712b1"), 0, new Guid("3fdc8922-31d4-4f81-a804-29aba5c78600"), null, 6520, "OW891YYB9NIU86795", 1134.1244473735417, 1, 3 },
                    { new Guid("6a1f6d04-4b66-42e7-895c-ad8e8aeb0921"), 1, new Guid("02b35ef0-01cd-4d8a-9b19-3f1e24ee155c"), null, 8499, "Q103IYPE8EYA92448", 3068.2537831923269, 0, 3 },
                    { new Guid("6b692e15-d3a5-4b26-b713-a3703b270442"), 3, new Guid("98648004-1d56-44cf-ad84-24b8eeb6ed20"), null, 2933, "FPD6I3890FYM24967", 3820.8066427564863, 1, 5 },
                    { new Guid("6be71611-038e-46fe-a62a-d116df453460"), 1, new Guid("3fdc8922-31d4-4f81-a804-29aba5c78600"), null, 4651, "QWLFC8IB40H394645", 1345.7959469046168, 0, 4 },
                    { new Guid("6c9000d7-1844-429e-b91f-eb7b601fbd87"), 1, new Guid("3e8f4dc1-850d-4b56-9f79-eb3bfd8e2c1c"), null, 4916, "7B1OXNCUCEXT91506", 3819.9986544522762, 1, 5 },
                    { new Guid("6f024be1-f0ae-4cf4-aee4-2d85025134a8"), 1, new Guid("d9f2bff6-0afd-4146-b36f-da2882fa76a6"), null, 1859, "KNDCBU2MS5DE95983", 3322.86287147638, 2, 4 },
                    { new Guid("712590f2-556d-41ea-b0c2-d861f670ab56"), 0, new Guid("8b66b146-b82e-4057-a343-a49e8fca8269"), null, 5494, "016T9MGNI2JC52800", 853.62920187091504, 2, 3 },
                    { new Guid("729aa0f7-cdef-4372-880a-6484c61c2a11"), 0, new Guid("599a7abb-6894-4d72-98a4-26e359262fab"), null, 368, "MQJO480UOVTI64860", 2620.4637397463116, 3, 5 },
                    { new Guid("74435be8-d980-41aa-8058-0dc5ec3bdb51"), 3, new Guid("acea193c-79ff-490a-b56b-3eea1c5c9216"), null, 5875, "XG5EIPZGTWI238124", 3998.2196207984343, 3, 5 },
                    { new Guid("745fffd4-116a-4795-a9a3-6729ccc3d00a"), 3, new Guid("3fdc8922-31d4-4f81-a804-29aba5c78600"), null, 7745, "1K5ZVBJ5BYD691691", 336.56903265942447, 3, 3 },
                    { new Guid("76adfa35-1e4a-4742-b226-ddb0a5489e6b"), 0, new Guid("c148e18a-88b1-446d-be26-212243cdffb7"), null, 8266, "JVQLK2K77RM077146", 255.09284488754147, 0, 2 },
                    { new Guid("7a56b932-482b-4be8-b457-72152b7d6750"), 1, new Guid("21408ca9-511f-4b9c-a360-ec6907d22884"), null, 3231, "W511B8D0O4TO84529", 1905.8158403506054, 2, 4 },
                    { new Guid("7d9a17f4-d652-4dc2-8179-6721b23c2af8"), 0, new Guid("5a57d85e-6ad8-4ad1-9365-6a88076d5da5"), null, 6979, "LORG10MEA4WI18482", 2015.9225439134977, 2, 4 },
                    { new Guid("7e446375-7c8f-47b2-aec3-0ea8da2aabc7"), 3, new Guid("21408ca9-511f-4b9c-a360-ec6907d22884"), null, 525, "UMN84515PPIZ52258", 3286.7666630660756, 0, 0 },
                    { new Guid("802ed124-218d-40db-81b8-549a19580d71"), 1, new Guid("3b07cda8-76d4-4989-bf35-07092bf9a35c"), null, 1937, "G98MNIRXSSD552574", 2968.5830755564234, 0, 4 },
                    { new Guid("80f35aec-967e-43c2-9db5-dce3656ccd79"), 3, new Guid("d9f2bff6-0afd-4146-b36f-da2882fa76a6"), null, 25, "Y5AOWSJYOYQP39363", 1778.4557397505955, 3, 5 },
                    { new Guid("8438a8d4-8d54-46c4-a8e5-77e44b1a83c2"), 0, new Guid("3e8f4dc1-850d-4b56-9f79-eb3bfd8e2c1c"), null, 1803, "Z5A8Q9VEQRKF20044", 1402.805627942111, 1, 0 },
                    { new Guid("861e652f-542b-4cd4-9c58-7498f804e489"), 0, new Guid("0db382d2-09a9-44a3-9751-a87c3d450cca"), null, 8635, "ZXHPJZ1TTOST16959", 3714.1675068798818, 0, 3 },
                    { new Guid("8a618924-1763-4ab8-b731-08e8636176f4"), 2, new Guid("d36a0d38-25e1-44da-bfdc-2354fcee7ee3"), null, 2843, "T1P1ADGN8VNO92612", 1285.5653724363683, 3, 5 },
                    { new Guid("8b41fba8-2fdb-4373-a846-04dda59c7711"), 2, new Guid("acea193c-79ff-490a-b56b-3eea1c5c9216"), null, 5861, "BZ23HR9VTGBC34599", 3669.3605118855317, 1, 2 },
                    { new Guid("8bf6f7d8-a809-4fa1-8304-975400f9eb67"), 3, new Guid("98648004-1d56-44cf-ad84-24b8eeb6ed20"), null, 9438, "91OWY9V8CSRY70479", 1557.5433097131938, 1, 5 },
                    { new Guid("8c0a1598-931e-47a1-99f3-ed3222e965bd"), 2, new Guid("9eb8a33e-0351-4be0-9f4b-2ce6398fd703"), null, 7911, "4FMI5RZVOFSI99469", 3197.3257836845523, 2, 3 },
                    { new Guid("8d57fa56-2cfd-4350-a433-185dd2e67fad"), 0, new Guid("3d60ff96-9955-40f4-9fec-8101045a3365"), null, 5095, "SX97FT3PTEKI43578", 3176.1325420089124, 2, 5 },
                    { new Guid("8db133cf-cc08-4003-aebf-37124a263145"), 0, new Guid("02b35ef0-01cd-4d8a-9b19-3f1e24ee155c"), null, 7563, "QA2BQT1IB6PY95773", 3576.4826760206515, 2, 1 },
                    { new Guid("9158f753-593e-4891-a51d-effeeeeba0d6"), 3, new Guid("3e8f4dc1-850d-4b56-9f79-eb3bfd8e2c1c"), null, 442, "418K1IYURIT244086", 1669.3026033561518, 0, 0 },
                    { new Guid("917fd3d8-67f8-4004-9537-c32b91f98182"), 2, new Guid("23b61a3c-ce67-4d25-8177-da9c7f8f43ae"), null, 697, "GYDQ3RR73NVX68952", 1507.0534633258433, 1, 0 },
                    { new Guid("91b6110d-4cf2-4b6d-8da5-3cd698fc96f3"), 2, new Guid("0db382d2-09a9-44a3-9751-a87c3d450cca"), null, 2342, "HNMFXHKSZ9EG24141", 2412.0835520622518, 2, 4 },
                    { new Guid("923c440d-4747-4634-a850-5dcf1ab6576d"), 2, new Guid("0db382d2-09a9-44a3-9751-a87c3d450cca"), null, 4958, "HUQXKOWPIKSL94472", 825.57098550474279, 3, 2 },
                    { new Guid("9257584f-c5c9-4fc0-b8da-d41df0cc98c9"), 0, new Guid("d80c6e25-4af7-4c49-97ca-58fa1f3f9e39"), null, 5295, "EFT163ADLTBX33885", 353.13516957939532, 3, 1 },
                    { new Guid("953bb464-19a0-4ba9-893f-e90700b726f7"), 1, new Guid("0cf5ccd2-f87e-4026-8d13-ebbb023c9be6"), null, 6331, "INPTBUD7JQNM70078", 620.25259981552904, 3, 0 },
                    { new Guid("961a7b80-183e-458f-b740-3dfb35cbda14"), 1, new Guid("24a8daaf-8337-459d-b365-125bc0a5554f"), null, 6844, "O9R0N3SGXAEC72128", 3382.1115284662546, 3, 4 },
                    { new Guid("9a246027-7e5a-4ff7-b3de-a891b62c7b1c"), 2, new Guid("599a7abb-6894-4d72-98a4-26e359262fab"), null, 6636, "4KGJSW43NGPV94925", 597.19496120008102, 0, 0 },
                    { new Guid("9d1c5ce7-7080-44ad-b8bb-e2f20b1ab524"), 1, new Guid("64611803-bcef-4bf8-8132-fee42ebd2d55"), null, 1131, "HNERK1UEVRU165773", 916.31754917794001, 1, 5 },
                    { new Guid("9f5f24e3-0c1f-497f-9eeb-fffbad523402"), 0, new Guid("98648004-1d56-44cf-ad84-24b8eeb6ed20"), null, 5693, "Z8MTGIY7XAE714175", 1906.0088581891769, 3, 5 },
                    { new Guid("a02370aa-aec7-4f60-8199-45befeb8c5e5"), 2, new Guid("8b66b146-b82e-4057-a343-a49e8fca8269"), null, 4524, "RAH4VF65WVG084850", 3091.4233530135225, 0, 4 },
                    { new Guid("a03612bc-d777-4527-8cce-cc2d85d41481"), 1, new Guid("3d60ff96-9955-40f4-9fec-8101045a3365"), null, 87, "D6C34JJDHTA074184", 3998.6831534849694, 1, 2 },
                    { new Guid("a18e89ad-f259-407a-af83-4452c753bb84"), 2, new Guid("0cf5ccd2-f87e-4026-8d13-ebbb023c9be6"), null, 9258, "P4HLQZZFXCNN51612", 240.79053504587102, 0, 5 },
                    { new Guid("a29a0576-f3ee-4062-9833-79c1855760d8"), 0, new Guid("c148e18a-88b1-446d-be26-212243cdffb7"), null, 4107, "QJ2PS6RVZ6SE47959", 3094.8346422807881, 2, 0 },
                    { new Guid("a6257dc7-7fac-4746-8a2d-3311a771a597"), 3, new Guid("24a8daaf-8337-459d-b365-125bc0a5554f"), null, 2745, "UH2XA0IJUTON87619", 3567.7283860022517, 2, 0 },
                    { new Guid("a7d3cc33-84b9-41d4-b53e-0706f76f634c"), 3, new Guid("02b35ef0-01cd-4d8a-9b19-3f1e24ee155c"), null, 9676, "6PK84VTNN6UD35389", 2192.5344973847054, 0, 4 },
                    { new Guid("a89007b2-a72d-4ffe-802e-dfebd037e0d5"), 1, new Guid("64611803-bcef-4bf8-8132-fee42ebd2d55"), null, 1660, "NACPI9Z6I8WK85979", 2452.8924061816169, 1, 1 },
                    { new Guid("aa1a99e6-42ec-420e-9552-207205bce135"), 1, new Guid("fa5e1095-f059-4672-b7e8-cef2bb2c9098"), null, 9119, "4161G6DYFIF479333", 2957.2057403765384, 2, 2 },
                    { new Guid("aac3d840-3487-47cc-92fa-c7374337df91"), 0, new Guid("23b61a3c-ce67-4d25-8177-da9c7f8f43ae"), null, 2336, "87UMLUE9PNJF51643", 1136.0411825917686, 2, 1 },
                    { new Guid("aeb377b7-d0d7-4c0a-afe1-45d0cf497b5f"), 2, new Guid("5a57d85e-6ad8-4ad1-9365-6a88076d5da5"), null, 2055, "14HOGFMPIPCD19491", 392.18191301111636, 3, 2 },
                    { new Guid("af36fda8-c9ed-4702-a1eb-7c11bed80e31"), 1, new Guid("d8c337a9-c89d-41e1-8c1f-4bee38c64ec1"), null, 9717, "3O9U0LR94GZX19330", 2643.6938244925045, 1, 3 },
                    { new Guid("b10f4510-ef09-47f7-a716-693cacdd81d4"), 1, new Guid("8b66b146-b82e-4057-a343-a49e8fca8269"), null, 235, "G63LOCUWIRK542308", 2562.6032086194441, 2, 2 },
                    { new Guid("b21be1c8-fa9e-451e-b5e1-4c5e7ccf8517"), 0, new Guid("64611803-bcef-4bf8-8132-fee42ebd2d55"), null, 7678, "D21KCB6ASSOM51934", 564.21959656696993, 2, 3 },
                    { new Guid("b43407ab-13ab-40a3-9a7b-b4c431bf2540"), 3, new Guid("23b61a3c-ce67-4d25-8177-da9c7f8f43ae"), null, 5977, "8R1X2R9OBSQ985070", 556.66163906470968, 3, 4 },
                    { new Guid("b6908416-e012-4fba-b5f5-0922a979fe46"), 0, new Guid("d9f2bff6-0afd-4146-b36f-da2882fa76a6"), null, 117, "YKNEUE5GD0F568315", 677.42381156206841, 0, 2 },
                    { new Guid("b8f33ac9-6db3-4d80-bd7f-382ab431aea7"), 3, new Guid("1e62b078-df9d-4b57-b963-e071b9729821"), null, 8297, "OG2AQI139YAQ84095", 1644.531347418837, 3, 3 },
                    { new Guid("b98a3862-0eb4-49c3-b053-20fa1b3f2dd5"), 2, new Guid("1e62b078-df9d-4b57-b963-e071b9729821"), null, 433, "AHKR838VEVJ412211", 2817.3936137682799, 0, 2 },
                    { new Guid("b99c3f41-eed6-49fe-9fd9-910b1b044b46"), 0, new Guid("d8c337a9-c89d-41e1-8c1f-4bee38c64ec1"), null, 9469, "D8VHNODCW5IY41344", 1400.1283854183669, 1, 0 },
                    { new Guid("c58ee51b-162d-437e-9175-22ba1cee632e"), 1, new Guid("23b61a3c-ce67-4d25-8177-da9c7f8f43ae"), null, 7264, "VWSDC5YA1CC987363", 1436.1891083990788, 3, 1 },
                    { new Guid("c6e96234-c30f-4563-af7c-d3071f01769d"), 1, new Guid("3b07cda8-76d4-4989-bf35-07092bf9a35c"), null, 2120, "GWTQ17O1S8JM62754", 895.06267290926246, 2, 0 },
                    { new Guid("c9daee2b-e548-4465-a1d5-868e0325d1ea"), 0, new Guid("24a8daaf-8337-459d-b365-125bc0a5554f"), null, 206, "8EFI4CZ7QGQC47785", 2704.5109348878077, 3, 3 },
                    { new Guid("cc14932a-85b1-49a2-b346-fde004561b85"), 3, new Guid("d9f2bff6-0afd-4146-b36f-da2882fa76a6"), null, 6534, "ZY2ZVQSGB1SU49590", 1714.0347753904, 0, 3 },
                    { new Guid("cdb1726d-0881-4a39-97f1-9797f289c9d3"), 1, new Guid("9eb8a33e-0351-4be0-9f4b-2ce6398fd703"), null, 8224, "TJYRTSE7ZBRY78582", 2274.5228800853311, 1, 4 },
                    { new Guid("ce41f512-af93-48d5-88a9-ee792ce4b1fb"), 3, new Guid("8b66b146-b82e-4057-a343-a49e8fca8269"), null, 9495, "FD3IOFI2EZLX82949", 3116.9174316025751, 1, 2 },
                    { new Guid("d51c8fe2-2dff-4e32-87f5-d0b90b73e5bc"), 2, new Guid("5a57d85e-6ad8-4ad1-9365-6a88076d5da5"), null, 3870, "83JHNUGHS7BC51688", 4000.370907766533, 0, 3 },
                    { new Guid("d58b74a4-130e-4fcc-892e-6cc77c837547"), 3, new Guid("24a8daaf-8337-459d-b365-125bc0a5554f"), null, 3686, "GENZIJ9XGVS219239", 3982.6413052588318, 2, 1 },
                    { new Guid("db041257-e2e0-45f3-80f8-2acf79ddbb4e"), 0, new Guid("d80c6e25-4af7-4c49-97ca-58fa1f3f9e39"), null, 8506, "1SMJGSJZ75NN15476", 662.81294688272567, 3, 4 },
                    { new Guid("dcdc4b9f-8a47-44e0-b89a-e01c9aef54e7"), 1, new Guid("3e8f4dc1-850d-4b56-9f79-eb3bfd8e2c1c"), null, 2264, "8B7XM7E0WYER46268", 285.01109205374689, 2, 1 },
                    { new Guid("e4843a6d-ecb2-45b2-a201-4d49abfc7405"), 0, new Guid("fa5e1095-f059-4672-b7e8-cef2bb2c9098"), null, 2099, "CJZXC8XIR9TQ86688", 1471.7578467180101, 0, 5 },
                    { new Guid("e52600d2-ca3f-42d6-ad44-4f8efaba63ce"), 2, new Guid("21408ca9-511f-4b9c-a360-ec6907d22884"), null, 3345, "JCCNE1X08SJ753431", 3746.8559841851256, 3, 1 },
                    { new Guid("ea678c2b-50a1-498b-94ed-84822e554630"), 2, new Guid("21408ca9-511f-4b9c-a360-ec6907d22884"), null, 8364, "3E2SYOSV31GR19721", 2127.5530897941771, 0, 2 },
                    { new Guid("f03e4e15-4e67-470e-ae11-48f1d99856ec"), 0, new Guid("fa5e1095-f059-4672-b7e8-cef2bb2c9098"), null, 352, "1GDZ1E4NVWIU66260", 1271.4954962520183, 2, 3 },
                    { new Guid("f0ec4117-2dbb-4c23-bd6f-a1a75da13431"), 1, new Guid("02b35ef0-01cd-4d8a-9b19-3f1e24ee155c"), null, 8513, "7IKFO0ZXJFM771060", 825.68540331373833, 0, 1 },
                    { new Guid("f1ba06f4-2d87-47c1-b79f-88e5ef7b5462"), 3, new Guid("d36a0d38-25e1-44da-bfdc-2354fcee7ee3"), null, 6618, "WQHWKB2IJ0FQ83862", 1469.3248090655247, 2, 4 },
                    { new Guid("f3c102be-3316-4f82-9f0c-9fd01e900803"), 0, new Guid("0cf5ccd2-f87e-4026-8d13-ebbb023c9be6"), null, 6038, "GHU0GTZO8QRI65629", 2203.224038148393, 3, 0 },
                    { new Guid("f52b8eea-83fd-433e-9e10-e70050636df5"), 2, new Guid("d8c337a9-c89d-41e1-8c1f-4bee38c64ec1"), null, 4820, "LSN2B5DR3MJA79693", 1229.3767607202458, 2, 5 },
                    { new Guid("f576de07-210c-40ce-bc20-8b75c9ed8438"), 0, new Guid("acea193c-79ff-490a-b56b-3eea1c5c9216"), null, 1463, "DCEO3KOJOKE363826", 2070.9305944122107, 2, 3 },
                    { new Guid("f74da237-00db-41b4-85ab-e3d3f8fd7588"), 1, new Guid("21408ca9-511f-4b9c-a360-ec6907d22884"), null, 7539, "AT9NHB976RP118140", 3811.630273283693, 1, 4 },
                    { new Guid("f7ffaa45-fdbd-4480-aeab-49f7149e6d3b"), 1, new Guid("d9f2bff6-0afd-4146-b36f-da2882fa76a6"), null, 8337, "F1KGIJNAB0D817627", 3055.0243245550155, 1, 5 },
                    { new Guid("f8aa1bb2-a95d-4fa1-b66e-6219bcdc7158"), 3, new Guid("c148e18a-88b1-446d-be26-212243cdffb7"), null, 4136, "QEKATN6SWNQ095269", 1536.7221430432478, 3, 2 },
                    { new Guid("fe039996-5784-4c34-9f3f-4273b993f6a9"), 1, new Guid("0db382d2-09a9-44a3-9751-a87c3d450cca"), null, 1048, "IE02T4P275Y425203", 1004.6382049572555, 1, 4 },
                    { new Guid("fec374ff-80d1-4b8d-bf5b-7db26a59e4c8"), 3, new Guid("3d60ff96-9955-40f4-9fec-8101045a3365"), null, 9262, "9HEDY89B5DUJ38940", 3535.5021801880052, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("0bf37bc1-59b2-4ccf-86c5-f0fdda7b1229"), new Guid("620e1326-bd16-474c-ba79-16356640f3a8"), new DateTime(2024, 5, 29, 13, 18, 3, 368, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 5, 31, 21, 32, 52, 224, DateTimeKind.Utc).AddTicks(9977), new Guid("519768bc-91f2-43d7-9a51-2574ddeb3cb6") },
                    { new Guid("3b35d673-bda9-4e1d-94a1-3ba3e49b7bf1"), new Guid("620e1326-bd16-474c-ba79-16356640f3a8"), new DateTime(2024, 2, 1, 23, 50, 8, 33, DateTimeKind.Utc).AddTicks(7330), new DateTime(2023, 10, 21, 16, 2, 2, 516, DateTimeKind.Utc).AddTicks(9011), new Guid("6c9000d7-1844-429e-b91f-eb7b601fbd87") },
                    { new Guid("7d6de991-b39b-4aea-a50a-00d3d372b3c7"), new Guid("620e1326-bd16-474c-ba79-16356640f3a8"), new DateTime(2024, 2, 8, 1, 44, 24, 645, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 2, 14, 3, 48, 3, 74, DateTimeKind.Utc).AddTicks(3968), new Guid("186522b6-26c7-4d66-ba7a-568231e772ef") },
                    { new Guid("b5031f7f-5f77-4542-af6d-71e2a6f27f5e"), new Guid("620e1326-bd16-474c-ba79-16356640f3a8"), new DateTime(2024, 1, 30, 19, 21, 25, 933, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 4, 5, 20, 50, 53, 845, DateTimeKind.Utc).AddTicks(1850), new Guid("c58ee51b-162d-437e-9175-22ba1cee632e") },
                    { new Guid("fbd68544-a853-4de3-b819-e98ff7eb1062"), new Guid("620e1326-bd16-474c-ba79-16356640f3a8"), new DateTime(2024, 2, 6, 16, 8, 31, 669, DateTimeKind.Utc).AddTicks(4578), new DateTime(2023, 10, 12, 7, 20, 2, 705, DateTimeKind.Utc).AddTicks(6309), new Guid("537b287f-affc-47dd-aa2b-0f71ea3de567") }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("02b35ef0-01cd-4d8a-9b19-3f1e24ee155c"), new Guid("fb42c12c-595b-4760-9d0b-f7bcf36d367d"), "Silverado" },
                    { new Guid("0cf5ccd2-f87e-4026-8d13-ebbb023c9be6"), new Guid("c0300098-2a0f-4ab5-b987-74af75739d8f"), "ATS" },
                    { new Guid("0db382d2-09a9-44a3-9751-a87c3d450cca"), new Guid("a2e3d429-9c44-4cc8-94c7-57f11b0848ac"), "A8" },
                    { new Guid("1e62b078-df9d-4b57-b963-e071b9729821"), new Guid("c114a801-3f6d-4eb0-9a60-8e31a5039589"), "Spyder" },
                    { new Guid("21408ca9-511f-4b9c-a360-ec6907d22884"), new Guid("da266208-001c-4ada-ad4f-96978db63c94"), "Camry" },
                    { new Guid("23b61a3c-ce67-4d25-8177-da9c7f8f43ae"), new Guid("a2e3d429-9c44-4cc8-94c7-57f11b0848ac"), "Challenger" },
                    { new Guid("24a8daaf-8337-459d-b365-125bc0a5554f"), new Guid("da266208-001c-4ada-ad4f-96978db63c94"), "Camry" },
                    { new Guid("3b07cda8-76d4-4989-bf35-07092bf9a35c"), new Guid("fb42c12c-595b-4760-9d0b-f7bcf36d367d"), "Silverado" },
                    { new Guid("3d60ff96-9955-40f4-9fec-8101045a3365"), new Guid("fb42c12c-595b-4760-9d0b-f7bcf36d367d"), "Fiesta" },
                    { new Guid("3e8f4dc1-850d-4b56-9f79-eb3bfd8e2c1c"), new Guid("da266208-001c-4ada-ad4f-96978db63c94"), "Expedition" },
                    { new Guid("3fdc8922-31d4-4f81-a804-29aba5c78600"), new Guid("c0300098-2a0f-4ab5-b987-74af75739d8f"), "Taurus" },
                    { new Guid("599a7abb-6894-4d72-98a4-26e359262fab"), new Guid("a2e3d429-9c44-4cc8-94c7-57f11b0848ac"), "2" },
                    { new Guid("5a57d85e-6ad8-4ad1-9365-6a88076d5da5"), new Guid("a2e3d429-9c44-4cc8-94c7-57f11b0848ac"), "El Camino" },
                    { new Guid("64611803-bcef-4bf8-8132-fee42ebd2d55"), new Guid("c0300098-2a0f-4ab5-b987-74af75739d8f"), "PT Cruiser" },
                    { new Guid("6c3295fd-474b-4269-84ac-cf60439fbbe9"), new Guid("c114a801-3f6d-4eb0-9a60-8e31a5039589"), "Sentra" },
                    { new Guid("8b66b146-b82e-4057-a343-a49e8fca8269"), new Guid("c114a801-3f6d-4eb0-9a60-8e31a5039589"), "Malibu" },
                    { new Guid("98648004-1d56-44cf-ad84-24b8eeb6ed20"), new Guid("c114a801-3f6d-4eb0-9a60-8e31a5039589"), "Silverado" },
                    { new Guid("9eb8a33e-0351-4be0-9f4b-2ce6398fd703"), new Guid("c0300098-2a0f-4ab5-b987-74af75739d8f"), "Golf" },
                    { new Guid("acea193c-79ff-490a-b56b-3eea1c5c9216"), new Guid("c114a801-3f6d-4eb0-9a60-8e31a5039589"), "PT Cruiser" },
                    { new Guid("c148e18a-88b1-446d-be26-212243cdffb7"), new Guid("fb42c12c-595b-4760-9d0b-f7bcf36d367d"), "A4" },
                    { new Guid("d36a0d38-25e1-44da-bfdc-2354fcee7ee3"), new Guid("da266208-001c-4ada-ad4f-96978db63c94"), "Durango" },
                    { new Guid("d80c6e25-4af7-4c49-97ca-58fa1f3f9e39"), new Guid("da266208-001c-4ada-ad4f-96978db63c94"), "Charger" },
                    { new Guid("d8c337a9-c89d-41e1-8c1f-4bee38c64ec1"), new Guid("a2e3d429-9c44-4cc8-94c7-57f11b0848ac"), "Fiesta" },
                    { new Guid("d9f2bff6-0afd-4146-b36f-da2882fa76a6"), new Guid("c0300098-2a0f-4ab5-b987-74af75739d8f"), "Ranchero" },
                    { new Guid("fa5e1095-f059-4672-b7e8-cef2bb2c9098"), new Guid("fb42c12c-595b-4760-9d0b-f7bcf36d367d"), "Camry" }
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
