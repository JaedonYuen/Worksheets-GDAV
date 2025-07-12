using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float jumpForce = 5f;
    public Rigidbody rb;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnJump()
    {
         rb.AddForce(Vector3.right * jumpForce, ForceMode.Impulse);
    }
}
