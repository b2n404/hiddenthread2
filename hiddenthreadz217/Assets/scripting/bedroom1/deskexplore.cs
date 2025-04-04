// using NUnit.Framework.Constraints;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class deskexplore : MonoBehaviour
// {
//     public string targetTag = "Player";
    
//     //explore text 
//     public GameObject desktext;
  
//     //thought text - triggers 
//     //public GameObject deskthought1;

//     //thought text 

//     //interactive/investigation text 
//     //public GameObject deskq1;
    

//     private bool inTriggerArea = false;

//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         desktext.SetActive(false);
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         // if(inTriggerArea && Input.GetKey(KeyCode.X))
//         // {
//         //     desktext.SetActive(false);
//         // }
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         inTriggerArea = true;

//         Debug.Log("player entered desk area");
//         desktext.SetActive(true);

//         if(other.gameObject.CompareTag("Player"))
//         {
//             if(Input.GetKey(KeyCode.X))
//             {
//                 desktext.SetActive(false);
//             }

//         }
        

//     }

//     void OnTriggerExit(Collider other)
//     {
//         inTriggerArea = false;
//         Debug.Log("player left desk area");

//         if(other.CompareTag("Player"))
//         {
//             desktext.SetActive(false);
//         }
//     }

// }

using UnityEngine;

public class deskexplore : MonoBehaviour
{
    public string targetTag = "Player";

    
    //FRIDGE TEXT INVESTIATION

    public GameObject lookdrawing1;


    // BOOLLSLSLRGOLKJSNROFGNKJ
    
    private bool bydesk = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lookdrawing1.SetActive(false);
    }
        void OnTriggerEnter(Collider other)
    {
        bydesk = true;

        Debug.Log("player entered area");
        

        if(other.gameObject.CompareTag("Player"))
        {
            lookdrawing1.SetActive(true);

        if(Input.GetKey(KeyCode.X))
        {
            lookdrawing1.SetActive(false);
        
        }


        }
        
    
    }

    void OnTriggerExit(Collider other)
    {
        bydesk = false;
        if(other.CompareTag("Player"))
        {
            Debug.Log("player exited area");

            lookdrawing1.SetActive(false);

        }
    }

        // Update is called once per frame
    void Update()
    {
        if(bydesk && Input.GetKey(KeyCode.X))
        {
            lookdrawing1.SetActive(false);
        }

    }
  


}

