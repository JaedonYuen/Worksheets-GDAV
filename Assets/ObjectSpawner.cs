using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
   public Sprite newSprite;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        GameObject newObject = new GameObject("New GameObject");

        spriteRenderer = newObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = newSprite; 
    }

}
