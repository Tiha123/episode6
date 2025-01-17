using NaughtyAttributes;
using UnityEngine;

public class Random1 : MonoBehaviour
{

    // [SerializeField] int seed;
    [SerializeField, MinValue(1), MaxValue(10)] int excludevalue;


    [Button]
    void randomRange()
    {
        // Random.InitState(seed);
        // int a=Random.Range(0, 10);
        // float b=Random.Range(0f, 10f);
        // int c=(int) (Random.value*100);
        // Vector2 d=new Vector2();
        // Vector3 e=new Vector3();
        // d=Random.insideUnitCircle;
        // e=Random.insideUnitSphere;
        // Debug.Log(a);
        // Debug.Log($"{b:F5}");
        // Debug.Log($"{c}");
        // Debug.Log($"{d}");
        // Debug.Log($"{e}");
    }

    [Button]
    void randomExclusive()
    {
        int result = Random.Range(1, 11);
        if (result == excludevalue)
        {
            randomExclusive();
        }
        else
        {
            Debug.Log(result);
        }
    }
    [SerializeField] float TargetRate;
    float floor = 0f;
    int trys = 0;
    float value;
    bool beforefloorhit = false;
    int GoldenLegendary = 0;

    [Button]
    void RandomRate()
    {
        value = Random.value;
        if (trys < 1000)
        {
            floor += TargetRate;
            if (value < TargetRate)
            {
                if (floor < 1f)
                {
                    if (beforefloorhit == true)
                    {
                        RandomRate();
                    }
                    else
                    {
                        trys++;
                        beforefloorhit = true;
                        GoldenLegendary++;
                        Debug.Log($"{trys}번째 시도: {value}, 천장 {floor}");
                        RandomRate();
                    }
                }
                else
                {
                    if (beforefloorhit == true)
                    {
                        RandomRate();
                    }
                    else
                    {
                        trys++;
                        floor = floor-1f;
                        beforefloorhit = false;
                        GoldenLegendary++;
                        Debug.Log($"{trys}번째 시도: {value}, 천장 {floor}");
                        RandomRate();
                    }

                }
            }
            else
            {
                if (floor < 1f)
                {
                    if (beforefloorhit == true)
                    {
                        trys++;
                        Debug.Log($"{trys}번째 시도: {value}, 천장 {floor}");
                        RandomRate();
                    }
                    else
                    {
                        trys++;
                        Debug.Log($"{trys}번째 시도: {value}, 천장 {floor}");
                        RandomRate();
                    }
                }
                else
                {
                    if (beforefloorhit == true)
                    {
                        trys++;
                        floor=floor-1f;
                        beforefloorhit = false;
                        Debug.Log($"{trys}번째 시도: {value}, 천장 {floor}");
                        RandomRate();
                    }
                    else
                    {
                        trys++;
                        floor = floor-1f;
                        GoldenLegendary++;
                        Debug.Log($"{trys}번째 시도: {TargetRate}, 천장 {floor}");
                        RandomRate();
                    }
                }
            }
        }
        else
        {
            Debug.Log($"{trys}번 시도, {GoldenLegendary}번 나옴.");
            GoldenLegendary=0;
            trys=0;
        }
    }

    [Button]
    void RandomRate2()
    {
        float rate=1/Random.value;
        for (int i=0;i<=rate;i++)
        {

        }
    }
}
