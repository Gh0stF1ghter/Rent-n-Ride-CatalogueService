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
                values: new object[] { new Guid("5da0b549-709d-42a7-911a-40c53532dd3b"), "Aurelia_Hirthe40@gmail.com", "Deja", "Keebler", "732.527.1470" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("33033254-55f6-4f3b-a8d2-c9dd071ffbd1"), "Hyundai" },
                    { new Guid("4b3a93c1-aae1-4239-9b92-79a69ef177f7"), "Lamborghini" },
                    { new Guid("b6a7711c-a5ce-4197-9a36-a0e9c957a0bc"), "Tesla" },
                    { new Guid("be7f8ca5-7c97-4574-96a8-d7da0a317ffb"), "Nissan" },
                    { new Guid("c1893305-d1ba-4930-941e-00e2279a5d49"), "Mercedes Benz" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "ModelNameId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("00be6035-a719-406b-9fd1-39313aaf9e16"), 1, new Guid("4387099b-8477-4ab3-a04c-5f8cd225ebdc"), null, 7722, "5P61VY1ZY5ON67384", 2527.028805502775, 2, 5 },
                    { new Guid("02bdb585-9037-46bd-9fee-b6387820d4ae"), 0, new Guid("b7d576f3-a9f7-440e-9c34-2289923d464b"), null, 7704, "OLSMKUFGGQUH62585", 693.33826474577199, 0, 1 },
                    { new Guid("0464f160-5894-4798-a48d-e89b7ad760d0"), 0, new Guid("db15f770-f6dc-4c94-a3ad-6799ed7df34a"), null, 4302, "5E45LYOWHGR628259", 1460.7347868621173, 3, 1 },
                    { new Guid("07674a44-014c-4091-ab6b-ca40fd132a23"), 0, new Guid("db15f770-f6dc-4c94-a3ad-6799ed7df34a"), null, 2694, "4CFT91AVMJEM67450", 2669.2403603777684, 2, 1 },
                    { new Guid("0c9ca35e-6927-4cf2-9acc-fe3cd817fc40"), 3, new Guid("eedb2e04-0223-4ab0-bbac-aa43b37b6d95"), null, 3664, "WD1VR99LFJT257414", 1685.2751859954187, 1, 2 },
                    { new Guid("0cddd240-ee9a-4d30-879b-ba5123f3c22b"), 2, new Guid("0cae08a1-e2de-4790-a1aa-5d3e91060acc"), null, 1092, "BGPXO8KW48SJ41753", 3648.495677067162, 3, 4 },
                    { new Guid("10763b92-bfcf-45d2-ad3b-50c1e1184b40"), 1, new Guid("5e58ca15-9a3d-49ba-8054-8ea280e92980"), null, 2420, "HJKHSUBQ7KN973582", 115.23149514356473, 1, 3 },
                    { new Guid("11b9f524-f621-44e8-b175-ec191ea4a48e"), 3, new Guid("50433eaf-f309-4a9f-b603-d2a14e59701b"), null, 2591, "2US6Q8CED7LL25227", 3664.1969113054201, 1, 3 },
                    { new Guid("11f179bf-30c2-4593-9050-87afce1aa112"), 2, new Guid("9995fc8c-3844-4c97-8c99-e0bcfc360cad"), null, 2602, "XXOAPVW7NNV157834", 1154.1018424728377, 0, 0 },
                    { new Guid("15c33d7f-8675-4841-b7b8-7d4a6c947db3"), 2, new Guid("95b7414f-dc5a-4bb1-831e-bd915d295713"), null, 6352, "EZJFA1HHFEMX59110", 2736.1873562388141, 3, 2 },
                    { new Guid("16101dac-7bb2-4e4e-83be-51a28ba55aa0"), 2, new Guid("8ae805d5-0d78-4c71-bd7b-799b49a3a774"), null, 3242, "7OG6F1S8F8SC91768", 1430.0654789232035, 0, 4 },
                    { new Guid("17f06459-ebab-4271-a79b-afbef15277f9"), 1, new Guid("8e169234-04b3-48e5-9518-c21cd39f2c7f"), null, 3308, "0XFR2ZTMRIP717788", 3122.9669077444701, 2, 0 },
                    { new Guid("1b085255-c951-4318-b233-c6c834356fcd"), 1, new Guid("45f39368-4456-433c-ad9b-edaa7783e343"), null, 6632, "KW5BXYPR09B099674", 501.89836141179285, 3, 1 },
                    { new Guid("1da3a269-d59c-4b5a-99ba-4a75c28ed7e6"), 0, new Guid("4387099b-8477-4ab3-a04c-5f8cd225ebdc"), null, 4089, "7EEFTYFH9ZKQ12040", 564.90221691955583, 0, 1 },
                    { new Guid("21c1407b-5af8-4828-b3df-bb942670c4b3"), 0, new Guid("bffaddb9-36c2-484a-b968-78afa974fcac"), null, 2888, "XB3X77LN2QQ359801", 400.16389433528195, 1, 0 },
                    { new Guid("244e81ec-3e62-462e-8daf-101ce9ba93fb"), 2, new Guid("79034739-1060-4346-a39b-3800e3651960"), null, 4517, "TWDRGUU1XABA76236", 910.49826017275529, 2, 1 },
                    { new Guid("31151c8a-b801-4f5e-8fd4-d092abc5cfd6"), 1, new Guid("44561354-904e-4ac5-bd97-10415a0d1585"), null, 2204, "H0TT07WO5ISC50353", 3257.4311021946905, 2, 1 },
                    { new Guid("343a615c-e28b-4f45-ba96-041d9f917f37"), 0, new Guid("cd76eccf-a3f0-4680-b90a-0b19b10c4d48"), null, 8143, "SAMLSNNBHKBQ99550", 2036.0845886707107, 2, 0 },
                    { new Guid("38024e9f-36df-4168-a2d9-c62821219642"), 1, new Guid("b7d576f3-a9f7-440e-9c34-2289923d464b"), null, 5094, "VQ6GECSSJDW628881", 3908.2002615417355, 0, 0 },
                    { new Guid("3bd49b40-1472-4a04-bd6c-acea90b50d8d"), 0, new Guid("15bf6bbf-a110-4a88-bc5e-8b4c47510b44"), null, 9497, "RGYX2N0AWNUH14391", 3212.0614621721188, 1, 2 },
                    { new Guid("3bee9412-17d4-4265-9ad8-2f40f273bdf0"), 1, new Guid("b7d576f3-a9f7-440e-9c34-2289923d464b"), null, 7815, "AWCZ3EV4H8TX41366", 3100.2564217338772, 2, 5 },
                    { new Guid("3db17bb2-20d8-4f2b-8243-a0f96379e858"), 0, new Guid("8e169234-04b3-48e5-9518-c21cd39f2c7f"), null, 4749, "IB7UEOQ3DXNT69710", 731.0120835602421, 3, 3 },
                    { new Guid("3f6deafd-eafd-49a2-9cbd-9eccaeee911a"), 2, new Guid("0cae08a1-e2de-4790-a1aa-5d3e91060acc"), null, 6112, "0VMKE2ML3IQ613643", 3403.0045672769211, 2, 0 },
                    { new Guid("404a789e-7494-4cff-a672-f6d24a5431fe"), 2, new Guid("ea1cc4b7-c655-4b48-8297-557e2d3fbff0"), null, 1567, "3837S71LPVEG80427", 3587.045664381536, 1, 5 },
                    { new Guid("42e79489-70e7-4c89-8912-fea0214590f0"), 2, new Guid("4d54f5ee-5813-4c5e-9246-c065a85c99b9"), null, 3542, "OON9W94808QB70853", 315.64282322497041, 0, 5 },
                    { new Guid("446cf47a-498e-4f51-b443-e2df15fc727a"), 3, new Guid("eedb2e04-0223-4ab0-bbac-aa43b37b6d95"), null, 5186, "WOACESWFFXC647328", 2660.3450193888189, 1, 0 },
                    { new Guid("4548b1cb-83b9-4cc7-a8e2-aca462c2239c"), 1, new Guid("50433eaf-f309-4a9f-b603-d2a14e59701b"), null, 1487, "KFKKLTVZ5TYA52104", 3225.9165076959339, 1, 5 },
                    { new Guid("45b0a26b-879e-41b3-ac9e-602d70d3c29e"), 1, new Guid("602fd8a7-57f7-4662-b82f-5351c7351af3"), null, 2476, "QOS39CFOASPH62418", 2025.6523326295496, 3, 2 },
                    { new Guid("47ac843e-4cf8-4d52-bb77-82dc79a8cc66"), 2, new Guid("c22744ad-e7e4-4083-9da8-68d3de702289"), null, 7215, "HO4300YG4KDK63786", 2873.9558369302054, 3, 4 },
                    { new Guid("47e675f4-ecf6-4325-90ef-93e16d86e8e0"), 2, new Guid("602fd8a7-57f7-4662-b82f-5351c7351af3"), null, 7182, "95GM37TCNKVY41638", 1738.4591707470286, 2, 3 },
                    { new Guid("496b9fad-261c-45a3-b3c7-9ef7dbb06cd0"), 1, new Guid("45f39368-4456-433c-ad9b-edaa7783e343"), null, 9040, "62BP1G1XNPPP29312", 1950.2579431421236, 0, 1 },
                    { new Guid("4a298220-efc3-4a66-a3f0-f58fde993dc1"), 0, new Guid("602fd8a7-57f7-4662-b82f-5351c7351af3"), null, 9076, "YTNKAWY5AJNU89675", 2062.8500094562442, 2, 2 },
                    { new Guid("4c794350-ba62-47c2-a8ba-2f39b1013f03"), 0, new Guid("ee86b2a2-2428-4053-917b-9a5fef50d789"), null, 4847, "LRS78V0R3RYN16309", 1109.3985304300609, 1, 3 },
                    { new Guid("4f8b7f50-2a57-48c6-9170-89f033d2b86f"), 3, new Guid("4d54f5ee-5813-4c5e-9246-c065a85c99b9"), null, 8679, "PECKFPXG16PI71781", 1465.9194183590942, 2, 0 },
                    { new Guid("4f8d8c54-76fc-4b8a-8e4f-3d529df898bd"), 3, new Guid("95b7414f-dc5a-4bb1-831e-bd915d295713"), null, 5847, "LHD5K8FM83A364003", 3115.5767437333852, 1, 4 },
                    { new Guid("538d25be-9805-4061-b559-4f47a1a58dcf"), 0, new Guid("c22744ad-e7e4-4083-9da8-68d3de702289"), null, 1737, "UTLRMQ1ZUFF953552", 3502.6600331214436, 3, 3 },
                    { new Guid("53c45c17-442e-4962-acc9-f17a1dd8f3c7"), 1, new Guid("db15f770-f6dc-4c94-a3ad-6799ed7df34a"), null, 1992, "IAATY91OYIW130907", 2791.5189720640815, 0, 4 },
                    { new Guid("53e3af5e-c876-4534-9ada-47affc8e3a29"), 2, new Guid("34ce56cd-f2b9-495b-a839-7a9d285e0115"), null, 5922, "RZLO1PFCFTSW61011", 1242.3798766909558, 0, 4 },
                    { new Guid("58102c09-5c15-4e36-9b89-d24ad5b98291"), 3, new Guid("703ff426-1d0e-403c-bfd6-664927657232"), null, 81, "C30N2T6O54MI39561", 3631.1928856201066, 2, 5 },
                    { new Guid("59ca6ad6-4664-4dba-92d4-a532c67ba3f7"), 2, new Guid("703ff426-1d0e-403c-bfd6-664927657232"), null, 3562, "454NWQCN2LIZ57424", 1774.5622062529451, 1, 5 },
                    { new Guid("5a809356-3312-4883-aac2-03e57df5e85d"), 3, new Guid("db15f770-f6dc-4c94-a3ad-6799ed7df34a"), null, 9067, "LO9OTEBNDXZ116054", 3058.2299487996079, 3, 3 },
                    { new Guid("5cd498c0-7aa2-4a6a-a6b4-200481b1ecc3"), 2, new Guid("b7d576f3-a9f7-440e-9c34-2289923d464b"), null, 8892, "XAKM0N9XC5EM27695", 3292.6074243568928, 1, 0 },
                    { new Guid("5cf0fa82-da19-4ec4-b55b-308b47ddcbac"), 3, new Guid("0cae08a1-e2de-4790-a1aa-5d3e91060acc"), null, 5923, "I975S5OUGNDF17644", 1216.6122813215902, 2, 1 },
                    { new Guid("61c0d1ac-693c-47a0-9de8-aa63caac7d64"), 1, new Guid("45f39368-4456-433c-ad9b-edaa7783e343"), null, 7627, "G057RLGLS1WN33869", 966.96979296551717, 2, 5 },
                    { new Guid("6472dcc5-2e96-44c7-a987-e05007037e6c"), 0, new Guid("ee86b2a2-2428-4053-917b-9a5fef50d789"), null, 2481, "PKRJ1THMIMII94518", 2160.6985150974974, 2, 2 },
                    { new Guid("670f5130-e264-49db-bda9-8df326af012a"), 2, new Guid("45f39368-4456-433c-ad9b-edaa7783e343"), null, 3234, "5NPMXUSUIHCG10113", 1124.0457303336852, 1, 5 },
                    { new Guid("6942e5ab-153b-477f-87fa-589aada8c0e4"), 1, new Guid("eedb2e04-0223-4ab0-bbac-aa43b37b6d95"), null, 3670, "3E8WPOWR7CM686398", 3344.5251315146861, 1, 4 },
                    { new Guid("6ac9b28d-1517-4759-917d-8977a1541b3c"), 2, new Guid("45f39368-4456-433c-ad9b-edaa7783e343"), null, 1965, "N2N1E3BF8EGM66557", 2809.7659068949315, 3, 3 },
                    { new Guid("6c866869-5bd0-4466-a4e0-75939c12f43f"), 2, new Guid("9995fc8c-3844-4c97-8c99-e0bcfc360cad"), null, 5320, "O85887Z6DSPV73647", 2559.5853708365721, 3, 2 },
                    { new Guid("6d087d7b-2fca-4ed1-8da8-a36aa973ff9f"), 2, new Guid("ea1cc4b7-c655-4b48-8297-557e2d3fbff0"), null, 81, "O2FUODLEBWDO93475", 1400.6560790769736, 3, 4 },
                    { new Guid("6e93c7b8-54ea-4d6d-b893-789e4ac22819"), 0, new Guid("4387099b-8477-4ab3-a04c-5f8cd225ebdc"), null, 820, "R9DM4TFP0KRK89779", 1669.0446185832534, 0, 2 },
                    { new Guid("6f39f195-1419-4d42-8002-ecfc71593d8e"), 3, new Guid("ee86b2a2-2428-4053-917b-9a5fef50d789"), null, 9295, "KEWTFWCRSBQ642653", 1442.3742433077341, 3, 0 },
                    { new Guid("6f64fd2b-b878-41ac-8ee9-b3530c805396"), 1, new Guid("c22744ad-e7e4-4083-9da8-68d3de702289"), null, 9749, "1DJI9YAZOWIB19126", 2412.4581076387299, 3, 2 },
                    { new Guid("750da4bb-9e92-4529-9f47-811538035d39"), 0, new Guid("eedb2e04-0223-4ab0-bbac-aa43b37b6d95"), null, 733, "H7AQB5AM6DFH57756", 2242.3684808137205, 2, 1 },
                    { new Guid("768f480c-49f6-49ac-abd7-bc248eb92d54"), 0, new Guid("44561354-904e-4ac5-bd97-10415a0d1585"), null, 3217, "ENMO45AFLNRV53448", 3619.3822536945831, 1, 5 },
                    { new Guid("76f37ce8-1957-4ec1-9f93-a8e287c1e2ce"), 1, new Guid("8ae805d5-0d78-4c71-bd7b-799b49a3a774"), null, 3599, "UFM4A98O8KLC55263", 1515.1963515422754, 1, 5 },
                    { new Guid("782a6007-8316-4345-ae2a-3e4c5bc0550d"), 2, new Guid("79034739-1060-4346-a39b-3800e3651960"), null, 5528, "887306Q4QIAD96882", 3097.9350801498745, 2, 1 },
                    { new Guid("79b27d5d-85fd-4166-9057-2179c4336325"), 2, new Guid("8e169234-04b3-48e5-9518-c21cd39f2c7f"), null, 4043, "DVQ84ZD8Y7DR35451", 3838.0699004557459, 0, 2 },
                    { new Guid("79d212d3-045f-45e3-8bc2-5a73bd2a36eb"), 3, new Guid("4d54f5ee-5813-4c5e-9246-c065a85c99b9"), null, 7816, "CCKQYQVDKXSL20440", 677.85628659378096, 2, 1 },
                    { new Guid("7aa431a8-c425-41f9-98c9-ca7226d60316"), 0, new Guid("ea1cc4b7-c655-4b48-8297-557e2d3fbff0"), null, 1973, "E23XU6ILE8MX64598", 2291.0589837434554, 3, 0 },
                    { new Guid("7d0f2101-d4d6-4a35-8a9e-e31a3d4af432"), 0, new Guid("8e169234-04b3-48e5-9518-c21cd39f2c7f"), null, 1781, "60RJGFPTDOW161437", 3247.0601344374381, 2, 1 },
                    { new Guid("82ae790e-2fc3-43e6-9d44-910d16b8c0b8"), 1, new Guid("95b7414f-dc5a-4bb1-831e-bd915d295713"), null, 514, "MXCP0KZHN1U239800", 1232.2532895763561, 2, 2 },
                    { new Guid("8838c6b1-c43f-45dd-9eef-4bf84d6aa712"), 3, new Guid("5e58ca15-9a3d-49ba-8054-8ea280e92980"), null, 386, "V0KM7Y9Q10BX88302", 2367.9353224899965, 3, 0 },
                    { new Guid("89e81961-7efb-469b-a9d5-c6ec7f973228"), 3, new Guid("95b7414f-dc5a-4bb1-831e-bd915d295713"), null, 1473, "WT9Y001MSYVA34984", 3552.5784929035426, 2, 5 },
                    { new Guid("8b5f8d92-ab8f-4583-bfe7-f4099388dc84"), 0, new Guid("15bf6bbf-a110-4a88-bc5e-8b4c47510b44"), null, 8357, "1J8U1MPYCHPM81865", 409.14694021276961, 2, 4 },
                    { new Guid("8d89b45f-423c-4133-9cf3-fbcf6ee36532"), 0, new Guid("81ab22e6-6240-4b31-8586-2475de8edc51"), null, 3545, "4DC2Z2TFAFZK77050", 2836.7248072209422, 1, 4 },
                    { new Guid("8e9aba1e-3dd0-46cb-8e44-c38ced3a1ef3"), 1, new Guid("bffaddb9-36c2-484a-b968-78afa974fcac"), null, 9951, "33QEHQ9AKTL417061", 748.81408590592412, 1, 3 },
                    { new Guid("8f97999d-46a0-4873-b2b0-8d45cac96248"), 0, new Guid("4387099b-8477-4ab3-a04c-5f8cd225ebdc"), null, 538, "U4DH6HV1PQEJ94847", 3141.504362870533, 1, 0 },
                    { new Guid("8ff89c2c-635b-4f38-a02f-b6794160a789"), 3, new Guid("44561354-904e-4ac5-bd97-10415a0d1585"), null, 374, "HMBRAO884HBN68770", 1557.2330785261638, 1, 4 },
                    { new Guid("9172ab35-7cf3-48ac-9cbe-37b30131c467"), 1, new Guid("44561354-904e-4ac5-bd97-10415a0d1585"), null, 5336, "727VZW6QOSGH72308", 1295.6064865532226, 2, 0 },
                    { new Guid("923576ca-472a-4e52-849e-d1c01067c8da"), 3, new Guid("95b7414f-dc5a-4bb1-831e-bd915d295713"), null, 101, "L10TIY1JAUPN51822", 2255.4564375101395, 2, 0 },
                    { new Guid("927e1c03-7857-4617-a5ad-bec2caa9a88a"), 0, new Guid("bffaddb9-36c2-484a-b968-78afa974fcac"), null, 9835, "GUSCB6A3DUQN46974", 1485.5746662921968, 0, 2 },
                    { new Guid("97b78eb0-dff7-49b7-90ca-89f4aeae9d1d"), 2, new Guid("9995fc8c-3844-4c97-8c99-e0bcfc360cad"), null, 4905, "W2WBZ4LOJYGO20575", 1964.2106161244046, 3, 3 },
                    { new Guid("9a1ea418-b6f2-4c55-9be8-4b72f5d56d5e"), 1, new Guid("bffaddb9-36c2-484a-b968-78afa974fcac"), null, 4779, "MBARZH97Z9Q694864", 242.68248916891176, 3, 4 },
                    { new Guid("9a685f64-f625-4d27-9ea6-13501258ccb4"), 0, new Guid("79034739-1060-4346-a39b-3800e3651960"), null, 9933, "WHZJXMHV8OEI17073", 3949.6318946599931, 0, 3 },
                    { new Guid("9c02cf28-1708-4ba4-85a7-bbb740bf7b1e"), 1, new Guid("602fd8a7-57f7-4662-b82f-5351c7351af3"), null, 5551, "G7FBV7CFA7UW63103", 3979.6428673307041, 2, 5 },
                    { new Guid("a0d22b27-6cc9-4a15-8fbe-b0a93ec4289c"), 0, new Guid("8ae805d5-0d78-4c71-bd7b-799b49a3a774"), null, 973, "V4K3W7E0BBM280328", 1979.5383017298959, 2, 5 },
                    { new Guid("a1b4de89-a964-4e06-93e4-32616a99b28f"), 1, new Guid("b7d576f3-a9f7-440e-9c34-2289923d464b"), null, 6721, "Q2CBZNAEKMWX95385", 2437.4293765347165, 2, 1 },
                    { new Guid("a50cdf57-6867-4d3e-9b19-e7e9add00783"), 3, new Guid("81ab22e6-6240-4b31-8586-2475de8edc51"), null, 3772, "AHD5XCXZJDTM82490", 3866.9087134807064, 1, 5 },
                    { new Guid("a531ee2b-3f11-4ec7-9a72-c15186890739"), 2, new Guid("4d54f5ee-5813-4c5e-9246-c065a85c99b9"), null, 5191, "ICXVYO8OBURB95521", 1593.3804027223368, 2, 0 },
                    { new Guid("a69e8837-a628-40e5-9d03-16502f35b599"), 2, new Guid("703ff426-1d0e-403c-bfd6-664927657232"), null, 2868, "V7ILO64TY7B634187", 3490.3174330292973, 2, 2 },
                    { new Guid("a7bc50f8-1415-424d-826f-9e57c12338c6"), 1, new Guid("9995fc8c-3844-4c97-8c99-e0bcfc360cad"), null, 5765, "E5JCT2EJQNE477385", 2588.7853149260973, 2, 5 },
                    { new Guid("a8976017-657e-4ee5-b6e7-eb07e2232812"), 2, new Guid("5e58ca15-9a3d-49ba-8054-8ea280e92980"), null, 9223, "LE5DDDZX0BXY75716", 2301.0439891306391, 1, 1 },
                    { new Guid("aaaaa1c3-96a4-4233-b013-cb0fe1dd40ed"), 2, new Guid("81ab22e6-6240-4b31-8586-2475de8edc51"), null, 2554, "OFJCKEZFHUDS21917", 1661.6974565308451, 0, 4 },
                    { new Guid("abde47ef-0186-4e8b-b9db-e2b0e82b8bcc"), 3, new Guid("c22744ad-e7e4-4083-9da8-68d3de702289"), null, 3989, "PFMJFUURWEMQ85619", 1065.1524140114361, 3, 0 },
                    { new Guid("af3b5a24-796c-45b6-802d-87edac0e0cc4"), 3, new Guid("15bf6bbf-a110-4a88-bc5e-8b4c47510b44"), null, 9254, "L4BN8Z0AOCSU92534", 3058.1908939835307, 0, 4 },
                    { new Guid("b21131c0-1da9-4fb0-8935-6edc729d9d84"), 1, new Guid("5e58ca15-9a3d-49ba-8054-8ea280e92980"), null, 6575, "N8EAHIAZ9RZ296656", 3322.819743113429, 0, 5 },
                    { new Guid("b378ebbb-e4d6-4027-8466-f7cab9b153ad"), 3, new Guid("cd76eccf-a3f0-4680-b90a-0b19b10c4d48"), null, 7802, "E515QM9TSCA139047", 3674.6122738784852, 0, 3 },
                    { new Guid("b3bfd9f4-5e4e-4ba2-b8a8-c9050a10a0ec"), 2, new Guid("c22744ad-e7e4-4083-9da8-68d3de702289"), null, 8473, "MTY2WIWKLCC831389", 1144.3321538621381, 2, 2 },
                    { new Guid("b53bcca4-d811-4b7f-b074-1eb9662b17b8"), 2, new Guid("15bf6bbf-a110-4a88-bc5e-8b4c47510b44"), null, 3461, "527Q7D0TJVLX13970", 1801.5914961220824, 0, 4 },
                    { new Guid("b70c608b-85b6-4235-862e-e9239cb4eb03"), 3, new Guid("9995fc8c-3844-4c97-8c99-e0bcfc360cad"), null, 4588, "1TYEA6QWYCQD99644", 3056.7319506534864, 2, 5 },
                    { new Guid("b951e0ae-9ea3-44cc-bc65-b7b7067c4005"), 1, new Guid("4387099b-8477-4ab3-a04c-5f8cd225ebdc"), null, 1886, "20VYGEQNNNLE60320", 426.53266456881829, 2, 5 },
                    { new Guid("ba784c0f-cc66-4677-ad26-f3b0b737be43"), 2, new Guid("8ae805d5-0d78-4c71-bd7b-799b49a3a774"), null, 2477, "P433YQBMR9OM68877", 2390.6491200764117, 1, 2 },
                    { new Guid("bd9c217d-58d6-41dc-bd9d-59697f9a7877"), 1, new Guid("db15f770-f6dc-4c94-a3ad-6799ed7df34a"), null, 7281, "9ZEFLA7R05OJ18297", 266.1001381614584, 3, 0 },
                    { new Guid("bf5d35d3-5c76-4000-8ed5-eaf86f534e04"), 0, new Guid("50433eaf-f309-4a9f-b603-d2a14e59701b"), null, 8521, "FQJ6FDSHP5AW20346", 2444.6885333543332, 0, 2 },
                    { new Guid("c59a3a8f-3155-469d-9452-ca5b69053b0c"), 1, new Guid("ea1cc4b7-c655-4b48-8297-557e2d3fbff0"), null, 6288, "L4FFEVRCOUUO50449", 3634.641414006931, 2, 5 },
                    { new Guid("c9584dcd-b427-42f7-a4b5-e977f43c05c4"), 2, new Guid("ea1cc4b7-c655-4b48-8297-557e2d3fbff0"), null, 6576, "CKYF7KQGEFPQ63223", 3351.1321108407283, 2, 1 },
                    { new Guid("c95e1902-2480-416e-a81e-160b59e5e449"), 0, new Guid("703ff426-1d0e-403c-bfd6-664927657232"), null, 3466, "NGCJP1EFAETD19096", 1778.9095953301774, 0, 2 },
                    { new Guid("d1a653d6-d565-49ec-97a3-5686d72800d3"), 3, new Guid("703ff426-1d0e-403c-bfd6-664927657232"), null, 5963, "6X3LSHUITWY187078", 3979.0517726401963, 3, 1 },
                    { new Guid("d3e25e66-7d90-43cd-ad1f-d69f22493786"), 3, new Guid("44561354-904e-4ac5-bd97-10415a0d1585"), null, 8026, "MCVOAC40VYV085998", 1579.9343236179368, 0, 5 },
                    { new Guid("d3e2d749-f411-4d2f-be69-5fde49a73eeb"), 2, new Guid("4d54f5ee-5813-4c5e-9246-c065a85c99b9"), null, 6671, "9W42KVYU8OJC98247", 3769.8490324375207, 2, 4 },
                    { new Guid("d7d2a61b-57c0-461a-b268-df00bc5a8a2a"), 0, new Guid("79034739-1060-4346-a39b-3800e3651960"), null, 3947, "AJ2H41NIALKJ45606", 1328.8014275830105, 2, 0 },
                    { new Guid("da6972b8-7c23-4cac-8b7a-0483799ac322"), 3, new Guid("81ab22e6-6240-4b31-8586-2475de8edc51"), null, 7397, "OLJKO8RQN7O081713", 3121.1362260487231, 2, 5 },
                    { new Guid("dba740a9-9070-477b-a3da-e3a1207197e3"), 1, new Guid("15bf6bbf-a110-4a88-bc5e-8b4c47510b44"), null, 5123, "AJ0FP7S4DPNF53804", 1321.6271989951376, 2, 3 },
                    { new Guid("dbc10c30-4a5b-4f91-9791-78bceec204f5"), 0, new Guid("34ce56cd-f2b9-495b-a839-7a9d285e0115"), null, 4255, "LZEDB0AP3PZ946102", 1453.4188973053992, 3, 4 },
                    { new Guid("dd96ba71-2080-40fb-bde1-49dde7b23698"), 3, new Guid("bffaddb9-36c2-484a-b968-78afa974fcac"), null, 7471, "NM9KABO0ZIAA72504", 1306.9742638634457, 3, 5 },
                    { new Guid("de07f4ab-2872-4e63-bf31-d449ca4ed851"), 1, new Guid("0cae08a1-e2de-4790-a1aa-5d3e91060acc"), null, 3528, "7IA9Y68JJUCA54730", 295.92911944626388, 0, 2 },
                    { new Guid("dea3935a-b76b-46aa-a6ed-d2a2e5e6a545"), 0, new Guid("50433eaf-f309-4a9f-b603-d2a14e59701b"), null, 6850, "53JG4EY0QLDC72452", 2479.9299593447558, 1, 5 },
                    { new Guid("df18d420-db36-4472-8b1b-e33b134f5001"), 1, new Guid("34ce56cd-f2b9-495b-a839-7a9d285e0115"), null, 4966, "D2M2I9D9ULUU99898", 610.25924701163331, 0, 1 },
                    { new Guid("e18fe9eb-8948-400c-bb55-cc5de8e609ea"), 0, new Guid("cd76eccf-a3f0-4680-b90a-0b19b10c4d48"), null, 3378, "QZW2F2ICNTHY42698", 3595.9452799517412, 3, 5 },
                    { new Guid("e2722fa0-d09f-4b98-b551-0c681a82cf32"), 2, new Guid("eedb2e04-0223-4ab0-bbac-aa43b37b6d95"), null, 5815, "NQE4O6BSQ4DE50392", 318.60551016501847, 1, 0 },
                    { new Guid("e46c6467-783d-4540-a931-1b837251d039"), 2, new Guid("cd76eccf-a3f0-4680-b90a-0b19b10c4d48"), null, 711, "VNADP9D5X3MR21419", 2353.0020756198201, 1, 4 },
                    { new Guid("e46efc08-49f1-43fe-83b0-a79ec820a8d9"), 1, new Guid("ee86b2a2-2428-4053-917b-9a5fef50d789"), null, 4689, "EUZC11TH6MDE61673", 1112.4091283222542, 3, 0 },
                    { new Guid("e4914beb-0204-4497-83a0-b65b56186a90"), 1, new Guid("34ce56cd-f2b9-495b-a839-7a9d285e0115"), null, 3627, "C2KP1UUFMQQQ82949", 2451.8922634038163, 3, 2 },
                    { new Guid("e566093e-912d-4b63-aec6-948fd0e4a6a1"), 0, new Guid("5e58ca15-9a3d-49ba-8054-8ea280e92980"), null, 8141, "ZE0X1QPLHBF324687", 601.61277961403607, 1, 2 },
                    { new Guid("eb99eac3-d6a0-456a-8d65-eb94ba9a64b5"), 2, new Guid("79034739-1060-4346-a39b-3800e3651960"), null, 460, "U3B3Z0A24WBP31037", 1893.3374230949175, 1, 1 },
                    { new Guid("eeb7722a-80ad-43ce-90cb-c4d7f217f752"), 1, new Guid("50433eaf-f309-4a9f-b603-d2a14e59701b"), null, 203, "4L8TWMEHCSF018179", 1937.4305130505288, 3, 2 },
                    { new Guid("f14fbbf4-76bf-4055-9f9b-006cae06ac0b"), 2, new Guid("8e169234-04b3-48e5-9518-c21cd39f2c7f"), null, 2767, "4WA8Y88KBMG950825", 562.43534454488849, 0, 5 },
                    { new Guid("f5389ea0-1dbc-4c8b-aff1-734e7bf864a8"), 3, new Guid("602fd8a7-57f7-4662-b82f-5351c7351af3"), null, 4827, "AII4DLO5AFL563487", 1845.0779876994732, 1, 4 },
                    { new Guid("f7b540db-9d79-4674-a182-d83ca8521370"), 1, new Guid("34ce56cd-f2b9-495b-a839-7a9d285e0115"), null, 7238, "4KBXJHANVAN049703", 493.76313627594192, 2, 5 },
                    { new Guid("f8214993-0cdd-4c2a-88d0-75b74149a35e"), 2, new Guid("cd76eccf-a3f0-4680-b90a-0b19b10c4d48"), null, 446, "12XLKLKXMRDM13924", 1448.2184584411414, 0, 5 },
                    { new Guid("f9a199f2-5c4b-4c0f-ac81-324665e642e8"), 0, new Guid("8ae805d5-0d78-4c71-bd7b-799b49a3a774"), null, 6759, "4Q81LIR5H7AW41624", 583.43270143449433, 2, 0 },
                    { new Guid("faa4b28f-91a1-4094-ae5b-6c559277c390"), 3, new Guid("0cae08a1-e2de-4790-a1aa-5d3e91060acc"), null, 5453, "8V7KG4888KBZ32404", 2973.1591687363839, 3, 5 },
                    { new Guid("fb7fea6a-e9a5-4f45-a8f4-b9011ad7387e"), 0, new Guid("81ab22e6-6240-4b31-8586-2475de8edc51"), null, 9698, "EAYRVV3CR5HR15390", 218.50419556275401, 2, 2 },
                    { new Guid("fbe42799-0a4c-4970-ac0f-38c02e8c0ed5"), 3, new Guid("ee86b2a2-2428-4053-917b-9a5fef50d789"), null, 4267, "G1ZHA7GMC4U395314", 1345.1164075904464, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("07ab88f5-ad1a-44ba-8d06-3bd0017c494f"), new Guid("5da0b549-709d-42a7-911a-40c53532dd3b"), new DateTime(2023, 6, 25, 21, 0, 29, 156, DateTimeKind.Utc).AddTicks(1853), new DateTime(2023, 6, 24, 4, 15, 42, 279, DateTimeKind.Utc).AddTicks(1620), new Guid("dbc10c30-4a5b-4f91-9791-78bceec204f5") },
                    { new Guid("455b43fe-2e14-4824-bffb-4623bed2f887"), new Guid("5da0b549-709d-42a7-911a-40c53532dd3b"), new DateTime(2023, 8, 28, 15, 29, 4, 860, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 4, 10, 12, 42, 43, 950, DateTimeKind.Utc).AddTicks(9321), new Guid("e2722fa0-d09f-4b98-b551-0c681a82cf32") },
                    { new Guid("4a7cd805-a270-4ea4-9b3c-56cb218e11ee"), new Guid("5da0b549-709d-42a7-911a-40c53532dd3b"), new DateTime(2024, 4, 29, 0, 25, 0, 602, DateTimeKind.Utc).AddTicks(7713), new DateTime(2024, 6, 8, 7, 41, 50, 274, DateTimeKind.Utc).AddTicks(1155), new Guid("3bd49b40-1472-4a04-bd6c-acea90b50d8d") },
                    { new Guid("4bad2048-9b59-4b98-9bc0-3e189e414317"), new Guid("5da0b549-709d-42a7-911a-40c53532dd3b"), new DateTime(2023, 8, 27, 21, 39, 1, 386, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 10, 22, 7, 21, 17, 585, DateTimeKind.Utc).AddTicks(9345), new Guid("e2722fa0-d09f-4b98-b551-0c681a82cf32") },
                    { new Guid("d0e6f9af-04b5-4f1d-bf5a-9ff3bfe3588d"), new Guid("5da0b549-709d-42a7-911a-40c53532dd3b"), new DateTime(2024, 5, 4, 23, 14, 25, 962, DateTimeKind.Utc).AddTicks(3965), new DateTime(2023, 12, 4, 13, 24, 10, 501, DateTimeKind.Utc).AddTicks(1209), new Guid("89e81961-7efb-469b-a9d5-c6ec7f973228") }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0cae08a1-e2de-4790-a1aa-5d3e91060acc"), new Guid("c1893305-d1ba-4930-941e-00e2279a5d49"), "Focus" },
                    { new Guid("15bf6bbf-a110-4a88-bc5e-8b4c47510b44"), new Guid("c1893305-d1ba-4930-941e-00e2279a5d49"), "A8" },
                    { new Guid("34ce56cd-f2b9-495b-a839-7a9d285e0115"), new Guid("be7f8ca5-7c97-4574-96a8-d7da0a317ffb"), "Explorer" },
                    { new Guid("4387099b-8477-4ab3-a04c-5f8cd225ebdc"), new Guid("be7f8ca5-7c97-4574-96a8-d7da0a317ffb"), "Focus" },
                    { new Guid("44561354-904e-4ac5-bd97-10415a0d1585"), new Guid("33033254-55f6-4f3b-a8d2-c9dd071ffbd1"), "2" },
                    { new Guid("45f39368-4456-433c-ad9b-edaa7783e343"), new Guid("c1893305-d1ba-4930-941e-00e2279a5d49"), "V90" },
                    { new Guid("4d54f5ee-5813-4c5e-9246-c065a85c99b9"), new Guid("b6a7711c-a5ce-4197-9a36-a0e9c957a0bc"), "Wrangler" },
                    { new Guid("50433eaf-f309-4a9f-b603-d2a14e59701b"), new Guid("33033254-55f6-4f3b-a8d2-c9dd071ffbd1"), "Camry" },
                    { new Guid("5e58ca15-9a3d-49ba-8054-8ea280e92980"), new Guid("be7f8ca5-7c97-4574-96a8-d7da0a317ffb"), "Focus" },
                    { new Guid("602fd8a7-57f7-4662-b82f-5351c7351af3"), new Guid("be7f8ca5-7c97-4574-96a8-d7da0a317ffb"), "CX-9" },
                    { new Guid("703ff426-1d0e-403c-bfd6-664927657232"), new Guid("c1893305-d1ba-4930-941e-00e2279a5d49"), "Mercielago" },
                    { new Guid("79034739-1060-4346-a39b-3800e3651960"), new Guid("33033254-55f6-4f3b-a8d2-c9dd071ffbd1"), "Fiesta" },
                    { new Guid("81ab22e6-6240-4b31-8586-2475de8edc51"), new Guid("b6a7711c-a5ce-4197-9a36-a0e9c957a0bc"), "Grand Caravan" },
                    { new Guid("8ae805d5-0d78-4c71-bd7b-799b49a3a774"), new Guid("c1893305-d1ba-4930-941e-00e2279a5d49"), "LeBaron" },
                    { new Guid("8e169234-04b3-48e5-9518-c21cd39f2c7f"), new Guid("4b3a93c1-aae1-4239-9b92-79a69ef177f7"), "Impala" },
                    { new Guid("95b7414f-dc5a-4bb1-831e-bd915d295713"), new Guid("be7f8ca5-7c97-4574-96a8-d7da0a317ffb"), "A8" },
                    { new Guid("9995fc8c-3844-4c97-8c99-e0bcfc360cad"), new Guid("4b3a93c1-aae1-4239-9b92-79a69ef177f7"), "Element" },
                    { new Guid("b7d576f3-a9f7-440e-9c34-2289923d464b"), new Guid("33033254-55f6-4f3b-a8d2-c9dd071ffbd1"), "Volt" },
                    { new Guid("bffaddb9-36c2-484a-b968-78afa974fcac"), new Guid("4b3a93c1-aae1-4239-9b92-79a69ef177f7"), "Spyder" },
                    { new Guid("c22744ad-e7e4-4083-9da8-68d3de702289"), new Guid("33033254-55f6-4f3b-a8d2-c9dd071ffbd1"), "Escalade" },
                    { new Guid("cd76eccf-a3f0-4680-b90a-0b19b10c4d48"), new Guid("b6a7711c-a5ce-4197-9a36-a0e9c957a0bc"), "XC90" },
                    { new Guid("db15f770-f6dc-4c94-a3ad-6799ed7df34a"), new Guid("b6a7711c-a5ce-4197-9a36-a0e9c957a0bc"), "Ranchero" },
                    { new Guid("ea1cc4b7-c655-4b48-8297-557e2d3fbff0"), new Guid("b6a7711c-a5ce-4197-9a36-a0e9c957a0bc"), "Focus" },
                    { new Guid("ee86b2a2-2428-4053-917b-9a5fef50d789"), new Guid("4b3a93c1-aae1-4239-9b92-79a69ef177f7"), "Malibu" },
                    { new Guid("eedb2e04-0223-4ab0-bbac-aa43b37b6d95"), new Guid("4b3a93c1-aae1-4239-9b92-79a69ef177f7"), "Countach" }
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
