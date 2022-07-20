using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinOpening : MonoBehaviour
{
    public bool isOpened = false;

    public void OpenBin()
    {
        if (!isOpened)
        {
            isOpened = true;
            Debug.Log("BinIsOpened");
        }
    }
}
