# Comment contribuer au projet ?

**Une issue = un assigné = une branche = une pull request = un reviewer**

Voici le principe général afin de contribuer au projet de la manière la plus
simple pour tout le monde en évitant le maximum de chevauchement lors du
développement.

## Choisir une issue

Allez dans la page du milestone courant puis parcourir la liste des issues dans
le backlog.

Lorsque vous avez choisi (regardez quand même la priorité avec les personnes
responsables du projet).

## Faire une branche

Pour chaque issue, il est nécessaire de faire une branche spécifique cela permet
d'éviter d'éventuels conflits et de potentiels bugs faussement induits.

La branche devrait être nommé dans le style de `fb-documentation-dev`.

Faites cette opération en local sur votre ordinateur grâce à la commande 
`git checkout -b "fb-…"`.

## Faire le premier commit

Vous avez une première avancée ? 

Commitez alors vos fichier (il peut être pratique d'adapter le fichier
`.gitignore`).

## Créer la pull request 

Depuis l'interface du site GitHub, créez une Pull Request nommée `[WIP] …`
dans l'issue vous pouvez alors lié la pull request à l'issue.

## Lors du développement

Sur la pull request vous pouvez poser des questions etc…

Oubliez pas de commiter après votre travail en cas de problème avec votre
ordinateur.

## Finis ? 

Vous pensez en avoir finis ? 

Alors éditer le nom de la Pull Request en `[TOREVIEW] …` passé l'issue dans le
tableau du projet dans la colonne "To review".

Ajoutez un reviewer

## Review

Le reviewer doit contrôler les points suivants :

* Compilation du projet toujours fonctionnelle,
* Les éventuels tests unitaires passent toujours,
* Tester l'application et plus particulièrement la fonctionnalité de manière
  approfondie,
* Review du code afin d'éviter des erreurs potentielles, ou proposer des
  améliorations du code,
* Erreurs d'orthographe.

Si cela est bon alors :

* passer l'issue dans "done",
* merger la pull request,
* supprimer la branche.

Sinon alors

* expliquer ce qui ne va pas et passer l'issue dans la colonne "Reviewer asked
  changes"

## Et les bug-fixes ?

Les petits patchs sont tolérés sur la branche main, il est toujours nécessaire
d'avertir néanmoins que l'on travail dessus. Une issue avec le tag "bug" est
alors simple et rapide à utiliser
