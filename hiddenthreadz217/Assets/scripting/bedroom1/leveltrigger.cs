//using UnityEditor.Rendering;
using UnityEngine;

public class leveltrigger : MonoBehaviour
{
    public GameObject closedoortext;
    //public GameObject opendoortext;

    private bool inTriggerArea = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea && Input.GetKey(KeyCode.X))
        {
            closedoortext.SetActive(false);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        if (other.gameObject.CompareTag("Player"))
        {
            closedoortext.SetActive(true);
        }
        Debug.Log("Player here");
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        closedoortext.SetActive(false);
        Debug.Log("player gone");
    }
}
