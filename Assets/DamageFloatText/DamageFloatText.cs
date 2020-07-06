using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;


public class DamageFloatText : MonoBehaviour
{
    public struct Data
    {
        public int number;
        public bool isBigDamage;
    }

    [SerializeField] TMP_Text m_Text;
    [SerializeField] TMP_Text numberDisplay;
    [SerializeField] GameObject m_HeadShotText;
    [SerializeField] float smallDamageTextSize = 2.5f;
    [SerializeField] float bigDamageTextSize = 4f;
    int m_DamageValue;
    StringBuilder damageString = new StringBuilder(string.Empty, 3);

    protected virtual void OnEnable() { }

    public void SetUp(Data damageData)
    {
        SetText(Mathf.Floor(damageData.number));
        if (damageData.isBigDamage) { m_Text.fontSize = bigDamageTextSize; }
        else { m_Text.fontSize = smallDamageTextSize; }
    }

    public void SetUp(float damage, string text)
    {
        m_Text.text = string.Format("{0}\n{1}", text, damage);
    }

    public void SetUpHeadShot(float damage)
    {
        m_HeadShotText.SetActive(true);
        SetText(damage);
    }

    protected void SetText(float damage)
    {
        numberDisplay.text = ((int)damage).ToString();
        /*var intDamage = (int)damage;
        if (m_DamageValue != intDamage)
        {
            m_DamageValue = intDamage;
            damageString.Length = 0;
            damageString.Concat(m_DamageValue);
            m_Text.SetText(damageString);
        }*/
    }

    public void RemoveText()
    {
        //m_Text.text = string.Empty;
    }

    public void Destroy()
    {
        //LeanPool.Despawn(gameObject);
        Destroy(gameObject);
    }
}
