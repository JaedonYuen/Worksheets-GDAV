using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Material colideEnterMaterial;
    public Material colideExitMaterial;
    private Renderer cubeRenderer;
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (cubeRenderer != null && colideEnterMaterial != null)
        {
            cubeRenderer.material = colideEnterMaterial; // Change material on collision enter
        }
    }
    
    void OnCollisionExit(Collision collision)
    {
        if (cubeRenderer != null && colideExitMaterial != null)
        {
            cubeRenderer.material = colideExitMaterial; // Change material on collision exit
        }
    }
}
