// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Shader101/Basic" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_SecondTex ("Second Texture", 2D) = "white" {}
		_Tween("Tween", range(0,1)) = 0
		_Color (	"Color", Color) = (1,1,1,1)
		// _Glossiness ("Smoothness", Range(0,1)) = 0.5
		// _Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader{
		Tags{
			"Queue" = "Transparent"
		}
		Pass {
			Blend SrcAlpha OneMinusSrcAlpha
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}

			sampler2D _MainTex;
			sampler2D _SecondTex;
			float4 _Color;
			float _Tween;

			float4 frag(v2f i) : SV_TARGET
			{
				float4 color1 = tex2D(_MainTex , i.uv) ;
				float4 color2 = tex2D(_SecondTex , i.uv ) ;
				float lum1 = color1.r * 0.3 + color1.g * 0.59 + color1.b * 0.11;
				float lum2 = color2.r * 0.3 + color2.g * 0.59 + color2.b * 0.11;
				float4 grayscale1  = float4(lum1,lum1,lum1,color1.a) * _Color;
				float4 grayscale2  = float4(lum2,lum2,lum2,color2.a) * _Color;
				float4 pix = lerp(grayscale1,grayscale2,_Tween);
				return pix * _Color;
			}

			ENDCG
		}
	}
}
