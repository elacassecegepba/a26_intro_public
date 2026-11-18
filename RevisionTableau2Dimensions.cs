
decimal[,] notes = { { 77, 88, 99 }, { 85, 75, 49 }, { 94, 92, 88 }, { 75, 84, 85 } };

decimal DemanderNombreDecimal(string message)
{
    Console.Write(message);
    decimal nombre;
    while (!decimal.TryParse(Console.ReadLine(), out nombre))
    {
        Console.Write("Veuillez entrer un nombre décimal valide : ");
    }
    return nombre;
}

void AfficherTableau(decimal[,] tableau)
{
    for (int ligne = 0; ligne < tableau.GetLength(0); ligne++)
    {
        for (int colonne = 0; colonne < tableau.GetLength(1); colonne++)
        {
            // "\t" ajoute une tabulation entre les éléments pour un meilleur alignement
            Console.Write(tableau[ligne, colonne] + "\t");
        }
        Console.WriteLine();
    }
}

void ExecuterProgrammeCalculerMoyenne()
{
    // Appelez votre fonction CalculerMoyenne ici et affichez le résultat
}

void ExecuterProgrammeCompterNotesEnHautOuEgale()
{
    decimal seuil = DemanderNombreDecimal("Entrez le seuil : ");
    // Appelez votre fonction CompterNotesEnHautOuEgale ici et affichez le résultat
}

void ExecuterProgrammeTrouverMeilleureNote()
{
    // Appelez votre fonction TrouverMeilleureNote ici et affichez le résultat
}

void ExecuterProgrammeDiagonales0()
{
    decimal[,] tableau = { { 2, -4, 3, 5 }, { 6, 5, 3, 1 }, { 8, 7, 3, 5 }, { 2, 3, 7, -3 } };
    Console.WriteLine("Tableau avant modification :");
    AfficherTableau(tableau);
    // Appelez votre fonction MettreDiagonalesA0 ici

    Console.WriteLine();
    Console.WriteLine("Tableau après modification :");
    AfficherTableau(tableau);
}

void AfficherMenu()
{
    Console.WriteLine("Menu :");
    AfficherOptionMenu("1", "Calculer la moyenne");
    AfficherOptionMenu("2", "Compter les notes en haut ou égale");
    AfficherOptionMenu("3", "Trouver la meilleure note");
    AfficherOptionMenu("4", "Mettre les diagonales à 0");
    AfficherOptionMenu("5", "Quitter");
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
                ExecuterProgrammeCalculerMoyenne();
                break;
            case ConsoleKey.D2 or ConsoleKey.NumPad2:
                ExecuterProgrammeCompterNotesEnHautOuEgale();
                break;
            case ConsoleKey.D3 or ConsoleKey.NumPad3:
                ExecuterProgrammeTrouverMeilleureNote();
                break;
            case ConsoleKey.D4 or ConsoleKey.NumPad4:
                ExecuterProgrammeDiagonales0();
                break;
            case ConsoleKey.D5 or ConsoleKey.NumPad5:
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