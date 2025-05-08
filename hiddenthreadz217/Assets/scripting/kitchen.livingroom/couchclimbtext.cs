using UnityEngine;

public class couchclimbtext : MonoBehaviour
{
    public string targetTag = "Player";

     public GameObject Player;

     private bool bycouchleg = false;

     public GameObject couchfront;

    public GameObject text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        bycouchleg = true;
        text.SetActive(true);
        couchfront.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        bycouchleg = false;
        text.SetActive(false);
        }
        
    }
}
