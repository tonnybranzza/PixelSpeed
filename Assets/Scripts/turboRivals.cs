using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Attributs
    public float speed;
    public float position;
    public int boostsAvailable = 3;
    public string state = "normal";

    // Méthode pour déplacer le véhicule
    public virtual void Move()
    {
        position += speed * Time.deltaTime;
        transform.position = new Vector3(position, transform.position.y, transform.position.z);
    }

    // Méthode pour appliquer un boost de vitesse
    public void ApplyBoost()
    {
        if (boostsAvailable > 0)
        {
            speed += 10;
            boostsAvailable--;
        }
    }

    // Méthode pour gérer les collisions
    public void Collide()
    {

    }

    // Méthode pour réinitialiser l'état du véhicule
    public void ResetVehicle()
    {
        speed = 0;
        position = 0;
        boostsAvailable = 3;
        state = "normal";
    }
}
