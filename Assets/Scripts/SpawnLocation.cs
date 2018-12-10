﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{
    public int positionID;
    public int pieceID;
    public bool playerPiece;
    public bool hasPiece;
    public PieceManager pieceManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")) LoadGame();
        if (Input.GetKeyDown("s")) SaveGame();
        if (Input.GetKeyDown("w")) print("Position " + positionID + " contains " +GameData.savedPiece[positionID-1]);
        if (!hasPiece)
        {
        }
    }
    public void LoadGame()
    {
        if (pieceID > 0 && !hasPiece)
        {
            if (!playerPiece) { Instantiate(pieceManager.enemyPieces[GameData.savedPiece[positionID-1]], transform.position, Quaternion.identity); }

            else { Instantiate(pieceManager.playerPieces[GameData.savedPiece[positionID-1]], transform.position, Quaternion.identity); }
        }
    }

    public void SaveGame() {
        GameData.savedPiece[positionID-1] = pieceID;
    }

    public void ResetValues()
    {
        pieceID = 0;
        hasPiece = false;
        playerPiece = false;

    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Piece")) { pieceID = other.GetComponentInParent<PieceScript>().ID; hasPiece = true; }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Piece")) { pieceID = 0; hasPiece = false; }

    }
}
