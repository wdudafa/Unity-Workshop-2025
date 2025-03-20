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
        Vector3Int pos = tileManager.GetMouseToTile();

        foreach (Plant plant in currentPlants)
        {
            if (plant.transform.position == pos)
            {
                print("Keep it, we don't want it");
                return;
            }
        }

        Plant newPlant = Instantiate(plantPrefab, plantsTransform).GetComponent<Plant>();
        newPlant.Set(seedClass);
        newPlant.transform.position = pos;
        currentPlants.Add(newPlant);
    }

    public void OnNewDay()
    {
        foreach(Plant plant in currentPlants)
        {
            if(plant.isWatered)
            {
                plant.growthIndex++;                
                //TO-DO Would need to check if at max, meaning it can be harvested
            }
            plant.isWatered = false;
            plant.SetVisual();
        }
    }

    public void WaterPlant()
    {
        Vector3Int plantPos = tileManager.GetMouseToTile();
        foreach (Plant plant in currentPlants)
        {
            if (plant.transform.position == plantPos && !plant.isWatered)
            {
                plant.isWatered = true;
                plant.SetVisual();
                return;
            }
        }
    }
}
