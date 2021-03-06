﻿using UnityEngine;

public class MouseInputDir : MonoBehaviour
{
	static Vector3 startPos;    //始点
	static Vector3 endPos;      //終点
	public static string dir = "";
 
	public static void Flick ()
	{
		dir = "";
		
		if(Input.GetKeyDown (KeyCode.Mouse0))    //マウス左クリック時に始点座標を代入
		{
			startPos = new Vector3(Input.mousePosition.x , Input.mousePosition.y , Input.mousePosition.z);
		}
		
		if(Input.GetKeyUp (KeyCode.Mouse0))    //マウスのボタン解放時に終点座標を代入
		{
			endPos = new Vector3(Input.mousePosition.x , Input.mousePosition.y , Input.mousePosition.z);
			float directionX = endPos.x - startPos.x;
			float directionY = endPos.y - startPos.y;
 
			if(!(Mathf.Abs(directionX) < 15.0f && Mathf.Abs(directionY) < 15.0f)){
				float radian = Mathf.Atan2 ( directionY , directionX ) * Mathf.Rad2Deg;
 
				dir = "";
 
				if(radian < 0)
				{
					radian += 360;    //マイナスのものは360を加算
				}
 
				//方向判定
				if(radian <= 22.5f || radian > 337.5f)
				{
					dir = "a";
				}
				else if(radian <= 67.5f && radian > 22.5f)
				{
					dir = "b";
				}
				else if(radian <= 112.5f && radian > 67.5f)
				{
					dir = "c";
				}
				else if(radian <= 157.5f && radian > 112.5f)
				{
					dir = "d";
				}
				else if(radian <= 202.5f && radian > 157.5f)
				{
					dir = "e";
				}
				else if(radian <= 247.5f && radian > 202.5f)
				{
					dir = "f";
				}
				else if(radian <= 292.5f && radian > 247.5f)
				{
					dir = "g";
				}
				else if(radian <= 337.5f && radian > 292.5f)
				{
					dir = "h";
				}
			}
		}
	}
}
