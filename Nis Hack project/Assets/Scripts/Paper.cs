using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PaperObject", menuName = "Inventory/Items/Paper")]

public class Paper : Item
{
    public void Awake()
    {
        type = ItemType.paper;
    }
}
