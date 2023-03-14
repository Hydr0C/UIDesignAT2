using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveButton : MonoBehaviour
{
    [SerializeField] Button leButt;
    private void OnEnable()
    {
        leButt.Select();
    }
}
