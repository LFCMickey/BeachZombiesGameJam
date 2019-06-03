using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMotion : MonoBehaviour
{
    public float Speed = -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector3(Speed * Time.deltaTime, 0, 0); ;    
    }
}
