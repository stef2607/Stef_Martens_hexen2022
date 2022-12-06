using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Tile[] allTiles;

    public void OnEnable()
    {
        allTiles = GameObject.FindObjectsOfType<Tile>();
    }

    void Start()
    {
        foreach (var item in allTiles)
        {
            if (item.Q == 0 && item.R == 0)
            {
                ChangePosition(item);
            }
        }
    }


    public void ChangePosition(Tile destination)
    {
        gameObject.transform.position = destination.gameObject.transform.position;
        gameObject.transform.position += new Vector3(0, 0.208152f, 0);
    }
}
