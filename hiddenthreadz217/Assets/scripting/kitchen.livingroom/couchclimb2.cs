using UnityEngine;

public class couchclimb2 : MonoBehaviour
{
        public string targetTag = "Player";

     public GameObject Player;

     private bool bycouchfront = false;

     public GameObject couchleg;

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
        bycouchfront = true;
        text.SetActive(true);
        couchleg.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        bycouchfront = false;
        text.SetActive(false);
        }
        
    }
}
