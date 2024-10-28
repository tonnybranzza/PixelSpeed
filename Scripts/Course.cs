using UnityEngine;

public class Course : MonoBehaviour
{
    private Circuit circuit;           // Instance de Circuit
    private Map map;                   // Carte
    private GestionCourse gestionCourse; // Gestion de la course

    public void Start()
    {
        // Commence la course
    }

    public void UpdatePositions()
    {
        // Met à jour les positions des véhicules
    }

    public void CheckVictory()
    {
        // Vérifie si un véhicule a terminé la course
    }
}