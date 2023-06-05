using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public GameObject NextUI;
    public Text ChatText;  //ä���� ������ �ؽ�Ʈ

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
                        Chat00("�� ���� �н���õ ��������?");
                        HideAndShow();
                        break;
                    case 2:
                        Chat00("����.... �н���õ ������?");
                        HideAndShow();
                        break;
                }
                break;
            case 2:
                if (AiManager.instance.numberManager.chooseYesorNo == 1)
                {
                    Chat00("����, ���� �ʰ� �ִ°��� ����?");
                }
                else if (AiManager.instance.numberManager.chooseYesorNo == 2)
                {
                    Chat00("���� �׷� �ֱ���ž�;;");
                }
                break;
            case 3:
                Chat00("������ �?");
                break;
            case 4:
                Chat00("�µ��� �?");
                break;
            case 5:
                Chat00("������?");
                break;
            case 6:
                Chat00("������?");
                break;
            case 7:
                Chat00("¥��");
                break;
        }
        isText = true;
    }

    void Chat00(string narration)
    {
        ChatText.text = narration;
    }


    // ������ �ڵ�
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
                        yield return StartCoroutine(Chat("�� ���� �н���õ ��������?"));
                        HideAndShow();
                        break;
                    case 2:
                        yield return StartCoroutine(Chat("����.... �н���õ ������?"));
                        HideAndShow();
                        break;
                }
                break;
            case 2:
                if (AiManager.instance.numberManager.chooseYesorNo == 1)
                {
                    Chat00("����, ���� �ʰ� �ִ°��� ����?");
                    HideAndShow();
                }
                else if (AiManager.instance.numberManager.chooseYesorNo == 2)
                {
                    Chat00("���� �׷� �ֱ���ž�;;");
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
                yield return StartCoroutine(Chat(1, "�� ���� �н���õ ��������?"));
                HideAndShow();
            }
            else if (randomNumber == 2)
            {
                yield return StartCoroutine(Chat(2, "����.... �н���õ ������?"));
                HideAndShow();
            }
            else if (randomNumber == 3)
            {
                yield return StartCoroutine(Chat(3, "�Ͼ�~ �����. �н���õ ���ٱ�?"));
                HideAndShow();
            }
            else if (randomNumber == 4)
            {
                yield return StartCoroutine(Chat(4, "�ֺҷ�... �н���õ �ʿ���?"));
                HideAndShow();
            }
            else if (randomNumber == 5)
            {
                yield return StartCoroutine(Chat(5, "�̷�... �н���õ ���ٱ�?"));
                HideAndShow();
            }
            else if (randomNumber == 6)
            {
                yield return StartCoroutine(Chat(6, "�����ϴ�~ �н���õ �ʿ���?"));
                HideAndShow();
            }
            else if (randomNumber == 7)
            {
                yield return StartCoroutine(Chat(7, "��.. �ֱ���... ������ �ٰ� �־��µ�.... �н� ��õ �ʿ���?"));
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
                    yield return StartCoroutine(Chat(1, "����, ���� �ʰ� �ִ°��� ����?"));
                    HideAndShow();
                }
                else if (randomNumber == 2)
                {
                    yield return StartCoroutine(Chat(2, "�˰ھ�! ���� �Ͼ�! �ʰ� ���� �ִ°��� �˷���"));
                    HideAndShow();
                }
                else if (randomNumber == 3)
                {
                    yield return StartCoroutine(Chat(3, "���� �������� ���� �ʰ� �ִ� ��ġ��?"));
                    HideAndShow();
                }
                else if (randomNumber == 4)
                {
                    yield return StartCoroutine(Chat(4, "�Ͼ�.... �� ��ġ�� ���"));
                    HideAndShow();
                }
                else if (randomNumber == 5)
                {
                    yield return StartCoroutine(Chat( "���� ���ִ°ɷ� ��õ���״� ��ġ�� �˷���"));
                    HideAndShow();
                }
                AiManager.instance.numberManager.turn = 3;
            }
            else if (AiManager.instance.numberManager.chooseYesorNo == 2)
            {
                int randomNumber = Random.Range(1, 7);
                if (randomNumber == 1)
                {
                    yield return StartCoroutine(Chat("���� �׷� �ֱ���ž�;;"));
                    HideAndShow();
                }
                else if (randomNumber == 2)
                {
                    yield return StartCoroutine(Chat("�ٽ� �߷�...."));
                    HideAndShow();
                }
                else if (randomNumber == 3)
                {
                    yield return StartCoroutine(Chat("�ʿ��Ҷ� �ٽ� �ҷ���"));
                    HideAndShow();
                }
                else if (randomNumber == 4)
                {
                    yield return StartCoroutine(Chat("�������� �ʹ��ϴ� ��_��"));
                    HideAndShow();
                }
                else if (randomNumber == 5)
                {
                    yield return StartCoroutine(Chat(5, "�̿�.. �㿡�� �н���õ�ϰ� ����..."));
                    HideAndShow();
                }
                else if (randomNumber == 6)
                {
                    yield return StartCoroutine(Chat(5, "�׷�.... �������� ����"));
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

