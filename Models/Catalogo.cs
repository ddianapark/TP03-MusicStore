namespace TP03_MusicStore.Models;

public class Catalogo
{
    public static List<Disco> catalogo { get; private set; }

    public static void InicializarCatalogo()
        {
            catalogo = new List<Disco>();
            Disco blackPink = new Disco(1, "Born Pink", "BLACKPINK", "Teddy Park", "K-Pop", new List<string> { "Pink Venom", "Shut Down", "Typa Girl", "Yeah Yeah Yeah" }, "/images/BORNPINK.png");
            Disco brunoMars = new Disco(2, "24K Magic", "Bruno Mars", "Bruno Mars, Shampoo Press & Curl", "Funk / R&B", new List<string> { "24K Magic", "Chunky", "That's What I Like", "Versace on the Floor" }, "/images/24K_Magic.png");
            Disco ColdPlay = new Disco(3,"A Head Full of Dreams","Coldplay","Stargate, Rik Simpson","Pop Rock",new List<string> { "Adventure of a Lifetime", "Hymn for the Weekend", "Up&Up" },"/images/COLD.jpg");
            Disco Uncorazon = new Disco (4,"Somos Iglesia","Un Corazón", "Steven Richards", "Cristiano", new List<string> { "Somos Iglesia", "Alabanza", "Jesús", "Libre" }, "/images/un croazón.png");
            Disco Dualipa = new Disco (5,"Future Nostalgia", "Dua Lipa", "Jeff Bhasker", "Pop", new List<string> { "Don't Start Now", "Physical", "Levitating", "Break My Heart" }, "/images/dua.png");
            Disco Theweeknd = new Disco (6, "After Hours", "The Weeknd", "Max Martin, Metro Boomin", "Synthpop / R&B", new List<string> { "Blinding Lights", "Save Your Tears", "Heartless" }, "/images/after.png" );
            Disco HarryStyles = new Disco (7, "Fine Line", "Harry Styles", "Tyler Johnson", "Pop Rock", new List<string> { "Watermelon Sugar", "Adore You", "Falling" }, "/images/ha.png");
            Disco JustinBieber = new Disco (8, "Justice", "Justin Bieber", "Andrew Watt, Skrillex", "Pop", new List<string> { "Peaches", "Hold On", "Anyone", "Ghost" }, "/images/jus.png");
            Disco BillieEilish = new Disco (9, "When We All Fall Asleep, Where Do We Go?", "Billie Eilish", "Finneas O'Connell", "Alternative Pop", new List<string> { "bad guy", "bury a friend", "when the party's over" }, "/images/wwafawdwg.jpg");
            Disco TaylorSwift = new Disco ( 10, "Evermore", "Taylor Swift", "Aaron Dessner, Jack Antonoff", "Indie Folk", new List<string> { "willow", "champagne problems", "no body, no crime" }, "/images/evermore.jpg");
        }
}

