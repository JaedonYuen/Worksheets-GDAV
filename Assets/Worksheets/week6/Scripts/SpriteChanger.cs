using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite newSprite; // Assign this in the Inspector

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component from this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Change the sprite if a new one is assigned
        if (newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}