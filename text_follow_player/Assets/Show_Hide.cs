using UnityEngine;
using UnityEngine.UI;

public class Show_Hide : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            this.GetComponent<Image>().enabled = !this.GetComponent<Image>().enabled;
        }
    }
}
