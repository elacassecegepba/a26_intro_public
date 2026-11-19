namespace RevisionTableaux
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ongletsTabControl = new TabControl();
            page1DimensionTabPage = new TabPage();
            tableauLabel = new Label();
            tableauTextBox = new TextBox();
            inverserGroupBox = new GroupBox();
            inverserButton = new Button();
            chercherGroupBox = new GroupBox();
            valeurLabel = new Label();
            valeurTextBox = new TextBox();
            chercherButton = new Button();
            resultatRechercheLabel = new Label();
            cumulatifGroupBox = new GroupBox();
            cumulatifButton = new Button();
            cumulatifTextBox = new TextBox();
            aleatoireGroupBox = new GroupBox();
            genererAleatoireButton = new Button();
            aleatoireTextBox = new TextBox();
            manquantGroupBox = new GroupBox();
            trouverManquantButton = new Button();
            manquantLabel = new Label();
            compterChiffresGroupBox = new GroupBox();
            texteLabel = new Label();
            texteTextBox = new TextBox();
            compterChiffresButton = new Button();
            occurrencesTextBox = new TextBox();
            page2DimensionsTabPage = new TabPage();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            moyenneGroupBox = new GroupBox();
            noEtudiantLabel = new Label();
            noEtudiantTextBox = new TextBox();
            moyenneButton = new Button();
            moyenneLabel = new Label();
            compterEtudiantsGroupBox = new GroupBox();
            seuilLabel = new Label();
            seuilTextBox = new TextBox();
            compterEtudiantsButton = new Button();
            nbEtudiantsLabel = new Label();
            meilleureGroupBox = new GroupBox();
            meilleureButton = new Button();
            meilleureLabel = new Label();
            diagonalesGroupBox = new GroupBox();
            diagonalesButton = new Button();
            avantLabel = new Label();
            avantTextBox = new TextBox();
            apresLabel = new Label();
            apresTextBox = new TextBox();
            ongletsTabControl.SuspendLayout();
            page1DimensionTabPage.SuspendLayout();
            inverserGroupBox.SuspendLayout();
            chercherGroupBox.SuspendLayout();
            cumulatifGroupBox.SuspendLayout();
            aleatoireGroupBox.SuspendLayout();
            manquantGroupBox.SuspendLayout();
            compterChiffresGroupBox.SuspendLayout();
            page2DimensionsTabPage.SuspendLayout();
            moyenneGroupBox.SuspendLayout();
            compterEtudiantsGroupBox.SuspendLayout();
            meilleureGroupBox.SuspendLayout();
            diagonalesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ongletsTabControl
            // 
            ongletsTabControl.Controls.Add(page1DimensionTabPage);
            ongletsTabControl.Controls.Add(page2DimensionsTabPage);
            ongletsTabControl.Location = new Point(12, 12);
            ongletsTabControl.Name = "ongletsTabControl";
            ongletsTabControl.SelectedIndex = 0;
            ongletsTabControl.Size = new Size(680, 649);
            ongletsTabControl.TabIndex = 0;
            // 
            // page1DimensionTabPage
            // 
            page1DimensionTabPage.Controls.Add(tableauLabel);
            page1DimensionTabPage.Controls.Add(tableauTextBox);
            page1DimensionTabPage.Controls.Add(inverserGroupBox);
            page1DimensionTabPage.Controls.Add(chercherGroupBox);
            page1DimensionTabPage.Controls.Add(cumulatifGroupBox);
            page1DimensionTabPage.Controls.Add(aleatoireGroupBox);
            page1DimensionTabPage.Controls.Add(manquantGroupBox);
            page1DimensionTabPage.Controls.Add(compterChiffresGroupBox);
            page1DimensionTabPage.Location = new Point(4, 24);
            page1DimensionTabPage.Name = "page1DimensionTabPage";
            page1DimensionTabPage.Padding = new Padding(3);
            page1DimensionTabPage.Size = new Size(672, 621);
            page1DimensionTabPage.TabIndex = 0;
            page1DimensionTabPage.Text = "Tableaux à 1 dimension";
            page1DimensionTabPage.UseVisualStyleBackColor = true;
            // 
            // tableauLabel
            // 
            tableauLabel.AutoSize = true;
            tableauLabel.Location = new Point(12, 12);
            tableauLabel.Name = "tableauLabel";
            tableauLabel.Size = new Size(54, 15);
            tableauLabel.TabIndex = 0;
            tableauLabel.Text = "Tableau :";
            // 
            // tableauTextBox
            // 
            tableauTextBox.Font = new Font("Consolas", 10F);
            tableauTextBox.Location = new Point(12, 32);
            tableauTextBox.Name = "tableauTextBox";
            tableauTextBox.ReadOnly = true;
            tableauTextBox.Size = new Size(600, 23);
            tableauTextBox.TabIndex = 1;
            tableauTextBox.TabStop = false;
            tableauTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // inverserGroupBox
            // 
            inverserGroupBox.Controls.Add(inverserButton);
            inverserGroupBox.Location = new Point(12, 68);
            inverserGroupBox.Name = "inverserGroupBox";
            inverserGroupBox.Size = new Size(290, 95);
            inverserGroupBox.TabIndex = 2;
            inverserGroupBox.TabStop = false;
            inverserGroupBox.Text = "Inversion";
            // 
            // inverserButton
            // 
            inverserButton.Location = new Point(15, 35);
            inverserButton.Name = "inverserButton";
            inverserButton.Size = new Size(260, 30);
            inverserButton.TabIndex = 0;
            inverserButton.Text = "Inverser le tableau";
            inverserButton.UseVisualStyleBackColor = true;
            inverserButton.Click += inverserButton_Click;
            // 
            // chercherGroupBox
            // 
            chercherGroupBox.Controls.Add(valeurLabel);
            chercherGroupBox.Controls.Add(valeurTextBox);
            chercherGroupBox.Controls.Add(chercherButton);
            chercherGroupBox.Controls.Add(resultatRechercheLabel);
            chercherGroupBox.Location = new Point(322, 68);
            chercherGroupBox.Name = "chercherGroupBox";
            chercherGroupBox.Size = new Size(290, 95);
            chercherGroupBox.TabIndex = 3;
            chercherGroupBox.TabStop = false;
            chercherGroupBox.Text = "Recherche";
            // 
            // valeurLabel
            // 
            valeurLabel.AutoSize = true;
            valeurLabel.Location = new Point(15, 30);
            valeurLabel.Name = "valeurLabel";
            valeurLabel.Size = new Size(45, 15);
            valeurLabel.TabIndex = 0;
            valeurLabel.Text = "Valeur :";
            // 
            // valeurTextBox
            // 
            valeurTextBox.Location = new Point(80, 27);
            valeurTextBox.Name = "valeurTextBox";
            valeurTextBox.Size = new Size(80, 23);
            valeurTextBox.TabIndex = 1;
            // 
            // chercherButton
            // 
            chercherButton.Location = new Point(170, 26);
            chercherButton.Name = "chercherButton";
            chercherButton.Size = new Size(105, 25);
            chercherButton.TabIndex = 2;
            chercherButton.Text = "Chercher";
            chercherButton.UseVisualStyleBackColor = true;
            chercherButton.Click += chercherButton_Click;
            // 
            // resultatRechercheLabel
            // 
            resultatRechercheLabel.AutoSize = true;
            resultatRechercheLabel.Location = new Point(15, 63);
            resultatRechercheLabel.Name = "resultatRechercheLabel";
            resultatRechercheLabel.Size = new Size(0, 15);
            resultatRechercheLabel.TabIndex = 3;
            // 
            // cumulatifGroupBox
            // 
            cumulatifGroupBox.Controls.Add(cumulatifButton);
            cumulatifGroupBox.Controls.Add(cumulatifTextBox);
            cumulatifGroupBox.Location = new Point(12, 175);
            cumulatifGroupBox.Name = "cumulatifGroupBox";
            cumulatifGroupBox.Size = new Size(600, 95);
            cumulatifGroupBox.TabIndex = 4;
            cumulatifGroupBox.TabStop = false;
            cumulatifGroupBox.Text = "Somme cumulative";
            // 
            // cumulatifButton
            // 
            cumulatifButton.Location = new Point(15, 25);
            cumulatifButton.Name = "cumulatifButton";
            cumulatifButton.Size = new Size(200, 27);
            cumulatifButton.TabIndex = 0;
            cumulatifButton.Text = "Créer le tableau cumulatif";
            cumulatifButton.UseVisualStyleBackColor = true;
            cumulatifButton.Click += cumulatifButton_Click;
            // 
            // cumulatifTextBox
            // 
            cumulatifTextBox.Font = new Font("Consolas", 10F);
            cumulatifTextBox.Location = new Point(15, 58);
            cumulatifTextBox.Name = "cumulatifTextBox";
            cumulatifTextBox.ReadOnly = true;
            cumulatifTextBox.Size = new Size(570, 23);
            cumulatifTextBox.TabIndex = 1;
            cumulatifTextBox.TabStop = false;
            cumulatifTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // aleatoireGroupBox
            // 
            aleatoireGroupBox.Controls.Add(genererAleatoireButton);
            aleatoireGroupBox.Controls.Add(aleatoireTextBox);
            aleatoireGroupBox.Location = new Point(12, 282);
            aleatoireGroupBox.Name = "aleatoireGroupBox";
            aleatoireGroupBox.Size = new Size(600, 95);
            aleatoireGroupBox.TabIndex = 5;
            aleatoireGroupBox.TabStop = false;
            aleatoireGroupBox.Text = "Aléatoire";
            // 
            // genererAleatoireButton
            // 
            genererAleatoireButton.Location = new Point(15, 25);
            genererAleatoireButton.Name = "genererAleatoireButton";
            genererAleatoireButton.Size = new Size(200, 27);
            genererAleatoireButton.TabIndex = 0;
            genererAleatoireButton.Text = "Générer un tableau aléatoire";
            genererAleatoireButton.UseVisualStyleBackColor = true;
            genererAleatoireButton.Click += genererAleatoireButton_Click;
            // 
            // aleatoireTextBox
            // 
            aleatoireTextBox.Font = new Font("Consolas", 10F);
            aleatoireTextBox.Location = new Point(15, 58);
            aleatoireTextBox.Name = "aleatoireTextBox";
            aleatoireTextBox.ReadOnly = true;
            aleatoireTextBox.Size = new Size(570, 23);
            aleatoireTextBox.TabIndex = 1;
            aleatoireTextBox.TabStop = false;
            aleatoireTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // manquantGroupBox
            // 
            manquantGroupBox.Controls.Add(trouverManquantButton);
            manquantGroupBox.Controls.Add(manquantLabel);
            manquantGroupBox.Location = new Point(12, 389);
            manquantGroupBox.Name = "manquantGroupBox";
            manquantGroupBox.Size = new Size(600, 70);
            manquantGroupBox.TabIndex = 6;
            manquantGroupBox.TabStop = false;
            manquantGroupBox.Text = "Manquant";
            // 
            // trouverManquantButton
            // 
            trouverManquantButton.Location = new Point(15, 25);
            trouverManquantButton.Name = "trouverManquantButton";
            trouverManquantButton.Size = new Size(200, 27);
            trouverManquantButton.TabIndex = 0;
            trouverManquantButton.Text = "Trouver le nombre manquant";
            trouverManquantButton.UseVisualStyleBackColor = true;
            trouverManquantButton.Click += trouverManquantButton_Click;
            // 
            // manquantLabel
            // 
            manquantLabel.AutoSize = true;
            manquantLabel.Location = new Point(230, 31);
            manquantLabel.Name = "manquantLabel";
            manquantLabel.Size = new Size(0, 15);
            manquantLabel.TabIndex = 1;
            // 
            // compterChiffresGroupBox
            // 
            compterChiffresGroupBox.Controls.Add(texteLabel);
            compterChiffresGroupBox.Controls.Add(texteTextBox);
            compterChiffresGroupBox.Controls.Add(compterChiffresButton);
            compterChiffresGroupBox.Controls.Add(occurrencesTextBox);
            compterChiffresGroupBox.Location = new Point(12, 471);
            compterChiffresGroupBox.Name = "compterChiffresGroupBox";
            compterChiffresGroupBox.Size = new Size(600, 130);
            compterChiffresGroupBox.TabIndex = 7;
            compterChiffresGroupBox.TabStop = false;
            compterChiffresGroupBox.Text = "Occurrences des chiffres";
            // 
            // texteLabel
            // 
            texteLabel.AutoSize = true;
            texteLabel.Location = new Point(15, 30);
            texteLabel.Name = "texteLabel";
            texteLabel.Size = new Size(40, 15);
            texteLabel.TabIndex = 0;
            texteLabel.Text = "Texte :";
            // 
            // texteTextBox
            // 
            texteTextBox.Location = new Point(80, 27);
            texteTextBox.Name = "texteTextBox";
            texteTextBox.Size = new Size(300, 23);
            texteTextBox.TabIndex = 1;
            texteTextBox.Text = "542a783b0er8921k1";
            // 
            // compterChiffresButton
            // 
            compterChiffresButton.Location = new Point(395, 26);
            compterChiffresButton.Name = "compterChiffresButton";
            compterChiffresButton.Size = new Size(190, 25);
            compterChiffresButton.TabIndex = 2;
            compterChiffresButton.Text = "Compter les chiffres";
            compterChiffresButton.UseVisualStyleBackColor = true;
            compterChiffresButton.Click += compterChiffresButton_Click;
            // 
            // occurrencesTextBox
            // 
            occurrencesTextBox.Font = new Font("Consolas", 10F);
            occurrencesTextBox.Location = new Point(15, 62);
            occurrencesTextBox.Multiline = true;
            occurrencesTextBox.Name = "occurrencesTextBox";
            occurrencesTextBox.ReadOnly = true;
            occurrencesTextBox.Size = new Size(570, 50);
            occurrencesTextBox.TabIndex = 3;
            occurrencesTextBox.TabStop = false;
            occurrencesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // page2DimensionsTabPage
            // 
            page2DimensionsTabPage.Controls.Add(notesLabel);
            page2DimensionsTabPage.Controls.Add(notesTextBox);
            page2DimensionsTabPage.Controls.Add(moyenneGroupBox);
            page2DimensionsTabPage.Controls.Add(compterEtudiantsGroupBox);
            page2DimensionsTabPage.Controls.Add(meilleureGroupBox);
            page2DimensionsTabPage.Controls.Add(diagonalesGroupBox);
            page2DimensionsTabPage.Location = new Point(4, 24);
            page2DimensionsTabPage.Name = "page2DimensionsTabPage";
            page2DimensionsTabPage.Padding = new Padding(3);
            page2DimensionsTabPage.Size = new Size(672, 621);
            page2DimensionsTabPage.TabIndex = 1;
            page2DimensionsTabPage.Text = "Tableaux à 2 dimensions";
            page2DimensionsTabPage.UseVisualStyleBackColor = true;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(12, 12);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(117, 15);
            notesLabel.TabIndex = 0;
            notesLabel.Text = "Notes des étudiants :";
            // 
            // notesTextBox
            // 
            notesTextBox.Font = new Font("Consolas", 10F);
            notesTextBox.Location = new Point(12, 32);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.ReadOnly = true;
            notesTextBox.ScrollBars = ScrollBars.Vertical;
            notesTextBox.Size = new Size(360, 105);
            notesTextBox.TabIndex = 1;
            notesTextBox.TabStop = false;
            // 
            // moyenneGroupBox
            // 
            moyenneGroupBox.Controls.Add(noEtudiantLabel);
            moyenneGroupBox.Controls.Add(noEtudiantTextBox);
            moyenneGroupBox.Controls.Add(moyenneButton);
            moyenneGroupBox.Controls.Add(moyenneLabel);
            moyenneGroupBox.Location = new Point(12, 145);
            moyenneGroupBox.Name = "moyenneGroupBox";
            moyenneGroupBox.Size = new Size(360, 80);
            moyenneGroupBox.TabIndex = 2;
            moyenneGroupBox.TabStop = false;
            moyenneGroupBox.Text = "Moyenne d'un étudiant";
            // 
            // noEtudiantLabel
            // 
            noEtudiantLabel.AutoSize = true;
            noEtudiantLabel.Location = new Point(10, 25);
            noEtudiantLabel.Name = "noEtudiantLabel";
            noEtudiantLabel.Size = new Size(86, 15);
            noEtudiantLabel.TabIndex = 0;
            noEtudiantLabel.Text = "No d'étudiant :";
            // 
            // noEtudiantTextBox
            // 
            noEtudiantTextBox.Location = new Point(120, 22);
            noEtudiantTextBox.Name = "noEtudiantTextBox";
            noEtudiantTextBox.Size = new Size(60, 23);
            noEtudiantTextBox.TabIndex = 1;
            // 
            // moyenneButton
            // 
            moyenneButton.Location = new Point(190, 21);
            moyenneButton.Name = "moyenneButton";
            moyenneButton.Size = new Size(160, 25);
            moyenneButton.TabIndex = 2;
            moyenneButton.Text = "Calculer la moyenne";
            moyenneButton.UseVisualStyleBackColor = true;
            moyenneButton.Click += moyenneButton_Click;
            // 
            // moyenneLabel
            // 
            moyenneLabel.AutoSize = true;
            moyenneLabel.Location = new Point(10, 54);
            moyenneLabel.Name = "moyenneLabel";
            moyenneLabel.Size = new Size(0, 15);
            moyenneLabel.TabIndex = 3;
            // 
            // compterEtudiantsGroupBox
            // 
            compterEtudiantsGroupBox.Controls.Add(seuilLabel);
            compterEtudiantsGroupBox.Controls.Add(seuilTextBox);
            compterEtudiantsGroupBox.Controls.Add(compterEtudiantsButton);
            compterEtudiantsGroupBox.Controls.Add(nbEtudiantsLabel);
            compterEtudiantsGroupBox.Location = new Point(12, 233);
            compterEtudiantsGroupBox.Name = "compterEtudiantsGroupBox";
            compterEtudiantsGroupBox.Size = new Size(360, 80);
            compterEtudiantsGroupBox.TabIndex = 3;
            compterEtudiantsGroupBox.TabStop = false;
            compterEtudiantsGroupBox.Text = "Compte des étudiants (moyenne ≥ note)";
            // 
            // seuilLabel
            // 
            seuilLabel.AutoSize = true;
            seuilLabel.Location = new Point(10, 25);
            seuilLabel.Name = "seuilLabel";
            seuilLabel.Size = new Size(39, 15);
            seuilLabel.TabIndex = 0;
            seuilLabel.Text = "Note :";
            // 
            // seuilTextBox
            // 
            seuilTextBox.Location = new Point(120, 22);
            seuilTextBox.Name = "seuilTextBox";
            seuilTextBox.Size = new Size(60, 23);
            seuilTextBox.TabIndex = 1;
            // 
            // compterEtudiantsButton
            // 
            compterEtudiantsButton.Location = new Point(190, 21);
            compterEtudiantsButton.Name = "compterEtudiantsButton";
            compterEtudiantsButton.Size = new Size(160, 25);
            compterEtudiantsButton.TabIndex = 2;
            compterEtudiantsButton.Text = "Compter les étudiants";
            compterEtudiantsButton.UseVisualStyleBackColor = true;
            compterEtudiantsButton.Click += compterEtudiantsButton_Click;
            // 
            // nbEtudiantsLabel
            // 
            nbEtudiantsLabel.AutoSize = true;
            nbEtudiantsLabel.Location = new Point(10, 54);
            nbEtudiantsLabel.Name = "nbEtudiantsLabel";
            nbEtudiantsLabel.Size = new Size(0, 15);
            nbEtudiantsLabel.TabIndex = 3;
            // 
            // meilleureGroupBox
            // 
            meilleureGroupBox.Controls.Add(meilleureButton);
            meilleureGroupBox.Controls.Add(meilleureLabel);
            meilleureGroupBox.Location = new Point(12, 321);
            meilleureGroupBox.Name = "meilleureGroupBox";
            meilleureGroupBox.Size = new Size(360, 60);
            meilleureGroupBox.TabIndex = 4;
            meilleureGroupBox.TabStop = false;
            meilleureGroupBox.Text = "Meilleure note";
            // 
            // meilleureButton
            // 
            meilleureButton.Location = new Point(10, 21);
            meilleureButton.Name = "meilleureButton";
            meilleureButton.Size = new Size(170, 25);
            meilleureButton.TabIndex = 0;
            meilleureButton.Text = "Trouver la meilleure note";
            meilleureButton.UseVisualStyleBackColor = true;
            meilleureButton.Click += meilleureButton_Click;
            // 
            // meilleureLabel
            // 
            meilleureLabel.AutoSize = true;
            meilleureLabel.Location = new Point(190, 26);
            meilleureLabel.Name = "meilleureLabel";
            meilleureLabel.Size = new Size(0, 15);
            meilleureLabel.TabIndex = 1;
            // 
            // diagonalesGroupBox
            // 
            diagonalesGroupBox.Controls.Add(diagonalesButton);
            diagonalesGroupBox.Controls.Add(avantLabel);
            diagonalesGroupBox.Controls.Add(avantTextBox);
            diagonalesGroupBox.Controls.Add(apresLabel);
            diagonalesGroupBox.Controls.Add(apresTextBox);
            diagonalesGroupBox.Location = new Point(384, 12);
            diagonalesGroupBox.Name = "diagonalesGroupBox";
            diagonalesGroupBox.Size = new Size(260, 369);
            diagonalesGroupBox.TabIndex = 5;
            diagonalesGroupBox.TabStop = false;
            diagonalesGroupBox.Text = "Diagonales";
            // 
            // diagonalesButton
            // 
            diagonalesButton.Location = new Point(10, 22);
            diagonalesButton.Name = "diagonalesButton";
            diagonalesButton.Size = new Size(240, 27);
            diagonalesButton.TabIndex = 0;
            diagonalesButton.Text = "Mettre les diagonales à 0";
            diagonalesButton.UseVisualStyleBackColor = true;
            diagonalesButton.Click += diagonalesButton_Click;
            // 
            // avantLabel
            // 
            avantLabel.AutoSize = true;
            avantLabel.Location = new Point(10, 60);
            avantLabel.Name = "avantLabel";
            avantLabel.Size = new Size(44, 15);
            avantLabel.TabIndex = 1;
            avantLabel.Text = "Avant :";
            // 
            // avantTextBox
            // 
            avantTextBox.Font = new Font("Consolas", 10F);
            avantTextBox.Location = new Point(10, 80);
            avantTextBox.Multiline = true;
            avantTextBox.Name = "avantTextBox";
            avantTextBox.ReadOnly = true;
            avantTextBox.Size = new Size(240, 120);
            avantTextBox.TabIndex = 2;
            avantTextBox.TabStop = false;
            // 
            // apresLabel
            // 
            apresLabel.AutoSize = true;
            apresLabel.Location = new Point(10, 210);
            apresLabel.Name = "apresLabel";
            apresLabel.Size = new Size(43, 15);
            apresLabel.TabIndex = 3;
            apresLabel.Text = "Après :";
            // 
            // apresTextBox
            // 
            apresTextBox.Font = new Font("Consolas", 10F);
            apresTextBox.Location = new Point(10, 230);
            apresTextBox.Multiline = true;
            apresTextBox.Name = "apresTextBox";
            apresTextBox.ReadOnly = true;
            apresTextBox.Size = new Size(240, 120);
            apresTextBox.TabIndex = 4;
            apresTextBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 673);
            Controls.Add(ongletsTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Révision - Tableaux";
            Load += Form1_Load;
            ongletsTabControl.ResumeLayout(false);
            page1DimensionTabPage.ResumeLayout(false);
            page1DimensionTabPage.PerformLayout();
            inverserGroupBox.ResumeLayout(false);
            chercherGroupBox.ResumeLayout(false);
            chercherGroupBox.PerformLayout();
            cumulatifGroupBox.ResumeLayout(false);
            cumulatifGroupBox.PerformLayout();
            aleatoireGroupBox.ResumeLayout(false);
            aleatoireGroupBox.PerformLayout();
            manquantGroupBox.ResumeLayout(false);
            manquantGroupBox.PerformLayout();
            compterChiffresGroupBox.ResumeLayout(false);
            compterChiffresGroupBox.PerformLayout();
            page2DimensionsTabPage.ResumeLayout(false);
            page2DimensionsTabPage.PerformLayout();
            moyenneGroupBox.ResumeLayout(false);
            moyenneGroupBox.PerformLayout();
            compterEtudiantsGroupBox.ResumeLayout(false);
            compterEtudiantsGroupBox.PerformLayout();
            meilleureGroupBox.ResumeLayout(false);
            meilleureGroupBox.PerformLayout();
            diagonalesGroupBox.ResumeLayout(false);
            diagonalesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ongletsTabControl;
        private TabPage page1DimensionTabPage;
        private TabPage page2DimensionsTabPage;
        private Label tableauLabel;
        private TextBox tableauTextBox;
        private GroupBox inverserGroupBox;
        private Button inverserButton;
        private GroupBox chercherGroupBox;
        private Label valeurLabel;
        private TextBox valeurTextBox;
        private Button chercherButton;
        private Label resultatRechercheLabel;
        private GroupBox cumulatifGroupBox;
        private Button cumulatifButton;
        private TextBox cumulatifTextBox;
        private GroupBox aleatoireGroupBox;
        private Button genererAleatoireButton;
        private TextBox aleatoireTextBox;
        private GroupBox manquantGroupBox;
        private Button trouverManquantButton;
        private Label manquantLabel;
        private GroupBox compterChiffresGroupBox;
        private Label texteLabel;
        private TextBox texteTextBox;
        private Button compterChiffresButton;
        private TextBox occurrencesTextBox;
        private Label notesLabel;
        private TextBox notesTextBox;
        private GroupBox moyenneGroupBox;
        private Label noEtudiantLabel;
        private TextBox noEtudiantTextBox;
        private Button moyenneButton;
        private Label moyenneLabel;
        private GroupBox compterEtudiantsGroupBox;
        private Label seuilLabel;
        private TextBox seuilTextBox;
        private Button compterEtudiantsButton;
        private Label nbEtudiantsLabel;
        private GroupBox meilleureGroupBox;
        private Button meilleureButton;
        private Label meilleureLabel;
        private GroupBox diagonalesGroupBox;
        private Button diagonalesButton;
        private Label avantLabel;
        private TextBox avantTextBox;
        private Label apresLabel;
        private TextBox apresTextBox;
    }
}
