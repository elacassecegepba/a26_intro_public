using System.Runtime.CompilerServices;

namespace RevisionTableaux
{
    public partial class Form1 : Form
    {
        // Variable globale (1 dimension) : le tableau utilisé par les exercices
        int[] tableau = { 45, 12, 33, 66, 99, 33, 55, 4, 5, 78, 23, 45, 9, 41 };

        // Variable globale (1 dimension) : le tableau généré par GenererTableauAleatoire (vide au départ)
        int[] tableauAleatoire = new int[0];

        // Générateur de nombres aléatoires (à utiliser pour l'exercice « Aléatoire »)
        Random generateur = new Random();

        // Variable globale (2 dimensions) : les notes des étudiants
        // Chaque ligne = un étudiant, chaque colonne = un exercice (même pondération)
        decimal[,] notes = { { 77, 88, 99 }, { 85, 75, 49 }, { 94, 92, 88 }, { 75, 84, 85 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableauTextBox.Text = ConvertirTableau1DEnTexte(tableau);
            notesTextBox.Text = ConvertirNotesEnTexte(notes);
            noEtudiantLabel.Text = "No (1 à " + notes.GetLength(0) + ") :";
        }

        // ################################################################
        //  ONGLET 1 : TABLEAUX À 1 DIMENSION
        // ################################################################

        // Transforme un tableau en texte. Chaque valeur occupe 5 caractères
        // pour que les colonnes soient bien alignées.
        string ConvertirTableau1DEnTexte(int[] tableau)
        {
            string texte = "";
            for (int noCase = 0; noCase < tableau.GetLength(0); noCase++)
            {
                int valeur = tableau[noCase];
                texte += valeur.ToString().PadLeft(5);
            }
            return texte;
        }

        // Retourne la ligne des indices (0, 1, 2, ...) alignée de la même façon
        // que ConvertirEnTexte.
        string ConvertirIndicesEnTexte(int nbCases)
        {
            string texte = "";
            for (int indice = 0; indice < nbCases; indice++)
            {
                texte += indice.ToString().PadLeft(5);
            }
            return texte;
        }

        private void inverserButton_Click(object sender, EventArgs e)
        {
            // Appelez votre fonction InverserTableau ici et affichez le tableau inversé dans tableauTextBox
            // Utilisez ConvertirTableau1DEnTexte pour convertir le tableau cumulatif en texte
        }

        private void chercherButton_Click(object sender, EventArgs e)
        {
            int valeur;
            if (!int.TryParse(valeurTextBox.Text, out valeur))
            {
                MessageBox.Show("Veuillez entrer un nombre entier valide.", "Valeur invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valeurTextBox.Focus();
            }
            else
            {
                // Appelez votre fonction ChercherValeur ici et affichez le résultat dans resultatRechercheLabel
            }
        }

        private void cumulatifButton_Click(object sender, EventArgs e)
        {
            // Appelez votre fonction CreerTableauCumulatif ici et affichez le tableau cumulatif dans cumulatifTextBox
            // Utilisez ConvertirTableau1DEnTexte pour convertir le tableau cumulatif en texte

        }

        private void genererAleatoireButton_Click(object sender, EventArgs e)
        {
            // Appelez votre fonction GenererTableauAleatoire ici, conservez le résultat dans tableauAleatoire
            // et affichez le tableau généré dans aleatoireTextBox
            // Utilisez ConvertirTableau1DEnTexte pour convertir le tableau en texte

            manquantLabel.Text = "";
        }

        private void trouverManquantButton_Click(object sender, EventArgs e)
        {
            if (tableauAleatoire.GetLength(0) == 0)
            {
                MessageBox.Show("Veuillez d'abord générer un tableau aléatoire.", "Aucun tableau",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                genererAleatoireButton.Focus();
            }
            else
            {
                // Appelez votre fonction TrouverNombreManquant ici et affichez le résultat dans manquantLabel
            }
        }

        private void compterChiffresButton_Click(object sender, EventArgs e)
        {
            string texte = texteTextBox.Text;
            // Remplacez la valeur tableau par ce qui est retourné par votre fonction CompterOccurrencesChiffres
            int[] occurences = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            occurrencesTextBox.Text = ConvertirIndicesEnTexte(10) + Environment.NewLine + ConvertirTableau1DEnTexte(occurences);
        }

        // ################################################################
        //  ONGLET 2 : TABLEAUX À 2 DIMENSIONS
        // ################################################################

        // Transforme un tableau à 2 dimensions en texte (une ligne du tableau par ligne de texte).
        // Chaque valeur occupe 5 caractères pour que les colonnes soient bien alignées.
        string ConvertirTableau2DEnTexte(decimal[,] tableau)
        {
            string texte = "";
            for (int ligne = 0; ligne < tableau.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < tableau.GetLength(1); colonne++)
                {
                    texte += tableau[ligne, colonne].ToString().PadLeft(5);
                }
                texte += Environment.NewLine;
            }
            return texte;
        }

        // Transforme le tableau des notes en texte, avec un en-tête et le numéro de chaque étudiant
        string ConvertirNotesEnTexte(decimal[,] notes)
        {
            string texte = "Étudiant".PadRight(10);
            for (int colonne = 0; colonne < notes.GetLength(1); colonne++)
            {
                texte += ("Ex " + (colonne + 1)).PadLeft(7);
            }
            texte += Environment.NewLine;

            for (int ligne = 0; ligne < notes.GetLength(0); ligne++)
            {
                texte += (ligne + 1).ToString().PadRight(10);
                for (int colonne = 0; colonne < notes.GetLength(1); colonne++)
                {
                    texte += notes[ligne, colonne].ToString().PadLeft(7);
                }
                texte += Environment.NewLine;
            }
            return texte;
        }

        // Affiche un message d'erreur et remet le focus sur la zone de texte fautive
        void AfficherErreur(string message, TextBox zoneTexte)
        {
            MessageBox.Show(message, "Valeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            zoneTexte.Focus();
        }

        private void moyenneButton_Click(object sender, EventArgs e)
        {
            int nbEtudiants = notes.GetLength(0);
            int noEtudiant;
            if (!int.TryParse(noEtudiantTextBox.Text, out noEtudiant) || noEtudiant < 1 || noEtudiant > nbEtudiants)
            {
                AfficherErreur("Veuillez entrer un numéro d'étudiant entre 1 et " + nbEtudiants + ".", noEtudiantTextBox);
            }
            else
            {
                int ligne = noEtudiant - 1; // L'étudiant no 1 est à la ligne 0
                // Appelez votre fonction CalculerMoyenne ici et affichez le résultat dans moyenneLabel

            }
        }

        private void compterEtudiantsButton_Click(object sender, EventArgs e)
        {
            decimal note;
            if (!decimal.TryParse(seuilTextBox.Text, out note))
            {
                AfficherErreur("Veuillez entrer une note valide.", seuilTextBox);
            }
            else
            {
                // Appelez votre fonction CompterEtudiantsEnHautOuEgal ici et affichez le résultat dans nbEtudiantsLabel

            }
        }

        private void meilleureButton_Click(object sender, EventArgs e)
        {
            // Appelez votre fonction TrouverMeilleureNote ici et affichez le résultat dans meilleureLabel
        }

        private void diagonalesButton_Click(object sender, EventArgs e)
        {
            decimal[,] tableau = { { 2, -4, 3, 5 }, { 6, 5, 3, 1 }, { 8, 7, 3, 5 }, { 1, 3, 7, -3 } };
            avantTextBox.Text = ConvertirTableau2DEnTexte(tableau);
            // Appelez votre fonction MettreDiagonalesA0 ici

            apresTextBox.Text = ConvertirTableau2DEnTexte(tableau);
        }
    }
}
