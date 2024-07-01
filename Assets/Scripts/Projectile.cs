using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    private PointManager pointManager;

    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }


    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            pointManager.UpdateScore(1);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
