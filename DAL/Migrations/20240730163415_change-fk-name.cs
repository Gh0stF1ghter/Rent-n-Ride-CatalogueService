using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class changefkname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_CarModels_CarModelId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("4b524395-7112-4516-aeed-c4d268a68396"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("540cf388-3096-4941-a651-a226fb287c8d"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("9bb895b3-f778-411f-a977-afbd281e9172"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("a360ac28-660d-4819-97d2-8da1875e7907"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0074ed41-b5f1-43a1-9ded-cf544e7f1382"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("00ed94c7-5e4a-4177-8e65-d01c861a66d6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("02ed95a4-27f4-4f2e-82ac-6a0cd4643229"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("04d5cc6c-9717-4331-aa49-a2d91b55cfca"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0500586f-cf1e-4139-b6f0-7a66cd0835fc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0551088a-ff60-4be0-9abc-691b2bd6af73"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("05c3337c-cdda-4df9-8a1a-bb58b055b126"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0646dc87-7a5e-4e26-8945-f44d17032165"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("07ff6e5a-2176-4840-9c69-0333d5de2e46"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0aabe96c-3e39-4872-8cc7-11e0710e32fb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0b28e941-1209-44ae-9717-808995e500df"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0d0cf421-d5a8-4589-a5b6-a28a587b56fa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("12308882-80db-4f17-8259-019666ca14f9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("167f5359-200d-472c-baa2-2fb350846c15"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("18372838-2c64-40cf-8ad9-4cda4b234abd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("19c49823-9fad-4cda-be3f-1c48d5938f8a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1a649605-f7ab-4aaf-b06d-54fe54f47eae"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1bd2ef45-4f0c-4b6e-b5bc-df003cb53dff"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1fad1d94-ee6e-423b-a2d5-ee8181b6b9c6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("201c1db3-7e6e-4611-899f-a3afb6a7434f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2098f8d0-4e54-4af1-8ea4-fda7e9e7142e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2183346d-f9ff-449f-9108-e69d8786474a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2753a419-2b39-40db-9641-d3b72f22ee1f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("27730151-801c-4965-8718-1d1b19481071"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2a1a59a4-e8d0-4ea4-98c3-5b61ba4976d1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2a8d3ba5-1d24-4382-865b-1889552f6fde"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2ef5df33-d03f-4048-a1ab-c23d85e2400e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("36781d0e-fe3f-452a-9099-d613309b7304"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3865e756-b01b-4d30-85fb-7e009c4d0d96"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("39bfcff8-1a74-4af0-8745-72b0657f9c7e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3b39ccda-b425-4169-badc-297524379815"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("41ab7d63-7043-4d15-87a9-e721f3f28518"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4554f4a6-1e88-4568-b0ad-1ebcc686f4fc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("460b6ed2-06d2-4331-9765-eeaeac620fd6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e084d5-1e54-4b92-8483-9e181b0dac05"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("47fa4898-c709-4e77-a22c-642a635cf18c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4bc28e0e-8bca-4f33-a6b2-7b239db3ce50"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4cb8aa41-8878-4eaf-af6e-d9f0e2c11bc4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("514769b8-59ac-4b1e-86c5-47a97db6971f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("52f237c2-35d7-4f02-8cb6-325ab1f7168f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("54239a14-adc7-499c-b3d7-7fa081366b88"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("543e729b-60b1-48c2-9c7c-2edcfd164787"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("572701e4-b08d-4091-aedd-2f17479b58ea"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5aaa99ed-eb22-4862-9839-a5d573ee690e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5c622405-dc83-4ce2-83cd-d00a9f0a19d2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("62d392b0-afb8-4397-9771-8dfc27444e5a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("63e14189-7cb3-4c26-a054-ed966db2111b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("661c7ce9-ea62-4ef5-9584-b05e100b89ef"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6748d90f-bfab-4bbe-93b0-15ac385367cd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("68af71de-a593-4aa6-8c79-01a37c980a97"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("693b95c6-11a5-46c6-82f8-f2c829a0d86d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6abb6e59-6b3c-4558-bf94-a05e2aa9ff03"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6d0e1397-9e31-46a2-a751-ac320f93c920"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("73997aa4-127e-42e9-a6be-95cb79b18250"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7836d28a-4f8b-4ce5-ba4a-644672bb64b4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("783866cb-b69a-4d1b-a69d-3165d7fe12cd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7842a101-ae51-4938-b0d4-74f28badc71e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7a244adf-6df1-4871-b2ee-f7e903c6dbb6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7a9ef475-d665-4895-bb02-3867fe6c6d0a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ba75e96-bda8-4607-afbe-a67ab67f3aa8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7d34c61a-90bf-4b78-85cc-fc85be15cb52"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7e67658d-396f-4d19-ba58-5e3a08c6e405"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ef2b46c-1654-4275-8ba8-b91a1f3aab49"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7fcbc263-2991-4a08-9c9f-68b10743a1e4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("80f2b8d1-f244-43dc-a9d6-3359e1867238"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("85a06530-e7e6-484a-85d9-95837348c7ea"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8bfb0768-2222-481f-8c2c-987f8e9dfb47"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8c612899-aadf-441b-a1cf-5a32f16ac762"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8d530439-7a54-4413-94e6-73c33d3bb40e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8e483215-2833-4ffc-9227-6e89893eed17"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("909d195d-43d8-49f3-bce2-7d7e3b80da9c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9119fcb2-6cf3-44c7-80c8-654671bdf245"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("965291fb-3f77-4c4b-9adb-9c9554c6241e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("97eb5374-f109-4d91-971a-e0a2d057e9fa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("994a2a4c-dcd2-4721-8eed-6d0fd75029d8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9992137d-a4c0-4d1b-82af-5e157a697ff4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a08bd175-0b08-471d-9e6f-703460e655d6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a10dba78-130e-4a44-98a3-a0167680a0ac"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a1d3b740-21ed-4366-b6aa-c4cefdfdadd0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a520ec86-c12e-42db-9814-bc4ff2f524b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a652e8fa-481c-42fb-b002-a1275f91a92d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a7772a68-c19a-41c9-a029-7a9a450ca525"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a80409f7-84ae-486a-9021-c5e746b5a221"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a893a50c-11f4-4085-acec-9d9660a51fa5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a99d8758-b9a2-4216-b251-2cb2fefe14fb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("aa0306ef-fbee-4142-8c35-6604a2585d3c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("abf1e8fd-258c-4825-bf68-f6b00f6f0bbf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ad6337e6-5cd0-4b62-afe5-9974954be651"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b1a24365-5930-4276-85da-674175c3c647"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b469bb89-443a-4968-ba07-31f6ffc1931b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("beaff452-e462-4eeb-8393-ee2e90eb8f50"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c72805f9-e51d-47b1-8909-05bc4063d090"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c8326bf4-b6c8-472d-abea-a6eea890e953"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c841e52f-23f4-4d11-b19d-27ef507ab72d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ca23a0bb-98d5-4dc5-bfcf-f4f607820818"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cdf10118-82dc-42c9-b994-9936c00754e9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d0c47779-49e6-4921-b505-79ce9bed996e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d0d31fd7-6c3f-4a4e-96d0-78acadf0d347"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d1d514d9-5bec-4c8f-a943-7e10287d1cb3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d49fc15a-76f2-41ce-b585-6041c71bada1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d78544c6-24d9-459e-92f7-987ebdb01344"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d919e753-9d28-4f53-a8a5-5d2533c0121a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d96a57f7-67b6-481f-86ec-0c06a139bcfd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d9e4734c-4019-462a-8da4-4e95d364a30f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dc331a19-2c13-434f-925e-40586b80fa6d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dd4db276-6ba3-41cd-be5f-ef6756b518a5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("df06b71c-8821-4c61-b39d-7e0d31b4fba8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dff49dbe-7fda-40b3-bfda-e1a0ffcf88c2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e2936981-c273-4b56-a3ea-629338a0cbf9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e2f9c83b-80ef-4eff-a409-85ddcfbbf76c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e7691a25-e87e-4881-b1fb-7d775908195d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e7b07e06-6ee9-4c83-9b0b-2bbf9e0f9e2d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e7e1cc08-d962-4d30-a249-77fffdc05a9d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e7f8c860-5483-40f9-b4c4-599afb473849"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e8306a4e-997b-47f5-a208-9775f8e796e4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ea5d6418-e5c7-445c-a532-6e8753dfe434"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ef07de98-b3bf-4ada-975c-23373626e3d1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f03b9ec5-0052-4550-9998-d41cdd074baf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f31c62dd-9834-475e-8dc9-4124b7bee29e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f56dafa5-484e-47d1-a4f3-0baa9ab6efe1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f680c942-5ede-49fc-be0a-002a6f7070be"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f833f24b-5274-4241-be63-da4a696a7328"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fb65e3a7-cbf8-486c-a522-b53987ebb519"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fbde3658-1e75-491b-8ed3-0e7870eafcd4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fdbd469d-d452-457d-a93c-c49e27431bd7"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"));

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<Guid>(
                name: "CarModelId",
                table: "Vehicles",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"), "Toyota" },
                    { new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"), "Bentley" },
                    { new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"), "Hyundai" },
                    { new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"), "Land Rover" },
                    { new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"), "Chevrolet" }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"), new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"), "Mustang" },
                    { new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"), new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"), "Altima" },
                    { new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"), new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"), "XC90" },
                    { new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"), new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"), "2" },
                    { new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"), new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"), "Fortwo" },
                    { new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"), new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"), "A8" },
                    { new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"), new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"), "Golf" },
                    { new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"), new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"), "PT Cruiser" },
                    { new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"), new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"), "Explorer" },
                    { new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"), new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"), "El Camino" },
                    { new Guid("8bca530d-96be-412e-99d7-5399f8524cac"), new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"), "Cruze" },
                    { new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"), new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"), "Challenger" },
                    { new Guid("91cf93b0-f0e5-4302-be56-e62600663109"), new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"), "Fortwo" },
                    { new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"), new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"), "Impala" },
                    { new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"), new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"), "V90" },
                    { new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"), new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"), "Model 3" },
                    { new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"), new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"), "Charger" },
                    { new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"), new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"), "Element" },
                    { new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"), new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"), "Accord" },
                    { new Guid("be836d80-2053-49bf-ac77-f30c782652ad"), new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"), "Grand Caravan" },
                    { new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"), new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"), "Aventador" },
                    { new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"), new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"), "Charger" },
                    { new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"), new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"), "Fortwo" },
                    { new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"), new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"), "Cruze" },
                    { new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"), new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"), "Focus" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarModelId", "FuelType", "IsRented", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("026704da-8d7e-4b15-a2ec-d4fca47f0642"), new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"), 2, true, 6905, "TNPSDQ9E7GAG65286", 2873.158239042626500m, 1, 1 },
                    { new Guid("04ab2ae6-ab9d-4672-9ceb-aebabe9948f6"), new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"), 2, true, 6806, "E9WRVSA2SLFL21119", 2302.620284600756800m, 1, 4 },
                    { new Guid("0519707b-563d-41a3-ae28-b55f21020b75"), new Guid("91cf93b0-f0e5-4302-be56-e62600663109"), 2, false, 5257, "ICWL28YVX1S066111", 995.147109861581200m, 2, 4 },
                    { new Guid("07b61bfa-aeda-4758-bb83-86d9b2ad620d"), new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"), 1, false, 2114, "KWT7MNGCO6RG53918", 2446.928723170872100m, 1, 2 },
                    { new Guid("0b67abff-b381-47fc-81e3-7597264f0029"), new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"), 0, true, 2317, "EEYBN1N3NIL896226", 1879.168452083089600m, 3, 3 },
                    { new Guid("0bbfc7db-3d9e-405f-b8b7-b048993406b2"), new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"), 2, false, 1939, "DQ0EWCHE9VZT12316", 2876.840755628001400m, 2, 0 },
                    { new Guid("1111ad1a-a3f3-4d79-894b-b0a82f2664e5"), new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"), 0, false, 5401, "RFWNXV17D3LC20584", 349.5199340048248600m, 0, 3 },
                    { new Guid("137afe20-d4e5-4e52-9bef-5ae16b7e3d09"), new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"), 0, false, 3560, "NHDIT72T2WFB84803", 3896.598511714278400m, 2, 0 },
                    { new Guid("1427c182-5cc4-4286-a468-9444dccae2a9"), new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"), 2, true, 4984, "9EV12RSTGRUW96030", 3882.902762542040800m, 2, 1 },
                    { new Guid("183da0e1-393a-4612-b1d0-cab9369c781c"), new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"), 3, false, 4073, "BZQ27N7W20TK22336", 2723.784821049316600m, 0, 2 },
                    { new Guid("1b23856b-73d9-4a94-80fd-0391ab22645c"), new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"), 2, false, 4303, "LZM8YLSDGQF681334", 3146.71457183064400m, 3, 5 },
                    { new Guid("1bbe480a-c8ad-4b8d-8504-df8cfb70364e"), new Guid("8bca530d-96be-412e-99d7-5399f8524cac"), 1, false, 2820, "VP5GNR3MTLO183446", 3967.148912092722100m, 2, 0 },
                    { new Guid("1e9d931f-49a2-45c6-8b0d-3e143cacc997"), new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"), 2, false, 1847, "81FOL28GRGE764209", 2037.612610073545600m, 0, 1 },
                    { new Guid("21b7b541-27d3-4d85-b332-bc055f18314d"), new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"), 2, true, 6890, "PCU09TSBNFD155938", 538.11498754110100m, 1, 3 },
                    { new Guid("23584d03-2204-461f-95d1-595e5375d602"), new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"), 0, false, 5916, "1SORISKWKZV370782", 190.4848457361362800m, 2, 1 },
                    { new Guid("23af35ff-1f09-4398-8f77-041451985906"), new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"), 3, false, 3864, "GUNXL6JLQSIU28700", 2433.219704374249600m, 1, 3 },
                    { new Guid("26c5855c-653a-4eba-94a5-3fc5d4d6bc47"), new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"), 0, false, 6828, "WGK5TVRIPGZB73731", 2760.477595242056200m, 0, 2 },
                    { new Guid("26c5f912-74d9-4a04-a50f-82fca089346f"), new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"), 3, false, 8558, "W4CZ8XN190FQ45867", 2517.821067689489800m, 0, 5 },
                    { new Guid("2b8b1870-e4ab-42db-b73f-fa770a0d1734"), new Guid("91cf93b0-f0e5-4302-be56-e62600663109"), 2, true, 2027, "63V7SIYRMAZ758668", 1380.07846125218800m, 3, 5 },
                    { new Guid("2f93d5e4-4262-475f-9fa7-3e15a54b576c"), new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"), 3, false, 316, "3F0Y1V3KJJK478222", 3979.818045741987700m, 2, 1 },
                    { new Guid("36503db4-7df4-4fcb-8576-0584576dfb67"), new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"), 3, true, 1845, "H3MH1S94YXGS62423", 3014.735180115729100m, 1, 5 },
                    { new Guid("36d5bb68-efa5-4c85-8d65-076ca8914973"), new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"), 3, false, 435, "Q6IO4QYCEHM218663", 953.355540757922800m, 0, 1 },
                    { new Guid("3a5f9234-f817-429e-907b-c008ea2cd6b3"), new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"), 0, false, 25, "A6IKQG1W2WNB77155", 3859.994600585173600m, 2, 5 },
                    { new Guid("3d3e53bf-b54f-4136-936a-62c15f1064c7"), new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"), 3, false, 365, "CDZGPJEA65XE80818", 906.042317886527800m, 2, 4 },
                    { new Guid("3dee8b72-0c9c-4693-aeef-7318a1eb267c"), new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"), 2, true, 9530, "Z0DYNZI01BJ024640", 3804.408231579039400m, 1, 3 },
                    { new Guid("3e5bedc8-978f-43e8-8aa0-4bdecbcd0b67"), new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"), 3, false, 9569, "5IK6NE1DZYD382237", 3336.117957958783300m, 2, 4 },
                    { new Guid("4094cb5e-9e77-4b89-82e4-5ac89822f05e"), new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"), 2, false, 6328, "RA61S3HSWQBJ57532", 515.927888963723500m, 3, 0 },
                    { new Guid("41a329bb-120b-4e69-b843-afa0d01c28c3"), new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"), 2, false, 5648, "QXVG9MDYJ4HO24594", 3488.792822853946300m, 3, 5 },
                    { new Guid("4363dc6d-f721-4aad-a429-3bb0889ba6d6"), new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"), 0, true, 410, "WIXNQ6O967K939143", 2566.244610845228200m, 3, 1 },
                    { new Guid("4fe1b13c-6d83-4fc0-8017-0418a994dec1"), new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"), 1, false, 9833, "F8MRDG31IUDC92976", 1323.181818458356900m, 3, 5 },
                    { new Guid("50136db2-52c2-4b22-afb6-fe29b0855ff6"), new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"), 3, false, 2416, "2KX6O8WTGCT698471", 1564.887851322703600m, 1, 2 },
                    { new Guid("513ba94f-db79-4688-866f-f86c623b7764"), new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"), 3, true, 5114, "QNXSMYI2E6TI93422", 3367.110895646419900m, 1, 0 },
                    { new Guid("51d5101f-78da-43a4-903a-5c7fd86ddf3a"), new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"), 0, false, 2879, "9U8CCTESYJC937274", 373.5461622847170100m, 3, 5 },
                    { new Guid("556a1d9e-b10c-410c-941d-ece054fc1774"), new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"), 3, true, 5515, "WSO73S9JQZW866512", 1791.839213667573100m, 3, 4 },
                    { new Guid("566c2538-2c08-4a12-9678-256930db8356"), new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"), 0, false, 7383, "WLVTA131EYYK13150", 903.012408766925500m, 3, 4 },
                    { new Guid("62a1020a-8f50-478a-a454-199a8b9a0e4a"), new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"), 1, true, 8102, "RNAV5UPN4HYF85854", 3559.711982781039700m, 2, 2 },
                    { new Guid("63819291-a6e5-4680-af5f-4d98ab69a254"), new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"), 0, true, 3715, "QCY5524XWKOP80621", 1220.231874169649800m, 1, 5 },
                    { new Guid("646576da-00f5-4eed-a7f9-6ae53e2caa60"), new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"), 3, true, 3876, "0CVLOHLRG3SV10647", 2381.252368750665700m, 3, 5 },
                    { new Guid("66bbf49b-f37e-4e85-b124-1a8b5ed3fbce"), new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"), 0, true, 5146, "E1FP3GEJ37YV67183", 313.6987081359048100m, 1, 4 },
                    { new Guid("66e841aa-4fb3-4e0b-80fd-fb2fca7d05ba"), new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"), 2, false, 7607, "ZTBSGFZG6VQF54031", 2322.22316998173700m, 3, 3 },
                    { new Guid("68ea7e55-89a5-4a9b-bd2b-49cb92e63b5d"), new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"), 0, false, 6258, "33X1L2QAAJBM55716", 1438.469378786343700m, 0, 0 },
                    { new Guid("68eb1606-b7b5-4abf-8e68-ccbb867ad266"), new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"), 0, false, 3190, "MP2N1EQGQCTR88026", 175.0176702460623100m, 2, 1 },
                    { new Guid("69c1a579-9fc0-475e-8af8-3b64ad827eba"), new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"), 2, false, 1931, "SSSCJUQ98ZDK38221", 3361.96800265078600m, 1, 4 },
                    { new Guid("702be2f5-b058-4b48-98bb-ab563548f7a2"), new Guid("be836d80-2053-49bf-ac77-f30c782652ad"), 1, false, 4308, "Y2V0UPX0SFWD66135", 3026.81763497145100m, 3, 3 },
                    { new Guid("7318ea57-dc7e-4b17-9171-fd65c287f9ec"), new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"), 2, false, 4097, "UWDFSXK16KSG15208", 1443.103165466381800m, 3, 0 },
                    { new Guid("7323db83-986d-44ba-860a-43b5671f6534"), new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"), 3, false, 4066, "MB6H79VGBXN486538", 2778.491526927010600m, 0, 2 },
                    { new Guid("735ca0ea-d352-47d3-98c3-2b20ecf4adb8"), new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"), 0, true, 8563, "J9E5VBB9SGE623310", 2495.689937164174300m, 0, 3 },
                    { new Guid("738b006c-9bff-4d26-ae18-cbc2fb73c6e5"), new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"), 2, false, 585, "Q9BFMT66NJZ713232", 3546.807933291825700m, 0, 4 },
                    { new Guid("74672d42-d8d3-45b4-af37-46b9346e2600"), new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"), 3, true, 2897, "ESFUVCK1ZXDA46902", 3962.532872756564500m, 2, 0 },
                    { new Guid("784c19bd-47aa-49df-b94c-0acd66bf1d43"), new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"), 2, false, 2287, "Y5VZBKZ17TKT94932", 3625.8023399423500m, 2, 3 },
                    { new Guid("7ab28f14-8add-4236-a71a-828ee023d60f"), new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"), 2, true, 7895, "IUFUFQ9FQ9LN77173", 414.6186327020545900m, 1, 2 },
                    { new Guid("7abae46d-da6a-4a3f-8c0a-bcc0d0e04d02"), new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"), 2, false, 5730, "TK3NBH7RGPQ195643", 289.8329601155217100m, 0, 1 },
                    { new Guid("7dc1166f-9b81-460d-98ab-ee06dad75086"), new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"), 0, true, 4072, "HZD23Y3MT2XX10641", 972.862512748700500m, 2, 0 },
                    { new Guid("80d39ddc-c46e-47b1-88d0-0753621f158e"), new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"), 3, true, 692, "6JI2ZQ0X2GY555430", 3340.097237367456700m, 1, 3 },
                    { new Guid("81947ba9-6872-4a3a-88e9-18edcafdfdc2"), new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"), 2, false, 5720, "NM2TISQIPEBI92382", 667.223887134884200m, 2, 4 },
                    { new Guid("81af1aca-08ad-4108-ae98-5d615e3e9ccf"), new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"), 0, true, 6998, "19XNYR7440OB32993", 2254.20628977041800m, 1, 0 },
                    { new Guid("81c54fed-13ae-4728-954f-a73fa8556208"), new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"), 2, true, 9099, "KMYMR9P03WHH75883", 2337.629275218625600m, 0, 5 },
                    { new Guid("81e0f9c0-3433-4452-9a5f-effcf20820f4"), new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"), 2, false, 2421, "PNKF2NYNRMZX58400", 1239.384427538106100m, 0, 2 },
                    { new Guid("8218918d-38cf-4779-9e69-3ea5a53b6bc0"), new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"), 2, true, 8382, "X8R2BJGWJVH229592", 3736.90419390149800m, 3, 5 },
                    { new Guid("835d1f89-8ca8-4135-b6e4-47ad4d78acdd"), new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"), 2, true, 7321, "HCL5MGX1LMX074173", 278.4787964637909400m, 1, 1 },
                    { new Guid("84933806-9900-4219-8d01-a418cf0777f2"), new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"), 2, true, 1452, "ER37QKK4M4X494884", 3349.64767738865800m, 3, 0 },
                    { new Guid("892212fe-5acf-497b-abfe-67f561cef4b1"), new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"), 0, true, 564, "8CKI64GLM2ZF72293", 2312.513361875857300m, 3, 5 },
                    { new Guid("899edf75-6928-4d83-9373-7a5d67005dd5"), new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"), 2, true, 3939, "6KWN7C4OG5JQ51396", 3565.576095078229600m, 1, 5 },
                    { new Guid("8bd5874d-4964-4394-a277-a26df1293737"), new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"), 2, true, 6195, "404RX7A4JLL864063", 2710.312131134215300m, 3, 5 },
                    { new Guid("8c02f080-e921-4f11-bb7f-e899aebfd5ac"), new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"), 1, false, 5075, "DTMCM8K5K4XE32144", 1589.840906197914400m, 0, 0 },
                    { new Guid("8ef86c73-b23d-479e-a51c-d72d8532aab7"), new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"), 1, true, 803, "2BGX1NSZR0BL70230", 118.42384768023198100m, 3, 0 },
                    { new Guid("9143ed66-7e97-4af6-91ba-45e54b59dadc"), new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"), 0, false, 4100, "YLRTGPROZ9QH63158", 1642.57504721171800m, 1, 5 },
                    { new Guid("93a24b33-c539-444f-a0b9-797c88514a9c"), new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"), 3, true, 8465, "200ZYR2WCLL726014", 1178.607894288242500m, 2, 3 },
                    { new Guid("93d384df-5794-4263-98b0-be69ff598f64"), new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"), 1, true, 2888, "JCQBDSZIPYLK53729", 3688.078817089978900m, 1, 3 },
                    { new Guid("9c9b6518-1885-45c5-8902-854eb3a0c690"), new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"), 3, true, 4377, "H51ALGAW4IBT98083", 1552.488037871704600m, 2, 5 },
                    { new Guid("9cc04b12-25a9-4e04-9478-a956681090ca"), new Guid("8bca530d-96be-412e-99d7-5399f8524cac"), 0, false, 9986, "BF6UFCUJ92E478651", 3458.433601476791500m, 1, 3 },
                    { new Guid("a5d377a8-dd37-4936-88b3-1636edf212cd"), new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"), 3, false, 2664, "B4TM83A1E9WU12283", 824.462955961903600m, 0, 5 },
                    { new Guid("a69a74f7-97a7-4129-8fc8-a1ffab060e4b"), new Guid("8bca530d-96be-412e-99d7-5399f8524cac"), 0, false, 5862, "8VJJUJPC0HMO94170", 715.676294524209100m, 3, 3 },
                    { new Guid("a6cb36ef-417e-4751-be80-1d06fe677485"), new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"), 0, true, 6240, "KEBD1WK6FWV678190", 268.7662450880411200m, 2, 2 },
                    { new Guid("a7d50611-561c-4be5-95a2-b52595280c3a"), new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"), 1, false, 5978, "GSB7NMZFDZZ022583", 3199.450485907574500m, 3, 5 },
                    { new Guid("a862f3ed-c20a-4ca9-b751-38fee24a3c9a"), new Guid("91cf93b0-f0e5-4302-be56-e62600663109"), 3, false, 9816, "4701QMGVCETF66165", 2657.690141323961800m, 1, 4 },
                    { new Guid("a984b4f4-d22e-40f3-a477-598fb5c8da3a"), new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"), 1, false, 6557, "KLSPGENDR7RS75846", 2446.01070030503800m, 3, 2 },
                    { new Guid("a9adc3bd-9121-4e7a-b011-fc0caceeacea"), new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"), 3, true, 9547, "WUI8XOFOWNQP15459", 2466.103406389921900m, 1, 3 },
                    { new Guid("ab833744-f39f-4833-84b1-22f00ebf04af"), new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"), 2, true, 735, "IWHLQ3EN8GTY25963", 208.7723585333803600m, 1, 5 },
                    { new Guid("ae52b464-d7d1-441f-8860-76318a028641"), new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"), 0, false, 3144, "9ZHNQF1YEQU048360", 2865.857776927195600m, 0, 2 },
                    { new Guid("af2bdaaf-7dd2-427b-8a0e-36bdb1976a78"), new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"), 3, false, 4426, "8DWLZ1YD1CXY14723", 2706.605650720411600m, 3, 5 },
                    { new Guid("b037a7ab-8858-4bea-8289-22da86202d58"), new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"), 1, false, 8209, "SPSI2FK8FAW263920", 3350.886204287218900m, 0, 0 },
                    { new Guid("b1c513b0-b96b-4cb2-90de-7f4c9e82f3fb"), new Guid("91cf93b0-f0e5-4302-be56-e62600663109"), 3, false, 7354, "U6608YGYCWIY26067", 1177.100210902631500m, 0, 3 },
                    { new Guid("b3f3bff1-a1a1-4195-b144-53ccf47e8a06"), new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"), 2, false, 8496, "LUCJMDXZYZO126408", 721.170855855565600m, 1, 1 },
                    { new Guid("b73cca49-323a-4f7c-9780-1ed80961ec94"), new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"), 2, true, 2572, "P590QX2PEELQ43117", 2082.825338931174400m, 0, 4 },
                    { new Guid("b7c29220-7c50-4966-9f8b-2f1c585f2125"), new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"), 0, false, 3301, "YC4FYQB8ASV636264", 1915.904633056797400m, 3, 2 },
                    { new Guid("b89ecf8e-6079-4ca0-b36c-55a089d99e2c"), new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"), 3, true, 3, "9QZEF4J6V0V778533", 255.2129692634836900m, 1, 5 },
                    { new Guid("c1f1ef60-ba3d-4db9-bf7a-c11eea0af88b"), new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"), 0, false, 673, "PMMD8VNQS2VJ11499", 1332.559646684243800m, 3, 4 },
                    { new Guid("c2161515-6ad4-4785-8631-a47adb636c02"), new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"), 3, false, 6616, "MOR7V7DZ9FUU49737", 3205.814969198024200m, 3, 0 },
                    { new Guid("c25e0dc4-0d82-405d-9283-b4d9926b6f7d"), new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"), 0, false, 9993, "Z17QI4ON4EJY71692", 571.602822301413400m, 2, 2 },
                    { new Guid("c39bb951-2a23-4925-b06b-0247f588d390"), new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"), 1, true, 7815, "EOZHNTZWB7VZ96541", 303.9199930950824200m, 3, 2 },
                    { new Guid("c53829af-6ae2-499c-b5b8-38c915a91e9f"), new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"), 2, true, 4025, "EBEYEKM88NMX22124", 1241.661211933469500m, 0, 0 },
                    { new Guid("c97d2918-fc9d-4b15-9f45-0708e098a144"), new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"), 0, true, 2313, "QH7GKLW8TXOM71606", 678.37230752169700m, 3, 0 },
                    { new Guid("cb4b2797-1a73-4897-ac21-342f901ea858"), new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"), 1, true, 8915, "5OQNLGYICOAD91473", 2973.000044966112100m, 2, 2 },
                    { new Guid("cc0997f7-4fb5-4014-9483-f921f510f310"), new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"), 3, true, 2715, "KVZHYCQ39ROY84134", 3676.991006446218400m, 0, 0 },
                    { new Guid("d0f7226b-c883-4955-8ec6-b25ccd127090"), new Guid("8bca530d-96be-412e-99d7-5399f8524cac"), 0, false, 1026, "Y0AE2SP043JF13116", 2826.464000413305100m, 3, 2 },
                    { new Guid("d3dcd36d-9e36-4cd2-bf47-089135778cce"), new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"), 3, false, 5769, "WIUU31LH60Q815089", 1962.785369381431300m, 1, 2 },
                    { new Guid("d7c4fd75-7054-46a1-b0d6-71891762ae78"), new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"), 0, true, 74, "WKI9Y1ZFE3LD96933", 522.944859263481100m, 0, 2 },
                    { new Guid("dcabe86a-e8ef-4360-b3c4-f598b8a177ea"), new Guid("be836d80-2053-49bf-ac77-f30c782652ad"), 2, true, 1049, "4WQW9Y9RSOVQ46784", 3537.022497888904600m, 1, 0 },
                    { new Guid("e054541e-2678-4b11-91da-2579bcb9cfde"), new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"), 1, false, 4667, "2CAUVKQCPFQ237056", 1503.172978796921800m, 1, 3 },
                    { new Guid("e303afa9-5e81-49cd-8238-b222c1659eb4"), new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"), 1, true, 6363, "0PNSBKX17SO316786", 3785.780270935285900m, 3, 1 },
                    { new Guid("e552a114-3aac-4870-baf4-5c00204c866a"), new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"), 3, false, 3295, "UPPF0FMYLQGG97944", 1685.073002370227500m, 2, 1 },
                    { new Guid("e5a86f4d-5811-4bfe-89cb-09e0f362a5c9"), new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"), 0, false, 4820, "I10WNYJC30G824504", 672.640694207818600m, 2, 0 },
                    { new Guid("e6fdb950-2699-4d22-a011-09d3c635dad9"), new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"), 3, true, 2644, "FF1TXSZQQWK252174", 2742.871688607038200m, 3, 1 },
                    { new Guid("e865b0f1-18bf-42f9-8aea-69928ba6d12a"), new Guid("8bca530d-96be-412e-99d7-5399f8524cac"), 1, true, 2234, "V1UX32LK6GNX65839", 1584.648671218472500m, 2, 3 },
                    { new Guid("e91a04ad-a42a-4655-97ce-d0049dad954b"), new Guid("be836d80-2053-49bf-ac77-f30c782652ad"), 3, false, 3159, "SK2UH9XTE3AB56043", 2947.045274071203400m, 3, 0 },
                    { new Guid("ea2e4d54-aa6b-4b5b-a91e-ba2aaa8ed3cc"), new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"), 3, true, 7057, "BREL0YN03HSB36445", 1371.62558306929600m, 1, 0 },
                    { new Guid("eabf7f2a-5e1f-45fe-b7ef-aaab3331db10"), new Guid("be836d80-2053-49bf-ac77-f30c782652ad"), 2, true, 4267, "Y2CMMGFO1SBH74619", 3087.628255904394700m, 3, 1 },
                    { new Guid("eac524b0-bbe0-488e-a45d-59c786d88fae"), new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"), 0, true, 1140, "GJ3MRNT5EVV626237", 2083.262870041963900m, 2, 5 },
                    { new Guid("eb33c3db-099a-469e-9d70-6e1a050e21c4"), new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"), 0, false, 387, "MXD9RROESYPG95483", 2393.453537988332200m, 0, 2 },
                    { new Guid("ee3758ef-3315-47c9-bc76-71affe881e17"), new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"), 2, false, 8669, "JFCW91FBKIKP58393", 1368.696217009889200m, 0, 2 },
                    { new Guid("ee988550-8377-4b8e-a02c-b6f74c4c9268"), new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"), 1, false, 2690, "6POHUHASSCLU36533", 2351.762662546251400m, 1, 5 },
                    { new Guid("f21977ed-3fc0-4aa5-a01b-998f0c030f30"), new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"), 1, true, 4246, "7DLI0FE8W2V360419", 799.328902905396400m, 3, 5 },
                    { new Guid("f22d1bcb-5bba-4865-a743-7f8ceff22b7f"), new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"), 2, false, 6763, "WFUC0H1BMVLD58194", 3038.29704676892800m, 2, 0 },
                    { new Guid("f24d17ec-6cf6-413f-9d48-638cc1d2e7c6"), new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"), 3, false, 508, "28364JAW8OIY52633", 964.777456675767700m, 3, 3 },
                    { new Guid("f289870d-048b-46f5-b944-a99c8521c4f4"), new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"), 2, true, 6264, "ZDVWD3YDIFX781315", 2738.10384503676400m, 2, 5 },
                    { new Guid("f3cb3b73-2d55-40a2-b060-8d2ba4d44dff"), new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"), 0, false, 8144, "8LA05E2ZINQU16019", 1900.765668154238500m, 1, 4 },
                    { new Guid("f4107725-6837-4254-bd31-73b2d283bcee"), new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"), 0, true, 3773, "U0Q52EOKOWAK74379", 1467.504800264258500m, 2, 5 },
                    { new Guid("f42ea2f5-ffee-4ea7-be60-2d5f2c781ece"), new Guid("be836d80-2053-49bf-ac77-f30c782652ad"), 2, false, 8449, "J3L8TXNR88Y493758", 1678.702429978289200m, 0, 4 },
                    { new Guid("f6274b34-b897-46aa-b0a2-d8c503c96e5c"), new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"), 1, true, 7485, "QFQ59KJGA0LA58623", 724.720375564944100m, 1, 0 },
                    { new Guid("f648b9ed-d177-43cb-8a7e-fb9ee80ce527"), new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"), 0, false, 9590, "FESX2KMHVPUS22320", 3801.940728426241600m, 3, 2 },
                    { new Guid("f775aae6-47c2-48cd-afaa-1228d334c2b2"), new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"), 3, false, 5091, "NCV4QW9O7QDE96072", 3309.440046264571600m, 1, 1 },
                    { new Guid("f8a846fb-137c-4489-9526-2a99363640f8"), new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"), 3, false, 2045, "XV2TU5P9FMQQ75875", 1555.247649716309800m, 3, 2 },
                    { new Guid("fd41c9df-f4a7-4495-9581-073305c5032f"), new Guid("91cf93b0-f0e5-4302-be56-e62600663109"), 0, true, 6991, "9GA8BAKA95IH55377", 1976.668520559597700m, 1, 2 },
                    { new Guid("fdba8a23-3af4-4c8c-b3fd-d1c5854f6927"), new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"), 3, false, 7223, "KJ3AR67685LY46982", 322.7283358798626700m, 0, 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_CarModels_CarModelId",
                table: "Vehicles",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_CarModels_CarModelId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("026704da-8d7e-4b15-a2ec-d4fca47f0642"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("04ab2ae6-ab9d-4672-9ceb-aebabe9948f6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0519707b-563d-41a3-ae28-b55f21020b75"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("07b61bfa-aeda-4758-bb83-86d9b2ad620d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0b67abff-b381-47fc-81e3-7597264f0029"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0bbfc7db-3d9e-405f-b8b7-b048993406b2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1111ad1a-a3f3-4d79-894b-b0a82f2664e5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("137afe20-d4e5-4e52-9bef-5ae16b7e3d09"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1427c182-5cc4-4286-a468-9444dccae2a9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("183da0e1-393a-4612-b1d0-cab9369c781c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1b23856b-73d9-4a94-80fd-0391ab22645c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1bbe480a-c8ad-4b8d-8504-df8cfb70364e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1e9d931f-49a2-45c6-8b0d-3e143cacc997"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("21b7b541-27d3-4d85-b332-bc055f18314d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("23584d03-2204-461f-95d1-595e5375d602"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("23af35ff-1f09-4398-8f77-041451985906"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("26c5855c-653a-4eba-94a5-3fc5d4d6bc47"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("26c5f912-74d9-4a04-a50f-82fca089346f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2b8b1870-e4ab-42db-b73f-fa770a0d1734"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2f93d5e4-4262-475f-9fa7-3e15a54b576c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("36503db4-7df4-4fcb-8576-0584576dfb67"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("36d5bb68-efa5-4c85-8d65-076ca8914973"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3a5f9234-f817-429e-907b-c008ea2cd6b3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3d3e53bf-b54f-4136-936a-62c15f1064c7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3dee8b72-0c9c-4693-aeef-7318a1eb267c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3e5bedc8-978f-43e8-8aa0-4bdecbcd0b67"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4094cb5e-9e77-4b89-82e4-5ac89822f05e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("41a329bb-120b-4e69-b843-afa0d01c28c3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4363dc6d-f721-4aad-a429-3bb0889ba6d6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4fe1b13c-6d83-4fc0-8017-0418a994dec1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("50136db2-52c2-4b22-afb6-fe29b0855ff6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("513ba94f-db79-4688-866f-f86c623b7764"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("51d5101f-78da-43a4-903a-5c7fd86ddf3a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("556a1d9e-b10c-410c-941d-ece054fc1774"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("566c2538-2c08-4a12-9678-256930db8356"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("62a1020a-8f50-478a-a454-199a8b9a0e4a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("63819291-a6e5-4680-af5f-4d98ab69a254"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("646576da-00f5-4eed-a7f9-6ae53e2caa60"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("66bbf49b-f37e-4e85-b124-1a8b5ed3fbce"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("66e841aa-4fb3-4e0b-80fd-fb2fca7d05ba"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("68ea7e55-89a5-4a9b-bd2b-49cb92e63b5d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("68eb1606-b7b5-4abf-8e68-ccbb867ad266"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("69c1a579-9fc0-475e-8af8-3b64ad827eba"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("702be2f5-b058-4b48-98bb-ab563548f7a2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7318ea57-dc7e-4b17-9171-fd65c287f9ec"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7323db83-986d-44ba-860a-43b5671f6534"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("735ca0ea-d352-47d3-98c3-2b20ecf4adb8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("738b006c-9bff-4d26-ae18-cbc2fb73c6e5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("74672d42-d8d3-45b4-af37-46b9346e2600"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("784c19bd-47aa-49df-b94c-0acd66bf1d43"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ab28f14-8add-4236-a71a-828ee023d60f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7abae46d-da6a-4a3f-8c0a-bcc0d0e04d02"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7dc1166f-9b81-460d-98ab-ee06dad75086"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("80d39ddc-c46e-47b1-88d0-0753621f158e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("81947ba9-6872-4a3a-88e9-18edcafdfdc2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("81af1aca-08ad-4108-ae98-5d615e3e9ccf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("81c54fed-13ae-4728-954f-a73fa8556208"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("81e0f9c0-3433-4452-9a5f-effcf20820f4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8218918d-38cf-4779-9e69-3ea5a53b6bc0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("835d1f89-8ca8-4135-b6e4-47ad4d78acdd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("84933806-9900-4219-8d01-a418cf0777f2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("892212fe-5acf-497b-abfe-67f561cef4b1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("899edf75-6928-4d83-9373-7a5d67005dd5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8bd5874d-4964-4394-a277-a26df1293737"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8c02f080-e921-4f11-bb7f-e899aebfd5ac"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8ef86c73-b23d-479e-a51c-d72d8532aab7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9143ed66-7e97-4af6-91ba-45e54b59dadc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("93a24b33-c539-444f-a0b9-797c88514a9c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("93d384df-5794-4263-98b0-be69ff598f64"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9c9b6518-1885-45c5-8902-854eb3a0c690"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9cc04b12-25a9-4e04-9478-a956681090ca"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a5d377a8-dd37-4936-88b3-1636edf212cd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a69a74f7-97a7-4129-8fc8-a1ffab060e4b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a6cb36ef-417e-4751-be80-1d06fe677485"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a7d50611-561c-4be5-95a2-b52595280c3a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a862f3ed-c20a-4ca9-b751-38fee24a3c9a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a984b4f4-d22e-40f3-a477-598fb5c8da3a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a9adc3bd-9121-4e7a-b011-fc0caceeacea"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ab833744-f39f-4833-84b1-22f00ebf04af"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ae52b464-d7d1-441f-8860-76318a028641"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("af2bdaaf-7dd2-427b-8a0e-36bdb1976a78"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b037a7ab-8858-4bea-8289-22da86202d58"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b1c513b0-b96b-4cb2-90de-7f4c9e82f3fb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b3f3bff1-a1a1-4195-b144-53ccf47e8a06"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b73cca49-323a-4f7c-9780-1ed80961ec94"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b7c29220-7c50-4966-9f8b-2f1c585f2125"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b89ecf8e-6079-4ca0-b36c-55a089d99e2c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c1f1ef60-ba3d-4db9-bf7a-c11eea0af88b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c2161515-6ad4-4785-8631-a47adb636c02"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c25e0dc4-0d82-405d-9283-b4d9926b6f7d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c39bb951-2a23-4925-b06b-0247f588d390"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c53829af-6ae2-499c-b5b8-38c915a91e9f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c97d2918-fc9d-4b15-9f45-0708e098a144"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb4b2797-1a73-4897-ac21-342f901ea858"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cc0997f7-4fb5-4014-9483-f921f510f310"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d0f7226b-c883-4955-8ec6-b25ccd127090"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d3dcd36d-9e36-4cd2-bf47-089135778cce"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d7c4fd75-7054-46a1-b0d6-71891762ae78"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dcabe86a-e8ef-4360-b3c4-f598b8a177ea"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e054541e-2678-4b11-91da-2579bcb9cfde"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e303afa9-5e81-49cd-8238-b222c1659eb4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e552a114-3aac-4870-baf4-5c00204c866a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e5a86f4d-5811-4bfe-89cb-09e0f362a5c9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e6fdb950-2699-4d22-a011-09d3c635dad9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e865b0f1-18bf-42f9-8aea-69928ba6d12a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e91a04ad-a42a-4655-97ce-d0049dad954b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ea2e4d54-aa6b-4b5b-a91e-ba2aaa8ed3cc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eabf7f2a-5e1f-45fe-b7ef-aaab3331db10"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eac524b0-bbe0-488e-a45d-59c786d88fae"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("eb33c3db-099a-469e-9d70-6e1a050e21c4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ee3758ef-3315-47c9-bc76-71affe881e17"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ee988550-8377-4b8e-a02c-b6f74c4c9268"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f21977ed-3fc0-4aa5-a01b-998f0c030f30"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f22d1bcb-5bba-4865-a743-7f8ceff22b7f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f24d17ec-6cf6-413f-9d48-638cc1d2e7c6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f289870d-048b-46f5-b944-a99c8521c4f4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f3cb3b73-2d55-40a2-b060-8d2ba4d44dff"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f4107725-6837-4254-bd31-73b2d283bcee"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f42ea2f5-ffee-4ea7-be60-2d5f2c781ece"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6274b34-b897-46aa-b0a2-d8c503c96e5c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f648b9ed-d177-43cb-8a7e-fb9ee80ce527"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f775aae6-47c2-48cd-afaa-1228d334c2b2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f8a846fb-137c-4489-9526-2a99363640f8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fd41c9df-f4a7-4495-9581-073305c5032f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fdba8a23-3af4-4c8c-b3fd-d1c5854f6927"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("02db554c-ea6c-4903-8101-2d979d4a2cd7"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("0d811fc8-ec52-40f1-a5d5-f16bbfa857d5"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("2e0d7ea3-37c3-428b-90da-732aa97454cf"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("3f1a4e84-e0b8-42b5-aa3f-2853542d93a3"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("43b8b327-040f-42b0-b5b4-8a22a1ff1caa"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("628289ca-ab18-4fad-a6c4-9cf7170dc1b0"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("657cee49-fae6-4b6f-afd8-8cdfefc04dec"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("69855412-737a-4cd2-95c2-73bda4319bd3"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("7142fc39-7095-4a7c-b30b-7b8277115bc7"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("7f05a046-0775-4b00-b7c8-898f8d0dad1d"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("8bca530d-96be-412e-99d7-5399f8524cac"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("8d533c5e-0e9b-41b9-b2ab-ebe90c46a4cc"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("91cf93b0-f0e5-4302-be56-e62600663109"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("9cc191d0-1450-49ac-a24f-74ad91dfd149"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("9efa2665-13f4-47f2-b61d-0421db1f7b24"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("a4a25bf3-9cb5-4112-870c-c7555535906b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("af525422-03ee-438f-9c2a-8d88d47ea2e3"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("af7c96d5-5525-499c-81aa-f67585dfdc6a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("bd0c2ac3-0d90-4b7a-af47-3082cf538d8a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("be836d80-2053-49bf-ac77-f30c782652ad"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("cb1d99c3-654d-4632-ac7b-444cc45d570f"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("e4f8f2b7-b264-45f0-ba69-226b8d0daf6b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("e77bd8b1-fcdd-44c2-a647-2d5f0a39938f"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("e999cc5f-6f96-4fa3-ab82-ebffc3ab5b32"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("f2db5a40-136b-44eb-b13f-3dbec8d8760c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1fcb4e4b-e85c-40bf-b4dc-2b8d4cf47564"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("34d3738d-f952-4c31-9e8a-2b35b14d3d8f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7653e02e-8e33-4326-adca-ae857ae784d8"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7c713192-2c0e-43e0-96f1-786a5efd0122"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8fd7a782-a3e9-436c-8e64-01415ff5c174"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CarModelId",
                table: "Vehicles",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Vehicles",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"), "Bentley" },
                    { new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"), "Mazda" },
                    { new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"), "Toyota" },
                    { new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"), "Bentley" },
                    { new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"), "Nissan" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarModelId", "FuelType", "IsRented", "ModelId", "Odo", "PlateNumber", "RentCost", "VehicleState", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("0074ed41-b5f1-43a1-9ded-cf544e7f1382"), null, 2, true, new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"), 2581, "FSLACA3WKFMD20512", 1433.495962490227900m, 2, 4 },
                    { new Guid("00ed94c7-5e4a-4177-8e65-d01c861a66d6"), null, 0, true, new Guid("4b524395-7112-4516-aeed-c4d268a68396"), 5575, "HK82XMGY6ERY55484", 2879.895803585024800m, 1, 0 },
                    { new Guid("02ed95a4-27f4-4f2e-82ac-6a0cd4643229"), null, 2, false, new Guid("4b524395-7112-4516-aeed-c4d268a68396"), 8840, "2TAEN1HQT9RU64177", 3704.16621457344400m, 1, 0 },
                    { new Guid("04d5cc6c-9717-4331-aa49-a2d91b55cfca"), null, 3, false, new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"), 8428, "XXJ9JSH5YGT172291", 351.0837480363830800m, 1, 5 },
                    { new Guid("0500586f-cf1e-4139-b6f0-7a66cd0835fc"), null, 2, true, new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"), 1080, "CMFGEWI3HTKE71415", 3807.856708406191900m, 2, 1 },
                    { new Guid("0551088a-ff60-4be0-9abc-691b2bd6af73"), null, 1, true, new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"), 8271, "MLIFUCH6WNO455117", 900.950177276949700m, 3, 2 },
                    { new Guid("05c3337c-cdda-4df9-8a1a-bb58b055b126"), null, 0, true, new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"), 6799, "L0F9DUEGBKFJ58790", 3069.230475234657400m, 3, 0 },
                    { new Guid("0646dc87-7a5e-4e26-8945-f44d17032165"), null, 2, true, new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"), 8477, "OEIVXL37LTIU14163", 249.6352825254695200m, 3, 4 },
                    { new Guid("07ff6e5a-2176-4840-9c69-0333d5de2e46"), null, 1, false, new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"), 4023, "350219113HHA62540", 3774.639286874498800m, 1, 2 },
                    { new Guid("0aabe96c-3e39-4872-8cc7-11e0710e32fb"), null, 0, true, new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"), 5049, "YC6ST3YHF4EH36937", 2737.877196093696700m, 2, 2 },
                    { new Guid("0b28e941-1209-44ae-9717-808995e500df"), null, 0, true, new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"), 3688, "GTA8BSG1NNAH86654", 2583.550558141525600m, 3, 1 },
                    { new Guid("0d0cf421-d5a8-4589-a5b6-a28a587b56fa"), null, 2, true, new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"), 4929, "TTID5UPHGREM33586", 2311.4143431491800m, 3, 5 },
                    { new Guid("12308882-80db-4f17-8259-019666ca14f9"), null, 3, true, new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"), 1157, "KWOMITB51AVG46419", 2862.866750642607700m, 1, 0 },
                    { new Guid("167f5359-200d-472c-baa2-2fb350846c15"), null, 2, false, new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"), 4554, "4VOCCR1V87ON42409", 781.986177410410600m, 1, 3 },
                    { new Guid("18372838-2c64-40cf-8ad9-4cda4b234abd"), null, 3, true, new Guid("9bb895b3-f778-411f-a977-afbd281e9172"), 5372, "CV9RSVYPF3GH58179", 2119.243286360466400m, 0, 0 },
                    { new Guid("19c49823-9fad-4cda-be3f-1c48d5938f8a"), null, 0, true, new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"), 102, "18E8TOLNTBJQ15025", 2995.670580373187500m, 3, 4 },
                    { new Guid("1a649605-f7ab-4aaf-b06d-54fe54f47eae"), null, 2, false, new Guid("540cf388-3096-4941-a651-a226fb287c8d"), 5154, "UW88W68P3SDE38841", 2754.850338313443400m, 3, 4 },
                    { new Guid("1bd2ef45-4f0c-4b6e-b5bc-df003cb53dff"), null, 1, false, new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"), 8682, "5FN9VCO4LAUQ55634", 1761.470475802352800m, 2, 3 },
                    { new Guid("1fad1d94-ee6e-423b-a2d5-ee8181b6b9c6"), null, 1, false, new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"), 8007, "CYL07YJOSBYL93118", 1607.49259742547700m, 3, 4 },
                    { new Guid("201c1db3-7e6e-4611-899f-a3afb6a7434f"), null, 0, false, new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"), 3146, "5R8U7TRNXHCF37388", 3602.272945307917300m, 1, 5 },
                    { new Guid("2098f8d0-4e54-4af1-8ea4-fda7e9e7142e"), null, 3, true, new Guid("9bb895b3-f778-411f-a977-afbd281e9172"), 9662, "GZZJM5WYX3T290315", 1091.179840656354700m, 1, 0 },
                    { new Guid("2183346d-f9ff-449f-9108-e69d8786474a"), null, 3, true, new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"), 9626, "Q9D8XLTBDVS948210", 362.9386385940874300m, 3, 1 },
                    { new Guid("2753a419-2b39-40db-9641-d3b72f22ee1f"), null, 2, false, new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"), 1482, "NWII1YCW7TYW17460", 3242.851007856102400m, 0, 4 },
                    { new Guid("27730151-801c-4965-8718-1d1b19481071"), null, 1, false, new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"), 540, "WH07VJDPO0I732926", 3652.810876404840700m, 2, 0 },
                    { new Guid("2a1a59a4-e8d0-4ea4-98c3-5b61ba4976d1"), null, 0, false, new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"), 7103, "4HV123QR31RQ99468", 356.2077187936454500m, 3, 3 },
                    { new Guid("2a8d3ba5-1d24-4382-865b-1889552f6fde"), null, 2, true, new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"), 5163, "O0VBRSCFV4PG51397", 830.798038693910200m, 1, 5 },
                    { new Guid("2ef5df33-d03f-4048-a1ab-c23d85e2400e"), null, 0, false, new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"), 5386, "1ZQ2VCZWKLH529997", 2494.379797511154700m, 3, 4 },
                    { new Guid("36781d0e-fe3f-452a-9099-d613309b7304"), null, 1, false, new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"), 7055, "E7N82D4GDVU599280", 3490.092791984653300m, 1, 2 },
                    { new Guid("3865e756-b01b-4d30-85fb-7e009c4d0d96"), null, 1, false, new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"), 2398, "WP2468S0CKU360009", 3242.705167074023200m, 2, 1 },
                    { new Guid("39bfcff8-1a74-4af0-8745-72b0657f9c7e"), null, 0, true, new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"), 8885, "2Y2QXSR3B2CL35991", 3005.383325709837700m, 0, 1 },
                    { new Guid("3b39ccda-b425-4169-badc-297524379815"), null, 2, false, new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"), 2049, "H4G60WC5OJI964492", 1648.703171017011100m, 1, 1 },
                    { new Guid("41ab7d63-7043-4d15-87a9-e721f3f28518"), null, 3, false, new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"), 2227, "1RZBUT27AWGR46827", 1231.725359750759800m, 2, 3 },
                    { new Guid("4554f4a6-1e88-4568-b0ad-1ebcc686f4fc"), null, 0, false, new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"), 466, "WGX1FP34T6GR84853", 3151.171215933396400m, 0, 2 },
                    { new Guid("460b6ed2-06d2-4331-9765-eeaeac620fd6"), null, 0, true, new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"), 830, "WIHY8W6CB5D159189", 3940.897910369880100m, 2, 3 },
                    { new Guid("46e084d5-1e54-4b92-8483-9e181b0dac05"), null, 0, false, new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"), 1501, "VK7FC49CZQOA91789", 892.292638450374100m, 0, 1 },
                    { new Guid("47fa4898-c709-4e77-a22c-642a635cf18c"), null, 3, true, new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"), 3234, "UT51MJNSDORF55126", 3227.470113487743400m, 1, 2 },
                    { new Guid("4bc28e0e-8bca-4f33-a6b2-7b239db3ce50"), null, 2, false, new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"), 8242, "8B05ZIFMHGEO95046", 1994.005217088883600m, 0, 2 },
                    { new Guid("4cb8aa41-8878-4eaf-af6e-d9f0e2c11bc4"), null, 2, true, new Guid("4b524395-7112-4516-aeed-c4d268a68396"), 9789, "A8UT637VTSMG94911", 3243.701823986510800m, 2, 4 },
                    { new Guid("514769b8-59ac-4b1e-86c5-47a97db6971f"), null, 2, true, new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"), 4925, "KAC8U9AXIZEF22157", 1830.684746845837900m, 3, 4 },
                    { new Guid("52f237c2-35d7-4f02-8cb6-325ab1f7168f"), null, 3, true, new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"), 2760, "FICA98FDH8QU89641", 979.439906106119800m, 1, 3 },
                    { new Guid("54239a14-adc7-499c-b3d7-7fa081366b88"), null, 1, false, new Guid("540cf388-3096-4941-a651-a226fb287c8d"), 2499, "LMGCYST1WVRV21351", 3587.850841908620200m, 3, 4 },
                    { new Guid("543e729b-60b1-48c2-9c7c-2edcfd164787"), null, 3, true, new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"), 9998, "MQS9L3CUKEBO91368", 431.3687672481565600m, 1, 4 },
                    { new Guid("572701e4-b08d-4091-aedd-2f17479b58ea"), null, 3, false, new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"), 4057, "8SDARFIMAQCV45728", 3708.548166965045200m, 1, 4 },
                    { new Guid("5aaa99ed-eb22-4862-9839-a5d573ee690e"), null, 0, true, new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"), 898, "FYUAIA591RNZ53523", 3145.139713312106800m, 3, 1 },
                    { new Guid("5c622405-dc83-4ce2-83cd-d00a9f0a19d2"), null, 1, true, new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"), 4343, "EIQAGFU7VKP680372", 145.5615690566611900m, 2, 4 },
                    { new Guid("62d392b0-afb8-4397-9771-8dfc27444e5a"), null, 2, true, new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"), 5909, "BZ9NNVZ0TRAF14503", 1571.479167524988700m, 3, 5 },
                    { new Guid("63e14189-7cb3-4c26-a054-ed966db2111b"), null, 2, false, new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"), 5507, "01KX3NDL3AZ296660", 1388.542819077900100m, 1, 3 },
                    { new Guid("661c7ce9-ea62-4ef5-9584-b05e100b89ef"), null, 3, true, new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"), 9812, "ODL8KSW0CER116571", 3644.708312865943600m, 1, 5 },
                    { new Guid("6748d90f-bfab-4bbe-93b0-15ac385367cd"), null, 1, false, new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"), 7634, "ND21RWYN5MFY45620", 1175.555566063638400m, 2, 2 },
                    { new Guid("68af71de-a593-4aa6-8c79-01a37c980a97"), null, 0, true, new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"), 8979, "K32B1MZTMFT813427", 488.7811073218727200m, 1, 2 },
                    { new Guid("693b95c6-11a5-46c6-82f8-f2c829a0d86d"), null, 0, true, new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"), 4115, "0L06L02LP3I717213", 3925.007923998406600m, 0, 1 },
                    { new Guid("6abb6e59-6b3c-4558-bf94-a05e2aa9ff03"), null, 2, false, new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"), 9714, "B00D2PV5F9SI20228", 248.3293568767484500m, 1, 5 },
                    { new Guid("6d0e1397-9e31-46a2-a751-ac320f93c920"), null, 3, true, new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"), 3567, "HOWV940OLYPU52195", 1453.558596345498400m, 3, 4 },
                    { new Guid("73997aa4-127e-42e9-a6be-95cb79b18250"), null, 2, false, new Guid("a360ac28-660d-4819-97d2-8da1875e7907"), 4955, "RKW3J5OJMUJM52806", 2662.144196611678900m, 2, 3 },
                    { new Guid("7836d28a-4f8b-4ce5-ba4a-644672bb64b4"), null, 3, false, new Guid("a360ac28-660d-4819-97d2-8da1875e7907"), 5185, "EETS125F9XYM19026", 3491.03265199909600m, 0, 5 },
                    { new Guid("783866cb-b69a-4d1b-a69d-3165d7fe12cd"), null, 1, false, new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"), 48, "BSF1L6NC21H761915", 669.91043184520900m, 1, 2 },
                    { new Guid("7842a101-ae51-4938-b0d4-74f28badc71e"), null, 3, false, new Guid("4b524395-7112-4516-aeed-c4d268a68396"), 1055, "OBQI9SC4L2VM65825", 740.10234511709200m, 0, 0 },
                    { new Guid("7a244adf-6df1-4871-b2ee-f7e903c6dbb6"), null, 0, true, new Guid("9bb895b3-f778-411f-a977-afbd281e9172"), 6038, "EYVMQVSJI2VR51968", 280.8533573104254100m, 0, 0 },
                    { new Guid("7a9ef475-d665-4895-bb02-3867fe6c6d0a"), null, 2, false, new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"), 4680, "JHNEOR66HRIR73762", 3347.597472881265400m, 0, 0 },
                    { new Guid("7ba75e96-bda8-4607-afbe-a67ab67f3aa8"), null, 3, true, new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"), 9023, "5TIZSCC8BXEU53475", 706.099175185082800m, 1, 3 },
                    { new Guid("7d34c61a-90bf-4b78-85cc-fc85be15cb52"), null, 0, false, new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"), 6543, "NIG5SK2M5WCC28121", 1080.269426966724700m, 0, 0 },
                    { new Guid("7e67658d-396f-4d19-ba58-5e3a08c6e405"), null, 2, true, new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"), 7900, "1TGBUEV8KAKM50925", 1887.756040549628500m, 3, 5 },
                    { new Guid("7ef2b46c-1654-4275-8ba8-b91a1f3aab49"), null, 0, true, new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"), 6337, "AGOUBA0XJUTE11961", 3386.125730606258800m, 2, 0 },
                    { new Guid("7fcbc263-2991-4a08-9c9f-68b10743a1e4"), null, 3, false, new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"), 2182, "KT996CXCF5JL59374", 1800.250998492194200m, 2, 5 },
                    { new Guid("80f2b8d1-f244-43dc-a9d6-3359e1867238"), null, 1, false, new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"), 2509, "I3QXW6I9LHHY91061", 2047.667612348278600m, 3, 2 },
                    { new Guid("85a06530-e7e6-484a-85d9-95837348c7ea"), null, 0, false, new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"), 7629, "JO10TVJKRNTW89489", 2056.826803946739400m, 1, 3 },
                    { new Guid("8bfb0768-2222-481f-8c2c-987f8e9dfb47"), null, 0, false, new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"), 572, "88ORYXBHWTA757884", 1576.975250852159500m, 1, 5 },
                    { new Guid("8c612899-aadf-441b-a1cf-5a32f16ac762"), null, 1, true, new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"), 6529, "TSSJ849TZRD538357", 573.884079992026600m, 0, 1 },
                    { new Guid("8d530439-7a54-4413-94e6-73c33d3bb40e"), null, 1, false, new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"), 6916, "C3OFG1IWAIU298074", 2665.28374334724700m, 0, 3 },
                    { new Guid("8e483215-2833-4ffc-9227-6e89893eed17"), null, 3, false, new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"), 4892, "4SNO4QFOC6SL46921", 2413.988176161188800m, 3, 0 },
                    { new Guid("909d195d-43d8-49f3-bce2-7d7e3b80da9c"), null, 2, false, new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"), 5215, "BPOGQV2REQO781206", 1954.986755879428600m, 0, 1 },
                    { new Guid("9119fcb2-6cf3-44c7-80c8-654671bdf245"), null, 3, false, new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"), 3130, "XSVPOL6B00ZG98078", 1401.08329818305800m, 1, 5 },
                    { new Guid("965291fb-3f77-4c4b-9adb-9c9554c6241e"), null, 2, true, new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"), 4026, "E5ZA7NI5JLTG24086", 3031.705227512534200m, 3, 4 },
                    { new Guid("97eb5374-f109-4d91-971a-e0a2d057e9fa"), null, 1, true, new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"), 7819, "71IJY3S3IBA324631", 2202.027501611833900m, 3, 4 },
                    { new Guid("994a2a4c-dcd2-4721-8eed-6d0fd75029d8"), null, 0, false, new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"), 6336, "474PEDNPI9GH14021", 2718.698583020926900m, 2, 3 },
                    { new Guid("9992137d-a4c0-4d1b-82af-5e157a697ff4"), null, 3, true, new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"), 4661, "4DEDX753XJL355568", 2933.821732603856800m, 2, 3 },
                    { new Guid("a08bd175-0b08-471d-9e6f-703460e655d6"), null, 1, true, new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"), 2086, "R8VDZO4S81CH68086", 617.749631440705300m, 1, 5 },
                    { new Guid("a10dba78-130e-4a44-98a3-a0167680a0ac"), null, 1, false, new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"), 3380, "DQ8OT7V3KUUO21283", 3088.566494135634100m, 1, 3 },
                    { new Guid("a1d3b740-21ed-4366-b6aa-c4cefdfdadd0"), null, 2, true, new Guid("a360ac28-660d-4819-97d2-8da1875e7907"), 8794, "4ZZY50K2NYLC83062", 459.8684532581479900m, 0, 0 },
                    { new Guid("a520ec86-c12e-42db-9814-bc4ff2f524b0"), null, 3, true, new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"), 8952, "ALBX9GXNUSNN89116", 2287.928360969189800m, 1, 3 },
                    { new Guid("a652e8fa-481c-42fb-b002-a1275f91a92d"), null, 2, true, new Guid("a360ac28-660d-4819-97d2-8da1875e7907"), 4046, "ECEOCA15YAX369775", 795.325666422676900m, 1, 5 },
                    { new Guid("a7772a68-c19a-41c9-a029-7a9a450ca525"), null, 1, false, new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"), 1704, "VKQYDDT2PMWD42030", 3989.154671352199600m, 1, 3 },
                    { new Guid("a80409f7-84ae-486a-9021-c5e746b5a221"), null, 1, true, new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"), 6226, "WSVLL1R5RGK869416", 3238.181761641830800m, 0, 4 },
                    { new Guid("a893a50c-11f4-4085-acec-9d9660a51fa5"), null, 0, false, new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"), 9625, "MZH8PF94YIU457132", 3554.694443559724300m, 3, 0 },
                    { new Guid("a99d8758-b9a2-4216-b251-2cb2fefe14fb"), null, 3, true, new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"), 8532, "NU9TQRSO9ATG40322", 2170.69943604487600m, 3, 5 },
                    { new Guid("aa0306ef-fbee-4142-8c35-6604a2585d3c"), null, 1, true, new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"), 4028, "N9F14ZTLH6RH65256", 2383.663231838446900m, 1, 3 },
                    { new Guid("abf1e8fd-258c-4825-bf68-f6b00f6f0bbf"), null, 3, false, new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"), 5397, "ITDUW8YFZ4ZO11248", 3807.825334083687700m, 2, 0 },
                    { new Guid("ad6337e6-5cd0-4b62-afe5-9974954be651"), null, 2, true, new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"), 2389, "F3SC5KS1P0LC39578", 1165.270943203643800m, 1, 3 },
                    { new Guid("b1a24365-5930-4276-85da-674175c3c647"), null, 2, true, new Guid("540cf388-3096-4941-a651-a226fb287c8d"), 8121, "SL7YVIBGGEM594013", 3840.252939863997700m, 3, 2 },
                    { new Guid("b469bb89-443a-4968-ba07-31f6ffc1931b"), null, 1, false, new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"), 1533, "9KW4P4YGTLGV61690", 2817.372189143774500m, 2, 1 },
                    { new Guid("beaff452-e462-4eeb-8393-ee2e90eb8f50"), null, 1, true, new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"), 9207, "PAQPPKI6OQBV59666", 3239.666229534144700m, 1, 0 },
                    { new Guid("c72805f9-e51d-47b1-8909-05bc4063d090"), null, 1, false, new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"), 3569, "TDMO7K6DQBLN24136", 1137.933257810983300m, 3, 1 },
                    { new Guid("c8326bf4-b6c8-472d-abea-a6eea890e953"), null, 3, false, new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"), 7915, "LS6JVVXUY4U981307", 244.4695892496032800m, 0, 1 },
                    { new Guid("c841e52f-23f4-4d11-b19d-27ef507ab72d"), null, 2, false, new Guid("9bb895b3-f778-411f-a977-afbd281e9172"), 5879, "9A4OHYPIJJLR40401", 1087.269612873766300m, 1, 5 },
                    { new Guid("ca23a0bb-98d5-4dc5-bfcf-f4f607820818"), null, 0, true, new Guid("540cf388-3096-4941-a651-a226fb287c8d"), 9257, "0MYWEFY52LDN66958", 2227.571036753691100m, 0, 1 },
                    { new Guid("cdf10118-82dc-42c9-b994-9936c00754e9"), null, 0, false, new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"), 8418, "R3HNBHEZOMOV26640", 1167.485586753394900m, 1, 3 },
                    { new Guid("d0c47779-49e6-4921-b505-79ce9bed996e"), null, 2, false, new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"), 6266, "DFECKLOHEADH50434", 1567.014620266994500m, 2, 1 },
                    { new Guid("d0d31fd7-6c3f-4a4e-96d0-78acadf0d347"), null, 0, true, new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"), 9841, "WPCCMT48WZC531219", 1299.694315449662500m, 1, 4 },
                    { new Guid("d1d514d9-5bec-4c8f-a943-7e10287d1cb3"), null, 3, true, new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"), 8634, "19PPBLRPGYL696736", 213.3740351715162100m, 1, 2 },
                    { new Guid("d49fc15a-76f2-41ce-b585-6041c71bada1"), null, 2, true, new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"), 4205, "ZIVJPM26IIJJ58174", 3213.071201064678100m, 2, 4 },
                    { new Guid("d78544c6-24d9-459e-92f7-987ebdb01344"), null, 0, true, new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"), 370, "HUPWPTK463VY96325", 1532.781871325416300m, 3, 4 },
                    { new Guid("d919e753-9d28-4f53-a8a5-5d2533c0121a"), null, 0, false, new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"), 5628, "74TJSQT9EHX244722", 915.403424655656200m, 0, 0 },
                    { new Guid("d96a57f7-67b6-481f-86ec-0c06a139bcfd"), null, 0, true, new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"), 7705, "N2OOIXWZWXUB79127", 3111.102154966024600m, 0, 2 },
                    { new Guid("d9e4734c-4019-462a-8da4-4e95d364a30f"), null, 2, true, new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"), 3714, "UMVPD2T3O6F323437", 2043.418003216814800m, 1, 5 },
                    { new Guid("dc331a19-2c13-434f-925e-40586b80fa6d"), null, 2, false, new Guid("540cf388-3096-4941-a651-a226fb287c8d"), 4048, "WLFKOCRMQIIL23854", 656.014440151350700m, 0, 2 },
                    { new Guid("dd4db276-6ba3-41cd-be5f-ef6756b518a5"), null, 0, true, new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"), 9496, "XCOZR8X2W7Y461115", 1736.475563803034500m, 3, 3 },
                    { new Guid("df06b71c-8821-4c61-b39d-7e0d31b4fba8"), null, 1, false, new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"), 9005, "1ZO2J4HCUDAH40831", 848.580055479525100m, 0, 4 },
                    { new Guid("dff49dbe-7fda-40b3-bfda-e1a0ffcf88c2"), null, 2, false, new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"), 1080, "KJAKQ3USMSOP79567", 2630.525219305002400m, 1, 3 },
                    { new Guid("e2936981-c273-4b56-a3ea-629338a0cbf9"), null, 2, true, new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"), 9325, "XX4LA8QAMFZA43766", 2859.669174179569600m, 1, 2 },
                    { new Guid("e2f9c83b-80ef-4eff-a409-85ddcfbbf76c"), null, 1, true, new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"), 5293, "YRDMG6E10PD973269", 3699.02807503006300m, 1, 0 },
                    { new Guid("e7691a25-e87e-4881-b1fb-7d775908195d"), null, 1, false, new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"), 8610, "U1OE97MVNZFH87240", 3102.598243415617600m, 0, 3 },
                    { new Guid("e7b07e06-6ee9-4c83-9b0b-2bbf9e0f9e2d"), null, 2, false, new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"), 2802, "C1SQZFBOSRHB16507", 3560.04453520558300m, 0, 4 },
                    { new Guid("e7e1cc08-d962-4d30-a249-77fffdc05a9d"), null, 1, true, new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"), 3875, "ZI4B0V1ABUQ261807", 1519.195632932552800m, 2, 3 },
                    { new Guid("e7f8c860-5483-40f9-b4c4-599afb473849"), null, 2, false, new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"), 8505, "OLK0HKHUILOZ51203", 793.829991314820100m, 1, 0 },
                    { new Guid("e8306a4e-997b-47f5-a208-9775f8e796e4"), null, 1, true, new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"), 158, "F2UXEIQUA2JF92640", 3570.722258732411800m, 1, 5 },
                    { new Guid("ea5d6418-e5c7-445c-a532-6e8753dfe434"), null, 0, false, new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"), 9891, "DUDMAKYB2VLY89390", 1170.262378060755100m, 0, 4 },
                    { new Guid("ef07de98-b3bf-4ada-975c-23373626e3d1"), null, 2, false, new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"), 9578, "IZ0CBFC5CSI854787", 422.854278376789900m, 3, 0 },
                    { new Guid("f03b9ec5-0052-4550-9998-d41cdd074baf"), null, 2, true, new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"), 9761, "5J2LO2RSIAI098355", 1972.426694939405800m, 2, 0 },
                    { new Guid("f31c62dd-9834-475e-8dc9-4124b7bee29e"), null, 2, false, new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"), 8429, "8FIVYBBJETHJ48508", 312.4024401171930400m, 1, 4 },
                    { new Guid("f56dafa5-484e-47d1-a4f3-0baa9ab6efe1"), null, 2, false, new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"), 188, "TMPVBJ65NFW837391", 980.853801786130900m, 2, 5 },
                    { new Guid("f680c942-5ede-49fc-be0a-002a6f7070be"), null, 3, false, new Guid("4b524395-7112-4516-aeed-c4d268a68396"), 7280, "1SWXRABWAIX923781", 2672.705298156405100m, 3, 0 },
                    { new Guid("f833f24b-5274-4241-be63-da4a696a7328"), null, 3, true, new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"), 4871, "WY5PX8ZVJ9J654988", 3526.367290933350400m, 0, 0 },
                    { new Guid("fb65e3a7-cbf8-486c-a522-b53987ebb519"), null, 3, true, new Guid("a360ac28-660d-4819-97d2-8da1875e7907"), 1976, "IAYX6871OXGG71790", 2497.557311354572900m, 1, 5 },
                    { new Guid("fbde3658-1e75-491b-8ed3-0e7870eafcd4"), null, 2, false, new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"), 3865, "B3IVVDJNFFH340027", 2659.340655195430600m, 2, 4 },
                    { new Guid("fdbd469d-d452-457d-a93c-c49e27431bd7"), null, 3, true, new Guid("9bb895b3-f778-411f-a977-afbd281e9172"), 5128, "71BJGA2EY7DF38939", 2454.100391712413500m, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("079aa0df-7c76-4e77-b1b6-6e9db5599059"), new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"), "Volt" },
                    { new Guid("115dc2d1-fb53-428e-8416-e97a2bee119c"), new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"), "El Camino" },
                    { new Guid("1e68205e-a045-4b11-94e7-b9795305f9ae"), new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"), "Element" },
                    { new Guid("1f80be54-f6ee-4e90-9511-7de71ee80554"), new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"), "Escalade" },
                    { new Guid("2b85290f-9bcb-4091-af8a-28877ee939ab"), new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"), "Roadster" },
                    { new Guid("3cec53a9-b6f3-42d9-b6f0-d40a11c478b2"), new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"), "Silverado" },
                    { new Guid("40cc5e13-99b2-43c9-b86e-e5848ac2244f"), new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"), "Charger" },
                    { new Guid("4b524395-7112-4516-aeed-c4d268a68396"), new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"), "XC90" },
                    { new Guid("540cf388-3096-4941-a651-a226fb287c8d"), new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"), "1" },
                    { new Guid("5aef2904-4011-44cc-bdad-2fe00b5b43f3"), new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"), "Escalade" },
                    { new Guid("66841042-23d8-4b53-8f18-d21ac4a30897"), new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"), "Element" },
                    { new Guid("818d9a1e-338f-4704-bed7-3cd0f71b35d5"), new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"), "XTS" },
                    { new Guid("874fa827-a393-46e1-ba9c-48ea40f01f8b"), new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"), "Roadster" },
                    { new Guid("8951d126-0ae4-4a04-9a59-cf5a0182741a"), new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"), "Model T" },
                    { new Guid("9bb895b3-f778-411f-a977-afbd281e9172"), new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"), "Taurus" },
                    { new Guid("a10a9bb9-b8dd-4a8f-820f-5094520d4429"), new Guid("2b321309-e057-4dd8-9a7d-9e0d254e6f37"), "Alpine" },
                    { new Guid("a34a169c-02ca-47fb-8cd7-04138dbe5266"), new Guid("64564c0a-f309-476f-80a0-2b41aeee6695"), "911" },
                    { new Guid("a360ac28-660d-4819-97d2-8da1875e7907"), new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"), "Grand Cherokee" },
                    { new Guid("b1ff8f2f-12ba-4c1c-98e6-a937620b39a4"), new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"), "Mercielago" },
                    { new Guid("bc868db3-207c-4ce8-8f72-a2c2943d7a67"), new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"), "Accord" },
                    { new Guid("c38f99d3-66d1-43e4-a9c9-c9f796d46b1d"), new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"), "ATS" },
                    { new Guid("d766776c-7dac-475d-a50c-8f99fa7579f6"), new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"), "Alpine" },
                    { new Guid("da2f8fba-e449-4c7a-b4ad-3b813b66ac83"), new Guid("7336d067-baa3-4c19-867b-2c6e49b58c20"), "Charger" },
                    { new Guid("f0b82dae-0425-4b95-a5fe-826bc62d7e27"), new Guid("b89de499-e213-4fc5-a700-89382b2b4f5d"), "Escalade" },
                    { new Guid("fd739c86-b73d-4763-8eb9-a0f56022f5d9"), new Guid("62973dfc-01b5-4642-9d6f-3e739bc1bd6c"), "Jetta" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_CarModels_CarModelId",
                table: "Vehicles",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id");
        }
    }
}
