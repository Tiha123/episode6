using NaughtyAttributes;
using UnityEngine;

public class while1 : MonoBehaviour
{
    [SerializeField] bool isLoop;

    [Button]
    void func1()
    {
        // int a=0;
        // while (a<5)
        // {
        //     Debug.Log($"I'm {a}");
        //     a++;
        // }

        while (isLoop)
        {
            Debug.Log($"I'm loop");
        }
    }

}
