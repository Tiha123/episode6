using UnityEngine;
using TMPro;

public class FPSCalculator : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI tmp;
    [SerializeField] int fps;

    float dt=0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        dt += (Time.deltaTime-dt)*0.1f;
        fps=(int)(1.0f/dt);
        tmp.SetText($"<size=80%>FPS=</size> <size=110%>{fps}</size>");
    }
}
