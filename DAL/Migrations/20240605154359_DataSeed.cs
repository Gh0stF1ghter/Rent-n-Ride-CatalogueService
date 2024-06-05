using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3142be66-531e-48e1-955d-2e62a62609f6"), "Dodge" },
                    { new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"), "BMW" },
                    { new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"), "Volkswagen" },
                    { new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"), "Chrysler" },
                    { new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"), "Toyota" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("14b3149b-1914-4eb6-9636-1474569a9621"), new Guid("3142be66-531e-48e1-955d-2e62a62609f6"), "F-150" },
                    { new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"), new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"), "Durango" },
                    { new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"), new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"), "Mustang" },
                    { new Guid("3346afc6-b216-4d87-903e-db596a98c220"), new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"), "CTS" },
                    { new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"), new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"), "Mercielago" },
                    { new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"), new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"), "V90" },
                    { new Guid("412352a2-191c-466e-8c0c-17923c8f045c"), new Guid("3142be66-531e-48e1-955d-2e62a62609f6"), "El Camino" },
                    { new Guid("47869e57-7703-419c-868b-2ec46d88b858"), new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"), "XC90" },
                    { new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"), new Guid("3142be66-531e-48e1-955d-2e62a62609f6"), "Colorado" },
                    { new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"), new Guid("3142be66-531e-48e1-955d-2e62a62609f6"), "Cruze" },
                    { new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"), new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"), "Sentra" },
                    { new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"), new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"), "Taurus" },
                    { new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"), new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"), "2" },
                    { new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"), new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"), "Golf" },
                    { new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"), new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"), "Charger" },
                    { new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"), new Guid("3142be66-531e-48e1-955d-2e62a62609f6"), "Model T" },
                    { new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"), new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"), "Camaro" },
                    { new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"), new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"), "Aventador" },
                    { new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"), new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"), "Taurus" },
                    { new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"), new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"), "Accord" },
                    { new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"), new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"), "CX-9" },
                    { new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"), new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"), "ATS" },
                    { new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"), new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"), "Model 3" },
                    { new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"), new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"), "Mustang" },
                    { new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"), new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"), "Fiesta" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("0087c1e7-244a-4ded-955a-7816ac19ea0c"), 0, new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"), 1587, "7DT4ERC3GFG076899", 3365.5207046365199, 1, 4 },
                    { new Guid("05833a74-87b7-44e7-9532-ef09ec49324e"), 3, new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"), 7166, "9M0KTZIO97IN88029", 3801.5239435539274, 2, 0 },
                    { new Guid("077d302f-5577-45de-8901-d83f4cf78406"), 2, new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"), 9408, "NUSDGHWSE3CZ89955", 1899.61584167618, 3, 4 },
                    { new Guid("09e508f9-03c1-42cb-bc80-6d5af76298c0"), 2, new Guid("47869e57-7703-419c-868b-2ec46d88b858"), 3588, "R1PFPI749WP589799", 3683.4805135117845, 2, 3 },
                    { new Guid("0dfb8a56-5162-4947-b931-d0c27f123b05"), 2, new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"), 8049, "WMRYO4OGA6UC67418", 2476.0534119161389, 0, 1 },
                    { new Guid("129ca150-3497-4701-8904-db16e4963283"), 0, new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"), 9654, "8KNGT5K7ZDR424515", 2924.2015066693953, 3, 5 },
                    { new Guid("18e57f54-7856-4d25-969e-6d9d2c03506f"), 1, new Guid("47869e57-7703-419c-868b-2ec46d88b858"), 4814, "9K2IY4WLKBGH23170", 556.107822306407, 2, 5 },
                    { new Guid("1be00318-93c3-4b14-8d2d-c754962929b7"), 1, new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"), 2746, "CA83KLTLR0BA39631", 3207.1938001130484, 3, 3 },
                    { new Guid("238400fa-3b74-4211-ab61-b24378a0f226"), 0, new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"), 9745, "VNB2YF7G3QRW30369", 3877.052684219535, 3, 5 },
                    { new Guid("23cfa208-b631-4ba6-bad6-2c8677366d74"), 3, new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"), 534, "A5UHQRT5PGKJ93616", 3559.8822401605398, 1, 1 },
                    { new Guid("258aaa11-c45b-4522-8ee1-460c108703c6"), 3, new Guid("14b3149b-1914-4eb6-9636-1474569a9621"), 725, "PARZJ0DLCXCD54188", 591.19975985723886, 2, 1 },
                    { new Guid("25916132-b0d2-4ac3-9ecd-f615db261646"), 3, new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"), 2368, "JNFBHZQMCMB496879", 2305.3606127784001, 3, 2 },
                    { new Guid("27a3fdac-1097-4518-8865-3c669e4cc328"), 2, new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"), 6009, "AYUX111Q0BZ253401", 3065.4916876729362, 2, 4 },
                    { new Guid("2a0eb47c-6759-4c5b-8bed-4dea7d9082cf"), 3, new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"), 5080, "9IZYJ3FMM8L991309", 785.9843066604509, 0, 5 },
                    { new Guid("2bc595d4-55b3-4e8b-a944-298189d4eb1b"), 1, new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"), 4820, "FMUI2COSP3AK96734", 2633.2921475689823, 3, 1 },
                    { new Guid("2cadaa99-a4ca-4470-8372-4c08abd12619"), 3, new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"), 6950, "XMKE9JHJ91XH23277", 1410.5450905226035, 2, 0 },
                    { new Guid("2dda2bc7-fe0f-4e0d-a2ff-6ebe064215b8"), 0, new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"), 1500, "4L6MTTLGXTL032734", 261.7464640560039, 1, 0 },
                    { new Guid("2eb336a2-cc4a-4b2f-90c1-0d0761a07d89"), 0, new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"), 2591, "QVGIZLSDDOB379504", 2911.7738467527497, 3, 3 },
                    { new Guid("2f9973f8-7f5c-4695-95a5-3e19331df094"), 1, new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"), 5156, "IMCVSZSV5EJ714449", 788.28587646931123, 0, 5 },
                    { new Guid("2f999c4d-ea66-484c-97d6-4d2387203416"), 3, new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"), 4102, "K064GQ3Z9HZB12796", 1204.2277958056759, 2, 3 },
                    { new Guid("2fe32966-67c9-4e66-b18a-8c5aea8e7d8f"), 0, new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"), 9415, "L7FAGT7CADI280727", 267.60004652868594, 0, 0 },
                    { new Guid("323af1ed-d79e-46f3-8133-d39ae6f3a6a9"), 3, new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"), 3391, "S53XYBCRXIXG81384", 417.05968625264234, 1, 1 },
                    { new Guid("33d75741-ead1-45b1-9889-e3631a23be0c"), 3, new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"), 4735, "43Q97LT1W9J016755", 553.3805188894496, 0, 5 },
                    { new Guid("33ea0be7-2d72-4bc8-be83-f0189aa7a599"), 2, new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"), 9449, "5JX8Z1T6W6BE93206", 2434.6897527006572, 1, 1 },
                    { new Guid("34ecd90f-09c0-43f1-bcf7-124e801e7c11"), 1, new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"), 5526, "XKPU5FEKBHX861820", 1538.4274750123254, 0, 0 },
                    { new Guid("378776b7-cb79-4331-afe0-3de5c20933e2"), 0, new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"), 9077, "YHGZO14FDQKK66444", 3607.3489312506276, 3, 1 },
                    { new Guid("39288488-91e8-40b6-9a46-06937b59172a"), 2, new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"), 2319, "2NZA4TNLCWPP38931", 2129.5995759830621, 0, 3 },
                    { new Guid("3c51f4f6-2889-421e-9fc9-e58ab2d622af"), 1, new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"), 4681, "KP417XBWYITO88029", 1980.5096444758285, 3, 4 },
                    { new Guid("3d36eb12-1927-4e3f-b81a-e438e5ff31ce"), 2, new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"), 7917, "2HEYVGCW8VKR62626", 1911.1155481463127, 0, 4 },
                    { new Guid("3e10acbb-8b08-4033-8041-ea58322e8f7d"), 0, new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"), 2846, "BIQVA9YJJYYJ58127", 1608.5861475012389, 2, 2 },
                    { new Guid("3e62094d-2b3a-4a67-9546-9aee715a0a38"), 2, new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"), 8417, "EVP1DV92EHLX86044", 2097.777760190992, 3, 0 },
                    { new Guid("41262f6b-c810-4228-9e77-279931dbbd3a"), 1, new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"), 495, "ZFI15N5PDHNN27604", 717.59123668574318, 3, 2 },
                    { new Guid("41bb7078-a8e0-44be-9980-ee49fd2e03af"), 2, new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"), 1181, "KF2FHS8VJOZB45286", 3100.3619512488344, 3, 5 },
                    { new Guid("43462802-03c6-4d5a-a9b4-ab9fcbf6370e"), 2, new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"), 7717, "BBUB3A2NAQDK19276", 2498.1095385539661, 0, 1 },
                    { new Guid("44072a48-1a0e-4057-8374-a4cc33775a82"), 1, new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"), 7860, "HV7GDZNOB1SL66813", 2719.995319389308, 0, 3 },
                    { new Guid("4592969b-9b03-40bd-86f2-808bd278418f"), 0, new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"), 3558, "XO8CAMHHAUUE97354", 1338.0481347731163, 3, 5 },
                    { new Guid("45a7c36b-c974-4708-9a47-645f45bbad2b"), 2, new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"), 3738, "8U4OATARQ7L558534", 1303.6396442680907, 3, 1 },
                    { new Guid("45f72d07-b3b7-448f-8856-e1d9def8717f"), 0, new Guid("14b3149b-1914-4eb6-9636-1474569a9621"), 1453, "J10EXA8S7IP124531", 3545.8878725788081, 1, 4 },
                    { new Guid("4967fcac-5adb-47d3-8c51-82f7a67d0e86"), 0, new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"), 2418, "32PTLCN0GZDR15083", 3401.5812747716541, 0, 0 },
                    { new Guid("4b38f6dc-8bd7-44b3-9d2e-616dab55c9e1"), 2, new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"), 3328, "31CTQM6VQTQN75270", 1517.0797904706124, 0, 2 },
                    { new Guid("4b7d41ff-d2a2-471e-b453-364a957743ef"), 3, new Guid("14b3149b-1914-4eb6-9636-1474569a9621"), 602, "OUDDG5EC0DO455575", 1109.6861117534518, 2, 1 },
                    { new Guid("5063f017-7172-47c3-9851-62c9d504b39a"), 1, new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"), 3426, "0NVW7NVIKWWS89577", 2428.2177982960989, 3, 3 },
                    { new Guid("53210b7f-0382-41ff-84ad-07e5545a24a8"), 1, new Guid("412352a2-191c-466e-8c0c-17923c8f045c"), 941, "YNCTDSCXQQM337123", 1480.740560655604, 2, 0 },
                    { new Guid("53a7e9ab-f57a-4a6f-99bf-953b93c8f9b8"), 2, new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"), 3218, "AYAKHKXSRCW088099", 3919.3186443364611, 2, 3 },
                    { new Guid("53ef54bf-1f82-4377-b676-245f87825890"), 2, new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"), 9069, "R8TQDCOC6HJ659225", 2896.389938026472, 0, 0 },
                    { new Guid("5672183f-5e47-462d-8ac8-70ab22be0919"), 3, new Guid("412352a2-191c-466e-8c0c-17923c8f045c"), 9014, "VTVDZPHJLKEW11304", 2004.4295428235694, 1, 0 },
                    { new Guid("57d569c7-c2cd-4a26-bc06-d91215ce8679"), 2, new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"), 6986, "KV59GRPZ6VAO17720", 1180.9367676576724, 1, 4 },
                    { new Guid("5bb29662-7f57-44ae-a419-a65337d19f42"), 1, new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"), 2891, "DBIOOUM1D0QF37641", 1523.0736597509492, 2, 2 },
                    { new Guid("5cb03a6e-3b29-4e24-a4c8-0ae11d8efb83"), 2, new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"), 7108, "0E9WYLIKYME349433", 230.62187160813161, 2, 0 },
                    { new Guid("607996c4-2c20-4097-91f0-8273409171e9"), 2, new Guid("3346afc6-b216-4d87-903e-db596a98c220"), 3118, "FFZJICKN2RN940605", 947.97742886728543, 0, 3 },
                    { new Guid("60d86345-d960-41ca-bdd2-e1a7c069b541"), 0, new Guid("47869e57-7703-419c-868b-2ec46d88b858"), 186, "RUFPL2Q9GWAB30135", 1142.1003113756958, 1, 1 },
                    { new Guid("624c4c02-e05c-4dd1-881d-8022761abf47"), 1, new Guid("412352a2-191c-466e-8c0c-17923c8f045c"), 9675, "1V04L4L3C3RU83081", 2364.9529700720973, 0, 2 },
                    { new Guid("653da33b-ec3f-4a86-a2d7-cf287a21e314"), 0, new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"), 295, "BDAZ3K3LKAN324781", 2817.853506645431, 0, 5 },
                    { new Guid("68d1547b-8e82-41ac-a9ee-780f4bf4a8a1"), 2, new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"), 9863, "A9PB1YQJHIVA20357", 3436.4101205849383, 0, 1 },
                    { new Guid("6cf5fcfb-605c-47c6-a420-9bc70acacecf"), 1, new Guid("3346afc6-b216-4d87-903e-db596a98c220"), 9723, "GGFNB0DEIVJ591008", 746.98397051128393, 1, 5 },
                    { new Guid("6db1af4e-0c21-403e-b9a2-55b0e588fc71"), 0, new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"), 2093, "09RS1NV0RUZH24069", 2303.0560745418616, 1, 2 },
                    { new Guid("70ff9674-c5c6-4700-b972-1dd3c332acdf"), 1, new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"), 4843, "I2X68WVCITG564488", 2575.2440478778317, 0, 1 },
                    { new Guid("77317fc8-ad2b-45d0-8af6-82c0ac6cc8c4"), 1, new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"), 6813, "2LYH4DT330GB38674", 436.97558456756616, 3, 5 },
                    { new Guid("7a2d57a6-48a3-40e9-8590-9b6932daf049"), 1, new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"), 462, "GNUTLOT6AXIP90659", 1864.7772582012101, 0, 4 },
                    { new Guid("7ad45e50-e0fd-4a05-a1f3-3a8f4515ef8b"), 0, new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"), 8015, "DMY6PA3GR4UV68318", 2495.0777745067803, 2, 2 },
                    { new Guid("7e1b3ab1-8064-490b-9e4b-1dbcf8822493"), 1, new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"), 639, "TG4WGO1HTUAN27436", 2391.5842915394719, 0, 2 },
                    { new Guid("7ea6792e-6ff0-4b06-af0f-71e3a8984335"), 0, new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"), 9750, "DMOORM5N4WEV67809", 2688.9093218711241, 1, 4 },
                    { new Guid("8650a7f6-06cd-4015-96db-f14f3e208a82"), 0, new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"), 5058, "6PND4LVF4NS421577", 1876.4472161014146, 0, 3 },
                    { new Guid("86600e35-1023-4a39-9b69-af1082d29746"), 0, new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"), 8784, "K2U0LIAIYJU381118", 1128.1763285334316, 3, 2 },
                    { new Guid("8a22537f-9863-4960-9fd0-39bc22fcd87d"), 1, new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"), 5386, "D29XAYSAIIGM73843", 1908.3509770524247, 3, 5 },
                    { new Guid("8cc7f4bb-0195-4066-9ce8-cb64605ae79e"), 1, new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"), 1438, "2P95J9VFXUEX30530", 1001.9770400043105, 0, 2 },
                    { new Guid("8e65b189-b73d-466b-97ae-dd4fb340287b"), 0, new Guid("412352a2-191c-466e-8c0c-17923c8f045c"), 379, "BV4C2NFKT5ZP58183", 1163.6049642581906, 1, 5 },
                    { new Guid("9566f16d-0105-4c11-aff7-bced4be5d251"), 0, new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"), 9387, "0H52MSWX6NSP50332", 3319.285906548329, 3, 2 },
                    { new Guid("95839ddd-c584-474f-a782-4592acbda97f"), 3, new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"), 6392, "K8WLABO5URZW22735", 275.58832643439484, 0, 1 },
                    { new Guid("962432c5-ec46-4176-8483-c9facaccd3f6"), 1, new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"), 9323, "206DPC4B79N896779", 553.25853139741503, 1, 0 },
                    { new Guid("96312c40-b798-4e11-8464-523e8c6713fd"), 1, new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"), 8087, "EJLL8W9Z4TKE61499", 2885.9206484648612, 3, 1 },
                    { new Guid("96fe5d56-be84-4f3e-a725-5df6f79f63e3"), 1, new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"), 5919, "85TYG4UM5HHM24361", 317.8867234530141, 0, 5 },
                    { new Guid("9c441f04-76c9-4073-b526-a7059a86e736"), 2, new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"), 1411, "7S7L0DW2QXWI63252", 2525.3514431691833, 0, 4 },
                    { new Guid("9c582887-f4cd-4ba5-844d-b53f23869552"), 1, new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"), 3322, "5ANP2I75I2Q087570", 3336.363517408296, 0, 3 },
                    { new Guid("9c8f97fa-501e-47a8-ba70-557d1fc1c2d5"), 2, new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"), 2605, "NGEE2T2AC9JE14554", 1404.3051222342517, 0, 2 },
                    { new Guid("9cb5d755-7b91-40f5-a469-067d841c7eb9"), 0, new Guid("47869e57-7703-419c-868b-2ec46d88b858"), 536, "MQE66142VRTJ45309", 980.84147404520729, 1, 0 },
                    { new Guid("9cb92c0f-cb12-472d-af14-4dcf88b2a2b6"), 2, new Guid("14b3149b-1914-4eb6-9636-1474569a9621"), 3667, "8XY326DG1WNI97629", 1079.2478760178788, 2, 1 },
                    { new Guid("9d02ccd5-eaf9-4295-922e-d38b97f8509f"), 0, new Guid("3346afc6-b216-4d87-903e-db596a98c220"), 6616, "GQ0Q0XD9KKVI52176", 2702.8218771193101, 0, 3 },
                    { new Guid("9f534456-fa08-463b-9d12-e16947674e44"), 1, new Guid("47869e57-7703-419c-868b-2ec46d88b858"), 3664, "OGEP4H4F8PUF74233", 586.17429971921183, 2, 2 },
                    { new Guid("a0329e08-e3d4-44c4-b40c-1f169da91ed9"), 2, new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"), 3808, "NJV41TZQ7TT070809", 3716.6024917857007, 3, 0 },
                    { new Guid("a4f9c5a4-96bb-493b-814b-170b1512fc75"), 0, new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"), 5605, "2VW7NCUKGERX22912", 2484.4865566857161, 3, 4 },
                    { new Guid("a62735dc-a618-4e71-bfef-cf8b7a31d11a"), 1, new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"), 1056, "WSLQMBE983U845731", 468.38950331489565, 1, 2 },
                    { new Guid("a74203f2-2ae5-4b06-9824-232c1f3b18ab"), 2, new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"), 6503, "4Y6MOZHH11HH67089", 3965.861919034322, 0, 4 },
                    { new Guid("add6cfd3-1ba6-4a7d-bef3-e0a63d0d56a1"), 0, new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"), 1559, "6PD26WN5SPDS38317", 676.89447407273019, 2, 5 },
                    { new Guid("ae1c13d9-6c04-4e70-98b2-5263f74e82a5"), 3, new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"), 8201, "6FFARU0JJ2ND92464", 1939.3574634242627, 3, 3 },
                    { new Guid("afcf4096-72da-4af4-8c01-fe2e9cc0054a"), 0, new Guid("3346afc6-b216-4d87-903e-db596a98c220"), 105, "YIHG7AQCNUY243912", 2524.465330089155, 0, 2 },
                    { new Guid("b06fb151-df55-426c-856f-50e606867310"), 2, new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"), 7065, "3XD1BDVXW9DA68611", 3891.3339102858281, 0, 5 },
                    { new Guid("b18799c7-0bb0-436a-8090-5d30196c9c6f"), 2, new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"), 4765, "8OYMOX7T8SDN70302", 573.30252291459624, 3, 5 },
                    { new Guid("b32a154a-cdb1-4adc-acad-098b079bb133"), 0, new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"), 3259, "DMDXKN4G11Y958936", 1968.0949070630343, 0, 1 },
                    { new Guid("b792036e-3ef1-4614-a3be-3002618ce141"), 0, new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"), 4134, "HPCKIR1NAZM820146", 638.085866784058, 2, 2 },
                    { new Guid("b896db69-7f07-4f64-807a-521849a8cb4a"), 2, new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"), 6721, "SGFK332TPOL447579", 1613.0330163669105, 3, 4 },
                    { new Guid("b93a0040-17ba-43e1-8923-2136ef4692e1"), 0, new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"), 3826, "BYV2G6SRWKU792851", 1419.7328382930964, 1, 0 },
                    { new Guid("b9c53563-32de-4bef-8419-420138628da7"), 2, new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"), 1316, "EK9KNJMW3VJO68983", 3219.5823370692688, 2, 1 },
                    { new Guid("bbc5a991-a45d-42e7-aa6f-047ad6839197"), 0, new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"), 4759, "06R5AH5P6PQ694645", 3319.1794595113915, 0, 0 },
                    { new Guid("bcd240c5-e500-4610-ad93-7b773b3b5bdc"), 0, new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"), 8166, "HV1EYKJ1YAAZ93052", 1439.4385563492317, 1, 5 },
                    { new Guid("bce61c2a-f55e-4ec0-8c54-203467a26aa4"), 1, new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"), 5361, "C5C6N4NPIKE658212", 2670.3824456515267, 1, 2 },
                    { new Guid("bd2c7c28-4365-473d-9326-4ac2018267bf"), 0, new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"), 8956, "DXF9T0BJZMXN59776", 1547.9989642034009, 2, 0 },
                    { new Guid("c0fdccca-d6a3-415f-8fc2-0791b3865673"), 0, new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"), 1221, "4LX1ME91JADX93785", 2814.6759812577448, 2, 2 },
                    { new Guid("c27c7992-56bd-4798-9a60-ca7619f23959"), 0, new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"), 6001, "T57OT01FAQDS74307", 2624.6842150700268, 3, 1 },
                    { new Guid("c694f202-30ba-4ed9-bb8d-95d87e7db905"), 2, new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"), 5659, "G5WADFMGZMEN36176", 3728.4026239353871, 3, 3 },
                    { new Guid("c851fbff-55b4-4e37-a8c6-d66928dd67ec"), 1, new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"), 9506, "UB7324KIYBKR71501", 3441.5341693629612, 1, 3 },
                    { new Guid("cce4f137-bb64-4659-bef1-94f49a355054"), 3, new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"), 6387, "ZK89H7K7VVOD80961", 1378.5389989397672, 1, 1 },
                    { new Guid("d264f91e-0203-42a4-9eac-59bc4a1f2327"), 1, new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"), 6392, "Y2EP5OXIKKHG20443", 2006.1582376813465, 2, 0 },
                    { new Guid("d736f790-9338-450a-933e-bbe65bc8de3d"), 2, new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"), 2548, "Z4LJ2D8WX7KX19642", 2509.7263811416578, 0, 2 },
                    { new Guid("d74eaa94-5e5a-4d3d-8574-74cc40401dd9"), 2, new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"), 1434, "B8N6VJL8TQWD63243", 1263.786108943764, 2, 1 },
                    { new Guid("d8a361f7-1753-4b74-9717-dd86805a15ff"), 1, new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"), 5188, "JT7T8QHXATCV52045", 1107.8255034257741, 3, 1 },
                    { new Guid("d8ac9efe-89cb-46c5-b7cb-c14ba850ca43"), 1, new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"), 2648, "Y9V65B1DE5PW94447", 3946.2918538356344, 3, 1 },
                    { new Guid("db3110ef-4e42-4619-8c08-00a8267437e6"), 2, new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"), 9071, "XG6EDR4U3ML979364", 3053.0318824128231, 3, 5 },
                    { new Guid("e0516236-d65e-4554-b47d-aba5eba0e174"), 1, new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"), 6817, "TF8RDBAPNSXP35566", 3143.5809317412368, 1, 1 },
                    { new Guid("e0c8fa63-ef8b-41e6-b1b2-055799ef3b9e"), 0, new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"), 5322, "1WJMQ0ZIJPMH68111", 2647.0316121258456, 0, 4 },
                    { new Guid("e2721253-4e39-4473-8089-b435f5a1d5fc"), 2, new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"), 5581, "YJMH6GZ44CEB30094", 2737.2678228393561, 3, 0 },
                    { new Guid("e49df283-83f3-4cbf-a925-34a3181a6e58"), 0, new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"), 2715, "WNJ3VBNUODSV22726", 2180.3503880066055, 2, 3 },
                    { new Guid("e67d2e05-1128-4e51-a7c8-5a7742d7f020"), 3, new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"), 2020, "D6126Q98M4RR27289", 1727.6699468672225, 0, 2 },
                    { new Guid("e6912140-10d6-4664-a693-a88adb49f922"), 2, new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"), 6344, "JJBIUBJDEJCS88369", 1025.2761269005805, 0, 1 },
                    { new Guid("e81c3404-6572-44ba-b4ac-629586d8d2c6"), 3, new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"), 8732, "H7G8N4WPIDH013630", 628.5565252412498, 2, 0 },
                    { new Guid("e8587f6e-55c0-48f0-8061-5899c88bbdf9"), 1, new Guid("14b3149b-1914-4eb6-9636-1474569a9621"), 7828, "QBV95B8FJBWV30861", 3734.6159508133996, 3, 3 },
                    { new Guid("eb222bfa-54bf-4181-9ae9-cb2d38bdfe4e"), 1, new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"), 388, "QICXC6V7XAFB73934", 260.5333762227225, 0, 5 },
                    { new Guid("eb8e4e3e-c91e-4141-bde4-ad582f43e699"), 0, new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"), 1976, "FG993NYQOVPC54327", 1143.2452296184604, 2, 3 },
                    { new Guid("ed5335eb-6376-4f17-8e1e-fbe92bc51798"), 3, new Guid("412352a2-191c-466e-8c0c-17923c8f045c"), 3958, "FIG12VTJOYWB90546", 3163.1269711679179, 1, 0 },
                    { new Guid("efb681ee-ae4d-4965-a4cc-f25725b115b0"), 1, new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"), 3773, "467XU7E9JICO66579", 3435.1912952496914, 1, 2 },
                    { new Guid("f0a653ba-ce83-4be1-bdc3-7fa18bcaa336"), 2, new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"), 5738, "P5COOYGXU6VU51024", 3707.4917497650131, 0, 2 },
                    { new Guid("f5343a02-b09b-4f57-ac0e-575b13de1445"), 1, new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"), 8854, "D4L5O5QMFOHL25815", 2642.1035439118768, 1, 1 },
                    { new Guid("f63f8777-b8c1-442b-949c-db2dad9123a8"), 0, new Guid("3346afc6-b216-4d87-903e-db596a98c220"), 7748, "TUXBT9BZNKAK48830", 3981.0715712931892, 1, 0 },
                    { new Guid("f6d05f4c-057c-4675-80fb-387ef4f24aaa"), 0, new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"), 8566, "RB5AHZUAS3Q466963", 2459.2074002803811, 2, 3 },
                    { new Guid("f7ab5d6e-8f89-4d4a-8a23-1236e0e7a426"), 0, new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"), 426, "PSUVJYIMAUIE29547", 2596.3083912843663, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("01a664bf-2b7e-4dca-b81e-9ab935e71b75"), "Jovani_Kling5@hotmail.com", "Wilburn", "Bednar", "986.894.4359", new Guid("a4f9c5a4-96bb-493b-814b-170b1512fc75") },
                    { new Guid("053cfe2f-9238-4bf3-87a6-5d380811ee8c"), "Marielle21@gmail.com", "Jamil", "Daugherty", "(949) 546-8425 x110", new Guid("db3110ef-4e42-4619-8c08-00a8267437e6") },
                    { new Guid("06793c74-abdb-4575-8f81-6d79b70657ed"), "Amaya81@yahoo.com", "Hugh", "Zboncak", "487-981-0743 x82168", new Guid("8650a7f6-06cd-4015-96db-f14f3e208a82") },
                    { new Guid("0744d0b0-3a15-46c5-829a-7a8070eb697a"), "Coby.Luettgen60@hotmail.com", "Telly", "Blick", "469.392.1580 x0771", new Guid("8e65b189-b73d-466b-97ae-dd4fb340287b") },
                    { new Guid("08f6511f-433f-4351-aee6-1e81b210a1e6"), "Claudine64@gmail.com", "Edmund", "Nicolas", "998.745.8570", new Guid("e0516236-d65e-4554-b47d-aba5eba0e174") },
                    { new Guid("09e1fdf2-7881-42da-bd03-af61526af443"), "Herminia_Champlin@gmail.com", "Jayme", "Kunze", "955.904.2345 x729", new Guid("d74eaa94-5e5a-4d3d-8574-74cc40401dd9") },
                    { new Guid("0a3ac469-370e-46cf-b303-76350c5f4fab"), "Joana26@hotmail.com", "Ona", "Harris", "929.385.4481", new Guid("60d86345-d960-41ca-bdd2-e1a7c069b541") },
                    { new Guid("0a422fe1-3893-4c0c-b037-7e7c3b23dc9f"), "Ricky36@gmail.com", "Percival", "Mertz", "557.630.2371 x621", new Guid("2dda2bc7-fe0f-4e0d-a2ff-6ebe064215b8") },
                    { new Guid("0a82d1de-a38f-4437-a331-53cd0c4b0943"), "Rico_Welch@gmail.com", "Edyth", "Parisian", "306-625-6388", new Guid("8cc7f4bb-0195-4066-9ce8-cb64605ae79e") },
                    { new Guid("0b17afaa-58f6-4377-a28e-d84b3b69df98"), "Jarred_Senger39@hotmail.com", "Kailee", "Breitenberg", "(816) 483-6669 x41532", new Guid("077d302f-5577-45de-8901-d83f4cf78406") },
                    { new Guid("0f60f5f8-4b07-4bad-a41a-9dcfa487c1f8"), "Anabel.Thompson@gmail.com", "Kylie", "Parker", "600.773.9226 x04308", new Guid("eb8e4e3e-c91e-4141-bde4-ad582f43e699") },
                    { new Guid("10e9d462-670e-45e2-a2b6-45b40812499e"), "Zachery66@hotmail.com", "Arvilla", "Ward", "359.222.8189", new Guid("afcf4096-72da-4af4-8c01-fe2e9cc0054a") },
                    { new Guid("133f2844-d9d5-4902-b76e-935c7753ba91"), "Vicente.Muller@hotmail.com", "Dillon", "Schamberger", "775-907-2597 x5771", new Guid("b9c53563-32de-4bef-8419-420138628da7") },
                    { new Guid("163a3302-1efc-4143-9f35-0fc29d51b8e3"), "Cedrick.Wyman@yahoo.com", "Ayden", "Smith", "(627) 386-4913 x138", new Guid("9c582887-f4cd-4ba5-844d-b53f23869552") },
                    { new Guid("17c1393e-0ee9-4202-96b5-ec736017fff7"), "Timmy.Kunde79@hotmail.com", "Trey", "Nitzsche", "225-380-9459 x50547", new Guid("41bb7078-a8e0-44be-9980-ee49fd2e03af") },
                    { new Guid("190e0167-636e-4513-81cf-53b6ce643264"), "Americo29@gmail.com", "D'angelo", "Prosacco", "718.839.8424", new Guid("e8587f6e-55c0-48f0-8061-5899c88bbdf9") },
                    { new Guid("19eed56d-5c0f-4146-ba60-cb6e84b9dd97"), "Addison66@hotmail.com", "Angeline", "Gorczany", "1-464-234-8566", new Guid("bd2c7c28-4365-473d-9326-4ac2018267bf") },
                    { new Guid("1d8cd704-ca38-424e-a425-745e7c4cba91"), "Johnathan.Corkery97@gmail.com", "Wilhelm", "Hoppe", "301.499.6061 x26850", new Guid("ed5335eb-6376-4f17-8e1e-fbe92bc51798") },
                    { new Guid("1efdf8b4-2589-4ec8-8474-bfac9101441d"), "Earl.Fay38@yahoo.com", "Ansel", "Wolff", "1-518-992-8476 x1641", new Guid("41262f6b-c810-4228-9e77-279931dbbd3a") },
                    { new Guid("21818b7f-0808-4e70-9d03-d80900a2d07d"), "Bernice66@yahoo.com", "Polly", "Hintz", "596.817.1299 x86409", new Guid("238400fa-3b74-4211-ab61-b24378a0f226") },
                    { new Guid("2182688f-d9ae-4c46-af74-d2bf2c7d00ed"), "Leonor.Homenick@gmail.com", "Raphael", "Wilkinson", "389.205.1279 x404", new Guid("129ca150-3497-4701-8904-db16e4963283") },
                    { new Guid("24c0a221-3f17-48dd-adee-778ad6d581d2"), "Eva80@gmail.com", "Domingo", "Hartmann", "859.823.4659 x7495", new Guid("2f9973f8-7f5c-4695-95a5-3e19331df094") },
                    { new Guid("26994f23-c146-4d78-a1cc-e880a1fd8dfb"), "Pattie.Hyatt10@yahoo.com", "Eleonore", "Buckridge", "1-396-922-8250 x9764", new Guid("9566f16d-0105-4c11-aff7-bced4be5d251") },
                    { new Guid("26aff0d8-5a57-465a-adbc-ec2036806ffa"), "Rodger.Howell66@yahoo.com", "Sabina", "Hand", "(839) 409-8570 x03417", new Guid("9cb92c0f-cb12-472d-af14-4dcf88b2a2b6") },
                    { new Guid("2a5a9153-c5e3-460d-bbdd-bcb8558cb9a9"), "Clarissa_Bergstrom@yahoo.com", "Ryleigh", "Howell", "(342) 781-2255 x054", new Guid("3e62094d-2b3a-4a67-9546-9aee715a0a38") },
                    { new Guid("2b407d9a-b070-4987-a375-66ac1657da9a"), "Irma_Ward@yahoo.com", "Nella", "Yost", "825-902-1860", new Guid("258aaa11-c45b-4522-8ee1-460c108703c6") },
                    { new Guid("2e672717-8f42-4962-8cc8-1315d844cf11"), "Jovan88@yahoo.com", "Jeramy", "Crist", "983.696.5816 x94792", new Guid("6cf5fcfb-605c-47c6-a420-9bc70acacecf") },
                    { new Guid("2eb67ee1-2f20-4902-9cd1-050b812569f4"), "Vinnie51@hotmail.com", "Gaston", "Fahey", "1-372-345-5423 x47623", new Guid("0dfb8a56-5162-4947-b931-d0c27f123b05") },
                    { new Guid("309d5356-15d1-403c-b8bb-b1199706345d"), "Gilbert.Auer77@yahoo.com", "Sven", "Berge", "1-431-489-3166 x601", new Guid("e49df283-83f3-4cbf-a925-34a3181a6e58") },
                    { new Guid("310ac8f3-a6ab-4acd-8452-95925b944ddd"), "Fatima.Halvorson@hotmail.com", "Bradly", "Blick", "1-492-203-6442 x0275", new Guid("bcd240c5-e500-4610-ad93-7b773b3b5bdc") },
                    { new Guid("31fd0929-4692-420d-a805-a10436db4b6c"), "Vena.Jerde@hotmail.com", "Demarco", "Nolan", "714.342.4835", new Guid("5cb03a6e-3b29-4e24-a4c8-0ae11d8efb83") },
                    { new Guid("32512f63-4076-44f9-82a4-8a927c0ff560"), "Serenity81@yahoo.com", "Patsy", "Abshire", "1-994-928-3000", new Guid("eb222bfa-54bf-4181-9ae9-cb2d38bdfe4e") },
                    { new Guid("33a2104e-c4a4-4ba0-8e5b-79ae0aca7f3c"), "Alysha94@yahoo.com", "Dylan", "Davis", "539.662.4594 x244", new Guid("7ea6792e-6ff0-4b06-af0f-71e3a8984335") },
                    { new Guid("347490d8-f0e3-47e8-9134-f28ea8ba516f"), "Garry71@yahoo.com", "Emery", "Wyman", "618.667.6990 x77597", new Guid("2eb336a2-cc4a-4b2f-90c1-0d0761a07d89") },
                    { new Guid("356c4c87-caf6-413d-a353-868e1bd1f6d7"), "Joanne4@hotmail.com", "Creola", "O'Kon", "882-799-9888 x88930", new Guid("a74203f2-2ae5-4b06-9824-232c1f3b18ab") },
                    { new Guid("395081a5-622d-4004-b761-83ad9ae26fbe"), "Lavada32@yahoo.com", "Americo", "Bartoletti", "390.708.2708", new Guid("f5343a02-b09b-4f57-ac0e-575b13de1445") },
                    { new Guid("3b36266d-b5de-410a-b77e-0cd827aa8d91"), "Jared83@gmail.com", "America", "Kiehn", "1-335-442-6404", new Guid("f0a653ba-ce83-4be1-bdc3-7fa18bcaa336") },
                    { new Guid("3c1a503b-1440-483f-bfc0-bf3a21c5c556"), "Keenan.Quigley3@gmail.com", "Jamil", "Greenholt", "855.798.5918", new Guid("23cfa208-b631-4ba6-bad6-2c8677366d74") },
                    { new Guid("4255d815-230c-4d7a-8dc9-3dd27c0343f2"), "Kirk.Hirthe@hotmail.com", "Rahul", "Rosenbaum", "(835) 942-1252", new Guid("57d569c7-c2cd-4a26-bc06-d91215ce8679") },
                    { new Guid("42f32d3b-131e-429b-9856-5c3caaaf4e81"), "Estel.Stracke53@gmail.com", "Felton", "Stroman", "794.759.8258 x746", new Guid("9c441f04-76c9-4073-b526-a7059a86e736") },
                    { new Guid("45180c62-aa65-4467-9226-b7f0f1fcaf76"), "Alana_Blick93@gmail.com", "Joanie", "Parker", "954.561.8202 x3023", new Guid("653da33b-ec3f-4a86-a2d7-cf287a21e314") },
                    { new Guid("4518be48-7557-476e-957b-28bb4c91b8b4"), "Everardo36@gmail.com", "Candace", "Hartmann", "1-716-974-7793", new Guid("33ea0be7-2d72-4bc8-be83-f0189aa7a599") },
                    { new Guid("45bd4f03-fa50-4027-9d0e-07988fb8c4b9"), "Lea_Huels10@gmail.com", "Kian", "Roob", "1-238-725-9115 x050", new Guid("f63f8777-b8c1-442b-949c-db2dad9123a8") },
                    { new Guid("48dfdcfe-8235-49bf-a3a2-d1cfd537442b"), "Laury71@yahoo.com", "Bradford", "Jakubowski", "1-365-238-3264 x9408", new Guid("5bb29662-7f57-44ae-a419-a65337d19f42") },
                    { new Guid("4d22949a-5090-49da-99bf-ba06fc7c56dd"), "Cassidy_Beer91@hotmail.com", "Betsy", "Beer", "218-559-5973 x58849", new Guid("9c8f97fa-501e-47a8-ba70-557d1fc1c2d5") },
                    { new Guid("4d2f9ed9-1bd0-4e02-8148-6a3ef97717a4"), "Rasheed95@yahoo.com", "Tremaine", "Weimann", "226-262-3026 x29407", new Guid("96fe5d56-be84-4f3e-a725-5df6f79f63e3") },
                    { new Guid("4db7cc68-743a-4b00-9ef2-1cbf0bf578a4"), "Margarete45@gmail.com", "Jermaine", "Purdy", "1-471-580-7999 x56735", new Guid("f6d05f4c-057c-4675-80fb-387ef4f24aaa") },
                    { new Guid("4e5945c4-63d1-4f93-b154-790e134de06c"), "Flossie_Crooks76@yahoo.com", "Kolby", "Prosacco", "848.813.8898", new Guid("d8a361f7-1753-4b74-9717-dd86805a15ff") },
                    { new Guid("50123aee-3a5b-4f68-a18c-93aa146ea4c6"), "Ashley97@yahoo.com", "Jalon", "Becker", "880-655-7560", new Guid("add6cfd3-1ba6-4a7d-bef3-e0a63d0d56a1") },
                    { new Guid("50e7319c-24cf-4e14-bb59-8ee6f0a1e286"), "Katharina_Spinka80@hotmail.com", "Turner", "Olson", "229.490.8201 x2620", new Guid("45f72d07-b3b7-448f-8856-e1d9def8717f") },
                    { new Guid("5281967c-2758-4af4-91a0-097e77fb3394"), "Lou_Little@gmail.com", "Rachel", "Braun", "(261) 260-1125 x664", new Guid("d264f91e-0203-42a4-9eac-59bc4a1f2327") },
                    { new Guid("554bf0a1-1512-4ade-977d-79d77cf3a822"), "Bonnie62@yahoo.com", "Kianna", "Gulgowski", "609-696-9045 x863", new Guid("5672183f-5e47-462d-8ac8-70ab22be0919") },
                    { new Guid("5b891731-5cad-4a21-b3a7-c0465d2bcdd5"), "Constantin_Langworth@hotmail.com", "Bernita", "Mueller", "1-552-342-4835 x9263", new Guid("4967fcac-5adb-47d3-8c51-82f7a67d0e86") },
                    { new Guid("5d34dfc5-8aa6-48ed-b228-e7256bc8be7b"), "Vivian60@hotmail.com", "Aileen", "Gorczany", "1-307-203-4041", new Guid("378776b7-cb79-4331-afe0-3de5c20933e2") },
                    { new Guid("5e3260c4-9134-4f7b-87c2-292adad0fa90"), "Samantha54@gmail.com", "Avis", "Gerlach", "1-239-699-6658 x3431", new Guid("c27c7992-56bd-4798-9a60-ca7619f23959") },
                    { new Guid("5eaea798-c8dd-4509-8b0a-52464b3c7fb4"), "Elda64@yahoo.com", "Delta", "Heidenreich", "411-922-3558", new Guid("f7ab5d6e-8f89-4d4a-8a23-1236e0e7a426") },
                    { new Guid("62c49b0c-6d5d-4a7f-90bc-8cbd0558100c"), "Annetta_Harris6@yahoo.com", "Shawna", "Powlowski", "1-777-663-9773", new Guid("e81c3404-6572-44ba-b4ac-629586d8d2c6") },
                    { new Guid("63c0b037-7ed6-40da-971d-7ea97547f205"), "Roslyn44@hotmail.com", "Jeremie", "Langosh", "681.398.5031 x26056", new Guid("b93a0040-17ba-43e1-8923-2136ef4692e1") },
                    { new Guid("69c27c5a-aa5b-40e6-a25e-24a1294ab112"), "Laverna_Toy55@yahoo.com", "Jayson", "Mohr", "(391) 795-9491 x6200", new Guid("18e57f54-7856-4d25-969e-6d9d2c03506f") },
                    { new Guid("6d4b7ab3-8a0b-4461-b232-2677ce4a374c"), "Timothy.Blick@gmail.com", "Patricia", "Kunde", "758-408-3735", new Guid("cce4f137-bb64-4659-bef1-94f49a355054") },
                    { new Guid("6eb65722-7834-44a4-81c7-bc4435d45061"), "Kristoffer_Kling29@gmail.com", "Michale", "Breitenberg", "1-413-533-5835 x889", new Guid("d736f790-9338-450a-933e-bbe65bc8de3d") },
                    { new Guid("72ed0250-dba2-4d0b-bdd5-497cf991fc80"), "Monte_Runolfsdottir@hotmail.com", "Parker", "Bechtelar", "320.352.3542", new Guid("96312c40-b798-4e11-8464-523e8c6713fd") },
                    { new Guid("757197d6-a20f-4e7c-9799-40476164a764"), "Teresa.Funk93@yahoo.com", "Mathew", "Mohr", "606.730.8284 x784", new Guid("2bc595d4-55b3-4e8b-a944-298189d4eb1b") },
                    { new Guid("76dc63f4-bf66-4da2-bc18-e21855d93a77"), "Jazmyne22@yahoo.com", "Laila", "Rice", "1-705-696-1103", new Guid("962432c5-ec46-4176-8483-c9facaccd3f6") },
                    { new Guid("77579639-6d35-4833-aed6-00c9de0319ec"), "Mortimer_Jenkins@gmail.com", "Aliya", "Will", "1-225-572-3008", new Guid("e2721253-4e39-4473-8089-b435f5a1d5fc") },
                    { new Guid("78b0fbf3-8713-4f88-97b7-6685ef9ccc8b"), "Trenton_OReilly53@yahoo.com", "Russell", "Rau", "465.606.5945 x5131", new Guid("0087c1e7-244a-4ded-955a-7816ac19ea0c") },
                    { new Guid("7a9f9f68-d793-4344-8e20-b65c0f09b2e1"), "Winifred.OConner@yahoo.com", "Vada", "Nolan", "(966) 790-5287 x573", new Guid("d8ac9efe-89cb-46c5-b7cb-c14ba850ca43") },
                    { new Guid("7f6b9a00-1d72-4549-835f-ff4e9fd96e12"), "Jakayla80@gmail.com", "Austin", "Botsford", "(392) 913-0735 x05641", new Guid("3e10acbb-8b08-4033-8041-ea58322e8f7d") },
                    { new Guid("7fff12a1-f1be-4bb9-b5f2-a3eaa321e537"), "Giles.Walsh@hotmail.com", "Jayne", "Green", "542.661.8621 x154", new Guid("9cb5d755-7b91-40f5-a469-067d841c7eb9") },
                    { new Guid("80097957-9d9f-4e23-a600-867617a29462"), "Janelle_Durgan15@gmail.com", "Kamren", "Von", "766.356.0208 x8022", new Guid("ae1c13d9-6c04-4e70-98b2-5263f74e82a5") },
                    { new Guid("8249f394-ac27-4efd-ae55-4554ad7557c4"), "Genesis.Dickinson@hotmail.com", "Joannie", "DuBuque", "279-881-8195 x99352", new Guid("a62735dc-a618-4e71-bfef-cf8b7a31d11a") },
                    { new Guid("8472c2a2-51e9-4700-a0a9-19cdfb964ba1"), "Davion42@gmail.com", "Alba", "Ruecker", "1-385-223-9964 x4915", new Guid("86600e35-1023-4a39-9b69-af1082d29746") },
                    { new Guid("847451fb-eb28-4704-b013-e699cdafe3f7"), "Veda.Windler19@yahoo.com", "Alexis", "Weber", "1-465-297-4801 x189", new Guid("95839ddd-c584-474f-a782-4592acbda97f") },
                    { new Guid("84c92703-589c-451a-8239-ebb3d7ce4757"), "Ceasar.Konopelski@gmail.com", "Cindy", "Jones", "625.410.0615 x746", new Guid("53a7e9ab-f57a-4a6f-99bf-953b93c8f9b8") },
                    { new Guid("852269e6-0ce4-4f49-9f9a-6ac0da874a6d"), "Ahmed14@yahoo.com", "Toney", "Cremin", "(442) 676-4593", new Guid("44072a48-1a0e-4057-8374-a4cc33775a82") },
                    { new Guid("85f41c1b-e160-4a45-9e5c-d02005065add"), "Hellen.Kunze85@yahoo.com", "Tanner", "Gutkowski", "1-699-790-8787", new Guid("1be00318-93c3-4b14-8d2d-c754962929b7") },
                    { new Guid("8967678b-1fc0-4fca-949b-1682b45255e7"), "Tiffany_Walsh@hotmail.com", "Candelario", "Dickens", "(990) 965-1408 x760", new Guid("3d36eb12-1927-4e3f-b81a-e438e5ff31ce") },
                    { new Guid("8d014b14-d002-4652-b0b6-80834a6f41bf"), "Kristin.Koepp39@yahoo.com", "Jailyn", "Schaefer", "431.977.8727", new Guid("607996c4-2c20-4097-91f0-8273409171e9") },
                    { new Guid("8fc2cf6f-9ffc-4b11-bb61-c1e349223577"), "Martina.Cronin91@gmail.com", "Gordon", "Jacobs", "628-346-4849 x2947", new Guid("27a3fdac-1097-4518-8865-3c669e4cc328") },
                    { new Guid("922d75f4-22b0-4aef-96f0-5280ebc724f7"), "Darion_Corkery@hotmail.com", "Elizabeth", "Welch", "(283) 892-0449", new Guid("2a0eb47c-6759-4c5b-8bed-4dea7d9082cf") },
                    { new Guid("9537d340-5d5c-4cdc-82e3-d8e118f1b8b1"), "Lafayette.Nitzsche@yahoo.com", "Robert", "Hegmann", "896.884.9225 x93571", new Guid("efb681ee-ae4d-4965-a4cc-f25725b115b0") },
                    { new Guid("962040f8-5c3e-4aaa-afc4-b3297de9a869"), "Elsie_Kassulke@hotmail.com", "Arlene", "Pfeffer", "592-666-9876", new Guid("b06fb151-df55-426c-856f-50e606867310") },
                    { new Guid("96759d1d-818b-4f27-b39d-2830de231462"), "Bradley64@gmail.com", "Rogelio", "Reynolds", "1-357-492-5401 x1860", new Guid("39288488-91e8-40b6-9a46-06937b59172a") },
                    { new Guid("96dbf0a1-06f0-4129-9640-e87e451c686e"), "Alena2@hotmail.com", "Eden", "Buckridge", "(556) 945-1529 x1653", new Guid("624c4c02-e05c-4dd1-881d-8022761abf47") },
                    { new Guid("96f7d278-be9c-43b9-a3c1-0e297713802e"), "Arden17@hotmail.com", "Fiona", "Stamm", "1-403-780-8113", new Guid("4b7d41ff-d2a2-471e-b453-364a957743ef") },
                    { new Guid("97818aea-a602-4e9f-bc4b-79f11cbc82a1"), "Jairo.Erdman52@gmail.com", "Cristobal", "Lind", "417-564-6980", new Guid("2cadaa99-a4ca-4470-8372-4c08abd12619") },
                    { new Guid("9846dacf-4be5-441a-9516-0bd640c4de42"), "Sadie7@hotmail.com", "Jeanne", "Lebsack", "451-255-5883 x316", new Guid("2fe32966-67c9-4e66-b18a-8c5aea8e7d8f") },
                    { new Guid("9c010b46-cda5-4606-87b5-8b06659fb0a3"), "Jeremie_Larson17@yahoo.com", "Mercedes", "Schroeder", "226-801-9462 x27884", new Guid("77317fc8-ad2b-45d0-8af6-82c0ac6cc8c4") },
                    { new Guid("9f47d88b-1e75-492c-97f2-06d1137feb82"), "Johann25@yahoo.com", "Onie", "Kuhic", "765-841-2331 x93395", new Guid("05833a74-87b7-44e7-9532-ef09ec49324e") },
                    { new Guid("a1607d61-4005-4426-82d4-6c3d88756eed"), "Eileen.Stoltenberg@hotmail.com", "Leanna", "Glover", "1-465-646-3520 x186", new Guid("68d1547b-8e82-41ac-a9ee-780f4bf4a8a1") },
                    { new Guid("a5ad9458-96fe-4528-9db7-3b5215ef9463"), "Joelle.Kovacek@hotmail.com", "Saul", "Stoltenberg", "1-350-946-7904", new Guid("e67d2e05-1128-4e51-a7c8-5a7742d7f020") },
                    { new Guid("a848adaa-529d-4ecd-a1e4-b2fa83ba9667"), "Hank_Mraz41@hotmail.com", "Albertha", "Bartoletti", "(878) 249-3988 x60348", new Guid("7a2d57a6-48a3-40e9-8590-9b6932daf049") },
                    { new Guid("ab4e244f-67f9-4494-8879-044cc0d7bd0f"), "Amalia93@hotmail.com", "Gretchen", "Ryan", "1-740-874-6599 x5191", new Guid("7e1b3ab1-8064-490b-9e4b-1dbcf8822493") },
                    { new Guid("abc32456-dbee-4936-b7e0-98be81d6fc6e"), "Rhoda22@hotmail.com", "Verona", "Collins", "1-586-323-0023 x205", new Guid("bbc5a991-a45d-42e7-aa6f-047ad6839197") },
                    { new Guid("ad013950-9b81-4f46-bcef-ad20432eda3f"), "Mallory_Hoeger@hotmail.com", "Ryleigh", "Parker", "1-377-780-8255 x4332", new Guid("09e508f9-03c1-42cb-bc80-6d5af76298c0") },
                    { new Guid("ad15b9e0-8cdc-40cf-8818-2c7264f4b297"), "Emmalee.Quitzon@hotmail.com", "Claudine", "Pagac", "397.433.2795 x832", new Guid("5063f017-7172-47c3-9851-62c9d504b39a") },
                    { new Guid("b0853972-9e3c-460a-a52e-90a12feede80"), "Kadin52@gmail.com", "Nia", "Altenwerth", "541.630.4293 x52107", new Guid("25916132-b0d2-4ac3-9ecd-f615db261646") },
                    { new Guid("b564b3d9-158d-47be-aba4-5c5922fd234c"), "Jermey.Wisoky8@hotmail.com", "Orpha", "Hartmann", "232.897.4507", new Guid("3c51f4f6-2889-421e-9fc9-e58ab2d622af") },
                    { new Guid("c08e74e3-c324-47bc-98ed-2efd49b58a5e"), "Mervin.Marvin@hotmail.com", "Jewel", "Ryan", "(363) 774-5865", new Guid("53ef54bf-1f82-4377-b676-245f87825890") },
                    { new Guid("c0bc5c5c-9d9b-46f2-b828-9a83cd512e62"), "Destin23@hotmail.com", "Kenny", "Conn", "570-851-3326", new Guid("4592969b-9b03-40bd-86f2-808bd278418f") },
                    { new Guid("c0c8737b-2839-4fc2-b42f-3332e6a970e4"), "Aron.Lockman@yahoo.com", "Judah", "Koelpin", "1-746-420-0622 x7248", new Guid("45a7c36b-c974-4708-9a47-645f45bbad2b") },
                    { new Guid("c42e5cc5-6a03-4433-b8f1-69035108b239"), "Robbie_Hirthe@yahoo.com", "Virgie", "Rippin", "1-981-316-6636 x453", new Guid("c694f202-30ba-4ed9-bb8d-95d87e7db905") },
                    { new Guid("c48dc928-28c9-4ad5-9ee2-f69b5c581150"), "Geovany.Jenkins59@hotmail.com", "Toni", "White", "378-794-2050", new Guid("323af1ed-d79e-46f3-8133-d39ae6f3a6a9") },
                    { new Guid("c6cb2599-607d-43a8-a0e4-17ca80dfabe6"), "Nathen17@gmail.com", "Anne", "Lowe", "919.469.9184 x890", new Guid("70ff9674-c5c6-4700-b972-1dd3c332acdf") },
                    { new Guid("c80e6c7d-0297-4390-a092-7126d2b21150"), "Naomi21@hotmail.com", "Joey", "Spencer", "1-840-214-1407 x892", new Guid("b792036e-3ef1-4614-a3be-3002618ce141") },
                    { new Guid("c8a0603b-f395-4bc6-8a43-b68001d25795"), "Krystal_Mayer49@gmail.com", "Justina", "Okuneva", "(738) 688-4588 x95883", new Guid("9d02ccd5-eaf9-4295-922e-d38b97f8509f") },
                    { new Guid("ce3a5b7e-5520-44ee-b1c4-f94bb29d1744"), "Daija35@hotmail.com", "Aglae", "Swaniawski", "552-711-3537", new Guid("c851fbff-55b4-4e37-a8c6-d66928dd67ec") },
                    { new Guid("d0242af8-aac0-4973-8f6e-cb53ee65bd60"), "Reuben13@yahoo.com", "Raoul", "Smith", "1-305-334-4881 x42548", new Guid("e6912140-10d6-4664-a693-a88adb49f922") },
                    { new Guid("d16dd45e-edc4-4267-84e6-24c9be9f47ea"), "Guiseppe_Jerde60@hotmail.com", "Arno", "Schamberger", "1-710-306-5684 x215", new Guid("a0329e08-e3d4-44c4-b40c-1f169da91ed9") },
                    { new Guid("d8f3fd14-9bf6-481e-8545-39af37d14cb8"), "Elise_Nitzsche70@hotmail.com", "Turner", "Russel", "922.627.9080 x7982", new Guid("c0fdccca-d6a3-415f-8fc2-0791b3865673") },
                    { new Guid("d97d52cd-f1c0-430c-aaee-65ecf96af4ad"), "Mohammed.Ankunding@gmail.com", "Erin", "Doyle", "228.369.8345 x319", new Guid("34ecd90f-09c0-43f1-bcf7-124e801e7c11") },
                    { new Guid("dacc177a-3a39-4f39-aeac-810d1f4d1d3c"), "Santina45@yahoo.com", "Delores", "Cole", "473.683.8616", new Guid("43462802-03c6-4d5a-a9b4-ab9fcbf6370e") },
                    { new Guid("daed3afd-8333-4e17-bc21-e22e938a421a"), "Mia36@hotmail.com", "Elza", "Gottlieb", "(564) 834-2989 x5702", new Guid("7ad45e50-e0fd-4a05-a1f3-3a8f4515ef8b") },
                    { new Guid("db743138-cc59-4280-b9aa-cd6c28ff56ed"), "Bertha_Kunze@yahoo.com", "Monserrat", "Windler", "1-744-267-7266 x0394", new Guid("b32a154a-cdb1-4adc-acad-098b079bb133") },
                    { new Guid("e0047444-3551-423b-84d3-35f1e0c283e2"), "Rodrick11@hotmail.com", "Jedediah", "Carter", "741-244-4013", new Guid("2f999c4d-ea66-484c-97d6-4d2387203416") },
                    { new Guid("e32296f1-29bf-4e8f-b468-7236f0daaa25"), "Vella.Hilll44@hotmail.com", "Albertha", "Rath", "943.964.5136 x3229", new Guid("6db1af4e-0c21-403e-b9a2-55b0e588fc71") },
                    { new Guid("e5554b69-97fb-4310-911e-c3c049240e7c"), "Liana_Nolan43@hotmail.com", "Skye", "Beier", "845.879.2752 x9148", new Guid("8a22537f-9863-4960-9fd0-39bc22fcd87d") },
                    { new Guid("e6884c93-ffa4-443b-969e-0504fb803114"), "Mariela_Berge94@gmail.com", "Melyssa", "Littel", "1-843-250-2678 x10129", new Guid("53210b7f-0382-41ff-84ad-07e5545a24a8") },
                    { new Guid("e80c23e5-9264-4a2d-8fb8-50438c4f1a66"), "Fritz_OKon57@yahoo.com", "Bo", "Sauer", "(977) 399-8582", new Guid("b18799c7-0bb0-436a-8090-5d30196c9c6f") },
                    { new Guid("e902924e-65fb-4e47-a9a4-58c5be282edb"), "Elisabeth.Ritchie25@hotmail.com", "Ayla", "Kunze", "1-967-542-8502", new Guid("bce61c2a-f55e-4ec0-8c54-203467a26aa4") },
                    { new Guid("e93590c7-7ca6-42a3-a35f-200cc203c193"), "Madaline.Turner@gmail.com", "Junius", "Huels", "1-354-504-8349 x13352", new Guid("9f534456-fa08-463b-9d12-e16947674e44") },
                    { new Guid("e9d35c34-1f01-434c-a349-a43d5dcfdac7"), "Trenton.Homenick@yahoo.com", "Payton", "Mitchell", "547-303-9153 x94822", new Guid("b896db69-7f07-4f64-807a-521849a8cb4a") },
                    { new Guid("ed5a38fc-d644-4f61-b155-054e8b5a9a9c"), "Devyn49@yahoo.com", "Rhianna", "Monahan", "787-676-8320 x5240", new Guid("e0c8fa63-ef8b-41e6-b1b2-055799ef3b9e") },
                    { new Guid("f529bd43-e30f-403f-8d25-301e997b6cc7"), "Weldon.Lemke@hotmail.com", "Caesar", "McClure", "429.666.9564 x6203", new Guid("4b38f6dc-8bd7-44b3-9d2e-616dab55c9e1") },
                    { new Guid("fa57d13e-34c4-4978-bdee-2929a59353ba"), "Blaise.Turcotte30@yahoo.com", "Emelia", "Kohler", "1-996-825-3658", new Guid("33d75741-ead1-45b1-9889-e3631a23be0c") }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("18def712-c3df-499b-aa61-f853e1e2aa74"), new Guid("76dc63f4-bf66-4da2-bc18-e21855d93a77"), new DateTime(2024, 1, 27, 9, 45, 3, 696, DateTimeKind.Utc).AddTicks(256), new DateTime(2023, 12, 29, 16, 53, 41, 403, DateTimeKind.Utc).AddTicks(5537), new Guid("e2721253-4e39-4473-8089-b435f5a1d5fc") },
                    { new Guid("6583e66d-8d0c-437d-a9bd-c4501ba09141"), new Guid("356c4c87-caf6-413d-a353-868e1bd1f6d7"), new DateTime(2024, 1, 3, 20, 45, 44, 407, DateTimeKind.Utc).AddTicks(4375), new DateTime(2023, 8, 15, 0, 18, 2, 337, DateTimeKind.Utc).AddTicks(7740), new Guid("3e10acbb-8b08-4033-8041-ea58322e8f7d") },
                    { new Guid("6a6aa0a4-6300-485a-ac3f-2eea7a84bf60"), new Guid("72ed0250-dba2-4d0b-bdd5-497cf991fc80"), new DateTime(2024, 3, 29, 3, 52, 32, 935, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 5, 21, 7, 41, 44, 197, DateTimeKind.Utc).AddTicks(4786), new Guid("60d86345-d960-41ca-bdd2-e1a7c069b541") },
                    { new Guid("8794ebcd-07e2-4ae2-8848-e13994bf785c"), new Guid("10e9d462-670e-45e2-a2b6-45b40812499e"), new DateTime(2023, 11, 22, 11, 49, 49, 427, DateTimeKind.Utc).AddTicks(6227), new DateTime(2023, 11, 3, 22, 12, 42, 409, DateTimeKind.Utc).AddTicks(4146), new Guid("b9c53563-32de-4bef-8419-420138628da7") },
                    { new Guid("d76fc770-d801-47da-86df-afeead81ee68"), new Guid("d97d52cd-f1c0-430c-aaee-65ecf96af4ad"), new DateTime(2023, 12, 15, 15, 40, 17, 215, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 10, 10, 4, 51, 21, 52, DateTimeKind.Utc).AddTicks(6353), new Guid("d264f91e-0203-42a4-9eac-59bc4a1f2327") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("01a664bf-2b7e-4dca-b81e-9ab935e71b75"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("053cfe2f-9238-4bf3-87a6-5d380811ee8c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("06793c74-abdb-4575-8f81-6d79b70657ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0744d0b0-3a15-46c5-829a-7a8070eb697a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("08f6511f-433f-4351-aee6-1e81b210a1e6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("09e1fdf2-7881-42da-bd03-af61526af443"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0a3ac469-370e-46cf-b303-76350c5f4fab"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0a422fe1-3893-4c0c-b037-7e7c3b23dc9f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0a82d1de-a38f-4437-a331-53cd0c4b0943"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0b17afaa-58f6-4377-a28e-d84b3b69df98"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0f60f5f8-4b07-4bad-a41a-9dcfa487c1f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("133f2844-d9d5-4902-b76e-935c7753ba91"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("163a3302-1efc-4143-9f35-0fc29d51b8e3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("17c1393e-0ee9-4202-96b5-ec736017fff7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("190e0167-636e-4513-81cf-53b6ce643264"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("19eed56d-5c0f-4146-ba60-cb6e84b9dd97"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1d8cd704-ca38-424e-a425-745e7c4cba91"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1efdf8b4-2589-4ec8-8474-bfac9101441d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("21818b7f-0808-4e70-9d03-d80900a2d07d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2182688f-d9ae-4c46-af74-d2bf2c7d00ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("24c0a221-3f17-48dd-adee-778ad6d581d2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("26994f23-c146-4d78-a1cc-e880a1fd8dfb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("26aff0d8-5a57-465a-adbc-ec2036806ffa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2a5a9153-c5e3-460d-bbdd-bcb8558cb9a9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2b407d9a-b070-4987-a375-66ac1657da9a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2e672717-8f42-4962-8cc8-1315d844cf11"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2eb67ee1-2f20-4902-9cd1-050b812569f4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("309d5356-15d1-403c-b8bb-b1199706345d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("310ac8f3-a6ab-4acd-8452-95925b944ddd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("31fd0929-4692-420d-a805-a10436db4b6c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("32512f63-4076-44f9-82a4-8a927c0ff560"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("33a2104e-c4a4-4ba0-8e5b-79ae0aca7f3c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("347490d8-f0e3-47e8-9134-f28ea8ba516f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("395081a5-622d-4004-b761-83ad9ae26fbe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3b36266d-b5de-410a-b77e-0cd827aa8d91"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3c1a503b-1440-483f-bfc0-bf3a21c5c556"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4255d815-230c-4d7a-8dc9-3dd27c0343f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("42f32d3b-131e-429b-9856-5c3caaaf4e81"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("45180c62-aa65-4467-9226-b7f0f1fcaf76"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4518be48-7557-476e-957b-28bb4c91b8b4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("45bd4f03-fa50-4027-9d0e-07988fb8c4b9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("48dfdcfe-8235-49bf-a3a2-d1cfd537442b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4d22949a-5090-49da-99bf-ba06fc7c56dd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4d2f9ed9-1bd0-4e02-8148-6a3ef97717a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4db7cc68-743a-4b00-9ef2-1cbf0bf578a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4e5945c4-63d1-4f93-b154-790e134de06c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("50123aee-3a5b-4f68-a18c-93aa146ea4c6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("50e7319c-24cf-4e14-bb59-8ee6f0a1e286"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5281967c-2758-4af4-91a0-097e77fb3394"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("554bf0a1-1512-4ade-977d-79d77cf3a822"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5b891731-5cad-4a21-b3a7-c0465d2bcdd5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5d34dfc5-8aa6-48ed-b228-e7256bc8be7b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5e3260c4-9134-4f7b-87c2-292adad0fa90"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5eaea798-c8dd-4509-8b0a-52464b3c7fb4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("62c49b0c-6d5d-4a7f-90bc-8cbd0558100c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("63c0b037-7ed6-40da-971d-7ea97547f205"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("69c27c5a-aa5b-40e6-a25e-24a1294ab112"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6d4b7ab3-8a0b-4461-b232-2677ce4a374c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6eb65722-7834-44a4-81c7-bc4435d45061"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("757197d6-a20f-4e7c-9799-40476164a764"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("77579639-6d35-4833-aed6-00c9de0319ec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("78b0fbf3-8713-4f88-97b7-6685ef9ccc8b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7a9f9f68-d793-4344-8e20-b65c0f09b2e1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7f6b9a00-1d72-4549-835f-ff4e9fd96e12"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7fff12a1-f1be-4bb9-b5f2-a3eaa321e537"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("80097957-9d9f-4e23-a600-867617a29462"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8249f394-ac27-4efd-ae55-4554ad7557c4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8472c2a2-51e9-4700-a0a9-19cdfb964ba1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("847451fb-eb28-4704-b013-e699cdafe3f7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("84c92703-589c-451a-8239-ebb3d7ce4757"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("852269e6-0ce4-4f49-9f9a-6ac0da874a6d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("85f41c1b-e160-4a45-9e5c-d02005065add"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8967678b-1fc0-4fca-949b-1682b45255e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8d014b14-d002-4652-b0b6-80834a6f41bf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8fc2cf6f-9ffc-4b11-bb61-c1e349223577"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("922d75f4-22b0-4aef-96f0-5280ebc724f7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9537d340-5d5c-4cdc-82e3-d8e118f1b8b1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("962040f8-5c3e-4aaa-afc4-b3297de9a869"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("96759d1d-818b-4f27-b39d-2830de231462"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("96dbf0a1-06f0-4129-9640-e87e451c686e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("96f7d278-be9c-43b9-a3c1-0e297713802e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("97818aea-a602-4e9f-bc4b-79f11cbc82a1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9846dacf-4be5-441a-9516-0bd640c4de42"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9c010b46-cda5-4606-87b5-8b06659fb0a3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9f47d88b-1e75-492c-97f2-06d1137feb82"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a1607d61-4005-4426-82d4-6c3d88756eed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a5ad9458-96fe-4528-9db7-3b5215ef9463"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a848adaa-529d-4ecd-a1e4-b2fa83ba9667"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ab4e244f-67f9-4494-8879-044cc0d7bd0f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("abc32456-dbee-4936-b7e0-98be81d6fc6e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ad013950-9b81-4f46-bcef-ad20432eda3f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ad15b9e0-8cdc-40cf-8818-2c7264f4b297"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b0853972-9e3c-460a-a52e-90a12feede80"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b564b3d9-158d-47be-aba4-5c5922fd234c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c08e74e3-c324-47bc-98ed-2efd49b58a5e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c0bc5c5c-9d9b-46f2-b828-9a83cd512e62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c0c8737b-2839-4fc2-b42f-3332e6a970e4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c42e5cc5-6a03-4433-b8f1-69035108b239"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c48dc928-28c9-4ad5-9ee2-f69b5c581150"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c6cb2599-607d-43a8-a0e4-17ca80dfabe6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c80e6c7d-0297-4390-a092-7126d2b21150"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c8a0603b-f395-4bc6-8a43-b68001d25795"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ce3a5b7e-5520-44ee-b1c4-f94bb29d1744"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d0242af8-aac0-4973-8f6e-cb53ee65bd60"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d16dd45e-edc4-4267-84e6-24c9be9f47ea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d8f3fd14-9bf6-481e-8545-39af37d14cb8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("dacc177a-3a39-4f39-aeac-810d1f4d1d3c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("daed3afd-8333-4e17-bc21-e22e938a421a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("db743138-cc59-4280-b9aa-cd6c28ff56ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e0047444-3551-423b-84d3-35f1e0c283e2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e32296f1-29bf-4e8f-b468-7236f0daaa25"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e5554b69-97fb-4310-911e-c3c049240e7c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e6884c93-ffa4-443b-969e-0504fb803114"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e80c23e5-9264-4a2d-8fb8-50438c4f1a66"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e902924e-65fb-4e47-a9a4-58c5be282edb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e93590c7-7ca6-42a3-a35f-200cc203c193"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e9d35c34-1f01-434c-a349-a43d5dcfdac7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ed5a38fc-d644-4f61-b155-054e8b5a9a9c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f529bd43-e30f-403f-8d25-301e997b6cc7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fa57d13e-34c4-4978-bdee-2929a59353ba"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("18def712-c3df-499b-aa61-f853e1e2aa74"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("6583e66d-8d0c-437d-a9bd-c4501ba09141"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("6a6aa0a4-6300-485a-ac3f-2eea7a84bf60"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("8794ebcd-07e2-4ae2-8848-e13994bf785c"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("d76fc770-d801-47da-86df-afeead81ee68"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("10e9d462-670e-45e2-a2b6-45b40812499e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("356c4c87-caf6-413d-a353-868e1bd1f6d7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("72ed0250-dba2-4d0b-bdd5-497cf991fc80"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("76dc63f4-bf66-4da2-bc18-e21855d93a77"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d97d52cd-f1c0-430c-aaee-65ecf96af4ad"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0087c1e7-244a-4ded-955a-7816ac19ea0c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("05833a74-87b7-44e7-9532-ef09ec49324e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("077d302f-5577-45de-8901-d83f4cf78406"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("09e508f9-03c1-42cb-bc80-6d5af76298c0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0dfb8a56-5162-4947-b931-d0c27f123b05"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("129ca150-3497-4701-8904-db16e4963283"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("18e57f54-7856-4d25-969e-6d9d2c03506f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1be00318-93c3-4b14-8d2d-c754962929b7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("238400fa-3b74-4211-ab61-b24378a0f226"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("23cfa208-b631-4ba6-bad6-2c8677366d74"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("258aaa11-c45b-4522-8ee1-460c108703c6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("25916132-b0d2-4ac3-9ecd-f615db261646"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("27a3fdac-1097-4518-8865-3c669e4cc328"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2a0eb47c-6759-4c5b-8bed-4dea7d9082cf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2bc595d4-55b3-4e8b-a944-298189d4eb1b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2cadaa99-a4ca-4470-8372-4c08abd12619"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2dda2bc7-fe0f-4e0d-a2ff-6ebe064215b8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2eb336a2-cc4a-4b2f-90c1-0d0761a07d89"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2f9973f8-7f5c-4695-95a5-3e19331df094"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2f999c4d-ea66-484c-97d6-4d2387203416"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2fe32966-67c9-4e66-b18a-8c5aea8e7d8f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("323af1ed-d79e-46f3-8133-d39ae6f3a6a9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("33d75741-ead1-45b1-9889-e3631a23be0c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("33ea0be7-2d72-4bc8-be83-f0189aa7a599"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("378776b7-cb79-4331-afe0-3de5c20933e2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("39288488-91e8-40b6-9a46-06937b59172a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3c51f4f6-2889-421e-9fc9-e58ab2d622af"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3d36eb12-1927-4e3f-b81a-e438e5ff31ce"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3e10acbb-8b08-4033-8041-ea58322e8f7d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3e62094d-2b3a-4a67-9546-9aee715a0a38"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("41262f6b-c810-4228-9e77-279931dbbd3a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("41bb7078-a8e0-44be-9980-ee49fd2e03af"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("43462802-03c6-4d5a-a9b4-ab9fcbf6370e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("44072a48-1a0e-4057-8374-a4cc33775a82"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4592969b-9b03-40bd-86f2-808bd278418f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("45a7c36b-c974-4708-9a47-645f45bbad2b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("45f72d07-b3b7-448f-8856-e1d9def8717f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4967fcac-5adb-47d3-8c51-82f7a67d0e86"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4b38f6dc-8bd7-44b3-9d2e-616dab55c9e1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4b7d41ff-d2a2-471e-b453-364a957743ef"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5063f017-7172-47c3-9851-62c9d504b39a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("53210b7f-0382-41ff-84ad-07e5545a24a8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("53a7e9ab-f57a-4a6f-99bf-953b93c8f9b8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("53ef54bf-1f82-4377-b676-245f87825890"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5672183f-5e47-462d-8ac8-70ab22be0919"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("57d569c7-c2cd-4a26-bc06-d91215ce8679"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5bb29662-7f57-44ae-a419-a65337d19f42"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5cb03a6e-3b29-4e24-a4c8-0ae11d8efb83"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("607996c4-2c20-4097-91f0-8273409171e9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("60d86345-d960-41ca-bdd2-e1a7c069b541"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("624c4c02-e05c-4dd1-881d-8022761abf47"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("653da33b-ec3f-4a86-a2d7-cf287a21e314"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("68d1547b-8e82-41ac-a9ee-780f4bf4a8a1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6cf5fcfb-605c-47c6-a420-9bc70acacecf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6db1af4e-0c21-403e-b9a2-55b0e588fc71"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("70ff9674-c5c6-4700-b972-1dd3c332acdf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("77317fc8-ad2b-45d0-8af6-82c0ac6cc8c4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7a2d57a6-48a3-40e9-8590-9b6932daf049"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ad45e50-e0fd-4a05-a1f3-3a8f4515ef8b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7e1b3ab1-8064-490b-9e4b-1dbcf8822493"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ea6792e-6ff0-4b06-af0f-71e3a8984335"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8650a7f6-06cd-4015-96db-f14f3e208a82"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("86600e35-1023-4a39-9b69-af1082d29746"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8a22537f-9863-4960-9fd0-39bc22fcd87d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8cc7f4bb-0195-4066-9ce8-cb64605ae79e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8e65b189-b73d-466b-97ae-dd4fb340287b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9566f16d-0105-4c11-aff7-bced4be5d251"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("95839ddd-c584-474f-a782-4592acbda97f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("96fe5d56-be84-4f3e-a725-5df6f79f63e3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9c441f04-76c9-4073-b526-a7059a86e736"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9c582887-f4cd-4ba5-844d-b53f23869552"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9c8f97fa-501e-47a8-ba70-557d1fc1c2d5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9cb5d755-7b91-40f5-a469-067d841c7eb9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9cb92c0f-cb12-472d-af14-4dcf88b2a2b6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9d02ccd5-eaf9-4295-922e-d38b97f8509f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9f534456-fa08-463b-9d12-e16947674e44"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a0329e08-e3d4-44c4-b40c-1f169da91ed9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a4f9c5a4-96bb-493b-814b-170b1512fc75"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a62735dc-a618-4e71-bfef-cf8b7a31d11a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("add6cfd3-1ba6-4a7d-bef3-e0a63d0d56a1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ae1c13d9-6c04-4e70-98b2-5263f74e82a5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b06fb151-df55-426c-856f-50e606867310"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b18799c7-0bb0-436a-8090-5d30196c9c6f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b32a154a-cdb1-4adc-acad-098b079bb133"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b792036e-3ef1-4614-a3be-3002618ce141"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b896db69-7f07-4f64-807a-521849a8cb4a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b93a0040-17ba-43e1-8923-2136ef4692e1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b9c53563-32de-4bef-8419-420138628da7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bbc5a991-a45d-42e7-aa6f-047ad6839197"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bcd240c5-e500-4610-ad93-7b773b3b5bdc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bce61c2a-f55e-4ec0-8c54-203467a26aa4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bd2c7c28-4365-473d-9326-4ac2018267bf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c0fdccca-d6a3-415f-8fc2-0791b3865673"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c27c7992-56bd-4798-9a60-ca7619f23959"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c694f202-30ba-4ed9-bb8d-95d87e7db905"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c851fbff-55b4-4e37-a8c6-d66928dd67ec"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cce4f137-bb64-4659-bef1-94f49a355054"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d264f91e-0203-42a4-9eac-59bc4a1f2327"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d736f790-9338-450a-933e-bbe65bc8de3d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d74eaa94-5e5a-4d3d-8574-74cc40401dd9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d8a361f7-1753-4b74-9717-dd86805a15ff"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d8ac9efe-89cb-46c5-b7cb-c14ba850ca43"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("db3110ef-4e42-4619-8c08-00a8267437e6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e0516236-d65e-4554-b47d-aba5eba0e174"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e0c8fa63-ef8b-41e6-b1b2-055799ef3b9e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e2721253-4e39-4473-8089-b435f5a1d5fc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e49df283-83f3-4cbf-a925-34a3181a6e58"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e67d2e05-1128-4e51-a7c8-5a7742d7f020"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e6912140-10d6-4664-a693-a88adb49f922"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e81c3404-6572-44ba-b4ac-629586d8d2c6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e8587f6e-55c0-48f0-8061-5899c88bbdf9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eb222bfa-54bf-4181-9ae9-cb2d38bdfe4e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eb8e4e3e-c91e-4141-bde4-ad582f43e699"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ed5335eb-6376-4f17-8e1e-fbe92bc51798"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("efb681ee-ae4d-4965-a4cc-f25725b115b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f0a653ba-ce83-4be1-bdc3-7fa18bcaa336"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f5343a02-b09b-4f57-ac0e-575b13de1445"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f63f8777-b8c1-442b-949c-db2dad9123a8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6d05f4c-057c-4675-80fb-387ef4f24aaa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f7ab5d6e-8f89-4d4a-8a23-1236e0e7a426"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("14b3149b-1914-4eb6-9636-1474569a9621"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("2433f0d1-df98-43b7-af3c-1def7079e573"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("28c943c3-4f86-4457-afba-ea5620c2f9e8"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("3de28e0d-20db-4363-8760-6faf7fd1d922"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("412352a2-191c-466e-8c0c-17923c8f045c"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("47869e57-7703-419c-868b-2ec46d88b858"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("6928d922-a7e3-46ad-aecc-0cf387ee8ab6"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("749bf410-7590-4493-85c5-a094fa8ffff8"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("95dcfc02-cc7f-42af-bc1c-f0b702518996"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("ab2821aa-6a2f-43b4-93e1-dfb5adfa4e65"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("ac531981-79a9-4100-85f7-f239c410b9d4"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("aec29edc-5a8d-41b8-be50-24989c8c845c"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("bb45c467-d14c-434b-8e81-af2b7189f3df"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("bbb8a533-7cca-4412-baea-0d89fd0786a5"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c474a3d9-2d97-4c47-b67a-0db779f909e2"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c9b70dca-5858-4ff1-aeea-62dcdcb2fcf6"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("cc5decac-d1ed-4fb4-8be6-ae41be7ec311"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("d916d9a8-c91f-48e6-b2f9-be85f81923ac"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e3f3c8ee-714f-4b80-903d-2aada9febc58"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e8e013e2-6731-4bc4-bab4-c0faa9ce01e4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("34ecd90f-09c0-43f1-bcf7-124e801e7c11"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("962432c5-ec46-4176-8483-c9facaccd3f6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("96312c40-b798-4e11-8464-523e8c6713fd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a74203f2-2ae5-4b06-9824-232c1f3b18ab"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("afcf4096-72da-4af4-8c01-fe2e9cc0054a"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4e6e4829-a563-4a87-ba62-c8904412ec96"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("3346afc6-b216-4d87-903e-db596a98c220"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("35e62fb3-d6f3-4b4a-9387-739b1c7a8498"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("4c82b429-a08e-4e56-bb53-a00e6e4c717a"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("5f648e6f-cf31-4158-8049-24309f4103e9"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("623d6cbe-a144-478e-8064-8bdd185f2918"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3142be66-531e-48e1-955d-2e62a62609f6"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("62ee0ce1-3f15-4da2-b0dd-9bac37ccad85"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("ca6004d1-ae57-41f0-8bd8-5810e45ad714"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("e94a7a01-c1c7-4f08-9ff8-fb4c4c5c24bd"));
        }
    }
}
