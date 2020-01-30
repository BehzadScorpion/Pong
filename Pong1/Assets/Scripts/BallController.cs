using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour 
{
    private float randomX, randomY, speed;
    private Rigidbody2D rbody;
    public float x, y;
    //private float topColliderY, bottomColliderY;


    // Start is called before the first frame update
    void Start()
    {
        //speed = 4.5f;
        speed = 7f;
        randomX = Random.Range(-1f, 1f);
        randomY= Random.Range(-1f, 1f);
        rbody = GetComponent<Rigidbody2D>();
        x = randomX * speed;
        y = randomY * speed;
        rbody.velocity = new Vector2(x, y);
        //topColliderY =  float.Parse(GameObject.FindGameObjectWithTag("TopCollider").GetComponent<Transform>().position.ToString());
        //bottomColliderY = float.Parse(GameObject.FindGameObjectWithTag("BottomCollider").GetComponent<Transform>().position.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
   
        
        
       
    }
}
