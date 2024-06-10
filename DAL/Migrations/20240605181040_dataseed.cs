using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
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
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Manufacturers_ManufacturerId",
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
                    ModelId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"), "Chevrolet" },
                    { new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"), "Maserati" },
                    { new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"), "Ferrari" },
                    { new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"), "Maserati" },
                    { new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"), "Ford" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("059c5e66-a3ae-4332-a39f-681f4a1d0446"), new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"), "Durango" },
                    { new Guid("08550dfb-5a88-417d-a2f3-c6bc6c403f5b"), new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"), "Grand Cherokee" },
                    { new Guid("08c89363-6532-4d6e-a0fb-79379f5ab037"), new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"), "Model T" },
                    { new Guid("122b6900-cf7e-4c49-92df-d6b64ff1bcf8"), new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"), "Escalade" },
                    { new Guid("25875d23-c84e-4424-a9a6-87c8cff7651e"), new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"), "PT Cruiser" },
                    { new Guid("2825e346-cf00-49ea-b633-3e2b8d2d3836"), new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"), "Focus" },
                    { new Guid("2ef98c3f-8b73-4678-b999-57252df46867"), new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"), "Focus" },
                    { new Guid("35275ca3-d357-42a5-8a10-f786f3605b53"), new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"), "Mustang" },
                    { new Guid("355d8a76-ded2-4a54-a2c9-9302fe9098cf"), new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"), "Grand Caravan" },
                    { new Guid("35e1912d-df67-42c0-84aa-f3b72587f29a"), new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"), "LeBaron" },
                    { new Guid("3f6869cf-337e-4a1f-a45b-8118635529ce"), new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"), "CTS" },
                    { new Guid("59a1d690-ded6-4bec-a61f-25023064c3e9"), new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"), "Roadster" },
                    { new Guid("5f3aad52-7633-42ef-b71b-dab478e96004"), new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"), "Fiesta" },
                    { new Guid("6e2a0a7a-c11f-4bee-b54b-4ab60bcbea5a"), new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"), "Corvette" },
                    { new Guid("745838f6-5294-44bf-a53f-902b05e3f957"), new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"), "Countach" },
                    { new Guid("96844c89-ca04-4159-948e-4380adb2ef95"), new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"), "ATS" },
                    { new Guid("99c40c96-1c48-4ae3-967a-9e9eb94cf551"), new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"), "XTS" },
                    { new Guid("a14beb03-bb61-4661-b12c-5404ddb16a31"), new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"), "Altima" },
                    { new Guid("a87ccbaa-657c-4be0-b459-e52e3acc4bf1"), new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"), "Impala" },
                    { new Guid("be78c2ab-6c93-4e6e-8682-960475d04af3"), new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"), "A4" },
                    { new Guid("bf8a6b7c-0de1-41e9-ad26-c47019955a19"), new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"), "Taurus" },
                    { new Guid("d62d6ca6-e50e-4708-a25b-09bd9ca3d9d4"), new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"), "Challenger" },
                    { new Guid("e2e5c5be-6568-41f9-a2bb-f778222cf140"), new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"), "Prius" },
                    { new Guid("f032770c-7cb2-439d-9de6-ec8648c0459e"), new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"), "Model S" },
                    { new Guid("fae96621-6f94-4704-8a0a-2ba480cdd053"), new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"), "Jetta" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("032b868f-8e6a-4876-a2be-267a0b4e005b"), 1, new Guid("96844c89-ca04-4159-948e-4380adb2ef95"), 1517, "H68KM6K2S2T735442", 1312.0619559683425, 1, 4 },
                    { new Guid("046a7470-b7a5-4597-bd3d-f510abcab39d"), 3, new Guid("08550dfb-5a88-417d-a2f3-c6bc6c403f5b"), 6415, "NKVREC60V0H964823", 2836.7341662442977, 2, 0 },
                    { new Guid("088d59f7-594d-445f-8dbf-afad4e47abdd"), 1, new Guid("fae96621-6f94-4704-8a0a-2ba480cdd053"), 5315, "PDDA02UWNRC344091", 398.2742338699378, 2, 0 },
                    { new Guid("09534804-ece9-4c9f-a486-c10201751d8b"), 3, new Guid("745838f6-5294-44bf-a53f-902b05e3f957"), 3140, "1BTWEU2YYBYC28811", 1399.0383249926729, 2, 0 },
                    { new Guid("0b24714f-08e9-4ae7-87c9-d63b0c6c8690"), 3, new Guid("25875d23-c84e-4424-a9a6-87c8cff7651e"), 7457, "RSB3FXC8MAXS78201", 114.17945501973009, 0, 1 },
                    { new Guid("0bd13ef4-10bb-4a82-9b03-063ac598df31"), 2, new Guid("2825e346-cf00-49ea-b633-3e2b8d2d3836"), 3980, "EWUBRACTNNQ720466", 2634.83800244535, 3, 4 },
                    { new Guid("126c26d7-562f-4309-b4c8-09d5e4151d20"), 2, new Guid("35e1912d-df67-42c0-84aa-f3b72587f29a"), 5989, "XU053N1WJUC631687", 1672.6665311637601, 1, 2 },
                    { new Guid("130e7870-8aeb-44ff-a925-300ff88768b2"), 3, new Guid("122b6900-cf7e-4c49-92df-d6b64ff1bcf8"), 7561, "Y2WPNGY0CULW58017", 2897.7231142741844, 0, 3 },
                    { new Guid("153a4e76-6294-4607-85a9-c226cfb859b0"), 0, new Guid("2ef98c3f-8b73-4678-b999-57252df46867"), 2295, "5MEC5ODXFEWP40120", 2254.8549688789503, 2, 3 },
                    { new Guid("15dbf370-fbdc-4a2f-b744-e586475d4195"), 1, new Guid("059c5e66-a3ae-4332-a39f-681f4a1d0446"), 7937, "55C95OG58YMI10501", 3871.8795575071485, 1, 2 },
                    { new Guid("17d0eecc-9a2c-4491-b810-774923701c2d"), 3, new Guid("08c89363-6532-4d6e-a0fb-79379f5ab037"), 2076, "A4V5H2K0PVPL99740", 2666.7641392590631, 1, 3 },
                    { new Guid("1909097d-00cb-4994-859a-dda666b53392"), 2, new Guid("bf8a6b7c-0de1-41e9-ad26-c47019955a19"), 6035, "XDYD02CF7YOX77286", 161.82061815566715, 0, 3 },
                    { new Guid("1aea4615-8492-45f7-ac7a-63a999f09639"), 0, new Guid("08550dfb-5a88-417d-a2f3-c6bc6c403f5b"), 28, "HKSRTLBTCYII96654", 357.20822135817787, 3, 1 },
                    { new Guid("1c0f49c9-a9a6-4e9d-9312-a990ac7da3e0"), 2, new Guid("6e2a0a7a-c11f-4bee-b54b-4ab60bcbea5a"), 639, "3F4YUWOYSMRP59787", 2044.2961343564341, 3, 2 },
                    { new Guid("1e7ec0c2-37ca-480a-9fa5-a13a7b27c54d"), 3, new Guid("be78c2ab-6c93-4e6e-8682-960475d04af3"), 1518, "27A3KDF1YNQX48904", 3037.3348212480869, 1, 1 },
                    { new Guid("1f093440-fe67-4fb1-bce6-6327648d2d81"), 0, new Guid("bf8a6b7c-0de1-41e9-ad26-c47019955a19"), 8861, "4G8LTPGS0WRI99994", 428.80759374466572, 2, 3 },
                    { new Guid("1fb84f5b-1b5a-4e7c-b94b-edd42ac6e352"), 3, new Guid("5f3aad52-7633-42ef-b71b-dab478e96004"), 2931, "BZKZZ2Z5YQMK21422", 2615.8054974016804, 0, 0 },
                    { new Guid("235dd289-587f-40e0-ae1c-34e4bf09f59a"), 2, new Guid("bf8a6b7c-0de1-41e9-ad26-c47019955a19"), 9564, "V8HX2PK6PYY144749", 3611.636009535699, 0, 3 },
                    { new Guid("277c04f0-5534-43e9-9329-5fe3a686bcf2"), 3, new Guid("be78c2ab-6c93-4e6e-8682-960475d04af3"), 7341, "PCRTDAFS6GFV48842", 2425.1304228555396, 2, 4 },
                    { new Guid("290c9e80-2170-442d-8f12-7f13eddfb4e6"), 3, new Guid("fae96621-6f94-4704-8a0a-2ba480cdd053"), 775, "F5XDP1M6APH244815", 2684.2746996791457, 3, 2 },
                    { new Guid("2a98538b-8352-4ea7-8147-adadff39b88d"), 0, new Guid("35275ca3-d357-42a5-8a10-f786f3605b53"), 1672, "8BIEU3EVXIDC83259", 3021.6260291402368, 2, 1 },
                    { new Guid("2c58e172-2d2c-441b-85c4-0c227a77b226"), 2, new Guid("745838f6-5294-44bf-a53f-902b05e3f957"), 7686, "XRPNXGJOHFZE29804", 3599.6462321720196, 0, 1 },
                    { new Guid("31ecb0f5-0341-4b87-bc30-e8e582f21546"), 2, new Guid("be78c2ab-6c93-4e6e-8682-960475d04af3"), 8053, "ENSC5P042NB943002", 2196.4477314921469, 1, 1 },
                    { new Guid("33a08167-e1eb-41c2-aa32-1831ef4dd422"), 1, new Guid("e2e5c5be-6568-41f9-a2bb-f778222cf140"), 3982, "B5DEZZKAGMDM45844", 705.64048781643669, 2, 1 },
                    { new Guid("36b95d43-eaa4-4431-a368-5df47d845f2f"), 2, new Guid("e2e5c5be-6568-41f9-a2bb-f778222cf140"), 7119, "6Z8MTAZKO1CD88504", 2296.9060638783094, 1, 1 },
                    { new Guid("372371fc-7069-4538-88c0-a92581de3f53"), 3, new Guid("3f6869cf-337e-4a1f-a45b-8118635529ce"), 8046, "N976LHR1JQRU89385", 2149.3597757473426, 0, 5 },
                    { new Guid("382a564a-4d45-4047-9d2e-d7f66f6a711b"), 0, new Guid("5f3aad52-7633-42ef-b71b-dab478e96004"), 1272, "U1U596HCB0PQ59700", 1081.9877798153514, 3, 0 },
                    { new Guid("39a50889-1a71-4037-af66-26a31b5ed7b4"), 3, new Guid("745838f6-5294-44bf-a53f-902b05e3f957"), 739, "OCOD0GOEC5K664588", 1218.197452383851, 2, 2 },
                    { new Guid("3a2efff2-96dd-4d81-aa34-a383c63f3922"), 1, new Guid("2825e346-cf00-49ea-b633-3e2b8d2d3836"), 316, "7S1SUE335IM649485", 2104.0375249463905, 0, 0 },
                    { new Guid("3d3d5f43-e223-4acc-b274-a269cb80edb4"), 0, new Guid("a87ccbaa-657c-4be0-b459-e52e3acc4bf1"), 2651, "H0GH208XCEUA15950", 1736.3177433016904, 1, 3 },
                    { new Guid("401a8282-f667-4e27-b702-d4a62d85fded"), 0, new Guid("35275ca3-d357-42a5-8a10-f786f3605b53"), 6100, "AIPAEHCA9UGH72620", 2748.9102188106654, 0, 2 },
                    { new Guid("40cd9aa5-2b7e-4a2a-9080-89f8ca43efd9"), 0, new Guid("2ef98c3f-8b73-4678-b999-57252df46867"), 8039, "2U2WZIAEBLZS28025", 1173.6605165915569, 3, 4 },
                    { new Guid("41d3bb3d-085f-404a-9d03-7d5aa00cd966"), 3, new Guid("2825e346-cf00-49ea-b633-3e2b8d2d3836"), 1499, "8BXAIZ96Q3EB66012", 2589.8459567807358, 3, 4 },
                    { new Guid("4584a699-6814-441e-b1d7-d974822fb080"), 2, new Guid("5f3aad52-7633-42ef-b71b-dab478e96004"), 7478, "43GG8SKKNXFU78012", 3539.3867101181349, 3, 5 },
                    { new Guid("45925cfc-c82f-4d48-a97a-9a2c900c1d52"), 0, new Guid("f032770c-7cb2-439d-9de6-ec8648c0459e"), 9489, "1UYFRU9NB4LV13288", 211.44823166110314, 3, 3 },
                    { new Guid("4650edd4-c239-40d1-9996-2c034b6ef84b"), 1, new Guid("99c40c96-1c48-4ae3-967a-9e9eb94cf551"), 7930, "BM70CL5KCOJH73637", 1310.3277122799484, 2, 4 },
                    { new Guid("51a3382d-34a1-46c0-bed3-91bd8d5c3761"), 2, new Guid("745838f6-5294-44bf-a53f-902b05e3f957"), 6672, "BRSS4ZXI3SQV22265", 2856.8412461708417, 1, 2 },
                    { new Guid("52558c9f-3c52-4b07-912b-db71cb10a24e"), 3, new Guid("745838f6-5294-44bf-a53f-902b05e3f957"), 7905, "MYT5W4GMIWEF13245", 2102.1084938368977, 2, 3 },
                    { new Guid("532f1b4f-7713-4872-9ba5-532bf7d640b3"), 3, new Guid("08550dfb-5a88-417d-a2f3-c6bc6c403f5b"), 9883, "TS7UAR0SPQJ017346", 2214.689728181218, 2, 2 },
                    { new Guid("54684fd4-457e-435a-bfa5-09c9a23b6e85"), 1, new Guid("99c40c96-1c48-4ae3-967a-9e9eb94cf551"), 1303, "7NU93HFOKVNZ81932", 1013.5489899430978, 1, 2 },
                    { new Guid("54b44a54-f6ca-40be-b924-3d91e10e1548"), 1, new Guid("96844c89-ca04-4159-948e-4380adb2ef95"), 8648, "ZQ58ABLNPLSE17968", 424.2450258962092, 0, 2 },
                    { new Guid("57dc40b0-8fd0-406b-8aff-950c4bc689e8"), 1, new Guid("a87ccbaa-657c-4be0-b459-e52e3acc4bf1"), 1116, "43S4JDA8W1HX14609", 2762.2399487229804, 1, 3 },
                    { new Guid("5943ba8e-0207-44b0-8bca-5e5c52f0194f"), 2, new Guid("35275ca3-d357-42a5-8a10-f786f3605b53"), 9633, "9CD5W2MYCOOO64218", 1392.6118640446512, 1, 4 },
                    { new Guid("59d79065-e64d-4b1e-9d0d-1df0f878eef8"), 3, new Guid("059c5e66-a3ae-4332-a39f-681f4a1d0446"), 7930, "BOORHVJ4YUTM45991", 2449.5986399309445, 2, 3 },
                    { new Guid("5ea53211-02c8-4973-809c-750ccbc73419"), 2, new Guid("bf8a6b7c-0de1-41e9-ad26-c47019955a19"), 7133, "BUSNB0U4VNU379466", 3856.9014648299503, 2, 4 },
                    { new Guid("603aba0c-4476-402a-b861-b4e2b2cb40ed"), 1, new Guid("e2e5c5be-6568-41f9-a2bb-f778222cf140"), 2480, "59898MIAT8WR35740", 3604.7866465967154, 1, 3 },
                    { new Guid("603e0085-3c03-4ed3-aa3d-2e5abec75b40"), 3, new Guid("2ef98c3f-8b73-4678-b999-57252df46867"), 7514, "46DRET48LYIQ83534", 3781.9007566954656, 3, 5 },
                    { new Guid("6199b535-8fba-4f5c-b81b-fbe346ab8849"), 2, new Guid("f032770c-7cb2-439d-9de6-ec8648c0459e"), 5187, "7PCYN1G6M5R120158", 1667.5586324729634, 3, 2 },
                    { new Guid("6235e713-4d9c-48f8-8669-2c7f829ff89e"), 0, new Guid("fae96621-6f94-4704-8a0a-2ba480cdd053"), 283, "GKGG5EY4UCF539908", 1399.2736897247091, 1, 1 },
                    { new Guid("67cd3aff-ce12-4048-abfe-733bc1303a42"), 1, new Guid("a14beb03-bb61-4661-b12c-5404ddb16a31"), 2732, "59628PDQH6IU78767", 2275.5512224349609, 1, 3 },
                    { new Guid("67f60de1-3a42-438f-815f-cb4316953a97"), 1, new Guid("fae96621-6f94-4704-8a0a-2ba480cdd053"), 7497, "T9YAQ3KFOEJC86009", 786.95979066570783, 2, 3 },
                    { new Guid("6b866b81-b3b5-4e98-817e-a864fca75f16"), 3, new Guid("f032770c-7cb2-439d-9de6-ec8648c0459e"), 5419, "Y8TBOQXAUYV448720", 872.30105674260619, 1, 1 },
                    { new Guid("6ce9a573-32da-4186-9753-b9ceade93551"), 2, new Guid("99c40c96-1c48-4ae3-967a-9e9eb94cf551"), 9166, "QWJ3Q6MDR3W144171", 120.0778896438144, 3, 2 },
                    { new Guid("752fb4c1-673b-476e-9473-89dfde17d025"), 0, new Guid("d62d6ca6-e50e-4708-a25b-09bd9ca3d9d4"), 2129, "MTS60BCGRNZD76627", 2910.7268570859414, 2, 2 },
                    { new Guid("76065e0b-19ba-430e-9ba3-fd6acc9bf17f"), 3, new Guid("122b6900-cf7e-4c49-92df-d6b64ff1bcf8"), 9257, "IH64C7WWG2FA59032", 3774.4834260558559, 3, 4 },
                    { new Guid("783575f9-6f31-4ca8-892e-a058be11619b"), 2, new Guid("3f6869cf-337e-4a1f-a45b-8118635529ce"), 9292, "8O9XP9QPF1TY98175", 163.48289760095571, 3, 2 },
                    { new Guid("7ad42b36-0dae-4318-b527-b2757240394a"), 3, new Guid("96844c89-ca04-4159-948e-4380adb2ef95"), 5205, "YUXP5BIFXUL971939", 3083.279156704863, 0, 1 },
                    { new Guid("7b11e8f1-d65c-404e-a2b7-a2d12331adca"), 1, new Guid("bf8a6b7c-0de1-41e9-ad26-c47019955a19"), 1618, "1M428O80DRLP30540", 3017.5976902756224, 1, 5 },
                    { new Guid("7cb666ea-79eb-42b2-b20b-a2171a9a553a"), 0, new Guid("99c40c96-1c48-4ae3-967a-9e9eb94cf551"), 774, "2B1MIWJ65ZYI26377", 442.90873240703496, 2, 1 },
                    { new Guid("7ff31899-8b8b-41a9-922d-9371b9856232"), 3, new Guid("08550dfb-5a88-417d-a2f3-c6bc6c403f5b"), 1574, "9T629504BOTU13432", 2543.0780993565168, 0, 5 },
                    { new Guid("80a82c5b-e697-43f2-96db-62d88c6c0d8c"), 1, new Guid("08c89363-6532-4d6e-a0fb-79379f5ab037"), 628, "R3TUZ3VVEHV710179", 585.61583082079039, 0, 1 },
                    { new Guid("821ab2da-fa1f-4120-8965-50a919525a95"), 2, new Guid("6e2a0a7a-c11f-4bee-b54b-4ab60bcbea5a"), 7655, "TGFL3QBBMGXW67502", 2817.432693311614, 0, 1 },
                    { new Guid("85a56cf8-ce09-4339-a1d1-75e00174296d"), 3, new Guid("96844c89-ca04-4159-948e-4380adb2ef95"), 5989, "SO0XPTXFZ6VT82512", 2960.736011094727, 0, 4 },
                    { new Guid("862990df-ebb9-4758-a31f-65421c5d9c94"), 1, new Guid("08550dfb-5a88-417d-a2f3-c6bc6c403f5b"), 1069, "Z5JEDRGI1BYL52313", 3121.6674963584956, 2, 0 },
                    { new Guid("875961fb-09e3-481f-98c6-9e77d2a1cb25"), 0, new Guid("08c89363-6532-4d6e-a0fb-79379f5ab037"), 7395, "U5MTP4YD7AXH99797", 2101.4586028706035, 3, 0 },
                    { new Guid("8b27699a-e9d1-4e93-8baf-0fe50699aecc"), 1, new Guid("25875d23-c84e-4424-a9a6-87c8cff7651e"), 2820, "PV7M8QHVS6ET16347", 686.12034610063438, 3, 2 },
                    { new Guid("8dbffae7-2862-4159-a55b-6f0875ef7c49"), 0, new Guid("d62d6ca6-e50e-4708-a25b-09bd9ca3d9d4"), 8992, "DAO53HDZWRNV87230", 2038.6010245583157, 3, 0 },
                    { new Guid("8e0d97a0-8625-4486-b7a2-6cd8901de96f"), 3, new Guid("355d8a76-ded2-4a54-a2c9-9302fe9098cf"), 6687, "WMF8PTLVRCUU52471", 2937.237912849027, 0, 3 },
                    { new Guid("8e88e16c-64c2-4bdf-9cbd-d64a62945729"), 1, new Guid("5f3aad52-7633-42ef-b71b-dab478e96004"), 2733, "PI51MIAYWBVU69693", 259.62006984990222, 0, 0 },
                    { new Guid("8eab7b68-e2a4-4fa3-a2ae-0366f7bd6477"), 0, new Guid("25875d23-c84e-4424-a9a6-87c8cff7651e"), 6934, "33O1THTT9HPS24420", 2679.9890633115474, 1, 3 },
                    { new Guid("910eb90f-32d4-47c2-91d5-4aa6b94614aa"), 0, new Guid("122b6900-cf7e-4c49-92df-d6b64ff1bcf8"), 3086, "M7FFHQP36EGL33295", 3130.058083074126, 0, 3 },
                    { new Guid("92ed7d9f-a2f4-4738-b77d-7e8de60613e4"), 2, new Guid("35e1912d-df67-42c0-84aa-f3b72587f29a"), 522, "83X0SLTGLNA317887", 3861.9377849882485, 2, 1 },
                    { new Guid("991e672b-89ba-4774-a249-11677c445949"), 1, new Guid("6e2a0a7a-c11f-4bee-b54b-4ab60bcbea5a"), 10, "TERUTIGV5LBF66353", 3047.2114827182741, 0, 0 },
                    { new Guid("9aa381c1-b981-4157-9200-4b4efd255777"), 2, new Guid("a87ccbaa-657c-4be0-b459-e52e3acc4bf1"), 7091, "QHSKEBCU75HF61540", 2786.2045402908711, 1, 5 },
                    { new Guid("9ebf6281-871b-4ad7-874f-39ba86391f24"), 0, new Guid("35e1912d-df67-42c0-84aa-f3b72587f29a"), 3736, "TP8FGWORMTXT62098", 2997.0766767286905, 0, 1 },
                    { new Guid("a01a76ff-aadf-425d-98f7-051cfcf80a95"), 2, new Guid("6e2a0a7a-c11f-4bee-b54b-4ab60bcbea5a"), 3172, "QE16OKVM37Q334500", 975.08730381910618, 2, 3 },
                    { new Guid("a0feab96-b8c5-49eb-ac7f-e453bcd9b5d4"), 0, new Guid("35e1912d-df67-42c0-84aa-f3b72587f29a"), 8353, "2WKI5KXDWGWA54693", 2330.9545493445848, 1, 5 },
                    { new Guid("a25437ef-62a4-4789-8702-36eca223937b"), 3, new Guid("059c5e66-a3ae-4332-a39f-681f4a1d0446"), 8541, "V1U55I64W0E030458", 3295.5781121558034, 1, 4 },
                    { new Guid("a316f629-d98d-46e4-b048-a2b0af0d5a60"), 0, new Guid("f032770c-7cb2-439d-9de6-ec8648c0459e"), 9768, "5XJTGM6BF8A484695", 2452.0689805224765, 0, 3 },
                    { new Guid("a34a8489-965c-4598-b0d3-3b5dee545840"), 2, new Guid("d62d6ca6-e50e-4708-a25b-09bd9ca3d9d4"), 949, "CL6RAW5387YO69772", 109.93868066439211, 2, 4 },
                    { new Guid("a494bb83-9873-42ed-b1ab-38caf68787bc"), 0, new Guid("2825e346-cf00-49ea-b633-3e2b8d2d3836"), 1266, "ZCN60D6D53AW18260", 3728.8266864795214, 0, 2 },
                    { new Guid("a4ccd972-df23-464f-a9bd-92e887d11a55"), 2, new Guid("e2e5c5be-6568-41f9-a2bb-f778222cf140"), 9998, "54OUA460M1QY18350", 869.26260454279588, 0, 5 },
                    { new Guid("a581e9a9-1d34-4434-b366-32c889480a2c"), 3, new Guid("355d8a76-ded2-4a54-a2c9-9302fe9098cf"), 9748, "BEHMTAE4RTUB89083", 669.83855523696002, 3, 0 },
                    { new Guid("a71936ed-e259-4125-8f2f-c0366966a4bf"), 3, new Guid("355d8a76-ded2-4a54-a2c9-9302fe9098cf"), 6653, "J2H5AC2E8OH512721", 243.78211553567314, 2, 0 },
                    { new Guid("a8fe9edb-9334-42a9-acfd-cdb7d7cd424d"), 2, new Guid("59a1d690-ded6-4bec-a61f-25023064c3e9"), 9691, "01QS73LQVUA327570", 3103.9532636332624, 3, 0 },
                    { new Guid("a942b0c5-5f7a-45d2-a3a8-b11be52c293d"), 3, new Guid("a14beb03-bb61-4661-b12c-5404ddb16a31"), 5968, "AVNS6JREP9KG30722", 1160.6863277306613, 2, 1 },
                    { new Guid("ad2bd5cb-e53e-45ed-9781-a6876e7de9d6"), 3, new Guid("be78c2ab-6c93-4e6e-8682-960475d04af3"), 2962, "WTBGRS7X4XG548542", 3475.5079148624886, 0, 0 },
                    { new Guid("aed4b545-1def-4421-a085-1bbd77a8a8ab"), 0, new Guid("a14beb03-bb61-4661-b12c-5404ddb16a31"), 2722, "2G8JUZZOH7P093423", 972.32172204823723, 0, 3 },
                    { new Guid("afa09279-398c-4730-ae4f-5058cb4f7cbd"), 0, new Guid("59a1d690-ded6-4bec-a61f-25023064c3e9"), 5258, "45DTFRYLA7D456238", 3010.3353091897898, 0, 3 },
                    { new Guid("b184a513-69ee-4d7b-be41-0c4fac77f72b"), 3, new Guid("a14beb03-bb61-4661-b12c-5404ddb16a31"), 713, "QF2S7MKS4SO643049", 1097.0409477601488, 0, 1 },
                    { new Guid("b894a0f5-b2a7-4c59-a23c-a13eca140480"), 0, new Guid("59a1d690-ded6-4bec-a61f-25023064c3e9"), 3081, "BJHG2VNI3PEG11954", 2229.8049051967723, 1, 4 },
                    { new Guid("b8e1aa2e-f6a6-476d-b652-9df8a7dc42ab"), 1, new Guid("355d8a76-ded2-4a54-a2c9-9302fe9098cf"), 6667, "ONSBYL240VD552359", 3208.9674445181595, 0, 1 },
                    { new Guid("b9f6bba7-6e6a-437e-9d43-ab3444b7c142"), 1, new Guid("99c40c96-1c48-4ae3-967a-9e9eb94cf551"), 8930, "GQXY2IX5C4VP90874", 580.10915391807453, 0, 2 },
                    { new Guid("bc1fc5f5-3311-46e3-ae44-e7318a3ca220"), 2, new Guid("059c5e66-a3ae-4332-a39f-681f4a1d0446"), 4539, "Z2OWKV550NVQ55717", 474.51560009212017, 0, 2 },
                    { new Guid("bc6483a2-3fe7-4095-a78c-7056881fecd6"), 3, new Guid("122b6900-cf7e-4c49-92df-d6b64ff1bcf8"), 1010, "L2MYCZ3KPMH581847", 2877.3731785795126, 1, 2 },
                    { new Guid("be1efdaa-974e-4adf-8287-b32f4644e8f4"), 0, new Guid("a14beb03-bb61-4661-b12c-5404ddb16a31"), 5621, "KT37RGPY7KO791043", 3418.26135243197, 3, 0 },
                    { new Guid("c14cafd5-8f30-48af-8e74-ab3d4251e880"), 0, new Guid("59a1d690-ded6-4bec-a61f-25023064c3e9"), 5974, "H34OFS9V3NQD36083", 3213.601208288715, 1, 3 },
                    { new Guid("c171b130-7ff9-47b7-980b-a3b764627dc4"), 3, new Guid("96844c89-ca04-4159-948e-4380adb2ef95"), 3301, "B6U64ZMSY1FZ70725", 3521.2900087605935, 0, 5 },
                    { new Guid("c6a7a84f-7730-44b2-bda1-3397718d31f9"), 0, new Guid("35e1912d-df67-42c0-84aa-f3b72587f29a"), 2050, "9N7WW5S9S0F238867", 2715.453666335763, 1, 3 },
                    { new Guid("c90d8798-4b04-4c57-90b8-f7a820738d9c"), 3, new Guid("122b6900-cf7e-4c49-92df-d6b64ff1bcf8"), 4614, "0HQ7DBXE3QBG18168", 2987.8725962067729, 1, 5 },
                    { new Guid("c91dc273-e92a-4824-9260-529feb8f4168"), 2, new Guid("2825e346-cf00-49ea-b633-3e2b8d2d3836"), 570, "7HRG4FIMAKQG11061", 3144.6369977438894, 3, 3 },
                    { new Guid("c9a7727f-764d-403a-99b9-3e63aadfc43e"), 0, new Guid("be78c2ab-6c93-4e6e-8682-960475d04af3"), 3935, "1WLTVB65NEZ325185", 3171.6520094959592, 3, 5 },
                    { new Guid("ccc11fee-830b-4e6c-a175-9045d02a8f7d"), 3, new Guid("2ef98c3f-8b73-4678-b999-57252df46867"), 4607, "Z949Q80YDEIL14303", 1757.2072969435874, 0, 1 },
                    { new Guid("d14f420b-1a7b-4df2-adfb-54f6368499f2"), 2, new Guid("25875d23-c84e-4424-a9a6-87c8cff7651e"), 3045, "4880YVBQFXWW53062", 1128.6610511450922, 2, 2 },
                    { new Guid("d2586236-b23b-4349-82b7-73d77d7ed682"), 3, new Guid("a87ccbaa-657c-4be0-b459-e52e3acc4bf1"), 197, "P4NAJV9JWWPY85215", 3231.4426839029566, 0, 0 },
                    { new Guid("d41092cf-c2e5-49d7-af24-3fe4b79df0fa"), 1, new Guid("059c5e66-a3ae-4332-a39f-681f4a1d0446"), 6121, "W75X0VYIURJO78287", 2536.3826321120332, 3, 0 },
                    { new Guid("d6220782-6f86-401f-8e39-193c032f3128"), 0, new Guid("fae96621-6f94-4704-8a0a-2ba480cdd053"), 395, "Q1LX3414CJX655448", 1979.693925110158, 0, 4 },
                    { new Guid("d7279ce8-6e50-4377-9409-4e7652631698"), 3, new Guid("59a1d690-ded6-4bec-a61f-25023064c3e9"), 9872, "K9JBA8AJR8O894424", 2506.3544825747135, 0, 0 },
                    { new Guid("dc91dc90-2591-4bc7-a817-3882a722fb63"), 3, new Guid("5f3aad52-7633-42ef-b71b-dab478e96004"), 9112, "0XUARIXFL8BP43993", 3493.3291512813144, 0, 0 },
                    { new Guid("de89ca38-81bd-4c5d-b0ea-22ac453738e7"), 2, new Guid("a87ccbaa-657c-4be0-b459-e52e3acc4bf1"), 6516, "WP4HQQ9B3EAD94883", 2109.3757330157277, 0, 3 },
                    { new Guid("df12b93a-da77-4795-9f84-d50a0eda2a80"), 0, new Guid("25875d23-c84e-4424-a9a6-87c8cff7651e"), 8328, "S5P5WGBPHKWR69108", 1739.5910918352822, 1, 3 },
                    { new Guid("e09acd55-4f8b-406d-98d0-d7962e1d406e"), 3, new Guid("3f6869cf-337e-4a1f-a45b-8118635529ce"), 4363, "GZ0ZZYPIVLEU72984", 606.77378938979746, 3, 0 },
                    { new Guid("e732d8ae-0bf1-4cfe-acac-6b52103ada64"), 2, new Guid("2ef98c3f-8b73-4678-b999-57252df46867"), 2395, "AKDC8WGVGXHY78022", 2759.7491637375092, 3, 1 },
                    { new Guid("e7c34660-beaf-4a8c-93bf-b6b374ad43fc"), 2, new Guid("f032770c-7cb2-439d-9de6-ec8648c0459e"), 7723, "CDMDDL8795FB32271", 865.03099615819269, 2, 0 },
                    { new Guid("eaf8c308-4afe-4f6d-902c-6ad79911862d"), 0, new Guid("6e2a0a7a-c11f-4bee-b54b-4ab60bcbea5a"), 5513, "92ZNT3Y2PWCX95816", 889.86081322826237, 3, 4 },
                    { new Guid("edf67d77-5289-44eb-bd4f-262bc5603a57"), 1, new Guid("d62d6ca6-e50e-4708-a25b-09bd9ca3d9d4"), 210, "SEG5BIJXKHGO76739", 3721.1326076818045, 2, 3 },
                    { new Guid("ef0ad918-3479-4b6a-bd58-1ab894ef5696"), 0, new Guid("d62d6ca6-e50e-4708-a25b-09bd9ca3d9d4"), 4151, "G9RQXJCRRRT252529", 2301.7436126941188, 3, 1 },
                    { new Guid("f1bbf45d-5bd1-4704-9295-1849cc4a8dbd"), 3, new Guid("08c89363-6532-4d6e-a0fb-79379f5ab037"), 1907, "PBGL7Z0NF1KQ75389", 1227.3233303220388, 0, 3 },
                    { new Guid("f20df682-b95f-4380-a75b-f29afa611274"), 0, new Guid("35275ca3-d357-42a5-8a10-f786f3605b53"), 9217, "2N513GJMW4GY52622", 3571.3893778245142, 2, 4 },
                    { new Guid("f603ea04-6957-45bc-b6b4-bd177605fd38"), 0, new Guid("08c89363-6532-4d6e-a0fb-79379f5ab037"), 9359, "73N4HY8KS4M170140", 2501.6788170721397, 0, 5 },
                    { new Guid("f8977078-5ae9-4812-9bc8-23fba9855945"), 0, new Guid("e2e5c5be-6568-41f9-a2bb-f778222cf140"), 1825, "V9PPCAQMLIZW62807", 3785.3962400454825, 3, 3 },
                    { new Guid("f8a3ff7d-29ce-4efc-86a2-a5c06094800f"), 1, new Guid("3f6869cf-337e-4a1f-a45b-8118635529ce"), 2540, "7R8QDNBZQJRB59029", 3757.5298722041171, 1, 5 },
                    { new Guid("fc3a5ad4-9d3b-49ed-ab47-faf44f44dda6"), 0, new Guid("355d8a76-ded2-4a54-a2c9-9302fe9098cf"), 2598, "6CJNCC17T8HU49003", 470.12074464371381, 2, 5 },
                    { new Guid("fe9a117d-9f79-4df0-8a20-95a0f19dcc07"), 1, new Guid("35275ca3-d357-42a5-8a10-f786f3605b53"), 2890, "ZKWAAWY2AONP35739", 2123.8607116398571, 0, 4 },
                    { new Guid("fee773d9-287f-4326-abf5-6853fb7fb2d6"), 2, new Guid("3f6869cf-337e-4a1f-a45b-8118635529ce"), 4127, "4WQ6WXJ6JNR277217", 2244.9368382047373, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("0119077f-bdee-4393-9351-a9ab104b1513"), "Russ_Rath@yahoo.com", "Hardy", "Aufderhar", "1-255-773-4863 x923", new Guid("54684fd4-457e-435a-bfa5-09c9a23b6e85") },
                    { new Guid("051f95b6-954b-4028-99da-f919779e95aa"), "Earnest.Reilly26@gmail.com", "Benny", "Streich", "(656) 728-1920", new Guid("d14f420b-1a7b-4df2-adfb-54f6368499f2") },
                    { new Guid("06fe5674-1fb6-4384-9f5c-7a54b22a863f"), "Mark_Russel42@yahoo.com", "Brandt", "Veum", "446-458-4649 x05067", new Guid("0b24714f-08e9-4ae7-87c9-d63b0c6c8690") },
                    { new Guid("07c41577-1d81-4e0b-a86b-fb9b2219d780"), "Carolyne.Bode@gmail.com", "Jayde", "Howell", "343-490-2588 x50937", new Guid("85a56cf8-ce09-4339-a1d1-75e00174296d") },
                    { new Guid("116e0057-c66e-44ae-a733-7b5a0ebbdd40"), "Sincere_Roob@hotmail.com", "Tyree", "DuBuque", "522-696-2247 x795", new Guid("126c26d7-562f-4309-b4c8-09d5e4151d20") },
                    { new Guid("122a9387-b22c-41c1-8dda-8dee05045e50"), "Gisselle76@gmail.com", "Ole", "Reichel", "789-469-0656 x03934", new Guid("8eab7b68-e2a4-4fa3-a2ae-0366f7bd6477") },
                    { new Guid("12bef98d-6f68-41be-b745-43f6a83fc67c"), "Earlene15@hotmail.com", "Maiya", "Maggio", "581.572.6463 x09468", new Guid("277c04f0-5534-43e9-9329-5fe3a686bcf2") },
                    { new Guid("1998aabe-f5e8-4864-91e0-c9a705106683"), "Treva.Pouros@yahoo.com", "Cesar", "Bins", "494-549-8596 x1340", new Guid("be1efdaa-974e-4adf-8287-b32f4644e8f4") },
                    { new Guid("1a62ac3f-31de-4e01-88d6-825c43104719"), "Aliya8@gmail.com", "Lemuel", "Johns", "(520) 480-4308", new Guid("8e0d97a0-8625-4486-b7a2-6cd8901de96f") },
                    { new Guid("1d11ba86-6d69-4be6-b33c-16978565867f"), "Octavia44@hotmail.com", "Kitty", "Graham", "(536) 509-0201 x67017", new Guid("1909097d-00cb-4994-859a-dda666b53392") },
                    { new Guid("1f8f1033-f851-430b-8af6-6598b689a234"), "Skye.Hartmann9@yahoo.com", "Celestino", "Pouros", "827-592-3262 x845", new Guid("046a7470-b7a5-4597-bd3d-f510abcab39d") },
                    { new Guid("1fc7dc7f-4deb-46d3-a6d3-0f968a407339"), "Noe_Weissnat54@hotmail.com", "Emmalee", "Bogan", "1-552-324-8757 x55721", new Guid("fe9a117d-9f79-4df0-8a20-95a0f19dcc07") },
                    { new Guid("226d1fba-8841-4531-b42a-822aeabeea6d"), "Lonnie.Bosco@gmail.com", "Jalon", "Hackett", "1-822-863-3159", new Guid("fee773d9-287f-4326-abf5-6853fb7fb2d6") },
                    { new Guid("228c2690-ddf0-4388-a33c-bdf71a3e67de"), "Audra.Kozey@gmail.com", "Larry", "Batz", "595-534-3625 x5100", new Guid("fc3a5ad4-9d3b-49ed-ab47-faf44f44dda6") },
                    { new Guid("2497b6f5-9463-4ead-a2b3-eb499f441529"), "Mathias.Glover@hotmail.com", "Marilou", "McKenzie", "351.522.3359", new Guid("4584a699-6814-441e-b1d7-d974822fb080") },
                    { new Guid("25911b64-2819-49a3-ac59-dd86ebee95fa"), "Dakota.Will85@gmail.com", "Julianne", "Romaguera", "852.675.0312 x93244", new Guid("76065e0b-19ba-430e-9ba3-fd6acc9bf17f") },
                    { new Guid("26b544c7-9bf5-4904-b6a5-bd544a5d955a"), "Deangelo.Carter@yahoo.com", "Shyanne", "Altenwerth", "(393) 835-1952", new Guid("f603ea04-6957-45bc-b6b4-bd177605fd38") },
                    { new Guid("27e2cbd1-d9e4-478d-899c-7eea09f29292"), "Ethel3@hotmail.com", "Daija", "Altenwerth", "895.525.9097", new Guid("e09acd55-4f8b-406d-98d0-d7962e1d406e") },
                    { new Guid("2d60e186-c218-4619-a378-fcc84a4738e1"), "Toni98@gmail.com", "Magdalena", "Kirlin", "1-388-773-5317", new Guid("f20df682-b95f-4380-a75b-f29afa611274") },
                    { new Guid("2dcf406c-aeac-4e08-b955-69acc825b5f1"), "Carroll20@gmail.com", "Nicole", "Heathcote", "1-384-849-6311 x00689", new Guid("3d3d5f43-e223-4acc-b274-a269cb80edb4") },
                    { new Guid("2e4850eb-fdcb-42c9-ac19-4f0115e94a72"), "Blake30@yahoo.com", "Frederic", "Boyer", "694-801-2474 x82532", new Guid("c14cafd5-8f30-48af-8e74-ab3d4251e880") },
                    { new Guid("369f591d-922a-4a15-8551-0cddd8656981"), "Marilyne76@yahoo.com", "Darren", "Parisian", "(883) 502-4059 x77461", new Guid("603e0085-3c03-4ed3-aa3d-2e5abec75b40") },
                    { new Guid("3a32d2f4-759b-42bb-8fdd-1c12cecb9351"), "Gilda54@yahoo.com", "Jeanie", "Cronin", "623.529.9647 x7127", new Guid("a01a76ff-aadf-425d-98f7-051cfcf80a95") },
                    { new Guid("3cf83c26-44a0-4911-8faf-974c2c67776d"), "Constance99@yahoo.com", "Lon", "Padberg", "1-404-238-8184", new Guid("372371fc-7069-4538-88c0-a92581de3f53") },
                    { new Guid("3d2a8918-6f86-4ca3-8c8e-ed00db6d2b52"), "Hershel_Ondricka@hotmail.com", "Raul", "Effertz", "738.621.6762", new Guid("9ebf6281-871b-4ad7-874f-39ba86391f24") },
                    { new Guid("3db246e1-ee5c-40a8-87c8-ff40f7567a54"), "Trystan.Willms@gmail.com", "Guy", "Grady", "1-854-572-9174 x14816", new Guid("e7c34660-beaf-4a8c-93bf-b6b374ad43fc") },
                    { new Guid("3f48f497-dac0-44d2-b5db-da2ed25e5dc1"), "Brisa58@gmail.com", "Beverly", "Metz", "240-800-9676 x99126", new Guid("a0feab96-b8c5-49eb-ac7f-e453bcd9b5d4") },
                    { new Guid("433c42d5-6f4b-4b3c-96bb-ef201c9a37e0"), "Violette.Kovacek39@hotmail.com", "Hilton", "Dare", "960.269.1286", new Guid("36b95d43-eaa4-4431-a368-5df47d845f2f") },
                    { new Guid("43a56e64-b359-4f71-845e-580db04d9490"), "Garrick55@yahoo.com", "Elta", "Reilly", "(360) 305-0633", new Guid("032b868f-8e6a-4876-a2be-267a0b4e005b") },
                    { new Guid("48f2f1b6-0a7d-4a08-918e-6b4752adc4f4"), "Oliver_Mann25@yahoo.com", "Kariane", "Davis", "1-352-980-2775", new Guid("130e7870-8aeb-44ff-a925-300ff88768b2") },
                    { new Guid("49c59f3d-ed36-4880-8af8-e2967892870a"), "Robert_Schiller34@hotmail.com", "Blake", "Willms", "989-569-3752 x2024", new Guid("eaf8c308-4afe-4f6d-902c-6ad79911862d") },
                    { new Guid("5006167d-171b-4675-b85a-11c55ff7cfb6"), "Quincy.Nader99@hotmail.com", "Lester", "Koelpin", "1-732-382-6544 x900", new Guid("b8e1aa2e-f6a6-476d-b652-9df8a7dc42ab") },
                    { new Guid("51abeffc-7937-4a03-99e2-2e7829a7a0b5"), "Leonor.Stark@yahoo.com", "Augusta", "Grant", "1-866-799-7452 x817", new Guid("862990df-ebb9-4758-a31f-65421c5d9c94") },
                    { new Guid("523f330e-a21b-42f9-bad4-92f94709de47"), "Abbigail_Ferry11@yahoo.com", "Jacques", "Rolfson", "(634) 816-9662 x66552", new Guid("df12b93a-da77-4795-9f84-d50a0eda2a80") },
                    { new Guid("59c7a731-ed02-4e17-bd86-9154208d0cdf"), "Marcelle_Pouros@yahoo.com", "Priscilla", "Bergnaum", "778.436.8342 x98029", new Guid("a494bb83-9873-42ed-b1ab-38caf68787bc") },
                    { new Guid("5ac53b99-3171-4319-9b29-e96b18f39bd1"), "Dax94@hotmail.com", "Angelo", "Frami", "1-892-343-5669", new Guid("9aa381c1-b981-4157-9200-4b4efd255777") },
                    { new Guid("5b680b5d-362b-48ee-a4f1-b63fb4529a86"), "Ericka64@hotmail.com", "Ethel", "Huel", "1-323-355-5256 x575", new Guid("6235e713-4d9c-48f8-8669-2c7f829ff89e") },
                    { new Guid("5b792803-bcf5-4bce-9fc4-a34ad75df41b"), "Berenice.Hills@yahoo.com", "Darryl", "Marks", "878-942-5484 x435", new Guid("0bd13ef4-10bb-4a82-9b03-063ac598df31") },
                    { new Guid("5df75aa5-8492-4ece-96f9-b00f24a69de0"), "Kaleigh.Willms@hotmail.com", "Mario", "Runolfsdottir", "1-543-308-5417", new Guid("67cd3aff-ce12-4048-abfe-733bc1303a42") },
                    { new Guid("5eac2099-f813-43d5-a7fe-3f3d79e8cbea"), "Alvena89@hotmail.com", "Kadin", "Sawayn", "260-586-1862 x540", new Guid("52558c9f-3c52-4b07-912b-db71cb10a24e") },
                    { new Guid("6063a634-204a-4317-bbbf-4744a855483b"), "Olin10@yahoo.com", "Esmeralda", "Wunsch", "581.797.3639 x42259", new Guid("c90d8798-4b04-4c57-90b8-f7a820738d9c") },
                    { new Guid("60b6c491-b00e-4278-8c66-f61c1c4dab2f"), "Emilia_Durgan0@yahoo.com", "Hubert", "Jones", "1-870-995-9397 x6361", new Guid("ccc11fee-830b-4e6c-a175-9045d02a8f7d") },
                    { new Guid("6236458c-c900-4041-8745-25cf1550d5f6"), "Jena_Larkin@hotmail.com", "Alvena", "Heathcote", "1-866-938-4126 x858", new Guid("c171b130-7ff9-47b7-980b-a3b764627dc4") },
                    { new Guid("63285149-19ef-4a51-a635-4231a27c84f9"), "Eric96@gmail.com", "Makayla", "Mueller", "966-688-9111 x70896", new Guid("d7279ce8-6e50-4377-9409-4e7652631698") },
                    { new Guid("6342f603-dea0-48f5-9af4-cd5ad4e4be87"), "Adelle_Kiehn1@gmail.com", "Vicky", "Hessel", "542.909.9120 x3505", new Guid("603aba0c-4476-402a-b861-b4e2b2cb40ed") },
                    { new Guid("65648115-2f6d-49b1-b66d-acef99494d71"), "Brain_Hegmann@gmail.com", "Russ", "Hills", "942.758.8826 x657", new Guid("821ab2da-fa1f-4120-8965-50a919525a95") },
                    { new Guid("6a7655da-80aa-41c9-a9cb-e964280abec2"), "Bradley_Treutel@yahoo.com", "Julianne", "Greenholt", "545.995.2503 x3664", new Guid("2c58e172-2d2c-441b-85c4-0c227a77b226") },
                    { new Guid("6d3508b3-8e8c-4e37-8b7d-3ec5fee76041"), "Lauriane.Rippin43@gmail.com", "Malika", "Will", "(496) 751-3876", new Guid("39a50889-1a71-4037-af66-26a31b5ed7b4") },
                    { new Guid("6ee9b6d3-bef2-4730-a965-2714c111977a"), "Mireille.Russel@gmail.com", "Robb", "Runolfsson", "559.642.6672", new Guid("92ed7d9f-a2f4-4738-b77d-7e8de60613e4") },
                    { new Guid("705f7e49-5a19-4d5b-bee1-ebbbb929b47c"), "Aubree.Shanahan@hotmail.com", "Cindy", "Yost", "538-396-5024 x80652", new Guid("a34a8489-965c-4598-b0d3-3b5dee545840") },
                    { new Guid("74088a8d-3779-4a36-bbf6-ef5bf41572d8"), "Andre44@hotmail.com", "Osbaldo", "Hermann", "446.643.9236 x8419", new Guid("17d0eecc-9a2c-4491-b810-774923701c2d") },
                    { new Guid("742296ee-902d-4552-b251-a449de3ff9bb"), "Pat76@hotmail.com", "Vena", "Barton", "(207) 481-4680 x823", new Guid("2a98538b-8352-4ea7-8147-adadff39b88d") },
                    { new Guid("773775bb-0c51-4d06-b3da-c9b2d2b819ea"), "Erna73@gmail.com", "Robbie", "Schmitt", "(873) 745-1432 x1760", new Guid("1fb84f5b-1b5a-4e7c-b94b-edd42ac6e352") },
                    { new Guid("79f4f617-1907-4289-b60b-bcfc783ce6c7"), "Blaze_Osinski@yahoo.com", "Dominique", "Kozey", "(835) 629-3729 x762", new Guid("aed4b545-1def-4421-a085-1bbd77a8a8ab") },
                    { new Guid("7b704554-b0cd-44d6-aa6b-5c504188e316"), "Eloy22@gmail.com", "Keon", "Feeney", "344.399.0650 x424", new Guid("532f1b4f-7713-4872-9ba5-532bf7d640b3") },
                    { new Guid("7c1b06bc-fd29-4c37-9a6e-6f532576453b"), "Dawson.Labadie79@gmail.com", "Jocelyn", "O'Reilly", "651.289.4468", new Guid("edf67d77-5289-44eb-bd4f-262bc5603a57") },
                    { new Guid("7c4fe8b5-97ac-4341-b98b-1f5afe28e725"), "Harold.Durgan17@hotmail.com", "Damion", "Gorczany", "720-466-4710 x584", new Guid("7ad42b36-0dae-4318-b527-b2757240394a") },
                    { new Guid("7eb76c30-ee24-4ecd-b838-9e43a6936463"), "Jamison4@hotmail.com", "Candelario", "Willms", "(643) 800-6105", new Guid("290c9e80-2170-442d-8f12-7f13eddfb4e6") },
                    { new Guid("82362023-c0a9-419a-86ba-bcc897bebd34"), "Collin.Anderson@gmail.com", "Velda", "Gerlach", "454.652.6014 x62137", new Guid("153a4e76-6294-4607-85a9-c226cfb859b0") },
                    { new Guid("824b4f27-5bb5-4705-95df-dcaf8f54ba9b"), "Dianna_Barton32@gmail.com", "Einar", "Mraz", "1-679-396-9415", new Guid("8b27699a-e9d1-4e93-8baf-0fe50699aecc") },
                    { new Guid("8518007e-bee3-4368-ac9f-965ad4e11a88"), "Llewellyn.Barrows@yahoo.com", "Elza", "Harvey", "1-910-842-0399 x89298", new Guid("235dd289-587f-40e0-ae1c-34e4bf09f59a") },
                    { new Guid("85865632-4ed8-4eeb-9b83-a32204b47abb"), "Wendy_Gislason@gmail.com", "Nola", "Volkman", "805-933-6555 x56212", new Guid("dc91dc90-2591-4bc7-a817-3882a722fb63") },
                    { new Guid("85af737b-7e56-4795-b809-8d3d62fd1839"), "Madelynn_Rice92@hotmail.com", "Nova", "Dietrich", "(978) 402-8662 x32860", new Guid("ef0ad918-3479-4b6a-bd58-1ab894ef5696") },
                    { new Guid("8749f172-087b-4226-8b6e-237abdaf51c8"), "Ashton78@hotmail.com", "Amani", "Olson", "1-856-634-7803 x780", new Guid("f1bbf45d-5bd1-4704-9295-1849cc4a8dbd") },
                    { new Guid("881f4235-d24f-4669-a974-37f17b57f91c"), "Ola_Heathcote76@yahoo.com", "Sean", "Homenick", "(521) 216-3535 x512", new Guid("875961fb-09e3-481f-98c6-9e77d2a1cb25") },
                    { new Guid("88c9e95b-4210-40a8-8c26-d694fd287529"), "Megane_Braun@yahoo.com", "Laury", "Bins", "401-264-1958 x78441", new Guid("41d3bb3d-085f-404a-9d03-7d5aa00cd966") },
                    { new Guid("8a0daae4-030a-4db6-80d3-2fe7c31c3dea"), "Caleigh.Pagac28@hotmail.com", "Breanne", "Johns", "1-239-541-1026", new Guid("67f60de1-3a42-438f-815f-cb4316953a97") },
                    { new Guid("8abc287f-4a09-4da1-a1fe-2b1f648b48c4"), "Linwood_OKon@hotmail.com", "Afton", "Barton", "996.884.2631 x496", new Guid("b894a0f5-b2a7-4c59-a23c-a13eca140480") },
                    { new Guid("8d8e6141-20c2-41db-904a-a3b86c219a46"), "Carlos22@hotmail.com", "Micaela", "Wilderman", "274-772-9148 x8914", new Guid("5943ba8e-0207-44b0-8bca-5e5c52f0194f") },
                    { new Guid("8f3967d9-b29a-4955-960b-1a038e8c73b7"), "Reina_Bode@yahoo.com", "Murl", "Hilll", "882-773-4977 x000", new Guid("51a3382d-34a1-46c0-bed3-91bd8d5c3761") },
                    { new Guid("905c83f8-52d7-49a4-9cae-3532da2197e5"), "Jillian.Stehr73@yahoo.com", "Tyree", "Cormier", "(476) 569-9919 x0227", new Guid("57dc40b0-8fd0-406b-8aff-950c4bc689e8") },
                    { new Guid("9365a67f-1c7b-4821-a9e9-ab96a2cb6cce"), "Earnestine27@gmail.com", "Alivia", "Schmeler", "494-799-8721", new Guid("31ecb0f5-0341-4b87-bc30-e8e582f21546") },
                    { new Guid("94422038-5a88-4efd-8a86-d0e1c6d0053d"), "Noemy.Schinner@yahoo.com", "Kaela", "Bode", "1-700-893-4131 x55135", new Guid("b184a513-69ee-4d7b-be41-0c4fac77f72b") },
                    { new Guid("99c05a0d-d61a-43b5-b566-af5655ae9b3d"), "Violette.Kohler48@hotmail.com", "Dwight", "West", "1-818-725-6619", new Guid("8dbffae7-2862-4159-a55b-6f0875ef7c49") },
                    { new Guid("99d1a106-e515-46e4-8729-e9cb6307dd62"), "Reuben_Monahan72@gmail.com", "Dario", "Ryan", "1-987-249-5402 x96703", new Guid("59d79065-e64d-4b1e-9d0d-1df0f878eef8") },
                    { new Guid("9d518119-c0d8-4dca-83ed-e145dbe7f8e6"), "Anderson.Kozey@hotmail.com", "Gladyce", "Ryan", "982-745-8641 x2016", new Guid("8e88e16c-64c2-4bdf-9cbd-d64a62945729") },
                    { new Guid("9ee4c4ee-6ac0-4c98-b803-e28e1853e5e6"), "Lonzo70@hotmail.com", "Rebecca", "Conroy", "(660) 295-7786", new Guid("991e672b-89ba-4774-a249-11677c445949") },
                    { new Guid("a2c39cd9-12bb-435f-9bb4-0975870f45c6"), "Eda_Bruen62@hotmail.com", "Matt", "Turner", "240.571.7995 x574", new Guid("5ea53211-02c8-4973-809c-750ccbc73419") },
                    { new Guid("a92d2acb-81c9-4b22-ba61-bc35daa0786a"), "Easton.Greenfelder17@hotmail.com", "Courtney", "Berge", "613.218.5824", new Guid("3a2efff2-96dd-4d81-aa34-a383c63f3922") },
                    { new Guid("aa3d96d7-ef00-415a-baac-063968d0eb7e"), "Briana58@gmail.com", "Jacklyn", "Conn", "1-619-476-3686 x130", new Guid("1e7ec0c2-37ca-480a-9fa5-a13a7b27c54d") },
                    { new Guid("acdf4d00-a322-44e4-9fb0-83d6fc29d19c"), "Louie_Nolan@gmail.com", "Chesley", "Harber", "(476) 784-3856 x23053", new Guid("a25437ef-62a4-4789-8702-36eca223937b") },
                    { new Guid("af7f9fb9-aa49-4d3b-bf7d-7881ee74f5f1"), "Brenden69@hotmail.com", "Lee", "Spencer", "556.703.7639", new Guid("d6220782-6f86-401f-8e39-193c032f3128") },
                    { new Guid("b086a440-0e06-4452-937c-d0aa57c2ce04"), "Jessie.Mosciski72@yahoo.com", "Mallory", "Anderson", "233-714-1530 x139", new Guid("f8a3ff7d-29ce-4efc-86a2-a5c06094800f") },
                    { new Guid("b9151be3-964b-4a61-ac90-9399cdc2038c"), "Gregoria79@gmail.com", "Aimee", "Brekke", "1-998-473-7498 x776", new Guid("382a564a-4d45-4047-9d2e-d7f66f6a711b") },
                    { new Guid("bb4eb145-0b7a-4c8b-ab08-3d2842410216"), "Garth.Schroeder17@hotmail.com", "Sim", "O'Conner", "288.761.5199", new Guid("6b866b81-b3b5-4e98-817e-a864fca75f16") },
                    { new Guid("bc627863-0d12-4df4-9a57-3d101ef0f7e7"), "Daphne7@gmail.com", "Mariana", "Grimes", "1-501-213-6401 x0256", new Guid("a942b0c5-5f7a-45d2-a3a8-b11be52c293d") },
                    { new Guid("bc682bdf-ef51-4a5a-a961-d770f4dff6b7"), "Mac.Sanford69@hotmail.com", "Molly", "Wolff", "959-850-5986", new Guid("4650edd4-c239-40d1-9996-2c034b6ef84b") },
                    { new Guid("bd2032c1-5ba1-4978-b251-0c80aa86a7c4"), "Norene_Thiel@gmail.com", "Shaylee", "Wuckert", "589.263.4413", new Guid("f8977078-5ae9-4812-9bc8-23fba9855945") },
                    { new Guid("bdc42045-dda3-4972-a231-596cefbc2093"), "Mack1@yahoo.com", "Hosea", "Murazik", "1-583-340-9525", new Guid("45925cfc-c82f-4d48-a97a-9a2c900c1d52") },
                    { new Guid("bef918d7-789c-43b8-a5b1-2cdd18679fcd"), "Susana28@yahoo.com", "Bridget", "O'Hara", "783.351.5666 x82155", new Guid("e732d8ae-0bf1-4cfe-acac-6b52103ada64") },
                    { new Guid("bff23b31-4ba2-4640-9c1e-bbc0605cb086"), "Lynn51@gmail.com", "Golda", "Rohan", "468.542.2254 x68466", new Guid("bc1fc5f5-3311-46e3-ae44-e7318a3ca220") },
                    { new Guid("c1fc2062-807c-4899-ab6b-554b4d658824"), "Marlee_Tillman48@gmail.com", "Herta", "Erdman", "(503) 572-7679 x92116", new Guid("1f093440-fe67-4fb1-bce6-6327648d2d81") },
                    { new Guid("cc22eebf-528e-4c8d-8ceb-a6393ba849a1"), "Shanon18@yahoo.com", "Neal", "Padberg", "290.384.1955", new Guid("6ce9a573-32da-4186-9753-b9ceade93551") },
                    { new Guid("cd2297cb-4ef7-4074-859f-2a804519ee7b"), "Candace.Douglas@gmail.com", "Marge", "Jenkins", "1-692-761-3461", new Guid("15dbf370-fbdc-4a2f-b744-e586475d4195") },
                    { new Guid("cdb6f5bd-12c6-4ebb-842a-65037e06e779"), "Charley84@yahoo.com", "Kevon", "Zemlak", "1-341-588-5249", new Guid("ad2bd5cb-e53e-45ed-9781-a6876e7de9d6") },
                    { new Guid("cdc2b2aa-87c5-4eee-a69f-3e6cea078b0d"), "Barbara.Heller@yahoo.com", "Adrain", "Altenwerth", "630.906.1874", new Guid("d41092cf-c2e5-49d7-af24-3fe4b79df0fa") },
                    { new Guid("cf24a6d3-fc7f-4f20-b186-901cef3f7ebd"), "Eveline58@yahoo.com", "Dylan", "Wiza", "1-318-391-3876", new Guid("910eb90f-32d4-47c2-91d5-4aa6b94614aa") },
                    { new Guid("d4eddeb0-5f95-460b-964f-3c541f7afbae"), "Noemie.Rath@yahoo.com", "Kattie", "Marvin", "636-747-9587 x7769", new Guid("1c0f49c9-a9a6-4e9d-9312-a990ac7da3e0") },
                    { new Guid("d5e95ade-1f5f-4dd7-bb9d-cfbbd1d71a68"), "Santa_Carroll@hotmail.com", "Maybell", "Erdman", "1-802-522-5183", new Guid("783575f9-6f31-4ca8-892e-a058be11619b") },
                    { new Guid("d68f7954-f46f-4cff-85e6-8c17fd3131d0"), "Darius47@hotmail.com", "Brennan", "Zemlak", "950-631-6821 x67054", new Guid("a71936ed-e259-4125-8f2f-c0366966a4bf") },
                    { new Guid("d96d54a2-2251-4e8b-a024-c97eb093f59c"), "Clement.Gleichner67@gmail.com", "John", "Kutch", "1-238-611-6662", new Guid("a8fe9edb-9334-42a9-acfd-cdb7d7cd424d") },
                    { new Guid("d9dfb68d-cfd8-49b3-8b7f-6dab33b933f2"), "Ressie.Auer@hotmail.com", "Leon", "King", "208-219-3451 x50189", new Guid("752fb4c1-673b-476e-9473-89dfde17d025") },
                    { new Guid("db44458f-d9e6-4ab8-a39b-a7d0c7b99bda"), "Jacklyn21@yahoo.com", "Rachelle", "Mueller", "842.315.1379", new Guid("33a08167-e1eb-41c2-aa32-1831ef4dd422") },
                    { new Guid("dd29f833-6f98-471f-8a8e-d0a9920bdb89"), "Darron_Boyle@gmail.com", "Beryl", "Homenick", "301-825-5218", new Guid("d2586236-b23b-4349-82b7-73d77d7ed682") },
                    { new Guid("e0519ea5-3233-41c2-99b6-80c73e58c6f0"), "Orlo.Heller58@yahoo.com", "Micah", "Rohan", "341-407-4457 x2690", new Guid("afa09279-398c-4730-ae4f-5058cb4f7cbd") },
                    { new Guid("e1d5d42a-fada-421c-9760-d9da5b72a23e"), "Armando_Ullrich@yahoo.com", "Marjorie", "Schamberger", "625-571-7120 x7636", new Guid("a4ccd972-df23-464f-a9bd-92e887d11a55") },
                    { new Guid("e205316d-b96a-4014-9a0a-98cd9c3a8ef6"), "Lucas65@hotmail.com", "Dallas", "Flatley", "1-321-498-5721", new Guid("401a8282-f667-4e27-b702-d4a62d85fded") },
                    { new Guid("e53ceca9-3156-46dd-ba55-43e7f10b5d21"), "Haylee.Collins@yahoo.com", "Alisa", "Weimann", "1-586-792-5409 x0736", new Guid("b9f6bba7-6e6a-437e-9d43-ab3444b7c142") },
                    { new Guid("e736192a-aa01-4952-9552-172ff7101b2e"), "Dixie72@yahoo.com", "Laurine", "Blanda", "1-366-754-3023", new Guid("54b44a54-f6ca-40be-b924-3d91e10e1548") },
                    { new Guid("e7f7276b-5b18-4975-a47c-4eeb93ce8767"), "Julia_Lemke18@gmail.com", "Lisandro", "Ankunding", "(344) 881-5729 x447", new Guid("088d59f7-594d-445f-8dbf-afad4e47abdd") },
                    { new Guid("e8937ccc-a27a-4db0-b7a7-142c4dc7eec5"), "Jarod0@yahoo.com", "Randi", "Auer", "609.596.0951", new Guid("7ff31899-8b8b-41a9-922d-9371b9856232") },
                    { new Guid("e8bb0794-2b99-44b6-9432-e1f19c28ba6d"), "Tremaine14@yahoo.com", "Marcos", "Padberg", "(996) 269-4480 x9967", new Guid("a316f629-d98d-46e4-b048-a2b0af0d5a60") },
                    { new Guid("eb55f322-63b5-44b0-8c45-2ccfd861f9df"), "Owen.Schneider66@yahoo.com", "Augusta", "Barton", "494-730-7819 x8882", new Guid("40cd9aa5-2b7e-4a2a-9080-89f8ca43efd9") },
                    { new Guid("ed0c965f-602e-48f0-be0c-fbf98c9082e3"), "Amani34@gmail.com", "Yazmin", "Lang", "(516) 761-9806", new Guid("6199b535-8fba-4f5c-b81b-fbe346ab8849") },
                    { new Guid("f0dab059-3a09-4d28-bd5d-aa96623590ab"), "Jacquelyn_Kulas70@yahoo.com", "Else", "Hyatt", "(859) 421-5130", new Guid("c91dc273-e92a-4824-9260-529feb8f4168") },
                    { new Guid("f181d126-67c3-4318-bc39-f1dc619eda2e"), "Maximus.Denesik@hotmail.com", "Jarod", "Boyer", "588-796-7352 x70769", new Guid("09534804-ece9-4c9f-a486-c10201751d8b") },
                    { new Guid("f1e0ac55-3b37-443d-934d-4279baee2dec"), "Melisa32@gmail.com", "Marcella", "Beer", "222.339.1954 x7130", new Guid("c6a7a84f-7730-44b2-bda1-3397718d31f9") },
                    { new Guid("f49b1296-20ac-42cb-86b3-54b99a0e24f9"), "Abigail44@gmail.com", "Xzavier", "Crona", "549.629.7819 x2080", new Guid("7b11e8f1-d65c-404e-a2b7-a2d12331adca") },
                    { new Guid("f4b4d44e-6e15-4b0a-9510-ac190cd06a98"), "Verla_Luettgen79@gmail.com", "Davonte", "Beatty", "398-371-4947 x76105", new Guid("1aea4615-8492-45f7-ac7a-63a999f09639") },
                    { new Guid("f4cd97e1-c253-4c33-9a0a-0275e9ea04c2"), "Dell_Kiehn@yahoo.com", "Talon", "Dickinson", "294.274.0085", new Guid("7cb666ea-79eb-42b2-b20b-a2171a9a553a") },
                    { new Guid("f6d61270-b152-4691-b87f-bd8e5f5b8b31"), "Jewel47@gmail.com", "Ashly", "McDermott", "600-849-9199 x8826", new Guid("a581e9a9-1d34-4434-b366-32c889480a2c") },
                    { new Guid("f93ee326-697c-4300-bdc2-bdaaf18cb2a5"), "Amely57@gmail.com", "Bernhard", "Mosciski", "469.527.0850", new Guid("80a82c5b-e697-43f2-96db-62d88c6c0d8c") },
                    { new Guid("fb294911-82a2-411e-b5e8-181c2b0df260"), "Taryn47@yahoo.com", "Earline", "Kemmer", "(372) 837-4533", new Guid("c9a7727f-764d-403a-99b9-3e63aadfc43e") },
                    { new Guid("fc7bacc4-4c77-4a75-90b2-c2dbc9ed103a"), "Hulda25@yahoo.com", "Deangelo", "Blick", "496.919.1126 x0325", new Guid("bc6483a2-3fe7-4095-a78c-7056881fecd6") },
                    { new Guid("fee406d1-93cf-4b12-b796-b0054a6cf3a3"), "Myrtle_Kozey@gmail.com", "Neal", "Welch", "1-806-225-5537", new Guid("de89ca38-81bd-4c5d-b0ea-22ac453738e7") }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("6f5dcee0-c8a6-4f3d-860d-ee4026ebac10"), new Guid("1fc7dc7f-4deb-46d3-a6d3-0f968a407339"), new DateTime(2023, 10, 25, 18, 9, 25, 583, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 1, 21, 8, 17, 27, 203, DateTimeKind.Utc).AddTicks(7936), new Guid("bc6483a2-3fe7-4095-a78c-7056881fecd6") },
                    { new Guid("6fd005da-ad0b-47f6-a18e-daee1e03e851"), new Guid("43a56e64-b359-4f71-845e-580db04d9490"), new DateTime(2023, 9, 14, 7, 35, 45, 302, DateTimeKind.Utc).AddTicks(2918), new DateTime(2024, 2, 2, 15, 16, 14, 393, DateTimeKind.Utc).AddTicks(5006), new Guid("eaf8c308-4afe-4f6d-902c-6ad79911862d") },
                    { new Guid("7ffea636-2166-4465-bfcb-9b694fb51fb8"), new Guid("b086a440-0e06-4452-937c-d0aa57c2ce04"), new DateTime(2024, 2, 2, 0, 8, 32, 910, DateTimeKind.Utc).AddTicks(5902), new DateTime(2024, 2, 13, 9, 25, 55, 532, DateTimeKind.Utc).AddTicks(1432), new Guid("f8977078-5ae9-4812-9bc8-23fba9855945") },
                    { new Guid("8276d176-b632-4eb6-bd55-d56ef02542f5"), new Guid("824b4f27-5bb5-4705-95df-dcaf8f54ba9b"), new DateTime(2023, 9, 22, 4, 57, 13, 621, DateTimeKind.Utc).AddTicks(659), new DateTime(2023, 6, 16, 23, 49, 5, 545, DateTimeKind.Utc).AddTicks(9583), new Guid("59d79065-e64d-4b1e-9d0d-1df0f878eef8") },
                    { new Guid("b6116524-4025-4567-8a6f-2867fa15403c"), new Guid("369f591d-922a-4a15-8551-0cddd8656981"), new DateTime(2023, 9, 3, 22, 11, 59, 730, DateTimeKind.Utc).AddTicks(4079), new DateTime(2023, 7, 31, 1, 0, 25, 907, DateTimeKind.Utc).AddTicks(5973), new Guid("17d0eecc-9a2c-4491-b810-774923701c2d") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_VehicleId",
                table: "Clients",
                column: "VehicleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClientHistories_ClientId",
                table: "VehicleClientHistories",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClientHistories_VehicleId",
                table: "VehicleClientHistories",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                column: "ModelId");
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
                name: "Models");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
