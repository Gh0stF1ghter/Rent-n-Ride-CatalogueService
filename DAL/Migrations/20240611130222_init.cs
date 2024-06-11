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
                values: new object[] { new Guid("3eb356a0-8123-42ef-af05-0650b333a949"), "Mark_Pagac@gmail.com", "Lisa", "Labadie", "(868) 880-3175" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("41708490-fd13-4408-a894-0c40a308923d"), "Polestar" },
                    { new Guid("5b8b98f6-4929-4d73-a6dd-0725808eede3"), "Dodge" },
                    { new Guid("7d7a7a20-8083-44cf-8917-20f6ae5ce184"), "Chrysler" },
                    { new Guid("92025cfe-da31-4823-8060-d91540bcadb4"), "Cadillac" },
                    { new Guid("bc77cd17-3aa7-45d8-b6d6-50e1fb281b88"), "Kia" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "ModelNameId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("00aa0349-52ca-4efd-87d0-775cc07b6da2"), 3, new Guid("3c56381f-56eb-4b55-9cec-f4885921d043"), null, 4251, "51FY76DJQUJW39216", 1485.3671360991598, 0, 2 },
                    { new Guid("026ce876-d0d9-4cfe-884a-e8da603c04cc"), 0, new Guid("1a6474bb-e95b-4712-b053-e5cdc8df2a6e"), null, 9984, "75C5ZKVKACGQ57710", 2495.8437017632359, 0, 5 },
                    { new Guid("039230c9-69a0-4d03-b6b4-d541aa1bb787"), 1, new Guid("922afd35-158e-4c72-99fd-805bb758f702"), null, 1060, "S8OBD3430NB631622", 2266.8605282616436, 0, 5 },
                    { new Guid("05c3cba2-cfc7-47f6-9bcc-bdadc35ce051"), 1, new Guid("18227dd6-01c6-4795-9203-8255e318ce28"), null, 8635, "IQO4DR96LQMF14928", 2235.1586779085515, 2, 4 },
                    { new Guid("0ceac604-2283-454c-bf7c-a9db129bfab8"), 0, new Guid("555bc933-c002-4fda-937f-8fe3e83d8326"), null, 131, "TBRNWMRB8ZVH50224", 1773.4208331258321, 1, 2 },
                    { new Guid("0e121d2d-f184-45c5-a0be-2ed061de1171"), 0, new Guid("76f2cfc6-5fba-48aa-82e4-5d69c71cd4b7"), null, 4854, "8CZZJXMNMJTA39827", 681.36646509714285, 2, 1 },
                    { new Guid("1055e07f-a942-4b7f-9513-841124842ea1"), 3, new Guid("647e3c20-dfc9-4e01-9b4f-007a6c9ea3f5"), null, 2271, "I9E69MOR35FO52251", 1536.2562230475432, 2, 1 },
                    { new Guid("135bbfb6-8b00-41c8-85b3-25d347d51be5"), 2, new Guid("6db119ab-df8e-4ce6-91b2-8dd8473e1e70"), null, 5635, "4CLJ0CBYGZUY60800", 1355.8940819091199, 1, 2 },
                    { new Guid("13f04f29-0b0b-4df4-9d85-fbc671eef7c2"), 0, new Guid("76f2cfc6-5fba-48aa-82e4-5d69c71cd4b7"), null, 849, "B4R3S6Y3Z3XD48583", 3124.4099791744443, 0, 0 },
                    { new Guid("153a02e3-01ba-473a-9087-a0a77d1c06ce"), 2, new Guid("141f64eb-b7e8-4bd8-9437-860d4dd46c8b"), null, 8257, "3ESOLZ2CJVWB58139", 1095.8939828837993, 1, 4 },
                    { new Guid("160861ec-e96a-4753-b900-611b4c074bf9"), 2, new Guid("922afd35-158e-4c72-99fd-805bb758f702"), null, 6244, "7APSHVSICERH50586", 1870.513334279593, 3, 1 },
                    { new Guid("16419846-1370-4881-a831-6f95acdc4e07"), 3, new Guid("dcb1a6f4-fd91-4d1a-9eb0-4d9d7963688c"), null, 665, "CFOJ3YSQOQFF69825", 1818.4267588231478, 0, 5 },
                    { new Guid("1a88bf6f-9977-4b4b-abbd-671fe3aabedf"), 0, new Guid("76f2cfc6-5fba-48aa-82e4-5d69c71cd4b7"), null, 56, "97EFOJMAGNLY51558", 2409.2765969496822, 3, 3 },
                    { new Guid("1abcfbc0-dddd-40b2-8f3f-31ff6fae57c1"), 0, new Guid("3c56381f-56eb-4b55-9cec-f4885921d043"), null, 4821, "VYT3E57X7DHP73754", 1351.9655976788733, 0, 1 },
                    { new Guid("1c1e3feb-23a6-41ab-8c38-9824dff8bd7f"), 2, new Guid("1a6474bb-e95b-4712-b053-e5cdc8df2a6e"), null, 9192, "MCAF110ZNOQ115446", 1235.609524980825, 2, 3 },
                    { new Guid("1caec604-84de-4a90-85a1-8c6cd7518263"), 2, new Guid("24f3d93c-10f6-4260-836c-b3f041551209"), null, 2325, "JABCBOD94RJB11240", 3070.6514606579021, 1, 1 },
                    { new Guid("1d6ba6ae-d6a9-418a-b97d-16ff6bcde9f2"), 0, new Guid("000a5545-0f97-48f6-b8de-cfbdc3368a5b"), null, 1049, "7DIXK0J5HWX962421", 3780.3984463750598, 2, 1 },
                    { new Guid("24c77547-fbb3-428b-9d6e-6b470b8e8066"), 0, new Guid("24f3d93c-10f6-4260-836c-b3f041551209"), null, 1908, "FM3084YOCTFT64151", 633.15225827624363, 0, 4 },
                    { new Guid("26d4a454-56a6-4d09-a58c-0067289c6423"), 0, new Guid("922afd35-158e-4c72-99fd-805bb758f702"), null, 3898, "WRJNFZWX52IU71167", 542.68939443050772, 0, 0 },
                    { new Guid("294081d5-077b-487f-acf8-233528581dc7"), 3, new Guid("d06ff28c-7710-4c15-937f-5f49633aa704"), null, 9316, "AQ9H18OWZYKD50769", 2883.1470229419447, 3, 4 },
                    { new Guid("2b54c4a2-e85b-4223-ba51-bb277e0ddec4"), 1, new Guid("e0c9186d-7831-4735-9da0-cb884d53bd83"), null, 5426, "2HSE58JUWGH721343", 624.9104457311887, 2, 0 },
                    { new Guid("2d88aff3-a62a-4674-a659-03d96afc0466"), 1, new Guid("027ba638-4808-4d07-9c41-f8551c411c24"), null, 3659, "VTCGD4B3XHYC59686", 3422.0365338018419, 1, 3 },
                    { new Guid("353c738b-b9c3-4d22-97fd-f22e41df772a"), 0, new Guid("517b1982-794f-4bf6-999f-5b5c2f462721"), null, 8548, "MV330QT42RPV55323", 1561.286063950567, 0, 4 },
                    { new Guid("379d1bf9-10bc-4415-9742-fb11f91525d1"), 0, new Guid("24f3d93c-10f6-4260-836c-b3f041551209"), null, 9621, "3I606FK8P4Y438089", 1954.834118103882, 1, 1 },
                    { new Guid("3f3ffd9e-938f-4321-83fb-3bcd2f7941d2"), 1, new Guid("5fefaeee-2a38-4042-945b-ad4ad07b4657"), null, 411, "QAXJPYEF9GR139304", 3421.5809445556974, 2, 1 },
                    { new Guid("417da5bf-fdc1-4bf7-889d-c53282fb4343"), 0, new Guid("db3603ac-0ae3-4987-8120-924e1bcd2119"), null, 5563, "WN4BSIJA8WZY45112", 2128.2384366641363, 3, 0 },
                    { new Guid("4487e13c-3340-4530-8036-7c311032c615"), 1, new Guid("dcb1a6f4-fd91-4d1a-9eb0-4d9d7963688c"), null, 7484, "P7PMOG2CXUCU93714", 2017.2948041274863, 1, 2 },
                    { new Guid("45a698d1-40fd-4200-9a99-a95a24bb9c67"), 1, new Guid("141f64eb-b7e8-4bd8-9437-860d4dd46c8b"), null, 9855, "JKVDN3WEIMXQ26079", 328.17507132376971, 0, 3 },
                    { new Guid("481d9e74-7df7-4457-ae81-bd0cdba4b3ba"), 2, new Guid("13614880-4880-451a-9935-25f2f5b0f93d"), null, 4023, "SAQOSOFTPSZ751450", 2825.6579301407346, 2, 0 },
                    { new Guid("4e7df071-9cf8-4558-b8fe-54e07079622f"), 3, new Guid("f073954f-e1de-4699-bb33-e9e6df99becd"), null, 1103, "UXBB63AYVMG391707", 1380.4861980944986, 1, 1 },
                    { new Guid("503546c9-5439-4317-9837-e05e2c6479ba"), 1, new Guid("f073954f-e1de-4699-bb33-e9e6df99becd"), null, 1366, "CWXKEETB39SF79346", 3173.2616989233629, 0, 5 },
                    { new Guid("51191d92-ab79-4ae5-9ba1-186b507b0d4d"), 1, new Guid("647e3c20-dfc9-4e01-9b4f-007a6c9ea3f5"), null, 7018, "8TZSS2ZV38WT46304", 605.42621063834054, 1, 4 },
                    { new Guid("51ac07f7-87de-4170-98bd-2265a60daaa6"), 0, new Guid("7d0ec296-ee40-4321-b44f-94980baac2f9"), null, 2227, "4SXGJW9ZQYAV53762", 3975.7820696141125, 3, 3 },
                    { new Guid("534d24eb-f165-449c-8838-02d19eaa025e"), 0, new Guid("647e3c20-dfc9-4e01-9b4f-007a6c9ea3f5"), null, 4071, "4IF6KY0FFPI930557", 291.78289732059648, 2, 5 },
                    { new Guid("542d1be7-a402-4696-9b15-cb4c8a2708e7"), 3, new Guid("33d56cd1-5975-48c9-b73c-0b748e63b8ff"), null, 8146, "X1JSBMD1GLSZ68088", 1547.327016649291, 3, 3 },
                    { new Guid("5a248d69-368f-4db1-8fbf-2ffb291e4ee1"), 3, new Guid("33d56cd1-5975-48c9-b73c-0b748e63b8ff"), null, 4130, "MMOEAN1HCJDC37003", 894.96006936358606, 0, 5 },
                    { new Guid("5ac758ae-6024-4271-b190-4890babffeaf"), 1, new Guid("7d0ec296-ee40-4321-b44f-94980baac2f9"), null, 4843, "3WK0Z2SNBNKT93290", 2628.3404801421766, 1, 2 },
                    { new Guid("5bcad41c-870d-4182-a234-f21b7c763be7"), 0, new Guid("76f2cfc6-5fba-48aa-82e4-5d69c71cd4b7"), null, 3012, "7HZ5TQNTT7SE94909", 1299.210206467397, 0, 0 },
                    { new Guid("5ee525bc-522f-41b3-9b91-b83ddf22f6ea"), 0, new Guid("f073954f-e1de-4699-bb33-e9e6df99becd"), null, 4066, "BWG7VK88NZTV88570", 1912.5454990141825, 0, 0 },
                    { new Guid("5ef4c8b4-13a2-49df-b0f7-643b2b7ca459"), 1, new Guid("13614880-4880-451a-9935-25f2f5b0f93d"), null, 8754, "634EYL4HRWU336951", 874.77332997535484, 0, 0 },
                    { new Guid("5f7ada7e-747f-4043-8a0e-be850c63d692"), 2, new Guid("027ba638-4808-4d07-9c41-f8551c411c24"), null, 6753, "P4GCTA62G6VB73239", 587.63040647149228, 2, 2 },
                    { new Guid("5fc1075e-0015-4430-b023-54e81aa5e024"), 1, new Guid("647e3c20-dfc9-4e01-9b4f-007a6c9ea3f5"), null, 8886, "HREPUGCOJ5WN60825", 2249.1122780451692, 0, 2 },
                    { new Guid("623a6d83-076a-4063-843a-414a4c276f6d"), 0, new Guid("628daeca-f69d-4281-aee7-b935e9f52bb5"), null, 6526, "KA34CGYVQTFL21809", 1447.5502379846528, 1, 0 },
                    { new Guid("63fd496d-8891-4a53-a99f-283b67ddab8d"), 2, new Guid("33d56cd1-5975-48c9-b73c-0b748e63b8ff"), null, 9102, "LEM1V0MWQQX638469", 812.16262126824222, 1, 2 },
                    { new Guid("641bb4fc-8709-4404-8e48-fcbb75e8b9c0"), 1, new Guid("dcb1a6f4-fd91-4d1a-9eb0-4d9d7963688c"), null, 4761, "SAGOVPWG2LYJ27777", 291.34214179889761, 3, 5 },
                    { new Guid("64fdca40-af92-4d40-9489-422ce4fcc241"), 3, new Guid("db3603ac-0ae3-4987-8120-924e1bcd2119"), null, 3167, "1E9J1ZQ9HNYC85444", 1218.7666549632452, 0, 3 },
                    { new Guid("677cc126-f2c1-445a-a53a-dbed3d0ae456"), 3, new Guid("13614880-4880-451a-9935-25f2f5b0f93d"), null, 3038, "J2J83KQ2V2NP56792", 1616.7442082118482, 0, 2 },
                    { new Guid("67ce83b4-8fde-48e2-9c2f-9203da1471e4"), 2, new Guid("1a6474bb-e95b-4712-b053-e5cdc8df2a6e"), null, 7323, "I5SFGE3KOVSR89968", 1952.7865051980341, 1, 5 },
                    { new Guid("6a027294-b966-41a1-bc0a-434844c9dd5d"), 3, new Guid("e0c9186d-7831-4735-9da0-cb884d53bd83"), null, 1772, "CCPKH1XWEPDI88059", 1116.1122442839019, 3, 4 },
                    { new Guid("6df620a7-224b-41a4-9f86-3897cbe1e721"), 0, new Guid("3c56381f-56eb-4b55-9cec-f4885921d043"), null, 5533, "WO2VTWXUGSER70002", 599.07444379597268, 3, 3 },
                    { new Guid("760fd47b-5218-4989-a483-ca2cf698fdaa"), 3, new Guid("db3603ac-0ae3-4987-8120-924e1bcd2119"), null, 7330, "V0QGNSE5HRMP84625", 3552.9250617121179, 2, 2 },
                    { new Guid("77c837f8-8f92-4ec8-8342-efc04a078438"), 3, new Guid("555bc933-c002-4fda-937f-8fe3e83d8326"), null, 2826, "VM9KCNIA7PJW27454", 2900.7428557412622, 2, 0 },
                    { new Guid("77ff74a5-e967-4424-8a65-58337ee18fd8"), 2, new Guid("db3603ac-0ae3-4987-8120-924e1bcd2119"), null, 9823, "RBV88CPOSXF269646", 933.20908209606432, 2, 5 },
                    { new Guid("7ab8f5c1-97df-40c2-850b-466cda8703c1"), 0, new Guid("76f2cfc6-5fba-48aa-82e4-5d69c71cd4b7"), null, 1005, "WSPOZ9W9CJR052018", 3125.0880662914456, 0, 0 },
                    { new Guid("8102baa1-d51a-432d-9d5f-17d4bf868a78"), 0, new Guid("517b1982-794f-4bf6-999f-5b5c2f462721"), null, 7186, "9B0MOMTCU2ZB53344", 3346.5929062474065, 1, 3 },
                    { new Guid("8519217a-1796-45d9-b267-e51c4f752951"), 2, new Guid("3c56381f-56eb-4b55-9cec-f4885921d043"), null, 7448, "DSEPMM1WL3AV17913", 3364.2264308281119, 3, 0 },
                    { new Guid("857da1c3-9e4b-4da5-9d77-ce76a0d3a498"), 1, new Guid("5fefaeee-2a38-4042-945b-ad4ad07b4657"), null, 6609, "0GE5CRSHADI290611", 3793.3865904017416, 3, 0 },
                    { new Guid("89d76d9c-43c2-4285-9e15-6b45f31beb8b"), 2, new Guid("18227dd6-01c6-4795-9203-8255e318ce28"), null, 5011, "Z7WRK2SULIN851884", 1139.5829308715702, 3, 1 },
                    { new Guid("8e789e58-6c46-4c5e-9ff2-9d709d3095bb"), 0, new Guid("13614880-4880-451a-9935-25f2f5b0f93d"), null, 5587, "I7A3JIG2BEO078397", 3062.7762393843605, 1, 2 },
                    { new Guid("8f0afa87-c002-4194-99d5-c371213d36d7"), 2, new Guid("027ba638-4808-4d07-9c41-f8551c411c24"), null, 2177, "GYBSL3PL8QJO71817", 1555.9135208877508, 0, 1 },
                    { new Guid("922677c0-3ff0-4eae-a0ce-c48ce29d6a72"), 0, new Guid("5fefaeee-2a38-4042-945b-ad4ad07b4657"), null, 7314, "OA9YIJ8JJJI289946", 487.13746298392175, 0, 4 },
                    { new Guid("9243f438-005d-4602-aad9-28d8a400ff4a"), 1, new Guid("d06ff28c-7710-4c15-937f-5f49633aa704"), null, 2367, "4TG8SY92KZV058719", 1128.7032729268853, 1, 3 },
                    { new Guid("9348f750-57f9-47fa-9dd9-55b27b88e72f"), 1, new Guid("555bc933-c002-4fda-937f-8fe3e83d8326"), null, 7443, "2DL12SS3A0X740494", 1661.9623785022616, 2, 3 },
                    { new Guid("94c13f30-b739-4631-a569-c30bfd33361b"), 2, new Guid("555bc933-c002-4fda-937f-8fe3e83d8326"), null, 8101, "JC37WWNKK4VH39036", 3777.5372681010308, 1, 0 },
                    { new Guid("96042697-85fc-49a8-931c-b42dc9c048f5"), 3, new Guid("6db119ab-df8e-4ce6-91b2-8dd8473e1e70"), null, 1140, "KLWI3O949EEV26280", 1892.5919125236921, 0, 5 },
                    { new Guid("9680f392-3f80-4a8e-9f2f-fe5a51c3d8ef"), 2, new Guid("141f64eb-b7e8-4bd8-9437-860d4dd46c8b"), null, 8729, "NFCKO8UDK0OA40694", 764.04137657879505, 1, 2 },
                    { new Guid("9894cfba-e4ba-4132-afe8-bca567b30f93"), 2, new Guid("6db119ab-df8e-4ce6-91b2-8dd8473e1e70"), null, 9924, "S9DJ6U61IGEA71967", 2160.6179047907008, 0, 2 },
                    { new Guid("9bbed713-4044-4409-96ad-bca7822d9455"), 0, new Guid("628daeca-f69d-4281-aee7-b935e9f52bb5"), null, 3495, "KJ8R404AA2N148950", 3295.3211393103625, 1, 1 },
                    { new Guid("9bde5e5a-fac2-40e1-a6dc-b55bb5bfe8ef"), 1, new Guid("922afd35-158e-4c72-99fd-805bb758f702"), null, 9827, "F8B4WLZQ71X580925", 2482.9684668812033, 2, 2 },
                    { new Guid("9ea3a92f-ecbe-4506-bf2b-e3d94ea446bb"), 2, new Guid("1a6474bb-e95b-4712-b053-e5cdc8df2a6e"), null, 7665, "7CJJ0HYE7UW181784", 715.60705714335779, 2, 4 },
                    { new Guid("a1bf509b-b560-4cc2-8bfc-9fa428016f88"), 1, new Guid("d06ff28c-7710-4c15-937f-5f49633aa704"), null, 7445, "0COGAPLAPSD915450", 708.58177896790278, 3, 4 },
                    { new Guid("a2edced4-51a2-4179-a756-1388ef5bd5ab"), 1, new Guid("6db119ab-df8e-4ce6-91b2-8dd8473e1e70"), null, 9732, "B2O0H898OOBZ51746", 973.49573380217009, 2, 0 },
                    { new Guid("a6505baa-d2fd-48f1-b982-7d691b29a565"), 0, new Guid("628daeca-f69d-4281-aee7-b935e9f52bb5"), null, 3520, "5GUKSH69ZBEO61128", 2606.1198294184342, 2, 3 },
                    { new Guid("a67a446b-6c4e-486f-a74e-24a39bacd901"), 1, new Guid("33d56cd1-5975-48c9-b73c-0b748e63b8ff"), null, 7810, "7X7LU6NRSGJL49699", 640.64136639140565, 0, 1 },
                    { new Guid("a75b5551-4bb6-4225-93eb-434974013340"), 0, new Guid("2418ffbd-5c3f-48a2-9c9f-d93cafe0112f"), null, 6280, "L7I4RGP0E8MQ30707", 1684.574317203266, 3, 0 },
                    { new Guid("a8a86913-1235-4d3b-9f1f-175af8f5ba10"), 0, new Guid("1a6474bb-e95b-4712-b053-e5cdc8df2a6e"), null, 6315, "EK0XEJ4U95AY24679", 1607.1135441562187, 2, 5 },
                    { new Guid("ab326315-5819-4cb6-b199-2635592de425"), 1, new Guid("141f64eb-b7e8-4bd8-9437-860d4dd46c8b"), null, 7908, "IYCYOB4HMPDJ97175", 2997.1151257618681, 1, 1 },
                    { new Guid("ab9646d9-49ca-4903-9891-04745eed9ef5"), 3, new Guid("db3603ac-0ae3-4987-8120-924e1bcd2119"), null, 7208, "6CB9KCP6CDS669882", 944.38230116667273, 2, 5 },
                    { new Guid("aea36c9a-26e0-4105-b357-44e453223382"), 0, new Guid("5fefaeee-2a38-4042-945b-ad4ad07b4657"), null, 3347, "Q3FJ5AAY6DZF69608", 2151.7660794788439, 3, 0 },
                    { new Guid("b0994018-b3f6-4b56-99d3-1f643cd3793b"), 0, new Guid("6db119ab-df8e-4ce6-91b2-8dd8473e1e70"), null, 833, "RG1J2B9BV7H995901", 1416.2571478541706, 0, 3 },
                    { new Guid("b0d6c516-d7c6-4eaa-9243-61cfb3009668"), 0, new Guid("e554df25-3a79-4264-82c3-08fc630c25e6"), null, 3359, "PW7H21B703TD29406", 228.22618243713671, 0, 5 },
                    { new Guid("b1738f4d-436c-4bbc-a1d1-b3a9439e3b41"), 0, new Guid("647e3c20-dfc9-4e01-9b4f-007a6c9ea3f5"), null, 2767, "FGWRK6JL8GWC98311", 2347.9113105736528, 1, 1 },
                    { new Guid("b1b7f6b1-71f1-4e6c-900d-4d12a1f9dc6a"), 0, new Guid("e554df25-3a79-4264-82c3-08fc630c25e6"), null, 1304, "5W8ENK2D65A911236", 2612.4655403595093, 3, 5 },
                    { new Guid("b1c6b53f-8333-46b9-a5b9-7c0b3b3dc345"), 1, new Guid("7d0ec296-ee40-4321-b44f-94980baac2f9"), null, 7417, "TTV31JIYODLG59442", 2076.0558068919272, 1, 2 },
                    { new Guid("b43bd1cd-bfb7-4478-adb6-2c26e7672755"), 3, new Guid("000a5545-0f97-48f6-b8de-cfbdc3368a5b"), null, 8068, "YT53WKA9QTEH19608", 1797.8334015996745, 0, 4 },
                    { new Guid("b4b8e095-6385-47c5-84a2-5aa53f6f2cfd"), 2, new Guid("517b1982-794f-4bf6-999f-5b5c2f462721"), null, 4125, "OLG0YNSICRDR11167", 192.12506887746252, 2, 2 },
                    { new Guid("b5702259-d2c2-47b7-83f8-8ae50b84f266"), 1, new Guid("141f64eb-b7e8-4bd8-9437-860d4dd46c8b"), null, 5025, "6LK3FUN4HRVC48919", 451.43666399894556, 3, 2 },
                    { new Guid("b5d01de9-91c9-4f86-a4dc-3a9beb482550"), 1, new Guid("000a5545-0f97-48f6-b8de-cfbdc3368a5b"), null, 5557, "EHSEP4AEZ3ZW83244", 1296.7680365277745, 0, 5 },
                    { new Guid("b725e2fb-a958-49f4-b6e6-23c3c096578b"), 3, new Guid("13614880-4880-451a-9935-25f2f5b0f93d"), null, 6094, "VAPDICUF0TLC87149", 348.15277638908219, 1, 0 },
                    { new Guid("b7daa736-b848-4106-80a7-95ee69963eda"), 1, new Guid("18227dd6-01c6-4795-9203-8255e318ce28"), null, 6048, "DQJV64S601ZF24494", 2564.712389811687, 2, 5 },
                    { new Guid("b8dd118a-5845-49df-b0c2-78e2c285ed1e"), 2, new Guid("dcb1a6f4-fd91-4d1a-9eb0-4d9d7963688c"), null, 5759, "JWTLHMB2H6OO70973", 2571.9158278738014, 2, 3 },
                    { new Guid("b9ba1e24-85f1-4aa6-ba85-b06f488faacc"), 2, new Guid("18227dd6-01c6-4795-9203-8255e318ce28"), null, 5147, "H6FCGIK0NCLD64065", 184.43010477328215, 2, 4 },
                    { new Guid("bced4528-1972-447d-b770-953ea2ddfacf"), 1, new Guid("5fefaeee-2a38-4042-945b-ad4ad07b4657"), null, 1540, "VC2ONLFOO4HD98472", 2071.5770809832011, 2, 2 },
                    { new Guid("bd7e2abb-b014-42a0-be89-768c6dfd4733"), 3, new Guid("d06ff28c-7710-4c15-937f-5f49633aa704"), null, 6673, "ETO2KSIX1GJ135514", 3813.5398658818585, 2, 5 },
                    { new Guid("bf73fc95-54c8-4882-b845-0dac4e4ff0e9"), 1, new Guid("e554df25-3a79-4264-82c3-08fc630c25e6"), null, 7724, "LD5ERA4BBNRE97788", 747.11594372523632, 0, 0 },
                    { new Guid("c16d1f74-042d-42d6-90b4-93f9d396b739"), 2, new Guid("e0c9186d-7831-4735-9da0-cb884d53bd83"), null, 3328, "2PRA0WHOYIQ652943", 1115.9925398685496, 0, 5 },
                    { new Guid("c21fe318-d278-4422-a22a-3ada3e9055a6"), 2, new Guid("027ba638-4808-4d07-9c41-f8551c411c24"), null, 3773, "HJN96258A5UQ40352", 3945.9188887200726, 3, 1 },
                    { new Guid("c2692daa-cce0-4d9b-9601-6492ed74b36b"), 2, new Guid("e0c9186d-7831-4735-9da0-cb884d53bd83"), null, 4469, "XEQM2YS12ND725496", 1116.0562302427318, 2, 0 },
                    { new Guid("c477c7bb-3802-4f48-bd3a-638a384d8e72"), 3, new Guid("517b1982-794f-4bf6-999f-5b5c2f462721"), null, 3748, "4XJDV6IHLWP768596", 549.71191275030401, 2, 5 },
                    { new Guid("c78bc037-9315-465c-bde7-e56584340114"), 0, new Guid("000a5545-0f97-48f6-b8de-cfbdc3368a5b"), null, 6153, "4H8GZXRPWUH561377", 1360.2413900108897, 3, 4 },
                    { new Guid("c9a5de51-1683-49b5-93ae-9f1a484ba95f"), 0, new Guid("dcb1a6f4-fd91-4d1a-9eb0-4d9d7963688c"), null, 5004, "M09QV8XLZNQS33129", 986.41143019624883, 2, 1 },
                    { new Guid("ce14879c-b867-4838-a241-c488efd37950"), 3, new Guid("7d0ec296-ee40-4321-b44f-94980baac2f9"), null, 7858, "FF1XXMNYS6VX48275", 3626.2362226554505, 0, 1 },
                    { new Guid("cec76663-27ee-4d69-98a1-069026c1f03c"), 3, new Guid("e554df25-3a79-4264-82c3-08fc630c25e6"), null, 6598, "CRGXR64TVXQI11185", 2495.9845516822252, 3, 5 },
                    { new Guid("cf826d0c-a666-4af1-acd0-e954b294f2c6"), 3, new Guid("2418ffbd-5c3f-48a2-9c9f-d93cafe0112f"), null, 3815, "5VD1KD2CV1AE70182", 510.40227531130364, 1, 4 },
                    { new Guid("d19fda6d-8cf4-47e6-a039-883467e7aaca"), 1, new Guid("18227dd6-01c6-4795-9203-8255e318ce28"), null, 2704, "ZDXUUP9GHPZ017601", 2847.2122543319906, 3, 3 },
                    { new Guid("d27fbd28-4a0b-4bc5-8eb4-27b55416e5dd"), 3, new Guid("e0c9186d-7831-4735-9da0-cb884d53bd83"), null, 7545, "R6VYPSQJB6B067538", 924.16812183704997, 3, 4 },
                    { new Guid("d2d61b60-905d-4071-8b18-57aed6feb695"), 1, new Guid("628daeca-f69d-4281-aee7-b935e9f52bb5"), null, 8957, "L4UZ7X1CA1J215250", 2987.7808728750583, 3, 1 },
                    { new Guid("d4ddab94-4bb8-4e83-ac7a-1eb3fb1055be"), 1, new Guid("922afd35-158e-4c72-99fd-805bb758f702"), null, 1223, "WTIBDJVKJ6LW13502", 3893.4945689142269, 1, 0 },
                    { new Guid("d4f59c8c-7b8c-4987-9f76-15a39dbb8d7b"), 0, new Guid("24f3d93c-10f6-4260-836c-b3f041551209"), null, 707, "MMBGGZ2OJ8DN32699", 3490.8732741478816, 1, 3 },
                    { new Guid("d776e92f-31a6-4181-9be4-bf0849021694"), 2, new Guid("2418ffbd-5c3f-48a2-9c9f-d93cafe0112f"), null, 5145, "RB9WYRCZGLMJ83852", 1344.8192347492304, 0, 3 },
                    { new Guid("d9df8f8b-cbea-40e6-b6cd-bf5651ee1b23"), 1, new Guid("555bc933-c002-4fda-937f-8fe3e83d8326"), null, 6827, "5N4Z5Y4LXRYK34379", 1902.83044550868, 1, 5 },
                    { new Guid("dc02197a-ce1a-4c08-8c83-e18789d63bd5"), 2, new Guid("3c56381f-56eb-4b55-9cec-f4885921d043"), null, 9637, "MVNS48KOPENG39712", 3367.0799278691757, 0, 1 },
                    { new Guid("dd747cbd-344d-4a8c-988e-bbbe71361641"), 3, new Guid("e554df25-3a79-4264-82c3-08fc630c25e6"), null, 6872, "UDJ3SMPU3BT886288", 767.9188277538608, 2, 3 },
                    { new Guid("de97503b-7fa3-4b50-86d5-41f3969312e8"), 0, new Guid("000a5545-0f97-48f6-b8de-cfbdc3368a5b"), null, 7779, "Z84Q0I36DGWR10525", 3614.5589700809469, 1, 3 },
                    { new Guid("deb45842-ad67-462d-9814-2bdce6c43e33"), 3, new Guid("33d56cd1-5975-48c9-b73c-0b748e63b8ff"), null, 2272, "DW0STHX7CFLA15959", 3929.4805621769196, 1, 2 },
                    { new Guid("deb4c1c2-5062-4c61-a34b-144f4f390b1e"), 1, new Guid("f073954f-e1de-4699-bb33-e9e6df99becd"), null, 3988, "UNGYQJHEUSCO76495", 2236.8759245688566, 3, 0 },
                    { new Guid("e89f9ef7-ad27-4814-9bcf-73e3bab94eef"), 3, new Guid("7d0ec296-ee40-4321-b44f-94980baac2f9"), null, 4586, "OIJVQH2WW1G335369", 272.50635485609791, 3, 4 },
                    { new Guid("e9d522b5-37ff-4740-8ba3-63cec63a9b32"), 1, new Guid("2418ffbd-5c3f-48a2-9c9f-d93cafe0112f"), null, 3828, "48P5E28S13DG67447", 3051.3809673524761, 0, 5 },
                    { new Guid("eabcebe6-15b2-42c7-a354-7e8649161d77"), 0, new Guid("f073954f-e1de-4699-bb33-e9e6df99becd"), null, 4293, "JO58XCQTPNXR43512", 1340.4520062011056, 3, 3 },
                    { new Guid("edfc90bc-d92d-4479-90e3-d16a42d341e3"), 0, new Guid("628daeca-f69d-4281-aee7-b935e9f52bb5"), null, 3300, "O43W1DQ3YFA445186", 1697.5165561075387, 3, 0 },
                    { new Guid("ee4cae45-fc39-45d9-a53e-7b0391be2926"), 1, new Guid("d06ff28c-7710-4c15-937f-5f49633aa704"), null, 1928, "48HYS8Q7HSI043743", 3506.1423030685346, 3, 1 },
                    { new Guid("ef082489-ca3b-40b3-84e4-b32672b430a0"), 0, new Guid("2418ffbd-5c3f-48a2-9c9f-d93cafe0112f"), null, 5839, "6OQBSOM6YFGZ21569", 3946.0432113647594, 3, 0 },
                    { new Guid("ef1f9fd3-ee65-470f-9145-450c99d8b4a1"), 1, new Guid("517b1982-794f-4bf6-999f-5b5c2f462721"), null, 4028, "IQCSFKXQNWQG71212", 2687.8351480880228, 2, 0 },
                    { new Guid("fb3ed3a2-e031-4eac-9e2e-67a32bb927e1"), 1, new Guid("24f3d93c-10f6-4260-836c-b3f041551209"), null, 7598, "DFZCSLVQGVHO52562", 110.46875368459706, 3, 3 },
                    { new Guid("fd6640fe-c7c7-47f3-9a6c-3e774dee812d"), 0, new Guid("027ba638-4808-4d07-9c41-f8551c411c24"), null, 3305, "MR4VALHOFMI374959", 2364.5010413912973, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("1dcb247b-f8ab-4158-a646-7d9de700a44c"), new Guid("3eb356a0-8123-42ef-af05-0650b333a949"), new DateTime(2023, 9, 4, 17, 51, 47, 990, DateTimeKind.Utc).AddTicks(2944), new DateTime(2023, 9, 12, 7, 9, 2, 852, DateTimeKind.Utc).AddTicks(7515), new Guid("1d6ba6ae-d6a9-418a-b97d-16ff6bcde9f2") },
                    { new Guid("4d9717dd-f81c-4959-aefb-49f13876d6c6"), new Guid("3eb356a0-8123-42ef-af05-0650b333a949"), new DateTime(2023, 6, 22, 5, 36, 30, 319, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 8, 24, 18, 36, 4, 567, DateTimeKind.Utc).AddTicks(4061), new Guid("294081d5-077b-487f-acf8-233528581dc7") },
                    { new Guid("5129272d-5326-4348-a411-b1bb59617757"), new Guid("3eb356a0-8123-42ef-af05-0650b333a949"), new DateTime(2024, 6, 6, 9, 0, 12, 791, DateTimeKind.Utc).AddTicks(8886), new DateTime(2023, 9, 9, 20, 1, 33, 767, DateTimeKind.Utc).AddTicks(1210), new Guid("89d76d9c-43c2-4285-9e15-6b45f31beb8b") },
                    { new Guid("84866180-cc0c-4665-809a-763f143a58c6"), new Guid("3eb356a0-8123-42ef-af05-0650b333a949"), new DateTime(2024, 3, 16, 14, 28, 38, 370, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 2, 8, 13, 33, 22, 549, DateTimeKind.Utc).AddTicks(5410), new Guid("3f3ffd9e-938f-4321-83fb-3bcd2f7941d2") },
                    { new Guid("ee2fd042-f0ba-4976-9e9e-7eb00ea559e9"), new Guid("3eb356a0-8123-42ef-af05-0650b333a949"), new DateTime(2024, 3, 5, 23, 35, 38, 920, DateTimeKind.Utc).AddTicks(6877), new DateTime(2023, 7, 29, 2, 16, 39, 149, DateTimeKind.Utc).AddTicks(9299), new Guid("8102baa1-d51a-432d-9d5f-17d4bf868a78") }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("000a5545-0f97-48f6-b8de-cfbdc3368a5b"), new Guid("7d7a7a20-8083-44cf-8917-20f6ae5ce184"), "Model T" },
                    { new Guid("027ba638-4808-4d07-9c41-f8551c411c24"), new Guid("bc77cd17-3aa7-45d8-b6d6-50e1fb281b88"), "Ranchero" },
                    { new Guid("13614880-4880-451a-9935-25f2f5b0f93d"), new Guid("92025cfe-da31-4823-8060-d91540bcadb4"), "Focus" },
                    { new Guid("141f64eb-b7e8-4bd8-9437-860d4dd46c8b"), new Guid("bc77cd17-3aa7-45d8-b6d6-50e1fb281b88"), "Model S" },
                    { new Guid("18227dd6-01c6-4795-9203-8255e318ce28"), new Guid("7d7a7a20-8083-44cf-8917-20f6ae5ce184"), "Explorer" },
                    { new Guid("1a6474bb-e95b-4712-b053-e5cdc8df2a6e"), new Guid("41708490-fd13-4408-a894-0c40a308923d"), "Volt" },
                    { new Guid("2418ffbd-5c3f-48a2-9c9f-d93cafe0112f"), new Guid("bc77cd17-3aa7-45d8-b6d6-50e1fb281b88"), "Land Cruiser" },
                    { new Guid("24f3d93c-10f6-4260-836c-b3f041551209"), new Guid("41708490-fd13-4408-a894-0c40a308923d"), "Camaro" },
                    { new Guid("33d56cd1-5975-48c9-b73c-0b748e63b8ff"), new Guid("7d7a7a20-8083-44cf-8917-20f6ae5ce184"), "2" },
                    { new Guid("3c56381f-56eb-4b55-9cec-f4885921d043"), new Guid("7d7a7a20-8083-44cf-8917-20f6ae5ce184"), "Sentra" },
                    { new Guid("517b1982-794f-4bf6-999f-5b5c2f462721"), new Guid("41708490-fd13-4408-a894-0c40a308923d"), "Colorado" },
                    { new Guid("555bc933-c002-4fda-937f-8fe3e83d8326"), new Guid("5b8b98f6-4929-4d73-a6dd-0725808eede3"), "CTS" },
                    { new Guid("5fefaeee-2a38-4042-945b-ad4ad07b4657"), new Guid("92025cfe-da31-4823-8060-d91540bcadb4"), "Camry" },
                    { new Guid("628daeca-f69d-4281-aee7-b935e9f52bb5"), new Guid("92025cfe-da31-4823-8060-d91540bcadb4"), "Camaro" },
                    { new Guid("647e3c20-dfc9-4e01-9b4f-007a6c9ea3f5"), new Guid("92025cfe-da31-4823-8060-d91540bcadb4"), "Cruze" },
                    { new Guid("6db119ab-df8e-4ce6-91b2-8dd8473e1e70"), new Guid("bc77cd17-3aa7-45d8-b6d6-50e1fb281b88"), "XC90" },
                    { new Guid("76f2cfc6-5fba-48aa-82e4-5d69c71cd4b7"), new Guid("92025cfe-da31-4823-8060-d91540bcadb4"), "Explorer" },
                    { new Guid("7d0ec296-ee40-4321-b44f-94980baac2f9"), new Guid("bc77cd17-3aa7-45d8-b6d6-50e1fb281b88"), "ATS" },
                    { new Guid("922afd35-158e-4c72-99fd-805bb758f702"), new Guid("5b8b98f6-4929-4d73-a6dd-0725808eede3"), "Fiesta" },
                    { new Guid("d06ff28c-7710-4c15-937f-5f49633aa704"), new Guid("7d7a7a20-8083-44cf-8917-20f6ae5ce184"), "Volt" },
                    { new Guid("db3603ac-0ae3-4987-8120-924e1bcd2119"), new Guid("5b8b98f6-4929-4d73-a6dd-0725808eede3"), "Camaro" },
                    { new Guid("dcb1a6f4-fd91-4d1a-9eb0-4d9d7963688c"), new Guid("5b8b98f6-4929-4d73-a6dd-0725808eede3"), "Malibu" },
                    { new Guid("e0c9186d-7831-4735-9da0-cb884d53bd83"), new Guid("41708490-fd13-4408-a894-0c40a308923d"), "Expedition" },
                    { new Guid("e554df25-3a79-4264-82c3-08fc630c25e6"), new Guid("41708490-fd13-4408-a894-0c40a308923d"), "2" },
                    { new Guid("f073954f-e1de-4699-bb33-e9e6df99becd"), new Guid("5b8b98f6-4929-4d73-a6dd-0725808eede3"), "Model 3" }
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
