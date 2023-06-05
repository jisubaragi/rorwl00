using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public GameObject NextUI;
    public Text ChatText;  //채팅이 나오는 텍스트

    public string writerText = "";
    public bool isText;

    private void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        if (!isText)
        {
            //StartCoroutine(TextPrint());
            PrintText();
        }

        if(AiManager.instance.numberManager.turn == 0){
            if (Input.GetMouseButtonDown(0))
            {
                AiManager.instance.numberManager.turn++;
                isText = false;
            }
        }
    }

    void PrintText()
    {
        switch (AiManager.instance.numberManager.turn)
        {
            case 0:
                Chat00("Z...z..z");
                break;
            case 1:
                int randomNumber = Random.Range(1, 3);
                switch (randomNumber)
                {
                    case 1:
                        Chat00("어 뭐야 학식추천 받으려고?");
                        HideAndShow();
                        break;
                    case 2:
                        Chat00("뭐야.... 학식추천 받을래?");
                        HideAndShow();
                        break;
                }
                break;
            case 2:
                if (AiManager.instance.numberManager.chooseYesorNo == 1)
                {
                    Chat00("좋아, 지금 너가 있는곳은 어디야?");
                }
                else if (AiManager.instance.numberManager.chooseYesorNo == 2)
                {
                    Chat00("뭐야 그럼 왜깨운거야;;");
                }
                break;
            case 3:
                Chat00("날씨가 어때?");
                break;
            case 4:
                Chat00("온도는 어때?");
                break;
            case 5:
                Chat00("소종류?");
                break;
            case 6:
                Chat00("대종류?");
                break;
            case 7:
                Chat00("짜잔");
                break;
        }
        isText = true;
    }

    void Chat00(string narration)
    {
        ChatText.text = narration;
    }


    // 원진씨 코드
    IEnumerator Chat(string narration)
    {
        int a = 0;
        writerText = "";
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                AiManager.instance.numberManager.turn++;
                break;
            }
            yield return null;
        }
    }

    /*IEnumerator TextPrint()
    {
        switch (AiManager.instance.numberManager.turn)
        {
            case 0:
                yield return StartCoroutine(Chat("Z...z..z"));
                isText = true;
                break;
            case 1:
                int randomNumber = Random.Range(1, 3);
                switch (randomNumber)
                {
                    case 1:
                        yield return StartCoroutine(Chat("어 뭐야 학식추천 받으려고?"));
                        HideAndShow();
                        break;
                    case 2:
                        yield return StartCoroutine(Chat("뭐야.... 학식추천 받을래?"));
                        HideAndShow();
                        break;
                }
                break;
            case 2:
                if (AiManager.instance.numberManager.chooseYesorNo == 1)
                {
                    Chat00("좋아, 지금 너가 있는곳은 어디야?");
                    HideAndShow();
                }
                else if (AiManager.instance.numberManager.chooseYesorNo == 2)
                {
                    Chat00("뭐야 그럼 왜깨운거야;;");
                    HideAndShow();
                }
                    break;
        }
        
        if (AiManager.instance.numberManager.turn == 0)
        {
            yield return StartCoroutine(Chat(1, "Z...z..z"));
            AiManager.instance.numberManager.turn = 1;
        }
        if (AiManager.instance.numberManager.turn == 1)
        {
            int randomNumber = Random.Range(1, 8);
            if (randomNumber == 1)
            {
                yield return StartCoroutine(Chat(1, "어 뭐야 학식추천 받으려고?"));
                HideAndShow();
            }
            else if (randomNumber == 2)
            {
                yield return StartCoroutine(Chat(2, "뭐야.... 학식추천 받을래?"));
                HideAndShow();
            }
            else if (randomNumber == 3)
            {
                yield return StartCoroutine(Chat(3, "하암~ 잘잤다. 학식추천 해줄까?"));
                HideAndShow();
            }
            else if (randomNumber == 4)
            {
                yield return StartCoroutine(Chat(4, "왜불러... 학식추천 필요해?"));
                HideAndShow();
            }
            else if (randomNumber == 5)
            {
                yield return StartCoroutine(Chat(5, "이런... 학식추천 해줄까?"));
                HideAndShow();
            }
            else if (randomNumber == 6)
            {
                yield return StartCoroutine(Chat(6, "개운하다~ 학식추천 필요해?"));
                HideAndShow();
            }
            else if (randomNumber == 7)
            {
                yield return StartCoroutine(Chat(7, "아.. 왜깨워... 좋은꿈 꾸고 있었는데.... 학식 추천 필요해?"));
                HideAndShow();
            }
            AiManager.instance.numberManager.turn = 2;
        }
        else if (AiManager.instance.numberManager.turn == 2)
        {
            if (AiManager.instance.numberManager.chooseYesorNo == 1)
            {
                int randomNumber = Random.Range(1, 6);
                if (randomNumber == 1)
                {
                    yield return StartCoroutine(Chat(1, "좋아, 지금 너가 있는곳은 어디야?"));
                    HideAndShow();
                }
                else if (randomNumber == 2)
                {
                    yield return StartCoroutine(Chat(2, "알겠어! 나만 믿어! 너가 현재 있는곳을 알려줘"));
                    HideAndShow();
                }
                else if (randomNumber == 3)
                {
                    yield return StartCoroutine(Chat(3, "에이 귀찮은데 좋아 너가 있는 위치는?"));
                    HideAndShow();
                }
                else if (randomNumber == 4)
                {
                    yield return StartCoroutine(Chat(4, "하암.... 너 위치나 찍어"));
                    HideAndShow();
                }
                else if (randomNumber == 5)
                {
                    yield return StartCoroutine(Chat( "내가 맛있는걸로 추천할테니 위치를 알려줘"));
                    HideAndShow();
                }
                AiManager.instance.numberManager.turn = 3;
            }
            else if (AiManager.instance.numberManager.chooseYesorNo == 2)
            {
                int randomNumber = Random.Range(1, 7);
                if (randomNumber == 1)
                {
                    yield return StartCoroutine(Chat("뭐야 그럼 왜깨운거야;;"));
                    HideAndShow();
                }
                else if (randomNumber == 2)
                {
                    yield return StartCoroutine(Chat("다시 잘래...."));
                    HideAndShow();
                }
                else if (randomNumber == 3)
                {
                    yield return StartCoroutine(Chat("필요할때 다시 불러줘"));
                    HideAndShow();
                }
                else if (randomNumber == 4)
                {
                    yield return StartCoroutine(Chat("깨워놓고 너무하다 ㅡ_ㅡ"));
                    HideAndShow();
                }
                else if (randomNumber == 5)
                {
                    yield return StartCoroutine(Chat(5, "미워.. 담에는 학식추천하게 해줘..."));
                    HideAndShow();
                }
                else if (randomNumber == 6)
                {
                    yield return StartCoroutine(Chat(5, "그래.... 다음번에 보자"));
                    HideAndShow();
                }
                AiManager.instance.numberManager.turn++;
            }

        }
    }*/
    public void HideAndShow()
    {
        if (NextUI != null)
        {
            NextUI.SetActive(true);
        }
    }
}

