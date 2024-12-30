
Ce projet vous permet de simuler le plateau de la coupe robotique 2025. Il est possible de déplacer le robot sur le plateau et de le faire interagir avec les éléments du plateau.

## Prise en main

Certaines de ces installations peuvent prendre du temps.

- Installer **Unity Hub** et créer un compte Unity gratuit
- Ouvrir le projet dans Unity Hub. Cliquer sur "Add" et sélectionner le dossier du projet.
- Installer la version de **Unity** dédiée au projet lorsque demandé

![completed install](docs/complete-install.png)

## Utilisation

- Dans Unity, appuyer sur Ctrl+B pour lancer la simulation
- Utiliser les flèches directionnelles pour déplacer les robots ou connecter une manette de jeu

![le robot en action](docs/en-action.png)

## Builder pour Android

Pour générer un APK pour Android, il faut installer le module Android dans la configuration Build de Unity.

## Importer votre robot ou vos PAMIs

### Depuis Studio

- Dans Studio, exporter votre robot ou vos PAMIs en format Collada (.dae)
- Dans Unity, faites un glisser-déposer du .dae dans le dossier `Assets/Models`
- Dans Unity, faites un glisser-déposer du .dae dans la scène
- Faire bouton droit de la souris sur le prefab et faire "unpack prefab"

![unpack prefab](docs/unpack-prefab.png)

- Faire glisser déposer du robot/PAMI dans la scène racine
- A ce stade, vous pouvez supprimer le prefab



