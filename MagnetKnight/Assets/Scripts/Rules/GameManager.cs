﻿using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    //Awake is always called before any Start functions
    void Awake()
    {
        if (instance == null) 
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
