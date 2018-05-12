using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class insertKeys : MonoBehaviour {
    private Manager Gerenciador;
    private GameObject GerenciadorObj;
    public GameObject blueKeyInsert;
    public GameObject greenKeyInsert;
    
    public Text texto;
	// Use this for initialization
	void Start () {
        GerenciadorObj = GameObject.FindGameObjectWithTag("Manager");
        Gerenciador = GerenciadorObj.GetComponent<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Aproximar da máquina de cartão
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            texto.text = "Pressione a tecla 'R' para inserir as chaves.";
            Gerenciador.canDoAction = true;
            Invoke("desativaTexto", 3);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            texto.text = "";
            Gerenciador.canDoAction = false;
        }
    }

    void desativaTexto()
    {
        texto.text = "";
    }
}
