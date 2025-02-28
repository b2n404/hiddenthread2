using UnityEngine;

public class EnableCompenents : MonoBehaviour
{
    private Light lamp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       lamp = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            lamp.enabled = !lamp.enabled;
        }
    }

    void LateUpdate()
    {
        
    }

 
}
