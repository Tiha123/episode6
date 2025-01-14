using UnityEngine;
using NaughtyAttributes;

public class HealthGauge : MonoBehaviour
{
    [SerializeField] float HitPoint;
    [SerializeField] float damage;
    [SerializeField] float heal;
    [SerializeField] Color color1;

    [SerializeField] GameObject gauge;

    [SerializeField] float basehp;

    [Button]
    void Start()
    {
        HitPoint=basehp;
    }


    [Button]
    void Changecolor()
    {
        gauge.GetComponent<MeshRenderer>().material.color=color1;
    }

    [Button]
    void DamageAndHeal()
    {
        HitPoint=HitPoint-damage+heal;

        if(HitPoint>basehp)
        {
            HitPoint=basehp;
        }
        else if(HitPoint<0f)
        {
            HitPoint=0f;
        }

        // HitPoint=HitPoint>basehp?basehp : HitPoint; 
        
        // HitPoint=HitPoint<0f? 0f : HitPoint;

        Debug.Log($"캐릭터가 {damage}만큼의 피해를 입고 {heal}만큼의 치유를 받아 {HitPoint}만큼의 체력이 남았습니다.");

        float red=HitPoint>=(basehp/3)?1f-((HitPoint-(basehp/3))/(basehp*2/3)):1f;

        float green=HitPoint<=(basehp/3)?(HitPoint*3/basehp):1f;

        float fade=HitPoint/basehp;

        color1=new Color(red,green,0f,1f);
        gauge.GetComponent<MeshRenderer>().material.color=color1;
        gauge.GetComponent<MeshRenderer>().material.SetFloat("_Fade", fade);
    }
}
