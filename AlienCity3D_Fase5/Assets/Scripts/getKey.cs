using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getKey : MonoBehaviour {
    private GameObject Manager;
    private Manager GM;

    private void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        GM = Manager.GetComponent<Manager>();
    }

	//Pegar chaves
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.name == "key01") //verde
            {
                GM.hasGreen = true;
            }
            if (gameObject.name == "key02") //azul
            {
                GM.hasBlue = true;
            }
            VarTemp.holdKeys++;
            //Debug.Log(VarTemp.holdKeys);
            Destroy(gameObject);
        }

        
    }
}
