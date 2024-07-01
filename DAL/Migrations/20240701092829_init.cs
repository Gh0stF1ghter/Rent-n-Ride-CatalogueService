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
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_Manufacturers_ManufacturerId",
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
                    CarModelId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39c8cafb-e68d-4ed8-8657-59aa992be4d0"), "Jeep" },
                    { new Guid("39f75f2f-d37c-4a20-a6f6-11f4481caf9e"), "Land Rover" },
                    { new Guid("3d46b121-8c23-422a-b91c-4587f4f81e23"), "Nissan" },
                    { new Guid("63966981-4ee5-4504-a6c9-85fa38b7311e"), "Fiat" },
                    { new Guid("834d8097-c842-4d2e-ab0b-808ccb4352f9"), "Mini" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarModelId", "FuelType", "ModelId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("0361ba9c-642a-4372-961d-c4dce60941fb"), null, 0, new Guid("bd6dc88f-be42-4b5f-bbe4-576771e0890b"), 2055, "IO8GBGWZHOZ468416", 222.11618833593624, 2, 1 },
                    { new Guid("03acfcb8-e25f-4efc-88fc-2a7005a905d3"), null, 1, new Guid("7f369d6d-3223-4e00-804e-29e7840396e6"), 198, "1DKWK222MZYK41755", 246.69439761542048, 2, 3 },
                    { new Guid("04253b82-cfb7-4a46-90ac-c62285ed490a"), null, 2, new Guid("7f47c3ae-5071-462b-b02e-1365c7b96548"), 9164, "LD2ZLRF3OFJC55704", 3685.6132850505442, 1, 1 },
                    { new Guid("0714cac0-9dbc-46b9-ad82-515dd52649bc"), null, 0, new Guid("bcd6b584-9e69-44ce-b51d-86da2b92c1ca"), 168, "RYZX0YQFBHPF98056", 3154.2724476414364, 3, 0 },
                    { new Guid("07263759-4174-4107-96fa-5a661ebebd97"), null, 0, new Guid("d8a70a3f-6c89-44a8-bed8-9ec5941808eb"), 6031, "YV6YMENKIDA559059", 3782.5472616247671, 1, 0 },
                    { new Guid("094d76be-9791-42f5-ba92-5f2ca44aae62"), null, 3, new Guid("2a476438-4af4-4261-9696-8333b85da652"), 8569, "L8HWXBBVG2NG35288", 316.02892140201965, 3, 1 },
                    { new Guid("098a7668-1db5-4b0e-8ed7-41a7e4a2548f"), null, 2, new Guid("994248b5-f049-4012-8b89-ffe0ca5dde6a"), 6410, "UETYX5YAJBC647340", 2134.7948424322631, 1, 4 },
                    { new Guid("0b9f64c1-db1f-44ee-b62f-43e653b47e6a"), null, 2, new Guid("e7eb530e-19cc-4ae9-8341-2961fea3a54c"), 9603, "2GX5LO2VA4G547209", 2804.9137369230375, 0, 0 },
                    { new Guid("0bb19c09-cc01-49e6-b34b-0cbe4708fb1d"), null, 3, new Guid("a2e9ac92-8f98-467e-a128-ee5e8b04f7c8"), 5245, "7AXGXPD59TVM84651", 2248.6260663143644, 2, 4 },
                    { new Guid("0efac801-e804-4c1c-a4ae-206aed05ba93"), null, 2, new Guid("e768ecab-0a8f-4246-a02d-dc9139d497dd"), 463, "BJGZFTE6XBPQ36241", 494.96085489072351, 1, 4 },
                    { new Guid("0f365ed8-52b9-4dbf-9a4e-eedae555da99"), null, 1, new Guid("bcd6b584-9e69-44ce-b51d-86da2b92c1ca"), 5690, "JJTSB9J7HPF522211", 721.43799092725931, 2, 2 },
                    { new Guid("10c4b1cc-2d6c-466a-842f-31a548d81083"), null, 2, new Guid("3ae5efb5-eefb-41bb-97fc-2df40a72c8f1"), 5919, "LC11QG93ITHQ62064", 425.03277661247535, 0, 3 },
                    { new Guid("122cfa83-018e-4014-9197-b13d352a27b6"), null, 0, new Guid("acdf47e3-f257-4989-8c09-04f610d0a197"), 5450, "HRE7K8FIXHCY48518", 3042.7160417202972, 3, 2 },
                    { new Guid("15d18e48-37c8-4307-9844-e51e3d16d117"), null, 1, new Guid("e768ecab-0a8f-4246-a02d-dc9139d497dd"), 7774, "UQ53UR29E0N427237", 1428.9275258499633, 0, 5 },
                    { new Guid("166026df-305f-4a4b-8ad7-4306b7d5aad9"), null, 0, new Guid("39c8eb29-afa6-42a8-a75f-2473812a7e2c"), 1139, "HIU8DARRXWCN90748", 2641.8159927113493, 3, 2 },
                    { new Guid("17b50b3d-5a1d-4e07-ba1a-b669473da0f3"), null, 1, new Guid("e768ecab-0a8f-4246-a02d-dc9139d497dd"), 8085, "3DK2CSR4EDQR81719", 859.0505228475879, 2, 5 },
                    { new Guid("1835525d-70a0-43fe-8f7b-ad159a00843a"), null, 2, new Guid("bd6dc88f-be42-4b5f-bbe4-576771e0890b"), 3434, "6OBDVQYSPQJ614665", 247.31339086741016, 0, 1 },
                    { new Guid("19fba074-eef5-429c-8d0e-e09ba96cce3f"), null, 0, new Guid("acdf47e3-f257-4989-8c09-04f610d0a197"), 756, "D4UL0OT0IRA844159", 794.65311814367362, 0, 1 },
                    { new Guid("1a1a09be-2807-4a49-8c1c-5a5c4ea52334"), null, 3, new Guid("bd6dc88f-be42-4b5f-bbe4-576771e0890b"), 2750, "T3XWKHG7KKRF49758", 2764.537736016418, 3, 1 },
                    { new Guid("1a1b1bcd-9551-4b63-9085-33ed9cbd5901"), null, 3, new Guid("bf80bd70-f83b-4f49-afea-63df41243d78"), 7694, "FGS5SLK20VF852455", 1008.8959312106759, 1, 5 },
                    { new Guid("1a597447-676f-4e86-9c97-a375d85c631a"), null, 0, new Guid("e7eb530e-19cc-4ae9-8341-2961fea3a54c"), 5822, "BTE3JB6GDVSM35069", 2149.9537746395604, 3, 5 },
                    { new Guid("1b1511e8-58e4-445d-bc8c-ad22d881fb9d"), null, 2, new Guid("39c8eb29-afa6-42a8-a75f-2473812a7e2c"), 4607, "F26OMPX48HP241303", 2947.0921812745282, 3, 0 },
                    { new Guid("1e81301f-6864-46b1-8e7b-25ed4d31ba37"), null, 2, new Guid("63d7dc30-c83a-46cd-936b-254dc48173b4"), 7657, "0SDCZW8TUJFM65143", 1832.7645954458892, 3, 5 },
                    { new Guid("2552ae63-a08e-4da0-b85a-eb5d6c05b3fc"), null, 2, new Guid("3ae5efb5-eefb-41bb-97fc-2df40a72c8f1"), 5071, "EJ6KOO3Z3EVJ26833", 558.07146444239743, 3, 1 },
                    { new Guid("259a8f1c-9f3f-4452-b2b2-4e5ca688bf23"), null, 0, new Guid("63d7dc30-c83a-46cd-936b-254dc48173b4"), 416, "39439PQ4UJD227320", 2219.0411241110146, 1, 4 },
                    { new Guid("266d0b20-6e74-40a5-983e-e8ae81d2516a"), null, 2, new Guid("2a476438-4af4-4261-9696-8333b85da652"), 336, "OE2A95F4NNVO64884", 1293.7960302727647, 0, 3 },
                    { new Guid("28a01177-678f-46dc-81c7-896765670842"), null, 2, new Guid("89fb2363-5303-49b2-8241-31c0d0a57240"), 4940, "TT3O80OG7OOP84084", 3498.1933967730861, 3, 3 },
                    { new Guid("2a24678f-42ea-488b-91d2-c4dfe5874141"), null, 1, new Guid("774a072c-b689-41b3-aa0d-07d39b86c26d"), 6326, "JDY2CK3CD7GM92911", 348.50365645303282, 2, 3 },
                    { new Guid("2e24a90c-0fdd-450a-8848-42f1627362de"), null, 0, new Guid("89fb2363-5303-49b2-8241-31c0d0a57240"), 3485, "ZLQV2GXCGXTN48487", 2176.3388443105109, 3, 0 },
                    { new Guid("2f334f92-7422-474d-a707-8b6d13263de6"), null, 1, new Guid("019f2d5e-c2c3-4e19-90d7-29b1e57ef74d"), 125, "AIZQYA1CU8I835204", 2194.4698260262871, 3, 3 },
                    { new Guid("2fa3703c-5446-4807-a465-7b7ac56a17ce"), null, 1, new Guid("994248b5-f049-4012-8b89-ffe0ca5dde6a"), 4455, "75CKZQGGFQOR42938", 631.62997194541015, 0, 4 },
                    { new Guid("322e6abf-80ac-401f-8f7f-39d9dd93ffff"), null, 2, new Guid("e7eb530e-19cc-4ae9-8341-2961fea3a54c"), 9685, "DSBY9LI68UTK60415", 1149.8410951155297, 3, 3 },
                    { new Guid("329d8d53-9aca-48ab-b883-acf2263b4077"), null, 2, new Guid("bf80bd70-f83b-4f49-afea-63df41243d78"), 2209, "W9G686LWL5AE75761", 3521.3208956815688, 3, 0 },
                    { new Guid("36b58940-8dce-46d8-a270-a02e4b2a8e5a"), null, 1, new Guid("aa3e71dc-c837-4988-8bb7-5e2566ba9b21"), 1263, "7PVELUQZVLT545058", 3550.9019595070959, 3, 1 },
                    { new Guid("38df96fa-90e8-4eb7-bd17-18158c7902b8"), null, 0, new Guid("1ab2986f-184e-4c30-bba8-7ca6b68d4a63"), 4942, "NUONGL7CIWZ322656", 3627.2766399272746, 0, 2 },
                    { new Guid("3a7cd983-70d5-4b7a-9b0c-62d2c084eac0"), null, 0, new Guid("04c0fb3c-6a9d-4525-ae5c-0dda606c8442"), 8587, "Z2R1O82XXDU441816", 2938.655992539796, 2, 3 },
                    { new Guid("3ae7f7b3-fd22-4ef5-a4f8-72311232d882"), null, 3, new Guid("e768ecab-0a8f-4246-a02d-dc9139d497dd"), 9856, "IBJ9RDX75NED55803", 248.28463729510167, 0, 0 },
                    { new Guid("3b2af9a1-8353-4991-a3bf-994e6fc078fb"), null, 1, new Guid("d8a70a3f-6c89-44a8-bed8-9ec5941808eb"), 9977, "3G3HDPN9R6Q217157", 206.36545733794117, 0, 1 },
                    { new Guid("3c5172e3-d23a-48f4-9329-8403fb761d5c"), null, 2, new Guid("89fb2363-5303-49b2-8241-31c0d0a57240"), 9375, "T350MBK03TRS93929", 3666.555362110947, 2, 2 },
                    { new Guid("3f7d0a0f-aa22-4d09-8c9c-2751b6a0dc6f"), null, 0, new Guid("a4203fc0-04fe-4dad-9659-145c7d5eb161"), 6070, "QFFJC4CZ8TON65192", 3372.0124122874327, 1, 5 },
                    { new Guid("4256fea8-ea1d-4e72-8e3f-bfdeb66a0264"), null, 1, new Guid("99ad68d2-f7ac-406e-a7e1-5e53999b33fc"), 4845, "BBRGKL9RLEPU70032", 282.51933212100562, 0, 1 },
                    { new Guid("4309d2e7-7441-429c-87c4-aba1573de495"), null, 1, new Guid("3ae5efb5-eefb-41bb-97fc-2df40a72c8f1"), 4631, "UT141J834CPN99875", 234.34772455918545, 2, 4 },
                    { new Guid("439bac42-a7c4-456f-b07a-09fa674fd464"), null, 3, new Guid("e7eb530e-19cc-4ae9-8341-2961fea3a54c"), 8855, "5PN2ZITFYYP726089", 3539.5426776786289, 3, 3 },
                    { new Guid("4783aa81-393b-4372-be78-c79dce7421ca"), null, 2, new Guid("99ad68d2-f7ac-406e-a7e1-5e53999b33fc"), 6329, "F52ZVZWI5TCV37912", 2312.7379253328936, 1, 3 },
                    { new Guid("48e3d306-b64c-4a07-9eb5-64f93e4561f1"), null, 3, new Guid("bf80bd70-f83b-4f49-afea-63df41243d78"), 5345, "0BCDQZ7GJ7DP44779", 1767.1711451259685, 2, 0 },
                    { new Guid("4b1396cc-94aa-47ff-a4a2-084fa5bd777c"), null, 2, new Guid("a4203fc0-04fe-4dad-9659-145c7d5eb161"), 9484, "B2WEW73JZ5VG22866", 143.27656311992246, 2, 3 },
                    { new Guid("4c1a1369-8ffe-44e5-ac4b-a0698b3a5a2d"), null, 2, new Guid("1ab2986f-184e-4c30-bba8-7ca6b68d4a63"), 1465, "WUBCWXOCMLKR87783", 2509.7351414044228, 3, 3 },
                    { new Guid("4f1373c8-c8c1-4a9d-a000-b4a976db8d14"), null, 1, new Guid("994248b5-f049-4012-8b89-ffe0ca5dde6a"), 9002, "ZYP9OR5D3FF140184", 597.7792065729036, 1, 1 },
                    { new Guid("5182d7ad-b0fb-41c5-adf5-fa7124753523"), null, 1, new Guid("39c8eb29-afa6-42a8-a75f-2473812a7e2c"), 2889, "JYX0U8IK96V175826", 124.25036748013498, 3, 5 },
                    { new Guid("52181824-30ff-4356-94c2-2260f2149a5a"), null, 1, new Guid("3ae5efb5-eefb-41bb-97fc-2df40a72c8f1"), 409, "9QPIENKKNNY382813", 193.14621809378423, 1, 0 },
                    { new Guid("522cd41f-b55e-4733-8b70-2d01806caf80"), null, 3, new Guid("7f47c3ae-5071-462b-b02e-1365c7b96548"), 6277, "MR2IOBI5CZO597363", 147.68023914709306, 3, 3 },
                    { new Guid("525c95f1-73a4-4b4d-8033-22a34feb0e5d"), null, 0, new Guid("a2e9ac92-8f98-467e-a128-ee5e8b04f7c8"), 1430, "9A9KJ5P26HO547511", 3851.6534067587404, 2, 2 },
                    { new Guid("52d0791e-4037-4a87-a678-545fda1d51d4"), null, 1, new Guid("691d0d40-2f3b-43f1-b392-6bf66a3d874a"), 9855, "85L02DGUISZB37382", 2623.3806476512023, 2, 4 },
                    { new Guid("53651752-3c3d-48e5-9241-645735e84da8"), null, 0, new Guid("aa3e71dc-c837-4988-8bb7-5e2566ba9b21"), 2164, "OOD533JWJHK612212", 1518.5598139648064, 1, 0 },
                    { new Guid("56361eb5-e3b3-48ec-8b6c-4132673ec75e"), null, 0, new Guid("1ab2986f-184e-4c30-bba8-7ca6b68d4a63"), 3774, "50VGY7QJUKYL37882", 3122.2286666489035, 2, 5 },
                    { new Guid("5654291a-9cf6-4175-9c5c-a30037bd3889"), null, 3, new Guid("019f2d5e-c2c3-4e19-90d7-29b1e57ef74d"), 4714, "KFWWHIBORNQC62436", 247.52583720970674, 1, 0 },
                    { new Guid("593376ed-b53a-47eb-87ff-8c371398018c"), null, 0, new Guid("d8a70a3f-6c89-44a8-bed8-9ec5941808eb"), 3880, "IZVYGXHDHMFC76339", 3867.3180228874462, 3, 5 },
                    { new Guid("5b24cd05-3be4-4035-bd9e-f31a8d9b9620"), null, 2, new Guid("774a072c-b689-41b3-aa0d-07d39b86c26d"), 1485, "V51S2B84FCD558653", 410.22516505810455, 0, 4 },
                    { new Guid("60f73081-d083-4a0d-bca9-f63aef4322c1"), null, 3, new Guid("acdf47e3-f257-4989-8c09-04f610d0a197"), 962, "I2KMJ0AGSMNG92957", 2091.5103273500117, 3, 0 },
                    { new Guid("62bf891b-b5c7-41c0-b555-607b1cab1eec"), null, 3, new Guid("99ad68d2-f7ac-406e-a7e1-5e53999b33fc"), 9760, "24A1TAL1JSNY11092", 3375.4538179722354, 1, 2 },
                    { new Guid("6430e78b-f9b4-4d13-bc48-4f5403a99372"), null, 2, new Guid("691d0d40-2f3b-43f1-b392-6bf66a3d874a"), 6786, "U1EALHOI2YU193384", 618.07103150944693, 1, 5 },
                    { new Guid("65219251-d587-463a-bb62-3c785c973113"), null, 0, new Guid("89fb2363-5303-49b2-8241-31c0d0a57240"), 5179, "QNW5PSM013J185451", 3512.0141753789035, 1, 5 },
                    { new Guid("665bc1aa-8e16-418c-8a2e-0beaa61b0081"), null, 2, new Guid("63d7dc30-c83a-46cd-936b-254dc48173b4"), 746, "VJY1HQARLKS918689", 799.86151923684463, 0, 2 },
                    { new Guid("66ad8c44-eedc-449f-bfe8-4de1024b3416"), null, 1, new Guid("e7eb530e-19cc-4ae9-8341-2961fea3a54c"), 6768, "KCV12DXJHIBI88813", 631.04756455962843, 0, 4 },
                    { new Guid("67d99fef-c16e-4836-b851-977d19bc6e49"), null, 1, new Guid("019f2d5e-c2c3-4e19-90d7-29b1e57ef74d"), 3031, "F4R7RQM78AXH82037", 791.42243306705723, 1, 1 },
                    { new Guid("6d92a730-66f1-4efb-9d9a-4f771064176c"), null, 2, new Guid("a4203fc0-04fe-4dad-9659-145c7d5eb161"), 8648, "73XX3FNED2S988361", 2182.7489922469044, 3, 2 },
                    { new Guid("6de17886-c12a-4f69-8099-171ca460b81d"), null, 0, new Guid("39c8eb29-afa6-42a8-a75f-2473812a7e2c"), 848, "3970Y6I7KBAB65078", 834.42587447638482, 3, 1 },
                    { new Guid("702d5c3f-8510-4c2d-8643-808b785e2db9"), null, 2, new Guid("bd6dc88f-be42-4b5f-bbe4-576771e0890b"), 6440, "XGNA94WQHMTF37202", 247.43957731608435, 2, 0 },
                    { new Guid("73236d96-2b84-477c-9900-8a84a269e914"), null, 0, new Guid("04c0fb3c-6a9d-4525-ae5c-0dda606c8442"), 8262, "VXL2IU7Q79PN61252", 2333.5260048971445, 0, 1 },
                    { new Guid("7670c96d-ba34-4a8e-bfb7-09d8610b878a"), null, 0, new Guid("bcd6b584-9e69-44ce-b51d-86da2b92c1ca"), 8691, "O43QOS2ZDBB110540", 3929.2816685215444, 1, 4 },
                    { new Guid("77b07e70-faa4-43bd-921d-a08584c8c37f"), null, 1, new Guid("c0f12b18-5b1c-486d-a622-709ad132b54a"), 6815, "2YB5V8TO15K653999", 2659.8492246889505, 1, 4 },
                    { new Guid("781e5109-d5a5-4916-8a84-fbe516b48116"), null, 0, new Guid("04c0fb3c-6a9d-4525-ae5c-0dda606c8442"), 7665, "D98H370QQFET41921", 1956.4382389927844, 3, 1 },
                    { new Guid("782af9c0-5a73-492d-8b42-53d2f0342f8a"), null, 0, new Guid("2a476438-4af4-4261-9696-8333b85da652"), 2355, "M0HVTZ6L94UL67872", 2197.1961384791293, 2, 3 },
                    { new Guid("78c8ec32-b1a1-4565-97d8-1b31ff0e01a7"), null, 3, new Guid("a2e9ac92-8f98-467e-a128-ee5e8b04f7c8"), 9087, "XIYYTRQIOATU86749", 2430.8034404019936, 1, 0 },
                    { new Guid("7b479454-8e79-44ee-be4d-c1d9cba30a04"), null, 1, new Guid("2a476438-4af4-4261-9696-8333b85da652"), 1474, "6C75TAEKO5PG55238", 1658.7860429636166, 3, 4 },
                    { new Guid("7eca6e37-7119-4316-be8e-b4b9c7492e51"), null, 2, new Guid("7f47c3ae-5071-462b-b02e-1365c7b96548"), 7436, "LMIG9HJVKHVA39110", 3118.6541469942495, 0, 3 },
                    { new Guid("82ddf777-565f-4894-82e9-2453c3d9a069"), null, 0, new Guid("7f47c3ae-5071-462b-b02e-1365c7b96548"), 3127, "TY5IECKRP2FT99488", 2124.4053556372796, 3, 5 },
                    { new Guid("84b67b47-2fba-464a-afe1-3cba7e1aeb52"), null, 1, new Guid("99ad68d2-f7ac-406e-a7e1-5e53999b33fc"), 3972, "ZMG7CJ7P56SN43000", 3777.8203835129707, 0, 3 },
                    { new Guid("861b30d3-3cba-4524-a670-84ff5d25496a"), null, 3, new Guid("c0f12b18-5b1c-486d-a622-709ad132b54a"), 3345, "RR32QM9VGFSA16908", 125.65059507755127, 1, 4 },
                    { new Guid("870290ba-9223-4d8b-9e84-65478e892fa9"), null, 2, new Guid("bcd6b584-9e69-44ce-b51d-86da2b92c1ca"), 7367, "HGC2H6E0N9LY53551", 3220.9115362807884, 2, 0 },
                    { new Guid("8858203c-68e2-49ac-b9f7-cf8f48b15589"), null, 0, new Guid("bf80bd70-f83b-4f49-afea-63df41243d78"), 8772, "BSJAVTKTFKNI44769", 3199.079786950515, 0, 0 },
                    { new Guid("88a78a0c-f9c0-482c-a5c4-b6aeb832357a"), null, 3, new Guid("d8a70a3f-6c89-44a8-bed8-9ec5941808eb"), 2367, "LKTL8SMSQXG977873", 1074.8432114782549, 3, 5 },
                    { new Guid("8c56e425-5033-4eb8-a7e2-d56e0c2ae112"), null, 0, new Guid("994248b5-f049-4012-8b89-ffe0ca5dde6a"), 7444, "NJMA8RR1Z4YV77073", 571.8908835296761, 2, 4 },
                    { new Guid("8d49ab87-09c2-4682-87e5-62f79425cd8a"), null, 2, new Guid("e768ecab-0a8f-4246-a02d-dc9139d497dd"), 2534, "0GMT2OAOOFZK31840", 763.20326667379607, 2, 4 },
                    { new Guid("8e8c0827-4af2-4777-8419-d0a0fc07480a"), null, 3, new Guid("7f369d6d-3223-4e00-804e-29e7840396e6"), 9059, "094PVL9MSQF662429", 3459.6883628743371, 0, 0 },
                    { new Guid("91f0bb11-3296-4ec3-a07c-7bcee7808340"), null, 0, new Guid("691d0d40-2f3b-43f1-b392-6bf66a3d874a"), 3443, "5ZJR7FKQGVEH22486", 3873.2307881068082, 2, 1 },
                    { new Guid("9525c881-03ec-4e98-ad99-3054e0751349"), null, 2, new Guid("99ad68d2-f7ac-406e-a7e1-5e53999b33fc"), 3243, "YI04TFAXVOCJ68244", 881.40797034555612, 3, 0 },
                    { new Guid("957521d0-7401-4a2e-9988-85423b69ca64"), null, 2, new Guid("bcd6b584-9e69-44ce-b51d-86da2b92c1ca"), 8327, "9W693MR7Q1KH87915", 2069.5397979692834, 2, 4 },
                    { new Guid("959eaf0f-d2b1-4a7b-a96b-b6b24979374e"), null, 0, new Guid("aa3e71dc-c837-4988-8bb7-5e2566ba9b21"), 8503, "LMXLN32IPHET37605", 398.02769459953049, 1, 1 },
                    { new Guid("9b1882de-4e39-46ee-a838-7c28ab4481db"), null, 2, new Guid("63d7dc30-c83a-46cd-936b-254dc48173b4"), 3371, "86JTCNFPVQST78810", 3568.7460110709076, 0, 3 },
                    { new Guid("9ce84445-e620-4985-b66f-082d996a0bf6"), null, 2, new Guid("7f47c3ae-5071-462b-b02e-1365c7b96548"), 1392, "AUN00RU49OMW39696", 2667.1972214047087, 1, 3 },
                    { new Guid("a0082af5-d0c6-4e25-a896-09b66bb78661"), null, 0, new Guid("7f369d6d-3223-4e00-804e-29e7840396e6"), 6006, "FBVPU5QQLFL034993", 730.39903941640296, 0, 1 },
                    { new Guid("a02983d5-a2d0-4cba-8926-739596f33a3b"), null, 1, new Guid("774a072c-b689-41b3-aa0d-07d39b86c26d"), 660, "4W33U5OR1ECK61258", 2204.0351922044429, 1, 2 },
                    { new Guid("a269dd95-d7b2-4af3-af6c-4298d7ee1b17"), null, 3, new Guid("04c0fb3c-6a9d-4525-ae5c-0dda606c8442"), 6114, "85T1S5LU9RBW89273", 1378.8620877638898, 0, 3 },
                    { new Guid("a67fd14b-baed-48ea-9d23-c15263b9791a"), null, 1, new Guid("63d7dc30-c83a-46cd-936b-254dc48173b4"), 2400, "T9HMJU8R2AIP16392", 2508.981634326949, 0, 2 },
                    { new Guid("a859a4eb-61ee-404a-9533-086e2da71677"), null, 3, new Guid("acdf47e3-f257-4989-8c09-04f610d0a197"), 1275, "9MPPIXR26WY797092", 2555.4314260653732, 1, 0 },
                    { new Guid("ab4ac36b-459c-4186-b70a-8caa2333b1b0"), null, 1, new Guid("1ab2986f-184e-4c30-bba8-7ca6b68d4a63"), 556, "997OH2GFSNWP45409", 3750.0240590231838, 1, 3 },
                    { new Guid("ae98ba44-92f3-435c-b41a-210e55bc6971"), null, 2, new Guid("89fb2363-5303-49b2-8241-31c0d0a57240"), 5339, "P32ELO2LV5EV12511", 1149.209018070243, 0, 4 },
                    { new Guid("aed06558-2655-4a4c-836e-a8181a423143"), null, 1, new Guid("019f2d5e-c2c3-4e19-90d7-29b1e57ef74d"), 2881, "2VRBW0WNDMTR45245", 1299.0409716929362, 1, 5 },
                    { new Guid("af34876d-8cd8-4a21-8c70-8dd5d2306bb0"), null, 0, new Guid("7f369d6d-3223-4e00-804e-29e7840396e6"), 2678, "RIADZYAEY1ZG10509", 3741.8604139755107, 2, 2 },
                    { new Guid("afbcc840-b808-4799-9237-7fc267eead78"), null, 0, new Guid("aa3e71dc-c837-4988-8bb7-5e2566ba9b21"), 4191, "MS11NBJKA3TD14206", 3598.3268285102204, 1, 5 },
                    { new Guid("b31a6916-9ee7-4db3-a89b-3cd2f48c99aa"), null, 0, new Guid("774a072c-b689-41b3-aa0d-07d39b86c26d"), 6447, "R9P0SIQS1RTU97011", 3731.9061208468265, 0, 4 },
                    { new Guid("b6d495f9-de92-477d-b70d-cebf232114bb"), null, 2, new Guid("774a072c-b689-41b3-aa0d-07d39b86c26d"), 2278, "BC9TZB5YOQSE39756", 2357.3101377675594, 3, 5 },
                    { new Guid("bf604fb1-f45b-4c6e-990b-d92f833162af"), null, 0, new Guid("aa3e71dc-c837-4988-8bb7-5e2566ba9b21"), 4635, "96YJUPEGKNT789149", 3888.645263387692, 1, 3 },
                    { new Guid("bf870cfd-ddab-406f-83db-8db3e29a5781"), null, 0, new Guid("7f369d6d-3223-4e00-804e-29e7840396e6"), 1436, "ZVZFVCZ0B5S419782", 1815.5339011215913, 1, 1 },
                    { new Guid("c2067438-7752-40d0-8b4d-28002c02dcaf"), null, 0, new Guid("d8a70a3f-6c89-44a8-bed8-9ec5941808eb"), 7450, "E4SD3UAYG0DM64198", 2572.0312449513485, 3, 5 },
                    { new Guid("c8567a38-3eac-4471-a310-47a2238ef5aa"), null, 2, new Guid("acdf47e3-f257-4989-8c09-04f610d0a197"), 4477, "UCD0WXLWD7W517709", 2084.6526849290776, 1, 3 },
                    { new Guid("cc281cca-edc9-4387-9c04-cd3a1e68cb35"), null, 3, new Guid("3ae5efb5-eefb-41bb-97fc-2df40a72c8f1"), 6565, "U8T6C53V9NRD84498", 3369.2808966330504, 0, 3 },
                    { new Guid("cd124ce4-bc1c-4d1a-9f56-0c1434ab55b3"), null, 1, new Guid("1ab2986f-184e-4c30-bba8-7ca6b68d4a63"), 7130, "MSB1K2ZOTEKW29193", 1424.22742268101, 2, 0 },
                    { new Guid("cd83afe1-2070-4948-9f2c-2099548c553a"), null, 2, new Guid("994248b5-f049-4012-8b89-ffe0ca5dde6a"), 2103, "SXRY1A1KWVLH28668", 1003.9630257530916, 3, 2 },
                    { new Guid("cdc57dde-8e07-48a8-b4ef-88b6316bcd21"), null, 0, new Guid("a2e9ac92-8f98-467e-a128-ee5e8b04f7c8"), 7907, "6I71NV856QNA67683", 3519.8810803289089, 0, 3 },
                    { new Guid("ce2ec460-9c8a-420d-bb64-b23959cc140b"), null, 2, new Guid("bf80bd70-f83b-4f49-afea-63df41243d78"), 6453, "JOVGAO199HYG59527", 3502.7618542756704, 3, 2 },
                    { new Guid("d34a654d-4460-4f94-a89a-74093f717402"), null, 3, new Guid("c0f12b18-5b1c-486d-a622-709ad132b54a"), 7423, "Y84CUP1462EY74734", 1657.4270350714235, 2, 1 },
                    { new Guid("d5981632-bd29-40e8-911f-834de9129eca"), null, 2, new Guid("c0f12b18-5b1c-486d-a622-709ad132b54a"), 4961, "8B2EQI0FGER738415", 3500.7824176056793, 0, 2 },
                    { new Guid("d6637746-50d4-4f37-8892-ee316f82dca0"), null, 2, new Guid("691d0d40-2f3b-43f1-b392-6bf66a3d874a"), 1834, "D9HG7XATCKSM62677", 1877.5188459015651, 0, 2 },
                    { new Guid("d9507274-7479-4778-9c81-6d5bb90ece5e"), null, 1, new Guid("bd6dc88f-be42-4b5f-bbe4-576771e0890b"), 7949, "22CEC0WN1KND97541", 1657.0766130673831, 3, 0 },
                    { new Guid("dc2b4e73-869b-4fb2-87e2-1581127b1776"), null, 1, new Guid("04c0fb3c-6a9d-4525-ae5c-0dda606c8442"), 6405, "M4DU21B2U0S211368", 3308.6906607010978, 1, 4 },
                    { new Guid("e5815a7c-004e-4225-8875-2f0f299954b6"), null, 1, new Guid("a2e9ac92-8f98-467e-a128-ee5e8b04f7c8"), 6444, "CWX2QQMJNHPY37450", 1957.2832640692322, 2, 0 },
                    { new Guid("e66ebdf0-e20d-4dd8-9640-65c15b23a683"), null, 2, new Guid("39c8eb29-afa6-42a8-a75f-2473812a7e2c"), 349, "VC2UUXSQ5MO020021", 3553.8841497557764, 2, 1 },
                    { new Guid("f4a82858-7dc5-4199-9a4b-151bd7bcce28"), null, 3, new Guid("a4203fc0-04fe-4dad-9659-145c7d5eb161"), 1632, "CAJWAHP46YIB29330", 2264.912089788163, 1, 0 },
                    { new Guid("f57eece5-c05b-4385-971c-63269344f03e"), null, 0, new Guid("019f2d5e-c2c3-4e19-90d7-29b1e57ef74d"), 8144, "CLIWN756NTF155400", 3251.4638101919577, 1, 1 },
                    { new Guid("f72b99be-81c3-48cb-9235-229b967c16bb"), null, 2, new Guid("2a476438-4af4-4261-9696-8333b85da652"), 729, "J8HI5HM7VHTI41438", 1137.4082316726347, 1, 3 },
                    { new Guid("f75cb5d7-77d3-4c61-ae7a-206725c56214"), null, 2, new Guid("691d0d40-2f3b-43f1-b392-6bf66a3d874a"), 3049, "GN1NY8YCLQOT51856", 1016.3833134121318, 3, 1 },
                    { new Guid("f9819970-5dac-4929-a724-6f206ea59797"), null, 3, new Guid("a4203fc0-04fe-4dad-9659-145c7d5eb161"), 6036, "4VC3CUCE61RM72220", 3917.7873240705667, 2, 0 },
                    { new Guid("fc350745-93f5-45cc-bcf7-cf73e43a37ae"), null, 0, new Guid("c0f12b18-5b1c-486d-a622-709ad132b54a"), 1091, "81N6P1HGELD357660", 717.16298833411668, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("019f2d5e-c2c3-4e19-90d7-29b1e57ef74d"), new Guid("39f75f2f-d37c-4a20-a6f6-11f4481caf9e"), "Charger" },
                    { new Guid("04c0fb3c-6a9d-4525-ae5c-0dda606c8442"), new Guid("39f75f2f-d37c-4a20-a6f6-11f4481caf9e"), "Model T" },
                    { new Guid("1ab2986f-184e-4c30-bba8-7ca6b68d4a63"), new Guid("39c8cafb-e68d-4ed8-8657-59aa992be4d0"), "Civic" },
                    { new Guid("2a476438-4af4-4261-9696-8333b85da652"), new Guid("3d46b121-8c23-422a-b91c-4587f4f81e23"), "Taurus" },
                    { new Guid("39c8eb29-afa6-42a8-a75f-2473812a7e2c"), new Guid("39c8cafb-e68d-4ed8-8657-59aa992be4d0"), "Civic" },
                    { new Guid("3ae5efb5-eefb-41bb-97fc-2df40a72c8f1"), new Guid("63966981-4ee5-4504-a6c9-85fa38b7311e"), "Fiesta" },
                    { new Guid("63d7dc30-c83a-46cd-936b-254dc48173b4"), new Guid("3d46b121-8c23-422a-b91c-4587f4f81e23"), "2" },
                    { new Guid("691d0d40-2f3b-43f1-b392-6bf66a3d874a"), new Guid("834d8097-c842-4d2e-ab0b-808ccb4352f9"), "911" },
                    { new Guid("774a072c-b689-41b3-aa0d-07d39b86c26d"), new Guid("39f75f2f-d37c-4a20-a6f6-11f4481caf9e"), "V90" },
                    { new Guid("7f369d6d-3223-4e00-804e-29e7840396e6"), new Guid("39c8cafb-e68d-4ed8-8657-59aa992be4d0"), "Civic" },
                    { new Guid("7f47c3ae-5071-462b-b02e-1365c7b96548"), new Guid("63966981-4ee5-4504-a6c9-85fa38b7311e"), "Corvette" },
                    { new Guid("89fb2363-5303-49b2-8241-31c0d0a57240"), new Guid("63966981-4ee5-4504-a6c9-85fa38b7311e"), "Fiesta" },
                    { new Guid("994248b5-f049-4012-8b89-ffe0ca5dde6a"), new Guid("63966981-4ee5-4504-a6c9-85fa38b7311e"), "Beetle" },
                    { new Guid("99ad68d2-f7ac-406e-a7e1-5e53999b33fc"), new Guid("39c8cafb-e68d-4ed8-8657-59aa992be4d0"), "Model 3" },
                    { new Guid("a2e9ac92-8f98-467e-a128-ee5e8b04f7c8"), new Guid("3d46b121-8c23-422a-b91c-4587f4f81e23"), "Altima" },
                    { new Guid("a4203fc0-04fe-4dad-9659-145c7d5eb161"), new Guid("834d8097-c842-4d2e-ab0b-808ccb4352f9"), "LeBaron" },
                    { new Guid("aa3e71dc-c837-4988-8bb7-5e2566ba9b21"), new Guid("39c8cafb-e68d-4ed8-8657-59aa992be4d0"), "Colorado" },
                    { new Guid("acdf47e3-f257-4989-8c09-04f610d0a197"), new Guid("834d8097-c842-4d2e-ab0b-808ccb4352f9"), "Focus" },
                    { new Guid("bcd6b584-9e69-44ce-b51d-86da2b92c1ca"), new Guid("63966981-4ee5-4504-a6c9-85fa38b7311e"), "Fortwo" },
                    { new Guid("bd6dc88f-be42-4b5f-bbe4-576771e0890b"), new Guid("834d8097-c842-4d2e-ab0b-808ccb4352f9"), "A4" },
                    { new Guid("bf80bd70-f83b-4f49-afea-63df41243d78"), new Guid("39f75f2f-d37c-4a20-a6f6-11f4481caf9e"), "Element" },
                    { new Guid("c0f12b18-5b1c-486d-a622-709ad132b54a"), new Guid("3d46b121-8c23-422a-b91c-4587f4f81e23"), "Corvette" },
                    { new Guid("d8a70a3f-6c89-44a8-bed8-9ec5941808eb"), new Guid("39f75f2f-d37c-4a20-a6f6-11f4481caf9e"), "ATS" },
                    { new Guid("e768ecab-0a8f-4246-a02d-dc9139d497dd"), new Guid("834d8097-c842-4d2e-ab0b-808ccb4352f9"), "Element" },
                    { new Guid("e7eb530e-19cc-4ae9-8341-2961fea3a54c"), new Guid("3d46b121-8c23-422a-b91c-4587f4f81e23"), "Malibu" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_ManufacturerId",
                table: "CarModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CarModelId",
                table: "Vehicles",
                column: "CarModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
