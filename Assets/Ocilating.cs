using UnityEngine;

public class Ocilating : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 1f; 
    public float distance = 1f; 
    public float offset = 0f; // Offset to start the oscillation from a specific point
    private Vector3 startPosition;
    
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newX = startPosition.x + Mathf.Sin(Time.time * speed + offset) * distance;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
