using UnityEngine;
using UnityEngine.UI;

public class buttonHandle : MonoBehaviour
{
    public GameObject panel;
    public Button button;  

    void Start()
    {
        button = GetComponent<Button>(); 
    }

    public void HidePanelAndButton()
    {
        panel.SetActive(false);
        button.gameObject.SetActive(false);  
    }
}