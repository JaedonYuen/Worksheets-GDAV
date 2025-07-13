using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class TrafficLight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created]\
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;
    public float lightDuration = 2f; // Duration for each light in seconds

    private string currentLight = "Red";

    void Start()
    {
        StartCoroutine(ChangeLight());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ChangeLight()
    {
        while (true)
        {
            switch (currentLight)
            { 
                case "Red":
                    colorLight(redLight, Color.red);
                    yield return new WaitForSeconds(lightDuration); // Red light for 5 seconds
                    colorLight(redLight, Color.black);
                    currentLight = "Green";
                    break;

                case "Green":
                    colorLight(greenLight, Color.green);
                    yield return new WaitForSeconds(lightDuration); // Green light for 5 seconds
                    colorLight(greenLight, Color.black);
                    currentLight = "Yellow";
                    break;

                case "Yellow":
                    colorLight(yellowLight, Color.yellow);
                    yield return new WaitForSeconds(lightDuration); // Yellow light for 2 seconds
                    colorLight(yellowLight, Color.black);
                    currentLight = "Red";
                    break;
            }
        }
    }

    void colorLight(GameObject light, Color color)
    {
        // Logic to change the color of the light
        light.GetComponent<Renderer>().material.color = color;
    }   
    
}
