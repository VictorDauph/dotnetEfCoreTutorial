tuto: https://www.youtube.com/watch?v=FGsXzIgFgJg&ab_channel=NehanthWorld

Pour configurer la synchro � la BDD, dans la console du package manager (nuget)

Scaffold-DbContext "Data Source=MACBOOLPORTABLE;Initial Catalog=dotnetEFcoreDBFirstTutorial;Integrated Security=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

La string entre "" est la connection string propre � la database que l'on veut utiliser. On la retrouve dans le fichier DotnetEfcoreDbfirstTutorialContext g�n�r� automatiquement dans le dossier models
Cette commande va g�n�rer des mod�les � partir des tables pr�sentes dans la base de donn�es.

En l'�tat, l'application n'est pas code first