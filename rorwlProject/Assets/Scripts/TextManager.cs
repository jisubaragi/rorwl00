using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public GameObject NextUI;
    public Text ChatText;  //ä���� ������ �ؽ�Ʈ

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
                    yield return StartCoroutine(Chat(5, "���� ���ִ°ɷ� ��õ���״� ��ġ�� �˷���"));
                    HideAndShow();
                }
                AiManager.instance.numberManager.turn = 3;
            }
            else if (AiManager.instance.numberManager.chooseYesorNo == 2)
            {
                int randomNumber = Random.Range(1, 7);
                if (randomNumber == 1)
                {
                    yield return StartCoroutine(Chat(1, "���� �׷� �ֱ���ž�;;"));
                    HideAndShow();
                }
                else if (randomNumber == 2)
                {
                    yield return StartCoroutine(Chat(2, "�ٽ� �߷�...."));
                    HideAndShow();
                }
                else if (randomNumber == 3)
                {
                    yield return StartCoroutine(Chat(3, "�ʿ��Ҷ� �ٽ� �ҷ���"));
                    HideAndShow();
                }
                else if (randomNumber == 4)
                {
                    yield return StartCoroutine(Chat(4, "�������� �ʹ��ϴ� ��_��"));
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
    }

    public void HideAndShow()
    {
        if (NextUI != null)
        {
            NextUI.SetActive(true);
        }
    }
}

