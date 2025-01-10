using UnityEngine;

public class IFtutorial : MonoBehaviour
{
    [SerializeField] int grade;
    void Start()
    {
        if (grade>=90)
        {
            Debug.Log("A학점");
        }
        else if(grade>=80)
        {
            Debug.Log("B학점");
        }
        else if (grade>=60)
        {
            Debug.Log("C학점");
        }
        else
        {
            Debug.Log("F학점");
        }
    }

    void Update()
    {
        
    }
}
