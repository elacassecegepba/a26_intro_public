int[] tableau = { 45, 12, 33, 66, 99, 33, 55, 4, 5, 78, 23, 45, 9, 41 };

int DemanderNombreEntier(string message)
{
    Console.Write(message);
    int nombre;
    while (!int.TryParse(Console.ReadLine(), out nombre))
    {
        Console.Write("Veuillez entrer un nombre entier valide : ");
    }
    return nombre;
}

void AfficherTableau(int[] tableau)
{
    for (int noCase = 0; noCase < tableau.GetLength(0); noCase++)
    {
        int valeur = tableau[noCase];
        // "\t" ajoute une tabulation entre les éléments pour un meilleur alignement
        Console.Write(valeur + "\t");
    }
    Console.WriteLine(); // Ajout d'une nouvelle ligne après l'affichage du tableau
}

void ExecuterProgrammeInverserTableau()
{
    Console.WriteLine("Tableau avant inversion :");
    AfficherTableau(tableau);
    // Appelez votre fonction InverserTableau ici et affichez le tableau inversé
}

void ExecuterProgrammeChercherValeur()
{
    int valeur = DemanderNombreEntier("Entrez la valeur à chercher : ");
    // Appelez votre fonction ChercherValeur ici et affichez le résultat
}

void ExecuterProgrammeCreerTableauCumulatif()
{
    Console.WriteLine("Tableau original :");
    AfficherTableau(tableau);
    // Appelez votre fonction CreerTableauCumulatif ici et affichez le tableau cumulatif
}

void ExecuterProgrammeCompterOccurrencesChiffres()
{
    Console.Write("Entrez un texte à analyser : ");
    string texte = Console.ReadLine()!; // Utilisation de l'opérateur null-forgiving (!) pour indiquer que la valeur ne sera pas nulle
    // Appelez votre fonction CompterOccurrencesChiffres ici et affichez le résultat
}

void AfficherMenu()
{
    Console.WriteLine("Menu :");
    AfficherOptionMenu("1", "Afficher le tableau");
    AfficherOptionMenu("2", "Inverser le tableau");
    AfficherOptionMenu("3", "Chercher une valeur");
    AfficherOptionMenu("4", "Créer un tableau cumulatif");
    AfficherOptionMenu("5", "Compter les occurrences des chiffres");
    AfficherOptionMenu("6", "Quitter");
}

void AfficherOptionMenu(string option, string description)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(option);
    Console.ResetColor();
    Console.WriteLine($". {description}");
}

void Main()
{
    bool continuer = true;
    while (continuer)
    {
        Console.Clear();
        AfficherMenu();
        Console.Write("Choisissez une option : ");
        ConsoleKey choix = Console.ReadKey(true).Key;
        Console.Clear();

        switch (choix)
        {
            case ConsoleKey.D1 or ConsoleKey.NumPad1:
                AfficherTableau(tableau);
                break;
            case ConsoleKey.D2 or ConsoleKey.NumPad2:
                ExecuterProgrammeInverserTableau();
                break;
            case ConsoleKey.D3 or ConsoleKey.NumPad3:
                ExecuterProgrammeChercherValeur();
                break;
            case ConsoleKey.D4 or ConsoleKey.NumPad4:
                ExecuterProgrammeCreerTableauCumulatif();
                break;
            case ConsoleKey.D5 or ConsoleKey.NumPad5:
                ExecuterProgrammeCompterOccurrencesChiffres();
                break;
            case ConsoleKey.D6 or ConsoleKey.NumPad6:
                continuer = false;
                break;
            default:
                Console.WriteLine("Option invalide.");
                break;
        }
        
        if (continuer)
        {
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}

Main();