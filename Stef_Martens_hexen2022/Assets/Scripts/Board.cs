using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private LayerMask _piecesLayer;

    [SerializeField]
    private LayerMask _tilesLayer;
    Tile[] allTiles;

    public void OnEnable()
    {
        allTiles = GameObject.FindObjectsOfType<Tile>();
    }


    public void Select(Tile tile)
    {
        tile.Highlight();
        List<Tile> neighbours = new List<Tile>();
        foreach (var item in allTiles)
        {
            if ((item.Q == tile.Q || item.Q + 1 == tile.Q || item.Q - 1 == tile.Q) &&
            (item.R == tile.R || item.R - 1 == tile.R || item.R + 1 == tile.R) &&
            (item.S == tile.S || item.S + 1 == tile.S || item.S - 1 == tile.S))
            {
                neighbours.Add(item);
            }
        }
        foreach (var item in neighbours)
        {
            item.Highlight();
        }
    }
}
