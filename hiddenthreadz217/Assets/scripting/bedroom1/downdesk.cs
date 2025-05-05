using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class downdesk : MonoBehaviour
{
    public GameObject climbdowntext;

    public string targetTag = "Player";

    public GameObject Player;
    public Transform player, destinationfloor;

    public bool downd = false;

    public GameObject topdesktrigger;

    //public GameObject floor;



    public Image img;

    public GameObject blackscreenimg;

    public float targetOpacity = 0.0f;    //the following two WORK 

    public float targetOpacity2 = 0.0f;
    public float fadeTime = 2.0f;

    public float fadeTime2 = 0.0f;




    //public GameObject deskcollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (downd == true && Input.GetKey(KeyCode.V))
        {
            // Player.SetActive(false);
            // player.position = destinationfloor.position;
            // Player.SetActive(true);

            climbdowntext.SetActive(false);
            topdesktrigger.SetActive(false);

            
            StartCoroutine(FadeImage());  //THIS WORKS 

            StartCoroutine(DelayFade(2.0f));

            StartCoroutine(DelayTeleport());
        }


    }
    /////////////////////////// 

 private IEnumerator FadeImage() // THIS ALSO WORKS 
    {
        if(downd == true)
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

         if(downd == true && Input.GetKey(KeyCode.V))
        {
           //img.canvasRenderer(false);
           blackscreenimg.SetActive(false);

        }

    }

    IEnumerator DelayTeleport()
    {
        if(downd == true && Input.GetKey(KeyCode.V))
        {
            yield return new WaitForSeconds(2);
            Player.SetActive(false);
            player.position = destinationfloor.position;
            Player.SetActive(true);

            downd = false;

        }

    }


/////////////////////////////////

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            downd = true;
            Debug.Log("player entered");
            climbdowntext.SetActive(true); 
            topdesktrigger.SetActive(false);
            //floor.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        downd = false;
        Debug.Log("player exited");
        climbdowntext.SetActive(false);
        //floor.SetActive(false);

    }




}
