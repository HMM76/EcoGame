using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float moveHor;
    float moveVer;
    public int speed = 2;
    public Rigidbody2D playerRB;
    bool isFacingRight = true;
    public Animator animator;
    public InventoryUI inventoryUI;
    public WholeInventory inventory;
    GameObject INventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHor = Input.GetAxis("Horizontal");
        animator.SetFloat("SpeedX", Mathf.Abs(moveHor));
        moveVer = Input.GetAxis("Vertical");
        animator.SetFloat("SpeedY", moveVer);
        if (moveHor > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveHor < 0 && isFacingRight)
        {
            Flip();
        }
        /*if (moveVer > 0 && !isFacingUp)
        {
            FlipY();
        }
        else if (moveVer < 0 && isFacingUp)
        {
            FlipY();
        }*/
        /*if (Input.GetKeyUp(KeyCode.C))
        {
            //inventory.PutItem(paper, 2, true);
        }*/
    }
    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(moveHor * speed, moveVer * speed);
    }
    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 TheScale = transform.localScale;
        TheScale.x *= -1;
        transform.localScale = TheScale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.GetComponent<Iteeem>();
        if (obj)
        {
            bool hasItem;
            inventory.AddItem(obj.item, 1, out hasItem);
            Destroy(collision.gameObject);
            if(hasItem == false)
            {
                inventoryUI.CreateItemUI(inventory, obj.item, 1);
            }
            else
            {
                inventoryUI.UpdateItemUI(inventory, obj.item, 1);
            }
        }
    }

    
        
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }

    
    /*void FlipY()
    {
        isFacingUp = !isFacingUp;
        Vector3 TheScale = transform.localScale;
        TheScale.x *= -1;
        transform.localScale = TheScale;
    }*/
}
