using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private int speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vert = Input.GetAxis("VerticalArrows");
        float horiz = Input.GetAxis("HorizontalArrows");

        GetComponent<Rigidbody2D>().velocity = new Vector2(horiz * speed, vert * speed);
    }
}
