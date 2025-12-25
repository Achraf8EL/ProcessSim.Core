# ProcessSim – Mini projet de migration VB.NET vers C#

## Objectif
Ce mini projet sert à montrer comment migrer une application **VB.NET** vers **C#** de façon propre, sans casser le fonctionnement.

L’idée principale :  
 **on écrit des tests**, puis  **on migre un module**, et  **on vérifie que les tests passent toujours**.

---

## Structure de la solution
La solution contient 3 projets :

### 1) ProcessSim.Core (VB.NET)
C’est la partie “logique métier” en VB.NET.
On y a mis :
- `UnitConverter.vb` : conversions d’unités (mL ↔ L, °C ↔ K, etc.)
- `ChromatoModel.vb` : petits calculs type “chromatographie” (formules simples)

### 2) ProcessSim.Core.CSharp (C#)
C’est la version C# (migration).
On y a migré **un premier module** :
- `UnitConverter.cs` : même logique que `UnitConverter.vb`, mais en C#  
  (on l’a mis dans le namespace `ProcessSim.Core.CSharp` pour éviter les conflits avec la version VB).

### 3) ProcessSim.Tests (VB.NET – MSTest)
C’est le projet de tests unitaires.
Il contient :
- `UnitConverterTests` : tests pour vérifier les conversions et les erreurs (ex: valeur négative)
- `ChromatoModelTests` : tests pour vérifier les calculs du modèle

---

## Ce qu’on a fait (étapes)
1.  Création du projet VB.NET (`ProcessSim.Core`)
2.  Ajout d’un projet de tests (`ProcessSim.Tests`)
3.  Écriture des tests (baseline) pour sécuriser le comportement
4.  Ajout de `ChromatoModel` + tests (au total : 11 tests)
5.  Création du projet C# (`ProcessSim.Core.CSharp`)
6.  Migration de `UnitConverter` en C#
7.  Les tests passent toujours : **11 tests réussis**
   → donc la migration n’a pas cassé le comportement

---

## Comment lancer les tests
Dans Visual Studio :
- Menu **Test** → **Explorateur de tests**
- Cliquer sur **Exécuter tout**

Résultat attendu :  
 **11 réussites**

---

## Pourquoi c’est une bonne méthode de migration ?
- Les tests servent de “filet de sécurité”
- On migre module par module (migration incrémentale)
- On peut prouver que “avant = après” grâce aux tests

---

## Prochaine étape (si on continue)
- Migrer `ChromatoModel` en C# avec la même méthode
- Garder uniquement la version C# à la fin
