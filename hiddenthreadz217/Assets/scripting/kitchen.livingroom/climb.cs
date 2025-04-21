using UnityEngine;
using UnityEngine.SceneManagement;

public class climb : MonoBehaviour
{

    public GameObject climbtext;

    public string targetTag = "Player";

    private bool inTriggerArea = false;

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

        if(inTriggerArea && Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("kitchen.countertop");
        }

        if(inTriggerArea && Input.GetKey(KeyCode.X))
        {
            climbtext.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        Debug.Log("player entered");


        if(other.gameObject.CompareTag("Player"))
        {
            climbtext.SetActive(true);
            //SceneManager.LoadScene("kitchen.countertop");
        }
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        Debug.Log("player exited");
        climbtext.SetActive(false);

    }
    void LateUpdate()
    {
       // if(Input.GetKey(KeyCode.O))
       // {
       //     SceneManager.LoadScene("kitchen.countertop");
      //  }
      //  if(Input.GetKey(KeyCode.X))
     //   {
      //      climbtext.SetActive(false);
     //   }
    }
}
