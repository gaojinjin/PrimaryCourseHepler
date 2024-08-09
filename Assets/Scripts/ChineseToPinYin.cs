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
                //Style = PinyinStyle.Normal, // 不带声调(默认) zhong wen
                Style = PinyinStyle.Tone, // 带声调 zhōng wén
                EnableInterval = true       // 多个拼音之间是否启用间隔 zhong wen  zhongwen
            };
            var result = pinyin.ConvertToPinyin(arg); // zhong wen
            textMeshProUGUI.text = result;
        });
    }

}
