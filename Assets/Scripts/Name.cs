using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Name : NetworkBehaviour
{
    [SyncVar(hook = "InputName")]
    public string PlayerName = "Test";



    void InputName(string newname)
    {
        if(!isServer)
        {
            return;
        }
        PlayerName = newname;
        Debug.Log("Name Changed");
    }
}
