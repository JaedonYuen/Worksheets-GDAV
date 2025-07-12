using UnityEngine;

public class YRespawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    public float Y_Limit = -50f;


    void Start()
    {
        // Store the initial position and rotation of the GameObject
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < Y_Limit)
        {
            // Reset the position and rotation of the GameObject
            transform.position = initialPosition;
            transform.rotation = initialRotation;

            // Optionally, reset any velocity if using Rigidbody
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}
