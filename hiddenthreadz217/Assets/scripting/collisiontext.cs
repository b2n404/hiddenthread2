using NUnit.Framework.Constraints;
using UnityEngine;

public class collisiontext : MonoBehaviour
{
    //text
    public GameObject PressX;
    public GameObject bookshelftext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bookshelftext.SetActive(false);
        PressX.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            PressX.SetActive(true);
             if(Input.GetKeyUp(KeyCode.X))
            {
            PressX.SetActive(false);
            bookshelftext.SetActive(true);
            }
        }
    }

    void LateUpdate()
    {
       
    }
}
