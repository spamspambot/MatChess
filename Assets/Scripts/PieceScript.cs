using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceScript : MonoBehaviour {
    public GameObject evolutionTarget;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Piece")) {
            Instantiate(evolutionTarget, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
