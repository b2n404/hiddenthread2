using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisiontext : MonoBehaviour
{
    //text
    //public GameObject PressX;
    public GameObject bookshelftext;
    //public GameObject walltext;
    public GameObject exitdoortext;
    public GameObject desktext;

    public GameObject level1doorcollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // bookshelftext.SetActive(false);

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
        // if(other.gameObject.CompareTag("wall"))
        // {
        //     walltext.SetActive(true);
        // }

        if(other.gameObject.CompareTag("desk"))
        {
            desktext.SetActive(true);
        }

        if(other.gameObject.CompareTag("bedroomdoor1"))
        {
            exitdoortext.SetActive(true);
        }

        if(other.gameObject.CompareTag("key"))
        {
            Destroy(level1doorcollider);
        }
        if(other.gameObject.CompareTag("TOHALLWAY"))
        {
            SceneManager.LoadScene("Hallway");
        }
    }

    void LateUpdate()
    {
       if(Input.GetKeyUp(KeyCode.X))
            {
            //PressX.SetActive(false);
            bookshelftext.SetActive(false);
            //walltext.SetActive(false);
            desktext.SetActive(false);
            exitdoortext.SetActive(false);
            }
        
    }
}
