using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{
    public int CharPerSeconds;      //글자 재생 속도를 위한 변수
    public GameObject EndCursor;
    public TextManager text;
    public GameObject MouseControll;
    public Animator AIpanel;

    string targetMsg;       //표시할 문자열을 저장하는 변수
    Text msgText;
    int index;
    float interval;
    private void Awake()
    {
        msgText = GetComponent<Text>();
    }
    public void SetMsg(string msg)
    {
        targetMsg = msg;
        EffectStart();      //애니메이션 시작
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;
        EndCursor.SetActive(false);

        interval = 1.0f / CharPerSeconds;
        Invoke("Effecting", interval);      //애니메이션 재생
    }
    void Effecting()
    {
        if (msgText.text == targetMsg)
        {
            if (AiManager.instance.numberManager.turn == 0)
            {
                Invoke("EffecStart", 2.5f);
                TextManager.instance.isText = false;
            }
            if (AiManager.instance.numberManager.turn == 2)
            {
                text.AiHIde();
                MouseControll.SetActive(true);
            }
            EffectEnd();
            return;
        }
        AIpanel.SetTrigger("doEffect");
        msgText.text += targetMsg[index];
        index++;
        Invoke("Effecting", interval);
    }
    void EffectEnd()
    {
        EndCursor.SetActive(true);
    }
}
