using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Attributs
    public float speed;
    public float position;
    public int boostsAvailable = 3;
    public string state = "normal";

    // M�thode pour d�placer le v�hicule
    public virtual void Move()
    {
        position += speed * Time.deltaTime;
        transform.position = new Vector3(position, transform.position.y, transform.position.z);
    }

    // M�thode pour appliquer un boost de vitesse
    public void ApplyBoost()
    {
        if (boostsAvailable > 0)
        {
            speed += 10;
            boostsAvailable--;
        }
    }

    // M�thode pour g�rer les collisions
    public void Collide()
    {

    }

    // M�thode pour r�initialiser l'�tat du v�hicule
    public void ResetVehicle()
    {
        speed = 0;
        position = 0;
        boostsAvailable = 3;
        state = "normal";
    }
}
