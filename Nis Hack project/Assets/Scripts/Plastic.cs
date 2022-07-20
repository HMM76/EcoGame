using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlasticObject", menuName = "Inventory/Items/Plastic")]

public class Plastic : Item
{
    public void Awake()
    {
        type = ItemType.plastic;
    }
}
