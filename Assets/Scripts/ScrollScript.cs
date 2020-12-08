using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{

    public float speed 	= 0;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Renderer>().material.mainTextureOffset 	= new Vector2 (Time.time * speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
