using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Rigidbody2D rbody;
    private float speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float vert = Input.GetAxis("VerticalArrows");
       rbody.velocity = new Vector2(0f , vert * speed);
    }
}
