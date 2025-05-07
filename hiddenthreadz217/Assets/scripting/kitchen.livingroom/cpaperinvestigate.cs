using UnityEngine;

public class cpaperinvestigate : MonoBehaviour
{
    public string targetTag = "Player";
    //public float delaytime = 4f;
    
    //counter papers
    public GameObject paper1;
    public GameObject paper2;
    
    //FRIDGE TEXT INVESTIATION

    public GameObject lookpaper1;
    public GameObject lookpaper2;

    // BOOLLSLSLRGOLKJSNROFGNKJ
    
    private bool bypaper = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bypaper == true && Input.GetKey(KeyCode.K))
        {
            lookpaper1.SetActive(false);
            lookpaper2.SetActive(true);
            paper1.SetActive(true);
            paper2.SetActive(false);
        }

        if(bypaper == true && Input.GetKey(KeyCode.J))
        {
            lookpaper2.SetActive(false);
            lookpaper1.SetActive(true);
            paper2.SetActive(true);
            paper1.SetActive(false);
        }

        if(bypaper == true && Input.GetKey(KeyCode.X))
        {
            paper1.SetActive(false); 
            paper2.SetActive(false);
            lookpaper1.SetActive(true);
            lookpaper2.SetActive(true);

        }
    }

        void OnTriggerEnter(Collider other)
    {
        bypaper = true;

        Debug.Log("player entered area");
        lookpaper1.SetActive(true);
        lookpaper2.SetActive(true);
        
    
    }

    void OnTriggerExit(Collider other)
    {
        bypaper = false;
        if(other.CompareTag("Player"))
        {
            Debug.Log("player exited area");
            paper1.SetActive(false);
            paper2.SetActive(false);
            lookpaper1.SetActive(false);
            lookpaper2.SetActive(false);
        }
    }
}
