using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 0f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void fire()
    {
        if (speed > 0f)
        {
            Debug.Log("Projectile fired at speed: " + speed);
        }
        else
        {
            Debug.Log("Projectile speed is not set");
            autoFire();
            Debug.Log("Projectile auto fired at speed: " + speed);
        }
    }

    public void autoFire () //self fix speed not set
    {
        speed = 100f; // Set a default speed for auto fire
        
    }
}
