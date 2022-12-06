using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private LayerMask _piecesLayer;

    [SerializeField]
    private LayerMask _tilesLayer;


    public static void SelectNeighbours(Tile tile)
    {
        tile.Highlight();
        List<Tile> neighbours = new List<Tile>();
        var allTiles = GameObject.FindObjectsOfType<Tile>();
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

    public static void Teleport(Tile tile){
        
    }
}
