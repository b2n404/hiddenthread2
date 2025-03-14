using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class lampbuttoncontrol : MonoBehaviour
{
    public Light lamp;
    public GameObject book;

    public GameObject LAMPINTEXT;

    public GameObject pressxtextforlamp;

    public GameObject lampinvesttext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //lamp = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("book"))
        {
            lamp.intensity = 1;

            Destroy(LAMPINTEXT);
            // pressxtextforlamp.SetActive(false);
            // lampinvesttext.SetActive(false);
            
        }
    }


}
