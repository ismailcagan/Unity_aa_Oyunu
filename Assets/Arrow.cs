using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [Range(0,10)]public float speed = 1;
    public bool stop;
    void Update()
    {
        if (!stop)
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "daire")
        {
            Debug.Log("aa");
            stop = true;
            transform.parent = collision.transform;
        }
        if (collision.gameObject.tag == "ok")
        {
            Debug.Log("yandın");
            Time.timeScale = 0;
            stop = false;
        }
    }
}
