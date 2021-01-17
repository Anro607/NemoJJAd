using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullat : MonoBehaviour
{

    public float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "dirt_Collider")
        {
            Debug.Log("sfdsf");
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().gravityScale = 2;
            transform.Rotate(new Vector3(0, 0, -30));
        }
        else if(col.gameObject.name == "dirt_Collider")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.01f, GetComponent<Rigidbody2D>().velocity.y);
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<Collider2D>());
            Destroy(this.gameObject, 3);
            Debug.Log("hfsjkfdf");
        }

    }
}
