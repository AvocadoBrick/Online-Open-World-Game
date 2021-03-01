using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class RPCscript : MonoBehaviourPun
{
    private Text text;
    public InputField inpt;
    // Start is called before the first frame update
    void Start()
    {
        GameObject canvasobject = GameObject.FindGameObjectWithTag("text");
        text = canvasobject.GetComponentInChildren<Text>();
    }
    [PunRPC]
    void changetext(string textRPC)
    {
        text.text = textRPC;
    }
    public void callrpc()
    {
        photonView.RPC("changetext", RpcTarget.All, inpt.text);
    }
}
