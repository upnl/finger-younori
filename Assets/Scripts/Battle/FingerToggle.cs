using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FingerToggle : MonoBehaviour
{
    [SerializeField]private int SerialNumber;
    [SerializeField]private FingerToggleGroup _FingerToggleGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Toggle�� IsOn�� ��ȭ�� �� ȣ��Ǵ� �޼���. ������ ��� �ڽ��� SerialNumber��, ������ ��� -1�� SelectedFinger�� �Ҵ�
    public void ToggleClick(bool isOn)
    {
        if(_FingerToggleGroup.SelectedFinger < 0)
        {
            _FingerToggleGroup.SelectedFinger = SerialNumber;
        }
        else
        {
            _FingerToggleGroup.SelectedFinger = -1;
        }
        Debug.Log(_FingerToggleGroup.SelectedFinger.ToString());
    }
}
