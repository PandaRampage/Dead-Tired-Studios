using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    public Inventory inv;
    public GameObject notice;
    public InvMan invMan;
    public Items i2p;

    private void OnTriggerStay(Collider collision)
    {
        if(collision.GetComponent<Player>())
        {
            notice.SetActive(true);
            if(Input.GetKey(KeyCode.Mouse0) )
            {

                notice.SetActive(false);
                Destroy(gameObject);
                if (inv.item5 == false)
                {
                    invMan.AddItems(i2p);
                    inv.Get5();
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
