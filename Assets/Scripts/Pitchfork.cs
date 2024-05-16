using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitchfork : MonoBehaviour
{
    public Inventory inv;
    public GameObject notice;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider collision)
    {
        if(collision.GetComponent<Move>())
        {
            notice.SetActive(true);
            if(Input.GetKey(KeyCode.Mouse0))
            {
                inv.Get2();
                Destroy(gameObject);
                notice.SetActive(false);
                image.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Move>())
        {      
            notice.SetActive(false);
        }  
    }
}
