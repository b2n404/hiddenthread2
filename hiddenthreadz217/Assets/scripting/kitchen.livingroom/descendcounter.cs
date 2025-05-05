using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class descendcounter : MonoBehaviour
{

    public string targetTag = "Player";

    public GameObject Player;
    public GameObject descendcountertext;
    public Transform player, livingroomfloor;
    public GameObject countertoptarget;


    private bool downcounter = false;


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
        if (downcounter == true && Input.GetKey(KeyCode.V))
        {
            // Player.SetActive(false);
            // player.position = livingroomfloor.position;
            // Player.SetActive(true);

            descendcountertext.SetActive(false);
            countertoptarget.SetActive(false);

            StartCoroutine(FadeImage());  //THIS WORKS 

            StartCoroutine(DelayFade(2.0f));

            StartCoroutine(DelayTeleport());
        }
    }

      /////////////////////////// 

 private IEnumerator FadeImage() // THIS ALSO WORKS 
    {
        if(downcounter == true)
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

         if(downcounter == true && Input.GetKey(KeyCode.V))
        {
           //img.canvasRenderer(false);
           blackscreenimg.SetActive(false);

        }

    }

    IEnumerator DelayTeleport()
    {
        if(downcounter == true && Input.GetKey(KeyCode.V))
        {
            yield return new WaitForSeconds(2);
            Player.SetActive(false);
            player.position = livingroomfloor.position;
            Player.SetActive(true);

            downcounter = false;

        }

    }


/////////////////////////////////


    void OnTriggerEnter(Collider other)
    {
        downcounter = true;
        Debug.Log("player entered");

        if (other.gameObject.CompareTag("Player"))
        {
            descendcountertext.SetActive(true); 
            countertoptarget.SetActive(false);
        }
    }



    void OnTriggerExit(Collider other)
    {
        downcounter = false;
        Debug.Log("player exited");

        descendcountertext.SetActive(false);

    
    }
}
