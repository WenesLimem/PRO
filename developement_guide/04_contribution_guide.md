# Comment contribuer au projet ?

**Une issue = un assigné = une branche = une pull request = un reviewer**

Voici le principe général afin de contribuer au projet de la manière la plus simple pour tout le monde en evitant le maximum de chevauchement lors du développement.



## Choisir une issue

Allez dans la page du milestone courant puis parcourer la liste des issues dans le backlog.

Lorsque vous avez choisi (regarder quand même avec les personnes responsable du projet la priorité).



## Faire une branche

Pour chaque issue, il est necessaire de faire une branche spécifique cela permet d'éviter d'eventuel conflit et de potentiel bug faussement induits.

La branche devrait être nommé dans le style de `fb-documentation-dev`

Faite cette opération en local sur votre ordinateur grâce à la commande `git checkout -b "fb-...."`

## Faire le premier commit

Vous avez une première avancée ? 

Commitez alors vos fichier (il peut être pratique d'adapter le fichier `.gitignore`).

## Creer la pull request 

Depuis l'interface du site github, creez une pull request nommée `[WIP] .... ` dans l'issue vous pouvez alors lié la pull request à l'issue

## Lors du développement

Sur la pull request vous pouvez poser des questions etc...

Oubliez pas de commiter apres votre travail en cas de problème avec votre ordinateur.

## Finis ? 

Vous pensez en avoir finis ? 

Alors éditer le nom de la pull request en `[TOREVIEW] ....` passé l'issue dans le tableau du projet dans la colonne "To review"

Ajoutez un reviewer



## Review

Le reviewer doit contrôler les points suivants:

* Compilation du projet toujours fonctionnelle
* Les éventuels tests unitaire passe toujours
* Tester l'application et plus particulièrement la fonctionnalité de manière appronfondie
* Review du code afin d'éviter des erreurs potentielle, ou proposer des améliorations du code
* Erreur d'orthographes

Si cela est bon alors:

* passer l'issue dans "done" 
* merger la pull request
* supprimer la branche

Sinon alors

* expliquer ce qu'il ne va pas et passer l'issue dans la colonne "Reviewer asked changes"



## Et les bug-fixes ?

Les petits patch sont tolérés sur la branche main, il est toujours nécessaire d'avertir neanmoins que l'on travail dessus. Une issue avec le tag "bug" est alors simple et rapide à utiliser

