using NaughtyAttributes;
using UnityEngine;

public class Switch1 : MonoBehaviour
{
    [Header("입력"), HorizontalLine(color: EColor.Green)]
    [BoxGroup("")]
    [SerializeField] int input1;

    [Button("스위치문")]
    void DayOfWeek()
    {
        switch (input1)
        {
            case 1:
                Debug.Log("월");
                break;
            case 2:
                Debug.Log("수");
                break;
            case 3:
                Debug.Log("금");
                break;
            case 4:
                Debug.Log("일");
                break;
            default:
                Debug.Log("잘못 입력");
                break;

        }
    }

    [Button("스위치문2")]
    void newSwitch()
    {
        string r = input1 switch
        {
            1 => "월요일",
            2 => "수요일",
            3 => "금요일",
            4 => "일요일",
            _ => "잘못 입력"
        };

        Debug.Log(r);

    }

    [Button("조건문")]
    void IfSwitch()
    {
        string result;
        if ((input1 >= 1 && input1 <= 2) || input1 == 12)
        {
            result = "겨울";
        }
        else if (input1 >= 3 && input1 <= 5)
        {
            result = "봄";
        }
        else if (input1 >= 6 && input1 <= 8)
        {
            result = "여름";
        }
        else if (input1 >= 9 && input1 <= 11)
        {
            result = "가을";
        }
        else
        {
            result = "잘못 입력";
        }
        Debug.Log(result);


        result = input1 switch
        {
            1 or 2 or 12 =>"겨울",
            3 or 4 or 5 =>"봄",
            6 or 7 or 8 =>"여름",
            9 or 10 or 11 =>"가을",
            _ => "잘못입력"
        };
        Debug.Log(result);
    }
}
