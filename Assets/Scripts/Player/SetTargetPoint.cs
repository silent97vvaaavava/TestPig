using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SetTargetPoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Camera mainCamera;
    private SpriteRenderer sprite;

    delegate void GetPosition();

    private GetPosition CurrentPosition;

    private Color temp;
    void Awake()
    {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
        CurrentPosition = InputEditor;
#elif UNITY_ANDROID || UNITY_IOS
        CurrentPosition = InputAndroid;
#endif

        sprite = GetComponent<SpriteRenderer>();
        temp = sprite.color;
    }

    void Start()
    {
        mainCamera = Camera.main;
        InvokeRepeating("UpdateTarget", 0, 0.5f);
    }

    void UpdateTarget()
    {
        if (Vector2.Distance(transform.position, player.position) <= 1f)
        {
            temp.a = 0;
            sprite.color = temp;
        }
    }

    void Update()
    {
        CurrentPosition();
    }



    void InputEditor()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            transform.position = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            temp.a = 1;
            sprite.color = temp;
        }
    }

    void InputAndroid()
    {
        if (Input.touchCount > 0 && !EventSystem.current.IsPointerOverGameObject())
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                transform.position = (Vector2)mainCamera.ScreenToWorldPoint(touch.position);
                temp.a = 1;
                sprite.color = temp;
            }
        }
    }
}
