using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    public TileManager tileManager;
    public Transform plantsTransform;
    public List<Plant> currentPlants = new List<Plant>();
    public GameObject plantPrefab;

    private void Start()
    {
        tileManager = GetComponent<TileManager>();
    }

    public void AddNewPlant(SeedClass seedClass)
    {
        Plant newPlant = Instantiate(plantPrefab, plantsTransform).GetComponent<Plant>();
        newPlant.Set(seedClass);
        newPlant.transform.position = tileManager.GetMouseToTile();
        currentPlants.Add(newPlant);
    }
}
