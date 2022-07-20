using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType{
    plastic,
    paper
}

public abstract class Item : ScriptableObject
{
    public GameObject Prefab;
    public int ItemID;
    public ItemType type;
    [TextArea(5,20)]
    public string description;

}
