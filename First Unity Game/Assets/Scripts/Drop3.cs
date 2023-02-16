using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop3 : MonoBehaviour
{
    private  Rigidbody2D new_item;

    // Start is called before the first frame update
    void Start()
    {
        new_item = GetComponent<Rigidbody2D>();
        new_item.AddForce(transform.right * -500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
