
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;

    // Your variables used for moving the player
    public float moveSpeed = 5.0F;
    public float jumpForce = 10.0F;

    // Code to set the radius and force of the explosion
    public float radius = 5.0F;
    public float power = 10000.0F;

    public float kickForce = 10.0F;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false; // See comment about this!

        CheckLineOfSight(); // Check line of sight at the start
    }

    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Your code to generate the explosion
            Vector3 explosionPosition = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Apply explosion force
                    rb.AddExplosionForce(power, explosionPosition, radius);
                }
            }

        }
    }

    void checkKick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1.0f);
            foreach (Collider hit in hitColliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Apply kick force
                    Vector3 direction = transform.forward;
                    rb.AddForce(direction.normalized * kickForce, ForceMode.Impulse);
                }
            }
        }
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction.Normalize();

        // Apply movement
        controller.Move(direction * moveSpeed * Time.deltaTime);

        // Jumping
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            Vector3 jump = new Vector3(0, jumpForce, 0);
            controller.Move(jump * Time.deltaTime);
        }
    }

    void CheckLineOfSight()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        RaycastHit hitData;

        foreach (GameObject enemy in enemies)
        {
            Vector3 vec = enemy.transform.position - transform.position;
            Debug.DrawRay(transform.position, vec, Color.red);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, vec, out hit, 30f))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    hit.collider.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }



    void FixedUpdate()
    {
        CheckExplosion();
        MovePlayer();
        checkKick();
    }
}

