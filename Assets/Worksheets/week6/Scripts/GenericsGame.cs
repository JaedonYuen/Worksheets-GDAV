using UnityEngine;
using System.Collections;

public class GenericsGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (TryGetComponent<AudioSource>(out AudioSource audioSource))
        {
            Debug.Log("AudioSource component found on this GameObject.");
        }
        else
        {
            Debug.LogError("AudioSource component not found on this GameObject.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
