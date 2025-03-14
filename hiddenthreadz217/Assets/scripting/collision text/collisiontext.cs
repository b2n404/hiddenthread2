using NUnit.Framework.Constraints;
using UnityEngine;

public class collisiontext : MonoBehaviour
{
    //text
    //public GameObject PressX;
    public GameObject bookshelftext;
    public GameObject walltext;

    public GameObject desktext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bookshelftext.SetActive(false);

        //PressX.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("bookshelf"))
        {
            //PressX.SetActive(true);
            bookshelftext.SetActive(true);

        }
        if(other.gameObject.CompareTag("wall"))
        {
            walltext.SetActive(true);
        }

        if(other.gameObject.CompareTag("desk"))
        {
            desktext.SetActive(true);
        }
    }

    void LateUpdate()
    {
       if(Input.GetKeyUp(KeyCode.X))
            {
            //PressX.SetActive(false);
            bookshelftext.SetActive(false);
            walltext.SetActive(false);
            desktext.SetActive(false);
            }
        
    }
}
