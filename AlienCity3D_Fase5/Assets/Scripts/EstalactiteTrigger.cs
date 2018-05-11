using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstalactiteTrigger : MonoBehaviour {

    private EstalactiteActive[] filhos;
    private float tempoParaAtivar;
    private bool podeAtivar = true;

    void Start()
    {
        filhos = GetComponentsInChildren<EstalactiteActive>();
        //Debug.Log(filhos.Length);
    }

    private void Update()
    {
        if (tempoParaAtivar < Time.time && !podeAtivar)
        {
            podeAtivar = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && podeAtivar)
        {
            podeAtivar = false;
            tempoParaAtivar = Time.time + 6.5f;
            foreach (var codigo in filhos)
            {
                codigo.ativar();
            }
        }
    }
}
