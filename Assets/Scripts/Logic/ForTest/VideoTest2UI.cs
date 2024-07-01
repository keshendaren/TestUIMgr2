/*-------------------------------------------------------------------------------------
--- Author: 
--- Date  : 2024-07-02 12:12
--- Desc  : 
-------------------------------------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UIMgrDemo;



/// <summary>
/// xxxUI
/// </summary>
public class VideoTest2UI : UIBase
{
	//UIAutoBuild_CtrlDefine
	public TextMeshProUGUI tmpTitle;
	public TextMeshProUGUI tmpTest1;
	public Button btnSayHello;
	//UIAutoBuild_CtrlDefine


	public override void Awake()
	{
		//UIAutoBuild_CtrlBind
		base.Awake();
		Transform tf = transform;
		tmpTitle = tf.Find("tmpTitle").GetComponent<TextMeshProUGUI>();
		tmpTest1 = tf.Find("tmpTest1").GetComponent<TextMeshProUGUI>();
		btnSayHello = tf.Find("btnSayHello").GetComponent<Button>();
		//UIAutoBuild_CtrlBind
	}

	void OnEnable()
	{
		//UIAutoBuild_EventReg
		btnSayHello.onClick.AddListener(OnBtnSayHelloClick);
		//UIAutoBuild_EventReg
	}

	void OnDisable()
	{
		//UIAutoBuild_EventUnReg
		btnSayHello.onClick.RemoveAllListeners();
		//UIAutoBuild_EventUnReg
	}

	void Start()
	{
	}

	public override void Show(params object[] _params)
	{
		base.Show(_params);

	}
	///////////////////////////////////////////UIAutoBuild_Events//////////////////////////////////////////

	private void OnBtnSayHelloClick()
	{
		tmpTest1.text = "Hello UIMgr!";

    }
	///////////////////////////////////////////UIAutoBuild_Events//////////////////////////////////////////

}
