using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ExitButon : MonoBehaviour
{
public Button exitButton;

void Start()
{
    Button btn = exitButton.GetComponent<Button>();
    btn.onClick.AddListener(TaskOnClick);
}    
    public  void TaskOnClick()
    {
        Application.Quit ();
        Debug.Log("You touched this button.");
    }
    


// void OnGUI() {
//    if (GUI.Button(new Rect(10, 70, 50, 30), "Exit"))
//       Debug.Log("Clicked the exit button");
//       Application.Quit();
// }

}
