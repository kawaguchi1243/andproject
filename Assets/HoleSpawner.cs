using UnityEngine;

public class HoleSpawner : MonoBehaviour
{
    public GameObject holePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float xSpacing = 1.0f; // 横の間隔
    public float ySpacing = 4.0f; // 縦の間隔
    void Start()
    {
        xSpacing = 4.0f; // 横の間隔
        ySpacing = 3.0f; // 縦の間隔
        Debug.Log("xSpacing = " + xSpacing);
        // 上段（3）
        SpawnRow(3, ySpacing, xSpacing);

        // 中段（4）
        SpawnRow(4, 0f, xSpacing);

        // 下段（3）
        SpawnRow(3, -ySpacing, xSpacing);
    }


    void SpawnRow(int count, float y, float spacing)
        {
            float startX = -(count - 1) * spacing / 2;

            for (int i = 0; i < count; i++)
            {
                Vector3 pos = new Vector3(startX + i * spacing, y, 0);
                Instantiate(holePrefab, pos, Quaternion.identity);
            }
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
