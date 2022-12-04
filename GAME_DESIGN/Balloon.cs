using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] AudioSource source;
    private GameObject balloon;
    private Scoring scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
       if (source == null){
        source = GetComponent<AudioSource>();
       } 

       if (scoreKeeper == null){
            scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<Scoring>();
        }

       InvokeRepeating("GrowBalloon", 5.0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localScale.x  > 0.8f|| gameObject.transform.localScale.y > 0.8f){
            CancelInvoke("GrowBalloon");
            // InvokeRepeating("ShrinkBalloon", 1f, 0.3f);
        }
    }

     private void OnTriggerEnter2D (Collider2D collision){
        if(collision.gameObject.tag == "Projectile"){
            AudioSource.PlayClipAtPoint(source.clip, transform.position);
            Destroy(gameObject);

            if (gameObject.transform.localScale.y == 0.8f)
                scoreKeeper.UpdateScore(0);

            if (gameObject.transform.localScale.y <= 0.75f && gameObject.transform.localScale.y > 0.7f)
                scoreKeeper.UpdateScore(1);

            if (gameObject.transform.localScale.y <= 0.7f && gameObject.transform.localScale.y > 0.65f)
                scoreKeeper.UpdateScore(2);

            if (gameObject.transform.localScale.y <= 0.65f && gameObject.transform.localScale.y > 0.6f)
                scoreKeeper.UpdateScore(3);

            if (gameObject.transform.localScale.y <= 0.6f && gameObject.transform.localScale.y > 0.5f)
                scoreKeeper.UpdateScore(4);    

            if (gameObject.transform.localScale.y == 0.5f) 
                scoreKeeper.UpdateScore(5);    
       }
    }

    private void GrowBalloon()
    {
        if(transform.localScale.x > 0f)
            gameObject.transform.localScale += new Vector3(.025f, .025f, 0f);
        else
            gameObject.transform.localScale += new Vector3(-.025f, .025f, 0f);
    }

    // private void ShrinkBalloon()
    // {
    //      if(transform.localScale.x > 0f && transform.localScale.x > 0.8f)
    //         gameObject.transform.localScale += new Vector3(-.025f, -.025f, -0f);
    //     else if (transform.localScale.x < 0f && transform.localScale.x > 0.8f)
    //         gameObject.transform.localScale += new Vector3(.025f, -.025f, -0f);
    // }

    
}
