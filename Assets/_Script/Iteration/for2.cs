using NaughtyAttributes;
using UnityEngine;

public class for2 : MonoBehaviour
{   
    [Button]
    void AddOneToTen()
    {
        int result=0;
        for(int i=0;i<10;++i)
        {
            result+=(i+1);
            Debug.Log($"i= {i+1}, result= {result}  ");
        }
    }

    [Button]
    void Odd3to1()
    {
        int count=0;
        for(int i=30;i>0;--i)
        {
            if(i%2==1)
            {
                Debug.Log($"Odd number: {i}");
                count++;
            }
        }
        Debug.Log($"Oddnumber total: {count}");
    }
}
