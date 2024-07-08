tuto: https://www.youtube.com/watch?v=FGsXzIgFgJg&ab_channel=NehanthWorld

Pour configurer la synchro à la BDD, dans la console du package manager (nuget)

------------
Scaffold-DbContext "Data Source=MACBOOLPORTABLE;Initial Catalog=dotnetEFcoreDBFirstTutorial;Integrated Security=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
----------------

La string entre "" est la connection string propre à la database que l'on veut utiliser. On la retrouve dans le fichier DotnetEfcoreDbfirstTutorialContext généré automatiquement dans le dossier models
Cette commande va générer des modèles à partir des tables présentes dans la base de données.

Pour repliqer la structure de la database

1) créer une migration à partir des modèles scaffoldés (et éventuellement modifiés dans leurs fichiers .cs)
------------------
add-migration [migration-name]
---------------------

2) importer la nouvelle structure dans la BDD
--------------------------
update-database
-------------------------


