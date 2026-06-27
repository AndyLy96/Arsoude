using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arsoude_Backend.Migrations
{
    public partial class seeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "bbecf30a-20f0-45f3-8101-f93f85f7de45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24252ac9-9714-4b9a-bbd4-7f8954fbf477", "AQAAAAEAACcQAAAAECurr+LMVWK6ZcfKpAFWdQr6/JVtC5YpaXPSkLCmX1+cdQ+Yc3f3rDUtm3+ZsbPRUw==", "81f0630b-dcd2-4158-b5f2-21d0d0b50eef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b245f4ac-9042-447d-b251-261afa67e90a", "AQAAAAEAACcQAAAAEKavuwCiAxgj4YYLWNJky8VLT8Dutjr0YP/dGPx/ZYxIh/Rg5YWJZySMIJP8mrUIZA==", "5daa531e-0f15-46c2-bc5c-bbfbc103d8da" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/49777868268_2dcd6e6d85_o_603e508e5d170.jpg?alt=media&token=ddb83ad6-6384-4c61-9410-c7ec2809e020");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/640px-Tim_Hortons.jpg?alt=media&token=5b7707d7-8f0b-45fb-8029-e6192291c10b");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/646ecba4d5310c7256b400e4_iphigenie-carte-IGN.jpeg?alt=media&token=a1285d82-eb22-4c38-b509-3718bcecc23d");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/A-Sea-Of-Clouds-And-Mountains.jpg?alt=media&token=18d7ba11-bb99-4b18-97dc-c0f5c9c59999");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/istockphoto-1369171053-612x612.jpg?alt=media&token=5506f8ac-46cd-4023-89fc-e7b0ac18909c");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/mountainBackground.jpg?alt=media&token=56efecc5-c94b-4927-9d19-23f5def22854");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/photo-aerienne.jpg?alt=media&token=c1bc1d71-979c-4bc8-ba7e-7c4c7cc15434");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/rando.jpg?alt=media&token=fc58456a-ce4d-42b1-94d1-bf6a6ecbe5b4");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/randonnee-en-france-dans-les-gorges-du-verdon.jpg?alt=media&token=f1c7f80a-3d7d-4606-b97a-c24d587070e7");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/t%C3%A9l%C3%A9chargement%20(2).jfif?alt=media&token=85a8dbbb-0960-4ed5-9628-869dcc977adb");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/t%C3%A9l%C3%A9chargement.jpg?alt=media&token=c22f1408-24e1-49e4-9afa-d245a5c09b88");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/uvqqzh20rqargzgyuqzv.jpg?alt=media&token=b13cf228-e7e9-409b-b9b7-919889e42a96");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5aG");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "8f4b35da-e4ba-48e2-bf37-8afb739cdb88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e6273e-e2be-4740-8929-22267507a7fe", "AQAAAAEAACcQAAAAEIcUQ+kKhmgiYkbYpL3NTdU0kmtPmd4huhEQpN6PPBzX+ThGbtttkZHQjNRk5x8xbA==", "2a0ee01a-97a6-4ff9-8cab-c9dc78dcc162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db8a260f-5428-4762-8759-ba186fa379b8", "AQAAAAEAACcQAAAAEJ3Nlir8iKc7HpKlAq1Pkql+3oCGGeQZLI4KbJ/EpTHBZJILKn+poe6N+oZnziub1g==", "3e2fc6a7-de7b-496a-9e03-f3765c28bb85" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.parksconservancy.org/sites/default/files/styles/basic/public/programs/A_PRSF_111020_MCu_020-2104x1440.jpg?itok=Cp14Z3ba");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://cdn.kimkim.com/files/a/images/47739a6ddfef20df8e214fb3bd457adf1f27feab/original-fd1e0fff538a1dd6ebb2ab679ffbab4d.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://californiathroughmylens.com/wp-content/uploads/2019/05/crystal-cove-el-moro-12-640x427.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://blog.ab.bluecross.ca/wp-content/uploads/2020/08/fav-hikes-part-three.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://www.tourismpei.com/sites/default/files/styles/hero_mobile/public/media/images/51271316495_139f7c6199_o_0.jpg?h=3cbfe8df&itok=dRMEGC9G");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://i.cbc.ca/1.4170049.1530218327!/fileImage/httpImage/hiking-trails.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://www.mississauga.ca/wp-content/uploads/2022/10/14143203/20221010_115918-scaled.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://www.lutsen.com/sites/default/files/styles/scale_1440/public/2021-10/Biking%20-%20Molly%20at%20Britton%20Peak%20-%20VCC%20UL%20-%20by%20Al%20%26%20Lyndsey%20Johnson%20%20%2842%29.jpg?itok=N7pFjnwx");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://www.surrey.ca/sites/default/files/styles/metatag_facebook/public/2020-08/InvergarryNatureTrail.JPG?h=d262251e&itok=oXPbDLYW");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://i.pinimg.com/originals/7f/e4/e2/7fe4e24eb9024d61139ac44a607e478a.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://www.nps.gov/hosp/planyourvisit/images/_DSC7261.jpg?maxwidth=650&autorotate=false");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAO_hEyiI2Tkfl5TI78QWQpncjBZ_7VWxtU4rceThJXeSRAKCutUx62Hfw5sdbX_QBEa4&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://i.natgeofe.com/n/71741e7e-db92-41fc-9c54-f781c3df87df/2C57A8C_16x9.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUGLsH09jYtknRspMu0BDdOsADZrSLhzBUtA&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://assets.simpleviewinc.com/simpleview/image/upload/c_limit,h_1200,q_75,w_1200/v1/clients/gatlinburgtn/Forney_Ridge_trail_Smokies_3_796a5a89-db2b-49b4-9c62-b5fd805e1885.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://travel.home.sndimg.com/content/dam/images/travel/fullset/2012/08/24/a0/us-hiking-trails_ss_001.rend.hgtvcom.616.462.suffix/1491580965291.jpeg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://assets.simpleviewinc.com/simpleview/image/upload/c_limit,h_1200,q_75,w_1200/v1/clients/gatlinburgtn/Forney_Ridge_trail_Smokies_3_796a5a89-db2b-49b4-9c62-b5fd805e1885.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://1.bp.blogspot.com/-PzBA1W501qQ/VBhtDjlsI7I/AAAAAAAAaRM/L4PGqyTlPtg/s1600/Aspen%2B009.JPG");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://media.cnn.com/api/v1/images/stellar/prod/230821123314-01-body-family-of-7-hiking-americas-longest-trails.jpg?c=original");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://www.vmcdn.ca/f/files/glaciermedia/import/lmp-all/899734-image-copy.jpg");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://gowanderwild.com/wp-content/uploads/2022/12/The-Garden-Wall-Shelly-Pabis.jpg");
        }
    }
}
