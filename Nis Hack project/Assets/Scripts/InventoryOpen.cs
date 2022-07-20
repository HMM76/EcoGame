using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpen : MonoBehaviour
{
    private GameObject InventoryRef;
    public bool Inventoryopen = false;

    void Start()
    {
        InventoryRef = GameObject.Find("INventory");
        InventoryRef.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (!Inventoryopen)
            {
                OpenTheInv();
            }
            else
            {
                CloseTheInv();
            }
        }
    }
    public void OpenTheInv()
    {
        InventoryRef.SetActive(true);
        Inventoryopen = true;
    }
    public void CloseTheInv()
    {
        InventoryRef.SetActive(false);
        Inventoryopen = false;
    }
}
