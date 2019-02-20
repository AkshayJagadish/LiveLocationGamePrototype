namespace Mapbox.Examples
{
    using UnityEngine;
    using Mapbox.Utils;
    using Mapbox.Unity.Map;
    using Mapbox.Unity.MeshGeneration.Factories;
    using Mapbox.Unity.Utilities;
    using System.Collections.Generic;

    public class SpawnOnMap : MonoBehaviour
    {
        public gps ggpps;
        [SerializeField]
        AbstractMap _map;
        public string latlongg;
        public PhotonNetworkManager pmm;

        [SerializeField]
        [Geocode]
        public string[] _locationStrings;
        Vector2d[] _locations;
        public Transform ti;

        [SerializeField]
        float _spawnScale = 100f;

        [SerializeField]
        public GameObject _markerPrefab;

        public List<GameObject> _spawnedObjects;
        private void Awake()
        {
            // _locationStrings[0] = ggpps.latitude.ToString() + "," + ggpps.longitude.ToString(); 
        }
        public void AfterenteringLobby()
        {
            Debug.Log(latlongg);
            _locationStrings[0] = ggpps.latitude.ToString() + "," + ggpps.longitude.ToString();
            //_locationStrings[0] = latlongg;
            // _locationStrings[0] = pmm.latlong;
            Debug.Log("after entering lobby");
            _locations = new Vector2d[_locationStrings.Length];
            _spawnedObjects = new List<GameObject>();
            for (int i = 0; i < _locationStrings.Length; i++)
            {
                Debug.Log("check1");
                // latlongg = ggppss.latitude.ToString() + "," + ggppss.longitude.ToString();
                var locationString = _locationStrings[i];
                _locationStrings[0] = latlongg;
                var latlon = _locationStrings[0];
                //latlong = latlon;
                // _locationStrings[0] = latlongg;
                //_locationStrings[0] = pmm.latlong;
                Debug.Log("acheck2");
                _locations[i] = Conversions.StringToLatLon(locationString);
                Debug.Log("check3");
                var instance = Instantiate(_markerPrefab);
                Debug.Log("check4");
                ti = instance.transform;

                instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
                instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
                _spawnedObjects.Add(instance);
                Debug.Log("ainstance sdded");

            }
        }
        private void Update()
        {
            _locationStrings[0] = latlongg;
            //_locationStrings[0]=  ggpps.latitude.ToString() + "," + ggpps.longitude.ToString();
            int count = _spawnedObjects.Count;
            for (int i = 0; i < count; i++)
            {
                var spawnedObject = _spawnedObjects[i];
                var location = _locations[i];
                spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
                spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
            }
        }
    }
}
        