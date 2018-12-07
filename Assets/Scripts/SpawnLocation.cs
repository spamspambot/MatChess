using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{
    public bool hasPiece;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasPiece) {
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Piece")) hasPiece = true;

    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Piece")) hasPiece = false;

    }
}
