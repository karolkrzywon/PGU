Shader "Custom/potShader"
{
   Properties {
        _CirclesX ("Circles in X", Float) = 200
        _CirclesY ("Circles in Y", Float) = 100
        _Fade ("Fade", Range (0.1,1)) = 0.7
    }
    SubShader {
        Pass {

            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 3.0

            #include "UnityCG.cginc"
            
            uniform float _CirclesX;
            uniform float _CirclesY;
            uniform float _Fade;

            float4 vert(appdata_base v) : POSITION {
                return UnityObjectToClipPos (v.vertex);
            }

            fixed4 frag(float4 sp:VPOS) : SV_Target {
                float2 wcoord = sp.xy/_ScreenParams.xy;
                fixed4 color;
                if (length(fmod(float2(_CirclesX*wcoord.x,_CirclesY*wcoord.y),2)-1)<_Fade) {
                    color = fixed4(sp.xy/_ScreenParams.xy,100,1.0);
                } else {
                    color = fixed4(0.3,0.3,0.3,1.0);
                } 
                return color;
            }
            ENDCG
        }
    }
}
