//using System;
using System.Collections;
//using Microsoft.Unity.VisualStudio.Editor;
//using UnityEditor.Rendering;
using UnityEngine;
//using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
//using System.Collections.Generic;
using UnityEngine.UI;

public class doorleveltrigger : MonoBehaviour
{
    //public GameObject closedoortext;
    public GameObject opendoortext;

    private bool inTriggerArea = false;




    public Image img;
    public GameObject blackscreen;
    public float targetOpacity = 0.0f;
    public float fadeTime = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea == true && Input.GetKey(KeyCode.X))
        {
            opendoortext.SetActive(false);
            //SceneManager.LoadScene("Main2-kitchen-livingroom");


            StartCoroutine(FadeImage());

            StartCoroutine(DelayLoad());
        }


    }

    private IEnumerator FadeImage()
    {
        if(inTriggerArea == true)
        {
            float alpha = img.color.a;
            for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime)
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity, t));

                yield return null;

            }
        }
    }

    private IEnumerator DelayLoad()
    {
        if(inTriggerArea == true && Input.GetKey(KeyCode.X))
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Main2-kitchen-livingroom");

            inTriggerArea = false;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        if (other.gameObject.CompareTag("Player"))
        {
            opendoortext.SetActive(true);
        }
        Debug.Log("Player here");
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        opendoortext.SetActive(false);
        Debug.Log("player gone");
    }
}
