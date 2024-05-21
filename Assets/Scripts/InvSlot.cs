using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InvSlot : MonoBehaviour
{
    public Image image;
    public Color selColor, unselColor;
    // Start is called before the first frame update
    void Awake()
    {
        Unselect();
    }
    public void Select()
    {
        image.color = selColor;
    }
    public void Unselect()
    {
        image.color = unselColor;
    }
}
