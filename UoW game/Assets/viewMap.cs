using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewMap : MonoBehaviour {
    public GameObject camobj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         if(Input.GetKeyDown("q"))
            {
            camobj.SetActive(true);
            }

       if(Input.GetKeyDown("e"))
        {
            camobj.SetActive(false);
        }

    }
}
