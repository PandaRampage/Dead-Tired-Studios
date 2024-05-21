using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockKey : MonoBehaviour
{
    public Inventory inv;
    public GameObject notice;
    public InvMan invMan;
    public Items i2p;
    //public GameObject image;
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
        if(collision.GetComponent<Player>())
        {
                notice.SetActive(true);
                if(Input.GetKey(KeyCode.Mouse0))
                {

                    notice.SetActive(false);
                    //image.SetActive(true);
                    if (inv.item3 == false)
                    {
                    invMan.AddItems(i2p);
                    inv.Get3();
                    Destroy(gameObject);
                    }
                }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Player>())
        {      
            notice.SetActive(false);
        }  
    }
}
