using Mapbox.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gps : MonoBehaviour {
    public static gps Instance { set; get; }
    public float latitude;
    public float longitude;
    public SpawnOnMap spawnOnMap;
	// Use this for initialization
	private void Start () {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());  
	}
    private IEnumerator StartLocationService()
    {if(!Input.location.isEnabledByUser)
        {
            Debug.Log("User has not enabled GPS");
            yield break;
        }
        Input.location.Start();
        int maxWait = 20;
        while(Input.location.status==LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if(maxWait<=0)
        {
            Debug.Log("Timed out");
            yield break;
        }
        if(Input.location.status==LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;
        }
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        spawnOnMap.enabled = true;
        spawnOnMap.latlongg= latitude.ToString() + "," + longitude.ToString();
        Debug.Log("check");
        yield break;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
