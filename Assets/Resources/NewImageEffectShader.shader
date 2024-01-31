Shader "Custom/LightningEffect" {
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" { }
        _Color ("Tint", Color) = (1,1,1,1)
        _FlashColor ("Flash Color", Color) = (1,1,1,1)
        _FlashIntensity ("Flash Intensity", Range (0, 5)) = 0.0
        _ScrollSpeed ("Scroll Speed", Range (0, 10)) = 1.0
    }

    SubShader {
        Tags { "Queue" = "Overlay" }
        LOD 100

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma exclude_renderers gles xbox360 ps3
            ENDCG

            CGPROGRAM
            #pragma fragment frag
            sampler2D _MainTex;
            fixed4 _Color;
            fixed4 _FlashColor;
            float _FlashIntensity;
            float _ScrollSpeed;
            float4 frag(v2f i) : COLOR {
                fixed4 col = tex2D(_MainTex, i.uv);
                
                // Add a scrolling effect based on time
                float scrollOffset = _Time.y * _ScrollSpeed;
                
                // Create a lightning effect using a sine function
                float lightningEffect = sin(i.uv.y * 10 + scrollOffset) * _FlashIntensity;
                
                // Blend the original color with the flash color based on the lightning effect
                col.rgb = lerp(col.rgb, _FlashColor.rgb, lightningEffect);
                
                return col;
            }
            ENDCG
        }
    }
}
