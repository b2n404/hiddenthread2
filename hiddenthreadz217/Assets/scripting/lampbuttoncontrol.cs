using Unity.VisualScripting;
using UnityEngine;

public class lampbuttoncontrol : MonoBehaviour
{
    public Light lamp;
    public GameObject book;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("book"))
        lamp = GetComponent<Light>();
    }


}
