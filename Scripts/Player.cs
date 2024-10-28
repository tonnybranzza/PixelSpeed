using UnityEngine;
using System.Collections.Generic;

public class Player : Vehicle
{
    public string name;              // Nom du joueur
    public int score;                // Score du joueur
    public List<PowerUp> objetsSpeciaux; // Liste d'objets spéciaux

    public void UsePowerUp()
    {
        // Utilise un objet spécial
    }
}}
