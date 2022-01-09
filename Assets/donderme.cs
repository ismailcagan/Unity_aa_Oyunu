using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donderme : MonoBehaviour
{
    public int dondermehızı = 50;
    void Update()
    {
        transform.Rotate(0,0, dondermehızı * Time.deltaTime);
    }
}
