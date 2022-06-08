using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Score scoreText;
    private TextMeshProUGUI textMeshProObject;
    private Player player ;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        textMeshProObject = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        textMeshProObject.text = "Score : " + player.score ;    
    }
    
}
