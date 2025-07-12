using UnityEngine;


namespace GDAVDatatypes
{
    public class SpriteScaler : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private Transform spriteTransform;
        private string scale = "2.0a";

        void Start()
        {
            spriteTransform = GetComponent<Transform>();
            
            float scaleValue = float.Parse(scale);

            spriteTransform.localScale = new Vector3(scaleValue, scaleValue, 1f);
        }

    }
}