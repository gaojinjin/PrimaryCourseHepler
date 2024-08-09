using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;
using NPinyin;
public class ChineseToPinYin : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField inputField;
    public TextMeshProUGUI textMeshProUGUI;
    public string[] strings;
    void Start()
    {
        inputField.onValueChanged.AddListener((arg) => {

            var pinyin = new Pinyin();
            pinyin.Option = new PinyinOption()
            {
                //Style = PinyinStyle.Normal, // ��������(Ĭ��) zhong wen
                Style = PinyinStyle.Tone, // ������ zh��ng w��n
                EnableInterval = true       // ���ƴ��֮���Ƿ����ü�� zhong wen  zhongwen
            };
            var result = pinyin.ConvertToPinyin(arg); // zhong wen
            textMeshProUGUI.text = result;
        });
    }

}
