using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DragToMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    [SerializeField] private GameObject canvasComponent;
    [SerializeField] private Button btn = null;


    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.0007f;
    }

    // Update is called once per frame
    void Update()
    {
        btn.onClick.AddListener(NoParamaterOnclick);
        //print(canvasComponent.activeSelf);
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).tapCount == 2)
            {
                canvasComponent.SetActive(true);
                print("double tap");
            }

            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y + touch.deltaPosition.y * speedModifier, transform.position.z + touch.deltaPosition.y * speedModifier);
            }
        }
    }
    private void NoParamaterOnclick()
    {
        if (canvasComponent.activeSelf == true)
        {
            canvasComponent.SetActive(false);
        }
    }

}

