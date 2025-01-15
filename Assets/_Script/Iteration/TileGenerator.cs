using System.Collections.Generic;
using NaughtyAttributes;
using Unity.VisualScripting;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [Foldout("프리팹")]
    [SerializeField] GameObject TilePrefab;
    [SerializeField] uint HorzTileAmout;
    [SerializeField] uint VertTileAmout;
    [SerializeField] uint FloorAmout;
    [SerializeField] float xStartOffset;
    [SerializeField] float yStartOffset;
    [SerializeField] float zStartOffset;
    [SerializeField] float xgap;
    [SerializeField] float ygap;
    [SerializeField] float zgap;

    

    [Button]
    void build()
    {
        GameObject Empty=new GameObject("Group");
        float OriginalX = TilePrefab.GetComponent<Transform>().localScale.x;
        float OriginalY = TilePrefab.GetComponent<Transform>().localScale.y;
        float OriginalZ = TilePrefab.GetComponent<Transform>().localScale.z;

        for (float i = 0f; i < HorzTileAmout; i++)
        {
            for (float j = 0f; j < VertTileAmout; j++)
            {
                for (float k = 0f; k < FloorAmout; k++)
                {
                    GameObject o=Instantiate(TilePrefab, new Vector3((i * (OriginalX+xgap)) + xStartOffset, (OriginalY / 2) + yStartOffset + (k * (OriginalY+ygap)), (j * (OriginalZ+zgap)) + zStartOffset), Quaternion.identity);
                    o.transform.SetParent(Empty.transform);
                }
            }
        }
    }

}
