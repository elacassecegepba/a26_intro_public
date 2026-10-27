// Demande à .NET de ne pas générer de fichier exécutable pour cette application console.
// Évite les problèmes de droits d'accès sur certains systèmes.
#:property UseAppHost=false

Console.OutputEncoding = System.Text.Encoding.UTF8;

const int LONGUEUR_MOT = 6;
const int NOMBRE_ERREURS_MAX = 6;

Random random = new Random();
string[] dessinsDuPendu = new string[NOMBRE_ERREURS_MAX + 1];
char[] lettresTrouvees = new char[LONGUEUR_MOT];
int nombreErreurs = 0;
string motADeviner = "";
bool[] lettresEssayees = new bool[26]; // Défi 3 - Variable globale pour garder en mémoire les lettres déjà essayées

LancerLeJeu();

// ==================== À COMPLÉTER ====================

void ChargerLesDessinsDuPendu()
{
    // 1 - À compléter
    // Chaque case du tableau dessinsDuPendu doit contenir le contenu d'un fichier
    // du dossier « dessins » : pendu0.txt dans la case 0, pendu1.txt dans la case 1, etc.
    // Indice : File.ReadAllText(chemin) retourne le contenu d'un fichier, donc
    //          File.ReadAllText("dessins/pendu0.txt"); donne le contenu du fichier pendu0.txt
    for (int i = 0; i < dessinsDuPendu.GetLength(0); i++)
    {
        string cheminFichier = $"dessins/pendu{i}.txt";
        dessinsDuPendu[i] = File.ReadAllText(cheminFichier);
    }
}

void ViderLesLettres()
{
    // 2 - À compléter
    // Chaque case du tableau lettresTrouvees doit contenir le caractère '_'
    for (int i = 0; i < lettresTrouvees.GetLength(0); i++)
    {
        lettresTrouvees[i] = '_';
    }
}

bool FaitPartieDuMot(char lettreATester)
{
    // 3 - À compléter
    // Retourne vrai si la lettre est dans le mot à deviner
    // Indice : motADeviner[i] retourne la lettre à la position i du mot à deviner, donc
    //          si le mot à deviner est "BONJOUR", motADeviner[0] vaut 'B', motADeviner[1] vaut 'O', etc.
    // Indice : motADeviner.Length retourne le nombre de lettres dans le mot à deviner
    bool faitPartie = false;
    for (int noLettre = 0; noLettre < motADeviner.Length; noLettre++)
    {
        char lettreCourante = motADeviner[noLettre];
        if (lettreCourante == lettreATester)
        {
            faitPartie = true;
        }
    }
    return faitPartie;
}

bool ADejaEteEssaye(char lettre)
{
    // 4 - À compléter
    // Retourne vrai si la lettre est déjà affichée dans le tableau lettresTrouvees
    bool dejaEssaye = false;
    for (int noLettre = 0; noLettre < lettresTrouvees.GetLength(0); noLettre++)
    {
        char lettreCourante = lettresTrouvees[noLettre];
        if (lettreCourante == lettre)
        {
            dejaEssaye = true;
        }
    }
    return dejaEssaye;
}

void AfficherLettreDansLeMot(char lettre)
{
    // 5 - À compléter
    // Place la lettre dans le tableau lettresTrouvees,
    // à chaque position où elle se trouve dans motADeviner.
    for (int noLettre = 0; noLettre < motADeviner.Length; noLettre++)
    {
        if (motADeviner[noLettre] == lettre)
        {
            lettresTrouvees[noLettre] = lettre;
        }
    }
}

bool ToutesLesLettresTrouvees()
{
    // 6 - À compléter
    // Vous devez vérifier si toutes les lettres du mot ont été trouvées
    bool toutesTrouvees = true;
    for (int i = 0; i < lettresTrouvees.GetLength(0); i++)
    {
        if (lettresTrouvees[i] == '_')
        {
            toutesTrouvees = false;
        }
    }
    return toutesTrouvees;
}

void AfficherLettresManquantes()
{
    // 7 - À compléter
    // Affiche le mot au complet, sur une seule ligne :
    // - les lettres trouvées dans la couleur normale;
    // - les lettres qui n'ont pas été trouvées en jaune.
    for (int i = 0; i < motADeviner.Length; i++)
    {
        if (lettresTrouvees[i] == '_')
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        Console.Write(motADeviner[i]);
        Console.ResetColor();
    }
    Console.WriteLine();
}

void NoterLettreEssayee(char lettre)
{
    // Défi 3 - Garder en mémoire les lettres déjà essayées
    // Ajouter une variable globale pour garder en mémoire les lettres déjà essayées.
    int noLettre = lettre - 'A';
    lettresEssayees[noLettre] = true;
}

void AfficherLettresEssayees()
{
    // Défi 3 - Affiche les lettres déjà essayées, sur une seule ligne.
    string texte = "Lettres essayées : ";
    for (int i = 0; i < lettresEssayees.GetLength(0); i++)
    {
        if (lettresEssayees[i])
        {
            char lettre = (char)('A' + i);
            texte = texte + lettre + " ";
        }
    }
    Console.WriteLine(texte);
}

// ==================== Ne pas modifier ====================

void LancerLeJeu()
{
    if (!File.Exists("mots.csv"))
    {
        Console.WriteLine("Le fichier mots.csv est introuvable.");
        Console.WriteLine("Si vous avez ouvert un autre dossier que celui de l'exercice, vous devez fermer Visual Studio Code et l'ouvrir dans le bon dossier.");
        return;
    }

    ChargerLesDessinsDuPendu();
    bool rejouer = true;
    while (rejouer)
    {
        InitialiserLeJeu();
        JouerUnePartie();
        rejouer = DemanderSiRejouer();
    }
}

void InitialiserLeJeu()
{
    nombreErreurs = 0;
    ViderLesLettres();
    NouveauMot();
}

void NouveauMot()
{
    string[] motsPossibles = ObtenirMotsDeLongueurX(LONGUEUR_MOT);
    int indexAleatoire = random.Next(0, motsPossibles.GetLength(0));
    motADeviner = motsPossibles[indexAleatoire];
}

void JouerUnePartie()
{
    bool partieTerminee = false;
    while (!partieTerminee)
    {
        AfficherLeJeu();
        char lettre = DemanderLettre();
        if (lettre == '?')
        {
            Console.WriteLine("Le mot à deviner est : " + motADeviner);
            AttendreAppuiTouche();
        }
        else
        {
            TesterLettre(lettre);
            partieTerminee = VerifierFinDePartie();
        }
    }
}

char DemanderLettre()
{
    // Défi 2 - Valider que la lettre entrée est bien une lettre de l'alphabet (A-Z) ou le caractère '?'.
    bool estLettre = false;
    string texte;

    do
    {
        Console.Write("Entrez une lettre (? pour tricher) : ");
        texte = Console.ReadLine() ?? "";
        texte = texte.ToUpper(); // Convertit le texte en majuscules
        if (texte.Length == 1 && (texte[0] == '?' || (texte[0] >= 'A' && texte[0] <= 'Z')))
        {
            estLettre = true;
        }
    } while (!estLettre);

    return texte[0]; // Retourne le premier caractère du texte
}

void TesterLettre(char lettreATester)
{
    NoterLettreEssayee(lettreATester); // Défi 3 - Garder en mémoire les lettres déjà essayées
    if (FaitPartieDuMot(lettreATester) && !ADejaEteEssaye(lettreATester))
    {
        AfficherLettreDansLeMot(lettreATester);
    }
    else
    {
        AjouterUneErreur();
    }
}

void AjouterUneErreur()
{
    nombreErreurs++;
}

bool VerifierFinDePartie()
{
    bool partieTerminee = false;
    if (nombreErreurs >= NOMBRE_ERREURS_MAX)
    {
        AfficherLeJeu();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Vous avez perdu!");
        Console.ResetColor();
        Console.Write("Le mot était : ");
        AfficherLettresManquantes();
        partieTerminee = true;
    }
    else if (ToutesLesLettresTrouvees())
    {
        AfficherLeJeu();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Vous avez gagné!");
        Console.ResetColor();
        partieTerminee = true;
    }
    return partieTerminee;
}

void AfficherLeJeu()
{
    Console.Clear();
    Console.WriteLine("========== LE PENDU ==========");
    Console.WriteLine();
    Console.WriteLine(dessinsDuPendu[nombreErreurs]);
    for (int i = 0; i < lettresTrouvees.GetLength(0); i++)
    {
        Console.Write(lettresTrouvees[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    AfficherLettresEssayees(); // Défi 3 - Affiche les lettres déjà essayées
    Console.WriteLine();
    Console.WriteLine("Erreurs : " + nombreErreurs + " / " + NOMBRE_ERREURS_MAX);
    Console.WriteLine();
}

bool DemanderSiRejouer()
{
    Console.WriteLine();
    Console.Write("Voulez-vous rejouer? (O/N) ");
    string reponse = (Console.ReadLine() ?? "").Trim().ToUpper();
    return reponse == "O";
}

void AttendreAppuiTouche()
{
    Console.WriteLine("Appuyez sur une touche pour continuer...");
    Console.ReadKey(true);
}

string[] ObtenirMotsDeLongueurX(int longueur)
{
    // Une liste est un tableau qui change de taille automatiquement.
    // On peut ajouter des éléments à la fin avec la méthode Add().
    List<string> mots = [];
    // Ouvrir le fichier mots.csv en lecture.
    // StreamReader permet de lire un fichier ligne par ligne.
    using StreamReader reader = new StreamReader("mots.csv");
    // Tant qu'on n'est pas à la fin du fichier
    while (!reader.EndOfStream)
    {
        // Lit la prochaine ligne
        string mot = reader.ReadLine()!;
        if (mot.Length == longueur)
        {
            mots.Add(mot);
        }
    }
    // Retourne le tableau de mots
    return mots.ToArray();
}
