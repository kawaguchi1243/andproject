using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour
{
    public GameObject mole;

    public float minTime = 1f;
    public float maxTime = 3f;
    public float visibleTime = 1.0f;

    void Start()
    {
        mole.SetActive(false); 
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            // ランダム待機
            float wait = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(wait);

            // 出現
            mole.GetComponent<Mole>().Appear();

            // 表示時間
            yield return new WaitForSeconds(visibleTime);

            // 叩かれてなければ消す
            if (mole.activeSelf)
            {
                mole.SetActive(false);
            }
        }
    }
}