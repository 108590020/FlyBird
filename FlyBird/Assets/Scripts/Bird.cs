using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //It's not moved or controlled by physics objects or the physics system on its own.
        GetComponent<Rigidbody2D>().isKinematic = true;
    }
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
