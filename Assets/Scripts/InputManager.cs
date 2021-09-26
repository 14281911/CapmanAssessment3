using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    private Tweener tweener;

    private Vector3 capmanRight, capmanUp, capmanLeft, capmanDown;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();

        capmanRight = new Vector3(-12.0f, 9.0f, 0.0f);
        capmanUp = new Vector3(-7.0f, 9.0f, 0.0f);
        capmanLeft = new Vector3(-7.0f, 13.0f, 0.0f);
        capmanDown = new Vector3(-12.0f, 13.0f, 0.0f);
    }

    
    void Update()
    {
        if (item.transform.position == capmanRight)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (-7.0f, 9.0f, 0.0f), 2.0f);
		}

        if (item.transform.position == capmanUp)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (-7.0f, 13.0f, 0.0f), 1.5f);
		}

        if (item.transform.position == capmanLeft)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (-12.0f, 13.0f, 0.0f), 2.0f);
		}

        if (item.transform.position == capmanDown)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (-12.0f, 9.0f, 0.0f), 1.5f);
		}
    }
}
