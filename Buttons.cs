using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void OnClickAddTime()
    {
        EventManager.OnTimerUpdate(5.0f);
    }

    public void OnClickSubtractTime()
    {
        EventManager.OnTimerUpdate(-5.0f);
    }
}
