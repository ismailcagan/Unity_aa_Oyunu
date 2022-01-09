using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject ok;
    void Start()
    {
        okuret();
    }
    void Update()
    {
        mousetıklama();
    }
    public void mousetıklama()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            okuret();
        }
    }
    public void okuret()
    {
        Instantiate(ok, new Vector2(0.03323587f, -4.032312f), transform.rotation);
    }
}
