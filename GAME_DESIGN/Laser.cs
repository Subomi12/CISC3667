using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
  
    [SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Top"){
            Destroy(gameObject);
        }  

        if (collision.gameObject.tag == "Barrier"){
            Destroy(gameObject);
        }  

    }
}
