using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getKey : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VarTemp.holdKeys++;
            //Debug.Log(VarTemp.holdKeys);
            Destroy(gameObject);
        }
    }
}
