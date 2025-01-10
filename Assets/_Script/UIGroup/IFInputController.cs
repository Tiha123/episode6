using UnityEngine;
using TMPro;

public class IFInputController : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] TextMeshProUGUI output;


    void Start()
    {
        
    }

    void Update()
    {
        // output.SetText(extractnum(input.text));
        output.SetText(extractnum(input.text));
    }
    int temp=0;
        string extractnum(string a)
    {
        //return int.Parse(a).ToString();
        
        int b;
        if(int.TryParse(a, out b))
        {   
            temp=b;
            return b.ToString();
        }
        else
        {
            return temp.ToString();
        }
    }
}
