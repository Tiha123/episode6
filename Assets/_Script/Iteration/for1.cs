using NaughtyAttributes;
using UnityEngine;

public class for1 : MonoBehaviour
{
    [Header("반복문(count만큼)")]
    [HorizontalLine(height: 1.0f, color: EColor.Red)]
    [Space(10)]
    [SerializeField] int count;

    [Button]
    void func1()
    {
        for (int a = 0; a < count; a+=2)
        {
            for (int b = 0; b <= a; b+=2)
            {
                Debug.Log($"{a}번{b}");
            }
        }
    }

    [Button]
    void func2()
    {
        for (int a = count; a > 0; a--)
        {
            for (int b = count; b >= 0; b--)
            {
                Debug.Log($"{a}번{b}");
            }
        }
    }
}