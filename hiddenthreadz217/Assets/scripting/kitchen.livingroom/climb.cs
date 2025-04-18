using UnityEngine;
using UnityEngine.SceneManagement;

public class climb : MonoBehaviour
{

    public GameObject climbtext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.X))
            //{
            //SceneManager.LoadScene("kitchen.countertop");
            //}
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            climbtext.SetActive(true);
            //SceneManager.LoadScene("kitchen.countertop");
        }
    }

    void LateUpdate()
    {
        if(Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("kitchen.countertop");
        }
        if(Input.GetKey(KeyCode.X))
        {
            climbtext.SetActive(false);
        }
    }
}
