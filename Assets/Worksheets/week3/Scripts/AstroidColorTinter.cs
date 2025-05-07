using UnityEngine;

public class AstroidColorTinter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Color defaultColor = Color.white; // Default color
    public Color targetColor = Color.blue; // Target color
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Get the current color of the GameObject's material
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

            if (spriteRenderer.color == targetColor)
            {
                //change the color to white
                spriteRenderer.color = defaultColor;
                

            }
            else
            {
                //change the color to blue
                spriteRenderer.color = targetColor;
            }
            Debug.Log("space key was pressed! The color of the GameObject is now: " + spriteRenderer.color);
        }
    }
}
