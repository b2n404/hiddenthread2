using Unity.VisualScripting;
using UnityEngine;

public class lamptext : MonoBehaviour

{

    public GameObject Lamptext;
    public GameObject pressX;
    public Light level1LAMP;



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
        if(other.gameObject.CompareTag("lamp"))
        {
            pressX.SetActive(true);
        }
    }

    void LateUpdate()
    {
        if(Input.GetKey(KeyCode.E))
        {
            pressX.SetActive(false);
            Lamptext.SetActive(true);

        }

        if(Input.GetKey(KeyCode.Tab))
        {
            Lamptext.SetActive(false);
        }

    }
}
