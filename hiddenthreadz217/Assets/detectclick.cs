using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class detectclick : MonoBehaviour
{

    private bool sceneover = false;

    public Image clicktostart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DelayActiveImg());

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneover == true && Input.GetMouseButtonDown(0))
        {
//Input.GetKey(KeyCode.Space))//
            SceneManager.LoadScene("Main1-bedroom 1");
           
        }
    }

     IEnumerator DelayActiveImg()
    {
        yield return new WaitForSeconds(2);
        clicktostart.enabled = true;
        sceneover = true;

        // if (Input.GetMouseButtonDown(0))
        // {

        //     SceneManager.LoadScene("Main1-bedroom-1");
           
        // }
            

    }
}
