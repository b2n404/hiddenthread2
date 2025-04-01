using UnityEngine;
using UnityEngine.SceneManagement;

public class collision2 : MonoBehaviour
{
    public string targetTag = "Player";
    private bool inTriggerArea = false;
    public GameObject question;
    //public GameObject yes;
    //public GameObject no;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inTriggerArea && Input.GetKey(KeyCode.X))
        {
            SceneManager.LoadScene("Main2-kitchen-livingroom");
        }

        if(inTriggerArea && Input.GetKey(KeyCode.O))
        {
            question.SetActive(false);
            //yes.SetActive(false);
            //no.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        if(other.gameObject.CompareTag("Player"))
        {
            question.SetActive(true);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        question.SetActive(false);
        //yes.SetActive(false);
        //no.SetActive(true);

    }
}
