using TMPro;
using UnityEngine;

public class IfCalculator : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI a;
    [SerializeField] TextMeshProUGUI b;
    [SerializeField] TextMeshProUGUI c;
    
    void Update()
    {
        if (a.text==b.text)
        {
            c.text="same";
        }
    }
}
