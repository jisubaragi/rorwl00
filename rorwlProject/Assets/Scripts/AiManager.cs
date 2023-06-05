using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManager : MonoBehaviour
{
    public static AiManager instance;

    public NumberManager numberManager;
    public PrefabManager prefabManager;
    public Transform tfFoodPrefab;

    public bool isFood;
    public GameObject[] readyFoodPrefabs;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (numberManager.turn == 7)
        {
            if (!isFood)
            {
                MakeFood();
            }
        }
    }

    void MakeFood()
    {
        int index01 = 0;
        int index02 = 0;
        int index03 = 0;

        int randomNumber02 = Random.Range(1,6);
        int randomNumber03 = Random.Range(1,6);

        // 음식 프리펩 저장
        for (int j = 0; j < 3; j++)
        {
            if (j == 2)
            {
                readyFoodPrefabs = new GameObject[index02];
            }

            if (!isFood)
            {
                if (numberManager.choosePlaceNum == 1)
                {
                    for (int i = 0; i < prefabManager.food01Prefabs.Length; i++)
                    {
                        if (numberManager.chooseSmallKindNum == 6)
                        {
                            numberManager.chooseSmallKindNum = randomNumber02;
                        }
                        if (prefabManager.food01Prefabs[i].GetComponent<FoodManager>().foodNumber.foodSmallKindNum == numberManager.chooseSmallKindNum)
                            {
                                if (j > 0 && index01 == 0)
                                {
                                    if (j == 1)
                                    {
                                        index02++;
                                    }
                                    else if (j == 2)
                                    {
                                        readyFoodPrefabs[index03] = prefabManager.food01Prefabs[i];
                                        index03++;
                                    }
                                }
                                else
                                {
                                    if (numberManager.chooseBigKindNum == 6)
                                    {
                                        numberManager.chooseBigKindNum = randomNumber03;
                                    }

                                    if (prefabManager.food01Prefabs[i].GetComponent<FoodManager>().foodNumber.foodBigKindNum == numberManager.chooseBigKindNum)
                                        {
                                            if (j == 0)
                                            {
                                                index01++;
                                            }
                                            else if (j == 1)
                                            {
                                                index02++;
                                            }
                                            else if (j == 2)
                                            {
                                                readyFoodPrefabs[index03] = prefabManager.food01Prefabs[i];
                                                index03++;
                                            }
                                        }
                                }
                            }
                    }
                }
                else if (numberManager.choosePlaceNum == 2)
                {
                    for (int i = 0; i < prefabManager.food02Prefabs.Length; i++)
                    {
                        if (numberManager.chooseSmallKindNum == 6)
                        {
                            numberManager.chooseSmallKindNum = randomNumber02;
                        }
                        if (prefabManager.food02Prefabs[i].GetComponent<FoodManager>().foodNumber.foodSmallKindNum == numberManager.chooseSmallKindNum)
                        {
                            if (j > 0 && index01 == 0)
                            {
                                if (j == 1)
                                {
                                    index02++;
                                }
                                else if (j == 2)
                                {
                                    readyFoodPrefabs[index03] = prefabManager.food02Prefabs[i];
                                    index03++;
                                }
                            }
                            else
                            {
                                if (numberManager.chooseBigKindNum == 6)
                                {
                                    numberManager.chooseBigKindNum = randomNumber03;
                                }

                                if (prefabManager.food02Prefabs[i].GetComponent<FoodManager>().foodNumber.foodBigKindNum == numberManager.chooseBigKindNum)
                                {
                                    if (j == 0)
                                    {
                                        index01++;
                                    }
                                    else if (j == 1)
                                    {
                                        index02++;
                                    }
                                    else if (j == 2)
                                    {
                                        readyFoodPrefabs[index03] = prefabManager.food02Prefabs[i];
                                        index03++;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (numberManager.choosePlaceNum == 3)
                {
                    for (int i = 0; i < prefabManager.food03Prefabs.Length; i++)
                    {
                        if (numberManager.chooseSmallKindNum == 6)
                        {
                            numberManager.chooseSmallKindNum = randomNumber02;
                        }
                        if (prefabManager.food03Prefabs[i].GetComponent<FoodManager>().foodNumber.foodSmallKindNum == numberManager.chooseSmallKindNum)
                        {
                            if (j > 0 && index01 == 0)
                            {
                                if (j == 1)
                                {
                                    index02++;
                                }
                                else if (j == 2)
                                {
                                    readyFoodPrefabs[index03] = prefabManager.food03Prefabs[i];
                                    index03++;
                                }
                            }
                            else
                            {
                                if (numberManager.chooseBigKindNum == 6)
                                {
                                    numberManager.chooseBigKindNum = randomNumber03;
                                }

                                if (prefabManager.food03Prefabs[i].GetComponent<FoodManager>().foodNumber.foodBigKindNum == numberManager.chooseBigKindNum)
                                {
                                    if (j == 0)
                                    {
                                        index01++;
                                    }
                                    else if (j == 1)
                                    {
                                        index02++;
                                    }
                                    else if (j == 2)
                                    {
                                        readyFoodPrefabs[index03] = prefabManager.food03Prefabs[i];
                                        index03++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        int randomNumber01 = Random.Range(0, index02);

        GameObject makeFood = Instantiate(readyFoodPrefabs[randomNumber01], tfFoodPrefab.position, Quaternion.identity);
        makeFood.transform.position = tfFoodPrefab.position;

        isFood = true;
    }
}

[System.Serializable]
public class NumberManager
{
    public int turn;
    public int chooseYesorNo;
    public int choosePlaceNum;
    public int chooseWeatherNum;
    public int chooseTempNum;
    public int chooseSmallKindNum;
    public int chooseBigKindNum;
}
