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
public class VideoTest1UI : UIBase
{
	//UIAutoBuild_CtrlDefine
	public Button btnTest1;
	public Button btnTest2;
	public Button btnTest3;
	public Button btnCloseAll;
	//UIAutoBuild_CtrlDefine


	public override void Awake()
	{
		//UIAutoBuild_CtrlBind
		base.Awake();
		Transform tf = transform;
		btnTest1 = tf.Find("Panel/btnTest1").GetComponent<Button>();
		btnTest2 = tf.Find("Panel/btnTest2").GetComponent<Button>();
		btnTest3 = tf.Find("Panel/btnTest3").GetComponent<Button>();
		btnCloseAll = tf.Find("Panel/btnCloseAll").GetComponent<Button>();
		//UIAutoBuild_CtrlBind
	}

	void OnEnable()
	{
		//UIAutoBuild_EventReg
		btnTest1.onClick.AddListener(OnBtnTest1Click);
		btnTest2.onClick.AddListener(OnBtnTest2Click);
		btnTest3.onClick.AddListener(OnBtnTest3Click);
		btnCloseAll.onClick.AddListener(OnBtnCloseAllClick);
		//UIAutoBuild_EventReg
	}

	void OnDisable()
	{
		//UIAutoBuild_EventUnReg
		btnTest1.onClick.RemoveAllListeners();
		btnTest2.onClick.RemoveAllListeners();
		btnTest3.onClick.RemoveAllListeners();
		btnCloseAll.onClick.RemoveAllListeners();
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

	private void OnBtnTest1Click()
	{
		UIMgr.OpenUI<VideoTest2UI>();
	}

	private void OnBtnTest2Click()
	{
		Tips.ShowHint("Hello UGUI!");
	}

	private void OnBtnTest3Click()
	{
		Tips.ShowDialog("Hello UGUI!");
	}
		private void OnBtnCloseAllClick()
	{
		UIMgr.CloseAllUI();

    }
///////////////////////////////////////////UIAutoBuild_Events//////////////////////////////////////////

}
