using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    private PlantManager plantManager;
    // Start is called before the first frame update
    void Awake()
    {
        plantManager = GetComponent<PlantManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewDay()
    {
        print("new day");
        plantManager.OnNewDay();
    }
}
