using UnityEngine;

public class fridgeinvestigation : MonoBehaviour
{
    public string targetTag = "Player";
    //public float delaytime = 4f;
    public GameObject drawing1;
    public GameObject drawing2;
    
    //FRIDGE TEXT INVESTIATION

    public GameObject lookdrawing1;
    public GameObject lookdrawing2;

    // BOOLLSLSLRGOLKJSNROFGNKJ
    
    private bool inTriggerArea = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inTriggerArea && Input.GetKey(KeyCode.Keypad1))
        {
            lookdrawing1.SetActive(false);
            lookdrawing2.SetActive(false);
            drawing1.SetActive(true);
        }

        if(inTriggerArea && Input.GetKey(KeyCode.Keypad2))
        {
            lookdrawing2.SetActive(false);
            lookdrawing1.SetActive(false);
            drawing2.SetActive(true);
        }

        if(inTriggerArea && Input.GetKey(KeyCode.Tab))
        {
            drawing1.SetActive(false); 
            drawing2.SetActive(false);
            lookdrawing1.SetActive(true);
            lookdrawing2.SetActive(true);

        }
    }
      void LateUpdate()
    {
        // if(Input.GetKey(KeyCode.Keypad1))
        // {
        //     lookdrawing1.SetActive(false);
        //     lookdrawing2.SetActive(false);
        //     drawing1.SetActive(true);
        // }

        // if(Input.GetKey(KeyCode.Keypad2))
        // {
        //     lookdrawing2.SetActive(false);
        //     lookdrawing1.SetActive(false);
        //     drawing2.SetActive(true);
        // }

        // if(Input.GetKey(KeyCode.Tab))
        // {
        //     drawing1.SetActive(false); 
        //     drawing2.SetActive(false);
        //     lookdrawing1.SetActive(true);
        //     lookdrawing2.SetActive(true);

        // }
    }
  

        void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        if(other.gameObject.CompareTag("Player"))
        {

        if(Input.GetKey(KeyCode.Keypad1))
        {
            lookdrawing1.SetActive(false);
            lookdrawing2.SetActive(false);
            drawing1.SetActive(true);
        }

        if(Input.GetKey(KeyCode.Keypad2))
        {
            lookdrawing2.SetActive(false);
            lookdrawing1.SetActive(false);
            drawing2.SetActive(true);
        }

        if(Input.GetKey(KeyCode.Tab))
        {
            drawing1.SetActive(false); 
            drawing2.SetActive(false);
            lookdrawing1.SetActive(true);
            lookdrawing2.SetActive(true);

        }
        //////////////////////////
        Debug.Log("player entered area");
        lookdrawing1.SetActive(true);
        lookdrawing2.SetActive(true);
        //drawing1.SetActive(true);
        //drawing1.SetActive(false, delaytime);
        }
        
    
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        if(other.CompareTag("Player"))
        {
            Debug.Log("player exited area");
            drawing1.SetActive(false);
            drawing2.SetActive(false);
            lookdrawing1.SetActive(false);
            lookdrawing2.SetActive(false);
        }
    }


}
