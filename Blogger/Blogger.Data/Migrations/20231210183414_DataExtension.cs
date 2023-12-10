using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blogger.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("54ea3747-8178-4960-8e68-8d75c59b743f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("885f8c0d-0d0b-4e48-8934-f38accaae449"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("ab059ad4-dac9-4aa3-b85a-53d215397ff1"), new Guid("11e8b5ea-dabb-4b9b-a13e-9086ed9a54f1"), "Asp.Net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin test", new DateTime(2023, 12, 10, 21, 34, 13, 948, DateTimeKind.Local).AddTicks(4968), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85a153dc-b556-4e1a-ae32-3bf864acef76"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core deneme makalesi", 15 },
                    { new Guid("b4bfe9ac-b648-447b-a84d-2e1ac430dd98"), new Guid("1fd6f712-ce03-4ead-9c26-0fc2ba1db6e4"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin test", new DateTime(2023, 12, 10, 21, 34, 13, 948, DateTimeKind.Local).AddTicks(4973), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34714a6c-561b-400f-8271-54ceb82dbcac"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio deneme makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11e8b5ea-dabb-4b9b-a13e-9086ed9a54f1"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 21, 34, 13, 948, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fd6f712-ce03-4ead-9c26-0fc2ba1db6e4"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 21, 34, 13, 948, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("34714a6c-561b-400f-8271-54ceb82dbcac"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 21, 34, 13, 948, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("85a153dc-b556-4e1a-ae32-3bf864acef76"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 21, 34, 13, 948, DateTimeKind.Local).AddTicks(6397));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ab059ad4-dac9-4aa3-b85a-53d215397ff1"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b4bfe9ac-b648-447b-a84d-2e1ac430dd98"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("54ea3747-8178-4960-8e68-8d75c59b743f"), new Guid("1fd6f712-ce03-4ead-9c26-0fc2ba1db6e4"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin test", new DateTime(2023, 12, 4, 23, 45, 29, 504, DateTimeKind.Local).AddTicks(8026), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34714a6c-561b-400f-8271-54ceb82dbcac"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio deneme makalesi", 15 },
                    { new Guid("885f8c0d-0d0b-4e48-8934-f38accaae449"), new Guid("11e8b5ea-dabb-4b9b-a13e-9086ed9a54f1"), "Asp.Net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin test", new DateTime(2023, 12, 4, 23, 45, 29, 504, DateTimeKind.Local).AddTicks(8021), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85a153dc-b556-4e1a-ae32-3bf864acef76"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core deneme makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11e8b5ea-dabb-4b9b-a13e-9086ed9a54f1"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 23, 45, 29, 504, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fd6f712-ce03-4ead-9c26-0fc2ba1db6e4"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 23, 45, 29, 504, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("34714a6c-561b-400f-8271-54ceb82dbcac"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 23, 45, 29, 504, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("85a153dc-b556-4e1a-ae32-3bf864acef76"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 23, 45, 29, 504, DateTimeKind.Local).AddTicks(9466));
        }
    }
}
