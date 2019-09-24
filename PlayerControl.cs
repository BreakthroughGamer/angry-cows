using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    bool isPressed = false;
    private Camera cam;
    Vector3 point = new Vector3();
    //Event currentEvent = Event.current;
    Vector2 mousePos = new Vector2();
    public GameObject cow;

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

            cow.transform.position = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
            //rb.position = point; 
        }
        
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
    }

}
