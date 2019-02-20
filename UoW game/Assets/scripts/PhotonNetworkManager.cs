using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using Mapbox.Examples;

public class PhotonNetworkManager : Photon.PunBehaviour {
    [SerializeField] private Text connectText;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Clone;
    //[SerializeField] private Transform spawn;
    [SerializeField] private GameObject lobbyCamera;
    //[SerializeField] public Camera miniCamera;
    //public string latlong;
    public gps CurrentLiveLocation;
    
    //public Canvas canas;
    //[SerializeField] public GameObject minimapTargetTexture;
    Color synccolor; Vector3 tempcolor;
    public GameObject locationobj;
    public displayLatLon refe;
   // public Transform analogStick;
    //public Transform t;
   // public GameObject canvasinstance;
   // private GameObject mini;
    //private  GameObject 
    
    //Vector v3=transform.spawnPoint.
   public  SpawnOnMap SpawnPoint;
    //[SerializeField] private Transform spawnPoint;
    displayLatLon dc;
    //  setaschild sac = new setaschild();
    //Transform t = s.instance.transform.localPosition

    // [SerializeField] private Text connectText;

    private void Awake()
    {
        //latlong = ggppss.latitude.ToString() + "," + ggppss.longitude.ToString();
        //s.latlongg = latlong;
        
    }
    // Use this for initialization
    void Start () {
       
        PhotonNetwork.ConnectUsingSettings("0.1");
	}
	
    public virtual void OnJoinedLobby()
    {
        //s.enabled = true;
        Debug.Log("we are noew connected to lobby");
        PhotonNetwork.JoinOrCreateRoom("New", null, null);
    }
    public virtual void OnJoinedRoom()
    {
        SpawnPoint.AfterenteringLobby();
       // spawnPoint = SpawnPoint._markerPrefab.transform;
        Clone =(GameObject)PhotonNetwork.Instantiate(player.name, SpawnPoint.ti.position, SpawnPoint.ti.rotation, 0);
        refe._referenceCamera = Clone.transform.GetChild(0).GetComponent<Camera>();
        Clone.transform.GetChild(1).GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Clone.transform.GetChild(2).GetComponent<Renderer>().material.color= Clone.transform.GetChild(1).GetComponent<Renderer>().material.color;
        Clone.transform.GetChild(3).GetComponent<Renderer>().material.color = Clone.transform.GetChild(1).GetComponent<Renderer>().material.color;
        Clone.transform.GetChild(4).GetComponent<Renderer>().material.color = Clone.transform.GetChild(1).GetComponent<Renderer>().material.color;
        Clone.transform.GetChild(5).GetComponent<Renderer>().material.color = Clone.transform.GetChild(1).GetComponent<Renderer>().material.color;
        Clone.transform.GetChild(6).GetComponent<Renderer>().material.color = Clone.transform.GetChild(1).GetComponent<Renderer>().material.color; 
        //Transform analogStick = Clone.transform;
      //  Instantiate(analogStick);
        Transform canas = Clone.transform;
        Instantiate(canas);
        locationobj.SetActive(true);
       // t = player.transform;
        lobbyCamera.SetActive(true);
        
    }
	// Update is called once per frame
	void Update () {
       // spawnPoint = SpawnPoint._markerPrefab.transform;
        // Clone.GetComponent<PhotonView>().RPC("setRed", PhotonTargets.AllBuffered, null);
        connectText.text = PhotonNetwork.connectionStateDetailed.ToString();
    }
 }
// miniCamera.transform.rotation=player.transform.rotation;
// Debug.Log("after entering lobby");
//s._locationStrings[0] = latlong;
// s.ti
//  spawnPoint = player.gameObject;

//  photonView.RPC("ColorRed", PhotonTargets.AllBuffered, null);
//Clone.transform.GetChild(6).GetComponent<Renderer>().material.color = Clone.transform.GetChild(2).GetComponent<Renderer>().material.color;

//sac.cll();
//locationobj = player;
//PhotonNetwork.Instantiate(miniCamera.name, spawnPoint.transform.position, spawnPoint.transform.rotation, 0);
//Transform transform1 = miniCamera.transform;
// Instantiate(miniCamera,miniCamera.transform.position, miniCamera.transform.rotation);
// miniCamera.transform.parent = player.transform;
//miniCamera = player.transform.GetChild(4).GetComponent<Camera>();

//   Clone.GetComponent<PhotonView>().RPC("setRed", PhotonTargets.AllBuffered,null);
// PhotonNetwork.Clone.SetCustomProperties
// PhotonNetwork.playerList=

// dc.assignCamera();
// refe._referenceCamera = miniCamera;
//dc.o = player;

// PhotonNetwork.Instantiate(miniCamera.name, spawnPoint.transform.position, spawnPoint.transform.rotation, 0);
//PhotonNetwork.Instantiate(mini);
// Instantiate(miniCamera);
//mini.transform.parent = player.transform;