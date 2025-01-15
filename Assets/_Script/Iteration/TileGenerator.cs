using NaughtyAttributes;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [Foldout("프리팹")]
    [SerializeField] GameObject TilePrefab;
    [SerializeField] int TileAmout;
    [SerializeField] float xStartOffset;
    [SerializeField] float zStartOffset;

    [Button]
    void build()
    {
        float OriginalX = TilePrefab.GetComponent<Transform>().localScale.x;
        float OriginalY = TilePrefab.GetComponent<Transform>().localScale.y;

        for (float i = 0f; i < TileAmout; i++)
        {
            GameObject.Instantiate(TilePrefab, new Vector3(i * OriginalX * 1.2f + xStartOffset, (OriginalY / 2), zStartOffset), Quaternion.identity);
        }

    }
}
