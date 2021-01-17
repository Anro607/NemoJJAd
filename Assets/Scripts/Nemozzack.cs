using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nemozzack : MonoBehaviour
{
    public Sprite[] zzack;

    public float speed = 10.0f;
    public float jump = 500.0f;
    public float down = -800.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1.2f)
        {
            GetComponent<SpriteRenderer>().sprite = zzack[0];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jump));
                GetComponent<SpriteRenderer>().sprite = zzack[1];
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if(Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, GetComponent<Rigidbody2D>().velocity.y);
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, down));
                GetComponent<SpriteRenderer>().sprite = zzack[2];
            }
        }

    }
}
