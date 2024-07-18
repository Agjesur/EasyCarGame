using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Camerasystem : MonoBehaviour
{
    public Camera aci1; 
    public Camera aci2; 
    public Camera aci3; 
    public TMP_Dropdown dropdown; 

    void Start()
    {
        
        if (aci1 == null || aci2 == null || aci3 == null)
        {
            Debug.Log("One or more cameras are not assigned in the inspector!");
            return;
        }

        if (dropdown == null)
        {
            Debug.Log("Dropdown is not assigned in the inspector!");
            return;
        }

        
        SwitchCamera(aci1);
        dropdown.value = 0; 
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    public void OnDropdownValueChanged(int index)
    {
        switch (index)
        {
            case 0:
                SwitchCamera(aci1);
                break;
            case 1:
                SwitchCamera(aci2);
                break;
            case 2:
                SwitchCamera(aci3);
                break;
            default:
                break;
        }
    }

    void SwitchCamera(Camera activeCamera)
    {
        
        aci1.gameObject.SetActive(false);
        aci2.gameObject.SetActive(false);
        aci3.gameObject.SetActive(false);

        
        activeCamera.gameObject.SetActive(true);
    }
}