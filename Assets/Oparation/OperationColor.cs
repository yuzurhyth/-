using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationColor : MonoBehaviour
{

    public float red = 1.0f, blue = 1.0f, green = 1.0f, transparency = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //Textコンポーネントを取得(using UnityEngine.UI;がいる)
        Text text = this.GetComponent<Text>();
        //色を指定(赤0～1,青,緑 ,透明度)
        text.color = new Color(red, blue, green, transparency);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
