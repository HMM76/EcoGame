using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableYellow : MonoBehaviour
{
    public bool isOpened = false;
    private GameObject BinRef;
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    // Start is called before the first frame update
    void Start()
    {
        BinRef = GameObject.Find("MrBin0");
        BinRef.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                if (!isOpened)
                {
                    interactAction.Invoke();
                    OpenTheBin();
                }
                else
                {
                    CloseTheBin();
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("InRange");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("NotInRange");
        }
    }
    public void OpenTheBin()
    {
        BinRef.SetActive(true);
        isOpened = true;
    }
    public void CloseTheBin()
    {
        BinRef.SetActive(false);
        isOpened = false;
    }
}