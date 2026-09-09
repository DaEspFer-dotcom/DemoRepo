using TMPro;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public TextMeshProUGUI textbox;

    
    public void OnClick()
    {
        textbox.text = "I have changed!";
    }

    // public int AdditionTemp(int a, int b)
    // {
    //         return a+b;
    // }

}
