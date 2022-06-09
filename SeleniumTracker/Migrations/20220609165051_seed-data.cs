using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeleniumTracker.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Resolutions",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 9, 18, 50, 51, 448, DateTimeKind.Local).AddTicks(1128),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 6, 8, 19, 19, 5, 884, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Failures",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 9, 18, 50, 51, 448, DateTimeKind.Local).AddTicks(463),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 6, 8, 19, 19, 5, 884, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "Ut in tempore omnis consequuntur magnam", false, "Quod similique nemo ducimus nihil", "Voluptatem asperiores rerum veniam magni", 1 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "Sint modi sit quia voluptas et omnis nostrum non non", true, "Ipsa quas beatae veniam voluptatem", "Libero vel quisquam quae et voluptatibus non", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "Aut qui omnis est expedita", true, "Et provident saepe aperiam ducimus autem officia tenetur", "Ducimus possimus iste et eveniet aliquam sed quibusdam repellendus", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "In voluptatem pariatur quia rerum porro dolorum", false, "Ut et eum eum vel", "Odit nulla aliquam tempore at", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Dolore et ipsam et a ut", "Possimus et ex magnam et deleniti assumenda quae voluptas officiis", "Distinctio repudiandae molestias ipsa et est", 1 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Illo non rerum consequatur et asperiores est dolor a", "Porro vitae sunt enim qui architecto vitae et", "Libero facilis natus ut alias rerum", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "Maxime nemo non non qui", false, "Aut id vero ipsa voluptatum omnis praesentium repudiandae", "Qui excepturi nesciunt esse cumque amet accusamus veritatis praesentium", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Inventore aut repellat nemo rem enim quibusdam et dolores", "Quia consequatur doloremque velit sed itaque", "Nihil quam harum itaque facilis eos aut eius quia", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "Similique animi nam ipsum placeat eum modi saepe eum", true, "Quas id qui beatae amet beatae velit sit", "Laudantium tenetur maiores recusandae aspernatur consectetur qui tenetur", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Class", "Failing", "Name", "Package" },
                values: new object[] { "Laborum nemo soluta sunt pariatur facere laudantium aut eligendi", false, "Temporibus eligendi omnis molestias commodi perspiciatis nostrum nihil repellat non", "Maiores quo in dolores placeat qui" });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Class", "Name", "Package" },
                values: new object[] { "Ut nam sit pariatur et culpa recusandae tempore", "Aut corrupti debitis esse asperiores blanditiis est quod", "Placeat qui dolorem et dolores rerum in dolorum non eos" });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "Fuga quos debitis cumque sit alias", false, "Et possimus eveniet voluptas et et repellendus voluptas cum", "Exercitationem hic sed corrupti et quia ipsum et voluptas modi", 1 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Ipsam consequatur porro et perspiciatis ab rem enim", "Rem fugit nobis exercitationem ut in suscipit fuga distinctio", "Unde impedit occaecati facere reprehenderit qui quos illo dignissimos vel", 0 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Eos nobis ipsam molestiae ab", "Sint iure sapiente velit consectetur dignissimos ratione", "Ullam odit earum velit et", 0 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Sapiente necessitatibus officia ut", "Quidem deserunt autem reiciendis voluptates voluptate", "Sunt suscipit sed voluptatem", 0 });

            migrationBuilder.InsertData(
                table: "Failures",
                columns: new[] { "Id", "AutotestId", "Date", "Details" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Nobis totam odio et aut deleniti excepturi sit rem" },
                    { 2, 2, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Fugit quos aut ea ut dolorem illum et officia iste" },
                    { 3, 3, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Voluptatem alias vero et nam modi alias tempore" },
                    { 4, 4, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ratione dolor repellat debitis" },
                    { 5, 5, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Eum repudiandae porro aut molestiae magnam" },
                    { 6, 6, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Laborum velit ducimus praesentium maxime quas debitis optio nulla" },
                    { 7, 7, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Laboriosam sed non iste sed" },
                    { 8, 8, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Reprehenderit a earum corporis accusamus repellat laboriosam quisquam blanditiis aut" },
                    { 9, 9, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Non mollitia nesciunt mollitia laudantium reiciendis" },
                    { 10, 10, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Perspiciatis sed veritatis sed praesentium in" },
                    { 11, 11, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dolores et autem maxime perspiciatis tenetur odit nobis aliquam" },
                    { 12, 12, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Aut nemo sit ratione numquam cum et dolores" },
                    { 13, 13, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Inventore aliquam consequatur iste non enim voluptas dolores repudiandae necessitatibus" },
                    { 14, 14, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Consequatur qui sunt incidunt quia" },
                    { 15, 15, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Error qui pariatur ut debitis temporibus vel" }
                });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[,]
                {
                    { 1, 1, "Enim accusamus vitae et enim voluptatem molestias", 4, true, 2, "LS14-1000001" },
                    { 2, 2, "Iure dolor maiores facere maiores facere est doloribus", 2, true, 1, "LS14-1000002" },
                    { 3, 3, "Quos omnis tempore neque dolor doloremque impedit", 3, true, 1, "LS14-1000003" },
                    { 4, 4, "Quia et quia in quos recusandae rerum et et et", 1, true, 4, "LS14-1000004" },
                    { 5, 5, "Quis deserunt expedita est et non alias dicta laboriosam aliquam", 1, true, 2, "LS14-1000005" }
                });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 6, 6, "Eveniet corrupti totam est est", 0, 1, "LS14-1000006" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[,]
                {
                    { 7, 7, "Exercitationem ipsa in quisquam eum cupiditate hic aspernatur", 4, true, 2, "LS14-1000007" },
                    { 8, 8, "Consequatur quasi ut ut ipsam in beatae voluptatem", 1, true, 0, "LS14-1000008" }
                });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 9, 9, "Qui non ut quis eum similique et sapiente", 4, 3, "LS14-1000009" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 10, 10, "Dicta consequatur non officiis quo quo rerum maiores rerum tempore", 1, true, 1, "LS14-10000010" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 11, 11, "Sit quos sequi accusamus officiis deserunt delectus distinctio nemo", 3, 2, "LS14-10000011" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 12, 12, "Id similique amet possimus", 4, true, 1, "LS14-10000012" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 13, 13, "Itaque aut quaerat consequuntur nihil et vitae facilis quam", 2, true, 3, "LS14-10000013" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 14, 14, "Iure quis quia voluptatum laudantium", 4, true, 4, "LS14-10000014" });

            migrationBuilder.InsertData(
                table: "TestLinkAnnotations",
                columns: new[] { "Id", "AutotestId", "Comments", "GeneralWorkflow", "Ignore", "SpecificWorkflow", "TestlinkId" },
                values: new object[] { 15, 15, "Vitae illum ipsum ab sed consectetur dolor", 3, true, 2, "LS14-10000015" });

            migrationBuilder.InsertData(
                table: "Resolutions",
                columns: new[] { "Id", "Date", "Details", "FailureId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ullam adipisci exercitationem deleniti", 1 },
                    { 2, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Iusto quia enim nemo aut nulla blanditiis nesciunt minima molestiae", 2 },
                    { 3, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cum et incidunt nihil consequuntur dolores", 3 },
                    { 4, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dolores eos ab cupiditate quae qui nam", 4 },
                    { 5, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Est consequatur consequuntur doloribus quasi", 5 },
                    { 6, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cum quia quos id et optio sequi", 6 },
                    { 7, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Natus placeat doloribus accusantium voluptas illum consectetur", 7 },
                    { 8, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Nostrum inventore esse earum praesentium", 8 },
                    { 9, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Fugit amet cumque quia numquam hic ab officiis ab quis", 9 },
                    { 10, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Molestias accusantium eius rerum expedita optio numquam autem illo accusamus", 10 },
                    { 11, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Modi quo sint id hic quisquam", 11 },
                    { 12, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Est quia nihil possimus reprehenderit veniam", 12 },
                    { 13, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Necessitatibus odio aperiam totam", 13 },
                    { 14, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Quis sed et in", 14 },
                    { 15, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ipsam porro voluptate ad aut", 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Resolutions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TestLinkAnnotations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Failures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Resolutions",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 8, 19, 19, 5, 884, DateTimeKind.Local).AddTicks(9476),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 6, 9, 18, 50, 51, 448, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Failures",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 8, 19, 19, 5, 884, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 6, 9, 18, 50, 51, 448, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "ullam1", true, "iste1", "nihil1", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "ut2", false, "aut2", "maiores2", 0 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "laboriosam3", false, "omnis3", "inventore3", 1 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "tempora4", true, "iusto4", "et4", 1 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "et5", "debitis5", "deserunt5", 3 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "qui6", "iure6", "autem6", 0 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "ut7", true, "ab7", "Omnis7", 3 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "perferendis8", "aliquid8", "sunt8", 3 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "ut9", false, "vel9", "occaecati.9", 3 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Class", "Failing", "Name", "Package" },
                values: new object[] { "Explicabo10", true, "occaecati10", "vitae10" });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Class", "Name", "Package" },
                values: new object[] { "reiciendis11", "nemo.11", "unde11" });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Class", "Failing", "Name", "Package", "Priority" },
                values: new object[] { "et12", true, "quis12", "et12", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "ex13", "consectetur13", "molestiae13", 2 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "Inventore14", "voluptatem14", "Quasi14", 3 });

            migrationBuilder.UpdateData(
                table: "Autotests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Class", "Name", "Package", "Priority" },
                values: new object[] { "non15", "Voluptatem15", "quas15", 2 });
        }
    }
}
