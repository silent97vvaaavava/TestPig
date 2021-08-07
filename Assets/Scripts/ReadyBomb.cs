using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReadyBomb : MonoBehaviour
{
    [Range(0.1f, 1f)] public float speed;
    [SerializeField] private GameObject bombPref;
    private Button button;

    private Image image;


    void Awake()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        StartCoroutine(Tick());
        button.onClick.AddListener(UpdateTimerBomb);
    }

    void UpdateTimerBomb()
    {
        StartCoroutine(Tick());
    }

    IEnumerator Tick()
    {
        while (image.fillAmount < 1)
        {
            image.fillAmount += speed*Time.deltaTime;
            yield return null;
        }

        button.interactable = true;
    }

    public void SetBomb(Transform targetPosition)
    {
        Instantiate(bombPref, (Vector2)targetPosition.position, Quaternion.identity);
        image.fillAmount = 0;
        button.interactable = false;
    }
}
