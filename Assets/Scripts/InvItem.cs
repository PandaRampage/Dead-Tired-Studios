using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InvItem : MonoBehaviour
{
    public Items item;

    [Header("UI")]
    public Image image;

    public void InitItem(Items newItem)
    {
        item = newItem;
        image.sprite = newItem.image;
    }
    
}
