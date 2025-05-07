using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inventoryimage;
    bool istrue;

    void Start()
    {
        istrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            istrue = true;
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            istrue = false;
        }
        if (istrue)
        {
            inventoryimage.SetActive(true);
        }
        else
        {
           inventoryimage.SetActive(false);
        }
    }
}
