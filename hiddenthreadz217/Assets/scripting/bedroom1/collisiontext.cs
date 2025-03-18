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
    public GameObject thought1;
    public GameObject thought2;
    public GameObject bed2bath;

    public GameObject bookshelfcollider;
    public GameObject level1doorcollider;
    public GameObject wheredorothy;
    public GameObject whodorothy;
    public GameObject key1;
    public GameObject bed2bathcollider;

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
            Destroy(whodorothy);
            Destroy(bookshelfcollider); 


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
            key1.SetActive(false);   
            
        }
        if(other.gameObject.CompareTag("TOHALLWAY"))
        {
            SceneManager.LoadScene("Hallway");
        }
        if(other.gameObject.CompareTag("dorothy"))
        {
            thought1.SetActive(true);
        }
        if(other.gameObject.CompareTag("dorothy2"))
        {
            Destroy(wheredorothy);
            thought1.SetActive(false);
            thought2.SetActive(true);
        }
        if (other.gameObject.CompareTag("bed2bathdoor"))
        {
            bed2bath.SetActive(true);
            Destroy(bed2bathcollider);
        }
        if(other.gameObject.CompareTag("off"))
        {
            thought2.SetActive(false);
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
