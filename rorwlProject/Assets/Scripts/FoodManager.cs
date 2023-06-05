using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public FoodNumber foodNumber;
}

[System.Serializable]
public class FoodNumber
{
    public int foodPlaceNum;
    public int foodWeatherNum;
    public int foodTempNum;
    public int foodSmallKindNum;
    public int foodBigKindNum;
}