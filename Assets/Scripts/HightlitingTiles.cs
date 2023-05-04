using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HightlitingTiles : MonoBehaviour
{
    private HighLightableObject _lastHighliteObject;
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (_lastHighliteObject!=null)
        {
            _lastHighliteObject.Reset();
        }

        if (Physics.Raycast(ray,out var hitInfo))
        {
            var highLightableObject = hitInfo.collider.gameObject.GetComponent<HighLightableObject>();

            if (highLightableObject != null)
            {
                highLightableObject.Highlight();
                _lastHighliteObject = highLightableObject;
            }
        }
    }
}
