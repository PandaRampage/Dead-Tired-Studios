using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool item1 = false;
    public bool item2 = false;
    public bool item3 = false;
    public bool item4 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Get1()
    {
        item1 = true;
    }
    public void Get2()
    {
        item2 = true;
    }
    public void Get3()
    {
        item3 = true;
    }
}
