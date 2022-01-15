#ifdef VERTEX
layout (location = 0) in vec2 a_vp;
layout (location = 1) in vec2 a_uv;

out vec2 uv;

void main()
{
    gl_Position = vec4(a_vp, 0.0, 1.0);
    uv = a_uv;
}
#endif

#ifdef FRAGMENT
out vec4 frag_color;

in vec2 uv;

uniform float bending_factor = 0.3;
uniform float darkness = 0.3;
uniform float num_lines = 256;

uniform sampler2D tex;

void main()
{
    vec2 nuv = uv - vec2(0.5, 0.5);
    float x = nuv.x * nuv.x;
    float y = nuv.y * abs(nuv.y);
    vec2 offset = vec2(0, x * y * bending_factor);
    vec2 uvo = uv + offset;
    
    float tint = mix(1, darkness, smoothstep(0,0.5,fract(uvo.y * num_lines)) - smoothstep(0.5,1.0,fract(uvo.y * num_lines)));

    frag_color = vec4(texture(tex, uvo).rgb * tint, 1);
}
#endif