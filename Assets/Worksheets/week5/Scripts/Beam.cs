using UnityEngine;

public class Beam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float torqueForce = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // apply torque clockwise
            ApplyTorque(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            // apply torque counter-clockwise
            ApplyTorque(Vector3.down);
        }
    }

    void ApplyTorque(Vector3 direction)
    {
        if (rb != null)
        {
            rb.AddTorque(direction * torqueForce, ForceMode.Impulse);
        }
    }
}
