using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoysticController : MonoBehaviour
{
    [SerializeField] private GameObject JoystickBackground;
    [SerializeField] private GameObject Joystick;
    public Vector2 JoystickVector { get; set; }
    private Vector2 joystickTouchPos;
    private Vector2 joystickOrigionalPos;
    private float joystickRadious;



    void Start()
    {
        joystickOrigionalPos = JoystickBackground.transform.position;
        joystickRadious = JoystickBackground.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    public void TouchDown()
    {
        joystickTouchPos = Input.mousePosition;
        Joystick.transform.position = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        JoystickVector = (dragPos - joystickTouchPos).normalized;

        float joystickDistance = Vector2.Distance(JoystickVector, joystickOrigionalPos);

        if (joystickDistance < joystickRadious)
        {
            Joystick.transform.position = joystickTouchPos + JoystickVector * joystickDistance;
        }

        else
        {
            Joystick.transform.position = joystickOrigionalPos + JoystickVector * joystickRadious;
        }


    }

    public void pointUP()
    {
        JoystickVector = Vector2.zero;
        Joystick.transform.position = joystickOrigionalPos;
    }




    
}
