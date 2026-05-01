using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite hitSprite;

    private SpriteRenderer sr;
    private bool isHit = false;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>(); // ← StartじゃなくAwake
    }

    void OnMouseDown()
    {
        if (isHit) return;
        StartCoroutine(Hit());
    }

    IEnumerator Hit()
    {
        isHit = true;

        sr.sprite = hitSprite;

        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);

        isHit = false;
    }

    public void Appear()
    {
        isHit = false;
        sr.sprite = normalSprite;
        gameObject.SetActive(true);
    }
}