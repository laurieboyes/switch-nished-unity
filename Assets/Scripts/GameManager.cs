using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Grid grid;
    private List<GameObject> structures;

    void Start()
    {
        Object dwellingPrefab = Resources.Load("Dwelling");
        structures = new List<GameObject>();

        for (int i = 0; i < 10; i++)
        {
            GameObject dwelling = Instantiate(dwellingPrefab) as GameObject;
            Structure dwellingStructure = dwelling.GetComponent<Structure>();
            dwellingStructure.gridPosition = new Vector2Int(i, 0);

            dwelling.transform.position = grid.CellToWorld(new Vector3Int(dwellingStructure.gridPosition.x, dwellingStructure.gridPosition.y, 0));

            structures.Add(dwelling);

        }
    }

    void Update()
    {
    }
}
