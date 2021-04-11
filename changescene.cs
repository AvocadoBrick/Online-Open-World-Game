using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviourPun
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(PhotonNetwork.IsMasterClient);
    }

    public void sceneselect()
    {
        SceneManager.LoadScene("Game 1");
    }
}
