using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Movement : MonoBehaviour
{
    private Vector3 move;
    private float speed = 2.4f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(0f, 12 * speed, 0f);

        transform.position = transform.position + move * Time.deltaTime;
    }



    
}
