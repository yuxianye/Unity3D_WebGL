using UnityEngine;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void Hello();

    [DllImport("__Internal")]
    private static extern void HelloString(string str);

    [DllImport("__Internal")]
    private static extern void PrintFloatArray(float[] array, int size);

    [DllImport("__Internal")]
    private static extern int AddNumbers(int x, int y);

    [DllImport("__Internal")]
    private static extern string StringReturnValueFunction();

    [DllImport("__Internal")]
    private static extern void BindWebGLTexture(int texture);

    void Start()
    {
       
        mesh = GetComponent<TextMesh>();
        Debug.Log(mesh.text);
     
        // Hello();
        HelloString("This is a string.");

        float[] myArray = new float[10];
        PrintFloatArray(myArray, myArray.Length);

        int result = AddNumbers(5, 7);
        Debug.Log(result);

        Debug.Log(StringReturnValueFunction());

        var texture = new Texture2D(0, 0, TextureFormat.ARGB32, false);
        BindWebGLTexture(texture.GetNativeTexturePtr().ToInt32());
    }

    public TextMesh mesh;

    void UpText(string msg)
    {
        Debug.Log("收到信息" + msg);

        if (mesh != null)
        {
            mesh.text = msg;
        }

        this.msg = msg;
    }

    public string msg = "null";
    // Update is called once per frame
    void Update()
    {
        if (mesh != null)
        {
            mesh.text = msg;
        }

        //UpText(DateTime.Now.ToString());
        //rd.AddForce(Vector3.right);
    }


}