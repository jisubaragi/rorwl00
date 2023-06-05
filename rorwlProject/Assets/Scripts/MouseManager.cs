using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Vector2 worldPosition;
    public Transform[] restaurantPosition;
    public Camera mainCamera;
    public GameObject NextUI;
    public GameObject UI;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&AiManager.instance.numberManager.turn == 2)
        {
                Vector2 clickPosition = Input.mousePosition;
                worldPosition = mainCamera.ScreenToWorldPoint(clickPosition);
                AiManager.instance.numberManager.choosePlaceNum = FindClosestPoint() + 1;
                AiManager.instance.numberManager.turn++;
            TextManager.instance.isText = false;

                NextUI.SetActive(true);
                UI.SetActive(false);
        }
    }

    int FindClosestPoint()
    {
        float closestDistance = Mathf.Infinity;
        int index = 0;

        for (int i = 0; i < restaurantPosition.Length; i++)
        {
            float distance = Vector2.Distance(restaurantPosition[i].position, worldPosition);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                index = i;
            }
        }

        return index;
    }
}
