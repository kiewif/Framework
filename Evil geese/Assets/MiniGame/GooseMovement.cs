﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseMovement : MonoBehaviour {

    public int speed;
    public Transform Spawn;
    public Transform end;
    public GameObject player;

    

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < end.position.y)
        {
            int charge = Random.Range(3, 20);
            if (charge == 5)
            {
                speed = 30;
            }
            speed = charge;

            transform.position = Spawn.position;
        }

        transform.Translate(new Vector3(0, (-1*speed), 0) * Time.deltaTime);

    }
}
