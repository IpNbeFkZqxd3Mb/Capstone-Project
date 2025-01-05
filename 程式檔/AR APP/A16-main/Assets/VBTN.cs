using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class VBTN : MonoBehaviour
{
    string currentQRCode = "1";
    GameObject ImageTarget1;
    GameObject ImageTarget2;
    GameObject ImageTarget3;
    GameObject ImageTarget4;
    GameObject ImageTarget5;
    GameObject ImageTarget6;
    GameObject ImageTarget7;
    GameObject ImageTarget8;
    GameObject ImageTarget9;
    GameObject ImageTarget10;
    void Start()
    {
        ImageTarget1 = GameObject.Find("Target1");
        ImageTarget2 = GameObject.Find("Target2");
        ImageTarget3 = GameObject.Find("Target3");
        ImageTarget4 = GameObject.Find("Target4");
        ImageTarget5 = GameObject.Find("Target5");
        ImageTarget6 = GameObject.Find("Target6");
        ImageTarget7 = GameObject.Find("Target7");
        ImageTarget8 = GameObject.Find("Target8");
        ImageTarget9 = GameObject.Find("Target9");
        ImageTarget10 = GameObject.Find("Target10");
        SetActiveAllTarget(false);

        //每秒向server發送請求一次
        StartCoroutine(getRequest("https://a16-web.onrender.com/"));
    }
    void Update()
    {
    
    }
    private void SetActiveAllTarget(bool b){
        ImageTarget1.SetActive(b);
        ImageTarget2.SetActive(b);
        ImageTarget3.SetActive(b);
        ImageTarget4.SetActive(b);
        ImageTarget5.SetActive(b);
        ImageTarget6.SetActive(b);
        ImageTarget7.SetActive(b);
        ImageTarget8.SetActive(b);
        ImageTarget9.SetActive(b);
        ImageTarget10.SetActive(b);
    }

    IEnumerator getRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            if(currentQRCode != uwr.downloadHandler.text){
                currentQRCode = uwr.downloadHandler.text;
                Debug.Log(currentQRCode);
                SetActiveAllTarget(false);
                activeImageTarget();
            }
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(getRequest(uri));
    }

    private void activeImageTarget(){
        switch(currentQRCode){
            case "1":
                ImageTarget1.SetActive(true);
                break;
            case "2":
                ImageTarget2.SetActive(true);
                break;
            case "3":
                ImageTarget3.SetActive(true);
                break;
            case "4":
                ImageTarget4.SetActive(true);
                break;
            case "5":
                ImageTarget5.SetActive(true);
                break;
            case "6":
                ImageTarget6.SetActive(true);
                break;
            case "7":
                ImageTarget7.SetActive(true);
                break;
            case "8":
                ImageTarget8.SetActive(true);
                break;
            case "9":
                ImageTarget9.SetActive(true);
                break;
            case "10":
                ImageTarget10.SetActive(true);
                break;
            default:
                Debug.Log("serverResponse not found.");
                break;
        }
    }
}
