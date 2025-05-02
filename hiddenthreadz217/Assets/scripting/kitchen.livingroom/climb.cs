using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class climb : MonoBehaviour
{

    public GameObject climbcountertext;

    public string targetTag = "Player";

    public bool bystool = false;

    public GameObject Player;

    public Transform player, counterdestination;

    public GameObject countertrigger;




    public Image img;

    public GameObject blackscreenimg;

    public float targetOpacity = 0.0f;    //the following two WORK 

    public float targetOpacity2 = 0.0f;
    public float fadeTime = 2.0f;

    public float fadeTime2 = 0.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(bystool == true && Input.GetKey(KeyCode.C))
        {
            // Player.SetActive(false);
            // player.position = counterdestination.position;
            // Player.SetActive(true);
            climbcountertext.SetActive(false);
            bystool = false;




            StartCoroutine(FadeImage());  //THIS WORKS 

            StartCoroutine(DelayFade(2.0f));

            StartCoroutine(DelayTeleport());


        }

    }

/////////////////////////// 

 private IEnumerator FadeImage() // THIS ALSO WORKS 
    {
        if(bystool = true)
        {

            float alpha = img.color.a;
            for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime)
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity, t));

                yield return null;

            }
        }
    }


        IEnumerator DelayFade(float delay)
    {

        yield return new WaitForSeconds(delay);
        float alpha = img.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime2)
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity2, t));
            yield return null;

        }

         if(bystool == true && Input.GetKey(KeyCode.C))
        {
           blackscreenimg.SetActive(false);

        }

    }

    IEnumerator DelayTeleport()
    {
        // if(bystool == true && Input.GetKey(KeyCode.C))
        // {
        //     yield return new WaitForSeconds(2);
        //     Player.SetActive(false);
        //     player.position = counterdestination.position;
        //     Player.SetActive(true);

        //     bystool = false;

        // }

         yield return new WaitForSeconds(2);
            //Player.SetActive(false);
            player.position = counterdestination.position;
            //Player.SetActive(true);

            bystool = false;


    }


/////////////////////////////////

    void OnTriggerEnter(Collider other)
    {
        // bystool = true;
        // Debug.Log("player entered");


        if(other.gameObject.CompareTag("Player"))
        {
            bystool = true;
            Debug.Log("player entered");
            climbcountertext.SetActive(true);


        }
    }




    void OnTriggerExit(Collider other)
    {
        bystool = false;
        Debug.Log("player exited");
        climbcountertext.SetActive(false);

        

    }

    
}







// THE FOLLOWING HAS A GLITCH WHERE EVERYTIME THE C KEY IS PRESSED THE SCREEN FADES - TRYING TO FIX THIS 




// using UnityEngine;
// //using UnityEngine.SceneManagement;
// using System.Collections;
// using System.Collections.Generic;

// using UnityEngine.UI;
// using UnityEngine.Rendering;
// //using UnityEngine.UIElements;


// public class climb : MonoBehaviour
// {

//     public GameObject climbcountertext;

//     public string targetTag = "Player";

//     private bool inTriggerArea = false;

//     public GameObject Player;

//     public Transform player, counterdestination;

//     public GameObject countertrigger;



//     public Image img;

//     public GameObject blackscreenimg;

//     public float targetOpacity = 0.0f;    //the following two WORK 

//     public float targetOpacity2 = 0.0f;
//     public float fadeTime = 2.0f;

//     public float fadeTime2 = 0.0f;


    

//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         //StartCoroutine(FadeImage());
//     }
//     void OnTriggerEnter(Collider other)
//     {
//         inTriggerArea = true;
//         Debug.Log("player entered stool climb");


//         if (other.gameObject.CompareTag("Player"))
//         {
//             climbcountertext.SetActive(true);
//         }


//         //if (!enabled) return;


//     }


//     void OnTriggerExit(Collider other)
//     {
//         inTriggerArea = false;
//         Debug.Log("player exited");
//         climbcountertext.SetActive(false);

//         StopCoroutine(FadeImage());
//         //StopCoroutine(DelayTeleport(0.5f));
//         StopCoroutine(DelayFade(2.0f));

//     }
//     // Update is called once per frame
//     void Update()
//     {

//         if(inTriggerArea && Input.GetKeyDown(KeyCode.C))
//         {
//             // Player.SetActive(false);
//             // player.position = counterdestination.position;
//             // Player.SetActive(true);

//             climbcountertext.SetActive(false);

//             StartCoroutine(FadeImage());  //THIS WORKS 

//             //StartCoroutine(FadeImageout());

//            //StartCoroutine(DelayTeleport(0.5f));

//             StartCoroutine(DelayFade(2.0f));

//             //StartCoroutine(FadeImage(true));


//             //invoke("");

//             Player.SetActive(false);
//             player.position = counterdestination.position;
//             Player.SetActive(true);

//         }

//     }

 

//     IEnumerator DelayFade(float delay)
//     {

//         yield return new WaitForSeconds(delay);
//         float alpha = img.color.a;
//         for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime2)
//         {
//             img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity2, t));
//             yield return null;

//         }

//          if(inTriggerArea && Input.GetKey(KeyCode.C))
//         {
//            //img.canvasRenderer(false);
//            blackscreenimg.SetActive(false);
//         }

//     }



//     private IEnumerator FadeImage() // THIS ALSO WORKS 
//     {
//         if(inTriggerArea = true)
//         {
//             float alpha = img.color.a;
//             for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime)
//             {
//                 img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity, t));
//                 yield return null;

          

//             }
//         }
        

//     }

   

//     ///////////////////// I don't know what the stuff below is anymore my head huirts 


//     //   private IEnumerator FadeImageout() // THIS ALSO WORKS 
//     // {
//     //     float alpha = img.color.a;
//     //     for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime2)
//     //     {
//     //         img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity2, t));
//     //         yield return null;

//     //     }

//     // }



//     // IEnumerator FadeImage(bool fadeAway)
//     // {
//     //     if (fadeAway)
//     //     {
//     //         for (float i = 1; i >= 0; i -= Time.deltaTime)
//     //         {
//     //             img.color = new Color(1, 1, 1, i);
//     //             yield return null;
//     //         }
//     //     }

//     //     else
//     //     {
//     //         for (float i = 0; i <= 1; i += Time.deltaTime)
//     //         {
//     //             img.color = new Color(1, 1, 1, i);
//     //             yield return null; 
//     //         }
//     //     }
//     // }


// }
