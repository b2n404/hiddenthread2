using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Light lamp;
    bool lampon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       lamp = GetComponent<Light>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            lampon = true;
            lamp.enabled = false; 
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lampon = false;
            lamp.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        
    }

 
}
