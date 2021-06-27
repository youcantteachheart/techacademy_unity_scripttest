using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = new int[5];

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        //昇順
        Debug.Log("昇順");
        for (int i = 0; i < numbers.Length; i++){
            Debug.Log(numbers[i]);
        }
        
        //逆順
        Debug.Log("逆順");
        for (int j = numbers.Length - 1; j >= 0; j--){
            Debug.Log(numbers[j]);
        }

        //魔法
        Boss mpchecker = new Boss();
        Debug.Log("MPチェッカー");
        for (int m = 1; m <= 11; m++){
            Debug.Log(m+"回");
            mpchecker.Magic();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (mp >= 5){
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
        
    }


}