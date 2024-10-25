# PixelSpeed
Draw.io
![Untitled Diagram drawio](https://github.com/user-attachments/assets/443d3054-ba76-4994-9762-251e1129934c)

TurboRival
Attributs :
GameState, Course, InterfaceMenus, ObjeSpeciaux, Vehicules
Méthodes :
startGame(): initialise le jeu et démarre la course.
update(): boucle de jeu principale.
showMenu(): affiche le menu principal.

Course
circuit: instance de Circuit, map, GestionCourse

start(): commence la course.
updatePositions(): met à jour les positions des véhicules.
checkVictory(): vérifie si un véhicule a terminé la course.

Vehicle
Attributs :

speed: vitesse actuelle
position: position sur le circuit
boostsAvailable: nombre de boosts restants
Etat: état du véhicule (normal, protégé, etc.)
Méthodes :

move(): déplace le véhicule en fonction de la vitesse.
applyBoost(): applique un boost de vitesse.
collide(): gère les collisions avec d'autres véhicules ou obstacles.
Player (hérite de Vehicle)
Attributs supplémentaires :

name: nom du joueur
score: score du joueur
objetSpeciaux: liste d'objets spéciaux
Méthodes :

usePowerUp(): utilise un objet spécial.
AI (hérite de Vehicle)
Méthodes :
navigate(): détermine le meilleur chemin sur le circuit.
usePowerUp(): utilise des objets spéciaux de manière stratégique.
PowerUp
Attributs :

type: type de power-up
duration: durée de l'effet
Méthodes :

applyEffect(vehicle): applique l'effet au véhicule ciblé.
