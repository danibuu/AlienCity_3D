using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	
    private GameObject[] key;
    public Animator porta;
    public bool hasBlue = false;
    public bool hasGreen = false;
    public bool canDoAction = false;
    public GameObject keylogger;
    private insertKeys inserirChaves;

	// Use this for initialization
	void Start () {
        key = GameObject.FindGameObjectsWithTag("key");
        
	}
	
	// Update is called once per frame
	void Update () {
        inserirChaves = keylogger.GetComponent<insertKeys>();

		if (Input.GetKeyDown(KeyCode.R))
        {
            if (canDoAction)
            {
                DoAction();
            }
        }
	}

    

    void DoAction()
    {        
		//chave verde
        if (hasGreen)
        {
            inserirChaves.greenKeyInsert.SetActive(true);
            hasGreen = false;
        }
        //chave azul.
        if (hasBlue)
        {
            inserirChaves.blueKeyInsert.SetActive(true);
            hasBlue = false;
        }
        //Abre a porta com as chaves.
        if (VarTemp.holdKeys == key.Length)
        {
            VarTemp.holdKeys = 0;
            DoorOpen();
        }
    }

	void DoorOpen()
	{
		keylogger.GetComponent<Collider>().enabled = false;
		porta.SetTrigger("open");
	}
}
