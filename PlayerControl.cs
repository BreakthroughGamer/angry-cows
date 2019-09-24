using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    
    public Rigidbody2D rb;
    public GameObject cow;
    public GameObject hook;

    bool isPressed;
    //KEEP
    bool yeet;
    private Camera cam;

    Vector2 mousePos = new Vector2();


    void Start()
    {
        cam = Camera.main;
        
    }

    void Update()
    {
            mousePos.x = Input.mousePosition.x;
            mousePos.y = Input.mousePosition.y;
        
        if (isPressed)
        {
            yeet = true;
            rb.AddRelativeForce(cam.ScreenToWorldPoint(new Vector2(mousePos.x, mousePos.y)));
            cow.transform.position = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10)); 
        }
        
        if (yeet)
        {
            rb.AddRelativeForce(new Vector2(7f, 5f));
        }
     
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
        //Debug.Log(isPressed + "<=Press || Kinetic=>" + rb.isKinematic);
        

    }

    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        
        // Add force to cow based on distance from origin
        //Shoot();

        //Debug.Log(isPressed + "<=Press || Kinetic=>" + rb.isKinematic);
        //Debug.Log(Physics.queriesHitTriggers);

    }
}
