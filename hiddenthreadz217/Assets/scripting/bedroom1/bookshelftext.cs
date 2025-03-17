using NUnit.Framework.Constraints;
using UnityEngine;

public class collisiontextv2 : MonoBehaviour
{
    //public GameObject PressXbookshelf;
    public GameObject bookshelftext;

    //public bool bookshelftext = false;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bookshelftext.SetActive(false);
        //PressX.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            //PressXbookshelf.SetActive(true);
            bookshelftext.SetActive(true);

        }
    }

    void LateUpdate()
    {
       if(Input.GetKeyUp(KeyCode.X))
            {
           // PressXbookshelf.SetActive(false);
            //bookshelftext.SetActive(true);
            bookshelftext.SetActive(false);
            }
        // if(Input.GetKeyUp(KeyCode.C))
        // { 
        //     bookshelftext.SetActive(false);
        // }
        
    }
}
