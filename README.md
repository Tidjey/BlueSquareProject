# BlueSquareProject
--------------------
## Pré-requis de Développement sur poste Windows
--------------------
1) avoir Visual Studio Community installé
2) avoir le framework .NET 6 Runtime et SDK installé sur le poste de travail
--------------------
## Initialisation du projet :
--------------------
1) Ouvrir une console PowerShell à la racine dans le dossier BlueSquareBugTracker
2) executer la commandes suivantes
''
dotnet ef update database
''
--------------------
## Debug et Développement:
--------------------
1) ouvrir le fichier BlueSquareBugTracker.sln avec Visual Studio Community
2) dans l'explorateur de solution, faire un click droit sur la Solution pour ouvrir le menu contextuel
3) dans le menu contextuel, cliquer sur "Restaurer les packages NuGet"
4) laisser Visual Studio télécharger les dépendances
5) Dans la barre d'outil, cliquer sur le démarrage du programme (L'icone play suivi du nom de l'application)
