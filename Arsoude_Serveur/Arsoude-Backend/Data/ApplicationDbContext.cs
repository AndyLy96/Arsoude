using Arsoude_Backend.Models;
using Arsoude_Backend.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Arsoude_Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "11111111-1111-1111-1111-111111111113", Name = "Admin", NormalizedName = "ADMIN" }
        );

            // Creation du compte admin
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            IdentityUser admin = new IdentityUser
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                // La comparaison d'identity se fait avec les versions normalis�s
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                EmailConfirmed = true
            };
            User userAdmin = new User()
            {
                Id = 99,
                LastName = "Admin",
                FirstName = "Admin",
                AreaCode = "A1A 1A1",
                IdentityUserId = admin.Id,



            };
            builder.Entity<User>().HasData(userAdmin);
            // On encrypte le mot de passe
            admin.PasswordHash = hasher.HashPassword(admin, "Passw0rd!");
            builder.Entity<IdentityUser>().HasData(admin);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = "11111111-1111-1111-1111-111111111113" }
            );

            /*builder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "2", Name = "Player", NormalizedName = "PLAYER" }
           );*/

            // Creation d'un compte utilisateur test
            PasswordHasher<IdentityUser> hasher2 = new PasswordHasher<IdentityUser>();
            IdentityUser user = new IdentityUser
            {
                Id = "11111111-1111-1111-1111-111111111112",
                UserName = "user@user.com",
                Email = "user@user.com",
                // La comparaison d'identity se fait avec les versions normalis�s
                NormalizedEmail = "USER@USER.COM",
                NormalizedUserName = "USER@USER.COM",
                EmailConfirmed = true
            };
            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string> { UserId = user.Id, RoleId = "11111111-1111-1111-1111-111111111113" }
           );

            User test = new User {
                Id = 1,
                LastName = "Test",
                FirstName = "Test",
                AreaCode = "111 111",
                IdentityUserId = user.Id,
            };

            // On encrypte le mot de passe
            user.PasswordHash = hasher2.HashPassword(user, "Passw0rd!");
            builder.Entity<IdentityUser>().HasData(user);
            builder.Entity<User>().HasData(test);
            

            List<Coordinates> coordinates = new List<Coordinates>();

            Coordinates c1 = new Coordinates()
            {
                Id = 1,
                Latitude = 45.559602,
                Longitude = -73.580236

            };
            Coordinates c2 = new Coordinates()
            {
                Id = 2,
                Latitude = 45.671822,
                Longitude = -73.526654

            };
            builder.Entity<Coordinates>().HasData(c1, c2);

            Coordinates c3 = new Coordinates()
            {
                Id = 3,
                Latitude = 48.909387,
                Longitude = -75.818077

            };
            Coordinates c4 = new Coordinates()
            {
                Id = 4,
                Latitude = 48.806409,
                Longitude = -75.914645

            };
            builder.Entity<Coordinates>().HasData(c3, c4);

            Coordinates c5 = new Coordinates()
            {
                Id = 5,
                Latitude = 48.969093,
                Longitude = -76.906712

            };
            Coordinates c6 = new Coordinates()
            {
                Id = 6,
                Latitude = 48.925914,
                Longitude = -76.893322

            };
            builder.Entity<Coordinates>().HasData(c5, c6);

            Coordinates c7 = new Coordinates()
            {
                Id = 7,
                Latitude = 45.92813,
                Longitude = -74.04425

            };
            Coordinates c8 = new Coordinates()
            {
                Id = 8,
                Latitude = 45.92399,
                Longitude = -74.04164

            };
            builder.Entity<Coordinates>().HasData(c7, c8);

            Coordinates c9 = new Coordinates()
            {
                Id = 9,
                Latitude = 45.89206,
                Longitude = -74.15947

            };
            Coordinates c10 = new Coordinates()
            {
                Id = 10,
                Latitude = 46.34144,
                Longitude = -74.26788

            };
            builder.Entity<Coordinates>().HasData(c9, c10);

            Coordinates c11 = new Coordinates()
            {
                Id = 11,
                Latitude = 48.56827,
                Longitude = -64.30681
            };
            Coordinates c12 = new Coordinates()
            {
                Id = 12,
                Latitude = 48.574313,
                Longitude = -64.352937
            };
            builder.Entity<Coordinates>().HasData(c11, c12);

            Coordinates c13 = new Coordinates()
            {
                Id = 13,
                Latitude = 48.56827,
                Longitude = -64.30681
            };
            Coordinates c14 = new Coordinates()
            {
                Id = 14,
                Latitude = 48.808651,
                Longitude = -64.220134
            };
            builder.Entity<Coordinates>().HasData(c13, c14);

            Coordinates c15 = new Coordinates()
            {
                Id = 15,
                Latitude = 49.227136,
                Longitude = -65.920733
            };
            Coordinates c16 = new Coordinates()
            {
                Id = 16,
                Latitude = 49.193142,
                Longitude = -65.902365
            };
            builder.Entity<Coordinates>().HasData(c15, c16);


            Coordinates c17 = new Coordinates()
            {
                Id = 17,
                Latitude = 51.545590,
                Longitude = -69.132335
            };
            Coordinates c18 = new Coordinates()
            {
                Id = 18,
                Latitude = 51.160510,
                Longitude = -69.023845
            };
            builder.Entity<Coordinates>().HasData(c17, c18);

            Coordinates c19 = new Coordinates()
            {
                Id = 19,
                Latitude = 51.545590,
                Longitude = -69.132335
            };
            Coordinates c20 = new Coordinates()
            {
                Id = 20,
                Latitude = 51.160510,
                Longitude = -69.023845
            };
            builder.Entity<Coordinates>().HasData(c19, c20);

            Coordinates c21 = new Coordinates()
            {
                Id = 21,
                Latitude = 51.545590,
                Longitude = -69.132335
            };
            Coordinates c22 = new Coordinates()
            {
                Id = 22,
                Latitude = 51.160510,
                Longitude = -69.023845
            };
            builder.Entity<Coordinates>().HasData(c21, c22);

            Coordinates c23 = new Coordinates()
            {
                Id = 23,
                Latitude = 54.012407,
                Longitude = -82.219066
            };
            Coordinates c24= new Coordinates()
            {
                Id = 24,
                Latitude = 55.002627,
                Longitude = -82.279491
            };
            builder.Entity<Coordinates>().HasData(c23, c24);

            Coordinates c25 = new Coordinates()
            {
                Id = 25,
                Latitude = 62.838535,
                Longitude = -91.898670
            };
            Coordinates c26 = new Coordinates()
            {
                Id = 26,
                Latitude = 63.303736,
                Longitude = -90.769825
            };
            builder.Entity<Coordinates>().HasData(c25, c26);


            //

            Coordinates c27 = new Coordinates()
            {
                Id = 27,
                Latitude = 74.022659,
                Longitude = -41.820592

            };
            Coordinates c28 = new Coordinates()
            {
                Id = 28,
                Latitude = 75.560385,
                Longitude = -31.515417

            };
            builder.Entity<Coordinates>().HasData(c27, c28);

            Coordinates c29 = new Coordinates()
            {
                Id = 29,
                Latitude = 68.110088,
                Longitude = 23.315586

            };
            Coordinates c30 = new Coordinates()
            {
                Id = 30,
                Latitude = 67.879562,
                Longitude = 23.189229
            };
            builder.Entity<Coordinates>().HasData(c29, c30);

            Coordinates c31 = new Coordinates()
            {
                Id = 31,
                Latitude = 69.151650,
                Longitude = 106.003671

            };
            Coordinates c32 = new Coordinates()
            {
                Id = 32,
                Latitude = 59.895603,
                Longitude = 104.905038
            };
            builder.Entity<Coordinates>().HasData(c31, c32);



            Coordinates c33 = new Coordinates()
            {
                Id = 33,
                Latitude = 29.240485,
                Longitude = -114.689688


            };
            Coordinates c34 = new Coordinates()
            {
                Id = 34,
                Latitude = 23.807555,
                Longitude = -110.657706

            };
            builder.Entity<Coordinates>().HasData(c33, c34);

            Coordinates c35 = new Coordinates()
            {
                Id = 35,
                Latitude = -11.490477,
                Longitude = -37.386364
            };
            Coordinates c36 = new Coordinates()
            {
                Id = 36,
                Latitude = -12.838269,
                Longitude = -38.243298
            };
            builder.Entity<Coordinates>().HasData(c35, c36);



            Coordinates c37 = new Coordinates()
            {
                Id = 37,
                Latitude = -18.224066,
                Longitude = 49.397387
            };
            Coordinates c38 = new Coordinates()
            {
                Id = 38,
                Latitude = -20.637858,
                Longitude = 48.529467
            };
            builder.Entity<Coordinates>().HasData(c37, c38);

            Coordinates c39 = new Coordinates()
            {
                Id = 39,
                Latitude = 10.711090,
                Longitude = 51.120647
            };
            Coordinates c40 = new Coordinates()
            {
                Id = 40,
                Latitude = 6.682897,
                Longitude = 49.088177
            };
            builder.Entity<Coordinates>().HasData(c39, c40);

            Coordinates c41 = new Coordinates()
            {
                Id = 41,
                Latitude = 38.587607,
                Longitude = 128.374712
            };
            Coordinates c42 = new Coordinates()
            {
                Id = 42,
                Latitude = 38.404083,
                Longitude = 128.455050
            };
            builder.Entity<Coordinates>().HasData(c41, c42);

            Trail trail2 = new Trail()
            {
                Id = 2,
                Name = "Sentier de la Forêt Enchantée",
                Description = "Une randonnée pittoresque à travers une forêt luxuriante où les oiseaux chantent et les rivières murmurent.",
                Location = "Parc National de la Forêt Verte",
                Type = TrailType.Pied,
                StartingCoordinatesId = 1,
                EndingCoordinatesId = 2,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail2);

            Trail trail3 = new Trail()
            {
                Id = 3,
                Name = "Escapade au Sommet",
                Description = "Une aventure difficile menant au sommet d'une montagne majestueuse offrant une vue imprenable sur la vallée ci-dessous.",
                Location = "Parc National des Montagnes Escarpées",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 3,
                EndingCoordinatesId = 4,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/49777868268_2dcd6e6d85_o_603e508e5d170.jpg?alt=media&token=ddb83ad6-6384-4c61-9410-c7ec2809e020",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail3);

            Trail trail31 = new Trail()
            {
                Id = 31,
                Name = "Sentier des Cascades Étincelantes",
                Description = "Une randonnée enchanteresse le long de plusieurs cascades étincelantes, où l'eau scintille au soleil et crée un spectacle magique. Ce sentier offre une expérience sensorielle unique avec le bruit apaisant de l'eau qui coule, les reflets chatoyants et la fraîcheur de l'air pur. Vous serez transporté dans un monde de beauté naturelle et de tranquillité.",
                Location = "Parc National des Cascades Étincelantes",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 5,
                EndingCoordinatesId = 6,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/640px-Tim_Hortons.jpg?alt=media&token=5b7707d7-8f0b-45fb-8029-e6192291c10b",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail31);

            Trail trail32 = new Trail()
            {
                Id = 32,
                Name = "Promenade des Champs de Fleurs",
                Description = "Une promenade pittoresque à travers de vastes champs de fleurs colorées, où vous pourrez vous imprégner des parfums enivrants et des couleurs éclatantes de la nature. Ce sentier offre une expérience visuelle et olfactive unique, avec des vues panoramiques sur les champs à perte de vue et une ambiance paisible qui invite à la détente et à la contemplation.",
                Location = "Champs de Fleurs en Fleur",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 7,
                EndingCoordinatesId = 8,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/646ecba4d5310c7256b400e4_iphigenie-carte-IGN.jpeg?alt=media&token=a1285d82-eb22-4c38-b509-3718bcecc23d",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail32);

            Trail trail33 = new Trail()
            {
                Id = 33,
                Name = "Escapade au Lac de Montagne",
                Description = "Une randonnée jusqu'à un pittoresque lac de montagne, niché au creux des sommets enneigés et entouré d'une nature sauvage et préservée. Ce sentier offre des vues panoramiques spectaculaires sur les montagnes environnantes et une atmosphère paisible et relaxante près de l'eau cristalline du lac.",
                Location = "Lac de Montagne Tranquille",
                Type = TrailType.Pied,
                StartingCoordinatesId = 9,
                EndingCoordinatesId = 10,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/A-Sea-Of-Clouds-And-Mountains.jpg?alt=media&token=18d7ba11-bb99-4b18-97dc-c0f5c9c59999",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail33);

            Trail trail34 = new Trail()
            {
                Id = 34,
                Name = "Sentier des Ruines Anciennes",
                Description = "Une aventure à travers les ruines anciennes d'une civilisation disparue, où vous pourrez découvrir l'histoire fascinante de ce site archéologique. Ce sentier offre une expérience immersive dans le passé, avec des vestiges bien préservés et des paysages à couper le souffle qui témoignent de la grandeur passée de cette civilisation.",
                Location = "Site Archéologique des Ruines Anciennes",
                Type = TrailType.Pied,
                StartingCoordinatesId = 11,
                EndingCoordinatesId = 12,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/istockphoto-1369171053-612x612.jpg?alt=media&token=5506f8ac-46cd-4023-89fc-e7b0ac18909c",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail34);

            Trail trail35 = new Trail()
            {
                Id = 35,
                Name = "Randonnée des Falaises Côtières",
                Description = "Une randonnée le long de falaises côtières majestueuses, offrant des vues spectaculaires sur l'océan et les côtes rocheuses. Ce sentier offre une expérience unique en bord de mer, avec des panoramas à couper le souffle et une ambiance maritime rafraîchissante.",
                Location = "Falaises Côtières",
                Type = TrailType.Pied,
                StartingCoordinatesId = 13,
                EndingCoordinatesId = 14,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/mountainBackground.jpg?alt=media&token=56efecc5-c94b-4927-9d19-23f5def22854",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail35);

            Trail trail36 = new Trail()
            {
                Id = 36,
                Name = "Sentier de la Vallée Endormie",
                Description = "Une balade à travers une vallée paisible et endormie, où le temps semble s'être arrêté. Ce sentier offre une expérience tranquille en pleine nature, avec des paysages pittoresques et une ambiance relaxante qui invite à la contemplation.",
                Location = "Vallée Endormie",
                Type = TrailType.Pied,
                StartingCoordinatesId = 15,
                EndingCoordinatesId = 16,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/photo-aerienne.jpg?alt=media&token=c1bc1d71-979c-4bc8-ba7e-7c4c7cc15434",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail36);

            Trail trail37 = new Trail()
            {
                Id = 37,
                Name = "Randonnée du Pic Vertigineux",
                Description = "Une randonnée jusqu'au sommet d'un pic vertigineux, offrant des vues à couper le souffle sur les vallées et les montagnes environnantes. Ce sentier offre une expérience exaltante pour les amateurs de sensations fortes, avec des panoramas spectaculaires et une montée stimulante.",
                Location = "Pic Vertigineux",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 17,
                EndingCoordinatesId = 18,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/rando.jpg?alt=media&token=fc58456a-ce4d-42b1-94d1-bf6a6ecbe5b4",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail37);

            Trail trail38 = new Trail()
            {
                Id = 38,
                Name = "Chemin des Chutes Mystiques",
                Description = "Une balade le long de plusieurs chutes mystiques, cachées au cœur d'une forêt luxuriante. Ce sentier offre une expérience enchantée, avec des cascades paisibles et des paysages magiques qui émerveilleront les sens.",
                Location = "Forêt des Chutes Mystiques",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 19,
                EndingCoordinatesId = 20,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/randonnee-en-france-dans-les-gorges-du-verdon.jpg?alt=media&token=f1c7f80a-3d7d-4606-b97a-c24d587070e7",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail38);

            Trail trail39 = new Trail()
            {
                Id = 39,
                Name = "Randonnée du Lac de Cristal",
                Description = "Une randonnée jusqu'à un magnifique lac de cristal, dont les eaux claires reflètent les montagnes environnantes. Ce sentier offre une expérience rafraîchissante en plein air, avec la possibilité de se baigner dans les eaux cristallines du lac.",
                Location = "Lac de Cristal",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 21,
                EndingCoordinatesId = 22,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail39);

            Trail trail40 = new Trail()
            {
                Id = 40,
                Name = "Sentier du Canyon Étincelant",
                Description = "Une randonnée à travers un canyon étincelant, où la lumière du soleil se reflète sur les parois rocheuses pour créer un spectacle scintillant. Ce sentier offre une expérience visuelle saisissante, avec des jeux de lumière magiques et des formations rocheuses uniques.",
                Location = "Canyon Étincelant",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 23,
                EndingCoordinatesId = 24,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/t%C3%A9l%C3%A9chargement%20(2).jfif?alt=media&token=85a8dbbb-0960-4ed5-9628-869dcc977adb",
                isPublic = true
            };
            builder.Entity<Trail>().HasData(trail40);

            Trail trail41 = new Trail()
            {
                Id = 41,
                Name = "Promenade des Jardins Enchantés",
                Description = "Une balade à travers des jardins enchanteurs, où vous pourrez admirer une grande variété de plantes exotiques et de fleurs colorées. Ce sentier offre une expérience botanique unique, avec des jardins bien entretenus et une ambiance paisible qui invite à la contemplation.",
                Location = "Jardins Enchantés",
                Type = TrailType.Pied,
                StartingCoordinatesId = 25,
                EndingCoordinatesId = 26,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/t%C3%A9l%C3%A9chargement.jpg?alt=media&token=c22f1408-24e1-49e4-9afa-d245a5c09b88"
            };
            builder.Entity<Trail>().HasData(trail41);

            Trail trail42 = new Trail()
            {
                Id = 42,
                Name = "Randonnée du Sommet Enneigé",
                Description = "Une randonnée épique jusqu'au sommet d'une montagne enneigée, offrant des vues à couper le souffle sur les paysages alpins. Ce sentier offre une expérience alpine authentique, avec des vues panoramiques sur les montagnes enneigées et une ambiance hivernale magique.",
                Location = "Sommet Enneigé",
                Type = TrailType.Pied,
                StartingCoordinatesId = 27,
                EndingCoordinatesId = 28,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/uvqqzh20rqargzgyuqzv.jpg?alt=media&token=b13cf228-e7e9-409b-b9b7-919889e42a96"
            };
            builder.Entity<Trail>().HasData(trail42);

            //IMAGE MARCHE PAS
            Trail trail43 = new Trail()
            {
                Id = 43,
                Name = "Sentier des Marais Brumeux",
                Description = "Une promenade à travers des marais brumeux, où l'air est chargé d'humidité et la lumière filtre à travers le brouillard. Ce sentier offre une expérience mystérieuse et immersive dans les marais, avec des paysages enveloppés de brume et une ambiance envoûtante.",
                Location = "Marais Brumeux",
                Type = TrailType.Pied,
                StartingCoordinatesId = 29,
                EndingCoordinatesId = 30,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a"
            };
            builder.Entity<Trail>().HasData(trail43);

            //Trail trail44 = new Trail()
            //{
            //    Id = 44,
            //    Name = "Randonnée des Gorges Profondes",
            //    Description = "Une randonnée à travers des gorges profondes, où les parois rocheuses s'élèvent majestueusement de chaque côté. Ce sentier offre une expérience immersive dans les profondeurs de la terre, avec des formations rocheuses impressionnantes et des vues spectaculaires.",
            //    Location = "Gorges Profondes",
            //    Type = TrailType.Vélo,
            //    StartingCoordinatesId = 1,
            //    EndingCoordinatesId = 2,
            //    OwnerId = test.Id,
            //    ImageUrl = "https://i.ibb.co/C6Xw0Dp/kawaivlad.png"
            //};
            //builder.Entity<Trail>().HasData(trail44);

            Trail trail45 = new Trail()
            {
                Id = 45,
                Name = "Sentier de la Cascade Éternelle",
                Description = "Une randonnée jusqu'à une cascade éternelle, dont les eaux coulent continuellement et offrent un spectacle apaisant. Ce sentier offre une expérience rafraîchissante en plein air, avec la possibilité de se détendre près de la cascade et d'admirer sa beauté intemporelle.",
                Location = "Cascade Éternelle",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 31,
                EndingCoordinatesId = 32,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a"
            };
            builder.Entity<Trail>().HasData(trail45);

            Trail trail46 = new Trail()
            {
                Id = 46,
                Name = "Promenade du Lac Serein",
                Description = "Une balade paisible autour d'un lac serein, où vous pourrez profiter de la tranquillité de l'eau et observer la faune locale. Ce sentier offre une expérience relaxante en plein air, avec des vues pittoresques sur le lac et une ambiance calme qui invite à la méditation.",
                Location = "Lac Serein",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 33,
                EndingCoordinatesId = 34,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a"
            };
            builder.Entity<Trail>().HasData(trail46);

            Trail trail47 = new Trail()
            {
                Id = 47,
                Name = "Randonnée des Montagnes Miroir",
                Description = "Une randonnée à travers les montagnes miroir, où les sommets reflètent parfaitement le ciel et les nuages. Ce sentier offre une expérience visuelle spectaculaire, avec des panoramas époustouflants et des paysages qui semblent sortis d'un rêve.",
                Location = "Montagnes Miroir",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 35,
                EndingCoordinatesId = 36,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5aG"
            };
            builder.Entity<Trail>().HasData(trail47);

            Trail trail48 = new Trail()
            {
                Id = 48,
                Name = "Sentier du Coucher de Soleil",
                Description = "Une balade en fin de journée pour admirer le coucher de soleil sur l'horizon, offrant des couleurs chaudes et des reflets dorés sur l'eau. Ce sentier offre une expérience magique en plein air, avec des vues panoramiques sur le ciel coloré et une ambiance paisible qui invite à la contemplation.",
                Location = "Coucher de Soleil",
                Type = TrailType.Pied,
                StartingCoordinatesId = 37,
                EndingCoordinatesId = 38,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a"
            };
            builder.Entity<Trail>().HasData(trail48);

            Trail trail49 = new Trail()
            {
                Id = 49,
                Name = "Randonnée du Canyon Profond",
                Description = "Une randonnée épique à travers un canyon profond, où les parois rocheuses s'élèvent à des hauteurs vertigineuses de chaque côté. Ce sentier offre une expérience immersive dans la nature sauvage, avec des vues spectaculaires sur les falaises et les gorges.",
                Location = "Canyon Profond",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 39,
                EndingCoordinatesId = 40,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a"
            };
            builder.Entity<Trail>().HasData(trail49);

            Trail trail50 = new Trail()
            {
                Id = 50,
                Name = "Sentier de la Vallée des Brumes",
                Description = "Une balade à travers une vallée mystique, où les brumes matinales créent une atmosphère envoûtante. Ce sentier offre une expérience magique en plein air, avec des paysages enveloppés de brume et une ambiance tranquille qui invite à la contemplation.",
                Location = "Vallée des Brumes",
                Type = TrailType.Vélo,
                StartingCoordinatesId = 41,
                EndingCoordinatesId = 42,
                OwnerId = test.Id,
                ImageUrl = "https://firebasestorage.googleapis.com/v0/b/arsoudeserv.appspot.com/o/test.jpg?alt=media&token=16218832-5af7-4544-add2-a384190f4a5a"
            };
            builder.Entity<Trail>().HasData(trail50);


        }

        public DbSet<User> TrailUsers { get; set; } = default!;

        public DbSet<Trail> Trails { get; set; } = default!;

        public DbSet<UserFavoriteTrail> UserFavoriteTrails { get; set; } = default!;

        public DbSet<Coordinates> Coordinates { get; set; } = default!;

        public DbSet<Level> Levels { get; set; } = default!;

        public DbSet<Hike> Hikes { get; set; } = default!;

        public DbSet<ImageTrail> TrailImages { get; set; } = default!;

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<TrailUser> TrailRatingUser { get; set; } = default!;
    }
}