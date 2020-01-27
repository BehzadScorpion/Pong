using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    private float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("HorizontalWASD");
        float vert = Input.GetAxis("VerticalWASD");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horiz* speed, vert * speed);
    }
}
