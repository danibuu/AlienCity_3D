using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    private GameObject[] key;
    public Animator porta;
	// Use this for initialization
	void Start () {
        key = GameObject.FindGameObjectsWithTag("key");
        //Debug.Log(key.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if(VarTemp.holdKeys == key.Length)
        {
            VarTemp.holdKeys = 0;
            DoorOpen();
        }
	}

    void DoorOpen()
    {
        porta.SetTrigger("open");
    }
}
