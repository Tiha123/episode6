using NaughtyAttributes;
using UnityEngine;

public class TilemapGenerator : MonoBehaviour
{
    [Foldout("하이트맵 소스")]
    [SerializeField] Texture2D heightmap;
    [SerializeField] GameObject TilePrefab;
    [SerializeField] GameObject TreePrefab;
    
    
    [Header("하이트맵 속성")]
    [SerializeField, MinValue(0f), MaxValue(50f)] float heigtrange;

    [Button]
    void GetInfo()
    {
        GameObject Empty = new GameObject("Group");
        float w = heightmap.width;
        float h = heightmap.height;
        Debug.Log($"{w}, {h}");

        for (int a = 0; a < w; ++a)
        {
            for (int b = 0; b < h; ++b)
            {
                Color col = heightmap.GetPixel(a, b);
                Debug.Log($"{col}");
                float y=col.r*heigtrange;

                GameObject o = Instantiate(TilePrefab, new Vector3(a, y, b), Quaternion.identity);
                o.GetComponent<MeshRenderer>().material.color = col;
                o.transform.SetParent(Empty.transform);

            }
        }
    }

    [Button]
    void buildmap()
    {
        float w = heightmap.width;
        float h = heightmap.height;
        GameObject Empty = new GameObject("TileGroup");
        GameObject Empty2 = new GameObject("TreeGroup");
        
        for (int x = 0; x < w; ++x)
        {
            for (int z = 0; z < h; ++z)
            {
                float var=Random.Range(0.0f, 1.0f);
                Color col = heightmap.GetPixel(x, z);
                Debug.Log($"{col}");
                //color의 R채널을 높이값으로 활용*heigtrange으로 증폭
                float y=col.r*heigtrange;

                GameObject o = Instantiate(TilePrefab, new Vector3(x, (TilePrefab.transform.localScale.y/2)+y, z), Quaternion.identity);
                if((col.g>0.5f||var>0.8)&&(TilePrefab.transform.localScale.y+y)>12)
                {
                    GameObject o2 = Instantiate(TreePrefab, new Vector3(x, (TilePrefab.transform.localScale.y)+y, z), Quaternion.identity);
                    o2.transform.SetParent(Empty2.transform);
                }
                o.transform.SetParent(Empty.transform);

            }
        }
    }
}
