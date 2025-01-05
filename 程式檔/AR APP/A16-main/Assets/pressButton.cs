using UnityEngine;
using TMPro;
using Vuforia;

public class pressButton : MonoBehaviour {
	public VirtualButtonBehaviour yourButton;
    ImageTargetBehaviour imageTarget;
    public TextMeshPro FloorText;
    public TextMeshPro vbtn1;
    public TextMeshPro vbtn2;
    public TextMeshPro vbtn3;

	void Start () {
		VirtualButtonBehaviour btn = yourButton.GetComponent<VirtualButtonBehaviour>();
        imageTarget = btn.GetImageTargetBehaviour();

        btn.RegisterOnButtonPressed(OnButtonPressed);
        btn.RegisterOnButtonReleased(OnButtonReleased);

	}
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(yourButton.name == "VirtualButton1"){
            FloorText.text = vbtn1.text;
            Application.OpenURL("http://"+PlayerPrefs.GetString("ip")+"/one");
        }
        else if(yourButton.name == "VirtualButton2"){
            FloorText.text = vbtn2.text;
            Application.OpenURL("http://"+PlayerPrefs.GetString("ip")+"/two");
        }
        else if(yourButton.name == "VirtualButton3"){
            FloorText.text = vbtn3.text;
            Application.OpenURL("http://"+PlayerPrefs.GetString("ip")+"/three");
        }
        else{
            FloorText.text = "X";
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        FloorText.text = "";
    }

}