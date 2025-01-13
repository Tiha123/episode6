using NaughtyAttributes;
using UnityEngine;

public class IfAttribute : MonoBehaviour
{
    [Header("title"), HorizontalLine(color:EColor.Red)]
    [Space(10)]

    [BoxGroup("")]
    [SerializeField] int a;

    [BoxGroup("")]
    [SerializeField] int b;

    [BoxGroup("")]
    [SerializeField] int c;

    [BoxGroup("")] 
    [SerializeField]bool d;

    [Button]
    void operatorEx()
    {
    //    c=a + b++;
    //    c=++a + ++b;
    //    a=1.23f;
    //    c=a++;
    //    Debug.Log(c);
    }

    [Button]
    void DayOfWeek()
    {
        if (a==1)
        {
            Debug.Log("월");
        }
        else if (a==2)
        {
            Debug.Log("수");
        }
        else if (a==3)
        {
            Debug.Log("금");
        }
        else
        {
            Debug.Log("일");
        }
    }

    [Button("삼항연산")]
    void TernayOperator()
    {
        string result=d? "왼쪽" : "오른쪽";
        Debug.Log(result);
    }

    [Button("삼항연산2")]
    void TernayOperator2()
    {
        string result= (a>=3&&a<9)||(b>5&&b<=10)? "참" : "거짓";
        Debug.Log(result);
    }

}
