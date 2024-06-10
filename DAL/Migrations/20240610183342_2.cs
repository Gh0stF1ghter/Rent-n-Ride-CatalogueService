using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0119077f-bdee-4393-9351-a9ab104b1513"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("051f95b6-954b-4028-99da-f919779e95aa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("06fe5674-1fb6-4384-9f5c-7a54b22a863f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("07c41577-1d81-4e0b-a86b-fb9b2219d780"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("116e0057-c66e-44ae-a733-7b5a0ebbdd40"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("122a9387-b22c-41c1-8dda-8dee05045e50"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("12bef98d-6f68-41be-b745-43f6a83fc67c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1998aabe-f5e8-4864-91e0-c9a705106683"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1a62ac3f-31de-4e01-88d6-825c43104719"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1d11ba86-6d69-4be6-b33c-16978565867f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1f8f1033-f851-430b-8af6-6598b689a234"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("226d1fba-8841-4531-b42a-822aeabeea6d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("228c2690-ddf0-4388-a33c-bdf71a3e67de"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2497b6f5-9463-4ead-a2b3-eb499f441529"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("25911b64-2819-49a3-ac59-dd86ebee95fa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("26b544c7-9bf5-4904-b6a5-bd544a5d955a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("27e2cbd1-d9e4-478d-899c-7eea09f29292"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2d60e186-c218-4619-a378-fcc84a4738e1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2dcf406c-aeac-4e08-b955-69acc825b5f1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2e4850eb-fdcb-42c9-ac19-4f0115e94a72"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3a32d2f4-759b-42bb-8fdd-1c12cecb9351"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3cf83c26-44a0-4911-8faf-974c2c67776d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3d2a8918-6f86-4ca3-8c8e-ed00db6d2b52"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3db246e1-ee5c-40a8-87c8-ff40f7567a54"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3f48f497-dac0-44d2-b5db-da2ed25e5dc1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("433c42d5-6f4b-4b3c-96bb-ef201c9a37e0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("48f2f1b6-0a7d-4a08-918e-6b4752adc4f4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("49c59f3d-ed36-4880-8af8-e2967892870a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5006167d-171b-4675-b85a-11c55ff7cfb6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("51abeffc-7937-4a03-99e2-2e7829a7a0b5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("523f330e-a21b-42f9-bad4-92f94709de47"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("59c7a731-ed02-4e17-bd86-9154208d0cdf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5ac53b99-3171-4319-9b29-e96b18f39bd1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5b680b5d-362b-48ee-a4f1-b63fb4529a86"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5b792803-bcf5-4bce-9fc4-a34ad75df41b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5df75aa5-8492-4ece-96f9-b00f24a69de0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5eac2099-f813-43d5-a7fe-3f3d79e8cbea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6063a634-204a-4317-bbbf-4744a855483b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("60b6c491-b00e-4278-8c66-f61c1c4dab2f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6236458c-c900-4041-8745-25cf1550d5f6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("63285149-19ef-4a51-a635-4231a27c84f9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6342f603-dea0-48f5-9af4-cd5ad4e4be87"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("65648115-2f6d-49b1-b66d-acef99494d71"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6a7655da-80aa-41c9-a9cb-e964280abec2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6d3508b3-8e8c-4e37-8b7d-3ec5fee76041"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6ee9b6d3-bef2-4730-a965-2714c111977a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("705f7e49-5a19-4d5b-bee1-ebbbb929b47c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("74088a8d-3779-4a36-bbf6-ef5bf41572d8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("742296ee-902d-4552-b251-a449de3ff9bb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("773775bb-0c51-4d06-b3da-c9b2d2b819ea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("79f4f617-1907-4289-b60b-bcfc783ce6c7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7b704554-b0cd-44d6-aa6b-5c504188e316"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7c1b06bc-fd29-4c37-9a6e-6f532576453b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7c4fe8b5-97ac-4341-b98b-1f5afe28e725"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7eb76c30-ee24-4ecd-b838-9e43a6936463"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("82362023-c0a9-419a-86ba-bcc897bebd34"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8518007e-bee3-4368-ac9f-965ad4e11a88"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("85865632-4ed8-4eeb-9b83-a32204b47abb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("85af737b-7e56-4795-b809-8d3d62fd1839"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8749f172-087b-4226-8b6e-237abdaf51c8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("881f4235-d24f-4669-a974-37f17b57f91c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("88c9e95b-4210-40a8-8c26-d694fd287529"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8a0daae4-030a-4db6-80d3-2fe7c31c3dea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8abc287f-4a09-4da1-a1fe-2b1f648b48c4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8d8e6141-20c2-41db-904a-a3b86c219a46"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8f3967d9-b29a-4955-960b-1a038e8c73b7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("905c83f8-52d7-49a4-9cae-3532da2197e5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9365a67f-1c7b-4821-a9e9-ab96a2cb6cce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("94422038-5a88-4efd-8a86-d0e1c6d0053d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("99c05a0d-d61a-43b5-b566-af5655ae9b3d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("99d1a106-e515-46e4-8729-e9cb6307dd62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9d518119-c0d8-4dca-83ed-e145dbe7f8e6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9ee4c4ee-6ac0-4c98-b803-e28e1853e5e6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a2c39cd9-12bb-435f-9bb4-0975870f45c6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a92d2acb-81c9-4b22-ba61-bc35daa0786a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("aa3d96d7-ef00-415a-baac-063968d0eb7e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("acdf4d00-a322-44e4-9fb0-83d6fc29d19c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("af7f9fb9-aa49-4d3b-bf7d-7881ee74f5f1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b9151be3-964b-4a61-ac90-9399cdc2038c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bb4eb145-0b7a-4c8b-ab08-3d2842410216"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bc627863-0d12-4df4-9a57-3d101ef0f7e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bc682bdf-ef51-4a5a-a961-d770f4dff6b7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bd2032c1-5ba1-4978-b251-0c80aa86a7c4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bdc42045-dda3-4972-a231-596cefbc2093"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bef918d7-789c-43b8-a5b1-2cdd18679fcd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bff23b31-4ba2-4640-9c1e-bbc0605cb086"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c1fc2062-807c-4899-ab6b-554b4d658824"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cc22eebf-528e-4c8d-8ceb-a6393ba849a1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cd2297cb-4ef7-4074-859f-2a804519ee7b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cdb6f5bd-12c6-4ebb-842a-65037e06e779"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cdc2b2aa-87c5-4eee-a69f-3e6cea078b0d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cf24a6d3-fc7f-4f20-b186-901cef3f7ebd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d4eddeb0-5f95-460b-964f-3c541f7afbae"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d5e95ade-1f5f-4dd7-bb9d-cfbbd1d71a68"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d68f7954-f46f-4cff-85e6-8c17fd3131d0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d96d54a2-2251-4e8b-a024-c97eb093f59c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d9dfb68d-cfd8-49b3-8b7f-6dab33b933f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("db44458f-d9e6-4ab8-a39b-a7d0c7b99bda"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("dd29f833-6f98-471f-8a8e-d0a9920bdb89"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e0519ea5-3233-41c2-99b6-80c73e58c6f0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e1d5d42a-fada-421c-9760-d9da5b72a23e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e205316d-b96a-4014-9a0a-98cd9c3a8ef6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e53ceca9-3156-46dd-ba55-43e7f10b5d21"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e736192a-aa01-4952-9552-172ff7101b2e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e7f7276b-5b18-4975-a47c-4eeb93ce8767"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e8937ccc-a27a-4db0-b7a7-142c4dc7eec5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e8bb0794-2b99-44b6-9432-e1f19c28ba6d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("eb55f322-63b5-44b0-8c45-2ccfd861f9df"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ed0c965f-602e-48f0-be0c-fbf98c9082e3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f0dab059-3a09-4d28-bd5d-aa96623590ab"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f181d126-67c3-4318-bc39-f1dc619eda2e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f1e0ac55-3b37-443d-934d-4279baee2dec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f49b1296-20ac-42cb-86b3-54b99a0e24f9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f4b4d44e-6e15-4b0a-9510-ac190cd06a98"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f4cd97e1-c253-4c33-9a0a-0275e9ea04c2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f6d61270-b152-4691-b87f-bd8e5f5b8b31"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f93ee326-697c-4300-bdc2-bdaaf18cb2a5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fb294911-82a2-411e-b5e8-181c2b0df260"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fc7bacc4-4c77-4a75-90b2-c2dbc9ed103a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fee406d1-93cf-4b12-b796-b0054a6cf3a3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2962e41a-1a22-407a-8e4a-b2f220c59a9c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3fff4b64-716b-4449-9781-c665c8b16c4d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("42f68436-593e-4bec-adda-69ad4a71d4ea"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8dc75adb-15f0-47e2-9ae5-2fc5cce549a1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("eeb87c6f-8998-4ac8-ab3c-f2e32e11b8d4"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("6f5dcee0-c8a6-4f3d-860d-ee4026ebac10"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("6fd005da-ad0b-47f6-a18e-daee1e03e851"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("7ffea636-2166-4465-bfcb-9b694fb51fb8"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("8276d176-b632-4eb6-bd55-d56ef02542f5"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("b6116524-4025-4567-8a6f-2867fa15403c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1fc7dc7f-4deb-46d3-a6d3-0f968a407339"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("369f591d-922a-4a15-8551-0cddd8656981"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("43a56e64-b359-4f71-845e-580db04d9490"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("824b4f27-5bb5-4705-95df-dcaf8f54ba9b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b086a440-0e06-4452-937c-d0aa57c2ce04"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("046a7470-b7a5-4597-bd3d-f510abcab39d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("088d59f7-594d-445f-8dbf-afad4e47abdd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("09534804-ece9-4c9f-a486-c10201751d8b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0b24714f-08e9-4ae7-87c9-d63b0c6c8690"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0bd13ef4-10bb-4a82-9b03-063ac598df31"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("126c26d7-562f-4309-b4c8-09d5e4151d20"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("130e7870-8aeb-44ff-a925-300ff88768b2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("153a4e76-6294-4607-85a9-c226cfb859b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("15dbf370-fbdc-4a2f-b744-e586475d4195"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("17d0eecc-9a2c-4491-b810-774923701c2d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1909097d-00cb-4994-859a-dda666b53392"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1aea4615-8492-45f7-ac7a-63a999f09639"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1c0f49c9-a9a6-4e9d-9312-a990ac7da3e0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1e7ec0c2-37ca-480a-9fa5-a13a7b27c54d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1f093440-fe67-4fb1-bce6-6327648d2d81"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1fb84f5b-1b5a-4e7c-b94b-edd42ac6e352"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("235dd289-587f-40e0-ae1c-34e4bf09f59a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("277c04f0-5534-43e9-9329-5fe3a686bcf2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("290c9e80-2170-442d-8f12-7f13eddfb4e6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2a98538b-8352-4ea7-8147-adadff39b88d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2c58e172-2d2c-441b-85c4-0c227a77b226"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("31ecb0f5-0341-4b87-bc30-e8e582f21546"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("33a08167-e1eb-41c2-aa32-1831ef4dd422"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("36b95d43-eaa4-4431-a368-5df47d845f2f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("372371fc-7069-4538-88c0-a92581de3f53"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("382a564a-4d45-4047-9d2e-d7f66f6a711b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("39a50889-1a71-4037-af66-26a31b5ed7b4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3a2efff2-96dd-4d81-aa34-a383c63f3922"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3d3d5f43-e223-4acc-b274-a269cb80edb4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("401a8282-f667-4e27-b702-d4a62d85fded"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("40cd9aa5-2b7e-4a2a-9080-89f8ca43efd9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("41d3bb3d-085f-404a-9d03-7d5aa00cd966"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4584a699-6814-441e-b1d7-d974822fb080"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("45925cfc-c82f-4d48-a97a-9a2c900c1d52"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4650edd4-c239-40d1-9996-2c034b6ef84b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("51a3382d-34a1-46c0-bed3-91bd8d5c3761"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("52558c9f-3c52-4b07-912b-db71cb10a24e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("532f1b4f-7713-4872-9ba5-532bf7d640b3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("54684fd4-457e-435a-bfa5-09c9a23b6e85"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("54b44a54-f6ca-40be-b924-3d91e10e1548"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("57dc40b0-8fd0-406b-8aff-950c4bc689e8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5943ba8e-0207-44b0-8bca-5e5c52f0194f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("59d79065-e64d-4b1e-9d0d-1df0f878eef8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5ea53211-02c8-4973-809c-750ccbc73419"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("603aba0c-4476-402a-b861-b4e2b2cb40ed"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6199b535-8fba-4f5c-b81b-fbe346ab8849"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6235e713-4d9c-48f8-8669-2c7f829ff89e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("67cd3aff-ce12-4048-abfe-733bc1303a42"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("67f60de1-3a42-438f-815f-cb4316953a97"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6b866b81-b3b5-4e98-817e-a864fca75f16"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6ce9a573-32da-4186-9753-b9ceade93551"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("752fb4c1-673b-476e-9473-89dfde17d025"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("76065e0b-19ba-430e-9ba3-fd6acc9bf17f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("783575f9-6f31-4ca8-892e-a058be11619b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ad42b36-0dae-4318-b527-b2757240394a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7b11e8f1-d65c-404e-a2b7-a2d12331adca"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7cb666ea-79eb-42b2-b20b-a2171a9a553a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ff31899-8b8b-41a9-922d-9371b9856232"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("80a82c5b-e697-43f2-96db-62d88c6c0d8c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("821ab2da-fa1f-4120-8965-50a919525a95"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("85a56cf8-ce09-4339-a1d1-75e00174296d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("862990df-ebb9-4758-a31f-65421c5d9c94"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("875961fb-09e3-481f-98c6-9e77d2a1cb25"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8dbffae7-2862-4159-a55b-6f0875ef7c49"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8e0d97a0-8625-4486-b7a2-6cd8901de96f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8e88e16c-64c2-4bdf-9cbd-d64a62945729"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8eab7b68-e2a4-4fa3-a2ae-0366f7bd6477"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("910eb90f-32d4-47c2-91d5-4aa6b94614aa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("92ed7d9f-a2f4-4738-b77d-7e8de60613e4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("991e672b-89ba-4774-a249-11677c445949"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9aa381c1-b981-4157-9200-4b4efd255777"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9ebf6281-871b-4ad7-874f-39ba86391f24"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a01a76ff-aadf-425d-98f7-051cfcf80a95"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a0feab96-b8c5-49eb-ac7f-e453bcd9b5d4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a25437ef-62a4-4789-8702-36eca223937b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a316f629-d98d-46e4-b048-a2b0af0d5a60"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a34a8489-965c-4598-b0d3-3b5dee545840"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a494bb83-9873-42ed-b1ab-38caf68787bc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a4ccd972-df23-464f-a9bd-92e887d11a55"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a581e9a9-1d34-4434-b366-32c889480a2c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a71936ed-e259-4125-8f2f-c0366966a4bf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a8fe9edb-9334-42a9-acfd-cdb7d7cd424d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a942b0c5-5f7a-45d2-a3a8-b11be52c293d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ad2bd5cb-e53e-45ed-9781-a6876e7de9d6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("aed4b545-1def-4421-a085-1bbd77a8a8ab"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("afa09279-398c-4730-ae4f-5058cb4f7cbd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b184a513-69ee-4d7b-be41-0c4fac77f72b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b894a0f5-b2a7-4c59-a23c-a13eca140480"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b8e1aa2e-f6a6-476d-b652-9df8a7dc42ab"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b9f6bba7-6e6a-437e-9d43-ab3444b7c142"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bc1fc5f5-3311-46e3-ae44-e7318a3ca220"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bc6483a2-3fe7-4095-a78c-7056881fecd6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("be1efdaa-974e-4adf-8287-b32f4644e8f4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c14cafd5-8f30-48af-8e74-ab3d4251e880"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c171b130-7ff9-47b7-980b-a3b764627dc4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6a7a84f-7730-44b2-bda1-3397718d31f9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c90d8798-4b04-4c57-90b8-f7a820738d9c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c91dc273-e92a-4824-9260-529feb8f4168"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c9a7727f-764d-403a-99b9-3e63aadfc43e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ccc11fee-830b-4e6c-a175-9045d02a8f7d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d14f420b-1a7b-4df2-adfb-54f6368499f2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d2586236-b23b-4349-82b7-73d77d7ed682"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d41092cf-c2e5-49d7-af24-3fe4b79df0fa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d6220782-6f86-401f-8e39-193c032f3128"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d7279ce8-6e50-4377-9409-4e7652631698"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dc91dc90-2591-4bc7-a817-3882a722fb63"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("de89ca38-81bd-4c5d-b0ea-22ac453738e7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("df12b93a-da77-4795-9f84-d50a0eda2a80"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e09acd55-4f8b-406d-98d0-d7962e1d406e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e732d8ae-0bf1-4cfe-acac-6b52103ada64"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e7c34660-beaf-4a8c-93bf-b6b374ad43fc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eaf8c308-4afe-4f6d-902c-6ad79911862d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("edf67d77-5289-44eb-bd4f-262bc5603a57"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ef0ad918-3479-4b6a-bd58-1ab894ef5696"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f1bbf45d-5bd1-4704-9295-1849cc4a8dbd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f20df682-b95f-4380-a75b-f29afa611274"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f603ea04-6957-45bc-b6b4-bd177605fd38"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f8977078-5ae9-4812-9bc8-23fba9855945"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fc3a5ad4-9d3b-49ed-ab47-faf44f44dda6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fee773d9-287f-4326-abf5-6853fb7fb2d6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("032b868f-8e6a-4876-a2be-267a0b4e005b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("603e0085-3c03-4ed3-aa3d-2e5abec75b40"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8b27699a-e9d1-4e93-8baf-0fe50699aecc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f8a3ff7d-29ce-4efc-86a2-a5c06094800f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fe9a117d-9f79-4df0-8a20-95a0f19dcc07"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModelNameId",
                table: "Vehicles",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"), "Bentley" },
                    { new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"), "Smart" },
                    { new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"), "Land Rover" },
                    { new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"), "Audi" },
                    { new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"), "Land Rover" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "ModelId", "ModelNameId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("035ca887-13ca-476f-8525-236aa94f43cf"), 1, new Guid("cd3b071d-1343-4a5c-8592-4ebb8cb7bfa0"), null, 2350, "8JOJF8A73NFD29181", 302.12075187208933, 3, 4 },
                    { new Guid("0402a079-d449-4701-a6c6-fc6d2043849c"), 2, new Guid("6b0dae5a-ae24-475b-a65b-b7b4b272f496"), null, 4507, "EBC01808RQTK19529", 2662.0635220816434, 3, 5 },
                    { new Guid("04f97cb7-bffa-43f6-b2bb-aa0967bd19b5"), 3, new Guid("33c068af-065c-4207-801c-6c6ee832dd23"), null, 7544, "3C5PUZZ4LJJ998465", 3213.438327881528, 3, 1 },
                    { new Guid("09354b0d-9af3-423a-9f79-ed72ea89ac45"), 1, new Guid("afd30eba-43fb-4704-ad7a-2ebb25515fb7"), null, 9982, "LNV89TX0UEX910452", 3128.671408473866, 1, 1 },
                    { new Guid("0bf42133-b603-402a-a2da-ad0b317aa67c"), 1, new Guid("a1dc7086-3a3e-416f-b476-02c3988cdaba"), null, 2886, "XYN46T4RULZ972291", 2309.4333966990207, 2, 4 },
                    { new Guid("0feae8cd-a195-4b76-af38-057400a76b69"), 2, new Guid("1edf469c-f9f2-41dd-b0b4-ba20277ae4f8"), null, 5835, "IZ4D9U9I23M479721", 1541.5272491756189, 3, 4 },
                    { new Guid("132d9e51-0089-4641-8d22-e7b9e5efe04e"), 3, new Guid("298aa61e-a596-45d6-a993-710bb22a808b"), null, 1241, "AHBF4RIDPXSK99288", 145.54241659436616, 0, 3 },
                    { new Guid("1df04cfa-86a2-49ad-bcbf-4b1157b095ac"), 0, new Guid("55ce2ac7-53c1-48d9-96b4-571829d682c1"), null, 9470, "302PMGBWFZTR37708", 3281.418159461401, 0, 2 },
                    { new Guid("1e1f00e2-14bc-47f5-b6fe-949e8ae29b23"), 0, new Guid("84a41c34-da68-42ba-a17e-c001d9dcf77d"), null, 4578, "IF10HO5MOTCY96194", 3542.7013211078561, 0, 2 },
                    { new Guid("1f40976d-e377-4316-b3eb-2e35eeb83a94"), 2, new Guid("33c068af-065c-4207-801c-6c6ee832dd23"), null, 6961, "PALF48NBY3HS86734", 284.43700012157365, 0, 0 },
                    { new Guid("23793948-9876-45aa-9e58-301a8c4a48f3"), 1, new Guid("91a6f37f-5ceb-4cce-a27f-90f630e16355"), null, 1540, "THJEJZJ9C8Z532879", 3632.5053341629628, 0, 3 },
                    { new Guid("23d43cd0-24b8-4490-9a17-31a65f590fc5"), 1, new Guid("6b0dae5a-ae24-475b-a65b-b7b4b272f496"), null, 8601, "HF3VQDQVQ6H749324", 1951.2112479243342, 2, 5 },
                    { new Guid("24151eab-0b1f-4902-8798-b91e31bd78e3"), 2, new Guid("298aa61e-a596-45d6-a993-710bb22a808b"), null, 4576, "CKUQT6JJEPO376895", 2108.830922787567, 2, 1 },
                    { new Guid("24305129-5519-40de-baf1-6e042634b476"), 0, new Guid("9f9352f4-8102-4b40-9042-447519453f4e"), null, 6162, "IX8Z80OV0BDT64290", 2737.6263027209152, 1, 1 },
                    { new Guid("25ebddd1-aa95-41a1-b629-2aeaa67b1fd3"), 2, new Guid("030278f5-6d50-40a3-a3af-5e14e90954eb"), null, 4461, "20A9AQOQUVEU51778", 640.15070480175939, 3, 3 },
                    { new Guid("28190b26-27e0-4134-8cf1-ee518f7823a1"), 0, new Guid("cd3b071d-1343-4a5c-8592-4ebb8cb7bfa0"), null, 8542, "S6YVJ3ZPOPFU79894", 3920.7634819673535, 2, 5 },
                    { new Guid("28549331-a1ec-4ce4-9888-5be729686356"), 3, new Guid("a3a757e5-394f-46ab-8c8a-c956d5fe9110"), null, 4219, "SUBW0AWLU3RX59966", 3419.401805993939, 1, 4 },
                    { new Guid("2b0d80a2-5876-4f36-8bdd-a6c132e84c1d"), 0, new Guid("5be1f7f4-8066-4741-bcd2-8542fc2e6115"), null, 8459, "C99QKHX7GTKZ70690", 1908.1176000053867, 2, 0 },
                    { new Guid("2b70567e-b2ab-46e0-a9b3-90677e0775be"), 1, new Guid("cd3b071d-1343-4a5c-8592-4ebb8cb7bfa0"), null, 5602, "2AVDUQPCO2QI10492", 1930.539677021909, 1, 1 },
                    { new Guid("2b92e109-4745-4fe5-82ea-52ed0f74d0b6"), 1, new Guid("7290df1e-e104-4bf5-b7f3-6ae10053a96b"), null, 3861, "L7VDI86Y07UY80248", 988.4737215988157, 3, 0 },
                    { new Guid("2c6dc7c0-ee08-4986-99ca-523b4718a202"), 3, new Guid("49f3b4f9-5fd7-488c-861d-0a8a14fc61ff"), null, 6744, "01ZS0NEBYMUN16906", 2656.3041545252918, 1, 3 },
                    { new Guid("2d2f7e70-5ebf-4e6d-a1d8-3cbf73ded16d"), 0, new Guid("abe323d3-5e80-4e45-9a03-10aecd2ce0c7"), null, 5874, "5SB1GITZKWGH29567", 2387.8715714024888, 3, 4 },
                    { new Guid("2e8004ad-bdde-418f-b878-acd62effc529"), 0, new Guid("a3a757e5-394f-46ab-8c8a-c956d5fe9110"), null, 8198, "WKNMIHPCUXCH11651", 3929.8352561051215, 1, 5 },
                    { new Guid("2f0b169b-11b7-4d5a-8930-d3e04854f2c3"), 2, new Guid("abe323d3-5e80-4e45-9a03-10aecd2ce0c7"), null, 2570, "JRJJCSKL92J741243", 1150.6875537130591, 1, 3 },
                    { new Guid("2fec0375-384a-45b1-8a29-f42d8779471e"), 2, new Guid("a1dc7086-3a3e-416f-b476-02c3988cdaba"), null, 4297, "V1J8EQMB2BEO90343", 477.1146833432461, 1, 5 },
                    { new Guid("39508c99-6512-4567-8413-7df6bf94bccb"), 3, new Guid("d84b07b7-5d85-4c81-98d6-0f636b18546b"), null, 4548, "LKXWUWY431MS51091", 2021.4182183809892, 3, 5 },
                    { new Guid("399bdadb-dbc6-4251-8501-78d8902acb6f"), 2, new Guid("7290df1e-e104-4bf5-b7f3-6ae10053a96b"), null, 8107, "VKPSYS8ACOZP85091", 3289.676951949285, 1, 1 },
                    { new Guid("3a48d8d0-b0e7-4391-8353-619dbaf501e9"), 1, new Guid("55d8493f-6af2-435a-9c97-09db44d1e9d4"), null, 2361, "IYDV7WNTQFK161369", 1154.8583586381069, 1, 0 },
                    { new Guid("3b21114f-be6f-42e9-95a8-0692c48967a1"), 3, new Guid("a44d8035-034b-4369-a98e-1e61ee9706a2"), null, 5183, "CMRQB3XQEFX336840", 3744.651395957259, 1, 0 },
                    { new Guid("3f33389e-84ff-4ef5-826b-60ce63f1439b"), 2, new Guid("639649f9-a608-412e-b8ab-1877a493b86d"), null, 9219, "238XGBP38RW392286", 143.57838194091556, 2, 2 },
                    { new Guid("3f5f6667-fe02-49b5-9791-300ca9a83a8d"), 0, new Guid("a44d8035-034b-4369-a98e-1e61ee9706a2"), null, 7566, "BHSS3HJZL7LF18854", 214.175126549418, 0, 2 },
                    { new Guid("40418352-5ca9-4e72-be55-97972eb73483"), 0, new Guid("f1bb40a8-ebbc-4096-8d83-028ad80690c2"), null, 2967, "JZVZR7MLS0VG45033", 3517.9908528718615, 3, 4 },
                    { new Guid("425a8920-ab68-4dd9-8293-131a50b149e7"), 0, new Guid("a5dd859c-80f5-47a8-8eb2-e50d1285dac3"), null, 7641, "DNAC3TGEOKUA84285", 3576.3565166444318, 1, 1 },
                    { new Guid("4293e359-2944-4e61-adb8-1f9c968f5f7e"), 2, new Guid("84a41c34-da68-42ba-a17e-c001d9dcf77d"), null, 6754, "7BPD9T1PQVX620143", 3386.5897796775871, 2, 4 },
                    { new Guid("45695c1f-0160-412e-a3ee-322287992fd1"), 2, new Guid("5be1f7f4-8066-4741-bcd2-8542fc2e6115"), null, 516, "8HE7XYNIJHN470601", 3727.0869202621029, 2, 4 },
                    { new Guid("4570cd9d-1de3-495a-97f1-effd41957d92"), 0, new Guid("030278f5-6d50-40a3-a3af-5e14e90954eb"), null, 6307, "BPGUB3ME7JSA47596", 658.03668629983019, 3, 5 },
                    { new Guid("499c770f-698a-4e5b-85df-ae3444a11358"), 1, new Guid("afd30eba-43fb-4704-ad7a-2ebb25515fb7"), null, 575, "TAU5VN09L6MX74918", 3749.5294697695958, 1, 2 },
                    { new Guid("4a1d3036-d642-49c0-bd34-f6755c035b7f"), 1, new Guid("abe323d3-5e80-4e45-9a03-10aecd2ce0c7"), null, 3579, "3ME6SYD9FPZ236231", 660.34798634385572, 0, 0 },
                    { new Guid("4bfdd9e7-4f9a-4c34-85bd-3f338a3aa7f0"), 0, new Guid("9f9352f4-8102-4b40-9042-447519453f4e"), null, 7275, "H173LUCFKYBP11936", 1216.5045390022649, 1, 0 },
                    { new Guid("4e1115c2-051b-4472-8eb9-708ef0c92f50"), 3, new Guid("639649f9-a608-412e-b8ab-1877a493b86d"), null, 4450, "K81RFCLHCTT785116", 2613.2404835758284, 3, 2 },
                    { new Guid("4e2c2567-b046-4259-a844-fcbe877b57e6"), 2, new Guid("298aa61e-a596-45d6-a993-710bb22a808b"), null, 5421, "AY7VQ6HM9EXU60493", 658.67408051761799, 3, 5 },
                    { new Guid("55f76e64-08da-4911-952e-814c23e45018"), 1, new Guid("afd30eba-43fb-4704-ad7a-2ebb25515fb7"), null, 2743, "UPZPUCIOBSS173643", 1418.4654166408318, 2, 4 },
                    { new Guid("578541f0-1e3e-4593-b5ca-77b747d8ddd1"), 2, new Guid("a44d8035-034b-4369-a98e-1e61ee9706a2"), null, 5207, "UC1TMT3CS0G927500", 1621.3307575904155, 1, 2 },
                    { new Guid("57fd5bb4-4f0f-4036-ae5e-0c76383fed8e"), 2, new Guid("d84b07b7-5d85-4c81-98d6-0f636b18546b"), null, 4595, "AE8D25Z8ZBGT57618", 1053.4535336464701, 1, 0 },
                    { new Guid("58dc5b15-594b-46f3-bce6-d3684c66eb33"), 1, new Guid("6b0dae5a-ae24-475b-a65b-b7b4b272f496"), null, 1208, "L9GHO8ZTAFTF47932", 3578.9337978927942, 2, 0 },
                    { new Guid("59a5a781-e45d-4f97-bc20-091fe1cdc1bf"), 3, new Guid("55ce2ac7-53c1-48d9-96b4-571829d682c1"), null, 3344, "I9XYVQ6I1TSK78979", 729.03835314022263, 2, 4 },
                    { new Guid("5b50c102-c37a-401f-8a2a-49da669702ee"), 2, new Guid("84a41c34-da68-42ba-a17e-c001d9dcf77d"), null, 495, "Q4857QTSAEM661501", 3183.6066525674664, 3, 3 },
                    { new Guid("5bb42dea-7bd5-4555-b3ab-d1547266dd1b"), 0, new Guid("d84b07b7-5d85-4c81-98d6-0f636b18546b"), null, 723, "N9PFZJ0BPFY810669", 109.30099383923873, 1, 3 },
                    { new Guid("5d06fda3-9c63-4a82-8172-f42414adcf24"), 2, new Guid("9f9352f4-8102-4b40-9042-447519453f4e"), null, 7541, "XLJCY2E4RXBS66151", 600.4534581601863, 3, 3 },
                    { new Guid("5f2419e1-56b4-497d-9181-f3c48072a2fb"), 3, new Guid("6b0dae5a-ae24-475b-a65b-b7b4b272f496"), null, 9955, "2FF3R9W2SFKL21519", 105.0501750351374, 3, 5 },
                    { new Guid("65780980-f627-420c-b537-5efc2ec06f6c"), 1, new Guid("a1dc7086-3a3e-416f-b476-02c3988cdaba"), null, 7426, "AVUY5QZD8JKE40953", 1288.6126179484784, 1, 3 },
                    { new Guid("67d6a8fa-6e70-42c3-970d-ee8a8e3c6388"), 1, new Guid("55d8493f-6af2-435a-9c97-09db44d1e9d4"), null, 3591, "R221UAU8QAGS20652", 1941.9208122101779, 0, 0 },
                    { new Guid("6abddfec-7e17-40c9-bc28-40b330dd1147"), 2, new Guid("33c068af-065c-4207-801c-6c6ee832dd23"), null, 4374, "QYIRT5108SH247712", 1275.2986261044623, 0, 5 },
                    { new Guid("6b349ea2-116d-4a53-91f0-f632dba48379"), 0, new Guid("6b0dae5a-ae24-475b-a65b-b7b4b272f496"), null, 1094, "K2H91QA5NPU757263", 984.99327913348509, 1, 5 },
                    { new Guid("6bce64f5-8aa6-4940-ad58-c697eabdf512"), 2, new Guid("1edf469c-f9f2-41dd-b0b4-ba20277ae4f8"), null, 9480, "H09S8PN0IQHP10210", 3687.0687799927059, 2, 2 },
                    { new Guid("6bf01cee-b0d0-4ca4-9c81-5277891d32b0"), 0, new Guid("84a41c34-da68-42ba-a17e-c001d9dcf77d"), null, 9860, "W22PDK71MQTC44091", 2421.843337637446, 0, 5 },
                    { new Guid("6dbc66b9-ada1-4085-8160-668a20878440"), 2, new Guid("a5dd859c-80f5-47a8-8eb2-e50d1285dac3"), null, 3058, "7DPNC9V0XZPB65886", 274.70673810741334, 3, 3 },
                    { new Guid("6e1ff8e7-a416-4ef4-b928-791c6c44632b"), 0, new Guid("a5dd859c-80f5-47a8-8eb2-e50d1285dac3"), null, 4581, "8RZJ3XP0X2QF35643", 2812.7126817735866, 1, 1 },
                    { new Guid("7099b685-74ec-4124-b266-4b4d684b44b0"), 3, new Guid("84a41c34-da68-42ba-a17e-c001d9dcf77d"), null, 1497, "VGLLX9D9S2PZ74379", 3332.7466784892531, 2, 3 },
                    { new Guid("7129453d-76f4-4ce9-b18c-ec6d663bbc39"), 0, new Guid("afd30eba-43fb-4704-ad7a-2ebb25515fb7"), null, 2256, "2PNDVD88XWO466187", 1404.7856462008267, 0, 4 },
                    { new Guid("75247936-2300-4e69-bf03-ac3ecf9bc891"), 3, new Guid("639649f9-a608-412e-b8ab-1877a493b86d"), null, 4572, "9RMXF4TU98VU56804", 1347.3055209224742, 2, 5 },
                    { new Guid("752cfca8-e84c-42e1-a1af-f0c7b4039a00"), 3, new Guid("a1dc7086-3a3e-416f-b476-02c3988cdaba"), null, 7690, "VG6HBN2VMTBC59749", 2720.4165314162424, 2, 4 },
                    { new Guid("762f13a9-5ba9-4af7-8e0f-e1839b29efcf"), 1, new Guid("a44d8035-034b-4369-a98e-1e61ee9706a2"), null, 8148, "QZB44KISG5WZ75582", 3543.2123485724005, 0, 3 },
                    { new Guid("7695e0ff-92d9-47fc-bbf2-0a8bf39c6e71"), 3, new Guid("5be1f7f4-8066-4741-bcd2-8542fc2e6115"), null, 2109, "GZFV10KMAHGA92806", 3833.2109834269245, 1, 3 },
                    { new Guid("7696709d-1607-469a-b74a-0b79d303c1d4"), 0, new Guid("fd139145-5df2-4ee7-bdb7-c93fddece837"), null, 5220, "7WXLHE8MP6VC44351", 1815.7436573729829, 1, 2 },
                    { new Guid("7706b50a-1368-4961-b2f0-5c0367ab17da"), 2, new Guid("f1bb40a8-ebbc-4096-8d83-028ad80690c2"), null, 3035, "U7Z14N1KYVS546605", 564.02261380308028, 2, 2 },
                    { new Guid("79e506b2-71bc-475e-9e06-f2ca5037cdcb"), 1, new Guid("298aa61e-a596-45d6-a993-710bb22a808b"), null, 5514, "KF104Z9WXKBG25878", 1612.7197393871897, 2, 4 },
                    { new Guid("7ae190c6-d23e-4c72-9680-ca9fa4410076"), 0, new Guid("d86f99cf-078a-437d-83b6-824bb13c4702"), null, 4906, "4DY0OQJ9JZSD26625", 2575.4598981159011, 3, 0 },
                    { new Guid("7b56f402-5922-4ed2-8f91-7108d40b4637"), 0, new Guid("fd139145-5df2-4ee7-bdb7-c93fddece837"), null, 7708, "FBCZ35DXBBXA90533", 3237.8262064816836, 2, 2 },
                    { new Guid("7c9a501e-6ac6-4a78-adf1-1c755098e243"), 2, new Guid("639649f9-a608-412e-b8ab-1877a493b86d"), null, 5451, "BYGYPWB5NMFZ66069", 3252.0963456984286, 2, 2 },
                    { new Guid("7cd55ed5-cdb5-4955-a38b-0d23e51a328c"), 2, new Guid("a1dc7086-3a3e-416f-b476-02c3988cdaba"), null, 2780, "10ORZXX7JOJL75993", 2932.8000686718137, 2, 0 },
                    { new Guid("7d646714-3ca8-410e-a9d7-c4b7fab2a292"), 2, new Guid("639649f9-a608-412e-b8ab-1877a493b86d"), null, 4512, "GKLTNDYMPYJ050838", 3413.7364699350624, 2, 5 },
                    { new Guid("80abdd2d-227e-45a5-ab06-1c3193e272ff"), 0, new Guid("9f9352f4-8102-4b40-9042-447519453f4e"), null, 6352, "0R8CYHZG9VUZ44975", 502.53697630719091, 1, 1 },
                    { new Guid("812ccb65-8978-40ae-9227-31461cc89162"), 0, new Guid("abe323d3-5e80-4e45-9a03-10aecd2ce0c7"), null, 4672, "YRK1RH6W2UOJ89667", 2268.749116350491, 1, 5 },
                    { new Guid("82acca8a-42a7-43d9-9bc7-f1074ead1cab"), 1, new Guid("fd139145-5df2-4ee7-bdb7-c93fddece837"), null, 2952, "7MDZN7RBMEPL91857", 2456.4646067581375, 3, 1 },
                    { new Guid("82d244e2-2d86-46f8-bbc9-78889055992c"), 1, new Guid("fd139145-5df2-4ee7-bdb7-c93fddece837"), null, 3274, "UW62P6DVKZE235413", 2507.2565179893854, 3, 5 },
                    { new Guid("850a8e3b-28c1-47d6-87e9-d2a0cb30e983"), 1, new Guid("a3a757e5-394f-46ab-8c8a-c956d5fe9110"), null, 6402, "XX4M62KBZSJ775544", 1838.5950789487999, 1, 2 },
                    { new Guid("8564a9fc-b21c-414a-9fc8-f5293f58ee23"), 2, new Guid("7290df1e-e104-4bf5-b7f3-6ae10053a96b"), null, 5196, "26IUZI7XHYJQ16635", 275.94033365213471, 3, 3 },
                    { new Guid("87b1dc48-ba09-4df6-b272-6ee4a56fcdf7"), 2, new Guid("d86f99cf-078a-437d-83b6-824bb13c4702"), null, 6655, "5S7B4V1I7JDZ47141", 3750.3447594978511, 3, 0 },
                    { new Guid("88729b64-e8fd-4647-84ff-32775b5185bc"), 2, new Guid("f1bb40a8-ebbc-4096-8d83-028ad80690c2"), null, 377, "CEGPNQ56K2Z539078", 2124.9527392334394, 3, 2 },
                    { new Guid("88da7d48-b38a-4825-94a4-d3c8362319a6"), 1, new Guid("030278f5-6d50-40a3-a3af-5e14e90954eb"), null, 9897, "3M0QZ86VQMPA69389", 2334.4201484779137, 0, 5 },
                    { new Guid("8e6d2415-4231-4db8-a2b8-97a3736e3336"), 3, new Guid("030278f5-6d50-40a3-a3af-5e14e90954eb"), null, 9372, "26BIHVV3TKCF34066", 2873.2105092447214, 2, 5 },
                    { new Guid("94d79976-3f1b-4a4c-9312-b6632e204e2a"), 0, new Guid("33c068af-065c-4207-801c-6c6ee832dd23"), null, 6025, "LH8A63XO7UC679112", 1236.9444665337157, 1, 0 },
                    { new Guid("958b62d8-2e27-40d3-90fd-9c0411b3b8c6"), 1, new Guid("d84b07b7-5d85-4c81-98d6-0f636b18546b"), null, 5362, "D9GOJT80G3SL43719", 1139.4546564152524, 3, 0 },
                    { new Guid("95bbdd88-4b0d-4d9e-8cb5-8329ba69034a"), 3, new Guid("91a6f37f-5ceb-4cce-a27f-90f630e16355"), null, 7688, "YVE8ORZ0I6XC55465", 312.80607546077931, 0, 1 },
                    { new Guid("9774eff8-cdaf-46d6-aa0f-680739a427b5"), 2, new Guid("d86f99cf-078a-437d-83b6-824bb13c4702"), null, 3613, "N7V58FXZB7F584957", 781.18156017156332, 1, 2 },
                    { new Guid("a1b91859-73f1-4860-83e9-08cbb0bd1778"), 0, new Guid("55d8493f-6af2-435a-9c97-09db44d1e9d4"), null, 1206, "DNMTT7QXI8WV93555", 2099.6144285471705, 3, 3 },
                    { new Guid("a21f606f-821e-4afe-94f0-1a8f1070ea95"), 0, new Guid("55ce2ac7-53c1-48d9-96b4-571829d682c1"), null, 8887, "WG7I8F41ZZL747318", 1241.1313315597565, 2, 1 },
                    { new Guid("a554d681-c9f1-4460-9190-efa5faa5ec41"), 0, new Guid("a3a757e5-394f-46ab-8c8a-c956d5fe9110"), null, 4467, "2ANM2PDKOAFF56579", 803.83496304700225, 0, 3 },
                    { new Guid("a72ae15d-0327-42fa-92f9-92982806d7b0"), 3, new Guid("f1bb40a8-ebbc-4096-8d83-028ad80690c2"), null, 968, "UDCFA9LRZYCT53082", 1097.3050549334885, 2, 2 },
                    { new Guid("a86c9e61-216e-4cc2-9e7c-4fe1eceac774"), 1, new Guid("afd30eba-43fb-4704-ad7a-2ebb25515fb7"), null, 1969, "ZFI9220WZTOF70795", 2109.3606045263432, 3, 1 },
                    { new Guid("a8abd601-97b6-4d10-82b3-73afeaae828d"), 2, new Guid("1edf469c-f9f2-41dd-b0b4-ba20277ae4f8"), null, 6362, "XIPKNEWF62ZH26508", 2148.1422619065452, 3, 1 },
                    { new Guid("a93b850d-67fb-4068-9bb7-b628e8edde33"), 0, new Guid("030278f5-6d50-40a3-a3af-5e14e90954eb"), null, 8421, "F6SG16FE2SPT43684", 222.36574640783635, 0, 0 },
                    { new Guid("ad0ce44e-d5ea-49e5-8245-466f7e95518e"), 3, new Guid("55ce2ac7-53c1-48d9-96b4-571829d682c1"), null, 8718, "L9LWVA1AR9EL77186", 1280.3840735632702, 1, 3 },
                    { new Guid("b0cd2d2e-134f-4b7d-89b9-0011c36475f9"), 3, new Guid("91a6f37f-5ceb-4cce-a27f-90f630e16355"), null, 6158, "WO7JWU9V25R739017", 3164.587442218417, 3, 1 },
                    { new Guid("b3daa36c-fff0-4db3-abc5-98dc3080d8f2"), 3, new Guid("33c068af-065c-4207-801c-6c6ee832dd23"), null, 1119, "IJC1KEZWDVO410711", 2740.0200006303367, 3, 5 },
                    { new Guid("b574da5f-4d55-42e8-bc73-d723fc15c368"), 1, new Guid("cd3b071d-1343-4a5c-8592-4ebb8cb7bfa0"), null, 3022, "T1RQTK3GPYUK12851", 744.87082943243593, 3, 2 },
                    { new Guid("be09a16e-7192-4152-94bd-454d49d1dc58"), 0, new Guid("abe323d3-5e80-4e45-9a03-10aecd2ce0c7"), null, 3536, "9WVQV10DILP090956", 3455.7194690596266, 0, 3 },
                    { new Guid("bedbe7c1-0a77-42b6-a963-b95440f59eac"), 3, new Guid("5be1f7f4-8066-4741-bcd2-8542fc2e6115"), null, 6003, "6UI7RJA55HCP10027", 2182.9197636389558, 1, 3 },
                    { new Guid("bf57197f-c030-4255-bd07-0dba26d76503"), 1, new Guid("5be1f7f4-8066-4741-bcd2-8542fc2e6115"), null, 8771, "AJCJ17ZO4UUL73798", 1051.0056662093198, 0, 4 },
                    { new Guid("bff2f657-58f2-4ef0-a27b-06a371cf172c"), 1, new Guid("f1bb40a8-ebbc-4096-8d83-028ad80690c2"), null, 6531, "O665B4MTSDTJ61484", 2470.753480437998, 0, 2 },
                    { new Guid("c7b48b09-a7f4-49a1-80c8-2da35038d706"), 3, new Guid("55d8493f-6af2-435a-9c97-09db44d1e9d4"), null, 909, "911PP7HV13II56864", 1307.2363859180418, 0, 1 },
                    { new Guid("cb06d699-2e4d-4889-b0f5-c469a75e3d85"), 3, new Guid("d86f99cf-078a-437d-83b6-824bb13c4702"), null, 2613, "EBQRDS1SU3YF96722", 1459.0535393257928, 3, 4 },
                    { new Guid("ccd39f50-0a7d-4e78-868d-bdb8af2aaa2f"), 3, new Guid("49f3b4f9-5fd7-488c-861d-0a8a14fc61ff"), null, 2574, "1TM4OS5BTOA142822", 2585.6863642387316, 1, 3 },
                    { new Guid("ce914af8-e3ba-439a-86b2-7d1ecd819bbb"), 0, new Guid("91a6f37f-5ceb-4cce-a27f-90f630e16355"), null, 8505, "NB388TEQ6UIO63632", 682.97537495263123, 1, 5 },
                    { new Guid("d3f74f3f-9e30-4701-ae7e-62c01812c6fa"), 0, new Guid("a5dd859c-80f5-47a8-8eb2-e50d1285dac3"), null, 9464, "YYX5E7LJPQUB92823", 2809.0355392116039, 3, 5 },
                    { new Guid("d7f9a3b8-bfe8-45a1-9a65-d07218270ced"), 1, new Guid("1edf469c-f9f2-41dd-b0b4-ba20277ae4f8"), null, 386, "B24DI77P6OAA85388", 180.81422808161557, 2, 0 },
                    { new Guid("dc0850e2-38c3-4d99-9454-b8e30451ac03"), 0, new Guid("d84b07b7-5d85-4c81-98d6-0f636b18546b"), null, 6264, "CJOPOHHJVWGG82833", 372.09602759605269, 3, 1 },
                    { new Guid("e069e7f6-f3d5-4b65-993c-10b0b2a9b477"), 0, new Guid("cd3b071d-1343-4a5c-8592-4ebb8cb7bfa0"), null, 6541, "KL6PBPVC8DJB71186", 1677.0878308038784, 0, 4 },
                    { new Guid("e099005b-55be-49ed-bf2d-8a954212a8d6"), 1, new Guid("a44d8035-034b-4369-a98e-1e61ee9706a2"), null, 4753, "PER7XO42ODYW48572", 2248.9601071069428, 1, 1 },
                    { new Guid("e100129b-337c-41be-8cd7-b1f95f48c81f"), 0, new Guid("fd139145-5df2-4ee7-bdb7-c93fddece837"), null, 8673, "6LARDLXWJJQA38563", 3926.0967595419384, 2, 4 },
                    { new Guid("e142b9af-06b8-4f5e-8acd-617195cde85b"), 0, new Guid("1edf469c-f9f2-41dd-b0b4-ba20277ae4f8"), null, 6649, "K8CYUNDWAZS097232", 3316.507765448986, 2, 4 },
                    { new Guid("e1673403-8ff9-44a5-8048-442e34d3925e"), 0, new Guid("7290df1e-e104-4bf5-b7f3-6ae10053a96b"), null, 4852, "00NIPQU2YHXR85776", 2936.6581630336009, 0, 2 },
                    { new Guid("e3af85e7-0e02-4fce-9ce4-ed2fbb5a99be"), 3, new Guid("7290df1e-e104-4bf5-b7f3-6ae10053a96b"), null, 4507, "K2UNC454U0JR91961", 921.05871984251507, 0, 2 },
                    { new Guid("e48849a5-a1ac-4bb2-ac07-f51c6c924716"), 3, new Guid("55d8493f-6af2-435a-9c97-09db44d1e9d4"), null, 4904, "ZE68O49TZPMM74799", 1588.3270833562656, 0, 5 },
                    { new Guid("eaead9b4-fb55-419a-b076-5f63173d8ebc"), 0, new Guid("49f3b4f9-5fd7-488c-861d-0a8a14fc61ff"), null, 9855, "KI734EX8WJDJ90207", 1245.3230740067861, 2, 5 },
                    { new Guid("eda01b31-8694-41da-934c-6a8f2e7828ed"), 2, new Guid("91a6f37f-5ceb-4cce-a27f-90f630e16355"), null, 7949, "G1AKFSK14SFZ55000", 1084.4774756672721, 1, 0 },
                    { new Guid("ef1b889b-047e-440a-ac5e-d16ae2299624"), 0, new Guid("9f9352f4-8102-4b40-9042-447519453f4e"), null, 9767, "6KPWDGLYP9T888597", 2604.506528155051, 1, 5 },
                    { new Guid("f176a17b-04ee-4d2b-99f4-a307712f168c"), 2, new Guid("49f3b4f9-5fd7-488c-861d-0a8a14fc61ff"), null, 1707, "OWQTBWVBMQRU23715", 3018.8534537077912, 1, 4 },
                    { new Guid("f4601dbd-8b9b-453c-8544-729337472092"), 3, new Guid("d86f99cf-078a-437d-83b6-824bb13c4702"), null, 2437, "U091G40PTJAJ49562", 2178.9117292179953, 3, 2 },
                    { new Guid("f56a7ed8-2bca-4d67-8fd2-00c05f91ae30"), 2, new Guid("a5dd859c-80f5-47a8-8eb2-e50d1285dac3"), null, 8596, "7CXYFEAZWHQV33907", 2642.3017813560582, 1, 5 },
                    { new Guid("f5ea22f2-727e-42ed-9b2f-9fadd66a6c82"), 1, new Guid("55ce2ac7-53c1-48d9-96b4-571829d682c1"), null, 2253, "QZFPN23KXEKJ56220", 3186.2158682662998, 2, 2 },
                    { new Guid("fb32c839-b79f-4e3c-a96a-b34d57c93848"), 2, new Guid("a3a757e5-394f-46ab-8c8a-c956d5fe9110"), null, 9717, "GH80B1SNSQNF63834", 2246.22158194228, 0, 1 },
                    { new Guid("ff16361f-e4ea-4df5-8c33-defd30cdf675"), 2, new Guid("49f3b4f9-5fd7-488c-861d-0a8a14fc61ff"), null, 9634, "BLLE15LAR7YN29911", 2736.3234826546968, 1, 2 },
                    { new Guid("ff3e9753-56f1-4d80-acd5-0dc41a58eca3"), 2, new Guid("298aa61e-a596-45d6-a993-710bb22a808b"), null, 8563, "45WJ3LQW6VJE76511", 1695.8252528388505, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("0081dad6-0bfe-4b0f-a221-e48207c476f1"), "Princess.Johnston34@gmail.com", "Fritz", "Bosco", "723-536-5005 x326", new Guid("a21f606f-821e-4afe-94f0-1a8f1070ea95") },
                    { new Guid("020a6acc-742b-4744-99f8-d405446502a0"), "Ezequiel78@hotmail.com", "Darius", "Torp", "590.970.7163 x4764", new Guid("1e1f00e2-14bc-47f5-b6fe-949e8ae29b23") },
                    { new Guid("0324d16d-3b13-4b61-ba2f-0ede1a54d320"), "Gunnar9@yahoo.com", "Willard", "Corwin", "1-510-623-7558 x343", new Guid("55f76e64-08da-4911-952e-814c23e45018") },
                    { new Guid("05e1c97b-d013-4317-8748-24e8f2798ab4"), "Pierce.Upton20@yahoo.com", "Adolph", "Spinka", "668-249-4427 x6517", new Guid("9774eff8-cdaf-46d6-aa0f-680739a427b5") },
                    { new Guid("06e725bd-c753-4fd9-be6a-5bbd0a90649e"), "Layne30@yahoo.com", "Jazmyn", "Bartoletti", "(725) 493-5134", new Guid("4293e359-2944-4e61-adb8-1f9c968f5f7e") },
                    { new Guid("09cbcbaf-441c-4057-b933-1ec6999b10f9"), "Christ.Casper78@hotmail.com", "Rey", "Feeney", "1-655-625-9789", new Guid("28549331-a1ec-4ce4-9888-5be729686356") },
                    { new Guid("0efe199e-d40d-4f20-84ba-a7aba87129f3"), "Sarina.OKeefe@hotmail.com", "Michele", "Paucek", "975.617.2161 x615", new Guid("f4601dbd-8b9b-453c-8544-729337472092") },
                    { new Guid("1193b6ac-37ac-4e27-82cc-ed05dd6e78f1"), "Germaine_Langworth71@yahoo.com", "Juana", "Schaefer", "499-876-0035 x4011", new Guid("7b56f402-5922-4ed2-8f91-7108d40b4637") },
                    { new Guid("13478ce7-45c6-4863-be4f-3735cb2e29a3"), "Rocio.Powlowski63@yahoo.com", "Suzanne", "Farrell", "(250) 702-7588", new Guid("2f0b169b-11b7-4d5a-8930-d3e04854f2c3") },
                    { new Guid("15bd9c8c-d928-4b84-bd0b-e478ac41f2f8"), "Burdette44@hotmail.com", "Octavia", "Robel", "1-477-341-4171 x89991", new Guid("79e506b2-71bc-475e-9e06-f2ca5037cdcb") },
                    { new Guid("15e935ba-0ce5-4cdb-abd9-203b7f6d5fd8"), "Lionel.Weissnat@gmail.com", "Johnathon", "D'Amore", "1-344-994-6378 x029", new Guid("2e8004ad-bdde-418f-b878-acd62effc529") },
                    { new Guid("16af6a1e-ac4c-4506-927a-19d151132ae7"), "Cheyenne14@hotmail.com", "Marjory", "Jacobs", "958-702-9998 x188", new Guid("7099b685-74ec-4124-b266-4b4d684b44b0") },
                    { new Guid("19f603f1-2eab-4737-9af6-b4b5a66dccf1"), "Tre_Kohler4@hotmail.com", "Arno", "Flatley", "947.222.5566 x40309", new Guid("0feae8cd-a195-4b76-af38-057400a76b69") },
                    { new Guid("1b5f4904-16c9-4927-979f-b61055a59465"), "Brielle_Flatley13@hotmail.com", "Tiara", "Schamberger", "465.676.9968 x70553", new Guid("2d2f7e70-5ebf-4e6d-a1d8-3cbf73ded16d") },
                    { new Guid("1d34076b-142e-468b-98c5-a626eb3759aa"), "Jordi.Becker@hotmail.com", "Mafalda", "Beier", "610.334.4153 x02424", new Guid("67d6a8fa-6e70-42c3-970d-ee8a8e3c6388") },
                    { new Guid("1e7d69a3-0578-46a6-aaab-f51d55583b20"), "Sammie_VonRueden33@yahoo.com", "Jaylen", "Auer", "(591) 874-3859", new Guid("e3af85e7-0e02-4fce-9ce4-ed2fbb5a99be") },
                    { new Guid("21a808e0-0ab2-4d4f-8de2-b5d03496a614"), "Terrill.Donnelly@hotmail.com", "Brice", "Torp", "(593) 962-8056 x683", new Guid("2b0d80a2-5876-4f36-8bdd-a6c132e84c1d") },
                    { new Guid("2252ec33-7c90-45dd-a1d2-17daec94e8c4"), "Kianna94@hotmail.com", "Kyla", "Mante", "1-885-309-9685", new Guid("2fec0375-384a-45b1-8a29-f42d8779471e") },
                    { new Guid("238785e3-02ca-4a18-88e9-6ce7f3b11e39"), "Hipolito.Veum@gmail.com", "Rasheed", "Rempel", "1-329-360-3546 x9261", new Guid("035ca887-13ca-476f-8525-236aa94f43cf") },
                    { new Guid("23e18591-d974-43d7-a89f-a83b78c00142"), "Anthony.Conn7@gmail.com", "Lisa", "Nienow", "283.558.0732 x8839", new Guid("c7b48b09-a7f4-49a1-80c8-2da35038d706") },
                    { new Guid("26ee8545-bffb-46d9-8e3e-5f6554dc9237"), "Guillermo_Bayer@yahoo.com", "Janessa", "Krajcik", "(642) 609-7679 x1166", new Guid("ccd39f50-0a7d-4e78-868d-bdb8af2aaa2f") },
                    { new Guid("2891e377-444e-4a82-a1ef-29dc2bf3614b"), "Breana.Feil9@hotmail.com", "Jenifer", "Reichel", "312.708.8209 x827", new Guid("958b62d8-2e27-40d3-90fd-9c0411b3b8c6") },
                    { new Guid("2892875a-dbe5-49a8-b02f-83ae2f7a206c"), "Kameron54@yahoo.com", "Kitty", "Balistreri", "(756) 985-9814", new Guid("09354b0d-9af3-423a-9f79-ed72ea89ac45") },
                    { new Guid("295da0a1-3093-4ac4-afa8-21d3a0105bbc"), "Eladio64@yahoo.com", "Pearlie", "Marks", "626-739-3710 x19981", new Guid("e099005b-55be-49ed-bf2d-8a954212a8d6") },
                    { new Guid("2b0b86ec-8100-4693-be79-06eafa441013"), "Earnest_Thiel@gmail.com", "Guadalupe", "Reichert", "(584) 867-3491 x8924", new Guid("578541f0-1e3e-4593-b5ca-77b747d8ddd1") },
                    { new Guid("2f2d8a0d-50a0-4319-bce1-729cdace810b"), "Davon.Corwin73@yahoo.com", "Beaulah", "Huel", "373-369-2534", new Guid("4570cd9d-1de3-495a-97f1-effd41957d92") },
                    { new Guid("313524a0-24b4-4eee-8ac4-32b448f7a8f6"), "Jacinthe2@hotmail.com", "Jaunita", "Toy", "1-800-424-0279", new Guid("6abddfec-7e17-40c9-bc28-40b330dd1147") },
                    { new Guid("36c28ffd-d733-489b-ad0d-4e70baa88da4"), "Samson.Feil@gmail.com", "Raoul", "Lakin", "(869) 944-0069 x5725", new Guid("1f40976d-e377-4316-b3eb-2e35eeb83a94") },
                    { new Guid("38de5ec1-1b16-44d3-939e-82d10cd33e55"), "Josiah40@hotmail.com", "Syble", "Little", "1-542-518-7551", new Guid("b574da5f-4d55-42e8-bc73-d723fc15c368") },
                    { new Guid("3a4899e7-a528-4406-8417-b9a6b392353f"), "Sheldon.Crona80@yahoo.com", "Tavares", "Jast", "981-242-6097 x19555", new Guid("82d244e2-2d86-46f8-bbc9-78889055992c") },
                    { new Guid("3cb44855-2d66-41f5-b516-53d0ff71621d"), "Donny68@hotmail.com", "Madalyn", "Schumm", "1-474-595-0340 x17082", new Guid("7cd55ed5-cdb5-4955-a38b-0d23e51a328c") },
                    { new Guid("3fb69d4c-c194-480b-9d3a-035d50780805"), "Wilber40@yahoo.com", "Name", "Willms", "(538) 248-4614 x97763", new Guid("6bf01cee-b0d0-4ca4-9c81-5277891d32b0") },
                    { new Guid("44e16406-96a7-4a2d-86ab-4b193f287653"), "Ericka90@gmail.com", "Eladio", "Luettgen", "809.550.3903", new Guid("4e2c2567-b046-4259-a844-fcbe877b57e6") },
                    { new Guid("45be23a3-8d26-4a49-9c8c-468f2bc44011"), "Susana.Hermiston@gmail.com", "Kaitlin", "Abernathy", "(436) 512-7469", new Guid("fb32c839-b79f-4e3c-a96a-b34d57c93848") },
                    { new Guid("481cab84-1a13-4f6c-9bd5-d46978fc00f3"), "Abbey_Doyle87@gmail.com", "Ottis", "Ward", "337.632.3497 x58313", new Guid("5b50c102-c37a-401f-8a2a-49da669702ee") },
                    { new Guid("48a28632-1593-4da8-a702-5f24e49fd4e2"), "Jayde.OKon82@hotmail.com", "Heidi", "Kiehn", "(574) 296-9064", new Guid("eaead9b4-fb55-419a-b076-5f63173d8ebc") },
                    { new Guid("4b92a086-3756-4f10-8fa2-a3cad2645053"), "Isobel_Kemmer30@gmail.com", "Omer", "Larkin", "1-515-446-3787 x7217", new Guid("7d646714-3ca8-410e-a9d7-c4b7fab2a292") },
                    { new Guid("4cb499a3-38f4-49f5-938a-ff25772623c9"), "Lola.Senger@yahoo.com", "Marcelo", "Greenfelder", "(796) 716-5055 x0343", new Guid("e100129b-337c-41be-8cd7-b1f95f48c81f") },
                    { new Guid("4f356b5c-8863-4ba2-b495-069afa01ed59"), "Rhea67@yahoo.com", "Justyn", "Balistreri", "(860) 624-4750", new Guid("7695e0ff-92d9-47fc-bbf2-0a8bf39c6e71") },
                    { new Guid("50c16984-964c-422e-9526-811d973854cf"), "Sally_Prosacco@gmail.com", "Rebekah", "Bayer", "1-268-547-6065", new Guid("812ccb65-8978-40ae-9227-31461cc89162") },
                    { new Guid("537e808e-e01f-43d6-baab-49c9205548ed"), "Viva45@gmail.com", "Jakob", "Boyer", "1-479-927-3678", new Guid("a72ae15d-0327-42fa-92f9-92982806d7b0") },
                    { new Guid("53d95ad0-9853-4787-b66f-35b35a2ff154"), "Orlo24@yahoo.com", "Odell", "Klein", "574.461.6492 x919", new Guid("3f5f6667-fe02-49b5-9791-300ca9a83a8d") },
                    { new Guid("550b3507-baf4-41cf-989c-b48b9b823d6c"), "Max.Sanford@hotmail.com", "Tony", "Shields", "1-272-945-5712 x94862", new Guid("f5ea22f2-727e-42ed-9b2f-9fadd66a6c82") },
                    { new Guid("556c7279-530f-4c7f-aa36-bd12ee86ef8e"), "Donnell_Hegmann29@yahoo.com", "Beth", "Mills", "421-292-2042", new Guid("88da7d48-b38a-4825-94a4-d3c8362319a6") },
                    { new Guid("5976c167-a2af-4cb4-aefc-13db04b214c0"), "Harmon_Dare62@hotmail.com", "Kory", "Blick", "1-605-535-0518 x51940", new Guid("88729b64-e8fd-4647-84ff-32775b5185bc") },
                    { new Guid("5c7e1c48-99fb-49b9-96a3-17a0bea75a2f"), "Amy49@yahoo.com", "Reyes", "Krajcik", "519-483-8292", new Guid("6e1ff8e7-a416-4ef4-b928-791c6c44632b") },
                    { new Guid("5e3676eb-bf1c-4c93-9ecd-959b0baa8d39"), "Larue7@hotmail.com", "Rupert", "O'Connell", "(741) 321-5472 x7025", new Guid("e142b9af-06b8-4f5e-8acd-617195cde85b") },
                    { new Guid("601b604e-cca6-483d-8af9-4af30b783d62"), "Lora_Parker14@gmail.com", "Cade", "Mraz", "1-477-849-6257 x35865", new Guid("0402a079-d449-4701-a6c6-fc6d2043849c") },
                    { new Guid("625f97b6-59c8-478b-a805-b2f0da38727a"), "Nat_Boyer35@hotmail.com", "Makenna", "Barton", "1-500-937-2356", new Guid("bf57197f-c030-4255-bd07-0dba26d76503") },
                    { new Guid("64156eee-2f34-4c32-8731-d2e8b8b2f479"), "Herbert.Padberg65@gmail.com", "Lizeth", "Blanda", "(277) 998-4373 x31291", new Guid("be09a16e-7192-4152-94bd-454d49d1dc58") },
                    { new Guid("6416bda2-12c9-4d02-b98f-d666734e2f8f"), "Luis_Mertz@gmail.com", "Hayden", "Beahan", "(863) 801-9204 x2411", new Guid("6bce64f5-8aa6-4940-ad58-c697eabdf512") },
                    { new Guid("6475b262-418b-4c8f-afdb-a21426a77510"), "Americo.VonRueden45@gmail.com", "Walker", "Connelly", "602.985.0621 x037", new Guid("2c6dc7c0-ee08-4986-99ca-523b4718a202") },
                    { new Guid("657a8e1d-0501-4db1-8f1a-f0e98edb8578"), "Rose_Boehm77@yahoo.com", "Magdalena", "Mraz", "(327) 921-1605 x5373", new Guid("39508c99-6512-4567-8413-7df6bf94bccb") },
                    { new Guid("6bb5a425-de2c-4d70-bed7-b6fc11c78783"), "Cloyd1@yahoo.com", "Okey", "Ziemann", "1-908-723-9255 x1726", new Guid("75247936-2300-4e69-bf03-ac3ecf9bc891") },
                    { new Guid("707e3dda-9c1a-4ced-8aee-89ee93e6ae5c"), "Meghan.Purdy@gmail.com", "Nedra", "McClure", "408.456.4914 x51367", new Guid("5f2419e1-56b4-497d-9181-f3c48072a2fb") },
                    { new Guid("74c9615a-7431-4ab0-a301-3d86eba785a0"), "Herminia.Greenfelder32@hotmail.com", "Oswaldo", "Harvey", "(238) 796-0538 x355", new Guid("57fd5bb4-4f0f-4036-ae5e-0c76383fed8e") },
                    { new Guid("75c4250c-2e0a-48ad-ad2d-8ae74dd18bbb"), "Luigi95@gmail.com", "Darren", "Herman", "(955) 733-7461", new Guid("ff16361f-e4ea-4df5-8c33-defd30cdf675") },
                    { new Guid("7a0afdc5-f11d-4f70-9e88-de5737455d7b"), "Keaton.Schneider87@yahoo.com", "Agustina", "Schultz", "800.307.4905 x894", new Guid("25ebddd1-aa95-41a1-b629-2aeaa67b1fd3") },
                    { new Guid("7c84432c-a625-4c5b-987c-32474563feda"), "Leora.Hills59@hotmail.com", "Dixie", "Kuphal", "740.292.3973 x5501", new Guid("a1b91859-73f1-4860-83e9-08cbb0bd1778") },
                    { new Guid("7df2138b-526c-4458-a794-c7f19fd0933d"), "Keenan.Greenholt@gmail.com", "Marcel", "Keeling", "305-412-3789", new Guid("94d79976-3f1b-4a4c-9312-b6632e204e2a") },
                    { new Guid("809bbb38-a4d0-4326-b88d-d3c7a636cbdd"), "Chandler_Mayer@gmail.com", "Clinton", "Kuhic", "1-873-280-9879 x569", new Guid("7ae190c6-d23e-4c72-9680-ca9fa4410076") },
                    { new Guid("81045fc1-3b9a-4034-ba57-c8d035711883"), "Kacie.Krajcik@yahoo.com", "Zetta", "Nicolas", "424-527-3997 x122", new Guid("ef1b889b-047e-440a-ac5e-d16ae2299624") },
                    { new Guid("8477561f-5450-402b-af3d-475a1fbd6122"), "Zachary.Cremin33@gmail.com", "Hazle", "Bins", "995-219-0182 x96675", new Guid("40418352-5ca9-4e72-be55-97972eb73483") },
                    { new Guid("873d79dc-9b9a-4c0b-93a0-93dc7d31ee48"), "Cathrine_Hessel66@yahoo.com", "Ofelia", "Cruickshank", "449.400.1045 x1287", new Guid("ad0ce44e-d5ea-49e5-8245-466f7e95518e") },
                    { new Guid("88ec27b9-9fa5-4d98-b5d7-77f86f643576"), "Elisha.Kuphal84@yahoo.com", "Thomas", "Corkery", "(220) 258-8619", new Guid("b0cd2d2e-134f-4b7d-89b9-0011c36475f9") },
                    { new Guid("89958d5d-b8df-4503-a113-b2d9d7ea3d71"), "Aimee56@yahoo.com", "Ali", "Ebert", "1-228-759-7821", new Guid("e48849a5-a1ac-4bb2-ac07-f51c6c924716") },
                    { new Guid("8a165485-1430-4afc-b846-0a888fe7e450"), "Erik93@hotmail.com", "Judson", "Harber", "1-387-374-1689 x6459", new Guid("7c9a501e-6ac6-4a78-adf1-1c755098e243") },
                    { new Guid("8bb69b47-f2c0-42c6-91dc-985b52b6e53a"), "Enid.Spencer76@hotmail.com", "Jacinthe", "Fisher", "623-564-3740 x9366", new Guid("399bdadb-dbc6-4251-8501-78d8902acb6f") },
                    { new Guid("8c709958-2e71-4f2b-a109-1f0d075c08ca"), "Carlee_Lebsack22@gmail.com", "Julianne", "Gleichner", "1-511-845-2781 x7154", new Guid("24151eab-0b1f-4902-8798-b91e31bd78e3") },
                    { new Guid("8cd236ab-d93e-4ff3-bf5e-b39873fd60e4"), "Oleta.Gutmann@gmail.com", "Gilberto", "Carroll", "939-823-5565", new Guid("95bbdd88-4b0d-4d9e-8cb5-8329ba69034a") },
                    { new Guid("911caab8-09e1-477c-89f0-91c547f3e009"), "Deangelo_Ondricka@yahoo.com", "Quinten", "Tillman", "634-483-7687 x7960", new Guid("23d43cd0-24b8-4490-9a17-31a65f590fc5") },
                    { new Guid("95202c99-5f9b-44c4-bd9f-940eb535593b"), "Kieran.Witting@yahoo.com", "Jeremy", "Langworth", "(466) 769-8285", new Guid("ce914af8-e3ba-439a-86b2-7d1ecd819bbb") },
                    { new Guid("9954740f-4a9a-48f0-8efe-ce02220a9fad"), "Felipa.Hoeger@hotmail.com", "Jayde", "Jast", "1-356-959-5413 x63245", new Guid("132d9e51-0089-4641-8d22-e7b9e5efe04e") },
                    { new Guid("9f27e45c-5054-4bfc-9309-d1d89635634f"), "Garrison14@yahoo.com", "Brandy", "Mayert", "1-489-825-0885", new Guid("80abdd2d-227e-45a5-ab06-1c3193e272ff") },
                    { new Guid("a470fd86-d553-40fc-98c4-34674c8ea355"), "Sydnee_Homenick@gmail.com", "Elsa", "Jacobson", "1-943-272-5184", new Guid("a93b850d-67fb-4068-9bb7-b628e8edde33") },
                    { new Guid("a884083d-8fce-4f1e-837f-b0f72a48caba"), "Jerrold_Schaden@gmail.com", "Crystal", "Pfannerstill", "1-968-593-6380 x2018", new Guid("bff2f657-58f2-4ef0-a27b-06a371cf172c") },
                    { new Guid("a8a8e5c8-89cf-424f-bd07-01e99452d1b4"), "Jaquelin90@gmail.com", "Miles", "Pacocha", "245-522-6798", new Guid("eda01b31-8694-41da-934c-6a8f2e7828ed") },
                    { new Guid("a8f2553a-e242-4a5c-a05d-bc9e7fb2d854"), "Rosie.Franecki@yahoo.com", "Leila", "Lubowitz", "888.930.8041", new Guid("04f97cb7-bffa-43f6-b2bb-aa0967bd19b5") },
                    { new Guid("a9811e84-c22d-4488-97a6-052b7962293f"), "Russell11@gmail.com", "Wade", "Nienow", "(398) 878-1504 x190", new Guid("499c770f-698a-4e5b-85df-ae3444a11358") },
                    { new Guid("ab9afe08-8adc-4fd7-a917-b9b820f305d6"), "Rolando_Jerde32@hotmail.com", "Cleora", "Glover", "766-391-4057 x726", new Guid("d7f9a3b8-bfe8-45a1-9a65-d07218270ced") },
                    { new Guid("ac8c576e-5757-46ca-97c5-7ec41927cdff"), "Raina50@gmail.com", "Zula", "Fritsch", "1-419-276-5009 x292", new Guid("f176a17b-04ee-4d2b-99f4-a307712f168c") },
                    { new Guid("ad85d84f-9768-40fe-acc1-0f502af4adcc"), "Kathlyn53@hotmail.com", "Jayne", "Aufderhar", "294-945-4559 x265", new Guid("b3daa36c-fff0-4db3-abc5-98dc3080d8f2") },
                    { new Guid("ae60da7c-4c71-42ee-8c0d-2b53a5a9ff30"), "Neil_Glover15@yahoo.com", "Claudia", "Bahringer", "1-206-203-5851", new Guid("3b21114f-be6f-42e9-95a8-0692c48967a1") },
                    { new Guid("aee36a37-610c-4f36-baa6-eb96adab98ca"), "Chet.Nienow33@yahoo.com", "Joyce", "Leuschke", "1-818-749-8918 x2354", new Guid("cb06d699-2e4d-4889-b0f5-c469a75e3d85") },
                    { new Guid("b21f8441-684b-404e-a8c4-dd156650dedb"), "Tressie_Wolff@gmail.com", "Trevor", "Collins", "938-325-2960 x4426", new Guid("a86c9e61-216e-4cc2-9e7c-4fe1eceac774") },
                    { new Guid("b669ddef-5fe9-4afb-a5ca-f99e736e360f"), "Zena1@yahoo.com", "Rosina", "Harvey", "903-490-5176 x1595", new Guid("ff3e9753-56f1-4d80-acd5-0dc41a58eca3") },
                    { new Guid("b8dc2146-439f-41af-885a-4ff1f86db65e"), "Lavon34@hotmail.com", "Edwardo", "Leannon", "575-886-7269", new Guid("a554d681-c9f1-4460-9190-efa5faa5ec41") },
                    { new Guid("b998c8e6-0b3c-4293-8d24-53611fec24dc"), "Jeramie33@gmail.com", "Timothy", "Leannon", "1-788-873-7240", new Guid("e1673403-8ff9-44a5-8048-442e34d3925e") },
                    { new Guid("b9a3ebfb-e89a-41bd-9530-8902fd579350"), "Jeremie_Corwin@hotmail.com", "Caleb", "Larkin", "(843) 410-2706 x9123", new Guid("7129453d-76f4-4ce9-b18c-ec6d663bbc39") },
                    { new Guid("bbf793b8-a103-4f43-9476-8041adbcd06e"), "Erna14@hotmail.com", "Brayan", "Bashirian", "853.900.4248 x48811", new Guid("24305129-5519-40de-baf1-6e042634b476") },
                    { new Guid("bd4f5f49-596c-413d-875a-b627e5086e3d"), "Alverta.Cremin8@hotmail.com", "Madeline", "Leannon", "660-569-4272", new Guid("2b70567e-b2ab-46e0-a9b3-90677e0775be") },
                    { new Guid("bef46614-c3d3-4713-b5a3-731d59b38c84"), "Jade.Ullrich@yahoo.com", "Cooper", "Denesik", "1-291-395-1504 x536", new Guid("6b349ea2-116d-4a53-91f0-f632dba48379") },
                    { new Guid("c038d26b-d636-4867-9e02-6083cd85bb04"), "Alec39@gmail.com", "Mohammad", "Gleason", "1-590-569-9487 x4822", new Guid("65780980-f627-420c-b537-5efc2ec06f6c") },
                    { new Guid("c0ef87be-5024-45d8-aff0-4d06ac52b619"), "Deanna.Schmeler93@yahoo.com", "Tracy", "Koepp", "252-615-7726 x73806", new Guid("425a8920-ab68-4dd9-8293-131a50b149e7") },
                    { new Guid("c2c70a38-43bd-48c9-b75f-c07e60ba7228"), "Jazmin.King@yahoo.com", "Aidan", "VonRueden", "306-269-3955", new Guid("7696709d-1607-469a-b74a-0b79d303c1d4") },
                    { new Guid("c4236ddb-32cd-4310-9010-8f8ceb30e854"), "Alexandra79@yahoo.com", "Rafael", "Farrell", "(393) 273-7274 x831", new Guid("a8abd601-97b6-4d10-82b3-73afeaae828d") },
                    { new Guid("c6b3f6b6-8012-49ea-b3b6-ca32a9d738c9"), "Korey_Weber@gmail.com", "Nasir", "Mayer", "1-606-503-9357 x301", new Guid("0bf42133-b603-402a-a2da-ad0b317aa67c") },
                    { new Guid("c9ad63c2-84e0-4b7d-93c9-c4d83bba5453"), "Lilla_Jacobson92@gmail.com", "Judd", "Crona", "235-883-6016", new Guid("4bfdd9e7-4f9a-4c34-85bd-3f338a3aa7f0") },
                    { new Guid("cd06b421-a377-4501-8769-d8dbf42de555"), "Samanta92@yahoo.com", "Sheila", "Wisozk", "489.868.6347", new Guid("8e6d2415-4231-4db8-a2b8-97a3736e3336") },
                    { new Guid("cd5c9f08-deff-4a14-aff2-8155e4700b59"), "Jamison20@yahoo.com", "Keven", "Bahringer", "742.740.7002 x1651", new Guid("2b92e109-4745-4fe5-82ea-52ed0f74d0b6") },
                    { new Guid("cd9d87f0-9f36-4be6-9d7d-dca1680bbee9"), "Kip83@hotmail.com", "Clay", "Keeling", "741.388.9251", new Guid("e069e7f6-f3d5-4b65-993c-10b0b2a9b477") },
                    { new Guid("d20fd751-11a1-4b73-bb08-f7bcb62875c1"), "Delia_Sipes@gmail.com", "Charity", "Sanford", "(361) 874-2423", new Guid("87b1dc48-ba09-4df6-b272-6ee4a56fcdf7") },
                    { new Guid("d46f2f52-eb19-42ae-b75a-05d1dcab20df"), "Paris27@gmail.com", "Gabriella", "Adams", "261-415-2659", new Guid("dc0850e2-38c3-4d99-9454-b8e30451ac03") },
                    { new Guid("d9617964-c015-447a-a3ef-87baf959b506"), "Marianna77@yahoo.com", "Jakob", "Lueilwitz", "272.761.3480", new Guid("f56a7ed8-2bca-4d67-8fd2-00c05f91ae30") },
                    { new Guid("da81eae3-956e-446e-a0c7-11399e3e5214"), "Hellen_Nicolas99@hotmail.com", "Keanu", "Dickens", "(269) 777-0525 x5931", new Guid("5bb42dea-7bd5-4555-b3ab-d1547266dd1b") },
                    { new Guid("ddbf63f2-afe8-4771-a6f8-fce30e4dea57"), "Presley_Torp29@gmail.com", "Kurt", "Schulist", "(768) 495-5878 x4787", new Guid("4a1d3036-d642-49c0-bd34-f6755c035b7f") },
                    { new Guid("e0a4d9e6-c7d2-4ffa-8c14-b5bab748ba15"), "Damon_Kunze89@hotmail.com", "Rodrick", "Bailey", "437-310-2899", new Guid("5d06fda3-9c63-4a82-8172-f42414adcf24") },
                    { new Guid("e0aa7406-27d4-4a24-91fd-e558c2861a6a"), "Jaron81@gmail.com", "Athena", "Rice", "1-399-574-7606 x660", new Guid("3f33389e-84ff-4ef5-826b-60ce63f1439b") },
                    { new Guid("e276b4a0-7951-4334-8c8f-c1f441b580c9"), "Jamal75@hotmail.com", "Jordan", "Mayer", "215-771-5884", new Guid("3a48d8d0-b0e7-4391-8353-619dbaf501e9") },
                    { new Guid("e3daafa4-b6a9-4f5e-81ff-afae1849ac39"), "Dessie_Metz69@hotmail.com", "Tyreek", "Windler", "1-488-817-3302", new Guid("752cfca8-e84c-42e1-a1af-f0c7b4039a00") },
                    { new Guid("e3f1db48-8340-4b28-93d9-a99cac395a1e"), "Gretchen35@gmail.com", "Elmira", "Mann", "(892) 830-2533 x9332", new Guid("82acca8a-42a7-43d9-9bc7-f1074ead1cab") },
                    { new Guid("e43bb188-8c81-40df-9135-58640017d097"), "Dion_Hayes@gmail.com", "Tessie", "Bashirian", "(394) 397-0281", new Guid("bedbe7c1-0a77-42b6-a963-b95440f59eac") },
                    { new Guid("e4e277a0-efbb-4c5c-9b35-9f674297b00d"), "Vallie_Kihn63@gmail.com", "Hulda", "Wisozk", "(227) 463-4797", new Guid("23793948-9876-45aa-9e58-301a8c4a48f3") },
                    { new Guid("e7b89713-4246-453f-b164-051ca9b3fef1"), "Ilene50@gmail.com", "Theodora", "Wilkinson", "1-722-959-0571 x78342", new Guid("850a8e3b-28c1-47d6-87e9-d2a0cb30e983") },
                    { new Guid("e9c4ef4c-42c0-457a-a530-f471d99fb13a"), "Dejah.Shields@yahoo.com", "Shayna", "Runte", "(529) 278-8453", new Guid("4e1115c2-051b-4472-8eb9-708ef0c92f50") },
                    { new Guid("eceb2944-fb54-49f8-868d-514f25b96037"), "Lafayette.Haag@gmail.com", "Kassandra", "Rutherford", "(993) 374-9763", new Guid("28190b26-27e0-4134-8cf1-ee518f7823a1") },
                    { new Guid("f12e6254-95ba-4e17-9f25-bd0b51c6ffc4"), "Owen.Cormier@hotmail.com", "Wayne", "Runolfsdottir", "1-954-778-4792", new Guid("762f13a9-5ba9-4af7-8e0f-e1839b29efcf") },
                    { new Guid("f24f7621-db69-4ce3-bc21-aa620aab78f2"), "Elna.Schowalter@gmail.com", "Alva", "Upton", "245.292.4997 x581", new Guid("1df04cfa-86a2-49ad-bcbf-4b1157b095ac") },
                    { new Guid("f4081a01-8011-4e76-9b43-00836eb50d24"), "Gilberto.Hessel95@yahoo.com", "Aurelio", "Beer", "1-876-920-4113 x824", new Guid("7706b50a-1368-4961-b2f0-5c0367ab17da") },
                    { new Guid("f4f2d853-4495-4ff9-9212-31d342bc49f2"), "Meda23@yahoo.com", "Hailie", "Kshlerin", "1-430-410-3198 x1458", new Guid("d3f74f3f-9e30-4701-ae7e-62c01812c6fa") },
                    { new Guid("f5445ed2-00f5-4161-b8c3-5b008efedf82"), "Kurtis.Von32@hotmail.com", "Marvin", "Haag", "1-643-390-0729 x8208", new Guid("6dbc66b9-ada1-4085-8160-668a20878440") },
                    { new Guid("f71b01d4-0a9f-42e2-89eb-2b0d79a3b793"), "Enrique_Kunze@gmail.com", "Fatima", "Satterfield", "(390) 824-3451", new Guid("8564a9fc-b21c-414a-9fc8-f5293f58ee23") },
                    { new Guid("f97f0049-1b9a-4d78-8928-eeddfd359f0d"), "Brad17@hotmail.com", "Maximus", "Williamson", "(709) 694-0683 x3588", new Guid("58dc5b15-594b-46f3-bce6-d3684c66eb33") },
                    { new Guid("fa5cfc41-c274-4eb4-9e8e-394d44b804c5"), "Josue4@hotmail.com", "Laverna", "Lakin", "474.501.1778", new Guid("59a5a781-e45d-4f97-bc20-091fe1cdc1bf") },
                    { new Guid("fded5c0a-50f2-449d-931e-eb952ee87abd"), "Lindsey.Lubowitz@hotmail.com", "Cathrine", "Mohr", "(331) 557-2828 x21247", new Guid("45695c1f-0160-412e-a3ee-322287992fd1") }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("030278f5-6d50-40a3-a3af-5e14e90954eb"), new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"), "Beetle" },
                    { new Guid("1edf469c-f9f2-41dd-b0b4-ba20277ae4f8"), new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"), "Fiesta" },
                    { new Guid("298aa61e-a596-45d6-a993-710bb22a808b"), new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"), "Camaro" },
                    { new Guid("33c068af-065c-4207-801c-6c6ee832dd23"), new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"), "Taurus" },
                    { new Guid("49f3b4f9-5fd7-488c-861d-0a8a14fc61ff"), new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"), "Charger" },
                    { new Guid("55ce2ac7-53c1-48d9-96b4-571829d682c1"), new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"), "Element" },
                    { new Guid("55d8493f-6af2-435a-9c97-09db44d1e9d4"), new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"), "Grand Cherokee" },
                    { new Guid("5be1f7f4-8066-4741-bcd2-8542fc2e6115"), new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"), "Ranchero" },
                    { new Guid("639649f9-a608-412e-b8ab-1877a493b86d"), new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"), "Fortwo" },
                    { new Guid("6b0dae5a-ae24-475b-a65b-b7b4b272f496"), new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"), "Escalade" },
                    { new Guid("7290df1e-e104-4bf5-b7f3-6ae10053a96b"), new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"), "V90" },
                    { new Guid("84a41c34-da68-42ba-a17e-c001d9dcf77d"), new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"), "CX-9" },
                    { new Guid("91a6f37f-5ceb-4cce-a27f-90f630e16355"), new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"), "Countach" },
                    { new Guid("9f9352f4-8102-4b40-9042-447519453f4e"), new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"), "Spyder" },
                    { new Guid("a1dc7086-3a3e-416f-b476-02c3988cdaba"), new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"), "Explorer" },
                    { new Guid("a3a757e5-394f-46ab-8c8a-c956d5fe9110"), new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"), "Model S" },
                    { new Guid("a44d8035-034b-4369-a98e-1e61ee9706a2"), new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"), "1" },
                    { new Guid("a5dd859c-80f5-47a8-8eb2-e50d1285dac3"), new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"), "CTS" },
                    { new Guid("abe323d3-5e80-4e45-9a03-10aecd2ce0c7"), new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"), "XC90" },
                    { new Guid("afd30eba-43fb-4704-ad7a-2ebb25515fb7"), new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"), "CTS" },
                    { new Guid("cd3b071d-1343-4a5c-8592-4ebb8cb7bfa0"), new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"), "Model S" },
                    { new Guid("d84b07b7-5d85-4c81-98d6-0f636b18546b"), new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"), "2" },
                    { new Guid("d86f99cf-078a-437d-83b6-824bb13c4702"), new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"), "Durango" },
                    { new Guid("f1bb40a8-ebbc-4096-8d83-028ad80690c2"), new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"), "Civic" },
                    { new Guid("fd139145-5df2-4ee7-bdb7-c93fddece837"), new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"), "PT Cruiser" }
                });

            migrationBuilder.InsertData(
                table: "VehicleClientHistories",
                columns: new[] { "Id", "ClientId", "EndDate", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("05271ce7-c44e-49d1-93aa-5d02f5eb952d"), new Guid("c0ef87be-5024-45d8-aff0-4d06ac52b619"), new DateTime(2024, 2, 6, 3, 17, 42, 493, DateTimeKind.Utc).AddTicks(5027), new DateTime(2024, 2, 6, 9, 58, 5, 537, DateTimeKind.Utc).AddTicks(6709), new Guid("2f0b169b-11b7-4d5a-8930-d3e04854f2c3") },
                    { new Guid("0e65046e-2389-4bd9-8b7f-41e6556863e7"), new Guid("f4081a01-8011-4e76-9b43-00836eb50d24"), new DateTime(2023, 11, 19, 3, 58, 24, 891, DateTimeKind.Utc).AddTicks(7755), new DateTime(2023, 8, 26, 23, 17, 11, 28, DateTimeKind.Utc).AddTicks(910), new Guid("39508c99-6512-4567-8413-7df6bf94bccb") },
                    { new Guid("0fb74884-43ae-4f5a-a2ba-580ae74a3cab"), new Guid("2892875a-dbe5-49a8-b02f-83ae2f7a206c"), new DateTime(2023, 9, 9, 20, 35, 10, 669, DateTimeKind.Utc).AddTicks(3561), new DateTime(2024, 3, 6, 8, 26, 42, 25, DateTimeKind.Utc).AddTicks(52), new Guid("dc0850e2-38c3-4d99-9454-b8e30451ac03") },
                    { new Guid("938ed5c2-6fc8-463e-b77f-9372c0aa7b72"), new Guid("601b604e-cca6-483d-8af9-4af30b783d62"), new DateTime(2023, 7, 7, 17, 58, 52, 311, DateTimeKind.Utc).AddTicks(6634), new DateTime(2023, 11, 24, 1, 3, 4, 741, DateTimeKind.Utc).AddTicks(3626), new Guid("7d646714-3ca8-410e-a9d7-c4b7fab2a292") },
                    { new Guid("cb63a27d-53bc-4e6e-b588-da0a6c632dcb"), new Guid("7c84432c-a625-4c5b-987c-32474563feda"), new DateTime(2023, 11, 13, 2, 44, 20, 150, DateTimeKind.Utc).AddTicks(2265), new DateTime(2024, 6, 2, 18, 47, 2, 731, DateTimeKind.Utc).AddTicks(7676), new Guid("e099005b-55be-49ed-bf2d-8a954212a8d6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelNameId",
                table: "Vehicles",
                column: "ModelNameId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_ManufacturerId",
                table: "VehicleModels",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleModels_ModelNameId",
                table: "Vehicles",
                column: "ModelNameId",
                principalTable: "VehicleModels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleModels_ModelNameId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ModelNameId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0081dad6-0bfe-4b0f-a221-e48207c476f1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("020a6acc-742b-4744-99f8-d405446502a0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0324d16d-3b13-4b61-ba2f-0ede1a54d320"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("05e1c97b-d013-4317-8748-24e8f2798ab4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("06e725bd-c753-4fd9-be6a-5bbd0a90649e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("09cbcbaf-441c-4057-b933-1ec6999b10f9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0efe199e-d40d-4f20-84ba-a7aba87129f3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1193b6ac-37ac-4e27-82cc-ed05dd6e78f1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("13478ce7-45c6-4863-be4f-3735cb2e29a3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("15bd9c8c-d928-4b84-bd0b-e478ac41f2f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("15e935ba-0ce5-4cdb-abd9-203b7f6d5fd8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("16af6a1e-ac4c-4506-927a-19d151132ae7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("19f603f1-2eab-4737-9af6-b4b5a66dccf1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1b5f4904-16c9-4927-979f-b61055a59465"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1d34076b-142e-468b-98c5-a626eb3759aa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1e7d69a3-0578-46a6-aaab-f51d55583b20"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("21a808e0-0ab2-4d4f-8de2-b5d03496a614"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2252ec33-7c90-45dd-a1d2-17daec94e8c4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("238785e3-02ca-4a18-88e9-6ce7f3b11e39"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("23e18591-d974-43d7-a89f-a83b78c00142"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("26ee8545-bffb-46d9-8e3e-5f6554dc9237"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2891e377-444e-4a82-a1ef-29dc2bf3614b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("295da0a1-3093-4ac4-afa8-21d3a0105bbc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2b0b86ec-8100-4693-be79-06eafa441013"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2f2d8a0d-50a0-4319-bce1-729cdace810b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("313524a0-24b4-4eee-8ac4-32b448f7a8f6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("36c28ffd-d733-489b-ad0d-4e70baa88da4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("38de5ec1-1b16-44d3-939e-82d10cd33e55"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3a4899e7-a528-4406-8417-b9a6b392353f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3cb44855-2d66-41f5-b516-53d0ff71621d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3fb69d4c-c194-480b-9d3a-035d50780805"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("44e16406-96a7-4a2d-86ab-4b193f287653"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("45be23a3-8d26-4a49-9c8c-468f2bc44011"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("481cab84-1a13-4f6c-9bd5-d46978fc00f3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("48a28632-1593-4da8-a702-5f24e49fd4e2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4b92a086-3756-4f10-8fa2-a3cad2645053"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4cb499a3-38f4-49f5-938a-ff25772623c9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4f356b5c-8863-4ba2-b495-069afa01ed59"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("50c16984-964c-422e-9526-811d973854cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("537e808e-e01f-43d6-baab-49c9205548ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("53d95ad0-9853-4787-b66f-35b35a2ff154"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("550b3507-baf4-41cf-989c-b48b9b823d6c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("556c7279-530f-4c7f-aa36-bd12ee86ef8e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5976c167-a2af-4cb4-aefc-13db04b214c0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5c7e1c48-99fb-49b9-96a3-17a0bea75a2f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5e3676eb-bf1c-4c93-9ecd-959b0baa8d39"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("625f97b6-59c8-478b-a805-b2f0da38727a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("64156eee-2f34-4c32-8731-d2e8b8b2f479"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6416bda2-12c9-4d02-b98f-d666734e2f8f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6475b262-418b-4c8f-afdb-a21426a77510"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("657a8e1d-0501-4db1-8f1a-f0e98edb8578"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6bb5a425-de2c-4d70-bed7-b6fc11c78783"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("707e3dda-9c1a-4ced-8aee-89ee93e6ae5c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("74c9615a-7431-4ab0-a301-3d86eba785a0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("75c4250c-2e0a-48ad-ad2d-8ae74dd18bbb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7a0afdc5-f11d-4f70-9e88-de5737455d7b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7df2138b-526c-4458-a794-c7f19fd0933d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("809bbb38-a4d0-4326-b88d-d3c7a636cbdd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("81045fc1-3b9a-4034-ba57-c8d035711883"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8477561f-5450-402b-af3d-475a1fbd6122"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("873d79dc-9b9a-4c0b-93a0-93dc7d31ee48"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("88ec27b9-9fa5-4d98-b5d7-77f86f643576"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("89958d5d-b8df-4503-a113-b2d9d7ea3d71"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8a165485-1430-4afc-b846-0a888fe7e450"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8bb69b47-f2c0-42c6-91dc-985b52b6e53a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8c709958-2e71-4f2b-a109-1f0d075c08ca"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8cd236ab-d93e-4ff3-bf5e-b39873fd60e4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("911caab8-09e1-477c-89f0-91c547f3e009"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("95202c99-5f9b-44c4-bd9f-940eb535593b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9954740f-4a9a-48f0-8efe-ce02220a9fad"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9f27e45c-5054-4bfc-9309-d1d89635634f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a470fd86-d553-40fc-98c4-34674c8ea355"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a884083d-8fce-4f1e-837f-b0f72a48caba"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a8a8e5c8-89cf-424f-bd07-01e99452d1b4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a8f2553a-e242-4a5c-a05d-bc9e7fb2d854"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a9811e84-c22d-4488-97a6-052b7962293f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ab9afe08-8adc-4fd7-a917-b9b820f305d6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ac8c576e-5757-46ca-97c5-7ec41927cdff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ad85d84f-9768-40fe-acc1-0f502af4adcc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ae60da7c-4c71-42ee-8c0d-2b53a5a9ff30"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("aee36a37-610c-4f36-baa6-eb96adab98ca"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b21f8441-684b-404e-a8c4-dd156650dedb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b669ddef-5fe9-4afb-a5ca-f99e736e360f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b8dc2146-439f-41af-885a-4ff1f86db65e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b998c8e6-0b3c-4293-8d24-53611fec24dc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b9a3ebfb-e89a-41bd-9530-8902fd579350"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bbf793b8-a103-4f43-9476-8041adbcd06e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bd4f5f49-596c-413d-875a-b627e5086e3d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bef46614-c3d3-4713-b5a3-731d59b38c84"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c038d26b-d636-4867-9e02-6083cd85bb04"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c2c70a38-43bd-48c9-b75f-c07e60ba7228"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c4236ddb-32cd-4310-9010-8f8ceb30e854"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c6b3f6b6-8012-49ea-b3b6-ca32a9d738c9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c9ad63c2-84e0-4b7d-93c9-c4d83bba5453"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cd06b421-a377-4501-8769-d8dbf42de555"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cd5c9f08-deff-4a14-aff2-8155e4700b59"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cd9d87f0-9f36-4be6-9d7d-dca1680bbee9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d20fd751-11a1-4b73-bb08-f7bcb62875c1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d46f2f52-eb19-42ae-b75a-05d1dcab20df"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d9617964-c015-447a-a3ef-87baf959b506"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("da81eae3-956e-446e-a0c7-11399e3e5214"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ddbf63f2-afe8-4771-a6f8-fce30e4dea57"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e0a4d9e6-c7d2-4ffa-8c14-b5bab748ba15"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e0aa7406-27d4-4a24-91fd-e558c2861a6a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e276b4a0-7951-4334-8c8f-c1f441b580c9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e3daafa4-b6a9-4f5e-81ff-afae1849ac39"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e3f1db48-8340-4b28-93d9-a99cac395a1e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e43bb188-8c81-40df-9135-58640017d097"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e4e277a0-efbb-4c5c-9b35-9f674297b00d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e7b89713-4246-453f-b164-051ca9b3fef1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e9c4ef4c-42c0-457a-a530-f471d99fb13a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("eceb2944-fb54-49f8-868d-514f25b96037"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f12e6254-95ba-4e17-9f25-bd0b51c6ffc4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f24f7621-db69-4ce3-bc21-aa620aab78f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f4f2d853-4495-4ff9-9212-31d342bc49f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f5445ed2-00f5-4161-b8c3-5b008efedf82"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f71b01d4-0a9f-42e2-89eb-2b0d79a3b793"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f97f0049-1b9a-4d78-8928-eeddfd359f0d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fa5cfc41-c274-4eb4-9e8e-394d44b804c5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fded5c0a-50f2-449d-931e-eb952ee87abd"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("555f2cdd-68f0-46c8-ad8b-791f230d2fc3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8134158e-e0c2-470b-b3f3-cc64f837ca40"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("89938ded-ea28-4c16-8dda-c67a090b84d4"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a40ba996-8d1d-41b8-8615-849613d5d0b1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c5e56f7e-c6e3-449e-9a97-80acc5e010f9"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("05271ce7-c44e-49d1-93aa-5d02f5eb952d"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("0e65046e-2389-4bd9-8b7f-41e6556863e7"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("0fb74884-43ae-4f5a-a2ba-580ae74a3cab"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("938ed5c2-6fc8-463e-b77f-9372c0aa7b72"));

            migrationBuilder.DeleteData(
                table: "VehicleClientHistories",
                keyColumn: "Id",
                keyValue: new Guid("cb63a27d-53bc-4e6e-b588-da0a6c632dcb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2892875a-dbe5-49a8-b02f-83ae2f7a206c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("601b604e-cca6-483d-8af9-4af30b783d62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7c84432c-a625-4c5b-987c-32474563feda"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c0ef87be-5024-45d8-aff0-4d06ac52b619"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f4081a01-8011-4e76-9b43-00836eb50d24"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("035ca887-13ca-476f-8525-236aa94f43cf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("04f97cb7-bffa-43f6-b2bb-aa0967bd19b5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0bf42133-b603-402a-a2da-ad0b317aa67c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0feae8cd-a195-4b76-af38-057400a76b69"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("132d9e51-0089-4641-8d22-e7b9e5efe04e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1df04cfa-86a2-49ad-bcbf-4b1157b095ac"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1e1f00e2-14bc-47f5-b6fe-949e8ae29b23"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1f40976d-e377-4316-b3eb-2e35eeb83a94"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("23793948-9876-45aa-9e58-301a8c4a48f3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("23d43cd0-24b8-4490-9a17-31a65f590fc5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("24151eab-0b1f-4902-8798-b91e31bd78e3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("24305129-5519-40de-baf1-6e042634b476"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("25ebddd1-aa95-41a1-b629-2aeaa67b1fd3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("28190b26-27e0-4134-8cf1-ee518f7823a1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("28549331-a1ec-4ce4-9888-5be729686356"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2b0d80a2-5876-4f36-8bdd-a6c132e84c1d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2b70567e-b2ab-46e0-a9b3-90677e0775be"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2b92e109-4745-4fe5-82ea-52ed0f74d0b6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2c6dc7c0-ee08-4986-99ca-523b4718a202"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2d2f7e70-5ebf-4e6d-a1d8-3cbf73ded16d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e8004ad-bdde-418f-b878-acd62effc529"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2f0b169b-11b7-4d5a-8930-d3e04854f2c3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2fec0375-384a-45b1-8a29-f42d8779471e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("39508c99-6512-4567-8413-7df6bf94bccb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("399bdadb-dbc6-4251-8501-78d8902acb6f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3a48d8d0-b0e7-4391-8353-619dbaf501e9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3b21114f-be6f-42e9-95a8-0692c48967a1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3f33389e-84ff-4ef5-826b-60ce63f1439b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3f5f6667-fe02-49b5-9791-300ca9a83a8d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("40418352-5ca9-4e72-be55-97972eb73483"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4293e359-2944-4e61-adb8-1f9c968f5f7e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("45695c1f-0160-412e-a3ee-322287992fd1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4570cd9d-1de3-495a-97f1-effd41957d92"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("499c770f-698a-4e5b-85df-ae3444a11358"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4a1d3036-d642-49c0-bd34-f6755c035b7f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4bfdd9e7-4f9a-4c34-85bd-3f338a3aa7f0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4e1115c2-051b-4472-8eb9-708ef0c92f50"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4e2c2567-b046-4259-a844-fcbe877b57e6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("55f76e64-08da-4911-952e-814c23e45018"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("578541f0-1e3e-4593-b5ca-77b747d8ddd1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("57fd5bb4-4f0f-4036-ae5e-0c76383fed8e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("58dc5b15-594b-46f3-bce6-d3684c66eb33"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("59a5a781-e45d-4f97-bc20-091fe1cdc1bf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5b50c102-c37a-401f-8a2a-49da669702ee"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5bb42dea-7bd5-4555-b3ab-d1547266dd1b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5d06fda3-9c63-4a82-8172-f42414adcf24"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5f2419e1-56b4-497d-9181-f3c48072a2fb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("65780980-f627-420c-b537-5efc2ec06f6c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("67d6a8fa-6e70-42c3-970d-ee8a8e3c6388"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6abddfec-7e17-40c9-bc28-40b330dd1147"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6b349ea2-116d-4a53-91f0-f632dba48379"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6bce64f5-8aa6-4940-ad58-c697eabdf512"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6bf01cee-b0d0-4ca4-9c81-5277891d32b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6dbc66b9-ada1-4085-8160-668a20878440"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6e1ff8e7-a416-4ef4-b928-791c6c44632b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7099b685-74ec-4124-b266-4b4d684b44b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7129453d-76f4-4ce9-b18c-ec6d663bbc39"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("75247936-2300-4e69-bf03-ac3ecf9bc891"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("752cfca8-e84c-42e1-a1af-f0c7b4039a00"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("762f13a9-5ba9-4af7-8e0f-e1839b29efcf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7695e0ff-92d9-47fc-bbf2-0a8bf39c6e71"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7696709d-1607-469a-b74a-0b79d303c1d4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("79e506b2-71bc-475e-9e06-f2ca5037cdcb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ae190c6-d23e-4c72-9680-ca9fa4410076"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7b56f402-5922-4ed2-8f91-7108d40b4637"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7c9a501e-6ac6-4a78-adf1-1c755098e243"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7cd55ed5-cdb5-4955-a38b-0d23e51a328c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7d646714-3ca8-410e-a9d7-c4b7fab2a292"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("80abdd2d-227e-45a5-ab06-1c3193e272ff"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("812ccb65-8978-40ae-9227-31461cc89162"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("82acca8a-42a7-43d9-9bc7-f1074ead1cab"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("82d244e2-2d86-46f8-bbc9-78889055992c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("850a8e3b-28c1-47d6-87e9-d2a0cb30e983"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8564a9fc-b21c-414a-9fc8-f5293f58ee23"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("87b1dc48-ba09-4df6-b272-6ee4a56fcdf7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("88729b64-e8fd-4647-84ff-32775b5185bc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("88da7d48-b38a-4825-94a4-d3c8362319a6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8e6d2415-4231-4db8-a2b8-97a3736e3336"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("94d79976-3f1b-4a4c-9312-b6632e204e2a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("958b62d8-2e27-40d3-90fd-9c0411b3b8c6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("95bbdd88-4b0d-4d9e-8cb5-8329ba69034a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9774eff8-cdaf-46d6-aa0f-680739a427b5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a21f606f-821e-4afe-94f0-1a8f1070ea95"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a554d681-c9f1-4460-9190-efa5faa5ec41"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a72ae15d-0327-42fa-92f9-92982806d7b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a86c9e61-216e-4cc2-9e7c-4fe1eceac774"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a8abd601-97b6-4d10-82b3-73afeaae828d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a93b850d-67fb-4068-9bb7-b628e8edde33"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ad0ce44e-d5ea-49e5-8245-466f7e95518e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b0cd2d2e-134f-4b7d-89b9-0011c36475f9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b3daa36c-fff0-4db3-abc5-98dc3080d8f2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b574da5f-4d55-42e8-bc73-d723fc15c368"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("be09a16e-7192-4152-94bd-454d49d1dc58"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bedbe7c1-0a77-42b6-a963-b95440f59eac"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bf57197f-c030-4255-bd07-0dba26d76503"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bff2f657-58f2-4ef0-a27b-06a371cf172c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c7b48b09-a7f4-49a1-80c8-2da35038d706"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb06d699-2e4d-4889-b0f5-c469a75e3d85"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ccd39f50-0a7d-4e78-868d-bdb8af2aaa2f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ce914af8-e3ba-439a-86b2-7d1ecd819bbb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d3f74f3f-9e30-4701-ae7e-62c01812c6fa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d7f9a3b8-bfe8-45a1-9a65-d07218270ced"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dc0850e2-38c3-4d99-9454-b8e30451ac03"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e069e7f6-f3d5-4b65-993c-10b0b2a9b477"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e099005b-55be-49ed-bf2d-8a954212a8d6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e100129b-337c-41be-8cd7-b1f95f48c81f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e142b9af-06b8-4f5e-8acd-617195cde85b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e1673403-8ff9-44a5-8048-442e34d3925e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e3af85e7-0e02-4fce-9ce4-ed2fbb5a99be"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e48849a5-a1ac-4bb2-ac07-f51c6c924716"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eaead9b4-fb55-419a-b076-5f63173d8ebc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eda01b31-8694-41da-934c-6a8f2e7828ed"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ef1b889b-047e-440a-ac5e-d16ae2299624"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f176a17b-04ee-4d2b-99f4-a307712f168c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f4601dbd-8b9b-453c-8544-729337472092"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f56a7ed8-2bca-4d67-8fd2-00c05f91ae30"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f5ea22f2-727e-42ed-9b2f-9fadd66a6c82"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fb32c839-b79f-4e3c-a96a-b34d57c93848"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff16361f-e4ea-4df5-8c33-defd30cdf675"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff3e9753-56f1-4d80-acd5-0dc41a58eca3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0402a079-d449-4701-a6c6-fc6d2043849c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("09354b0d-9af3-423a-9f79-ed72ea89ac45"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("425a8920-ab68-4dd9-8293-131a50b149e7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7706b50a-1368-4961-b2f0-5c0367ab17da"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a1b91859-73f1-4860-83e9-08cbb0bd1778"));

            migrationBuilder.DropColumn(
                name: "ModelNameId",
                table: "Vehicles");

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
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
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
