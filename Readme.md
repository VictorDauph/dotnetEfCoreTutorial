tuto: https://www.youtube.com/watch?v=FGsXzIgFgJg&ab_channel=NehanthWorld

Pour configurer la synchro à la BDD, dans la console du package manager (nuget)

Scaffold-DbContext "Data Source=MACBOOLPORTABLE;Initial Catalog=dotnetEFcoreDBFirstTutorial;Integrated Security=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

La string entre "" est la connection string propre à la database que l'on veut utiliser. On la retrouve dans le fichier DotnetEfcoreDbfirstTutorialContext généré automatiquement dans le dossier models
Cette commande va générer des modèles à partir des tables présentes dans la base de données.

En l'état, l'application n'est pas code first