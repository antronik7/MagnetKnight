using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetController : MonoBehaviour {

    BoxCollider2D boxCollider2D;

    // Use this for initialization
    void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        foreach (Touch touch in Input.touches)
        {

        }
	}
}
