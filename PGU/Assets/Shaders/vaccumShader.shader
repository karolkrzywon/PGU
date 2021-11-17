// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/vaccumShader"
{
    Properties
    {
        _MainTex("cylinderTexture", 2D) = "white" {}
        _BlinkColor("BlinkColor", Color) = (0.6,0,0,1)
    }
    SubShader
    {
        CGPROGRAM
        #pragma surface surf Lambert

        fixed4 _BlinkColor;
        sampler2D cylinderTexture;

        struct Input {
            float2 uv_cylinderTexture;
        };

        void surf(Input IN, inout SurfaceOutput o) {
            half4 c = tex2D(cylinderTexture, IN.uv_cylinderTexture);
            c *= (0.5f + abs(sin(_Time.w)));
            o.Albedo = c.rgb * _BlinkColor;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
