using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory System/New Item")]
public class Items : ScriptableObject
{
    public Sprite image;
    [TextArea(15,20)]
    public string description;
}
