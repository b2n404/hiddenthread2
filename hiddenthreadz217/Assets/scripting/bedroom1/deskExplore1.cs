// using NUnit.Framework.Constraints;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class deskExplore1 : MonoBehaviour
// {
//     public string targetTag = "Player";
    
//     //investigation text 
//     public GameObject bookshelftext;
//     public GameObject exitdoortext;
//     public GameObject desktext;

//     //thought text - triggers 
//     public GameObject thought1;
//     public GameObject thought2;

//     //thought text 
//     public GameObject wheredorothy;
//     public GameObject whodorothy;


//     public GameObject bed2bath;
//     // public GameObject bookshelfcollider;
//     // public GameObject level1doorcollider;
    
//     // Interactive Object - KEY can 'pick up' 
//     public GameObject key1;
//     //public GameObject bed2bathcollider;

//     private bool inTriggerArea = false;

//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//        // bookshelftext.SetActive(false);

//         //PressX.SetActive(false);
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         inTriggerArea = true;

//         if(other.CompareTag("Player"))
//         {

//         }

//         if(other.gameObject.CompareTag("bookshelf"))
//         {
//             //PressX.SetActive(true);
//             bookshelftext.SetActive(true);
//             Destroy(whodorothy);
//             //Destroy(bookshelfcollider); 


//         }

//         if(other.gameObject.CompareTag("desk"))
//         {
//             desktext.SetActive(true);
//         }

//         if(other.gameObject.CompareTag("bedroomdoor1"))
//         {
//             exitdoortext.SetActive(true);
//         }

//         if(other.gameObject.CompareTag("key"))
//         {
//             //Destroy(level1doorcollider);
//             key1.SetActive(false);   
            
//         }
//         if(other.gameObject.CompareTag("TOHALLWAY"))
//         {
//             SceneManager.LoadScene("Hallway");
//         }
//         if(other.gameObject.CompareTag("dorothy"))
//         {
//             thought1.SetActive(true);
//         }
//         if(other.gameObject.CompareTag("dorothy2"))
//         {
//             Destroy(wheredorothy);
//             thought1.SetActive(false);
//             thought2.SetActive(true);
//         }
//         if (other.gameObject.CompareTag("bed2bathdoor"))
//         {
//             bed2bath.SetActive(true);
//             //Destroy(bed2bathcollider);
//         }
//         if(other.gameObject.CompareTag("off"))
//         {
//             thought2.SetActive(false);
//         }
//     }

//     void OnTriggerExit(Collider other)
//     {
//         inTriggerArea = false;
//         if(other.CompareTag("Player"))
//         {
            
//         }
//     }

//     void LateUpdate()
//     {
//     //    if(Input.GetKeyUp(KeyCode.X))
//     //         {
//     //         //PressX.SetActive(false);
//     //         bookshelftext.SetActive(false);
//     //         //walltext.SetActive(false);
//     //         desktext.SetActive(false);
//     //         exitdoortext.SetActive(false);
//     //         }
        
//     }
// }
