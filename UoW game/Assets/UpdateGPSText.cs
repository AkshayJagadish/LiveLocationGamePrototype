using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour {

    public Text coordinates;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
        coordinates.text = "Lat:" + gps.Instance.latitude.ToString() + "   Lon:" 
            + gps.Instance.longitude.ToString();
		
	}
}
