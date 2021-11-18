Shader "Custom/TableShader"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Blink ( "Blink", Float ) = 0
        _Color ("Color", Color) = (1,1,1,1)
    }
    SubShader
    {
        Tags {"RenderType"="Opaque"}
        // Blend SrcAlpha One

        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;
        float _Blink;
        fixed4 _Color;

        struct Input {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o) {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Alpha = c.a;
            if( _Blink == 1.0f )
                c.rgb =  c*( 0.8f + abs( sin( _Time.w/3 ) ) );
            o.Albedo = c.rgb;
            /*half4 c = tex2D (_MainTex, IN.uv_MainTex );
            if( _Blink == 1.0f )
                c *=  ( 0.5f + abs( sin( _Time.w ) ) );*/
            //o.Albedo    = c.rgb*_Color;
            
        }
        ENDCG
}
FallBack "Diffuse"
}
