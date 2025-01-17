using NaughtyAttributes;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    [SerializeField] int numerator;
    [SerializeField] int denominator;
    [SerializeField, ReadOnly] float percent;

    [Button]
    void GenerateRange()
    {
        float probability=((float) numerator/(float) denominator);
        percent=probability*100f;
        float ticket=Random.Range(0f, 100f);
        Debug.Log($"{percent}%");
        if (ticket<=percent)
        {
            Debug.Log($"Hit! {ticket}%");
        }
        else
        {
            Debug.Log($"Not hit! {ticket}%");
        }
    }
}
