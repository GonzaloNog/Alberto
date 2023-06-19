using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer ren;
    public Vector3 trans;
    public Vector3 pos;
    void Start()
    {
        ren.color = Color.red;
        this.transform.localScale = trans;
        this.transform.position = pos;
    }

    void Update()
    {
        Debug.Log("loop");
    }
}
