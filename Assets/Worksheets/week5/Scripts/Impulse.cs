using UnityEngine;

public class Impulse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float impulseForce = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyImpulse(Vector3.up); // Apply impulse in the upward direction when space is pressed
        }
        if (movement != Vector2.zero)
        {
            Vector3 direction = new Vector3(movement.x, 0, movement.y).normalized;
            ApplyImpulse(direction); // Apply impulse in the direction of movement
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
