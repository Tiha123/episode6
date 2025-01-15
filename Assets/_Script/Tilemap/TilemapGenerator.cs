using NaughtyAttributes;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class TilemapGenerator : MonoBehaviour
{
    [Foldout("하이트맵 소스")]
    [SerializeField] Texture2D heightmap;
    [SerializeField] GameObject Prefab;

    [Button]
    void GetInfo()
    {
        float w=heightmap.width;
        float h=heightmap.height;
        Debug.Log($"{w}, {h}");

        for(int a=0;a<=w;++a)
        {
            for(int b=0;b<=h;++b)
            {
                Color col=heightmap.GetPixel(a,b);
                if(col.r>=0.5)
                {
                    
                }
                else
                {
                    
                }
                GameObject o=Instantiate(Prefab,new Vector3(a,0.5f,b),Quaternion.identity);
                o.GetComponent<MeshRenderer>().material.color=col;
            }
        }
    }
}
