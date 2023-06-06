using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public GameObject NextUI;
    public TypeEffect ChatText;  //채팅이 나오는 텍스트
    public Animator AIanim;     //AI이미지 저장
    public Animator AIpanel;                 //AI이미지 올라갔다 내려오는 애니메이션
    public bool isText;
    public static bool isAction = false;  //Ai패널을 관리하는변수
    

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (!isText)
        {
            PrintText();
        }

        if (AiManager.instance.numberManager.turn == 0)
        {
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
                int randomNumber = Random.Range(1, 8);
                switch (randomNumber)
                {
                    case 1:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("어 뭐야 학식추천 받으려고?");
                        HideAndShow();
                        break;
                    case 2:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("뭐야.... 학식추천 받을래?");
                        HideAndShow();
                        break;
                    case 3:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("하암~ 잘잤다. 학식추천 해줄까?");
                        HideAndShow();
                        break;
                    case 4:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("왜불러... 학식추천 필요해?");
                        HideAndShow();
                        break;
                    case 5:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("이런... 학식추천 해줄게");
                        HideAndShow();
                        break;
                    case 6:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("개운하다~ 학식추천 필요해?");
                        HideAndShow();
                        break;
                    case 7:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("아.. 왜깨워... 좋은꿈 꾸고 있었는데.... 학식 추천 필요해?");
                        HideAndShow();
                        break;
                }
                break;
            case 2:
                if (AiManager.instance.numberManager.chooseYesorNo == 1)
                {
                    int randomNumber2 = Random.Range(1, 6);
                    switch (randomNumber2)
                    {
                        case 1:
                            Chat00("좋아, 지금 너가 있는곳은 어디야?");
                            break;
                        case 2:
                            Chat00("알겠어! 나만 믿어! 너가 현재 있는곳을 알려줘");
                            break;
                        case 3:
                            Chat00("에이 귀찮은데 좋아 너가 있는 위치는?");
                            break;
                        case 4:
                            Chat00("하암.... 너 위치나 찍어");
                            break;
                        case 5:
                            Chat00("내가 맛있는걸로 추천할테니 위치를 알려줘");
                            break;
                    }
                }
                else if (AiManager.instance.numberManager.chooseYesorNo == 2)
                {
                    int randomNumber22 = Random.Range(1, 7);
                    switch (randomNumber22)
                    {
                        case 1:
                            Chat00("뭐야 그럼 왜깨운거야;;");
                            break;
                        case 2:
                            Chat00("다시 잘래....");
                            break;
                        case 3:
                            Chat00("필요할때 다시 불러줘 ");
                            break;
                        case 4:
                            Chat00("깨워놓고 너무하다 ㅡ_ㅡ");
                            break;
                        case 5:
                            Chat00("미워.. 담에는 학식추천하게 해줘...");
                            break;
                        case 6:
                            Chat00(" 그래.... 다음번에 보자");
                            break;
                    }
                }
                break;
            case 3:
                int randomNumber3 = Random.Range(1, 6);
                switch (randomNumber3)
                {
                    case 1:
                        AiShow();
                        Chat00("너가 지금 있는 곳의 날씨는어때?");
                        break;
                    case 2:
                        AiShow();
                        Chat00("현재의 날씨는 어떤것 같아?");
                        break;
                    case 3:
                        AiShow();
                        Chat00("거기는 많이 더운 날씨야?");
                        break;
                    case 4:
                        AiShow();
                        Chat00("거기는 추운날씨야?");
                        break;
                    case 5:
                        AiShow();
                        Chat00("거기는 비가오고있어?");
                        break;
                }
                break;
            case 4:
                int randomNumber4 = Random.Range(1, 9);
                switch (randomNumber4)
                {
                    case 1:
                        Chat00("지금 온도는 어때?");
                        break;
                    case 2:
                        Chat00("너가 있는 곳은 따쓰해?");
                        break;
                    case 3:
                        Chat00("너가 있는곳은 어떤것 같아?");
                        break;
                    case 4:
                        Chat00("그곳은 많이 추워?");
                        break;
                    case 5:
                        Chat00("지금 그곳의 온도가 정말 궁금해!");
                        break;
                    case 6:
                        Chat00("바람이 많이 불고있어?");
                        break;
                    case 7:
                        Chat00("적당한 온도야?");
                        break;
                    case 8:
                        Chat00("오늘의 온도는 어떤거 같아?");
                        break;
                }
                break;
            case 5:
                int randomNumber5 = Random.Range(1, 8);
                switch (randomNumber5)
                {
                    case 1:
                        Chat00("지금 땡기는 종류는 뭔지 알려줘!");
                        break;
                    case 2:
                        Chat00("어떤 종류가 먹고싶어?");
                        break;
                    case 3:
                        Chat00("나는 튀김이 땡기네 ㅎㅎ");
                        break;
                    case 4:
                        Chat00("오늘은 면종류는 어때?");
                        break;
                    case 5:
                        Chat00("국물이 있는 국종류가 땡기지 않아?");
                        break;
                    case 6:
                        Chat00("한국인은 밥심이지! 밥은 어때?");
                        break;
                    case 7:
                        Chat00("간단한 빵종류는 어때?");
                        break;
                }
                break;
            case 6:
                int randomNumber6 = Random.Range(1, 8);
                switch (randomNumber6)
                {
                    case 1:
                        Chat00("한식 양식 중식 일식 매운거 안... 아 미안 ㅎㅎ");
                        break;
                    case 2:
                        Chat00("한국인은 든든한 국밥먹는게 최곤데 한식어때?");
                        break;
                    case 3:
                        Chat00("다른거 먹을빠에 싸고 뜨근한 국밥 든든하게 먹고말지");
                        break;
                    case 4:
                        Chat00("너가 원하는 선택지를 골라줘!");
                        break;
                    case 5:
                        Chat00("오늘은 양식은 어때?");
                        break;
                    case 6:
                        Chat00("돈까스 먹고싶을때는 일식이지!");
                        break;
                    case 7:
                        Chat00("오늘은 중식은 어때?");
                        break;
                }
                break;
            case 7:
                Chat00("짜잔");
                break;
        }
        isText = true;
    }

    void Chat00(string narration)
    {
        ChatText.SetMsg(narration);
    }
    public void AiShow()
    {
            AIpanel.SetBool("isShow", false);
    }
    public void AiHIde()
    {
            AIpanel.SetBool("isShow", true);
    }


    // 원진씨 코드
   /* IEnumerator Chat(string narration)
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

