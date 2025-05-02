using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class deskclimb : MonoBehaviour
{
    public GameObject Player;
    public Transform player, destination;

    public GameObject climbdesktext;

    public bool bydesk = false;

    public GameObject topdesktrigger;



    public Image img;

    public GameObject blackscreenimg;

    public float targetOpacity = 0.0f;    //the following two WORK 

    public float targetOpacity2 = 0.0f;
    public float fadeTime = 2.0f;

    public float fadeTime2 = 0.0f;

    void Start()
    {
    }

    void Update()
    {
        if (bydesk == true && Input.GetKey(KeyCode.C))
        {
            // Player.SetActive(false);
            // player.position = destination.position;
            // Player.SetActive(true);

            climbdesktext.SetActive(false);
            bydesk = false;

            StartCoroutine(FadeImage());  //THIS WORKS 

            StartCoroutine(DelayFade(2.0f));

            StartCoroutine(DelayTeleport());

        }

    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("player entered area");
            climbdesktext.SetActive(true);
            bydesk = true;



        }
    }

    /////////////////////////// 

 private IEnumerator FadeImage() // THIS ALSO WORKS 
    {
        if(bydesk = true)
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

         if(bydesk == true && Input.GetKey(KeyCode.C))
        {
           //img.canvasRenderer(false);
           blackscreenimg.SetActive(false);

        }

    }

    IEnumerator DelayTeleport()
    {
        if(bydesk == true && Input.GetKey(KeyCode.C))
        {
            yield return new WaitForSeconds(2);
            Player.SetActive(false);
            player.position = destination.position;
            Player.SetActive(true);

            bydesk = false;

        }

    }


/////////////////////////////////

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            bydesk = false;
            Debug.Log("player exited");
            climbdesktext.SetActive(false);
            //deskcollider.SetActive(false);
            topdesktrigger.SetActive(false);
        }
    }
}   