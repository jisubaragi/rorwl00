using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int btNumber;

    public GameObject UI;
    public GameObject NextUI;
    public bool ManagerOk = true;

    private void Update()
    {
        
    }

    public void Decision()
    {
        switch (AiManager.instance.numberManager.turn) 
        {
            case 1:
                //AiManager.instance.numberManager.choosePlaceNum = btNumber;
                AiManager.instance.numberManager.chooseYesorNo = btNumber;
                AiManager.instance.numberManager.turn++;
                break;
            case 3:
                AiManager.instance.numberManager.chooseWeatherNum = btNumber;
                AiManager.instance.numberManager.turn++;
                break;
            case 4:
                AiManager.instance.numberManager.chooseTempNum = btNumber;
                AiManager.instance.numberManager.turn++;
                break;
            case 5:
                AiManager.instance.numberManager.chooseSmallKindNum = btNumber;
                AiManager.instance.numberManager.turn++;
                break;
            case 6:
                AiManager.instance.numberManager.chooseBigKindNum = btNumber;
                AiManager.instance.numberManager.turn++;
                break;
        }

        TextManager.instance.isText = false;

        UI.SetActive(false);
        if (NextUI != null)
        {
            NextUI.SetActive(true);
        }
    }
}