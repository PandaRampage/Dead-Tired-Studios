using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvMan : MonoBehaviour
{
    public Items item;
    public InvSlot[] iSlots;
    public GameObject iPrefab;
    int selSlot = -1;
    void Start()
    {
        ChSelSlot(0);
    }
    void Update()
    {
        float scroll = - Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0) 
        {
            int newVal = selSlot + (int)(scroll / Mathf.Abs(scroll));
            if (newVal < 0)
            {
                newVal = iSlots.Length - 1;
            }
            else if (newVal >= iSlots.Length)
            {
                newVal = 0;
            }
            ChSelSlot(newVal);
            
        }
        //GetSelItem();
    }
    void ChSelSlot(int newVal)
    {
        if (selSlot >= 0)
        {
            iSlots[selSlot].Unselect();
        }
        iSlots[newVal].Select();
        selSlot = newVal;
    }
    public Items GetSelItem()
    {
        InvSlot slot = iSlots[selSlot];
        InvItem inSlot= slot.GetComponentInChildren<InvItem>();
        if (inSlot != null)
        {
            item = inSlot.item;
            //Debug.Log (item);
        }else{
            item = null;
        }
        return null;
    }
    public void ItemUsed()
    {
        InvSlot slot = iSlots[selSlot];
        InvItem inSlot= slot.GetComponentInChildren<InvItem>();
        Destroy(inSlot.gameObject);
    }
    public void AddItems (Items item)
    {
        for (int i=0; i<iSlots.Length; i++)
        {
            InvSlot slot = iSlots[i];
            InvItem inSlot= slot.GetComponentInChildren<InvItem>();
            if (inSlot == null)
            {
                SpawnItem(item, slot);
                GetSelItem();
                return;
            }
        }
    } 
    public void SpawnItem(Items item, InvSlot slots)
    {
       GameObject newItemGo = Instantiate (iPrefab, slots.transform);
       InvItem invItem = newItemGo.GetComponent<InvItem>();
       invItem.InitItem(item);
    }
}
