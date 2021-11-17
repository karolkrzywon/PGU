
Shader "Custom/potShader"
{
    
    SubShader {
        Pass {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 3.0

            #include "UnityCG.cginc"

            float4 vert(appdata_base v) : POSITION {
                return UnityObjectToClipPos (v.vertex);
            }

            fixed4 frag(float4 sp:VPOS) : SV_Target {
               
                return fixed4(sp.x/_ScreenParams.x, sp.y/_ScreenParams.y, sp.z/_ScreenParams.z, 1.0);
            }

            ENDCG
        }
    }
}
