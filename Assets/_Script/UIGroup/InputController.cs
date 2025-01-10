using UnityEngine;
using TMPro;

public class InputController : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] TextMeshProUGUI output;
    void Start()
    {
        
    }

    void Update()
    {
        output.SetText(input.text);
    }
}
