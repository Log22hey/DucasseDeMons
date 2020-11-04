using DoudouMons.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DoudouMons.DAL
{
    public class DoudouInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DoudouContext>
    {
        protected override void Seed(DoudouContext context)
        {
            var characters = new List<Character>
            {
            new Character{IdCharacter=1,Name="Saint George",costume="Le héros est vêtu d'une casaque jaune bordée de rouge, d'une chemise bleue, de gants blancs, de collants de cavaliers blancs et de bottes noires. Il porte un casque de cuirassier belge de 1845 (rarissime car les cuirassiers belges n'ont pas été légion) : cimier cuivré, plumet rouge et queue de cheval à la nuque. Il porte des rubans rouges sur sa casaque, aux épaules et aux coudes, et la ferme avec des rubans aux couleurs de la Belgique. Pour des raisons d'esthétique, on intervertit l'ordre des couleurs : de noir jaune rouge, on place les rubans en jaune, rouge et noir car le noir en face est assez triste. Sa cravate est jaune.", ExplicationRole="Tuer le dragon qui represente le mal", NomArmes="lances, sabre, pistolet"},
            new Character{IdCharacter=2,Name="Chins-Chins", costume="Habillés d'une veste en tartan à dominante de rouge au-dessus d'une chemise verte et d'un pantalon blanc, portant un chapeau à large bords noir, ils chevauchent une carcasse d'osier recouverte d'une peau de vache à la manière des chevaux-jupons.", ExplicationRole=" ce sont les alliés naturels de saint Georges. Ils sont au nombre de douze", NomArmes="aucune"},
            new Character{IdCharacter=3,Name="Chinchin protecteur", costume="un tartan à dominante de bleu, tout comme la jupette de sa carcasse. La peau qui recouvre cette dernière est entièrement blanche, raison pour laquelle les autres ne peuvent pas avoir une carcasse de cette couleur. Son chapeau est blanc.", NomArmes="aucune"},
            new Character{IdCharacter=4, Name="Diables", costume="Leur costume est composé d'une salopette noire aux manchettes et au col blancs. Leur dos est recouvert d'une tête de Diable inspirée du dieu Pan, bouche ouverte en signe d'agressivité et à la pilosité hirsute", ExplicationRole="Au nombre de 11, les Diables sont les alliés naturels du Dragon, mais représentant le Malin, ils ne le respectent même pas. En effet, l'étymologie du nom les pousse à toujours viser la séparation. Le nombre 11 n'est pas choisi un hasard car c'est 1+1 : la dualité.", NomArmes="une vessie de porc"},
            new Character{IdCharacter=5, Name="Hommes blancs", costume="Ils sont habillés tout en blanc, chemise et pantalon, et ont une ceinture noire épaisse (ceinture de balle pelote) qui représente l'équilibre des forces, la part de mal de chacun. ", ExplicationRole="Ils ont un rôle fondamental car leur précision est nécessaire pour que le combat réussisse tant les phases exécutées sont délicates : pommeau, entrée dans l'arène, coups de queue et faux coups de queue, etc.", NomArmes="aucune"},
            new Character{IdCharacter=6, Name="Hommes de Feuilles", costume=" Ils sont habillés d'une veste et d'un pantalon verts recouverts de feuilles de lierre au nombre de 1 500 à 2 000 environ. ", ExplicationRole="ls soutiennent et gardent la queue du dragon. Ils sont au nombre de huit.", NomArmes="une massue"},
            new Character{IdCharacter=7, Name="Cybèle", costume="est habillée en jaune et noir, les couleurs du chapitre de sainte Waudru", ExplicationRole="Elle ranime les Chinchins renversés en touchant la carcasse de chacun d'eux. Elle donne les lances au Chinchin protecteur qui les apporte à saint Georges. Elle donne à ce dernier la lance noire et blanche, en fin de combat, afin de marquer le retour à l'équilibre et la continuité du cycle vers l'an d'après.", NomArmes="aucune"},
            new Character{IdCharacter=8,Name="Poliade", costume="Ses rubans sont blancs et rouges, le blanc sur sa tunique rouge, le rouge sur son pantalon blanc.", ExplicationRole="Elle remet les pistolets à l'officier, qui à son tour les donne à saint Georges. Elle distribue les canines du Dragon au public.", NomArmes="aucune"}
            };

            characters.ForEach(c => context.Characters.Add(c));
            context.SaveChanges();
        }
    }
}
