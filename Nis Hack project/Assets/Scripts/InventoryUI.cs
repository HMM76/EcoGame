using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    Dictionary<InventorySlots, GameObject> itemsDisplayed = new Dictionary<InventorySlots, GameObject>();
    public void CreateItemUI(WholeInventory inventory, Item _item, int _amount)
    {
        var obj = Instantiate(_item.Prefab, Vector3.zero, Quaternion.identity, transform);
        obj.GetComponentInChildren<Text>().text = _amount + "";
        itemsDisplayed.Add(inventory.Container[inventory.Container.Count - 1], obj);

    }
    public void UpdateItemUI(WholeInventory inventory, Item _item, int _amount)
    {
        for(int i = 0; i < inventory.Container.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
                itemsDisplayed[inventory.Container[i]].GetComponentInChildren<Text>().text = inventory.Container[i].amount + "";
            }
        }
    }
}
