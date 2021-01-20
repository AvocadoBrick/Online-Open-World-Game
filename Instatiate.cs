using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Instatiate : MonoBehaviour
{
    [SerializeField] private GameObject PLayerPrefab = null;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(PLayerPrefab.name, new Vector3(Random.Range(-10.0f, 10.0f), 2f, 0), Quaternion.identity);
    }
}
