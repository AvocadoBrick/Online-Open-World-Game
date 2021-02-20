using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class data : MonoBehaviourPun
{
    public KeyCode Pushbutton = KeyCode.L;
    private PhotonView view;
    private GameObject lightinscene;
    // Start is called before the first frame update
    void Start()
    {
        view = photonView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Pushbutton))
        {
            if (view.IsMine)
            {
                PhotonNetwork.Instantiate("Point Light", new Vector3(2.89f, 1.784f, 1.3f), Quaternion.identity, 0);
            }
        }else if (Input.GetKeyUp(Pushbutton))
        {
            if  (view.IsMine)
            {
                lightinscene = GameObject.FindGameObjectWithTag("light");
                PhotonNetwork.Destroy(lightinscene);
            }
        }
    }
}
