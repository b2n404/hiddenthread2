using UnityEngine;

public class flicker : MonoBehaviour
{
    public Light myLight;
    public float interval = 1;

    float timer; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myLight.enabled = true;

        myLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
            if (timer > interval )
        {
            myLight.enabled = !myLight.enabled;
            interval = Random.Range(0f, 1f);
            timer = 0;
        }
    }
}
