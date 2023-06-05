using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public GameObject NextUI;
    public Text ChatText;  //채팅이 나오는 텍스트

    public string writerText = "";
    public bool isText;

    /*void Start()
    {
        StartCoroutine(TextPrint());
    }*/

    private void Update()
    {
        if (!isText)
        {
            StartCoroutine(TextPrint());
        }
    }

    IEnumerator Chat(int num, string narration)
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
                isText = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPrint()
    {
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
                    yield return StartCoroutine(Chat(5, "내가 맛있는걸로 추천할테니 위치를 알려줘"));
                    HideAndShow();
                }
                AiManager.instance.numberManager.turn = 3;
            }
            else if (AiManager.instance.numberManager.chooseYesorNo == 2)
            {
                int randomNumber = Random.Range(1, 7);
                if (randomNumber == 1)
                {
                    yield return StartCoroutine(Chat(1, "뭐야 그럼 왜깨운거야;;"));
                    HideAndShow();
                }
                else if (randomNumber == 2)
                {
                    yield return StartCoroutine(Chat(2, "다시 잘래...."));
                    HideAndShow();
                }
                else if (randomNumber == 3)
                {
                    yield return StartCoroutine(Chat(3, "필요할때 다시 불러줘"));
                    HideAndShow();
                }
                else if (randomNumber == 4)
                {
                    yield return StartCoroutine(Chat(4, "깨워놓고 너무하다 ㅡ_ㅡ"));
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
    }

    public void HideAndShow()
    {
        if (NextUI != null)
        {
            NextUI.SetActive(true);
        }
    }
}

