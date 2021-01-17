using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStage_Monster : MonoBehaviour
{

    public Sprite[] monster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject Monster = transform.parent.gameObject;
        GameObject HP = GameObject.Find("UI_1");
        if(col.gameObject.name == "Nemozzack")
        { 
            Monster.GetComponent<SpriteRenderer>().sprite = monster[1];
            Destroy(Monster.GetComponent<Rigidbody2D>());
            Destroy(Monster.GetComponent<Collider2D>());
            Destroy(HP);
            Destroy(GetComponent<Collider2D>());
        }
    }
}
