using NaughtyAttributes;
using UnityEngine;

public class for2 : MonoBehaviour
{   
    [SerializeField] int a;


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
    void Odd30To1()
    {
        int count=0;
        for(int i=30;i>0;--i)
        {
            if(i%2!=1)
                continue;
            if(i<=10)
            {
                Debug.Log("Break");
                break;
            }
                
            Debug.Log($"Odd number: {i}");
            count++;
        }
        Debug.Log($"Oddnumber total: {count}");
    }

    [Button]
    void timestable()
    {
        for(int i=1;i<10;++i)
        {
            if (a<=0) break;
            int result=a*i;
            Debug.Log($"{a}×{i}={result}");
        }
        int j=1; 
        while(j<10&&a>0)
        {
            int result=a*j;
            Debug.Log($"{a}×{j}={result}");
            j++;
        }
    }
}
