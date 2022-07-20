using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "OnlyInventory", menuName = "Inventory/OnlyInv")]

public class WholeInventory : ScriptableObject
{
    public List<InventorySlots> Container = new List<InventorySlots>();

    public void AddItem(Item _item, int _amount, out bool hasItem)
    {
        hasItem = false;
        for(int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if(hasItem == false)
        {
            Container.Add(new InventorySlots(_item, _amount));
        }
    }

    public void PutItem(Item _item, int _amount, out bool hasItem)
    {
        hasItem = true;
        
        if (hasItem == true)
        {
            Container.Remove(new InventorySlots(_item, _amount));
        }
    }
}
[System.Serializable]
public class InventorySlots
{
    public int amount;
    public Item item;

    public InventorySlots(Item _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
}
