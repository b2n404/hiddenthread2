using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class scenefadein : MonoBehaviour
{

   // public string targetTag = "Player";

    //public GameObject Player; 

    public GameObject howplaytext;

    ///

    public Image img;

    public GameObject scenefadeinscreen;

    public float targetOpacity;
    public float fadeTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FadeImage());

        scenefadeinscreen.SetActive(true);

        howplaytext.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            howplaytext.SetActive(false);
        }
    }
    
    private IEnumerator FadeImage()
    {
        float alpha = img.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeTime)
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Lerp(alpha, targetOpacity, t));

            yield return null;
        }
    }
}
