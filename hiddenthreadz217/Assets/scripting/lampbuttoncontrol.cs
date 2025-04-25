using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class lampbuttoncontrol : MonoBehaviour
{
    public Light lamp;
    public Light lamp2;
    public GameObject book;

    public GameObject LAMPINTEXT;

    public GameObject pressxtextforlamp;

    public GameObject lampinvesttext;

    //public GameObject KEY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //lamp = GetComponent<Light>();
        //KEY.SetActive(false);
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
            lamp2.intensity = 1;

            Destroy(LAMPINTEXT);
            //KEY.SetActive(true);
            // pressxtextforlamp.SetActive(false);
            // lampinvesttext.SetActive(false);
            
        }
    }


}
