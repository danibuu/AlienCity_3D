using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {

    public GameObject malha;
    public GameObject arma;
    public Camera cmr;
    private PlayerController pc;
    private int HP = 10;
    public bool isDead = false;
	// Use this for initialization
	void Start () {
        pc = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (HP < 0 && !isDead)
        {
            HP = 0;
            isDead = true;
            die();
        }
	}

    public void die()
    {
        pc.enabled = false;
        malha.SetActive(false);
        arma.SetActive(false);
        cmr.transform.parent = null;
    }

    public void takeDamage(int hp)
    {
        if(HP>=0 && !isDead)
        {
            HP -= hp;
        }
    }
}
