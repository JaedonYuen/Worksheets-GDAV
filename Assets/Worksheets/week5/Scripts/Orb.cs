using UnityEngine;

public class Orb : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float impulseForce = 10f;
    private Rigidbody rb;   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyImpulse(Vector3.forward); // Apply impulse in the forward direction when space is pressed
        }
    }

    void ApplyImpulse(Vector3 direction)
    {
        if (rb != null)
        {
            rb.AddForce(direction * impulseForce, ForceMode.Impulse);
        }
    }
}
