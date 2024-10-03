# Formes Géométriques en C#

Ce projet implémente plusieurs classes pour représenter des formes géométriques simples telles que des cercles et des rectangles, ainsi que des points dans un espace 2D. Le projet est structuré selon le paradigme de la programmation orientée objet avec des relations d'héritage et de polymorphisme. Les conventions de nommage en C# sont respectées, et le projet est compilable et exécutable sous .NET Framework.

### Explication :
- La section **Explication de l'Architecture .NET** détaille les composants principaux de la plateforme .NET tels que le **CLR**, le **BCL**, et le rôle de **C#** dans le projet.
- Elle explique aussi comment .NET gère des concepts tels que l'héritage et le polymorphisme, utilisés dans le projet.
- Enfin, elle liste les avantages d'utiliser la plateforme .NET, tels que la portabilité, la gestion automatique de la mémoire et l'interopérabilité.

Cela aide à comprendre non seulement la logique du projet, mais aussi pourquoi et comment .NET est utilisé pour implémenter les fonctionnalités.

## Structure du Projet

### Classes principales

- `Point.cs`
- `Forme.cs` (classe abstraite)
- `Cercle.cs` (hérite de `Forme`)
- `Rectangle.cs` (hérite de `Forme`)
- `Program.cs` (fichier principal pour tester les fonctionnalités)

## Détails des Classes et Fonctions

### 1. `Point.cs`

La classe `Point` représente un point dans un plan en 2 dimensions. Chaque point a deux propriétés :
- **x** : Coordonnée sur l'axe des abscisses (axe X).
- **y** : Coordonnée sur l'axe des ordonnées (axe Y).

#### Méthodes :
- **`Point()`** : Constructeur par défaut qui initialise un point à (0,0).
- **`Point(int x, int y)`** : Constructeur qui initialise le point avec des coordonnées spécifiques.
- **`Equals(object obj)`** : Redéfinie la méthode `Equals()` pour comparer deux objets de type `Point`. Elle vérifie si les deux points ont les mêmes coordonnées.
- **`ToString()`** : Redéfinie la méthode `ToString()` pour retourner une représentation textuelle des coordonnées du point sous la forme `(x,y)`.

### 2. `Forme.cs` (Classe abstraite)

`Forme` est une classe abstraite qui représente une forme géométrique quelconque. Elle sert de base pour les classes `Cercle` et `Rectangle`.

#### Propriétés :
- **`point`** : Un objet de la classe `Point` qui représente le centre ou une position de référence de la forme.

#### Méthodes abstraites :
- **`Perimetre()`** : Méthode abstraite qui doit être implémentée dans les classes dérivées pour calculer le périmètre de la forme.
- **`Aire()`** : Méthode abstraite qui doit être implémentée dans les classes dérivées pour calculer l'aire de la forme.

> Cette classe ne peut pas être instanciée directement. Elle sert de modèle pour d'autres formes géométriques comme les cercles et les rectangles.

### 3. `Cercle.cs`

La classe `Cercle` hérite de `Forme` et représente un cercle défini par un centre et un rayon.

#### Propriétés :
- **`rayon`** : Le rayon du cercle.

#### Constructeur :
- **`Cercle(Point point, double rayon)`** : Initialise un cercle avec un centre (de type `Point`) et un rayon.

#### Méthodes :
- **`Perimetre()`** : Implémentation de la méthode abstraite pour calculer le périmètre du cercle selon la formule : 
  \[
  Périmètre = 2 \times \pi \times \text{rayon}
  \]
- **`Aire()`** : Implémentation de la méthode abstraite pour calculer l'aire du cercle selon la formule :
  \[
  Aire = \pi \times \text{rayon}^2
  \]
- **`ToString()`** : Redéfinie la méthode `ToString()` pour retourner une description textuelle du cercle avec son centre et son rayon.

### 4. `Rectangle.cs`

La classe `Rectangle` hérite de `Forme` et représente un rectangle défini par une longueur et une largeur.

#### Propriétés :
- **`longueur`** : La longueur du rectangle.
- **`largeur`** : La largeur du rectangle.

#### Constructeur :
- **`Rectangle(Point point, double longueur, double largeur)`** : Initialise un rectangle avec un centre (de type `Point`), une longueur et une largeur.

#### Méthodes :
- **`Perimetre()`** : Implémentation de la méthode abstraite pour calculer le périmètre du rectangle selon la formule :
  \[
  Périmètre = 2 \times (\text{longueur} + \text{largeur})
  \]
- **`Aire()`** : Implémentation de la méthode abstraite pour calculer l'aire du rectangle selon la formule :
  \[
  Aire = \text{longueur} \times \text{largeur}
  \]
- **`ToString()`** : Redéfinie la méthode `ToString()` pour retourner une description textuelle du rectangle avec son centre, sa longueur et sa largeur.

### 5. `Program.cs`

Le fichier `Program.cs` contient le point d'entrée du programme, où sont testées les différentes fonctionnalités des classes. Ce fichier permet de :
1. Créer des instances de `Point`, `Cercle` et `Rectangle`.
2. Comparer des points pour vérifier s'ils sont égaux ou différents.
3. Calculer et afficher le périmètre et l'aire d'un cercle et d'un rectangle.

#### Exemple de sortie :

```plaintext
Classe Point :
O(0,0)
A(2,2)
B(2,2)
A et B sont égaux
A et O sont différents

Classe Cercle :
Centre : (2,2), Rayon : 10
Perimetre : 62,8318530717959
Aire : 314,159265358979

Classe Rectangle :
Centre : (2,2), Longueur : 40, Largeur : 10
Perimetre : 100
Aire : 400
```



