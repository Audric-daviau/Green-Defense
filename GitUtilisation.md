# Git sous windows
Si vous utilisez un poste windows, vous devez d'abord télécharger "git bash" via le lien ci-dessous :
https://gitforwindows.org/

# Générer une clé ssh
Lancer git bash en le recherchant dans avec votre touche windows.
Afin de générer une clé ssh si vous n'en avez pas déjà une, vous devez entrer dans un terminal git les commandes suivantes :

```shell
ssh-keygen #appuyez trois fois sur entrer afin de ne pas modifier l'emplacement, ne pas mettre de mdp et confirmer ce choix
cat ~/your_name/.ssh/id_rsa.pub #en remplaçant your_name par votre nom d'utilisateur windows
```

Copier le contenu du fichier id_rsa.pub et coller le dans github. Pour cela rendez-vous dans l'onglet "SSH and GPG keys" qui se trouve dans en cliquant sur sa photo de profile->settings et à gauche chercher l'onglet en question. Puis fait "new SSH key".

# Cloner le répertoir du projet
Enfin, dans le terminal, entrez les commandes ci-dessous.
```shell
cd ton_emplacement # remplacer "ton_emplacement par l'emplacement où tu veux mettre le projet 
git clone git@github.com:maykeul27/Projet-EvalBot-Formula-1-EvalBoost-Edition.git
git pull
```

# Les commandes indispensable bases git
```shell
git branch ma_branche # avec "ma_branche" le nom de la branche où vous voulez aller
git add . # permet de prévenir qu'on va faire un ajout
git commit -m "message" # ajoute vos modification à git
git push # pousse vos modification dans git. 
git pull # récupérer les modifications des autres, met à jour le projet avec les dernières modifications
git reset --hard clé # Avec clé, la clé du commit auquel vous voulez revenir, git log pour obtenir la clé des précédents commits
```