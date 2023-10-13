//#############################################################################
// Aqualisテスト
// 実行後removeNaNを実行し非数値数式をコメントアウト
let projectname = "test1"
let version = "1.0.0"
//#############################################################################

let outputdir = __SOURCE_DIRECTORY__

#I @"C:\home\LightwaveLaboratory\Aqualis\bin\Debug\net6.0"
#r "Aqualis.dll"

open Aqualis

Compile [F;C] outputdir projectname ("aaa","aaa") <| fun () ->
    ch.dddd <| fun (x,y,z1,z2) ->
        let p = 1.5
        let q = 8.4
        x <== p
        y <== q
        printfn "%d" 1
        !"test001"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 001) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2
        !"test002"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 002) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3
        !"test003"
        z1 <== (7.0+(p/((-q))*((-q)/8.4/p)-((-p)+q/(-p))+8.4))
        z2 <== (7.0+(x/((-y))*((-y)/8.4/x)-((-x)+y/(-x))+8.4))
        print.cccc (I 003) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4
        !"test004"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 004) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 5
        !"test005"
        z1 <== (-2.7)
        z2 <== (-2.7)
        print.cccc (I 005) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 6
        !"test006"
        z1 <== ((-1.3)-(p)/((-p)+4.2)+(-8.4)*(q-(-6.4)+q+3.6))
        z2 <== ((-1.3)-(x)/((-x)+4.2)+(-8.4)*(y-(-6.4)+y+3.6))
        print.cccc (I 006) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 7
        !"test007"
        z1 <== (-p)*((p/(-q)+q-p*p)-(5.1/(-3.0)))*(((-q)/p-(-q)*(-5.3)*(-4.6))+((-p))+(q*q-(-q))+6.7)*((-p))/((-q))-(p/(-6.7))*(p)/(-p)
        z2 <== (-x)*((x/(-y)+y-x*x)-(5.1/(-3.0)))*(((-y)/x-(-y)*(-5.3)*(-4.6))+((-x))+(y*y-(-y))+6.7)*((-x))/((-y))-(x/(-6.7))*(x)/(-x)
        print.cccc (I 007) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 8
        !"test008"
        z1 <== (q)/(q-((-p)/0.4-(-p)*2.2))-q+(((-p)*1.7-(-q)*2.1)-(1.0)/q)
        z2 <== (y)/(y-((-x)/0.4-(-x)*2.2))-y+(((-x)*1.7-(-y)*2.1)-(1.0)/y)
        print.cccc (I 008) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 9
        !"test009"
        z1 <== 3.7*(((-5.0))/(p*6.1-(-p)))+(((-p))-(p)/p/2.1/(8.1*(-p)*q))
        z2 <== 3.7*(((-5.0))/(x*6.1-(-x)))+(((-x))-(x)/x/2.1/(8.1*(-x)*y))
        print.cccc (I 009) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 10
        !"test010"
        z1 <== ((6.0/(-3.0)-(-1.6))/2.5-(((-0.1)*1.6-5.3-(-4.6)))/((-p)*q+3.6-(-0.4)+(-6.3)/((-q)/3.6)*(-p)))
        z2 <== ((6.0/(-3.0)-(-1.6))/2.5-(((-0.1)*1.6-5.3-(-4.6)))/((-x)*y+3.6-(-0.4)+(-6.3)/((-y)/3.6)*(-x)))
        print.cccc (I 010) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 11
        !"test011"
        z1 <== ((-q)/(-8.7))
        z2 <== ((-y)/(-8.7))
        print.cccc (I 011) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 12
        !"test012"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 012) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 13
        !"test013"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 013) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 14
        !"test014"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 014) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 15
        !"test015"
        z1 <== 2.2
        z2 <== 2.2
        print.cccc (I 015) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 16
        !"test016"
        z1 <== ((-1.2)+q)
        z2 <== ((-1.2)+y)
        print.cccc (I 016) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 17
        !"test017"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 017) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 18
        !"test018"
        z1 <== 7.5*(-2.1)/((p+(-8.1)+(-2.0)+p)-(q*(-2.2)+(-p)-(-p)/(-3.7))+((-q)+(-q)))-p*4.0
        z2 <== 7.5*(-2.1)/((x+(-8.1)+(-2.0)+x)-(y*(-2.2)+(-x)-(-x)/(-3.7))+((-y)+(-y)))-x*4.0
        print.cccc (I 018) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 19
        !"test019"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 019) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 20
        !"test020"
        z1 <== (8.8-(-2.1)+(((-0.4)-(-7.4))+(-p)*2.6)*(-1.2))
        z2 <== (8.8-(-2.1)+(((-0.4)-(-7.4))+(-x)*2.6)*(-1.2))
        print.cccc (I 020) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 21
        !"test021"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 021) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 22
        !"test022"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 022) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 23
        !"test023"
        z1 <== ((q/p+(-p))/((-3.1)-q)+(-4.1)-(-5.2)+((-p)*p/(-6.2)+q))
        z2 <== ((y/x+(-x))/((-3.1)-y)+(-4.1)-(-5.2)+((-x)*x/(-6.2)+y))
        print.cccc (I 023) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 24
        !"test024"
        z1 <== (((-3.1)*q/(-q))-1.7)
        z2 <== (((-3.1)*y/(-y))-1.7)
        print.cccc (I 024) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 25
        !"test025"
        z1 <== ((-8.5)-(-q)/(-5.4)+(6.1-(-p)/((-3.6))*p+((-0.1)-(-p)))+1.8)
        z2 <== ((-8.5)-(-y)/(-5.4)+(6.1-(-x)/((-3.6))*x+((-0.1)-(-x)))+1.8)
        print.cccc (I 025) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 26
        !"test026"
        z1 <== p
        z2 <== x
        print.cccc (I 026) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 27
        !"test027"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 027) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 28
        !"test028"
        z1 <== (7.5)
        z2 <== (7.5)
        print.cccc (I 028) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 29
        !"test029"
        z1 <== ((-5.6)/p+(-p))
        z2 <== ((-5.6)/x+(-x))
        print.cccc (I 029) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 30
        !"test030"
        z1 <== (2.5)
        z2 <== (2.5)
        print.cccc (I 030) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 31
        !"test031"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 031) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 32
        !"test032"
        z1 <== ((((-p)+(-p)*(-7.6)))*(p)-q*(-7.7))
        z2 <== ((((-x)+(-x)*(-7.6)))*(x)-y*(-7.7))
        print.cccc (I 032) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 33
        !"test033"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 033) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 34
        !"test034"
        z1 <== (((q*(-0.7)-(-q)/(-8.2))/(-q)/(q-1.6)/(2.7-(-q)+(-5.8)-q+(-4.0)))+4.5/2.4+(8.2/(q*(-7.7)-(-q)+(-5.3))/7.5-(7.4-(-5.2))/(-p))*(-7.4))
        z2 <== (((y*(-0.7)-(-y)/(-8.2))/(-y)/(y-1.6)/(2.7-(-y)+(-5.8)-y+(-4.0)))+4.5/2.4+(8.2/(y*(-7.7)-(-y)+(-5.3))/7.5-(7.4-(-5.2))/(-x))*(-7.4))
        print.cccc (I 034) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 35
        !"test035"
        z1 <== ((-p)/(3.6*p)-4.2)
        z2 <== ((-x)/(3.6*x)-4.2)
        print.cccc (I 035) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 36
        !"test036"
        z1 <== (-3.7)
        z2 <== (-3.7)
        print.cccc (I 036) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 37
        !"test037"
        z1 <== q
        z2 <== y
        print.cccc (I 037) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 38
        !"test038"
        z1 <== 2.5+(-0.2)-p
        z2 <== 2.5+(-0.2)-x
        print.cccc (I 038) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 39
        !"test039"
        z1 <== q
        z2 <== y
        print.cccc (I 039) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 40
        !"test040"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 040) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 41
        !"test041"
        z1 <== (((-p)+(-p))+(-q)+(-q)*(-q))
        z2 <== (((-x)+(-x))+(-y)+(-y)*(-y))
        print.cccc (I 041) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 42
        !"test042"
        z1 <== ((p)*(-p)+(((-8.4)*(-p)+8.4)-(q+p*(-p)/3.0)+q+(-p)-((-7.7)))+8.7-(-1.2))
        z2 <== ((x)*(-x)+(((-8.4)*(-x)+8.4)-(y+x*(-x)/3.0)+y+(-x)-((-7.7)))+8.7-(-1.2))
        print.cccc (I 042) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 43
        !"test043"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 043) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 44
        !"test044"
        z1 <== p
        z2 <== x
        print.cccc (I 044) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 45
        !"test045"
        z1 <== (((-0.1)-0.3)+(p+5.3/(-p)+(-0.3))+((-8.5)+4.7-7.0-(-q)-q)/(-0.3)*p*(p/3.0+q/(-2.8)+((-p)/(-q)-(-8.3))-(-3.0)+(8.7)))
        z2 <== (((-0.1)-0.3)+(x+5.3/(-x)+(-0.3))+((-8.5)+4.7-7.0-(-y)-y)/(-0.3)*x*(x/3.0+y/(-2.8)+((-x)/(-y)-(-8.3))-(-3.0)+(8.7)))
        print.cccc (I 045) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 46
        !"test046"
        z1 <== q
        z2 <== y
        print.cccc (I 046) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 47
        !"test047"
        z1 <== 7.0-(-2.5)
        z2 <== 7.0-(-2.5)
        print.cccc (I 047) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 48
        !"test048"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 048) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 49
        !"test049"
        z1 <== ((-4.0))
        z2 <== ((-4.0))
        print.cccc (I 049) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 50
        !"test050"
        z1 <== ((((-q)*p)-(p)*q-q-(-p)*(-p)/(-6.5)-(-p)+(p+(-q)+(-q)/(-0.8)/(-q)))-((-5.2)-p*((-5.6)/(-q)-4.3-7.2))-(-0.0)+((4.3*q/(-q)*p/(-2.3))-p+2.1/(p))-((0.5*p+(-6.1))))
        z2 <== ((((-y)*x)-(x)*y-y-(-x)*(-x)/(-6.5)-(-x)+(x+(-y)+(-y)/(-0.8)/(-y)))-((-5.2)-x*((-5.6)/(-y)-4.3-7.2))-(-0.0)+((4.3*y/(-y)*x/(-2.3))-x+2.1/(x))-((0.5*x+(-6.1))))
        print.cccc (I 050) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 51
        !"test051"
        z1 <== ((q)-((-p)-(-5.8)*p-(-3.5)/(-q)-((-7.7)+(-q)+p-q/p)/q*(-2.2))-(-8.3)-(((-8.4)*p/q-(-p))-(-q)*((-p)+(-q))+2.8)/((4.7)))
        z2 <== ((y)-((-x)-(-5.8)*x-(-3.5)/(-y)-((-7.7)+(-y)+x-y/x)/y*(-2.2))-(-8.3)-(((-8.4)*x/y-(-x))-(-y)*((-x)+(-y))+2.8)/((4.7)))
        print.cccc (I 051) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 52
        !"test052"
        z1 <== (5.4+(-4.3)+(((-4.1)/(-2.3)-(-1.6)-(-5.7)*(-6.7))+6.3-(-8.4)*(q*8.8))+(-q))
        z2 <== (5.4+(-4.3)+(((-4.1)/(-2.3)-(-1.6)-(-5.7)*(-6.7))+6.3-(-8.4)*(y*8.8))+(-y))
        print.cccc (I 052) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 53
        !"test053"
        z1 <== p
        z2 <== x
        print.cccc (I 053) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 54
        !"test054"
        z1 <== p
        z2 <== x
        print.cccc (I 054) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 55
        !"test055"
        z1 <== ((2.1/(-p)-5.4-5.3/(-p))*(-6.6)/5.1+q)+q+p-(-p)+(-7.4)
        z2 <== ((2.1/(-x)-5.4-5.3/(-x))*(-6.6)/5.1+y)+y+x-(-x)+(-7.4)
        print.cccc (I 055) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 56
        !"test056"
        z1 <== ((-0.1)/(q-0.3))
        z2 <== ((-0.1)/(y-0.3))
        print.cccc (I 056) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 57
        !"test057"
        z1 <== 7.3
        z2 <== 7.3
        print.cccc (I 057) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 58
        !"test058"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 058) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 59
        !"test059"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 059) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 60
        !"test060"
        z1 <== (p/(-1.5))
        z2 <== (x/(-1.5))
        print.cccc (I 060) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 61
        !"test061"
        z1 <== (2.3/(-2.6)/7.3-(-p)*3.7)
        z2 <== (2.3/(-2.6)/7.3-(-x)*3.7)
        print.cccc (I 061) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 62
        !"test062"
        z1 <== ((-2.1)-1.8)
        z2 <== ((-2.1)-1.8)
        print.cccc (I 062) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 63
        !"test063"
        z1 <== (1.0*((-3.6)*5.0)/p+(0.2+(-5.1)-0.5*(-4.8)+(-5.5)*1.4+5.3+(-4.6)/(p)*((-p)/(-p))*(-q)))
        z2 <== (1.0*((-3.6)*5.0)/x+(0.2+(-5.1)-0.5*(-4.8)+(-5.5)*1.4+5.3+(-4.6)/(x)*((-x)/(-x))*(-y)))
        print.cccc (I 063) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 64
        !"test064"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 064) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 65
        !"test065"
        z1 <== (((-q)-((-q)+p+q/(-5.8)))*((-p)*(-4.4)-(-q)-2.6*(-p)+((-p)*(-8.2)))/6.5-(3.2/(-5.6)/(-2.8)))
        z2 <== (((-y)-((-y)+x+y/(-5.8)))*((-x)*(-4.4)-(-y)-2.6*(-x)+((-x)*(-8.2)))/6.5-(3.2/(-5.6)/(-2.8)))
        print.cccc (I 065) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 66
        !"test066"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 066) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 67
        !"test067"
        z1 <== (((-1.1)-q)+((-p)/(-p)+((-p)-(-5.7)*(-1.8)+q)-(-q))/p+3.5-(((-q)*(-p))))
        z2 <== (((-1.1)-y)+((-x)/(-x)+((-x)-(-5.7)*(-1.8)+y)-(-y))/x+3.5-(((-y)*(-x))))
        print.cccc (I 067) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 68
        !"test068"
        z1 <== ((q-q)*4.6+(-0.7)*(3.3)+(q/q))
        z2 <== ((y-y)*4.6+(-0.7)*(3.3)+(y/y))
        print.cccc (I 068) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 69
        !"test069"
        z1 <== q
        z2 <== y
        print.cccc (I 069) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 70
        !"test070"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 070) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 71
        !"test071"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 071) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 72
        !"test072"
        z1 <== (1.1+6.7+3.8)
        z2 <== (1.1+6.7+3.8)
        print.cccc (I 072) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 73
        !"test073"
        z1 <== (((-8.2)*3.7+(-3.5)+5.4+3.5*0.0)*(0.1/(-q)-(-7.8)+(-q)-p-(-4.4)/p*(-0.2)+5.0/8.1+(-p)/4.0/8.6)+(-p)+(-p))
        z2 <== (((-8.2)*3.7+(-3.5)+5.4+3.5*0.0)*(0.1/(-y)-(-7.8)+(-y)-x-(-4.4)/x*(-0.2)+5.0/8.1+(-x)/4.0/8.6)+(-x)+(-x))
        print.cccc (I 073) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 74
        !"test074"
        z1 <== p
        z2 <== x
        print.cccc (I 074) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 75
        !"test075"
        z1 <== ((-q)*(8.2+p/(-5.3)-(-3.7)*(q-(-p)-(-q)/6.6+1.6))-((-p)/(-7.5)*(-p))*((-5.5)/(-6.1)))
        z2 <== ((-y)*(8.2+x/(-5.3)-(-3.7)*(y-(-x)-(-y)/6.6+1.6))-((-x)/(-7.5)*(-x))*((-5.5)/(-6.1)))
        print.cccc (I 075) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 76
        !"test076"
        z1 <== ((-0.4)+(((-7.0)*(-p)+p)+q+(4.2/q)*(p*p-q)+3.0)-(-2.4)-((-p)+(-p)+7.5/q))
        z2 <== ((-0.4)+(((-7.0)*(-x)+x)+y+(4.2/y)*(x*x-y)+3.0)-(-2.4)-((-x)+(-x)+7.5/y))
        print.cccc (I 076) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 77
        !"test077"
        z1 <== (((-8.5)/(-4.7)-p)+((-8.3)-8.8/p*7.3/(-8.6)+(p/p+q)-(4.1+(-p)*(-4.4)-5.7+4.8))/(4.5*((-5.2)*(-2.2)/8.4-(-1.2)+(-p)))/(-p))
        z2 <== (((-8.5)/(-4.7)-x)+((-8.3)-8.8/x*7.3/(-8.6)+(x/x+y)-(4.1+(-x)*(-4.4)-5.7+4.8))/(4.5*((-5.2)*(-2.2)/8.4-(-1.2)+(-x)))/(-x))
        print.cccc (I 077) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 78
        !"test078"
        z1 <== ((q-3.5+(-1.4)+p/(-6.3))-(-p)-((-7.1)*(-6.2)+q)/p-p+q*8.0/1.8)+1.4+p/((5.0*6.6)+5.8/q)/(-q)
        z2 <== ((y-3.5+(-1.4)+x/(-6.3))-(-x)-((-7.1)*(-6.2)+y)/x-x+y*8.0/1.8)+1.4+x/((5.0*6.6)+5.8/y)/(-y)
        print.cccc (I 078) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 79
        !"test079"
        z1 <== ((-q)/2.6-(-p))
        z2 <== ((-y)/2.6-(-x))
        print.cccc (I 079) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 80
        !"test080"
        z1 <== (q*(p-3.4)-3.3/(-p)/(-q))
        z2 <== (y*(x-3.4)-3.3/(-x)/(-y))
        print.cccc (I 080) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 81
        !"test081"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 081) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 82
        !"test082"
        z1 <== (q-(-4.2)/(-2.2)*(-8.3)*(-5.7)*(-q)*(((-2.1)*(-1.2))+(-p)))
        z2 <== (y-(-4.2)/(-2.2)*(-8.3)*(-5.7)*(-y)*(((-2.1)*(-1.2))+(-x)))
        print.cccc (I 082) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 83
        !"test083"
        z1 <== ((((-q)-(-p)*(-q)/(-p))-((-p)+p))-((-q)*(-q)-(-7.2)-q-p/((-8.0)-(-5.4)+p)-((-q)-(-6.3)-p*(-q))/(q/(-q)-(-p))-(0.0-(-7.2)))*(((-q)*p)+(-1.1)))
        z2 <== ((((-y)-(-x)*(-y)/(-x))-((-x)+x))-((-y)*(-y)-(-7.2)-y-x/((-8.0)-(-5.4)+x)-((-y)-(-6.3)-x*(-y))/(y/(-y)-(-x))-(0.0-(-7.2)))*(((-y)*x)+(-1.1)))
        print.cccc (I 083) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 84
        !"test084"
        z1 <== q
        z2 <== y
        print.cccc (I 084) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 85
        !"test085"
        z1 <== (((6.3/p*(-p)/p)/((-q)))/q*((-8.2)*(-p)/((-7.7)+(-8.8)+6.3/(-1.1)*(-q))))
        z2 <== (((6.3/x*(-x)/x)/((-y)))/y*((-8.2)*(-x)/((-7.7)+(-8.8)+6.3/(-1.1)*(-y))))
        print.cccc (I 085) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 86
        !"test086"
        z1 <== 4.3
        z2 <== 4.3
        print.cccc (I 086) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 87
        !"test087"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 087) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 88
        !"test088"
        z1 <== ((-p)/(-q)+(-q)-p*q*(-q)*q*((-0.3)/(-p)*(-5.1)-(-q)*2.2))/3.3-(-p)
        z2 <== ((-x)/(-y)+(-y)-x*y*(-y)*y*((-0.3)/(-x)*(-5.1)-(-y)*2.2))/3.3-(-x)
        print.cccc (I 088) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 89
        !"test089"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 089) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 90
        !"test090"
        z1 <== (((-2.0)*4.5)*((p)*(-0.7)-(-q)*(6.6+q-p))-(-p)+(-q)/0.4)
        z2 <== (((-2.0)*4.5)*((x)*(-0.7)-(-y)*(6.6+y-x))-(-x)+(-y)/0.4)
        print.cccc (I 090) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 91
        !"test091"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 091) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 92
        !"test092"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 092) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 93
        !"test093"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 093) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 94
        !"test094"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 094) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 95
        !"test095"
        z1 <== (((-p))/(-0.6))
        z2 <== (((-x))/(-0.6))
        print.cccc (I 095) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 96
        !"test096"
        z1 <== (((-p)-p/q-(-8.6))-(-p)+(-5.2)-(-4.5)/((-p)/6.5*7.7*(-p)+p)+1.2+(-3.3)/((-p)))
        z2 <== (((-x)-x/y-(-8.6))-(-x)+(-5.2)-(-4.5)/((-x)/6.5*7.7*(-x)+x)+1.2+(-3.3)/((-x)))
        print.cccc (I 096) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 97
        !"test097"
        z1 <== q
        z2 <== y
        print.cccc (I 097) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 98
        !"test098"
        z1 <== (q-(p/(-1.6)*(-5.6)-(-p))/(q-0.1/0.0-p+8.3)+(5.0*q+8.7*(-8.7)+(-q))*(-3.7)*2.1)
        z2 <== (y-(x/(-1.6)*(-5.6)-(-x))/(y-0.1/0.0-x+8.3)+(5.0*y+8.7*(-8.7)+(-y))*(-3.7)*2.1)
        print.cccc (I 098) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 99
        !"test099"
        z1 <== (((-6.1)+(-p)-(-8.0)/(-7.0)))
        z2 <== (((-6.1)+(-x)-(-8.0)/(-7.0)))
        print.cccc (I 099) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 100
        !"test100"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 100) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 101
        !"test101"
        z1 <== ((-p)-(-p)+p)
        z2 <== ((-x)-(-x)+x)
        print.cccc (I 101) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 102
        !"test102"
        z1 <== (((-5.7)-q+4.0/q*q-5.5)+((7.7*7.4/(-p)/(-0.6))/((-8.6)/3.5-q))/((-3.3)+p/(-q)+(-0.8)/5.1-(8.1-(-q))*(p+(-3.4)-7.8))/p)
        z2 <== (((-5.7)-y+4.0/y*y-5.5)+((7.7*7.4/(-x)/(-0.6))/((-8.6)/3.5-y))/((-3.3)+x/(-y)+(-0.8)/5.1-(8.1-(-y))*(x+(-3.4)-7.8))/x)
        print.cccc (I 102) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 103
        !"test103"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 103) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 104
        !"test104"
        z1 <== (((-6.2)+(-4.7)-1.5/q))+((-0.8)+(-7.4)/((-4.8)/(-4.2)*(-p)-p)*p+(3.7-(-q)+6.2*(-8.8)))*((-7.4)*(-q)+q*2.6-(-8.8)+8.0)
        z2 <== (((-6.2)+(-4.7)-1.5/y))+((-0.8)+(-7.4)/((-4.8)/(-4.2)*(-x)-x)*x+(3.7-(-y)+6.2*(-8.8)))*((-7.4)*(-y)+y*2.6-(-8.8)+8.0)
        print.cccc (I 104) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 105
        !"test105"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 105) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 106
        !"test106"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 106) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 107
        !"test107"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 107) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 108
        !"test108"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 108) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 109
        !"test109"
        z1 <== (-q)/(q+(4.8/q+(-q)/(-p))+(-3.6)-(-q))/(((-p)*q/(-p)))+(p*(6.4*(-6.4))-7.8*(2.5/5.7*(-1.5)-(-1.1)))
        z2 <== (-y)/(y+(4.8/y+(-y)/(-x))+(-3.6)-(-y))/(((-x)*y/(-x)))+(x*(6.4*(-6.4))-7.8*(2.5/5.7*(-1.5)-(-1.1)))
        print.cccc (I 109) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 110
        !"test110"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 110) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 111
        !"test111"
        z1 <== ((-5.0)-(p/(-p)/(-3.5)*8.4-((-2.4)*q+(-7.6)))/(-q))
        z2 <== ((-5.0)-(x/(-x)/(-3.5)*8.4-((-2.4)*y+(-7.6)))/(-y))
        print.cccc (I 111) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 112
        !"test112"
        z1 <== (((-7.1)/(-0.4)-p)-q+3.7-((-7.5))*(p*7.1/4.4*(-8.8))*(-5.1)/0.2/0.8)
        z2 <== (((-7.1)/(-0.4)-x)-y+3.7-((-7.5))*(x*7.1/4.4*(-8.8))*(-5.1)/0.2/0.8)
        print.cccc (I 112) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 113
        !"test113"
        z1 <== (((p*p-q)+q*(-3.5)+7.3))
        z2 <== (((x*x-y)+y*(-3.5)+7.3))
        print.cccc (I 113) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 114
        !"test114"
        z1 <== ((-1.6)/(q*(p*7.5-2.2/(-q))+(-p))*(2.5/q*((-q)*(-3.6)-0.5-q+(-3.4))+(2.5-1.6))+((-2.1)-((-p)*3.1)-(-q)))
        z2 <== ((-1.6)/(y*(x*7.5-2.2/(-y))+(-x))*(2.5/y*((-y)*(-3.6)-0.5-y+(-3.4))+(2.5-1.6))+((-2.1)-((-x)*3.1)-(-y)))
        print.cccc (I 114) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 115
        !"test115"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 115) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 116
        !"test116"
        z1 <== ((4.2/(6.0*(-1.4)/(-8.0)*4.8)-(-4.0)-p)-(-5.6)*(-q)+(2.8+((-3.1)/2.8+(-q))+(-6.5)*((-p)/(-5.8)/(-q))))
        z2 <== ((4.2/(6.0*(-1.4)/(-8.0)*4.8)-(-4.0)-x)-(-5.6)*(-y)+(2.8+((-3.1)/2.8+(-y))+(-6.5)*((-x)/(-5.8)/(-y))))
        print.cccc (I 116) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 117
        !"test117"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 117) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 118
        !"test118"
        z1 <== (((-1.4)/((-6.1)-q+8.7/(-4.6)))-((-0.7)*p+((-7.2)/(-p)-0.5*p+q)+q)-p*(-q)+p)
        z2 <== (((-1.4)/((-6.1)-y+8.7/(-4.6)))-((-0.7)*x+((-7.2)/(-x)-0.5*x+y)+y)-x*(-y)+x)
        print.cccc (I 118) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 119
        !"test119"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 119) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 120
        !"test120"
        z1 <== (((-q)-q))
        z2 <== (((-y)-y))
        print.cccc (I 120) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 121
        !"test121"
        z1 <== ((-p)+p)
        z2 <== ((-x)+x)
        print.cccc (I 121) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 122
        !"test122"
        z1 <== (-q)*(-p)*(p-(-q)+p)
        z2 <== (-y)*(-x)*(x-(-y)+x)
        print.cccc (I 122) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 123
        !"test123"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 123) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 124
        !"test124"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 124) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 125
        !"test125"
        z1 <== ((-3.1))
        z2 <== ((-3.1))
        print.cccc (I 125) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 126
        !"test126"
        z1 <== p
        z2 <== x
        print.cccc (I 126) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 127
        !"test127"
        z1 <== 2.2
        z2 <== 2.2
        print.cccc (I 127) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 128
        !"test128"
        z1 <== p
        z2 <== x
        print.cccc (I 128) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 129
        !"test129"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 129) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 130
        !"test130"
        z1 <== ((-p)-(-3.1)/((-3.0)-1.2+(-7.7)*((-5.6)-2.3/q+6.2+1.1)))
        z2 <== ((-x)-(-3.1)/((-3.0)-1.2+(-7.7)*((-5.6)-2.3/y+6.2+1.1)))
        print.cccc (I 130) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 131
        !"test131"
        z1 <== (8.5+(-3.1))
        z2 <== (8.5+(-3.1))
        print.cccc (I 131) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 132
        !"test132"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 132) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 133
        !"test133"
        z1 <== (2.3)
        z2 <== (2.3)
        print.cccc (I 133) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 134
        !"test134"
        z1 <== ((2.3-(q))+(-q)-(q*q-0.3)/p)
        z2 <== ((2.3-(y))+(-y)-(y*y-0.3)/x)
        print.cccc (I 134) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 135
        !"test135"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 135) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 136
        !"test136"
        z1 <== ((((-0.6)/p-(-0.1)+5.8)))
        z2 <== ((((-0.6)/x-(-0.1)+5.8)))
        print.cccc (I 136) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 137
        !"test137"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 137) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 138
        !"test138"
        z1 <== ((-p)*6.4-(p+(q*(-0.2)/q+(-3.8)*(-7.4))/(p-(-6.4)*p)))
        z2 <== ((-x)*6.4-(x+(y*(-0.2)/y+(-3.8)*(-7.4))/(x-(-6.4)*x)))
        print.cccc (I 138) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 139
        !"test139"
        z1 <== ((-4.2)+p)
        z2 <== ((-4.2)+x)
        print.cccc (I 139) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 140
        !"test140"
        z1 <== ((-8.7))
        z2 <== ((-8.7))
        print.cccc (I 140) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 141
        !"test141"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 141) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 142
        !"test142"
        z1 <== ((2.3-p+q*(-p))+6.1)+(p-((-3.2)*(-1.8)*3.0-p+p)*((-q)/q)-((-q)*q)/(-q)-(-2.4)/(-q)-p/(-p))/5.2+(-q)-((-q))
        z2 <== ((2.3-x+y*(-x))+6.1)+(x-((-3.2)*(-1.8)*3.0-x+x)*((-y)/y)-((-y)*y)/(-y)-(-2.4)/(-y)-x/(-x))/5.2+(-y)-((-y))
        print.cccc (I 142) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 143
        !"test143"
        z1 <== (-6.8)*q/((p-(-q)/q+p)+(-q)-(-p)/(-q)/(-q))+(-0.1)
        z2 <== (-6.8)*y/((x-(-y)/y+x)+(-y)-(-x)/(-y)/(-y))+(-0.1)
        print.cccc (I 143) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 144
        !"test144"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 144) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 145
        !"test145"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 145) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 146
        !"test146"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 146) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 147
        !"test147"
        z1 <== (0.8)
        z2 <== (0.8)
        print.cccc (I 147) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 148
        !"test148"
        z1 <== ((-0.1)/2.6-(7.8-((-4.8)*(-q)/5.1-p)+8.8+(-4.4)/(-p)-2.5)*0.1-((-q)/(-5.7)+(-p)-(-3.7))-q+((6.5+(-3.2)+5.4-q)/(-p)))
        z2 <== ((-0.1)/2.6-(7.8-((-4.8)*(-y)/5.1-x)+8.8+(-4.4)/(-x)-2.5)*0.1-((-y)/(-5.7)+(-x)-(-3.7))-y+((6.5+(-3.2)+5.4-y)/(-x)))
        print.cccc (I 148) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 149
        !"test149"
        z1 <== ((p)/((3.3*p-(-0.4)*q-(-p))*(-8.4)-q)*q-(-q)*(p+7.2*(p-(-p)*4.2)*(q+q*(-7.6)-(-p))*(q*4.3+(-3.5)+(-p)*p)/((-8.0)+(-p)*q)))
        z2 <== ((x)/((3.3*x-(-0.4)*y-(-x))*(-8.4)-y)*y-(-y)*(x+7.2*(x-(-x)*4.2)*(y+y*(-7.6)-(-x))*(y*4.3+(-3.5)+(-x)*x)/((-8.0)+(-x)*y)))
        print.cccc (I 149) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 150
        !"test150"
        z1 <== ((-2.4))
        z2 <== ((-2.4))
        print.cccc (I 150) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 151
        !"test151"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 151) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 152
        !"test152"
        z1 <== (p*4.6)+(p*0.5/8.6)*(8.0*(-q)+5.8/(-0.2)-1.3)/4.3+5.0
        z2 <== (x*4.6)+(x*0.5/8.6)*(8.0*(-y)+5.8/(-0.2)-1.3)/4.3+5.0
        print.cccc (I 152) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 153
        !"test153"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 153) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 154
        !"test154"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 154) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 155
        !"test155"
        z1 <== ((-1.6)+((p-q-(-7.5)-(-q))/(-4.4))/q-(4.4))
        z2 <== ((-1.6)+((x-y-(-7.5)-(-y))/(-4.4))/y-(4.4))
        print.cccc (I 155) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 156
        !"test156"
        z1 <== (2.2)
        z2 <== (2.2)
        print.cccc (I 156) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 157
        !"test157"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 157) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 158
        !"test158"
        z1 <== ((-3.8)*(-q))
        z2 <== ((-3.8)*(-y))
        print.cccc (I 158) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 159
        !"test159"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 159) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 160
        !"test160"
        z1 <== ((-q)*4.0*((-4.1)-2.3/(-6.8)-(-p)*(2.0*(-8.1)/3.6+5.1)/(q-(-6.2)+2.8+2.6)-(q/8.0*(-5.4)))+p+((p)/0.2-((-p)+p*(-3.3))*(q)*p))
        z2 <== ((-y)*4.0*((-4.1)-2.3/(-6.8)-(-x)*(2.0*(-8.1)/3.6+5.1)/(y-(-6.2)+2.8+2.6)-(y/8.0*(-5.4)))+x+((x)/0.2-((-x)+x*(-3.3))*(y)*x))
        print.cccc (I 160) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 161
        !"test161"
        z1 <== p
        z2 <== x
        print.cccc (I 161) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 162
        !"test162"
        z1 <== (p/((-p)*(-p)*p+(-q)-q-(-4.6)+((-q)-(-p)/q/(-q)+5.6)/(-5.5)))
        z2 <== (x/((-x)*(-x)*x+(-y)-y-(-4.6)+((-y)-(-x)/y/(-y)+5.6)/(-5.5)))
        print.cccc (I 162) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 163
        !"test163"
        z1 <== ((-q)*(((-7.6)*1.0-p)-(-p)-(-3.7)/(p+p-(-p))-((-p)-(-q)/2.6*8.8+(-q)))/1.8)
        z2 <== ((-y)*(((-7.6)*1.0-x)-(-x)-(-3.7)/(x+x-(-x))-((-x)-(-y)/2.6*8.8+(-y)))/1.8)
        print.cccc (I 163) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 164
        !"test164"
        z1 <== (((-0.3)-(-p)-(-3.5))+(0.3-2.7/(p*(-q)*3.1)/((-q)/p/(-4.4)/0.3)/1.6)+(-8.0)*(-p))
        z2 <== (((-0.3)-(-x)-(-3.5))+(0.3-2.7/(x*(-y)*3.1)/((-y)/x/(-4.4)/0.3)/1.6)+(-8.0)*(-x))
        print.cccc (I 164) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 165
        !"test165"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 165) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 166
        !"test166"
        z1 <== (((-p))-(q/(-p)*(-2.8)-(-q)-8.2*p*p))
        z2 <== (((-x))-(y/(-x)*(-2.8)-(-y)-8.2*x*x))
        print.cccc (I 166) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 167
        !"test167"
        z1 <== ((5.0+(-0.6))-((-3.2)-(8.2+q*q/p)*8.8)-p/((p/(-p)-p))/(-1.3))
        z2 <== ((5.0+(-0.6))-((-3.2)-(8.2+y*y/x)*8.8)-x/((x/(-x)-x))/(-1.3))
        print.cccc (I 167) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 168
        !"test168"
        z1 <== p
        z2 <== x
        print.cccc (I 168) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 169
        !"test169"
        z1 <== ((-p)+q*((-q)/(-0.8)*(0.6/q/(-p))*(-5.5)-(-p)-(-5.4)/q+(-p))*(-1.0))
        z2 <== ((-x)+y*((-y)/(-0.8)*(0.6/y/(-x))*(-5.5)-(-x)-(-5.4)/y+(-x))*(-1.0))
        print.cccc (I 169) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 170
        !"test170"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 170) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 171
        !"test171"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 171) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 172
        !"test172"
        z1 <== ((8.1)+(-p)*(((-6.0)*p-p*(-5.7)-(-1.6))+(-3.4)-(-q)-(8.5-(-q))+(-8.8)))
        z2 <== ((8.1)+(-x)*(((-6.0)*x-x*(-5.7)-(-1.6))+(-3.4)-(-y)-(8.5-(-y))+(-8.8)))
        print.cccc (I 172) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 173
        !"test173"
        z1 <== (6.8+(7.4+7.0-(-4.3)*0.2*1.8)-(-7.5)+6.5+(-5.3)+(p))
        z2 <== (6.8+(7.4+7.0-(-4.3)*0.2*1.8)-(-7.5)+6.5+(-5.3)+(x))
        print.cccc (I 173) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 174
        !"test174"
        z1 <== (3.8-(-8.1)+(-q)/(-3.3)-8.5/p*((-q)))
        z2 <== (3.8-(-8.1)+(-y)/(-3.3)-8.5/x*((-y)))
        print.cccc (I 174) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 175
        !"test175"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 175) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 176
        !"test176"
        z1 <== (((q*q*0.3)-(0.8*(-6.6)+5.5))-((p/2.3*p)/(-4.7)/(8.8*(-7.2)/(-p)*(-7.0)*(-p))-p+(-7.5)*(-6.8)-(-q)*((-q)*p)))
        z2 <== (((y*y*0.3)-(0.8*(-6.6)+5.5))-((x/2.3*x)/(-4.7)/(8.8*(-7.2)/(-x)*(-7.0)*(-x))-x+(-7.5)*(-6.8)-(-y)*((-y)*x)))
        print.cccc (I 176) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 177
        !"test177"
        z1 <== (1.6/(-4.0))
        z2 <== (1.6/(-4.0))
        print.cccc (I 177) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 178
        !"test178"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 178) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 179
        !"test179"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 179) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 180
        !"test180"
        z1 <== (((-4.0)+7.5/(0.2)+((-q)-q*(-4.8)*8.7-(-0.0)))+(-5.3)-q*(-p)/8.2)
        z2 <== (((-4.0)+7.5/(0.2)+((-y)-y*(-4.8)*8.7-(-0.0)))+(-5.3)-y*(-x)/8.2)
        print.cccc (I 180) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 181
        !"test181"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 181) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 182
        !"test182"
        z1 <== (-0.1)
        z2 <== (-0.1)
        print.cccc (I 182) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 183
        !"test183"
        z1 <== p
        z2 <== x
        print.cccc (I 183) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 184
        !"test184"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 184) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 185
        !"test185"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 185) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 186
        !"test186"
        z1 <== ((-3.5)/(3.3+(0.4+0.2-5.3)/(1.2-q+(-q))+((-q)-3.3/1.8-q)*2.4)+((-p)+((-q)*0.8)-(1.1)*((-q)-(-2.6))*q)*3.1-(-p)-(0.0)*p/(-0.2))
        z2 <== ((-3.5)/(3.3+(0.4+0.2-5.3)/(1.2-y+(-y))+((-y)-3.3/1.8-y)*2.4)+((-x)+((-y)*0.8)-(1.1)*((-y)-(-2.6))*y)*3.1-(-x)-(0.0)*x/(-0.2))
        print.cccc (I 186) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 187
        !"test187"
        z1 <== 4.3
        z2 <== 4.3
        print.cccc (I 187) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 188
        !"test188"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 188) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 189
        !"test189"
        z1 <== q
        z2 <== y
        print.cccc (I 189) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 190
        !"test190"
        z1 <== (q+((7.8+3.0+(-2.0)*4.1)/8.4-(-5.0))*((1.2-(-q)*7.4)/((-p))/(q+p*p)/(5.5/7.4/(-p)*q*q)/(p-q))/(-7.1)+(-p)+(-8.4)-q+(-p))
        z2 <== (y+((7.8+3.0+(-2.0)*4.1)/8.4-(-5.0))*((1.2-(-y)*7.4)/((-x))/(y+x*x)/(5.5/7.4/(-x)*y*y)/(x-y))/(-7.1)+(-x)+(-8.4)-y+(-x))
        print.cccc (I 190) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 191
        !"test191"
        z1 <== ((-7.0)/p*p*q/8.2+7.4+(-p))
        z2 <== ((-7.0)/x*x*y/8.2+7.4+(-x))
        print.cccc (I 191) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 192
        !"test192"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 192) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 193
        !"test193"
        z1 <== ((-7.2)-(-q)/((q+5.3+(-0.6))/(p))*((-6.7)/(-p)/((-p)))-(-p))
        z2 <== ((-7.2)-(-y)/((y+5.3+(-0.6))/(x))*((-6.7)/(-x)/((-x)))-(-x))
        print.cccc (I 193) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 194
        !"test194"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 194) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 195
        !"test195"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 195) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 196
        !"test196"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 196) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 197
        !"test197"
        z1 <== ((-q)/(-1.3)/(-2.7))
        z2 <== ((-y)/(-1.3)/(-2.7))
        print.cccc (I 197) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 198
        !"test198"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 198) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 199
        !"test199"
        z1 <== ((-2.7)*(6.6*(-q)+(-q)+(-q)*q)*q)
        z2 <== ((-2.7)*(6.6*(-y)+(-y)+(-y)*y)*y)
        print.cccc (I 199) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 200
        !"test200"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 200) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 201
        !"test201"
        z1 <== p
        z2 <== x
        print.cccc (I 201) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 202
        !"test202"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 202) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 203
        !"test203"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 203) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 204
        !"test204"
        z1 <== ((-0.5)*(-q)+(((-3.8)-(-3.3))/(6.1+q)))
        z2 <== ((-0.5)*(-y)+(((-3.8)-(-3.3))/(6.1+y)))
        print.cccc (I 204) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 205
        !"test205"
        z1 <== (-q)/1.7-p*(8.8*4.7)
        z2 <== (-y)/1.7-x*(8.8*4.7)
        print.cccc (I 205) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 206
        !"test206"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 206) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 207
        !"test207"
        z1 <== ((4.4-(q*(-1.5)-(-3.7))/(5.2+5.6*q))/((q)/((-p)-p*(-q)/(-2.4)/7.4)+((-q))-(-6.5))*((-2.2)*(q*1.2)+7.6*((-q))*(-q))+((-3.1)*((-p)-(-2.4)-q)+q-(-6.8)-q)/5.0)
        z2 <== ((4.4-(y*(-1.5)-(-3.7))/(5.2+5.6*y))/((y)/((-x)-x*(-y)/(-2.4)/7.4)+((-y))-(-6.5))*((-2.2)*(y*1.2)+7.6*((-y))*(-y))+((-3.1)*((-x)-(-2.4)-y)+y-(-6.8)-y)/5.0)
        print.cccc (I 207) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 208
        !"test208"
        z1 <== ((-p)/(-2.8)+(-p)+p-((-q)/(-q)))
        z2 <== ((-x)/(-2.8)+(-x)+x-((-y)/(-y)))
        print.cccc (I 208) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 209
        !"test209"
        z1 <== ((2.4-(-p))*((-6.6)*((-p)/p*(-p)/(-3.7))))
        z2 <== ((2.4-(-x))*((-6.6)*((-x)/x*(-x)/(-3.7))))
        print.cccc (I 209) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 210
        !"test210"
        z1 <== ((p*(q)/(-p))+(((-q)*3.6+(-p)+(-q))*p/(-8.8)))
        z2 <== ((x*(y)/(-x))+(((-y)*3.6+(-x)+(-y))*x/(-8.8)))
        print.cccc (I 210) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 211
        !"test211"
        z1 <== p
        z2 <== x
        print.cccc (I 211) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 212
        !"test212"
        z1 <== (p-((-q)/(-p)/(-6.6)+6.6*5.8)*(-q)+3.4)
        z2 <== (x-((-y)/(-x)/(-6.6)+6.6*5.8)*(-y)+3.4)
        print.cccc (I 212) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 213
        !"test213"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 213) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 214
        !"test214"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 214) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 215
        !"test215"
        z1 <== (p*p+((-6.4)+((-q)-5.2)-(-q))+(1.2))
        z2 <== (x*x+((-6.4)+((-y)-5.2)-(-y))+(1.2))
        print.cccc (I 215) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 216
        !"test216"
        z1 <== (((3.2*6.4-p+p)*((-8.2)/(-q)-4.2)+(-p)/((-2.5))-3.3)/(6.4+(-6.0)/((-p)+p*q*p)/((-p)-p))+((-p)))
        z2 <== (((3.2*6.4-x+x)*((-8.2)/(-y)-4.2)+(-x)/((-2.5))-3.3)/(6.4+(-6.0)/((-x)+x*y*x)/((-x)-x))+((-x)))
        print.cccc (I 216) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 217
        !"test217"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 217) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 218
        !"test218"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 218) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 219
        !"test219"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 219) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 220
        !"test220"
        z1 <== p
        z2 <== x
        print.cccc (I 220) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 221
        !"test221"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 221) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 222
        !"test222"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 222) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 223
        !"test223"
        z1 <== (q-((-4.7))+(-1.3)/((-q)+(-6.1)/q+(p))/(((-6.8)-4.8-(-6.3)+(-5.6))-(q+3.7*(-p)+(-p)/(-5.0))))
        z2 <== (y-((-4.7))+(-1.3)/((-y)+(-6.1)/y+(x))/(((-6.8)-4.8-(-6.3)+(-5.6))-(y+3.7*(-x)+(-x)/(-5.0))))
        print.cccc (I 223) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 224
        !"test224"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 224) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 225
        !"test225"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 225) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 226
        !"test226"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 226) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 227
        !"test227"
        z1 <== 7.6
        z2 <== 7.6
        print.cccc (I 227) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 228
        !"test228"
        z1 <== p
        z2 <== x
        print.cccc (I 228) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 229
        !"test229"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 229) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 230
        !"test230"
        z1 <== (((p*q+(-5.4))/q*(-8.6)*p-p)*q)
        z2 <== (((x*y+(-5.4))/y*(-8.6)*x-x)*y)
        print.cccc (I 230) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 231
        !"test231"
        z1 <== ((-0.3))
        z2 <== ((-0.3))
        print.cccc (I 231) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 232
        !"test232"
        z1 <== (-p)/(-q)*1.5
        z2 <== (-x)/(-y)*1.5
        print.cccc (I 232) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 233
        !"test233"
        z1 <== (2.8/(-2.2)*q/(((-p)/(-4.2)+q*7.2)/2.5+(q-q+p)*2.7/(-0.8))+(((-p)/q/(-p))))
        z2 <== (2.8/(-2.2)*y/(((-x)/(-4.2)+y*7.2)/2.5+(y-y+x)*2.7/(-0.8))+(((-x)/y/(-x))))
        print.cccc (I 233) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 234
        !"test234"
        z1 <== ((1.2+((-0.2)-p/2.4*(-6.7)-p)*(-q)+0.7)/q)
        z2 <== ((1.2+((-0.2)-x/2.4*(-6.7)-x)*(-y)+0.7)/y)
        print.cccc (I 234) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 235
        !"test235"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 235) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 236
        !"test236"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 236) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 237
        !"test237"
        z1 <== ((p+(p+(-p)/(-p)+(-0.6))/q-(-q))-(-2.0))
        z2 <== ((x+(x+(-x)/(-x)+(-0.6))/y-(-y))-(-2.0))
        print.cccc (I 237) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 238
        !"test238"
        z1 <== (p+(-7.8)+((q*3.5)+((-3.0))/(-q))+q)
        z2 <== (x+(-7.8)+((y*3.5)+((-3.0))/(-y))+y)
        print.cccc (I 238) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 239
        !"test239"
        z1 <== ((((-q))/(q)+((-7.3)/(-0.5)-(-5.0)-(-6.5)+(-2.8))-7.3*2.5/(-2.3)+q-2.2*p)+(-q)/p+((-8.6)*(p-0.2/(-2.2))*((-p)-(-q)+(-1.8)))/q)
        z2 <== ((((-y))/(y)+((-7.3)/(-0.5)-(-5.0)-(-6.5)+(-2.8))-7.3*2.5/(-2.3)+y-2.2*x)+(-y)/x+((-8.6)*(x-0.2/(-2.2))*((-x)-(-y)+(-1.8)))/y)
        print.cccc (I 239) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 240
        !"test240"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 240) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 241
        !"test241"
        z1 <== p+((-2.3)+(p))+(-3.1)
        z2 <== x+((-2.3)+(x))+(-3.1)
        print.cccc (I 241) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 242
        !"test242"
        z1 <== (((-7.5)+(6.1/(-8.5)-(-q))*((-p)*q-p*3.2)-(7.5/(-2.5))+p)+((2.1-(-p)/(-q))-(4.2)-(4.4*p+3.7-q+q)+3.6)+(-p))
        z2 <== (((-7.5)+(6.1/(-8.5)-(-y))*((-x)*y-x*3.2)-(7.5/(-2.5))+x)+((2.1-(-x)/(-y))-(4.2)-(4.4*x+3.7-y+y)+3.6)+(-x))
        print.cccc (I 242) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 243
        !"test243"
        z1 <== (-2.0)/q
        z2 <== (-2.0)/y
        print.cccc (I 243) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 244
        !"test244"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 244) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 245
        !"test245"
        z1 <== (((-1.7)*8.0+q)+((-8.2)/((-6.2)/q*5.0)-(p*q+1.5/(-q))/(6.0/p)/((-5.5)+(-3.5)*(-6.2)))/(0.3*(q)/(-0.2))-(((-7.3))-(-q)/((-6.8)/7.3)*((-q)+2.7))-(4.5-0.8+q+((-p))/q))
        z2 <== (((-1.7)*8.0+y)+((-8.2)/((-6.2)/y*5.0)-(x*y+1.5/(-y))/(6.0/x)/((-5.5)+(-3.5)*(-6.2)))/(0.3*(y)/(-0.2))-(((-7.3))-(-y)/((-6.8)/7.3)*((-y)+2.7))-(4.5-0.8+y+((-x))/y))
        print.cccc (I 245) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 246
        !"test246"
        z1 <== p
        z2 <== x
        print.cccc (I 246) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 247
        !"test247"
        z1 <== q
        z2 <== y
        print.cccc (I 247) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 248
        !"test248"
        z1 <== (-1.6)
        z2 <== (-1.6)
        print.cccc (I 248) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 249
        !"test249"
        z1 <== ((-q)*((-8.1)/(-q)+2.1-8.5-(-q))/2.3/((-q)-q))/((-0.5)-(-q))
        z2 <== ((-y)*((-8.1)/(-y)+2.1-8.5-(-y))/2.3/((-y)-y))/((-0.5)-(-y))
        print.cccc (I 249) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 250
        !"test250"
        z1 <== (q/(((-0.4)+(-p)*q+(-q)*(-7.6))-(-2.3)+((-q)-(-p)-(-3.6))-(7.2-7.3/(-p))*(p))*((-q)*(-8.0)+p/(-q)/q*(p+(-q)-(-q)-p+(-4.0))))
        z2 <== (y/(((-0.4)+(-x)*y+(-y)*(-7.6))-(-2.3)+((-y)-(-x)-(-3.6))-(7.2-7.3/(-x))*(x))*((-y)*(-8.0)+x/(-y)/y*(x+(-y)-(-y)-x+(-4.0))))
        print.cccc (I 250) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 251
        !"test251"
        z1 <== ((q*5.3*(-q)*(-q)+(-p)-(-0.6)/(-2.3)*(-1.4))/(p-((-q))+1.8/(-p))-(-p)+(-5.7)*0.7)
        z2 <== ((y*5.3*(-y)*(-y)+(-x)-(-0.6)/(-2.3)*(-1.4))/(x-((-y))+1.8/(-x))-(-x)+(-5.7)*0.7)
        print.cccc (I 251) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 252
        !"test252"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 252) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 253
        !"test253"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 253) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 254
        !"test254"
        z1 <== ((-2.2))
        z2 <== ((-2.2))
        print.cccc (I 254) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 255
        !"test255"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 255) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 256
        !"test256"
        z1 <== (1.0)
        z2 <== (1.0)
        print.cccc (I 256) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 257
        !"test257"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 257) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 258
        !"test258"
        z1 <== 7.2-(-q)/((-p)-p)+((-q)-(-3.6)/(-p)+(-1.2))+(p+1.4)-p*(((-8.7)*(-1.5)))
        z2 <== 7.2-(-y)/((-x)-x)+((-y)-(-3.6)/(-x)+(-1.2))+(x+1.4)-x*(((-8.7)*(-1.5)))
        print.cccc (I 258) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 259
        !"test259"
        z1 <== ((-8.2)*(p-(-2.8)*p+(-q))-p-3.7*p-(7.8*((-p)+q-(-4.6)/p)+((-5.5)+3.7*q)+(-5.4)))
        z2 <== ((-8.2)*(x-(-2.8)*x+(-y))-x-3.7*x-(7.8*((-x)+y-(-4.6)/x)+((-5.5)+3.7*y)+(-5.4)))
        print.cccc (I 259) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 260
        !"test260"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 260) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 261
        !"test261"
        z1 <== (((-p)+7.1))
        z2 <== (((-x)+7.1))
        print.cccc (I 261) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 262
        !"test262"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 262) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 263
        !"test263"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 263) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 264
        !"test264"
        z1 <== (((-p))*(-8.0))
        z2 <== (((-x))*(-8.0))
        print.cccc (I 264) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 265
        !"test265"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 265) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 266
        !"test266"
        z1 <== (3.4+(-p))
        z2 <== (3.4+(-x))
        print.cccc (I 266) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 267
        !"test267"
        z1 <== ((-p)+((-q)+5.2-((-6.0)+(-p)+(-q)+(-q)*0.1))*(8.2+(-p)+(-p))-(-q))
        z2 <== ((-x)+((-y)+5.2-((-6.0)+(-x)+(-y)+(-y)*0.1))*(8.2+(-x)+(-x))-(-y))
        print.cccc (I 267) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 268
        !"test268"
        z1 <== p
        z2 <== x
        print.cccc (I 268) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 269
        !"test269"
        z1 <== q
        z2 <== y
        print.cccc (I 269) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 270
        !"test270"
        z1 <== p
        z2 <== x
        print.cccc (I 270) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 271
        !"test271"
        z1 <== (-5.1)
        z2 <== (-5.1)
        print.cccc (I 271) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 272
        !"test272"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 272) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 273
        !"test273"
        z1 <== p
        z2 <== x
        print.cccc (I 273) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 274
        !"test274"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 274) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 275
        !"test275"
        z1 <== ((((-2.1)/p/(-q))-7.7/(-3.7)+(-8.7)/(-0.5)-(-p)))
        z2 <== ((((-2.1)/x/(-y))-7.7/(-3.7)+(-8.7)/(-0.5)-(-x)))
        print.cccc (I 275) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 276
        !"test276"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 276) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 277
        !"test277"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 277) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 278
        !"test278"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 278) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 279
        !"test279"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 279) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 280
        !"test280"
        z1 <== (-2.0)
        z2 <== (-2.0)
        print.cccc (I 280) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 281
        !"test281"
        z1 <== (-3.5)-(q*(-p))-((-q)/p+(-q)-5.1+4.1)+((-q)*5.2*p+2.7-8.2)+6.4+8.6/(q-(-0.8)*(p/(-p))/(-0.3)+((-4.8)*4.5+(-p)))-q
        z2 <== (-3.5)-(y*(-x))-((-y)/x+(-y)-5.1+4.1)+((-y)*5.2*x+2.7-8.2)+6.4+8.6/(y-(-0.8)*(x/(-x))/(-0.3)+((-4.8)*4.5+(-x)))-y
        print.cccc (I 281) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 282
        !"test282"
        z1 <== (p+5.0)
        z2 <== (x+5.0)
        print.cccc (I 282) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 283
        !"test283"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 283) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 284
        !"test284"
        z1 <== ((-3.2))
        z2 <== ((-3.2))
        print.cccc (I 284) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 285
        !"test285"
        z1 <== (-7.4)
        z2 <== (-7.4)
        print.cccc (I 285) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 286
        !"test286"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 286) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 287
        !"test287"
        z1 <== q*(p/(8.8*(-q)/7.1+q)-((-q)-(-8.0))+q)-(-6.6)/(p-(-6.2)*p)*((-3.5)*5.6*8.8-(-5.7)+(-q))/p/(q)
        z2 <== y*(x/(8.8*(-y)/7.1+y)-((-y)-(-8.0))+y)-(-6.6)/(x-(-6.2)*x)*((-3.5)*5.6*8.8-(-5.7)+(-y))/x/(y)
        print.cccc (I 287) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 288
        !"test288"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 288) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 289
        !"test289"
        z1 <== q
        z2 <== y
        print.cccc (I 289) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 290
        !"test290"
        z1 <== (p/p)
        z2 <== (x/x)
        print.cccc (I 290) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 291
        !"test291"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 291) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 292
        !"test292"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 292) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 293
        !"test293"
        z1 <== ((-0.7))
        z2 <== ((-0.7))
        print.cccc (I 293) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 294
        !"test294"
        z1 <== ((-2.6)/2.0/1.0+(8.3-(8.5)+(-p)-(p)))
        z2 <== ((-2.6)/2.0/1.0+(8.3-(8.5)+(-x)-(x)))
        print.cccc (I 294) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 295
        !"test295"
        z1 <== (-6.5)
        z2 <== (-6.5)
        print.cccc (I 295) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 296
        !"test296"
        z1 <== (((-6.8))-((-q)-(-7.2)/((-5.6)-7.2*(-q))-(p-5.8*q/2.3))*((-p)+((-6.4)-(-4.1))))
        z2 <== (((-6.8))-((-y)-(-7.2)/((-5.6)-7.2*(-y))-(x-5.8*y/2.3))*((-x)+((-6.4)-(-4.1))))
        print.cccc (I 296) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 297
        !"test297"
        z1 <== ((-1.4))
        z2 <== ((-1.4))
        print.cccc (I 297) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 298
        !"test298"
        z1 <== (((-1.5)+2.8-(-p)*0.2/0.1-((-q)/(-7.7)+6.6))*q/q+p-(((-p)/(-0.1)+(-5.0))*(7.3/6.7-p/4.5)+((-3.6)/6.0)))
        z2 <== (((-1.5)+2.8-(-x)*0.2/0.1-((-y)/(-7.7)+6.6))*y/y+x-(((-x)/(-0.1)+(-5.0))*(7.3/6.7-x/4.5)+((-3.6)/6.0)))
        print.cccc (I 298) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 299
        !"test299"
        z1 <== ((q+(4.0)*(-p)-(-1.4)))
        z2 <== ((y+(4.0)*(-x)-(-1.4)))
        print.cccc (I 299) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 300
        !"test300"
        z1 <== p
        z2 <== x
        print.cccc (I 300) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 301
        !"test301"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 301) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 302
        !"test302"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 302) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 303
        !"test303"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 303) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 304
        !"test304"
        z1 <== 8.4*p*(q/((-6.6)+4.6+q*1.1-(-q))/0.5*(-4.3)+p/(-p))
        z2 <== 8.4*x*(y/((-6.6)+4.6+y*1.1-(-y))/0.5*(-4.3)+x/(-x))
        print.cccc (I 304) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 305
        !"test305"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 305) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 306
        !"test306"
        z1 <== ((-p)/(3.6)+p/(-p)*p/2.7)
        z2 <== ((-x)/(3.6)+x/(-x)*x/2.7)
        print.cccc (I 306) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 307
        !"test307"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 307) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 308
        !"test308"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 308) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 309
        !"test309"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 309) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 310
        !"test310"
        z1 <== ((q/(-q)+p-q)+(-8.0)*((q*p*(-5.6)-(-p)-(-0.1))+((-p))/(q)-(-p))/(p)-4.1)
        z2 <== ((y/(-y)+x-y)+(-8.0)*((y*x*(-5.6)-(-x)-(-0.1))+((-x))/(y)-(-x))/(x)-4.1)
        print.cccc (I 310) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 311
        !"test311"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 311) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 312
        !"test312"
        z1 <== (q/(-q)-p*7.1-((-2.4)*3.1+(-3.5)/(-p)*(2.5-q*p-0.1*(-q))+((-1.4)-(-p)-(-5.1)+2.6)))
        z2 <== (y/(-y)-x*7.1-((-2.4)*3.1+(-3.5)/(-x)*(2.5-y*x-0.1*(-y))+((-1.4)-(-x)-(-5.1)+2.6)))
        print.cccc (I 312) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 313
        !"test313"
        z1 <== q
        z2 <== y
        print.cccc (I 313) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 314
        !"test314"
        z1 <== (-q)/(p/7.5*(2.5-1.0+(-4.7)/q*(-q))/(7.7+(-3.1)-q)-((-q)/(-2.0)+(-p)/5.0))
        z2 <== (-y)/(x/7.5*(2.5-1.0+(-4.7)/y*(-y))/(7.7+(-3.1)-y)-((-y)/(-2.0)+(-x)/5.0))
        print.cccc (I 314) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 315
        !"test315"
        z1 <== ((-8.3)-8.1/(-0.3)*(8.4*q+(-q)*(-p)/(-7.1)/3.4*p-(-1.2)+q)+4.6)
        z2 <== ((-8.3)-8.1/(-0.3)*(8.4*y+(-y)*(-x)/(-7.1)/3.4*x-(-1.2)+y)+4.6)
        print.cccc (I 315) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 316
        !"test316"
        z1 <== p
        z2 <== x
        print.cccc (I 316) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 317
        !"test317"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 317) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 318
        !"test318"
        z1 <== q
        z2 <== y
        print.cccc (I 318) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 319
        !"test319"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 319) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 320
        !"test320"
        z1 <== (8.3+(-6.0)+(-p)/(-q)*(q))
        z2 <== (8.3+(-6.0)+(-x)/(-y)*(y))
        print.cccc (I 320) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 321
        !"test321"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 321) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 322
        !"test322"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 322) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 323
        !"test323"
        z1 <== ((((-q)-(-p))*3.7-1.0)+7.8+((-4.7)))
        z2 <== ((((-y)-(-x))*3.7-1.0)+7.8+((-4.7)))
        print.cccc (I 323) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 324
        !"test324"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 324) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 325
        !"test325"
        z1 <== ((5.0+(-q)-(-q)-(-q))+((-q)-q*p)-(-q)/(-6.1))
        z2 <== ((5.0+(-y)-(-y)-(-y))+((-y)-y*x)-(-y)/(-6.1))
        print.cccc (I 325) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 326
        !"test326"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 326) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 327
        !"test327"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 327) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 328
        !"test328"
        z1 <== (((-p)*6.5*q-((-p)/0.3*(-2.4)-6.7+q)-((-p)*(-p)+1.6))*3.2*((-q)/(7.3)+((-2.0)+q-(-q)-(-6.7)))+((4.6+q/q)/1.3-((-p)-(-p)-7.3+8.1+p)))
        z2 <== (((-x)*6.5*y-((-x)/0.3*(-2.4)-6.7+y)-((-x)*(-x)+1.6))*3.2*((-y)/(7.3)+((-2.0)+y-(-y)-(-6.7)))+((4.6+y/y)/1.3-((-x)-(-x)-7.3+8.1+x)))
        print.cccc (I 328) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 329
        !"test329"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 329) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 330
        !"test330"
        z1 <== ((-8.0)*(-0.7)*(-5.1)*((-p))*(-2.4)+(-q)*8.4*(-p)+(-q)*(-q)-4.4)
        z2 <== ((-8.0)*(-0.7)*(-5.1)*((-x))*(-2.4)+(-y)*8.4*(-x)+(-y)*(-y)-4.4)
        print.cccc (I 330) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 331
        !"test331"
        z1 <== p
        z2 <== x
        print.cccc (I 331) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 332
        !"test332"
        z1 <== (((p-(-1.6))-(7.3)/(2.8/3.7/(-p)-(-p)))/((-p)/p*q+(-q))+(((-4.4)*5.2)+((-q)*(-2.0))*6.1-(-p)*2.3+(-q))-p*(-q))
        z2 <== (((x-(-1.6))-(7.3)/(2.8/3.7/(-x)-(-x)))/((-x)/x*y+(-y))+(((-4.4)*5.2)+((-y)*(-2.0))*6.1-(-x)*2.3+(-y))-x*(-y))
        print.cccc (I 332) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 333
        !"test333"
        z1 <== ((-4.0))
        z2 <== ((-4.0))
        print.cccc (I 333) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 334
        !"test334"
        z1 <== (p/q/5.0-((-3.8)*(p)))
        z2 <== (x/y/5.0-((-3.8)*(x)))
        print.cccc (I 334) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 335
        !"test335"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 335) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 336
        !"test336"
        z1 <== (3.3)
        z2 <== (3.3)
        print.cccc (I 336) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 337
        !"test337"
        z1 <== ((q+(-1.1)+p)*8.2-((-q)*p)/((-p)*(-0.5)*2.7)-(-0.0)+(p/(-3.2))+(-p)+(-q)-(7.3))
        z2 <== ((y+(-1.1)+x)*8.2-((-y)*x)/((-x)*(-0.5)*2.7)-(-0.0)+(x/(-3.2))+(-x)+(-y)-(7.3))
        print.cccc (I 337) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 338
        !"test338"
        z1 <== p
        z2 <== x
        print.cccc (I 338) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 339
        !"test339"
        z1 <== (((-8.7)/(-2.4)/(-p))-(((-2.1)*4.3-(-q))*((-7.4)/(-3.3))))
        z2 <== (((-8.7)/(-2.4)/(-x))-(((-2.1)*4.3-(-y))*((-7.4)/(-3.3))))
        print.cccc (I 339) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 340
        !"test340"
        z1 <== ((-p)-(-p))
        z2 <== ((-x)-(-x))
        print.cccc (I 340) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 341
        !"test341"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 341) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 342
        !"test342"
        z1 <== ((q*((-p)-4.8-1.3/q)*((-6.8)+6.8))*p+(-6.6)/((-0.4)-0.5-1.2-((-p)-(-q)*4.5))-(-5.6))
        z2 <== ((y*((-x)-4.8-1.3/y)*((-6.8)+6.8))*x+(-6.6)/((-0.4)-0.5-1.2-((-x)-(-y)*4.5))-(-5.6))
        print.cccc (I 342) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 343
        !"test343"
        z1 <== (((p*7.6-p)+(1.2)))
        z2 <== (((x*7.6-x)+(1.2)))
        print.cccc (I 343) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 344
        !"test344"
        z1 <== ((-q)-(-2.4)+((7.3+q)*(0.6*(-p)-p)))
        z2 <== ((-y)-(-2.4)+((7.3+y)*(0.6*(-x)-x)))
        print.cccc (I 344) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 345
        !"test345"
        z1 <== ((-3.2)+p-q-((q)-(-q)-p))
        z2 <== ((-3.2)+x-y-((y)-(-y)-x))
        print.cccc (I 345) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 346
        !"test346"
        z1 <== (2.0)
        z2 <== (2.0)
        print.cccc (I 346) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 347
        !"test347"
        z1 <== (-2.0)
        z2 <== (-2.0)
        print.cccc (I 347) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 348
        !"test348"
        z1 <== ((((-5.1)+q-p-0.5))*(-p)/5.2)
        z2 <== ((((-5.1)+y-x-0.5))*(-x)/5.2)
        print.cccc (I 348) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 349
        !"test349"
        z1 <== q
        z2 <== y
        print.cccc (I 349) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 350
        !"test350"
        z1 <== ((((-2.8)*5.3)-(q*(-1.2)+8.1*q)))
        z2 <== ((((-2.8)*5.3)-(y*(-1.2)+8.1*y)))
        print.cccc (I 350) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 351
        !"test351"
        z1 <== q+7.0
        z2 <== y+7.0
        print.cccc (I 351) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 352
        !"test352"
        z1 <== q
        z2 <== y
        print.cccc (I 352) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 353
        !"test353"
        z1 <== p
        z2 <== x
        print.cccc (I 353) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 354
        !"test354"
        z1 <== ((-0.2)+3.8/q)
        z2 <== ((-0.2)+3.8/y)
        print.cccc (I 354) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 355
        !"test355"
        z1 <== p
        z2 <== x
        print.cccc (I 355) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 356
        !"test356"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 356) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 357
        !"test357"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 357) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 358
        !"test358"
        z1 <== (p-6.1+q)
        z2 <== (x-6.1+y)
        print.cccc (I 358) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 359
        !"test359"
        z1 <== p+(q)-8.7
        z2 <== x+(y)-8.7
        print.cccc (I 359) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 360
        !"test360"
        z1 <== q
        z2 <== y
        print.cccc (I 360) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 361
        !"test361"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 361) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 362
        !"test362"
        z1 <== ((((-6.7)))/((-p)+p/8.5/4.2*(-8.2))-p/3.6+(-4.6)*(-p)-(-q)*(-p)/(-p)+(((-6.1)*1.3/q/1.0*4.7))-(-q)+q)
        z2 <== ((((-6.7)))/((-x)+x/8.5/4.2*(-8.2))-x/3.6+(-4.6)*(-x)-(-y)*(-x)/(-x)+(((-6.1)*1.3/y/1.0*4.7))-(-y)+y)
        print.cccc (I 362) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 363
        !"test363"
        z1 <== ((-1.3)/1.2*8.3+(((-4.6)+p+6.7+(-0.7))+q))
        z2 <== ((-1.3)/1.2*8.3+(((-4.6)+x+6.7+(-0.7))+y))
        print.cccc (I 363) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 364
        !"test364"
        z1 <== ((((-q))/3.4-p*((-p)+p-(-4.3)*(-5.8)*(-6.8))+(-3.5)*(-q)+(-1.8)*(-p))-q/q/((7.6+(-q))-q*p*(-q))-((-p)*(-4.8)*q-(-p)))
        z2 <== ((((-y))/3.4-x*((-x)+x-(-4.3)*(-5.8)*(-6.8))+(-3.5)*(-y)+(-1.8)*(-x))-y/y/((7.6+(-y))-y*x*(-y))-((-x)*(-4.8)*y-(-x)))
        print.cccc (I 364) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 365
        !"test365"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 365) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 366
        !"test366"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 366) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 367
        !"test367"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 367) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 368
        !"test368"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 368) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 369
        !"test369"
        z1 <== (((7.2)*(q))-p+(-4.7)/(-0.3))
        z2 <== (((7.2)*(y))-x+(-4.7)/(-0.3))
        print.cccc (I 369) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 370
        !"test370"
        z1 <== ((-2.4)*(-q))
        z2 <== ((-2.4)*(-y))
        print.cccc (I 370) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 371
        !"test371"
        z1 <== ((7.4))
        z2 <== ((7.4))
        print.cccc (I 371) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 372
        !"test372"
        z1 <== (q+(3.6-(q-p/2.7-q+(-q))+3.5-(-q)*q-(-q)*(p-3.2-(-p)/3.0*q)/((-p)-(-p)/(-p)*1.6*0.3)))
        z2 <== (y+(3.6-(y-x/2.7-y+(-y))+3.5-(-y)*y-(-y)*(x-3.2-(-x)/3.0*y)/((-x)-(-x)/(-x)*1.6*0.3)))
        print.cccc (I 372) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 373
        !"test373"
        z1 <== (3.8/(-p)/(-p)+8.2-((-q)/p/(-q))/(2.5+5.4)-(q))+q*3.2
        z2 <== (3.8/(-x)/(-x)+8.2-((-y)/x/(-y))/(2.5+5.4)-(y))+y*3.2
        print.cccc (I 373) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 374
        !"test374"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 374) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 375
        !"test375"
        z1 <== ((0.3+2.2*q*(p))+6.4)
        z2 <== ((0.3+2.2*y*(x))+6.4)
        print.cccc (I 375) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 376
        !"test376"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 376) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 377
        !"test377"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 377) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 378
        !"test378"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 378) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 379
        !"test379"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 379) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 380
        !"test380"
        z1 <== p
        z2 <== x
        print.cccc (I 380) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 381
        !"test381"
        z1 <== q
        z2 <== y
        print.cccc (I 381) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 382
        !"test382"
        z1 <== (3.1*3.6)
        z2 <== (3.1*3.6)
        print.cccc (I 382) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 383
        !"test383"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 383) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 384
        !"test384"
        z1 <== ((-8.0)/(((-p)*(-p)+(-3.5)-(-p))-((-5.0)))/0.7+(-q))
        z2 <== ((-8.0)/(((-x)*(-x)+(-3.5)-(-x))-((-5.0)))/0.7+(-y))
        print.cccc (I 384) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 385
        !"test385"
        z1 <== q
        z2 <== y
        print.cccc (I 385) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 386
        !"test386"
        z1 <== (((-p)-q))
        z2 <== (((-x)-y))
        print.cccc (I 386) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 387
        !"test387"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 387) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 388
        !"test388"
        z1 <== ((-0.1)/(-p)+(6.6/(-q)+(-6.4)*q-(5.0+(-4.8)+(-5.5)*(-q))*0.4-q)/0.4-q)
        z2 <== ((-0.1)/(-x)+(6.6/(-y)+(-6.4)*y-(5.0+(-4.8)+(-5.5)*(-y))*0.4-y)/0.4-y)
        print.cccc (I 388) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 389
        !"test389"
        z1 <== (5.8/((-2.1))+p)
        z2 <== (5.8/((-2.1))+x)
        print.cccc (I 389) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 390
        !"test390"
        z1 <== ((((-q)/(-q)+(-p)+(-p)/(-q))/(-4.6)+q-(-4.3)*2.3*7.6)*4.5+6.0)
        z2 <== ((((-y)/(-y)+(-x)+(-x)/(-y))/(-4.6)+y-(-4.3)*2.3*7.6)*4.5+6.0)
        print.cccc (I 390) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 391
        !"test391"
        z1 <== (q-((-4.7)*(-7.3)+2.5-((-p)+(-7.4)/q/(-0.5)-(-2.7))))
        z2 <== (y-((-4.7)*(-7.3)+2.5-((-x)+(-7.4)/y/(-0.5)-(-2.7))))
        print.cccc (I 391) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 392
        !"test392"
        z1 <== (((-p)*7.1)-((-0.0)*5.4)+(2.2+8.6*p)/(-q)/(5.3*q/6.1*2.0-(-p)/((-4.5))-(q+(-q)+p+(-p)))-(-p))
        z2 <== (((-x)*7.1)-((-0.0)*5.4)+(2.2+8.6*x)/(-y)/(5.3*y/6.1*2.0-(-x)/((-4.5))-(y+(-y)+x+(-x)))-(-x))
        print.cccc (I 392) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 393
        !"test393"
        z1 <== ((-6.4))
        z2 <== ((-6.4))
        print.cccc (I 393) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 394
        !"test394"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 394) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 395
        !"test395"
        z1 <== (((6.6+p*7.5)*(q/(-1.2))*(-0.8))*((p/(-7.7)/0.5/(-3.3)-8.4)-2.8*(-p)/(-p)*((-0.2)/q+1.7*(-2.1)+q))*(q)/(-p))
        z2 <== (((6.6+x*7.5)*(y/(-1.2))*(-0.8))*((x/(-7.7)/0.5/(-3.3)-8.4)-2.8*(-x)/(-x)*((-0.2)/y+1.7*(-2.1)+y))*(y)/(-x))
        print.cccc (I 395) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 396
        !"test396"
        z1 <== ((((-q)))+(((-p)+p*(-p))*(2.7)*(q+p+2.7+p-1.5)/(-q))/((-5.8))/(-5.0))
        z2 <== ((((-y)))+(((-x)+x*(-x))*(2.7)*(y+x+2.7+x-1.5)/(-y))/((-5.8))/(-5.0))
        print.cccc (I 396) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 397
        !"test397"
        z1 <== p
        z2 <== x
        print.cccc (I 397) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 398
        !"test398"
        z1 <== ((((-q)))/q-8.8/0.1+5.7/(4.8-q+((-p)+3.0*(-6.5)/(-0.2)))+(((-p)-p+(-8.4)/1.3*p)/5.5/(q*6.5-(-q)*0.4-(-q))*5.6-((-p)*(-2.8)+(-4.7)+0.1+2.1))/(((-5.5)-(-5.7)-(-0.1)*(-1.5)-6.3)))
        z2 <== ((((-y)))/y-8.8/0.1+5.7/(4.8-y+((-x)+3.0*(-6.5)/(-0.2)))+(((-x)-x+(-8.4)/1.3*x)/5.5/(y*6.5-(-y)*0.4-(-y))*5.6-((-x)*(-2.8)+(-4.7)+0.1+2.1))/(((-5.5)-(-5.7)-(-0.1)*(-1.5)-6.3)))
        print.cccc (I 398) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 399
        !"test399"
        z1 <== ((p)+(5.0)*((8.1/(-p))+0.4/5.1+p-p/q/7.2/((-p)*(-p)))+(-q))
        z2 <== ((x)+(5.0)*((8.1/(-x))+0.4/5.1+x-x/y/7.2/((-x)*(-x)))+(-y))
        print.cccc (I 399) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 400
        !"test400"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 400) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 401
        !"test401"
        z1 <== 3.3
        z2 <== 3.3
        print.cccc (I 401) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 402
        !"test402"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 402) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 403
        !"test403"
        z1 <== ((-p)*6.7)
        z2 <== ((-x)*6.7)
        print.cccc (I 403) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 404
        !"test404"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 404) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 405
        !"test405"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 405) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 406
        !"test406"
        z1 <== q
        z2 <== y
        print.cccc (I 406) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 407
        !"test407"
        z1 <== (-4.0)
        z2 <== (-4.0)
        print.cccc (I 407) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 408
        !"test408"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 408) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 409
        !"test409"
        z1 <== (0.0*(2.1/p))
        z2 <== (0.0*(2.1/x))
        print.cccc (I 409) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 410
        !"test410"
        z1 <== ((-4.8)+(p)/(1.1/(-p)-q*3.4+q)-8.4*(-p))-3.6
        z2 <== ((-4.8)+(x)/(1.1/(-x)-y*3.4+y)-8.4*(-x))-3.6
        print.cccc (I 410) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 411
        !"test411"
        z1 <== (((-q)*q/q)*((q-(-3.5)/(-q)/(-0.2)-(-q)))+(-p)/(-q))
        z2 <== (((-y)*y/y)*((y-(-3.5)/(-y)/(-0.2)-(-y)))+(-x)/(-y))
        print.cccc (I 411) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 412
        !"test412"
        z1 <== (-p)-4.7*(-p)
        z2 <== (-x)-4.7*(-x)
        print.cccc (I 412) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 413
        !"test413"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 413) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 414
        !"test414"
        z1 <== (q/(-2.7))
        z2 <== (y/(-2.7))
        print.cccc (I 414) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 415
        !"test415"
        z1 <== (((-q))+0.1+(p*(-6.7)*p*(-4.8)))
        z2 <== (((-y))+0.1+(x*(-6.7)*x*(-4.8)))
        print.cccc (I 415) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 416
        !"test416"
        z1 <== ((((-8.6)*q)+4.2-p))
        z2 <== ((((-8.6)*y)+4.2-x))
        print.cccc (I 416) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 417
        !"test417"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 417) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 418
        !"test418"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 418) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 419
        !"test419"
        z1 <== ((2.0*2.3-((-q))-(-p)*(-3.7))-q-(6.5*(-p)+(-8.5)-(-7.7)+(-0.7)*p))
        z2 <== ((2.0*2.3-((-y))-(-x)*(-3.7))-y-(6.5*(-x)+(-8.5)-(-7.7)+(-0.7)*x))
        print.cccc (I 419) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 420
        !"test420"
        z1 <== q
        z2 <== y
        print.cccc (I 420) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 421
        !"test421"
        z1 <== p
        z2 <== x
        print.cccc (I 421) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 422
        !"test422"
        z1 <== (((q+p*2.0/(-q)-(-p))/(-7.5)/3.8+(-1.4)-(-1.8)/(-0.4))/(((-p)/1.0/q-(-q)+q)+q)/p)
        z2 <== (((y+x*2.0/(-y)-(-x))/(-7.5)/3.8+(-1.4)-(-1.8)/(-0.4))/(((-x)/1.0/y-(-y)+y)+y)/x)
        print.cccc (I 422) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 423
        !"test423"
        z1 <== ((-q)-(-0.2))-((-7.7)/(-7.6)/4.6+(-p)*7.5)/q/(1.8)+p
        z2 <== ((-y)-(-0.2))-((-7.7)/(-7.6)/4.6+(-x)*7.5)/y/(1.8)+x
        print.cccc (I 423) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 424
        !"test424"
        z1 <== (((-5.6))/(5.2/5.1)*(7.5-(-8.3)))
        z2 <== (((-5.6))/(5.2/5.1)*(7.5-(-8.3)))
        print.cccc (I 424) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 425
        !"test425"
        z1 <== p
        z2 <== x
        print.cccc (I 425) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 426
        !"test426"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 426) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 427
        !"test427"
        z1 <== p
        z2 <== x
        print.cccc (I 427) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 428
        !"test428"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 428) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 429
        !"test429"
        z1 <== q
        z2 <== y
        print.cccc (I 429) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 430
        !"test430"
        z1 <== (((6.1/(-5.4))*((-4.5)))-(((-7.3)*0.4-(-4.6)/(-1.5)*(-q))))
        z2 <== (((6.1/(-5.4))*((-4.5)))-(((-7.3)*0.4-(-4.6)/(-1.5)*(-y))))
        print.cccc (I 430) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 431
        !"test431"
        z1 <== 3.3
        z2 <== 3.3
        print.cccc (I 431) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 432
        !"test432"
        z1 <== p
        z2 <== x
        print.cccc (I 432) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 433
        !"test433"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 433) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 434
        !"test434"
        z1 <== (p*(-7.1))
        z2 <== (x*(-7.1))
        print.cccc (I 434) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 435
        !"test435"
        z1 <== ((-4.2)-(-6.1)-q*(-5.0)-((-1.3)/p))
        z2 <== ((-4.2)-(-6.1)-y*(-5.0)-((-1.3)/x))
        print.cccc (I 435) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 436
        !"test436"
        z1 <== ((-3.1)/1.2*((5.5)/2.6)+(-p))
        z2 <== ((-3.1)/1.2*((5.5)/2.6)+(-x))
        print.cccc (I 436) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 437
        !"test437"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 437) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 438
        !"test438"
        z1 <== 4.3/(((-8.5)+(-p)/(-4.1)/(-5.3)+2.3)-((-7.0)+(-5.1)-0.5)-(-q))-((3.0)*((-2.5)))-((-8.1))/((-q)-(-p)*(q+q))
        z2 <== 4.3/(((-8.5)+(-x)/(-4.1)/(-5.3)+2.3)-((-7.0)+(-5.1)-0.5)-(-y))-((3.0)*((-2.5)))-((-8.1))/((-y)-(-x)*(y+y))
        print.cccc (I 438) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 439
        !"test439"
        z1 <== (((p+(-0.6))-(-0.8)/((-2.1)+p*(-1.7))+(-q))-8.4-8.4)
        z2 <== (((x+(-0.6))-(-0.8)/((-2.1)+x*(-1.7))+(-y))-8.4-8.4)
        print.cccc (I 439) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 440
        !"test440"
        z1 <== ((-3.4)-(-1.5)/(-q)*(-6.7)+q)
        z2 <== ((-3.4)-(-1.5)/(-y)*(-6.7)+y)
        print.cccc (I 440) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 441
        !"test441"
        z1 <== (8.0/(-8.3)+(-1.3)-7.7)/(3.0/(-7.1)-(-q)*p)*(p/(-4.4))*(-p)*((-q)-(-p)/(p+(-8.4)+4.3)*(-p))/((0.7)/p/((-2.5)+p*(-p))/(-q)-(4.5-(-7.4)))-((-6.7)-(-2.7)/q)-(-p)-p/6.1/p
        z2 <== (8.0/(-8.3)+(-1.3)-7.7)/(3.0/(-7.1)-(-y)*x)*(x/(-4.4))*(-x)*((-y)-(-x)/(x+(-8.4)+4.3)*(-x))/((0.7)/x/((-2.5)+x*(-x))/(-y)-(4.5-(-7.4)))-((-6.7)-(-2.7)/y)-(-x)-x/6.1/x
        print.cccc (I 441) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 442
        !"test442"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 442) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 443
        !"test443"
        z1 <== q
        z2 <== y
        print.cccc (I 443) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 444
        !"test444"
        z1 <== ((-q)*4.1-(3.6)-((-q)*(-q)/(-q)+(-4.7)+(p-q)/((-8.3)))/(-7.0)/p/(-q))
        z2 <== ((-y)*4.1-(3.6)-((-y)*(-y)/(-y)+(-4.7)+(x-y)/((-8.3)))/(-7.0)/x/(-y))
        print.cccc (I 444) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 445
        !"test445"
        z1 <== ((p/(-4.4)-(-p)*(-3.6)*(-6.0))+q+((-1.3)*(-3.1)-(-q)+p*1.0)*q-0.5+p)
        z2 <== ((x/(-4.4)-(-x)*(-3.6)*(-6.0))+y+((-1.3)*(-3.1)-(-y)+x*1.0)*y-0.5+x)
        print.cccc (I 445) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 446
        !"test446"
        z1 <== (((-4.1)*((-q)-(-0.1)/(-p)/(-p))+(-5.8)/((-7.6)+(-p)+q-q)))
        z2 <== (((-4.1)*((-y)-(-0.1)/(-x)/(-x))+(-5.8)/((-7.6)+(-x)+y-y)))
        print.cccc (I 446) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 447
        !"test447"
        z1 <== p
        z2 <== x
        print.cccc (I 447) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 448
        !"test448"
        z1 <== ((-q)-(8.0+(-8.8)*(-q)/(-3.5))/q-(-q))-1.2/(-q)+(-p)+(6.0-(-6.8)/(-1.3))/((-q)-q+6.0+6.1/(-p))+(-p)/(-8.8)
        z2 <== ((-y)-(8.0+(-8.8)*(-y)/(-3.5))/y-(-y))-1.2/(-y)+(-x)+(6.0-(-6.8)/(-1.3))/((-y)-y+6.0+6.1/(-x))+(-x)/(-8.8)
        print.cccc (I 448) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 449
        !"test449"
        z1 <== (((-0.6))*(3.2)-(-1.4)/5.4-(2.1-(-p)-(-q)+(-q)-p))*4.6+(-q)
        z2 <== (((-0.6))*(3.2)-(-1.4)/5.4-(2.1-(-x)-(-y)+(-y)-x))*4.6+(-y)
        print.cccc (I 449) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 450
        !"test450"
        z1 <== ((1.0)*(((-p)/4.3)-3.3+7.5))
        z2 <== ((1.0)*(((-x)/4.3)-3.3+7.5))
        print.cccc (I 450) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 451
        !"test451"
        z1 <== (-4.8)+(-q)-(q*8.5+(q-p)-(-8.4)+((-p)+(-q)))+(((-p)/(-2.8)/(-8.2)/p))
        z2 <== (-4.8)+(-y)-(y*8.5+(y-x)-(-8.4)+((-x)+(-y)))+(((-x)/(-2.8)/(-8.2)/x))
        print.cccc (I 451) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 452
        !"test452"
        z1 <== (((-q)*q-3.0)-(p+0.1/0.0-(-5.8))-((-q)*(-q)-q+q/q)-2.0+q+q/(p-2.6-p+6.7)/((q-p*8.4/p)/5.4/q/0.3-2.7))
        z2 <== (((-y)*y-3.0)-(x+0.1/0.0-(-5.8))-((-y)*(-y)-y+y/y)-2.0+y+y/(x-2.6-x+6.7)/((y-x*8.4/x)/5.4/y/0.3-2.7))
        print.cccc (I 452) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 453
        !"test453"
        z1 <== (((-p)*(-5.4)-q+(-2.1))*7.6)
        z2 <== (((-x)*(-5.4)-y+(-2.1))*7.6)
        print.cccc (I 453) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 454
        !"test454"
        z1 <== (-2.3)
        z2 <== (-2.3)
        print.cccc (I 454) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 455
        !"test455"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 455) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 456
        !"test456"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 456) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 457
        !"test457"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 457) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 458
        !"test458"
        z1 <== (-6.7)
        z2 <== (-6.7)
        print.cccc (I 458) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 459
        !"test459"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 459) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 460
        !"test460"
        z1 <== q
        z2 <== y
        print.cccc (I 460) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 461
        !"test461"
        z1 <== (1.0)
        z2 <== (1.0)
        print.cccc (I 461) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 462
        !"test462"
        z1 <== ((-q)+(-p)/p+((-q)*(2.2-(-6.7))*(-q)/(-p))*(q-((-4.4)/1.4)/(p/(-1.2))-(-p)*(4.6*p-(-q)-5.6)))
        z2 <== ((-y)+(-x)/x+((-y)*(2.2-(-6.7))*(-y)/(-x))*(y-((-4.4)/1.4)/(x/(-1.2))-(-x)*(4.6*x-(-y)-5.6)))
        print.cccc (I 462) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 463
        !"test463"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 463) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 464
        !"test464"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 464) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 465
        !"test465"
        z1 <== ((-3.2)/(-3.8)*(-7.8)+(q-(-q))+6.7/((p/(-4.6)+4.5))+(((-2.7))))
        z2 <== ((-3.2)/(-3.8)*(-7.8)+(y-(-y))+6.7/((x/(-4.6)+4.5))+(((-2.7))))
        print.cccc (I 465) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 466
        !"test466"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 466) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 467
        !"test467"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 467) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 468
        !"test468"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 468) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 469
        !"test469"
        z1 <== 2.6
        z2 <== 2.6
        print.cccc (I 469) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 470
        !"test470"
        z1 <== p
        z2 <== x
        print.cccc (I 470) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 471
        !"test471"
        z1 <== (p*((-p))+(-1.2)*(p*(-3.8)*(-1.4)*(-4.4)/p*q*(-p))/5.8)
        z2 <== (x*((-x))+(-1.2)*(x*(-3.8)*(-1.4)*(-4.4)/x*y*(-x))/5.8)
        print.cccc (I 471) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 472
        !"test472"
        z1 <== ((-q)+1.0/(-p)*(-8.4)+((-4.4)*(1.7+4.8/8.6+(-p))/((-q)+(-8.5)*0.6*(-q)/p)/8.7-1.8))
        z2 <== ((-y)+1.0/(-x)*(-8.4)+((-4.4)*(1.7+4.8/8.6+(-x))/((-y)+(-8.5)*0.6*(-y)/x)/8.7-1.8))
        print.cccc (I 472) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 473
        !"test473"
        z1 <== ((p+2.5*6.5-(-q)-(-p))*(0.2)*(-p)*p)/((-q))-1.4-(-2.0)
        z2 <== ((x+2.5*6.5-(-y)-(-x))*(0.2)*(-x)*x)/((-y))-1.4-(-2.0)
        print.cccc (I 473) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 474
        !"test474"
        z1 <== (4.2)
        z2 <== (4.2)
        print.cccc (I 474) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 475
        !"test475"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 475) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 476
        !"test476"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 476) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 477
        !"test477"
        z1 <== q
        z2 <== y
        print.cccc (I 477) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 478
        !"test478"
        z1 <== ((p))
        z2 <== ((x))
        print.cccc (I 478) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 479
        !"test479"
        z1 <== p
        z2 <== x
        print.cccc (I 479) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 480
        !"test480"
        z1 <== 8.3*(5.6-(-8.5)/((-6.3))-q)/(p/2.5*q+((-q)+(-0.3)*5.6+(-p))*(p/(-1.2)*p))
        z2 <== 8.3*(5.6-(-8.5)/((-6.3))-y)/(x/2.5*y+((-y)+(-0.3)*5.6+(-x))*(x/(-1.2)*x))
        print.cccc (I 480) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 481
        !"test481"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 481) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 482
        !"test482"
        z1 <== ((((-p)+p/q*8.6/(-q))/(-1.6)*q)*(q*q+3.7-((-p)))*8.7/((-q)*(-p))*(-2.1))
        z2 <== ((((-x)+x/y*8.6/(-y))/(-1.6)*y)*(y*y+3.7-((-x)))*8.7/((-y)*(-x))*(-2.1))
        print.cccc (I 482) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 483
        !"test483"
        z1 <== (((4.2/q/(-5.0))*(-p)*p-p/(-7.7)*7.4)/2.3/q+q)
        z2 <== (((4.2/y/(-5.0))*(-x)*x-x/(-7.7)*7.4)/2.3/y+y)
        print.cccc (I 483) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 484
        !"test484"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 484) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 485
        !"test485"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 485) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 486
        !"test486"
        z1 <== ((-3.8))
        z2 <== ((-3.8))
        print.cccc (I 486) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 487
        !"test487"
        z1 <== ((q/4.4-(-p))+(7.5*(-q)))
        z2 <== ((y/4.4-(-x))+(7.5*(-y)))
        print.cccc (I 487) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 488
        !"test488"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 488) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 489
        !"test489"
        z1 <== p
        z2 <== x
        print.cccc (I 489) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 490
        !"test490"
        z1 <== (((0.1)+(-0.0)/(-3.8))*(-4.1)+(q)/((-q)/(-q))-(3.5/(-8.1)))
        z2 <== (((0.1)+(-0.0)/(-3.8))*(-4.1)+(y)/((-y)/(-y))-(3.5/(-8.1)))
        print.cccc (I 490) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 491
        !"test491"
        z1 <== p
        z2 <== x
        print.cccc (I 491) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 492
        !"test492"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 492) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 493
        !"test493"
        z1 <== (q+(-q)*q/p)
        z2 <== (y+(-y)*y/x)
        print.cccc (I 493) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 494
        !"test494"
        z1 <== q
        z2 <== y
        print.cccc (I 494) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 495
        !"test495"
        z1 <== (((-q)-q*(-6.5)/(-6.0)+6.4)-(p-0.4*(-5.5)-(-1.0))/(-5.8)+(-8.2)*(-q)-q-((-p)-p+0.2-1.1))
        z2 <== (((-y)-y*(-6.5)/(-6.0)+6.4)-(x-0.4*(-5.5)-(-1.0))/(-5.8)+(-8.2)*(-y)-y-((-x)-x+0.2-1.1))
        print.cccc (I 495) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 496
        !"test496"
        z1 <== (-5.1)
        z2 <== (-5.1)
        print.cccc (I 496) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 497
        !"test497"
        z1 <== ((-0.0)+(-p))
        z2 <== ((-0.0)+(-x))
        print.cccc (I 497) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 498
        !"test498"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 498) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 499
        !"test499"
        z1 <== (q*7.6/(4.8/(-8.5)))/(-q)
        z2 <== (y*7.6/(4.8/(-8.5)))/(-y)
        print.cccc (I 499) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 500
        !"test500"
        z1 <== p
        z2 <== x
        print.cccc (I 500) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 501
        !"test501"
        z1 <== (-3.4)
        z2 <== (-3.4)
        print.cccc (I 501) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 502
        !"test502"
        z1 <== q
        z2 <== y
        print.cccc (I 502) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 503
        !"test503"
        z1 <== ((-1.8))
        z2 <== ((-1.8))
        print.cccc (I 503) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 504
        !"test504"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 504) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 505
        !"test505"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 505) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 506
        !"test506"
        z1 <== ((-6.7)+(q*q)+(p*(-q)+(-8.4))/(-7.0)+7.2+5.0-8.2)
        z2 <== ((-6.7)+(y*y)+(x*(-y)+(-8.4))/(-7.0)+7.2+5.0-8.2)
        print.cccc (I 506) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 507
        !"test507"
        z1 <== ((-q)+((-6.0))-4.3-((-5.0)*p)*(1.4+(-p)/(-5.4)/(-6.3))*(-3.0))
        z2 <== ((-y)+((-6.0))-4.3-((-5.0)*x)*(1.4+(-x)/(-5.4)/(-6.3))*(-3.0))
        print.cccc (I 507) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 508
        !"test508"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 508) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 509
        !"test509"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 509) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 510
        !"test510"
        z1 <== 2.0-(-p)
        z2 <== 2.0-(-x)
        print.cccc (I 510) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 511
        !"test511"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 511) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 512
        !"test512"
        z1 <== ((-q)-((-p))-(q)+(-3.7)+((-7.5))*((6.4+q)/q/((-p)*(-2.6)*q+(-p)*2.0)+(2.8))/(-q))
        z2 <== ((-y)-((-x))-(y)+(-3.7)+((-7.5))*((6.4+y)/y/((-x)*(-2.6)*y+(-x)*2.0)+(2.8))/(-y))
        print.cccc (I 512) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 513
        !"test513"
        z1 <== p
        z2 <== x
        print.cccc (I 513) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 514
        !"test514"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 514) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 515
        !"test515"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 515) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 516
        !"test516"
        z1 <== (q*7.0+((-6.1)+3.3*(-q))*((-p)-q*q*(-7.5)-4.6*(-q)-(-6.0)+(-7.8)))
        z2 <== (y*7.0+((-6.1)+3.3*(-y))*((-x)-y*y*(-7.5)-4.6*(-y)-(-6.0)+(-7.8)))
        print.cccc (I 516) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 517
        !"test517"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 517) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 518
        !"test518"
        z1 <== (0.0+(((-p)))*(((-2.7)-(-0.0)/7.5/2.2-2.7)+((-2.1)-(-p)-(-4.5)-p)/p)/5.6)
        z2 <== (0.0+(((-x)))*(((-2.7)-(-0.0)/7.5/2.2-2.7)+((-2.1)-(-x)-(-4.5)-x)/x)/5.6)
        print.cccc (I 518) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 519
        !"test519"
        z1 <== q
        z2 <== y
        print.cccc (I 519) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 520
        !"test520"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 520) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 521
        !"test521"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 521) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 522
        !"test522"
        z1 <== (((-6.0))-(-p)+(-8.3)-4.8*2.4-(-q)/4.3/(-p)*4.2-((-q)-(-q)*0.6)-p*8.7)
        z2 <== (((-6.0))-(-x)+(-8.3)-4.8*2.4-(-y)/4.3/(-x)*4.2-((-y)-(-y)*0.6)-x*8.7)
        print.cccc (I 522) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 523
        !"test523"
        z1 <== (0.0/q/((0.1-(-p)+p-q)+(-7.0)/6.5+(-5.3))+p-((-1.6)-(-1.7)*0.3*2.2-(-p)-(-3.8)+(-1.1)-((-2.1)*(-4.4)-(-3.7))))
        z2 <== (0.0/y/((0.1-(-x)+x-y)+(-7.0)/6.5+(-5.3))+x-((-1.6)-(-1.7)*0.3*2.2-(-x)-(-3.8)+(-1.1)-((-2.1)*(-4.4)-(-3.7))))
        print.cccc (I 523) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 524
        !"test524"
        z1 <== (((-7.8)/(-3.8)-6.6+(-5.6)-(-p)+p+3.3-q*((-6.6)+2.1-0.3/(-3.7)+p))+((-q)+(-q)*(1.8+q-(-0.7)+(-8.2)))*p+(-p)/(-0.4))
        z2 <== (((-7.8)/(-3.8)-6.6+(-5.6)-(-x)+x+3.3-y*((-6.6)+2.1-0.3/(-3.7)+x))+((-y)+(-y)*(1.8+y-(-0.7)+(-8.2)))*x+(-x)/(-0.4))
        print.cccc (I 524) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 525
        !"test525"
        z1 <== (-0.1)
        z2 <== (-0.1)
        print.cccc (I 525) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 526
        !"test526"
        z1 <== (((-1.1)+((-3.5))*8.6-(2.1-(-q)+(-q)-(-8.0)*(-7.7))-p)/((q/2.5/1.6-(-p))/(-q)))
        z2 <== (((-1.1)+((-3.5))*8.6-(2.1-(-y)+(-y)-(-8.0)*(-7.7))-x)/((y/2.5/1.6-(-x))/(-y)))
        print.cccc (I 526) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 527
        !"test527"
        z1 <== 4.1-(0.3+(-3.5)+2.5-6.4/7.4-p*(-0.7))*((-p)+(-2.0)*(7.6*(-0.2)-p-q+p)/((-p)-(-5.4)))-(-3.8)-(5.0*(q)-3.8-p*(-q))
        z2 <== 4.1-(0.3+(-3.5)+2.5-6.4/7.4-x*(-0.7))*((-x)+(-2.0)*(7.6*(-0.2)-x-y+x)/((-x)-(-5.4)))-(-3.8)-(5.0*(y)-3.8-x*(-y))
        print.cccc (I 527) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 528
        !"test528"
        z1 <== q
        z2 <== y
        print.cccc (I 528) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 529
        !"test529"
        z1 <== ((-p)/p)
        z2 <== ((-x)/x)
        print.cccc (I 529) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 530
        !"test530"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 530) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 531
        !"test531"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 531) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 532
        !"test532"
        z1 <== (2.8*6.5)
        z2 <== (2.8*6.5)
        print.cccc (I 532) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 533
        !"test533"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 533) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 534
        !"test534"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 534) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 535
        !"test535"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 535) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 536
        !"test536"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 536) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 537
        !"test537"
        z1 <== p/2.8+(-0.4)+p+(-p)
        z2 <== x/2.8+(-0.4)+x+(-x)
        print.cccc (I 537) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 538
        !"test538"
        z1 <== (1.4*1.3/(-4.6)-(((-p))*(-3.1)/((-p))/(-q)))
        z2 <== (1.4*1.3/(-4.6)-(((-x))*(-3.1)/((-x))/(-y)))
        print.cccc (I 538) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 539
        !"test539"
        z1 <== ((-p)+(6.8-(-p))*5.6/(-q)/(5.8))
        z2 <== ((-x)+(6.8-(-x))*5.6/(-y)/(5.8))
        print.cccc (I 539) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 540
        !"test540"
        z1 <== (0.0-((-q)+(3.1*p*(-q))*(p)+(6.1)/((-p)*1.8))*(-p)/8.4+(-8.5))
        z2 <== (0.0-((-y)+(3.1*x*(-y))*(x)+(6.1)/((-x)*1.8))*(-x)/8.4+(-8.5))
        print.cccc (I 540) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 541
        !"test541"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 541) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 542
        !"test542"
        z1 <== ((-0.7)-((-6.6))-(-p)+(-3.2)/(-q)+q+(-p)+(4.6+(-p)*(-8.0))-0.6)
        z2 <== ((-0.7)-((-6.6))-(-x)+(-3.2)/(-y)+y+(-x)+(4.6+(-x)*(-8.0))-0.6)
        print.cccc (I 542) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 543
        !"test543"
        z1 <== 8.1
        z2 <== 8.1
        print.cccc (I 543) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 544
        !"test544"
        z1 <== ((((-q))+7.1/p/(-8.5)*q/p)-(-p)+((-3.2))+(4.4+p-5.0-q/q)+(-p)+(-7.2))
        z2 <== ((((-y))+7.1/x/(-8.5)*y/x)-(-x)+((-3.2))+(4.4+x-5.0-y/y)+(-x)+(-7.2))
        print.cccc (I 544) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 545
        !"test545"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 545) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 546
        !"test546"
        z1 <== ((-1.8)*7.1*p/((-0.7)/((-p)/(-p)*0.8*(-p)/q)+((-p)/5.7-q+0.8*3.4)-(q-(-8.2)/(-7.0))-8.0)-((-p)-(-3.5)*(-p)))
        z2 <== ((-1.8)*7.1*x/((-0.7)/((-x)/(-x)*0.8*(-x)/y)+((-x)/5.7-y+0.8*3.4)-(y-(-8.2)/(-7.0))-8.0)-((-x)-(-3.5)*(-x)))
        print.cccc (I 546) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 547
        !"test547"
        z1 <== (-6.4)
        z2 <== (-6.4)
        print.cccc (I 547) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 548
        !"test548"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 548) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 549
        !"test549"
        z1 <== ((-4.0)/(-q)-(-q)/(q-(-p)+3.8*(-7.7))/(((-1.1)-p/(-p)-(-q))/((-p)+q)-1.8*((-8.1)*(-q)*3.7/3.6*(-p))/(-8.2))*((-4.2)*4.3)/(-p))
        z2 <== ((-4.0)/(-y)-(-y)/(y-(-x)+3.8*(-7.7))/(((-1.1)-x/(-x)-(-y))/((-x)+y)-1.8*((-8.1)*(-y)*3.7/3.6*(-x))/(-8.2))*((-4.2)*4.3)/(-x))
        print.cccc (I 549) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 550
        !"test550"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 550) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 551
        !"test551"
        z1 <== ((p)*(p/(-8.0)*(-1.4)-q*q)/(p))
        z2 <== ((x)*(x/(-8.0)*(-1.4)-y*y)/(x))
        print.cccc (I 551) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 552
        !"test552"
        z1 <== (((0.5+(-1.3)/(-p))-(q*q)-1.5/q)/((-4.4)*p)+(-p))
        z2 <== (((0.5+(-1.3)/(-x))-(y*y)-1.5/y)/((-4.4)*x)+(-x))
        print.cccc (I 552) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 553
        !"test553"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 553) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 554
        !"test554"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 554) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 555
        !"test555"
        z1 <== p-((5.2/(-4.6)*7.1)+q-(p/(-p))+(-q)/5.3)
        z2 <== x-((5.2/(-4.6)*7.1)+y-(x/(-x))+(-y)/5.3)
        print.cccc (I 555) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 556
        !"test556"
        z1 <== q
        z2 <== y
        print.cccc (I 556) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 557
        !"test557"
        z1 <== (((-q)/(2.2+7.5)*(5.5))+0.4-1.5*((-p)-(6.8/2.1-(-q)+(-0.7))))
        z2 <== (((-y)/(2.2+7.5)*(5.5))+0.4-1.5*((-x)-(6.8/2.1-(-y)+(-0.7))))
        print.cccc (I 557) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 558
        !"test558"
        z1 <== (p/(-2.1)*((-p)*(-p)*((-2.5)/p))/(-0.2))
        z2 <== (x/(-2.1)*((-x)*(-x)*((-2.5)/x))/(-0.2))
        print.cccc (I 558) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 559
        !"test559"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 559) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 560
        !"test560"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 560) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 561
        !"test561"
        z1 <== (((4.7+(-1.0))/2.3*((-p)*(-7.2)+p*(-q)+(-3.8))))
        z2 <== (((4.7+(-1.0))/2.3*((-x)*(-7.2)+x*(-y)+(-3.8))))
        print.cccc (I 561) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 562
        !"test562"
        z1 <== p
        z2 <== x
        print.cccc (I 562) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 563
        !"test563"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 563) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 564
        !"test564"
        z1 <== (q/(-p))
        z2 <== (y/(-x))
        print.cccc (I 564) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 565
        !"test565"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 565) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 566
        !"test566"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 566) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 567
        !"test567"
        z1 <== ((-1.8)/(1.7/((-3.4)+q/3.3+(-3.6)))/(-2.0)/(-q)-q)
        z2 <== ((-1.8)/(1.7/((-3.4)+y/3.3+(-3.6)))/(-2.0)/(-y)-y)
        print.cccc (I 567) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 568
        !"test568"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 568) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 569
        !"test569"
        z1 <== p
        z2 <== x
        print.cccc (I 569) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 570
        !"test570"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 570) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 571
        !"test571"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 571) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 572
        !"test572"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 572) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 573
        !"test573"
        z1 <== q
        z2 <== y
        print.cccc (I 573) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 574
        !"test574"
        z1 <== 1.4
        z2 <== 1.4
        print.cccc (I 574) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 575
        !"test575"
        z1 <== q
        z2 <== y
        print.cccc (I 575) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 576
        !"test576"
        z1 <== p
        z2 <== x
        print.cccc (I 576) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 577
        !"test577"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 577) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 578
        !"test578"
        z1 <== (-2.7)
        z2 <== (-2.7)
        print.cccc (I 578) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 579
        !"test579"
        z1 <== q
        z2 <== y
        print.cccc (I 579) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 580
        !"test580"
        z1 <== ((-8.2)*(-q)*(p)/(-p)-(-p))
        z2 <== ((-8.2)*(-y)*(x)/(-x)-(-x))
        print.cccc (I 580) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 581
        !"test581"
        z1 <== ((8.1/((-p))/5.5/(4.4)))
        z2 <== ((8.1/((-x))/5.5/(4.4)))
        print.cccc (I 581) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 582
        !"test582"
        z1 <== ((-p)/3.2*(-7.6)+((-7.5))*1.5-p-q*(-q)/((-q)+(-q)+8.0-(-2.7)))
        z2 <== ((-x)/3.2*(-7.6)+((-7.5))*1.5-x-y*(-y)/((-y)+(-y)+8.0-(-2.7)))
        print.cccc (I 582) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 583
        !"test583"
        z1 <== ((-1.4)*4.2)
        z2 <== ((-1.4)*4.2)
        print.cccc (I 583) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 584
        !"test584"
        z1 <== (((2.2-(-1.1)*(-2.8)))+((0.7*(-3.1)*(-q))/8.4-6.1)*(p+(-3.6)-1.3+(-3.3)*3.2)+(-p)*p-(-q)/(-3.0)*((-0.1)*(-7.7)+(-5.4)/p)-(-2.4)-(-q)+(-p)/q)
        z2 <== (((2.2-(-1.1)*(-2.8)))+((0.7*(-3.1)*(-y))/8.4-6.1)*(x+(-3.6)-1.3+(-3.3)*3.2)+(-x)*x-(-y)/(-3.0)*((-0.1)*(-7.7)+(-5.4)/x)-(-2.4)-(-y)+(-x)/y)
        print.cccc (I 584) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 585
        !"test585"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 585) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 586
        !"test586"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 586) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 587
        !"test587"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 587) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 588
        !"test588"
        z1 <== ((p/(-6.8)-0.4+7.3)/(4.7+6.0*(-q)*(-4.7)-(-6.4))+((-p)*(-q)/(-p)*(-0.3)*(-8.1)))
        z2 <== ((x/(-6.8)-0.4+7.3)/(4.7+6.0*(-y)*(-4.7)-(-6.4))+((-x)*(-y)/(-x)*(-0.3)*(-8.1)))
        print.cccc (I 588) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 589
        !"test589"
        z1 <== (-7.7)/(-4.0)*(((-p))/p/(-p)-(8.0/7.2/q)/(-p))
        z2 <== (-7.7)/(-4.0)*(((-x))/x/(-x)-(8.0/7.2/y)/(-x))
        print.cccc (I 589) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 590
        !"test590"
        z1 <== q
        z2 <== y
        print.cccc (I 590) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 591
        !"test591"
        z1 <== ((-q)/0.0*(-q))
        z2 <== ((-y)/0.0*(-y))
        print.cccc (I 591) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 592
        !"test592"
        z1 <== ((-4.0))
        z2 <== ((-4.0))
        print.cccc (I 592) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 593
        !"test593"
        z1 <== 0.4-q*q+((-q)+(-p)/(-q)+q-(-0.0))/(6.6/(-3.4)-p*(-p))/(-q)
        z2 <== 0.4-y*y+((-y)+(-x)/(-y)+y-(-0.0))/(6.6/(-3.4)-x*(-x))/(-y)
        print.cccc (I 593) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 594
        !"test594"
        z1 <== ((-4.7)*(-q))
        z2 <== ((-4.7)*(-y))
        print.cccc (I 594) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 595
        !"test595"
        z1 <== q
        z2 <== y
        print.cccc (I 595) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 596
        !"test596"
        z1 <== ((p*p/((-q)*6.7))*(-q)+5.3*(4.1/(-6.6)/q)-(-q)/p+q-(-4.2)+(-3.3)/(-7.0)+(-p)*q)
        z2 <== ((x*x/((-y)*6.7))*(-y)+5.3*(4.1/(-6.6)/y)-(-y)/x+y-(-4.2)+(-3.3)/(-7.0)+(-x)*y)
        print.cccc (I 596) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 597
        !"test597"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 597) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 598
        !"test598"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 598) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 599
        !"test599"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 599) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 600
        !"test600"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 600) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 601
        !"test601"
        z1 <== ((-q)/((-0.0)+((-5.6)-(-7.8))))
        z2 <== ((-y)/((-0.0)+((-5.6)-(-7.8))))
        print.cccc (I 601) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 602
        !"test602"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 602) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 603
        !"test603"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 603) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 604
        !"test604"
        z1 <== (p-1.2/((-2.7)-((-4.6)-0.7)/(-3.5)*(-5.6)+q-p))
        z2 <== (x-1.2/((-2.7)-((-4.6)-0.7)/(-3.5)*(-5.6)+y-x))
        print.cccc (I 604) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 605
        !"test605"
        z1 <== ((-5.8)+((-2.8)/(-p)-(-q)*(-6.2)/7.6)-p)
        z2 <== ((-5.8)+((-2.8)/(-x)-(-y)*(-6.2)/7.6)-x)
        print.cccc (I 605) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 606
        !"test606"
        z1 <== ((-3.3)+(-8.0)*q)
        z2 <== ((-3.3)+(-8.0)*y)
        print.cccc (I 606) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 607
        !"test607"
        z1 <== ((7.8/(-3.4))*(p+3.7)*2.8)
        z2 <== ((7.8/(-3.4))*(x+3.7)*2.8)
        print.cccc (I 607) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 608
        !"test608"
        z1 <== (p-(-3.2)/p)
        z2 <== (x-(-3.2)/x)
        print.cccc (I 608) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 609
        !"test609"
        z1 <== ((-1.8))
        z2 <== ((-1.8))
        print.cccc (I 609) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 610
        !"test610"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 610) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 611
        !"test611"
        z1 <== (((q/(-p))/(-5.3)*7.1/(-p)*p-((-q)-p+(-2.4)-(-q))+((-1.0)-(-p)))/((-q)+p)*((-q)-0.8/(-q)))
        z2 <== (((y/(-x))/(-5.3)*7.1/(-x)*x-((-y)-x+(-2.4)-(-y))+((-1.0)-(-x)))/((-y)+x)*((-y)-0.8/(-y)))
        print.cccc (I 611) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 612
        !"test612"
        z1 <== (6.3*((p+q*(-5.0)-(-0.6)*(-2.4))/((-q))/(-p)-p*((-p))))
        z2 <== (6.3*((x+y*(-5.0)-(-0.6)*(-2.4))/((-y))/(-x)-x*((-x))))
        print.cccc (I 612) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 613
        !"test613"
        z1 <== ((3.4)/(-q))
        z2 <== ((3.4)/(-y))
        print.cccc (I 613) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 614
        !"test614"
        z1 <== ((p)/(8.6+q*(-1.4)+(q*p)))
        z2 <== ((x)/(8.6+y*(-1.4)+(y*x)))
        print.cccc (I 614) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 615
        !"test615"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 615) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 616
        !"test616"
        z1 <== (((-p))+(-0.0)-((q-8.3+q+(-q))-((-3.2)-(-4.0)+(-p)/q)+(-1.2)-(p-q*q-3.3/(-q))))
        z2 <== (((-x))+(-0.0)-((y-8.3+y+(-y))-((-3.2)-(-4.0)+(-x)/y)+(-1.2)-(x-y*y-3.3/(-y))))
        print.cccc (I 616) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 617
        !"test617"
        z1 <== 4.8/(-1.4)-(-1.4)-(-q)/(p*(-q)*4.4)+(((-p)*5.5+1.3)-((-p)))
        z2 <== 4.8/(-1.4)-(-1.4)-(-y)/(x*(-y)*4.4)+(((-x)*5.5+1.3)-((-x)))
        print.cccc (I 617) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 618
        !"test618"
        z1 <== ((-q)*(-7.5)-(((-p)/7.1+0.8/2.6/p))*(-5.7))
        z2 <== ((-y)*(-7.5)-(((-x)/7.1+0.8/2.6/x))*(-5.7))
        print.cccc (I 618) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 619
        !"test619"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 619) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 620
        !"test620"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 620) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 621
        !"test621"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 621) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 622
        !"test622"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 622) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 623
        !"test623"
        z1 <== (((5.2-(-8.8)*1.7/(-p))-((-q)))+q*((-0.3))/(-6.2)*3.5-((-q)-(-q)*(-5.2)-q/q)+((-3.2)*(-q)+(-p))+(-q)/(p/(-0.2)*p/p+(4.5*(-p)+6.5/(-8.6)/(-4.1))-p))
        z2 <== (((5.2-(-8.8)*1.7/(-x))-((-y)))+y*((-0.3))/(-6.2)*3.5-((-y)-(-y)*(-5.2)-y/y)+((-3.2)*(-y)+(-x))+(-y)/(x/(-0.2)*x/x+(4.5*(-x)+6.5/(-8.6)/(-4.1))-x))
        print.cccc (I 623) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 624
        !"test624"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 624) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 625
        !"test625"
        z1 <== (4.1*((-8.1))-(p+p-(1.6))*(-6.2)-p)
        z2 <== (4.1*((-8.1))-(x+x-(1.6))*(-6.2)-x)
        print.cccc (I 625) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 626
        !"test626"
        z1 <== ((((-5.3)+(-8.0)))+(q/q-(-q)/(4.4+p-4.4/0.8*(-7.1))*((-p)-p+(-3.8)-(-3.2)*0.2))*(((-q)+5.8/3.4*4.1)-q-((-4.6)*(-q)*3.0)*(q/7.2/0.5*(-6.1)-5.6)-(7.3+(-p)/q)))
        z2 <== ((((-5.3)+(-8.0)))+(y/y-(-y)/(4.4+x-4.4/0.8*(-7.1))*((-x)-x+(-3.8)-(-3.2)*0.2))*(((-y)+5.8/3.4*4.1)-y-((-4.6)*(-y)*3.0)*(y/7.2/0.5*(-6.1)-5.6)-(7.3+(-x)/y)))
        print.cccc (I 626) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 627
        !"test627"
        z1 <== (((2.0*2.0+(-q)+(-p)/(-q))+4.7*p*(-q))/q+6.3*((-4.4)-((-5.8)+(-6.8)/q)*(-q)-(-0.7)+((-4.6)*q*(-q)*(-8.3)+0.3)))
        z2 <== (((2.0*2.0+(-y)+(-x)/(-y))+4.7*x*(-y))/y+6.3*((-4.4)-((-5.8)+(-6.8)/y)*(-y)-(-0.7)+((-4.6)*y*(-y)*(-8.3)+0.3)))
        print.cccc (I 627) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 628
        !"test628"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 628) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 629
        !"test629"
        z1 <== (q/(((-q))*(-q)*q-(-6.5)+(-q)-(p)+(1.3/(-2.0)/q)*(-p)))
        z2 <== (y/(((-y))*(-y)*y-(-6.5)+(-y)-(x)+(1.3/(-2.0)/y)*(-x)))
        print.cccc (I 629) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 630
        !"test630"
        z1 <== (q/2.3+8.4-(-3.8))*6.3*(6.3-q-q*(-2.1)-1.3)-(-1.4)/(2.8+(-0.7))*1.7*(-q)+(-p)/((-q)-3.1/(-p)-(-q)/(-q))-((-4.8)-(-6.2))+((-7.1)*(-4.7))-((-q)/(-5.5)-p/1.4-(-4.1))
        z2 <== (y/2.3+8.4-(-3.8))*6.3*(6.3-y-y*(-2.1)-1.3)-(-1.4)/(2.8+(-0.7))*1.7*(-y)+(-x)/((-y)-3.1/(-x)-(-y)/(-y))-((-4.8)-(-6.2))+((-7.1)*(-4.7))-((-y)/(-5.5)-x/1.4-(-4.1))
        print.cccc (I 630) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 631
        !"test631"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 631) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 632
        !"test632"
        z1 <== ((-1.6)/(-0.7)+((-0.4)/((-p)+(-0.0)/(-q)-(-3.0))-(p/(-q)*q+1.4)/(-7.1)))
        z2 <== ((-1.6)/(-0.7)+((-0.4)/((-x)+(-0.0)/(-y)-(-3.0))-(x/(-y)*y+1.4)/(-7.1)))
        print.cccc (I 632) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 633
        !"test633"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 633) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 634
        !"test634"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 634) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 635
        !"test635"
        z1 <== (5.5*q-(-6.8))
        z2 <== (5.5*y-(-6.8))
        print.cccc (I 635) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 636
        !"test636"
        z1 <== ((((-q)*(-p)-p-q*q)))
        z2 <== ((((-y)*(-x)-x-y*y)))
        print.cccc (I 636) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 637
        !"test637"
        z1 <== (((q/(-q)*q)*p*p/p-1.6))
        z2 <== (((y/(-y)*y)*x*x/x-1.6))
        print.cccc (I 637) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 638
        !"test638"
        z1 <== (-7.8)
        z2 <== (-7.8)
        print.cccc (I 638) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 639
        !"test639"
        z1 <== (-7.7)
        z2 <== (-7.7)
        print.cccc (I 639) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 640
        !"test640"
        z1 <== ((p/(-p))+q+(((-q)*8.6*3.7-(-2.5))+(-7.6)-(p+(-5.1))-(-1.1))*((-0.4)/2.2)-0.7/p*(-p)+p*((-4.3)))
        z2 <== ((x/(-x))+y+(((-y)*8.6*3.7-(-2.5))+(-7.6)-(x+(-5.1))-(-1.1))*((-0.4)/2.2)-0.7/x*(-x)+x*((-4.3)))
        print.cccc (I 640) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 641
        !"test641"
        z1 <== p
        z2 <== x
        print.cccc (I 641) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 642
        !"test642"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 642) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 643
        !"test643"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 643) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 644
        !"test644"
        z1 <== ((((-p)-1.5))-(p*((-8.5)+(-6.3)+q/p/(-5.1))-(q/(-0.1)*(-0.5)/1.8/8.8)-((-5.3)))+((-1.4))/(((-2.7)*p+0.1/(-p)))/(p))
        z2 <== ((((-x)-1.5))-(x*((-8.5)+(-6.3)+y/x/(-5.1))-(y/(-0.1)*(-0.5)/1.8/8.8)-((-5.3)))+((-1.4))/(((-2.7)*x+0.1/(-x)))/(x))
        print.cccc (I 644) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 645
        !"test645"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 645) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 646
        !"test646"
        z1 <== q
        z2 <== y
        print.cccc (I 646) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 647
        !"test647"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 647) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 648
        !"test648"
        z1 <== p
        z2 <== x
        print.cccc (I 648) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 649
        !"test649"
        z1 <== (1.2)
        z2 <== (1.2)
        print.cccc (I 649) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 650
        !"test650"
        z1 <== 8.3
        z2 <== 8.3
        print.cccc (I 650) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 651
        !"test651"
        z1 <== q
        z2 <== y
        print.cccc (I 651) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 652
        !"test652"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 652) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 653
        !"test653"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 653) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 654
        !"test654"
        z1 <== ((-0.8)/(q)+p/q-(q/(-1.1))/8.5/(5.3)*(-p))
        z2 <== ((-0.8)/(y)+x/y-(y/(-1.1))/8.5/(5.3)*(-x))
        print.cccc (I 654) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 655
        !"test655"
        z1 <== 3.1
        z2 <== 3.1
        print.cccc (I 655) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 656
        !"test656"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 656) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 657
        !"test657"
        z1 <== (-5.6)*(((-p)/q)+((-4.2)*(-q)+p)+p)*(-p)/((4.1*p-3.2/q)*q/((-q)/q)*((-3.8)*(-5.5)-0.7-(-7.6)+1.1))
        z2 <== (-5.6)*(((-x)/y)+((-4.2)*(-y)+x)+x)*(-x)/((4.1*x-3.2/y)*y/((-y)/y)*((-3.8)*(-5.5)-0.7-(-7.6)+1.1))
        print.cccc (I 657) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 658
        !"test658"
        z1 <== (((-8.1)))
        z2 <== (((-8.1)))
        print.cccc (I 658) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 659
        !"test659"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 659) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 660
        !"test660"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 660) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 661
        !"test661"
        z1 <== ((-1.8)-(-2.2))
        z2 <== ((-1.8)-(-2.2))
        print.cccc (I 661) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 662
        !"test662"
        z1 <== ((-p)-((-7.1)))/((-q)-(-2.2)/(-q)/(-q)/(0.3+5.8)*(8.0)/7.3)
        z2 <== ((-x)-((-7.1)))/((-y)-(-2.2)/(-y)/(-y)/(0.3+5.8)*(8.0)/7.3)
        print.cccc (I 662) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 663
        !"test663"
        z1 <== ((-p)/(-p)-((0.3))*((-p)-(2.3/p+(-p)*q)/(2.5/q*0.0-(-p))*(-7.1)))
        z2 <== ((-x)/(-x)-((0.3))*((-x)-(2.3/x+(-x)*y)/(2.5/y*0.0-(-x))*(-7.1)))
        print.cccc (I 663) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 664
        !"test664"
        z1 <== ((-3.2))
        z2 <== ((-3.2))
        print.cccc (I 664) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 665
        !"test665"
        z1 <== (4.1-((-q)/((-2.4)*(-6.3))*q)*8.2/(0.1*7.1/((-p)+(-5.2)-(-5.6)/(-7.8)-(-1.6))*((-p))-1.2))
        z2 <== (4.1-((-y)/((-2.4)*(-6.3))*y)*8.2/(0.1*7.1/((-x)+(-5.2)-(-5.6)/(-7.8)-(-1.6))*((-x))-1.2))
        print.cccc (I 665) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 666
        !"test666"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 666) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 667
        !"test667"
        z1 <== (p*(((-p)/(-q)-(-7.2)*(-q)-(-p))-q+(-q)/p*((-8.7)-(-p)-(-p)*(-p)))*q+(-p))
        z2 <== (x*(((-x)/(-y)-(-7.2)*(-y)-(-x))-y+(-y)/x*((-8.7)-(-x)-(-x)*(-x)))*y+(-x))
        print.cccc (I 667) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 668
        !"test668"
        z1 <== (((-7.4)*((-p)+(-q)+(-3.4))-(q/(-6.1)))/p-6.1+(-p))
        z2 <== (((-7.4)*((-x)+(-y)+(-3.4))-(y/(-6.1)))/x-6.1+(-x))
        print.cccc (I 668) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 669
        !"test669"
        z1 <== ((2.3*(-p)*(-4.2)+(-0.4)+(-p))+((-q)*4.4+(-5.0))-((-5.0)+(-8.0)*q+6.4/(-q))-(q)+(-2.4))*((6.5-(-p)-q/6.4)*(-6.7)/((-q))/((-p)-1.1*(-p)/5.8)/p)
        z2 <== ((2.3*(-x)*(-4.2)+(-0.4)+(-x))+((-y)*4.4+(-5.0))-((-5.0)+(-8.0)*y+6.4/(-y))-(y)+(-2.4))*((6.5-(-x)-y/6.4)*(-6.7)/((-y))/((-x)-1.1*(-x)/5.8)/x)
        print.cccc (I 669) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 670
        !"test670"
        z1 <== q
        z2 <== y
        print.cccc (I 670) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 671
        !"test671"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 671) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 672
        !"test672"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 672) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 673
        !"test673"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 673) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 674
        !"test674"
        z1 <== 0.3
        z2 <== 0.3
        print.cccc (I 674) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 675
        !"test675"
        z1 <== (3.6-p+6.0-((-q)/8.6-(-0.1)*((-q)+(-6.0)+1.0-(-0.4)))-p-(-q))
        z2 <== (3.6-x+6.0-((-y)/8.6-(-0.1)*((-y)+(-6.0)+1.0-(-0.4)))-x-(-y))
        print.cccc (I 675) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 676
        !"test676"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 676) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 677
        !"test677"
        z1 <== ((-7.1)*(-q)-(-5.0)+(-8.6)*(q))
        z2 <== ((-7.1)*(-y)-(-5.0)+(-8.6)*(y))
        print.cccc (I 677) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 678
        !"test678"
        z1 <== (5.4/(-2.4)+(-0.4)-(0.6/3.2/(-p))-1.7-1.5-(-6.4))
        z2 <== (5.4/(-2.4)+(-0.4)-(0.6/3.2/(-x))-1.7-1.5-(-6.4))
        print.cccc (I 678) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 679
        !"test679"
        z1 <== 8.5/4.5/(p-(-7.3)*(-p)-(-p)-(-2.2)*2.6/((-p)/(-p)+(-p)/(-q))/(4.1*(-4.5)+(-q)))
        z2 <== 8.5/4.5/(x-(-7.3)*(-x)-(-x)-(-2.2)*2.6/((-x)/(-x)+(-x)/(-y))/(4.1*(-4.5)+(-y)))
        print.cccc (I 679) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 680
        !"test680"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 680) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 681
        !"test681"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 681) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 682
        !"test682"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 682) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 683
        !"test683"
        z1 <== ((-p)/q+q+0.4)
        z2 <== ((-x)/y+y+0.4)
        print.cccc (I 683) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 684
        !"test684"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 684) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 685
        !"test685"
        z1 <== q
        z2 <== y
        print.cccc (I 685) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 686
        !"test686"
        z1 <== ((p/(5.6-(-1.6)-6.5*(-p)+6.1)*p+(-p)-q)+q*(-6.2)-((1.2+5.5*(-p)-1.8/p)+(-7.5)/(q))+(-7.3))
        z2 <== ((x/(5.6-(-1.6)-6.5*(-x)+6.1)*x+(-x)-y)+y*(-6.2)-((1.2+5.5*(-x)-1.8/x)+(-7.5)/(y))+(-7.3))
        print.cccc (I 686) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 687
        !"test687"
        z1 <== ((-q)+q+(p-(-p))/(((-3.8))))
        z2 <== ((-y)+y+(x-(-x))/(((-3.8))))
        print.cccc (I 687) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 688
        !"test688"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 688) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 689
        !"test689"
        z1 <== (5.3)*(-8.3)/(-q)+3.0
        z2 <== (5.3)*(-8.3)/(-y)+3.0
        print.cccc (I 689) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 690
        !"test690"
        z1 <== ((-q)/(-6.5)*(p/(6.6*1.7)*0.3)+(q-((-2.7)-(-5.0)-(-2.4)/(-8.5)/(-7.7))-6.2-p-2.6+((-q)*(-q)))+(-p))
        z2 <== ((-y)/(-6.5)*(x/(6.6*1.7)*0.3)+(y-((-2.7)-(-5.0)-(-2.4)/(-8.5)/(-7.7))-6.2-x-2.6+((-y)*(-y)))+(-x))
        print.cccc (I 690) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 691
        !"test691"
        z1 <== (p*(-p)/(((-p)-q+4.2*4.1)+((-p))-((-q)*(-2.3))-(p/0.1*(-5.2))))
        z2 <== (x*(-x)/(((-x)-y+4.2*4.1)+((-x))-((-y)*(-2.3))-(x/0.1*(-5.2))))
        print.cccc (I 691) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 692
        !"test692"
        z1 <== (-6.4)
        z2 <== (-6.4)
        print.cccc (I 692) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 693
        !"test693"
        z1 <== (((-q)))
        z2 <== (((-y)))
        print.cccc (I 693) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 694
        !"test694"
        z1 <== p*(8.2-(-q))*(-q)+((-0.2)*((-p)/4.4))
        z2 <== x*(8.2-(-y))*(-y)+((-0.2)*((-x)/4.4))
        print.cccc (I 694) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 695
        !"test695"
        z1 <== q
        z2 <== y
        print.cccc (I 695) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 696
        !"test696"
        z1 <== q
        z2 <== y
        print.cccc (I 696) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 697
        !"test697"
        z1 <== (-7.7)
        z2 <== (-7.7)
        print.cccc (I 697) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 698
        !"test698"
        z1 <== (((-7.4)*(-4.8)+(-1.0)))
        z2 <== (((-7.4)*(-4.8)+(-1.0)))
        print.cccc (I 698) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 699
        !"test699"
        z1 <== ((-p)*(((-p)-(-q))+((-q)*q-(-q)))+(5.2/((-0.2)*(-8.7)+(-p)*(-p)*p)+q/7.6*(p-(-p))))
        z2 <== ((-x)*(((-x)-(-y))+((-y)*y-(-y)))+(5.2/((-0.2)*(-8.7)+(-x)*(-x)*x)+y/7.6*(x-(-x))))
        print.cccc (I 699) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 700
        !"test700"
        z1 <== ((p/q+p+(-q)))-p*(-4.0)*(-2.6)+p-7.7*3.4-((6.7/8.8)/7.2-(-p)-(-0.1)+q/2.0*2.1+(-7.0))
        z2 <== ((x/y+x+(-y)))-x*(-4.0)*(-2.6)+x-7.7*3.4-((6.7/8.8)/7.2-(-x)-(-0.1)+y/2.0*2.1+(-7.0))
        print.cccc (I 700) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 701
        !"test701"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 701) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 702
        !"test702"
        z1 <== (p/(-q)-p-(p)/(1.1/4.0/p)*p+p)
        z2 <== (x/(-y)-x-(x)/(1.1/4.0/x)*x+x)
        print.cccc (I 702) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 703
        !"test703"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 703) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 704
        !"test704"
        z1 <== (p+(((-0.0)*q*(-q))/((-0.4)-7.7/p)-(-q))*(q/(-4.0)+1.6)/(-0.0)-(-q))
        z2 <== (x+(((-0.0)*y*(-y))/((-0.4)-7.7/x)-(-y))*(y/(-4.0)+1.6)/(-0.0)-(-y))
        print.cccc (I 704) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 705
        !"test705"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 705) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 706
        !"test706"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 706) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 707
        !"test707"
        z1 <== (((p+3.3+q)/((-q)/(-7.0)/q/(-6.4)+2.5))*((-7.5)+p)+7.3*(3.6))
        z2 <== (((x+3.3+y)/((-y)/(-7.0)/y/(-6.4)+2.5))*((-7.5)+x)+7.3*(3.6))
        print.cccc (I 707) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 708
        !"test708"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 708) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 709
        !"test709"
        z1 <== ((8.2/p+7.8*(-q)))
        z2 <== ((8.2/x+7.8*(-y)))
        print.cccc (I 709) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 710
        !"test710"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 710) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 711
        !"test711"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 711) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 712
        !"test712"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 712) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 713
        !"test713"
        z1 <== q
        z2 <== y
        print.cccc (I 713) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 714
        !"test714"
        z1 <== ((-p)-(-1.7)*0.6-((p-(-p))*p+(-5.4)))
        z2 <== ((-x)-(-1.7)*0.6-((x-(-x))*x+(-5.4)))
        print.cccc (I 714) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 715
        !"test715"
        z1 <== (((p-p*(-q))+(-2.0))*(-5.7)-q)
        z2 <== (((x-x*(-y))+(-2.0))*(-5.7)-y)
        print.cccc (I 715) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 716
        !"test716"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 716) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 717
        !"test717"
        z1 <== p
        z2 <== x
        print.cccc (I 717) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 718
        !"test718"
        z1 <== (p/q*(-6.6)*(-5.4)/(1.2*p+p)*((0.3)+5.4+(-3.3)-8.7/p*3.5-((-1.5)-5.6)*(-1.8))*2.5)
        z2 <== (x/y*(-6.6)*(-5.4)/(1.2*x+x)*((0.3)+5.4+(-3.3)-8.7/x*3.5-((-1.5)-5.6)*(-1.8))*2.5)
        print.cccc (I 718) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 719
        !"test719"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 719) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 720
        !"test720"
        z1 <== (-7.7)
        z2 <== (-7.7)
        print.cccc (I 720) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 721
        !"test721"
        z1 <== (((0.8+(-3.1))+1.5-(-0.7)/4.6-6.0/p-(-p)+(-7.0))*((-0.8))+(q+7.5))
        z2 <== (((0.8+(-3.1))+1.5-(-0.7)/4.6-6.0/x-(-x)+(-7.0))*((-0.8))+(y+7.5))
        print.cccc (I 721) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 722
        !"test722"
        z1 <== p
        z2 <== x
        print.cccc (I 722) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 723
        !"test723"
        z1 <== (q-(-4.6)+6.0-(((-p))*4.4-((-0.7))-((-q)+p/(-q)/q-(-q))-4.8))
        z2 <== (y-(-4.6)+6.0-(((-x))*4.4-((-0.7))-((-y)+x/(-y)/y-(-y))-4.8))
        print.cccc (I 723) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 724
        !"test724"
        z1 <== (((-4.7)+(-p)*(-p))+(q)*((-0.1)/p+4.5)/(p/0.0-(-p))/(-8.5))-(-q)/(7.1+q*(-8.7))+(p-((-4.1)+(-5.4)-(-1.0)-(-1.3)/(-7.1)))+(-q)
        z2 <== (((-4.7)+(-x)*(-x))+(y)*((-0.1)/x+4.5)/(x/0.0-(-x))/(-8.5))-(-y)/(7.1+y*(-8.7))+(x-((-4.1)+(-5.4)-(-1.0)-(-1.3)/(-7.1)))+(-y)
        print.cccc (I 724) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 725
        !"test725"
        z1 <== (q/((-1.7)-q+(5.1/q/(-3.4)*(-1.7))*((-q)*(-q)+p-(-0.5))-3.8))
        z2 <== (y/((-1.7)-y+(5.1/y/(-3.4)*(-1.7))*((-y)*(-y)+x-(-0.5))-3.8))
        print.cccc (I 725) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 726
        !"test726"
        z1 <== q
        z2 <== y
        print.cccc (I 726) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 727
        !"test727"
        z1 <== q
        z2 <== y
        print.cccc (I 727) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 728
        !"test728"
        z1 <== ((-0.1)+(q-((-0.3)*(-0.1)+8.7/3.1*(-q))))
        z2 <== ((-0.1)+(y-((-0.3)*(-0.1)+8.7/3.1*(-y))))
        print.cccc (I 728) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 729
        !"test729"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 729) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 730
        !"test730"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 730) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 731
        !"test731"
        z1 <== p
        z2 <== x
        print.cccc (I 731) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 732
        !"test732"
        z1 <== ((((-2.4)+7.3+(-p)+q)+q+p)*p*(-q)+(-2.6))
        z2 <== ((((-2.4)+7.3+(-x)+y)+y+x)*x*(-y)+(-2.6))
        print.cccc (I 732) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 733
        !"test733"
        z1 <== (4.3+((-q)*8.7-(-p)*(-2.2))-(p+p*0.7+(-3.0)-(-7.6))+(-3.2)*((-q)*(-5.0)/(-q)/(-2.2)-p))/2.8+((5.8/(-0.5)+(-p)/1.7+(-p))*(-p))*(-q)
        z2 <== (4.3+((-y)*8.7-(-x)*(-2.2))-(x+x*0.7+(-3.0)-(-7.6))+(-3.2)*((-y)*(-5.0)/(-y)/(-2.2)-x))/2.8+((5.8/(-0.5)+(-x)/1.7+(-x))*(-x))*(-y)
        print.cccc (I 733) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 734
        !"test734"
        z1 <== ((4.8-(-p)*0.8)/(6.6/4.4-(-3.4)-(-2.3)/p)+(-5.3)+(-p)*(-0.1)+(-p))/(-q)/(-p)/(-8.8)
        z2 <== ((4.8-(-x)*0.8)/(6.6/4.4-(-3.4)-(-2.3)/x)+(-5.3)+(-x)*(-0.1)+(-x))/(-y)/(-x)/(-8.8)
        print.cccc (I 734) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 735
        !"test735"
        z1 <== q
        z2 <== y
        print.cccc (I 735) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 736
        !"test736"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 736) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 737
        !"test737"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 737) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 738
        !"test738"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 738) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 739
        !"test739"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 739) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 740
        !"test740"
        z1 <== 6.1/((-7.4)*4.8-p+(-3.5)/q+(-p)*(-p))
        z2 <== 6.1/((-7.4)*4.8-x+(-3.5)/y+(-x)*(-x))
        print.cccc (I 740) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 741
        !"test741"
        z1 <== q
        z2 <== y
        print.cccc (I 741) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 742
        !"test742"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 742) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 743
        !"test743"
        z1 <== (((-7.7)/(-p))/((-p)*(-p)*(-3.7))*q-(-4.5)+(-q)*(-p)-((-p)+7.8*4.2-(-q)+(-4.6))*((-7.7))+(1.4*p+6.4-(-q))-8.1+(-1.6)*((-q)+q*(-q))-(-q))
        z2 <== (((-7.7)/(-x))/((-x)*(-x)*(-3.7))*y-(-4.5)+(-y)*(-x)-((-x)+7.8*4.2-(-y)+(-4.6))*((-7.7))+(1.4*x+6.4-(-y))-8.1+(-1.6)*((-y)+y*(-y))-(-y))
        print.cccc (I 743) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 744
        !"test744"
        z1 <== (2.0+(-0.1))
        z2 <== (2.0+(-0.1))
        print.cccc (I 744) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 745
        !"test745"
        z1 <== ((5.6*(-3.0)))
        z2 <== ((5.6*(-3.0)))
        print.cccc (I 745) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 746
        !"test746"
        z1 <== (-0.1)
        z2 <== (-0.1)
        print.cccc (I 746) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 747
        !"test747"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 747) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 748
        !"test748"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 748) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 749
        !"test749"
        z1 <== ((-q)-(q*(-p)/p)*((2.8/3.5-(-4.1)-(-p))*(q-(-p)/p+1.8)))
        z2 <== ((-y)-(y*(-x)/x)*((2.8/3.5-(-4.1)-(-x))*(y-(-x)/x+1.8)))
        print.cccc (I 749) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 750
        !"test750"
        z1 <== ((((-p)*(-q)*(-q))+((-p)/7.1-(-4.6)*1.2)/(-q))*0.6*p/(-1.6))
        z2 <== ((((-x)*(-y)*(-y))+((-x)/7.1-(-4.6)*1.2)/(-y))*0.6*x/(-1.6))
        print.cccc (I 750) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 751
        !"test751"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 751) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 752
        !"test752"
        z1 <== ((-6.7))
        z2 <== ((-6.7))
        print.cccc (I 752) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 753
        !"test753"
        z1 <== ((-0.2)-(8.5+0.4)/(-p)/0.0/6.7*3.3+q+((-q)*(-q))*(((-5.6)*(-3.6))+(2.6+(-p)+(-q)))-(-3.1)*((q)))
        z2 <== ((-0.2)-(8.5+0.4)/(-x)/0.0/6.7*3.3+y+((-y)*(-y))*(((-5.6)*(-3.6))+(2.6+(-x)+(-y)))-(-3.1)*((y)))
        print.cccc (I 753) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 754
        !"test754"
        z1 <== ((-2.3))*5.8*((2.7/(-4.2)*2.5*(-p)-(-6.1))-q/(7.5+(-2.2)+(-q)/3.8)+1.8-p)
        z2 <== ((-2.3))*5.8*((2.7/(-4.2)*2.5*(-x)-(-6.1))-y/(7.5+(-2.2)+(-y)/3.8)+1.8-x)
        print.cccc (I 754) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 755
        !"test755"
        z1 <== 6.5
        z2 <== 6.5
        print.cccc (I 755) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 756
        !"test756"
        z1 <== (-p)-6.7-((1.3-(-6.0)/1.6))-(-q)/(p-3.0)
        z2 <== (-x)-6.7-((1.3-(-6.0)/1.6))-(-y)/(x-3.0)
        print.cccc (I 756) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 757
        !"test757"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 757) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 758
        !"test758"
        z1 <== (8.8*p+(-q)-(-p)*(-2.0)/((-p)+(-q)/((-p))+(-6.3))+p/p*q)
        z2 <== (8.8*x+(-y)-(-x)*(-2.0)/((-x)+(-y)/((-x))+(-6.3))+x/x*y)
        print.cccc (I 758) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 759
        !"test759"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 759) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 760
        !"test760"
        z1 <== ((-2.6))
        z2 <== ((-2.6))
        print.cccc (I 760) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 761
        !"test761"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 761) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 762
        !"test762"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 762) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 763
        !"test763"
        z1 <== (7.2/((q)-7.1*(-q)*((-p)+(-5.1)/(-6.1)+p-q))+(-q)-0.0)
        z2 <== (7.2/((y)-7.1*(-y)*((-x)+(-5.1)/(-6.1)+x-y))+(-y)-0.0)
        print.cccc (I 763) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 764
        !"test764"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 764) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 765
        !"test765"
        z1 <== (p+(-p)+(((-q))/(-p)-3.3*(-p)+p+(-2.4)/(-8.8)/q*4.8*(-p)/((-4.5))))
        z2 <== (x+(-x)+(((-y))/(-x)-3.3*(-x)+x+(-2.4)/(-8.8)/y*4.8*(-x)/((-4.5))))
        print.cccc (I 765) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 766
        !"test766"
        z1 <== ((-2.5)/(p)/(((-p)+q*2.6)+5.2-(-5.7)-(-p)+(-p)-(-q)*0.1)/p/q)
        z2 <== ((-2.5)/(x)/(((-x)+y*2.6)+5.2-(-5.7)-(-x)+(-x)-(-y)*0.1)/x/y)
        print.cccc (I 766) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 767
        !"test767"
        z1 <== ((q/(-q)+((-p)+6.0*(-q)+(-6.6))*(2.7*(-8.5)))*(-2.0))
        z2 <== ((y/(-y)+((-x)+6.0*(-y)+(-6.6))*(2.7*(-8.5)))*(-2.0))
        print.cccc (I 767) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 768
        !"test768"
        z1 <== (7.3*q)
        z2 <== (7.3*y)
        print.cccc (I 768) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 769
        !"test769"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 769) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 770
        !"test770"
        z1 <== ((-6.0)/q)
        z2 <== ((-6.0)/y)
        print.cccc (I 770) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 771
        !"test771"
        z1 <== q
        z2 <== y
        print.cccc (I 771) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 772
        !"test772"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 772) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 773
        !"test773"
        z1 <== ((-3.6)-8.7)
        z2 <== ((-3.6)-8.7)
        print.cccc (I 773) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 774
        !"test774"
        z1 <== ((((-1.8)/(-1.4)+0.2-(-7.3)-(-q))+(-p)/p-5.5-(-3.6)))
        z2 <== ((((-1.8)/(-1.4)+0.2-(-7.3)-(-y))+(-x)/x-5.5-(-3.6)))
        print.cccc (I 774) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 775
        !"test775"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 775) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 776
        !"test776"
        z1 <== ((-q)-(((-6.4))+(p-(-q)/1.2/2.1*(-q)))/p*7.5)
        z2 <== ((-y)-(((-6.4))+(x-(-y)/1.2/2.1*(-y)))/x*7.5)
        print.cccc (I 776) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 777
        !"test777"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 777) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 778
        !"test778"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 778) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 779
        !"test779"
        z1 <== (3.8*((2.7)/((-p))+(2.3*8.0))+(-4.2)+(-p)+q)
        z2 <== (3.8*((2.7)/((-x))+(2.3*8.0))+(-4.2)+(-x)+y)
        print.cccc (I 779) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 780
        !"test780"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 780) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 781
        !"test781"
        z1 <== q
        z2 <== y
        print.cccc (I 781) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 782
        !"test782"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 782) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 783
        !"test783"
        z1 <== p
        z2 <== x
        print.cccc (I 783) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 784
        !"test784"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 784) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 785
        !"test785"
        z1 <== 4.6+(-6.7)+(-q)+((-p)+7.3/(-6.8)+(-3.1))/(4.3*(-5.3))
        z2 <== 4.6+(-6.7)+(-y)+((-x)+7.3/(-6.8)+(-3.1))/(4.3*(-5.3))
        print.cccc (I 785) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 786
        !"test786"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 786) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 787
        !"test787"
        z1 <== 7.7
        z2 <== 7.7
        print.cccc (I 787) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 788
        !"test788"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 788) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 789
        !"test789"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 789) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 790
        !"test790"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 790) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 791
        !"test791"
        z1 <== q
        z2 <== y
        print.cccc (I 791) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 792
        !"test792"
        z1 <== ((q/(-6.0)*(-p)-q+(-p))/((-p)/(-p))+1.4-(1.1/q*q+8.2*p)+(-2.3)/(-q)+(-1.6))
        z2 <== ((y/(-6.0)*(-x)-y+(-x))/((-x)/(-x))+1.4-(1.1/y*y+8.2*x)+(-2.3)/(-y)+(-1.6))
        print.cccc (I 792) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 793
        !"test793"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 793) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 794
        !"test794"
        z1 <== ((q*(-6.1)*(-3.5)*(-p)*((-p)/q*4.3+1.4*(-q))*(-q)-5.3*(-2.7)*p/8.8)*0.6)
        z2 <== ((y*(-6.1)*(-3.5)*(-x)*((-x)/y*4.3+1.4*(-y))*(-y)-5.3*(-2.7)*x/8.8)*0.6)
        print.cccc (I 794) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 795
        !"test795"
        z1 <== (1.7+(-p))
        z2 <== (1.7+(-x))
        print.cccc (I 795) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 796
        !"test796"
        z1 <== p
        z2 <== x
        print.cccc (I 796) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 797
        !"test797"
        z1 <== 3.4/((-p))
        z2 <== 3.4/((-x))
        print.cccc (I 797) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 798
        !"test798"
        z1 <== (((-6.5)*(-2.6)-(-4.4)*p/(-q)-((-p)/(-0.3)*(-p)/5.8/1.3))/8.2-((-4.8))+1.2-p)
        z2 <== (((-6.5)*(-2.6)-(-4.4)*x/(-y)-((-x)/(-0.3)*(-x)/5.8/1.3))/8.2-((-4.8))+1.2-x)
        print.cccc (I 798) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 799
        !"test799"
        z1 <== (4.2*(((-2.7)+q+(-2.5))/(-4.0))/q/((-q)*((-0.2)+1.3+(-q)*(-6.5))*q+p-6.7+(-p)/(-q)*(p-1.0/(-7.3)))+1.8)
        z2 <== (4.2*(((-2.7)+y+(-2.5))/(-4.0))/y/((-y)*((-0.2)+1.3+(-y)*(-6.5))*y+x-6.7+(-x)/(-y)*(x-1.0/(-7.3)))+1.8)
        print.cccc (I 799) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 800
        !"test800"
        z1 <== (-q)/(5.1)+(-6.6)*p*((-5.4)-(-8.1)+(-4.2))*q+((-p)/8.6*(-p)/5.4/p)
        z2 <== (-y)/(5.1)+(-6.6)*x*((-5.4)-(-8.1)+(-4.2))*y+((-x)/8.6*(-x)/5.4/x)
        print.cccc (I 800) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 801
        !"test801"
        z1 <== (((q+(-8.5)*p-4.7/(-1.1))+((-p)-(-7.0))-((-7.5)+(-4.8)))-q)
        z2 <== (((y+(-8.5)*x-4.7/(-1.1))+((-x)-(-7.0))-((-7.5)+(-4.8)))-y)
        print.cccc (I 801) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 802
        !"test802"
        z1 <== (p*q)
        z2 <== (x*y)
        print.cccc (I 802) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 803
        !"test803"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 803) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 804
        !"test804"
        z1 <== ((q/((-q)+(-6.1)+1.0-0.4)-(-p)-(1.2/2.4-4.0-p/(-q))+(q/(-p)+5.3*(-q)))-((7.0/0.2*(-1.7)))+q*((-q)/(-8.3)-(-q)*3.0+q-((-p)*(-3.2)+3.6/6.4*(-p))+q))
        z2 <== ((y/((-y)+(-6.1)+1.0-0.4)-(-x)-(1.2/2.4-4.0-x/(-y))+(y/(-x)+5.3*(-y)))-((7.0/0.2*(-1.7)))+y*((-y)/(-8.3)-(-y)*3.0+y-((-x)*(-3.2)+3.6/6.4*(-x))+y))
        print.cccc (I 804) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 805
        !"test805"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 805) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 806
        !"test806"
        z1 <== (((q))*((-q))-(0.4-(-q)-7.5+q-(7.1))*(-2.0)/((-6.3))+0.7)
        z2 <== (((y))*((-y))-(0.4-(-y)-7.5+y-(7.1))*(-2.0)/((-6.3))+0.7)
        print.cccc (I 806) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 807
        !"test807"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 807) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 808
        !"test808"
        z1 <== ((-q)*0.8)
        z2 <== ((-y)*0.8)
        print.cccc (I 808) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 809
        !"test809"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 809) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 810
        !"test810"
        z1 <== (((-0.5))+(-2.6)-p)
        z2 <== (((-0.5))+(-2.6)-x)
        print.cccc (I 810) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 811
        !"test811"
        z1 <== (8.0-((-4.3)/(-5.1)+7.0-(-p))-((-8.6)+p/(p*(-4.8)/p/(-4.5))/((-6.7)-(-3.8)-(-2.7)+(-5.7))))
        z2 <== (8.0-((-4.3)/(-5.1)+7.0-(-x))-((-8.6)+x/(x*(-4.8)/x/(-4.5))/((-6.7)-(-3.8)-(-2.7)+(-5.7))))
        print.cccc (I 811) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 812
        !"test812"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 812) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 813
        !"test813"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 813) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 814
        !"test814"
        z1 <== p
        z2 <== x
        print.cccc (I 814) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 815
        !"test815"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 815) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 816
        !"test816"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 816) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 817
        !"test817"
        z1 <== p
        z2 <== x
        print.cccc (I 817) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 818
        !"test818"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 818) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 819
        !"test819"
        z1 <== 5.8/(p*(-4.5)+((-3.1)/1.2/(-0.5))/1.1)
        z2 <== 5.8/(x*(-4.5)+((-3.1)/1.2/(-0.5))/1.1)
        print.cccc (I 819) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 820
        !"test820"
        z1 <== 3.8
        z2 <== 3.8
        print.cccc (I 820) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 821
        !"test821"
        z1 <== (-4.0)
        z2 <== (-4.0)
        print.cccc (I 821) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 822
        !"test822"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 822) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 823
        !"test823"
        z1 <== q
        z2 <== y
        print.cccc (I 823) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 824
        !"test824"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 824) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 825
        !"test825"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 825) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 826
        !"test826"
        z1 <== (((-p)))
        z2 <== (((-x)))
        print.cccc (I 826) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 827
        !"test827"
        z1 <== ((-5.3)+(((-q)/(-p))/(-7.4)-q-0.7-(-0.4)*(-q))*((-p)+(-4.2)+0.3/(-q))+((q/q+p-(-p)*p)+(-p)*((-p)))/(6.3-(-p)/4.2+(-0.1)))
        z2 <== ((-5.3)+(((-y)/(-x))/(-7.4)-y-0.7-(-0.4)*(-y))*((-x)+(-4.2)+0.3/(-y))+((y/y+x-(-x)*x)+(-x)*((-x)))/(6.3-(-x)/4.2+(-0.1)))
        print.cccc (I 827) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 828
        !"test828"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 828) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 829
        !"test829"
        z1 <== p-(((-3.8)+(-p)+p-(-5.4))*(q-q/(-4.3)*(-p))/(-0.4)/(p-1.8))-4.2
        z2 <== x-(((-3.8)+(-x)+x-(-5.4))*(y-y/(-4.3)*(-x))/(-0.4)/(x-1.8))-4.2
        print.cccc (I 829) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 830
        !"test830"
        z1 <== ((p*(-q))+((-p)-3.2/(-0.8)/5.8)*6.0)
        z2 <== ((x*(-y))+((-x)-3.2/(-0.8)/5.8)*6.0)
        print.cccc (I 830) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 831
        !"test831"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 831) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 832
        !"test832"
        z1 <== ((-p)-(-q))+p-1.2
        z2 <== ((-x)-(-y))+x-1.2
        print.cccc (I 832) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 833
        !"test833"
        z1 <== p
        z2 <== x
        print.cccc (I 833) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 834
        !"test834"
        z1 <== (0.4+(-q)*((-p)*(p))/(-p))
        z2 <== (0.4+(-y)*((-x)*(x))/(-x))
        print.cccc (I 834) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 835
        !"test835"
        z1 <== ((-q)/q-(q*(-7.8)+2.3*(-5.6)-0.2)*(2.3+q/(-q)/4.1*p)-(-4.1)*0.8/(-8.2))
        z2 <== ((-y)/y-(y*(-7.8)+2.3*(-5.6)-0.2)*(2.3+y/(-y)/4.1*x)-(-4.1)*0.8/(-8.2))
        print.cccc (I 835) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 836
        !"test836"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 836) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 837
        !"test837"
        z1 <== (-5.1)/((-0.5)*q)/(-5.7)-(-8.6)+(p+p+(-p)*(-p))/((-q)/p*(-8.5))
        z2 <== (-5.1)/((-0.5)*y)/(-5.7)-(-8.6)+(x+x+(-x)*(-x))/((-y)/x*(-8.5))
        print.cccc (I 837) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 838
        !"test838"
        z1 <== p
        z2 <== x
        print.cccc (I 838) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 839
        !"test839"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 839) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 840
        !"test840"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 840) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 841
        !"test841"
        z1 <== (-2.5)-q-(((-6.2)/(-1.3)/(-7.6)-q)/((-6.2)-5.4+(-7.7)*(-p))/((-q)*(-5.5)+(-q)+p+(-7.1)))
        z2 <== (-2.5)-y-(((-6.2)/(-1.3)/(-7.6)-y)/((-6.2)-5.4+(-7.7)*(-x))/((-y)*(-5.5)+(-y)+x+(-7.1)))
        print.cccc (I 841) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 842
        !"test842"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 842) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 843
        !"test843"
        z1 <== p
        z2 <== x
        print.cccc (I 843) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 844
        !"test844"
        z1 <== (p-(1.2*(-4.2)/3.0+(-p)*2.6/(-q)+(-6.6)-p/(-6.7)))
        z2 <== (x-(1.2*(-4.2)/3.0+(-x)*2.6/(-y)+(-6.6)-x/(-6.7)))
        print.cccc (I 844) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 845
        !"test845"
        z1 <== (((-7.3)-(-6.0)*p-(-p)/1.4)+1.8-(q/(4.5)/1.1-p)+(5.4-(6.1/6.3)+(-1.3))-5.6)
        z2 <== (((-7.3)-(-6.0)*x-(-x)/1.4)+1.8-(y/(4.5)/1.1-x)+(5.4-(6.1/6.3)+(-1.3))-5.6)
        print.cccc (I 845) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 846
        !"test846"
        z1 <== 6.1
        z2 <== 6.1
        print.cccc (I 846) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 847
        !"test847"
        z1 <== ((-2.7))
        z2 <== ((-2.7))
        print.cccc (I 847) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 848
        !"test848"
        z1 <== ((6.8+(-5.5))-3.6)
        z2 <== ((6.8+(-5.5))-3.6)
        print.cccc (I 848) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 849
        !"test849"
        z1 <== q
        z2 <== y
        print.cccc (I 849) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 850
        !"test850"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 850) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 851
        !"test851"
        z1 <== q
        z2 <== y
        print.cccc (I 851) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 852
        !"test852"
        z1 <== (-0.4)-((-p))/(p*(-6.3)*p)
        z2 <== (-0.4)-((-x))/(x*(-6.3)*x)
        print.cccc (I 852) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 853
        !"test853"
        z1 <== ((-p)*(-p)/q*(((-q)-p*(-p)*(-7.7))*p-p/(-5.8)-((-p)-(-8.0)-(-p)))*(8.4+(-6.5))*q-(q+(-7.5)+(-3.7)+q))
        z2 <== ((-x)*(-x)/y*(((-y)-x*(-x)*(-7.7))*x-x/(-5.8)-((-x)-(-8.0)-(-x)))*(8.4+(-6.5))*y-(y+(-7.5)+(-3.7)+y))
        print.cccc (I 853) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 854
        !"test854"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 854) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 855
        !"test855"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 855) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 856
        !"test856"
        z1 <== (1.0+((-q)/(p+(-4.6)-(-p)*(-p))+(-1.4)/(2.4+p-(-q)-(-q)-(-p)))+((2.0+6.8*8.6+(-3.1)*(-p)))-((-p)-q/5.8)/(6.8-q+(-6.6)+(-4.7))-(q)+(-7.8)*(p/1.1+(-1.1)+0.3+(-5.3)))
        z2 <== (1.0+((-y)/(x+(-4.6)-(-x)*(-x))+(-1.4)/(2.4+x-(-y)-(-y)-(-x)))+((2.0+6.8*8.6+(-3.1)*(-x)))-((-x)-y/5.8)/(6.8-y+(-6.6)+(-4.7))-(y)+(-7.8)*(x/1.1+(-1.1)+0.3+(-5.3)))
        print.cccc (I 856) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 857
        !"test857"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 857) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 858
        !"test858"
        z1 <== ((-0.5)/p)
        z2 <== ((-0.5)/x)
        print.cccc (I 858) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 859
        !"test859"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 859) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 860
        !"test860"
        z1 <== ((p+3.8-(3.0+0.1+(-4.7)*(-p))+(-1.0)-((-0.7)/q+(-p)+(-q)-(-q)))+(-p))
        z2 <== ((x+3.8-(3.0+0.1+(-4.7)*(-x))+(-1.0)-((-0.7)/y+(-x)+(-y)-(-y)))+(-x))
        print.cccc (I 860) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 861
        !"test861"
        z1 <== ((-p)+p/(-1.0)+((-q)*(-0.3))-(3.4))
        z2 <== ((-x)+x/(-1.0)+((-y)*(-0.3))-(3.4))
        print.cccc (I 861) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 862
        !"test862"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 862) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 863
        !"test863"
        z1 <== ((0.8/(-8.5)*(-p)/(-q))-(-p)-(((-q))*((-4.6)+q-p-0.2*6.4)*(p/7.2)+6.2+((-p)+(-p)-(-4.8)*(-p)-2.6)))
        z2 <== ((0.8/(-8.5)*(-x)/(-y))-(-x)-(((-y))*((-4.6)+y-x-0.2*6.4)*(x/7.2)+6.2+((-x)+(-x)-(-4.8)*(-x)-2.6)))
        print.cccc (I 863) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 864
        !"test864"
        z1 <== ((-q)*((-q)/(-p)/((-q)+(-q))/(2.0*(-p)*(-q)))+((-1.5)+((-q)-(-q))-5.8)/(((-p)*5.8+(-p))-p/(-q)*(-1.5)*(-p)+3.5+(0.3+(-7.6)-1.8/p+(-p))*(-6.3)))
        z2 <== ((-y)*((-y)/(-x)/((-y)+(-y))/(2.0*(-x)*(-y)))+((-1.5)+((-y)-(-y))-5.8)/(((-x)*5.8+(-x))-x/(-y)*(-1.5)*(-x)+3.5+(0.3+(-7.6)-1.8/x+(-x))*(-6.3)))
        print.cccc (I 864) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 865
        !"test865"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 865) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 866
        !"test866"
        z1 <== (p/(-2.7)/(-7.3))
        z2 <== (x/(-2.7)/(-7.3))
        print.cccc (I 866) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 867
        !"test867"
        z1 <== p
        z2 <== x
        print.cccc (I 867) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 868
        !"test868"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 868) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 869
        !"test869"
        z1 <== (0.1*(-q)+((-q)*(-p))*(4.5)-7.8)
        z2 <== (0.1*(-y)+((-y)*(-x))*(4.5)-7.8)
        print.cccc (I 869) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 870
        !"test870"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 870) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 871
        !"test871"
        z1 <== q
        z2 <== y
        print.cccc (I 871) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 872
        !"test872"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 872) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 873
        !"test873"
        z1 <== (q/(-2.8)+(-p))
        z2 <== (y/(-2.8)+(-x))
        print.cccc (I 873) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 874
        !"test874"
        z1 <== (7.6*(p/q*((-q)+(-8.3)/q-p)-((-1.7)/(-p)*(-1.6)/(-q)+q))*((-2.1)/(7.5+6.2*(-8.6)))*q)
        z2 <== (7.6*(x/y*((-y)+(-8.3)/y-x)-((-1.7)/(-x)*(-1.6)/(-y)+y))*((-2.1)/(7.5+6.2*(-8.6)))*y)
        print.cccc (I 874) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 875
        !"test875"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 875) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 876
        !"test876"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 876) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 877
        !"test877"
        z1 <== p
        z2 <== x
        print.cccc (I 877) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 878
        !"test878"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 878) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 879
        !"test879"
        z1 <== (q/(-0.5)+(4.6*q-(p+(-7.1))-p)/(-p)-(-p))
        z2 <== (y/(-0.5)+(4.6*y-(x+(-7.1))-x)/(-x)-(-x))
        print.cccc (I 879) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 880
        !"test880"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 880) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 881
        !"test881"
        z1 <== ((((-q)+(-p))-p*q/(q*(-7.4)+0.8))-(-q))
        z2 <== ((((-y)+(-x))-x*y/(y*(-7.4)+0.8))-(-y))
        print.cccc (I 881) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 882
        !"test882"
        z1 <== (p*4.5/p-0.1)
        z2 <== (x*4.5/x-0.1)
        print.cccc (I 882) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 883
        !"test883"
        z1 <== p
        z2 <== x
        print.cccc (I 883) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 884
        !"test884"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 884) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 885
        !"test885"
        z1 <== (((-7.7)/q-((-0.5))/(p/(-8.6)/(-p)))-(-2.1)/((-p)/6.6*(-6.8)*(-8.3)*q)/2.5/7.3+(-p)/((-7.3)*4.1/(-2.2)/(p-p*6.8/q)))
        z2 <== (((-7.7)/y-((-0.5))/(x/(-8.6)/(-x)))-(-2.1)/((-x)/6.6*(-6.8)*(-8.3)*y)/2.5/7.3+(-x)/((-7.3)*4.1/(-2.2)/(x-x*6.8/y)))
        print.cccc (I 885) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 886
        !"test886"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 886) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 887
        !"test887"
        z1 <== (((-8.1)+((-3.8))+p/(-p)+(0.2/p-(-6.7))))
        z2 <== (((-8.1)+((-3.8))+x/(-x)+(0.2/x-(-6.7))))
        print.cccc (I 887) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 888
        !"test888"
        z1 <== (6.5-q-((-q)+(-p)*8.5+(-1.7)-(q/(-4.1)-p)*(-q)*(8.3-(-q)))-q)
        z2 <== (6.5-y-((-y)+(-x)*8.5+(-1.7)-(y/(-4.1)-x)*(-y)*(8.3-(-y)))-y)
        print.cccc (I 888) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 889
        !"test889"
        z1 <== ((7.0/4.6-p*1.6*(-0.1))-(-q)/((-4.5)+(-p))/((-1.3))/((-q)/(-7.2)/5.2/0.4))+(-3.4)
        z2 <== ((7.0/4.6-x*1.6*(-0.1))-(-y)/((-4.5)+(-x))/((-1.3))/((-y)/(-7.2)/5.2/0.4))+(-3.4)
        print.cccc (I 889) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 890
        !"test890"
        z1 <== (((-p))*(5.3-(-p)-(-p)-p-(-q)/(-p)+(-6.4))/(-q)*((-p)/(-3.6)*(-5.6)-q)-(-q)*(-1.6)-((q+(-q)-7.2*(-6.4)*(-q))))
        z2 <== (((-x))*(5.3-(-x)-(-x)-x-(-y)/(-x)+(-6.4))/(-y)*((-x)/(-3.6)*(-5.6)-y)-(-y)*(-1.6)-((y+(-y)-7.2*(-6.4)*(-y))))
        print.cccc (I 890) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 891
        !"test891"
        z1 <== q
        z2 <== y
        print.cccc (I 891) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 892
        !"test892"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 892) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 893
        !"test893"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 893) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 894
        !"test894"
        z1 <== (((-q)-7.1/((-5.2)+(-q)+(-q))+q)*p/(1.8-2.2-(-7.1)-(-q))+q+q/7.5-8.7/((-1.4)/(-q)/(-p)-(-1.1)-(-q)-(-3.7)+0.2)/(q-0.4*3.2)/((-q)/(-q)/(-4.8)+(-q))+(-p))
        z2 <== (((-y)-7.1/((-5.2)+(-y)+(-y))+y)*x/(1.8-2.2-(-7.1)-(-y))+y+y/7.5-8.7/((-1.4)/(-y)/(-x)-(-1.1)-(-y)-(-3.7)+0.2)/(y-0.4*3.2)/((-y)/(-y)/(-4.8)+(-y))+(-x))
        print.cccc (I 894) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 895
        !"test895"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 895) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 896
        !"test896"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 896) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 897
        !"test897"
        z1 <== q/((7.5/(-5.5)/(-q)+(-2.1)/(-6.6))+(p+(-2.2)-(-0.0)))*(-2.1)*((-p)+(-p)-p-6.5/(-0.6))
        z2 <== y/((7.5/(-5.5)/(-y)+(-2.1)/(-6.6))+(x+(-2.2)-(-0.0)))*(-2.1)*((-x)+(-x)-x-6.5/(-0.6))
        print.cccc (I 897) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 898
        !"test898"
        z1 <== (((8.3)/(p*(-3.0)/(-2.6)+p)-5.6*(q-(-8.2)+p/(-q)-(-q)))*(p*p/(-p)*(2.3+(-3.5))*(q/q/(-2.4)+(-4.4)+q))-q)
        z2 <== (((8.3)/(x*(-3.0)/(-2.6)+x)-5.6*(y-(-8.2)+x/(-y)-(-y)))*(x*x/(-x)*(2.3+(-3.5))*(y/y/(-2.4)+(-4.4)+y))-y)
        print.cccc (I 898) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 899
        !"test899"
        z1 <== ((((-q)*(-p)*7.7-q-q)*(-p)*q/((-7.4)*q*7.2+q)+(2.6-7.0+q)))
        z2 <== ((((-y)*(-x)*7.7-y-y)*(-x)*y/((-7.4)*y*7.2+y)+(2.6-7.0+y)))
        print.cccc (I 899) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 900
        !"test900"
        z1 <== ((-5.1)/(-2.3)/0.2)
        z2 <== ((-5.1)/(-2.3)/0.2)
        print.cccc (I 900) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 901
        !"test901"
        z1 <== (5.8)
        z2 <== (5.8)
        print.cccc (I 901) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 902
        !"test902"
        z1 <== (((q/2.8-(-7.5))-(7.0+(-5.4)))*(((-p)-(-1.1)-p)/(3.5/2.4*p)/(q)-(-p))-(((-3.4)-(-7.5)+(-p)+p)*(-q)/(-q)-(-q)*(-q)+(-p)-(-8.1)*(-q)))
        z2 <== (((y/2.8-(-7.5))-(7.0+(-5.4)))*(((-x)-(-1.1)-x)/(3.5/2.4*x)/(y)-(-x))-(((-3.4)-(-7.5)+(-x)+x)*(-y)/(-y)-(-y)*(-y)+(-x)-(-8.1)*(-y)))
        print.cccc (I 902) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 903
        !"test903"
        z1 <== ((p*6.2)/(-0.0))
        z2 <== ((x*6.2)/(-0.0))
        print.cccc (I 903) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 904
        !"test904"
        z1 <== (((4.5+(-p)/(-2.5)-(-p)-(-7.3))+((-7.4)-(-q)/(-5.6)+2.2*2.0)/2.4-((-8.3)))+(-p)*(-6.6)-((-2.1))*2.4+7.0*q/((-q)-(-3.7)+(-q))/((-q)))
        z2 <== (((4.5+(-x)/(-2.5)-(-x)-(-7.3))+((-7.4)-(-y)/(-5.6)+2.2*2.0)/2.4-((-8.3)))+(-x)*(-6.6)-((-2.1))*2.4+7.0*y/((-y)-(-3.7)+(-y))/((-y)))
        print.cccc (I 904) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 905
        !"test905"
        z1 <== q
        z2 <== y
        print.cccc (I 905) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 906
        !"test906"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 906) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 907
        !"test907"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 907) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 908
        !"test908"
        z1 <== (5.1-8.1*3.0-((q)*((-q))/2.5*((-0.6)+(-q)-q))-6.4)
        z2 <== (5.1-8.1*3.0-((y)*((-y))/2.5*((-0.6)+(-y)-y))-6.4)
        print.cccc (I 908) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 909
        !"test909"
        z1 <== ((p*((-p)/(-p)/(-p)-q)+p/5.3-(-p)-0.3/((-0.8)/q))/(-q)+7.0-(-5.8)/(-3.3))
        z2 <== ((x*((-x)/(-x)/(-x)-y)+x/5.3-(-x)-0.3/((-0.8)/y))/(-y)+7.0-(-5.8)/(-3.3))
        print.cccc (I 909) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 910
        !"test910"
        z1 <== ((2.4-7.4/(-0.2)*p)*(q)+(-p)-3.5)-(-4.7)*((-q)-((-q)-q/(-7.3)+(-q)+(-4.2))-((-q)-6.6-(-p)-(-q)/(-5.0))+(6.2))/p-(p+q-6.1*((-q)/(-6.3)/p+8.2))
        z2 <== ((2.4-7.4/(-0.2)*x)*(y)+(-x)-3.5)-(-4.7)*((-y)-((-y)-y/(-7.3)+(-y)+(-4.2))-((-y)-6.6-(-x)-(-y)/(-5.0))+(6.2))/x-(x+y-6.1*((-y)/(-6.3)/x+8.2))
        print.cccc (I 910) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 911
        !"test911"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 911) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 912
        !"test912"
        z1 <== ((-8.2)*((0.3)*q+4.7+(5.1/(-8.1)+(-p)-(-p))+(5.1-(-q)+(-q)+p))-((-q)-(q+(-p)+p/(-q))-(1.5+(-q)/q*q))/(-0.8)*q+(-1.0)-0.0+(-p)+(p*q)*((-1.3)/5.7*q-(-p)))
        z2 <== ((-8.2)*((0.3)*y+4.7+(5.1/(-8.1)+(-x)-(-x))+(5.1-(-y)+(-y)+x))-((-y)-(y+(-x)+x/(-y))-(1.5+(-y)/y*y))/(-0.8)*y+(-1.0)-0.0+(-x)+(x*y)*((-1.3)/5.7*y-(-x)))
        print.cccc (I 912) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 913
        !"test913"
        z1 <== q
        z2 <== y
        print.cccc (I 913) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 914
        !"test914"
        z1 <== (p*3.7*p*q+(-q)-(-q))-((5.8)-(-8.3)-(-1.1)+p*(-8.0)*((-3.1)/(-q)-(-p)-p+p))+((-7.3)-(-p)/(-3.3)+q)
        z2 <== (x*3.7*x*y+(-y)-(-y))-((5.8)-(-8.3)-(-1.1)+x*(-8.0)*((-3.1)/(-y)-(-x)-x+x))+((-7.3)-(-x)/(-3.3)+y)
        print.cccc (I 914) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 915
        !"test915"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 915) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 916
        !"test916"
        z1 <== (((-7.2)*(-4.2))*(8.6+(-8.5))-(-0.5)+5.2/7.2/5.7+((-q)/4.6-(-p))-4.8-(((-q)/(-4.2))))
        z2 <== (((-7.2)*(-4.2))*(8.6+(-8.5))-(-0.5)+5.2/7.2/5.7+((-y)/4.6-(-x))-4.8-(((-y)/(-4.2))))
        print.cccc (I 916) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 917
        !"test917"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 917) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 918
        !"test918"
        z1 <== (((q/q*p*(-5.6)+(-2.0))-(6.5-(-3.0)+(-p))+(p/q+(-3.6)*p-(-p)))/(-q)/8.5*((-0.6)+p-((-1.1)-(-5.0)/p*(-q)-q)-(-q)/((-p)/6.8/(-q)/p-5.4)))
        z2 <== (((y/y*x*(-5.6)+(-2.0))-(6.5-(-3.0)+(-x))+(x/y+(-3.6)*x-(-x)))/(-y)/8.5*((-0.6)+x-((-1.1)-(-5.0)/x*(-y)-y)-(-y)/((-x)/6.8/(-y)/x-5.4)))
        print.cccc (I 918) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 919
        !"test919"
        z1 <== (((5.5*7.4)-(p))+(7.8*q/((-q)*q/p+(-q)/p)-4.4)/(-4.6)+q)
        z2 <== (((5.5*7.4)-(x))+(7.8*y/((-y)*y/x+(-y)/x)-4.4)/(-4.6)+y)
        print.cccc (I 919) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 920
        !"test920"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 920) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 921
        !"test921"
        z1 <== (((p-p))/(((-q)/p*(-p)*q)-((-4.8)/(-5.7)+p)/1.4+p-(-q)/(-8.8)*(-6.0)))
        z2 <== (((x-x))/(((-y)/x*(-x)*y)-((-4.8)/(-5.7)+x)/1.4+x-(-y)/(-8.8)*(-6.0)))
        print.cccc (I 921) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 922
        !"test922"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 922) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 923
        !"test923"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 923) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 924
        !"test924"
        z1 <== ((-8.5)*(6.8))
        z2 <== ((-8.5)*(6.8))
        print.cccc (I 924) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 925
        !"test925"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 925) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 926
        !"test926"
        z1 <== ((-p)+(q+0.2))
        z2 <== ((-x)+(y+0.2))
        print.cccc (I 926) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 927
        !"test927"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 927) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 928
        !"test928"
        z1 <== ((1.7*1.5/(-2.8)+7.4/q/(-q)*p-5.8)-((-p)/(-q))+(-q))
        z2 <== ((1.7*1.5/(-2.8)+7.4/y/(-y)*x-5.8)-((-x)/(-y))+(-y))
        print.cccc (I 928) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 929
        !"test929"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 929) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 930
        !"test930"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 930) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 931
        !"test931"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 931) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 932
        !"test932"
        z1 <== ((-p)+q-6.5/p*(q/2.6*(-2.6)-(-3.0))/(-p)-p/((8.0+(-4.8)*(-5.6))/((-3.0)+(-6.3)-(-q)+(-8.5)-(-1.0))))
        z2 <== ((-x)+y-6.5/x*(y/2.6*(-2.6)-(-3.0))/(-x)-x/((8.0+(-4.8)*(-5.6))/((-3.0)+(-6.3)-(-y)+(-8.5)-(-1.0))))
        print.cccc (I 932) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 933
        !"test933"
        z1 <== ((-4.5)*((-0.3)*7.3/((-q)*p))+(-q)-((q*5.8*(-8.3)-2.0)/(p+q+8.7)+((-p)/0.3/p*(-p)/(-1.4))+(q-p+(-2.3)*(-p)+7.3)))
        z2 <== ((-4.5)*((-0.3)*7.3/((-y)*x))+(-y)-((y*5.8*(-8.3)-2.0)/(x+y+8.7)+((-x)/0.3/x*(-x)/(-1.4))+(y-x+(-2.3)*(-x)+7.3)))
        print.cccc (I 933) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 934
        !"test934"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 934) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 935
        !"test935"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 935) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 936
        !"test936"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 936) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 937
        !"test937"
        z1 <== p
        z2 <== x
        print.cccc (I 937) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 938
        !"test938"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 938) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 939
        !"test939"
        z1 <== 7.3
        z2 <== 7.3
        print.cccc (I 939) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 940
        !"test940"
        z1 <== (2.4/(-1.7)+(-p)-(p))
        z2 <== (2.4/(-1.7)+(-x)-(x))
        print.cccc (I 940) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 941
        !"test941"
        z1 <== ((-3.7)-q+0.7)
        z2 <== ((-3.7)-y+0.7)
        print.cccc (I 941) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 942
        !"test942"
        z1 <== p*(-p)-2.0*q+(-8.1)-(-q)*6.7*8.0+(-p)-((-p)/(3.5*(-8.5)-(-2.5))*(4.1-(-q)-q*(-p)+8.5)-(-q))
        z2 <== x*(-x)-2.0*y+(-8.1)-(-y)*6.7*8.0+(-x)-((-x)/(3.5*(-8.5)-(-2.5))*(4.1-(-y)-y*(-x)+8.5)-(-y))
        print.cccc (I 942) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 943
        !"test943"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 943) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 944
        !"test944"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 944) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 945
        !"test945"
        z1 <== ((-2.8)/(p-q-(q*(-0.6))*(p-q*(-q)+(-7.2)/p)-(-p))/((2.6/(-1.0)*(-3.2)*(-8.7))-(-1.4)+(-p)+(-q)-2.8+(-3.4)*(-q)/(-q)*p)*(-3.1)*p)
        z2 <== ((-2.8)/(x-y-(y*(-0.6))*(x-y*(-y)+(-7.2)/x)-(-x))/((2.6/(-1.0)*(-3.2)*(-8.7))-(-1.4)+(-x)+(-y)-2.8+(-3.4)*(-y)/(-y)*x)*(-3.1)*x)
        print.cccc (I 945) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 946
        !"test946"
        z1 <== (((-8.7)+(5.5/p-q/(-p))-(-0.8))+(-p)+7.2)
        z2 <== (((-8.7)+(5.5/x-y/(-x))-(-0.8))+(-x)+7.2)
        print.cccc (I 946) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 947
        !"test947"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 947) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 948
        !"test948"
        z1 <== (((q/q*q-(-q))*((-3.0)-(-3.6))+(-8.7)-7.8)*(p*2.5*(-7.3)/5.8-(-p))+(-3.3))
        z2 <== (((y/y*y-(-y))*((-3.0)-(-3.6))+(-8.7)-7.8)*(x*2.5*(-7.3)/5.8-(-x))+(-3.3))
        print.cccc (I 948) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 949
        !"test949"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 949) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 950
        !"test950"
        z1 <== ((q*(-q)+(-8.2)+(-6.0)+(-q))+(p+((-2.8)-(-q)*3.5)+5.2+q)/(-6.5)/(-p))
        z2 <== ((y*(-y)+(-8.2)+(-6.0)+(-y))+(x+((-2.8)-(-y)*3.5)+5.2+y)/(-6.5)/(-x))
        print.cccc (I 950) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 951
        !"test951"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 951) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 952
        !"test952"
        z1 <== (8.6/((-6.7)/(-7.1)*(-0.2)*(-p))*(((-8.7)/(-q)-(-1.7))*(-q)/((-p)-5.0-p+(-1.0))/(-p))/((-p)+q/6.3-(-q))/p-q-(-p)/(-7.3)/4.8*(-q)*p/p+5.7/q+q*((-4.6)/(-8.3)+q)-(q+q*(-2.0)))
        z2 <== (8.6/((-6.7)/(-7.1)*(-0.2)*(-x))*(((-8.7)/(-y)-(-1.7))*(-y)/((-x)-5.0-x+(-1.0))/(-x))/((-x)+y/6.3-(-y))/x-y-(-x)/(-7.3)/4.8*(-y)*x/x+5.7/y+y*((-4.6)/(-8.3)+y)-(y+y*(-2.0)))
        print.cccc (I 952) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 953
        !"test953"
        z1 <== ((-p)+(-p))
        z2 <== ((-x)+(-x))
        print.cccc (I 953) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 954
        !"test954"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 954) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 955
        !"test955"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 955) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 956
        !"test956"
        z1 <== ((-6.3)-(7.6/(-1.8)*1.5+(-3.4)-q)-q+(-2.6)/(-q)+(-7.4)+(-p)/4.1)*((6.0-(-p))*(-2.8)*p+(q))-(-q)-q*(5.7)
        z2 <== ((-6.3)-(7.6/(-1.8)*1.5+(-3.4)-y)-y+(-2.6)/(-y)+(-7.4)+(-x)/4.1)*((6.0-(-x))*(-2.8)*x+(y))-(-y)-y*(5.7)
        print.cccc (I 956) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 957
        !"test957"
        z1 <== q
        z2 <== y
        print.cccc (I 957) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 958
        !"test958"
        z1 <== (q/((1.3-p)+(-8.4))+(-q)+(-3.2)-p)
        z2 <== (y/((1.3-x)+(-8.4))+(-y)+(-3.2)-x)
        print.cccc (I 958) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 959
        !"test959"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 959) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 960
        !"test960"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 960) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 961
        !"test961"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 961) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 962
        !"test962"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 962) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 963
        !"test963"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 963) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 964
        !"test964"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 964) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 965
        !"test965"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 965) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 966
        !"test966"
        z1 <== (p*(-4.3)*5.7-2.8+1.7)*((-1.7)*2.1+4.3*4.8)-((-p)*(-q)*0.6)-(1.0+(-q)/q*8.2)+(-1.3)/((-0.7)/((-3.4)*(-8.2)+6.4/(-p))-(5.6+(-q)*q)-q)/(-2.6)+(5.1/q+p+(-6.5)+p+p/(-q)-p*p+(-6.3)-q)*(-1.7)
        z2 <== (x*(-4.3)*5.7-2.8+1.7)*((-1.7)*2.1+4.3*4.8)-((-x)*(-y)*0.6)-(1.0+(-y)/y*8.2)+(-1.3)/((-0.7)/((-3.4)*(-8.2)+6.4/(-x))-(5.6+(-y)*y)-y)/(-2.6)+(5.1/y+x+(-6.5)+x+x/(-y)-x*x+(-6.3)-y)*(-1.7)
        print.cccc (I 966) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 967
        !"test967"
        z1 <== ((-0.8)-((q*q/q/p)-((-8.4)*1.1+(-q))*(-q)*(5.6-7.5/(-4.3))/3.3+p*(-p)/(-q)/(-5.2))/(-2.4)-p/(-q))
        z2 <== ((-0.8)-((y*y/y/x)-((-8.4)*1.1+(-y))*(-y)*(5.6-7.5/(-4.3))/3.3+x*(-x)/(-y)/(-5.2))/(-2.4)-x/(-y))
        print.cccc (I 967) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 968
        !"test968"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 968) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 969
        !"test969"
        z1 <== (((p-(-8.5)*q)+(-0.6)+(-q)/((-p)+(-4.3)*p)*((-p)*3.3+3.4*q+(-q)))-5.2+(p+(3.2-(-q)+(-q))+p))
        z2 <== (((x-(-8.5)*y)+(-0.6)+(-y)/((-x)+(-4.3)*x)*((-x)*3.3+3.4*y+(-y)))-5.2+(x+(3.2-(-y)+(-y))+x))
        print.cccc (I 969) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 970
        !"test970"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 970) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 971
        !"test971"
        z1 <== q
        z2 <== y
        print.cccc (I 971) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 972
        !"test972"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 972) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 973
        !"test973"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 973) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 974
        !"test974"
        z1 <== (-6.8)
        z2 <== (-6.8)
        print.cccc (I 974) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 975
        !"test975"
        z1 <== (2.0/q+(-8.7)+8.3)
        z2 <== (2.0/y+(-8.7)+8.3)
        print.cccc (I 975) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 976
        !"test976"
        z1 <== (6.5)
        z2 <== (6.5)
        print.cccc (I 976) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 977
        !"test977"
        z1 <== (6.8)
        z2 <== (6.8)
        print.cccc (I 977) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 978
        !"test978"
        z1 <== q
        z2 <== y
        print.cccc (I 978) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 979
        !"test979"
        z1 <== ((-q)+((-8.0)*((-1.0))/(6.2-(-q)-(-4.8))*(6.3+q*(-p))))
        z2 <== ((-y)+((-8.0)*((-1.0))/(6.2-(-y)-(-4.8))*(6.3+y*(-x))))
        print.cccc (I 979) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 980
        !"test980"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 980) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 981
        !"test981"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 981) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 982
        !"test982"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 982) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 983
        !"test983"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 983) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 984
        !"test984"
        z1 <== 6.1
        z2 <== 6.1
        print.cccc (I 984) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 985
        !"test985"
        z1 <== p
        z2 <== x
        print.cccc (I 985) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 986
        !"test986"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 986) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 987
        !"test987"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 987) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 988
        !"test988"
        z1 <== (-5.2)
        z2 <== (-5.2)
        print.cccc (I 988) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 989
        !"test989"
        z1 <== (((-2.4)-p+(p/q*5.3*(-2.1)+(-q))/2.6)/p+(-p)-(((-1.7))+((-q)+q)-(-p)/1.0+((-q)*(-0.8)*6.1*5.8))+(1.6*((-8.2))))
        z2 <== (((-2.4)-x+(x/y*5.3*(-2.1)+(-y))/2.6)/x+(-x)-(((-1.7))+((-y)+y)-(-x)/1.0+((-y)*(-0.8)*6.1*5.8))+(1.6*((-8.2))))
        print.cccc (I 989) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 990
        !"test990"
        z1 <== q
        z2 <== y
        print.cccc (I 990) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 991
        !"test991"
        z1 <== ((0.5*q*q-q)/((7.1*(-p))*q*0.3*((-4.6)/(-q)-(-7.0)*(-3.1)*0.5)+(-p))/(q+q))
        z2 <== ((0.5*y*y-y)/((7.1*(-x))*y*0.3*((-4.6)/(-y)-(-7.0)*(-3.1)*0.5)+(-x))/(y+y))
        print.cccc (I 991) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 992
        !"test992"
        z1 <== ((-q)-(7.3-((-4.8)+8.0))*(p-(-7.4)*((-3.2)*7.4-(-p)+(-q)*(-5.3))-0.0)*(-0.5))
        z2 <== ((-y)-(7.3-((-4.8)+8.0))*(x-(-7.4)*((-3.2)*7.4-(-x)+(-y)*(-5.3))-0.0)*(-0.5))
        print.cccc (I 992) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 993
        !"test993"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 993) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 994
        !"test994"
        z1 <== p
        z2 <== x
        print.cccc (I 994) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 995
        !"test995"
        z1 <== ((-p)/(4.6+(-p)+((-0.3)))*(-1.4)-(-q)/6.0*(-1.1))
        z2 <== ((-x)/(4.6+(-x)+((-0.3)))*(-1.4)-(-y)/6.0*(-1.1))
        print.cccc (I 995) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 996
        !"test996"
        z1 <== ((((-7.8)+8.0-(-5.5))+((-q)/8.8)-(-p)+p/(2.0))-((-2.5)*q-((-0.7)+q-(-q)/(-4.7))/((-q))*(5.1+2.1))-((-3.5)/((-p)*0.1+(-q)-5.6)))
        z2 <== ((((-7.8)+8.0-(-5.5))+((-y)/8.8)-(-x)+x/(2.0))-((-2.5)*y-((-0.7)+y-(-y)/(-4.7))/((-y))*(5.1+2.1))-((-3.5)/((-x)*0.1+(-y)-5.6)))
        print.cccc (I 996) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 997
        !"test997"
        z1 <== ((3.7-6.7/(-q))+(-p))
        z2 <== ((3.7-6.7/(-y))+(-x))
        print.cccc (I 997) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 998
        !"test998"
        z1 <== p+(p*(-8.8)/(-8.7)+(-3.3)*(-0.4))/(-1.2)/(-q)*q
        z2 <== x+(x*(-8.8)/(-8.7)+(-3.3)*(-0.4))/(-1.2)/(-y)*y
        print.cccc (I 998) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 999
        !"test999"
        z1 <== p
        z2 <== x
        print.cccc (I 999) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1000
        !"test1000"
        z1 <== q+((-6.4))*((-q)/((-q)+(-p)+(-q)-(-6.2))/(2.8-5.8+(-p))+(-p)*p)/(-2.4)
        z2 <== y+((-6.4))*((-y)/((-y)+(-x)+(-y)-(-6.2))/(2.8-5.8+(-x))+(-x)*x)/(-2.4)
        print.cccc (I 1000) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1001
        !"test1001"
        z1 <== (((-7.5)+(1.6+(-p))))
        z2 <== (((-7.5)+(1.6+(-x))))
        print.cccc (I 1001) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1002
        !"test1002"
        z1 <== ((q-q*6.5*p+q+2.8/(-6.0))-(-q))
        z2 <== ((y-y*6.5*x+y+2.8/(-6.0))-(-y))
        print.cccc (I 1002) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1003
        !"test1003"
        z1 <== (((-3.5)*q-(-q)-q)+((-6.7)/(-7.1)/p+(-p)*3.1)*(q*4.5-(-p)))+(-2.8)/((4.5*1.7+(-6.7))-(-p)*(-6.0))
        z2 <== (((-3.5)*y-(-y)-y)+((-6.7)/(-7.1)/x+(-x)*3.1)*(y*4.5-(-x)))+(-2.8)/((4.5*1.7+(-6.7))-(-x)*(-6.0))
        print.cccc (I 1003) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1004
        !"test1004"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1004) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1005
        !"test1005"
        z1 <== (0.0+(q/(-1.3)*(-p)/(q+5.0*q)-7.2))
        z2 <== (0.0+(y/(-1.3)*(-x)/(y+5.0*y)-7.2))
        print.cccc (I 1005) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1006
        !"test1006"
        z1 <== (-q)/(((-p)-(-1.1)+(-p)))-p-7.5*6.2
        z2 <== (-y)/(((-x)-(-1.1)+(-x)))-x-7.5*6.2
        print.cccc (I 1006) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1007
        !"test1007"
        z1 <== ((q*(-q))/(-p)/((-p)))
        z2 <== ((y*(-y))/(-x)/((-x)))
        print.cccc (I 1007) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1008
        !"test1008"
        z1 <== ((-5.3)*p)
        z2 <== ((-5.3)*x)
        print.cccc (I 1008) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1009
        !"test1009"
        z1 <== ((((-q))-(-p)-((-2.1)*(-2.0)+(-0.5))*(0.6))*(-6.2)*((1.4+(-0.2))-q*((-6.2)*p))-(-p))
        z2 <== ((((-y))-(-x)-((-2.1)*(-2.0)+(-0.5))*(0.6))*(-6.2)*((1.4+(-0.2))-y*((-6.2)*x))-(-x))
        print.cccc (I 1009) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1010
        !"test1010"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 1010) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1011
        !"test1011"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 1011) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1012
        !"test1012"
        z1 <== ((-p)+p)
        z2 <== ((-x)+x)
        print.cccc (I 1012) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1013
        !"test1013"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 1013) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1014
        !"test1014"
        z1 <== (((q)-p*((-2.0)+(-7.3))*(-4.1)-q/(-4.7)/7.2*7.4)/(((-q)*(-q)*(-q)/(-8.4)*5.2)/((-8.2)+8.1-(-0.2)-6.5)+2.2+((-8.6)-(-3.3)*(-p))-(-p)+p/8.3*(-5.0))*(-8.3))
        z2 <== (((y)-x*((-2.0)+(-7.3))*(-4.1)-y/(-4.7)/7.2*7.4)/(((-y)*(-y)*(-y)/(-8.4)*5.2)/((-8.2)+8.1-(-0.2)-6.5)+2.2+((-8.6)-(-3.3)*(-x))-(-x)+x/8.3*(-5.0))*(-8.3))
        print.cccc (I 1014) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1015
        !"test1015"
        z1 <== ((-5.7)/(-q))
        z2 <== ((-5.7)/(-y))
        print.cccc (I 1015) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1016
        !"test1016"
        z1 <== (((-p)-q/(-6.7)/((-q)-(-4.3)/(-p)+(-p)/(-6.6)))+((p/q*(-6.0)+(-8.4))))
        z2 <== (((-x)-y/(-6.7)/((-y)-(-4.3)/(-x)+(-x)/(-6.6)))+((x/y*(-6.0)+(-8.4))))
        print.cccc (I 1016) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1017
        !"test1017"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 1017) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1018
        !"test1018"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1018) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1019
        !"test1019"
        z1 <== p
        z2 <== x
        print.cccc (I 1019) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1020
        !"test1020"
        z1 <== ((-q)*((-1.7)*(-8.6)*(-5.8)-(-q))*((-4.6)/5.7)-(p-(-8.2)/(-q))+(4.3/5.1*p/3.2*(-q)-(-p)*(-p)+8.4)-(0.7+4.4/(-q)+(-6.7)*(-q)/p*(-3.7)+(-5.6)+(-q))*8.8)
        z2 <== ((-y)*((-1.7)*(-8.6)*(-5.8)-(-y))*((-4.6)/5.7)-(x-(-8.2)/(-y))+(4.3/5.1*x/3.2*(-y)-(-x)*(-x)+8.4)-(0.7+4.4/(-y)+(-6.7)*(-y)/x*(-3.7)+(-5.6)+(-y))*8.8)
        print.cccc (I 1020) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1021
        !"test1021"
        z1 <== ((((-2.5)*4.1)*(-q))*p)
        z2 <== ((((-2.5)*4.1)*(-y))*x)
        print.cccc (I 1021) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1022
        !"test1022"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 1022) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1023
        !"test1023"
        z1 <== (8.3*p/((-2.4)/2.3-((-q)+(-5.2)+(-0.0)*2.4+p)+(8.4+(-6.7)/q*(-p))))
        z2 <== (8.3*x/((-2.4)/2.3-((-y)+(-5.2)+(-0.0)*2.4+x)+(8.4+(-6.7)/y*(-x))))
        print.cccc (I 1023) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1024
        !"test1024"
        z1 <== p
        z2 <== x
        print.cccc (I 1024) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1025
        !"test1025"
        z1 <== (p/(-q)/(-p)/(3.6-((-5.4)+6.0+6.0/q*(-0.8)))/(((-q)+(-q)-(-q)-(-3.1))-p*(1.1)))
        z2 <== (x/(-y)/(-x)/(3.6-((-5.4)+6.0+6.0/y*(-0.8)))/(((-y)+(-y)-(-y)-(-3.1))-x*(1.1)))
        print.cccc (I 1025) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1026
        !"test1026"
        z1 <== (((q*(-q)-(-6.5))/(p-q-q+(-5.8)+(-5.0))*(-2.5))-(-8.7)+((-p))+6.7+q*(-4.7))
        z2 <== (((y*(-y)-(-6.5))/(x-y-y+(-5.8)+(-5.0))*(-2.5))-(-8.7)+((-x))+6.7+y*(-4.7))
        print.cccc (I 1026) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1027
        !"test1027"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 1027) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1028
        !"test1028"
        z1 <== (p*p+((-2.8)-(-3.0)/q-2.1*(-p))*q+(((-q)+(-p)/(-q))/(p/p-3.8+q)*3.4+0.7*((-q)/7.0*p*q)))
        z2 <== (x*x+((-2.8)-(-3.0)/y-2.1*(-x))*y+(((-y)+(-x)/(-y))/(x/x-3.8+y)*3.4+0.7*((-y)/7.0*x*y)))
        print.cccc (I 1028) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1029
        !"test1029"
        z1 <== ((-q)/(-5.0)/(q-(-p))-(-p))
        z2 <== ((-y)/(-5.0)/(y-(-x))-(-x))
        print.cccc (I 1029) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1030
        !"test1030"
        z1 <== ((((-p)/(-0.8)))+(q/(-2.7)-p)-q)
        z2 <== ((((-x)/(-0.8)))+(y/(-2.7)-x)-y)
        print.cccc (I 1030) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1031
        !"test1031"
        z1 <== (((-p)*(p/p)/((-2.2)-(-p)*(-q)-(-p)+q)*(-0.5)+2.6))
        z2 <== (((-x)*(x/x)/((-2.2)-(-x)*(-y)-(-x)+y)*(-0.5)+2.6))
        print.cccc (I 1031) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1032
        !"test1032"
        z1 <== (-3.7)
        z2 <== (-3.7)
        print.cccc (I 1032) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1033
        !"test1033"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1033) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1034
        !"test1034"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 1034) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1035
        !"test1035"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1035) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1036
        !"test1036"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1036) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1037
        !"test1037"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 1037) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1038
        !"test1038"
        z1 <== ((((-p)*(-0.6)/6.7+7.5/(-7.6))))
        z2 <== ((((-x)*(-0.6)/6.7+7.5/(-7.6))))
        print.cccc (I 1038) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1039
        !"test1039"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 1039) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1040
        !"test1040"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 1040) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1041
        !"test1041"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 1041) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1042
        !"test1042"
        z1 <== (0.2)
        z2 <== (0.2)
        print.cccc (I 1042) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1043
        !"test1043"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 1043) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1044
        !"test1044"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1044) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1045
        !"test1045"
        z1 <== (p-((q*6.2)/p/((-4.2)*q*2.5)*p/((-p)+(-p))))
        z2 <== (x-((y*6.2)/x/((-4.2)*y*2.5)*x/((-x)+(-x))))
        print.cccc (I 1045) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1046
        !"test1046"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1046) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1047
        !"test1047"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 1047) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1048
        !"test1048"
        z1 <== ((-q)/(p/1.0))
        z2 <== ((-y)/(x/1.0))
        print.cccc (I 1048) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1049
        !"test1049"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1049) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1050
        !"test1050"
        z1 <== (-q)*1.7/((4.4+8.1-(-q)-7.7)/p)
        z2 <== (-y)*1.7/((4.4+8.1-(-y)-7.7)/x)
        print.cccc (I 1050) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1051
        !"test1051"
        z1 <== ((-q)/((-p)*(p/(-3.5)+q/(-0.1)))*((-p)/(-2.1)+(-4.8)*(-p)/((-q)/(-6.0))-3.3+(5.5/2.7/(-q)))/(-q)/((-8.3)-q+(1.8/(-p)/2.2)))
        z2 <== ((-y)/((-x)*(x/(-3.5)+y/(-0.1)))*((-x)/(-2.1)+(-4.8)*(-x)/((-y)/(-6.0))-3.3+(5.5/2.7/(-y)))/(-y)/((-8.3)-y+(1.8/(-x)/2.2)))
        print.cccc (I 1051) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1052
        !"test1052"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1052) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1053
        !"test1053"
        z1 <== p
        z2 <== x
        print.cccc (I 1053) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1054
        !"test1054"
        z1 <== ((p/6.6/(0.3/(-4.1)*(-4.5))-((-5.7)+(-8.5)/(-p))))
        z2 <== ((x/6.6/(0.3/(-4.1)*(-4.5))-((-5.7)+(-8.5)/(-x))))
        print.cccc (I 1054) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1055
        !"test1055"
        z1 <== ((q*(-4.6)-(-4.0)*(-1.0)+(-3.2))-(-q)*4.6+2.0+7.2+(-4.6)+7.7)
        z2 <== ((y*(-4.6)-(-4.0)*(-1.0)+(-3.2))-(-y)*4.6+2.0+7.2+(-4.6)+7.7)
        print.cccc (I 1055) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1056
        !"test1056"
        z1 <== (((-0.3)+6.8)-(-p))/7.8+(q+(q)*(0.7-p+(-q)/(-q)-(-3.2)))/q/((q)/(1.3*7.0*q+(-6.3)))
        z2 <== (((-0.3)+6.8)-(-x))/7.8+(y+(y)*(0.7-x+(-y)/(-y)-(-3.2)))/y/((y)/(1.3*7.0*y+(-6.3)))
        print.cccc (I 1056) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1057
        !"test1057"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 1057) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1058
        !"test1058"
        z1 <== (1.5-5.8)
        z2 <== (1.5-5.8)
        print.cccc (I 1058) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1059
        !"test1059"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1059) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1060
        !"test1060"
        z1 <== (1.1/(-2.3))
        z2 <== (1.1/(-2.3))
        print.cccc (I 1060) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1061
        !"test1061"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1061) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1062
        !"test1062"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 1062) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1063
        !"test1063"
        z1 <== (((-q)))
        z2 <== (((-y)))
        print.cccc (I 1063) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1064
        !"test1064"
        z1 <== (((p+(-q)+(-2.6)/(-2.0))-q/8.0+(-2.1))*((5.8+(-0.3)*0.4/(-q))-q-((-4.2)+(-6.8)/2.6-(-1.0)/(-q))-((-1.2)*(-0.7)*(-1.2)))-((-8.8))+(-0.4)*(p/q-q/p-5.4)/(-4.6)+(-p))
        z2 <== (((x+(-y)+(-2.6)/(-2.0))-y/8.0+(-2.1))*((5.8+(-0.3)*0.4/(-y))-y-((-4.2)+(-6.8)/2.6-(-1.0)/(-y))-((-1.2)*(-0.7)*(-1.2)))-((-8.8))+(-0.4)*(x/y-y/x-5.4)/(-4.6)+(-x))
        print.cccc (I 1064) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1065
        !"test1065"
        z1 <== ((p)/(-p)/(-q)*p+4.8+((-5.6)*1.4/(-p)/(-p)))/(-8.6)/q-q-3.6+((-2.2)+2.8)
        z2 <== ((x)/(-x)/(-y)*x+4.8+((-5.6)*1.4/(-x)/(-x)))/(-8.6)/y-y-3.6+((-2.2)+2.8)
        print.cccc (I 1065) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1066
        !"test1066"
        z1 <== (7.6-(-0.3))
        z2 <== (7.6-(-0.3))
        print.cccc (I 1066) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1067
        !"test1067"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 1067) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1068
        !"test1068"
        z1 <== ((-1.0))
        z2 <== ((-1.0))
        print.cccc (I 1068) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1069
        !"test1069"
        z1 <== (q+p)
        z2 <== (y+x)
        print.cccc (I 1069) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1070
        !"test1070"
        z1 <== q
        z2 <== y
        print.cccc (I 1070) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1071
        !"test1071"
        z1 <== ((q/((-8.1))-(-p))-p+q/2.6/(((-p)*(-p)+3.1-7.2)+(p)/(8.8/p/q*(-p)-(-8.7))-(-4.5)*q+(-p)+(-p)))
        z2 <== ((y/((-8.1))-(-x))-x+y/2.6/(((-x)*(-x)+3.1-7.2)+(x)/(8.8/x/y*(-x)-(-8.7))-(-4.5)*y+(-x)+(-x)))
        print.cccc (I 1071) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1072
        !"test1072"
        z1 <== q
        z2 <== y
        print.cccc (I 1072) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1073
        !"test1073"
        z1 <== (-7.4)-((-q)-(5.0)-3.6+(7.6*5.3*1.0/4.3/(-2.7))-(2.0+(-p)+(-p)-(-2.3)+1.4))-(-0.4)
        z2 <== (-7.4)-((-y)-(5.0)-3.6+(7.6*5.3*1.0/4.3/(-2.7))-(2.0+(-x)+(-x)-(-2.3)+1.4))-(-0.4)
        print.cccc (I 1073) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1074
        !"test1074"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1074) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1075
        !"test1075"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 1075) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1076
        !"test1076"
        z1 <== (q+((-0.4)/(-6.0)*1.2-(-2.3)+8.5)/p*(-q)/8.6-(1.0-q)+(-4.8)*(-q)/((-0.1)-(-q)*(p-(-q)+(-1.6))+(q)))
        z2 <== (y+((-0.4)/(-6.0)*1.2-(-2.3)+8.5)/x*(-y)/8.6-(1.0-y)+(-4.8)*(-y)/((-0.1)-(-y)*(x-(-y)+(-1.6))+(y)))
        print.cccc (I 1076) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1077
        !"test1077"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 1077) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1078
        !"test1078"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 1078) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1079
        !"test1079"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 1079) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1080
        !"test1080"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 1080) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1081
        !"test1081"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 1081) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1082
        !"test1082"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 1082) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1083
        !"test1083"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 1083) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1084
        !"test1084"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1084) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1085
        !"test1085"
        z1 <== (((-7.1)*q-(-p)+p/5.4-3.8*3.8))
        z2 <== (((-7.1)*y-(-x)+x/5.4-3.8*3.8))
        print.cccc (I 1085) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1086
        !"test1086"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 1086) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1087
        !"test1087"
        z1 <== (6.7+(-7.6))
        z2 <== (6.7+(-7.6))
        print.cccc (I 1087) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1088
        !"test1088"
        z1 <== (1.0+(q/(-0.1))*(-q)-(-5.4)-6.8)
        z2 <== (1.0+(y/(-0.1))*(-y)-(-5.4)-6.8)
        print.cccc (I 1088) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1089
        !"test1089"
        z1 <== ((-8.1)+8.1+((-q)))
        z2 <== ((-8.1)+8.1+((-y)))
        print.cccc (I 1089) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1090
        !"test1090"
        z1 <== q
        z2 <== y
        print.cccc (I 1090) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1091
        !"test1091"
        z1 <== q
        z2 <== y
        print.cccc (I 1091) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1092
        !"test1092"
        z1 <== (q+(-p)-(5.7)*(-p))
        z2 <== (y+(-x)-(5.7)*(-x))
        print.cccc (I 1092) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1093
        !"test1093"
        z1 <== (p*q*(-p)-(-p)*(p*(-p)))
        z2 <== (x*y*(-x)-(-x)*(x*(-x)))
        print.cccc (I 1093) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1094
        !"test1094"
        z1 <== ((-1.6)/7.5*(4.5-q*((-p)*5.2+p+(-1.6)+q)*(-7.7)-(-q)+(-p)-(-6.4))-(-0.7)-(p-(-1.7)/q/(-4.7))*3.7+(-4.0)+3.6-q+8.3+5.0-6.2)
        z2 <== ((-1.6)/7.5*(4.5-y*((-x)*5.2+x+(-1.6)+y)*(-7.7)-(-y)+(-x)-(-6.4))-(-0.7)-(x-(-1.7)/y/(-4.7))*3.7+(-4.0)+3.6-y+8.3+5.0-6.2)
        print.cccc (I 1094) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1095
        !"test1095"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1095) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1096
        !"test1096"
        z1 <== 8.1
        z2 <== 8.1
        print.cccc (I 1096) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1097
        !"test1097"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1097) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1098
        !"test1098"
        z1 <== ((q*p-(-6.4)/8.3+3.5)/((-4.4))-(q*(-6.1)*(-q))+q)-q/((-p)-(-p)*6.5/q-6.8)
        z2 <== ((y*x-(-6.4)/8.3+3.5)/((-4.4))-(y*(-6.1)*(-y))+y)-y/((-x)-(-x)*6.5/y-6.8)
        print.cccc (I 1098) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1099
        !"test1099"
        z1 <== ((6.0*6.5-(-8.1)*(-q)*(-6.4)-(q)))
        z2 <== ((6.0*6.5-(-8.1)*(-y)*(-6.4)-(y)))
        print.cccc (I 1099) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1100
        !"test1100"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 1100) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1101
        !"test1101"
        z1 <== (3.0/0.8-(((-5.1)+5.3/(-p))/5.2-(-5.1)*q+(-8.0)*(-0.2)*((-2.6)*p-(-q)*(-q)))/(8.3/p-(-q)-((-q)/(-q))/(4.3/(-4.6)*5.7))*(3.5/(3.2)+(-6.0)-(-p)-5.8))
        z2 <== (3.0/0.8-(((-5.1)+5.3/(-x))/5.2-(-5.1)*y+(-8.0)*(-0.2)*((-2.6)*x-(-y)*(-y)))/(8.3/x-(-y)-((-y)/(-y))/(4.3/(-4.6)*5.7))*(3.5/(3.2)+(-6.0)-(-x)-5.8))
        print.cccc (I 1101) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1102
        !"test1102"
        z1 <== ((((-1.4)*p)*(q+q-p)/(-q))-((-7.8)-(p/(-8.6)*(-8.1)*p-1.1)*5.4*p-q)+p*(6.0*(-q)))
        z2 <== ((((-1.4)*x)*(y+y-x)/(-y))-((-7.8)-(x/(-8.6)*(-8.1)*x-1.1)*5.4*x-y)+x*(6.0*(-y)))
        print.cccc (I 1102) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1103
        !"test1103"
        z1 <== ((((-q)/7.2-(-1.1)*q)*0.8)/(-4.0)*(-p))
        z2 <== ((((-y)/7.2-(-1.1)*y)*0.8)/(-4.0)*(-x))
        print.cccc (I 1103) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1104
        !"test1104"
        z1 <== (p*(-p)*(-p))
        z2 <== (x*(-x)*(-x))
        print.cccc (I 1104) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1105
        !"test1105"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1105) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1106
        !"test1106"
        z1 <== ((p-(-5.8)+(-3.4)/(-1.1)*2.7))-((-p)+q)+(-0.5)+(7.8-(-p)-((-7.3)/p*(-5.0)-(-3.4))-7.2-3.3-(-7.2)-5.4+p/(-8.0))
        z2 <== ((x-(-5.8)+(-3.4)/(-1.1)*2.7))-((-x)+y)+(-0.5)+(7.8-(-x)-((-7.3)/x*(-5.0)-(-3.4))-7.2-3.3-(-7.2)-5.4+x/(-8.0))
        print.cccc (I 1106) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1107
        !"test1107"
        z1 <== (((5.1*q/0.2-q/(-0.2))*1.6-(-4.4))+(-8.0))
        z2 <== (((5.1*y/0.2-y/(-0.2))*1.6-(-4.4))+(-8.0))
        print.cccc (I 1107) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1108
        !"test1108"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 1108) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1109
        !"test1109"
        z1 <== (q-q/(-8.7)*((-q)+(-2.4)-(-p))*(-3.3))
        z2 <== (y-y/(-8.7)*((-y)+(-2.4)-(-x))*(-3.3))
        print.cccc (I 1109) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1110
        !"test1110"
        z1 <== ((((-7.7)+(-2.6)/5.7/(-p)))+(-q))
        z2 <== ((((-7.7)+(-2.6)/5.7/(-x)))+(-y))
        print.cccc (I 1110) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1111
        !"test1111"
        z1 <== q
        z2 <== y
        print.cccc (I 1111) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1112
        !"test1112"
        z1 <== p
        z2 <== x
        print.cccc (I 1112) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1113
        !"test1113"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 1113) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1114
        !"test1114"
        z1 <== (((-4.7)*3.1*(-q)+(-4.0)-(-p))-q)
        z2 <== (((-4.7)*3.1*(-y)+(-4.0)-(-x))-y)
        print.cccc (I 1114) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1115
        !"test1115"
        z1 <== (-4.8)-6.6*p-(-p)
        z2 <== (-4.8)-6.6*x-(-x)
        print.cccc (I 1115) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1116
        !"test1116"
        z1 <== ((p/(-p)+((-p)-q)))
        z2 <== ((x/(-x)+((-x)-y)))
        print.cccc (I 1116) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1117
        !"test1117"
        z1 <== ((-p)/((-q)*(-4.8)*q*(-3.5)-(-1.3)))
        z2 <== ((-x)/((-y)*(-4.8)*y*(-3.5)-(-1.3)))
        print.cccc (I 1117) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1118
        !"test1118"
        z1 <== p
        z2 <== x
        print.cccc (I 1118) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1119
        !"test1119"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1119) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1120
        !"test1120"
        z1 <== p
        z2 <== x
        print.cccc (I 1120) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1121
        !"test1121"
        z1 <== (p-(4.0*p/6.6)-0.4/(-8.7)+((-6.6))/(-4.0)*(-p))
        z2 <== (x-(4.0*x/6.6)-0.4/(-8.7)+((-6.6))/(-4.0)*(-x))
        print.cccc (I 1121) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1122
        !"test1122"
        z1 <== q
        z2 <== y
        print.cccc (I 1122) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1123
        !"test1123"
        z1 <== p
        z2 <== x
        print.cccc (I 1123) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1124
        !"test1124"
        z1 <== ((-5.2)/(-1.0)*p+(-4.4))
        z2 <== ((-5.2)/(-1.0)*x+(-4.4))
        print.cccc (I 1124) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1125
        !"test1125"
        z1 <== ((-7.7)+((q+q-(-p)+(-7.0))+(-p)/(q/(-6.5))+q))
        z2 <== ((-7.7)+((y+y-(-x)+(-7.0))+(-x)/(y/(-6.5))+y))
        print.cccc (I 1125) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1126
        !"test1126"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1126) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1127
        !"test1127"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 1127) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1128
        !"test1128"
        z1 <== ((7.7/q)/((-p)-(6.6*6.8)+(-p)/q-(3.6+6.0+(-1.7)+1.2)))
        z2 <== ((7.7/y)/((-x)-(6.6*6.8)+(-x)/y-(3.6+6.0+(-1.7)+1.2)))
        print.cccc (I 1128) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1129
        !"test1129"
        z1 <== ((((-6.1)*(-0.0)-0.4)*(q/(-p)/3.6))*5.3/p*(-6.2)-p+((-p)-(-0.4)))
        z2 <== ((((-6.1)*(-0.0)-0.4)*(y/(-x)/3.6))*5.3/x*(-6.2)-x+((-x)-(-0.4)))
        print.cccc (I 1129) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1130
        !"test1130"
        z1 <== 1.7
        z2 <== 1.7
        print.cccc (I 1130) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1131
        !"test1131"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1131) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1132
        !"test1132"
        z1 <== ((0.0))
        z2 <== ((0.0))
        print.cccc (I 1132) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1133
        !"test1133"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 1133) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1134
        !"test1134"
        z1 <== ((4.4+(-2.6)-((-3.8)-(-0.8)*(-2.7)/8.2)*(-q)))
        z2 <== ((4.4+(-2.6)-((-3.8)-(-0.8)*(-2.7)/8.2)*(-y)))
        print.cccc (I 1134) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1135
        !"test1135"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1135) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1136
        !"test1136"
        z1 <== ((-p)*(-3.4))/(-q)*7.6+(p-2.4+(p/p+8.1/6.1)+1.4*(-2.7))
        z2 <== ((-x)*(-3.4))/(-y)*7.6+(x-2.4+(x/x+8.1/6.1)+1.4*(-2.7))
        print.cccc (I 1136) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1137
        !"test1137"
        z1 <== ((((-p))+((-p)+(-1.7)*p/(-6.1))-(5.4)/p/7.5)-(((-q))/(-8.3)-(q*q*q+(-p)+(-6.0))-2.5/((-q)/5.8/0.1))+(-0.4)+(7.7/7.6-(-5.3)*(-q)-7.8)*(q*(-q)-(-q)/1.0))
        z2 <== ((((-x))+((-x)+(-1.7)*x/(-6.1))-(5.4)/x/7.5)-(((-y))/(-8.3)-(y*y*y+(-x)+(-6.0))-2.5/((-y)/5.8/0.1))+(-0.4)+(7.7/7.6-(-5.3)*(-y)-7.8)*(y*(-y)-(-y)/1.0))
        print.cccc (I 1137) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1138
        !"test1138"
        z1 <== q
        z2 <== y
        print.cccc (I 1138) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1139
        !"test1139"
        z1 <== ((-4.3)-(p-q/q)-1.1)
        z2 <== ((-4.3)-(x-y/y)-1.1)
        print.cccc (I 1139) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1140
        !"test1140"
        z1 <== p
        z2 <== x
        print.cccc (I 1140) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1141
        !"test1141"
        z1 <== (q-(p*(6.6*0.3)*((-q)+2.6)))
        z2 <== (y-(x*(6.6*0.3)*((-y)+2.6)))
        print.cccc (I 1141) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1142
        !"test1142"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1142) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1143
        !"test1143"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 1143) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1144
        !"test1144"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1144) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1145
        !"test1145"
        z1 <== ((((-1.3))/p-(-q)))
        z2 <== ((((-1.3))/x-(-y)))
        print.cccc (I 1145) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1146
        !"test1146"
        z1 <== q
        z2 <== y
        print.cccc (I 1146) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1147
        !"test1147"
        z1 <== ((((-2.2)))+(-5.8))
        z2 <== ((((-2.2)))+(-5.8))
        print.cccc (I 1147) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1148
        !"test1148"
        z1 <== ((-8.2))
        z2 <== ((-8.2))
        print.cccc (I 1148) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1149
        !"test1149"
        z1 <== p
        z2 <== x
        print.cccc (I 1149) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1150
        !"test1150"
        z1 <== (4.3*(-p)/((-p)*(-5.2)/(-3.1)+q-p)/(-q)-(((-p)-(-p)+(-3.1))))
        z2 <== (4.3*(-x)/((-x)*(-5.2)/(-3.1)+y-x)/(-y)-(((-x)-(-x)+(-3.1))))
        print.cccc (I 1150) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1151
        !"test1151"
        z1 <== (2.8/4.3/(-7.5)*6.3-(-q)*8.0*(2.2-p+p-p)-(6.0)+(-p)+(8.1+1.7-p+(-3.1)+(-3.1))+((-3.7)/(-1.1)+0.4/(-8.3))/q*(-1.2)+5.0-(-6.2)+(-8.2))
        z2 <== (2.8/4.3/(-7.5)*6.3-(-y)*8.0*(2.2-x+x-x)-(6.0)+(-x)+(8.1+1.7-x+(-3.1)+(-3.1))+((-3.7)/(-1.1)+0.4/(-8.3))/y*(-1.2)+5.0-(-6.2)+(-8.2))
        print.cccc (I 1151) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1152
        !"test1152"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 1152) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1153
        !"test1153"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1153) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1154
        !"test1154"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 1154) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1155
        !"test1155"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1155) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1156
        !"test1156"
        z1 <== (((-6.0)+(-p)/(-p)))
        z2 <== (((-6.0)+(-x)/(-x)))
        print.cccc (I 1156) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1157
        !"test1157"
        z1 <== (p*((-5.2)/((-q)/0.7+(-q)+8.2/(-4.3)))-7.6*4.7*(((-q))))
        z2 <== (x*((-5.2)/((-y)/0.7+(-y)+8.2/(-4.3)))-7.6*4.7*(((-y))))
        print.cccc (I 1157) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1158
        !"test1158"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1158) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1159
        !"test1159"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1159) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1160
        !"test1160"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 1160) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1161
        !"test1161"
        z1 <== ((-p)*(-p)+(3.5/(-8.3)/(1.6*7.5+p/0.0)+(-8.7)))
        z2 <== ((-x)*(-x)+(3.5/(-8.3)/(1.6*7.5+x/0.0)+(-8.7)))
        print.cccc (I 1161) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1162
        !"test1162"
        z1 <== ((-6.5)+((-q))*2.7-((-p)-1.7/(-q))+(-q))
        z2 <== ((-6.5)+((-y))*2.7-((-x)-1.7/(-y))+(-y))
        print.cccc (I 1162) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1163
        !"test1163"
        z1 <== ((-3.2)+((-q)-7.6-(-7.7)-1.5-q)/(-3.0)/(q-3.2/2.7-3.4-4.4*(6.8*(-2.4)+(-2.6)-(-p)+6.7)-((-p))+(q)*(-p))*((p/(-p)+(-q)))/q)
        z2 <== ((-3.2)+((-y)-7.6-(-7.7)-1.5-y)/(-3.0)/(y-3.2/2.7-3.4-4.4*(6.8*(-2.4)+(-2.6)-(-x)+6.7)-((-x))+(y)*(-x))*((x/(-x)+(-y)))/y)
        print.cccc (I 1163) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1164
        !"test1164"
        z1 <== ((-8.6)-(-7.7)+(-2.1))
        z2 <== ((-8.6)-(-7.7)+(-2.1))
        print.cccc (I 1164) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1165
        !"test1165"
        z1 <== (q+((2.1*1.2+p-q-(-1.0))*(-0.6)+(-0.7)+p*(-5.3)/((-6.1)*(-p)-(-0.7)-8.7*8.3)/q)-p/((q)))
        z2 <== (y+((2.1*1.2+x-y-(-1.0))*(-0.6)+(-0.7)+x*(-5.3)/((-6.1)*(-x)-(-0.7)-8.7*8.3)/y)-x/((y)))
        print.cccc (I 1165) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1166
        !"test1166"
        z1 <== p
        z2 <== x
        print.cccc (I 1166) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1167
        !"test1167"
        z1 <== p
        z2 <== x
        print.cccc (I 1167) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1168
        !"test1168"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1168) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1169
        !"test1169"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 1169) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1170
        !"test1170"
        z1 <== (((-p)/(-p)+q*4.1)-(-p)*(-6.0)/4.7)
        z2 <== (((-x)/(-x)+y*4.1)-(-x)*(-6.0)/4.7)
        print.cccc (I 1170) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1171
        !"test1171"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1171) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1172
        !"test1172"
        z1 <== ((-7.4))
        z2 <== ((-7.4))
        print.cccc (I 1172) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1173
        !"test1173"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 1173) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1174
        !"test1174"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 1174) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1175
        !"test1175"
        z1 <== (6.4-(-q)+(q)*(p/q*(-2.3)+(-6.3))-p)
        z2 <== (6.4-(-y)+(y)*(x/y*(-2.3)+(-6.3))-x)
        print.cccc (I 1175) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1176
        !"test1176"
        z1 <== (((p*2.0)/(-q)+p+0.4/(-3.8)+(-2.1))/7.5+(-2.5))
        z2 <== (((x*2.0)/(-y)+x+0.4/(-3.8)+(-2.1))/7.5+(-2.5))
        print.cccc (I 1176) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1177
        !"test1177"
        z1 <== ((-q)*1.1-((-6.6)*(-q)*(-2.1))-(-p)/(((-1.1)*(-p)-p+(-4.8)-(-p))+q*q-7.6-p-(-p)-(p-(-3.8)+p)+(-p)))
        z2 <== ((-y)*1.1-((-6.6)*(-y)*(-2.1))-(-x)/(((-1.1)*(-x)-x+(-4.8)-(-x))+y*y-7.6-x-(-x)-(x-(-3.8)+x)+(-x)))
        print.cccc (I 1177) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1178
        !"test1178"
        z1 <== ((q+p+(-0.3)+(-8.2)))/p-2.5/(1.0/(-q)/8.2+3.1)
        z2 <== ((y+x+(-0.3)+(-8.2)))/x-2.5/(1.0/(-y)/8.2+3.1)
        print.cccc (I 1178) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1179
        !"test1179"
        z1 <== ((-6.5)/q-p/q)/8.7
        z2 <== ((-6.5)/y-x/y)/8.7
        print.cccc (I 1179) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1180
        !"test1180"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1180) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1181
        !"test1181"
        z1 <== ((((-p)*(-p))*p/(6.2*2.0+(-7.2)+8.1))-q/8.1)
        z2 <== ((((-x)*(-x))*x/(6.2*2.0+(-7.2)+8.1))-y/8.1)
        print.cccc (I 1181) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1182
        !"test1182"
        z1 <== (((4.3*p)*q*q/(2.7-(-p))*(-p))/((-4.0)-q+((-6.2)+6.0+2.0*q+6.4)+1.6*p/(-p)*2.4)-5.6-(p-(-5.8)-q+(-4.8))/((-3.4)/4.0)-(7.0)*(q/(-q)+2.7/(-5.3)-(-p)))
        z2 <== (((4.3*x)*y*y/(2.7-(-x))*(-x))/((-4.0)-y+((-6.2)+6.0+2.0*y+6.4)+1.6*x/(-x)*2.4)-5.6-(x-(-5.8)-y+(-4.8))/((-3.4)/4.0)-(7.0)*(y/(-y)+2.7/(-5.3)-(-x)))
        print.cccc (I 1182) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1183
        !"test1183"
        z1 <== p
        z2 <== x
        print.cccc (I 1183) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1184
        !"test1184"
        z1 <== p+6.4/(-q)-(((-1.1)))
        z2 <== x+6.4/(-y)-(((-1.1)))
        print.cccc (I 1184) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1185
        !"test1185"
        z1 <== ((-q)*((-q))/5.7/(p))
        z2 <== ((-y)*((-y))/5.7/(x))
        print.cccc (I 1185) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1186
        !"test1186"
        z1 <== p
        z2 <== x
        print.cccc (I 1186) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1187
        !"test1187"
        z1 <== ((-q)-(((-p)+(-q))*(-q)*(-8.4)*p)+(-q)*p+((-3.3)/p)-(p*(-q)+q*(-p)+(-q))-((6.1/p*(-q))+(2.4-(-2.6))))
        z2 <== ((-y)-(((-x)+(-y))*(-y)*(-8.4)*x)+(-y)*x+((-3.3)/x)-(x*(-y)+y*(-x)+(-y))-((6.1/x*(-y))+(2.4-(-2.6))))
        print.cccc (I 1187) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1188
        !"test1188"
        z1 <== p
        z2 <== x
        print.cccc (I 1188) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1189
        !"test1189"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 1189) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1190
        !"test1190"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 1190) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1191
        !"test1191"
        z1 <== q
        z2 <== y
        print.cccc (I 1191) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1192
        !"test1192"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 1192) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1193
        !"test1193"
        z1 <== (-1.0)
        z2 <== (-1.0)
        print.cccc (I 1193) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1194
        !"test1194"
        z1 <== p
        z2 <== x
        print.cccc (I 1194) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1195
        !"test1195"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1195) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1196
        !"test1196"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 1196) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1197
        !"test1197"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 1197) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1198
        !"test1198"
        z1 <== ((-7.8)*(-2.3)-((-q)-((-5.3))/q/6.0)+2.0/(-0.4))
        z2 <== ((-7.8)*(-2.3)-((-y)-((-5.3))/y/6.0)+2.0/(-0.4))
        print.cccc (I 1198) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1199
        !"test1199"
        z1 <== 2.7
        z2 <== 2.7
        print.cccc (I 1199) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1200
        !"test1200"
        z1 <== (((-3.3)*((-p)*p)-2.3+(-4.4)-8.0)/((6.0-(-p))+(0.3*p))-((-q)-1.8*(-6.1))*(((-q)+(-0.0)+p)/p+p+(-1.2)/(-p)-p/7.4))
        z2 <== (((-3.3)*((-x)*x)-2.3+(-4.4)-8.0)/((6.0-(-x))+(0.3*x))-((-y)-1.8*(-6.1))*(((-y)+(-0.0)+x)/x+x+(-1.2)/(-x)-x/7.4))
        print.cccc (I 1200) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1201
        !"test1201"
        z1 <== 7.6
        z2 <== 7.6
        print.cccc (I 1201) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1202
        !"test1202"
        z1 <== (q/p+(-3.8)*5.1/(2.1/(1.3/6.7/0.3-q+p)*q/(-8.4)))
        z2 <== (y/x+(-3.8)*5.1/(2.1/(1.3/6.7/0.3-y+x)*y/(-8.4)))
        print.cccc (I 1202) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1203
        !"test1203"
        z1 <== ((-q)*((-q)/(-q)-(-7.3)+(-5.8))-((-q)-((-8.1)/(-p)+(-6.6))))
        z2 <== ((-y)*((-y)/(-y)-(-7.3)+(-5.8))-((-y)-((-8.1)/(-x)+(-6.6))))
        print.cccc (I 1203) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1204
        !"test1204"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 1204) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1205
        !"test1205"
        z1 <== ((((-3.7)+(-4.4)+p+(-7.2))/(-3.8))+(-4.6))
        z2 <== ((((-3.7)+(-4.4)+x+(-7.2))/(-3.8))+(-4.6))
        print.cccc (I 1205) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1206
        !"test1206"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 1206) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1207
        !"test1207"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 1207) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1208
        !"test1208"
        z1 <== ((7.7)+q*q/(-p))
        z2 <== ((7.7)+y*y/(-x))
        print.cccc (I 1208) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1209
        !"test1209"
        z1 <== ((p+(-0.0)+2.2)-(p*(-p)/q-q+7.8)*p)-((-q))+((-p)/4.5*(3.5))
        z2 <== ((x+(-0.0)+2.2)-(x*(-x)/y-y+7.8)*x)-((-y))+((-x)/4.5*(3.5))
        print.cccc (I 1209) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1210
        !"test1210"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1210) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1211
        !"test1211"
        z1 <== 7.3-(-0.2)
        z2 <== 7.3-(-0.2)
        print.cccc (I 1211) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1212
        !"test1212"
        z1 <== (-q)+(-p)+((p-(-p)+(-p)+5.7)/(0.8)/((-2.2)-q-(-q)*8.4+(-p))/(-q)*3.3)
        z2 <== (-y)+(-x)+((x-(-x)+(-x)+5.7)/(0.8)/((-2.2)-y-(-y)*8.4+(-x))/(-y)*3.3)
        print.cccc (I 1212) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1213
        !"test1213"
        z1 <== 0.3
        z2 <== 0.3
        print.cccc (I 1213) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1214
        !"test1214"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 1214) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1215
        !"test1215"
        z1 <== (5.1)
        z2 <== (5.1)
        print.cccc (I 1215) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1216
        !"test1216"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1216) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1217
        !"test1217"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1217) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1218
        !"test1218"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 1218) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1219
        !"test1219"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 1219) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1220
        !"test1220"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 1220) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1221
        !"test1221"
        z1 <== (0.5+((-0.6)))
        z2 <== (0.5+((-0.6)))
        print.cccc (I 1221) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1222
        !"test1222"
        z1 <== ((-p)/(((-2.0)+(-p)/2.1)-(p*q+(-6.1)*(-q)*(-5.3))-7.7*0.4/(-6.8)*q+(-7.0))+8.1+(-q)+((-6.0)-p)*(6.1*(4.5*p-(-q)+q)+q/((-7.8)*p))+((-7.8)+((-7.8))-(p/(-7.6)-4.8*(-5.7))))
        z2 <== ((-x)/(((-2.0)+(-x)/2.1)-(x*y+(-6.1)*(-y)*(-5.3))-7.7*0.4/(-6.8)*y+(-7.0))+8.1+(-y)+((-6.0)-x)*(6.1*(4.5*x-(-y)+y)+y/((-7.8)*x))+((-7.8)+((-7.8))-(x/(-7.6)-4.8*(-5.7))))
        print.cccc (I 1222) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1223
        !"test1223"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1223) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1224
        !"test1224"
        z1 <== (0.5-2.7*(q/(6.4/q-5.4*q*(-p))/8.3-((-q)*(-8.2)/(-p)-(-p)+(-2.3)))-(-p)*8.8)
        z2 <== (0.5-2.7*(y/(6.4/y-5.4*y*(-x))/8.3-((-y)*(-8.2)/(-x)-(-x)+(-2.3)))-(-x)*8.8)
        print.cccc (I 1224) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1225
        !"test1225"
        z1 <== (6.4*(-p)-(-p)/(p+(-p)/1.6)*((-p))-(-1.3))
        z2 <== (6.4*(-x)-(-x)/(x+(-x)/1.6)*((-x))-(-1.3))
        print.cccc (I 1225) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1226
        !"test1226"
        z1 <== (q+((7.3+q/5.4)-q+(-q)+(-p)*8.0/(-7.1)/8.0/(-7.6)+p/(-p))-((-p)/p+(-q))*(-p)/(-q)/(-3.3)/q)
        z2 <== (y+((7.3+y/5.4)-y+(-y)+(-x)*8.0/(-7.1)/8.0/(-7.6)+x/(-x))-((-x)/x+(-y))*(-x)/(-y)/(-3.3)/y)
        print.cccc (I 1226) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1227
        !"test1227"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1227) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1228
        !"test1228"
        z1 <== q*p+p
        z2 <== y*x+x
        print.cccc (I 1228) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1229
        !"test1229"
        z1 <== q
        z2 <== y
        print.cccc (I 1229) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1230
        !"test1230"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1230) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1231
        !"test1231"
        z1 <== p
        z2 <== x
        print.cccc (I 1231) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1232
        !"test1232"
        z1 <== ((0.3/(-2.8)*8.5/(-6.2)-q)*(-1.5)*(((-3.1))*q*((-q)*(-q)+p-(-8.5)*5.3)))
        z2 <== ((0.3/(-2.8)*8.5/(-6.2)-y)*(-1.5)*(((-3.1))*y*((-y)*(-y)+x-(-8.5)*5.3)))
        print.cccc (I 1232) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1233
        !"test1233"
        z1 <== ((7.3)*(((-5.3)*6.1+7.8-6.5/(-6.6))/7.2/p*3.8/6.0)/(p/0.7/(-p)/(-q)+0.3)*q-(4.8-q)/(-8.8)/(-8.3)+((-8.0)*((-q))-(-2.2)+(3.4/5.3-(-p))))
        z2 <== ((7.3)*(((-5.3)*6.1+7.8-6.5/(-6.6))/7.2/x*3.8/6.0)/(x/0.7/(-x)/(-y)+0.3)*y-(4.8-y)/(-8.8)/(-8.3)+((-8.0)*((-y))-(-2.2)+(3.4/5.3-(-x))))
        print.cccc (I 1233) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1234
        !"test1234"
        z1 <== q
        z2 <== y
        print.cccc (I 1234) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1235
        !"test1235"
        z1 <== (((-p)*(-p)/(-6.6)+7.1)-((-2.5)/(-4.8)/p-(-p)+q))
        z2 <== (((-x)*(-x)/(-6.6)+7.1)-((-2.5)/(-4.8)/x-(-x)+y))
        print.cccc (I 1235) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1236
        !"test1236"
        z1 <== (((-p)-((-8.2))+(p))-p/(-3.5)-5.4*(-6.4)+((-6.0))-(((-5.5))*(-q)/(-p)-6.6+((-3.5)*q/(-4.8)*1.8)/(-0.4)-(-p)))
        z2 <== (((-x)-((-8.2))+(x))-x/(-3.5)-5.4*(-6.4)+((-6.0))-(((-5.5))*(-y)/(-x)-6.6+((-3.5)*y/(-4.8)*1.8)/(-0.4)-(-x)))
        print.cccc (I 1236) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1237
        !"test1237"
        z1 <== p
        z2 <== x
        print.cccc (I 1237) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1238
        !"test1238"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1238) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1239
        !"test1239"
        z1 <== (-p)/p/p-0.4*6.6+p*(-0.3)-((-1.3)+(-q))/(-7.2)/(1.8*q)*(-5.5)
        z2 <== (-x)/x/x-0.4*6.6+x*(-0.3)-((-1.3)+(-y))/(-7.2)/(1.8*y)*(-5.5)
        print.cccc (I 1239) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1240
        !"test1240"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 1240) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1241
        !"test1241"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 1241) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1242
        !"test1242"
        z1 <== (-7.7)
        z2 <== (-7.7)
        print.cccc (I 1242) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1243
        !"test1243"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 1243) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1244
        !"test1244"
        z1 <== p
        z2 <== x
        print.cccc (I 1244) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1245
        !"test1245"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 1245) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1246
        !"test1246"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 1246) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1247
        !"test1247"
        z1 <== ((((-q)/p*5.8-q)-(0.5+(-q))+(-8.3)/(-6.5)-3.0)*(1.1-p-5.5*6.0+(-p)+q)*(-2.6)+(-4.5)+5.2*4.5+5.1-(-p)*(-q)+p*(-2.2)+((0.5*p/p)))
        z2 <== ((((-y)/x*5.8-y)-(0.5+(-y))+(-8.3)/(-6.5)-3.0)*(1.1-x-5.5*6.0+(-x)+y)*(-2.6)+(-4.5)+5.2*4.5+5.1-(-x)*(-y)+x*(-2.2)+((0.5*x/x)))
        print.cccc (I 1247) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1248
        !"test1248"
        z1 <== ((-2.3)*1.3)
        z2 <== ((-2.3)*1.3)
        print.cccc (I 1248) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1249
        !"test1249"
        z1 <== ((q/(3.2-(-q)*(-q)))-(-q)/((-p)+(4.8)))
        z2 <== ((y/(3.2-(-y)*(-y)))-(-y)/((-x)+(4.8)))
        print.cccc (I 1249) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1250
        !"test1250"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1250) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1251
        !"test1251"
        z1 <== (q/((-q))*(-8.6)/q+p)
        z2 <== (y/((-y))*(-8.6)/y+x)
        print.cccc (I 1251) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1252
        !"test1252"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1252) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1253
        !"test1253"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 1253) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1254
        !"test1254"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 1254) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1255
        !"test1255"
        z1 <== (7.4*(p)*(-1.6)/(p/(-2.2)+3.6-p/(-p))/(2.5+4.1*(-8.5)*(-8.5)*(-p))/((-q)+(-q)*p/(-q)+(-0.0)))
        z2 <== (7.4*(x)*(-1.6)/(x/(-2.2)+3.6-x/(-x))/(2.5+4.1*(-8.5)*(-8.5)*(-x))/((-y)+(-y)*x/(-y)+(-0.0)))
        print.cccc (I 1255) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1256
        !"test1256"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 1256) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1257
        !"test1257"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 1257) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1258
        !"test1258"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1258) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1259
        !"test1259"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1259) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1260
        !"test1260"
        z1 <== ((-q)/(-8.0)+(q+1.1)-((-5.1)/(-3.6)*q*((-3.2)-(-3.3))+(-8.7)-8.7))
        z2 <== ((-y)/(-8.0)+(y+1.1)-((-5.1)/(-3.6)*y*((-3.2)-(-3.3))+(-8.7)-8.7))
        print.cccc (I 1260) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1261
        !"test1261"
        z1 <== (-6.4)
        z2 <== (-6.4)
        print.cccc (I 1261) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1262
        !"test1262"
        z1 <== ((-p)/((-p)*(q)+p/(-3.4)*(p*(-q)/(-0.1)))/3.7+8.2/(-3.1)+(-2.8)*(7.8-(-4.8)-(-2.1))/6.5-6.4+4.3/q+((-8.7)*(-3.2)))
        z2 <== ((-x)/((-x)*(y)+x/(-3.4)*(x*(-y)/(-0.1)))/3.7+8.2/(-3.1)+(-2.8)*(7.8-(-4.8)-(-2.1))/6.5-6.4+4.3/y+((-8.7)*(-3.2)))
        print.cccc (I 1262) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1263
        !"test1263"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1263) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1264
        !"test1264"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 1264) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1265
        !"test1265"
        z1 <== (2.5+((-4.5)/6.0)*((-1.6)/q+3.6+(-1.0))/p/(-2.2)+(-0.1))/1.0+(-p)/p+(-0.4)/(0.0/p+8.0+(-q)/(-q))*(-p)-(q+(-2.7)-0.2+(-p)*1.0)-(-q)
        z2 <== (2.5+((-4.5)/6.0)*((-1.6)/y+3.6+(-1.0))/x/(-2.2)+(-0.1))/1.0+(-x)/x+(-0.4)/(0.0/x+8.0+(-y)/(-y))*(-x)-(y+(-2.7)-0.2+(-x)*1.0)-(-y)
        print.cccc (I 1265) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1266
        !"test1266"
        z1 <== ((-p)-(-6.3)+((-3.5)/q/q/7.8/7.7))+(-6.2)
        z2 <== ((-x)-(-6.3)+((-3.5)/y/y/7.8/7.7))+(-6.2)
        print.cccc (I 1266) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1267
        !"test1267"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 1267) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1268
        !"test1268"
        z1 <== ((q/p)/(0.3-q-6.2+1.2))
        z2 <== ((y/x)/(0.3-y-6.2+1.2))
        print.cccc (I 1268) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1269
        !"test1269"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 1269) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1270
        !"test1270"
        z1 <== (((-0.8)*((-3.1))+q-(p)/q)+6.7*(((-p)/(-p)))+1.1*(-p)-(-3.6))
        z2 <== (((-0.8)*((-3.1))+y-(x)/y)+6.7*(((-x)/(-x)))+1.1*(-x)-(-3.6))
        print.cccc (I 1270) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1271
        !"test1271"
        z1 <== ((-q)+(-q)*(-p))
        z2 <== ((-y)+(-y)*(-x))
        print.cccc (I 1271) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1272
        !"test1272"
        z1 <== ((1.2+(-3.1)*q)+(-2.1)-(-7.5)*(-5.6)/(-7.7)-p*3.8*(((-q)/(-p)/p)*(q+(-p)-(-4.1))+p/7.6+(-3.2)*q-7.8))
        z2 <== ((1.2+(-3.1)*y)+(-2.1)-(-7.5)*(-5.6)/(-7.7)-x*3.8*(((-y)/(-x)/x)*(y+(-x)-(-4.1))+x/7.6+(-3.2)*y-7.8))
        print.cccc (I 1272) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1273
        !"test1273"
        z1 <== (((-q))-(-5.0)+(-q)/p/2.4*4.3-(-0.3)-(-p)/p/(-q)/((-3.7)*(-p)/q/(-q)))
        z2 <== (((-y))-(-5.0)+(-y)/x/2.4*4.3-(-0.3)-(-x)/x/(-y)/((-3.7)*(-x)/y/(-y)))
        print.cccc (I 1273) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1274
        !"test1274"
        z1 <== (((3.7*0.6+p*1.1)-(-p)/7.0*(-6.1)/p/((-p)*p-p)-(2.8*5.4+(-q)+0.2))*q-((-q)+(-q)*p/5.0+(-q))+((-q)))
        z2 <== (((3.7*0.6+x*1.1)-(-x)/7.0*(-6.1)/x/((-x)*x-x)-(2.8*5.4+(-y)+0.2))*y-((-y)+(-y)*x/5.0+(-y))+((-y)))
        print.cccc (I 1274) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1275
        !"test1275"
        z1 <== (((-p)*2.6/p+p-(-p)/2.0)+4.7)
        z2 <== (((-x)*2.6/x+x-(-x)/2.0)+4.7)
        print.cccc (I 1275) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1276
        !"test1276"
        z1 <== ((-3.1)/(((-p)/p)/2.4/p-q+8.6)+(-0.8)+(-p)/(-1.4)-(-5.3))
        z2 <== ((-3.1)/(((-x)/x)/2.4/x-y+8.6)+(-0.8)+(-x)/(-1.4)-(-5.3))
        print.cccc (I 1276) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1277
        !"test1277"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1277) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1278
        !"test1278"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 1278) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1279
        !"test1279"
        z1 <== 6.5/(-1.8)+(3.7*(-p))-(-p)*(8.6+7.3*(-5.0))
        z2 <== 6.5/(-1.8)+(3.7*(-x))-(-x)*(8.6+7.3*(-5.0))
        print.cccc (I 1279) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1280
        !"test1280"
        z1 <== (-6.5)
        z2 <== (-6.5)
        print.cccc (I 1280) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1281
        !"test1281"
        z1 <== ((q+2.5-(-6.8)-(-3.5)/(-q)-(-5.3)*(-5.3)/(-7.4)/1.5)/(q))
        z2 <== ((y+2.5-(-6.8)-(-3.5)/(-y)-(-5.3)*(-5.3)/(-7.4)/1.5)/(y))
        print.cccc (I 1281) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1282
        !"test1282"
        z1 <== 2.7
        z2 <== 2.7
        print.cccc (I 1282) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1283
        !"test1283"
        z1 <== (((-q)/(-q)/((-q)/(-p)/0.3/p)))
        z2 <== (((-y)/(-y)/((-y)/(-x)/0.3/x)))
        print.cccc (I 1283) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1284
        !"test1284"
        z1 <== ((-q)*(8.6+(1.1+6.6+(-q)-(-p)+(-6.5))/0.4*8.1)+((-1.0)+(q*p/8.7)/(-p)))
        z2 <== ((-y)*(8.6+(1.1+6.6+(-y)-(-x)+(-6.5))/0.4*8.1)+((-1.0)+(y*x/8.7)/(-x)))
        print.cccc (I 1284) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1285
        !"test1285"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 1285) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1286
        !"test1286"
        z1 <== (7.3)
        z2 <== (7.3)
        print.cccc (I 1286) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1287
        !"test1287"
        z1 <== (((q/(-q)+q/q*(-q)))*(1.3+(-7.7)+(-7.1)+p-(-2.2)/(1.8-(-p)/(-6.7)+(-7.2)-(-3.8)))*q)
        z2 <== (((y/(-y)+y/y*(-y)))*(1.3+(-7.7)+(-7.1)+x-(-2.2)/(1.8-(-x)/(-6.7)+(-7.2)-(-3.8)))*y)
        print.cccc (I 1287) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1288
        !"test1288"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 1288) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1289
        !"test1289"
        z1 <== p+(((-p)*(-p)/5.5)*q)+1.6-(0.2)/(-7.5)
        z2 <== x+(((-x)*(-x)/5.5)*y)+1.6-(0.2)/(-7.5)
        print.cccc (I 1289) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1290
        !"test1290"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1290) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1291
        !"test1291"
        z1 <== (5.3+((-0.5)-6.4-(-q)*(-p)-(-6.6))*((-q)*1.7/(-q)+p)-((-2.7))-q/(-4.2)-(1.8+(-4.4)))
        z2 <== (5.3+((-0.5)-6.4-(-y)*(-x)-(-6.6))*((-y)*1.7/(-y)+x)-((-2.7))-y/(-4.2)-(1.8+(-4.4)))
        print.cccc (I 1291) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1292
        !"test1292"
        z1 <== 3.8
        z2 <== 3.8
        print.cccc (I 1292) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1293
        !"test1293"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1293) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1294
        !"test1294"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 1294) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1295
        !"test1295"
        z1 <== (((-q)+7.2/8.0))
        z2 <== (((-y)+7.2/8.0))
        print.cccc (I 1295) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1296
        !"test1296"
        z1 <== 2.7
        z2 <== 2.7
        print.cccc (I 1296) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1297
        !"test1297"
        z1 <== ((((-6.1)*(-5.3)+(-1.2))/(p*(-p)/3.0/q-5.2)/((-7.4)*(-q)*p)))
        z2 <== ((((-6.1)*(-5.3)+(-1.2))/(x*(-x)/3.0/y-5.2)/((-7.4)*(-y)*x)))
        print.cccc (I 1297) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1298
        !"test1298"
        z1 <== ((((-0.7)-(-6.3)-(-0.1))*q)-(-0.6)-(p+((-p)-6.1)*(-7.0)/p-(-p))*((-3.1)*(-q)-((-q))/4.2)*(-8.7))
        z2 <== ((((-0.7)-(-6.3)-(-0.1))*y)-(-0.6)-(x+((-x)-6.1)*(-7.0)/x-(-x))*((-3.1)*(-y)-((-y))/4.2)*(-8.7))
        print.cccc (I 1298) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1299
        !"test1299"
        z1 <== (p+(-q)/(-4.5)-q)/((p/2.1/p*5.3+(-1.4))*(-3.6))/(-q)-3.7
        z2 <== (x+(-y)/(-4.5)-y)/((x/2.1/x*5.3+(-1.4))*(-3.6))/(-y)-3.7
        print.cccc (I 1299) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1300
        !"test1300"
        z1 <== (-3.2)
        z2 <== (-3.2)
        print.cccc (I 1300) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1301
        !"test1301"
        z1 <== (p-2.3)
        z2 <== (x-2.3)
        print.cccc (I 1301) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1302
        !"test1302"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 1302) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1303
        !"test1303"
        z1 <== (q+((-q)+p/(-8.4))/(-q)-(-p)-0.5/(((-5.4))/(-p)/((-4.3)/q+q+q)+q+(p)))
        z2 <== (y+((-y)+x/(-8.4))/(-y)-(-x)-0.5/(((-5.4))/(-x)/((-4.3)/y+y+y)+y+(x)))
        print.cccc (I 1303) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1304
        !"test1304"
        z1 <== (-5.8)-(-p)
        z2 <== (-5.8)-(-x)
        print.cccc (I 1304) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1305
        !"test1305"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1305) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1306
        !"test1306"
        z1 <== q
        z2 <== y
        print.cccc (I 1306) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1307
        !"test1307"
        z1 <== (-1.7)
        z2 <== (-1.7)
        print.cccc (I 1307) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1308
        !"test1308"
        z1 <== (((-6.4)+(p/(-p)-8.4-(-7.8)))-(((-5.0)/(-0.4))/p))
        z2 <== (((-6.4)+(x/(-x)-8.4-(-7.8)))-(((-5.0)/(-0.4))/x))
        print.cccc (I 1308) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1309
        !"test1309"
        z1 <== (((0.1*p/3.7-(-7.1))*((-2.8)/(-4.3)+(-p)/(-8.7)+(-q))+p/(-q))+6.5/q/0.2/(-2.2))
        z2 <== (((0.1*x/3.7-(-7.1))*((-2.8)/(-4.3)+(-x)/(-8.7)+(-y))+x/(-y))+6.5/y/0.2/(-2.2))
        print.cccc (I 1309) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1310
        !"test1310"
        z1 <== ((-p)+(-p)*(-q)/(8.5)*6.8)
        z2 <== ((-x)+(-x)*(-y)/(8.5)*6.8)
        print.cccc (I 1310) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1311
        !"test1311"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1311) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1312
        !"test1312"
        z1 <== ((-6.4)-((-1.3)))
        z2 <== ((-6.4)-((-1.3)))
        print.cccc (I 1312) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1313
        !"test1313"
        z1 <== (((-5.1)+(p)/(-0.3)/(-8.0))/(((-q)*q)-((-q)+(-p)/p*(-p))+7.3)-q+p)
        z2 <== (((-5.1)+(x)/(-0.3)/(-8.0))/(((-y)*y)-((-y)+(-x)/x*(-x))+7.3)-y+x)
        print.cccc (I 1313) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1314
        !"test1314"
        z1 <== (6.1-7.7+(((-4.4)*q)-q-(-7.1))+(-4.2))
        z2 <== (6.1-7.7+(((-4.4)*y)-y-(-7.1))+(-4.2))
        print.cccc (I 1314) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1315
        !"test1315"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1315) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1316
        !"test1316"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 1316) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1317
        !"test1317"
        z1 <== (((3.8)-((-p)*(-p))+((-2.5)*(-q))+4.3)*((-3.8))/8.4*((-p)-((-1.8)*(-7.1)/(-q)-4.8*1.0)-(p*(-q)/4.8/q)))
        z2 <== (((3.8)-((-x)*(-x))+((-2.5)*(-y))+4.3)*((-3.8))/8.4*((-x)-((-1.8)*(-7.1)/(-y)-4.8*1.0)-(x*(-y)/4.8/y)))
        print.cccc (I 1317) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1318
        !"test1318"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 1318) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1319
        !"test1319"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1319) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1320
        !"test1320"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1320) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1321
        !"test1321"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 1321) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1322
        !"test1322"
        z1 <== ((-4.8)*(-p)+p*(-0.0)+(-5.4)*((-8.3)*2.3/(-p))-3.2-3.0-(-3.8)+0.2/(-4.0)*7.6-5.3-7.7)
        z2 <== ((-4.8)*(-x)+x*(-0.0)+(-5.4)*((-8.3)*2.3/(-x))-3.2-3.0-(-3.8)+0.2/(-4.0)*7.6-5.3-7.7)
        print.cccc (I 1322) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1323
        !"test1323"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 1323) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1324
        !"test1324"
        z1 <== (((-p)/q*(q)*((-7.6)/5.7)*((-p)*q+p+q*(-q))))
        z2 <== (((-x)/y*(y)*((-7.6)/5.7)*((-x)*y+x+y*(-y))))
        print.cccc (I 1324) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1325
        !"test1325"
        z1 <== ((q/(-q)/5.0)-((-1.1)-(-7.2)*((-3.7)/(-p)-(-p)-(-4.0)*(-p)))+p)
        z2 <== ((y/(-y)/5.0)-((-1.1)-(-7.2)*((-3.7)/(-x)-(-x)-(-4.0)*(-x)))+x)
        print.cccc (I 1325) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1326
        !"test1326"
        z1 <== ((-3.4)*(-p)-(p+(-4.8)+(-8.7)))
        z2 <== ((-3.4)*(-x)-(x+(-4.8)+(-8.7)))
        print.cccc (I 1326) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1327
        !"test1327"
        z1 <== (((-2.0)+p*(-q))-(-q)-(-p)+4.7*(-p))+(-p)/(((-q)+(-8.4)*q)*(q/(-2.8)+7.3/p)*p+(-p)+(p*1.0*(-p)*p))
        z2 <== (((-2.0)+x*(-y))-(-y)-(-x)+4.7*(-x))+(-x)/(((-y)+(-8.4)*y)*(y/(-2.8)+7.3/x)*x+(-x)+(x*1.0*(-x)*x))
        print.cccc (I 1327) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1328
        !"test1328"
        z1 <== ((p/(q*5.3*(-p)*q*(-q))-p*(-7.1)*(-p))*0.1+(-p)/(-1.4)-((-q)*0.1*(-q))-p/((1.5-p/p+6.2+(-5.3))/((-7.8)/(-q)*0.8-(-q))*(-q)*p)-(q-5.2+((-0.7)*p/5.5)-(-6.0)*((-q)-p)))
        z2 <== ((x/(y*5.3*(-x)*y*(-y))-x*(-7.1)*(-x))*0.1+(-x)/(-1.4)-((-y)*0.1*(-y))-x/((1.5-x/x+6.2+(-5.3))/((-7.8)/(-y)*0.8-(-y))*(-y)*x)-(y-5.2+((-0.7)*x/5.5)-(-6.0)*((-y)-x)))
        print.cccc (I 1328) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1329
        !"test1329"
        z1 <== (((-4.7)-(-7.2)-0.7*(-q))+(-7.1)*((-q))+(-2.8)/5.1/(-p))
        z2 <== (((-4.7)-(-7.2)-0.7*(-y))+(-7.1)*((-y))+(-2.8)/5.1/(-x))
        print.cccc (I 1329) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1330
        !"test1330"
        z1 <== ((((-3.4)+0.0+(-q))/q)*((-p)/((-p)*p+(-1.0))*((-8.2))*(6.2/p+(-q)+(-q)+p)-((-1.6)+(-0.6)*8.0/8.5)))
        z2 <== ((((-3.4)+0.0+(-y))/y)*((-x)/((-x)*x+(-1.0))*((-8.2))*(6.2/x+(-y)+(-y)+x)-((-1.6)+(-0.6)*8.0/8.5)))
        print.cccc (I 1330) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1331
        !"test1331"
        z1 <== (3.1)
        z2 <== (3.1)
        print.cccc (I 1331) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1332
        !"test1332"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 1332) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1333
        !"test1333"
        z1 <== (p-8.3/q)
        z2 <== (x-8.3/y)
        print.cccc (I 1333) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1334
        !"test1334"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1334) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1335
        !"test1335"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 1335) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1336
        !"test1336"
        z1 <== ((4.5/p*1.3/2.8-(-p))/(-0.6)*((-p)+1.7+(-p))*(-q)/(-5.7)/q+((-8.7)-p/(-2.3)+2.0)-(-7.3)*(-p)+7.0)
        z2 <== ((4.5/x*1.3/2.8-(-x))/(-0.6)*((-x)+1.7+(-x))*(-y)/(-5.7)/y+((-8.7)-x/(-2.3)+2.0)-(-7.3)*(-x)+7.0)
        print.cccc (I 1336) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1337
        !"test1337"
        z1 <== ((((-6.0)-(-p)-(-q)*3.2)-q-6.7+5.6/(-q)/(-3.3))+((1.7/(-p))+8.1*(-p)/(-q)))
        z2 <== ((((-6.0)-(-x)-(-y)*3.2)-y-6.7+5.6/(-y)/(-3.3))+((1.7/(-x))+8.1*(-x)/(-y)))
        print.cccc (I 1337) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1338
        !"test1338"
        z1 <== (-5.3)*(q/(3.5)+(-3.6)-q+(-p))-((-0.8)*(6.4/(-p))*0.7)*(1.4*3.4-4.6-(4.6+5.2))-((-p)-3.0)
        z2 <== (-5.3)*(y/(3.5)+(-3.6)-y+(-x))-((-0.8)*(6.4/(-x))*0.7)*(1.4*3.4-4.6-(4.6+5.2))-((-x)-3.0)
        print.cccc (I 1338) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1339
        !"test1339"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1339) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1340
        !"test1340"
        z1 <== 0.3
        z2 <== 0.3
        print.cccc (I 1340) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1341
        !"test1341"
        z1 <== ((-7.8)*p/q*(-8.1)/(q-3.5+1.3+(-p)*8.5)*(-q)-(-q))
        z2 <== ((-7.8)*x/y*(-8.1)/(y-3.5+1.3+(-x)*8.5)*(-y)-(-y))
        print.cccc (I 1341) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1342
        !"test1342"
        z1 <== (2.3-((5.5-2.0*7.7-(-p)-(-1.7)))-4.3*((4.3/(-1.0)*p-p-1.6)-((-p)+0.4*0.8+(-3.8)+(-1.1))+(-3.0)+((-p))/((-7.3)+2.5-(-8.2)*7.7))/(q*7.0*p))
        z2 <== (2.3-((5.5-2.0*7.7-(-x)-(-1.7)))-4.3*((4.3/(-1.0)*x-x-1.6)-((-x)+0.4*0.8+(-3.8)+(-1.1))+(-3.0)+((-x))/((-7.3)+2.5-(-8.2)*7.7))/(y*7.0*x))
        print.cccc (I 1342) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1343
        !"test1343"
        z1 <== 3.8
        z2 <== 3.8
        print.cccc (I 1343) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1344
        !"test1344"
        z1 <== p
        z2 <== x
        print.cccc (I 1344) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1345
        !"test1345"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1345) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1346
        !"test1346"
        z1 <== (6.3+0.4)
        z2 <== (6.3+0.4)
        print.cccc (I 1346) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1347
        !"test1347"
        z1 <== (6.8/((0.0/q-7.8+(-q)+5.2)/((-4.0)+(-1.1)*(-p)*(-p)/p)+(-1.5)/p*0.8-0.5+(-q)+(1.7*p+(-p)-(-8.4))/p))
        z2 <== (6.8/((0.0/y-7.8+(-y)+5.2)/((-4.0)+(-1.1)*(-x)*(-x)/x)+(-1.5)/x*0.8-0.5+(-y)+(1.7*x+(-x)-(-8.4))/x))
        print.cccc (I 1347) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1348
        !"test1348"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 1348) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1349
        !"test1349"
        z1 <== ((-p)+((-6.6))/(-1.6)+(p+(-p)*(-6.6))-(-p)-((-8.7))/(2.2+(-3.2)+6.2-(-2.3)*(-q))*(((-7.2))*(-2.4))/((-6.1)*3.4*(3.8-p/q)-(-3.3)))
        z2 <== ((-x)+((-6.6))/(-1.6)+(x+(-x)*(-6.6))-(-x)-((-8.7))/(2.2+(-3.2)+6.2-(-2.3)*(-y))*(((-7.2))*(-2.4))/((-6.1)*3.4*(3.8-x/y)-(-3.3)))
        print.cccc (I 1349) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1350
        !"test1350"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 1350) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1351
        !"test1351"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 1351) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1352
        !"test1352"
        z1 <== q
        z2 <== y
        print.cccc (I 1352) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1353
        !"test1353"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1353) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1354
        !"test1354"
        z1 <== (5.0*3.8+((-q))-(-q)/((-p)+(-3.6)*(-5.0)+(-q))/(6.7+(-p)/(-3.0)*6.6*(-p))/((2.3)/((-1.8)*(-p)*(-q)/7.6)*(p*(-8.1)+q))*4.1)
        z2 <== (5.0*3.8+((-y))-(-y)/((-x)+(-3.6)*(-5.0)+(-y))/(6.7+(-x)/(-3.0)*6.6*(-x))/((2.3)/((-1.8)*(-x)*(-y)/7.6)*(x*(-8.1)+y))*4.1)
        print.cccc (I 1354) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1355
        !"test1355"
        z1 <== p
        z2 <== x
        print.cccc (I 1355) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1356
        !"test1356"
        z1 <== (-8.6)-(p+(-7.1)*(-2.4)+6.2/p+(-p)*(q-7.5+q*6.2)-((-7.2)/(-q)*(-0.8)-p+(-p)))/q-(-6.3)
        z2 <== (-8.6)-(x+(-7.1)*(-2.4)+6.2/x+(-x)*(y-7.5+y*6.2)-((-7.2)/(-y)*(-0.8)-x+(-x)))/y-(-6.3)
        print.cccc (I 1356) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1357
        !"test1357"
        z1 <== (-7.7)+(-q)/(((-7.5)*q*p)+(-q)+(2.8)*q)/(6.7-5.3/((-q)-(-2.6)-p-1.0))
        z2 <== (-7.7)+(-y)/(((-7.5)*y*x)+(-y)+(2.8)*y)/(6.7-5.3/((-y)-(-2.6)-x-1.0))
        print.cccc (I 1357) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1358
        !"test1358"
        z1 <== (((-p)+((-q))+(-3.7))/q-p)
        z2 <== (((-x)+((-y))+(-3.7))/y-x)
        print.cccc (I 1358) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1359
        !"test1359"
        z1 <== (-2.0)
        z2 <== (-2.0)
        print.cccc (I 1359) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1360
        !"test1360"
        z1 <== 3.3
        z2 <== 3.3
        print.cccc (I 1360) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1361
        !"test1361"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1361) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1362
        !"test1362"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 1362) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1363
        !"test1363"
        z1 <== (p/2.8/(5.6)*((3.1-p+7.7+(-4.2))*(p+(-6.1)+5.4/(-p)))-q)
        z2 <== (x/2.8/(5.6)*((3.1-x+7.7+(-4.2))*(x+(-6.1)+5.4/(-x)))-y)
        print.cccc (I 1363) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1364
        !"test1364"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 1364) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1365
        !"test1365"
        z1 <== p
        z2 <== x
        print.cccc (I 1365) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1366
        !"test1366"
        z1 <== (q-(-7.2))
        z2 <== (y-(-7.2))
        print.cccc (I 1366) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1367
        !"test1367"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1367) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1368
        !"test1368"
        z1 <== (-p)*((-p)*((-0.3)*(-p)))+5.6+(-q)+((q*0.8+0.4*(-p)+2.6)-(-6.6)*((-5.0)))
        z2 <== (-x)*((-x)*((-0.3)*(-x)))+5.6+(-y)+((y*0.8+0.4*(-x)+2.6)-(-6.6)*((-5.0)))
        print.cccc (I 1368) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1369
        !"test1369"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 1369) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1370
        !"test1370"
        z1 <== ((-p)+((-p)-(-1.1)/(-q))*(-p)*(-1.8)/(-4.0)-(3.3/q))
        z2 <== ((-x)+((-x)-(-1.1)/(-y))*(-x)*(-1.8)/(-4.0)-(3.3/y))
        print.cccc (I 1370) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1371
        !"test1371"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1371) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1372
        !"test1372"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 1372) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1373
        !"test1373"
        z1 <== ((q/((-p))))
        z2 <== ((y/((-x))))
        print.cccc (I 1373) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1374
        !"test1374"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 1374) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1375
        !"test1375"
        z1 <== (((0.7/2.2*(-7.7)/p*(-3.2))-(-5.3)-7.1/(-p)+(-q))/(-p)/(-q)*p-p+(6.6))
        z2 <== (((0.7/2.2*(-7.7)/x*(-3.2))-(-5.3)-7.1/(-x)+(-y))/(-x)/(-y)*x-x+(6.6))
        print.cccc (I 1375) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1376
        !"test1376"
        z1 <== (-5.7)*q+7.3+((8.6*(-p)+p)*(q)+(-7.2)+p)
        z2 <== (-5.7)*y+7.3+((8.6*(-x)+x)*(y)+(-7.2)+x)
        print.cccc (I 1376) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1377
        !"test1377"
        z1 <== (p-(p*(-1.4)*(-q))-8.7)
        z2 <== (x-(x*(-1.4)*(-y))-8.7)
        print.cccc (I 1377) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1378
        !"test1378"
        z1 <== (q/(-3.5)-(-4.4)*(((-q)/0.4-q*(-7.8)*4.5))-((-p))+(((-5.8))/(p-(-6.1)-(-q)+p-2.0)+(-4.7)))
        z2 <== (y/(-3.5)-(-4.4)*(((-y)/0.4-y*(-7.8)*4.5))-((-x))+(((-5.8))/(x-(-6.1)-(-y)+x-2.0)+(-4.7)))
        print.cccc (I 1378) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1379
        !"test1379"
        z1 <== ((5.0))
        z2 <== ((5.0))
        print.cccc (I 1379) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1380
        !"test1380"
        z1 <== (((-3.8)*q*(-q)*(-1.5)*(-q)/(-q)*(-7.6))+((-q)*(q/p)+7.6+(-p)*8.5/0.7+(-8.4)*(-p)/(-0.6))+(-6.6)*((-p)))
        z2 <== (((-3.8)*y*(-y)*(-1.5)*(-y)/(-y)*(-7.6))+((-y)*(y/x)+7.6+(-x)*8.5/0.7+(-8.4)*(-x)/(-0.6))+(-6.6)*((-x)))
        print.cccc (I 1380) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1381
        !"test1381"
        z1 <== ((-q)/((0.2)-(2.5/4.4-8.4)+(p/(-q)-(-q)+(-2.7))-(-6.2)+6.5-(-q))-(-p)*3.2-6.1)
        z2 <== ((-y)/((0.2)-(2.5/4.4-8.4)+(x/(-y)-(-y)+(-2.7))-(-6.2)+6.5-(-y))-(-x)*3.2-6.1)
        print.cccc (I 1381) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1382
        !"test1382"
        z1 <== ((p))
        z2 <== ((x))
        print.cccc (I 1382) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1383
        !"test1383"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1383) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1384
        !"test1384"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1384) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1385
        !"test1385"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1385) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1386
        !"test1386"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 1386) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1387
        !"test1387"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 1387) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1388
        !"test1388"
        z1 <== p
        z2 <== x
        print.cccc (I 1388) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1389
        !"test1389"
        z1 <== (((-q)/((-5.2)))+((q+(-4.4)+p-(-p)-p)+((-5.6))/p+(6.6-(-8.4)*7.3))*((-p)*(-7.4)-p*(-3.3))-(1.8+((-p)*2.7+p+(-2.1))-p-(-1.1)-(-0.1)*p-4.7)/(((-q)/(-p)+q)))
        z2 <== (((-y)/((-5.2)))+((y+(-4.4)+x-(-x)-x)+((-5.6))/x+(6.6-(-8.4)*7.3))*((-x)*(-7.4)-x*(-3.3))-(1.8+((-x)*2.7+x+(-2.1))-x-(-1.1)-(-0.1)*x-4.7)/(((-y)/(-x)+y)))
        print.cccc (I 1389) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1390
        !"test1390"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 1390) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1391
        !"test1391"
        z1 <== q
        z2 <== y
        print.cccc (I 1391) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1392
        !"test1392"
        z1 <== (((-p)+q-8.0)+(p/q*2.8)*(-p))
        z2 <== (((-x)+y-8.0)+(x/y*2.8)*(-x))
        print.cccc (I 1392) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1393
        !"test1393"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 1393) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1394
        !"test1394"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1394) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1395
        !"test1395"
        z1 <== (p/(-5.7)*(-5.0))+((-3.2)+p+q)*(((-p)+(-q)+(-5.6))+(q-p-q+7.2))
        z2 <== (x/(-5.7)*(-5.0))+((-3.2)+x+y)*(((-x)+(-y)+(-5.6))+(y-x-y+7.2))
        print.cccc (I 1395) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1396
        !"test1396"
        z1 <== ((-p)-p-((-p)/(-p)/(-q))+((-q)+(-5.0)-(-0.1)-(-7.3))*p)
        z2 <== ((-x)-x-((-x)/(-x)/(-y))+((-y)+(-5.0)-(-0.1)-(-7.3))*x)
        print.cccc (I 1396) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1397
        !"test1397"
        z1 <== (8.7-((1.0+(-p)/(-8.3)*1.3)+(-8.1)-(7.1*(-p)+q)+((-q)-(-p)-q)/1.2)/p)
        z2 <== (8.7-((1.0+(-x)/(-8.3)*1.3)+(-8.1)-(7.1*(-x)+y)+((-y)-(-x)-y)/1.2)/x)
        print.cccc (I 1397) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1398
        !"test1398"
        z1 <== (((-8.4))*q-((1.8)+(-8.0))+6.7/(-5.7)-p*(-7.2)+q*q)
        z2 <== (((-8.4))*y-((1.8)+(-8.0))+6.7/(-5.7)-x*(-7.2)+y*y)
        print.cccc (I 1398) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1399
        !"test1399"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1399) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1400
        !"test1400"
        z1 <== (q-((p+(-3.6)+1.8)+(-0.0)+(-3.8)+q)*(-q))
        z2 <== (y-((x+(-3.6)+1.8)+(-0.0)+(-3.8)+y)*(-y))
        print.cccc (I 1400) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1401
        !"test1401"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 1401) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1402
        !"test1402"
        z1 <== (((-q)*5.6)/(((-p)*q*(-p))*(6.8/p*p)-((-6.7)-(-6.5)*(-p)/(-q)))*(-6.3)/((-p)/5.8))
        z2 <== (((-y)*5.6)/(((-x)*y*(-x))*(6.8/x*x)-((-6.7)-(-6.5)*(-x)/(-y)))*(-6.3)/((-x)/5.8))
        print.cccc (I 1402) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1403
        !"test1403"
        z1 <== (7.2-((8.6/(-q)-(-5.3)/(-p)/(-6.5))/((-2.6)+(-0.5)/(-8.4)-(-8.3)-q)-(-q))/6.6/((6.7/3.2+p*(-5.7))/6.1+((-q))-p)*q)
        z2 <== (7.2-((8.6/(-y)-(-5.3)/(-x)/(-6.5))/((-2.6)+(-0.5)/(-8.4)-(-8.3)-y)-(-y))/6.6/((6.7/3.2+x*(-5.7))/6.1+((-y))-x)*y)
        print.cccc (I 1403) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1404
        !"test1404"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1404) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1405
        !"test1405"
        z1 <== (((-q)*q/(-1.5)/((-1.0)+(-q)+(-q)/(-6.4)))*(2.2/(-p)*(-7.1)+7.6+(-q))+6.0-5.8)
        z2 <== (((-y)*y/(-1.5)/((-1.0)+(-y)+(-y)/(-6.4)))*(2.2/(-x)*(-7.1)+7.6+(-y))+6.0-5.8)
        print.cccc (I 1405) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1406
        !"test1406"
        z1 <== (((-4.7)-((-p)*8.2+q*2.8))/((-0.4))/p-(3.2/(7.5*q+3.5*q-q)/(-4.5)/(6.2-(-p)))+3.6*(q*(-6.1)*(-p)-p))
        z2 <== (((-4.7)-((-x)*8.2+y*2.8))/((-0.4))/x-(3.2/(7.5*y+3.5*y-y)/(-4.5)/(6.2-(-x)))+3.6*(y*(-6.1)*(-x)-x))
        print.cccc (I 1406) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1407
        !"test1407"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1407) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1408
        !"test1408"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1408) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1409
        !"test1409"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1409) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1410
        !"test1410"
        z1 <== (2.7*p+(((-2.2)*8.3-q))/(-p))
        z2 <== (2.7*x+(((-2.2)*8.3-y))/(-x))
        print.cccc (I 1410) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1411
        !"test1411"
        z1 <== (((-3.6)*8.1+((-q)+p*(-0.5)))+((-7.1)*p*p*(-3.5)*((-1.3)+(-p)*(-4.0))+0.5*p*1.5)+(-4.2))
        z2 <== (((-3.6)*8.1+((-y)+x*(-0.5)))+((-7.1)*x*x*(-3.5)*((-1.3)+(-x)*(-4.0))+0.5*x*1.5)+(-4.2))
        print.cccc (I 1411) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1412
        !"test1412"
        z1 <== ((-5.3)/p-(-p)+q)
        z2 <== ((-5.3)/x-(-x)+y)
        print.cccc (I 1412) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1413
        !"test1413"
        z1 <== (-1.0)
        z2 <== (-1.0)
        print.cccc (I 1413) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1414
        !"test1414"
        z1 <== q
        z2 <== y
        print.cccc (I 1414) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1415
        !"test1415"
        z1 <== ((((-6.8)*(-q)-(-q))+(-2.8)*p*(-0.2)*7.5*(-4.5)-q/(7.3-(-q)/2.0*p))+q-(-4.2))
        z2 <== ((((-6.8)*(-y)-(-y))+(-2.8)*x*(-0.2)*7.5*(-4.5)-y/(7.3-(-y)/2.0*x))+y-(-4.2))
        print.cccc (I 1415) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1416
        !"test1416"
        z1 <== (p+((6.2*q*(-8.7)-p/4.0)+(-q)*(-q))*q/((-q)+q+q-8.6/5.7*(-5.2))+(-8.7))
        z2 <== (x+((6.2*y*(-8.7)-x/4.0)+(-y)*(-y))*y/((-y)+y+y-8.6/5.7*(-5.2))+(-8.7))
        print.cccc (I 1416) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1417
        !"test1417"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 1417) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1418
        !"test1418"
        z1 <== ((-7.5))
        z2 <== ((-7.5))
        print.cccc (I 1418) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1419
        !"test1419"
        z1 <== (((-4.7))-((7.7/8.0*(-q)-(-q)*q)-1.5+((-3.2)-(-q)-(-0.5)/(-6.7)/p)+(-8.6)*(-1.5)))
        z2 <== (((-4.7))-((7.7/8.0*(-y)-(-y)*y)-1.5+((-3.2)-(-y)-(-0.5)/(-6.7)/x)+(-8.6)*(-1.5)))
        print.cccc (I 1419) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1420
        !"test1420"
        z1 <== (p/(-7.2)-8.1/((-p)*p-(p-(-1.8)*(-p)-q*6.3)/p-(-p)-7.4+(-7.7)))
        z2 <== (x/(-7.2)-8.1/((-x)*x-(x-(-1.8)*(-x)-y*6.3)/x-(-x)-7.4+(-7.7)))
        print.cccc (I 1420) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1421
        !"test1421"
        z1 <== ((-0.5)*(4.6+(-p)))
        z2 <== ((-0.5)*(4.6+(-x)))
        print.cccc (I 1421) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1422
        !"test1422"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 1422) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1423
        !"test1423"
        z1 <== ((8.7*(-2.3)+q/(p*(-q)-(-0.0)/(-1.2)+(-0.6)))*((-q)+(-q)/(-q))*((-p)+7.5*p-(-1.7))+(-6.3)+q+7.1+7.5)
        z2 <== ((8.7*(-2.3)+y/(x*(-y)-(-0.0)/(-1.2)+(-0.6)))*((-y)+(-y)/(-y))*((-x)+7.5*x-(-1.7))+(-6.3)+y+7.1+7.5)
        print.cccc (I 1423) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1424
        !"test1424"
        z1 <== (-7.7)
        z2 <== (-7.7)
        print.cccc (I 1424) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1425
        !"test1425"
        z1 <== q
        z2 <== y
        print.cccc (I 1425) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1426
        !"test1426"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 1426) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1427
        !"test1427"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 1427) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1428
        !"test1428"
        z1 <== 2.2
        z2 <== 2.2
        print.cccc (I 1428) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1429
        !"test1429"
        z1 <== (2.0+(-3.7))
        z2 <== (2.0+(-3.7))
        print.cccc (I 1429) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1430
        !"test1430"
        z1 <== ((-1.3)*(5.4-(-p)))
        z2 <== ((-1.3)*(5.4-(-x)))
        print.cccc (I 1430) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1431
        !"test1431"
        z1 <== q
        z2 <== y
        print.cccc (I 1431) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1432
        !"test1432"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 1432) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1433
        !"test1433"
        z1 <== 8.3
        z2 <== 8.3
        print.cccc (I 1433) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1434
        !"test1434"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 1434) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1435
        !"test1435"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 1435) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1436
        !"test1436"
        z1 <== 2.7
        z2 <== 2.7
        print.cccc (I 1436) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1437
        !"test1437"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 1437) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1438
        !"test1438"
        z1 <== ((-2.4))
        z2 <== ((-2.4))
        print.cccc (I 1438) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1439
        !"test1439"
        z1 <== ((4.0-(-0.5)*p/p)+(-q))
        z2 <== ((4.0-(-0.5)*x/x)+(-y))
        print.cccc (I 1439) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1440
        !"test1440"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 1440) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1441
        !"test1441"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1441) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1442
        !"test1442"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 1442) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1443
        !"test1443"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 1443) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1444
        !"test1444"
        z1 <== (6.6+p-(-2.5)*(-p)+(-p))
        z2 <== (6.6+x-(-2.5)*(-x)+(-x))
        print.cccc (I 1444) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1445
        !"test1445"
        z1 <== p
        z2 <== x
        print.cccc (I 1445) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1446
        !"test1446"
        z1 <== (-2.3)
        z2 <== (-2.3)
        print.cccc (I 1446) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1447
        !"test1447"
        z1 <== (((p)/(-3.7)+(-q)/(-q)+(-q)+q/(-q)-(-6.0)/(-q)-(-p)))
        z2 <== (((x)/(-3.7)+(-y)/(-y)+(-y)+y/(-y)-(-6.0)/(-y)-(-x)))
        print.cccc (I 1447) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1448
        !"test1448"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1448) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1449
        !"test1449"
        z1 <== p
        z2 <== x
        print.cccc (I 1449) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1450
        !"test1450"
        z1 <== q
        z2 <== y
        print.cccc (I 1450) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1451
        !"test1451"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 1451) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1452
        !"test1452"
        z1 <== 6.1
        z2 <== 6.1
        print.cccc (I 1452) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1453
        !"test1453"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 1453) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1454
        !"test1454"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1454) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1455
        !"test1455"
        z1 <== (q/(8.6+q*4.1*7.0)+p+(q/(-3.8)+(-6.2)*5.1/q*(-p)-((-0.2)))/p-(-3.1))
        z2 <== (y/(8.6+y*4.1*7.0)+x+(y/(-3.8)+(-6.2)*5.1/y*(-x)-((-0.2)))/x-(-3.1))
        print.cccc (I 1455) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1456
        !"test1456"
        z1 <== (((-q))+((-q)-(-p)-(-0.1)/(-q)+2.8)+(2.0/(-q))/(1.7+q/(-q)+(-1.6)/(-p))+1.6)+(-0.3)
        z2 <== (((-y))+((-y)-(-x)-(-0.1)/(-y)+2.8)+(2.0/(-y))/(1.7+y/(-y)+(-1.6)/(-x))+1.6)+(-0.3)
        print.cccc (I 1456) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1457
        !"test1457"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 1457) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1458
        !"test1458"
        z1 <== q
        z2 <== y
        print.cccc (I 1458) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1459
        !"test1459"
        z1 <== (p+3.4+(-6.3)/(7.6*(-6.3)*(-q)-p*(-q)/(-p)-p/((-3.3)))-(((-q)+(-q)/q-1.1)/(-6.7)*(-q)-(p-(-7.5)*p*(-p)-3.2)-(q+8.8)))
        z2 <== (x+3.4+(-6.3)/(7.6*(-6.3)*(-y)-x*(-y)/(-x)-x/((-3.3)))-(((-y)+(-y)/y-1.1)/(-6.7)*(-y)-(x-(-7.5)*x*(-x)-3.2)-(y+8.8)))
        print.cccc (I 1459) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1460
        !"test1460"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 1460) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1461
        !"test1461"
        z1 <== q
        z2 <== y
        print.cccc (I 1461) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1462
        !"test1462"
        z1 <== 6.5
        z2 <== 6.5
        print.cccc (I 1462) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1463
        !"test1463"
        z1 <== ((-q)*5.7-(-q)/((-p)*(-4.7)*(-7.5)*(-p)))/((-0.2))/((-0.7)-(-3.8)/((-q)-8.7/(-6.5)*(-7.0)-(-8.4))*q)+(8.0*(q+q*(-0.6))-3.4/0.1)*p
        z2 <== ((-y)*5.7-(-y)/((-x)*(-4.7)*(-7.5)*(-x)))/((-0.2))/((-0.7)-(-3.8)/((-y)-8.7/(-6.5)*(-7.0)-(-8.4))*y)+(8.0*(y+y*(-0.6))-3.4/0.1)*x
        print.cccc (I 1463) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1464
        !"test1464"
        z1 <== ((0.5/((-5.7)))+(-0.6))
        z2 <== ((0.5/((-5.7)))+(-0.6))
        print.cccc (I 1464) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1465
        !"test1465"
        z1 <== (p-(-q))
        z2 <== (x-(-y))
        print.cccc (I 1465) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1466
        !"test1466"
        z1 <== (0.2-(((-p)-(-1.4))-(q+0.7-(-p))+(q/p*(-p)+4.2/(-p))+q)+((6.8+(-q)+(-p)*(-p))/((-q)+(-7.3)/(-1.5))-q*(-0.1)-((-q)/1.8/(-q)/(-p)/(-q))))
        z2 <== (0.2-(((-x)-(-1.4))-(y+0.7-(-x))+(y/x*(-x)+4.2/(-x))+y)+((6.8+(-y)+(-x)*(-x))/((-y)+(-7.3)/(-1.5))-y*(-0.1)-((-y)/1.8/(-y)/(-x)/(-y))))
        print.cccc (I 1466) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1467
        !"test1467"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 1467) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1468
        !"test1468"
        z1 <== (((p/4.7+8.7)+(-6.1)/(-3.3)-p))
        z2 <== (((x/4.7+8.7)+(-6.1)/(-3.3)-x))
        print.cccc (I 1468) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1469
        !"test1469"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 1469) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1470
        !"test1470"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1470) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1471
        !"test1471"
        z1 <== ((-p)/(((-8.6)/7.4+(-p)+1.6)-q-(-6.2)*q)*p)
        z2 <== ((-x)/(((-8.6)/7.4+(-x)+1.6)-y-(-6.2)*y)*x)
        print.cccc (I 1471) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1472
        !"test1472"
        z1 <== ((-1.3)/q+(-p)+q)+p/(-q)
        z2 <== ((-1.3)/y+(-x)+y)+x/(-y)
        print.cccc (I 1472) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1473
        !"test1473"
        z1 <== p
        z2 <== x
        print.cccc (I 1473) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1474
        !"test1474"
        z1 <== (((7.0/(-p))-(q+0.3-p*2.1)/(-2.8)))
        z2 <== (((7.0/(-x))-(y+0.3-x*2.1)/(-2.8)))
        print.cccc (I 1474) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1475
        !"test1475"
        z1 <== 6.5-((-p)*(-5.5)*2.4+1.3+(-0.1)*q-((-q)+3.6-(-4.6)-(-6.5)))-(-3.6)*(-6.6)+(q/(0.8*6.4-(-3.1))-(-8.6)+p/(-3.7))
        z2 <== 6.5-((-x)*(-5.5)*2.4+1.3+(-0.1)*y-((-y)+3.6-(-4.6)-(-6.5)))-(-3.6)*(-6.6)+(y/(0.8*6.4-(-3.1))-(-8.6)+x/(-3.7))
        print.cccc (I 1475) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1476
        !"test1476"
        z1 <== ((((-p)*(-8.4))*(3.0+(-8.2)/(-p)-q-2.2)-(-p)-(-p)))
        z2 <== ((((-x)*(-8.4))*(3.0+(-8.2)/(-x)-y-2.2)-(-x)-(-x)))
        print.cccc (I 1476) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1477
        !"test1477"
        z1 <== p
        z2 <== x
        print.cccc (I 1477) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1478
        !"test1478"
        z1 <== (q/(-p))
        z2 <== (y/(-x))
        print.cccc (I 1478) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1479
        !"test1479"
        z1 <== ((5.4-((-7.3)*(-p)+p))/(8.8/(-q)-(-6.7)*0.8)*(-8.7)/2.5/4.7/(-q)-1.2+(-q)/(-p)/5.0*((-8.6)*p*(q/(-4.7)+4.7)))
        z2 <== ((5.4-((-7.3)*(-x)+x))/(8.8/(-y)-(-6.7)*0.8)*(-8.7)/2.5/4.7/(-y)-1.2+(-y)/(-x)/5.0*((-8.6)*x*(y/(-4.7)+4.7)))
        print.cccc (I 1479) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1480
        !"test1480"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1480) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1481
        !"test1481"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 1481) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1482
        !"test1482"
        z1 <== (-2.4)/q+(-1.0)
        z2 <== (-2.4)/y+(-1.0)
        print.cccc (I 1482) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1483
        !"test1483"
        z1 <== p
        z2 <== x
        print.cccc (I 1483) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1484
        !"test1484"
        z1 <== q
        z2 <== y
        print.cccc (I 1484) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1485
        !"test1485"
        z1 <== ((-1.7)-q*q+(-q)-(-p))
        z2 <== ((-1.7)-y*y+(-y)-(-x))
        print.cccc (I 1485) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1486
        !"test1486"
        z1 <== (((-3.7)/((-2.2)-q)+(-q)/p/p*(-p)-(-p)*p+p)+8.0-(((-q)+(-p)*7.7+2.4/q)*(q/(-q)*(-5.7)/(-p))+(-6.8)-((-p)/p+(-1.0)+(-6.4)/p)*(-0.7))-(-5.4)+q)
        z2 <== (((-3.7)/((-2.2)-y)+(-y)/x/x*(-x)-(-x)*x+x)+8.0-(((-y)+(-x)*7.7+2.4/y)*(y/(-y)*(-5.7)/(-x))+(-6.8)-((-x)/x+(-1.0)+(-6.4)/x)*(-0.7))-(-5.4)+y)
        print.cccc (I 1486) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1487
        !"test1487"
        z1 <== q
        z2 <== y
        print.cccc (I 1487) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1488
        !"test1488"
        z1 <== (-6.8)
        z2 <== (-6.8)
        print.cccc (I 1488) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1489
        !"test1489"
        z1 <== ((5.7+7.8))
        z2 <== ((5.7+7.8))
        print.cccc (I 1489) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1490
        !"test1490"
        z1 <== (-7.7)
        z2 <== (-7.7)
        print.cccc (I 1490) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1491
        !"test1491"
        z1 <== (q+(((-p)/(-p)/p)-(q/0.8-(-8.5))/((-2.6))-((-q))+q)+q*(8.3+(-p)+(-0.5))+p/(-p)-(6.2*3.6/(-5.1)*7.5+(-7.6)))
        z2 <== (y+(((-x)/(-x)/x)-(y/0.8-(-8.5))/((-2.6))-((-y))+y)+y*(8.3+(-x)+(-0.5))+x/(-x)-(6.2*3.6/(-5.1)*7.5+(-7.6)))
        print.cccc (I 1491) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1492
        !"test1492"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1492) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1493
        !"test1493"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 1493) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1494
        !"test1494"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1494) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1495
        !"test1495"
        z1 <== ((0.0*(-q))-p/q-7.7-((0.1)-(-8.1)-(-q)))
        z2 <== ((0.0*(-y))-x/y-7.7-((0.1)-(-8.1)-(-y)))
        print.cccc (I 1495) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1496
        !"test1496"
        z1 <== ((-p)-(-7.4)-7.3)
        z2 <== ((-x)-(-7.4)-7.3)
        print.cccc (I 1496) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1497
        !"test1497"
        z1 <== ((((-8.2)*(-p)*(-8.7)*(-p)*p)*(-6.6)*p/(p-7.5*8.2/7.0-(-7.0)))*((-4.0)/(-p)+(-p))+((-q)-p-(-q)*(-3.2))+(((-1.6)+(-q)+(-q)*(-p)/(-6.7))/(q-p/p-6.4-(-p))+(-p)/(q/p)*(-0.5))-((5.8*(-p)+(-0.7)*(-5.4)*(-q))+(p)))
        z2 <== ((((-8.2)*(-x)*(-8.7)*(-x)*x)*(-6.6)*x/(x-7.5*8.2/7.0-(-7.0)))*((-4.0)/(-x)+(-x))+((-y)-x-(-y)*(-3.2))+(((-1.6)+(-y)+(-y)*(-x)/(-6.7))/(y-x/x-6.4-(-x))+(-x)/(y/x)*(-0.5))-((5.8*(-x)+(-0.7)*(-5.4)*(-y))+(x)))
        print.cccc (I 1497) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1498
        !"test1498"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 1498) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1499
        !"test1499"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 1499) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1500
        !"test1500"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 1500) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1501
        !"test1501"
        z1 <== (((-7.5)/(-p)+(-p)*(-p)))-((-1.7)-(-5.2)/q)-(-p)*(-0.2)-((q)-((-7.7)+(-8.1)-(-q)))
        z2 <== (((-7.5)/(-x)+(-x)*(-x)))-((-1.7)-(-5.2)/y)-(-x)*(-0.2)-((y)-((-7.7)+(-8.1)-(-y)))
        print.cccc (I 1501) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1502
        !"test1502"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 1502) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1503
        !"test1503"
        z1 <== ((-q)*((-3.1))+(-2.1)+(((-5.2)-2.5*p+(-q))))
        z2 <== ((-y)*((-3.1))+(-2.1)+(((-5.2)-2.5*x+(-y))))
        print.cccc (I 1503) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1504
        !"test1504"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 1504) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1505
        !"test1505"
        z1 <== ((6.2-(-q)+(-q)))*(-7.8)/(7.0-(8.8+(-6.6)/q)/8.6+(7.3-1.1-(-2.4)+(-q)))+(-4.6)
        z2 <== ((6.2-(-y)+(-y)))*(-7.8)/(7.0-(8.8+(-6.6)/y)/8.6+(7.3-1.1-(-2.4)+(-y)))+(-4.6)
        print.cccc (I 1505) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1506
        !"test1506"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1506) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1507
        !"test1507"
        z1 <== (((-p)*(-6.6)+((-q))))
        z2 <== (((-x)*(-6.6)+((-y))))
        print.cccc (I 1507) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1508
        !"test1508"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1508) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1509
        !"test1509"
        z1 <== ((-q)-((-0.1)-(-q)*q)/((-4.7)*((-6.6)+7.1*(-p)-(-p)+p))/q+p)
        z2 <== ((-y)-((-0.1)-(-y)*y)/((-4.7)*((-6.6)+7.1*(-x)-(-x)+x))/y+x)
        print.cccc (I 1509) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1510
        !"test1510"
        z1 <== p
        z2 <== x
        print.cccc (I 1510) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1511
        !"test1511"
        z1 <== q
        z2 <== y
        print.cccc (I 1511) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1512
        !"test1512"
        z1 <== ((q)/(-3.2)*(-p)/p*(-q)+(-2.3)-(-p)*(p+q))-1.7/(-6.1)+(-4.7)
        z2 <== ((y)/(-3.2)*(-x)/x*(-y)+(-2.3)-(-x)*(x+y))-1.7/(-6.1)+(-4.7)
        print.cccc (I 1512) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1513
        !"test1513"
        z1 <== (p*6.7*(-p)-p-((-q)+1.8/8.4-(-p)*p)*7.3/(-q)-(-p)+(-2.2)/5.1-(-4.3))
        z2 <== (x*6.7*(-x)-x-((-y)+1.8/8.4-(-x)*x)*7.3/(-y)-(-x)+(-2.2)/5.1-(-4.3))
        print.cccc (I 1513) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1514
        !"test1514"
        z1 <== q
        z2 <== y
        print.cccc (I 1514) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1515
        !"test1515"
        z1 <== (((-1.2))/1.1/(-0.1)+(8.8)-(-2.1))
        z2 <== (((-1.2))/1.1/(-0.1)+(8.8)-(-2.1))
        print.cccc (I 1515) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1516
        !"test1516"
        z1 <== ((-p)*((-7.8)/((-p)-(-p)/q+(-q)))*(-5.7)-(-p)+(q+(8.5*q)))
        z2 <== ((-x)*((-7.8)/((-x)-(-x)/y+(-y)))*(-5.7)-(-x)+(y+(8.5*y)))
        print.cccc (I 1516) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1517
        !"test1517"
        z1 <== (-p)+2.1/((q+(-1.2))*(-q)+p)*(3.2)
        z2 <== (-x)+2.1/((y+(-1.2))*(-y)+x)*(3.2)
        print.cccc (I 1517) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1518
        !"test1518"
        z1 <== (p-7.6/(((-p)/(-2.6)+(-q)*8.6/(-q)))/q)
        z2 <== (x-7.6/(((-x)/(-2.6)+(-y)*8.6/(-y)))/y)
        print.cccc (I 1518) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1519
        !"test1519"
        z1 <== ((q-(-p)/1.3+(-q))/(((-p)*q/(-q)+(-p))*0.4+(-p)*(-p)/(-p))*(-4.0))
        z2 <== ((y-(-x)/1.3+(-y))/(((-x)*y/(-y)+(-x))*0.4+(-x)*(-x)/(-x))*(-4.0))
        print.cccc (I 1519) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1520
        !"test1520"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 1520) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1521
        !"test1521"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 1521) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1522
        !"test1522"
        z1 <== q
        z2 <== y
        print.cccc (I 1522) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1523
        !"test1523"
        z1 <== ((-8.7)/(-q)+8.7)
        z2 <== ((-8.7)/(-y)+8.7)
        print.cccc (I 1523) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1524
        !"test1524"
        z1 <== (((3.0-(-1.5)*2.0-p/p)-(-3.8)-((-q)-(-3.0)+(-6.1)+p)*((-p)*(-0.5)*(-6.5)/(-p)-q))/(-5.4)*(-1.2))
        z2 <== (((3.0-(-1.5)*2.0-x/x)-(-3.8)-((-y)-(-3.0)+(-6.1)+x)*((-x)*(-0.5)*(-6.5)/(-x)-y))/(-5.4)*(-1.2))
        print.cccc (I 1524) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1525
        !"test1525"
        z1 <== (2.6*(4.4/(6.1-(-6.3)-8.4)*(-7.2)+(-0.5)-2.8+(-5.0))/p+(-1.6))
        z2 <== (2.6*(4.4/(6.1-(-6.3)-8.4)*(-7.2)+(-0.5)-2.8+(-5.0))/x+(-1.6))
        print.cccc (I 1525) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1526
        !"test1526"
        z1 <== (1.6*((-7.3)/(-p))/(((-p)*q-q)+(-3.2)+(-q))*((-3.7)/(p+(-p)*(-7.7)/5.4))*(-4.8))
        z2 <== (1.6*((-7.3)/(-x))/(((-x)*y-y)+(-3.2)+(-y))*((-3.7)/(x+(-x)*(-7.7)/5.4))*(-4.8))
        print.cccc (I 1526) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1527
        !"test1527"
        z1 <== ((((-p)+q*7.3-(-q)/(-2.6))+(q-(-q))-q+(-3.8)-1.7*(-p)+(-0.0)-(-4.6))+(-q)+6.2)
        z2 <== ((((-x)+y*7.3-(-y)/(-2.6))+(y-(-y))-y+(-3.8)-1.7*(-x)+(-0.0)-(-4.6))+(-y)+6.2)
        print.cccc (I 1527) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1528
        !"test1528"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 1528) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1529
        !"test1529"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1529) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1530
        !"test1530"
        z1 <== ((-5.0)+1.7)
        z2 <== ((-5.0)+1.7)
        print.cccc (I 1530) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1531
        !"test1531"
        z1 <== ((-p)-p-(-q)+2.6+0.1-3.0-4.1)*p-((-5.1)*(-p)-(-6.8))*(8.5-8.4/(p+(-q)-p/4.2))+(((-p))-((-0.8))-((-4.1))+(-2.1)-0.1)-(3.3*(-1.6)+(-8.8)*(-4.1)*8.7)
        z2 <== ((-x)-x-(-y)+2.6+0.1-3.0-4.1)*x-((-5.1)*(-x)-(-6.8))*(8.5-8.4/(x+(-y)-x/4.2))+(((-x))-((-0.8))-((-4.1))+(-2.1)-0.1)-(3.3*(-1.6)+(-8.8)*(-4.1)*8.7)
        print.cccc (I 1531) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1532
        !"test1532"
        z1 <== q+((-6.1)/4.2-((-q)/6.7+(-7.4)+p)/(-q))
        z2 <== y+((-6.1)/4.2-((-y)/6.7+(-7.4)+x)/(-y))
        print.cccc (I 1532) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1533
        !"test1533"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 1533) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1534
        !"test1534"
        z1 <== q
        z2 <== y
        print.cccc (I 1534) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1535
        !"test1535"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1535) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1536
        !"test1536"
        z1 <== p
        z2 <== x
        print.cccc (I 1536) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1537
        !"test1537"
        z1 <== 4.7-(-3.2)+p*(1.3)+(-2.2)
        z2 <== 4.7-(-3.2)+x*(1.3)+(-2.2)
        print.cccc (I 1537) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1538
        !"test1538"
        z1 <== ((-3.4)+(p-p))
        z2 <== ((-3.4)+(x-x))
        print.cccc (I 1538) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1539
        !"test1539"
        z1 <== (((7.0))/(((-1.5)-(-6.2)/(-8.4)+(-5.0))*(-3.4)-((-5.2)*(-0.4)/(-6.4)/(-2.2))*p+p/q+((-q)*(-0.1))))
        z2 <== (((7.0))/(((-1.5)-(-6.2)/(-8.4)+(-5.0))*(-3.4)-((-5.2)*(-0.4)/(-6.4)/(-2.2))*x+x/y+((-y)*(-0.1))))
        print.cccc (I 1539) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1540
        !"test1540"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1540) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1541
        !"test1541"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1541) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1542
        !"test1542"
        z1 <== (2.5*(-5.2)/((-0.2)+(-6.1)/8.8-1.6-(p-(-q)+(-p)+p-(-1.1))+(7.7+(-1.5)-p-(-3.8)))*q+q-(-6.4)*(-q)+4.1-(8.5)/(-0.0)*((-1.6)-p))
        z2 <== (2.5*(-5.2)/((-0.2)+(-6.1)/8.8-1.6-(x-(-y)+(-x)+x-(-1.1))+(7.7+(-1.5)-x-(-3.8)))*y+y-(-6.4)*(-y)+4.1-(8.5)/(-0.0)*((-1.6)-x))
        print.cccc (I 1542) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1543
        !"test1543"
        z1 <== q-((-7.2)+q*(-1.7)/(p-q+(-1.6)*(-6.2))+(p*(-7.1)+(-q)/(-0.8)+q))+q-((q+q-6.0+(-p)))/(6.7/(-q)*((-0.3))*(-8.4)-((-p)*6.3/q-(-q)))
        z2 <== y-((-7.2)+y*(-1.7)/(x-y+(-1.6)*(-6.2))+(x*(-7.1)+(-y)/(-0.8)+y))+y-((y+y-6.0+(-x)))/(6.7/(-y)*((-0.3))*(-8.4)-((-x)*6.3/y-(-y)))
        print.cccc (I 1543) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1544
        !"test1544"
        z1 <== (q-(-p)/(-5.7)+0.3/6.2*8.2+((-6.5)+p*p/(-3.2)/q)/(-p)*(-0.6)+((7.0-p*(-p)/(-p))-((-q)*(-8.3)*(-2.4)/q)-((-4.4))-7.4))
        z2 <== (y-(-x)/(-5.7)+0.3/6.2*8.2+((-6.5)+x*x/(-3.2)/y)/(-x)*(-0.6)+((7.0-x*(-x)/(-x))-((-y)*(-8.3)*(-2.4)/y)-((-4.4))-7.4))
        print.cccc (I 1544) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1545
        !"test1545"
        z1 <== (((q-2.0/q/3.3)+(-2.7)*((-q)-q+(-p))/p/p+p-(-7.4)+1.5+(-p)))
        z2 <== (((y-2.0/y/3.3)+(-2.7)*((-y)-y+(-x))/x/x+x-(-7.4)+1.5+(-x)))
        print.cccc (I 1545) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1546
        !"test1546"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 1546) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1547
        !"test1547"
        z1 <== (((-q)/(-p))-(5.3+(q+(-2.6))/(-p)+7.6)-7.4/q)
        z2 <== (((-y)/(-x))-(5.3+(y+(-2.6))/(-x)+7.6)-7.4/y)
        print.cccc (I 1547) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1548
        !"test1548"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 1548) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1549
        !"test1549"
        z1 <== (((p+4.3*4.6)/6.6*2.7/((-p)*0.3*q*(-5.4)/(-p))+(8.2/4.2*7.7))-(8.1/3.3*4.7*0.3/((-7.1)*(-0.1)/1.5+7.7)-4.0))
        z2 <== (((x+4.3*4.6)/6.6*2.7/((-x)*0.3*y*(-5.4)/(-x))+(8.2/4.2*7.7))-(8.1/3.3*4.7*0.3/((-7.1)*(-0.1)/1.5+7.7)-4.0))
        print.cccc (I 1549) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1550
        !"test1550"
        z1 <== ((-0.1))
        z2 <== ((-0.1))
        print.cccc (I 1550) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1551
        !"test1551"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1551) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1552
        !"test1552"
        z1 <== ((-3.4))
        z2 <== ((-3.4))
        print.cccc (I 1552) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1553
        !"test1553"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1553) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1554
        !"test1554"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 1554) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1555
        !"test1555"
        z1 <== (-q)*(-8.0)+(-5.8)/(q/(-3.1)*p+0.0-4.5*(-q)*q-8.8-2.5)
        z2 <== (-y)*(-8.0)+(-5.8)/(y/(-3.1)*x+0.0-4.5*(-y)*y-8.8-2.5)
        print.cccc (I 1555) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1556
        !"test1556"
        z1 <== ((-q)-(((-q))+(6.1/q+p+(-q))+(q+q/p/3.4))+(-3.5)*(6.3+(-0.1)*(-2.7)+((-p)*(-p)/(-2.6))+(q-2.3+(-8.7))-(-p)-(-6.4)))
        z2 <== ((-y)-(((-y))+(6.1/y+x+(-y))+(y+y/x/3.4))+(-3.5)*(6.3+(-0.1)*(-2.7)+((-x)*(-x)/(-2.6))+(y-2.3+(-8.7))-(-x)-(-6.4)))
        print.cccc (I 1556) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1557
        !"test1557"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 1557) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1558
        !"test1558"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 1558) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1559
        !"test1559"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1559) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1560
        !"test1560"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 1560) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1561
        !"test1561"
        z1 <== ((((-8.3)+1.5+(-p)+(-7.0))-(-q)/(q+(-1.2))/(-5.0)*(-q))*(-4.7)/(5.8+4.8-p+5.6+(-p))*1.0)
        z2 <== ((((-8.3)+1.5+(-x)+(-7.0))-(-y)/(y+(-1.2))/(-5.0)*(-y))*(-4.7)/(5.8+4.8-x+5.6+(-x))*1.0)
        print.cccc (I 1561) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1562
        !"test1562"
        z1 <== q+p
        z2 <== y+x
        print.cccc (I 1562) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1563
        !"test1563"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1563) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1564
        !"test1564"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 1564) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1565
        !"test1565"
        z1 <== p
        z2 <== x
        print.cccc (I 1565) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1566
        !"test1566"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 1566) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1567
        !"test1567"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1567) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1568
        !"test1568"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 1568) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1569
        !"test1569"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 1569) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1570
        !"test1570"
        z1 <== (-4.4)
        z2 <== (-4.4)
        print.cccc (I 1570) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1571
        !"test1571"
        z1 <== 6.6-p-0.4
        z2 <== 6.6-x-0.4
        print.cccc (I 1571) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1572
        !"test1572"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1572) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1573
        !"test1573"
        z1 <== ((q+(-7.0)*(-4.5)+(-0.2)+5.1+(-p)*(-5.2))/q/(-3.1)-6.5)
        z2 <== ((y+(-7.0)*(-4.5)+(-0.2)+5.1+(-x)*(-5.2))/y/(-3.1)-6.5)
        print.cccc (I 1573) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1574
        !"test1574"
        z1 <== (((-1.2))/2.5/1.6*(((-8.1)-2.2*3.4*p)/((-6.0)/q)-(-3.4)/((-q)/q*6.0/(-7.5))*3.2))
        z2 <== (((-1.2))/2.5/1.6*(((-8.1)-2.2*3.4*x)/((-6.0)/y)-(-3.4)/((-y)/y*6.0/(-7.5))*3.2))
        print.cccc (I 1574) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1575
        !"test1575"
        z1 <== (p/(5.7/q)/(((-3.1)/0.3/7.6*(-4.1)+(-p))+((-8.8)+0.6*(-p)+(-q)*(-3.0))/((-q)/(-p)/p)+(2.6/(-q))+(-6.6))/p*(p-((-p)+q)+p*1.5/0.0/p-(-q)*(4.4+(-0.8)/(-4.0))))
        z2 <== (x/(5.7/y)/(((-3.1)/0.3/7.6*(-4.1)+(-x))+((-8.8)+0.6*(-x)+(-y)*(-3.0))/((-y)/(-x)/x)+(2.6/(-y))+(-6.6))/x*(x-((-x)+y)+x*1.5/0.0/x-(-y)*(4.4+(-0.8)/(-4.0))))
        print.cccc (I 1575) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1576
        !"test1576"
        z1 <== (((8.5+(-p)))*((-2.0)-(-4.7)-(p*p/(-0.3)*p/5.2)-(-8.5))+(p*(-p)*(-1.6)*5.8/((-1.8)/(-7.0)*3.3))/(-q)*((-q)*q*(4.0)))
        z2 <== (((8.5+(-x)))*((-2.0)-(-4.7)-(x*x/(-0.3)*x/5.2)-(-8.5))+(x*(-x)*(-1.6)*5.8/((-1.8)/(-7.0)*3.3))/(-y)*((-y)*y*(4.0)))
        print.cccc (I 1576) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1577
        !"test1577"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1577) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1578
        !"test1578"
        z1 <== (((-7.1)/(-q)/((-6.1))/(p/(-q)))/((p/4.1)*q/p+(-p)+(-p)+p*(2.4*(-q)+p-0.0*q)/1.1/q*q*(-q)*p))
        z2 <== (((-7.1)/(-y)/((-6.1))/(x/(-y)))/((x/4.1)*y/x+(-x)+(-x)+x*(2.4*(-y)+x-0.0*y)/1.1/y*y*(-y)*x))
        print.cccc (I 1578) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1579
        !"test1579"
        z1 <== q-((-q)/p+(3.6-8.8-(-5.4)-(-q)/3.6))*(-q)
        z2 <== y-((-y)/x+(3.6-8.8-(-5.4)-(-y)/3.6))*(-y)
        print.cccc (I 1579) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1580
        !"test1580"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 1580) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1581
        !"test1581"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 1581) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1582
        !"test1582"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1582) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1583
        !"test1583"
        z1 <== ((-p)-q/(-5.0)+(-q))/(p*(-q)/(1.7/(-p)-p/(-8.2)))-(3.6*(-0.1)-1.3+(p))
        z2 <== ((-x)-y/(-5.0)+(-y))/(x*(-y)/(1.7/(-x)-x/(-8.2)))-(3.6*(-0.1)-1.3+(x))
        print.cccc (I 1583) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1584
        !"test1584"
        z1 <== p
        z2 <== x
        print.cccc (I 1584) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1585
        !"test1585"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1585) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1586
        !"test1586"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 1586) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1587
        !"test1587"
        z1 <== p*(p+((-8.2)/(-q)*(-7.7)+(-0.4)+(-p))+5.6)+((p*(-7.4))-p+q/q+(-q))*1.0*2.6
        z2 <== x*(x+((-8.2)/(-y)*(-7.7)+(-0.4)+(-x))+5.6)+((x*(-7.4))-x+y/y+(-y))*1.0*2.6
        print.cccc (I 1587) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1588
        !"test1588"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1588) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1589
        !"test1589"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 1589) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1590
        !"test1590"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 1590) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1591
        !"test1591"
        z1 <== q
        z2 <== y
        print.cccc (I 1591) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1592
        !"test1592"
        z1 <== (-7.1)*8.5/((5.5)-(-2.8)+(p+(-q))+q/(-2.8))
        z2 <== (-7.1)*8.5/((5.5)-(-2.8)+(x+(-y))+y/(-2.8))
        print.cccc (I 1592) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1593
        !"test1593"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1593) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1594
        !"test1594"
        z1 <== (((5.6/5.3-6.2))-(-8.0)*(-3.6)-((-1.3)*4.2)/0.0+(6.1/(-p)+p)*((-q)-(-5.0)*q))
        z2 <== (((5.6/5.3-6.2))-(-8.0)*(-3.6)-((-1.3)*4.2)/0.0+(6.1/(-x)+x)*((-y)-(-5.0)*y))
        print.cccc (I 1594) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1595
        !"test1595"
        z1 <== (((-8.0)/p-(-6.5)-5.7/(-8.5))/(q/(-p)*(-q)/(-7.1)*(-0.4))/(-7.3)/(-3.1)+q/3.0/q-8.4+q-(-q)-(-3.1)/(-2.8)*(-0.7))+(((-1.2)+(-q)))-(p/(-6.0)+(-1.2)+3.6+(-p)+(-4.0)/(-8.5)+q-(7.6+(-p)+8.0*(-p))*(-q)*5.2)
        z2 <== (((-8.0)/x-(-6.5)-5.7/(-8.5))/(y/(-x)*(-y)/(-7.1)*(-0.4))/(-7.3)/(-3.1)+y/3.0/y-8.4+y-(-y)-(-3.1)/(-2.8)*(-0.7))+(((-1.2)+(-y)))-(x/(-6.0)+(-1.2)+3.6+(-x)+(-4.0)/(-8.5)+y-(7.6+(-x)+8.0*(-x))*(-y)*5.2)
        print.cccc (I 1595) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1596
        !"test1596"
        z1 <== (q*((-q)-((-q)-3.0*1.7-(-3.6)+q))-(-1.0))
        z2 <== (y*((-y)-((-y)-3.0*1.7-(-3.6)+y))-(-1.0))
        print.cccc (I 1596) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1597
        !"test1597"
        z1 <== ((-8.3))
        z2 <== ((-8.3))
        print.cccc (I 1597) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1598
        !"test1598"
        z1 <== (-q)-((p-(-7.4)/(-4.5))/p-(-p))+q
        z2 <== (-y)-((x-(-7.4)/(-4.5))/x-(-x))+y
        print.cccc (I 1598) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1599
        !"test1599"
        z1 <== ((((-7.8))*(4.6+q*6.5)*(6.2+(-7.8))*(-q)*3.4)/(((-0.2)*3.6)+(-8.3)+((-1.2)+(-7.4))*(5.8-0.2-2.5+q+(-0.7))*((-q)+q))-(-p))
        z2 <== ((((-7.8))*(4.6+y*6.5)*(6.2+(-7.8))*(-y)*3.4)/(((-0.2)*3.6)+(-8.3)+((-1.2)+(-7.4))*(5.8-0.2-2.5+y+(-0.7))*((-y)+y))-(-x))
        print.cccc (I 1599) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1600
        !"test1600"
        z1 <== ((p+(4.4-q+q+(-3.7)+(-q)))/p)
        z2 <== ((x+(4.4-y+y+(-3.7)+(-y)))/x)
        print.cccc (I 1600) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1601
        !"test1601"
        z1 <== ((5.1)/(((-q)))/(-q)/((8.8)/(-q)+(-7.8)-q/3.6+(-8.5)))
        z2 <== ((5.1)/(((-y)))/(-y)/((8.8)/(-y)+(-7.8)-y/3.6+(-8.5)))
        print.cccc (I 1601) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1602
        !"test1602"
        z1 <== (0.2+((-5.5)))
        z2 <== (0.2+((-5.5)))
        print.cccc (I 1602) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1603
        !"test1603"
        z1 <== ((((-p)+(-p)*(-7.5)/0.2-(-q))*(-q)-2.5*(-4.3)*q)+(-q)/((q*8.8-5.1*5.0)-((-6.1)-(-q))))
        z2 <== ((((-x)+(-x)*(-7.5)/0.2-(-y))*(-y)-2.5*(-4.3)*y)+(-y)/((y*8.8-5.1*5.0)-((-6.1)-(-y))))
        print.cccc (I 1603) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1604
        !"test1604"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 1604) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1605
        !"test1605"
        z1 <== ((((-2.6)))/(-p)-(p)/8.6*((-3.0)+q)-((-q)+p*(-q)*q)+q-(-5.5)+2.6-(-q)/(-p)/p/p)
        z2 <== ((((-2.6)))/(-x)-(x)/8.6*((-3.0)+y)-((-y)+x*(-y)*y)+y-(-5.5)+2.6-(-y)/(-x)/x/x)
        print.cccc (I 1605) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1606
        !"test1606"
        z1 <== 3.5
        z2 <== 3.5
        print.cccc (I 1606) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1607
        !"test1607"
        z1 <== (-7.4)
        z2 <== (-7.4)
        print.cccc (I 1607) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1608
        !"test1608"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1608) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1609
        !"test1609"
        z1 <== (((-6.2))*(8.0*(-p)*(-p)-(-p))+(-q)+q+((-q)+(-0.3)-3.8)+((-6.8)*(-0.8)-(-p)+(-0.4)/3.2)+0.4*(-p)+p)
        z2 <== (((-6.2))*(8.0*(-x)*(-x)-(-x))+(-y)+y+((-y)+(-0.3)-3.8)+((-6.8)*(-0.8)-(-x)+(-0.4)/3.2)+0.4*(-x)+x)
        print.cccc (I 1609) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1610
        !"test1610"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1610) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1611
        !"test1611"
        z1 <== (p/((q-3.0))-(-p)*6.7)
        z2 <== (x/((y-3.0))-(-x)*6.7)
        print.cccc (I 1611) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1612
        !"test1612"
        z1 <== (((4.1*(-6.4))+((-p)-2.4-(-q)))*p+6.3)
        z2 <== (((4.1*(-6.4))+((-x)-2.4-(-y)))*x+6.3)
        print.cccc (I 1612) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1613
        !"test1613"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 1613) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1614
        !"test1614"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1614) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1615
        !"test1615"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1615) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1616
        !"test1616"
        z1 <== ((((-p)*4.1*1.5)-((-p)+(-q)+4.3*6.8))/(((-5.6)/8.5+(-3.7))/(-8.1))*((-p)-(-7.2))-(q/(-3.7)-(-q)+5.4-1.7)/(-q))
        z2 <== ((((-x)*4.1*1.5)-((-x)+(-y)+4.3*6.8))/(((-5.6)/8.5+(-3.7))/(-8.1))*((-x)-(-7.2))-(y/(-3.7)-(-y)+5.4-1.7)/(-y))
        print.cccc (I 1616) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1617
        !"test1617"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1617) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1618
        !"test1618"
        z1 <== (((-2.4))*((p+1.2)*8.8/3.2/1.6)+p*5.5*(-q))
        z2 <== (((-2.4))*((x+1.2)*8.8/3.2/1.6)+x*5.5*(-y))
        print.cccc (I 1618) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1619
        !"test1619"
        z1 <== (((q*(-q)/(-p))/4.0/((-q)-8.7*p))-(-5.6)*((-5.2)+(1.7+2.0/3.5)/(6.5-(-4.7)/p/7.6-q)*((-p)*(-4.4)/4.7)/(2.6+p)))
        z2 <== (((y*(-y)/(-x))/4.0/((-y)-8.7*x))-(-5.6)*((-5.2)+(1.7+2.0/3.5)/(6.5-(-4.7)/x/7.6-y)*((-x)*(-4.4)/4.7)/(2.6+x)))
        print.cccc (I 1619) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1620
        !"test1620"
        z1 <== (q/q/3.2)
        z2 <== (y/y/3.2)
        print.cccc (I 1620) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1621
        !"test1621"
        z1 <== p
        z2 <== x
        print.cccc (I 1621) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1622
        !"test1622"
        z1 <== 2.8-q*((p/p-(-0.3)))*(((-7.3)+4.6-q/p-q)*p+(-q)+p)+p
        z2 <== 2.8-y*((x/x-(-0.3)))*(((-7.3)+4.6-y/x-y)*x+(-y)+x)+x
        print.cccc (I 1622) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1623
        !"test1623"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1623) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1624
        !"test1624"
        z1 <== ((((-1.0)*p/q-6.5+(-5.4))-((-6.3)*2.2-1.0-(-1.1)-(-1.8))-(-p)-(p/(-0.4)-q+2.8+(-3.5)))-((q*q)+((-1.3)+(-3.7)/0.3)+q-(-0.0)*(-p)+(-q))-(-p))
        z2 <== ((((-1.0)*x/y-6.5+(-5.4))-((-6.3)*2.2-1.0-(-1.1)-(-1.8))-(-x)-(x/(-0.4)-y+2.8+(-3.5)))-((y*y)+((-1.3)+(-3.7)/0.3)+y-(-0.0)*(-x)+(-y))-(-x))
        print.cccc (I 1624) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1625
        !"test1625"
        z1 <== q
        z2 <== y
        print.cccc (I 1625) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1626
        !"test1626"
        z1 <== q
        z2 <== y
        print.cccc (I 1626) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1627
        !"test1627"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1627) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1628
        !"test1628"
        z1 <== (8.5*(-p))
        z2 <== (8.5*(-x))
        print.cccc (I 1628) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1629
        !"test1629"
        z1 <== ((q*p/(4.0*(-q))))
        z2 <== ((y*x/(4.0*(-y))))
        print.cccc (I 1629) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1630
        !"test1630"
        z1 <== (p/q-((-5.2))*(4.6+((-q))/((-p)*(-q)+(-p)/(-q))*p))
        z2 <== (x/y-((-5.2))*(4.6+((-y))/((-x)*(-y)+(-x)/(-y))*x))
        print.cccc (I 1630) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1631
        !"test1631"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1631) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1632
        !"test1632"
        z1 <== (5.5*(-0.5)/p/(((-q)/p+3.0)*p-q/((-q)+4.2))*p-4.4*(-2.6))
        z2 <== (5.5*(-0.5)/x/(((-y)/x+3.0)*x-y/((-y)+4.2))*x-4.4*(-2.6))
        print.cccc (I 1632) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1633
        !"test1633"
        z1 <== ((-0.7)-(-7.1))
        z2 <== ((-0.7)-(-7.1))
        print.cccc (I 1633) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1634
        !"test1634"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 1634) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1635
        !"test1635"
        z1 <== (-3.2)
        z2 <== (-3.2)
        print.cccc (I 1635) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1636
        !"test1636"
        z1 <== q
        z2 <== y
        print.cccc (I 1636) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1637
        !"test1637"
        z1 <== q
        z2 <== y
        print.cccc (I 1637) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1638
        !"test1638"
        z1 <== (p-p+((-q)*8.0+(-7.8)+(-q)))
        z2 <== (x-x+((-y)*8.0+(-7.8)+(-y)))
        print.cccc (I 1638) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1639
        !"test1639"
        z1 <== 7.6
        z2 <== 7.6
        print.cccc (I 1639) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1640
        !"test1640"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1640) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1641
        !"test1641"
        z1 <== ((-1.1))
        z2 <== ((-1.1))
        print.cccc (I 1641) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1642
        !"test1642"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 1642) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1643
        !"test1643"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 1643) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1644
        !"test1644"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1644) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1645
        !"test1645"
        z1 <== (-2.7)
        z2 <== (-2.7)
        print.cccc (I 1645) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1646
        !"test1646"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1646) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1647
        !"test1647"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 1647) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1648
        !"test1648"
        z1 <== ((2.0+((-0.4)+3.2*7.3-(-p)+(-q)))+(((-4.0)+p*8.6*(-2.1)+(-q)))-((p+(-1.6)/(-3.2))+q+(q+3.3*3.7*6.6)/8.4)-((-p)/(-1.7)-(-0.3))-((p/p/(-p)+q)+((-q)+(-q)/(-p)+(-7.3))-2.2+((-p)-(-p)+(-7.4)/(-q)-(-p))+8.8))
        z2 <== ((2.0+((-0.4)+3.2*7.3-(-x)+(-y)))+(((-4.0)+x*8.6*(-2.1)+(-y)))-((x+(-1.6)/(-3.2))+y+(y+3.3*3.7*6.6)/8.4)-((-x)/(-1.7)-(-0.3))-((x/x/(-x)+y)+((-y)+(-y)/(-x)+(-7.3))-2.2+((-x)-(-x)+(-7.4)/(-y)-(-x))+8.8))
        print.cccc (I 1648) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1649
        !"test1649"
        z1 <== p
        z2 <== x
        print.cccc (I 1649) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1650
        !"test1650"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1650) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1651
        !"test1651"
        z1 <== ((-q)/((-q)*q))
        z2 <== ((-y)/((-y)*y))
        print.cccc (I 1651) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1652
        !"test1652"
        z1 <== (((-p)-(-q)+(-5.8)*((-3.8)/q*q/q)*q)/((-4.3)+((-2.0))*8.6*5.1-(-q)+(-0.3)-(-8.5)*(-q)-5.6)+((-q)+(7.1*p/7.6*q/p)*8.6)*(-p))
        z2 <== (((-x)-(-y)+(-5.8)*((-3.8)/y*y/y)*y)/((-4.3)+((-2.0))*8.6*5.1-(-y)+(-0.3)-(-8.5)*(-y)-5.6)+((-y)+(7.1*x/7.6*y/x)*8.6)*(-x))
        print.cccc (I 1652) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1653
        !"test1653"
        z1 <== (((-q)/7.4*p-(-p)+(-p)/(-p)/(q/(-p)/(-p)+6.7)+(-7.0))-((p*p+(-p)+p-q)/(-q)*(2.6-p+(-0.7)/(-p)*q)/(-6.8))+(3.6*(-8.5)/(-6.0)+(-0.3)-(q+5.7-(-3.0)+2.3)-((-p)-(-1.1))-(-2.7)))
        z2 <== (((-y)/7.4*x-(-x)+(-x)/(-x)/(y/(-x)/(-x)+6.7)+(-7.0))-((x*x+(-x)+x-y)/(-y)*(2.6-x+(-0.7)/(-x)*y)/(-6.8))+(3.6*(-8.5)/(-6.0)+(-0.3)-(y+5.7-(-3.0)+2.3)-((-x)-(-1.1))-(-2.7)))
        print.cccc (I 1653) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1654
        !"test1654"
        z1 <== (p*(-p)+(q)+q)
        z2 <== (x*(-x)+(y)+y)
        print.cccc (I 1654) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1655
        !"test1655"
        z1 <== ((-p)-p/(p-q+1.0-(-q))/(-8.8)/(((-q)/(-p)+q)+(-2.0)-p))
        z2 <== ((-x)-x/(x-y+1.0-(-y))/(-8.8)/(((-y)/(-x)+y)+(-2.0)-x))
        print.cccc (I 1655) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1656
        !"test1656"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1656) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1657
        !"test1657"
        z1 <== (7.8*(2.6-(-3.4)+(-q)-p/(-3.0)/(-p)-(-p)-7.2))
        z2 <== (7.8*(2.6-(-3.4)+(-y)-x/(-3.0)/(-x)-(-x)-7.2))
        print.cccc (I 1657) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1658
        !"test1658"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 1658) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1659
        !"test1659"
        z1 <== q
        z2 <== y
        print.cccc (I 1659) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1660
        !"test1660"
        z1 <== ((((-q))+((-2.8)*p-3.2)+(-7.2)-2.5-6.4/p*(-p))/((-6.5)+(-q)/8.3-p)+(-p)-8.8*q)
        z2 <== ((((-y))+((-2.8)*x-3.2)+(-7.2)-2.5-6.4/x*(-x))/((-6.5)+(-y)/8.3-x)+(-x)-8.8*y)
        print.cccc (I 1660) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1661
        !"test1661"
        z1 <== ((p-4.0))
        z2 <== ((x-4.0))
        print.cccc (I 1661) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1662
        !"test1662"
        z1 <== (p*(-2.6))
        z2 <== (x*(-2.6))
        print.cccc (I 1662) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1663
        !"test1663"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1663) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1664
        !"test1664"
        z1 <== p
        z2 <== x
        print.cccc (I 1664) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1665
        !"test1665"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1665) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1666
        !"test1666"
        z1 <== ((-1.1)+((-3.1)/q*6.6/1.2-7.5))
        z2 <== ((-1.1)+((-3.1)/y*6.6/1.2-7.5))
        print.cccc (I 1666) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1667
        !"test1667"
        z1 <== q
        z2 <== y
        print.cccc (I 1667) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1668
        !"test1668"
        z1 <== ((-6.1)+6.6/((p*2.1+(-q)/(-q))/(-4.8)/(-6.3)))
        z2 <== ((-6.1)+6.6/((x*2.1+(-y)/(-y))/(-4.8)/(-6.3)))
        print.cccc (I 1668) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1669
        !"test1669"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 1669) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1670
        !"test1670"
        z1 <== (((8.1)+(5.5*(-0.7)-p/3.0+q)-q/1.4/0.4+8.4/(-p)/(-6.1)))
        z2 <== (((8.1)+(5.5*(-0.7)-x/3.0+y)-y/1.4/0.4+8.4/(-x)/(-6.1)))
        print.cccc (I 1670) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1671
        !"test1671"
        z1 <== (p)-p-((-q))/(5.0-(-3.4))/(((-6.0)-p)*(p))
        z2 <== (x)-x-((-y))/(5.0-(-3.4))/(((-6.0)-x)*(x))
        print.cccc (I 1671) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1672
        !"test1672"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 1672) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1673
        !"test1673"
        z1 <== ((-p)+q/(-p)*((6.2/6.0-q+(-p)*q)/(3.4-(-q)-(-q)+(-q)))/(-7.8))
        z2 <== ((-x)+y/(-x)*((6.2/6.0-y+(-x)*y)/(3.4-(-y)-(-y)+(-y)))/(-7.8))
        print.cccc (I 1673) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1674
        !"test1674"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1674) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1675
        !"test1675"
        z1 <== p
        z2 <== x
        print.cccc (I 1675) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1676
        !"test1676"
        z1 <== p
        z2 <== x
        print.cccc (I 1676) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1677
        !"test1677"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1677) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1678
        !"test1678"
        z1 <== (((-q)+(-4.8)*p)/(-0.3)*(-0.0)+(-p)+(-q)+(-q))
        z2 <== (((-y)+(-4.8)*x)/(-0.3)*(-0.0)+(-x)+(-y)+(-y))
        print.cccc (I 1678) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1679
        !"test1679"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 1679) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1680
        !"test1680"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 1680) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1681
        !"test1681"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 1681) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1682
        !"test1682"
        z1 <== ((p+7.2-(-p)-((-8.4)/7.0)*((-0.1)+p/p*1.4-p)-5.6)*0.4/(((-3.0)/q/(-p))*(8.3*0.7+(-6.8)*p)-((-8.7)+(-4.6))))
        z2 <== ((x+7.2-(-x)-((-8.4)/7.0)*((-0.1)+x/x*1.4-x)-5.6)*0.4/(((-3.0)/y/(-x))*(8.3*0.7+(-6.8)*x)-((-8.7)+(-4.6))))
        print.cccc (I 1682) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1683
        !"test1683"
        z1 <== (-q)/(-4.0)/((q+4.6/(-p))-(-0.5)*(q*(-q)+(-p))+8.3+q)-p
        z2 <== (-y)/(-4.0)/((y+4.6/(-x))-(-0.5)*(y*(-y)+(-x))+8.3+y)-x
        print.cccc (I 1683) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1684
        !"test1684"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 1684) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1685
        !"test1685"
        z1 <== ((-p)+3.3/(0.3)/(-p))
        z2 <== ((-x)+3.3/(0.3)/(-x))
        print.cccc (I 1685) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1686
        !"test1686"
        z1 <== ((-0.8))
        z2 <== ((-0.8))
        print.cccc (I 1686) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1687
        !"test1687"
        z1 <== ((4.8)*q/((-4.4)/q+(p*7.7/q*(-p)+(-6.8))*(-p)+(-q)-(-3.7)+(-q)-(-p)*(5.2-(-p)*(-p)))*(-q)/4.5+p)
        z2 <== ((4.8)*y/((-4.4)/y+(x*7.7/y*(-x)+(-6.8))*(-x)+(-y)-(-3.7)+(-y)-(-x)*(5.2-(-x)*(-x)))*(-y)/4.5+x)
        print.cccc (I 1687) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1688
        !"test1688"
        z1 <== (q-(-q))
        z2 <== (y-(-y))
        print.cccc (I 1688) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1689
        !"test1689"
        z1 <== q
        z2 <== y
        print.cccc (I 1689) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1690
        !"test1690"
        z1 <== ((p/(0.7*(-1.3)+(-5.7)*(-q)+(-p)))*6.6+(-p)+(-3.5)/((-p)-1.4/1.8/(-0.4)*(8.8)+(-0.8)))
        z2 <== ((x/(0.7*(-1.3)+(-5.7)*(-y)+(-x)))*6.6+(-x)+(-3.5)/((-x)-1.4/1.8/(-0.4)*(8.8)+(-0.8)))
        print.cccc (I 1690) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1691
        !"test1691"
        z1 <== (((-1.5)/(-p)+(-8.3)-2.0-(-q))+(-0.4))
        z2 <== (((-1.5)/(-x)+(-8.3)-2.0-(-y))+(-0.4))
        print.cccc (I 1691) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1692
        !"test1692"
        z1 <== p
        z2 <== x
        print.cccc (I 1692) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1693
        !"test1693"
        z1 <== (-0.8)/q+6.8-(-3.5)-(-8.4)*(-8.1)-(5.3)-(q-(-q))
        z2 <== (-0.8)/y+6.8-(-3.5)-(-8.4)*(-8.1)-(5.3)-(y-(-y))
        print.cccc (I 1693) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1694
        !"test1694"
        z1 <== 2.2
        z2 <== 2.2
        print.cccc (I 1694) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1695
        !"test1695"
        z1 <== (q-p+(-q)/(((-8.0)+(-8.7)+(-p)/2.0+(-7.7))+3.6*(-q)/((-2.1))+4.8))
        z2 <== (y-x+(-y)/(((-8.0)+(-8.7)+(-x)/2.0+(-7.7))+3.6*(-y)/((-2.1))+4.8))
        print.cccc (I 1695) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1696
        !"test1696"
        z1 <== q
        z2 <== y
        print.cccc (I 1696) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1697
        !"test1697"
        z1 <== p
        z2 <== x
        print.cccc (I 1697) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1698
        !"test1698"
        z1 <== p
        z2 <== x
        print.cccc (I 1698) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1699
        !"test1699"
        z1 <== (((1.7*4.6/(-3.0))/(-q))*((-5.2))+p+(5.5+(-0.1)+p/(-7.6)*q+((-p)*(-1.6)/q)/(7.2)/(-4.7))*((-q)/(6.0/q-5.0*(-p)/8.1)))
        z2 <== (((1.7*4.6/(-3.0))/(-y))*((-5.2))+x+(5.5+(-0.1)+x/(-7.6)*y+((-x)*(-1.6)/y)/(7.2)/(-4.7))*((-y)/(6.0/y-5.0*(-x)/8.1)))
        print.cccc (I 1699) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1700
        !"test1700"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 1700) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1701
        !"test1701"
        z1 <== 4.6*((p)/p+((-q)/0.8+(-p)))
        z2 <== 4.6*((x)/x+((-y)/0.8+(-x)))
        print.cccc (I 1701) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1702
        !"test1702"
        z1 <== (p/(-0.4)*(-p)+5.7)
        z2 <== (x/(-0.4)*(-x)+5.7)
        print.cccc (I 1702) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1703
        !"test1703"
        z1 <== ((-6.8)-q/(-p)+q*(7.1-6.5)-(4.5*8.0-8.7*q+5.2*5.1-(-p))-(5.1+((-q)-(-1.8)-(-q))/((-q)+(-q)*(-q))+2.6)*(-0.8))
        z2 <== ((-6.8)-y/(-x)+y*(7.1-6.5)-(4.5*8.0-8.7*y+5.2*5.1-(-x))-(5.1+((-y)-(-1.8)-(-y))/((-y)+(-y)*(-y))+2.6)*(-0.8))
        print.cccc (I 1703) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1704
        !"test1704"
        z1 <== (5.5*5.3*(-1.5)/((-7.0)-2.7))
        z2 <== (5.5*5.3*(-1.5)/((-7.0)-2.7))
        print.cccc (I 1704) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1705
        !"test1705"
        z1 <== (8.7/7.2/(4.1-(-1.8)+(-2.4))+(3.8)/((-p)))-p+(8.6-((-p)*2.8-0.0-(-7.8))/(-2.6)*((-8.3)+p/p+p+(-p)))
        z2 <== (8.7/7.2/(4.1-(-1.8)+(-2.4))+(3.8)/((-x)))-x+(8.6-((-x)*2.8-0.0-(-7.8))/(-2.6)*((-8.3)+x/x+x+(-x)))
        print.cccc (I 1705) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1706
        !"test1706"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 1706) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1707
        !"test1707"
        z1 <== ((8.3*(-q)-p/p)+(-p)-(5.6-(q*(-q)/p+(-6.4)-(-p)))*((-p)/((-q)))-p*(-3.7))
        z2 <== ((8.3*(-y)-x/x)+(-x)-(5.6-(y*(-y)/x+(-6.4)-(-x)))*((-x)/((-y)))-x*(-3.7))
        print.cccc (I 1707) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1708
        !"test1708"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 1708) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1709
        !"test1709"
        z1 <== (((-2.2)+((-4.7))+(-6.5)*1.4+(q)*4.7)-(-q)-q+7.0-(p+p-p+(q)/(q*q+p+(-6.8)+(-2.2))*1.5*4.1))
        z2 <== (((-2.2)+((-4.7))+(-6.5)*1.4+(y)*4.7)-(-y)-y+7.0-(x+x-x+(y)/(y*y+x+(-6.8)+(-2.2))*1.5*4.1))
        print.cccc (I 1709) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1710
        !"test1710"
        z1 <== p
        z2 <== x
        print.cccc (I 1710) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1711
        !"test1711"
        z1 <== p
        z2 <== x
        print.cccc (I 1711) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1712
        !"test1712"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 1712) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1713
        !"test1713"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 1713) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1714
        !"test1714"
        z1 <== (((-8.7)+(-q)*(p-(-p)+1.6+3.5*(-p)))+(q/(-4.4)/q-(-8.8)/(-q))*(-2.4)+(-p)*5.5*0.7)
        z2 <== (((-8.7)+(-y)*(x-(-x)+1.6+3.5*(-x)))+(y/(-4.4)/y-(-8.8)/(-y))*(-2.4)+(-x)*5.5*0.7)
        print.cccc (I 1714) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1715
        !"test1715"
        z1 <== ((8.2)/((-8.6)*(1.0/(-7.0))*p+p-(-q))/6.1/(-q)+(-p)/(7.0*(-6.0)*p/8.1/p)/(-p)/2.0+(-4.7)+((-6.7)+(-p)*(2.1*(-3.8)-(-q)+(-p))))
        z2 <== ((8.2)/((-8.6)*(1.0/(-7.0))*x+x-(-y))/6.1/(-y)+(-x)/(7.0*(-6.0)*x/8.1/x)/(-x)/2.0+(-4.7)+((-6.7)+(-x)*(2.1*(-3.8)-(-y)+(-x))))
        print.cccc (I 1715) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1716
        !"test1716"
        z1 <== ((-q)+(-p))
        z2 <== ((-y)+(-x))
        print.cccc (I 1716) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1717
        !"test1717"
        z1 <== q
        z2 <== y
        print.cccc (I 1717) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1718
        !"test1718"
        z1 <== (p*((4.4*p)-3.1-2.0+8.3*(-q)))
        z2 <== (x*((4.4*x)-3.1-2.0+8.3*(-y)))
        print.cccc (I 1718) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1719
        !"test1719"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 1719) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1720
        !"test1720"
        z1 <== 8.1
        z2 <== 8.1
        print.cccc (I 1720) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1721
        !"test1721"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 1721) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1722
        !"test1722"
        z1 <== (2.7+(-4.4)/q/(0.0/(-1.8)))
        z2 <== (2.7+(-4.4)/y/(0.0/(-1.8)))
        print.cccc (I 1722) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1723
        !"test1723"
        z1 <== (((-p)-(-3.5)*(-q)-p/8.0))-q
        z2 <== (((-x)-(-3.5)*(-y)-x/8.0))-y
        print.cccc (I 1723) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1724
        !"test1724"
        z1 <== ((q)/(6.6-(-6.8)*p*p)*((-q)-(-5.2)+(-p)+(-q)+1.0)-6.5+((-2.1)*((-p)*(-5.7)-q*(-7.5)))-(-7.1)-(-p)+(-4.5))
        z2 <== ((y)/(6.6-(-6.8)*x*x)*((-y)-(-5.2)+(-x)+(-y)+1.0)-6.5+((-2.1)*((-x)*(-5.7)-y*(-7.5)))-(-7.1)-(-x)+(-4.5))
        print.cccc (I 1724) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1725
        !"test1725"
        z1 <== (1.8)
        z2 <== (1.8)
        print.cccc (I 1725) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1726
        !"test1726"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 1726) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1727
        !"test1727"
        z1 <== ((((-2.1)-p/(-q))*p)+q+((6.5-(-q)+(-q)/(-p))*p*1.2/(-6.7)*q*(5.8*5.4))/((-p)))
        z2 <== ((((-2.1)-x/(-y))*x)+y+((6.5-(-y)+(-y)/(-x))*x*1.2/(-6.7)*y*(5.8*5.4))/((-x)))
        print.cccc (I 1727) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1728
        !"test1728"
        z1 <== (-3.4)
        z2 <== (-3.4)
        print.cccc (I 1728) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1729
        !"test1729"
        z1 <== 6.7/(((-1.1)+(-0.3)+(-6.5)/(-p))*(-q)/p/(-q))/(-p)
        z2 <== 6.7/(((-1.1)+(-0.3)+(-6.5)/(-x))*(-y)/x/(-y))/(-x)
        print.cccc (I 1729) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1730
        !"test1730"
        z1 <== (p-5.8/(0.0/0.5-(-3.8)*p+p+(-2.1))-((q-4.4-(-q))/(-0.3)*(-p)/q+(5.4/(-p)-(-3.4)/(-q))))
        z2 <== (x-5.8/(0.0/0.5-(-3.8)*x+x+(-2.1))-((y-4.4-(-y))/(-0.3)*(-x)/y+(5.4/(-x)-(-3.4)/(-y))))
        print.cccc (I 1730) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1731
        !"test1731"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1731) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1732
        !"test1732"
        z1 <== ((((-q)/q*(-1.1)*q))-(-q)*((3.6)+p))
        z2 <== ((((-y)/y*(-1.1)*y))-(-y)*((3.6)+x))
        print.cccc (I 1732) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1733
        !"test1733"
        z1 <== ((-q)*((-q)-(3.1))*((q/(-0.8)/(-q)/(-p))-3.0))
        z2 <== ((-y)*((-y)-(3.1))*((y/(-0.8)/(-y)/(-x))-3.0))
        print.cccc (I 1733) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1734
        !"test1734"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1734) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1735
        !"test1735"
        z1 <== ((q*q+p-5.7)*p*((3.3))*(-p)*(-p)/((2.1*0.6*p*(-p)*p)))
        z2 <== ((y*y+x-5.7)*x*((3.3))*(-x)*(-x)/((2.1*0.6*x*(-x)*x)))
        print.cccc (I 1735) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1736
        !"test1736"
        z1 <== (-5.4)/((-6.7))+((0.6-q/(-5.8)-(-0.1)+q)*(6.4*4.6*(-2.1)-(-p))*p-(-8.2)-3.0/(-3.6)/(-p))*((-2.8)-(p*p+5.4))+(-0.0)
        z2 <== (-5.4)/((-6.7))+((0.6-y/(-5.8)-(-0.1)+y)*(6.4*4.6*(-2.1)-(-x))*x-(-8.2)-3.0/(-3.6)/(-x))*((-2.8)-(x*x+5.4))+(-0.0)
        print.cccc (I 1736) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1737
        !"test1737"
        z1 <== (2.5/(-1.7)-(-p))
        z2 <== (2.5/(-1.7)-(-x))
        print.cccc (I 1737) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1738
        !"test1738"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 1738) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1739
        !"test1739"
        z1 <== 7.6
        z2 <== 7.6
        print.cccc (I 1739) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1740
        !"test1740"
        z1 <== (((-7.3))/p)
        z2 <== (((-7.3))/x)
        print.cccc (I 1740) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1741
        !"test1741"
        z1 <== (5.8*(-6.8)-((1.6*(-p)-8.5+q)-((-q)-q*(-q)+(-p)/(-q))*(6.8/(-p)+(-p))*(-7.7)-(q+(-0.6)))-p)
        z2 <== (5.8*(-6.8)-((1.6*(-x)-8.5+y)-((-y)-y*(-y)+(-x)/(-y))*(6.8/(-x)+(-x))*(-7.7)-(y+(-0.6)))-x)
        print.cccc (I 1741) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1742
        !"test1742"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1742) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1743
        !"test1743"
        z1 <== ((0.2+(-p)+(-5.4)-q/q)-(q-5.8/(-2.7)*(-5.3)+(-8.5)))-(-4.3)/(-3.8)-((p/q/(-4.1)-1.3)+(-8.0))-(((-p))+2.5/q/(p+q*p*1.6))
        z2 <== ((0.2+(-x)+(-5.4)-y/y)-(y-5.8/(-2.7)*(-5.3)+(-8.5)))-(-4.3)/(-3.8)-((x/y/(-4.1)-1.3)+(-8.0))-(((-x))+2.5/y/(x+y*x*1.6))
        print.cccc (I 1743) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1744
        !"test1744"
        z1 <== 6.5-((5.2*(-2.5)-(-5.7)))-(-q)/(-5.5)
        z2 <== 6.5-((5.2*(-2.5)-(-5.7)))-(-y)/(-5.5)
        print.cccc (I 1744) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1745
        !"test1745"
        z1 <== p
        z2 <== x
        print.cccc (I 1745) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1746
        !"test1746"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 1746) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1747
        !"test1747"
        z1 <== ((-p)*(-q)+q+(2.7/(-q)+(-8.1)/0.3+(-4.8))-p/(-q)*5.8)
        z2 <== ((-x)*(-y)+y+(2.7/(-y)+(-8.1)/0.3+(-4.8))-x/(-y)*5.8)
        print.cccc (I 1747) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1748
        !"test1748"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1748) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1749
        !"test1749"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 1749) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1750
        !"test1750"
        z1 <== ((p*((-p)+(-p)*(-p)*(-6.3)+p)*(q-(-q))+((-8.2)))/p)
        z2 <== ((x*((-x)+(-x)*(-x)*(-6.3)+x)*(y-(-y))+((-8.2)))/x)
        print.cccc (I 1750) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1751
        !"test1751"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 1751) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1752
        !"test1752"
        z1 <== (-q)/(-q)
        z2 <== (-y)/(-y)
        print.cccc (I 1752) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1753
        !"test1753"
        z1 <== (1.5/(-p)*6.0*(8.1/(-p)/(q-(-4.3)/(-q)/(-1.7)+(-q))-((-3.2)+(-p)-(-p))-6.4))
        z2 <== (1.5/(-x)*6.0*(8.1/(-x)/(y-(-4.3)/(-y)/(-1.7)+(-y))-((-3.2)+(-x)-(-x))-6.4))
        print.cccc (I 1753) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1754
        !"test1754"
        z1 <== q
        z2 <== y
        print.cccc (I 1754) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1755
        !"test1755"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1755) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1756
        !"test1756"
        z1 <== (-5.0)/4.5
        z2 <== (-5.0)/4.5
        print.cccc (I 1756) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1757
        !"test1757"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 1757) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1758
        !"test1758"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 1758) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1759
        !"test1759"
        z1 <== (-p)+2.8-(-p)/(-6.7)+(p/6.5-1.2*(-q)/7.7)*(-2.5)
        z2 <== (-x)+2.8-(-x)/(-6.7)+(x/6.5-1.2*(-y)/7.7)*(-2.5)
        print.cccc (I 1759) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1760
        !"test1760"
        z1 <== ((-p)*(-6.7)-((-0.6)/((-p)/(-q)*(-p)/6.8)))
        z2 <== ((-x)*(-6.7)-((-0.6)/((-x)/(-y)*(-x)/6.8)))
        print.cccc (I 1760) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1761
        !"test1761"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 1761) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1762
        !"test1762"
        z1 <== ((-7.0))
        z2 <== ((-7.0))
        print.cccc (I 1762) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1763
        !"test1763"
        z1 <== ((-p)/6.8+q*((-6.0)*(-5.0)/8.8)*q-(3.3))
        z2 <== ((-x)/6.8+y*((-6.0)*(-5.0)/8.8)*y-(3.3))
        print.cccc (I 1763) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1764
        !"test1764"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 1764) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1765
        !"test1765"
        z1 <== 1.7
        z2 <== 1.7
        print.cccc (I 1765) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1766
        !"test1766"
        z1 <== (6.1-(((-6.4)/p))/(-q)*(q/(p*p*(-p)+5.1+(-p))-(-q)-(-p)/(-p)*(q+(-6.7)-0.2-(-1.3))/(-2.2))+q)
        z2 <== (6.1-(((-6.4)/x))/(-y)*(y/(x*x*(-x)+5.1+(-x))-(-y)-(-x)/(-x)*(y+(-6.7)-0.2-(-1.3))/(-2.2))+y)
        print.cccc (I 1766) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1767
        !"test1767"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 1767) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1768
        !"test1768"
        z1 <== (-3.6)-3.0*(2.4)
        z2 <== (-3.6)-3.0*(2.4)
        print.cccc (I 1768) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1769
        !"test1769"
        z1 <== ((6.7/(-5.4)+(p*(-3.3)/(-3.3)/(-8.4)*p)*(-p)/p*4.1*(q)))
        z2 <== ((6.7/(-5.4)+(x*(-3.3)/(-3.3)/(-8.4)*x)*(-x)/x*4.1*(y)))
        print.cccc (I 1769) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1770
        !"test1770"
        z1 <== (q*(p-4.0+2.0-p/(-q)-(-p))+(3.0+(-4.2)-(-1.3)))
        z2 <== (y*(x-4.0+2.0-x/(-y)-(-x))+(3.0+(-4.2)-(-1.3)))
        print.cccc (I 1770) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1771
        !"test1771"
        z1 <== (3.8)
        z2 <== (3.8)
        print.cccc (I 1771) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1772
        !"test1772"
        z1 <== (((5.7)-((-1.7)/6.2/p)+p/((-8.4)*q*(-p)/(-q)))*(4.0-((-p))+(3.3/(-q)-(-2.2)*7.3*(-5.7))*(3.1+(-p))-((-p))))
        z2 <== (((5.7)-((-1.7)/6.2/x)+x/((-8.4)*y*(-x)/(-y)))*(4.0-((-x))+(3.3/(-y)-(-2.2)*7.3*(-5.7))*(3.1+(-x))-((-x))))
        print.cccc (I 1772) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1773
        !"test1773"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1773) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1774
        !"test1774"
        z1 <== (((-2.5)*((-7.1))-(-p)+(-1.5))+(-7.7)*(((-p)*q)+(0.2-(-q))+q-7.5/2.8))
        z2 <== (((-2.5)*((-7.1))-(-x)+(-1.5))+(-7.7)*(((-x)*y)+(0.2-(-y))+y-7.5/2.8))
        print.cccc (I 1774) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1775
        !"test1775"
        z1 <== (q*(-p)*(-3.8)+((-5.6)/(-q)))
        z2 <== (y*(-x)*(-3.8)+((-5.6)/(-y)))
        print.cccc (I 1775) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1776
        !"test1776"
        z1 <== (p-((-q)*2.7*q)-(6.5))*(-5.1)*7.4*p/6.8+(8.4/p/p-(-q)-8.7)-(-5.7)*((q+(-6.0)+(-4.6)-p+(-6.2))*(0.4+3.1)+(-p)-6.0)
        z2 <== (x-((-y)*2.7*y)-(6.5))*(-5.1)*7.4*x/6.8+(8.4/x/x-(-y)-8.7)-(-5.7)*((y+(-6.0)+(-4.6)-x+(-6.2))*(0.4+3.1)+(-x)-6.0)
        print.cccc (I 1776) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1777
        !"test1777"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 1777) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1778
        !"test1778"
        z1 <== (((q+(-p))))
        z2 <== (((y+(-x))))
        print.cccc (I 1778) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1779
        !"test1779"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 1779) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1780
        !"test1780"
        z1 <== 1.3
        z2 <== 1.3
        print.cccc (I 1780) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1781
        !"test1781"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1781) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1782
        !"test1782"
        z1 <== (((p)+q/(-4.2)*q-(-0.5)-p*(q-2.3+q)+(-5.4)-(-1.3)-(-q)+p)*5.2+(8.7))
        z2 <== (((x)+y/(-4.2)*y-(-0.5)-x*(y-2.3+y)+(-5.4)-(-1.3)-(-y)+x)*5.2+(8.7))
        print.cccc (I 1782) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1783
        !"test1783"
        z1 <== p
        z2 <== x
        print.cccc (I 1783) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1784
        !"test1784"
        z1 <== 4.8+(p-p)
        z2 <== 4.8+(x-x)
        print.cccc (I 1784) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1785
        !"test1785"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1785) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1786
        !"test1786"
        z1 <== q
        z2 <== y
        print.cccc (I 1786) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1787
        !"test1787"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 1787) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1788
        !"test1788"
        z1 <== ((-q)+p*q/(8.4-(-p))-(-8.1)/(q*(3.8-p+(-6.2)*q+(-p))-(-p))+(-3.2)+((q)+p-4.8-(-2.8)-(-1.6)+(4.1)))
        z2 <== ((-y)+x*y/(8.4-(-x))-(-8.1)/(y*(3.8-x+(-6.2)*y+(-x))-(-x))+(-3.2)+((y)+x-4.8-(-2.8)-(-1.6)+(4.1)))
        print.cccc (I 1788) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1789
        !"test1789"
        z1 <== p
        z2 <== x
        print.cccc (I 1789) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1790
        !"test1790"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1790) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1791
        !"test1791"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1791) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1792
        !"test1792"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 1792) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1793
        !"test1793"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1793) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1794
        !"test1794"
        z1 <== q
        z2 <== y
        print.cccc (I 1794) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1795
        !"test1795"
        z1 <== q-((q*6.1-(-q)-3.6)*((-p)+p))/(((-p)*(-1.7)*(-p)*(-p)+(-q)))/q+((-p))
        z2 <== y-((y*6.1-(-y)-3.6)*((-x)+x))/(((-x)*(-1.7)*(-x)*(-x)+(-y)))/y+((-x))
        print.cccc (I 1795) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1796
        !"test1796"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1796) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1797
        !"test1797"
        z1 <== (-p)+2.7/(-8.2)
        z2 <== (-x)+2.7/(-8.2)
        print.cccc (I 1797) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1798
        !"test1798"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1798) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1799
        !"test1799"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 1799) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1800
        !"test1800"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 1800) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1801
        !"test1801"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 1801) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1802
        !"test1802"
        z1 <== ((-p)/p*(-7.1)-7.8/(q+8.7)*p-1.7)
        z2 <== ((-x)/x*(-7.1)-7.8/(y+8.7)*x-1.7)
        print.cccc (I 1802) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1803
        !"test1803"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 1803) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1804
        !"test1804"
        z1 <== ((-3.1))
        z2 <== ((-3.1))
        print.cccc (I 1804) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1805
        !"test1805"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 1805) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1806
        !"test1806"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 1806) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1807
        !"test1807"
        z1 <== (((-p)+(-2.6)/(-q)*(-2.5)*(-3.2)+p/(-p)/0.2)-(6.5-5.4-(-1.2)+p)+(-q)-((-5.3)/p*5.4/(-4.1)-6.7)/p-q/(-4.1)*((-7.6)*8.4))
        z2 <== (((-x)+(-2.6)/(-y)*(-2.5)*(-3.2)+x/(-x)/0.2)-(6.5-5.4-(-1.2)+x)+(-y)-((-5.3)/x*5.4/(-4.1)-6.7)/x-y/(-4.1)*((-7.6)*8.4))
        print.cccc (I 1807) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1808
        !"test1808"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1808) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1809
        !"test1809"
        z1 <== (((4.8)))
        z2 <== (((4.8)))
        print.cccc (I 1809) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1810
        !"test1810"
        z1 <== ((p+(-2.3)-((-4.4)*5.4+p*6.2)+p))
        z2 <== ((x+(-2.3)-((-4.4)*5.4+x*6.2)+x))
        print.cccc (I 1810) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1811
        !"test1811"
        z1 <== (((8.1))-(3.5)-p-(-q))
        z2 <== (((8.1))-(3.5)-x-(-y))
        print.cccc (I 1811) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1812
        !"test1812"
        z1 <== ((q+(-q)-(-4.4)-2.4)+8.6-(1.0-(-7.1))*(-2.8)/(-p)-(q))*(-p)-6.3+(((-8.0)/q)+((-q)+(-7.2))/(-q))+((-p)*(-q)+q*(-p)*1.2-(-0.5)+(-q)+2.6*(7.8/4.2*q*q))
        z2 <== ((y+(-y)-(-4.4)-2.4)+8.6-(1.0-(-7.1))*(-2.8)/(-x)-(y))*(-x)-6.3+(((-8.0)/y)+((-y)+(-7.2))/(-y))+((-x)*(-y)+y*(-x)*1.2-(-0.5)+(-y)+2.6*(7.8/4.2*y*y))
        print.cccc (I 1812) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1813
        !"test1813"
        z1 <== ((-0.0)/(-5.1))
        z2 <== ((-0.0)/(-5.1))
        print.cccc (I 1813) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1814
        !"test1814"
        z1 <== q
        z2 <== y
        print.cccc (I 1814) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1815
        !"test1815"
        z1 <== p
        z2 <== x
        print.cccc (I 1815) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1816
        !"test1816"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 1816) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1817
        !"test1817"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1817) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1818
        !"test1818"
        z1 <== ((-6.2)/(1.5-p*p/(-q)/q)/(q)/(8.4)/p+((q/8.8)*((-p)-(-6.5)+(-3.7)/(-4.3))))
        z2 <== ((-6.2)/(1.5-x*x/(-y)/y)/(y)/(8.4)/x+((y/8.8)*((-x)-(-6.5)+(-3.7)/(-4.3))))
        print.cccc (I 1818) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1819
        !"test1819"
        z1 <== p/3.1/((-q)+8.3/(-3.1)-q-(-5.3)/(-q)+(-p)+(-1.7)-((-p)/(-q)/(-p))+(p*p))/(p)+p-(((-q)*(-q)-p)+(-q)-6.8*q*0.2/q)
        z2 <== x/3.1/((-y)+8.3/(-3.1)-y-(-5.3)/(-y)+(-x)+(-1.7)-((-x)/(-y)/(-x))+(x*x))/(x)+x-(((-y)*(-y)-x)+(-y)-6.8*y*0.2/y)
        print.cccc (I 1819) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1820
        !"test1820"
        z1 <== ((((-2.5)+3.2/(-q)+8.4-(-p))+(-4.1))/q)
        z2 <== ((((-2.5)+3.2/(-y)+8.4-(-x))+(-4.1))/y)
        print.cccc (I 1820) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1821
        !"test1821"
        z1 <== (-6.8)
        z2 <== (-6.8)
        print.cccc (I 1821) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1822
        !"test1822"
        z1 <== (3.4-(-p)/((-3.0)+(-p)-1.6*((-1.7)-(-q)-p+(-p))*(-q)))
        z2 <== (3.4-(-x)/((-3.0)+(-x)-1.6*((-1.7)-(-y)-x+(-x))*(-y)))
        print.cccc (I 1822) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1823
        !"test1823"
        z1 <== (p/((6.8+3.8)))
        z2 <== (x/((6.8+3.8)))
        print.cccc (I 1823) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1824
        !"test1824"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 1824) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1825
        !"test1825"
        z1 <== p
        z2 <== x
        print.cccc (I 1825) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1826
        !"test1826"
        z1 <== ((-0.6)*(-5.5)*(-p))/(-q)/(-q)-(-p)/p+((-p)+p-7.2/((-q)+p)*q)-((5.2*7.6-p-3.3)-(-q)+(p/(-p)))
        z2 <== ((-0.6)*(-5.5)*(-x))/(-y)/(-y)-(-x)/x+((-x)+x-7.2/((-y)+x)*y)-((5.2*7.6-x-3.3)-(-y)+(x/(-x)))
        print.cccc (I 1826) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1827
        !"test1827"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 1827) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1828
        !"test1828"
        z1 <== ((-1.1)-(-1.1))
        z2 <== ((-1.1)-(-1.1))
        print.cccc (I 1828) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1829
        !"test1829"
        z1 <== p
        z2 <== x
        print.cccc (I 1829) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1830
        !"test1830"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 1830) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1831
        !"test1831"
        z1 <== p
        z2 <== x
        print.cccc (I 1831) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1832
        !"test1832"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 1832) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1833
        !"test1833"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 1833) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1834
        !"test1834"
        z1 <== ((-7.1))
        z2 <== ((-7.1))
        print.cccc (I 1834) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1835
        !"test1835"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 1835) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1836
        !"test1836"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 1836) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1837
        !"test1837"
        z1 <== ((-1.4)*(-8.4)+2.3/p*(((-p))-(-p))*p+(q*(-q)))
        z2 <== ((-1.4)*(-8.4)+2.3/x*(((-x))-(-x))*x+(y*(-y)))
        print.cccc (I 1837) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1838
        !"test1838"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1838) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1839
        !"test1839"
        z1 <== ((p-((-4.1)))*p*(-1.3))
        z2 <== ((x-((-4.1)))*x*(-1.3))
        print.cccc (I 1839) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1840
        !"test1840"
        z1 <== (8.0/(q*(-7.2)-(-p)))
        z2 <== (8.0/(y*(-7.2)-(-x)))
        print.cccc (I 1840) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1841
        !"test1841"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1841) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1842
        !"test1842"
        z1 <== (((-5.3)/(-4.5)/q-(-p))-(-q))-7.2*(-p)/(q)
        z2 <== (((-5.3)/(-4.5)/y-(-x))-(-y))-7.2*(-x)/(y)
        print.cccc (I 1842) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1843
        !"test1843"
        z1 <== ((-4.0)/(-4.0))
        z2 <== ((-4.0)/(-4.0))
        print.cccc (I 1843) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1844
        !"test1844"
        z1 <== (6.0)
        z2 <== (6.0)
        print.cccc (I 1844) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1845
        !"test1845"
        z1 <== ((-p)*((-p)-(-1.7))-(-7.4)+(-6.7)-q-0.1*((-q)-(-3.7)+((-q))*((-q)+(-0.6)+(-p)-(-q)/(-p))-6.0)-p)
        z2 <== ((-x)*((-x)-(-1.7))-(-7.4)+(-6.7)-y-0.1*((-y)-(-3.7)+((-y))*((-y)+(-0.6)+(-x)-(-y)/(-x))-6.0)-x)
        print.cccc (I 1845) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1846
        !"test1846"
        z1 <== ((-q)/(((-q))-(4.1-(-2.6)*4.7)+p/q)+((-q)/(-6.4)/q+8.5-(-p)/(-p)))
        z2 <== ((-y)/(((-y))-(4.1-(-2.6)*4.7)+x/y)+((-y)/(-6.4)/y+8.5-(-x)/(-x)))
        print.cccc (I 1846) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1847
        !"test1847"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1847) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1848
        !"test1848"
        z1 <== p
        z2 <== x
        print.cccc (I 1848) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1849
        !"test1849"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 1849) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1850
        !"test1850"
        z1 <== (((-q)*q-(-4.4)*7.4-(q*(-2.6)+(-p)+2.1+2.4)/(-1.4))*(((-p)*(-q))-(7.5)))
        z2 <== (((-y)*y-(-4.4)*7.4-(y*(-2.6)+(-x)+2.1+2.4)/(-1.4))*(((-x)*(-y))-(7.5)))
        print.cccc (I 1850) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1851
        !"test1851"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1851) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1852
        !"test1852"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 1852) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1853
        !"test1853"
        z1 <== (((-0.3)/((-8.1)+(-3.7))-(-q)/((-p)/(-q)+(-1.7))))
        z2 <== (((-0.3)/((-8.1)+(-3.7))-(-y)/((-x)/(-y)+(-1.7))))
        print.cccc (I 1853) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1854
        !"test1854"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1854) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1855
        !"test1855"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1855) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1856
        !"test1856"
        z1 <== q
        z2 <== y
        print.cccc (I 1856) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1857
        !"test1857"
        z1 <== (7.6-3.0*0.6)
        z2 <== (7.6-3.0*0.6)
        print.cccc (I 1857) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1858
        !"test1858"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 1858) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1859
        !"test1859"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 1859) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1860
        !"test1860"
        z1 <== (-6.7)
        z2 <== (-6.7)
        print.cccc (I 1860) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1861
        !"test1861"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 1861) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1862
        !"test1862"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 1862) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1863
        !"test1863"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 1863) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1864
        !"test1864"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 1864) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1865
        !"test1865"
        z1 <== (((p-(-q)*(-p)/1.0)+((-7.1))+(-p)-(-p)+((-p)-(-p)*0.0*(-7.7))-((-4.7)/(-p)/p)))
        z2 <== (((x-(-y)*(-x)/1.0)+((-7.1))+(-x)-(-x)+((-x)-(-x)*0.0*(-7.7))-((-4.7)/(-x)/x)))
        print.cccc (I 1865) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1866
        !"test1866"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1866) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1867
        !"test1867"
        z1 <== (-7.8)
        z2 <== (-7.8)
        print.cccc (I 1867) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1868
        !"test1868"
        z1 <== (-7.8)
        z2 <== (-7.8)
        print.cccc (I 1868) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1869
        !"test1869"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 1869) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1870
        !"test1870"
        z1 <== (-0.8)*p
        z2 <== (-0.8)*x
        print.cccc (I 1870) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1871
        !"test1871"
        z1 <== (4.0)
        z2 <== (4.0)
        print.cccc (I 1871) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1872
        !"test1872"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1872) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1873
        !"test1873"
        z1 <== ((-p)+(((-1.7)/5.8/4.0)/((-p)+p/(-p))*(p-8.5*(-7.3)-(-7.0)+(-q))-(-1.8)-(-7.5)-(-6.2)*(-p)*2.4)/(-4.3))
        z2 <== ((-x)+(((-1.7)/5.8/4.0)/((-x)+x/(-x))*(x-8.5*(-7.3)-(-7.0)+(-y))-(-1.8)-(-7.5)-(-6.2)*(-x)*2.4)/(-4.3))
        print.cccc (I 1873) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1874
        !"test1874"
        z1 <== (8.3*(((-2.8))/q))
        z2 <== (8.3*(((-2.8))/y))
        print.cccc (I 1874) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1875
        !"test1875"
        z1 <== ((((-1.6))*(q+(-p)+p)/7.1))
        z2 <== ((((-1.6))*(y+(-x)+x)/7.1))
        print.cccc (I 1875) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1876
        !"test1876"
        z1 <== p
        z2 <== x
        print.cccc (I 1876) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1877
        !"test1877"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 1877) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1878
        !"test1878"
        z1 <== ((4.1+6.7+5.8-q+(-1.3)-8.5*(-0.2))+(-q)/(-q))
        z2 <== ((4.1+6.7+5.8-y+(-1.3)-8.5*(-0.2))+(-y)/(-y))
        print.cccc (I 1878) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1879
        !"test1879"
        z1 <== (((8.6/(-p)/p*0.3+5.1))*q*p/(-q))
        z2 <== (((8.6/(-x)/x*0.3+5.1))*y*x/(-y))
        print.cccc (I 1879) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1880
        !"test1880"
        z1 <== (((-p))*(((-q)*2.0))*4.5/4.5-p)
        z2 <== (((-x))*(((-y)*2.0))*4.5/4.5-x)
        print.cccc (I 1880) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1881
        !"test1881"
        z1 <== (p+5.2/(p+q+0.2-q*1.5)*((-p)-(p/2.6)/(q*q/(-5.0)*4.3)*(8.8*p-1.6)+((-6.1))))
        z2 <== (x+5.2/(x+y+0.2-y*1.5)*((-x)-(x/2.6)/(y*y/(-5.0)*4.3)*(8.8*x-1.6)+((-6.1))))
        print.cccc (I 1881) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1882
        !"test1882"
        z1 <== q
        z2 <== y
        print.cccc (I 1882) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1883
        !"test1883"
        z1 <== (3.6*(-q)/((-8.2)-(-q)/p-1.8-p)-p*(-3.7)/(-p)/(((-0.0)-(-8.3)))-q)
        z2 <== (3.6*(-y)/((-8.2)-(-y)/x-1.8-x)-x*(-3.7)/(-x)/(((-0.0)-(-8.3)))-y)
        print.cccc (I 1883) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1884
        !"test1884"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 1884) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1885
        !"test1885"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 1885) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1886
        !"test1886"
        z1 <== (1.4*q*(p*8.5-(-q)/(-6.4)+q*(-q)*3.7-(-1.4)-5.1/4.8))
        z2 <== (1.4*y*(x*8.5-(-y)/(-6.4)+y*(-y)*3.7-(-1.4)-5.1/4.8))
        print.cccc (I 1886) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1887
        !"test1887"
        z1 <== ((p*((-p)/(-3.1)/(-p)-(-5.7)*5.8)-(5.8))-((-p)-5.0)-((p*(-7.8)*(-8.1))))
        z2 <== ((x*((-x)/(-3.1)/(-x)-(-5.7)*5.8)-(5.8))-((-x)-5.0)-((x*(-7.8)*(-8.1))))
        print.cccc (I 1887) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1888
        !"test1888"
        z1 <== 7.1-(4.6-(-1.2)+4.8)
        z2 <== 7.1-(4.6-(-1.2)+4.8)
        print.cccc (I 1888) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1889
        !"test1889"
        z1 <== ((6.5+q*(-q)-6.0/(-3.5)-q+3.2+(-5.5)/(-q)+p*q)+2.5+((p/(-1.1)))*(-5.1)+(3.8-(-5.8)/(-p)+(-8.2)-(p)/(1.8)))
        z2 <== ((6.5+y*(-y)-6.0/(-3.5)-y+3.2+(-5.5)/(-y)+x*y)+2.5+((x/(-1.1)))*(-5.1)+(3.8-(-5.8)/(-x)+(-8.2)-(x)/(1.8)))
        print.cccc (I 1889) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1890
        !"test1890"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1890) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1891
        !"test1891"
        z1 <== ((((-3.3)-3.3-(-4.3)/(-q)*3.8))/(((-8.8)+q/q-(-5.1)*q)*(5.6/p)/((-4.7)/(-5.5))/(7.2))+(((-5.7)+(-0.0)))+((-3.5)/3.4+q-(p*(-3.8)+(-p)-8.1)-(-p))*((q+(-6.0)+(-0.8)*p/1.1)/(-0.8)+(-q)))
        z2 <== ((((-3.3)-3.3-(-4.3)/(-y)*3.8))/(((-8.8)+y/y-(-5.1)*y)*(5.6/x)/((-4.7)/(-5.5))/(7.2))+(((-5.7)+(-0.0)))+((-3.5)/3.4+y-(x*(-3.8)+(-x)-8.1)-(-x))*((y+(-6.0)+(-0.8)*x/1.1)/(-0.8)+(-y)))
        print.cccc (I 1891) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1892
        !"test1892"
        z1 <== 7.6
        z2 <== 7.6
        print.cccc (I 1892) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1893
        !"test1893"
        z1 <== 2.2
        z2 <== 2.2
        print.cccc (I 1893) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1894
        !"test1894"
        z1 <== ((q)-(-p))
        z2 <== ((y)-(-x))
        print.cccc (I 1894) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1895
        !"test1895"
        z1 <== p
        z2 <== x
        print.cccc (I 1895) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1896
        !"test1896"
        z1 <== q
        z2 <== y
        print.cccc (I 1896) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1897
        !"test1897"
        z1 <== ((((-p)/(-3.6)/1.2+q*(-0.7))-q/(-5.8)*(-p)*(-7.4)/(-p)))
        z2 <== ((((-x)/(-3.6)/1.2+y*(-0.7))-y/(-5.8)*(-x)*(-7.4)/(-x)))
        print.cccc (I 1897) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1898
        !"test1898"
        z1 <== (p*p+(-6.7)*(((-2.2))-((-8.1)+(-p)))-(6.2*8.3/2.7))
        z2 <== (x*x+(-6.7)*(((-2.2))-((-8.1)+(-x)))-(6.2*8.3/2.7))
        print.cccc (I 1898) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1899
        !"test1899"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1899) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1900
        !"test1900"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1900) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1901
        !"test1901"
        z1 <== q
        z2 <== y
        print.cccc (I 1901) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1902
        !"test1902"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 1902) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1903
        !"test1903"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1903) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1904
        !"test1904"
        z1 <== p
        z2 <== x
        print.cccc (I 1904) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1905
        !"test1905"
        z1 <== 3.1+(((-8.7)))/8.3+(-4.1)+(-q)
        z2 <== 3.1+(((-8.7)))/8.3+(-4.1)+(-y)
        print.cccc (I 1905) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1906
        !"test1906"
        z1 <== (((q+p/(-4.7)+0.7/(-q))*1.2/4.3*(-4.4))*(-p)/(((-q)/2.4*p))/(q/(4.3/(-0.7)))*(8.8*(-q)+(-0.3)-(-8.8)/(-p)-8.1))
        z2 <== (((y+x/(-4.7)+0.7/(-y))*1.2/4.3*(-4.4))*(-x)/(((-y)/2.4*x))/(y/(4.3/(-0.7)))*(8.8*(-y)+(-0.3)-(-8.8)/(-x)-8.1))
        print.cccc (I 1906) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1907
        !"test1907"
        z1 <== q
        z2 <== y
        print.cccc (I 1907) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1908
        !"test1908"
        z1 <== q
        z2 <== y
        print.cccc (I 1908) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1909
        !"test1909"
        z1 <== (7.6-(p/2.4)-(-q)/3.4)
        z2 <== (7.6-(x/2.4)-(-y)/3.4)
        print.cccc (I 1909) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1910
        !"test1910"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 1910) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1911
        !"test1911"
        z1 <== (2.7-(3.7+p-(-p)+(-5.2)/((-1.5)/(-3.2)))+((-7.8)/p)*p+8.8*(-p))
        z2 <== (2.7-(3.7+x-(-x)+(-5.2)/((-1.5)/(-3.2)))+((-7.8)/x)*x+8.8*(-x))
        print.cccc (I 1911) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1912
        !"test1912"
        z1 <== p
        z2 <== x
        print.cccc (I 1912) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1913
        !"test1913"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 1913) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1914
        !"test1914"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1914) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1915
        !"test1915"
        z1 <== (q-(-8.8)+(((-p)+q-q-(-q))/(-8.0)/8.4/(-1.2)))
        z2 <== (y-(-8.8)+(((-x)+y-y-(-y))/(-8.0)/8.4/(-1.2)))
        print.cccc (I 1915) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1916
        !"test1916"
        z1 <== (-5.3)
        z2 <== (-5.3)
        print.cccc (I 1916) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1917
        !"test1917"
        z1 <== ((-6.0)/5.3/p)
        z2 <== ((-6.0)/5.3/x)
        print.cccc (I 1917) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1918
        !"test1918"
        z1 <== (-7.7)-(-q)-(((-q)*p)/(q+(-0.3)+(-p))*(-p)+((-8.8)/1.3))+(p)+(-0.4)
        z2 <== (-7.7)-(-y)-(((-y)*x)/(y+(-0.3)+(-x))*(-x)+((-8.8)/1.3))+(x)+(-0.4)
        print.cccc (I 1918) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1919
        !"test1919"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1919) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1920
        !"test1920"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 1920) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1921
        !"test1921"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 1921) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1922
        !"test1922"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1922) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1923
        !"test1923"
        z1 <== q*(-8.8)+(-0.8)-((-6.8)/q-((-p)-(-4.8)*p*6.2)-p/(-5.5)*3.5)*(((-q)+(-q)/p-(-q)))
        z2 <== y*(-8.8)+(-0.8)-((-6.8)/y-((-x)-(-4.8)*x*6.2)-x/(-5.5)*3.5)*(((-y)+(-y)/x-(-y)))
        print.cccc (I 1923) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1924
        !"test1924"
        z1 <== 4.3
        z2 <== 4.3
        print.cccc (I 1924) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1925
        !"test1925"
        z1 <== ((-2.3)-(-p)-(-p)-(((-q)*1.1*5.4+7.4-(-q))/(-1.7)/(-5.8)-(-5.2)+(7.4-p-p))/q)
        z2 <== ((-2.3)-(-x)-(-x)-(((-y)*1.1*5.4+7.4-(-y))/(-1.7)/(-5.8)-(-5.2)+(7.4-x-x))/y)
        print.cccc (I 1925) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1926
        !"test1926"
        z1 <== ((2.0*6.1*4.5+(-6.3)/8.2*((-7.4)-(-q)))+((-6.0)/(-7.8)*(-q))-((-q)))
        z2 <== ((2.0*6.1*4.5+(-6.3)/8.2*((-7.4)-(-y)))+((-6.0)/(-7.8)*(-y))-((-y)))
        print.cccc (I 1926) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1927
        !"test1927"
        z1 <== (-2.0)
        z2 <== (-2.0)
        print.cccc (I 1927) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1928
        !"test1928"
        z1 <== 1.7
        z2 <== 1.7
        print.cccc (I 1928) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1929
        !"test1929"
        z1 <== ((5.0-(7.0*(-1.2)*(-2.2)/q)-6.3+(4.3*6.0*(-p)))/5.2+p/(-p)/(-q))
        z2 <== ((5.0-(7.0*(-1.2)*(-2.2)/y)-6.3+(4.3*6.0*(-x)))/5.2+x/(-x)/(-y))
        print.cccc (I 1929) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1930
        !"test1930"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 1930) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1931
        !"test1931"
        z1 <== (((-p)-(-1.3)*(-1.6)))-(4.6*p+(-p)/(-3.6)+(-q)*(-8.8)-5.6-(-1.7)+(q))*(-p)*(q+(-1.6)+(p)/(-1.0)-(-p))
        z2 <== (((-x)-(-1.3)*(-1.6)))-(4.6*x+(-x)/(-3.6)+(-y)*(-8.8)-5.6-(-1.7)+(y))*(-x)*(y+(-1.6)+(x)/(-1.0)-(-x))
        print.cccc (I 1931) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1932
        !"test1932"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 1932) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1933
        !"test1933"
        z1 <== (5.8)
        z2 <== (5.8)
        print.cccc (I 1933) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1934
        !"test1934"
        z1 <== (q/((-p)+(-q)*(-q)+q*((-p))/q*(-p))+((-q)+(-p)+(q+8.3*0.8)-((-3.4))+((-p)+3.3/q*(-6.2))))
        z2 <== (y/((-x)+(-y)*(-y)+y*((-x))/y*(-x))+((-y)+(-x)+(y+8.3*0.8)-((-3.4))+((-x)+3.3/y*(-6.2))))
        print.cccc (I 1934) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1935
        !"test1935"
        z1 <== q
        z2 <== y
        print.cccc (I 1935) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1936
        !"test1936"
        z1 <== (2.1+p-(-q)+(-q)*((-p)/(-7.7)/(1.1/2.5)+(p)-((-q))))
        z2 <== (2.1+x-(-y)+(-y)*((-x)/(-7.7)/(1.1/2.5)+(x)-((-y))))
        print.cccc (I 1936) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1937
        !"test1937"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 1937) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1938
        !"test1938"
        z1 <== (((0.2+p/(-5.8))+(-p)-(-0.7)-7.7*4.6+q+0.8/(-1.3))*4.7-(-q)*(-8.6)*(p-(-1.3)-(-q)-(-p)*3.7)-(-q))
        z2 <== (((0.2+x/(-5.8))+(-x)-(-0.7)-7.7*4.6+y+0.8/(-1.3))*4.7-(-y)*(-8.6)*(x-(-1.3)-(-y)-(-x)*3.7)-(-y))
        print.cccc (I 1938) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1939
        !"test1939"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 1939) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1940
        !"test1940"
        z1 <== (((-5.5)))
        z2 <== (((-5.5)))
        print.cccc (I 1940) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1941
        !"test1941"
        z1 <== ((p+(-p)/(-q)*q-(-p)/7.1*(-q)/(7.8*(-8.4))))
        z2 <== ((x+(-x)/(-y)*y-(-x)/7.1*(-y)/(7.8*(-8.4))))
        print.cccc (I 1941) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1942
        !"test1942"
        z1 <== (((-2.1)))
        z2 <== (((-2.1)))
        print.cccc (I 1942) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1943
        !"test1943"
        z1 <== ((8.6-(-q)/(p*6.6*(-3.8)*(-q)/(-q))/(0.0-8.3-8.1)+4.0))
        z2 <== ((8.6-(-y)/(x*6.6*(-3.8)*(-y)/(-y))/(0.0-8.3-8.1)+4.0))
        print.cccc (I 1943) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1944
        !"test1944"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1944) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1945
        !"test1945"
        z1 <== ((-q)+3.2+(((-5.3)-q-q*5.5)+(-1.1)+(q+(-6.1)*(-4.7)-0.6-p))/(-p))
        z2 <== ((-y)+3.2+(((-5.3)-y-y*5.5)+(-1.1)+(y+(-6.1)*(-4.7)-0.6-x))/(-x))
        print.cccc (I 1945) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1946
        !"test1946"
        z1 <== (p/(8.1))
        z2 <== (x/(8.1))
        print.cccc (I 1946) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1947
        !"test1947"
        z1 <== q*(-0.7)-((q*8.3/7.7+(-q))*q*((-q)*0.0)*(-1.8)/((-p)-p))*(5.1-(-p)-4.0)-(6.5+(-7.0)*8.8)-((-3.3)*p+1.7-5.5/6.8)+1.2-((-p)-(-q)/(-q)-(-8.7))*((2.1-(-q)/(-4.7)*(-7.5))/5.3)
        z2 <== y*(-0.7)-((y*8.3/7.7+(-y))*y*((-y)*0.0)*(-1.8)/((-x)-x))*(5.1-(-x)-4.0)-(6.5+(-7.0)*8.8)-((-3.3)*x+1.7-5.5/6.8)+1.2-((-x)-(-y)/(-y)-(-8.7))*((2.1-(-y)/(-4.7)*(-7.5))/5.3)
        print.cccc (I 1947) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1948
        !"test1948"
        z1 <== (-2.3)
        z2 <== (-2.3)
        print.cccc (I 1948) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1949
        !"test1949"
        z1 <== (-q)/q-(-1.3)/p
        z2 <== (-y)/y-(-1.3)/x
        print.cccc (I 1949) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1950
        !"test1950"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 1950) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1951
        !"test1951"
        z1 <== ((((-0.6))-((-q)-q*(-p)-(-q)+(-2.8)))-p*((-4.1)+(-q)*2.6+q)+6.6/(6.0-(-8.0)-1.3-p+(-0.0)/(-3.3)*p/p+p-(3.0-p/(-p))))
        z2 <== ((((-0.6))-((-y)-y*(-x)-(-y)+(-2.8)))-x*((-4.1)+(-y)*2.6+y)+6.6/(6.0-(-8.0)-1.3-x+(-0.0)/(-3.3)*x/x+x-(3.0-x/(-x))))
        print.cccc (I 1951) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1952
        !"test1952"
        z1 <== ((-p)*q)
        z2 <== ((-x)*y)
        print.cccc (I 1952) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1953
        !"test1953"
        z1 <== 3.7
        z2 <== 3.7
        print.cccc (I 1953) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1954
        !"test1954"
        z1 <== (p-((-p)*(-p)*(-p)+p-(-q)*2.0+(-p)/((-p)-(-6.1)/q-(-6.6)))+(-0.7)*8.3/(p-(-7.4)*(-3.3)+(-2.1)*(-5.2))-(p*(-8.7)*(-4.3)/0.6)*2.0)
        z2 <== (x-((-x)*(-x)*(-x)+x-(-y)*2.0+(-x)/((-x)-(-6.1)/y-(-6.6)))+(-0.7)*8.3/(x-(-7.4)*(-3.3)+(-2.1)*(-5.2))-(x*(-8.7)*(-4.3)/0.6)*2.0)
        print.cccc (I 1954) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1955
        !"test1955"
        z1 <== (-4.7)/(-p)-q+((-3.1)*5.6+((-p)*(-3.5)*q-(-1.4)/p))
        z2 <== (-4.7)/(-x)-y+((-3.1)*5.6+((-x)*(-3.5)*y-(-1.4)/x))
        print.cccc (I 1955) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1956
        !"test1956"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 1956) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1957
        !"test1957"
        z1 <== (p*((-q)*q)-p+((-q)+(-q)*((-p)+p/(-q))+p))
        z2 <== (x*((-y)*y)-x+((-y)+(-y)*((-x)+x/(-y))+x))
        print.cccc (I 1957) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1958
        !"test1958"
        z1 <== ((((-0.6)-(-0.5)/(-q)*q*(-q))/(5.5+(-p)-(-p)+(-p))/(-6.5))*q*(-4.6))
        z2 <== ((((-0.6)-(-0.5)/(-y)*y*(-y))/(5.5+(-x)-(-x)+(-x))/(-6.5))*y*(-4.6))
        print.cccc (I 1958) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1959
        !"test1959"
        z1 <== ((p-(7.4-(-q)-5.5)))
        z2 <== ((x-(7.4-(-y)-5.5)))
        print.cccc (I 1959) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1960
        !"test1960"
        z1 <== q
        z2 <== y
        print.cccc (I 1960) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1961
        !"test1961"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1961) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1962
        !"test1962"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 1962) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1963
        !"test1963"
        z1 <== q
        z2 <== y
        print.cccc (I 1963) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1964
        !"test1964"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 1964) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1965
        !"test1965"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 1965) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1966
        !"test1966"
        z1 <== p-q
        z2 <== x-y
        print.cccc (I 1966) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1967
        !"test1967"
        z1 <== q
        z2 <== y
        print.cccc (I 1967) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1968
        !"test1968"
        z1 <== (((7.3+p+p)-((-q)-q-(-p)+2.5*(-1.6))))
        z2 <== (((7.3+x+x)-((-y)-y-(-x)+2.5*(-1.6))))
        print.cccc (I 1968) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1969
        !"test1969"
        z1 <== ((((-q)/q)+2.7*(-p)*(-2.6))*((-1.4)/p-q-(-2.4)/1.1)+q+(-8.2)-((6.2)+(q*(-6.8)+4.6/(-6.3))/(-0.7)))
        z2 <== ((((-y)/y)+2.7*(-x)*(-2.6))*((-1.4)/x-y-(-2.4)/1.1)+y+(-8.2)-((6.2)+(y*(-6.8)+4.6/(-6.3))/(-0.7)))
        print.cccc (I 1969) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1970
        !"test1970"
        z1 <== (-6.3)
        z2 <== (-6.3)
        print.cccc (I 1970) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1971
        !"test1971"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1971) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1972
        !"test1972"
        z1 <== ((-8.2)*5.0*(-7.0)/(-7.5))
        z2 <== ((-8.2)*5.0*(-7.0)/(-7.5))
        print.cccc (I 1972) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1973
        !"test1973"
        z1 <== ((-6.2)+3.7+(((-6.6))*(-3.8)/1.8)*((q*0.4)/6.8+(-p))/(-7.5))
        z2 <== ((-6.2)+3.7+(((-6.6))*(-3.8)/1.8)*((y*0.4)/6.8+(-x))/(-7.5))
        print.cccc (I 1973) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1974
        !"test1974"
        z1 <== (((-7.4)*(6.6+(-q)*(-p)+(-4.0)+6.2)/1.3-p)/(((-q)/(-p)+(-0.7)-2.4))*q*((p)-7.4/(-0.7)-(-7.5)))
        z2 <== (((-7.4)*(6.6+(-y)*(-x)+(-4.0)+6.2)/1.3-x)/(((-y)/(-x)+(-0.7)-2.4))*y*((x)-7.4/(-0.7)-(-7.5)))
        print.cccc (I 1974) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1975
        !"test1975"
        z1 <== (4.1)
        z2 <== (4.1)
        print.cccc (I 1975) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1976
        !"test1976"
        z1 <== (-q)-(-4.0)/(6.0*(1.6-(-3.4)/p)-(-5.3)*q-(-2.0)+p)/(-1.1)
        z2 <== (-y)-(-4.0)/(6.0*(1.6-(-3.4)/x)-(-5.3)*y-(-2.0)+x)/(-1.1)
        print.cccc (I 1976) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1977
        !"test1977"
        z1 <== (((7.6*2.7-(-p))-(p)*((-7.7)*(-p)*(-p)+(-p)+q)-(q+q/q)/((-q)))*(((-4.7))))
        z2 <== (((7.6*2.7-(-x))-(x)*((-7.7)*(-x)*(-x)+(-x)+y)-(y+y/y)/((-y)))*(((-4.7))))
        print.cccc (I 1977) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1978
        !"test1978"
        z1 <== (-6.3)
        z2 <== (-6.3)
        print.cccc (I 1978) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1979
        !"test1979"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 1979) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1980
        !"test1980"
        z1 <== (((-q)/4.6*(-p)+p*((-7.1)*p))/(((-0.1)*(-p)/1.1)-((-0.2)+q+(-q))/5.1)+q)
        z2 <== (((-y)/4.6*(-x)+x*((-7.1)*x))/(((-0.1)*(-x)/1.1)-((-0.2)+y+(-y))/5.1)+y)
        print.cccc (I 1980) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1981
        !"test1981"
        z1 <== p
        z2 <== x
        print.cccc (I 1981) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1982
        !"test1982"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1982) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1983
        !"test1983"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1983) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1984
        !"test1984"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1984) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1985
        !"test1985"
        z1 <== ((-p)/0.3-(p/(-5.2)-(-q))-(((-0.0)*(-q)+(-p)-p*(-7.2))))
        z2 <== ((-x)/0.3-(x/(-5.2)-(-y))-(((-0.0)*(-y)+(-x)-x*(-7.2))))
        print.cccc (I 1985) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1986
        !"test1986"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 1986) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1987
        !"test1987"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1987) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1988
        !"test1988"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1988) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1989
        !"test1989"
        z1 <== q
        z2 <== y
        print.cccc (I 1989) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1990
        !"test1990"
        z1 <== p
        z2 <== x
        print.cccc (I 1990) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1991
        !"test1991"
        z1 <== q
        z2 <== y
        print.cccc (I 1991) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1992
        !"test1992"
        z1 <== (q/(-3.8)-((-p))*(0.2-(-p)+(-4.5)*(-q))/(-4.4)+p-((-1.0)*(-p)))
        z2 <== (y/(-3.8)-((-x))*(0.2-(-x)+(-4.5)*(-y))/(-4.4)+x-((-1.0)*(-x)))
        print.cccc (I 1992) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1993
        !"test1993"
        z1 <== (p-(((-2.8)-7.6/(-q))*(q)-2.8+5.5))
        z2 <== (x-(((-2.8)-7.6/(-y))*(y)-2.8+5.5))
        print.cccc (I 1993) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1994
        !"test1994"
        z1 <== ((-8.5)*((-p)*((-0.4)))+(-8.7)+7.6)
        z2 <== ((-8.5)*((-x)*((-0.4)))+(-8.7)+7.6)
        print.cccc (I 1994) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1995
        !"test1995"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 1995) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1996
        !"test1996"
        z1 <== ((-4.6)-(((-q)*0.1/p/0.4))+(-4.7)/6.3)
        z2 <== ((-4.6)-(((-y)*0.1/x/0.4))+(-4.7)/6.3)
        print.cccc (I 1996) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1997
        !"test1997"
        z1 <== ((-q)+3.4*(-7.0)-p/(p+((-5.8)+(-1.3)-q)))
        z2 <== ((-y)+3.4*(-7.0)-x/(x+((-5.8)+(-1.3)-y)))
        print.cccc (I 1997) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1998
        !"test1998"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 1998) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 1999
        !"test1999"
        z1 <== q
        z2 <== y
        print.cccc (I 1999) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2000
        !"test2000"
        z1 <== q
        z2 <== y
        print.cccc (I 2000) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2001
        !"test2001"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 2001) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2002
        !"test2002"
        z1 <== ((((-7.0)*p)*(1.5+(-2.2)+p/(-5.4)/p))/(q-(-6.2)/((-8.7)+(-1.3)/8.8*(-7.6))))
        z2 <== ((((-7.0)*x)*(1.5+(-2.2)+x/(-5.4)/x))/(y-(-6.2)/((-8.7)+(-1.3)/8.8*(-7.6))))
        print.cccc (I 2002) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2003
        !"test2003"
        z1 <== (((-q)*8.8)-1.6/0.1-(-q)/(p/2.5-(-5.5)+(-2.0))+(((-1.0)+3.6+(-p)/4.0/7.8)+(q+5.4+(-p)+(-1.7))*(8.3/(-8.3)*p*7.5))*(-p)+(-5.4))
        z2 <== (((-y)*8.8)-1.6/0.1-(-y)/(x/2.5-(-5.5)+(-2.0))+(((-1.0)+3.6+(-x)/4.0/7.8)+(y+5.4+(-x)+(-1.7))*(8.3/(-8.3)*x*7.5))*(-x)+(-5.4))
        print.cccc (I 2003) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2004
        !"test2004"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 2004) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2005
        !"test2005"
        z1 <== 6.5
        z2 <== 6.5
        print.cccc (I 2005) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2006
        !"test2006"
        z1 <== (((8.8)/(-6.4)-(7.1+p/6.6-(-p)/(-p))))
        z2 <== (((8.8)/(-6.4)-(7.1+x/6.6-(-x)/(-x))))
        print.cccc (I 2006) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2007
        !"test2007"
        z1 <== p
        z2 <== x
        print.cccc (I 2007) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2008
        !"test2008"
        z1 <== (((-6.4)-(-q)+(-p)+8.2*(-8.0)-((-p)*8.8/(-q)/4.0)/((-q)*q))*((q-p+2.3*3.8+p)+(4.1)-(-p))+q)
        z2 <== (((-6.4)-(-y)+(-x)+8.2*(-8.0)-((-x)*8.8/(-y)/4.0)/((-y)*y))*((y-x+2.3*3.8+x)+(4.1)-(-x))+y)
        print.cccc (I 2008) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2009
        !"test2009"
        z1 <== p
        z2 <== x
        print.cccc (I 2009) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2010
        !"test2010"
        z1 <== ((4.0+(-q)-(-8.0)/(-q))*((-p)*2.3-(-8.6)*(-p))+(7.8+(-p)+6.0)*(-q)/(-3.4))-((-8.0)-q/(-3.0)*(-8.2)+1.2/q)+p*(p-(-5.8)+q)
        z2 <== ((4.0+(-y)-(-8.0)/(-y))*((-x)*2.3-(-8.6)*(-x))+(7.8+(-x)+6.0)*(-y)/(-3.4))-((-8.0)-y/(-3.0)*(-8.2)+1.2/y)+x*(x-(-5.8)+y)
        print.cccc (I 2010) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2011
        !"test2011"
        z1 <== ((p*p-(-q)+(p+(-q)))/(-5.2))
        z2 <== ((x*x-(-y)+(x+(-y)))/(-5.2))
        print.cccc (I 2011) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2012
        !"test2012"
        z1 <== (((-7.5))*(-p)*(5.0-(-6.7))-(-3.1))
        z2 <== (((-7.5))*(-x)*(5.0-(-6.7))-(-3.1))
        print.cccc (I 2012) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2013
        !"test2013"
        z1 <== q
        z2 <== y
        print.cccc (I 2013) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2014
        !"test2014"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 2014) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2015
        !"test2015"
        z1 <== p
        z2 <== x
        print.cccc (I 2015) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2016
        !"test2016"
        z1 <== ((((-q)-2.0/4.3+p)/0.7+q/q+p*(-p)-(-0.7)+q)-p)
        z2 <== ((((-y)-2.0/4.3+x)/0.7+y/y+x*(-x)-(-0.7)+y)-x)
        print.cccc (I 2016) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2017
        !"test2017"
        z1 <== ((-p)*p+((-q)+(-q))/(-6.6))
        z2 <== ((-x)*x+((-y)+(-y))/(-6.6))
        print.cccc (I 2017) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2018
        !"test2018"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2018) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2019
        !"test2019"
        z1 <== (2.7*(-0.1)*((-8.2)/(-q)/(-3.7)+(-6.1)))
        z2 <== (2.7*(-0.1)*((-8.2)/(-y)/(-3.7)+(-6.1)))
        print.cccc (I 2019) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2020
        !"test2020"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2020) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2021
        !"test2021"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 2021) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2022
        !"test2022"
        z1 <== q
        z2 <== y
        print.cccc (I 2022) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2023
        !"test2023"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 2023) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2024
        !"test2024"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2024) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2025
        !"test2025"
        z1 <== ((6.1-(q*p/p*(-q)))+4.0/(5.7+q)*((6.2)+p*(5.4-(-8.8)*2.6+(-6.7))*((-q)+q*p/8.0/(-5.8))))
        z2 <== ((6.1-(y*x/x*(-y)))+4.0/(5.7+y)*((6.2)+x*(5.4-(-8.8)*2.6+(-6.7))*((-y)+y*x/8.0/(-5.8))))
        print.cccc (I 2025) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2026
        !"test2026"
        z1 <== (((p*5.2*8.8*0.2)+p+(-0.0)*(q-6.2*(-q)*(-5.2)*(-6.4))*q-q/(-p)+(-7.2))*q-2.0)
        z2 <== (((x*5.2*8.8*0.2)+x+(-0.0)*(y-6.2*(-y)*(-5.2)*(-6.4))*y-y/(-x)+(-7.2))*y-2.0)
        print.cccc (I 2026) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2027
        !"test2027"
        z1 <== ((-p)*(p+(-6.1))-(((-2.6)*(-7.4)/q)-q+1.4/(-8.7)/q)-(3.1*(-p)+(p-(-q)*(-q))))
        z2 <== ((-x)*(x+(-6.1))-(((-2.6)*(-7.4)/y)-y+1.4/(-8.7)/y)-(3.1*(-x)+(x-(-y)*(-y))))
        print.cccc (I 2027) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2028
        !"test2028"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 2028) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2029
        !"test2029"
        z1 <== (1.6-(1.2-(-p))/(q+(-p)*(-4.2))-(p*(-0.3)*(-p)*(-1.4)*(-7.5))+((-3.0)+(-p)-(-7.2))/((-p)*4.8)*(p))
        z2 <== (1.6-(1.2-(-x))/(y+(-x)*(-4.2))-(x*(-0.3)*(-x)*(-1.4)*(-7.5))+((-3.0)+(-x)-(-7.2))/((-x)*4.8)*(x))
        print.cccc (I 2029) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2030
        !"test2030"
        z1 <== p
        z2 <== x
        print.cccc (I 2030) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2031
        !"test2031"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 2031) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2032
        !"test2032"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2032) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2033
        !"test2033"
        z1 <== p
        z2 <== x
        print.cccc (I 2033) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2034
        !"test2034"
        z1 <== (7.5/1.8+p*q-p)
        z2 <== (7.5/1.8+x*y-x)
        print.cccc (I 2034) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2035
        !"test2035"
        z1 <== (3.7+6.1-(-1.3)/2.0/((-q)+(-6.0)+(-7.8)+2.6)-((-q))-((-8.8)*(-p)+5.7+(-4.0)))
        z2 <== (3.7+6.1-(-1.3)/2.0/((-y)+(-6.0)+(-7.8)+2.6)-((-y))-((-8.8)*(-x)+5.7+(-4.0)))
        print.cccc (I 2035) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2036
        !"test2036"
        z1 <== ((-8.2)+(-2.0)-8.8-(-0.2))
        z2 <== ((-8.2)+(-2.0)-8.8-(-0.2))
        print.cccc (I 2036) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2037
        !"test2037"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2037) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2038
        !"test2038"
        z1 <== (8.5+(((-1.8))+(-6.5)*0.6*(-p)*p))
        z2 <== (8.5+(((-1.8))+(-6.5)*0.6*(-x)*x))
        print.cccc (I 2038) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2039
        !"test2039"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 2039) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2040
        !"test2040"
        z1 <== 2.5/p
        z2 <== 2.5/x
        print.cccc (I 2040) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2041
        !"test2041"
        z1 <== (p/(-p)+(-q)*7.0*7.8-(-6.3)-p-((-1.3)+(-p)/(-8.6)/(-q)))
        z2 <== (x/(-x)+(-y)*7.0*7.8-(-6.3)-x-((-1.3)+(-x)/(-8.6)/(-y)))
        print.cccc (I 2041) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2042
        !"test2042"
        z1 <== (q-((-p)-(-q))-3.5/7.0+(-4.8)-(-5.5)-0.5+2.7)-(-0.8)/p
        z2 <== (y-((-x)-(-y))-3.5/7.0+(-4.8)-(-5.5)-0.5+2.7)-(-0.8)/x
        print.cccc (I 2042) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2043
        !"test2043"
        z1 <== (1.8+((-p)+((-p)+(-0.4)+(-0.3)/(-q)/6.8)+p*((-q)/(-8.8)/q)-(6.6*(-3.0)/q-(-0.6)+0.0)))
        z2 <== (1.8+((-x)+((-x)+(-0.4)+(-0.3)/(-y)/6.8)+x*((-y)/(-8.8)/y)-(6.6*(-3.0)/y-(-0.6)+0.0)))
        print.cccc (I 2043) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2044
        !"test2044"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 2044) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2045
        !"test2045"
        z1 <== 2.2
        z2 <== 2.2
        print.cccc (I 2045) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2046
        !"test2046"
        z1 <== q
        z2 <== y
        print.cccc (I 2046) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2047
        !"test2047"
        z1 <== q
        z2 <== y
        print.cccc (I 2047) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2048
        !"test2048"
        z1 <== (((q*2.3)-(q*q)-p/(-p)*(-p))*(-8.5)*((p-(-3.5)-(-3.6)-p)-p-0.0/((-q)+(-3.2)/(-q))/((-p)))+((-6.8)-q)*(7.2*(-0.5)+(-q)-((-p)+(-6.1)-0.0/4.8-p)+(p)+(p*(-p)+(-5.7)-(-8.6)*3.4)/((-0.5))))
        z2 <== (((y*2.3)-(y*y)-x/(-x)*(-x))*(-8.5)*((x-(-3.5)-(-3.6)-x)-x-0.0/((-y)+(-3.2)/(-y))/((-x)))+((-6.8)-y)*(7.2*(-0.5)+(-y)-((-x)+(-6.1)-0.0/4.8-x)+(x)+(x*(-x)+(-5.7)-(-8.6)*3.4)/((-0.5))))
        print.cccc (I 2048) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2049
        !"test2049"
        z1 <== ((-7.4)+(4.8)+(-p)+p/((-1.4)/p))
        z2 <== ((-7.4)+(4.8)+(-x)+x/((-1.4)/x))
        print.cccc (I 2049) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2050
        !"test2050"
        z1 <== ((-p)-(3.6+(-q)-p-(-q)))
        z2 <== ((-x)-(3.6+(-y)-x-(-y)))
        print.cccc (I 2050) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2051
        !"test2051"
        z1 <== p
        z2 <== x
        print.cccc (I 2051) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2052
        !"test2052"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 2052) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2053
        !"test2053"
        z1 <== p
        z2 <== x
        print.cccc (I 2053) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2054
        !"test2054"
        z1 <== ((((-p))-(p-(-q)/2.8-4.7)-0.1+7.8))
        z2 <== ((((-x))-(x-(-y)/2.8-4.7)-0.1+7.8))
        print.cccc (I 2054) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2055
        !"test2055"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2055) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2056
        !"test2056"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 2056) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2057
        !"test2057"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 2057) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2058
        !"test2058"
        z1 <== (((q+q)+5.8/5.1*3.4*(-p)+(-4.7)*((-8.7)/(-1.0)-p)*2.5/(-3.8)+(-6.7)+0.0-p)+(-2.5)+(((-p)*8.1*(-p))-((-6.1)-p-p)))
        z2 <== (((y+y)+5.8/5.1*3.4*(-x)+(-4.7)*((-8.7)/(-1.0)-x)*2.5/(-3.8)+(-6.7)+0.0-x)+(-2.5)+(((-x)*8.1*(-x))-((-6.1)-x-x)))
        print.cccc (I 2058) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2059
        !"test2059"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 2059) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2060
        !"test2060"
        z1 <== ((-p)+((6.1*0.4-(-8.1)*(-1.4)/(-q))+(q+(-q))/(-p)+q+q+(-3.0)*p+((-0.5)-p/(-p)+(-0.6)-8.2))+(-p)+(1.3))
        z2 <== ((-x)+((6.1*0.4-(-8.1)*(-1.4)/(-y))+(y+(-y))/(-x)+y+y+(-3.0)*x+((-0.5)-x/(-x)+(-0.6)-8.2))+(-x)+(1.3))
        print.cccc (I 2060) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2061
        !"test2061"
        z1 <== (6.3/(-q)-(-p)/(-p))
        z2 <== (6.3/(-y)-(-x)/(-x))
        print.cccc (I 2061) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2062
        !"test2062"
        z1 <== p
        z2 <== x
        print.cccc (I 2062) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2063
        !"test2063"
        z1 <== (0.7)
        z2 <== (0.7)
        print.cccc (I 2063) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2064
        !"test2064"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 2064) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2065
        !"test2065"
        z1 <== (((-p))*(-6.5)*(-5.7)/(4.4+(-3.7))-(-p))
        z2 <== (((-x))*(-6.5)*(-5.7)/(4.4+(-3.7))-(-x))
        print.cccc (I 2065) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2066
        !"test2066"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 2066) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2067
        !"test2067"
        z1 <== (-4.0)
        z2 <== (-4.0)
        print.cccc (I 2067) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2068
        !"test2068"
        z1 <== ((-0.8)+((-7.1)/(-0.4)-((-q))*q*(7.6/2.1)))
        z2 <== ((-0.8)+((-7.1)/(-0.4)-((-y))*y*(7.6/2.1)))
        print.cccc (I 2068) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2069
        !"test2069"
        z1 <== (-1.6)*(-3.2)-p/((-0.2)-(-7.2))+(-4.2)-(q/7.7+(-7.3))+((-q)+(-q)+(p/3.6/4.2/q)+6.2/((-8.0)+7.3*p/1.4))
        z2 <== (-1.6)*(-3.2)-x/((-0.2)-(-7.2))+(-4.2)-(y/7.7+(-7.3))+((-y)+(-y)+(x/3.6/4.2/y)+6.2/((-8.0)+7.3*x/1.4))
        print.cccc (I 2069) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2070
        !"test2070"
        z1 <== ((-8.4)-(-q)*(-q))
        z2 <== ((-8.4)-(-y)*(-y))
        print.cccc (I 2070) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2071
        !"test2071"
        z1 <== (8.3+(-p)+p+(7.4+2.3/4.0+(-8.3)-q)/q+(-q))
        z2 <== (8.3+(-x)+x+(7.4+2.3/4.0+(-8.3)-y)/y+(-y))
        print.cccc (I 2071) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2072
        !"test2072"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2072) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2073
        !"test2073"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2073) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2074
        !"test2074"
        z1 <== ((-q)*q/(p))
        z2 <== ((-y)*y/(x))
        print.cccc (I 2074) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2075
        !"test2075"
        z1 <== 5.4*((-p)*(-q))
        z2 <== 5.4*((-x)*(-y))
        print.cccc (I 2075) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2076
        !"test2076"
        z1 <== ((((-7.1))*((-q)/(-p))))
        z2 <== ((((-7.1))*((-y)/(-x))))
        print.cccc (I 2076) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2077
        !"test2077"
        z1 <== (q+(-p)+(3.6/(-q)*q*(-q)-(-7.4)+(q+q))*((3.1))-(-6.1))
        z2 <== (y+(-x)+(3.6/(-y)*y*(-y)-(-7.4)+(y+y))*((3.1))-(-6.1))
        print.cccc (I 2077) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2078
        !"test2078"
        z1 <== ((-q)+q-(-q)+(-p)+q/(-5.8)/3.7/(-p))-7.6
        z2 <== ((-y)+y-(-y)+(-x)+y/(-5.8)/3.7/(-x))-7.6
        print.cccc (I 2078) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2079
        !"test2079"
        z1 <== p
        z2 <== x
        print.cccc (I 2079) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2080
        !"test2080"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2080) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2081
        !"test2081"
        z1 <== p*1.1*2.7-((q-(-4.0)-(-p)-2.2)/((-q)-(-p))-((-8.1)/(-7.1))*q/((-3.5)*7.2))
        z2 <== x*1.1*2.7-((y-(-4.0)-(-x)-2.2)/((-y)-(-x))-((-8.1)/(-7.1))*y/((-3.5)*7.2))
        print.cccc (I 2081) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2082
        !"test2082"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 2082) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2083
        !"test2083"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 2083) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2084
        !"test2084"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 2084) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2085
        !"test2085"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2085) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2086
        !"test2086"
        z1 <== ((q)+p+q)
        z2 <== ((y)+x+y)
        print.cccc (I 2086) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2087
        !"test2087"
        z1 <== (((-2.3)+(2.8+(-p)-(-q))+q)+(q)-p)
        z2 <== (((-2.3)+(2.8+(-x)-(-y))+y)+(y)-x)
        print.cccc (I 2087) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2088
        !"test2088"
        z1 <== p
        z2 <== x
        print.cccc (I 2088) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2089
        !"test2089"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2089) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2090
        !"test2090"
        z1 <== (q*(3.0/(-q)-(4.7-(-6.4)-q+(-p)+0.6)+((-3.6)))-(-2.6)*(-3.6)-((6.2)+3.0-((-7.1))/(-0.6)-5.1/(-q)))
        z2 <== (y*(3.0/(-y)-(4.7-(-6.4)-y+(-x)+0.6)+((-3.6)))-(-2.6)*(-3.6)-((6.2)+3.0-((-7.1))/(-0.6)-5.1/(-y)))
        print.cccc (I 2090) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2091
        !"test2091"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 2091) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2092
        !"test2092"
        z1 <== (7.3-p-((-7.3)+8.5/(-2.3)*(-q))-((-1.6)+(-6.3)*6.3+((-5.7)-2.7*(-2.3)*(-p)+q)+(-1.4))*(-p)-((-q)*(q-q)))
        z2 <== (7.3-x-((-7.3)+8.5/(-2.3)*(-y))-((-1.6)+(-6.3)*6.3+((-5.7)-2.7*(-2.3)*(-x)+y)+(-1.4))*(-x)-((-y)*(y-y)))
        print.cccc (I 2092) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2093
        !"test2093"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 2093) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2094
        !"test2094"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2094) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2095
        !"test2095"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 2095) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2096
        !"test2096"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 2096) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2097
        !"test2097"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 2097) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2098
        !"test2098"
        z1 <== ((((-7.6))-(-q)-p)-(q/1.4)/((-p))+((3.2+(-p)/(-3.1)+(-4.8))-(-p)-(q+p)-(-5.6)+((-2.0)/(-2.5)-(-3.0))))
        z2 <== ((((-7.6))-(-y)-x)-(y/1.4)/((-x))+((3.2+(-x)/(-3.1)+(-4.8))-(-x)-(y+x)-(-5.6)+((-2.0)/(-2.5)-(-3.0))))
        print.cccc (I 2098) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2099
        !"test2099"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 2099) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2100
        !"test2100"
        z1 <== ((((-8.2)+(-p))/(-6.6)/7.8-p+(-6.5)))
        z2 <== ((((-8.2)+(-x))/(-6.6)/7.8-x+(-6.5)))
        print.cccc (I 2100) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2101
        !"test2101"
        z1 <== (8.5/q/(q/(-p)*1.5-6.6)+(2.5/(-p)*(-q)/(-1.5)/2.3-4.3-(2.3-(-4.6))-((-7.5)*(-0.0)+4.8-1.8))+(-q))
        z2 <== (8.5/y/(y/(-x)*1.5-6.6)+(2.5/(-x)*(-y)/(-1.5)/2.3-4.3-(2.3-(-4.6))-((-7.5)*(-0.0)+4.8-1.8))+(-y))
        print.cccc (I 2101) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2102
        !"test2102"
        z1 <== q
        z2 <== y
        print.cccc (I 2102) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2103
        !"test2103"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2103) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2104
        !"test2104"
        z1 <== q
        z2 <== y
        print.cccc (I 2104) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2105
        !"test2105"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 2105) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2106
        !"test2106"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2106) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2107
        !"test2107"
        z1 <== (((-4.0)*(p-(-8.3)/5.3/8.1)+(5.0+(-5.8))))
        z2 <== (((-4.0)*(x-(-8.3)/5.3/8.1)+(5.0+(-5.8))))
        print.cccc (I 2107) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2108
        !"test2108"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 2108) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2109
        !"test2109"
        z1 <== (((-p)*(-2.4)/p+((-0.5)+p+4.6-4.8/q))+(-4.4)/q+(-5.2))
        z2 <== (((-x)*(-2.4)/x+((-0.5)+x+4.6-4.8/y))+(-4.4)/y+(-5.2))
        print.cccc (I 2109) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2110
        !"test2110"
        z1 <== q
        z2 <== y
        print.cccc (I 2110) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2111
        !"test2111"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 2111) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2112
        !"test2112"
        z1 <== ((-q)+(-p)-(-q)/(-p))
        z2 <== ((-y)+(-x)-(-y)/(-x))
        print.cccc (I 2112) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2113
        !"test2113"
        z1 <== (-7.8)
        z2 <== (-7.8)
        print.cccc (I 2113) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2114
        !"test2114"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 2114) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2115
        !"test2115"
        z1 <== ((0.0))
        z2 <== ((0.0))
        print.cccc (I 2115) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2116
        !"test2116"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2116) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2117
        !"test2117"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2117) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2118
        !"test2118"
        z1 <== ((((-8.1)-(-3.7)/3.0)-2.8)*((1.7-p+2.5)-(q/6.3*(-3.2))/q/(-1.2)+8.2-(-q)+(-6.6)-((-6.7)+6.2+q*(-p)))*(4.1*(p+(-q))+(-5.6)*(-3.8))+(-3.7))
        z2 <== ((((-8.1)-(-3.7)/3.0)-2.8)*((1.7-x+2.5)-(y/6.3*(-3.2))/y/(-1.2)+8.2-(-y)+(-6.6)-((-6.7)+6.2+y*(-x)))*(4.1*(x+(-y))+(-5.6)*(-3.8))+(-3.7))
        print.cccc (I 2118) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2119
        !"test2119"
        z1 <== p
        z2 <== x
        print.cccc (I 2119) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2120
        !"test2120"
        z1 <== ((-p)*q*(-q)*(((-2.8)/q-p-p-7.2)+p/(q/8.2)-((-8.5)-(-q)-(-5.0)-q)))
        z2 <== ((-x)*y*(-y)*(((-2.8)/y-x-x-7.2)+x/(y/8.2)-((-8.5)-(-y)-(-5.0)-y)))
        print.cccc (I 2120) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2121
        !"test2121"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2121) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2122
        !"test2122"
        z1 <== q
        z2 <== y
        print.cccc (I 2122) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2123
        !"test2123"
        z1 <== (((-1.4)/(8.6+(-q)/p/(-0.1))+((-1.3))-(-q)/0.5/(-q))+(-0.5)*(5.2)*(-q)/p)
        z2 <== (((-1.4)/(8.6+(-y)/x/(-0.1))+((-1.3))-(-y)/0.5/(-y))+(-0.5)*(5.2)*(-y)/x)
        print.cccc (I 2123) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2124
        !"test2124"
        z1 <== ((q-(q*(-p))+(-q)))
        z2 <== ((y-(y*(-x))+(-y)))
        print.cccc (I 2124) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2125
        !"test2125"
        z1 <== ((-4.4)/(-6.2)/(-5.1)-(-q)/(-p)*(-1.1))
        z2 <== ((-4.4)/(-6.2)/(-5.1)-(-y)/(-x)*(-1.1))
        print.cccc (I 2125) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2126
        !"test2126"
        z1 <== (5.3/(6.0)/((-q)/(-4.5)*q)+3.5)-(p)-(-2.3)+p*p+(-8.5)
        z2 <== (5.3/(6.0)/((-y)/(-4.5)*y)+3.5)-(x)-(-2.3)+x*x+(-8.5)
        print.cccc (I 2126) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2127
        !"test2127"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 2127) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2128
        !"test2128"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 2128) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2129
        !"test2129"
        z1 <== ((0.1+(-p))/q)*(-2.4)
        z2 <== ((0.1+(-x))/y)*(-2.4)
        print.cccc (I 2129) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2130
        !"test2130"
        z1 <== ((((-q)+(-3.0))/6.1*(-7.6))+p-8.4-8.4/7.4)
        z2 <== ((((-y)+(-3.0))/6.1*(-7.6))+x-8.4-8.4/7.4)
        print.cccc (I 2130) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2131
        !"test2131"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 2131) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2132
        !"test2132"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 2132) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2133
        !"test2133"
        z1 <== ((((-q))/(-p)*(1.0-(-p)*(-7.2)*q)*(-p)+((-q)+3.6*(-p)-(-6.5)*p))-(-q))
        z2 <== ((((-y))/(-x)*(1.0-(-x)*(-7.2)*y)*(-x)+((-y)+3.6*(-x)-(-6.5)*x))-(-y))
        print.cccc (I 2133) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2134
        !"test2134"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 2134) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2135
        !"test2135"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 2135) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2136
        !"test2136"
        z1 <== p
        z2 <== x
        print.cccc (I 2136) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2137
        !"test2137"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 2137) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2138
        !"test2138"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 2138) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2139
        !"test2139"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 2139) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2140
        !"test2140"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 2140) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2141
        !"test2141"
        z1 <== (((-7.0)*(-1.2)+((-2.7))-(-p))*((-4.6))+(-p)/5.2+((p/(-p)+1.7+(-p)*(-p))/(-q)+((-2.7)*q*q*2.2)))
        z2 <== (((-7.0)*(-1.2)+((-2.7))-(-x))*((-4.6))+(-x)/5.2+((x/(-x)+1.7+(-x)*(-x))/(-y)+((-2.7)*y*y*2.2)))
        print.cccc (I 2141) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2142
        !"test2142"
        z1 <== ((-q)-((-0.0)+((-2.4)+(-1.2))*((-p)))+(5.5+(-q)/(-3.3)+4.3*(-p)*(-q)/(-p)*q+(-p)+((-5.2)/8.0-5.5*7.0/0.8))/((-p)/p+q*((-3.1)))+(2.5+q*(-0.3)+3.2))
        z2 <== ((-y)-((-0.0)+((-2.4)+(-1.2))*((-x)))+(5.5+(-y)/(-3.3)+4.3*(-x)*(-y)/(-x)*y+(-x)+((-5.2)/8.0-5.5*7.0/0.8))/((-x)/x+y*((-3.1)))+(2.5+y*(-0.3)+3.2))
        print.cccc (I 2142) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2143
        !"test2143"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 2143) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2144
        !"test2144"
        z1 <== (7.2-(-4.4)+((q*(-q)/q)+(5.2*(-0.6)*(-q)-(-5.6))))
        z2 <== (7.2-(-4.4)+((y*(-y)/y)+(5.2*(-0.6)*(-y)-(-5.6))))
        print.cccc (I 2144) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2145
        !"test2145"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2145) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2146
        !"test2146"
        z1 <== (((-p)-(-6.0)/(-4.6)+0.1*(-3.2)*((-4.1)+(-7.2)-1.0+(-3.6)*(-q))/((-6.7)-(-p)*(-6.2)*1.6+(-7.2))+(-p)+((-p)*q))-(4.4)/((-p)))
        z2 <== (((-x)-(-6.0)/(-4.6)+0.1*(-3.2)*((-4.1)+(-7.2)-1.0+(-3.6)*(-y))/((-6.7)-(-x)*(-6.2)*1.6+(-7.2))+(-x)+((-x)*y))-(4.4)/((-x)))
        print.cccc (I 2146) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2147
        !"test2147"
        z1 <== (q+(-1.3)-(-0.0)*p/(q/(-8.2)+(-p)+p*(-3.3))/(0.5)-(q)/(8.4))
        z2 <== (y+(-1.3)-(-0.0)*x/(y/(-8.2)+(-x)+x*(-3.3))/(0.5)-(y)/(8.4))
        print.cccc (I 2147) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2148
        !"test2148"
        z1 <== q
        z2 <== y
        print.cccc (I 2148) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2149
        !"test2149"
        z1 <== (1.8*(-3.7))
        z2 <== (1.8*(-3.7))
        print.cccc (I 2149) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2150
        !"test2150"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 2150) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2151
        !"test2151"
        z1 <== p
        z2 <== x
        print.cccc (I 2151) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2152
        !"test2152"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 2152) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2153
        !"test2153"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 2153) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2154
        !"test2154"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 2154) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2155
        !"test2155"
        z1 <== ((-1.3)*q+(p+((-2.1)-(-q)-(-q)-q)))
        z2 <== ((-1.3)*y+(x+((-2.1)-(-y)-(-y)-y)))
        print.cccc (I 2155) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2156
        !"test2156"
        z1 <== ((p+q*p))
        z2 <== ((x+y*x))
        print.cccc (I 2156) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2157
        !"test2157"
        z1 <== ((-6.1)*1.2)*(1.3+q*p*(p/p))
        z2 <== ((-6.1)*1.2)*(1.3+y*x*(x/x))
        print.cccc (I 2157) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2158
        !"test2158"
        z1 <== (-1.0)
        z2 <== (-1.0)
        print.cccc (I 2158) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2159
        !"test2159"
        z1 <== q
        z2 <== y
        print.cccc (I 2159) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2160
        !"test2160"
        z1 <== ((-7.3)*q*(6.0+(-p)/p/p)/7.2)
        z2 <== ((-7.3)*y*(6.0+(-x)/x/x)/7.2)
        print.cccc (I 2160) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2161
        !"test2161"
        z1 <== q
        z2 <== y
        print.cccc (I 2161) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2162
        !"test2162"
        z1 <== (((-p)/(p*1.4/q*(-2.6)-(-1.5))-(-6.4)+(-4.0)/1.2)/(-q)+(7.8/(-0.3)/2.6/(-p)))
        z2 <== (((-x)/(x*1.4/y*(-2.6)-(-1.5))-(-6.4)+(-4.0)/1.2)/(-y)+(7.8/(-0.3)/2.6/(-x)))
        print.cccc (I 2162) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2163
        !"test2163"
        z1 <== ((-0.0)*(-7.4)-1.0+2.5*p)
        z2 <== ((-0.0)*(-7.4)-1.0+2.5*x)
        print.cccc (I 2163) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2164
        !"test2164"
        z1 <== q
        z2 <== y
        print.cccc (I 2164) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2165
        !"test2165"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 2165) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2166
        !"test2166"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 2166) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2167
        !"test2167"
        z1 <== (((-0.1)*(-2.2))+((p-q)-((-q)-0.6+(-q)-6.2-3.3)*(-6.8)*(-2.5)*(-4.8)*(-p))*q)
        z2 <== (((-0.1)*(-2.2))+((x-y)-((-y)-0.6+(-y)-6.2-3.3)*(-6.8)*(-2.5)*(-4.8)*(-x))*y)
        print.cccc (I 2167) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2168
        !"test2168"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2168) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2169
        !"test2169"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2169) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2170
        !"test2170"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 2170) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2171
        !"test2171"
        z1 <== ((-4.5))
        z2 <== ((-4.5))
        print.cccc (I 2171) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2172
        !"test2172"
        z1 <== p
        z2 <== x
        print.cccc (I 2172) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2173
        !"test2173"
        z1 <== ((5.6/(-q)+q+(-q)*p)*(-q)+(-q)-(-6.8)*((8.4+2.5+(-8.4))/((-p)))-(0.7*5.2*(-5.4))-(-p)/(p*(-q)*5.6+(-5.0)/(-2.6))-(-q)/((-q))*5.7)
        z2 <== ((5.6/(-y)+y+(-y)*x)*(-y)+(-y)-(-6.8)*((8.4+2.5+(-8.4))/((-x)))-(0.7*5.2*(-5.4))-(-x)/(x*(-y)*5.6+(-5.0)/(-2.6))-(-y)/((-y))*5.7)
        print.cccc (I 2173) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2174
        !"test2174"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 2174) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2175
        !"test2175"
        z1 <== q-2.0*(-q)
        z2 <== y-2.0*(-y)
        print.cccc (I 2175) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2176
        !"test2176"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 2176) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2177
        !"test2177"
        z1 <== (((-7.3))*(-p)*(p)-(-p)-(q*4.8+(-p)*(-7.7)+(-0.2)))
        z2 <== (((-7.3))*(-x)*(x)-(-x)-(y*4.8+(-x)*(-7.7)+(-0.2)))
        print.cccc (I 2177) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2178
        !"test2178"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2178) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2179
        !"test2179"
        z1 <== (((p-(-p)-(-5.2))-((-1.7))-(-2.1)-(-q)+1.1/(-q)*((-4.7)*4.1)))
        z2 <== (((x-(-x)-(-5.2))-((-1.7))-(-2.1)-(-y)+1.1/(-y)*((-4.7)*4.1)))
        print.cccc (I 2179) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2180
        !"test2180"
        z1 <== (((-p))+(-q)-(-p))
        z2 <== (((-x))+(-y)-(-x))
        print.cccc (I 2180) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2181
        !"test2181"
        z1 <== ((-8.7))
        z2 <== ((-8.7))
        print.cccc (I 2181) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2182
        !"test2182"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2182) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2183
        !"test2183"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 2183) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2184
        !"test2184"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 2184) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2185
        !"test2185"
        z1 <== ((q*((-2.7)*q))-8.2*8.3)
        z2 <== ((y*((-2.7)*y))-8.2*8.3)
        print.cccc (I 2185) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2186
        !"test2186"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 2186) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2187
        !"test2187"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2187) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2188
        !"test2188"
        z1 <== (q*(3.8/q)-((-p)))+((-q)/(2.6+(-7.7)*q+p)/1.8)-(((-p)+p+(-q))/7.8*6.3+(-8.5)*(-q))-7.4
        z2 <== (y*(3.8/y)-((-x)))+((-y)/(2.6+(-7.7)*y+x)/1.8)-(((-x)+x+(-y))/7.8*6.3+(-8.5)*(-y))-7.4
        print.cccc (I 2188) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2189
        !"test2189"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 2189) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2190
        !"test2190"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 2190) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2191
        !"test2191"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2191) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2192
        !"test2192"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 2192) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2193
        !"test2193"
        z1 <== (((-5.2)/q))
        z2 <== (((-5.2)/y))
        print.cccc (I 2193) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2194
        !"test2194"
        z1 <== ((-3.5)*((-q)))
        z2 <== ((-3.5)*((-y)))
        print.cccc (I 2194) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2195
        !"test2195"
        z1 <== (((-4.0)-(-q)/(3.1-q+q)/(-2.8))/(-p)-((-2.6)+0.1+p/(p)*(-q)))
        z2 <== (((-4.0)-(-y)/(3.1-y+y)/(-2.8))/(-x)-((-2.6)+0.1+x/(x)*(-y)))
        print.cccc (I 2195) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2196
        !"test2196"
        z1 <== ((-5.0))
        z2 <== ((-5.0))
        print.cccc (I 2196) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2197
        !"test2197"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2197) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2198
        !"test2198"
        z1 <== ((4.4)-((2.6*q)/(-q)/7.1+4.5+1.8*3.0+p+(-5.2))*p*((-7.5)-((-q)*q*2.5)+((-2.3)*(-2.1)+(-p)-(-5.5)*q)-p-(-3.1)))
        z2 <== ((4.4)-((2.6*y)/(-y)/7.1+4.5+1.8*3.0+x+(-5.2))*x*((-7.5)-((-y)*y*2.5)+((-2.3)*(-2.1)+(-x)-(-5.5)*y)-x-(-3.1)))
        print.cccc (I 2198) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2199
        !"test2199"
        z1 <== p
        z2 <== x
        print.cccc (I 2199) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2200
        !"test2200"
        z1 <== ((-p)-(-1.3)/(-q)-p)
        z2 <== ((-x)-(-1.3)/(-y)-x)
        print.cccc (I 2200) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2201
        !"test2201"
        z1 <== ((-4.8)-(-4.3)/p/7.8-p)
        z2 <== ((-4.8)-(-4.3)/x/7.8-x)
        print.cccc (I 2201) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2202
        !"test2202"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2202) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2203
        !"test2203"
        z1 <== p
        z2 <== x
        print.cccc (I 2203) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2204
        !"test2204"
        z1 <== 1.4
        z2 <== 1.4
        print.cccc (I 2204) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2205
        !"test2205"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2205) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2206
        !"test2206"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 2206) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2207
        !"test2207"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 2207) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2208
        !"test2208"
        z1 <== p
        z2 <== x
        print.cccc (I 2208) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2209
        !"test2209"
        z1 <== ((p-(-0.2)-8.8/q)*(8.0/q)+((-p)*3.6/(-p))+((-1.6))-(4.5+p*(-0.5)*(-q)-0.8)/(-1.4))
        z2 <== ((x-(-0.2)-8.8/y)*(8.0/y)+((-x)*3.6/(-x))+((-1.6))-(4.5+x*(-0.5)*(-y)-0.8)/(-1.4))
        print.cccc (I 2209) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2210
        !"test2210"
        z1 <== q
        z2 <== y
        print.cccc (I 2210) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2211
        !"test2211"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 2211) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2212
        !"test2212"
        z1 <== (((-p))+8.7-q-((-p)+p-((-p)))-(-5.7)*(p-(-p)-(-8.2)/3.8*(-8.4))/(-q)+((-p)+2.4/0.8+(-7.3)+(-0.4))-((-5.4)/3.8))
        z2 <== (((-x))+8.7-y-((-x)+x-((-x)))-(-5.7)*(x-(-x)-(-8.2)/3.8*(-8.4))/(-y)+((-x)+2.4/0.8+(-7.3)+(-0.4))-((-5.4)/3.8))
        print.cccc (I 2212) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2213
        !"test2213"
        z1 <== ((-q)-(q*0.8-((-7.1))-((-p)-5.0/q))/(8.0+(-2.3)*(-6.7)/6.0+q+4.6+3.4*(5.0*p))+((-q)+(p*8.6-4.0-(-1.2))-((-q)*5.4-(-q)*2.6-q))+(p/(3.5/p/(-7.6))*(6.1+q+3.0/q)))
        z2 <== ((-y)-(y*0.8-((-7.1))-((-x)-5.0/y))/(8.0+(-2.3)*(-6.7)/6.0+y+4.6+3.4*(5.0*x))+((-y)+(x*8.6-4.0-(-1.2))-((-y)*5.4-(-y)*2.6-y))+(x/(3.5/x/(-7.6))*(6.1+y+3.0/y)))
        print.cccc (I 2213) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2214
        !"test2214"
        z1 <== p
        z2 <== x
        print.cccc (I 2214) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2215
        !"test2215"
        z1 <== q
        z2 <== y
        print.cccc (I 2215) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2216
        !"test2216"
        z1 <== ((-7.6)/(((-4.3))*((-0.4)*(-q)))-((-6.5)*(-p))*(-q)/((-2.0)-(-2.5))*(((-p))))
        z2 <== ((-7.6)/(((-4.3))*((-0.4)*(-y)))-((-6.5)*(-x))*(-y)/((-2.0)-(-2.5))*(((-x))))
        print.cccc (I 2216) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2217
        !"test2217"
        z1 <== ((p/p*6.4/(-7.0))/((-8.1)-q*(-q)-(-5.7)/(-1.3))/p+q)/(q-(-6.8)/3.8+p)-q
        z2 <== ((x/x*6.4/(-7.0))/((-8.1)-y*(-y)-(-5.7)/(-1.3))/x+y)/(y-(-6.8)/3.8+x)-y
        print.cccc (I 2217) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2218
        !"test2218"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2218) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2219
        !"test2219"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 2219) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2220
        !"test2220"
        z1 <== ((-4.2))
        z2 <== ((-4.2))
        print.cccc (I 2220) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2221
        !"test2221"
        z1 <== (q+(-q)+(1.0/(-3.4)+q)-(q)*(-0.1)*(p)*(((-0.7)/7.0+(-q)))*p)
        z2 <== (y+(-y)+(1.0/(-3.4)+y)-(y)*(-0.1)*(x)*(((-0.7)/7.0+(-y)))*x)
        print.cccc (I 2221) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2222
        !"test2222"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2222) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2223
        !"test2223"
        z1 <== (((-0.8))/p+p)
        z2 <== (((-0.8))/x+x)
        print.cccc (I 2223) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2224
        !"test2224"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 2224) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2225
        !"test2225"
        z1 <== ((-8.2)+8.8+q/(-2.4))
        z2 <== ((-8.2)+8.8+y/(-2.4))
        print.cccc (I 2225) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2226
        !"test2226"
        z1 <== (0.2)
        z2 <== (0.2)
        print.cccc (I 2226) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2227
        !"test2227"
        z1 <== (((-p)/p*(-3.7)-2.2-(-6.4)+(-q))*(2.8+p+p/p)*(-5.2))
        z2 <== (((-x)/x*(-3.7)-2.2-(-6.4)+(-y))*(2.8+x+x/x)*(-5.2))
        print.cccc (I 2227) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2228
        !"test2228"
        z1 <== ((-p)+p-(((-4.1))/(-p)-p*(-p)+(-5.5))-((q/(-5.4)-(-q)+(-p))*p+(q)+8.7/(-p)))
        z2 <== ((-x)+x-(((-4.1))/(-x)-x*(-x)+(-5.5))-((y/(-5.4)-(-y)+(-x))*x+(y)+8.7/(-x)))
        print.cccc (I 2228) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2229
        !"test2229"
        z1 <== ((q*1.1*(0.7-8.0*(-0.0)-(-p)))/(-8.1))
        z2 <== ((y*1.1*(0.7-8.0*(-0.0)-(-x)))/(-8.1))
        print.cccc (I 2229) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2230
        !"test2230"
        z1 <== p
        z2 <== x
        print.cccc (I 2230) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2231
        !"test2231"
        z1 <== ((8.3-(-8.6)-(-4.2)/(q/(-5.2)/0.1/3.4/q))-(-p)+7.0+(-q)/(((-p)/6.6)/4.0/(-0.5)))
        z2 <== ((8.3-(-8.6)-(-4.2)/(y/(-5.2)/0.1/3.4/y))-(-x)+7.0+(-y)/(((-x)/6.6)/4.0/(-0.5)))
        print.cccc (I 2231) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2232
        !"test2232"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 2232) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2233
        !"test2233"
        z1 <== q
        z2 <== y
        print.cccc (I 2233) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2234
        !"test2234"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 2234) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2235
        !"test2235"
        z1 <== ((-q)-q/(((-q)+p/(-0.1))/(-5.2)/(-2.1)/(-p)-(q+4.3-0.3+7.6))*((-q)*(-p)+1.6/q)/(-q)-(-q)+((-p)+((-p)*p)+(-q)))
        z2 <== ((-y)-y/(((-y)+x/(-0.1))/(-5.2)/(-2.1)/(-x)-(y+4.3-0.3+7.6))*((-y)*(-x)+1.6/y)/(-y)-(-y)+((-x)+((-x)*x)+(-y)))
        print.cccc (I 2235) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2236
        !"test2236"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2236) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2237
        !"test2237"
        z1 <== (p/p/(-4.0)/3.2*(-p)+q-q*((3.8/q-(-6.6)+p)-(-2.2))*(3.1))
        z2 <== (x/x/(-4.0)/3.2*(-x)+y-y*((3.8/y-(-6.6)+x)-(-2.2))*(3.1))
        print.cccc (I 2237) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2238
        !"test2238"
        z1 <== ((-3.5)+1.0-(((-p)-q*p)/((-q)+3.1)/(p/5.4/(-8.6)+p)*(-2.5)+(-8.3))/(-8.7))
        z2 <== ((-3.5)+1.0-(((-x)-y*x)/((-y)+3.1)/(x/5.4/(-8.6)+x)*(-2.5)+(-8.3))/(-8.7))
        print.cccc (I 2238) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2239
        !"test2239"
        z1 <== (((-3.2)*(-p)*7.5-(-p))+(((-3.3)*p/(-p))-q-7.8-8.7+(-q)-(8.5-(-q)/(-0.0)/6.4+2.0)-((-p)))/q)
        z2 <== (((-3.2)*(-x)*7.5-(-x))+(((-3.3)*x/(-x))-y-7.8-8.7+(-y)-(8.5-(-y)/(-0.0)/6.4+2.0)-((-x)))/y)
        print.cccc (I 2239) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2240
        !"test2240"
        z1 <== (((-7.7)+(-p)/5.1/p+2.2)-(((-q))*p+q-6.1+(-q)*(-q)-((-q)+(-8.6))+(-3.3)-5.8)/5.5)
        z2 <== (((-7.7)+(-x)/5.1/x+2.2)-(((-y))*x+y-6.1+(-y)*(-y)-((-y)+(-8.6))+(-3.3)-5.8)/5.5)
        print.cccc (I 2240) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2241
        !"test2241"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2241) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2242
        !"test2242"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 2242) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2243
        !"test2243"
        z1 <== 7.7
        z2 <== 7.7
        print.cccc (I 2243) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2244
        !"test2244"
        z1 <== (((-4.4)-(-q)*(-1.7)+q)+7.4-(-p)+(-3.2)*p+(5.2/(-p)))
        z2 <== (((-4.4)-(-y)*(-1.7)+y)+7.4-(-x)+(-3.2)*x+(5.2/(-x)))
        print.cccc (I 2244) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2245
        !"test2245"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 2245) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2246
        !"test2246"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 2246) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2247
        !"test2247"
        z1 <== ((q-p+((-q)*(-p)-(-p)*(-q)+(-4.8))))
        z2 <== ((y-x+((-y)*(-x)-(-x)*(-y)+(-4.8))))
        print.cccc (I 2247) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2248
        !"test2248"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 2248) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2249
        !"test2249"
        z1 <== (-7.8)
        z2 <== (-7.8)
        print.cccc (I 2249) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2250
        !"test2250"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2250) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2251
        !"test2251"
        z1 <== p
        z2 <== x
        print.cccc (I 2251) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2252
        !"test2252"
        z1 <== (-5.8)*1.6
        z2 <== (-5.8)*1.6
        print.cccc (I 2252) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2253
        !"test2253"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2253) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2254
        !"test2254"
        z1 <== ((-p)/p+(-8.8)*(-1.5))
        z2 <== ((-x)/x+(-8.8)*(-1.5))
        print.cccc (I 2254) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2255
        !"test2255"
        z1 <== (((-8.7)/(-4.6)/(-0.3)))
        z2 <== (((-8.7)/(-4.6)/(-0.3)))
        print.cccc (I 2255) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2256
        !"test2256"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2256) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2257
        !"test2257"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2257) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2258
        !"test2258"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2258) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2259
        !"test2259"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 2259) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2260
        !"test2260"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 2260) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2261
        !"test2261"
        z1 <== (((7.4+7.1+(-q))-p*((-p)))/(0.4*p+p-((-p)*(-2.0)-1.0)))
        z2 <== (((7.4+7.1+(-y))-x*((-x)))/(0.4*x+x-((-x)*(-2.0)-1.0)))
        print.cccc (I 2261) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2262
        !"test2262"
        z1 <== ((-q)/(-p)/0.7/((8.1+q)/8.7))
        z2 <== ((-y)/(-x)/0.7/((8.1+y)/8.7))
        print.cccc (I 2262) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2263
        !"test2263"
        z1 <== q
        z2 <== y
        print.cccc (I 2263) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2264
        !"test2264"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 2264) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2265
        !"test2265"
        z1 <== p
        z2 <== x
        print.cccc (I 2265) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2266
        !"test2266"
        z1 <== ((7.7)+1.1)
        z2 <== ((7.7)+1.1)
        print.cccc (I 2266) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2267
        !"test2267"
        z1 <== (((-p)/(-q)*6.2*q)*((-p)/(-1.6)-2.2*0.4)*(4.6+(-p)-(-4.8)*5.4)*((q+(-0.7)/(-7.1)/(-q))/(-q))*(-2.5)-(-5.4)/(-q)-p-(6.2*4.6+(-2.4)+(-p))/1.5-(((-8.3))*(-5.8)+(-p)))
        z2 <== (((-x)/(-y)*6.2*y)*((-x)/(-1.6)-2.2*0.4)*(4.6+(-x)-(-4.8)*5.4)*((y+(-0.7)/(-7.1)/(-y))/(-y))*(-2.5)-(-5.4)/(-y)-x-(6.2*4.6+(-2.4)+(-x))/1.5-(((-8.3))*(-5.8)+(-x)))
        print.cccc (I 2267) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2268
        !"test2268"
        z1 <== q
        z2 <== y
        print.cccc (I 2268) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2269
        !"test2269"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2269) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2270
        !"test2270"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 2270) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2271
        !"test2271"
        z1 <== p
        z2 <== x
        print.cccc (I 2271) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2272
        !"test2272"
        z1 <== (p*((-2.0)-((-3.1)*(-5.7)-0.1))-q*q+1.5/8.8/(-8.8)+((-p)-(-p))/((-4.1)-(-q)-p)/p+p/(((-7.1)/p-(-5.4)-(-1.1))*(6.4)*q*p))
        z2 <== (x*((-2.0)-((-3.1)*(-5.7)-0.1))-y*y+1.5/8.8/(-8.8)+((-x)-(-x))/((-4.1)-(-y)-x)/x+x/(((-7.1)/x-(-5.4)-(-1.1))*(6.4)*y*x))
        print.cccc (I 2272) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2273
        !"test2273"
        z1 <== (-0.8)
        z2 <== (-0.8)
        print.cccc (I 2273) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2274
        !"test2274"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2274) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2275
        !"test2275"
        z1 <== p
        z2 <== x
        print.cccc (I 2275) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2276
        !"test2276"
        z1 <== ((q*(q-p/(-2.1)))+(((-q)-2.6*(-6.1)*(-8.0)*(-q))/(-3.1)*6.8/p*((-7.5)+p/(-p)-(-2.5)))/(1.6)-(-p))
        z2 <== ((y*(y-x/(-2.1)))+(((-y)-2.6*(-6.1)*(-8.0)*(-y))/(-3.1)*6.8/x*((-7.5)+x/(-x)-(-2.5)))/(1.6)-(-x))
        print.cccc (I 2276) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2277
        !"test2277"
        z1 <== 7.3
        z2 <== 7.3
        print.cccc (I 2277) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2278
        !"test2278"
        z1 <== (q-(-p))
        z2 <== (y-(-x))
        print.cccc (I 2278) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2279
        !"test2279"
        z1 <== ((-1.1))
        z2 <== ((-1.1))
        print.cccc (I 2279) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2280
        !"test2280"
        z1 <== q
        z2 <== y
        print.cccc (I 2280) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2281
        !"test2281"
        z1 <== (q+((-p)-(-8.3)+p-6.2*(-p)+p+(3.8/q*8.0+p))-((1.5-p)-((-q)-(-q)*p))*(((-6.1)-(-q)-p)+(-p)))
        z2 <== (y+((-x)-(-8.3)+x-6.2*(-x)+x+(3.8/y*8.0+x))-((1.5-x)-((-y)-(-y)*x))*(((-6.1)-(-y)-x)+(-x)))
        print.cccc (I 2281) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2282
        !"test2282"
        z1 <== ((2.1*p-(-q)/(-4.3)/7.1*(p*6.0))+(p*(-6.6)+(-q))*(-8.8)/(0.7+8.8/7.6))
        z2 <== ((2.1*x-(-y)/(-4.3)/7.1*(x*6.0))+(x*(-6.6)+(-y))*(-8.8)/(0.7+8.8/7.6))
        print.cccc (I 2282) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2283
        !"test2283"
        z1 <== ((-p)*(-8.0)-((-q)/(-p)-(-0.1)/(-p)*8.0)-0.0/(-6.7))
        z2 <== ((-x)*(-8.0)-((-y)/(-x)-(-0.1)/(-x)*8.0)-0.0/(-6.7))
        print.cccc (I 2283) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2284
        !"test2284"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 2284) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2285
        !"test2285"
        z1 <== (((-p)+0.0-(-q)+(-2.8))*(q*2.5)+4.0+(-4.8)/(1.3+2.1*6.6)+(-q)+q-(-p)-p+q+(-p)*p*(-3.7)*(-1.5))
        z2 <== (((-x)+0.0-(-y)+(-2.8))*(y*2.5)+4.0+(-4.8)/(1.3+2.1*6.6)+(-y)+y-(-x)-x+y+(-x)*x*(-3.7)*(-1.5))
        print.cccc (I 2285) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2286
        !"test2286"
        z1 <== q
        z2 <== y
        print.cccc (I 2286) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2287
        !"test2287"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2287) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2288
        !"test2288"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 2288) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2289
        !"test2289"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2289) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2290
        !"test2290"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 2290) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2291
        !"test2291"
        z1 <== q
        z2 <== y
        print.cccc (I 2291) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2292
        !"test2292"
        z1 <== (q+(4.3-(-p)/5.4/(-7.0)*q/5.8-(-4.0)/(1.1/(-p))*((-p)))+((-p)*(p-p*(-4.8)*6.5)/(-q))*2.1*(p-(p-q)+(-6.1)*0.7))
        z2 <== (y+(4.3-(-x)/5.4/(-7.0)*y/5.8-(-4.0)/(1.1/(-x))*((-x)))+((-x)*(x-x*(-4.8)*6.5)/(-y))*2.1*(x-(x-y)+(-6.1)*0.7))
        print.cccc (I 2292) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2293
        !"test2293"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 2293) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2294
        !"test2294"
        z1 <== ((((-q)+q/(-8.1))))
        z2 <== ((((-y)+y/(-8.1))))
        print.cccc (I 2294) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2295
        !"test2295"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 2295) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2296
        !"test2296"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2296) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2297
        !"test2297"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 2297) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2298
        !"test2298"
        z1 <== (7.7)
        z2 <== (7.7)
        print.cccc (I 2298) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2299
        !"test2299"
        z1 <== p
        z2 <== x
        print.cccc (I 2299) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2300
        !"test2300"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 2300) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2301
        !"test2301"
        z1 <== (q+3.6*(8.3/p-(-q)-(-q))/(-q)*6.7)
        z2 <== (y+3.6*(8.3/x-(-y)-(-y))/(-y)*6.7)
        print.cccc (I 2301) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2302
        !"test2302"
        z1 <== p
        z2 <== x
        print.cccc (I 2302) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2303
        !"test2303"
        z1 <== p
        z2 <== x
        print.cccc (I 2303) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2304
        !"test2304"
        z1 <== (p+(q/(-q)/6.0*3.4+q-(4.1/5.5/q-(-2.6))-8.0/(-0.2)*p)+((-p)-((-5.2)/6.3-(-8.3)*8.4)*(-1.7)))
        z2 <== (x+(y/(-y)/6.0*3.4+y-(4.1/5.5/y-(-2.6))-8.0/(-0.2)*x)+((-x)-((-5.2)/6.3-(-8.3)*8.4)*(-1.7)))
        print.cccc (I 2304) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2305
        !"test2305"
        z1 <== q
        z2 <== y
        print.cccc (I 2305) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2306
        !"test2306"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2306) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2307
        !"test2307"
        z1 <== (q*(-q)*(-q)+(-q)-p-0.6+(-2.0)/(-p)*(q/(-p)+(-q)/p+q)/1.0)
        z2 <== (y*(-y)*(-y)+(-y)-x-0.6+(-2.0)/(-x)*(y/(-x)+(-y)/x+y)/1.0)
        print.cccc (I 2307) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2308
        !"test2308"
        z1 <== q
        z2 <== y
        print.cccc (I 2308) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2309
        !"test2309"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2309) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2310
        !"test2310"
        z1 <== (-7.4)
        z2 <== (-7.4)
        print.cccc (I 2310) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2311
        !"test2311"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 2311) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2312
        !"test2312"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 2312) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2313
        !"test2313"
        z1 <== 5.0-((-2.8)+(-6.0)-(-q)*(-5.1)/p)-((-2.5)+2.1*8.7/(-1.7))*p+8.6+((-p)*q*(-p)+6.5+(7.1+p+(-7.8)))/(5.5/(-q))*(-5.4)
        z2 <== 5.0-((-2.8)+(-6.0)-(-y)*(-5.1)/x)-((-2.5)+2.1*8.7/(-1.7))*x+8.6+((-x)*y*(-x)+6.5+(7.1+x+(-7.8)))/(5.5/(-y))*(-5.4)
        print.cccc (I 2313) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2314
        !"test2314"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 2314) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2315
        !"test2315"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 2315) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2316
        !"test2316"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2316) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2317
        !"test2317"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 2317) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2318
        !"test2318"
        z1 <== (5.2-p)
        z2 <== (5.2-x)
        print.cccc (I 2318) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2319
        !"test2319"
        z1 <== (-p)*6.6*(-2.5)-(-1.0)/(-p)
        z2 <== (-x)*6.6*(-2.5)-(-1.0)/(-x)
        print.cccc (I 2319) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2320
        !"test2320"
        z1 <== q
        z2 <== y
        print.cccc (I 2320) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2321
        !"test2321"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2321) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2322
        !"test2322"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 2322) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2323
        !"test2323"
        z1 <== (-q)*(-p)-q*(q+3.2)/(-3.5)+7.1/7.5/(4.3/5.4)
        z2 <== (-y)*(-x)-y*(y+3.2)/(-3.5)+7.1/7.5/(4.3/5.4)
        print.cccc (I 2323) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2324
        !"test2324"
        z1 <== p
        z2 <== x
        print.cccc (I 2324) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2325
        !"test2325"
        z1 <== (2.2+((5.2)/q-3.3+(-0.8)))
        z2 <== (2.2+((5.2)/y-3.3+(-0.8)))
        print.cccc (I 2325) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2326
        !"test2326"
        z1 <== (p+q-(-q)*p*p*1.7/p*((3.2-p)+(-7.6)+((-1.2)*p)+q/((-q)-p*(-5.0)*(-3.0)*p))-(-6.7))
        z2 <== (x+y-(-y)*x*x*1.7/x*((3.2-x)+(-7.6)+((-1.2)*x)+y/((-y)-x*(-5.0)*(-3.0)*x))-(-6.7))
        print.cccc (I 2326) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2327
        !"test2327"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 2327) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2328
        !"test2328"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 2328) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2329
        !"test2329"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2329) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2330
        !"test2330"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2330) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2331
        !"test2331"
        z1 <== (((q)+q*p*(-p)-6.1)*(q/q-3.2*q)+(-p)/(-5.1))
        z2 <== (((y)+y*x*(-x)-6.1)*(y/y-3.2*y)+(-x)/(-5.1))
        print.cccc (I 2331) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2332
        !"test2332"
        z1 <== p
        z2 <== x
        print.cccc (I 2332) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2333
        !"test2333"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 2333) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2334
        !"test2334"
        z1 <== (7.6-(-p)-(-p)-(-5.3)-0.4)*(-q)*(-4.2)+(4.3/(-q)-q/(-q)/(-6.1)*p)/7.0
        z2 <== (7.6-(-x)-(-x)-(-5.3)-0.4)*(-y)*(-4.2)+(4.3/(-y)-y/(-y)/(-6.1)*x)/7.0
        print.cccc (I 2334) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2335
        !"test2335"
        z1 <== (1.0)
        z2 <== (1.0)
        print.cccc (I 2335) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2336
        !"test2336"
        z1 <== (-3.3)/(-7.0)+(-p)+(-7.2)
        z2 <== (-3.3)/(-7.0)+(-x)+(-7.2)
        print.cccc (I 2336) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2337
        !"test2337"
        z1 <== ((p))
        z2 <== ((x))
        print.cccc (I 2337) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2338
        !"test2338"
        z1 <== q
        z2 <== y
        print.cccc (I 2338) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2339
        !"test2339"
        z1 <== (((-4.5)/(-1.6)/(-0.0))+8.4*(-q)*(((-1.4)*q-(-q)*p)*(-p)/p*(-1.1))/((-q)))
        z2 <== (((-4.5)/(-1.6)/(-0.0))+8.4*(-y)*(((-1.4)*y-(-y)*x)*(-x)/x*(-1.1))/((-y)))
        print.cccc (I 2339) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2340
        !"test2340"
        z1 <== (((-q)-q/(-q)/q+1.6-(8.8/(-1.6)*(-4.3)/p)-(-8.2)+q+q)*4.3)
        z2 <== (((-y)-y/(-y)/y+1.6-(8.8/(-1.6)*(-4.3)/x)-(-8.2)+y+y)*4.3)
        print.cccc (I 2340) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2341
        !"test2341"
        z1 <== (p-3.2-(-7.8)*((-1.8)-(-6.4))+(-p)*2.8/(-5.7)+((-4.0)/q/p-(-3.1)/(-6.7))+(-p)/(1.3-((-1.3)/(-6.1)*(-7.0))/2.5/(-2.2)-4.8*q))
        z2 <== (x-3.2-(-7.8)*((-1.8)-(-6.4))+(-x)*2.8/(-5.7)+((-4.0)/y/x-(-3.1)/(-6.7))+(-x)/(1.3-((-1.3)/(-6.1)*(-7.0))/2.5/(-2.2)-4.8*y))
        print.cccc (I 2341) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2342
        !"test2342"
        z1 <== ((-4.5)+6.2)
        z2 <== ((-4.5)+6.2)
        print.cccc (I 2342) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2343
        !"test2343"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2343) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2344
        !"test2344"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 2344) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2345
        !"test2345"
        z1 <== 2.7
        z2 <== 2.7
        print.cccc (I 2345) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2346
        !"test2346"
        z1 <== q
        z2 <== y
        print.cccc (I 2346) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2347
        !"test2347"
        z1 <== (-q)/(-0.1)+((-7.5)*(8.1)*((-5.8)+1.1+1.6))
        z2 <== (-y)/(-0.1)+((-7.5)*(8.1)*((-5.8)+1.1+1.6))
        print.cccc (I 2347) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2348
        !"test2348"
        z1 <== ((-7.6)/((2.8-(-6.5)-(-6.5)+7.6)*(-3.1)/6.3*(-7.4)/((-p)-(-3.4)))*q+(((-q))+((-1.0)/(-3.0)/(-6.8))*((-p)+p+p/(-p)*q)*p)/((8.2*p/4.0/6.4)))
        z2 <== ((-7.6)/((2.8-(-6.5)-(-6.5)+7.6)*(-3.1)/6.3*(-7.4)/((-x)-(-3.4)))*y+(((-y))+((-1.0)/(-3.0)/(-6.8))*((-x)+x+x/(-x)*y)*x)/((8.2*x/4.0/6.4)))
        print.cccc (I 2348) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2349
        !"test2349"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 2349) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2350
        !"test2350"
        z1 <== (4.3)
        z2 <== (4.3)
        print.cccc (I 2350) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2351
        !"test2351"
        z1 <== ((p*(q-8.6+q-(-8.5))+q-(-q)*q-(-8.6)-(p/(-q)))-2.2/(-q)/(-p)/p)
        z2 <== ((x*(y-8.6+y-(-8.5))+y-(-y)*y-(-8.6)-(x/(-y)))-2.2/(-y)/(-x)/x)
        print.cccc (I 2351) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2352
        !"test2352"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2352) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2353
        !"test2353"
        z1 <== ((((-q)+q*(-4.2)+p+(-p))+(q/q-(-6.8)+(-q)+(-2.1))-(3.7-7.6+(-3.2)+(-p)/(-q))-7.1/((-0.4)-1.4-7.5))+((-p)+8.0))
        z2 <== ((((-y)+y*(-4.2)+x+(-x))+(y/y-(-6.8)+(-y)+(-2.1))-(3.7-7.6+(-3.2)+(-x)/(-y))-7.1/((-0.4)-1.4-7.5))+((-x)+8.0))
        print.cccc (I 2353) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2354
        !"test2354"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2354) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2355
        !"test2355"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 2355) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2356
        !"test2356"
        z1 <== q
        z2 <== y
        print.cccc (I 2356) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2357
        !"test2357"
        z1 <== ((-1.6)*q-(-7.7)+q+(-p)*2.2*q-(-8.7)/(q*(-p)))
        z2 <== ((-1.6)*y-(-7.7)+y+(-x)*2.2*y-(-8.7)/(y*(-x)))
        print.cccc (I 2357) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2358
        !"test2358"
        z1 <== (-4.1)/(-8.0)+6.0-(-0.7)/q*(-p)
        z2 <== (-4.1)/(-8.0)+6.0-(-0.7)/y*(-x)
        print.cccc (I 2358) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2359
        !"test2359"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 2359) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2360
        !"test2360"
        z1 <== (((-3.2)))
        z2 <== (((-3.2)))
        print.cccc (I 2360) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2361
        !"test2361"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2361) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2362
        !"test2362"
        z1 <== p
        z2 <== x
        print.cccc (I 2362) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2363
        !"test2363"
        z1 <== (3.4*(-1.0))
        z2 <== (3.4*(-1.0))
        print.cccc (I 2363) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2364
        !"test2364"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 2364) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2365
        !"test2365"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2365) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2366
        !"test2366"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 2366) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2367
        !"test2367"
        z1 <== ((-p)+(-4.4))
        z2 <== ((-x)+(-4.4))
        print.cccc (I 2367) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2368
        !"test2368"
        z1 <== q
        z2 <== y
        print.cccc (I 2368) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2369
        !"test2369"
        z1 <== (2.6*(-q))
        z2 <== (2.6*(-y))
        print.cccc (I 2369) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2370
        !"test2370"
        z1 <== ((-p)/(-q)/((-0.0)+4.0+q))*7.0*5.3/(-4.3)
        z2 <== ((-x)/(-y)/((-0.0)+4.0+y))*7.0*5.3/(-4.3)
        print.cccc (I 2370) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2371
        !"test2371"
        z1 <== (6.2*7.1/3.0/(((-0.5))))
        z2 <== (6.2*7.1/3.0/(((-0.5))))
        print.cccc (I 2371) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2372
        !"test2372"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 2372) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2373
        !"test2373"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2373) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2374
        !"test2374"
        z1 <== p
        z2 <== x
        print.cccc (I 2374) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2375
        !"test2375"
        z1 <== p
        z2 <== x
        print.cccc (I 2375) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2376
        !"test2376"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 2376) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2377
        !"test2377"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 2377) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2378
        !"test2378"
        z1 <== ((((-0.4)-(-q)+(-1.0))*((-2.4))/((-q)+3.4*1.2/(-2.1)))*(-8.2)*1.0)
        z2 <== ((((-0.4)-(-y)+(-1.0))*((-2.4))/((-y)+3.4*1.2/(-2.1)))*(-8.2)*1.0)
        print.cccc (I 2378) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2379
        !"test2379"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 2379) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2380
        !"test2380"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 2380) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2381
        !"test2381"
        z1 <== ((p))
        z2 <== ((x))
        print.cccc (I 2381) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2382
        !"test2382"
        z1 <== (((-q)+q)*(-p)+(-6.1))*((6.5-6.3-(-4.3))*((-q))+((-8.4)*(-p)/8.5)+(-p)/((-0.7)*(-2.8)))/(4.7-(-p)/(-q)*(-2.1)/(-q))/q-5.8+(-q)+(-4.3)+(-5.3)/(q-(-q)+(-6.7)-(-7.2)*p)
        z2 <== (((-y)+y)*(-x)+(-6.1))*((6.5-6.3-(-4.3))*((-y))+((-8.4)*(-x)/8.5)+(-x)/((-0.7)*(-2.8)))/(4.7-(-x)/(-y)*(-2.1)/(-y))/y-5.8+(-y)+(-4.3)+(-5.3)/(y-(-y)+(-6.7)-(-7.2)*x)
        print.cccc (I 2382) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2383
        !"test2383"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2383) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2384
        !"test2384"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2384) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2385
        !"test2385"
        z1 <== (p/(-0.5))
        z2 <== (x/(-0.5))
        print.cccc (I 2385) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2386
        !"test2386"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2386) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2387
        !"test2387"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2387) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2388
        !"test2388"
        z1 <== (3.6+(((-4.2)))+(-5.1)/(-p))
        z2 <== (3.6+(((-4.2)))+(-5.1)/(-x))
        print.cccc (I 2388) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2389
        !"test2389"
        z1 <== (((-q)+(p+(-0.8)-(-7.7))*(8.3*q*q)*0.8/p)/((-p)*(-2.1)*5.4-(-p)-(-q)-(-p)-(-p))*q)
        z2 <== (((-y)+(x+(-0.8)-(-7.7))*(8.3*y*y)*0.8/x)/((-x)*(-2.1)*5.4-(-x)-(-y)-(-x)-(-x))*y)
        print.cccc (I 2389) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2390
        !"test2390"
        z1 <== (((-3.7)-(-p))/((-q)+(-7.0))+(-6.0)/q*(p/((-3.5)*8.3+0.1+(-q)*(-2.8))+(5.7-0.5-3.6/(-0.2))))
        z2 <== (((-3.7)-(-x))/((-y)+(-7.0))+(-6.0)/y*(x/((-3.5)*8.3+0.1+(-y)*(-2.8))+(5.7-0.5-3.6/(-0.2))))
        print.cccc (I 2390) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2391
        !"test2391"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 2391) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2392
        !"test2392"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 2392) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2393
        !"test2393"
        z1 <== (((-6.1)-0.7-(p*4.8/p/(-p)*(-q))))
        z2 <== (((-6.1)-0.7-(x*4.8/x/(-x)*(-y))))
        print.cccc (I 2393) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2394
        !"test2394"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 2394) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2395
        !"test2395"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 2395) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2396
        !"test2396"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 2396) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2397
        !"test2397"
        z1 <== q
        z2 <== y
        print.cccc (I 2397) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2398
        !"test2398"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 2398) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2399
        !"test2399"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2399) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2400
        !"test2400"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 2400) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2401
        !"test2401"
        z1 <== (-3.6)-(((-q)*p-(-5.8))*p*q)*p
        z2 <== (-3.6)-(((-y)*x-(-5.8))*x*y)*x
        print.cccc (I 2401) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2402
        !"test2402"
        z1 <== (0.1/((-0.0)*(q-(-1.0)-(-7.2)-8.5))*((q+(-2.6)/(-7.7)-(-3.7)*p)/(-7.0)/(0.0/q*(-p))))
        z2 <== (0.1/((-0.0)*(y-(-1.0)-(-7.2)-8.5))*((y+(-2.6)/(-7.7)-(-3.7)*x)/(-7.0)/(0.0/y*(-x))))
        print.cccc (I 2402) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2403
        !"test2403"
        z1 <== p
        z2 <== x
        print.cccc (I 2403) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2404
        !"test2404"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 2404) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2405
        !"test2405"
        z1 <== (-p)/((-3.3)/((-q)/(-0.8)/(-7.7)*(-7.8))-q*q+q)+(p)
        z2 <== (-x)/((-3.3)/((-y)/(-0.8)/(-7.7)*(-7.8))-y*y+y)+(x)
        print.cccc (I 2405) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2406
        !"test2406"
        z1 <== ((4.4/(-4.1)*(8.7-(-p)/(-0.5)*(-q)))+(1.4))
        z2 <== ((4.4/(-4.1)*(8.7-(-x)/(-0.5)*(-y)))+(1.4))
        print.cccc (I 2406) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2407
        !"test2407"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 2407) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2408
        !"test2408"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 2408) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2409
        !"test2409"
        z1 <== ((((-0.6)-(-7.3)/(-p)+q))*(5.1*(-7.3)-((-8.7)-p*(-p)+p*0.0)-(p*q*2.8))*(-8.1)*(-q))
        z2 <== ((((-0.6)-(-7.3)/(-x)+y))*(5.1*(-7.3)-((-8.7)-x*(-x)+x*0.0)-(x*y*2.8))*(-8.1)*(-y))
        print.cccc (I 2409) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2410
        !"test2410"
        z1 <== ((-3.7)-(q/(-q)*(-8.1)/((-p)-(-p)+(-q)*(-q))/0.5*(q-8.2/p+7.3))/2.3)
        z2 <== ((-3.7)-(y/(-y)*(-8.1)/((-x)-(-x)+(-y)*(-y))/0.5*(y-8.2/x+7.3))/2.3)
        print.cccc (I 2410) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2411
        !"test2411"
        z1 <== (6.0)*((q+(-6.6)-3.3/q)-(p))+((-6.5)*6.1)/q
        z2 <== (6.0)*((y+(-6.6)-3.3/y)-(x))+((-6.5)*6.1)/y
        print.cccc (I 2411) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2412
        !"test2412"
        z1 <== ((q*2.1-4.7*(-6.7)*(2.7+p+4.7/6.5+3.2)-(-5.6)+p)-(-p)*3.1/((-q)-(-q)-7.3)-(p+p+(-6.2)/(-5.5)+(-p)))
        z2 <== ((y*2.1-4.7*(-6.7)*(2.7+x+4.7/6.5+3.2)-(-5.6)+x)-(-x)*3.1/((-y)-(-y)-7.3)-(x+x+(-6.2)/(-5.5)+(-x)))
        print.cccc (I 2412) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2413
        !"test2413"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2413) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2414
        !"test2414"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 2414) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2415
        !"test2415"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2415) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2416
        !"test2416"
        z1 <== ((2.3*6.5)-q-p+(-4.3)+p-q-7.6-p)-(-1.8)*5.4/(((-0.3)/0.7-p)+2.5+7.6*(p*(-2.5)))/(-3.1)
        z2 <== ((2.3*6.5)-y-x+(-4.3)+x-y-7.6-x)-(-1.8)*5.4/(((-0.3)/0.7-x)+2.5+7.6*(x*(-2.5)))/(-3.1)
        print.cccc (I 2416) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2417
        !"test2417"
        z1 <== q
        z2 <== y
        print.cccc (I 2417) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2418
        !"test2418"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2418) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2419
        !"test2419"
        z1 <== ((((-5.2)-(-2.2)/(-3.4)*0.0-(-q))*(-p)+(q/q*(-3.2)*(-8.1))-q-(4.6+4.4/(-p)-p)))
        z2 <== ((((-5.2)-(-2.2)/(-3.4)*0.0-(-y))*(-x)+(y/y*(-3.2)*(-8.1))-y-(4.6+4.4/(-x)-x)))
        print.cccc (I 2419) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2420
        !"test2420"
        z1 <== (((-8.1)+(-p)/p+p)-(-q)+((p+p)))
        z2 <== (((-8.1)+(-x)/x+x)-(-y)+((x+x)))
        print.cccc (I 2420) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2421
        !"test2421"
        z1 <== 8.3
        z2 <== 8.3
        print.cccc (I 2421) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2422
        !"test2422"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 2422) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2423
        !"test2423"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 2423) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2424
        !"test2424"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2424) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2425
        !"test2425"
        z1 <== p
        z2 <== x
        print.cccc (I 2425) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2426
        !"test2426"
        z1 <== (q*4.8/(-p)*q-((p)/(-p)-(-3.6)))
        z2 <== (y*4.8/(-x)*y-((x)/(-x)-(-3.6)))
        print.cccc (I 2426) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2427
        !"test2427"
        z1 <== p
        z2 <== x
        print.cccc (I 2427) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2428
        !"test2428"
        z1 <== q
        z2 <== y
        print.cccc (I 2428) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2429
        !"test2429"
        z1 <== (((-p)-6.7)+((0.6-q*8.6*(-p)+(-1.2))))
        z2 <== (((-x)-6.7)+((0.6-y*8.6*(-x)+(-1.2))))
        print.cccc (I 2429) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2430
        !"test2430"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 2430) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2431
        !"test2431"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2431) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2432
        !"test2432"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 2432) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2433
        !"test2433"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 2433) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2434
        !"test2434"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2434) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2435
        !"test2435"
        z1 <== 0.7+(-0.1)-(-0.2)-(-2.5)+(4.0-8.7+p)+p
        z2 <== 0.7+(-0.1)-(-0.2)-(-2.5)+(4.0-8.7+x)+x
        print.cccc (I 2435) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2436
        !"test2436"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 2436) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2437
        !"test2437"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 2437) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2438
        !"test2438"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2438) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2439
        !"test2439"
        z1 <== (4.8*(-p))
        z2 <== (4.8*(-x))
        print.cccc (I 2439) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2440
        !"test2440"
        z1 <== (((-2.0)/(q+3.3))+((q-0.4)*q-7.5-2.1)+(-p))
        z2 <== (((-2.0)/(y+3.3))+((y-0.4)*y-7.5-2.1)+(-x))
        print.cccc (I 2440) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2441
        !"test2441"
        z1 <== (0.1+q+(-q)*q)
        z2 <== (0.1+y+(-y)*y)
        print.cccc (I 2441) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2442
        !"test2442"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2442) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2443
        !"test2443"
        z1 <== (-3.4)
        z2 <== (-3.4)
        print.cccc (I 2443) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2444
        !"test2444"
        z1 <== (((-p))/(-4.4)*q-8.4*((-1.2)+q+(-q))+q-p/(-p)*1.6+((-3.8)/(-q)+6.5*2.3)-((-8.6)/6.8*1.8+q-(-7.1)))
        z2 <== (((-x))/(-4.4)*y-8.4*((-1.2)+y+(-y))+y-x/(-x)*1.6+((-3.8)/(-y)+6.5*2.3)-((-8.6)/6.8*1.8+y-(-7.1)))
        print.cccc (I 2444) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2445
        !"test2445"
        z1 <== (((-0.5)/(-p)+0.2-(-7.3)+1.6-p*(-p)-p)-q-((-p)/q+q-(-2.7))/(1.8*8.2+0.8+(-q))*((-3.0)-(-0.3)-q/(-q)-(-6.1)-0.7)-p)
        z2 <== (((-0.5)/(-x)+0.2-(-7.3)+1.6-x*(-x)-x)-y-((-x)/y+y-(-2.7))/(1.8*8.2+0.8+(-y))*((-3.0)-(-0.3)-y/(-y)-(-6.1)-0.7)-x)
        print.cccc (I 2445) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2446
        !"test2446"
        z1 <== p
        z2 <== x
        print.cccc (I 2446) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2447
        !"test2447"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 2447) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2448
        !"test2448"
        z1 <== q
        z2 <== y
        print.cccc (I 2448) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2449
        !"test2449"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 2449) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2450
        !"test2450"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 2450) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2451
        !"test2451"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 2451) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2452
        !"test2452"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 2452) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2453
        !"test2453"
        z1 <== q
        z2 <== y
        print.cccc (I 2453) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2454
        !"test2454"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2454) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2455
        !"test2455"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2455) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2456
        !"test2456"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 2456) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2457
        !"test2457"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2457) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2458
        !"test2458"
        z1 <== q
        z2 <== y
        print.cccc (I 2458) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2459
        !"test2459"
        z1 <== (-3.7)
        z2 <== (-3.7)
        print.cccc (I 2459) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2460
        !"test2460"
        z1 <== ((3.6)+((1.2/1.6+2.4-(-q))-(-p))+((-q)+(-0.2))/(7.4-((-3.5)*(-3.2)/(-p)))-7.4)
        z2 <== ((3.6)+((1.2/1.6+2.4-(-y))-(-x))+((-y)+(-0.2))/(7.4-((-3.5)*(-3.2)/(-x)))-7.4)
        print.cccc (I 2460) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2461
        !"test2461"
        z1 <== (2.0*(-p))
        z2 <== (2.0*(-x))
        print.cccc (I 2461) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2462
        !"test2462"
        z1 <== ((-2.2)-(-p))
        z2 <== ((-2.2)-(-x))
        print.cccc (I 2462) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2463
        !"test2463"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 2463) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2464
        !"test2464"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 2464) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2465
        !"test2465"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 2465) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2466
        !"test2466"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2466) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2467
        !"test2467"
        z1 <== q
        z2 <== y
        print.cccc (I 2467) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2468
        !"test2468"
        z1 <== (((-q)-((-8.2))+(-8.4)+((-6.4)+(-8.4))*((-q)))*(-q))
        z2 <== (((-y)-((-8.2))+(-8.4)+((-6.4)+(-8.4))*((-y)))*(-y))
        print.cccc (I 2468) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2469
        !"test2469"
        z1 <== (p-(-3.2))/8.3
        z2 <== (x-(-3.2))/8.3
        print.cccc (I 2469) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2470
        !"test2470"
        z1 <== (-5.2)*(-p)+((-p)/(-p)-p-p)*((-q)*(-1.4)/(-0.0)*3.5-1.5)*6.8*((4.7+q-q-(-8.0)/(-p))+(-5.3)*(-p)+q*(-8.5))+(p+4.6/(-q)+(-0.2)+(-q))/((-q)+2.3+(-2.8)-(-q))-q*(-p)-(q-(-q)/1.2*6.1)
        z2 <== (-5.2)*(-x)+((-x)/(-x)-x-x)*((-y)*(-1.4)/(-0.0)*3.5-1.5)*6.8*((4.7+y-y-(-8.0)/(-x))+(-5.3)*(-x)+y*(-8.5))+(x+4.6/(-y)+(-0.2)+(-y))/((-y)+2.3+(-2.8)-(-y))-y*(-x)-(y-(-y)/1.2*6.1)
        print.cccc (I 2470) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2471
        !"test2471"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2471) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2472
        !"test2472"
        z1 <== ((-6.2)-(p-(5.3*p)*(q+(-q)+(-p)+(-4.2)*(-0.3)))-3.4-(((-7.5))+(p-8.3-q+p*(-5.2))*((-q)+(-p)+(-8.2))+2.4*((-q)/(-8.4)-p-3.2/(-0.5))))
        z2 <== ((-6.2)-(x-(5.3*x)*(y+(-y)+(-x)+(-4.2)*(-0.3)))-3.4-(((-7.5))+(x-8.3-y+x*(-5.2))*((-y)+(-x)+(-8.2))+2.4*((-y)/(-8.4)-x-3.2/(-0.5))))
        print.cccc (I 2472) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2473
        !"test2473"
        z1 <== (-p)-((-6.2)*p+p*p*q)-(-5.8)
        z2 <== (-x)-((-6.2)*x+x*x*y)-(-5.8)
        print.cccc (I 2473) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2474
        !"test2474"
        z1 <== (((p+p+2.3))+(((-p))+q)-p*(7.2*(-7.8)-(-3.5))+5.2/(-1.1)-q+7.4+3.7-((-q)*p))
        z2 <== (((x+x+2.3))+(((-x))+y)-x*(7.2*(-7.8)-(-3.5))+5.2/(-1.1)-y+7.4+3.7-((-y)*x))
        print.cccc (I 2474) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2475
        !"test2475"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 2475) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2476
        !"test2476"
        z1 <== (7.1)
        z2 <== (7.1)
        print.cccc (I 2476) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2477
        !"test2477"
        z1 <== (8.7-p+((-q)/0.0-(-5.7)/p-(-3.3))+(-6.4)-p)
        z2 <== (8.7-x+((-y)/0.0-(-5.7)/x-(-3.3))+(-6.4)-x)
        print.cccc (I 2477) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2478
        !"test2478"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 2478) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2479
        !"test2479"
        z1 <== ((p*(-q))-q*((-q)/p+2.1*q*3.1)-(0.1/(-p)*0.7+3.0+(-q))-q)/3.0/(-4.1)+(p-(-3.6)/q-(-p)-q)-0.5
        z2 <== ((x*(-y))-y*((-y)/x+2.1*y*3.1)-(0.1/(-x)*0.7+3.0+(-y))-y)/3.0/(-4.1)+(x-(-3.6)/y-(-x)-y)-0.5
        print.cccc (I 2479) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2480
        !"test2480"
        z1 <== p
        z2 <== x
        print.cccc (I 2480) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2481
        !"test2481"
        z1 <== (-4.0)
        z2 <== (-4.0)
        print.cccc (I 2481) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2482
        !"test2482"
        z1 <== (-7.5)*0.1-((p*(-p)*(-4.7)/(-1.1))+((-q)-4.4-(-q))*6.8/p-q)+(((-q))*(-0.4)-(-q)*4.8*(-p))/(-q)
        z2 <== (-7.5)*0.1-((x*(-x)*(-4.7)/(-1.1))+((-y)-4.4-(-y))*6.8/x-y)+(((-y))*(-0.4)-(-y)*4.8*(-x))/(-y)
        print.cccc (I 2482) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2483
        !"test2483"
        z1 <== (2.0)
        z2 <== (2.0)
        print.cccc (I 2483) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2484
        !"test2484"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2484) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2485
        !"test2485"
        z1 <== 8.1+0.3*(-7.6)
        z2 <== 8.1+0.3*(-7.6)
        print.cccc (I 2485) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2486
        !"test2486"
        z1 <== (-p)*(-5.5)+((q*8.6/(-p)/(-7.4))-((-q)-q/q/7.0-(-p)))-8.4*(((-3.8))/q-(-5.8))
        z2 <== (-x)*(-5.5)+((y*8.6/(-x)/(-7.4))-((-y)-y/y/7.0-(-x)))-8.4*(((-3.8))/y-(-5.8))
        print.cccc (I 2486) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2487
        !"test2487"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 2487) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2488
        !"test2488"
        z1 <== (6.0+(-1.5)*6.4/q-(-p)+(-1.4)+((-0.8)+(-q)+4.0)-(((-q)*(-7.8)-q+(-q)+7.3)+(p))/5.8-((-p)+(4.5/(-3.1)+(-p)*(-q))/((-q))/6.8+(q*4.1/p-q)))
        z2 <== (6.0+(-1.5)*6.4/y-(-x)+(-1.4)+((-0.8)+(-y)+4.0)-(((-y)*(-7.8)-y+(-y)+7.3)+(x))/5.8-((-x)+(4.5/(-3.1)+(-x)*(-y))/((-y))/6.8+(y*4.1/x-y)))
        print.cccc (I 2488) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2489
        !"test2489"
        z1 <== p
        z2 <== x
        print.cccc (I 2489) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2490
        !"test2490"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 2490) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2491
        !"test2491"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2491) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2492
        !"test2492"
        z1 <== 2.6
        z2 <== 2.6
        print.cccc (I 2492) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2493
        !"test2493"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 2493) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2494
        !"test2494"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 2494) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2495
        !"test2495"
        z1 <== ((-q)/(-q)*(-1.4)/q)
        z2 <== ((-y)/(-y)*(-1.4)/y)
        print.cccc (I 2495) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2496
        !"test2496"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2496) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2497
        !"test2497"
        z1 <== (-p)-(2.7+1.0/(-q)+5.1+7.1)+8.4/((-p))+(-q)-((-0.6)+q+(-5.7)-(-p)-(p-6.2/7.1-p+q)/6.4-4.3)+2.2-((5.5-(-q)-p*(-8.2)*(-0.3))*7.5*q)*((p/4.7*p)*(-5.3)-(-6.0))
        z2 <== (-x)-(2.7+1.0/(-y)+5.1+7.1)+8.4/((-x))+(-y)-((-0.6)+y+(-5.7)-(-x)-(x-6.2/7.1-x+y)/6.4-4.3)+2.2-((5.5-(-y)-x*(-8.2)*(-0.3))*7.5*y)*((x/4.7*x)*(-5.3)-(-6.0))
        print.cccc (I 2497) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2498
        !"test2498"
        z1 <== ((-p)+(((-q)/(-0.7)+(-1.1)*6.4)-7.2+q))
        z2 <== ((-x)+(((-y)/(-0.7)+(-1.1)*6.4)-7.2+y))
        print.cccc (I 2498) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2499
        !"test2499"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2499) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2500
        !"test2500"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 2500) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2501
        !"test2501"
        z1 <== q
        z2 <== y
        print.cccc (I 2501) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2502
        !"test2502"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2502) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2503
        !"test2503"
        z1 <== 4.0
        z2 <== 4.0
        print.cccc (I 2503) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2504
        !"test2504"
        z1 <== 7.8
        z2 <== 7.8
        print.cccc (I 2504) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2505
        !"test2505"
        z1 <== q
        z2 <== y
        print.cccc (I 2505) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2506
        !"test2506"
        z1 <== ((-q)/(-0.7)/p+0.7+(-6.4)+(-p)-q+(-p)*p*4.2-(-7.4)-(-4.6)/(-3.2)*(-p))
        z2 <== ((-y)/(-0.7)/x+0.7+(-6.4)+(-x)-y+(-x)*x*4.2-(-7.4)-(-4.6)/(-3.2)*(-x))
        print.cccc (I 2506) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2507
        !"test2507"
        z1 <== q
        z2 <== y
        print.cccc (I 2507) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2508
        !"test2508"
        z1 <== ((-q)+(-p)+(-q)*(-8.8)-((-p)+q/(3.5+p/(-6.3)/(-8.5))*5.0-((-q)-p*2.5)))
        z2 <== ((-y)+(-x)+(-y)*(-8.8)-((-x)+y/(3.5+x/(-6.3)/(-8.5))*5.0-((-y)-x*2.5)))
        print.cccc (I 2508) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2509
        !"test2509"
        z1 <== (-0.8)
        z2 <== (-0.8)
        print.cccc (I 2509) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2510
        !"test2510"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2510) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2511
        !"test2511"
        z1 <== ((2.2-((-4.4))-0.2/(-q))*p+(2.0-((-1.3)+q)+(-p)+(6.1)+(-p))+3.0+((-7.2)*8.0-7.0/8.1))
        z2 <== ((2.2-((-4.4))-0.2/(-y))*x+(2.0-((-1.3)+y)+(-x)+(6.1)+(-x))+3.0+((-7.2)*8.0-7.0/8.1))
        print.cccc (I 2511) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2512
        !"test2512"
        z1 <== q
        z2 <== y
        print.cccc (I 2512) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2513
        !"test2513"
        z1 <== ((-p))-((-0.0))
        z2 <== ((-x))-((-0.0))
        print.cccc (I 2513) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2514
        !"test2514"
        z1 <== ((-6.4)*((-q))/p-((-p)/p))
        z2 <== ((-6.4)*((-y))/x-((-x)/x))
        print.cccc (I 2514) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2515
        !"test2515"
        z1 <== (8.6)
        z2 <== (8.6)
        print.cccc (I 2515) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2516
        !"test2516"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 2516) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2517
        !"test2517"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2517) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2518
        !"test2518"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 2518) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2519
        !"test2519"
        z1 <== (((-p)-q)-(-p)-1.1-((q)/3.6)/(-2.2)/((-p)*(-p)*(-8.7)+(-5.5)))
        z2 <== (((-x)-y)-(-x)-1.1-((y)/3.6)/(-2.2)/((-x)*(-x)*(-8.7)+(-5.5)))
        print.cccc (I 2519) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2520
        !"test2520"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2520) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2521
        !"test2521"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2521) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2522
        !"test2522"
        z1 <== (p+(p-3.6/(-0.7))-(-7.6)-(-q)/7.0)
        z2 <== (x+(x-3.6/(-0.7))-(-7.6)-(-y)/7.0)
        print.cccc (I 2522) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2523
        !"test2523"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 2523) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2524
        !"test2524"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 2524) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2525
        !"test2525"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 2525) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2526
        !"test2526"
        z1 <== (-5.7)*(((-q)*5.4-(-3.0)/q/(-p)))/(-2.5)
        z2 <== (-5.7)*(((-y)*5.4-(-3.0)/y/(-x)))/(-2.5)
        print.cccc (I 2526) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2527
        !"test2527"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 2527) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2528
        !"test2528"
        z1 <== p
        z2 <== x
        print.cccc (I 2528) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2529
        !"test2529"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2529) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2530
        !"test2530"
        z1 <== ((((-q)-q*(-q)/p*q))/3.7/(-p)+((8.7*(-p))))
        z2 <== ((((-y)-y*(-y)/x*y))/3.7/(-x)+((8.7*(-x))))
        print.cccc (I 2530) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2531
        !"test2531"
        z1 <== ((-3.4)/((-q)+(-q)-2.7-(-q)+(-4.6)-(-q)-5.1/5.2-(-q))*((p*p+(-p)*2.3*(-5.4)))+(-4.3)+3.0)
        z2 <== ((-3.4)/((-y)+(-y)-2.7-(-y)+(-4.6)-(-y)-5.1/5.2-(-y))*((x*x+(-x)*2.3*(-5.4)))+(-4.3)+3.0)
        print.cccc (I 2531) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2532
        !"test2532"
        z1 <== ((p)*1.5*p/((p/7.1-2.7-(-1.8))/((-8.4)/(-3.7))/7.2+(-7.2))-p-((-2.5)/8.2/q/(-1.8)-(-p)*1.3))
        z2 <== ((x)*1.5*x/((x/7.1-2.7-(-1.8))/((-8.4)/(-3.7))/7.2+(-7.2))-x-((-2.5)/8.2/y/(-1.8)-(-x)*1.3))
        print.cccc (I 2532) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2533
        !"test2533"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 2533) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2534
        !"test2534"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 2534) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2535
        !"test2535"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2535) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2536
        !"test2536"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2536) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2537
        !"test2537"
        z1 <== p
        z2 <== x
        print.cccc (I 2537) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2538
        !"test2538"
        z1 <== (-0.8)+(5.2)/0.1+4.1
        z2 <== (-0.8)+(5.2)/0.1+4.1
        print.cccc (I 2538) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2539
        !"test2539"
        z1 <== (1.7-2.7/p*(q/(-p)/(-q)/(-7.8))-((-p)+(-q)/(-0.0)/(q)/(-7.0)))
        z2 <== (1.7-2.7/x*(y/(-x)/(-y)/(-7.8))-((-x)+(-y)/(-0.0)/(y)/(-7.0)))
        print.cccc (I 2539) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2540
        !"test2540"
        z1 <== ((-2.4)*q*((-p)-(q-0.5+q)*p)-3.4)
        z2 <== ((-2.4)*y*((-x)-(y-0.5+y)*x)-3.4)
        print.cccc (I 2540) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2541
        !"test2541"
        z1 <== q
        z2 <== y
        print.cccc (I 2541) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2542
        !"test2542"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2542) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2543
        !"test2543"
        z1 <== (((-p)-q+(-3.8)*4.2/(-0.2)-6.8+q)-(-4.7))
        z2 <== (((-x)-y+(-3.8)*4.2/(-0.2)-6.8+y)-(-4.7))
        print.cccc (I 2543) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2544
        !"test2544"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 2544) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2545
        !"test2545"
        z1 <== q
        z2 <== y
        print.cccc (I 2545) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2546
        !"test2546"
        z1 <== ((-q)-p*(-6.0)/((-4.6)/p-((-q)/(-8.8))-((-3.0)+p-(-1.6)/(-4.4)))*(-1.6))
        z2 <== ((-y)-x*(-6.0)/((-4.6)/x-((-y)/(-8.8))-((-3.0)+x-(-1.6)/(-4.4)))*(-1.6))
        print.cccc (I 2546) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2547
        !"test2547"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 2547) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2548
        !"test2548"
        z1 <== (5.5+(-1.3))/(-0.8)-(-2.8)
        z2 <== (5.5+(-1.3))/(-0.8)-(-2.8)
        print.cccc (I 2548) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2549
        !"test2549"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 2549) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2550
        !"test2550"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 2550) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2551
        !"test2551"
        z1 <== 4.3
        z2 <== 4.3
        print.cccc (I 2551) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2552
        !"test2552"
        z1 <== ((-p)+(-1.8)+(-p)+(-p)-7.0)
        z2 <== ((-x)+(-1.8)+(-x)+(-x)-7.0)
        print.cccc (I 2552) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2553
        !"test2553"
        z1 <== ((-7.0)+q-(-6.5))
        z2 <== ((-7.0)+y-(-6.5))
        print.cccc (I 2553) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2554
        !"test2554"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 2554) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2555
        !"test2555"
        z1 <== (((-0.6)-6.3*q)/4.5/(q/p/((-8.8)+p))*(-p)+((-3.7)-(-3.8)/(-p)*7.5))
        z2 <== (((-0.6)-6.3*y)/4.5/(y/x/((-8.8)+x))*(-x)+((-3.7)-(-3.8)/(-x)*7.5))
        print.cccc (I 2555) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2556
        !"test2556"
        z1 <== (1.3+8.6*3.3/(-p)-(-q)*q/(-q)-(-4.8)/(-3.2))
        z2 <== (1.3+8.6*3.3/(-x)-(-y)*y/(-y)-(-4.8)/(-3.2))
        print.cccc (I 2556) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2557
        !"test2557"
        z1 <== (q+(-q))
        z2 <== (y+(-y))
        print.cccc (I 2557) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2558
        !"test2558"
        z1 <== (-1.7)
        z2 <== (-1.7)
        print.cccc (I 2558) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2559
        !"test2559"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 2559) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2560
        !"test2560"
        z1 <== (((-1.5)/(-5.4)*p-(-0.3)+(-q))-(p))
        z2 <== (((-1.5)/(-5.4)*x-(-0.3)+(-y))-(x))
        print.cccc (I 2560) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2561
        !"test2561"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2561) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2562
        !"test2562"
        z1 <== p
        z2 <== x
        print.cccc (I 2562) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2563
        !"test2563"
        z1 <== ((-3.1)+(7.2)+(((-5.4)-5.4/(-p)-q*0.4)/(4.5)))
        z2 <== ((-3.1)+(7.2)+(((-5.4)-5.4/(-x)-y*0.4)/(4.5)))
        print.cccc (I 2563) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2564
        !"test2564"
        z1 <== (5.2/((-7.6)/(1.3-(-q)*p)*(-p))+p*1.0*((1.5/4.7*(-6.8)-8.1*(-2.2))))
        z2 <== (5.2/((-7.6)/(1.3-(-y)*x)*(-x))+x*1.0*((1.5/4.7*(-6.8)-8.1*(-2.2))))
        print.cccc (I 2564) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2565
        !"test2565"
        z1 <== ((-2.0)-(-p)+(-6.1)*(-2.0)*(-7.0)*(-6.0)-((-3.0)+6.2))
        z2 <== ((-2.0)-(-x)+(-6.1)*(-2.0)*(-7.0)*(-6.0)-((-3.0)+6.2))
        print.cccc (I 2565) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2566
        !"test2566"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 2566) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2567
        !"test2567"
        z1 <== (((-5.3)/q*4.5)-(-q))
        z2 <== (((-5.3)/y*4.5)-(-y))
        print.cccc (I 2567) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2568
        !"test2568"
        z1 <== q
        z2 <== y
        print.cccc (I 2568) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2569
        !"test2569"
        z1 <== p
        z2 <== x
        print.cccc (I 2569) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2570
        !"test2570"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2570) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2571
        !"test2571"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 2571) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2572
        !"test2572"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 2572) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2573
        !"test2573"
        z1 <== ((((-4.4))*(1.4)-(1.4+(-8.8)+3.3)+(-3.0))-((1.2)/(-q)*q+(-5.0)+(-2.3)*(-2.4)-q/(-0.5)/(-8.2)))
        z2 <== ((((-4.4))*(1.4)-(1.4+(-8.8)+3.3)+(-3.0))-((1.2)/(-y)*y+(-5.0)+(-2.3)*(-2.4)-y/(-0.5)/(-8.2)))
        print.cccc (I 2573) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2574
        !"test2574"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2574) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2575
        !"test2575"
        z1 <== ((-q)+q+7.3*6.6/q+q+7.0+((-7.0)-(-q))/6.1)
        z2 <== ((-y)+y+7.3*6.6/y+y+7.0+((-7.0)-(-y))/6.1)
        print.cccc (I 2575) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2576
        !"test2576"
        z1 <== ((-1.7)+(p*7.1+(-6.8)/(-p)*(-2.3))-((-p)-(-0.2)+4.4)/6.6)
        z2 <== ((-1.7)+(x*7.1+(-6.8)/(-x)*(-2.3))-((-x)-(-0.2)+4.4)/6.6)
        print.cccc (I 2576) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2577
        !"test2577"
        z1 <== ((-8.1))-(((-7.7)/3.6/p/(-5.4))*(-q)/q-q+7.5-q/(-q)*(-q))
        z2 <== ((-8.1))-(((-7.7)/3.6/x/(-5.4))*(-y)/y-y+7.5-y/(-y)*(-y))
        print.cccc (I 2577) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2578
        !"test2578"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 2578) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2579
        !"test2579"
        z1 <== ((((-5.8)-(-q)-(-3.1))/((-2.4)+5.6+(-p)/(-q)+8.8)/((-8.7)*5.7)*2.5)*1.5+(q/q-p-(-3.2)/(-p)+p+(-3.6))+q/((-4.5)*(p+(-1.4))))
        z2 <== ((((-5.8)-(-y)-(-3.1))/((-2.4)+5.6+(-x)/(-y)+8.8)/((-8.7)*5.7)*2.5)*1.5+(y/y-x-(-3.2)/(-x)+x+(-3.6))+y/((-4.5)*(x+(-1.4))))
        print.cccc (I 2579) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2580
        !"test2580"
        z1 <== (((7.6*8.8-(-6.7)/q)/(-4.4)-(-q)-p/5.4*4.1+(-q))/(-q)*(6.8+((-5.2)+(-8.1))/8.6*((-2.1)-(-5.2)+8.2+7.4-(-q))-(-7.0))/(-8.7))
        z2 <== (((7.6*8.8-(-6.7)/y)/(-4.4)-(-y)-x/5.4*4.1+(-y))/(-y)*(6.8+((-5.2)+(-8.1))/8.6*((-2.1)-(-5.2)+8.2+7.4-(-y))-(-7.0))/(-8.7))
        print.cccc (I 2580) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2581
        !"test2581"
        z1 <== ((p/(-p)/4.2-(-6.3)-4.4*p*(-q)+1.5-q-(0.3-(-5.3)-(-2.0)))-((-5.4)/8.1/1.1-q/(-q))/(-4.7))
        z2 <== ((x/(-x)/4.2-(-6.3)-4.4*x*(-y)+1.5-y-(0.3-(-5.3)-(-2.0)))-((-5.4)/8.1/1.1-y/(-y))/(-4.7))
        print.cccc (I 2581) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2582
        !"test2582"
        z1 <== (((-2.3)*(q*(-6.7)*p+q+p)+((-7.2)+q/0.4-(-q)))-p*q+(-p)*(-q))
        z2 <== (((-2.3)*(y*(-6.7)*x+y+x)+((-7.2)+y/0.4-(-y)))-x*y+(-x)*(-y))
        print.cccc (I 2582) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2583
        !"test2583"
        z1 <== (p-6.7/8.1*(-8.3))-q-(-5.8)*4.5
        z2 <== (x-6.7/8.1*(-8.3))-y-(-5.8)*4.5
        print.cccc (I 2583) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2584
        !"test2584"
        z1 <== p
        z2 <== x
        print.cccc (I 2584) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2585
        !"test2585"
        z1 <== ((-q)-(-8.8))
        z2 <== ((-y)-(-8.8))
        print.cccc (I 2585) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2586
        !"test2586"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 2586) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2587
        !"test2587"
        z1 <== (-1.6)
        z2 <== (-1.6)
        print.cccc (I 2587) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2588
        !"test2588"
        z1 <== (((p-(-4.8)+(-0.6)+(-4.4))/(-5.4)+5.6)+((-0.2)))
        z2 <== (((x-(-4.8)+(-0.6)+(-4.4))/(-5.4)+5.6)+((-0.2)))
        print.cccc (I 2588) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2589
        !"test2589"
        z1 <== (((-q)-(-p)*7.3-8.3*2.7-((-1.5)*(-7.8)+q)-((-3.4)-(-p)+(-7.0)))*(-q)/p-(-q)*q)
        z2 <== (((-y)-(-x)*7.3-8.3*2.7-((-1.5)*(-7.8)+y)-((-3.4)-(-x)+(-7.0)))*(-y)/x-(-y)*y)
        print.cccc (I 2589) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2590
        !"test2590"
        z1 <== (7.1)
        z2 <== (7.1)
        print.cccc (I 2590) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2591
        !"test2591"
        z1 <== p
        z2 <== x
        print.cccc (I 2591) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2592
        !"test2592"
        z1 <== ((q*(-2.5)*3.4*(-7.5)*(-2.6)*8.6*(-q))+(p/4.2+2.1+0.7)/(8.7-(p/(-p)-(-7.6)-6.0-p)/p*q+(-q))*(-1.0))
        z2 <== ((y*(-2.5)*3.4*(-7.5)*(-2.6)*8.6*(-y))+(x/4.2+2.1+0.7)/(8.7-(x/(-x)-(-7.6)-6.0-x)/x*y+(-y))*(-1.0))
        print.cccc (I 2592) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2593
        !"test2593"
        z1 <== q
        z2 <== y
        print.cccc (I 2593) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2594
        !"test2594"
        z1 <== ((-1.5)/q+((p/8.4-8.3-(-q))*(-4.4)*8.6/q/(p/(-1.7)-p/2.0*7.1))/2.5+(-4.1))
        z2 <== ((-1.5)/y+((x/8.4-8.3-(-y))*(-4.4)*8.6/y/(x/(-1.7)-x/2.0*7.1))/2.5+(-4.1))
        print.cccc (I 2594) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2595
        !"test2595"
        z1 <== ((-q)-((-0.4)+((-8.4)/3.7*q)*q+(-p)*p)+((-5.8)/(-8.6)+p+((-q)*1.8+(-p)/4.3)*(3.3/0.2+(-q)+p))*((-p)+q*(-1.2)/(-p)+(-q)/((-3.6)+8.4-(-q)-4.5)*(-p)+(-7.7)/8.8+6.5))
        z2 <== ((-y)-((-0.4)+((-8.4)/3.7*y)*y+(-x)*x)+((-5.8)/(-8.6)+x+((-y)*1.8+(-x)/4.3)*(3.3/0.2+(-y)+x))*((-x)+y*(-1.2)/(-x)+(-y)/((-3.6)+8.4-(-y)-4.5)*(-x)+(-7.7)/8.8+6.5))
        print.cccc (I 2595) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2596
        !"test2596"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 2596) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2597
        !"test2597"
        z1 <== q
        z2 <== y
        print.cccc (I 2597) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2598
        !"test2598"
        z1 <== (((-5.4)-(-q)*(-1.7)+(-q)*(-p))*(((-q))-6.5+q))
        z2 <== (((-5.4)-(-y)*(-1.7)+(-y)*(-x))*(((-y))-6.5+y))
        print.cccc (I 2598) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2599
        !"test2599"
        z1 <== (-2.5)*(-8.6)*(-q)
        z2 <== (-2.5)*(-8.6)*(-y)
        print.cccc (I 2599) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2600
        !"test2600"
        z1 <== 7.3
        z2 <== 7.3
        print.cccc (I 2600) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2601
        !"test2601"
        z1 <== q
        z2 <== y
        print.cccc (I 2601) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2602
        !"test2602"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2602) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2603
        !"test2603"
        z1 <== p
        z2 <== x
        print.cccc (I 2603) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2604
        !"test2604"
        z1 <== ((((-1.3)))/(1.1-(7.5+(-2.3)*(-p))*((-7.6)))+q-q)
        z2 <== ((((-1.3)))/(1.1-(7.5+(-2.3)*(-x))*((-7.6)))+y-y)
        print.cccc (I 2604) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2605
        !"test2605"
        z1 <== ((3.2/(q/8.4*0.7*q)))
        z2 <== ((3.2/(y/8.4*0.7*y)))
        print.cccc (I 2605) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2606
        !"test2606"
        z1 <== (((1.5+(-6.3)*(-q))+2.5/(-p)-(-6.6)+(-0.5)+(-5.8)/p+q/7.5/p)/p-(-q))
        z2 <== (((1.5+(-6.3)*(-y))+2.5/(-x)-(-6.6)+(-0.5)+(-5.8)/x+y/7.5/x)/x-(-y))
        print.cccc (I 2606) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2607
        !"test2607"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2607) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2608
        !"test2608"
        z1 <== (q-q/((-q)-0.5+(p+7.7*p+(-p))-4.5))
        z2 <== (y-y/((-y)-0.5+(x+7.7*x+(-x))-4.5))
        print.cccc (I 2608) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2609
        !"test2609"
        z1 <== p
        z2 <== x
        print.cccc (I 2609) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2610
        !"test2610"
        z1 <== ((-0.7)*((-8.6)-(-q))/((-5.4))/q)
        z2 <== ((-0.7)*((-8.6)-(-y))/((-5.4))/y)
        print.cccc (I 2610) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2611
        !"test2611"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2611) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2612
        !"test2612"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 2612) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2613
        !"test2613"
        z1 <== (((-6.0))-(-4.7)/(p-(-q))*((-2.5)*(-q)+(-p))*(-q)+((0.5+5.8)-(-0.7)/(-p)+((-2.7)/(-p)/p/8.7)))
        z2 <== (((-6.0))-(-4.7)/(x-(-y))*((-2.5)*(-y)+(-x))*(-y)+((0.5+5.8)-(-0.7)/(-x)+((-2.7)/(-x)/x/8.7)))
        print.cccc (I 2613) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2614
        !"test2614"
        z1 <== (((3.6/(-1.1)+(-2.8)*(-0.4)*5.4)+q+(-q)-3.8/(-q)*p/q+((-7.8)*7.3))*(-2.4)-((3.2-(-q)-q))*(((-p)/2.3-8.4/(-4.5)/(-7.6))+(-p)*(-0.1)*q/(-7.2)*((-8.1))))
        z2 <== (((3.6/(-1.1)+(-2.8)*(-0.4)*5.4)+y+(-y)-3.8/(-y)*x/y+((-7.8)*7.3))*(-2.4)-((3.2-(-y)-y))*(((-x)/2.3-8.4/(-4.5)/(-7.6))+(-x)*(-0.1)*y/(-7.2)*((-8.1))))
        print.cccc (I 2614) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2615
        !"test2615"
        z1 <== (0.4-(((-6.4)+q/8.7*5.4)*((-q)/p)-q))
        z2 <== (0.4-(((-6.4)+y/8.7*5.4)*((-y)/x)-y))
        print.cccc (I 2615) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2616
        !"test2616"
        z1 <== 1.4+p+(((-p)/(-6.5))*p-(-q)*3.1)*(-6.1)
        z2 <== 1.4+x+(((-x)/(-6.5))*x-(-y)*3.1)*(-6.1)
        print.cccc (I 2616) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2617
        !"test2617"
        z1 <== ((-2.2))
        z2 <== ((-2.2))
        print.cccc (I 2617) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2618
        !"test2618"
        z1 <== ((((-q)/(-p)/(-p)-(-0.4))/(-p)*((-4.3)/(-4.6)/p)/(-0.3)-p/p)+(-p)*p+((-6.6))/((-q)))
        z2 <== ((((-y)/(-x)/(-x)-(-0.4))/(-x)*((-4.3)/(-4.6)/x)/(-0.3)-x/x)+(-x)*x+((-6.6))/((-y)))
        print.cccc (I 2618) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2619
        !"test2619"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2619) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2620
        !"test2620"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 2620) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2621
        !"test2621"
        z1 <== q
        z2 <== y
        print.cccc (I 2621) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2622
        !"test2622"
        z1 <== (4.1)
        z2 <== (4.1)
        print.cccc (I 2622) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2623
        !"test2623"
        z1 <== (1.6/((-q)*4.5+(-3.6)-(-3.3))*((-p))/(-q))
        z2 <== (1.6/((-y)*4.5+(-3.6)-(-3.3))*((-x))/(-y))
        print.cccc (I 2623) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2624
        !"test2624"
        z1 <== ((-5.4))
        z2 <== ((-5.4))
        print.cccc (I 2624) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2625
        !"test2625"
        z1 <== (((p)))
        z2 <== (((x)))
        print.cccc (I 2625) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2626
        !"test2626"
        z1 <== (5.2+(-3.6)/(-p)-((-3.6)/3.0/(-5.3)*3.3))/(-6.4)*((-p))*(p+(-2.6))/2.7+(7.5/(-p)*(-6.1)+3.5)-4.5
        z2 <== (5.2+(-3.6)/(-x)-((-3.6)/3.0/(-5.3)*3.3))/(-6.4)*((-x))*(x+(-2.6))/2.7+(7.5/(-x)*(-6.1)+3.5)-4.5
        print.cccc (I 2626) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2627
        !"test2627"
        z1 <== (5.0+p)-((-8.8)+p-q-q)-((-3.2))*5.3-(-6.5)+4.4/(-p)-(-q)-(-q)/(-8.0)-(p+q)
        z2 <== (5.0+x)-((-8.8)+x-y-y)-((-3.2))*5.3-(-6.5)+4.4/(-x)-(-y)-(-y)/(-8.0)-(x+y)
        print.cccc (I 2627) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2628
        !"test2628"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 2628) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2629
        !"test2629"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2629) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2630
        !"test2630"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 2630) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2631
        !"test2631"
        z1 <== (((-6.5)+1.6)-(1.7+5.8*(-2.2))-((0.0/7.6)+(-p)*(q+8.0/p/(-8.7)-(-q)))+(-5.7)-((-q)/((-q)+(-q)+(-3.0)-6.8)-0.1))
        z2 <== (((-6.5)+1.6)-(1.7+5.8*(-2.2))-((0.0/7.6)+(-x)*(y+8.0/x/(-8.7)-(-y)))+(-5.7)-((-y)/((-y)+(-y)+(-3.0)-6.8)-0.1))
        print.cccc (I 2631) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2632
        !"test2632"
        z1 <== (((p/(-3.3)-6.4-8.5-(-6.4))/1.5))
        z2 <== (((x/(-3.3)-6.4-8.5-(-6.4))/1.5))
        print.cccc (I 2632) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2633
        !"test2633"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2633) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2634
        !"test2634"
        z1 <== ((q+(p-0.0-6.8))-p-p*(3.5/7.3*(3.3/q/(-4.7))-4.7/(-q)-(-3.3))/(-7.2)+6.5+(-4.1)+((-q)))
        z2 <== ((y+(x-0.0-6.8))-x-x*(3.5/7.3*(3.3/y/(-4.7))-4.7/(-y)-(-3.3))/(-7.2)+6.5+(-4.1)+((-y)))
        print.cccc (I 2634) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2635
        !"test2635"
        z1 <== p
        z2 <== x
        print.cccc (I 2635) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2636
        !"test2636"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 2636) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2637
        !"test2637"
        z1 <== ((2.6))
        z2 <== ((2.6))
        print.cccc (I 2637) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2638
        !"test2638"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 2638) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2639
        !"test2639"
        z1 <== ((-q)/((-7.3)-((-p)+1.1/p/2.3*(-p))))
        z2 <== ((-y)/((-7.3)-((-x)+1.1/x/2.3*(-x))))
        print.cccc (I 2639) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2640
        !"test2640"
        z1 <== q
        z2 <== y
        print.cccc (I 2640) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2641
        !"test2641"
        z1 <== (((q/(-q)+(-q)/p)/(-3.5)*2.1/(6.2-5.3/p)/((-p)))*((-5.4))+q)
        z2 <== (((y/(-y)+(-y)/x)/(-3.5)*2.1/(6.2-5.3/x)/((-x)))*((-5.4))+y)
        print.cccc (I 2641) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2642
        !"test2642"
        z1 <== (((-q))/(-p)-p/(-0.3))
        z2 <== (((-y))/(-x)-x/(-0.3))
        print.cccc (I 2642) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2643
        !"test2643"
        z1 <== (-0.5)+(-5.0)-((-1.1)-q*(-q)-(-q)+p/((-0.4)))
        z2 <== (-0.5)+(-5.0)-((-1.1)-y*(-y)-(-y)+x/((-0.4)))
        print.cccc (I 2643) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2644
        !"test2644"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2644) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2645
        !"test2645"
        z1 <== q*(((-q))/((-0.0)+p)+8.5+((-p)-p)-(-p))/(-3.7)-((-p)-((-p)-p+q*5.7)-((-8.8)*p*7.2/(-p)+(-5.5))-p/7.7)*3.1
        z2 <== y*(((-y))/((-0.0)+x)+8.5+((-x)-x)-(-x))/(-3.7)-((-x)-((-x)-x+y*5.7)-((-8.8)*x*7.2/(-x)+(-5.5))-x/7.7)*3.1
        print.cccc (I 2645) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2646
        !"test2646"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2646) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2647
        !"test2647"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2647) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2648
        !"test2648"
        z1 <== (((-2.3)*(q/(-6.7)))/6.1+(5.0-(q-2.7+(-7.1))-((-3.3)))-q*q)
        z2 <== (((-2.3)*(y/(-6.7)))/6.1+(5.0-(y-2.7+(-7.1))-((-3.3)))-y*y)
        print.cccc (I 2648) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2649
        !"test2649"
        z1 <== ((q/0.5+(-q)-p*(-5.6))*q/(p-(-q)+(-q)/5.6-(-q)))
        z2 <== ((y/0.5+(-y)-x*(-5.6))*y/(x-(-y)+(-y)/5.6-(-y)))
        print.cccc (I 2649) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2650
        !"test2650"
        z1 <== ((q-(-q)*(-8.4)+(-p)/1.7)/p)
        z2 <== ((y-(-y)*(-8.4)+(-x)/1.7)/x)
        print.cccc (I 2650) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2651
        !"test2651"
        z1 <== (4.0)
        z2 <== (4.0)
        print.cccc (I 2651) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2652
        !"test2652"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 2652) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2653
        !"test2653"
        z1 <== 6.7
        z2 <== 6.7
        print.cccc (I 2653) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2654
        !"test2654"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 2654) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2655
        !"test2655"
        z1 <== (1.0-(7.3+5.2+6.7)/q*(-q)-(-8.2)-p/(((-7.2)+(-p)-(-p)+0.3)/p+3.8)-((q+(-0.7))*(0.4+(-q)+q+(-q)+p)))
        z2 <== (1.0-(7.3+5.2+6.7)/y*(-y)-(-8.2)-x/(((-7.2)+(-x)-(-x)+0.3)/x+3.8)-((y+(-0.7))*(0.4+(-y)+y+(-y)+x)))
        print.cccc (I 2655) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2656
        !"test2656"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2656) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2657
        !"test2657"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2657) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2658
        !"test2658"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 2658) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2659
        !"test2659"
        z1 <== (p+(-q)+p)
        z2 <== (x+(-y)+x)
        print.cccc (I 2659) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2660
        !"test2660"
        z1 <== (6.4+(-7.1)/p-p+(q*6.1+(-0.1)+3.2*2.2)-(2.1+6.1+(-p)*(-q)+(-3.5)))
        z2 <== (6.4+(-7.1)/x-x+(y*6.1+(-0.1)+3.2*2.2)-(2.1+6.1+(-x)*(-y)+(-3.5)))
        print.cccc (I 2660) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2661
        !"test2661"
        z1 <== ((7.5-((-q)*1.3+q*6.0-5.3)+q)-(-q)-4.4/1.2-(-2.8)*5.3+3.1*(q-(-q)+(-p)-(-p)+q)+((p/6.4*(-p))+((-p)*(-p)/p/5.1+5.2))*((q*(-q)*(-2.1)/1.8/(-q))))
        z2 <== ((7.5-((-y)*1.3+y*6.0-5.3)+y)-(-y)-4.4/1.2-(-2.8)*5.3+3.1*(y-(-y)+(-x)-(-x)+y)+((x/6.4*(-x))+((-x)*(-x)/x/5.1+5.2))*((y*(-y)*(-2.1)/1.8/(-y))))
        print.cccc (I 2661) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2662
        !"test2662"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 2662) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2663
        !"test2663"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 2663) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2664
        !"test2664"
        z1 <== ((-q)*8.6*((-0.6)/(4.1-(-6.3)*(-p))-q-q*(-p))-((2.8-(-p)/(-2.3)/4.1*(-q))/q/(-4.7)/2.3*8.2/6.0)+(6.8))
        z2 <== ((-y)*8.6*((-0.6)/(4.1-(-6.3)*(-x))-y-y*(-x))-((2.8-(-x)/(-2.3)/4.1*(-y))/y/(-4.7)/2.3*8.2/6.0)+(6.8))
        print.cccc (I 2664) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2665
        !"test2665"
        z1 <== 5.7+(-5.0)*((-7.0)+q)/(-3.8)*(p+p-(-7.5)/7.4)-(4.8+p*q-(-p)+p)+(0.6+(-8.5))
        z2 <== 5.7+(-5.0)*((-7.0)+y)/(-3.8)*(x+x-(-7.5)/7.4)-(4.8+x*y-(-x)+x)+(0.6+(-8.5))
        print.cccc (I 2665) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2666
        !"test2666"
        z1 <== (q+8.8+(-0.7))
        z2 <== (y+8.8+(-0.7))
        print.cccc (I 2666) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2667
        !"test2667"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 2667) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2668
        !"test2668"
        z1 <== ((-3.5)+7.3+(-4.1)+((-8.8)+(-1.5))+(-p)+5.0-((-6.6)+(-p)+p/(-8.0)+7.7)+(-p)+(-p))
        z2 <== ((-3.5)+7.3+(-4.1)+((-8.8)+(-1.5))+(-x)+5.0-((-6.6)+(-x)+x/(-8.0)+7.7)+(-x)+(-x))
        print.cccc (I 2668) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2669
        !"test2669"
        z1 <== q
        z2 <== y
        print.cccc (I 2669) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2670
        !"test2670"
        z1 <== 0.0*p-5.8-((-0.5)/(-q)/(-6.8)+(-7.6)/q*p+p-8.4*8.8+(-8.7)+(-2.6)-((-q)))
        z2 <== 0.0*x-5.8-((-0.5)/(-y)/(-6.8)+(-7.6)/y*x+x-8.4*8.8+(-8.7)+(-2.6)-((-y)))
        print.cccc (I 2670) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2671
        !"test2671"
        z1 <== (((q*(-q)-(-0.2))))
        z2 <== (((y*(-y)-(-0.2))))
        print.cccc (I 2671) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2672
        !"test2672"
        z1 <== q
        z2 <== y
        print.cccc (I 2672) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2673
        !"test2673"
        z1 <== ((-5.5)*(((-q)/(-p)/q*(-q)/1.7)*(q+(-q))/(0.4+p-p*p))*(-q)/(-7.2)/(-p)+(-4.3)*4.3*p-q/p*(3.5+5.6)*(-4.3)-(6.6))
        z2 <== ((-5.5)*(((-y)/(-x)/y*(-y)/1.7)*(y+(-y))/(0.4+x-x*x))*(-y)/(-7.2)/(-x)+(-4.3)*4.3*x-y/x*(3.5+5.6)*(-4.3)-(6.6))
        print.cccc (I 2673) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2674
        !"test2674"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 2674) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2675
        !"test2675"
        z1 <== ((-q)+((-p)+(-2.6)+(q*(-6.4)-(-p))))
        z2 <== ((-y)+((-x)+(-2.6)+(y*(-6.4)-(-x))))
        print.cccc (I 2675) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2676
        !"test2676"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 2676) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2677
        !"test2677"
        z1 <== q
        z2 <== y
        print.cccc (I 2677) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2678
        !"test2678"
        z1 <== (0.4*((3.7-p+(-0.7)/3.2)/(-p)))
        z2 <== (0.4*((3.7-x+(-0.7)/3.2)/(-x)))
        print.cccc (I 2678) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2679
        !"test2679"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2679) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2680
        !"test2680"
        z1 <== q
        z2 <== y
        print.cccc (I 2680) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2681
        !"test2681"
        z1 <== ((1.2-q*(-8.2)/1.1))*(q-(p-3.0/(-q)-0.1)+((-q)))*p
        z2 <== ((1.2-y*(-8.2)/1.1))*(y-(x-3.0/(-y)-0.1)+((-y)))*x
        print.cccc (I 2681) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2682
        !"test2682"
        z1 <== ((-5.2)/(5.0)-(((-3.2)-q/(-4.3))-(p-(-p)/6.3)-p+(-1.1)+(-4.1)*(-q)))
        z2 <== ((-5.2)/(5.0)-(((-3.2)-y/(-4.3))-(x-(-x)/6.3)-x+(-1.1)+(-4.1)*(-y)))
        print.cccc (I 2682) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2683
        !"test2683"
        z1 <== ((-5.5))
        z2 <== ((-5.5))
        print.cccc (I 2683) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2684
        !"test2684"
        z1 <== (-5.1)
        z2 <== (-5.1)
        print.cccc (I 2684) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2685
        !"test2685"
        z1 <== q
        z2 <== y
        print.cccc (I 2685) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2686
        !"test2686"
        z1 <== p
        z2 <== x
        print.cccc (I 2686) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2687
        !"test2687"
        z1 <== 7.7
        z2 <== 7.7
        print.cccc (I 2687) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2688
        !"test2688"
        z1 <== ((-p)*(q)+(-q)*(-q))
        z2 <== ((-x)*(y)+(-y)*(-y))
        print.cccc (I 2688) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2689
        !"test2689"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2689) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2690
        !"test2690"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 2690) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2691
        !"test2691"
        z1 <== p+(-4.3)+8.3-3.5+p
        z2 <== x+(-4.3)+8.3-3.5+x
        print.cccc (I 2691) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2692
        !"test2692"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2692) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2693
        !"test2693"
        z1 <== ((q+7.6/6.7*q+(-0.6))-(((-6.7))+q+(-p))+7.3-(((-p)*2.4*(-q)+(-p)-p)))
        z2 <== ((y+7.6/6.7*y+(-0.6))-(((-6.7))+y+(-x))+7.3-(((-x)*2.4*(-y)+(-x)-x)))
        print.cccc (I 2693) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2694
        !"test2694"
        z1 <== (-p)-2.8
        z2 <== (-x)-2.8
        print.cccc (I 2694) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2695
        !"test2695"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 2695) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2696
        !"test2696"
        z1 <== (-6.7)
        z2 <== (-6.7)
        print.cccc (I 2696) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2697
        !"test2697"
        z1 <== q
        z2 <== y
        print.cccc (I 2697) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2698
        !"test2698"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 2698) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2699
        !"test2699"
        z1 <== p
        z2 <== x
        print.cccc (I 2699) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2700
        !"test2700"
        z1 <== (((-1.6)))
        z2 <== (((-1.6)))
        print.cccc (I 2700) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2701
        !"test2701"
        z1 <== ((3.4-p+(p-q/6.1*3.7)-(-6.8))/(((-8.5)))/(((-4.2)/(-q)/(-q)+(-3.8))/p+(-3.1)+(-8.4)+q*(5.8)-1.4)*((q-(-q)*(-7.3)))+8.2)
        z2 <== ((3.4-x+(x-y/6.1*3.7)-(-6.8))/(((-8.5)))/(((-4.2)/(-y)/(-y)+(-3.8))/x+(-3.1)+(-8.4)+y*(5.8)-1.4)*((y-(-y)*(-7.3)))+8.2)
        print.cccc (I 2701) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2702
        !"test2702"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 2702) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2703
        !"test2703"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 2703) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2704
        !"test2704"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 2704) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2705
        !"test2705"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 2705) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2706
        !"test2706"
        z1 <== ((-q)+(1.1*(-p)-(-8.3)*(-p)-(-6.0)/(-p)))
        z2 <== ((-y)+(1.1*(-x)-(-8.3)*(-x)-(-6.0)/(-x)))
        print.cccc (I 2706) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2707
        !"test2707"
        z1 <== p
        z2 <== x
        print.cccc (I 2707) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2708
        !"test2708"
        z1 <== p
        z2 <== x
        print.cccc (I 2708) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2709
        !"test2709"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2709) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2710
        !"test2710"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2710) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2711
        !"test2711"
        z1 <== (((-q))-(-3.5)+(-8.6)+((-3.0)-((-2.5)+(-6.7)+2.5/(-q)/(-q))/(p*(-6.0)-(-8.7)-(-p)-(-p))*(-0.5))-(p-0.3+(-8.7)/((-q))-(8.1)))
        z2 <== (((-y))-(-3.5)+(-8.6)+((-3.0)-((-2.5)+(-6.7)+2.5/(-y)/(-y))/(x*(-6.0)-(-8.7)-(-x)-(-x))*(-0.5))-(x-0.3+(-8.7)/((-y))-(8.1)))
        print.cccc (I 2711) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2712
        !"test2712"
        z1 <== (-p)/(-p)*3.7
        z2 <== (-x)/(-x)*3.7
        print.cccc (I 2712) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2713
        !"test2713"
        z1 <== q
        z2 <== y
        print.cccc (I 2713) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2714
        !"test2714"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2714) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2715
        !"test2715"
        z1 <== (((p+(-q)-q*8.4/(-p)))/1.6)
        z2 <== (((x+(-y)-y*8.4/(-x)))/1.6)
        print.cccc (I 2715) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2716
        !"test2716"
        z1 <== ((6.0+(p/3.6/(-4.4)+(-p))+q)-((q*(-8.3)+q)+(p/(-4.7)/3.6/(-q)*(-q)))+p-(-p)+((-q)+(-p)/(-p))/3.8/(-q))
        z2 <== ((6.0+(x/3.6/(-4.4)+(-x))+y)-((y*(-8.3)+y)+(x/(-4.7)/3.6/(-y)*(-y)))+x-(-x)+((-y)+(-x)/(-x))/3.8/(-y))
        print.cccc (I 2716) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2717
        !"test2717"
        z1 <== (p-(-1.6)/8.7/((-q)))
        z2 <== (x-(-1.6)/8.7/((-y)))
        print.cccc (I 2717) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2718
        !"test2718"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2718) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2719
        !"test2719"
        z1 <== (-q)+(((-p)/(-q)/(-0.3)-3.8/3.3)*(p*(-6.4)/p)*(-p)/((-8.2)-q-1.4*8.7)/((-3.3)/q*(-q)-6.8))/1.2
        z2 <== (-y)+(((-x)/(-y)/(-0.3)-3.8/3.3)*(x*(-6.4)/x)*(-x)/((-8.2)-y-1.4*8.7)/((-3.3)/y*(-y)-6.8))/1.2
        print.cccc (I 2719) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2720
        !"test2720"
        z1 <== q
        z2 <== y
        print.cccc (I 2720) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2721
        !"test2721"
        z1 <== ((q-(q))*(-3.7))
        z2 <== ((y-(y))*(-3.7))
        print.cccc (I 2721) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2722
        !"test2722"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 2722) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2723
        !"test2723"
        z1 <== (((-q)-(-3.8)+(-7.1)-4.3)/p-(q/(-q)+(4.0-(-7.4)+(-q)*(-q)))*(p+(7.3/(-q)*2.7)/(p*(-p))))
        z2 <== (((-y)-(-3.8)+(-7.1)-4.3)/x-(y/(-y)+(4.0-(-7.4)+(-y)*(-y)))*(x+(7.3/(-y)*2.7)/(x*(-x))))
        print.cccc (I 2723) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2724
        !"test2724"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 2724) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2725
        !"test2725"
        z1 <== 3.7
        z2 <== 3.7
        print.cccc (I 2725) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2726
        !"test2726"
        z1 <== ((-q)/p-p)
        z2 <== ((-y)/x-x)
        print.cccc (I 2726) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2727
        !"test2727"
        z1 <== ((4.8*0.0+(-p)/(-p)+(-3.6))*((-q)*(-p)-((-7.7))/(6.0+q/(-p)*5.6+q))/p+((-q)-0.4+q)-(-q)+p-(-2.1)-(-7.0)+5.0+(-8.4)+2.6*p-q-(-2.5))
        z2 <== ((4.8*0.0+(-x)/(-x)+(-3.6))*((-y)*(-x)-((-7.7))/(6.0+y/(-x)*5.6+y))/x+((-y)-0.4+y)-(-y)+x-(-2.1)-(-7.0)+5.0+(-8.4)+2.6*x-y-(-2.5))
        print.cccc (I 2727) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2728
        !"test2728"
        z1 <== ((3.1-q/(-4.6)+(-q)-7.4-6.8-(3.1*8.4/(-2.8))*q)-((-q)/(q)))
        z2 <== ((3.1-y/(-4.6)+(-y)-7.4-6.8-(3.1*8.4/(-2.8))*y)-((-y)/(y)))
        print.cccc (I 2728) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2729
        !"test2729"
        z1 <== ((-1.6))+(-7.1)*(-2.5)-(-8.4)/((-q))/((-3.6))
        z2 <== ((-1.6))+(-7.1)*(-2.5)-(-8.4)/((-y))/((-3.6))
        print.cccc (I 2729) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2730
        !"test2730"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 2730) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2731
        !"test2731"
        z1 <== q
        z2 <== y
        print.cccc (I 2731) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2732
        !"test2732"
        z1 <== ((-5.5)+(5.8+(-3.2)/(-q)-p/3.3/6.0*((-p)+p+(-1.8)/1.1)/(-q))-q+p)
        z2 <== ((-5.5)+(5.8+(-3.2)/(-y)-x/3.3/6.0*((-x)+x+(-1.8)/1.1)/(-y))-y+x)
        print.cccc (I 2732) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2733
        !"test2733"
        z1 <== (-2.7)
        z2 <== (-2.7)
        print.cccc (I 2733) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2734
        !"test2734"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 2734) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2735
        !"test2735"
        z1 <== ((p*(-7.2)+((-0.5)*p+q+(-3.8)*q))-((p-(-p)*p)+(8.6*(-p)-q-2.1)-(-p)+(-4.8)*((-q)/(-p)))-(-4.8)+2.0-((6.8+p/q)-(q/1.4*q+8.6+1.8)*(6.3/(-6.3))+((-7.0)-p*(-5.3)*(-q))*(-p)))
        z2 <== ((x*(-7.2)+((-0.5)*x+y+(-3.8)*y))-((x-(-x)*x)+(8.6*(-x)-y-2.1)-(-x)+(-4.8)*((-y)/(-x)))-(-4.8)+2.0-((6.8+x/y)-(y/1.4*y+8.6+1.8)*(6.3/(-6.3))+((-7.0)-x*(-5.3)*(-y))*(-x)))
        print.cccc (I 2735) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2736
        !"test2736"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2736) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2737
        !"test2737"
        z1 <== (4.1)
        z2 <== (4.1)
        print.cccc (I 2737) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2738
        !"test2738"
        z1 <== (0.7/(-q)/((-q)+q+((-8.6)+(-p)*(-2.5)*(-q)-(-p))*6.8-(-7.7)))
        z2 <== (0.7/(-y)/((-y)+y+((-8.6)+(-x)*(-2.5)*(-y)-(-x))*6.8-(-7.7)))
        print.cccc (I 2738) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2739
        !"test2739"
        z1 <== 4.3
        z2 <== 4.3
        print.cccc (I 2739) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2740
        !"test2740"
        z1 <== ((q*(-p)-q+2.7*(p+(-q))))
        z2 <== ((y*(-x)-y+2.7*(x+(-y))))
        print.cccc (I 2740) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2741
        !"test2741"
        z1 <== ((-q)/((-3.0)*(-q)/p)+((-q)*((-7.5)-(-8.2)*(-p)+(-p)+(-q))/(-q)/((-7.0)/(-q)-(-0.4)))*(-8.6)-(-p))
        z2 <== ((-y)/((-3.0)*(-y)/x)+((-y)*((-7.5)-(-8.2)*(-x)+(-x)+(-y))/(-y)/((-7.0)/(-y)-(-0.4)))*(-8.6)-(-x))
        print.cccc (I 2741) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2742
        !"test2742"
        z1 <== (((-q))/(-p)-(-3.0)-5.8+7.0-7.0*q/5.6/6.1/p)
        z2 <== (((-y))/(-x)-(-3.0)-5.8+7.0-7.0*y/5.6/6.1/x)
        print.cccc (I 2742) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2743
        !"test2743"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 2743) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2744
        !"test2744"
        z1 <== (-q)-(-q)/q
        z2 <== (-y)-(-y)/y
        print.cccc (I 2744) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2745
        !"test2745"
        z1 <== (((-6.5)+((-q)*(-q))-p+((-p)-q+q)*(-p))+q*(-q))
        z2 <== (((-6.5)+((-y)*(-y))-x+((-x)-y+y)*(-x))+y*(-y))
        print.cccc (I 2745) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2746
        !"test2746"
        z1 <== ((((-4.0))+1.7/(-6.0)/(-p)))
        z2 <== ((((-4.0))+1.7/(-6.0)/(-x)))
        print.cccc (I 2746) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2747
        !"test2747"
        z1 <== ((((-8.5)*(-p)-6.8)/(-5.6))/(-q)-(4.8*p-(-5.0)-q/((-2.3)-5.8)-((-3.1)*2.6-(-0.2))-((-p)*4.1))*q)
        z2 <== ((((-8.5)*(-x)-6.8)/(-5.6))/(-y)-(4.8*x-(-5.0)-y/((-2.3)-5.8)-((-3.1)*2.6-(-0.2))-((-x)*4.1))*y)
        print.cccc (I 2747) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2748
        !"test2748"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 2748) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2749
        !"test2749"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2749) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2750
        !"test2750"
        z1 <== p*(-p)
        z2 <== x*(-x)
        print.cccc (I 2750) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2751
        !"test2751"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 2751) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2752
        !"test2752"
        z1 <== (((-7.1)+q*((-q)/p)+q)+(3.0-(-q)-(-7.0)/2.3*((-q)-8.4/q/1.7/0.7)+q)+(-p))
        z2 <== (((-7.1)+y*((-y)/x)+y)+(3.0-(-y)-(-7.0)/2.3*((-y)-8.4/y/1.7/0.7)+y)+(-x))
        print.cccc (I 2752) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2753
        !"test2753"
        z1 <== (-p)*((1.0)-4.1-((-p)+(-2.6)+(-1.2)+p))
        z2 <== (-x)*((1.0)-4.1-((-x)+(-2.6)+(-1.2)+x))
        print.cccc (I 2753) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2754
        !"test2754"
        z1 <== p
        z2 <== x
        print.cccc (I 2754) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2755
        !"test2755"
        z1 <== (((q/(-6.4))-q-((-4.0)))*2.7*p-(-q))
        z2 <== (((y/(-6.4))-y-((-4.0)))*2.7*x-(-y))
        print.cccc (I 2755) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2756
        !"test2756"
        z1 <== ((-3.8)*((6.5-6.8+p)*((-q)-4.1-q/(-p)*(-8.7))))
        z2 <== ((-3.8)*((6.5-6.8+x)*((-y)-4.1-y/(-x)*(-8.7))))
        print.cccc (I 2756) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2757
        !"test2757"
        z1 <== (((-q)+(-p)/8.8)*((-6.3)*((-7.8))/1.2*(-4.8)/q/3.7*5.6))
        z2 <== (((-y)+(-x)/8.8)*((-6.3)*((-7.8))/1.2*(-4.8)/y/3.7*5.6))
        print.cccc (I 2757) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2758
        !"test2758"
        z1 <== (p*(-p))
        z2 <== (x*(-x))
        print.cccc (I 2758) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2759
        !"test2759"
        z1 <== (p*(1.4/q*p)+(-2.5)+((-p)/q)/q*((-2.4)/2.0)-((-q))-0.3)
        z2 <== (x*(1.4/y*x)+(-2.5)+((-x)/y)/y*((-2.4)/2.0)-((-y))-0.3)
        print.cccc (I 2759) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2760
        !"test2760"
        z1 <== (((-q)+(-q)-(-p))*(-7.4)-(-0.4)*3.1-(-q)+((-q)/(-6.5)/p-q-(-q))+p-(-p)*(-4.6)+((-p)*(-0.0)*(4.0)/(-q)))
        z2 <== (((-y)+(-y)-(-x))*(-7.4)-(-0.4)*3.1-(-y)+((-y)/(-6.5)/x-y-(-y))+x-(-x)*(-4.6)+((-x)*(-0.0)*(4.0)/(-y)))
        print.cccc (I 2760) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2761
        !"test2761"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2761) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2762
        !"test2762"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2762) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2763
        !"test2763"
        z1 <== ((p/q)*(-p)*(2.5-q-(-3.0)*(-p)/(-6.2))*q)+((-p)+7.2*(5.8*q)-(p/q*q)/(-3.1))
        z2 <== ((x/y)*(-x)*(2.5-y-(-3.0)*(-x)/(-6.2))*y)+((-x)+7.2*(5.8*y)-(x/y*y)/(-3.1))
        print.cccc (I 2763) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2764
        !"test2764"
        z1 <== (2.7+q+q+((-q)/(-p)/q-(3.3-p/q))-((1.3*p/p+(-2.7))))
        z2 <== (2.7+y+y+((-y)/(-x)/y-(3.3-x/y))-((1.3*x/x+(-2.7))))
        print.cccc (I 2764) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2765
        !"test2765"
        z1 <== (((1.6/(-1.5)/q)-(-p)/(p/(-p)/(-1.1)+(-8.3))))
        z2 <== (((1.6/(-1.5)/y)-(-x)/(x/(-x)/(-1.1)+(-8.3))))
        print.cccc (I 2765) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2766
        !"test2766"
        z1 <== (((-q)+6.7-0.5-3.7*(-2.3))/p*(6.8+q))
        z2 <== (((-y)+6.7-0.5-3.7*(-2.3))/x*(6.8+y))
        print.cccc (I 2766) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2767
        !"test2767"
        z1 <== ((-q)*(p))
        z2 <== ((-y)*(x))
        print.cccc (I 2767) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2768
        !"test2768"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 2768) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2769
        !"test2769"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 2769) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2770
        !"test2770"
        z1 <== ((-7.7)+6.7+(-4.5)*(-p)+3.3*(6.5+(-p)-(-q)))
        z2 <== ((-7.7)+6.7+(-4.5)*(-x)+3.3*(6.5+(-x)-(-y)))
        print.cccc (I 2770) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2771
        !"test2771"
        z1 <== ((((-5.8)))+((-4.5)/0.2*((-6.3))*((-8.1)*(-q)))+((-7.7)-(-q)-(-2.8)-q/5.8)-4.4/((-5.5)+q/4.7)/(-q))
        z2 <== ((((-5.8)))+((-4.5)/0.2*((-6.3))*((-8.1)*(-y)))+((-7.7)-(-y)-(-2.8)-y/5.8)-4.4/((-5.5)+y/4.7)/(-y))
        print.cccc (I 2771) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2772
        !"test2772"
        z1 <== q
        z2 <== y
        print.cccc (I 2772) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2773
        !"test2773"
        z1 <== (p-(-q)+((-q))-p)
        z2 <== (x-(-y)+((-y))-x)
        print.cccc (I 2773) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2774
        !"test2774"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2774) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2775
        !"test2775"
        z1 <== p
        z2 <== x
        print.cccc (I 2775) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2776
        !"test2776"
        z1 <== (p*(4.7/(1.2*0.3*6.1)+(-q)+2.1)+4.8*(-3.7)-((-p)/(-2.8)*5.8/(-1.6)+3.8)*((-p)/q-2.2-(-3.3)+(-q))*q)
        z2 <== (x*(4.7/(1.2*0.3*6.1)+(-y)+2.1)+4.8*(-3.7)-((-x)/(-2.8)*5.8/(-1.6)+3.8)*((-x)/y-2.2-(-3.3)+(-y))*y)
        print.cccc (I 2776) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2777
        !"test2777"
        z1 <== (((-5.3)-p*((-1.8)/p*(-8.8))*q/(2.8+q/(-6.0)/5.5))*q+((-p)*(8.8/(-p)*1.7/(-1.2)-3.7)*(q-(-p)+7.5))*(((-q)+4.8/6.2)))
        z2 <== (((-5.3)-x*((-1.8)/x*(-8.8))*y/(2.8+y/(-6.0)/5.5))*y+((-x)*(8.8/(-x)*1.7/(-1.2)-3.7)*(y-(-x)+7.5))*(((-y)+4.8/6.2)))
        print.cccc (I 2777) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2778
        !"test2778"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 2778) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2779
        !"test2779"
        z1 <== (q-(-p)/(2.4*0.4+(-8.1))*q+(-q)+(-1.6)/6.8+2.3/(-q)/p*((-q)+(-3.3))-6.0)
        z2 <== (y-(-x)/(2.4*0.4+(-8.1))*y+(-y)+(-1.6)/6.8+2.3/(-y)/x*((-y)+(-3.3))-6.0)
        print.cccc (I 2779) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2780
        !"test2780"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 2780) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2781
        !"test2781"
        z1 <== (8.3-(-7.3)+(-q))
        z2 <== (8.3-(-7.3)+(-y))
        print.cccc (I 2781) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2782
        !"test2782"
        z1 <== (p+p*(-p)+(-p)-(-0.8))
        z2 <== (x+x*(-x)+(-x)-(-0.8))
        print.cccc (I 2782) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2783
        !"test2783"
        z1 <== (p+6.0*(-8.0))
        z2 <== (x+6.0*(-8.0))
        print.cccc (I 2783) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2784
        !"test2784"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2784) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2785
        !"test2785"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 2785) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2786
        !"test2786"
        z1 <== ((-q)+q/(p+5.5+(-q))-((-1.7)/0.7)-2.3*(p*(-1.7)-(-q)+(-4.6))+7.2-(-p))
        z2 <== ((-y)+y/(x+5.5+(-y))-((-1.7)/0.7)-2.3*(x*(-1.7)-(-y)+(-4.6))+7.2-(-x))
        print.cccc (I 2786) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2787
        !"test2787"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 2787) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2788
        !"test2788"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2788) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2789
        !"test2789"
        z1 <== (-3.5)*0.3-(-3.7)
        z2 <== (-3.5)*0.3-(-3.7)
        print.cccc (I 2789) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2790
        !"test2790"
        z1 <== (-7.8)
        z2 <== (-7.8)
        print.cccc (I 2790) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2791
        !"test2791"
        z1 <== p
        z2 <== x
        print.cccc (I 2791) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2792
        !"test2792"
        z1 <== q
        z2 <== y
        print.cccc (I 2792) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2793
        !"test2793"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 2793) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2794
        !"test2794"
        z1 <== ((-q)/(q-(-q)+2.1)*(((-3.6)-7.8*q-(-2.4))*p-(-4.0)+p*(-6.6)-(-p)))
        z2 <== ((-y)/(y-(-y)+2.1)*(((-3.6)-7.8*y-(-2.4))*x-(-4.0)+x*(-6.6)-(-x)))
        print.cccc (I 2794) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2795
        !"test2795"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 2795) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2796
        !"test2796"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 2796) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2797
        !"test2797"
        z1 <== (2.0+(-p)/(((-1.0)*q)/(8.0-0.3)*5.7)/(q+((-p)*(-6.6)-(-p)*2.6)*((-8.3))*(-p)))
        z2 <== (2.0+(-x)/(((-1.0)*y)/(8.0-0.3)*5.7)/(y+((-x)*(-6.6)-(-x)*2.6)*((-8.3))*(-x)))
        print.cccc (I 2797) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2798
        !"test2798"
        z1 <== (((-3.7)-(-3.6)/(-7.2))/(-p))
        z2 <== (((-3.7)-(-3.6)/(-7.2))/(-x))
        print.cccc (I 2798) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2799
        !"test2799"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2799) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2800
        !"test2800"
        z1 <== ((((-1.5)-(-1.5)/3.4)/q+4.7*(-5.0)-p-((-p)-(-q)+p)-(q/6.0-(-p)*(-7.4)+2.5))-3.4-((1.2))/(-q)+((-p)))
        z2 <== ((((-1.5)-(-1.5)/3.4)/y+4.7*(-5.0)-x-((-x)-(-y)+x)-(y/6.0-(-x)*(-7.4)+2.5))-3.4-((1.2))/(-y)+((-x)))
        print.cccc (I 2800) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2801
        !"test2801"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2801) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2802
        !"test2802"
        z1 <== ((((-1.2)/p-1.3-(-p)/q)*p-1.0/2.1+p-2.4*p))
        z2 <== ((((-1.2)/x-1.3-(-x)/y)*x-1.0/2.1+x-2.4*x))
        print.cccc (I 2802) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2803
        !"test2803"
        z1 <== (-2.1)
        z2 <== (-2.1)
        print.cccc (I 2803) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2804
        !"test2804"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 2804) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2805
        !"test2805"
        z1 <== (-6.5)
        z2 <== (-6.5)
        print.cccc (I 2805) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2806
        !"test2806"
        z1 <== p
        z2 <== x
        print.cccc (I 2806) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2807
        !"test2807"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 2807) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2808
        !"test2808"
        z1 <== (-q)/q/(-q)
        z2 <== (-y)/y/(-y)
        print.cccc (I 2808) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2809
        !"test2809"
        z1 <== ((-q)*q+4.7/(-p))
        z2 <== ((-y)*y+4.7/(-x))
        print.cccc (I 2809) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2810
        !"test2810"
        z1 <== ((-q)*(-p))
        z2 <== ((-y)*(-x))
        print.cccc (I 2810) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2811
        !"test2811"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 2811) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2812
        !"test2812"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 2812) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2813
        !"test2813"
        z1 <== q
        z2 <== y
        print.cccc (I 2813) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2814
        !"test2814"
        z1 <== (p+((-1.0))+p/q)
        z2 <== (x+((-1.0))+x/y)
        print.cccc (I 2814) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2815
        !"test2815"
        z1 <== q
        z2 <== y
        print.cccc (I 2815) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2816
        !"test2816"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 2816) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2817
        !"test2817"
        z1 <== (((-p)+(-q))*p+((q)*(p+(-6.2)/(-7.4))+(p)-p))
        z2 <== (((-x)+(-y))*x+((y)*(x+(-6.2)/(-7.4))+(x)-x))
        print.cccc (I 2817) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2818
        !"test2818"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 2818) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2819
        !"test2819"
        z1 <== (((-5.5)*(p*p/3.6+(-q)))+2.8-(q-(-1.4)+(-8.8)-((-p)+(-2.6)))+(-1.7))
        z2 <== (((-5.5)*(x*x/3.6+(-y)))+2.8-(y-(-1.4)+(-8.8)-((-x)+(-2.6)))+(-1.7))
        print.cccc (I 2819) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2820
        !"test2820"
        z1 <== ((((-p)+(-p))/(q)-q-0.2)/1.0*((-q)*(q-(-p))/((-p)/(-4.6)-(-7.4)*p/0.0)/q)+(q/3.8-(-8.3)+q*p-(-8.0)+(-p)+q))
        z2 <== ((((-x)+(-x))/(y)-y-0.2)/1.0*((-y)*(y-(-x))/((-x)/(-4.6)-(-7.4)*x/0.0)/y)+(y/3.8-(-8.3)+y*x-(-8.0)+(-x)+y))
        print.cccc (I 2820) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2821
        !"test2821"
        z1 <== (p-(-5.3)/(p+(-p))+q/q)
        z2 <== (x-(-5.3)/(x+(-x))+y/y)
        print.cccc (I 2821) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2822
        !"test2822"
        z1 <== ((-q)*(-p)+(-1.6)-(1.6-p/q)/((-0.0)/(-0.7)*(-q)-p))
        z2 <== ((-y)*(-x)+(-1.6)-(1.6-x/y)/((-0.0)/(-0.7)*(-y)-x))
        print.cccc (I 2822) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2823
        !"test2823"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 2823) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2824
        !"test2824"
        z1 <== q
        z2 <== y
        print.cccc (I 2824) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2825
        !"test2825"
        z1 <== (((q*4.2-1.6+(-p)-(-q))+((-7.7)))*((q+2.4-q)-(-5.7)))
        z2 <== (((y*4.2-1.6+(-x)-(-y))+((-7.7)))*((y+2.4-y)-(-5.7)))
        print.cccc (I 2825) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2826
        !"test2826"
        z1 <== (-4.5)/(p)-((-4.6)+q-3.8/(-q))*((-4.6)+p*(-3.5))/(-8.8)*(p+(-q)+3.7/q)-(1.7/(q*(-6.6)-(-p)+(-2.8)/2.4))+2.2
        z2 <== (-4.5)/(x)-((-4.6)+y-3.8/(-y))*((-4.6)+x*(-3.5))/(-8.8)*(x+(-y)+3.7/y)-(1.7/(y*(-6.6)-(-x)+(-2.8)/2.4))+2.2
        print.cccc (I 2826) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2827
        !"test2827"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2827) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2828
        !"test2828"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2828) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2829
        !"test2829"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2829) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2830
        !"test2830"
        z1 <== (((8.8+3.2-1.3+(-4.6))/4.3)+q*(3.6+(-3.0)*(-p))-(-6.5))
        z2 <== (((8.8+3.2-1.3+(-4.6))/4.3)+y*(3.6+(-3.0)*(-x))-(-6.5))
        print.cccc (I 2830) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2831
        !"test2831"
        z1 <== (-p)*((-4.7)/(-q)-p/2.2+p*(-q)*q)/(q)
        z2 <== (-x)*((-4.7)/(-y)-x/2.2+x*(-y)*y)/(y)
        print.cccc (I 2831) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2832
        !"test2832"
        z1 <== 7.7
        z2 <== 7.7
        print.cccc (I 2832) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2833
        !"test2833"
        z1 <== (1.4)
        z2 <== (1.4)
        print.cccc (I 2833) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2834
        !"test2834"
        z1 <== ((1.8-((-q)+(-q)+(-0.6))+((-2.3)+p/(-p))/((-5.6))-(-4.5))+(((-p)-3.6+(-7.4)*p))-q+7.7)
        z2 <== ((1.8-((-y)+(-y)+(-0.6))+((-2.3)+x/(-x))/((-5.6))-(-4.5))+(((-x)-3.6+(-7.4)*x))-y+7.7)
        print.cccc (I 2834) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2835
        !"test2835"
        z1 <== p/(5.1/p-(-8.6)+(q-4.0/q))/7.6
        z2 <== x/(5.1/x-(-8.6)+(y-4.0/y))/7.6
        print.cccc (I 2835) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2836
        !"test2836"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2836) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2837
        !"test2837"
        z1 <== p
        z2 <== x
        print.cccc (I 2837) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2838
        !"test2838"
        z1 <== ((3.3/((-p)/q)-((-q))/(-7.8)*q)/((-q)/4.4+(-p)+(-0.3))-0.1/(-4.2)+q*(2.1+(-q)-(-q)+p)-(-1.7)+q-(-2.8)*(-0.3)+4.8-(-0.6)-((1.0*q*p*(-p)+(-q))))
        z2 <== ((3.3/((-x)/y)-((-y))/(-7.8)*y)/((-y)/4.4+(-x)+(-0.3))-0.1/(-4.2)+y*(2.1+(-y)-(-y)+x)-(-1.7)+y-(-2.8)*(-0.3)+4.8-(-0.6)-((1.0*y*x*(-x)+(-y))))
        print.cccc (I 2838) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2839
        !"test2839"
        z1 <== (p*(-6.3))
        z2 <== (x*(-6.3))
        print.cccc (I 2839) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2840
        !"test2840"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2840) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2841
        !"test2841"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 2841) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2842
        !"test2842"
        z1 <== ((-2.5)+(-8.1)+2.0+(-3.3)*q/2.2/7.7-1.1/q)
        z2 <== ((-2.5)+(-8.1)+2.0+(-3.3)*y/2.2/7.7-1.1/y)
        print.cccc (I 2842) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2843
        !"test2843"
        z1 <== 6.3*(((-5.5))*(-q)+5.5)/p*(-p)
        z2 <== 6.3*(((-5.5))*(-y)+5.5)/x*(-x)
        print.cccc (I 2843) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2844
        !"test2844"
        z1 <== ((-q)-(p)+4.2/((-5.6)+q)-(-q))
        z2 <== ((-y)-(x)+4.2/((-5.6)+y)-(-y))
        print.cccc (I 2844) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2845
        !"test2845"
        z1 <== (1.3*1.8+(-3.5)-(-q)+(((-0.8)-(-2.5)/5.3)*((-7.8)*(-q)/q-p)))
        z2 <== (1.3*1.8+(-3.5)-(-y)+(((-0.8)-(-2.5)/5.3)*((-7.8)*(-y)/y-x)))
        print.cccc (I 2845) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2846
        !"test2846"
        z1 <== (-5.7)-((p-q+(-p)-0.4+p)-((-q)/1.2)/((-5.6)+3.5*7.7)*((-1.2)-(-p)))-(-p)
        z2 <== (-5.7)-((x-y+(-x)-0.4+x)-((-y)/1.2)/((-5.6)+3.5*7.7)*((-1.2)-(-x)))-(-x)
        print.cccc (I 2846) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2847
        !"test2847"
        z1 <== ((-7.7)+(-p))-q*(-8.2)+(-q)
        z2 <== ((-7.7)+(-x))-y*(-8.2)+(-y)
        print.cccc (I 2847) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2848
        !"test2848"
        z1 <== p
        z2 <== x
        print.cccc (I 2848) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2849
        !"test2849"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 2849) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2850
        !"test2850"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 2850) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2851
        !"test2851"
        z1 <== ((-q)/(2.4-(-q))*(0.4)*p*0.7-(6.7))
        z2 <== ((-y)/(2.4-(-y))*(0.4)*x*0.7-(6.7))
        print.cccc (I 2851) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2852
        !"test2852"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2852) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2853
        !"test2853"
        z1 <== ((-6.7)-5.5-8.3-8.4+(((-8.8)-0.6+(-q)*q*(-8.0))*((-q)-(-p))*q))
        z2 <== ((-6.7)-5.5-8.3-8.4+(((-8.8)-0.6+(-y)*y*(-8.0))*((-y)-(-x))*y))
        print.cccc (I 2853) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2854
        !"test2854"
        z1 <== 1.4
        z2 <== 1.4
        print.cccc (I 2854) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2855
        !"test2855"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 2855) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2856
        !"test2856"
        z1 <== q
        z2 <== y
        print.cccc (I 2856) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2857
        !"test2857"
        z1 <== q
        z2 <== y
        print.cccc (I 2857) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2858
        !"test2858"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2858) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2859
        !"test2859"
        z1 <== ((p/q-8.5-(-8.2)-p+q*(-q)-p+((-p)+(-3.0)+7.3-8.5))/(((-3.1))-(-6.3)/(-p)/q)*((-0.6)/2.3/p))
        z2 <== ((x/y-8.5-(-8.2)-x+y*(-y)-x+((-x)+(-3.0)+7.3-8.5))/(((-3.1))-(-6.3)/(-x)/y)*((-0.6)/2.3/x))
        print.cccc (I 2859) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2860
        !"test2860"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 2860) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2861
        !"test2861"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 2861) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2862
        !"test2862"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 2862) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2863
        !"test2863"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 2863) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2864
        !"test2864"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2864) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2865
        !"test2865"
        z1 <== ((-4.3)/(-q)+8.6*p)
        z2 <== ((-4.3)/(-y)+8.6*x)
        print.cccc (I 2865) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2866
        !"test2866"
        z1 <== q
        z2 <== y
        print.cccc (I 2866) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2867
        !"test2867"
        z1 <== (-p)/(((-p)+8.1)-((-q)*(-p)))
        z2 <== (-x)/(((-x)+8.1)-((-y)*(-x)))
        print.cccc (I 2867) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2868
        !"test2868"
        z1 <== ((-p)+((-2.8))+(p/(p/q-p)*((-5.4)))+(-q))
        z2 <== ((-x)+((-2.8))+(x/(x/y-x)*((-5.4)))+(-y))
        print.cccc (I 2868) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2869
        !"test2869"
        z1 <== (((-q)-((-6.5)/(-1.4)+(-q)-(-0.7)+(-p))-1.7*(-0.6)+(-0.0)*(-p)-q)*(q/(-q)/(-p)/4.7+8.2/(-p)-(-8.8)/1.3/((-3.4)/(-q))/(-3.7)+(3.6*(-5.4)*(-p)/(-5.0)+p))+((-8.8)*(-2.5)-(-1.2)-(-p)-(-5.5)*((-q)/0.0/3.8-q)))
        z2 <== (((-y)-((-6.5)/(-1.4)+(-y)-(-0.7)+(-x))-1.7*(-0.6)+(-0.0)*(-x)-y)*(y/(-y)/(-x)/4.7+8.2/(-x)-(-8.8)/1.3/((-3.4)/(-y))/(-3.7)+(3.6*(-5.4)*(-x)/(-5.0)+x))+((-8.8)*(-2.5)-(-1.2)-(-x)-(-5.5)*((-y)/0.0/3.8-y)))
        print.cccc (I 2869) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2870
        !"test2870"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2870) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2871
        !"test2871"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 2871) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2872
        !"test2872"
        z1 <== ((5.3-2.1)*q)
        z2 <== ((5.3-2.1)*y)
        print.cccc (I 2872) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2873
        !"test2873"
        z1 <== (((-1.4)/(-p)/(-q)+8.0+(-6.4)-(q*4.2)))
        z2 <== (((-1.4)/(-x)/(-y)+8.0+(-6.4)-(y*4.2)))
        print.cccc (I 2873) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2874
        !"test2874"
        z1 <== (((-0.5)-q+3.6-q*q*((-8.1)+(-p)-7.7))/(-q)-((q-p-(-p)+(-7.8)-(-2.2))+(q-p*p*p+(-4.7))/(p-0.4*0.1/p)/(-q)-(-7.3)))
        z2 <== (((-0.5)-y+3.6-y*y*((-8.1)+(-x)-7.7))/(-y)-((y-x-(-x)+(-7.8)-(-2.2))+(y-x*x*x+(-4.7))/(x-0.4*0.1/x)/(-y)-(-7.3)))
        print.cccc (I 2874) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2875
        !"test2875"
        z1 <== q
        z2 <== y
        print.cccc (I 2875) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2876
        !"test2876"
        z1 <== (-4.0)
        z2 <== (-4.0)
        print.cccc (I 2876) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2877
        !"test2877"
        z1 <== (((-p)-(-2.1)*(-4.2)*(-p)+p)*0.3-p)+(-7.6)-((-q)*((-p)*(-5.6)*(-p)))+(4.3/(-p)-(-p))
        z2 <== (((-x)-(-2.1)*(-4.2)*(-x)+x)*0.3-x)+(-7.6)-((-y)*((-x)*(-5.6)*(-x)))+(4.3/(-x)-(-x))
        print.cccc (I 2877) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2878
        !"test2878"
        z1 <== (((5.3*q*q*1.4)+0.5))
        z2 <== (((5.3*y*y*1.4)+0.5))
        print.cccc (I 2878) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2879
        !"test2879"
        z1 <== (-0.1)
        z2 <== (-0.1)
        print.cccc (I 2879) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2880
        !"test2880"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2880) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2881
        !"test2881"
        z1 <== (((q*(-p)+(-6.4))-(-5.4)*(-q)-0.4+p/q+(-q)+((-6.0))*7.8))
        z2 <== (((y*(-x)+(-6.4))-(-5.4)*(-y)-0.4+x/y+(-y)+((-6.0))*7.8))
        print.cccc (I 2881) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2882
        !"test2882"
        z1 <== (q*((-q)*p-(-q))*4.7-((3.0)+((-q)*(-0.7)-(-2.2)-7.5))*(-p))
        z2 <== (y*((-y)*x-(-y))*4.7-((3.0)+((-y)*(-0.7)-(-2.2)-7.5))*(-x))
        print.cccc (I 2882) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2883
        !"test2883"
        z1 <== ((3.0/(-p)*(p-(-1.0)+(-2.0)/(-1.2))*((-5.4)+7.1-p/8.8+8.0))-0.1-(q*(-8.2)*((-q)+(-p)*(-p)-(-2.7))-6.8/((-q)/(-4.4)/(-3.3)+2.7)))
        z2 <== ((3.0/(-x)*(x-(-1.0)+(-2.0)/(-1.2))*((-5.4)+7.1-x/8.8+8.0))-0.1-(y*(-8.2)*((-y)+(-x)*(-x)-(-2.7))-6.8/((-y)/(-4.4)/(-3.3)+2.7)))
        print.cccc (I 2883) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2884
        !"test2884"
        z1 <== ((((-q)+(-8.4)/(-7.7)*p+(-p)))+p)
        z2 <== ((((-y)+(-8.4)/(-7.7)*x+(-x)))+x)
        print.cccc (I 2884) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2885
        !"test2885"
        z1 <== (((-q)-1.7-(-q)*(3.2)*(q+p/(-2.3)+(-4.1)/p)-(-8.6))-(5.0/(-6.8)+p+(-2.2))/(-8.0))
        z2 <== (((-y)-1.7-(-y)*(3.2)*(y+x/(-2.3)+(-4.1)/x)-(-8.6))-(5.0/(-6.8)+x+(-2.2))/(-8.0))
        print.cccc (I 2885) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2886
        !"test2886"
        z1 <== ((((-7.6))/(q-0.5)+0.2+((-p)/(-8.5)*(-p)+(-q)))-(7.0+(-p)+3.4+q/6.3+q-((-p)+p+(-q)*6.2)+((-q)/(-q)/(-p)))/q)
        z2 <== ((((-7.6))/(y-0.5)+0.2+((-x)/(-8.5)*(-x)+(-y)))-(7.0+(-x)+3.4+y/6.3+y-((-x)+x+(-y)*6.2)+((-y)/(-y)/(-x)))/y)
        print.cccc (I 2886) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2887
        !"test2887"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 2887) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2888
        !"test2888"
        z1 <== (0.0+(-q)/(5.2*p)+(p/(-q))+(-4.5))-3.0*((-2.0)*(-q)+0.2+(-p))/((-p)-(-4.0)/(-p))-(-p)*(-8.0)
        z2 <== (0.0+(-y)/(5.2*x)+(x/(-y))+(-4.5))-3.0*((-2.0)*(-y)+0.2+(-x))/((-x)-(-4.0)/(-x))-(-x)*(-8.0)
        print.cccc (I 2888) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2889
        !"test2889"
        z1 <== (((-8.8)-p+(-q)-(-q)/(-8.2)*(-p))*(7.6)-2.6*(-4.5)-((p*p-0.7-(-4.3))*5.3/(q)/((-1.4)-3.1)-(-6.2)))
        z2 <== (((-8.8)-x+(-y)-(-y)/(-8.2)*(-x))*(7.6)-2.6*(-4.5)-((x*x-0.7-(-4.3))*5.3/(y)/((-1.4)-3.1)-(-6.2)))
        print.cccc (I 2889) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2890
        !"test2890"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 2890) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2891
        !"test2891"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 2891) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2892
        !"test2892"
        z1 <== (8.8-(p)+q)
        z2 <== (8.8-(x)+y)
        print.cccc (I 2892) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2893
        !"test2893"
        z1 <== (((-8.7)-(-p)/(-8.2)-(-q))/(4.7+(-3.8))-(-7.6))
        z2 <== (((-8.7)-(-x)/(-8.2)-(-y))/(4.7+(-3.8))-(-7.6))
        print.cccc (I 2893) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2894
        !"test2894"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2894) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2895
        !"test2895"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2895) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2896
        !"test2896"
        z1 <== ((q)+p)
        z2 <== ((y)+x)
        print.cccc (I 2896) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2897
        !"test2897"
        z1 <== ((p+(-3.5)-(-3.7)+q*8.6*(-p)-3.8)+((q*5.6)*((-5.0)-p+2.6+0.4/4.4)*((-6.3)*p*6.4/7.3)-(p+(-2.0)/(-q)/(-q)-(-q))*(-7.8))/(-2.5))
        z2 <== ((x+(-3.5)-(-3.7)+y*8.6*(-x)-3.8)+((y*5.6)*((-5.0)-x+2.6+0.4/4.4)*((-6.3)*x*6.4/7.3)-(x+(-2.0)/(-y)/(-y)-(-y))*(-7.8))/(-2.5))
        print.cccc (I 2897) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2898
        !"test2898"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 2898) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2899
        !"test2899"
        z1 <== ((-q)*(-6.3)*(((-p))*p-((-3.8)-2.0-(-q))*2.5))
        z2 <== ((-y)*(-6.3)*(((-x))*x-((-3.8)-2.0-(-y))*2.5))
        print.cccc (I 2899) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2900
        !"test2900"
        z1 <== q
        z2 <== y
        print.cccc (I 2900) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2901
        !"test2901"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 2901) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2902
        !"test2902"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 2902) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2903
        !"test2903"
        z1 <== (((3.0+(-0.8)+(-p)+(-p))*((-p)))/(-p)/0.0/(-5.3)+(-q)+(-p)-4.7-(4.2)/(-2.8)-(-p))
        z2 <== (((3.0+(-0.8)+(-x)+(-x))*((-x)))/(-x)/0.0/(-5.3)+(-y)+(-x)-4.7-(4.2)/(-2.8)-(-x))
        print.cccc (I 2903) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2904
        !"test2904"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 2904) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2905
        !"test2905"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2905) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2906
        !"test2906"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 2906) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2907
        !"test2907"
        z1 <== 4.7/q+(-q)/(-0.0)+(-p)*q*((q+0.5)/(-q)*((-q)-5.1)+(-p))/(-p)
        z2 <== 4.7/y+(-y)/(-0.0)+(-x)*y*((y+0.5)/(-y)*((-y)-5.1)+(-x))/(-x)
        print.cccc (I 2907) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2908
        !"test2908"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2908) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2909
        !"test2909"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 2909) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2910
        !"test2910"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 2910) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2911
        !"test2911"
        z1 <== ((-q)+((q/(-2.5)+(-1.5))-(2.7*(-5.2))-(-5.4)/((-p))-(-p)*(-p))*((q/(-q)-(-5.5))*7.0*((-3.4)*(-0.6)+(-6.8)*1.0))+p-0.3)
        z2 <== ((-y)+((y/(-2.5)+(-1.5))-(2.7*(-5.2))-(-5.4)/((-x))-(-x)*(-x))*((y/(-y)-(-5.5))*7.0*((-3.4)*(-0.6)+(-6.8)*1.0))+x-0.3)
        print.cccc (I 2911) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2912
        !"test2912"
        z1 <== (4.5)/((-6.3)+(2.0/p+(-2.5)*(-q))/((-q)*(-q)/(-q)))*((-q)/(-p)-(-p)*q)*((-q))+((-p))*((-3.6)/q)/(-q)-(-1.8)
        z2 <== (4.5)/((-6.3)+(2.0/x+(-2.5)*(-y))/((-y)*(-y)/(-y)))*((-y)/(-x)-(-x)*y)*((-y))+((-x))*((-3.6)/y)/(-y)-(-1.8)
        print.cccc (I 2912) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2913
        !"test2913"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 2913) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2914
        !"test2914"
        z1 <== q
        z2 <== y
        print.cccc (I 2914) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2915
        !"test2915"
        z1 <== (((p-(-q))/((-q))+(1.4+(-4.4)+p-(-6.7))+p))
        z2 <== (((x-(-y))/((-y))+(1.4+(-4.4)+x-(-6.7))+x))
        print.cccc (I 2915) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2916
        !"test2916"
        z1 <== (1.2-(-p)/(-6.1)*(-5.4))
        z2 <== (1.2-(-x)/(-6.1)*(-5.4))
        print.cccc (I 2916) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2917
        !"test2917"
        z1 <== (p+(-4.4)/(-p)-(q+p)+((-q)+p))
        z2 <== (x+(-4.4)/(-x)-(y+x)+((-y)+x))
        print.cccc (I 2917) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2918
        !"test2918"
        z1 <== ((-2.6)+1.2/q-(7.5-q+(-4.7)+0.1)+(q)*(3.7-(-p)+(-5.4))/(q+q)/1.0-(-7.7)-(p-0.1/(-q)+(-p)/1.8))
        z2 <== ((-2.6)+1.2/y-(7.5-y+(-4.7)+0.1)+(y)*(3.7-(-x)+(-5.4))/(y+y)/1.0-(-7.7)-(x-0.1/(-y)+(-x)/1.8))
        print.cccc (I 2918) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2919
        !"test2919"
        z1 <== ((-p)-(p*q)-1.2)
        z2 <== ((-x)-(x*y)-1.2)
        print.cccc (I 2919) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2920
        !"test2920"
        z1 <== (0.8+(-p)*((-3.4)+q)-(-q))
        z2 <== (0.8+(-x)*((-3.4)+y)-(-y))
        print.cccc (I 2920) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2921
        !"test2921"
        z1 <== (-6.5)
        z2 <== (-6.5)
        print.cccc (I 2921) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2922
        !"test2922"
        z1 <== (0.7*3.4)
        z2 <== (0.7*3.4)
        print.cccc (I 2922) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2923
        !"test2923"
        z1 <== (((-q)+q)+((p-1.1-(-p)/p)*((-q)*q+(-p)*p+8.4)-p)-(-q)*(-q))
        z2 <== (((-y)+y)+((x-1.1-(-x)/x)*((-y)*y+(-x)*x+8.4)-x)-(-y)*(-y))
        print.cccc (I 2923) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2924
        !"test2924"
        z1 <== ((-p)-3.2-q*(-p)*((-1.8)-(-q)/q-(-p)*7.3))*p*1.3/((-q)+(-q))*((q-3.0/q)+(-q)*(-1.8))
        z2 <== ((-x)-3.2-y*(-x)*((-1.8)-(-y)/y-(-x)*7.3))*x*1.3/((-y)+(-y))*((y-3.0/y)+(-y)*(-1.8))
        print.cccc (I 2924) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2925
        !"test2925"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 2925) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2926
        !"test2926"
        z1 <== (5.7/5.7*(7.1*(-3.5)-(-p)*(-q)+q/(-2.2)+q-(-p)))
        z2 <== (5.7/5.7*(7.1*(-3.5)-(-x)*(-y)+y/(-2.2)+y-(-x)))
        print.cccc (I 2926) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2927
        !"test2927"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2927) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2928
        !"test2928"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 2928) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2929
        !"test2929"
        z1 <== q-((-7.3)+(p)-q+p+p-(-0.3)*4.6/(-p))*(-4.2)
        z2 <== y-((-7.3)+(x)-y+x+x-(-0.3)*4.6/(-x))*(-4.2)
        print.cccc (I 2929) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2930
        !"test2930"
        z1 <== (1.2*(-1.6)-p/p*(-6.5)*(-6.8)-0.6*q+(-3.5)*q+6.2)
        z2 <== (1.2*(-1.6)-x/x*(-6.5)*(-6.8)-0.6*y+(-3.5)*y+6.2)
        print.cccc (I 2930) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2931
        !"test2931"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2931) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2932
        !"test2932"
        z1 <== (q-((0.2+p+(-0.8)+(-3.8)/(-p))-(-6.2)*(-4.1)-3.2*(-8.3)*p)*((-p))*(-6.6)-5.0*(q))
        z2 <== (y-((0.2+x+(-0.8)+(-3.8)/(-x))-(-6.2)*(-4.1)-3.2*(-8.3)*x)*((-x))*(-6.6)-5.0*(y))
        print.cccc (I 2932) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2933
        !"test2933"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 2933) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2934
        !"test2934"
        z1 <== (-3.7)
        z2 <== (-3.7)
        print.cccc (I 2934) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2935
        !"test2935"
        z1 <== (((5.2/(-8.4)*p)*(p/q))-(-6.0))
        z2 <== (((5.2/(-8.4)*x)*(x/y))-(-6.0))
        print.cccc (I 2935) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2936
        !"test2936"
        z1 <== 6.1
        z2 <== 6.1
        print.cccc (I 2936) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2937
        !"test2937"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2937) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2938
        !"test2938"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2938) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2939
        !"test2939"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 2939) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2940
        !"test2940"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 2940) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2941
        !"test2941"
        z1 <== (((-q)/(p-(-q))/3.2+2.3/(1.6-(-6.0)-0.5))/(2.8))
        z2 <== (((-y)/(x-(-y))/3.2+2.3/(1.6-(-6.0)-0.5))/(2.8))
        print.cccc (I 2941) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2942
        !"test2942"
        z1 <== ((-1.5)/(((-0.1)+(-p)-(-8.2)*p+(-q))/(-6.0)-q+(-q)))
        z2 <== ((-1.5)/(((-0.1)+(-x)-(-8.2)*x+(-y))/(-6.0)-y+(-y)))
        print.cccc (I 2942) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2943
        !"test2943"
        z1 <== 3.8
        z2 <== 3.8
        print.cccc (I 2943) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2944
        !"test2944"
        z1 <== ((2.4)+(-6.7)/(0.2)/3.4-(-q))
        z2 <== ((2.4)+(-6.7)/(0.2)/3.4-(-y))
        print.cccc (I 2944) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2945
        !"test2945"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 2945) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2946
        !"test2946"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2946) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2947
        !"test2947"
        z1 <== (q+7.5+((-p)*(-7.2)*(-q)-8.2)*(-7.3))*(-q)/(8.1*((-1.6))/(-4.7)/((-7.4)))/p-q
        z2 <== (y+7.5+((-x)*(-7.2)*(-y)-8.2)*(-7.3))*(-y)/(8.1*((-1.6))/(-4.7)/((-7.4)))/x-y
        print.cccc (I 2947) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2948
        !"test2948"
        z1 <== (((-4.6)-7.5*(-p)+q+((-1.5)+p)/((-2.2)))*((-q)))
        z2 <== (((-4.6)-7.5*(-x)+y+((-1.5)+x)/((-2.2)))*((-y)))
        print.cccc (I 2948) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2949
        !"test2949"
        z1 <== p-(-4.4)
        z2 <== x-(-4.4)
        print.cccc (I 2949) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2950
        !"test2950"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2950) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2951
        !"test2951"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2951) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2952
        !"test2952"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 2952) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2953
        !"test2953"
        z1 <== (6.5)/5.6
        z2 <== (6.5)/5.6
        print.cccc (I 2953) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2954
        !"test2954"
        z1 <== (0.5+(((-7.4)+6.7+8.0-(-q)+(-q))+(-4.5)-p)/5.6)
        z2 <== (0.5+(((-7.4)+6.7+8.0-(-y)+(-y))+(-4.5)-x)/5.6)
        print.cccc (I 2954) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2955
        !"test2955"
        z1 <== (((-6.6)+1.3+(-8.8)*8.4)*(q*((-4.1)/(-3.3))/(-p)/(-p))-(7.8-p))
        z2 <== (((-6.6)+1.3+(-8.8)*8.4)*(y*((-4.1)/(-3.3))/(-x)/(-x))-(7.8-x))
        print.cccc (I 2955) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2956
        !"test2956"
        z1 <== 2.8-(p)
        z2 <== 2.8-(x)
        print.cccc (I 2956) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2957
        !"test2957"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 2957) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2958
        !"test2958"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 2958) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2959
        !"test2959"
        z1 <== (7.2+3.0+(-q))
        z2 <== (7.2+3.0+(-y))
        print.cccc (I 2959) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2960
        !"test2960"
        z1 <== q
        z2 <== y
        print.cccc (I 2960) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2961
        !"test2961"
        z1 <== (-2.6)-((-8.4)+(-p)/p*1.1)/(8.0/7.5*(-2.6)+q)+(-4.0)/p/0.2*(q-8.1/p+(-5.6)/p)
        z2 <== (-2.6)-((-8.4)+(-x)/x*1.1)/(8.0/7.5*(-2.6)+y)+(-4.0)/x/0.2*(y-8.1/x+(-5.6)/x)
        print.cccc (I 2961) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2962
        !"test2962"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2962) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2963
        !"test2963"
        z1 <== (0.8-(0.7-(-8.6))*((6.5/q)*((-p)-(-p)))+3.0)
        z2 <== (0.8-(0.7-(-8.6))*((6.5/y)*((-x)-(-x)))+3.0)
        print.cccc (I 2963) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2964
        !"test2964"
        z1 <== ((-q)/q+(-0.0)*((-p)/(6.0/p-p)*(-8.2)+(-3.3)))
        z2 <== ((-y)/y+(-0.0)*((-x)/(6.0/x-x)*(-8.2)+(-3.3)))
        print.cccc (I 2964) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2965
        !"test2965"
        z1 <== ((6.2)+2.7)
        z2 <== ((6.2)+2.7)
        print.cccc (I 2965) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2966
        !"test2966"
        z1 <== ((p)/q*(-p)*((-8.8)+6.2-(-6.8)*8.0*q))/((-4.3)/0.7+((-1.8)+p)-6.8)/(-p)
        z2 <== ((x)/y*(-x)*((-8.8)+6.2-(-6.8)*8.0*y))/((-4.3)/0.7+((-1.8)+x)-6.8)/(-x)
        print.cccc (I 2966) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2967
        !"test2967"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2967) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2968
        !"test2968"
        z1 <== ((p+(-8.2)*p)-((-2.6)/(3.3-(-1.3)+(-1.3)-p)-6.0+4.4-(-q))/p+(-5.8))
        z2 <== ((x+(-8.2)*x)-((-2.6)/(3.3-(-1.3)+(-1.3)-x)-6.0+4.4-(-y))/x+(-5.8))
        print.cccc (I 2968) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2969
        !"test2969"
        z1 <== 8.1
        z2 <== 8.1
        print.cccc (I 2969) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2970
        !"test2970"
        z1 <== (((4.8*q-0.2+p-8.7)+((-4.5)))+0.4*(0.8+(-q)-5.1/5.8+p)-(-5.7))
        z2 <== (((4.8*y-0.2+x-8.7)+((-4.5)))+0.4*(0.8+(-y)-5.1/5.8+x)-(-5.7))
        print.cccc (I 2970) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2971
        !"test2971"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 2971) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2972
        !"test2972"
        z1 <== (((-2.4)*(-q)*q/4.3-((-1.0)*(-2.7)+(-q))-(p/p))+(-p)*(-0.3)/(-q)-(-p))
        z2 <== (((-2.4)*(-y)*y/4.3-((-1.0)*(-2.7)+(-y))-(x/x))+(-x)*(-0.3)/(-y)-(-x))
        print.cccc (I 2972) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2973
        !"test2973"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 2973) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2974
        !"test2974"
        z1 <== (-1.8)
        z2 <== (-1.8)
        print.cccc (I 2974) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2975
        !"test2975"
        z1 <== q-((-1.6)-(-p)/p)*(-0.5)
        z2 <== y-((-1.6)-(-x)/x)*(-0.5)
        print.cccc (I 2975) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2976
        !"test2976"
        z1 <== 8.1
        z2 <== 8.1
        print.cccc (I 2976) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2977
        !"test2977"
        z1 <== q
        z2 <== y
        print.cccc (I 2977) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2978
        !"test2978"
        z1 <== (6.8+(((-q)))*(8.0-((-7.7)/0.8/(-6.4)/p)*(-q))/6.6)
        z2 <== (6.8+(((-y)))*(8.0-((-7.7)/0.8/(-6.4)/x)*(-y))/6.6)
        print.cccc (I 2978) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2979
        !"test2979"
        z1 <== (((q*(-4.3))*((-6.6)-(-5.0))-7.5-(-3.6))*4.5*((-q)+(-6.8)-2.6/(-8.0))/((-7.0)/(-3.4)*5.0)/((-q)/(-5.5)-(-q)/(-q)*(-3.6))*(-q)/(((-1.6))-((-8.5)/p*(-3.7)+(-q)/(-q))*7.5-((-q)/p/(-3.1)*(-2.0))))
        z2 <== (((y*(-4.3))*((-6.6)-(-5.0))-7.5-(-3.6))*4.5*((-y)+(-6.8)-2.6/(-8.0))/((-7.0)/(-3.4)*5.0)/((-y)/(-5.5)-(-y)/(-y)*(-3.6))*(-y)/(((-1.6))-((-8.5)/x*(-3.7)+(-y)/(-y))*7.5-((-y)/x/(-3.1)*(-2.0))))
        print.cccc (I 2979) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2980
        !"test2980"
        z1 <== (q*(((-p)*(-4.8))+5.7/q/(-p)-1.2*q*1.0)-(((-q)/(-p)+(-p)*(-0.2)+6.3))+(((-8.8)+(-2.2)-(-p)/(-p))-((-q))/(1.0/(-q)))-(-p))
        z2 <== (y*(((-x)*(-4.8))+5.7/y/(-x)-1.2*y*1.0)-(((-y)/(-x)+(-x)*(-0.2)+6.3))+(((-8.8)+(-2.2)-(-x)/(-x))-((-y))/(1.0/(-y)))-(-x))
        print.cccc (I 2980) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2981
        !"test2981"
        z1 <== (p/1.8-(7.3/(-q)-q-((-q)/(-q)+(-p)+p)/(-p)))
        z2 <== (x/1.8-(7.3/(-y)-y-((-y)/(-y)+(-x)+x)/(-x)))
        print.cccc (I 2981) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2982
        !"test2982"
        z1 <== ((-5.3)-(p+((-6.4)/(-3.0)))-((2.8*(-q))/p-(-q)*(8.0-(-8.1)*(-8.3)*q*(-6.0))+1.7+2.1*(-4.1)/q)*q+p)
        z2 <== ((-5.3)-(x+((-6.4)/(-3.0)))-((2.8*(-y))/x-(-y)*(8.0-(-8.1)*(-8.3)*y*(-6.0))+1.7+2.1*(-4.1)/y)*y+x)
        print.cccc (I 2982) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2983
        !"test2983"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 2983) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2984
        !"test2984"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 2984) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2985
        !"test2985"
        z1 <== (4.8*((-0.5)/7.0)+3.3/((-5.8)*(-q))*q-(((-q)+(-p)/(-0.1)/(-5.4)*8.1)))
        z2 <== (4.8*((-0.5)/7.0)+3.3/((-5.8)*(-y))*y-(((-y)+(-x)/(-0.1)/(-5.4)*8.1)))
        print.cccc (I 2985) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2986
        !"test2986"
        z1 <== (q/3.5+0.4/8.6)
        z2 <== (y/3.5+0.4/8.6)
        print.cccc (I 2986) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2987
        !"test2987"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 2987) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2988
        !"test2988"
        z1 <== q
        z2 <== y
        print.cccc (I 2988) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2989
        !"test2989"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 2989) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2990
        !"test2990"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 2990) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2991
        !"test2991"
        z1 <== (-p)+p*(q*(-5.8)/(-q))/(p-(-6.1)*(-p))+(-p)/q
        z2 <== (-x)+x*(y*(-5.8)/(-y))/(x-(-6.1)*(-x))+(-x)/y
        print.cccc (I 2991) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2992
        !"test2992"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 2992) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2993
        !"test2993"
        z1 <== (((-p)*(-6.7)-(-4.1)+(-5.7))*(3.1*(q*q*(-p)*q/p))*(((-6.6))-(-3.5)))
        z2 <== (((-x)*(-6.7)-(-4.1)+(-5.7))*(3.1*(y*y*(-x)*y/x))*(((-6.6))-(-3.5)))
        print.cccc (I 2993) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2994
        !"test2994"
        z1 <== q
        z2 <== y
        print.cccc (I 2994) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2995
        !"test2995"
        z1 <== (3.0)
        z2 <== (3.0)
        print.cccc (I 2995) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2996
        !"test2996"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 2996) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2997
        !"test2997"
        z1 <== ((-4.8)/(4.4)/p-((-p)/(q/(-0.8)-(-1.1))-p-3.3*(-p)-4.0*(-6.5)-(-7.1)/(2.7/1.1*p*(-1.2)+(-q))))
        z2 <== ((-4.8)/(4.4)/x-((-x)/(y/(-0.8)-(-1.1))-x-3.3*(-x)-4.0*(-6.5)-(-7.1)/(2.7/1.1*x*(-1.2)+(-y))))
        print.cccc (I 2997) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2998
        !"test2998"
        z1 <== 1.4
        z2 <== 1.4
        print.cccc (I 2998) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 2999
        !"test2999"
        z1 <== ((-q)*7.6)
        z2 <== ((-y)*7.6)
        print.cccc (I 2999) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3000
        !"test3000"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 3000) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3001
        !"test3001"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3001) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3002
        !"test3002"
        z1 <== ((p)+(-q)+(7.2*(p-2.2-(-p)*(-q)+q)-p*((-1.6)+(-q)+(-q)/p*(-6.6)))-(-p)+(((-p)-(-p)+(-q)*q+8.2)))
        z2 <== ((x)+(-y)+(7.2*(x-2.2-(-x)*(-y)+y)-x*((-1.6)+(-y)+(-y)/x*(-6.6)))-(-x)+(((-x)-(-x)+(-y)*y+8.2)))
        print.cccc (I 3002) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3003
        !"test3003"
        z1 <== (-q)-(((-q)/(-6.0))*(-q))
        z2 <== (-y)-(((-y)/(-6.0))*(-y))
        print.cccc (I 3003) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3004
        !"test3004"
        z1 <== 7.7
        z2 <== 7.7
        print.cccc (I 3004) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3005
        !"test3005"
        z1 <== (q/p-(-3.8)+(p*(-p))-((-q)/(-q)*(-4.8))-((-q)-(-q)+q/(-p)/(-4.2)*((-p)*(-2.4))+((-0.1)-8.6))/(-4.3)/(-q))
        z2 <== (y/x-(-3.8)+(x*(-x))-((-y)/(-y)*(-4.8))-((-y)-(-y)+y/(-x)/(-4.2)*((-x)*(-2.4))+((-0.1)-8.6))/(-4.3)/(-y))
        print.cccc (I 3005) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3006
        !"test3006"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 3006) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3007
        !"test3007"
        z1 <== ((8.4+(-q)-(-q)-(-4.6)+q+(-p)*8.7*(-p)*4.2)-(-0.0)/(8.0-0.8)/q/q*((-7.5))-2.3)
        z2 <== ((8.4+(-y)-(-y)-(-4.6)+y+(-x)*8.7*(-x)*4.2)-(-0.0)/(8.0-0.8)/y/y*((-7.5))-2.3)
        print.cccc (I 3007) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3008
        !"test3008"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 3008) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3009
        !"test3009"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 3009) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3010
        !"test3010"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 3010) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3011
        !"test3011"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3011) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3012
        !"test3012"
        z1 <== (((3.5)/p*q+(-q)-(-p)*(0.1*p+(-6.0)*(-8.7)*0.1)-(q)+q)+((-2.4))/p-(-2.6))
        z2 <== (((3.5)/x*y+(-y)-(-x)*(0.1*x+(-6.0)*(-8.7)*0.1)-(y)+y)+((-2.4))/x-(-2.6))
        print.cccc (I 3012) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3013
        !"test3013"
        z1 <== ((-p)+((-2.7))/(-1.6)*(-7.0)+(-7.8))
        z2 <== ((-x)+((-2.7))/(-1.6)*(-7.0)+(-7.8))
        print.cccc (I 3013) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3014
        !"test3014"
        z1 <== ((((-0.4)*(-7.4)*2.0))*((-7.4)/(-q))/((q)+(-p))+(p/q)*1.6)
        z2 <== ((((-0.4)*(-7.4)*2.0))*((-7.4)/(-y))/((y)+(-x))+(x/y)*1.6)
        print.cccc (I 3014) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3015
        !"test3015"
        z1 <== ((-q)*((-q)-(-6.5))*((-2.6))+(((-5.3)/1.6)-4.1+0.2))
        z2 <== ((-y)*((-y)-(-6.5))*((-2.6))+(((-5.3)/1.6)-4.1+0.2))
        print.cccc (I 3015) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3016
        !"test3016"
        z1 <== (q-p+p)
        z2 <== (y-x+x)
        print.cccc (I 3016) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3017
        !"test3017"
        z1 <== (-5.1)*(q-(-q)+((-p)/8.8+4.5+(-0.3)+(-p)))/((-p)/p+(-0.4)*1.7+0.7/((-q)+q)-(q/p-5.7/(-q)-(-p))-1.6*3.8)-(-p)
        z2 <== (-5.1)*(y-(-y)+((-x)/8.8+4.5+(-0.3)+(-x)))/((-x)/x+(-0.4)*1.7+0.7/((-y)+y)-(y/x-5.7/(-y)-(-x))-1.6*3.8)-(-x)
        print.cccc (I 3017) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3018
        !"test3018"
        z1 <== ((-5.6)-(-2.1)*(-6.8)*6.2/(((-p)+p-q*1.8/p)+6.7-(-p)*(q+q)-7.2))
        z2 <== ((-5.6)-(-2.1)*(-6.8)*6.2/(((-x)+x-y*1.8/x)+6.7-(-x)*(y+y)-7.2))
        print.cccc (I 3018) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3019
        !"test3019"
        z1 <== p
        z2 <== x
        print.cccc (I 3019) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3020
        !"test3020"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3020) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3021
        !"test3021"
        z1 <== ((p+p/(0.0-(-2.0))+q*6.3+q/1.2)-6.2-((-7.0)/(-5.4)*(-3.0)+8.6/p/(-p)*((-p)*p*7.0*q)+6.5)-(-8.5)/q+p*p+p/(-6.8)+((-p)*p+(-8.3))*((-6.0)*p))
        z2 <== ((x+x/(0.0-(-2.0))+y*6.3+y/1.2)-6.2-((-7.0)/(-5.4)*(-3.0)+8.6/x/(-x)*((-x)*x*7.0*y)+6.5)-(-8.5)/y+x*x+x/(-6.8)+((-x)*x+(-8.3))*((-6.0)*x))
        print.cccc (I 3021) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3022
        !"test3022"
        z1 <== q
        z2 <== y
        print.cccc (I 3022) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3023
        !"test3023"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3023) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3024
        !"test3024"
        z1 <== (p+(((-p)/p)/1.0-(-p)*(-p)*5.1-(0.7+0.3/q*(-p)/4.8)+(2.3*(-2.2)*3.0+3.0)-q)-3.8-(-p))
        z2 <== (x+(((-x)/x)/1.0-(-x)*(-x)*5.1-(0.7+0.3/y*(-x)/4.8)+(2.3*(-2.2)*3.0+3.0)-y)-3.8-(-x))
        print.cccc (I 3024) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3025
        !"test3025"
        z1 <== p
        z2 <== x
        print.cccc (I 3025) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3026
        !"test3026"
        z1 <== q
        z2 <== y
        print.cccc (I 3026) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3027
        !"test3027"
        z1 <== ((-5.4)-((-q)*7.2-4.8-((-p)-(-6.6))))
        z2 <== ((-5.4)-((-y)*7.2-4.8-((-x)-(-6.6))))
        print.cccc (I 3027) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3028
        !"test3028"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 3028) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3029
        !"test3029"
        z1 <== ((-p)/((7.6+(-5.1))/p-(-p))+(-q)-2.3)
        z2 <== ((-x)/((7.6+(-5.1))/x-(-x))+(-y)-2.3)
        print.cccc (I 3029) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3030
        !"test3030"
        z1 <== ((-5.8)/(-4.1)*(-7.4))
        z2 <== ((-5.8)/(-4.1)*(-7.4))
        print.cccc (I 3030) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3031
        !"test3031"
        z1 <== (1.1*q/((-1.8)+((-q)+q)/4.6/(1.5-q+6.5*(-2.0))))
        z2 <== (1.1*y/((-1.8)+((-y)+y)/4.6/(1.5-y+6.5*(-2.0))))
        print.cccc (I 3031) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3032
        !"test3032"
        z1 <== ((-5.5)*6.3)
        z2 <== ((-5.5)*6.3)
        print.cccc (I 3032) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3033
        !"test3033"
        z1 <== p
        z2 <== x
        print.cccc (I 3033) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3034
        !"test3034"
        z1 <== ((-5.5)*p+q/(-4.4)*(-p))+((-0.5)+(-q)/((-p)/q+q*(-2.2)-(-p))*(-p)-(8.0*p))/(-2.2)/(7.8*(p*q-(-6.5))+((-1.3)-q*p)+(-p))
        z2 <== ((-5.5)*x+y/(-4.4)*(-x))+((-0.5)+(-y)/((-x)/y+y*(-2.2)-(-x))*(-x)-(8.0*x))/(-2.2)/(7.8*(x*y-(-6.5))+((-1.3)-y*x)+(-x))
        print.cccc (I 3034) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3035
        !"test3035"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3035) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3036
        !"test3036"
        z1 <== ((-8.6))
        z2 <== ((-8.6))
        print.cccc (I 3036) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3037
        !"test3037"
        z1 <== p
        z2 <== x
        print.cccc (I 3037) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3038
        !"test3038"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3038) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3039
        !"test3039"
        z1 <== p/p/(-1.3)+((-5.5)*(-5.1)-q+(-q)-(-1.2)+(-q)*(-5.8))
        z2 <== x/x/(-1.3)+((-5.5)*(-5.1)-y+(-y)-(-1.2)+(-y)*(-5.8))
        print.cccc (I 3039) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3040
        !"test3040"
        z1 <== (p+(7.7))
        z2 <== (x+(7.7))
        print.cccc (I 3040) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3041
        !"test3041"
        z1 <== (-2.7)*((-1.5)/3.0)/(-6.2)/((-2.2)*2.6/(-6.8)*(-q))-((-5.4)-(-p)-(-3.2))*p/(-p)-(0.7*5.8/(-q)-(-p))-8.5
        z2 <== (-2.7)*((-1.5)/3.0)/(-6.2)/((-2.2)*2.6/(-6.8)*(-y))-((-5.4)-(-x)-(-3.2))*x/(-x)-(0.7*5.8/(-y)-(-x))-8.5
        print.cccc (I 3041) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3042
        !"test3042"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 3042) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3043
        !"test3043"
        z1 <== ((-3.0)/p+(-q))
        z2 <== ((-3.0)/x+(-y))
        print.cccc (I 3043) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3044
        !"test3044"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 3044) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3045
        !"test3045"
        z1 <== p
        z2 <== x
        print.cccc (I 3045) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3046
        !"test3046"
        z1 <== (((-q))+((p+p*(-7.1)))-((8.7-8.8+6.8*(-4.2)-1.6)+(-0.4)-p+((-4.3))/((-1.2)*(-q)/5.1-(-q)))-((p/p)-((-3.8)*2.6*q*q)/(1.5*(-q))))
        z2 <== (((-y))+((x+x*(-7.1)))-((8.7-8.8+6.8*(-4.2)-1.6)+(-0.4)-x+((-4.3))/((-1.2)*(-y)/5.1-(-y)))-((x/x)-((-3.8)*2.6*y*y)/(1.5*(-y))))
        print.cccc (I 3046) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3047
        !"test3047"
        z1 <== q
        z2 <== y
        print.cccc (I 3047) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3048
        !"test3048"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 3048) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3049
        !"test3049"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3049) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3050
        !"test3050"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 3050) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3051
        !"test3051"
        z1 <== (6.2/4.1-2.3-(-1.8)/(-6.2)/p-q)
        z2 <== (6.2/4.1-2.3-(-1.8)/(-6.2)/x-y)
        print.cccc (I 3051) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3052
        !"test3052"
        z1 <== p
        z2 <== x
        print.cccc (I 3052) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3053
        !"test3053"
        z1 <== ((2.7*(-7.0)*q+(-q)+(-8.2))/((2.2*p)-q+q)+(6.8-p)+(-0.1)+p+7.5*q*(-7.5)/5.3/(-1.1))
        z2 <== ((2.7*(-7.0)*y+(-y)+(-8.2))/((2.2*x)-y+y)+(6.8-x)+(-0.1)+x+7.5*y*(-7.5)/5.3/(-1.1))
        print.cccc (I 3053) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3054
        !"test3054"
        z1 <== (3.1)
        z2 <== (3.1)
        print.cccc (I 3054) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3055
        !"test3055"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 3055) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3056
        !"test3056"
        z1 <== ((-q)/((-p)*(-1.1)*p*(-8.6)-(-q))/((-6.7)-7.3-q)/(-3.6)+(-p)-(-4.0))
        z2 <== ((-y)/((-x)*(-1.1)*x*(-8.6)-(-y))/((-6.7)-7.3-y)/(-3.6)+(-x)-(-4.0))
        print.cccc (I 3056) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3057
        !"test3057"
        z1 <== ((-6.0)-((-q))-((-4.5)/(-3.1)*q*(-4.6))+((-1.7))/(-p)-(((-6.0)*7.5*(-p))-0.3/(-p)-((-4.6)))+7.3)
        z2 <== ((-6.0)-((-y))-((-4.5)/(-3.1)*y*(-4.6))+((-1.7))/(-x)-(((-6.0)*7.5*(-x))-0.3/(-x)-((-4.6)))+7.3)
        print.cccc (I 3057) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3058
        !"test3058"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3058) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3059
        !"test3059"
        z1 <== (-5.3)+3.2/(-6.1)/(q-p*(-1.4)*(-0.8)+(-p))*p-(-q)/((-6.5))*q
        z2 <== (-5.3)+3.2/(-6.1)/(y-x*(-1.4)*(-0.8)+(-x))*x-(-y)/((-6.5))*y
        print.cccc (I 3059) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3060
        !"test3060"
        z1 <== (((-3.5)/q*(-2.1)-(-1.1)*(-8.4)/8.2+((-p)*(-6.2)+(-8.6)+(-q)))*(((-4.7)-(-3.4))+(-0.7)*((-p)/p*(-8.1)-0.5)/(-8.7)*4.8)*((q*(-q)-5.5)+(-3.3)*((-p)*(-q)/q)+((-6.2)+8.3/2.6/(-1.6)))+0.8+(-q))
        z2 <== (((-3.5)/y*(-2.1)-(-1.1)*(-8.4)/8.2+((-x)*(-6.2)+(-8.6)+(-y)))*(((-4.7)-(-3.4))+(-0.7)*((-x)/x*(-8.1)-0.5)/(-8.7)*4.8)*((y*(-y)-5.5)+(-3.3)*((-x)*(-y)/y)+((-6.2)+8.3/2.6/(-1.6)))+0.8+(-y))
        print.cccc (I 3060) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3061
        !"test3061"
        z1 <== ((-p)-(-3.2)-(-p)-q-(p-(-6.6)*(-0.4)+5.8))/(0.6/4.8+((-q))*(-p)/(-5.0)*(-1.8))-((-5.5)+(-0.0)*(-p)*(-q)-(-8.8)/(-p)*(-q)*(-0.1))
        z2 <== ((-x)-(-3.2)-(-x)-y-(x-(-6.6)*(-0.4)+5.8))/(0.6/4.8+((-y))*(-x)/(-5.0)*(-1.8))-((-5.5)+(-0.0)*(-x)*(-y)-(-8.8)/(-x)*(-y)*(-0.1))
        print.cccc (I 3061) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3062
        !"test3062"
        z1 <== 3.5
        z2 <== 3.5
        print.cccc (I 3062) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3063
        !"test3063"
        z1 <== ((-1.1)/((-q)/(-q)-(-p))+4.0/7.7/(-q)*(4.7-q/6.8)/(q/p)*(-q)+q-((-p)-p-(-0.0))/((-p)*(-2.6)+q*p+(-q))/((-p)*(-1.1))/q/(-q)+(3.1/((-5.0)+(-3.7)+p*0.6)*((-1.6)+(-0.5)/1.6-6.0*q)))
        z2 <== ((-1.1)/((-y)/(-y)-(-x))+4.0/7.7/(-y)*(4.7-y/6.8)/(y/x)*(-y)+y-((-x)-x-(-0.0))/((-x)*(-2.6)+y*x+(-y))/((-x)*(-1.1))/y/(-y)+(3.1/((-5.0)+(-3.7)+x*0.6)*((-1.6)+(-0.5)/1.6-6.0*y)))
        print.cccc (I 3063) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3064
        !"test3064"
        z1 <== 8.5/(((-3.7)/(-3.7)-6.2+(-q)+(-7.7))/(p*(-7.3)+p)+0.1)
        z2 <== 8.5/(((-3.7)/(-3.7)-6.2+(-y)+(-7.7))/(x*(-7.3)+x)+0.1)
        print.cccc (I 3064) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3065
        !"test3065"
        z1 <== (((-q)*(-p)*2.8-1.3/q+((-q)-5.6*(-q)*(-q))-(-q)/6.3/p)+((q*(-p)*(-5.3)-(-7.4)/p))-(((-p)*q/(-5.2))-((-p)-q+p+(-p))+p*((-4.8)-(-7.6)-(-p)/(-q))))
        z2 <== (((-y)*(-x)*2.8-1.3/y+((-y)-5.6*(-y)*(-y))-(-y)/6.3/x)+((y*(-x)*(-5.3)-(-7.4)/x))-(((-x)*y/(-5.2))-((-x)-y+x+(-x))+x*((-4.8)-(-7.6)-(-x)/(-y))))
        print.cccc (I 3065) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3066
        !"test3066"
        z1 <== q
        z2 <== y
        print.cccc (I 3066) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3067
        !"test3067"
        z1 <== (5.7+(q/((-2.7)+p*(-q))+p)+(((-7.2)+1.1+(-p)/(-1.2)-6.3))-q)
        z2 <== (5.7+(y/((-2.7)+x*(-y))+x)+(((-7.2)+1.1+(-x)/(-1.2)-6.3))-y)
        print.cccc (I 3067) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3068
        !"test3068"
        z1 <== ((p*(-q))*(-q)/6.5/(q-1.8)+((-3.8)-0.3*(-q)-6.1-1.5)/5.7+p/(7.7-6.2)+(q+p*1.7)*((-0.0)*(-p))+p)
        z2 <== ((x*(-y))*(-y)/6.5/(y-1.8)+((-3.8)-0.3*(-y)-6.1-1.5)/5.7+x/(7.7-6.2)+(y+x*1.7)*((-0.0)*(-x))+x)
        print.cccc (I 3068) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3069
        !"test3069"
        z1 <== (-p)+p+(-p)-((-1.7)*(-7.5)/2.0-(-p)-(-q))+(q+5.6+q)
        z2 <== (-x)+x+(-x)-((-1.7)*(-7.5)/2.0-(-x)-(-y))+(y+5.6+y)
        print.cccc (I 3069) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3070
        !"test3070"
        z1 <== (3.4*(-5.4)+(-6.8))
        z2 <== (3.4*(-5.4)+(-6.8))
        print.cccc (I 3070) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3071
        !"test3071"
        z1 <== (((-3.2)*q-((-q))*((-2.1)*(-8.5)*q+3.6))*((-6.4)/q+(-p))+3.3/p*(-q)/(-7.5)*q)
        z2 <== (((-3.2)*y-((-y))*((-2.1)*(-8.5)*y+3.6))*((-6.4)/y+(-x))+3.3/x*(-y)/(-7.5)*y)
        print.cccc (I 3071) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3072
        !"test3072"
        z1 <== q
        z2 <== y
        print.cccc (I 3072) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3073
        !"test3073"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 3073) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3074
        !"test3074"
        z1 <== p
        z2 <== x
        print.cccc (I 3074) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3075
        !"test3075"
        z1 <== (q+p*q*0.0-7.0+((-6.0)-2.2/(-2.8)+(-p)*q)-(p/7.6+(-q)*(-p)+(-0.7))+((-p))/p+(-8.8))
        z2 <== (y+x*y*0.0-7.0+((-6.0)-2.2/(-2.8)+(-x)*y)-(x/7.6+(-y)*(-x)+(-0.7))+((-x))/x+(-8.8))
        print.cccc (I 3075) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3076
        !"test3076"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 3076) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3077
        !"test3077"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 3077) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3078
        !"test3078"
        z1 <== ((-0.8)-p)
        z2 <== ((-0.8)-x)
        print.cccc (I 3078) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3079
        !"test3079"
        z1 <== ((((-0.1)*(-1.0))-(q-q*3.2-(-7.6)-(-0.5)))*(-q)-((-q)+(q/p*(-q)-q)-(5.8-(-q))*(8.0))+((-0.0)+(-q)-(-2.2)*8.0)/p-q-((-8.8)-q*(-p))+6.6)
        z2 <== ((((-0.1)*(-1.0))-(y-y*3.2-(-7.6)-(-0.5)))*(-y)-((-y)+(y/x*(-y)-y)-(5.8-(-y))*(8.0))+((-0.0)+(-y)-(-2.2)*8.0)/x-y-((-8.8)-y*(-x))+6.6)
        print.cccc (I 3079) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3080
        !"test3080"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 3080) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3081
        !"test3081"
        z1 <== 7.6
        z2 <== 7.6
        print.cccc (I 3081) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3082
        !"test3082"
        z1 <== ((5.1/8.4/p+(7.8+(-q)*(-5.3)-p)-p)/(8.0))
        z2 <== ((5.1/8.4/x+(7.8+(-y)*(-5.3)-x)-x)/(8.0))
        print.cccc (I 3082) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3083
        !"test3083"
        z1 <== p
        z2 <== x
        print.cccc (I 3083) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3084
        !"test3084"
        z1 <== 1.4
        z2 <== 1.4
        print.cccc (I 3084) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3085
        !"test3085"
        z1 <== q
        z2 <== y
        print.cccc (I 3085) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3086
        !"test3086"
        z1 <== (5.6)
        z2 <== (5.6)
        print.cccc (I 3086) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3087
        !"test3087"
        z1 <== ((((-p))/(-p)+(-q)))
        z2 <== ((((-x))/(-x)+(-y)))
        print.cccc (I 3087) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3088
        !"test3088"
        z1 <== ((-q)+(-q)-q)
        z2 <== ((-y)+(-y)-y)
        print.cccc (I 3088) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3089
        !"test3089"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 3089) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3090
        !"test3090"
        z1 <== 1.6*(-7.6)/(-p)
        z2 <== 1.6*(-7.6)/(-x)
        print.cccc (I 3090) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3091
        !"test3091"
        z1 <== ((-1.2)-3.0/(((-p)*(-p)/(-p)*5.4)))
        z2 <== ((-1.2)-3.0/(((-x)*(-x)/(-x)*5.4)))
        print.cccc (I 3091) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3092
        !"test3092"
        z1 <== (((-q)+(-4.0)*8.5/(-p)*q+8.3/(-q)/q+p*(-p)*(-p)-(-0.0)/8.7-q)+(q/q))
        z2 <== (((-y)+(-4.0)*8.5/(-x)*y+8.3/(-y)/y+x*(-x)*(-x)-(-0.0)/8.7-y)+(y/y))
        print.cccc (I 3092) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3093
        !"test3093"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 3093) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3094
        !"test3094"
        z1 <== ((-6.2)+(q*3.1+(-q)*(-5.2)/(-q))+((-p)+((-p))))
        z2 <== ((-6.2)+(y*3.1+(-y)*(-5.2)/(-y))+((-x)+((-x))))
        print.cccc (I 3094) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3095
        !"test3095"
        z1 <== (((1.4-7.1+(-1.1)/3.6/(-6.2)))/((-8.8)-(-6.6)+(-q)/5.7)-p+(-q)*((-q)-(p+5.7-q*p)-((-p)/q-(-q)+4.0+(-p))*p*((-8.5)*p-(-q))))
        z2 <== (((1.4-7.1+(-1.1)/3.6/(-6.2)))/((-8.8)-(-6.6)+(-y)/5.7)-x+(-y)*((-y)-(x+5.7-y*x)-((-x)/y-(-y)+4.0+(-x))*x*((-8.5)*x-(-y))))
        print.cccc (I 3095) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3096
        !"test3096"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 3096) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3097
        !"test3097"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 3097) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3098
        !"test3098"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 3098) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3099
        !"test3099"
        z1 <== (((-8.3)-8.6/p+6.8)/((-7.0))*1.2/3.5/(-q))
        z2 <== (((-8.3)-8.6/x+6.8)/((-7.0))*1.2/3.5/(-y))
        print.cccc (I 3099) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3100
        !"test3100"
        z1 <== (7.8*(-5.2)-((6.5))-(-q))
        z2 <== (7.8*(-5.2)-((6.5))-(-y))
        print.cccc (I 3100) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3101
        !"test3101"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 3101) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3102
        !"test3102"
        z1 <== q
        z2 <== y
        print.cccc (I 3102) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3103
        !"test3103"
        z1 <== ((8.2-((-p)*q+5.1+(-p)/(-p)))*(-q))
        z2 <== ((8.2-((-x)*y+5.1+(-x)/(-x)))*(-y))
        print.cccc (I 3103) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3104
        !"test3104"
        z1 <== ((4.0-(8.6-(-q)+(-p)))-(8.4/((-6.7))+(q/4.2/(-1.2)+8.8*6.3)*(4.4*0.5-(-3.1)+(-q)/p)-p)+(q))
        z2 <== ((4.0-(8.6-(-y)+(-x)))-(8.4/((-6.7))+(y/4.2/(-1.2)+8.8*6.3)*(4.4*0.5-(-3.1)+(-y)/x)-x)+(y))
        print.cccc (I 3104) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3105
        !"test3105"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 3105) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3106
        !"test3106"
        z1 <== p
        z2 <== x
        print.cccc (I 3106) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3107
        !"test3107"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 3107) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3108
        !"test3108"
        z1 <== (((8.3+q-q+(-7.5)+8.4))-(-6.4)*(-p)*(p+4.7/(-7.5)*(-p)/p)/(p)/((1.8+(-5.4)*(-q)+q)-(q+p-(-q)*p)))
        z2 <== (((8.3+y-y+(-7.5)+8.4))-(-6.4)*(-x)*(x+4.7/(-7.5)*(-x)/x)/(x)/((1.8+(-5.4)*(-y)+y)-(y+x-(-y)*x)))
        print.cccc (I 3108) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3109
        !"test3109"
        z1 <== q
        z2 <== y
        print.cccc (I 3109) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3110
        !"test3110"
        z1 <== (((-q)+q/(-p))-(-6.6)-(-q)-q*(-2.4)*(-0.8)*q)+(-p)+(-p)-(-7.0)
        z2 <== (((-y)+y/(-x))-(-6.6)-(-y)-y*(-2.4)*(-0.8)*y)+(-x)+(-x)-(-7.0)
        print.cccc (I 3110) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3111
        !"test3111"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3111) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3112
        !"test3112"
        z1 <== q
        z2 <== y
        print.cccc (I 3112) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3113
        !"test3113"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 3113) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3114
        !"test3114"
        z1 <== (p+(6.2/(-q)-(-3.1))+(-p)+3.6*(-p))
        z2 <== (x+(6.2/(-y)-(-3.1))+(-x)+3.6*(-x))
        print.cccc (I 3114) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3115
        !"test3115"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 3115) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3116
        !"test3116"
        z1 <== (1.8-6.1+q/2.4*((-1.0)*p))
        z2 <== (1.8-6.1+y/2.4*((-1.0)*x))
        print.cccc (I 3116) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3117
        !"test3117"
        z1 <== p
        z2 <== x
        print.cccc (I 3117) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3118
        !"test3118"
        z1 <== q
        z2 <== y
        print.cccc (I 3118) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3119
        !"test3119"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 3119) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3120
        !"test3120"
        z1 <== (((1.1*(-p)+(-7.5))/(-0.1)+q)+q*(-3.3)/((-p))/3.5*p/(7.8)/(5.6-q-2.3-5.8+q)/6.6)
        z2 <== (((1.1*(-x)+(-7.5))/(-0.1)+y)+y*(-3.3)/((-x))/3.5*x/(7.8)/(5.6-y-2.3-5.8+y)/6.6)
        print.cccc (I 3120) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3121
        !"test3121"
        z1 <== (2.0-((p/(-2.8)))*(q*(-7.0)/(-5.8)/p-(-p))-(7.6+(-4.5)+p/(-q))/(-2.2)*(3.7)-p+q+8.3-(-8.5)-6.6)
        z2 <== (2.0-((x/(-2.8)))*(y*(-7.0)/(-5.8)/x-(-x))-(7.6+(-4.5)+x/(-y))/(-2.2)*(3.7)-x+y+8.3-(-8.5)-6.6)
        print.cccc (I 3121) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3122
        !"test3122"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 3122) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3123
        !"test3123"
        z1 <== (-q)-5.8+((-q)*(-q)*(-q)-(-p)-7.2)/((-1.2)/p)+7.4+(-p)/(-p)/(-6.3)
        z2 <== (-y)-5.8+((-y)*(-y)*(-y)-(-x)-7.2)/((-1.2)/x)+7.4+(-x)/(-x)/(-6.3)
        print.cccc (I 3123) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3124
        !"test3124"
        z1 <== p
        z2 <== x
        print.cccc (I 3124) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3125
        !"test3125"
        z1 <== (((q/(-1.5)-p-q)-q-q)+((-p)+(q-(-2.5)+q*(-q)))-(-q))
        z2 <== (((y/(-1.5)-x-y)-y-y)+((-x)+(y-(-2.5)+y*(-y)))-(-y))
        print.cccc (I 3125) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3126
        !"test3126"
        z1 <== ((((-p)/(-q)-(-p)-2.4)*(-p)+((-8.3)+(-q)+(-p)/p))-(1.3)*(0.7+7.3+q-q*8.7)-p*p/(6.3+q/(-q)-(-q)+(-2.3))-(-q)+(-q)+(5.3+(p-(-0.2))+((-1.7)*(-q)))/(((-q)*p)))
        z2 <== ((((-x)/(-y)-(-x)-2.4)*(-x)+((-8.3)+(-y)+(-x)/x))-(1.3)*(0.7+7.3+y-y*8.7)-x*x/(6.3+y/(-y)-(-y)+(-2.3))-(-y)+(-y)+(5.3+(x-(-0.2))+((-1.7)*(-y)))/(((-y)*x)))
        print.cccc (I 3126) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3127
        !"test3127"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 3127) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3128
        !"test3128"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3128) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3129
        !"test3129"
        z1 <== ((((-7.1)-q/(-p)*(-0.8)-(-p))/(-3.4)))
        z2 <== ((((-7.1)-y/(-x)*(-0.8)-(-x))/(-3.4)))
        print.cccc (I 3129) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3130
        !"test3130"
        z1 <== (5.5+((-8.6)+((-q)*(-4.2)/2.7-(-1.4)+q)-(-p)))
        z2 <== (5.5+((-8.6)+((-y)*(-4.2)/2.7-(-1.4)+y)-(-x)))
        print.cccc (I 3130) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3131
        !"test3131"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3131) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3132
        !"test3132"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3132) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3133
        !"test3133"
        z1 <== (-7.0)+((-1.2)*((-0.2)/q+(-q)*4.2*(-8.6))/(-2.0)+(p+(-p)))+(-p)
        z2 <== (-7.0)+((-1.2)*((-0.2)/y+(-y)*4.2*(-8.6))/(-2.0)+(x+(-x)))+(-x)
        print.cccc (I 3133) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3134
        !"test3134"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3134) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3135
        !"test3135"
        z1 <== (q+p-((p)*(-8.4)/((-p)/6.6))+p/(-p)/(-5.5)/3.0/2.5-3.0*(-p)/0.5-((-8.2)-3.0-p))
        z2 <== (y+x-((x)*(-8.4)/((-x)/6.6))+x/(-x)/(-5.5)/3.0/2.5-3.0*(-x)/0.5-((-8.2)-3.0-x))
        print.cccc (I 3135) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3136
        !"test3136"
        z1 <== ((-7.0))
        z2 <== ((-7.0))
        print.cccc (I 3136) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3137
        !"test3137"
        z1 <== (((-q)*(-q)+(-1.5)/7.4)+q+q-(-2.6)+q)
        z2 <== (((-y)*(-y)+(-1.5)/7.4)+y+y-(-2.6)+y)
        print.cccc (I 3137) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3138
        !"test3138"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3138) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3139
        !"test3139"
        z1 <== p
        z2 <== x
        print.cccc (I 3139) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3140
        !"test3140"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 3140) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3141
        !"test3141"
        z1 <== ((-p)-p-8.0)
        z2 <== ((-x)-x-8.0)
        print.cccc (I 3141) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3142
        !"test3142"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3142) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3143
        !"test3143"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3143) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3144
        !"test3144"
        z1 <== (2.5*((-1.3)/((-q)+(-6.2)-q/(-8.0)))/(-6.5))
        z2 <== (2.5*((-1.3)/((-y)+(-6.2)-y/(-8.0)))/(-6.5))
        print.cccc (I 3144) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3145
        !"test3145"
        z1 <== ((1.0/3.7)-(((-2.6)/p+p+(-q)-(-p))-p*(8.1)*1.4)+p)
        z2 <== ((1.0/3.7)-(((-2.6)/x+x+(-y)-(-x))-x*(8.1)*1.4)+x)
        print.cccc (I 3145) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3146
        !"test3146"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3146) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3147
        !"test3147"
        z1 <== p
        z2 <== x
        print.cccc (I 3147) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3148
        !"test3148"
        z1 <== p
        z2 <== x
        print.cccc (I 3148) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3149
        !"test3149"
        z1 <== 6.5
        z2 <== 6.5
        print.cccc (I 3149) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3150
        !"test3150"
        z1 <== ((-7.1)/(-6.6)/(((-6.5)/(-q))-(p)/(6.4-(-p)))*(-q)/(8.3+(2.4/5.8/3.7*(-3.6)/0.4)-1.1*q))
        z2 <== ((-7.1)/(-6.6)/(((-6.5)/(-y))-(x)/(6.4-(-x)))*(-y)/(8.3+(2.4/5.8/3.7*(-3.6)/0.4)-1.1*y))
        print.cccc (I 3150) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3151
        !"test3151"
        z1 <== ((-p)+(6.0-p)/(-q))+(((-p)-3.7))
        z2 <== ((-x)+(6.0-x)/(-y))+(((-x)-3.7))
        print.cccc (I 3151) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3152
        !"test3152"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 3152) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3153
        !"test3153"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3153) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3154
        !"test3154"
        z1 <== q
        z2 <== y
        print.cccc (I 3154) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3155
        !"test3155"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3155) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3156
        !"test3156"
        z1 <== (q/8.5*(-p))
        z2 <== (y/8.5*(-x))
        print.cccc (I 3156) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3157
        !"test3157"
        z1 <== (6.8*(((-7.8)/1.6-2.7-(-3.6))/6.4/(-p)/8.5*(-7.3)-(5.1+p+q))+1.6-(((-8.7)/(-p)+(-6.7))+(-q)-(-2.8)-((-q)))*p)
        z2 <== (6.8*(((-7.8)/1.6-2.7-(-3.6))/6.4/(-x)/8.5*(-7.3)-(5.1+x+y))+1.6-(((-8.7)/(-x)+(-6.7))+(-y)-(-2.8)-((-y)))*x)
        print.cccc (I 3157) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3158
        !"test3158"
        z1 <== ((-q)/q-(p-(-p)+(-q))/(-p)/((-q)-p/q-((-3.2)/(-8.8)+(-p)*(-6.4)+(-2.2))+p-((-7.5)*(-8.1)*(-q)))/(-6.2))
        z2 <== ((-y)/y-(x-(-x)+(-y))/(-x)/((-y)-x/y-((-3.2)/(-8.8)+(-x)*(-6.4)+(-2.2))+x-((-7.5)*(-8.1)*(-y)))/(-6.2))
        print.cccc (I 3158) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3159
        !"test3159"
        z1 <== (((-6.8)*q/(p)+2.6*((-p)+p*(-q)+6.1))-(-p)*6.7+((6.3)-(-q)-q)*((p/(-0.7)+5.1-5.6+(-3.6))))
        z2 <== (((-6.8)*y/(x)+2.6*((-x)+x*(-y)+6.1))-(-x)*6.7+((6.3)-(-y)-y)*((x/(-0.7)+5.1-5.6+(-3.6))))
        print.cccc (I 3159) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3160
        !"test3160"
        z1 <== ((((-q)/q)+((-1.1))))
        z2 <== ((((-y)/y)+((-1.1))))
        print.cccc (I 3160) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3161
        !"test3161"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3161) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3162
        !"test3162"
        z1 <== ((-8.7)*(-q)/(-q)*q*(-6.6)+p-(-5.6)*1.5+(-2.2))+(((-0.3)))+(-q)+p*(-6.7)
        z2 <== ((-8.7)*(-y)/(-y)*y*(-6.6)+x-(-5.6)*1.5+(-2.2))+(((-0.3)))+(-y)+x*(-6.7)
        print.cccc (I 3162) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3163
        !"test3163"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 3163) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3164
        !"test3164"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 3164) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3165
        !"test3165"
        z1 <== (p-(-q)-(-5.8)+p*(-q)/0.2*((-6.7)+(0.1+(-7.7)/p+q)/((-0.2)/(-1.3)*(-1.4)))*7.0)
        z2 <== (x-(-y)-(-5.8)+x*(-y)/0.2*((-6.7)+(0.1+(-7.7)/x+y)/((-0.2)/(-1.3)*(-1.4)))*7.0)
        print.cccc (I 3165) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3166
        !"test3166"
        z1 <== q
        z2 <== y
        print.cccc (I 3166) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3167
        !"test3167"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3167) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3168
        !"test3168"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 3168) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3169
        !"test3169"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 3169) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3170
        !"test3170"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3170) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3171
        !"test3171"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3171) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3172
        !"test3172"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 3172) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3173
        !"test3173"
        z1 <== ((q*(p+1.8+p*q)+(-p))-q+(((-p)/(-0.2)/q)-(-0.8)+(-q)-(-4.3)))
        z2 <== ((y*(x+1.8+x*y)+(-x))-y+(((-x)/(-0.2)/y)-(-0.8)+(-y)-(-4.3)))
        print.cccc (I 3173) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3174
        !"test3174"
        z1 <== ((-4.2)-((0.1-(-p)*(-5.6))/(p+5.6-(-p)))/((3.8+p+q-(-p))/((-p)*(-4.4)*q))+1.1/q/((-3.4)+(-p)*(-7.3)*8.1))
        z2 <== ((-4.2)-((0.1-(-x)*(-5.6))/(x+5.6-(-x)))/((3.8+x+y-(-x))/((-x)*(-4.4)*y))+1.1/y/((-3.4)+(-x)*(-7.3)*8.1))
        print.cccc (I 3174) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3175
        !"test3175"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3175) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3176
        !"test3176"
        z1 <== (3.0-(-2.3)+(((-3.0))))
        z2 <== (3.0-(-2.3)+(((-3.0))))
        print.cccc (I 3176) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3177
        !"test3177"
        z1 <== q
        z2 <== y
        print.cccc (I 3177) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3178
        !"test3178"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3178) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3179
        !"test3179"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 3179) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3180
        !"test3180"
        z1 <== (((-p)+((-8.4))*4.6*(-q)/((-0.4)))+0.8*(p+((-7.5)/(-5.6))/1.2/((-8.6)))*((-8.8)/p-(-q)/(-p)/(-p)+(-0.7))-((-0.4)-(-q)+(-0.7)+(-q)+(-6.2))+(-q)+((-q))-(-2.4)/(8.0-7.0/(-3.1)))
        z2 <== (((-x)+((-8.4))*4.6*(-y)/((-0.4)))+0.8*(x+((-7.5)/(-5.6))/1.2/((-8.6)))*((-8.8)/x-(-y)/(-x)/(-x)+(-0.7))-((-0.4)-(-y)+(-0.7)+(-y)+(-6.2))+(-y)+((-y))-(-2.4)/(8.0-7.0/(-3.1)))
        print.cccc (I 3180) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3181
        !"test3181"
        z1 <== ((((-5.3)+q+(-8.0)))-(((-2.4)/(-8.6)-(-5.6)*(-6.2))))
        z2 <== ((((-5.3)+y+(-8.0)))-(((-2.4)/(-8.6)-(-5.6)*(-6.2))))
        print.cccc (I 3181) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3182
        !"test3182"
        z1 <== (2.8/(((-p)*p-(-4.6)/(-0.1)/(-q))-(-q)+7.7+((-0.1)))*(-q)/p-(p))
        z2 <== (2.8/(((-x)*x-(-4.6)/(-0.1)/(-y))-(-y)+7.7+((-0.1)))*(-y)/x-(x))
        print.cccc (I 3182) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3183
        !"test3183"
        z1 <== 7.6*(-1.8)-((-4.7)/(8.7-(-0.0))-p+(-p)-6.0*2.4-(-q))+(p/2.8*q)+(-4.0)-((-q)+(-4.6)-p-(-p)/(-6.1))+(-q)*(-q)*((-q)/p)
        z2 <== 7.6*(-1.8)-((-4.7)/(8.7-(-0.0))-x+(-x)-6.0*2.4-(-y))+(x/2.8*y)+(-4.0)-((-y)+(-4.6)-x-(-x)/(-6.1))+(-y)*(-y)*((-y)/x)
        print.cccc (I 3183) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3184
        !"test3184"
        z1 <== p
        z2 <== x
        print.cccc (I 3184) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3185
        !"test3185"
        z1 <== q
        z2 <== y
        print.cccc (I 3185) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3186
        !"test3186"
        z1 <== ((-4.0)*(-p)/(-8.2)-((-q)+(-p))/((-p)/p/q-p)*(8.7+(-q)/(-2.2)-6.7-(-3.6))/(-4.3)/(-6.1)*(-q))
        z2 <== ((-4.0)*(-x)/(-8.2)-((-y)+(-x))/((-x)/x/y-x)*(8.7+(-y)/(-2.2)-6.7-(-3.6))/(-4.3)/(-6.1)*(-y))
        print.cccc (I 3186) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3187
        !"test3187"
        z1 <== (-6.2)+((-6.3)-3.7-((-q)+(-q)-(-p))-((-5.3)*(-p)-(-q)+7.2))-(-q)+(-q)
        z2 <== (-6.2)+((-6.3)-3.7-((-y)+(-y)-(-x))-((-5.3)*(-x)-(-y)+7.2))-(-y)+(-y)
        print.cccc (I 3187) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3188
        !"test3188"
        z1 <== q
        z2 <== y
        print.cccc (I 3188) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3189
        !"test3189"
        z1 <== (((p+q)/4.6+5.5*(p+p*p+(-q)))+((5.3)))
        z2 <== (((x+y)/4.6+5.5*(x+x*x+(-y)))+((5.3)))
        print.cccc (I 3189) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3190
        !"test3190"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3190) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3191
        !"test3191"
        z1 <== p
        z2 <== x
        print.cccc (I 3191) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3192
        !"test3192"
        z1 <== ((-0.6)-((-3.4)+((-3.6)*(-p))*(-1.0)))
        z2 <== ((-0.6)-((-3.4)+((-3.6)*(-x))*(-1.0)))
        print.cccc (I 3192) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3193
        !"test3193"
        z1 <== (((p/q-(-p))/(1.1/8.0/q)+(7.4*8.5*(-0.8)+4.1-(-1.2))))
        z2 <== (((x/y-(-x))/(1.1/8.0/y)+(7.4*8.5*(-0.8)+4.1-(-1.2))))
        print.cccc (I 3193) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3194
        !"test3194"
        z1 <== p
        z2 <== x
        print.cccc (I 3194) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3195
        !"test3195"
        z1 <== (-p)*(-p)/(((-q))+(0.5+p-p))
        z2 <== (-x)*(-x)/(((-y))+(0.5+x-x))
        print.cccc (I 3195) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3196
        !"test3196"
        z1 <== p
        z2 <== x
        print.cccc (I 3196) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3197
        !"test3197"
        z1 <== (((-p)+(-p))+p*2.1+(-p)*(-p))
        z2 <== (((-x)+(-x))+x*2.1+(-x)*(-x))
        print.cccc (I 3197) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3198
        !"test3198"
        z1 <== 0.3
        z2 <== 0.3
        print.cccc (I 3198) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3199
        !"test3199"
        z1 <== p
        z2 <== x
        print.cccc (I 3199) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3200
        !"test3200"
        z1 <== (((-p)/0.5*(p*p*(-q)*(-p))*(-5.5)+p)/((3.7-p/(-p))/(-4.5))/p/((-4.4)/0.2/q*7.5*7.1*((-5.4)-(-6.5)-(-p)-5.3*2.1)+(-0.5)/q+q-(-p)+(-p)-((-1.3)+(-p)/p-(-1.6))-(-8.0)/6.7))
        z2 <== (((-x)/0.5*(x*x*(-y)*(-x))*(-5.5)+x)/((3.7-x/(-x))/(-4.5))/x/((-4.4)/0.2/y*7.5*7.1*((-5.4)-(-6.5)-(-x)-5.3*2.1)+(-0.5)/y+y-(-x)+(-x)-((-1.3)+(-x)/x-(-1.6))-(-8.0)/6.7))
        print.cccc (I 3200) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3201
        !"test3201"
        z1 <== (8.2/0.5/(-q)/((-p)*(-2.5)+2.4*(-2.8)/6.5-(-q)))
        z2 <== (8.2/0.5/(-y)/((-x)*(-2.5)+2.4*(-2.8)/6.5-(-y)))
        print.cccc (I 3201) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3202
        !"test3202"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 3202) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3203
        !"test3203"
        z1 <== ((-1.1)-7.5-((p/p)/(-6.7)+(-p)/(-q)*(-p)*2.7)-(-q)-(-p)*3.0*(4.2+(-p)*q/q)+(-7.2))
        z2 <== ((-1.1)-7.5-((x/x)/(-6.7)+(-x)/(-y)*(-x)*2.7)-(-y)-(-x)*3.0*(4.2+(-x)*y/y)+(-7.2))
        print.cccc (I 3203) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3204
        !"test3204"
        z1 <== ((-1.1)+((-q)/(-7.4)+((-0.7)+7.1/(-3.5)))+3.1-((q*p+8.0-(-p)))-q)
        z2 <== ((-1.1)+((-y)/(-7.4)+((-0.7)+7.1/(-3.5)))+3.1-((y*x+8.0-(-x)))-y)
        print.cccc (I 3204) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3205
        !"test3205"
        z1 <== (3.1-(-p)-(p-(4.8-7.0)/q+(-6.8))+q)
        z2 <== (3.1-(-x)-(x-(4.8-7.0)/y+(-6.8))+y)
        print.cccc (I 3205) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3206
        !"test3206"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3206) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3207
        !"test3207"
        z1 <== ((-2.8)/((-6.1)*(-p)/6.6)*(-4.3)-(-q)/q*q)/(-q)/(-p)
        z2 <== ((-2.8)/((-6.1)*(-x)/6.6)*(-4.3)-(-y)/y*y)/(-y)/(-x)
        print.cccc (I 3207) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3208
        !"test3208"
        z1 <== (((-p)-(-6.7)*(p+(-5.8)-7.7))-(((-p)-(-4.8))+8.0/(q/6.3)/((-2.7))+(4.0))+(-p)/(((-0.6))*(-p))/p)
        z2 <== (((-x)-(-6.7)*(x+(-5.8)-7.7))-(((-x)-(-4.8))+8.0/(y/6.3)/((-2.7))+(4.0))+(-x)/(((-0.6))*(-x))/x)
        print.cccc (I 3208) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3209
        !"test3209"
        z1 <== (q*3.4*(q/((-4.6)+p+(-4.0)/(-q)*p)-(-5.1)+(-q)+(-p)/0.6/3.5+(-p))*3.8-(-q))
        z2 <== (y*3.4*(y/((-4.6)+x+(-4.0)/(-y)*x)-(-5.1)+(-y)+(-x)/0.6/3.5+(-x))*3.8-(-y))
        print.cccc (I 3209) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3210
        !"test3210"
        z1 <== p
        z2 <== x
        print.cccc (I 3210) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3211
        !"test3211"
        z1 <== (q+7.3*(-3.4)+p*((-p)+8.2)-((-3.2))/0.6)
        z2 <== (y+7.3*(-3.4)+x*((-x)+8.2)-((-3.2))/0.6)
        print.cccc (I 3211) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3212
        !"test3212"
        z1 <== ((p+(-p)+0.2)/((6.0)/((-2.3)+6.5/p)-q)*(p-7.5*(-q)*p))
        z2 <== ((x+(-x)+0.2)/((6.0)/((-2.3)+6.5/x)-y)*(x-7.5*(-y)*x))
        print.cccc (I 3212) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3213
        !"test3213"
        z1 <== ((p-(-q)/(-5.4))/q/(3.5+5.6/((-p)/q*5.5)+(-p)-(-q)-7.5+p/p-2.5))
        z2 <== ((x-(-y)/(-5.4))/y/(3.5+5.6/((-x)/y*5.5)+(-x)-(-y)-7.5+x/x-2.5))
        print.cccc (I 3213) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3214
        !"test3214"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 3214) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3215
        !"test3215"
        z1 <== (((q)-(-7.2)-(q*2.0+p+(-p))))
        z2 <== (((y)-(-7.2)-(y*2.0+x+(-x))))
        print.cccc (I 3215) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3216
        !"test3216"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 3216) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3217
        !"test3217"
        z1 <== (q-((-8.4)-4.8)-(-2.4)*(-q)-p*(q/q)*(p)+1.7/(-5.3)*(-p))
        z2 <== (y-((-8.4)-4.8)-(-2.4)*(-y)-x*(y/y)*(x)+1.7/(-5.3)*(-x))
        print.cccc (I 3217) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3218
        !"test3218"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3218) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3219
        !"test3219"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 3219) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3220
        !"test3220"
        z1 <== p
        z2 <== x
        print.cccc (I 3220) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3221
        !"test3221"
        z1 <== q+(-8.5)+3.1*7.8-((-4.6)-((-p)+p*6.7*q-(-q)))*(-p)
        z2 <== y+(-8.5)+3.1*7.8-((-4.6)-((-x)+x*6.7*y-(-y)))*(-x)
        print.cccc (I 3221) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3222
        !"test3222"
        z1 <== p
        z2 <== x
        print.cccc (I 3222) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3223
        !"test3223"
        z1 <== (4.5+(-p)/(1.6-(-q))/8.4+(-p))
        z2 <== (4.5+(-x)/(1.6-(-y))/8.4+(-x))
        print.cccc (I 3223) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3224
        !"test3224"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 3224) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3225
        !"test3225"
        z1 <== ((-p)+((1.4*1.5)+3.4+(-4.4)/((-4.4)/q*p+(-2.7)+3.8)))
        z2 <== ((-x)+((1.4*1.5)+3.4+(-4.4)/((-4.4)/y*x+(-2.7)+3.8)))
        print.cccc (I 3225) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3226
        !"test3226"
        z1 <== ((((-p)+q+6.7/(-6.5))*((-3.4)+(-q)*(-5.1)-(-q))+1.8)+(-1.7)/(((-4.7))))
        z2 <== ((((-x)+y+6.7/(-6.5))*((-3.4)+(-y)*(-5.1)-(-y))+1.8)+(-1.7)/(((-4.7))))
        print.cccc (I 3226) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3227
        !"test3227"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3227) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3228
        !"test3228"
        z1 <== ((-p)*q/(-p)/p-(-q)+q/7.8+q+(-1.5)/(-q))
        z2 <== ((-x)*y/(-x)/x-(-y)+y/7.8+y+(-1.5)/(-y))
        print.cccc (I 3228) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3229
        !"test3229"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3229) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3230
        !"test3230"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 3230) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3231
        !"test3231"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 3231) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3232
        !"test3232"
        z1 <== (((3.6)*(q/q)*(4.3)*((-p)-4.7/(-2.4)*1.6+(-2.0)))/((q*0.2-(-5.5)/(-q))*((-p)+(-q))*(3.6-(-q)+p)-(-0.1)-q)*(((-6.4)-8.6*5.1)+((-p)+q)*((-p)+q*(-p)+(-6.1)*2.8))/(-p)+(-p))
        z2 <== (((3.6)*(y/y)*(4.3)*((-x)-4.7/(-2.4)*1.6+(-2.0)))/((y*0.2-(-5.5)/(-y))*((-x)+(-y))*(3.6-(-y)+x)-(-0.1)-y)*(((-6.4)-8.6*5.1)+((-x)+y)*((-x)+y*(-x)+(-6.1)*2.8))/(-x)+(-x))
        print.cccc (I 3232) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3233
        !"test3233"
        z1 <== (5.7)
        z2 <== (5.7)
        print.cccc (I 3233) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3234
        !"test3234"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 3234) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3235
        !"test3235"
        z1 <== (p*6.8*(5.2-(-q)+8.3/(-8.8))+7.5)
        z2 <== (x*6.8*(5.2-(-y)+8.3/(-8.8))+7.5)
        print.cccc (I 3235) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3236
        !"test3236"
        z1 <== ((-0.8)*(7.7*(-p)/4.7)-((-p)*1.3/p+1.5)/(-q)+7.7*0.5/(-q)+((-q))*(-q)/(8.3)-((-p)*(-8.2))+((-p)*(-q)*(-4.7)/(-q)/(-p))*((-2.0)))
        z2 <== ((-0.8)*(7.7*(-x)/4.7)-((-x)*1.3/x+1.5)/(-y)+7.7*0.5/(-y)+((-y))*(-y)/(8.3)-((-x)*(-8.2))+((-x)*(-y)*(-4.7)/(-y)/(-x))*((-2.0)))
        print.cccc (I 3236) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3237
        !"test3237"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 3237) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3238
        !"test3238"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 3238) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3239
        !"test3239"
        z1 <== p
        z2 <== x
        print.cccc (I 3239) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3240
        !"test3240"
        z1 <== ((-p)+((-p)/0.1)+((-1.3)+(-8.6)/(-q))/q+((-4.2)/((-0.5)*p+3.5/(-q)))-p*(q/8.4-(-q))+q*4.7/(-6.5)*(-1.1)+(-p))
        z2 <== ((-x)+((-x)/0.1)+((-1.3)+(-8.6)/(-y))/y+((-4.2)/((-0.5)*x+3.5/(-y)))-x*(y/8.4-(-y))+y*4.7/(-6.5)*(-1.1)+(-x))
        print.cccc (I 3240) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3241
        !"test3241"
        z1 <== (((1.0-(-5.4)*8.7-6.8)+((-7.3)/7.7-4.1/(-p))+((-8.6))/q-((-4.5)))+(((-p)*q-(-6.0)-0.0)+q-((-5.5)))+(-8.8)/q/(-p)-4.2-6.0/(q+(-4.2)+q-q*p)-(-3.8)+(p-(0.6/5.7/(-4.8)/(-q)-0.4)*2.8+(2.5+7.2/(-p))))
        z2 <== (((1.0-(-5.4)*8.7-6.8)+((-7.3)/7.7-4.1/(-x))+((-8.6))/y-((-4.5)))+(((-x)*y-(-6.0)-0.0)+y-((-5.5)))+(-8.8)/y/(-x)-4.2-6.0/(y+(-4.2)+y-y*x)-(-3.8)+(x-(0.6/5.7/(-4.8)/(-y)-0.4)*2.8+(2.5+7.2/(-x))))
        print.cccc (I 3241) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3242
        !"test3242"
        z1 <== q
        z2 <== y
        print.cccc (I 3242) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3243
        !"test3243"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3243) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3244
        !"test3244"
        z1 <== (((-q))-(-p)+(-5.4)/q)
        z2 <== (((-y))-(-x)+(-5.4)/y)
        print.cccc (I 3244) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3245
        !"test3245"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 3245) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3246
        !"test3246"
        z1 <== (p/((7.7)-8.7*p)-7.0)
        z2 <== (x/((7.7)-8.7*x)-7.0)
        print.cccc (I 3246) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3247
        !"test3247"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 3247) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3248
        !"test3248"
        z1 <== (((-4.5)-(p)+(1.0/(-p)/8.2-4.3+5.0)*(6.2-(-2.3)/(-p)*(-5.1)*q)*(-q))-(-p))
        z2 <== (((-4.5)-(x)+(1.0/(-x)/8.2-4.3+5.0)*(6.2-(-2.3)/(-x)*(-5.1)*y)*(-y))-(-x))
        print.cccc (I 3248) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3249
        !"test3249"
        z1 <== q
        z2 <== y
        print.cccc (I 3249) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3250
        !"test3250"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3250) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3251
        !"test3251"
        z1 <== p
        z2 <== x
        print.cccc (I 3251) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3252
        !"test3252"
        z1 <== (((q/6.0*(-q)/(-p))+8.3+(-q)*(-p)/(-0.1)-(-0.7)+(-2.4)/(-0.3)+1.3/(-q))*(4.3)*(3.1/3.7)/(-q)/(((-p))-(-q)/7.0*5.5*(q+(-0.1)*p*(-p)*(-0.1))/0.4))
        z2 <== (((y/6.0*(-y)/(-x))+8.3+(-y)*(-x)/(-0.1)-(-0.7)+(-2.4)/(-0.3)+1.3/(-y))*(4.3)*(3.1/3.7)/(-y)/(((-x))-(-y)/7.0*5.5*(y+(-0.1)*x*(-x)*(-0.1))/0.4))
        print.cccc (I 3252) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3253
        !"test3253"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3253) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3254
        !"test3254"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3254) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3255
        !"test3255"
        z1 <== (-4.7)
        z2 <== (-4.7)
        print.cccc (I 3255) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3256
        !"test3256"
        z1 <== (((q/q*(-p)-q+7.7)-(-p)))
        z2 <== (((y/y*(-x)-y+7.7)-(-x)))
        print.cccc (I 3256) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3257
        !"test3257"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3257) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3258
        !"test3258"
        z1 <== p
        z2 <== x
        print.cccc (I 3258) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3259
        !"test3259"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3259) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3260
        !"test3260"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3260) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3261
        !"test3261"
        z1 <== p
        z2 <== x
        print.cccc (I 3261) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3262
        !"test3262"
        z1 <== ((((-p))*2.4/7.5)*(-1.3)*(6.6*3.8*(-3.0)*(6.6+(-q)/(-p)-(-p)))/(4.7+1.7+(5.5/(-1.3)+(-q)/3.6)-((-4.8)+p*q+q*5.1))-(-4.3))
        z2 <== ((((-x))*2.4/7.5)*(-1.3)*(6.6*3.8*(-3.0)*(6.6+(-y)/(-x)-(-x)))/(4.7+1.7+(5.5/(-1.3)+(-y)/3.6)-((-4.8)+x*y+y*5.1))-(-4.3))
        print.cccc (I 3262) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3263
        !"test3263"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 3263) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3264
        !"test3264"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 3264) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3265
        !"test3265"
        z1 <== (((-q)))
        z2 <== (((-y)))
        print.cccc (I 3265) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3266
        !"test3266"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 3266) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3267
        !"test3267"
        z1 <== (((3.8)))
        z2 <== (((3.8)))
        print.cccc (I 3267) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3268
        !"test3268"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 3268) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3269
        !"test3269"
        z1 <== ((-5.1)/(-8.0)+(-p)*q/p-7.0*((-p))/6.4/p-(-p)*((7.6*(-2.2)-p*2.1)+(7.8)/(8.3/(-q)-(-7.0)/0.5)))
        z2 <== ((-5.1)/(-8.0)+(-x)*y/x-7.0*((-x))/6.4/x-(-x)*((7.6*(-2.2)-x*2.1)+(7.8)/(8.3/(-y)-(-7.0)/0.5)))
        print.cccc (I 3269) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3270
        !"test3270"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 3270) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3271
        !"test3271"
        z1 <== 2.6
        z2 <== 2.6
        print.cccc (I 3271) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3272
        !"test3272"
        z1 <== (((6.5*(-1.0)*(-p)*(-q))+(p/(-q)/4.5*p)/((-q)*(-3.6)/7.2/(-q)*(-p)))-((-p)+(-7.3)-((-4.0)/p*(-7.6)-0.8+(-2.3))+(-3.3)))
        z2 <== (((6.5*(-1.0)*(-x)*(-y))+(x/(-y)/4.5*x)/((-y)*(-3.6)/7.2/(-y)*(-x)))-((-x)+(-7.3)-((-4.0)/x*(-7.6)-0.8+(-2.3))+(-3.3)))
        print.cccc (I 3272) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3273
        !"test3273"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3273) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3274
        !"test3274"
        z1 <== p
        z2 <== x
        print.cccc (I 3274) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3275
        !"test3275"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3275) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3276
        !"test3276"
        z1 <== ((2.1-3.1*5.1+8.1*p)/q*((-p))+p)
        z2 <== ((2.1-3.1*5.1+8.1*x)/y*((-x))+x)
        print.cccc (I 3276) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3277
        !"test3277"
        z1 <== p
        z2 <== x
        print.cccc (I 3277) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3278
        !"test3278"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 3278) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3279
        !"test3279"
        z1 <== (q/(-p)-(-5.3))
        z2 <== (y/(-x)-(-5.3))
        print.cccc (I 3279) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3280
        !"test3280"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3280) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3281
        !"test3281"
        z1 <== q
        z2 <== y
        print.cccc (I 3281) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3282
        !"test3282"
        z1 <== p
        z2 <== x
        print.cccc (I 3282) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3283
        !"test3283"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 3283) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3284
        !"test3284"
        z1 <== p
        z2 <== x
        print.cccc (I 3284) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3285
        !"test3285"
        z1 <== ((-2.8)/(q*(-3.6)-(-p)/p))/((-p))-2.0*(-p)*q+(q/p/p+8.5/6.6-((-q)-5.1)*(-q))*(4.0+((-q)+p*(-2.6)/(-p))-(p))
        z2 <== ((-2.8)/(y*(-3.6)-(-x)/x))/((-x))-2.0*(-x)*y+(y/x/x+8.5/6.6-((-y)-5.1)*(-y))*(4.0+((-y)+x*(-2.6)/(-x))-(x))
        print.cccc (I 3285) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3286
        !"test3286"
        z1 <== (((0.2)-2.8+(q*5.4*q)))
        z2 <== (((0.2)-2.8+(y*5.4*y)))
        print.cccc (I 3286) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3287
        !"test3287"
        z1 <== (((p/(-q))/(5.2+(-1.6))-q-(-q)*(-8.1))*(((-6.1))*(-0.7)))
        z2 <== (((x/(-y))/(5.2+(-1.6))-y-(-y)*(-8.1))*(((-6.1))*(-0.7)))
        print.cccc (I 3287) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3288
        !"test3288"
        z1 <== ((p+0.4*(-1.7)*p*6.0))
        z2 <== ((x+0.4*(-1.7)*x*6.0))
        print.cccc (I 3288) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3289
        !"test3289"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 3289) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3290
        !"test3290"
        z1 <== (2.1*((-p)-(q-(-q)*(-5.5)*(-p))*(7.4/(-p))+(-8.8)+(-q))+((4.8)+(-2.3)))
        z2 <== (2.1*((-x)-(y-(-y)*(-5.5)*(-x))*(7.4/(-x))+(-8.8)+(-y))+((4.8)+(-2.3)))
        print.cccc (I 3290) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3291
        !"test3291"
        z1 <== (-6.3)
        z2 <== (-6.3)
        print.cccc (I 3291) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3292
        !"test3292"
        z1 <== (((q/3.5*(-3.0))*(q+4.1/3.6+(-p)*p)-q))
        z2 <== (((y/3.5*(-3.0))*(y+4.1/3.6+(-x)*x)-y))
        print.cccc (I 3292) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3293
        !"test3293"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3293) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3294
        !"test3294"
        z1 <== q
        z2 <== y
        print.cccc (I 3294) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3295
        !"test3295"
        z1 <== q
        z2 <== y
        print.cccc (I 3295) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3296
        !"test3296"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 3296) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3297
        !"test3297"
        z1 <== (p*6.5*(p*(-p)-0.2-(p*(-5.2)+(-0.4)))-q*(-q))
        z2 <== (x*6.5*(x*(-x)-0.2-(x*(-5.2)+(-0.4)))-y*(-y))
        print.cccc (I 3297) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3298
        !"test3298"
        z1 <== ((-q)/(-4.5)*(-p)/(-3.4))
        z2 <== ((-y)/(-4.5)*(-x)/(-3.4))
        print.cccc (I 3298) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3299
        !"test3299"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 3299) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3300
        !"test3300"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 3300) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3301
        !"test3301"
        z1 <== ((-q)+(6.1-p+(-5.1)/4.4/p)/(-q)-((-7.7)/0.1-(-p)-(-3.7)/q)-((-5.8))/(-2.7)+((-q)*q))
        z2 <== ((-y)+(6.1-x+(-5.1)/4.4/x)/(-y)-((-7.7)/0.1-(-x)-(-3.7)/y)-((-5.8))/(-2.7)+((-y)*y))
        print.cccc (I 3301) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3302
        !"test3302"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 3302) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3303
        !"test3303"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3303) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3304
        !"test3304"
        z1 <== q*(-q)/(-p)-(-6.2)/(-p)/5.1+(-1.3)/(p-6.4-(-p)/p)/(-4.5)*((-p)-1.5)/((-q)-(-6.2)-(-8.8)*(-q)+3.1)/((-5.7)/(p)+((-4.5)-5.7-(-4.8))+((-5.8)))
        z2 <== y*(-y)/(-x)-(-6.2)/(-x)/5.1+(-1.3)/(x-6.4-(-x)/x)/(-4.5)*((-x)-1.5)/((-y)-(-6.2)-(-8.8)*(-y)+3.1)/((-5.7)/(x)+((-4.5)-5.7-(-4.8))+((-5.8)))
        print.cccc (I 3304) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3305
        !"test3305"
        z1 <== (-3.7)
        z2 <== (-3.7)
        print.cccc (I 3305) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3306
        !"test3306"
        z1 <== (p+4.4/(-7.4)/(-7.1)*(-q)-(-q)+(5.0+q*(-q)/(-8.4)))+(-q)
        z2 <== (x+4.4/(-7.4)/(-7.1)*(-y)-(-y)+(5.0+y*(-y)/(-8.4)))+(-y)
        print.cccc (I 3306) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3307
        !"test3307"
        z1 <== p
        z2 <== x
        print.cccc (I 3307) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3308
        !"test3308"
        z1 <== 2.1
        z2 <== 2.1
        print.cccc (I 3308) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3309
        !"test3309"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 3309) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3310
        !"test3310"
        z1 <== ((-p)+((-6.5)+(-7.1)*(-q)/4.8*(-1.4))/((-p)*(-3.2)+(-p)/q+3.6*0.2*(7.2+q+(-0.5)-q-(-p))-8.3)*4.5)
        z2 <== ((-x)+((-6.5)+(-7.1)*(-y)/4.8*(-1.4))/((-x)*(-3.2)+(-x)/y+3.6*0.2*(7.2+y+(-0.5)-y-(-x))-8.3)*4.5)
        print.cccc (I 3310) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3311
        !"test3311"
        z1 <== (6.3-(((-0.3)/p/6.0-(-4.6))/q))
        z2 <== (6.3-(((-0.3)/x/6.0-(-4.6))/y))
        print.cccc (I 3311) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3312
        !"test3312"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 3312) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3313
        !"test3313"
        z1 <== (((-5.2)+(-q)-(-p))*(-q)/p-p/(-q)*(p+q+5.7))*3.7
        z2 <== (((-5.2)+(-y)-(-x))*(-y)/x-x/(-y)*(x+y+5.7))*3.7
        print.cccc (I 3313) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3314
        !"test3314"
        z1 <== ((((-1.7)+(-q)/6.6*p)-(6.2/q+(-q)/7.0*q))+(((-8.3)/2.0+p*q+3.2)*((-p)/(-p)+(-1.5)-q)+((-q)*(-8.5)/5.7)-3.8)+(1.1)-0.6)
        z2 <== ((((-1.7)+(-y)/6.6*x)-(6.2/y+(-y)/7.0*y))+(((-8.3)/2.0+x*y+3.2)*((-x)/(-x)+(-1.5)-y)+((-y)*(-8.5)/5.7)-3.8)+(1.1)-0.6)
        print.cccc (I 3314) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3315
        !"test3315"
        z1 <== (5.4*p/(-p)-(5.6/(-1.1)+(p-(-p))/(5.0+p*(-0.6)*(-3.8)*(-q))))
        z2 <== (5.4*x/(-x)-(5.6/(-1.1)+(x-(-x))/(5.0+x*(-0.6)*(-3.8)*(-y))))
        print.cccc (I 3315) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3316
        !"test3316"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3316) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3317
        !"test3317"
        z1 <== (((-4.8)*p+(-p))+1.0/(((-p)*p*p)/(3.7*(-p)-q)/(-q)/((-0.4)-(-7.1)))-(-p)*(-q))
        z2 <== (((-4.8)*x+(-x))+1.0/(((-x)*x*x)/(3.7*(-x)-y)/(-y)/((-0.4)-(-7.1)))-(-x)*(-y))
        print.cccc (I 3317) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3318
        !"test3318"
        z1 <== p
        z2 <== x
        print.cccc (I 3318) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3319
        !"test3319"
        z1 <== (((-3.0)+((-p)/(-q))-(p/3.2)))
        z2 <== (((-3.0)+((-x)/(-y))-(x/3.2)))
        print.cccc (I 3319) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3320
        !"test3320"
        z1 <== (8.1/2.3-(-2.8)/p-p)
        z2 <== (8.1/2.3-(-2.8)/x-x)
        print.cccc (I 3320) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3321
        !"test3321"
        z1 <== 6.8
        z2 <== 6.8
        print.cccc (I 3321) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3322
        !"test3322"
        z1 <== ((-q)+(-q)+2.6)*(-0.7)/((-p))-(6.3-(q-5.1+p))+(((-q)-(-6.8)+q-1.2)/(p-8.8/(-p)/(-1.6)/5.6)+2.7)
        z2 <== ((-y)+(-y)+2.6)*(-0.7)/((-x))-(6.3-(y-5.1+x))+(((-y)-(-6.8)+y-1.2)/(x-8.8/(-x)/(-1.6)/5.6)+2.7)
        print.cccc (I 3322) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3323
        !"test3323"
        z1 <== p
        z2 <== x
        print.cccc (I 3323) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3324
        !"test3324"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 3324) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3325
        !"test3325"
        z1 <== ((-q)+(-8.3)/(-4.3))
        z2 <== ((-y)+(-8.3)/(-4.3))
        print.cccc (I 3325) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3326
        !"test3326"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3326) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3327
        !"test3327"
        z1 <== (0.4+7.7+(3.6/p/6.6)-(5.4-1.3+(-p)*(-2.5))/((-8.0)-((-6.5)+p)*(-p)*((-p)*8.3)/(-3.2))/((-2.2)/q*(-0.4)+6.1-q*((-6.7)-5.0)/0.1-(4.6/(-7.6)*p*8.7/p))*((-2.7)+(-2.0))/q/(-p))
        z2 <== (0.4+7.7+(3.6/x/6.6)-(5.4-1.3+(-x)*(-2.5))/((-8.0)-((-6.5)+x)*(-x)*((-x)*8.3)/(-3.2))/((-2.2)/y*(-0.4)+6.1-y*((-6.7)-5.0)/0.1-(4.6/(-7.6)*x*8.7/x))*((-2.7)+(-2.0))/y/(-x))
        print.cccc (I 3327) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3328
        !"test3328"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 3328) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3329
        !"test3329"
        z1 <== (0.2-(-6.6)+((-5.3)+(-4.2)*1.3*p)+((-1.1)*(-p))*(q)*(2.4/q-(-p)/(-2.0)*0.6+p-p-(-1.7)+8.8*(-q)+((-2.6)*(-q)*(-4.3)*(-q))))
        z2 <== (0.2-(-6.6)+((-5.3)+(-4.2)*1.3*x)+((-1.1)*(-x))*(y)*(2.4/y-(-x)/(-2.0)*0.6+x-x-(-1.7)+8.8*(-y)+((-2.6)*(-y)*(-4.3)*(-y))))
        print.cccc (I 3329) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3330
        !"test3330"
        z1 <== ((-0.1)-p/((-p)*p+1.2*(-8.3)*6.5-5.8+(-1.0)+4.2-q+(-q)/((-p))-(8.6-(-q)))/q/p)
        z2 <== ((-0.1)-x/((-x)*x+1.2*(-8.3)*6.5-5.8+(-1.0)+4.2-y+(-y)/((-x))-(8.6-(-y)))/y/x)
        print.cccc (I 3330) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3331
        !"test3331"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 3331) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3332
        !"test3332"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3332) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3333
        !"test3333"
        z1 <== (1.2-(((-q)))*p+6.0*(((-q)*p+(-7.7)/p)))
        z2 <== (1.2-(((-y)))*x+6.0*(((-y)*x+(-7.7)/x)))
        print.cccc (I 3333) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3334
        !"test3334"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3334) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3335
        !"test3335"
        z1 <== (3.1*(-q)-(-p)/((7.0*(-7.3)+q*(-p)-(-p))/q-p*5.6+p))
        z2 <== (3.1*(-y)-(-x)/((7.0*(-7.3)+y*(-x)-(-x))/y-x*5.6+x))
        print.cccc (I 3335) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3336
        !"test3336"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 3336) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3337
        !"test3337"
        z1 <== ((2.5*4.8-q-(-p))-(-p)/4.7-(-5.5)+7.7)*(((-2.0)+(-q)+(-q)*0.3)/(-8.3)-((-8.1)-3.3/4.0)/1.5)
        z2 <== ((2.5*4.8-y-(-x))-(-x)/4.7-(-5.5)+7.7)*(((-2.0)+(-y)+(-y)*0.3)/(-8.3)-((-8.1)-3.3/4.0)/1.5)
        print.cccc (I 3337) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3338
        !"test3338"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3338) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3339
        !"test3339"
        z1 <== (((7.4-p*(-1.6)/1.3*p)*(-6.6)*q-(5.8/8.8-(-q)*(-8.0)))/((-p)+(p+8.6*p-2.6/1.5)-((-q)))/p-(-7.6))
        z2 <== (((7.4-x*(-1.6)/1.3*x)*(-6.6)*y-(5.8/8.8-(-y)*(-8.0)))/((-x)+(x+8.6*x-2.6/1.5)-((-y)))/x-(-7.6))
        print.cccc (I 3339) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3340
        !"test3340"
        z1 <== q
        z2 <== y
        print.cccc (I 3340) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3341
        !"test3341"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 3341) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3342
        !"test3342"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3342) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3343
        !"test3343"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 3343) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3344
        !"test3344"
        z1 <== (-1.0)
        z2 <== (-1.0)
        print.cccc (I 3344) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3345
        !"test3345"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 3345) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3346
        !"test3346"
        z1 <== p
        z2 <== x
        print.cccc (I 3346) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3347
        !"test3347"
        z1 <== q
        z2 <== y
        print.cccc (I 3347) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3348
        !"test3348"
        z1 <== ((((-q)))/(q*(-2.1)*(-2.3))+q+(-p)/5.5-p*((-p)+7.5*p/3.7+1.5)+(3.8-(-1.4)+q+(-p)-(-1.6))+p)
        z2 <== ((((-y)))/(y*(-2.1)*(-2.3))+y+(-x)/5.5-x*((-x)+7.5*x/3.7+1.5)+(3.8-(-1.4)+y+(-x)-(-1.6))+x)
        print.cccc (I 3348) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3349
        !"test3349"
        z1 <== q
        z2 <== y
        print.cccc (I 3349) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3350
        !"test3350"
        z1 <== ((p+(-p)-p*p)/4.1-(-q)-((-p)-(-1.5)-(-1.3)))
        z2 <== ((x+(-x)-x*x)/4.1-(-y)-((-x)-(-1.5)-(-1.3)))
        print.cccc (I 3350) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3351
        !"test3351"
        z1 <== q
        z2 <== y
        print.cccc (I 3351) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3352
        !"test3352"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 3352) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3353
        !"test3353"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3353) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3354
        !"test3354"
        z1 <== (6.0/p+((-p)/p-1.4)+p/(-q))
        z2 <== (6.0/x+((-x)/x-1.4)+x/(-y))
        print.cccc (I 3354) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3355
        !"test3355"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 3355) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3356
        !"test3356"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 3356) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3357
        !"test3357"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3357) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3358
        !"test3358"
        z1 <== ((-2.7)*(((-6.3)-p-q+(-8.2)+(-8.2))/(-4.4)/((-q)+4.2)/q)+0.6-(-3.5))
        z2 <== ((-2.7)*(((-6.3)-x-y+(-8.2)+(-8.2))/(-4.4)/((-y)+4.2)/y)+0.6-(-3.5))
        print.cccc (I 3358) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3359
        !"test3359"
        z1 <== (((-p)-(-8.6)+(5.1-(-7.8)-5.5+0.1)-(q+(-1.7)-(-p)*6.4)*8.8/(-8.6)+q-(-p))/(q+q*(-p)))
        z2 <== (((-x)-(-8.6)+(5.1-(-7.8)-5.5+0.1)-(y+(-1.7)-(-x)*6.4)*8.8/(-8.6)+y-(-x))/(y+y*(-x)))
        print.cccc (I 3359) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3360
        !"test3360"
        z1 <== ((q*(-6.3)+(-p)-(-q)/8.3+8.4+(-5.5))-((q*(-3.1))+((-4.2)*3.8)*(-p)*(7.6-(-q)/1.2+1.7)+q)/(-p))
        z2 <== ((y*(-6.3)+(-x)-(-y)/8.3+8.4+(-5.5))-((y*(-3.1))+((-4.2)*3.8)*(-x)*(7.6-(-y)/1.2+1.7)+y)/(-x))
        print.cccc (I 3360) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3361
        !"test3361"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3361) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3362
        !"test3362"
        z1 <== (((-q))/(-3.6))*(-q)+p
        z2 <== (((-y))/(-3.6))*(-y)+x
        print.cccc (I 3362) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3363
        !"test3363"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3363) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3364
        !"test3364"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3364) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3365
        !"test3365"
        z1 <== (q/q*(-q)+(-p)/(-p))*((-q)/(-q)*(-6.7)*2.1/(-3.8)*((-6.0)-(-3.0)/p+(-q)*1.4))/(q*q/(p/(-1.3)+(-7.4)-(-q))+(-3.0))
        z2 <== (y/y*(-y)+(-x)/(-x))*((-y)/(-y)*(-6.7)*2.1/(-3.8)*((-6.0)-(-3.0)/x+(-y)*1.4))/(y*y/(x/(-1.3)+(-7.4)-(-y))+(-3.0))
        print.cccc (I 3365) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3366
        !"test3366"
        z1 <== ((p+((-3.0)*8.0-3.3+(-p)/(-1.1))-p+(-p)*q)-(-p)*(-0.1))
        z2 <== ((x+((-3.0)*8.0-3.3+(-x)/(-1.1))-x+(-x)*y)-(-x)*(-0.1))
        print.cccc (I 3366) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3367
        !"test3367"
        z1 <== q
        z2 <== y
        print.cccc (I 3367) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3368
        !"test3368"
        z1 <== (((8.1)))
        z2 <== (((8.1)))
        print.cccc (I 3368) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3369
        !"test3369"
        z1 <== ((-5.5)+q-q*(-3.6)+4.3-(-8.7)/q+5.7)
        z2 <== ((-5.5)+y-y*(-3.6)+4.3-(-8.7)/y+5.7)
        print.cccc (I 3369) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3370
        !"test3370"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 3370) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3371
        !"test3371"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3371) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3372
        !"test3372"
        z1 <== (((-p)))
        z2 <== (((-x)))
        print.cccc (I 3372) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3373
        !"test3373"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3373) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3374
        !"test3374"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 3374) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3375
        !"test3375"
        z1 <== (p/(-p)-(-q))+(-p)/((p*p-(-p)-(-4.2)*3.2)/p/(-q))/(q+(5.5/(-q)*(-2.5)))
        z2 <== (x/(-x)-(-y))+(-x)/((x*x-(-x)-(-4.2)*3.2)/x/(-y))/(y+(5.5/(-y)*(-2.5)))
        print.cccc (I 3375) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3376
        !"test3376"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3376) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3377
        !"test3377"
        z1 <== ((-7.8)+q)
        z2 <== ((-7.8)+y)
        print.cccc (I 3377) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3378
        !"test3378"
        z1 <== ((-q)-p)
        z2 <== ((-y)-x)
        print.cccc (I 3378) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3379
        !"test3379"
        z1 <== (q-6.4-(-5.3)+(-q)/(-3.8)/(-3.6)/1.6*(6.8*3.5+4.6)-q)
        z2 <== (y-6.4-(-5.3)+(-y)/(-3.8)/(-3.6)/1.6*(6.8*3.5+4.6)-y)
        print.cccc (I 3379) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3380
        !"test3380"
        z1 <== p
        z2 <== x
        print.cccc (I 3380) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3381
        !"test3381"
        z1 <== (-p)/((q/q-(-7.4)-p+8.0)-(-5.2)*((-1.5)+p)-(5.5*(-q)*(-6.0)/(-0.4)))+(p)+8.1
        z2 <== (-x)/((y/y-(-7.4)-x+8.0)-(-5.2)*((-1.5)+x)-(5.5*(-y)*(-6.0)/(-0.4)))+(x)+8.1
        print.cccc (I 3381) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3382
        !"test3382"
        z1 <== ((q+p/(p/(-p)*(-q))*1.5)-((-1.2)-p)/(p+4.8+(-p)/p-(-1.3))*3.1+(-4.4))
        z2 <== ((y+x/(x/(-x)*(-y))*1.5)-((-1.2)-x)/(x+4.8+(-x)/x-(-1.3))*3.1+(-4.4))
        print.cccc (I 3382) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3383
        !"test3383"
        z1 <== (((6.2+(-p)+p+p-(-q))+(5.5)+(2.1+8.3-7.6+(-q)+(-q))-(-4.8)*(-q))/(1.5/(-p)-q+(-6.0)-3.5)-((-0.7)/8.7)-1.2+6.5+(-3.7))
        z2 <== (((6.2+(-x)+x+x-(-y))+(5.5)+(2.1+8.3-7.6+(-y)+(-y))-(-4.8)*(-y))/(1.5/(-x)-y+(-6.0)-3.5)-((-0.7)/8.7)-1.2+6.5+(-3.7))
        print.cccc (I 3383) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3384
        !"test3384"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 3384) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3385
        !"test3385"
        z1 <== q*(-2.4)-((-p)*p*(-5.8)*3.5-(-q))
        z2 <== y*(-2.4)-((-x)*x*(-5.8)*3.5-(-y))
        print.cccc (I 3385) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3386
        !"test3386"
        z1 <== q
        z2 <== y
        print.cccc (I 3386) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3387
        !"test3387"
        z1 <== (-5.2)
        z2 <== (-5.2)
        print.cccc (I 3387) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3388
        !"test3388"
        z1 <== (4.1)
        z2 <== (4.1)
        print.cccc (I 3388) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3389
        !"test3389"
        z1 <== 3.1
        z2 <== 3.1
        print.cccc (I 3389) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3390
        !"test3390"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 3390) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3391
        !"test3391"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 3391) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3392
        !"test3392"
        z1 <== ((p)-(p-(-0.4)*4.2+1.1+(1.8)))
        z2 <== ((x)-(x-(-0.4)*4.2+1.1+(1.8)))
        print.cccc (I 3392) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3393
        !"test3393"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 3393) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3394
        !"test3394"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 3394) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3395
        !"test3395"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 3395) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3396
        !"test3396"
        z1 <== q
        z2 <== y
        print.cccc (I 3396) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3397
        !"test3397"
        z1 <== ((-p))-(-4.0)-(((-q)*8.7-p/5.4)/q+8.1/7.2)*q-(p/7.4)+(q+(-7.2)/(-p))-(-p)-(4.4+p)/7.1
        z2 <== ((-x))-(-4.0)-(((-y)*8.7-x/5.4)/y+8.1/7.2)*y-(x/7.4)+(y+(-7.2)/(-x))-(-x)-(4.4+x)/7.1
        print.cccc (I 3397) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3398
        !"test3398"
        z1 <== (((q*q/8.1+8.2*p)*((-3.0)-(-q))*(2.5-(-p))-6.5)+q*(-p))
        z2 <== (((y*y/8.1+8.2*x)*((-3.0)-(-y))*(2.5-(-x))-6.5)+y*(-x))
        print.cccc (I 3398) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3399
        !"test3399"
        z1 <== ((((-1.5)-1.8-q*2.7)+(-2.4)/(7.0*(-p)+0.2)+0.0-(1.0+(-p)+(-q)))+(p+0.3-(-q)-(-q)*7.1*(-p)+q)*(8.1/(q/(-q))/6.8/(q)/5.2)-(-q))
        z2 <== ((((-1.5)-1.8-y*2.7)+(-2.4)/(7.0*(-x)+0.2)+0.0-(1.0+(-x)+(-y)))+(x+0.3-(-y)-(-y)*7.1*(-x)+y)*(8.1/(y/(-y))/6.8/(y)/5.2)-(-y))
        print.cccc (I 3399) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3400
        !"test3400"
        z1 <== (-2.7)
        z2 <== (-2.7)
        print.cccc (I 3400) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3401
        !"test3401"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 3401) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3402
        !"test3402"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3402) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3403
        !"test3403"
        z1 <== q
        z2 <== y
        print.cccc (I 3403) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3404
        !"test3404"
        z1 <== ((-p))*(-3.0)
        z2 <== ((-x))*(-3.0)
        print.cccc (I 3404) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3405
        !"test3405"
        z1 <== (-p)-(-q)
        z2 <== (-x)-(-y)
        print.cccc (I 3405) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3406
        !"test3406"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 3406) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3407
        !"test3407"
        z1 <== (-1.6)
        z2 <== (-1.6)
        print.cccc (I 3407) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3408
        !"test3408"
        z1 <== ((-6.1)+2.2/(p)-p*p)
        z2 <== ((-6.1)+2.2/(x)-x*x)
        print.cccc (I 3408) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3409
        !"test3409"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 3409) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3410
        !"test3410"
        z1 <== p*p*3.0/2.5/3.4/(-q)-(-p)*(-p)/(-1.2)*0.8*(-p)*q+6.1/(-q)
        z2 <== x*x*3.0/2.5/3.4/(-y)-(-x)*(-x)/(-1.2)*0.8*(-x)*y+6.1/(-y)
        print.cccc (I 3410) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3411
        !"test3411"
        z1 <== ((((-6.1)*(-q)+(-6.8))+((-p)-8.2-(-7.5)-(-p)))-(-2.5)*(-4.8)+(((-6.6)-q)+0.2))
        z2 <== ((((-6.1)*(-y)+(-6.8))+((-x)-8.2-(-7.5)-(-x)))-(-2.5)*(-4.8)+(((-6.6)-y)+0.2))
        print.cccc (I 3411) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3412
        !"test3412"
        z1 <== 3.7-((-q)/(-p))+(-q)
        z2 <== 3.7-((-y)/(-x))+(-y)
        print.cccc (I 3412) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3413
        !"test3413"
        z1 <== (8.7+((-3.4)*(5.7)*((-1.1)-(-4.0)-(-5.0)*(-p))/(q*(-p)/(-p)+(-q)+q)+((-7.7)))*(-q)/(-4.4)*(-4.3)/((-p)*(-p)*(-7.8))/q-p/q)
        z2 <== (8.7+((-3.4)*(5.7)*((-1.1)-(-4.0)-(-5.0)*(-x))/(y*(-x)/(-x)+(-y)+y)+((-7.7)))*(-y)/(-4.4)*(-4.3)/((-x)*(-x)*(-7.8))/y-x/y)
        print.cccc (I 3413) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3414
        !"test3414"
        z1 <== p
        z2 <== x
        print.cccc (I 3414) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3415
        !"test3415"
        z1 <== ((-1.2)*((-q)+0.5))
        z2 <== ((-1.2)*((-y)+0.5))
        print.cccc (I 3415) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3416
        !"test3416"
        z1 <== 7.7*q/((-p)/q)
        z2 <== 7.7*y/((-x)/y)
        print.cccc (I 3416) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3417
        !"test3417"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 3417) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3418
        !"test3418"
        z1 <== ((((-q))*p*(-1.3)-(2.0+(-p)-p/(-6.4)+q))+q)
        z2 <== ((((-y))*x*(-1.3)-(2.0+(-x)-x/(-6.4)+y))+y)
        print.cccc (I 3418) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3419
        !"test3419"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 3419) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3420
        !"test3420"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3420) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3421
        !"test3421"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 3421) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3422
        !"test3422"
        z1 <== (((-p)-(5.8/(-q))-p-(-q))-(-q)-p)
        z2 <== (((-x)-(5.8/(-y))-x-(-y))-(-y)-x)
        print.cccc (I 3422) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3423
        !"test3423"
        z1 <== (((p*(-0.1)-1.4-(-q)+8.0)+p+(7.4))/(-1.0)-(-q)*4.7/((-1.0)*(-q))-(8.5/(-p)/0.6)*(-8.6)/1.0/p)
        z2 <== (((x*(-0.1)-1.4-(-y)+8.0)+x+(7.4))/(-1.0)-(-y)*4.7/((-1.0)*(-y))-(8.5/(-x)/0.6)*(-8.6)/1.0/x)
        print.cccc (I 3423) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3424
        !"test3424"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 3424) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3425
        !"test3425"
        z1 <== (8.0)
        z2 <== (8.0)
        print.cccc (I 3425) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3426
        !"test3426"
        z1 <== ((((-5.5)*2.7*(-3.0))-((-p)+q*p)/(p/q-(-q)+(-p)/(-6.7)))-(((-q)))*(-7.8))
        z2 <== ((((-5.5)*2.7*(-3.0))-((-x)+y*x)/(x/y-(-y)+(-x)/(-6.7)))-(((-y)))*(-7.8))
        print.cccc (I 3426) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3427
        !"test3427"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3427) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3428
        !"test3428"
        z1 <== 2.6
        z2 <== 2.6
        print.cccc (I 3428) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3429
        !"test3429"
        z1 <== (p-((-q)*5.0+1.8-(-q))-4.1-p+((-p)/q/4.2)*(-q)*(5.4))
        z2 <== (x-((-y)*5.0+1.8-(-y))-4.1-x+((-x)/y/4.2)*(-y)*(5.4))
        print.cccc (I 3429) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3430
        !"test3430"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3430) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3431
        !"test3431"
        z1 <== ((-2.8)+p/((-p)*(-5.1))/(((-0.2)/q+(-4.5))/(q)-q/(-4.2)))
        z2 <== ((-2.8)+x/((-x)*(-5.1))/(((-0.2)/y+(-4.5))/(y)-y/(-4.2)))
        print.cccc (I 3431) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3432
        !"test3432"
        z1 <== q
        z2 <== y
        print.cccc (I 3432) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3433
        !"test3433"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 3433) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3434
        !"test3434"
        z1 <== p+(((-5.8))+p+((-6.0)*q+(-5.3)/p)*(6.4/(-2.2)+3.2-4.0/0.5)+(-4.4))+p
        z2 <== x+(((-5.8))+x+((-6.0)*y+(-5.3)/x)*(6.4/(-2.2)+3.2-4.0/0.5)+(-4.4))+x
        print.cccc (I 3434) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3435
        !"test3435"
        z1 <== ((-3.7))
        z2 <== ((-3.7))
        print.cccc (I 3435) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3436
        !"test3436"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3436) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3437
        !"test3437"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 3437) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3438
        !"test3438"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3438) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3439
        !"test3439"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3439) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3440
        !"test3440"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 3440) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3441
        !"test3441"
        z1 <== ((-0.8))
        z2 <== ((-0.8))
        print.cccc (I 3441) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3442
        !"test3442"
        z1 <== ((((-4.5)+(-q)-(-7.2)/p+p)*(-8.5)+7.8/(6.5/(-q)-(-q)+(-q)-(-q))+3.7+p)+(-p)-1.5/6.6-1.5)
        z2 <== ((((-4.5)+(-y)-(-7.2)/x+x)*(-8.5)+7.8/(6.5/(-y)-(-y)+(-y)-(-y))+3.7+x)+(-x)-1.5/6.6-1.5)
        print.cccc (I 3442) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3443
        !"test3443"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 3443) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3444
        !"test3444"
        z1 <== ((3.2)/(-4.0)*p-(-q)*(-q)*(-3.1)-(2.0*1.7*p*0.1-6.6))/p*((-p)-((-5.6)+7.3+2.0)/((-5.4)-(-2.4)+q))*q/5.6
        z2 <== ((3.2)/(-4.0)*x-(-y)*(-y)*(-3.1)-(2.0*1.7*x*0.1-6.6))/x*((-x)-((-5.6)+7.3+2.0)/((-5.4)-(-2.4)+y))*y/5.6
        print.cccc (I 3444) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3445
        !"test3445"
        z1 <== p
        z2 <== x
        print.cccc (I 3445) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3446
        !"test3446"
        z1 <== ((-3.1)+(-q)/(0.3/8.6/p/(-5.4)-p/((-q)+(-4.3)+(-p)/(-p)*4.4))*(((-p)-p)*(3.6*q*p)*(0.2+3.5*p))-((5.6)+1.8*(-q)))
        z2 <== ((-3.1)+(-y)/(0.3/8.6/x/(-5.4)-x/((-y)+(-4.3)+(-x)/(-x)*4.4))*(((-x)-x)*(3.6*y*x)*(0.2+3.5*x))-((5.6)+1.8*(-y)))
        print.cccc (I 3446) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3447
        !"test3447"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3447) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3448
        !"test3448"
        z1 <== p
        z2 <== x
        print.cccc (I 3448) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3449
        !"test3449"
        z1 <== (((-7.7)-p)/((-3.8)/q+(-q))+q+(-p)*q+(-1.6)-(-p)/(-6.6))
        z2 <== (((-7.7)-x)/((-3.8)/y+(-y))+y+(-x)*y+(-1.6)-(-x)/(-6.6))
        print.cccc (I 3449) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3450
        !"test3450"
        z1 <== (q*q*(-5.0))
        z2 <== (y*y*(-5.0))
        print.cccc (I 3450) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3451
        !"test3451"
        z1 <== (((-1.2)+q+(-1.1)-q-(-1.2)-(-p))+p)
        z2 <== (((-1.2)+y+(-1.1)-y-(-1.2)-(-x))+x)
        print.cccc (I 3451) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3452
        !"test3452"
        z1 <== p
        z2 <== x
        print.cccc (I 3452) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3453
        !"test3453"
        z1 <== p
        z2 <== x
        print.cccc (I 3453) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3454
        !"test3454"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 3454) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3455
        !"test3455"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3455) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3456
        !"test3456"
        z1 <== (-6.3)
        z2 <== (-6.3)
        print.cccc (I 3456) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3457
        !"test3457"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3457) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3458
        !"test3458"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3458) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3459
        !"test3459"
        z1 <== ((-p)+(-2.0)+(5.3*(4.8*8.3)+q/(q+5.1-3.7/p-8.5)))
        z2 <== ((-x)+(-2.0)+(5.3*(4.8*8.3)+y/(y+5.1-3.7/x-8.5)))
        print.cccc (I 3459) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3460
        !"test3460"
        z1 <== ((-p)-(((-q)*(-q)+4.5+(-1.7)*3.0)/(-2.7)*((-6.6)+6.3)-(q*(-p)*(-p)/(-p))*(q+p*(-p)*3.8*p))-1.8/(((-7.7)+(-q)-(-0.1))-1.7+(-p)/(-q)*8.1)+q)
        z2 <== ((-x)-(((-y)*(-y)+4.5+(-1.7)*3.0)/(-2.7)*((-6.6)+6.3)-(y*(-x)*(-x)/(-x))*(y+x*(-x)*3.8*x))-1.8/(((-7.7)+(-y)-(-0.1))-1.7+(-x)/(-y)*8.1)+y)
        print.cccc (I 3460) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3461
        !"test3461"
        z1 <== q
        z2 <== y
        print.cccc (I 3461) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3462
        !"test3462"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3462) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3463
        !"test3463"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 3463) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3464
        !"test3464"
        z1 <== q
        z2 <== y
        print.cccc (I 3464) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3465
        !"test3465"
        z1 <== 5.2/((-0.3))+(-q)+(-3.1)-(q/(-q)*(-8.4)+p*p)
        z2 <== 5.2/((-0.3))+(-y)+(-3.1)-(y/(-y)*(-8.4)+x*x)
        print.cccc (I 3465) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3466
        !"test3466"
        z1 <== q
        z2 <== y
        print.cccc (I 3466) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3467
        !"test3467"
        z1 <== ((((-q))/(-8.2)/((-3.0)/8.7/5.7+p)-q*((-p)-p*q))*((-5.8)/((-2.8)/q+(-4.4)*p))/1.3)
        z2 <== ((((-y))/(-8.2)/((-3.0)/8.7/5.7+x)-y*((-x)-x*y))*((-5.8)/((-2.8)/y+(-4.4)*x))/1.3)
        print.cccc (I 3467) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3468
        !"test3468"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3468) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3469
        !"test3469"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3469) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3470
        !"test3470"
        z1 <== (((p*(-6.7)-0.3-q)*((-7.5)*(-q)*(-1.1)*p+p)+((-0.2)+1.0/q))-q/(q))
        z2 <== (((x*(-6.7)-0.3-y)*((-7.5)*(-y)*(-1.1)*x+x)+((-0.2)+1.0/y))-y/(y))
        print.cccc (I 3470) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3471
        !"test3471"
        z1 <== (((q*4.1-(-q))*(p-6.3-(-3.3)))+4.7/8.8)
        z2 <== (((y*4.1-(-y))*(x-6.3-(-3.3)))+4.7/8.8)
        print.cccc (I 3471) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3472
        !"test3472"
        z1 <== q*q-1.1
        z2 <== y*y-1.1
        print.cccc (I 3472) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3473
        !"test3473"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 3473) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3474
        !"test3474"
        z1 <== p
        z2 <== x
        print.cccc (I 3474) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3475
        !"test3475"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 3475) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3476
        !"test3476"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 3476) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3477
        !"test3477"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 3477) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3478
        !"test3478"
        z1 <== (((-0.4)/(-p)*p)-p/((-0.1)+((-p))-p)/((-p)-(-0.1)*(-q))*(-0.5))
        z2 <== (((-0.4)/(-x)*x)-x/((-0.1)+((-x))-x)/((-x)-(-0.1)*(-y))*(-0.5))
        print.cccc (I 3478) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3479
        !"test3479"
        z1 <== (p/2.1+((-5.8)/5.4/1.3)*6.4-(-p)+(p+((-p)-(-p)-(-0.7)/(-q)/8.6)))
        z2 <== (x/2.1+((-5.8)/5.4/1.3)*6.4-(-x)+(x+((-x)-(-x)-(-0.7)/(-y)/8.6)))
        print.cccc (I 3479) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3480
        !"test3480"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3480) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3481
        !"test3481"
        z1 <== (7.2-(-q)/(-0.6)*(-q))
        z2 <== (7.2-(-y)/(-0.6)*(-y))
        print.cccc (I 3481) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3482
        !"test3482"
        z1 <== (5.0*((-p))/0.7)
        z2 <== (5.0*((-x))/0.7)
        print.cccc (I 3482) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3483
        !"test3483"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3483) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3484
        !"test3484"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3484) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3485
        !"test3485"
        z1 <== p
        z2 <== x
        print.cccc (I 3485) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3486
        !"test3486"
        z1 <== (-q)-3.8*6.2/(-1.2)*q
        z2 <== (-y)-3.8*6.2/(-1.2)*y
        print.cccc (I 3486) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3487
        !"test3487"
        z1 <== (-q)+((-7.3)-(-q)*0.2+(-0.8)*(-q)/(-0.4)*q/(-5.1))-2.5/3.3-((-p))/q+((-4.4)-(-p)/q)*((-q)+1.4-(-q)-q)
        z2 <== (-y)+((-7.3)-(-y)*0.2+(-0.8)*(-y)/(-0.4)*y/(-5.1))-2.5/3.3-((-x))/y+((-4.4)-(-x)/y)*((-y)+1.4-(-y)-y)
        print.cccc (I 3487) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3488
        !"test3488"
        z1 <== (p-p*0.2*(-7.3))
        z2 <== (x-x*0.2*(-7.3))
        print.cccc (I 3488) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3489
        !"test3489"
        z1 <== (((-0.0)/(q+(-q)*p-8.2/2.8)/(3.4)-(-7.5)/(-0.5)/0.7)+((-p)*(-4.1)+1.8-(-q)+q+q))
        z2 <== (((-0.0)/(y+(-y)*x-8.2/2.8)/(3.4)-(-7.5)/(-0.5)/0.7)+((-x)*(-4.1)+1.8-(-y)+y+y))
        print.cccc (I 3489) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3490
        !"test3490"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3490) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3491
        !"test3491"
        z1 <== q
        z2 <== y
        print.cccc (I 3491) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3492
        !"test3492"
        z1 <== q
        z2 <== y
        print.cccc (I 3492) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3493
        !"test3493"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 3493) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3494
        !"test3494"
        z1 <== (((-q)-(-q)+((-q)*(-p)-q)*1.3-((-3.1)*6.2/(-4.2)*q*2.7))-((-p)+(-p)-6.5/4.8*q/(-p)+8.6*(-6.1))/q-(((-p)/(-7.1)+8.6)*((-q)+(-1.0)+(-3.1))+(-p)/(-p)/(-q)-(-7.6)/7.4))
        z2 <== (((-y)-(-y)+((-y)*(-x)-y)*1.3-((-3.1)*6.2/(-4.2)*y*2.7))-((-x)+(-x)-6.5/4.8*y/(-x)+8.6*(-6.1))/y-(((-x)/(-7.1)+8.6)*((-y)+(-1.0)+(-3.1))+(-x)/(-x)/(-y)-(-7.6)/7.4))
        print.cccc (I 3494) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3495
        !"test3495"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3495) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3496
        !"test3496"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3496) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3497
        !"test3497"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3497) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3498
        !"test3498"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 3498) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3499
        !"test3499"
        z1 <== ((-4.1))
        z2 <== ((-4.1))
        print.cccc (I 3499) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3500
        !"test3500"
        z1 <== 3.5
        z2 <== 3.5
        print.cccc (I 3500) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3501
        !"test3501"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 3501) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3502
        !"test3502"
        z1 <== (0.0/((-5.5))/(-5.8))
        z2 <== (0.0/((-5.5))/(-5.8))
        print.cccc (I 3502) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3503
        !"test3503"
        z1 <== (5.5-((p*p))+((-p)+2.2/((-2.7)/(-0.0)-3.8)/(-1.4)+((-q)*(-p)-q-8.7)))
        z2 <== (5.5-((x*x))+((-x)+2.2/((-2.7)/(-0.0)-3.8)/(-1.4)+((-y)*(-x)-y-8.7)))
        print.cccc (I 3503) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3504
        !"test3504"
        z1 <== p
        z2 <== x
        print.cccc (I 3504) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3505
        !"test3505"
        z1 <== p
        z2 <== x
        print.cccc (I 3505) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3506
        !"test3506"
        z1 <== p
        z2 <== x
        print.cccc (I 3506) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3507
        !"test3507"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 3507) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3508
        !"test3508"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 3508) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3509
        !"test3509"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 3509) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3510
        !"test3510"
        z1 <== q
        z2 <== y
        print.cccc (I 3510) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3511
        !"test3511"
        z1 <== ((((-4.1)*p-(-p)/(-p)-(-q))+7.8-((-8.8)-8.7/p)+((-6.1)+(-q)+(-5.2)-(-8.7)-(-3.8)))-4.2/(-7.5)/(-2.7)-(2.4-(-p)+p+(-5.8))+(-5.5)+(-3.4))
        z2 <== ((((-4.1)*x-(-x)/(-x)-(-y))+7.8-((-8.8)-8.7/x)+((-6.1)+(-y)+(-5.2)-(-8.7)-(-3.8)))-4.2/(-7.5)/(-2.7)-(2.4-(-x)+x+(-5.8))+(-5.5)+(-3.4))
        print.cccc (I 3511) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3512
        !"test3512"
        z1 <== ((-q)-(-q)/(-p)-p-p*p+(-6.7)*(-p)+(q+(-p)/p-p+(-p))+p+3.4)
        z2 <== ((-y)-(-y)/(-x)-x-x*x+(-6.7)*(-x)+(y+(-x)/x-x+(-x))+x+3.4)
        print.cccc (I 3512) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3513
        !"test3513"
        z1 <== ((-0.7)-((-3.6)/7.3)/1.2*(1.4*(-q)+p*p))+p
        z2 <== ((-0.7)-((-3.6)/7.3)/1.2*(1.4*(-y)+x*x))+x
        print.cccc (I 3513) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3514
        !"test3514"
        z1 <== (-q)-p/(p-2.1)-((-8.4)/p+(-5.5)-q*(-q))-(-p)+((p*(-5.5)/q)+((-6.4)*(-q)-(-2.0))/3.7)+(-2.8)
        z2 <== (-y)-x/(x-2.1)-((-8.4)/x+(-5.5)-y*(-y))-(-x)+((x*(-5.5)/y)+((-6.4)*(-y)-(-2.0))/3.7)+(-2.8)
        print.cccc (I 3514) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3515
        !"test3515"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3515) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3516
        !"test3516"
        z1 <== ((-2.8)+p*((q+q+6.3/p)/(-6.7))+8.8-(3.5/(-q)))
        z2 <== ((-2.8)+x*((y+y+6.3/x)/(-6.7))+8.8-(3.5/(-y)))
        print.cccc (I 3516) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3517
        !"test3517"
        z1 <== ((-q)-(((-1.3)+(-7.6)*q)/(-1.0)/p+(-7.1)*q*(-5.3)/0.2*(-q)/p)/4.3+4.8+(-5.2))
        z2 <== ((-y)-(((-1.3)+(-7.6)*y)/(-1.0)/x+(-7.1)*y*(-5.3)/0.2*(-y)/x)/4.3+4.8+(-5.2))
        print.cccc (I 3517) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3518
        !"test3518"
        z1 <== (p/((p)/0.6*p/p*5.5-p*(-5.1))+(p))
        z2 <== (x/((x)/0.6*x/x*5.5-x*(-5.1))+(x))
        print.cccc (I 3518) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3519
        !"test3519"
        z1 <== (((7.8-(-p)*(-4.7)*(-p))/(-q)))
        z2 <== (((7.8-(-x)*(-4.7)*(-x))/(-y)))
        print.cccc (I 3519) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3520
        !"test3520"
        z1 <== ((((-8.8)/(-7.2)*(-1.8)-3.4)/(-q)+q*((-0.4)))/8.8/p)
        z2 <== ((((-8.8)/(-7.2)*(-1.8)-3.4)/(-y)+y*((-0.4)))/8.8/x)
        print.cccc (I 3520) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3521
        !"test3521"
        z1 <== 1.7
        z2 <== 1.7
        print.cccc (I 3521) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3522
        !"test3522"
        z1 <== (-5.1)
        z2 <== (-5.1)
        print.cccc (I 3522) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3523
        !"test3523"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3523) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3524
        !"test3524"
        z1 <== p
        z2 <== x
        print.cccc (I 3524) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3525
        !"test3525"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 3525) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3526
        !"test3526"
        z1 <== (q+(-q)+(-p)-((-q)-(q*(-6.1)-3.5*p-(-8.5))-(8.1)-((-1.6)))+((q)*2.3+(-q)/(4.8)-4.3))
        z2 <== (y+(-y)+(-x)-((-y)-(y*(-6.1)-3.5*x-(-8.5))-(8.1)-((-1.6)))+((y)*2.3+(-y)/(4.8)-4.3))
        print.cccc (I 3526) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3527
        !"test3527"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 3527) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3528
        !"test3528"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 3528) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3529
        !"test3529"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3529) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3530
        !"test3530"
        z1 <== ((p+p))
        z2 <== ((x+x))
        print.cccc (I 3530) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3531
        !"test3531"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 3531) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3532
        !"test3532"
        z1 <== ((-7.4)/(((-p)+p)*p*(0.7)-2.4)-3.0/((3.7+(-8.4))*(-0.8))*(-2.8))
        z2 <== ((-7.4)/(((-x)+x)*x*(0.7)-2.4)-3.0/((3.7+(-8.4))*(-0.8))*(-2.8))
        print.cccc (I 3532) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3533
        !"test3533"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 3533) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3534
        !"test3534"
        z1 <== q
        z2 <== y
        print.cccc (I 3534) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3535
        !"test3535"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3535) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3536
        !"test3536"
        z1 <== ((((-8.6)+(-q)-p/8.6)-(4.8/(-q))))
        z2 <== ((((-8.6)+(-y)-x/8.6)-(4.8/(-y))))
        print.cccc (I 3536) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3537
        !"test3537"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3537) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3538
        !"test3538"
        z1 <== ((-4.8)+5.0+(-q))
        z2 <== ((-4.8)+5.0+(-y))
        print.cccc (I 3538) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3539
        !"test3539"
        z1 <== (q-((6.4*(-p))*0.7))
        z2 <== (y-((6.4*(-x))*0.7))
        print.cccc (I 3539) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3540
        !"test3540"
        z1 <== ((-6.8)/((-q))+(1.5/(-p)*8.7)/(p/q*(-q)+(-p))+(q*4.6/p-8.0)*(((-p)*(-6.4)*p*3.6+(-q))+((-q)*(-4.2)/q)/(-q)*(-6.2)))
        z2 <== ((-6.8)/((-y))+(1.5/(-x)*8.7)/(x/y*(-y)+(-x))+(y*4.6/x-8.0)*(((-x)*(-6.4)*x*3.6+(-y))+((-y)*(-4.2)/y)/(-y)*(-6.2)))
        print.cccc (I 3540) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3541
        !"test3541"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 3541) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3542
        !"test3542"
        z1 <== (((2.4)+(3.7+(-1.4)-2.1/(-p)))-(((-7.0)/1.6+(-4.7)-3.8)/(p/0.4)/2.2-((-4.3)/p-q*(-q)/2.5)*(-6.3))/p)
        z2 <== (((2.4)+(3.7+(-1.4)-2.1/(-x)))-(((-7.0)/1.6+(-4.7)-3.8)/(x/0.4)/2.2-((-4.3)/x-y*(-y)/2.5)*(-6.3))/x)
        print.cccc (I 3542) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3543
        !"test3543"
        z1 <== q
        z2 <== y
        print.cccc (I 3543) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3544
        !"test3544"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3544) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3545
        !"test3545"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 3545) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3546
        !"test3546"
        z1 <== (0.2+(-8.8)+q+((-q))/p)
        z2 <== (0.2+(-8.8)+y+((-y))/x)
        print.cccc (I 3546) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3547
        !"test3547"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 3547) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3548
        !"test3548"
        z1 <== p
        z2 <== x
        print.cccc (I 3548) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3549
        !"test3549"
        z1 <== ((-q)-q*0.4)
        z2 <== ((-y)-y*0.4)
        print.cccc (I 3549) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3550
        !"test3550"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 3550) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3551
        !"test3551"
        z1 <== q
        z2 <== y
        print.cccc (I 3551) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3552
        !"test3552"
        z1 <== q
        z2 <== y
        print.cccc (I 3552) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3553
        !"test3553"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3553) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3554
        !"test3554"
        z1 <== q
        z2 <== y
        print.cccc (I 3554) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3555
        !"test3555"
        z1 <== ((p+(-q)*q)/((-p)-7.2+q*q)-p-3.2)
        z2 <== ((x+(-y)*y)/((-x)-7.2+y*y)-x-3.2)
        print.cccc (I 3555) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3556
        !"test3556"
        z1 <== ((q/(0.2)*1.6/(-p)+q-(-1.7)*(-0.5)-p/(-p))+p+((-1.4)+(-q))/((-4.8)*(-4.3)-(-0.6)+p*(-q))-6.5*(-p)+q/(4.4+(-q)+(-7.1)/5.0-(-q))-p-p)
        z2 <== ((y/(0.2)*1.6/(-x)+y-(-1.7)*(-0.5)-x/(-x))+x+((-1.4)+(-y))/((-4.8)*(-4.3)-(-0.6)+x*(-y))-6.5*(-x)+y/(4.4+(-y)+(-7.1)/5.0-(-y))-x-x)
        print.cccc (I 3556) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3557
        !"test3557"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 3557) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3558
        !"test3558"
        z1 <== ((-5.5)+q)
        z2 <== ((-5.5)+y)
        print.cccc (I 3558) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3559
        !"test3559"
        z1 <== q
        z2 <== y
        print.cccc (I 3559) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3560
        !"test3560"
        z1 <== ((-4.3)+(((-7.5)+(-1.7)-7.7/p-p)-(p/(-p)+(-6.3)+(-p))/(-q)-(-2.1)*q)-4.1-(-q)*((-4.5)*(-5.2)-p)+(-4.5)-((-1.5)/(-1.6)+(-8.5)-(-q)+p)/2.5-p)
        z2 <== ((-4.3)+(((-7.5)+(-1.7)-7.7/x-x)-(x/(-x)+(-6.3)+(-x))/(-y)-(-2.1)*y)-4.1-(-y)*((-4.5)*(-5.2)-x)+(-4.5)-((-1.5)/(-1.6)+(-8.5)-(-y)+x)/2.5-x)
        print.cccc (I 3560) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3561
        !"test3561"
        z1 <== (4.0+((5.4/q))/3.0-p)
        z2 <== (4.0+((5.4/y))/3.0-x)
        print.cccc (I 3561) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3562
        !"test3562"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 3562) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3563
        !"test3563"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 3563) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3564
        !"test3564"
        z1 <== ((((-5.7)-(-1.2)/(-q))-(-q)+2.1)+(q-(-p)+(-p)*2.5-(q/7.8-(-q)-q)))
        z2 <== ((((-5.7)-(-1.2)/(-y))-(-y)+2.1)+(y-(-x)+(-x)*2.5-(y/7.8-(-y)-y)))
        print.cccc (I 3564) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3565
        !"test3565"
        z1 <== (3.2*(-7.7)*5.4)
        z2 <== (3.2*(-7.7)*5.4)
        print.cccc (I 3565) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3566
        !"test3566"
        z1 <== (((q*(-4.6)))*4.1-q/q-((-8.1)+q/(-q))-p-p/p+(-p))
        z2 <== (((y*(-4.6)))*4.1-y/y-((-8.1)+y/(-y))-x-x/x+(-x))
        print.cccc (I 3566) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3567
        !"test3567"
        z1 <== (6.8-((5.8*7.7+3.5/5.4/p)/(-6.0)*(-5.6)/(-6.5)*(-7.8)+1.1)*(1.7-(-q)/(-3.4)*(-4.4)-(-4.8))-2.2-1.5*(q*(-1.7)/7.2*(q+3.8)))
        z2 <== (6.8-((5.8*7.7+3.5/5.4/x)/(-6.0)*(-5.6)/(-6.5)*(-7.8)+1.1)*(1.7-(-y)/(-3.4)*(-4.4)-(-4.8))-2.2-1.5*(y*(-1.7)/7.2*(y+3.8)))
        print.cccc (I 3567) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3568
        !"test3568"
        z1 <== 8.1
        z2 <== 8.1
        print.cccc (I 3568) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3569
        !"test3569"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3569) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3570
        !"test3570"
        z1 <== q
        z2 <== y
        print.cccc (I 3570) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3571
        !"test3571"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3571) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3572
        !"test3572"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3572) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3573
        !"test3573"
        z1 <== (q/((6.6/(-5.4))+((-0.6)*q))+(-p)+(-p)*(-p))
        z2 <== (y/((6.6/(-5.4))+((-0.6)*y))+(-x)+(-x)*(-x))
        print.cccc (I 3573) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3574
        !"test3574"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3574) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3575
        !"test3575"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3575) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3576
        !"test3576"
        z1 <== (q-(-q)*2.5/((-2.6)-2.5/(-8.6)*q)/(-p)*(-p))
        z2 <== (y-(-y)*2.5/((-2.6)-2.5/(-8.6)*y)/(-x)*(-x))
        print.cccc (I 3576) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3577
        !"test3577"
        z1 <== (q*(-6.5)-4.7-q-(-q)*q+1.1*(-q)+(-4.7)*((-5.5))-((-7.5))/(-4.8)+p)
        z2 <== (y*(-6.5)-4.7-y-(-y)*y+1.1*(-y)+(-4.7)*((-5.5))-((-7.5))/(-4.8)+x)
        print.cccc (I 3577) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3578
        !"test3578"
        z1 <== ((p)*((-p)+7.1-3.8*(-1.4)/(-2.5)))-((-p))+(-p)/q-q*(-8.0)
        z2 <== ((x)*((-x)+7.1-3.8*(-1.4)/(-2.5)))-((-x))+(-x)/y-y*(-8.0)
        print.cccc (I 3578) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3579
        !"test3579"
        z1 <== ((-0.7))
        z2 <== ((-0.7))
        print.cccc (I 3579) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3580
        !"test3580"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 3580) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3581
        !"test3581"
        z1 <== (q*3.6/0.3)
        z2 <== (y*3.6/0.3)
        print.cccc (I 3581) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3582
        !"test3582"
        z1 <== (-5.6)-p
        z2 <== (-5.6)-x
        print.cccc (I 3582) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3583
        !"test3583"
        z1 <== 0.7*q*(2.0*p*(-p)*3.4)
        z2 <== 0.7*y*(2.0*x*(-x)*3.4)
        print.cccc (I 3583) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3584
        !"test3584"
        z1 <== p
        z2 <== x
        print.cccc (I 3584) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3585
        !"test3585"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 3585) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3586
        !"test3586"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 3586) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3587
        !"test3587"
        z1 <== (-3.7)
        z2 <== (-3.7)
        print.cccc (I 3587) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3588
        !"test3588"
        z1 <== (-p)/((-7.2)*7.4-(-p)+0.7)-((-1.5)+q-(5.7)*q)-(-p)+((-4.8)+(p+(-2.7))*((-4.8)*p+(-q)/q*(-2.0))*(2.0+(-1.0))/(-q))
        z2 <== (-x)/((-7.2)*7.4-(-x)+0.7)-((-1.5)+y-(5.7)*y)-(-x)+((-4.8)+(x+(-2.7))*((-4.8)*x+(-y)/y*(-2.0))*(2.0+(-1.0))/(-y))
        print.cccc (I 3588) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3589
        !"test3589"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 3589) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3590
        !"test3590"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 3590) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3591
        !"test3591"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3591) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3592
        !"test3592"
        z1 <== ((-q)/((q-q/2.4+p)+((-6.8)*(-q)))/7.1)
        z2 <== ((-y)/((y-y/2.4+x)+((-6.8)*(-y)))/7.1)
        print.cccc (I 3592) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3593
        !"test3593"
        z1 <== p
        z2 <== x
        print.cccc (I 3593) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3594
        !"test3594"
        z1 <== p
        z2 <== x
        print.cccc (I 3594) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3595
        !"test3595"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 3595) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3596
        !"test3596"
        z1 <== (((-1.8))/((-2.0)*(6.0)+p-q)*((0.3-(-q)*5.2)))
        z2 <== (((-1.8))/((-2.0)*(6.0)+x-y)*((0.3-(-y)*5.2)))
        print.cccc (I 3596) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3597
        !"test3597"
        z1 <== q
        z2 <== y
        print.cccc (I 3597) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3598
        !"test3598"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3598) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3599
        !"test3599"
        z1 <== q
        z2 <== y
        print.cccc (I 3599) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3600
        !"test3600"
        z1 <== p
        z2 <== x
        print.cccc (I 3600) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3601
        !"test3601"
        z1 <== (q/p-3.3*(-7.7)/q)
        z2 <== (y/x-3.3*(-7.7)/y)
        print.cccc (I 3601) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3602
        !"test3602"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 3602) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3603
        !"test3603"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 3603) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3604
        !"test3604"
        z1 <== p
        z2 <== x
        print.cccc (I 3604) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3605
        !"test3605"
        z1 <== ((-q)-q-(-0.2)-(p+q))
        z2 <== ((-y)-y-(-0.2)-(x+y))
        print.cccc (I 3605) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3606
        !"test3606"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 3606) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3607
        !"test3607"
        z1 <== p
        z2 <== x
        print.cccc (I 3607) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3608
        !"test3608"
        z1 <== (2.0*(-6.4)*(p*((-q)*(-p)/(-1.0)+2.0))-((q+q+q-q-6.8)+((-q)*q*(-0.8)-(-q)/q)*p-(-6.4)-(-p)))
        z2 <== (2.0*(-6.4)*(x*((-y)*(-x)/(-1.0)+2.0))-((y+y+y-y-6.8)+((-y)*y*(-0.8)-(-y)/y)*x-(-6.4)-(-x)))
        print.cccc (I 3608) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3609
        !"test3609"
        z1 <== (-p)+(p-(-2.5)*(-p)*(8.4)+(-8.8))+((-p)*(-0.5)/p)*8.7+((8.4/p)/(-7.4)+(-q)*(q-4.0*p))
        z2 <== (-x)+(x-(-2.5)*(-x)*(8.4)+(-8.8))+((-x)*(-0.5)/x)*8.7+((8.4/x)/(-7.4)+(-y)*(y-4.0*x))
        print.cccc (I 3609) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3610
        !"test3610"
        z1 <== (((-q)+q*(-q)+3.0*(-6.7)/(-1.0)*p/(-q)))
        z2 <== (((-y)+y*(-y)+3.0*(-6.7)/(-1.0)*x/(-y)))
        print.cccc (I 3610) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3611
        !"test3611"
        z1 <== ((((-1.5)*(-8.8)+(-0.4)*(-p))/1.3*(-q)-((-q)/(-0.4)))*(1.0/(-q)+(-p)-7.7+4.3-(-q)))
        z2 <== ((((-1.5)*(-8.8)+(-0.4)*(-x))/1.3*(-y)-((-y)/(-0.4)))*(1.0/(-y)+(-x)-7.7+4.3-(-y)))
        print.cccc (I 3611) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3612
        !"test3612"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 3612) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3613
        !"test3613"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3613) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3614
        !"test3614"
        z1 <== ((2.2)/(q-((-8.0))/((-p)-4.6-(-q)*p-(-q)))-(-q))
        z2 <== ((2.2)/(y-((-8.0))/((-x)-4.6-(-y)*x-(-y)))-(-y))
        print.cccc (I 3614) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3615
        !"test3615"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 3615) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3616
        !"test3616"
        z1 <== (((-1.0)*q/3.5/p*p)+p/0.1*q)-(-q)-(-5.7)/((8.0+(-6.3)*p/(-q)-(-q)))
        z2 <== (((-1.0)*y/3.5/x*x)+x/0.1*y)-(-y)-(-5.7)/((8.0+(-6.3)*x/(-y)-(-y)))
        print.cccc (I 3616) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3617
        !"test3617"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 3617) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3618
        !"test3618"
        z1 <== (((2.6/q+5.0+(-q)+p)*(-q)))
        z2 <== (((2.6/y+5.0+(-y)+x)*(-y)))
        print.cccc (I 3618) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3619
        !"test3619"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 3619) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3620
        !"test3620"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 3620) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3621
        !"test3621"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 3621) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3622
        !"test3622"
        z1 <== (-6.5)
        z2 <== (-6.5)
        print.cccc (I 3622) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3623
        !"test3623"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 3623) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3624
        !"test3624"
        z1 <== ((7.7-(-4.0)+(q/p/p/q/(-q))*((-p)-q*p)))
        z2 <== ((7.7-(-4.0)+(y/x/x/y/(-y))*((-x)-y*x)))
        print.cccc (I 3624) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3625
        !"test3625"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 3625) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3626
        !"test3626"
        z1 <== (4.0+(-1.1)+((-0.0)-(q*5.8-(-p)+q)-(-q))-6.4/(-7.2))
        z2 <== (4.0+(-1.1)+((-0.0)-(y*5.8-(-x)+y)-(-y))-6.4/(-7.2))
        print.cccc (I 3626) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3627
        !"test3627"
        z1 <== 4.5*4.2*(-p)+((7.2))+((-7.8))/(((-7.1)*7.6)*3.0+(-p)-((-1.8)-(-1.7)*(-8.0)*2.0))
        z2 <== 4.5*4.2*(-x)+((7.2))+((-7.8))/(((-7.1)*7.6)*3.0+(-x)-((-1.8)-(-1.7)*(-8.0)*2.0))
        print.cccc (I 3627) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3628
        !"test3628"
        z1 <== ((-q)+((-q)*(1.2-q+(-1.8)-(-2.6)-(-p))-(-1.6)/(-1.5))*((-p)/(-p)-q/(-4.7)/(-p)+p-(2.7/(-3.3)*3.3-(-p))*7.0+6.7-(-3.8)/q-0.0*((-q)-q*2.8/8.6/p))*(-4.8))
        z2 <== ((-y)+((-y)*(1.2-y+(-1.8)-(-2.6)-(-x))-(-1.6)/(-1.5))*((-x)/(-x)-y/(-4.7)/(-x)+x-(2.7/(-3.3)*3.3-(-x))*7.0+6.7-(-3.8)/y-0.0*((-y)-y*2.8/8.6/x))*(-4.8))
        print.cccc (I 3628) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3629
        !"test3629"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3629) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3630
        !"test3630"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 3630) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3631
        !"test3631"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3631) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3632
        !"test3632"
        z1 <== ((-5.0)/3.2/(-0.8)-(-q))
        z2 <== ((-5.0)/3.2/(-0.8)-(-y))
        print.cccc (I 3632) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3633
        !"test3633"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 3633) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3634
        !"test3634"
        z1 <== ((q)/(-p)*(-q)-((p+q)-2.5+(7.3)))
        z2 <== ((y)/(-x)*(-y)-((x+y)-2.5+(7.3)))
        print.cccc (I 3634) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3635
        !"test3635"
        z1 <== 3.3
        z2 <== 3.3
        print.cccc (I 3635) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3636
        !"test3636"
        z1 <== ((p)/6.1+q+((-5.1)+6.4+6.7+6.5*3.2)*(-p)/(1.2/(-3.4))*((-p)/5.3*(-q)*(4.3/(-p)-(-p)*(-5.8)))-((-6.0)*((-8.8)*(-p))))
        z2 <== ((x)/6.1+y+((-5.1)+6.4+6.7+6.5*3.2)*(-x)/(1.2/(-3.4))*((-x)/5.3*(-y)*(4.3/(-x)-(-x)*(-5.8)))-((-6.0)*((-8.8)*(-x))))
        print.cccc (I 3636) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3637
        !"test3637"
        z1 <== ((q*p*((-p))+(p)-p*5.7/(-q))+(4.2*q)*((8.7-3.8-(-0.2)+3.4)-(-p)))
        z2 <== ((y*x*((-x))+(x)-x*5.7/(-y))+(4.2*y)*((8.7-3.8-(-0.2)+3.4)-(-x)))
        print.cccc (I 3637) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3638
        !"test3638"
        z1 <== ((1.4+(-5.8)-(-p)-(-q))/0.6/q+(3.5/(-q)/1.0-3.5/p)+(4.8+5.8/p*(-q)))/(-7.5)-5.8/((1.0+3.5-(-q))/(-p)-((-3.3))+((-3.0)))*(-q)
        z2 <== ((1.4+(-5.8)-(-x)-(-y))/0.6/y+(3.5/(-y)/1.0-3.5/x)+(4.8+5.8/x*(-y)))/(-7.5)-5.8/((1.0+3.5-(-y))/(-x)-((-3.3))+((-3.0)))*(-y)
        print.cccc (I 3638) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3639
        !"test3639"
        z1 <== (p-(-p)-((-q)*p)/(q-(-q)+2.7))*(-p)/(8.4-(-q)/(p/(-p)-p)-(-3.5))-(((-5.6)*(-7.8)*6.4*(-3.2))-p)-(-q)
        z2 <== (x-(-x)-((-y)*x)/(y-(-y)+2.7))*(-x)/(8.4-(-y)/(x/(-x)-x)-(-3.5))-(((-5.6)*(-7.8)*6.4*(-3.2))-x)-(-y)
        print.cccc (I 3639) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3640
        !"test3640"
        z1 <== (q*q-(-2.6)+(4.7)*((-0.4)/q/(-q)*(p)*(q/6.7*0.5)))
        z2 <== (y*y-(-2.6)+(4.7)*((-0.4)/y/(-y)*(x)*(y/6.7*0.5)))
        print.cccc (I 3640) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3641
        !"test3641"
        z1 <== (0.5+((-q))/(p-(-q)*p)-(-p)*(7.3+(-7.6)*q/(-8.8)-p))
        z2 <== (0.5+((-y))/(x-(-y)*x)-(-x)*(7.3+(-7.6)*y/(-8.8)-x))
        print.cccc (I 3641) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3642
        !"test3642"
        z1 <== (p/(-p))
        z2 <== (x/(-x))
        print.cccc (I 3642) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3643
        !"test3643"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3643) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3644
        !"test3644"
        z1 <== ((4.6/(6.5+(-1.7))/5.8*((-q))-(-0.6))-(-p)-p+(-6.0)-(-p)*(q)-(-1.3)-(5.2)+((-6.7)/((-6.1)*8.0*0.1-1.4/8.1)+p-q))
        z2 <== ((4.6/(6.5+(-1.7))/5.8*((-y))-(-0.6))-(-x)-x+(-6.0)-(-x)*(y)-(-1.3)-(5.2)+((-6.7)/((-6.1)*8.0*0.1-1.4/8.1)+x-y))
        print.cccc (I 3644) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3645
        !"test3645"
        z1 <== (((2.3-(-6.8))+((-4.0)*p-(-p)+(-1.1)*q)+((-7.6)/(-p)+0.7-(-q)+(-q))/2.6*(p/(-8.3)))/((-5.3)*(-q)*(-p)-1.1/0.2*(q+(-0.3)+(-3.2))-6.0*((-p)/(-q)-p-(-p)/(-4.7)))-(-2.7)*(((-q)-(-0.2)*(-p)/q+2.1)+(-p)/(1.6-p-(-2.6)/(-p))-(-8.7))/((-p)/(q)*((-p)-3.3)-0.5))
        z2 <== (((2.3-(-6.8))+((-4.0)*x-(-x)+(-1.1)*y)+((-7.6)/(-x)+0.7-(-y)+(-y))/2.6*(x/(-8.3)))/((-5.3)*(-y)*(-x)-1.1/0.2*(y+(-0.3)+(-3.2))-6.0*((-x)/(-y)-x-(-x)/(-4.7)))-(-2.7)*(((-y)-(-0.2)*(-x)/y+2.1)+(-x)/(1.6-x-(-2.6)/(-x))-(-8.7))/((-x)/(y)*((-x)-3.3)-0.5))
        print.cccc (I 3645) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3646
        !"test3646"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 3646) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3647
        !"test3647"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 3647) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3648
        !"test3648"
        z1 <== q
        z2 <== y
        print.cccc (I 3648) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3649
        !"test3649"
        z1 <== (-p)/(-3.2)-(-p)/6.2+8.3/((q/(-0.2)/(-q)+7.6)*((-q)*4.3*p*(-q)+(-q))-2.7-(-5.7))-(8.1*1.8/(-8.6)-3.5+(-0.8))
        z2 <== (-x)/(-3.2)-(-x)/6.2+8.3/((y/(-0.2)/(-y)+7.6)*((-y)*4.3*x*(-y)+(-y))-2.7-(-5.7))-(8.1*1.8/(-8.6)-3.5+(-0.8))
        print.cccc (I 3649) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3650
        !"test3650"
        z1 <== ((q-p*(-5.6)*(q))*(-p)*(p+p*(-p)-(-0.3)*2.2/p/(-p)*(-q)-(-q))-(((-p)/p/7.8+q/(-q))/(p)))
        z2 <== ((y-x*(-5.6)*(y))*(-x)*(x+x*(-x)-(-0.3)*2.2/x/(-x)*(-y)-(-y))-(((-x)/x/7.8+y/(-y))/(x)))
        print.cccc (I 3650) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3651
        !"test3651"
        z1 <== (((-p)*(q)*((-q)*(-0.1)/(-1.7)-5.7)/((-0.5))*(-0.8))-(-1.0)-(0.5)/(-q)-(5.7+((-4.8))))
        z2 <== (((-x)*(y)*((-y)*(-0.1)/(-1.7)-5.7)/((-0.5))*(-0.8))-(-1.0)-(0.5)/(-y)-(5.7+((-4.8))))
        print.cccc (I 3651) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3652
        !"test3652"
        z1 <== (q-(((-p)*(-8.8)-q)))
        z2 <== (y-(((-x)*(-8.8)-y)))
        print.cccc (I 3652) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3653
        !"test3653"
        z1 <== ((8.4-q))
        z2 <== ((8.4-y))
        print.cccc (I 3653) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3654
        !"test3654"
        z1 <== (6.8+(-8.7)/((2.7+p)/((-3.4))/q+((-0.5)))*(p-(-p)/q*p*(-p)*(-p)))
        z2 <== (6.8+(-8.7)/((2.7+x)/((-3.4))/y+((-0.5)))*(x-(-x)/y*x*(-x)*(-x)))
        print.cccc (I 3654) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3655
        !"test3655"
        z1 <== 0.6+(5.6*(-p)-3.7/(7.5/p/q+5.8))-(-q)+(-q)
        z2 <== 0.6+(5.6*(-x)-3.7/(7.5/x/y+5.8))-(-y)+(-y)
        print.cccc (I 3655) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3656
        !"test3656"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3656) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3657
        !"test3657"
        z1 <== p
        z2 <== x
        print.cccc (I 3657) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3658
        !"test3658"
        z1 <== (((5.1+(-4.4)-(-q)*2.4/q)+(2.6/(-q))))
        z2 <== (((5.1+(-4.4)-(-y)*2.4/y)+(2.6/(-y))))
        print.cccc (I 3658) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3659
        !"test3659"
        z1 <== ((-6.4)-((-7.0)/(0.6+(-6.5)/p)+6.7+(-q)))
        z2 <== ((-6.4)-((-7.0)/(0.6+(-6.5)/x)+6.7+(-y)))
        print.cccc (I 3659) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3660
        !"test3660"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3660) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3661
        !"test3661"
        z1 <== (((-8.8)-2.2/q*(-7.2)-(-2.8)/q-q)+8.0/(-1.3)/p)
        z2 <== (((-8.8)-2.2/y*(-7.2)-(-2.8)/y-y)+8.0/(-1.3)/x)
        print.cccc (I 3661) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3662
        !"test3662"
        z1 <== (((-7.0)*(q-7.8/(-3.8)/p)*(q-5.3)+q-q-(-8.3)+q)-((p-(-3.7)*(-8.0))*(-q))-(4.1*(-q))*5.0*((-p)+(-p)/0.2-(-3.7)*(-7.6)))
        z2 <== (((-7.0)*(y-7.8/(-3.8)/x)*(y-5.3)+y-y-(-8.3)+y)-((x-(-3.7)*(-8.0))*(-y))-(4.1*(-y))*5.0*((-x)+(-x)/0.2-(-3.7)*(-7.6)))
        print.cccc (I 3662) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3663
        !"test3663"
        z1 <== ((p+(0.0*3.0*(-p)*(-1.4))/q)/1.4)
        z2 <== ((x+(0.0*3.0*(-x)*(-1.4))/y)/1.4)
        print.cccc (I 3663) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3664
        !"test3664"
        z1 <== ((-7.1)*(((-q)*q*(-3.4)+(-7.1)*p)*(-3.6)/1.7/((-1.0)))+q-((-8.8)-(5.6-(-3.6)*p)-0.0)+1.5)
        z2 <== ((-7.1)*(((-y)*y*(-3.4)+(-7.1)*x)*(-3.6)/1.7/((-1.0)))+y-((-8.8)-(5.6-(-3.6)*x)-0.0)+1.5)
        print.cccc (I 3664) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3665
        !"test3665"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 3665) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3666
        !"test3666"
        z1 <== (p-8.5*(-p)/p)+((-p)*(-q)*(-3.8)+7.3/p)/(-p)
        z2 <== (x-8.5*(-x)/x)+((-x)*(-y)*(-3.8)+7.3/x)/(-x)
        print.cccc (I 3666) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3667
        !"test3667"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3667) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3668
        !"test3668"
        z1 <== ((0.5)-((-p)-3.6-(-p))+7.0-p*p+(-p))
        z2 <== ((0.5)-((-x)-3.6-(-x))+7.0-x*x+(-x))
        print.cccc (I 3668) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3669
        !"test3669"
        z1 <== (-3.2)
        z2 <== (-3.2)
        print.cccc (I 3669) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3670
        !"test3670"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3670) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3671
        !"test3671"
        z1 <== (((-0.0)+(-p))+(-q)*(-7.7)*(-5.8)+(-q)/8.8/(-5.3)*q+4.3-((-q)/(-6.2))*q/(-q))
        z2 <== (((-0.0)+(-x))+(-y)*(-7.7)*(-5.8)+(-y)/8.8/(-5.3)*y+4.3-((-y)/(-6.2))*y/(-y))
        print.cccc (I 3671) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3672
        !"test3672"
        z1 <== (-8.0)/3.6
        z2 <== (-8.0)/3.6
        print.cccc (I 3672) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3673
        !"test3673"
        z1 <== q
        z2 <== y
        print.cccc (I 3673) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3674
        !"test3674"
        z1 <== 0.4
        z2 <== 0.4
        print.cccc (I 3674) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3675
        !"test3675"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 3675) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3676
        !"test3676"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 3676) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3677
        !"test3677"
        z1 <== (((-2.4)+p-(-5.4))+q*(-q)*8.4+(-p)+q*(-0.2)+q+7.8+(-0.8)/(-4.2)-(-6.7)*0.3*8.4+(-p))
        z2 <== (((-2.4)+x-(-5.4))+y*(-y)*8.4+(-x)+y*(-0.2)+y+7.8+(-0.8)/(-4.2)-(-6.7)*0.3*8.4+(-x))
        print.cccc (I 3677) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3678
        !"test3678"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 3678) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3679
        !"test3679"
        z1 <== 1.1
        z2 <== 1.1
        print.cccc (I 3679) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3680
        !"test3680"
        z1 <== (((2.8)*(-3.1)*7.6)*(-8.7)*(q-((-0.6)/7.5*q*(-7.5)+2.4)/(-q)*q+1.5*(-6.0)+q)+(((-q))))
        z2 <== (((2.8)*(-3.1)*7.6)*(-8.7)*(y-((-0.6)/7.5*y*(-7.5)+2.4)/(-y)*y+1.5*(-6.0)+y)+(((-y))))
        print.cccc (I 3680) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3681
        !"test3681"
        z1 <== (((q+q*p)-((-8.8))-(1.2/2.1)/((-q)/(-5.3))/4.4)+((-p)/(6.1*2.2+5.5-(-7.0)))-7.4)
        z2 <== (((y+y*x)-((-8.8))-(1.2/2.1)/((-y)/(-5.3))/4.4)+((-x)/(6.1*2.2+5.5-(-7.0)))-7.4)
        print.cccc (I 3681) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3682
        !"test3682"
        z1 <== ((-7.4)+(-q))/(8.3-6.8*5.1-p)-(p)+((p/4.5)-((-q)/7.5*(-0.3)))
        z2 <== ((-7.4)+(-y))/(8.3-6.8*5.1-x)-(x)+((x/4.5)-((-y)/7.5*(-0.3)))
        print.cccc (I 3682) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3683
        !"test3683"
        z1 <== ((q/p/(-1.3)*(-0.2)+(-q)))+(-p)-8.7/((-p)-2.4-6.8)
        z2 <== ((y/x/(-1.3)*(-0.2)+(-y)))+(-x)-8.7/((-x)-2.4-6.8)
        print.cccc (I 3683) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3684
        !"test3684"
        z1 <== (6.3/3.6+(-5.0)*(-4.5)/(-p))-2.5-(-q)-(-4.1)*1.6/q
        z2 <== (6.3/3.6+(-5.0)*(-4.5)/(-x))-2.5-(-y)-(-4.1)*1.6/y
        print.cccc (I 3684) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3685
        !"test3685"
        z1 <== (-7.0)-q
        z2 <== (-7.0)-y
        print.cccc (I 3685) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3686
        !"test3686"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 3686) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3687
        !"test3687"
        z1 <== p
        z2 <== x
        print.cccc (I 3687) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3688
        !"test3688"
        z1 <== ((-0.5)-(7.1*p/((-p))-(-7.4))*q+((-4.0)+(-q)*(1.8-p-q)/q-2.6/(-0.1)))
        z2 <== ((-0.5)-(7.1*x/((-x))-(-7.4))*y+((-4.0)+(-y)*(1.8-x-y)/y-2.6/(-0.1)))
        print.cccc (I 3688) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3689
        !"test3689"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3689) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3690
        !"test3690"
        z1 <== ((-p)+(-7.8))
        z2 <== ((-x)+(-7.8))
        print.cccc (I 3690) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3691
        !"test3691"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3691) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3692
        !"test3692"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 3692) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3693
        !"test3693"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3693) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3694
        !"test3694"
        z1 <== (((-7.6)*p)+q/((0.2-(-q)*p+4.3+(-0.6))-(-3.0)/(-0.2)-(-p)-(-q)-(-q)/2.7*((-0.2)/(-0.3)*q*0.2))*(-7.7)*((-p)/4.5)/(-q)/(-8.1)/(-p))
        z2 <== (((-7.6)*x)+y/((0.2-(-y)*x+4.3+(-0.6))-(-3.0)/(-0.2)-(-x)-(-y)-(-y)/2.7*((-0.2)/(-0.3)*y*0.2))*(-7.7)*((-x)/4.5)/(-y)/(-8.1)/(-x))
        print.cccc (I 3694) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3695
        !"test3695"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 3695) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3696
        !"test3696"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3696) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3697
        !"test3697"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 3697) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3698
        !"test3698"
        z1 <== (((-q))/q*3.1)
        z2 <== (((-y))/y*3.1)
        print.cccc (I 3698) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3699
        !"test3699"
        z1 <== q
        z2 <== y
        print.cccc (I 3699) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3700
        !"test3700"
        z1 <== p
        z2 <== x
        print.cccc (I 3700) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3701
        !"test3701"
        z1 <== (-4.1)-q/(-1.0)/p+(-2.2)*(-p)+(1.5*3.2)
        z2 <== (-4.1)-y/(-1.0)/x+(-2.2)*(-x)+(1.5*3.2)
        print.cccc (I 3701) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3702
        !"test3702"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 3702) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3703
        !"test3703"
        z1 <== ((-p)+(((-q)/(-q)+(-p))*(q*(-p)*(-3.0))*(7.8/(-p)-(-p)))-3.0)
        z2 <== ((-x)+(((-y)/(-y)+(-x))*(y*(-x)*(-3.0))*(7.8/(-x)-(-x)))-3.0)
        print.cccc (I 3703) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3704
        !"test3704"
        z1 <== q
        z2 <== y
        print.cccc (I 3704) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3705
        !"test3705"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3705) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3706
        !"test3706"
        z1 <== ((8.6-(-1.0)+((-q)/q-q+(-8.6)*(-p)))/(-q)/(q+((-p))/(q*(-3.4)+(-1.4)/(-q)))/(5.8*p))
        z2 <== ((8.6-(-1.0)+((-y)/y-y+(-8.6)*(-x)))/(-y)/(y+((-x))/(y*(-3.4)+(-1.4)/(-y)))/(5.8*x))
        print.cccc (I 3706) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3707
        !"test3707"
        z1 <== (1.0)
        z2 <== (1.0)
        print.cccc (I 3707) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3708
        !"test3708"
        z1 <== (-p)+(-q)*q-p
        z2 <== (-x)+(-y)*y-x
        print.cccc (I 3708) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3709
        !"test3709"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 3709) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3710
        !"test3710"
        z1 <== p
        z2 <== x
        print.cccc (I 3710) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3711
        !"test3711"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3711) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3712
        !"test3712"
        z1 <== (p/p*((-p)+(-6.7)+(-p))*7.1/(q*(-8.1)-4.3)*((-1.7)*(-8.6))/(-1.2)+(-1.4)-(-q)+(-0.0)-(-5.2)+6.3/((-5.3)*(-q)*2.5/(-q)+5.0+q))
        z2 <== (x/x*((-x)+(-6.7)+(-x))*7.1/(y*(-8.1)-4.3)*((-1.7)*(-8.6))/(-1.2)+(-1.4)-(-y)+(-0.0)-(-5.2)+6.3/((-5.3)*(-y)*2.5/(-y)+5.0+y))
        print.cccc (I 3712) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3713
        !"test3713"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 3713) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3714
        !"test3714"
        z1 <== p
        z2 <== x
        print.cccc (I 3714) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3715
        !"test3715"
        z1 <== q
        z2 <== y
        print.cccc (I 3715) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3716
        !"test3716"
        z1 <== (3.2-7.3-p-7.5)
        z2 <== (3.2-7.3-x-7.5)
        print.cccc (I 3716) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3717
        !"test3717"
        z1 <== (1.3/((-q)-4.2-(5.7/6.8)))
        z2 <== (1.3/((-y)-4.2-(5.7/6.8)))
        print.cccc (I 3717) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3718
        !"test3718"
        z1 <== ((q/((-p)+(-4.0)/0.2)/(-3.8)/(-p)*(p+p/0.4/(-8.5))))
        z2 <== ((y/((-x)+(-4.0)/0.2)/(-3.8)/(-x)*(x+x/0.4/(-8.5))))
        print.cccc (I 3718) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3719
        !"test3719"
        z1 <== ((q+p*(-4.8)-(-5.0))/(-q)+(-0.2))
        z2 <== ((y+x*(-4.8)-(-5.0))/(-y)+(-0.2))
        print.cccc (I 3719) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3720
        !"test3720"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3720) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3721
        !"test3721"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 3721) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3722
        !"test3722"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3722) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3723
        !"test3723"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 3723) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3724
        !"test3724"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3724) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3725
        !"test3725"
        z1 <== (6.6-8.4)
        z2 <== (6.6-8.4)
        print.cccc (I 3725) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3726
        !"test3726"
        z1 <== (q/(8.4-5.7/p-(-5.4)*(-3.0))-q/(-7.7)/((-6.4)-q*7.7))
        z2 <== (y/(8.4-5.7/x-(-5.4)*(-3.0))-y/(-7.7)/((-6.4)-y*7.7))
        print.cccc (I 3726) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3727
        !"test3727"
        z1 <== p
        z2 <== x
        print.cccc (I 3727) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3728
        !"test3728"
        z1 <== 2.3
        z2 <== 2.3
        print.cccc (I 3728) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3729
        !"test3729"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3729) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3730
        !"test3730"
        z1 <== ((-p)+(-6.2)*((0.6*(-p)+(-7.1))/(-2.5)*p/q-(-q)*(-2.7)-(p/(-q)+p/p*(-p))+p))
        z2 <== ((-x)+(-6.2)*((0.6*(-x)+(-7.1))/(-2.5)*x/y-(-y)*(-2.7)-(x/(-y)+x/x*(-x))+x))
        print.cccc (I 3730) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3731
        !"test3731"
        z1 <== 4.3*(q)*(((-q)*p-(-q)))-(0.5+q)*(2.5-7.7-1.4-p/(-p))/3.3/(-5.6)
        z2 <== 4.3*(y)*(((-y)*x-(-y)))-(0.5+y)*(2.5-7.7-1.4-x/(-x))/3.3/(-5.6)
        print.cccc (I 3731) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3732
        !"test3732"
        z1 <== ((p*(-p)*(-7.4)+8.2+5.7)/(4.3))+3.3
        z2 <== ((x*(-x)*(-7.4)+8.2+5.7)/(4.3))+3.3
        print.cccc (I 3732) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3733
        !"test3733"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3733) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3734
        !"test3734"
        z1 <== q
        z2 <== y
        print.cccc (I 3734) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3735
        !"test3735"
        z1 <== ((-4.2)-((-p)-(-3.5)+p+2.0*1.7+6.4-6.3/(-2.8)-(-1.3)*q+q))
        z2 <== ((-4.2)-((-x)-(-3.5)+x+2.0*1.7+6.4-6.3/(-2.8)-(-1.3)*y+y))
        print.cccc (I 3735) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3736
        !"test3736"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 3736) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3737
        !"test3737"
        z1 <== q
        z2 <== y
        print.cccc (I 3737) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3738
        !"test3738"
        z1 <== q
        z2 <== y
        print.cccc (I 3738) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3739
        !"test3739"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 3739) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3740
        !"test3740"
        z1 <== ((-p)-((0.6-(-q)+7.1)/2.2+4.4/3.4/((-4.8)+q))/(((-p)*(-q)*q))-(-8.4))
        z2 <== ((-x)-((0.6-(-y)+7.1)/2.2+4.4/3.4/((-4.8)+y))/(((-x)*(-y)*y))-(-8.4))
        print.cccc (I 3740) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3741
        !"test3741"
        z1 <== ((-q)-(q/4.5*0.6*q/p)/(-q)*(2.8/(-q))/((-p)/5.0*(-6.7))-(p/(-6.3)+(7.3/(-q)-5.8)/(-2.1)))
        z2 <== ((-y)-(y/4.5*0.6*y/x)/(-y)*(2.8/(-y))/((-x)/5.0*(-6.7))-(x/(-6.3)+(7.3/(-y)-5.8)/(-2.1)))
        print.cccc (I 3741) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3742
        !"test3742"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 3742) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3743
        !"test3743"
        z1 <== p
        z2 <== x
        print.cccc (I 3743) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3744
        !"test3744"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 3744) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3745
        !"test3745"
        z1 <== ((((-p)+2.7/(-q))-(-3.8))*(p+(2.1)+(-q)/q/q-6.1*(-3.5)-((-1.3)+(-6.4)))/(7.7+(-p)/((-0.8)-(-7.1)+(-q))+(-q)+(-p))+(-8.0)+4.4)
        z2 <== ((((-x)+2.7/(-y))-(-3.8))*(x+(2.1)+(-y)/y/y-6.1*(-3.5)-((-1.3)+(-6.4)))/(7.7+(-x)/((-0.8)-(-7.1)+(-y))+(-y)+(-x))+(-8.0)+4.4)
        print.cccc (I 3745) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3746
        !"test3746"
        z1 <== (((-q))+(1.0-(-7.5)-(p+(-6.1)/(-q)/5.6/(-2.3))-(-2.4)*1.8/(-8.5)*q+8.2)/p)
        z2 <== (((-y))+(1.0-(-7.5)-(x+(-6.1)/(-y)/5.6/(-2.3))-(-2.4)*1.8/(-8.5)*y+8.2)/x)
        print.cccc (I 3746) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3747
        !"test3747"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 3747) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3748
        !"test3748"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 3748) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3749
        !"test3749"
        z1 <== (6.2-(-4.8)*((-3.8)-((-4.7)/(-1.7)/7.2/(-p))))
        z2 <== (6.2-(-4.8)*((-3.8)-((-4.7)/(-1.7)/7.2/(-x))))
        print.cccc (I 3749) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3750
        !"test3750"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3750) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3751
        !"test3751"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3751) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3752
        !"test3752"
        z1 <== (p*((-q))-((-2.4)*q*(-1.6)+(-2.5))-(-2.4)+(5.7*(-4.8)+(-3.5)+1.0/8.1))
        z2 <== (x*((-y))-((-2.4)*y*(-1.6)+(-2.5))-(-2.4)+(5.7*(-4.8)+(-3.5)+1.0/8.1))
        print.cccc (I 3752) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3753
        !"test3753"
        z1 <== ((8.4*(-p))+4.0+(-2.8)+(((-q)/p-(-p)/(-p)/q)-(8.6/(-6.1)+1.3*1.4)-((-q)+0.1*4.3+(-3.3))*(-5.2))-3.1)
        z2 <== ((8.4*(-x))+4.0+(-2.8)+(((-y)/x-(-x)/(-x)/y)-(8.6/(-6.1)+1.3*1.4)-((-y)+0.1*4.3+(-3.3))*(-5.2))-3.1)
        print.cccc (I 3753) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3754
        !"test3754"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3754) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3755
        !"test3755"
        z1 <== (-8.1)
        z2 <== (-8.1)
        print.cccc (I 3755) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3756
        !"test3756"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 3756) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3757
        !"test3757"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3757) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3758
        !"test3758"
        z1 <== 2.0
        z2 <== 2.0
        print.cccc (I 3758) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3759
        !"test3759"
        z1 <== ((-7.3)/((-2.1))+5.3*(3.7))
        z2 <== ((-7.3)/((-2.1))+5.3*(3.7))
        print.cccc (I 3759) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3760
        !"test3760"
        z1 <== ((-p)-0.0+((q-(-1.6)/3.8-q)*(2.2*p-(-p)*p-(-0.3)))+(-p))
        z2 <== ((-x)-0.0+((y-(-1.6)/3.8-y)*(2.2*x-(-x)*x-(-0.3)))+(-x))
        print.cccc (I 3760) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3761
        !"test3761"
        z1 <== (((-q))*8.3/(-7.7))
        z2 <== (((-y))*8.3/(-7.7))
        print.cccc (I 3761) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3762
        !"test3762"
        z1 <== ((((-3.0)-3.0*p/p/2.3)/(8.6-3.8/7.6)))
        z2 <== ((((-3.0)-3.0*x/x/2.3)/(8.6-3.8/7.6)))
        print.cccc (I 3762) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3763
        !"test3763"
        z1 <== q
        z2 <== y
        print.cccc (I 3763) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3764
        !"test3764"
        z1 <== ((0.8)-(-p)*(q/(-p))-(-p))
        z2 <== ((0.8)-(-x)*(y/(-x))-(-x))
        print.cccc (I 3764) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3765
        !"test3765"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 3765) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3766
        !"test3766"
        z1 <== 6.1
        z2 <== 6.1
        print.cccc (I 3766) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3767
        !"test3767"
        z1 <== q
        z2 <== y
        print.cccc (I 3767) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3768
        !"test3768"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 3768) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3769
        !"test3769"
        z1 <== (-1.7)
        z2 <== (-1.7)
        print.cccc (I 3769) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3770
        !"test3770"
        z1 <== (((q)/p))
        z2 <== (((y)/x))
        print.cccc (I 3770) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3771
        !"test3771"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3771) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3772
        !"test3772"
        z1 <== p
        z2 <== x
        print.cccc (I 3772) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3773
        !"test3773"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3773) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3774
        !"test3774"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3774) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3775
        !"test3775"
        z1 <== (6.4)
        z2 <== (6.4)
        print.cccc (I 3775) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3776
        !"test3776"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 3776) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3777
        !"test3777"
        z1 <== ((-q)-2.4+q+(-0.7)*q/(-q)+((-q)/(-5.1)-(-1.2)))+1.8/(-4.5)
        z2 <== ((-y)-2.4+y+(-0.7)*y/(-y)+((-y)/(-5.1)-(-1.2)))+1.8/(-4.5)
        print.cccc (I 3777) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3778
        !"test3778"
        z1 <== ((-q)/6.2)
        z2 <== ((-y)/6.2)
        print.cccc (I 3778) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3779
        !"test3779"
        z1 <== p
        z2 <== x
        print.cccc (I 3779) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3780
        !"test3780"
        z1 <== ((-8.5))
        z2 <== ((-8.5))
        print.cccc (I 3780) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3781
        !"test3781"
        z1 <== (-q)-(-3.7)/(6.4*(-q)-(-p))
        z2 <== (-y)-(-3.7)/(6.4*(-y)-(-x))
        print.cccc (I 3781) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3782
        !"test3782"
        z1 <== (p*(-0.6)/(-q)+(-2.2)/q)
        z2 <== (x*(-0.6)/(-y)+(-2.2)/y)
        print.cccc (I 3782) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3783
        !"test3783"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 3783) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3784
        !"test3784"
        z1 <== ((8.5+p+(-3.3)+(-q)+(-1.1))+(-6.7))/((-6.3)+((-p)+(-q)-(-p))+(8.1/(-3.4))-(-3.2)-6.7)
        z2 <== ((8.5+x+(-3.3)+(-y)+(-1.1))+(-6.7))/((-6.3)+((-x)+(-y)-(-x))+(8.1/(-3.4))-(-3.2)-6.7)
        print.cccc (I 3784) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3785
        !"test3785"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3785) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3786
        !"test3786"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3786) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3787
        !"test3787"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 3787) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3788
        !"test3788"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3788) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3789
        !"test3789"
        z1 <== ((-q)+(0.4*(8.7*(-4.7)/6.8+1.8-(-q))*((-p)/(-3.0)-p+q-p))*(q)/5.6+(-q)*q*2.3/p)
        z2 <== ((-y)+(0.4*(8.7*(-4.7)/6.8+1.8-(-y))*((-x)/(-3.0)-x+y-x))*(y)/5.6+(-y)*y*2.3/x)
        print.cccc (I 3789) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3790
        !"test3790"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 3790) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3791
        !"test3791"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3791) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3792
        !"test3792"
        z1 <== ((-1.2))
        z2 <== ((-1.2))
        print.cccc (I 3792) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3793
        !"test3793"
        z1 <== p
        z2 <== x
        print.cccc (I 3793) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3794
        !"test3794"
        z1 <== (8.2*(((-0.6)-q-(-5.1))+q)+((3.8/5.1+p-(-3.0)-0.4)-(-p)))
        z2 <== (8.2*(((-0.6)-y-(-5.1))+y)+((3.8/5.1+x-(-3.0)-0.4)-(-x)))
        print.cccc (I 3794) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3795
        !"test3795"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3795) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3796
        !"test3796"
        z1 <== ((-1.4)+(q/(-4.5)/p-(-q)-(-3.0)/7.1*(-q))*((q+(-p)+2.3/2.8)*(p/q+(-4.1))+(-q)*((-q)))+(-q))
        z2 <== ((-1.4)+(y/(-4.5)/x-(-y)-(-3.0)/7.1*(-y))*((y+(-x)+2.3/2.8)*(x/y+(-4.1))+(-y)*((-y)))+(-y))
        print.cccc (I 3796) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3797
        !"test3797"
        z1 <== (1.4/((-p)*(-3.4)))
        z2 <== (1.4/((-x)*(-3.4)))
        print.cccc (I 3797) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3798
        !"test3798"
        z1 <== (((-q))*p)/(-q)-6.1-((-p))*6.2
        z2 <== (((-y))*x)/(-y)-6.1-((-x))*6.2
        print.cccc (I 3798) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3799
        !"test3799"
        z1 <== p
        z2 <== x
        print.cccc (I 3799) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3800
        !"test3800"
        z1 <== (((-q)+8.4+(-8.7)*(-5.4)-((-5.3)+(-2.2)*(-1.3)*(-p)*(-1.2))*0.1)+(q*((-2.6))*3.0))
        z2 <== (((-y)+8.4+(-8.7)*(-5.4)-((-5.3)+(-2.2)*(-1.3)*(-x)*(-1.2))*0.1)+(y*((-2.6))*3.0))
        print.cccc (I 3800) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3801
        !"test3801"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3801) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3802
        !"test3802"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3802) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3803
        !"test3803"
        z1 <== ((-7.5))
        z2 <== ((-7.5))
        print.cccc (I 3803) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3804
        !"test3804"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3804) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3805
        !"test3805"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 3805) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3806
        !"test3806"
        z1 <== q
        z2 <== y
        print.cccc (I 3806) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3807
        !"test3807"
        z1 <== p
        z2 <== x
        print.cccc (I 3807) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3808
        !"test3808"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3808) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3809
        !"test3809"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3809) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3810
        !"test3810"
        z1 <== 7.0-(-5.3)+4.8-((-q)/1.6-q-7.3)-(-4.1)-(-0.2)+1.5
        z2 <== 7.0-(-5.3)+4.8-((-y)/1.6-y-7.3)-(-4.1)-(-0.2)+1.5
        print.cccc (I 3810) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3811
        !"test3811"
        z1 <== ((((-4.0)*(-3.1)+q-8.5+(-2.3))))
        z2 <== ((((-4.0)*(-3.1)+y-8.5+(-2.3))))
        print.cccc (I 3811) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3812
        !"test3812"
        z1 <== (2.3*(-0.6))
        z2 <== (2.3*(-0.6))
        print.cccc (I 3812) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3813
        !"test3813"
        z1 <== (((-2.0)-((-p)*q*(-7.7))+3.2*((-q))))
        z2 <== (((-2.0)-((-x)*y*(-7.7))+3.2*((-y))))
        print.cccc (I 3813) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3814
        !"test3814"
        z1 <== (-7.1)/(-p)/(p*(-q)/p+(-4.0)/2.3)/q+((-q)-0.4)+(-p)*p
        z2 <== (-7.1)/(-x)/(x*(-y)/x+(-4.0)/2.3)/y+((-y)-0.4)+(-x)*x
        print.cccc (I 3814) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3815
        !"test3815"
        z1 <== (((8.6+2.1/(-p)-q)*q/(-q)*(-p)+((-p)+(-p)+6.4/(-q)))+((-q)*(1.3-p/p)-6.6+((-2.0)+q/0.6+2.4/(-7.7)))+(-p))
        z2 <== (((8.6+2.1/(-x)-y)*y/(-y)*(-x)+((-x)+(-x)+6.4/(-y)))+((-y)*(1.3-x/x)-6.6+((-2.0)+y/0.6+2.4/(-7.7)))+(-x))
        print.cccc (I 3815) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3816
        !"test3816"
        z1 <== q
        z2 <== y
        print.cccc (I 3816) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3817
        !"test3817"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3817) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3818
        !"test3818"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 3818) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3819
        !"test3819"
        z1 <== q
        z2 <== y
        print.cccc (I 3819) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3820
        !"test3820"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3820) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3821
        !"test3821"
        z1 <== p
        z2 <== x
        print.cccc (I 3821) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3822
        !"test3822"
        z1 <== q
        z2 <== y
        print.cccc (I 3822) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3823
        !"test3823"
        z1 <== (6.1-((3.7)-p-p*(q/(-q))*(-2.1))*(-7.7)-(((-0.4)*(-8.0)*2.4)-((-8.1)-q*3.7*(-q))-5.0+4.4)+p)
        z2 <== (6.1-((3.7)-x-x*(y/(-y))*(-2.1))*(-7.7)-(((-0.4)*(-8.0)*2.4)-((-8.1)-y*3.7*(-y))-5.0+4.4)+x)
        print.cccc (I 3823) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3824
        !"test3824"
        z1 <== (-5.5)/q*(1.1-(-0.8)-((-q))/(q*(-p)/6.6*(-6.6)/(-5.4)))*8.8+(-7.3)
        z2 <== (-5.5)/y*(1.1-(-0.8)-((-y))/(y*(-x)/6.6*(-6.6)/(-5.4)))*8.8+(-7.3)
        print.cccc (I 3824) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3825
        !"test3825"
        z1 <== (p*((0.7*(-0.7)-(-4.2))/(-p)-p)/((2.1/(-q)/8.6)+((-p)*q))/2.2+2.1)
        z2 <== (x*((0.7*(-0.7)-(-4.2))/(-x)-x)/((2.1/(-y)/8.6)+((-x)*y))/2.2+2.1)
        print.cccc (I 3825) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3826
        !"test3826"
        z1 <== p
        z2 <== x
        print.cccc (I 3826) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3827
        !"test3827"
        z1 <== (p*(p-(-5.2)+(-p)))*(-4.4)
        z2 <== (x*(x-(-5.2)+(-x)))*(-4.4)
        print.cccc (I 3827) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3828
        !"test3828"
        z1 <== ((2.8-(7.2-(-q)+p+p)+(-q)))
        z2 <== ((2.8-(7.2-(-y)+x+x)+(-y)))
        print.cccc (I 3828) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3829
        !"test3829"
        z1 <== p
        z2 <== x
        print.cccc (I 3829) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3830
        !"test3830"
        z1 <== (-0.2)-(-3.3)+(8.7/4.0*3.0+(-p)/(-p))+6.7/(2.3+(-0.8)/1.0)+(-p)-(8.0+(-q)*0.6/(-q)/(q))
        z2 <== (-0.2)-(-3.3)+(8.7/4.0*3.0+(-x)/(-x))+6.7/(2.3+(-0.8)/1.0)+(-x)-(8.0+(-y)*0.6/(-y)/(y))
        print.cccc (I 3830) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3831
        !"test3831"
        z1 <== ((4.6/p+(-q)-p+(-q))-p)
        z2 <== ((4.6/x+(-y)-x+(-y))-x)
        print.cccc (I 3831) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3832
        !"test3832"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 3832) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3833
        !"test3833"
        z1 <== ((((-0.8)-(-p)/(-5.3))/(-4.3)+(6.0+2.1)-(-q))+((-4.7)+q*p+(-3.7)*q+0.7-(-p))/((4.1-(-5.7)/(-4.5)-(-p)+p)+((-q))/(-4.3)-p+(-p))-q-(1.4*(-7.4)/(-1.1)+q)-((-2.5)*7.4+q/6.3*6.7)/p)
        z2 <== ((((-0.8)-(-x)/(-5.3))/(-4.3)+(6.0+2.1)-(-y))+((-4.7)+y*x+(-3.7)*y+0.7-(-x))/((4.1-(-5.7)/(-4.5)-(-x)+x)+((-y))/(-4.3)-x+(-x))-y-(1.4*(-7.4)/(-1.1)+y)-((-2.5)*7.4+y/6.3*6.7)/x)
        print.cccc (I 3833) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3834
        !"test3834"
        z1 <== ((0.8*(q+7.8)-((-p))+0.2*(-p))*(-p)*(8.5)*(p-((-0.2)/(-q)-6.5)))
        z2 <== ((0.8*(y+7.8)-((-x))+0.2*(-x))*(-x)*(8.5)*(x-((-0.2)/(-y)-6.5)))
        print.cccc (I 3834) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3835
        !"test3835"
        z1 <== p
        z2 <== x
        print.cccc (I 3835) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3836
        !"test3836"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3836) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3837
        !"test3837"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 3837) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3838
        !"test3838"
        z1 <== (7.3-((-q)*((-6.8)+p*(-6.5)+(-p)-5.7))*3.4*4.1+(-5.7)-(3.1-7.6-6.1)/p)
        z2 <== (7.3-((-y)*((-6.8)+x*(-6.5)+(-x)-5.7))*3.4*4.1+(-5.7)-(3.1-7.6-6.1)/x)
        print.cccc (I 3838) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3839
        !"test3839"
        z1 <== ((-1.7)+(1.8-p-((-7.6)*p+1.1-(-8.0)-p))/(-2.2)*((-6.1)-(-q)))
        z2 <== ((-1.7)+(1.8-x-((-7.6)*x+1.1-(-8.0)-x))/(-2.2)*((-6.1)-(-y)))
        print.cccc (I 3839) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3840
        !"test3840"
        z1 <== p
        z2 <== x
        print.cccc (I 3840) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3841
        !"test3841"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 3841) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3842
        !"test3842"
        z1 <== (4.8+((-q)/6.3)+(p)/0.5*p)
        z2 <== (4.8+((-y)/6.3)+(x)/0.5*x)
        print.cccc (I 3842) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3843
        !"test3843"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 3843) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3844
        !"test3844"
        z1 <== (-6.7)
        z2 <== (-6.7)
        print.cccc (I 3844) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3845
        !"test3845"
        z1 <== (q/(-3.5)*(q-((-5.4)/q-(-p))))
        z2 <== (y/(-3.5)*(y-((-5.4)/y-(-x))))
        print.cccc (I 3845) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3846
        !"test3846"
        z1 <== ((-2.4)*((-1.1)-(-2.5)-(-2.6)-(-1.8))-(-p)/((p*(-p)+(-2.7))+((-q))/((-q)-(-5.4)-(-p)/1.2)/((-3.4))-((-q))))
        z2 <== ((-2.4)*((-1.1)-(-2.5)-(-2.6)-(-1.8))-(-x)/((x*(-x)+(-2.7))+((-y))/((-y)-(-5.4)-(-x)/1.2)/((-3.4))-((-y))))
        print.cccc (I 3846) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3847
        !"test3847"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 3847) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3848
        !"test3848"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 3848) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3849
        !"test3849"
        z1 <== (3.1+(-4.0)*(q)-((2.3))-(q-1.7-p+(-0.7))/((-3.2)*5.4/p)+((-4.3)*p+(-q)-(-5.8)+q))
        z2 <== (3.1+(-4.0)*(y)-((2.3))-(y-1.7-x+(-0.7))/((-3.2)*5.4/x)+((-4.3)*x+(-y)-(-5.8)+y))
        print.cccc (I 3849) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3850
        !"test3850"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 3850) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3851
        !"test3851"
        z1 <== ((p-q-(-3.7)-p)-((-0.7)-(-0.1)-(-0.0)-(-q)/(-p)+p+p*(-2.5))*p+p-p)
        z2 <== ((x-y-(-3.7)-x)-((-0.7)-(-0.1)-(-0.0)-(-y)/(-x)+x+x*(-2.5))*x+x-x)
        print.cccc (I 3851) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3852
        !"test3852"
        z1 <== p
        z2 <== x
        print.cccc (I 3852) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3853
        !"test3853"
        z1 <== ((8.4+(-0.3)*(-1.6)*5.6*q*3.3*(-6.1)+(-0.2)/(q))*(-1.5)*(-p)-(p*(-q)/2.7)*((p-(-q)-p+(-q)/(-p))+(p-8.6-(-5.7)*(-6.7)+(-5.2))))
        z2 <== ((8.4+(-0.3)*(-1.6)*5.6*y*3.3*(-6.1)+(-0.2)/(y))*(-1.5)*(-x)-(x*(-y)/2.7)*((x-(-y)-x+(-y)/(-x))+(x-8.6-(-5.7)*(-6.7)+(-5.2))))
        print.cccc (I 3853) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3854
        !"test3854"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 3854) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3855
        !"test3855"
        z1 <== ((p+4.1-(-p)-(-q)+8.5/q+((-q)*(-1.3)/(-7.7)*8.5)+(-q))*0.7/(5.2*(-6.2))+((-0.6)-4.4+p)*p)
        z2 <== ((x+4.1-(-x)-(-y)+8.5/y+((-y)*(-1.3)/(-7.7)*8.5)+(-y))*0.7/(5.2*(-6.2))+((-0.6)-4.4+x)*x)
        print.cccc (I 3855) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3856
        !"test3856"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 3856) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3857
        !"test3857"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 3857) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3858
        !"test3858"
        z1 <== ((4.8/2.4-(-p)/(-p)/1.2*(-0.5))-(-7.0)-(-1.1)*(-7.2)*(-q)*((-q))/(p*(3.4+6.0+p/q/q)+(-4.6)+(q-q+(-p)*(-4.0)/q)))
        z2 <== ((4.8/2.4-(-x)/(-x)/1.2*(-0.5))-(-7.0)-(-1.1)*(-7.2)*(-y)*((-y))/(x*(3.4+6.0+x/y/y)+(-4.6)+(y-y+(-x)*(-4.0)/y)))
        print.cccc (I 3858) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3859
        !"test3859"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 3859) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3860
        !"test3860"
        z1 <== q*(5.4+(-2.4)-(-4.0)+(-4.5)+(-8.5)/p+(-p)-((-q))*(q-q/(-6.6)))+(-q)+((-3.0)+p/(-p)*1.1)
        z2 <== y*(5.4+(-2.4)-(-4.0)+(-4.5)+(-8.5)/x+(-x)-((-y))*(y-y/(-6.6)))+(-y)+((-3.0)+x/(-x)*1.1)
        print.cccc (I 3860) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3861
        !"test3861"
        z1 <== (((-8.3)+3.7)+(-q)/((-p)))-(-5.8)*((q-5.7-(-0.6)/7.6+(-8.4)))+q*(-q)*q*(-q)/p*((-0.2)-q)
        z2 <== (((-8.3)+3.7)+(-y)/((-x)))-(-5.8)*((y-5.7-(-0.6)/7.6+(-8.4)))+y*(-y)*y*(-y)/x*((-0.2)-y)
        print.cccc (I 3861) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3862
        !"test3862"
        z1 <== p
        z2 <== x
        print.cccc (I 3862) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3863
        !"test3863"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3863) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3864
        !"test3864"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 3864) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3865
        !"test3865"
        z1 <== 4.4
        z2 <== 4.4
        print.cccc (I 3865) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3866
        !"test3866"
        z1 <== (-0.1)
        z2 <== (-0.1)
        print.cccc (I 3866) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3867
        !"test3867"
        z1 <== (p-((-4.1)+((-p)-(-8.1)/(-4.3))+(7.6*p*q/(-8.3)/3.0))+((-q)/p)-((p-(-1.5)+(-q))/(q/(-3.6)-q*(-p)/(-3.7))/(2.6-3.5+(-0.8)-(-q)/q))-1.4)
        z2 <== (x-((-4.1)+((-x)-(-8.1)/(-4.3))+(7.6*x*y/(-8.3)/3.0))+((-y)/x)-((x-(-1.5)+(-y))/(y/(-3.6)-y*(-x)/(-3.7))/(2.6-3.5+(-0.8)-(-y)/y))-1.4)
        print.cccc (I 3867) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3868
        !"test3868"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 3868) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3869
        !"test3869"
        z1 <== q-0.8+q
        z2 <== y-0.8+y
        print.cccc (I 3869) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3870
        !"test3870"
        z1 <== ((-8.8)/((-q))*((1.2+q)*((-7.6)))-(-3.2)*5.4/((-p)*4.4-(-q)*(-p))-(p/p-q))
        z2 <== ((-8.8)/((-y))*((1.2+y)*((-7.6)))-(-3.2)*5.4/((-x)*4.4-(-y)*(-x))-(x/x-y))
        print.cccc (I 3870) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3871
        !"test3871"
        z1 <== (q/4.6/((q-p*(-q)+7.6/(-q)))*((-p))/(q/3.8+0.8)+p*((-1.1))/(-4.1)/(p-q*p))
        z2 <== (y/4.6/((y-x*(-y)+7.6/(-y)))*((-x))/(y/3.8+0.8)+x*((-1.1))/(-4.1)/(x-y*x))
        print.cccc (I 3871) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3872
        !"test3872"
        z1 <== ((((-q)))/(-2.5)/p)
        z2 <== ((((-y)))/(-2.5)/x)
        print.cccc (I 3872) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3873
        !"test3873"
        z1 <== ((-p)*(-p))
        z2 <== ((-x)*(-x))
        print.cccc (I 3873) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3874
        !"test3874"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 3874) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3875
        !"test3875"
        z1 <== 1.2
        z2 <== 1.2
        print.cccc (I 3875) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3876
        !"test3876"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3876) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3877
        !"test3877"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 3877) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3878
        !"test3878"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 3878) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3879
        !"test3879"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 3879) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3880
        !"test3880"
        z1 <== (6.5/(-8.5)/(-p))
        z2 <== (6.5/(-8.5)/(-x))
        print.cccc (I 3880) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3881
        !"test3881"
        z1 <== p
        z2 <== x
        print.cccc (I 3881) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3882
        !"test3882"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 3882) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3883
        !"test3883"
        z1 <== ((-p)+((1.6*(-8.3)/(-7.1))+(-p)-(-p)-p+7.5-2.2-(-5.3)-((-q)/(-p)/(-2.5))))
        z2 <== ((-x)+((1.6*(-8.3)/(-7.1))+(-x)-(-x)-x+7.5-2.2-(-5.3)-((-y)/(-x)/(-2.5))))
        print.cccc (I 3883) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3884
        !"test3884"
        z1 <== p
        z2 <== x
        print.cccc (I 3884) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3885
        !"test3885"
        z1 <== q
        z2 <== y
        print.cccc (I 3885) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3886
        !"test3886"
        z1 <== (q*(-p)/((-8.8)+q/3.4-p))
        z2 <== (y*(-x)/((-8.8)+y/3.4-x))
        print.cccc (I 3886) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3887
        !"test3887"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 3887) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3888
        !"test3888"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3888) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3889
        !"test3889"
        z1 <== (-q)/(((-p)-(-q)+(-p)/(-p)+0.5)+(p*(-8.0)*(-8.4))*q+3.5/5.7)+(-2.7)-(-8.6)
        z2 <== (-y)/(((-x)-(-y)+(-x)/(-x)+0.5)+(x*(-8.0)*(-8.4))*y+3.5/5.7)+(-2.7)-(-8.6)
        print.cccc (I 3889) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3890
        !"test3890"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 3890) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3891
        !"test3891"
        z1 <== (((-q)-(-q)*7.7+p*(-8.0)/(q*(-4.3)))*(p/8.1/p/(-1.8)-((-p)))-(-p)-(-4.4)-(-1.3))
        z2 <== (((-y)-(-y)*7.7+x*(-8.0)/(y*(-4.3)))*(x/8.1/x/(-1.8)-((-x)))-(-x)-(-4.4)-(-1.3))
        print.cccc (I 3891) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3892
        !"test3892"
        z1 <== (((2.5*(-p)*q)/((-q)*p+5.3))*(q)*((-p)*p-(-q)-q*p)*6.4)
        z2 <== (((2.5*(-x)*y)/((-y)*x+5.3))*(y)*((-x)*x-(-y)-y*x)*6.4)
        print.cccc (I 3892) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3893
        !"test3893"
        z1 <== ((4.6))
        z2 <== ((4.6))
        print.cccc (I 3893) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3894
        !"test3894"
        z1 <== ((-1.0)*(-p))-((4.6+(-q)/6.7+1.7-(-7.3))/(q/4.0-(-2.7)+1.0/p)+(-q)-(-7.2)/1.1)-(5.4+(p*(-8.1))/5.7)/(-0.1)/p
        z2 <== ((-1.0)*(-x))-((4.6+(-y)/6.7+1.7-(-7.3))/(y/4.0-(-2.7)+1.0/x)+(-y)-(-7.2)/1.1)-(5.4+(x*(-8.1))/5.7)/(-0.1)/x
        print.cccc (I 3894) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3895
        !"test3895"
        z1 <== p
        z2 <== x
        print.cccc (I 3895) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3896
        !"test3896"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 3896) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3897
        !"test3897"
        z1 <== ((-0.0)+((1.0/(-3.0)/6.0)-((-4.5)*(-4.4)+p*(-q)+p))/((-q))/(1.5)/(((-p)+(-q))-(2.6)*(-4.6)*(4.8*p*(-q)*q)*((-q)*p/p/q)))
        z2 <== ((-0.0)+((1.0/(-3.0)/6.0)-((-4.5)*(-4.4)+x*(-y)+x))/((-y))/(1.5)/(((-x)+(-y))-(2.6)*(-4.6)*(4.8*x*(-y)*y)*((-y)*x/x/y)))
        print.cccc (I 3897) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3898
        !"test3898"
        z1 <== ((7.0-7.0/(-p))/(8.5+(-5.1)+p+3.5+8.4))*q/(-8.1)-((2.4*(-q))*(-3.6))*((6.7-p/(-6.3)-8.8)*(-p)*q)
        z2 <== ((7.0-7.0/(-x))/(8.5+(-5.1)+x+3.5+8.4))*y/(-8.1)-((2.4*(-y))*(-3.6))*((6.7-x/(-6.3)-8.8)*(-x)*y)
        print.cccc (I 3898) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3899
        !"test3899"
        z1 <== q
        z2 <== y
        print.cccc (I 3899) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3900
        !"test3900"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3900) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3901
        !"test3901"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 3901) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3902
        !"test3902"
        z1 <== (6.5-5.8/(-6.7))
        z2 <== (6.5-5.8/(-6.7))
        print.cccc (I 3902) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3903
        !"test3903"
        z1 <== ((0.1)+5.1)-4.6+q+(-q)*q
        z2 <== ((0.1)+5.1)-4.6+y+(-y)*y
        print.cccc (I 3903) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3904
        !"test3904"
        z1 <== ((-3.7))
        z2 <== ((-3.7))
        print.cccc (I 3904) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3905
        !"test3905"
        z1 <== (-6.7)-(-7.4)-2.2*(0.7-p/((-q)-1.4)*(p-6.4-(-7.8)+(-p)))*2.8
        z2 <== (-6.7)-(-7.4)-2.2*(0.7-x/((-y)-1.4)*(x-6.4-(-7.8)+(-x)))*2.8
        print.cccc (I 3905) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3906
        !"test3906"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3906) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3907
        !"test3907"
        z1 <== 5.5
        z2 <== 5.5
        print.cccc (I 3907) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3908
        !"test3908"
        z1 <== ((((-q))/(-5.6))/5.7*(-q)*2.4/(-2.7)+q)
        z2 <== ((((-y))/(-5.6))/5.7*(-y)*2.4/(-2.7)+y)
        print.cccc (I 3908) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3909
        !"test3909"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 3909) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3910
        !"test3910"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 3910) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3911
        !"test3911"
        z1 <== (q/(-q)-p*((-p))/0.0*q+(-2.2)-(-q))
        z2 <== (y/(-y)-x*((-x))/0.0*y+(-2.2)-(-y))
        print.cccc (I 3911) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3912
        !"test3912"
        z1 <== ((((-7.3))/((-0.5)-(-2.5)*p+p+(-3.0))*q-((-6.7)+0.2*6.3-(-3.1)*(-1.1))/(-5.5)-0.2/p+(-q)/(-q)))
        z2 <== ((((-7.3))/((-0.5)-(-2.5)*x+x+(-3.0))*y-((-6.7)+0.2*6.3-(-3.1)*(-1.1))/(-5.5)-0.2/x+(-y)/(-y)))
        print.cccc (I 3912) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3913
        !"test3913"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 3913) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3914
        !"test3914"
        z1 <== (-7.3)
        z2 <== (-7.3)
        print.cccc (I 3914) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3915
        !"test3915"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 3915) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3916
        !"test3916"
        z1 <== (3.3*(-2.1)-q/(((-2.1)-(-q)+q/0.7))/p)
        z2 <== (3.3*(-2.1)-y/(((-2.1)-(-y)+y/0.7))/x)
        print.cccc (I 3916) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3917
        !"test3917"
        z1 <== (-1.6)
        z2 <== (-1.6)
        print.cccc (I 3917) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3918
        !"test3918"
        z1 <== (p*(-7.2)+(((-2.6)+q+q)))
        z2 <== (x*(-7.2)+(((-2.6)+y+y)))
        print.cccc (I 3918) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3919
        !"test3919"
        z1 <== ((-5.8)-((1.3-(-6.5)*(-p)/(-3.0)/(-p))+(-6.1)))
        z2 <== ((-5.8)-((1.3-(-6.5)*(-x)/(-3.0)/(-x))+(-6.1)))
        print.cccc (I 3919) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3920
        !"test3920"
        z1 <== (((-p)-p*(-4.3)-((-4.8)*(-0.5)))+(-q)/(((-5.2)/(-3.8)*(-q)-(-1.8)+(-q))))
        z2 <== (((-x)-x*(-4.3)-((-4.8)*(-0.5)))+(-y)/(((-5.2)/(-3.8)*(-y)-(-1.8)+(-y))))
        print.cccc (I 3920) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3921
        !"test3921"
        z1 <== 8.3
        z2 <== 8.3
        print.cccc (I 3921) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3922
        !"test3922"
        z1 <== q
        z2 <== y
        print.cccc (I 3922) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3923
        !"test3923"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3923) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3924
        !"test3924"
        z1 <== (((-q)+q)-(-p)+(-7.7)-0.6+q)/(p+4.6-p+q)*1.0/((p-(-5.4)-4.2-q)*(-q)*(-q)/(-2.4)*q/(7.8*q+(-p)-q*(-5.3)))
        z2 <== (((-y)+y)-(-x)+(-7.7)-0.6+y)/(x+4.6-x+y)*1.0/((x-(-5.4)-4.2-y)*(-y)*(-y)/(-2.4)*y/(7.8*y+(-x)-y*(-5.3)))
        print.cccc (I 3924) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3925
        !"test3925"
        z1 <== p
        z2 <== x
        print.cccc (I 3925) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3926
        !"test3926"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3926) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3927
        !"test3927"
        z1 <== (((-4.1)*2.3-(-q)*(6.5-(-p))))
        z2 <== (((-4.1)*2.3-(-y)*(6.5-(-x))))
        print.cccc (I 3927) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3928
        !"test3928"
        z1 <== ((-q)*q/(p*3.1+(-q))-5.4-(-0.2)/(7.7*(-q)-p*(-4.6)*5.4)*((-q)/p*0.7+(-6.1)-(-q))-(q*(-7.5)/0.8*6.6)*(q+(-6.3)/(-5.0)/p+(-p)+0.3/p+((-q)/6.8+(-6.3)*q*8.7)))
        z2 <== ((-y)*y/(x*3.1+(-y))-5.4-(-0.2)/(7.7*(-y)-x*(-4.6)*5.4)*((-y)/x*0.7+(-6.1)-(-y))-(y*(-7.5)/0.8*6.6)*(y+(-6.3)/(-5.0)/x+(-x)+0.3/x+((-y)/6.8+(-6.3)*y*8.7)))
        print.cccc (I 3928) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3929
        !"test3929"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3929) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3930
        !"test3930"
        z1 <== (((-8.2))/q)
        z2 <== (((-8.2))/y)
        print.cccc (I 3930) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3931
        !"test3931"
        z1 <== (-6.7)
        z2 <== (-6.7)
        print.cccc (I 3931) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3932
        !"test3932"
        z1 <== ((-p)-(-0.2)-(-p)/7.6*(-q)+p*(p-2.4/(-p)+q+(-4.7))+((-8.4)+6.1/q*(-0.8))/(-3.3))
        z2 <== ((-x)-(-0.2)-(-x)/7.6*(-y)+x*(x-2.4/(-x)+y+(-4.7))+((-8.4)+6.1/y*(-0.8))/(-3.3))
        print.cccc (I 3932) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3933
        !"test3933"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3933) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3934
        !"test3934"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3934) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3935
        !"test3935"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 3935) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3936
        !"test3936"
        z1 <== (((-0.0)-(-q))-1.7+q)
        z2 <== (((-0.0)-(-y))-1.7+y)
        print.cccc (I 3936) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3937
        !"test3937"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 3937) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3938
        !"test3938"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3938) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3939
        !"test3939"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3939) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3940
        !"test3940"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 3940) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3941
        !"test3941"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 3941) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3942
        !"test3942"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 3942) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3943
        !"test3943"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 3943) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3944
        !"test3944"
        z1 <== ((-2.8)-0.3+4.8)
        z2 <== ((-2.8)-0.3+4.8)
        print.cccc (I 3944) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3945
        !"test3945"
        z1 <== (((3.5+4.8/(-8.1))-p/((-8.4)-q)+((-q)*8.0)/((-p)))*q*(-p)*(-4.3)-1.5/1.0*((-0.0)*q/(-q)-4.1/(-2.0))-6.2)
        z2 <== (((3.5+4.8/(-8.1))-x/((-8.4)-y)+((-y)*8.0)/((-x)))*y*(-x)*(-4.3)-1.5/1.0*((-0.0)*y/(-y)-4.1/(-2.0))-6.2)
        print.cccc (I 3945) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3946
        !"test3946"
        z1 <== p-7.6*(p/((-q)/0.2)-(-q))+(q+(-1.7)/(-1.6))+5.5
        z2 <== x-7.6*(x/((-y)/0.2)-(-y))+(y+(-1.7)/(-1.6))+5.5
        print.cccc (I 3946) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3947
        !"test3947"
        z1 <== ((((-6.7)+(-7.7)/2.2-2.1/(-1.2))/((-0.0)))+3.0+(3.7+(-0.0)-((-1.5)-1.6/(-2.0)+1.1/(-p))+((-q))))
        z2 <== ((((-6.7)+(-7.7)/2.2-2.1/(-1.2))/((-0.0)))+3.0+(3.7+(-0.0)-((-1.5)-1.6/(-2.0)+1.1/(-x))+((-y))))
        print.cccc (I 3947) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3948
        !"test3948"
        z1 <== q
        z2 <== y
        print.cccc (I 3948) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3949
        !"test3949"
        z1 <== (-1.6)
        z2 <== (-1.6)
        print.cccc (I 3949) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3950
        !"test3950"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3950) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3951
        !"test3951"
        z1 <== (((-p))-7.3*(p*p/(q/(-2.8)/(-p))/2.0)/(-p))
        z2 <== (((-x))-7.3*(x*x/(y/(-2.8)/(-x))/2.0)/(-x))
        print.cccc (I 3951) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3952
        !"test3952"
        z1 <== q
        z2 <== y
        print.cccc (I 3952) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3953
        !"test3953"
        z1 <== (1.2)
        z2 <== (1.2)
        print.cccc (I 3953) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3954
        !"test3954"
        z1 <== ((-p)/(p+1.7-(-2.5))/(q/(-1.5)-(-6.1)*4.6)*(-7.6))
        z2 <== ((-x)/(x+1.7-(-2.5))/(y/(-1.5)-(-6.1)*4.6)*(-7.6))
        print.cccc (I 3954) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3955
        !"test3955"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3955) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3956
        !"test3956"
        z1 <== p
        z2 <== x
        print.cccc (I 3956) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3957
        !"test3957"
        z1 <== (((-q))-((-8.0)+2.6)/(((-p)/(-p)/(-2.7)/(-p))+(-p)/(-4.1)*(-6.5))*(-6.0)*(-p))
        z2 <== (((-y))-((-8.0)+2.6)/(((-x)/(-x)/(-2.7)/(-x))+(-x)/(-4.1)*(-6.5))*(-6.0)*(-x))
        print.cccc (I 3957) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3958
        !"test3958"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3958) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3959
        !"test3959"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 3959) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3960
        !"test3960"
        z1 <== (((-3.6)-3.6)*7.5)
        z2 <== (((-3.6)-3.6)*7.5)
        print.cccc (I 3960) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3961
        !"test3961"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 3961) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3962
        !"test3962"
        z1 <== (3.2+((-8.6)+(-5.5)*(-4.8)*(-p)-(q+(-q)))*q+((q*(-6.2)/0.0/(-6.1)-7.0)+((-q)/(-q))-q-(p+q)-((-6.2))))
        z2 <== (3.2+((-8.6)+(-5.5)*(-4.8)*(-x)-(y+(-y)))*y+((y*(-6.2)/0.0/(-6.1)-7.0)+((-y)/(-y))-y-(x+y)-((-6.2))))
        print.cccc (I 3962) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3963
        !"test3963"
        z1 <== (q/((-3.3))*(0.2/p/5.3*(-q)*q/(-8.8)-(-p)/(-p)*p-(q/p+(-2.2)-2.1+p)*(q))/(p*(-6.5)*5.2-p/1.5-1.2+8.4-(q*5.0+(-5.1)*(-6.7)+(-4.4)))+(p/((-p)+(-q)-6.4-8.7*(-1.6))-((-1.7)/6.1-(-4.3)-3.2/1.0)))
        z2 <== (y/((-3.3))*(0.2/x/5.3*(-y)*y/(-8.8)-(-x)/(-x)*x-(y/x+(-2.2)-2.1+x)*(y))/(x*(-6.5)*5.2-x/1.5-1.2+8.4-(y*5.0+(-5.1)*(-6.7)+(-4.4)))+(x/((-x)+(-y)-6.4-8.7*(-1.6))-((-1.7)/6.1-(-4.3)-3.2/1.0)))
        print.cccc (I 3963) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3964
        !"test3964"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 3964) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3965
        !"test3965"
        z1 <== (7.3)
        z2 <== (7.3)
        print.cccc (I 3965) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3966
        !"test3966"
        z1 <== ((((-q)-(-q)+(-8.7)-(-p)*7.7))+(-q)+(-4.7)-((q+4.1)-(-2.6)-q*((-2.2)/(-8.4)/(-1.1)/3.7+5.5))*((-p)))
        z2 <== ((((-y)-(-y)+(-8.7)-(-x)*7.7))+(-y)+(-4.7)-((y+4.1)-(-2.6)-y*((-2.2)/(-8.4)/(-1.1)/3.7+5.5))*((-x)))
        print.cccc (I 3966) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3967
        !"test3967"
        z1 <== (1.7*q*(-1.1)/q-(-8.2))+(1.7/(-q)-(-p)-(-q)*(-3.3))+(6.8-(-q)-p+3.5)+(-1.2)
        z2 <== (1.7*y*(-1.1)/y-(-8.2))+(1.7/(-y)-(-x)-(-y)*(-3.3))+(6.8-(-y)-x+3.5)+(-1.2)
        print.cccc (I 3967) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3968
        !"test3968"
        z1 <== q
        z2 <== y
        print.cccc (I 3968) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3969
        !"test3969"
        z1 <== q
        z2 <== y
        print.cccc (I 3969) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3970
        !"test3970"
        z1 <== (((-q)/(-p)/2.6+((-q)-(-7.8)))+p-(q+(-3.6)/(-1.7)))
        z2 <== (((-y)/(-x)/2.6+((-y)-(-7.8)))+x-(y+(-3.6)/(-1.7)))
        print.cccc (I 3970) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3971
        !"test3971"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 3971) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3972
        !"test3972"
        z1 <== q
        z2 <== y
        print.cccc (I 3972) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3973
        !"test3973"
        z1 <== (((p+2.0-(-4.1)/(-2.6))+((-p)-(-q)))+6.1+(p)-((q+(-7.5))))
        z2 <== (((x+2.0-(-4.1)/(-2.6))+((-x)-(-y)))+6.1+(x)-((y+(-7.5))))
        print.cccc (I 3973) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3974
        !"test3974"
        z1 <== ((p+(-q)-(-p)-(-7.2)/(-7.6))+3.7*0.0-((p-8.8+(-q)/7.4+(-q))+p-(-1.7))/((7.6-(-2.7)))-((-3.5)*(-p)))
        z2 <== ((x+(-y)-(-x)-(-7.2)/(-7.6))+3.7*0.0-((x-8.8+(-y)/7.4+(-y))+x-(-1.7))/((7.6-(-2.7)))-((-3.5)*(-x)))
        print.cccc (I 3974) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3975
        !"test3975"
        z1 <== (-p)-3.6
        z2 <== (-x)-3.6
        print.cccc (I 3975) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3976
        !"test3976"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 3976) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3977
        !"test3977"
        z1 <== (-3.3)
        z2 <== (-3.3)
        print.cccc (I 3977) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3978
        !"test3978"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3978) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3979
        !"test3979"
        z1 <== (p+q)/(-3.3)
        z2 <== (x+y)/(-3.3)
        print.cccc (I 3979) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3980
        !"test3980"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 3980) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3981
        !"test3981"
        z1 <== (((-q)+(-2.3)/((-4.8)*p/q/(-q)))/p*p*(((-0.4)-1.2-q/2.4)/q)/(-6.5))
        z2 <== (((-y)+(-2.3)/((-4.8)*x/y/(-y)))/x*x*(((-0.4)-1.2-y/2.4)/y)/(-6.5))
        print.cccc (I 3981) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3982
        !"test3982"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3982) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3983
        !"test3983"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 3983) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3984
        !"test3984"
        z1 <== p
        z2 <== x
        print.cccc (I 3984) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3985
        !"test3985"
        z1 <== ((-3.6)*(6.6*q)-q/(-2.2)+q)
        z2 <== ((-3.6)*(6.6*y)-y/(-2.2)+y)
        print.cccc (I 3985) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3986
        !"test3986"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 3986) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3987
        !"test3987"
        z1 <== (-4.6)
        z2 <== (-4.6)
        print.cccc (I 3987) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3988
        !"test3988"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 3988) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3989
        !"test3989"
        z1 <== (p-((-p)*(-q)+q*q))
        z2 <== (x-((-x)*(-y)+y*y))
        print.cccc (I 3989) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3990
        !"test3990"
        z1 <== (q-(q+(p-(-0.7)-(-2.0)+(-p)-(-6.6))-q/((-q)+5.6+(-8.0)-(-8.5)/(-2.7)))+p/(-q)-(-5.8)*(-q)/p+1.6*4.6*(-p))
        z2 <== (y-(y+(x-(-0.7)-(-2.0)+(-x)-(-6.6))-y/((-y)+5.6+(-8.0)-(-8.5)/(-2.7)))+x/(-y)-(-5.8)*(-y)/x+1.6*4.6*(-x))
        print.cccc (I 3990) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3991
        !"test3991"
        z1 <== (((-0.0)+((-8.7)*q*(-3.1)+(-4.1))/(-q)+(p)))
        z2 <== (((-0.0)+((-8.7)*y*(-3.1)+(-4.1))/(-y)+(x)))
        print.cccc (I 3991) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3992
        !"test3992"
        z1 <== ((p*((-q)+(-p))*p)/(-q)*(q*1.7))
        z2 <== ((x*((-y)+(-x))*x)/(-y)*(y*1.7))
        print.cccc (I 3992) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3993
        !"test3993"
        z1 <== p/((q/4.0-(-7.4)*5.8))+q
        z2 <== x/((y/4.0-(-7.4)*5.8))+y
        print.cccc (I 3993) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3994
        !"test3994"
        z1 <== (((3.1)/(q/p*2.4-q*(-q))-2.3*((-p)/(-q))/1.1)/(p*(-p)*(-8.3))/(-q)*(((-2.4)*(-q))/(-6.6))+5.1)
        z2 <== (((3.1)/(y/x*2.4-y*(-y))-2.3*((-x)/(-y))/1.1)/(x*(-x)*(-8.3))/(-y)*(((-2.4)*(-y))/(-6.6))+5.1)
        print.cccc (I 3994) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3995
        !"test3995"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 3995) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3996
        !"test3996"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 3996) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3997
        !"test3997"
        z1 <== 1.6-(((-3.8)/p*(-p)+p*1.5)+(-6.0)-p-(-2.7)+(-2.5))
        z2 <== 1.6-(((-3.8)/x*(-x)+x*1.5)+(-6.0)-x-(-2.7)+(-2.5))
        print.cccc (I 3997) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3998
        !"test3998"
        z1 <== (0.1*(3.5/2.2*(-5.3)))
        z2 <== (0.1*(3.5/2.2*(-5.3)))
        print.cccc (I 3998) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 3999
        !"test3999"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 3999) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4000
        !"test4000"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 4000) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4001
        !"test4001"
        z1 <== ((((-5.1))-(-q)+(-7.1)+(-p)-2.5*(-3.4)/(-q)*p/(p))/((-p))-((-8.3)-((-p)))+((-p)-(-q)))
        z2 <== ((((-5.1))-(-y)+(-7.1)+(-x)-2.5*(-3.4)/(-y)*x/(x))/((-x))-((-8.3)-((-x)))+((-x)-(-y)))
        print.cccc (I 4001) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4002
        !"test4002"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4002) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4003
        !"test4003"
        z1 <== (((-5.8)+q)/(7.7+(-q))*p+(-q)/q+p)
        z2 <== (((-5.8)+y)/(7.7+(-y))*x+(-y)/y+x)
        print.cccc (I 4003) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4004
        !"test4004"
        z1 <== ((((-5.3)+(-q))/(-p)/(q-(-4.1))+q*(-p))*(-p)*(((-1.8)-(-3.7)*(-q))/(q)-(-q)+((-q)-2.5-q+0.6*q)/(1.7*0.6+q/(-7.5)+(-6.3))))
        z2 <== ((((-5.3)+(-y))/(-x)/(y-(-4.1))+y*(-x))*(-x)*(((-1.8)-(-3.7)*(-y))/(y)-(-y)+((-y)-2.5-y+0.6*y)/(1.7*0.6+y/(-7.5)+(-6.3))))
        print.cccc (I 4004) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4005
        !"test4005"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 4005) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4006
        !"test4006"
        z1 <== (-0.8)
        z2 <== (-0.8)
        print.cccc (I 4006) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4007
        !"test4007"
        z1 <== p
        z2 <== x
        print.cccc (I 4007) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4008
        !"test4008"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4008) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4009
        !"test4009"
        z1 <== ((-2.2)-(-q))+((-q)+q+(-0.1)+1.7+(-p))+(q*(-4.2)+q)/(-0.7)
        z2 <== ((-2.2)-(-y))+((-y)+y+(-0.1)+1.7+(-x))+(y*(-4.2)+y)/(-0.7)
        print.cccc (I 4009) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4010
        !"test4010"
        z1 <== (-7.4)-p+7.5/(-7.0)
        z2 <== (-7.4)-x+7.5/(-7.0)
        print.cccc (I 4010) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4011
        !"test4011"
        z1 <== ((-8.0))
        z2 <== ((-8.0))
        print.cccc (I 4011) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4012
        !"test4012"
        z1 <== (2.1+(p))
        z2 <== (2.1+(x))
        print.cccc (I 4012) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4013
        !"test4013"
        z1 <== 3.1
        z2 <== 3.1
        print.cccc (I 4013) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4014
        !"test4014"
        z1 <== ((p+(-q)*(-0.2)*((-p)/6.5/(-p))))
        z2 <== ((x+(-y)*(-0.2)*((-x)/6.5/(-x))))
        print.cccc (I 4014) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4015
        !"test4015"
        z1 <== ((5.0*((-q)+0.0-(-4.2))*(-p)+p-(-q))*(1.3)/(p*(q*(-p)+(-q)-5.4*p)))
        z2 <== ((5.0*((-y)+0.0-(-4.2))*(-x)+x-(-y))*(1.3)/(x*(y*(-x)+(-y)-5.4*x)))
        print.cccc (I 4015) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4016
        !"test4016"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4016) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4017
        !"test4017"
        z1 <== q
        z2 <== y
        print.cccc (I 4017) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4018
        !"test4018"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4018) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4019
        !"test4019"
        z1 <== (q*(((-p)/(-q)*(-8.3))+(p*q/8.2*(-5.4))))
        z2 <== (y*(((-x)/(-y)*(-8.3))+(x*y/8.2*(-5.4))))
        print.cccc (I 4019) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4020
        !"test4020"
        z1 <== ((-7.2)-q*(-q))
        z2 <== ((-7.2)-y*(-y))
        print.cccc (I 4020) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4021
        !"test4021"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 4021) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4022
        !"test4022"
        z1 <== ((-p)-(q/2.1-((-p)/(-p))-((-p)/(-q)/(-3.7))+(q*2.1+(-q)+q)))
        z2 <== ((-x)-(y/2.1-((-x)/(-x))-((-x)/(-y)/(-3.7))+(y*2.1+(-y)+y)))
        print.cccc (I 4022) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4023
        !"test4023"
        z1 <== q
        z2 <== y
        print.cccc (I 4023) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4024
        !"test4024"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 4024) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4025
        !"test4025"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4025) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4026
        !"test4026"
        z1 <== (-2.3)
        z2 <== (-2.3)
        print.cccc (I 4026) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4027
        !"test4027"
        z1 <== ((-q)/(-6.3)-(((-6.6)*p)/(-6.8)-p*((-p)-(-q))/5.0)/q+(-q)*0.5/(6.0-((-q)-4.5/p*5.4-7.5)))
        z2 <== ((-y)/(-6.3)-(((-6.6)*x)/(-6.8)-x*((-x)-(-y))/5.0)/y+(-y)*0.5/(6.0-((-y)-4.5/x*5.4-7.5)))
        print.cccc (I 4027) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4028
        !"test4028"
        z1 <== (3.8-((-2.6)+(-q)-((-7.1)/(-1.3)/3.2/2.6/4.1))*(p+5.5-(-0.0)+(-q)))
        z2 <== (3.8-((-2.6)+(-y)-((-7.1)/(-1.3)/3.2/2.6/4.1))*(x+5.5-(-0.0)+(-y)))
        print.cccc (I 4028) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4029
        !"test4029"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 4029) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4030
        !"test4030"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 4030) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4031
        !"test4031"
        z1 <== (-7.4)
        z2 <== (-7.4)
        print.cccc (I 4031) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4032
        !"test4032"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 4032) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4033
        !"test4033"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4033) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4034
        !"test4034"
        z1 <== (((-6.2)-(-6.8)+8.6-(-6.3))*q)
        z2 <== (((-6.2)-(-6.8)+8.6-(-6.3))*y)
        print.cccc (I 4034) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4035
        !"test4035"
        z1 <== p
        z2 <== x
        print.cccc (I 4035) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4036
        !"test4036"
        z1 <== (6.2/4.8)
        z2 <== (6.2/4.8)
        print.cccc (I 4036) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4037
        !"test4037"
        z1 <== ((-q)*(((-q)*7.2)-3.4+(-5.2)+((-p)-p*(-p)/q*p)/(q-(-3.4)*1.4))*(p-((-8.6)/(-2.2)/q)+((-p)*6.0*(-p)*3.6))/(-5.7)+((-q)*((-7.7)-(-q)+(-q))))
        z2 <== ((-y)*(((-y)*7.2)-3.4+(-5.2)+((-x)-x*(-x)/y*x)/(y-(-3.4)*1.4))*(x-((-8.6)/(-2.2)/y)+((-x)*6.0*(-x)*3.6))/(-5.7)+((-y)*((-7.7)-(-y)+(-y))))
        print.cccc (I 4037) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4038
        !"test4038"
        z1 <== p
        z2 <== x
        print.cccc (I 4038) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4039
        !"test4039"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4039) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4040
        !"test4040"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 4040) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4041
        !"test4041"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4041) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4042
        !"test4042"
        z1 <== ((p/(-q)*(-q)-p+3.7)*((-p))*(-0.0)*(p+((-7.1)+p*1.2)))
        z2 <== ((x/(-y)*(-y)-x+3.7)*((-x))*(-0.0)*(x+((-7.1)+x*1.2)))
        print.cccc (I 4042) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4043
        !"test4043"
        z1 <== (-1.3)-p-(-6.6)
        z2 <== (-1.3)-x-(-6.6)
        print.cccc (I 4043) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4044
        !"test4044"
        z1 <== (((-p)))
        z2 <== (((-x)))
        print.cccc (I 4044) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4045
        !"test4045"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 4045) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4046
        !"test4046"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 4046) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4047
        !"test4047"
        z1 <== (((-q))*(((-p)+p*p-p-7.0)-((-q)+(-q)*5.4)+3.8/6.4-(-7.0)/(-1.1)*8.6)/((-q)*(-q)-0.2-(-5.1)/(-7.3)*p*(7.3/(-2.7)))+(p/((-p)-(-2.6))*(-3.0)-(-7.1)+(-0.5)))
        z2 <== (((-y))*(((-x)+x*x-x-7.0)-((-y)+(-y)*5.4)+3.8/6.4-(-7.0)/(-1.1)*8.6)/((-y)*(-y)-0.2-(-5.1)/(-7.3)*x*(7.3/(-2.7)))+(x/((-x)-(-2.6))*(-3.0)-(-7.1)+(-0.5)))
        print.cccc (I 4047) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4048
        !"test4048"
        z1 <== (6.3-7.3-q*(((-2.4)+(-q)*2.2*q/1.0)/(1.4*(-q)+(-p)/8.5)/((-7.6)+(-0.7)-(-p)*(-7.7)+(-p))-(-p)/(2.2)))
        z2 <== (6.3-7.3-y*(((-2.4)+(-y)*2.2*y/1.0)/(1.4*(-y)+(-x)/8.5)/((-7.6)+(-0.7)-(-x)*(-7.7)+(-x))-(-x)/(2.2)))
        print.cccc (I 4048) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4049
        !"test4049"
        z1 <== 0.7-(((-6.3)-(-6.2)+(-p)*0.6)+(-p)/5.1)-8.7
        z2 <== 0.7-(((-6.3)-(-6.2)+(-x)*0.6)+(-x)/5.1)-8.7
        print.cccc (I 4049) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4050
        !"test4050"
        z1 <== q
        z2 <== y
        print.cccc (I 4050) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4051
        !"test4051"
        z1 <== (((-4.2))-((q+7.0*q-(-p)))+(-q)*(((-p))/((-0.1))*7.8+5.2))
        z2 <== (((-4.2))-((y+7.0*y-(-x)))+(-y)*(((-x))/((-0.1))*7.8+5.2))
        print.cccc (I 4051) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4052
        !"test4052"
        z1 <== (-0.7)
        z2 <== (-0.7)
        print.cccc (I 4052) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4053
        !"test4053"
        z1 <== (((3.3))*3.8+((-2.4)+q-(p)/(-p))/(-p))
        z2 <== (((3.3))*3.8+((-2.4)+y-(x)/(-x))/(-x))
        print.cccc (I 4053) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4054
        !"test4054"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4054) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4055
        !"test4055"
        z1 <== (6.6/1.0*p/(-p)+p-(-q)*(4.6-3.6*(5.1+q*p*(-q)-(-2.8))-(4.0/2.5)/(p*(-7.6)))*q+((-5.3)+((-8.8)+(-8.5)/p+4.7/(-5.8))-(-q)*((-3.3)+(-p)*p)/(q-(-p)*p))*(2.0*((-4.3)/q+(-5.6)+(-1.5))+((-q)-5.5-(-p)+(-p)+(-p))+(-p)))
        z2 <== (6.6/1.0*x/(-x)+x-(-y)*(4.6-3.6*(5.1+y*x*(-y)-(-2.8))-(4.0/2.5)/(x*(-7.6)))*y+((-5.3)+((-8.8)+(-8.5)/x+4.7/(-5.8))-(-y)*((-3.3)+(-x)*x)/(y-(-x)*x))*(2.0*((-4.3)/y+(-5.6)+(-1.5))+((-y)-5.5-(-x)+(-x)+(-x))+(-x)))
        print.cccc (I 4055) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4056
        !"test4056"
        z1 <== q/((-5.1)*(-0.8)+(0.1*(-q)/(-6.4)/q+3.0)-0.7*(-q)/(-4.7)-(-p))/(-7.1)/((-p)-p/(-q)*(-p)/q/q-(-q)-(-q))
        z2 <== y/((-5.1)*(-0.8)+(0.1*(-y)/(-6.4)/y+3.0)-0.7*(-y)/(-4.7)-(-x))/(-7.1)/((-x)-x/(-y)*(-x)/y/y-(-y)-(-y))
        print.cccc (I 4056) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4057
        !"test4057"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 4057) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4058
        !"test4058"
        z1 <== (((-5.0)+(-8.0)*(-4.2)))
        z2 <== (((-5.0)+(-8.0)*(-4.2)))
        print.cccc (I 4058) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4059
        !"test4059"
        z1 <== p
        z2 <== x
        print.cccc (I 4059) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4060
        !"test4060"
        z1 <== ((-2.1)-(2.2/(p-q*(-7.3))))
        z2 <== ((-2.1)-(2.2/(x-y*(-7.3))))
        print.cccc (I 4060) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4061
        !"test4061"
        z1 <== ((-p)/1.2+(-p)+((-q)+0.8-q+(-p)*(-q)-p))
        z2 <== ((-x)/1.2+(-x)+((-y)+0.8-y+(-x)*(-y)-x))
        print.cccc (I 4061) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4062
        !"test4062"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 4062) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4063
        !"test4063"
        z1 <== (-8.3)
        z2 <== (-8.3)
        print.cccc (I 4063) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4064
        !"test4064"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 4064) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4065
        !"test4065"
        z1 <== p-(((-3.2)/p)+p-3.3-(0.0+(-q)*5.1)/(p+(-7.7)))
        z2 <== x-(((-3.2)/x)+x-3.3-(0.0+(-y)*5.1)/(x+(-7.7)))
        print.cccc (I 4065) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4066
        !"test4066"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 4066) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4067
        !"test4067"
        z1 <== ((-7.3)-((-4.0)+((-1.0)/(-p)*p)/7.1-(-q)*(q/q))+2.4)
        z2 <== ((-7.3)-((-4.0)+((-1.0)/(-x)*x)/7.1-(-y)*(y/y))+2.4)
        print.cccc (I 4067) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4068
        !"test4068"
        z1 <== p
        z2 <== x
        print.cccc (I 4068) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4069
        !"test4069"
        z1 <== (((-q)*(q/(-8.4)*p/8.3)+((-q)+5.1+3.1*(-6.0))*(-p))+((-p)*((-q)*p)-(q/(-p)*8.6-p)-((-p)+(-q)*q)+((-6.0)-(-p)+q/q))-p/p-p)
        z2 <== (((-y)*(y/(-8.4)*x/8.3)+((-y)+5.1+3.1*(-6.0))*(-x))+((-x)*((-y)*x)-(y/(-x)*8.6-x)-((-x)+(-y)*y)+((-6.0)-(-x)+y/y))-x/x-x)
        print.cccc (I 4069) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4070
        !"test4070"
        z1 <== q+(2.4-(8.1*(-8.7)-p-4.2)/(-q)+(-6.8)*(-7.0)*3.3*(-4.3))
        z2 <== y+(2.4-(8.1*(-8.7)-x-4.2)/(-y)+(-6.8)*(-7.0)*3.3*(-4.3))
        print.cccc (I 4070) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4071
        !"test4071"
        z1 <== (p+(-5.4))
        z2 <== (x+(-5.4))
        print.cccc (I 4071) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4072
        !"test4072"
        z1 <== ((((-q))/(-6.7))-((-1.1)/0.3*p*(-p))+1.7)
        z2 <== ((((-y))/(-6.7))-((-1.1)/0.3*x*(-x))+1.7)
        print.cccc (I 4072) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4073
        !"test4073"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4073) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4074
        !"test4074"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4074) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4075
        !"test4075"
        z1 <== q
        z2 <== y
        print.cccc (I 4075) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4076
        !"test4076"
        z1 <== ((-q)+((-5.3)-8.4*(-q)+q-p)+(-7.4)-(-5.3)+6.1+(-q)+((-5.0)*5.5/6.2/(-p)/(-p))/q-(((-q)/(-q)+3.5)+p*p*(-8.8)*((-q)*p-4.7)-(-q)-1.4-(-p)+q)+(-1.6))
        z2 <== ((-y)+((-5.3)-8.4*(-y)+y-x)+(-7.4)-(-5.3)+6.1+(-y)+((-5.0)*5.5/6.2/(-x)/(-x))/y-(((-y)/(-y)+3.5)+x*x*(-8.8)*((-y)*x-4.7)-(-y)-1.4-(-x)+y)+(-1.6))
        print.cccc (I 4076) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4077
        !"test4077"
        z1 <== (-2.6)
        z2 <== (-2.6)
        print.cccc (I 4077) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4078
        !"test4078"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4078) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4079
        !"test4079"
        z1 <== ((p/((-p))-((-p)+(-5.0))/(q)/(-6.2)))
        z2 <== ((x/((-x))-((-x)+(-5.0))/(y)/(-6.2)))
        print.cccc (I 4079) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4080
        !"test4080"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 4080) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4081
        !"test4081"
        z1 <== q
        z2 <== y
        print.cccc (I 4081) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4082
        !"test4082"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 4082) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4083
        !"test4083"
        z1 <== 7.3
        z2 <== 7.3
        print.cccc (I 4083) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4084
        !"test4084"
        z1 <== p
        z2 <== x
        print.cccc (I 4084) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4085
        !"test4085"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 4085) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4086
        !"test4086"
        z1 <== (-1.0)
        z2 <== (-1.0)
        print.cccc (I 4086) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4087
        !"test4087"
        z1 <== (0.7)
        z2 <== (0.7)
        print.cccc (I 4087) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4088
        !"test4088"
        z1 <== (p*(-p)/(((-q)*4.0-(-q))/(6.3+(-5.1))))
        z2 <== (x*(-x)/(((-y)*4.0-(-y))/(6.3+(-5.1))))
        print.cccc (I 4088) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4089
        !"test4089"
        z1 <== ((-p))*((-5.6)-(-q)*(-4.8)+2.8)-(-q)
        z2 <== ((-x))*((-5.6)-(-y)*(-4.8)+2.8)-(-y)
        print.cccc (I 4089) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4090
        !"test4090"
        z1 <== p
        z2 <== x
        print.cccc (I 4090) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4091
        !"test4091"
        z1 <== (6.0+7.0/(p+(-1.3)*7.2)*(-q)+(-p)+(q+((-p)*1.0/(-p)*(-7.3)+(-7.0)))+(-8.7)*(-p)-((-q)*1.1*(-6.8)+(-q)))
        z2 <== (6.0+7.0/(x+(-1.3)*7.2)*(-y)+(-x)+(y+((-x)*1.0/(-x)*(-7.3)+(-7.0)))+(-8.7)*(-x)-((-y)*1.1*(-6.8)+(-y)))
        print.cccc (I 4091) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4092
        !"test4092"
        z1 <== ((q-(q/(-6.6)-p+(-q))*(-2.1)+2.8-(-7.8)))
        z2 <== ((y-(y/(-6.6)-x+(-y))*(-2.1)+2.8-(-7.8)))
        print.cccc (I 4092) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4093
        !"test4093"
        z1 <== ((q*(-p)+((-5.6))-(7.8-(-1.2)))*((q+(-p)-q))/(-8.8)-p)
        z2 <== ((y*(-x)+((-5.6))-(7.8-(-1.2)))*((y+(-x)-y))/(-8.8)-x)
        print.cccc (I 4093) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4094
        !"test4094"
        z1 <== ((p-6.7*((-5.4)+(-0.8)+(-p)*q*0.1)))
        z2 <== ((x-6.7*((-5.4)+(-0.8)+(-x)*y*0.1)))
        print.cccc (I 4094) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4095
        !"test4095"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4095) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4096
        !"test4096"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 4096) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4097
        !"test4097"
        z1 <== p
        z2 <== x
        print.cccc (I 4097) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4098
        !"test4098"
        z1 <== (7.0*7.6*p)
        z2 <== (7.0*7.6*x)
        print.cccc (I 4098) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4099
        !"test4099"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4099) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4100
        !"test4100"
        z1 <== (5.3+p+(-p)+4.3*q)
        z2 <== (5.3+x+(-x)+4.3*y)
        print.cccc (I 4100) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4101
        !"test4101"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4101) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4102
        !"test4102"
        z1 <== ((q-(-1.7))*q)
        z2 <== ((y-(-1.7))*y)
        print.cccc (I 4102) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4103
        !"test4103"
        z1 <== ((-p)+((-5.1)*(-6.1)-((-q)*p+0.0+p)*(-1.4)*q))
        z2 <== ((-x)+((-5.1)*(-6.1)-((-y)*x+0.0+x)*(-1.4)*y))
        print.cccc (I 4103) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4104
        !"test4104"
        z1 <== (6.0/(q+p)/3.7-6.0-((-2.0)*p))
        z2 <== (6.0/(y+x)/3.7-6.0-((-2.0)*x))
        print.cccc (I 4104) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4105
        !"test4105"
        z1 <== ((((-p)/(-7.0)/q-(-1.2))*((-p)+(-q)-(-q)/(-p)-(-p)))-((0.1-q*q/(-p))+1.1+(-4.7)/7.0/(2.5*(-q)))/(1.6*(-6.2)*(-q)-(-4.7)+q-(-7.7)))
        z2 <== ((((-x)/(-7.0)/y-(-1.2))*((-x)+(-y)-(-y)/(-x)-(-x)))-((0.1-y*y/(-x))+1.1+(-4.7)/7.0/(2.5*(-y)))/(1.6*(-6.2)*(-y)-(-4.7)+y-(-7.7)))
        print.cccc (I 4105) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4106
        !"test4106"
        z1 <== ((-7.2))
        z2 <== ((-7.2))
        print.cccc (I 4106) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4107
        !"test4107"
        z1 <== ((-p)/(4.1*((-3.7)-3.6-7.2-(-0.0)-(-1.3))*(-q)+((-p)/q))+q-(-q))
        z2 <== ((-x)/(4.1*((-3.7)-3.6-7.2-(-0.0)-(-1.3))*(-y)+((-x)/y))+y-(-y))
        print.cccc (I 4107) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4108
        !"test4108"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 4108) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4109
        !"test4109"
        z1 <== ((3.1+(-q)/(q)/(-p)*((-6.0)-(-p)*8.7+7.1-(-3.0)))/(((-p)-q-(-p))+(-6.7)/((-3.1)*(-0.2)/q+(-q)+(-q))-8.2))
        z2 <== ((3.1+(-y)/(y)/(-x)*((-6.0)-(-x)*8.7+7.1-(-3.0)))/(((-x)-y-(-x))+(-6.7)/((-3.1)*(-0.2)/y+(-y)+(-y))-8.2))
        print.cccc (I 4109) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4110
        !"test4110"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 4110) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4111
        !"test4111"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4111) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4112
        !"test4112"
        z1 <== ((-1.6)-(-p)*((-q)-(-1.7)-p-(p/2.6+8.6-p-(-p))+(-q))/1.8+(-p))
        z2 <== ((-1.6)-(-x)*((-y)-(-1.7)-x-(x/2.6+8.6-x-(-x))+(-y))/1.8+(-x))
        print.cccc (I 4112) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4113
        !"test4113"
        z1 <== (((1.2*q*q/(-p)*1.7)/((-q)*(-q)/q))+((4.2/(-p)+p))-((6.5-q/(-p)))-3.4)
        z2 <== (((1.2*y*y/(-x)*1.7)/((-y)*(-y)/y))+((4.2/(-x)+x))-((6.5-y/(-x)))-3.4)
        print.cccc (I 4113) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4114
        !"test4114"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 4114) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4115
        !"test4115"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 4115) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4116
        !"test4116"
        z1 <== (((-5.2)-(-q)*p)-(-p)*(((-0.7)/(-q)/(-p)*(-q))-5.1)+(-4.3)/((-q)+(-q)))
        z2 <== (((-5.2)-(-y)*x)-(-x)*(((-0.7)/(-y)/(-x)*(-y))-5.1)+(-4.3)/((-y)+(-y)))
        print.cccc (I 4116) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4117
        !"test4117"
        z1 <== ((-7.6)/(-q)*(-0.6))
        z2 <== ((-7.6)/(-y)*(-0.6))
        print.cccc (I 4117) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4118
        !"test4118"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4118) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4119
        !"test4119"
        z1 <== (8.6/((q*8.2/q+q-6.6)-p*q+1.2/(-q)))
        z2 <== (8.6/((y*8.2/y+y-6.6)-x*y+1.2/(-y)))
        print.cccc (I 4119) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4120
        !"test4120"
        z1 <== (q*(((-1.7))/p)*(((-q)-(-p)*0.3+(-p)+0.1)/5.3))
        z2 <== (y*(((-1.7))/x)*(((-y)-(-x)*0.3+(-x)+0.1)/5.3))
        print.cccc (I 4120) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4121
        !"test4121"
        z1 <== q
        z2 <== y
        print.cccc (I 4121) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4122
        !"test4122"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 4122) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4123
        !"test4123"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4123) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4124
        !"test4124"
        z1 <== p
        z2 <== x
        print.cccc (I 4124) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4125
        !"test4125"
        z1 <== ((p/(-q)*(-p)/((-p)-q*(-q)*(-p)*2.7)))
        z2 <== ((x/(-y)*(-x)/((-x)-y*(-y)*(-x)*2.7)))
        print.cccc (I 4125) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4126
        !"test4126"
        z1 <== (((-q)*(-p)+(-p))-q/1.3*((-0.8)-(-q)+8.7))/7.4
        z2 <== (((-y)*(-x)+(-x))-y/1.3*((-0.8)-(-y)+8.7))/7.4
        print.cccc (I 4126) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4127
        !"test4127"
        z1 <== (((q*p)-6.4/(q*(-2.3)+p/3.0*p))*2.0/(7.6+1.4)/p)
        z2 <== (((y*x)-6.4/(y*(-2.3)+x/3.0*x))*2.0/(7.6+1.4)/x)
        print.cccc (I 4127) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4128
        !"test4128"
        z1 <== (5.3+7.3*2.8/7.2+(-q))/(-7.3)+(5.8)/8.0-(7.2+(-q))/(-4.1)/(4.4)*p
        z2 <== (5.3+7.3*2.8/7.2+(-y))/(-7.3)+(5.8)/8.0-(7.2+(-y))/(-4.1)/(4.4)*x
        print.cccc (I 4128) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4129
        !"test4129"
        z1 <== q
        z2 <== y
        print.cccc (I 4129) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4130
        !"test4130"
        z1 <== q*p+((-7.8))+((-7.1)*(-q))/(7.8)+((p)*(q))
        z2 <== y*x+((-7.8))+((-7.1)*(-y))/(7.8)+((x)*(y))
        print.cccc (I 4130) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4131
        !"test4131"
        z1 <== p
        z2 <== x
        print.cccc (I 4131) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4132
        !"test4132"
        z1 <== p+((-q)/6.4+((-p)))/(-p)
        z2 <== x+((-y)/6.4+((-x)))/(-x)
        print.cccc (I 4132) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4133
        !"test4133"
        z1 <== (q*(-p)/q-p-0.2+(-4.2)-p*q+(q+q))
        z2 <== (y*(-x)/y-x-0.2+(-4.2)-x*y+(y+y))
        print.cccc (I 4133) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4134
        !"test4134"
        z1 <== 3.4
        z2 <== 3.4
        print.cccc (I 4134) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4135
        !"test4135"
        z1 <== ((-p)+(q+(-p)+(-5.1)))
        z2 <== ((-x)+(y+(-x)+(-5.1)))
        print.cccc (I 4135) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4136
        !"test4136"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4136) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4137
        !"test4137"
        z1 <== (((-8.8))*5.4+(-p))
        z2 <== (((-8.8))*5.4+(-x))
        print.cccc (I 4137) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4138
        !"test4138"
        z1 <== p
        z2 <== x
        print.cccc (I 4138) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4139
        !"test4139"
        z1 <== p
        z2 <== x
        print.cccc (I 4139) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4140
        !"test4140"
        z1 <== (8.2)
        z2 <== (8.2)
        print.cccc (I 4140) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4141
        !"test4141"
        z1 <== (-q)+(-p)
        z2 <== (-y)+(-x)
        print.cccc (I 4141) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4142
        !"test4142"
        z1 <== q*(-7.6)
        z2 <== y*(-7.6)
        print.cccc (I 4142) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4143
        !"test4143"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4143) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4144
        !"test4144"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 4144) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4145
        !"test4145"
        z1 <== p
        z2 <== x
        print.cccc (I 4145) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4146
        !"test4146"
        z1 <== p
        z2 <== x
        print.cccc (I 4146) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4147
        !"test4147"
        z1 <== (q+((-q)*(3.8)+(1.3*(-q)))*(4.2-(-1.2))+(-p))
        z2 <== (y+((-y)*(3.8)+(1.3*(-y)))*(4.2-(-1.2))+(-x))
        print.cccc (I 4147) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4148
        !"test4148"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4148) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4149
        !"test4149"
        z1 <== ((8.4+3.7+8.0/(-5.4)/q+(6.5-7.0+(-q)))/((-4.0)-((-1.0)*(-2.1)+(-4.4))-(1.6)-((-1.2)*(-q)+p-5.2/6.1)-5.0))
        z2 <== ((8.4+3.7+8.0/(-5.4)/y+(6.5-7.0+(-y)))/((-4.0)-((-1.0)*(-2.1)+(-4.4))-(1.6)-((-1.2)*(-y)+x-5.2/6.1)-5.0))
        print.cccc (I 4149) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4150
        !"test4150"
        z1 <== ((-0.1)-((-p)-(-7.3)-q*(-p)*q)*(p-(q+(-6.1)*0.2/(-3.1)/4.3))/((q)+7.5/((-0.2))/(-2.7)*(-3.5)-1.6/q/2.8)-(-p))
        z2 <== ((-0.1)-((-x)-(-7.3)-y*(-x)*y)*(x-(y+(-6.1)*0.2/(-3.1)/4.3))/((y)+7.5/((-0.2))/(-2.7)*(-3.5)-1.6/y/2.8)-(-x))
        print.cccc (I 4150) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4151
        !"test4151"
        z1 <== ((2.7-((-q)+3.2*q-8.2+p)+(-p)-(7.5*(-4.5)+q)*p))
        z2 <== ((2.7-((-y)+3.2*y-8.2+x)+(-x)-(7.5*(-4.5)+y)*x))
        print.cccc (I 4151) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4152
        !"test4152"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4152) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4153
        !"test4153"
        z1 <== ((-2.6)*((-2.5)-p/(-p)))/(((-q)+6.1+(-q)/(-3.2)))+(-p)*p/8.7-(-q)-(7.3+(-8.1))
        z2 <== ((-2.6)*((-2.5)-x/(-x)))/(((-y)+6.1+(-y)/(-3.2)))+(-x)*x/8.7-(-y)-(7.3+(-8.1))
        print.cccc (I 4153) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4154
        !"test4154"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 4154) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4155
        !"test4155"
        z1 <== (q/(6.5-8.8)*((p+(-q)*(-p))))
        z2 <== (y/(6.5-8.8)*((x+(-y)*(-x))))
        print.cccc (I 4155) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4156
        !"test4156"
        z1 <== 8.0
        z2 <== 8.0
        print.cccc (I 4156) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4157
        !"test4157"
        z1 <== (p/(((-8.3)*2.7/q/7.0-(-p))*(p*7.0/(-q))-(-p)*(q/0.3-q-4.8)*5.0)/((p)+((-p)+(-p)-7.6*(-q)-0.4)*((-3.4)+(-4.6)+(-p)/(-5.3)*(-1.0)))/(-p))
        z2 <== (x/(((-8.3)*2.7/y/7.0-(-x))*(x*7.0/(-y))-(-x)*(y/0.3-y-4.8)*5.0)/((x)+((-x)+(-x)-7.6*(-y)-0.4)*((-3.4)+(-4.6)+(-x)/(-5.3)*(-1.0)))/(-x))
        print.cccc (I 4157) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4158
        !"test4158"
        z1 <== (-q)+((-2.8)*(-p)+(-p)/3.7+((-7.8)*(-p)))/(((-0.6))/(2.1/6.1)+p-(-p))
        z2 <== (-y)+((-2.8)*(-x)+(-x)/3.7+((-7.8)*(-x)))/(((-0.6))/(2.1/6.1)+x-(-x))
        print.cccc (I 4158) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4159
        !"test4159"
        z1 <== p
        z2 <== x
        print.cccc (I 4159) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4160
        !"test4160"
        z1 <== p
        z2 <== x
        print.cccc (I 4160) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4161
        !"test4161"
        z1 <== 6.5
        z2 <== 6.5
        print.cccc (I 4161) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4162
        !"test4162"
        z1 <== ((-p)*(-q)+(-7.6))
        z2 <== ((-x)*(-y)+(-7.6))
        print.cccc (I 4162) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4163
        !"test4163"
        z1 <== ((-p)+(-0.0)*(q-((-p)*q+(-6.1)+(-2.1)*6.5)+(-4.2)+2.5))
        z2 <== ((-x)+(-0.0)*(y-((-x)*y+(-6.1)+(-2.1)*6.5)+(-4.2)+2.5))
        print.cccc (I 4163) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4164
        !"test4164"
        z1 <== ((-3.6)-6.5+((-5.1))+2.4+(0.2-((-5.1)*6.3-(-p)/(-3.3)-(-4.8))))
        z2 <== ((-3.6)-6.5+((-5.1))+2.4+(0.2-((-5.1)*6.3-(-x)/(-3.3)-(-4.8))))
        print.cccc (I 4164) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4165
        !"test4165"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 4165) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4166
        !"test4166"
        z1 <== ((((-2.1)/(-3.0)-(-q)-p+1.3)-((-6.2)-(-4.7))*(-6.2))/((-p)*(-p)*(-3.8)/p+(-8.0))/(-q)*(-7.2)+q)
        z2 <== ((((-2.1)/(-3.0)-(-y)-x+1.3)-((-6.2)-(-4.7))*(-6.2))/((-x)*(-x)*(-3.8)/x+(-8.0))/(-y)*(-7.2)+y)
        print.cccc (I 4166) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4167
        !"test4167"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 4167) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4168
        !"test4168"
        z1 <== (((-q)*4.5+5.0-3.5+q/(-q))+(1.0+(q/1.4+(-p))-(-8.5)-4.7*(-q)-p)+q)
        z2 <== (((-y)*4.5+5.0-3.5+y/(-y))+(1.0+(y/1.4+(-x))-(-8.5)-4.7*(-y)-x)+y)
        print.cccc (I 4168) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4169
        !"test4169"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 4169) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4170
        !"test4170"
        z1 <== 5.5*(5.2)-(q)
        z2 <== 5.5*(5.2)-(y)
        print.cccc (I 4170) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4171
        !"test4171"
        z1 <== p
        z2 <== x
        print.cccc (I 4171) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4172
        !"test4172"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4172) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4173
        !"test4173"
        z1 <== (((-q)))
        z2 <== (((-y)))
        print.cccc (I 4173) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4174
        !"test4174"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 4174) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4175
        !"test4175"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 4175) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4176
        !"test4176"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4176) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4177
        !"test4177"
        z1 <== (((4.2+(-p)+(-1.7))-(q)*5.6)*((-1.2)-(q*(-q)/(-0.2)-(-p)))/(-8.5)*((p*0.7)*(4.8+(-5.1)+q*(-8.5))/q/q+(p)))
        z2 <== (((4.2+(-x)+(-1.7))-(y)*5.6)*((-1.2)-(y*(-y)/(-0.2)-(-x)))/(-8.5)*((x*0.7)*(4.8+(-5.1)+y*(-8.5))/y/y+(x)))
        print.cccc (I 4177) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4178
        !"test4178"
        z1 <== p
        z2 <== x
        print.cccc (I 4178) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4179
        !"test4179"
        z1 <== ((-0.2)-(((-p)-q+4.5/q)-((-q)))/((p-(-q))-(-q)*(6.7)-((-3.0)-(-0.3))/(-p))-(8.2/q-((-q)+(-3.0))+(5.7+(-3.2))+(-5.8))*(p-(-q)))
        z2 <== ((-0.2)-(((-x)-y+4.5/y)-((-y)))/((x-(-y))-(-y)*(6.7)-((-3.0)-(-0.3))/(-x))-(8.2/y-((-y)+(-3.0))+(5.7+(-3.2))+(-5.8))*(x-(-y)))
        print.cccc (I 4179) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4180
        !"test4180"
        z1 <== (((-2.3)/(q+q*3.5))+p-((-q)+(-p)/1.6*(-q))/(-p)/(-6.1)+p/(5.2*1.8-(p/4.6+p)))
        z2 <== (((-2.3)/(y+y*3.5))+x-((-y)+(-x)/1.6*(-y))/(-x)/(-6.1)+x/(5.2*1.8-(x/4.6+x)))
        print.cccc (I 4180) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4181
        !"test4181"
        z1 <== (((q*(-4.6)/(-p)-(-q)))*((-1.1)*5.4/q*7.4+(-3.1)+(-1.4)-(-8.0)/(-p)*(-3.6))-6.0-(-q)*p-((-p))/(6.6/(-q)-(-q)*(-p)-(-p))+(-p)*p*((-q)-(p)-p-((-q))+(7.0-(-5.5)/(-q))))
        z2 <== (((y*(-4.6)/(-x)-(-y)))*((-1.1)*5.4/y*7.4+(-3.1)+(-1.4)-(-8.0)/(-x)*(-3.6))-6.0-(-y)*x-((-x))/(6.6/(-y)-(-y)*(-x)-(-x))+(-x)*x*((-y)-(x)-x-((-y))+(7.0-(-5.5)/(-y))))
        print.cccc (I 4181) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4182
        !"test4182"
        z1 <== ((-3.7))
        z2 <== ((-3.7))
        print.cccc (I 4182) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4183
        !"test4183"
        z1 <== 7.5
        z2 <== 7.5
        print.cccc (I 4183) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4184
        !"test4184"
        z1 <== (6.5/(-q)/(p+(-q)-(1.6)))
        z2 <== (6.5/(-y)/(x+(-y)-(1.6)))
        print.cccc (I 4184) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4185
        !"test4185"
        z1 <== (-3.1)*((-4.7)+(-q)/p*(-q)*(-p))-(p/p/(-p)+6.3)+(-0.2)/(1.6/(-1.1)/(-4.7)/(-p)*q)
        z2 <== (-3.1)*((-4.7)+(-y)/x*(-y)*(-x))-(x/x/(-x)+6.3)+(-0.2)/(1.6/(-1.1)/(-4.7)/(-x)*y)
        print.cccc (I 4185) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4186
        !"test4186"
        z1 <== ((-4.4)+3.7/((-p)*(3.8/(-7.7)*(-3.3)*(-8.5))+2.7/(-q)))
        z2 <== ((-4.4)+3.7/((-x)*(3.8/(-7.7)*(-3.3)*(-8.5))+2.7/(-y)))
        print.cccc (I 4186) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4187
        !"test4187"
        z1 <== ((-p)*(-q)+q*((-7.5)-p+q*(-0.4))-4.0+q)
        z2 <== ((-x)*(-y)+y*((-7.5)-x+y*(-0.4))-4.0+y)
        print.cccc (I 4187) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4188
        !"test4188"
        z1 <== ((-6.7)-q+(-q)+1.8)
        z2 <== ((-6.7)-y+(-y)+1.8)
        print.cccc (I 4188) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4189
        !"test4189"
        z1 <== ((-8.5)/q-((q-(-1.7)/(-p)*(-5.3))/(-q)-(p-(-3.5)-(-2.0)/6.0))*((7.2-(-q))/(-q)-q-3.1+0.0))
        z2 <== ((-8.5)/y-((y-(-1.7)/(-x)*(-5.3))/(-y)-(x-(-3.5)-(-2.0)/6.0))*((7.2-(-y))/(-y)-y-3.1+0.0))
        print.cccc (I 4189) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4190
        !"test4190"
        z1 <== (1.4*(q-q+(-8.2))+(p-p*(-3.1)*7.3-(-3.5))-((-2.0)/p/(-q)+(-q)-(-0.8))/(8.8))
        z2 <== (1.4*(y-y+(-8.2))+(x-x*(-3.1)*7.3-(-3.5))-((-2.0)/x/(-y)+(-y)-(-0.8))/(8.8))
        print.cccc (I 4190) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4191
        !"test4191"
        z1 <== (-5.8)
        z2 <== (-5.8)
        print.cccc (I 4191) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4192
        !"test4192"
        z1 <== ((p-7.1)+(-6.0)/(((-p))*(q/6.6)/p))
        z2 <== ((x-7.1)+(-6.0)/(((-x))*(y/6.6)/x))
        print.cccc (I 4192) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4193
        !"test4193"
        z1 <== (((-p)*(-p)/(-q)-(-q))*(-7.2)+(-q)*(-2.3)/((-6.5)/6.6))
        z2 <== (((-x)*(-x)/(-y)-(-y))*(-7.2)+(-y)*(-2.3)/((-6.5)/6.6))
        print.cccc (I 4193) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4194
        !"test4194"
        z1 <== ((-q)-(-0.6)/6.4-p-(-q)*6.0/(-p)*q)-((-q)-p*(-8.7)/(-0.0)*(-q)+(-q))*(-4.4)-7.4
        z2 <== ((-y)-(-0.6)/6.4-x-(-y)*6.0/(-x)*y)-((-y)-x*(-8.7)/(-0.0)*(-y)+(-y))*(-4.4)-7.4
        print.cccc (I 4194) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4195
        !"test4195"
        z1 <== (((q)*2.3+1.3-p/p/p)-(((-q)+p)*q)*((4.5-6.5)/((-p)-q)-((-1.4)/4.6)*3.3)/(-3.4))
        z2 <== (((y)*2.3+1.3-x/x/x)-(((-y)+x)*y)*((4.5-6.5)/((-x)-y)-((-1.4)/4.6)*3.3)/(-3.4))
        print.cccc (I 4195) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4196
        !"test4196"
        z1 <== (-5.2)
        z2 <== (-5.2)
        print.cccc (I 4196) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4197
        !"test4197"
        z1 <== ((-7.2)*p)
        z2 <== ((-7.2)*x)
        print.cccc (I 4197) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4198
        !"test4198"
        z1 <== 4.7
        z2 <== 4.7
        print.cccc (I 4198) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4199
        !"test4199"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4199) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4200
        !"test4200"
        z1 <== (-1.0)
        z2 <== (-1.0)
        print.cccc (I 4200) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4201
        !"test4201"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 4201) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4202
        !"test4202"
        z1 <== (-0.1)
        z2 <== (-0.1)
        print.cccc (I 4202) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4203
        !"test4203"
        z1 <== (((-1.7)/(-0.4)/p+(-5.0)-(-q)))
        z2 <== (((-1.7)/(-0.4)/x+(-5.0)-(-y)))
        print.cccc (I 4203) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4204
        !"test4204"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 4204) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4205
        !"test4205"
        z1 <== p
        z2 <== x
        print.cccc (I 4205) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4206
        !"test4206"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4206) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4207
        !"test4207"
        z1 <== p
        z2 <== x
        print.cccc (I 4207) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4208
        !"test4208"
        z1 <== ((((-q)/p*(-2.2)+q)/((-p))*6.7*(2.1+(-5.3)))/(q+(5.5/p)+6.7)*(-p)-((-q)/(-p)/(-7.2)-q*2.7/((-p)*(-q)/7.3+5.0))+((-q)/4.2/((-2.4)/p)/(-1.7)-q*(-q)*(-p)))
        z2 <== ((((-y)/x*(-2.2)+y)/((-x))*6.7*(2.1+(-5.3)))/(y+(5.5/x)+6.7)*(-x)-((-y)/(-x)/(-7.2)-y*2.7/((-x)*(-y)/7.3+5.0))+((-y)/4.2/((-2.4)/x)/(-1.7)-y*(-y)*(-x)))
        print.cccc (I 4208) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4209
        !"test4209"
        z1 <== ((p/(-8.2)+(-p)*(4.2+2.7/8.1+(-1.6)*(-p)))/((-2.0)/(-p))*((4.3-(-p)))+2.6)
        z2 <== ((x/(-8.2)+(-x)*(4.2+2.7/8.1+(-1.6)*(-x)))/((-2.0)/(-x))*((4.3-(-x)))+2.6)
        print.cccc (I 4209) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4210
        !"test4210"
        z1 <== (q*6.8/((-7.1)+p)*p/7.7-((-q)+2.3*q-(-q)*(-p))/(3.8+(5.6-3.4+(-q))))
        z2 <== (y*6.8/((-7.1)+x)*x/7.7-((-y)+2.3*y-(-y)*(-x))/(3.8+(5.6-3.4+(-y))))
        print.cccc (I 4210) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4211
        !"test4211"
        z1 <== 0.1+(-2.0)+(2.3/1.4)*(-q)/(p-(-3.7))+(-7.4)/((-2.1)/6.2/(-7.4)/(p-3.1-q-6.6)*(q*(-q)*(-q)-3.2+q)/(-5.0)/(-8.7))
        z2 <== 0.1+(-2.0)+(2.3/1.4)*(-y)/(x-(-3.7))+(-7.4)/((-2.1)/6.2/(-7.4)/(x-3.1-y-6.6)*(y*(-y)*(-y)-3.2+y)/(-5.0)/(-8.7))
        print.cccc (I 4211) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4212
        !"test4212"
        z1 <== p
        z2 <== x
        print.cccc (I 4212) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4213
        !"test4213"
        z1 <== ((-4.3)*1.8/7.3-(-7.4)/p)
        z2 <== ((-4.3)*1.8/7.3-(-7.4)/x)
        print.cccc (I 4213) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4214
        !"test4214"
        z1 <== ((-2.1)-(1.0/((-q)/8.5-(-p)-(-p)/q))+(6.0/4.2/4.8+(-p))+(-5.6)/(-p)+p+((-0.2)+(-0.1)*(-q))/(-q)*1.4)
        z2 <== ((-2.1)-(1.0/((-y)/8.5-(-x)-(-x)/y))+(6.0/4.2/4.8+(-x))+(-5.6)/(-x)+x+((-0.2)+(-0.1)*(-y))/(-y)*1.4)
        print.cccc (I 4214) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4215
        !"test4215"
        z1 <== p
        z2 <== x
        print.cccc (I 4215) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4216
        !"test4216"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 4216) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4217
        !"test4217"
        z1 <== ((-6.4)*(-p)+(-2.4)+((-1.0)*(-8.8)-2.7/p)*q+(p*(-5.5)+(-p))-(-q)*((-q))/(-p)+((-6.6)*(-p)/(-6.6)-(-p)/(-p)))
        z2 <== ((-6.4)*(-x)+(-2.4)+((-1.0)*(-8.8)-2.7/x)*y+(x*(-5.5)+(-x))-(-y)*((-y))/(-x)+((-6.6)*(-x)/(-6.6)-(-x)/(-x)))
        print.cccc (I 4217) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4218
        !"test4218"
        z1 <== ((-q)-q-(-4.1)*p/((7.3-(-6.4)-(-8.5)-(-2.8))+2.1)*(-0.1))
        z2 <== ((-y)-y-(-4.1)*x/((7.3-(-6.4)-(-8.5)-(-2.8))+2.1)*(-0.1))
        print.cccc (I 4218) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4219
        !"test4219"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4219) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4220
        !"test4220"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4220) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4221
        !"test4221"
        z1 <== ((-2.2)/((-3.8))-(-8.4))
        z2 <== ((-2.2)/((-3.8))-(-8.4))
        print.cccc (I 4221) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4222
        !"test4222"
        z1 <== ((-p)-((-q)-q-q))
        z2 <== ((-x)-((-y)-y-y))
        print.cccc (I 4222) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4223
        !"test4223"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 4223) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4224
        !"test4224"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 4224) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4225
        !"test4225"
        z1 <== ((-1.4))
        z2 <== ((-1.4))
        print.cccc (I 4225) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4226
        !"test4226"
        z1 <== p
        z2 <== x
        print.cccc (I 4226) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4227
        !"test4227"
        z1 <== (-4.1)/(-q)-p-(-p)-p
        z2 <== (-4.1)/(-y)-x-(-x)-x
        print.cccc (I 4227) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4228
        !"test4228"
        z1 <== ((-6.7)*(-3.2)*0.5/(-7.6)-q*(-q)-5.4*(-0.0)+(1.6+(-0.2)/4.3+(-q)-(-q)/(-8.6)*(q+(-p))-(-p))*(8.3+(-q)/(-2.3)+6.6*(-6.2)*((-q)+(-7.1)))/q+(((-2.8)/p+(-q))+(-6.5)/(-5.1)/((-p)*3.0)+(8.4*(-p))))
        z2 <== ((-6.7)*(-3.2)*0.5/(-7.6)-y*(-y)-5.4*(-0.0)+(1.6+(-0.2)/4.3+(-y)-(-y)/(-8.6)*(y+(-x))-(-x))*(8.3+(-y)/(-2.3)+6.6*(-6.2)*((-y)+(-7.1)))/y+(((-2.8)/x+(-y))+(-6.5)/(-5.1)/((-x)*3.0)+(8.4*(-x))))
        print.cccc (I 4228) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4229
        !"test4229"
        z1 <== (((-q)*((-p)/q+(-q)))+((p+7.5)+p/(p+p)/(4.2/(-7.8)-8.4))-(0.0/(p/(-6.4)*(-0.1)/(-q))))
        z2 <== (((-y)*((-x)/y+(-y)))+((x+7.5)+x/(x+x)/(4.2/(-7.8)-8.4))-(0.0/(x/(-6.4)*(-0.1)/(-y))))
        print.cccc (I 4229) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4230
        !"test4230"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 4230) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4231
        !"test4231"
        z1 <== q
        z2 <== y
        print.cccc (I 4231) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4232
        !"test4232"
        z1 <== (1.5/p-3.0-(-7.4)/5.1+(-p)+((8.4+p-4.7*(-7.5))*((-q)-5.0)))
        z2 <== (1.5/x-3.0-(-7.4)/5.1+(-x)+((8.4+x-4.7*(-7.5))*((-y)-5.0)))
        print.cccc (I 4232) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4233
        !"test4233"
        z1 <== (((-q)*(-3.3)+q-5.4+1.3*6.3/(q+p+(-q)*(-p)-6.2))+(-5.8)-(q/q/8.2-(-q))+(-8.0)*q+(-q)+(-3.3)+(-2.4))
        z2 <== (((-y)*(-3.3)+y-5.4+1.3*6.3/(y+x+(-y)*(-x)-6.2))+(-5.8)-(y/y/8.2-(-y))+(-8.0)*y+(-y)+(-3.3)+(-2.4))
        print.cccc (I 4233) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4234
        !"test4234"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 4234) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4235
        !"test4235"
        z1 <== (((q-(-5.5)/(-3.7))/(-5.0)+(-p)/(q-p*q)+((-7.0)-(-p)))-(-4.0)+(-0.1)/8.7+4.7-p*3.2+(-p)-0.2+((-p)*7.8/(-p)*4.1+(-q)))
        z2 <== (((y-(-5.5)/(-3.7))/(-5.0)+(-x)/(y-x*y)+((-7.0)-(-x)))-(-4.0)+(-0.1)/8.7+4.7-x*3.2+(-x)-0.2+((-x)*7.8/(-x)*4.1+(-y)))
        print.cccc (I 4235) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4236
        !"test4236"
        z1 <== ((p))
        z2 <== ((x))
        print.cccc (I 4236) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4237
        !"test4237"
        z1 <== q
        z2 <== y
        print.cccc (I 4237) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4238
        !"test4238"
        z1 <== (-8.6)+((-2.8)+(-1.0)-(-p)/(-0.1)-1.5)-(-q)
        z2 <== (-8.6)+((-2.8)+(-1.0)-(-x)/(-0.1)-1.5)-(-y)
        print.cccc (I 4238) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4239
        !"test4239"
        z1 <== (q/(6.0+(-0.3)-6.2+3.7)*5.0*((4.2-(-q)/p)))
        z2 <== (y/(6.0+(-0.3)-6.2+3.7)*5.0*((4.2-(-y)/x)))
        print.cccc (I 4239) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4240
        !"test4240"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4240) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4241
        !"test4241"
        z1 <== (((q+p))*p/((-p)))
        z2 <== (((y+x))*x/((-x)))
        print.cccc (I 4241) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4242
        !"test4242"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4242) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4243
        !"test4243"
        z1 <== 4.5
        z2 <== 4.5
        print.cccc (I 4243) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4244
        !"test4244"
        z1 <== (((q*(-1.5)-q/(-p)-(-q))+(-p)*q))
        z2 <== (((y*(-1.5)-y/(-x)-(-y))+(-x)*y))
        print.cccc (I 4244) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4245
        !"test4245"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 4245) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4246
        !"test4246"
        z1 <== ((4.1+(-6.0)*((-q)+q)+p+(p*(-q)-(-6.8)*5.6*(-3.7)))/(-q)-6.0-p)
        z2 <== ((4.1+(-6.0)*((-y)+y)+x+(x*(-y)-(-6.8)*5.6*(-3.7)))/(-y)-6.0-x)
        print.cccc (I 4246) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4247
        !"test4247"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4247) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4248
        !"test4248"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4248) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4249
        !"test4249"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 4249) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4250
        !"test4250"
        z1 <== ((-q)-(((-5.4)-p*q)/(-p))-(-q))
        z2 <== ((-y)-(((-5.4)-x*y)/(-x))-(-y))
        print.cccc (I 4250) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4251
        !"test4251"
        z1 <== ((-6.4)-(5.5*q/q*6.6)*(-p))
        z2 <== ((-6.4)-(5.5*y/y*6.6)*(-x))
        print.cccc (I 4251) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4252
        !"test4252"
        z1 <== ((-q)+(-1.0)/(-p)*(p/(5.0/(-7.8)*2.7/q*(-q))))
        z2 <== ((-y)+(-1.0)/(-x)*(x/(5.0/(-7.8)*2.7/y*(-y))))
        print.cccc (I 4252) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4253
        !"test4253"
        z1 <== p
        z2 <== x
        print.cccc (I 4253) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4254
        !"test4254"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 4254) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4255
        !"test4255"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4255) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4256
        !"test4256"
        z1 <== (q/(-1.2)/3.1+((q)-(-1.0))*((-q)+(-q)+q-(-p)/(-8.3)/(-q)-((-p)/4.1-(-q)-(-1.6)-(-6.3))*(0.7*(-0.7)/6.2/(-q))+(-4.6)))
        z2 <== (y/(-1.2)/3.1+((y)-(-1.0))*((-y)+(-y)+y-(-x)/(-8.3)/(-y)-((-x)/4.1-(-y)-(-1.6)-(-6.3))*(0.7*(-0.7)/6.2/(-y))+(-4.6)))
        print.cccc (I 4256) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4257
        !"test4257"
        z1 <== (((5.0/p)+(-6.3)/(7.3+(-8.2)*(-5.0))-(-2.1)))
        z2 <== (((5.0/x)+(-6.3)/(7.3+(-8.2)*(-5.0))-(-2.1)))
        print.cccc (I 4257) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4258
        !"test4258"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4258) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4259
        !"test4259"
        z1 <== q
        z2 <== y
        print.cccc (I 4259) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4260
        !"test4260"
        z1 <== ((0.8*3.8-(p*(-1.3))-((-7.1)-(-q)))-(7.0+p/4.8*p-(-6.5)*(-8.1)+(-p))*((-7.8))+p+(-0.8)/((-0.4)*(-q)-p*p)+(7.2+(-2.6)-(-p))+p/((-5.4)-q+p*4.8*(-7.2)/(-q)))
        z2 <== ((0.8*3.8-(x*(-1.3))-((-7.1)-(-y)))-(7.0+x/4.8*x-(-6.5)*(-8.1)+(-x))*((-7.8))+x+(-0.8)/((-0.4)*(-y)-x*x)+(7.2+(-2.6)-(-x))+x/((-5.4)-y+x*4.8*(-7.2)/(-y)))
        print.cccc (I 4260) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4261
        !"test4261"
        z1 <== p
        z2 <== x
        print.cccc (I 4261) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4262
        !"test4262"
        z1 <== p
        z2 <== x
        print.cccc (I 4262) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4263
        !"test4263"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 4263) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4264
        !"test4264"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4264) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4265
        !"test4265"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 4265) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4266
        !"test4266"
        z1 <== q
        z2 <== y
        print.cccc (I 4266) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4267
        !"test4267"
        z1 <== ((-4.0)/0.4+(((-8.3)+(-p)/3.4-(-1.5))-(-8.1))-(((-q))*(5.8+(-q))*((-4.2))-q-(5.4*(-2.8)/(-q)/(-7.0))))
        z2 <== ((-4.0)/0.4+(((-8.3)+(-x)/3.4-(-1.5))-(-8.1))-(((-y))*(5.8+(-y))*((-4.2))-y-(5.4*(-2.8)/(-y)/(-7.0))))
        print.cccc (I 4267) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4268
        !"test4268"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4268) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4269
        !"test4269"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4269) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4270
        !"test4270"
        z1 <== p
        z2 <== x
        print.cccc (I 4270) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4271
        !"test4271"
        z1 <== q
        z2 <== y
        print.cccc (I 4271) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4272
        !"test4272"
        z1 <== (((-4.2)-(6.3*(-q)))+7.4+(1.3))
        z2 <== (((-4.2)-(6.3*(-y)))+7.4+(1.3))
        print.cccc (I 4272) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4273
        !"test4273"
        z1 <== (7.5)
        z2 <== (7.5)
        print.cccc (I 4273) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4274
        !"test4274"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4274) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4275
        !"test4275"
        z1 <== (4.6*(0.5)+(-q))*6.5*4.7
        z2 <== (4.6*(0.5)+(-y))*6.5*4.7
        print.cccc (I 4275) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4276
        !"test4276"
        z1 <== (-5.3)/q/(4.7-((-2.8)+2.5/7.6)-((-5.3)*(-q)-1.8)/((-7.2))-(5.2+p))*q
        z2 <== (-5.3)/y/(4.7-((-2.8)+2.5/7.6)-((-5.3)*(-y)-1.8)/((-7.2))-(5.2+x))*y
        print.cccc (I 4276) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4277
        !"test4277"
        z1 <== ((((-p)+(-q)/(-q))-q-(p*q)-(p/(-5.0)+p)/p))
        z2 <== ((((-x)+(-y)/(-y))-y-(x*y)-(x/(-5.0)+x)/x))
        print.cccc (I 4277) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4278
        !"test4278"
        z1 <== ((-p)*(((-2.4))))
        z2 <== ((-x)*(((-2.4))))
        print.cccc (I 4278) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4279
        !"test4279"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4279) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4280
        !"test4280"
        z1 <== ((0.3-p-(-p)))
        z2 <== ((0.3-x-(-x)))
        print.cccc (I 4280) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4281
        !"test4281"
        z1 <== (((-7.4)/q/(-0.2)/(q)/(-p))-(-7.1))
        z2 <== (((-7.4)/y/(-0.2)/(y)/(-x))-(-7.1))
        print.cccc (I 4281) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4282
        !"test4282"
        z1 <== (1.0/7.7-(-0.8)*(-p))
        z2 <== (1.0/7.7-(-0.8)*(-x))
        print.cccc (I 4282) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4283
        !"test4283"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 4283) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4284
        !"test4284"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 4284) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4285
        !"test4285"
        z1 <== ((((-q)*q-7.1/(-p))*(q/(-8.1)*p+q)+((-3.0)+q/(-q))/(-q)-p)/(1.0-(7.7*5.6-(-6.3)-3.3*p)-(-7.4)-q)+(-5.4)/(4.7*2.7*(-q)*p))
        z2 <== ((((-y)*y-7.1/(-x))*(y/(-8.1)*x+y)+((-3.0)+y/(-y))/(-y)-x)/(1.0-(7.7*5.6-(-6.3)-3.3*x)-(-7.4)-y)+(-5.4)/(4.7*2.7*(-y)*x))
        print.cccc (I 4285) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4286
        !"test4286"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 4286) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4287
        !"test4287"
        z1 <== q
        z2 <== y
        print.cccc (I 4287) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4288
        !"test4288"
        z1 <== ((((-p)-q/q/0.7+(-3.6)))/((-q)/((-8.2)/(-p)+(-q)-(-p))-1.4-p-(p-(-p)/(-p)/(-8.2)*6.3))/(-4.4)+q)
        z2 <== ((((-x)-y/y/0.7+(-3.6)))/((-y)/((-8.2)/(-x)+(-y)-(-x))-1.4-x-(x-(-x)/(-x)/(-8.2)*6.3))/(-4.4)+y)
        print.cccc (I 4288) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4289
        !"test4289"
        z1 <== (((-p)-(-0.3))*(4.7)*8.3-(-q)/(2.4))
        z2 <== (((-x)-(-0.3))*(4.7)*8.3-(-y)/(2.4))
        print.cccc (I 4289) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4290
        !"test4290"
        z1 <== ((p-(-6.7)/((-q))+((-0.6)))*(-q)/((-4.3)-(q-(-q)/(-7.6))+(p)/((-2.5)+q))-6.7/(3.6/p/q+q)*(-6.1)-6.8*(-8.1))
        z2 <== ((x-(-6.7)/((-y))+((-0.6)))*(-y)/((-4.3)-(y-(-y)/(-7.6))+(x)/((-2.5)+y))-6.7/(3.6/x/y+y)*(-6.1)-6.8*(-8.1))
        print.cccc (I 4290) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4291
        !"test4291"
        z1 <== p
        z2 <== x
        print.cccc (I 4291) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4292
        !"test4292"
        z1 <== (4.6*p)/(q+(-q)/p-((-p)))
        z2 <== (4.6*x)/(y+(-y)/x-((-x)))
        print.cccc (I 4292) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4293
        !"test4293"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4293) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4294
        !"test4294"
        z1 <== ((-p)-q*(-p)/2.6+(-1.2)+0.2-((-8.3)+p/(-p)))
        z2 <== ((-x)-y*(-x)/2.6+(-1.2)+0.2-((-8.3)+x/(-x)))
        print.cccc (I 4294) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4295
        !"test4295"
        z1 <== ((2.1*(2.7+(-p))-(-q)+(-p)/(q)))
        z2 <== ((2.1*(2.7+(-x))-(-y)+(-x)/(y)))
        print.cccc (I 4295) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4296
        !"test4296"
        z1 <== ((0.8+(-p)*(-q)+4.6))-p*(-2.7)*(4.1)+((-5.8)/((-2.8)/(-7.0)-q-(-6.6)*(-4.5))-(0.0*(-p)-3.5+(-5.0)/(-q)))
        z2 <== ((0.8+(-x)*(-y)+4.6))-x*(-2.7)*(4.1)+((-5.8)/((-2.8)/(-7.0)-y-(-6.6)*(-4.5))-(0.0*(-x)-3.5+(-5.0)/(-y)))
        print.cccc (I 4296) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4297
        !"test4297"
        z1 <== p
        z2 <== x
        print.cccc (I 4297) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4298
        !"test4298"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 4298) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4299
        !"test4299"
        z1 <== ((8.0/(4.0-(-p))/8.0*(-q))*q*(((-6.1)/(-q)*(-2.0)-0.3*p)+(-2.5)*(p*1.7/p+3.5))-2.8)
        z2 <== ((8.0/(4.0-(-x))/8.0*(-y))*y*(((-6.1)/(-y)*(-2.0)-0.3*x)+(-2.5)*(x*1.7/x+3.5))-2.8)
        print.cccc (I 4299) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4300
        !"test4300"
        z1 <== q
        z2 <== y
        print.cccc (I 4300) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4301
        !"test4301"
        z1 <== ((-1.5)*(((-q)/q-(-p))-(0.3/(-5.6)-(-7.7))*(p*q+q)-(1.6))*((-7.1)/(6.1/1.8*q+(-4.4))*p/7.0+2.8/q+2.3+q)+((q*8.4+q-1.1)/(-6.4)-(-q)-p-p+(-q))/(((-6.0))*(-p)))
        z2 <== ((-1.5)*(((-y)/y-(-x))-(0.3/(-5.6)-(-7.7))*(x*y+y)-(1.6))*((-7.1)/(6.1/1.8*y+(-4.4))*x/7.0+2.8/y+2.3+y)+((y*8.4+y-1.1)/(-6.4)-(-y)-x-x+(-y))/(((-6.0))*(-x)))
        print.cccc (I 4301) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4302
        !"test4302"
        z1 <== q
        z2 <== y
        print.cccc (I 4302) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4303
        !"test4303"
        z1 <== (3.0/3.2)
        z2 <== (3.0/3.2)
        print.cccc (I 4303) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4304
        !"test4304"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 4304) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4305
        !"test4305"
        z1 <== (((6.4/(-5.6))+0.3)+((-8.8)-(-2.3)*((-q)-8.1*q*p+(-p))*(-p)*(-6.4))*((-1.5))-p)
        z2 <== (((6.4/(-5.6))+0.3)+((-8.8)-(-2.3)*((-y)-8.1*y*x+(-x))*(-x)*(-6.4))*((-1.5))-x)
        print.cccc (I 4305) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4306
        !"test4306"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 4306) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4307
        !"test4307"
        z1 <== ((((-p)*(-q)-(-8.4)*(-4.7)-(-p))+(q*(-p))*(q/4.8+p)))
        z2 <== ((((-x)*(-y)-(-8.4)*(-4.7)-(-x))+(y*(-x))*(y/4.8+x)))
        print.cccc (I 4307) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4308
        !"test4308"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4308) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4309
        !"test4309"
        z1 <== (-2.8)
        z2 <== (-2.8)
        print.cccc (I 4309) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4310
        !"test4310"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 4310) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4311
        !"test4311"
        z1 <== p
        z2 <== x
        print.cccc (I 4311) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4312
        !"test4312"
        z1 <== p
        z2 <== x
        print.cccc (I 4312) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4313
        !"test4313"
        z1 <== (((-q)+(-q)*3.3/4.3-(-p)+8.0-7.4/2.8+(-3.6)*(-6.2)/4.8/(5.3))*(-5.6)+(-2.7)+((-1.1)*((-p)+p/q-q))-(-1.7))
        z2 <== (((-y)+(-y)*3.3/4.3-(-x)+8.0-7.4/2.8+(-3.6)*(-6.2)/4.8/(5.3))*(-5.6)+(-2.7)+((-1.1)*((-x)+x/y-y))-(-1.7))
        print.cccc (I 4313) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4314
        !"test4314"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 4314) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4315
        !"test4315"
        z1 <== (((-7.5)/p+(8.6*(-5.6)/(-p)*p+0.5))-4.6+(0.6-q-(-1.2)-p)/4.5)
        z2 <== (((-7.5)/x+(8.6*(-5.6)/(-x)*x+0.5))-4.6+(0.6-y-(-1.2)-x)/4.5)
        print.cccc (I 4315) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4316
        !"test4316"
        z1 <== ((((-8.0))*(3.3*(-1.1)-p/(-p))/((-p)))*((-p)*((-3.1)*q*(-p))))
        z2 <== ((((-8.0))*(3.3*(-1.1)-x/(-x))/((-x)))*((-x)*((-3.1)*y*(-x))))
        print.cccc (I 4316) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4317
        !"test4317"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4317) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4318
        !"test4318"
        z1 <== ((p/(p/(-p)-6.8)*(-p)-(-p)-(-p)+(-q))/p)
        z2 <== ((x/(x/(-x)-6.8)*(-x)-(-x)-(-x)+(-y))/x)
        print.cccc (I 4318) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4319
        !"test4319"
        z1 <== (1.5*0.3)
        z2 <== (1.5*0.3)
        print.cccc (I 4319) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4320
        !"test4320"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 4320) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4321
        !"test4321"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 4321) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4322
        !"test4322"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 4322) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4323
        !"test4323"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4323) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4324
        !"test4324"
        z1 <== ((-0.3)*((-1.2)+1.5/3.8/(-5.5)/p)/(q-(-1.7)/p-q/(-6.6))/((-q))+((-p))*((3.0+4.1+(-3.5))-(q+(-p)-p*(-1.4)))-q/3.8-(-p)/(-4.8)+(p))
        z2 <== ((-0.3)*((-1.2)+1.5/3.8/(-5.5)/x)/(y-(-1.7)/x-y/(-6.6))/((-y))+((-x))*((3.0+4.1+(-3.5))-(y+(-x)-x*(-1.4)))-y/3.8-(-x)/(-4.8)+(x))
        print.cccc (I 4324) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4325
        !"test4325"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 4325) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4326
        !"test4326"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 4326) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4327
        !"test4327"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4327) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4328
        !"test4328"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 4328) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4329
        !"test4329"
        z1 <== (-5.4)
        z2 <== (-5.4)
        print.cccc (I 4329) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4330
        !"test4330"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 4330) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4331
        !"test4331"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 4331) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4332
        !"test4332"
        z1 <== ((q)+(q*2.0*q)-(-q))
        z2 <== ((y)+(y*2.0*y)-(-y))
        print.cccc (I 4332) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4333
        !"test4333"
        z1 <== (-3.8)
        z2 <== (-3.8)
        print.cccc (I 4333) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4334
        !"test4334"
        z1 <== (((6.1+(-p)-p/(-q))-(-q)+p)*(-0.8)/(-p))
        z2 <== (((6.1+(-x)-x/(-y))-(-y)+x)*(-0.8)/(-x))
        print.cccc (I 4334) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4335
        !"test4335"
        z1 <== ((-7.2)-3.8+(5.3+q-(-3.1)+p*1.4)+((-3.1)*p)*(-2.6)*p*(-q)*0.4-(-8.6)-(-2.2)*(-1.2)/((0.8*(-2.8)+5.5/2.8)-q+(3.4*p-0.2*6.0+(-0.4))+5.2-(-6.6)*(-q))*(p/(-3.8)+0.2*(-p)+p)+p-(p*(p+(-0.5)*5.8*(-q))))
        z2 <== ((-7.2)-3.8+(5.3+y-(-3.1)+x*1.4)+((-3.1)*x)*(-2.6)*x*(-y)*0.4-(-8.6)-(-2.2)*(-1.2)/((0.8*(-2.8)+5.5/2.8)-y+(3.4*x-0.2*6.0+(-0.4))+5.2-(-6.6)*(-y))*(x/(-3.8)+0.2*(-x)+x)+x-(x*(x+(-0.5)*5.8*(-y))))
        print.cccc (I 4335) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4336
        !"test4336"
        z1 <== q
        z2 <== y
        print.cccc (I 4336) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4337
        !"test4337"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4337) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4338
        !"test4338"
        z1 <== (((0.5+8.4+(-3.8)))*(q)-((0.1-(-q)-(-0.3)-2.0)/2.0)+((-p)+(-p)/7.6/(-2.7)/0.5))
        z2 <== (((0.5+8.4+(-3.8)))*(y)-((0.1-(-y)-(-0.3)-2.0)/2.0)+((-x)+(-x)/7.6/(-2.7)/0.5))
        print.cccc (I 4338) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4339
        !"test4339"
        z1 <== 7.0
        z2 <== 7.0
        print.cccc (I 4339) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4340
        !"test4340"
        z1 <== (((2.4))+(-p))
        z2 <== (((2.4))+(-x))
        print.cccc (I 4340) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4341
        !"test4341"
        z1 <== (q+8.1*1.2)
        z2 <== (y+8.1*1.2)
        print.cccc (I 4341) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4342
        !"test4342"
        z1 <== ((p+(q/q)+((-7.6)*0.8)/(-4.4))+((-2.5))/q)
        z2 <== ((x+(y/y)+((-7.6)*0.8)/(-4.4))+((-2.5))/y)
        print.cccc (I 4342) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4343
        !"test4343"
        z1 <== ((-0.2)+4.5*p/p*p-4.2*p-4.7+(-6.3)+6.4)
        z2 <== ((-0.2)+4.5*x/x*x-4.2*x-4.7+(-6.3)+6.4)
        print.cccc (I 4343) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4344
        !"test4344"
        z1 <== (q-(-2.2)-((-p)/(1.8+(-0.4)*1.5*6.6/(-p))))
        z2 <== (y-(-2.2)-((-x)/(1.8+(-0.4)*1.5*6.6/(-x))))
        print.cccc (I 4344) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4345
        !"test4345"
        z1 <== ((((-2.4)-(-1.7)))/6.3-(-p)-(-6.8)/6.8-p*(-q)*(-q)+(-0.7)*(-p)+(((-p)+6.6/(-5.3)-(-p)-(-p))))
        z2 <== ((((-2.4)-(-1.7)))/6.3-(-x)-(-6.8)/6.8-x*(-y)*(-y)+(-0.7)*(-x)+(((-x)+6.6/(-5.3)-(-x)-(-x))))
        print.cccc (I 4345) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4346
        !"test4346"
        z1 <== p
        z2 <== x
        print.cccc (I 4346) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4347
        !"test4347"
        z1 <== p
        z2 <== x
        print.cccc (I 4347) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4348
        !"test4348"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4348) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4349
        !"test4349"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4349) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4350
        !"test4350"
        z1 <== ((-p)/((-8.1)+(-8.3)-p*q-q/(0.6-p+q-(-4.4)/(-q)))/p+q)
        z2 <== ((-x)/((-8.1)+(-8.3)-x*y-y/(0.6-x+y-(-4.4)/(-y)))/x+y)
        print.cccc (I 4350) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4351
        !"test4351"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 4351) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4352
        !"test4352"
        z1 <== 4.6
        z2 <== 4.6
        print.cccc (I 4352) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4353
        !"test4353"
        z1 <== p
        z2 <== x
        print.cccc (I 4353) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4354
        !"test4354"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 4354) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4355
        !"test4355"
        z1 <== p
        z2 <== x
        print.cccc (I 4355) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4356
        !"test4356"
        z1 <== (((-0.7)/((-2.8)/(-q))/p/p)/1.6*5.1-(-q)/3.3*(-p)+p+q-(-3.8)*((-p)))
        z2 <== (((-0.7)/((-2.8)/(-y))/x/x)/1.6*5.1-(-y)/3.3*(-x)+x+y-(-3.8)*((-x)))
        print.cccc (I 4356) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4357
        !"test4357"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 4357) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4358
        !"test4358"
        z1 <== (-8.7)
        z2 <== (-8.7)
        print.cccc (I 4358) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4359
        !"test4359"
        z1 <== (-0.2)
        z2 <== (-0.2)
        print.cccc (I 4359) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4360
        !"test4360"
        z1 <== (6.7-(((-8.0)*(-2.6)-p*(-q))-(p+p*4.3)-q-(-5.6))-(((-8.8)+6.2/q*(-p)+8.2)/6.1+(-4.0)-(-2.1)-p*(-8.2)*(-p))*(((-p)/(-1.8)*q*q+8.2)*5.4))
        z2 <== (6.7-(((-8.0)*(-2.6)-x*(-y))-(x+x*4.3)-y-(-5.6))-(((-8.8)+6.2/y*(-x)+8.2)/6.1+(-4.0)-(-2.1)-x*(-8.2)*(-x))*(((-x)/(-1.8)*y*y+8.2)*5.4))
        print.cccc (I 4360) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4361
        !"test4361"
        z1 <== (-0.8)
        z2 <== (-0.8)
        print.cccc (I 4361) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4362
        !"test4362"
        z1 <== p
        z2 <== x
        print.cccc (I 4362) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4363
        !"test4363"
        z1 <== ((-q)/((-6.2)/((-6.2)+8.7-1.7/2.3)*((-4.8)*q/p)-((-p)/8.8-(-8.8)-6.5+5.7)))
        z2 <== ((-y)/((-6.2)/((-6.2)+8.7-1.7/2.3)*((-4.8)*y/x)-((-x)/8.8-(-8.8)-6.5+5.7)))
        print.cccc (I 4363) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4364
        !"test4364"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 4364) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4365
        !"test4365"
        z1 <== (-6.1)/(-2.2)
        z2 <== (-6.1)/(-2.2)
        print.cccc (I 4365) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4366
        !"test4366"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 4366) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4367
        !"test4367"
        z1 <== (((-q)+(-7.7)*8.7)-(4.7-5.5-8.8+(-6.7))+p/p-((-3.4)+p-q+(-2.3)*(-p))/q+((-0.1)*((-p)/(-p))*(-1.0)))
        z2 <== (((-y)+(-7.7)*8.7)-(4.7-5.5-8.8+(-6.7))+x/x-((-3.4)+x-y+(-2.3)*(-x))/y+((-0.1)*((-x)/(-x))*(-1.0)))
        print.cccc (I 4367) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4368
        !"test4368"
        z1 <== (((-p)-p/p/7.3+(-3.4)-(-5.2)/(-q)/(q/(-5.3)/4.6-q-(-p)))-p/(0.1/(p-3.2)-(3.4/(-7.1)/(-8.8)*7.4/(-6.1)))+(-4.3))
        z2 <== (((-x)-x/x/7.3+(-3.4)-(-5.2)/(-y)/(y/(-5.3)/4.6-y-(-x)))-x/(0.1/(x-3.2)-(3.4/(-7.1)/(-8.8)*7.4/(-6.1)))+(-4.3))
        print.cccc (I 4368) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4369
        !"test4369"
        z1 <== (3.3/4.6+1.3-5.0+(-p)-4.4*((-8.2))-((-3.3)*0.5*(-p)/6.2)-(-p))
        z2 <== (3.3/4.6+1.3-5.0+(-x)-4.4*((-8.2))-((-3.3)*0.5*(-x)/6.2)-(-x))
        print.cccc (I 4369) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4370
        !"test4370"
        z1 <== (0.2)
        z2 <== (0.2)
        print.cccc (I 4370) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4371
        !"test4371"
        z1 <== p-p
        z2 <== x-x
        print.cccc (I 4371) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4372
        !"test4372"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4372) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4373
        !"test4373"
        z1 <== (((-q))+(-1.1))
        z2 <== (((-y))+(-1.1))
        print.cccc (I 4373) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4374
        !"test4374"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 4374) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4375
        !"test4375"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4375) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4376
        !"test4376"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4376) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4377
        !"test4377"
        z1 <== q
        z2 <== y
        print.cccc (I 4377) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4378
        !"test4378"
        z1 <== p
        z2 <== x
        print.cccc (I 4378) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4379
        !"test4379"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 4379) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4380
        !"test4380"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 4380) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4381
        !"test4381"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4381) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4382
        !"test4382"
        z1 <== (q*(-6.4)/(-p)+((-5.5)+q-(-3.3)+(4.8/4.4)-((-8.3)))-p+((-1.7))-((-q)+(-2.2)-(-3.2))/(8.4-(-p)+(-8.6)))
        z2 <== (y*(-6.4)/(-x)+((-5.5)+y-(-3.3)+(4.8/4.4)-((-8.3)))-x+((-1.7))-((-y)+(-2.2)-(-3.2))/(8.4-(-x)+(-8.6)))
        print.cccc (I 4382) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4383
        !"test4383"
        z1 <== (p*7.6)
        z2 <== (x*7.6)
        print.cccc (I 4383) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4384
        !"test4384"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 4384) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4385
        !"test4385"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4385) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4386
        !"test4386"
        z1 <== ((q-((-2.2))/(-0.6)+((-p))-(-1.4))+(-p)-(((-p)-5.5/1.0)))
        z2 <== ((y-((-2.2))/(-0.6)+((-x))-(-1.4))+(-x)-(((-x)-5.5/1.0)))
        print.cccc (I 4386) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4387
        !"test4387"
        z1 <== p
        z2 <== x
        print.cccc (I 4387) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4388
        !"test4388"
        z1 <== 3.2
        z2 <== 3.2
        print.cccc (I 4388) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4389
        !"test4389"
        z1 <== 0.8
        z2 <== 0.8
        print.cccc (I 4389) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4390
        !"test4390"
        z1 <== (-q)-((q)+(4.7-6.3)-q/3.5+3.1)-((-p)+q+q*(-5.2)-p)*p
        z2 <== (-y)-((y)+(4.7-6.3)-y/3.5+3.1)-((-x)+y+y*(-5.2)-x)*x
        print.cccc (I 4390) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4391
        !"test4391"
        z1 <== ((q-(-4.5)))/(1.0+(-5.3)-(-q)/(-q)+(-0.7)-p-1.3)*3.8/((q+p+p)-p-4.7*(-q))
        z2 <== ((y-(-4.5)))/(1.0+(-5.3)-(-y)/(-y)+(-0.7)-x-1.3)*3.8/((y+x+x)-x-4.7*(-y))
        print.cccc (I 4391) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4392
        !"test4392"
        z1 <== ((-p)/(-q)-p)
        z2 <== ((-x)/(-y)-x)
        print.cccc (I 4392) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4393
        !"test4393"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 4393) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4394
        !"test4394"
        z1 <== 4.2+(((-6.4)+p)+((-p)))-q/(((-q)*(-8.2)/q-(-5.1)-(-p))+(p)*((-q)+q+3.2-6.3))
        z2 <== 4.2+(((-6.4)+x)+((-x)))-y/(((-y)*(-8.2)/y-(-5.1)-(-x))+(x)*((-y)+y+3.2-6.3))
        print.cccc (I 4394) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4395
        !"test4395"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 4395) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4396
        !"test4396"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 4396) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4397
        !"test4397"
        z1 <== (-6.4)
        z2 <== (-6.4)
        print.cccc (I 4397) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4398
        !"test4398"
        z1 <== p
        z2 <== x
        print.cccc (I 4398) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4399
        !"test4399"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4399) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4400
        !"test4400"
        z1 <== ((p/(-7.1)*((-0.8)-p-q+(-p))))
        z2 <== ((x/(-7.1)*((-0.8)-x-y+(-x))))
        print.cccc (I 4400) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4401
        !"test4401"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 4401) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4402
        !"test4402"
        z1 <== (-0.6)
        z2 <== (-0.6)
        print.cccc (I 4402) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4403
        !"test4403"
        z1 <== q
        z2 <== y
        print.cccc (I 4403) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4404
        !"test4404"
        z1 <== (-0.3)
        z2 <== (-0.3)
        print.cccc (I 4404) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4405
        !"test4405"
        z1 <== (q+(((-p)-(-7.5)-6.4))*((-3.7)+(-q)+(-q))+((p*6.0*(-5.2))-q+(-7.5))+0.7)
        z2 <== (y+(((-x)-(-7.5)-6.4))*((-3.7)+(-y)+(-y))+((x*6.0*(-5.2))-y+(-7.5))+0.7)
        print.cccc (I 4405) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4406
        !"test4406"
        z1 <== q
        z2 <== y
        print.cccc (I 4406) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4407
        !"test4407"
        z1 <== ((((-p)/4.7*(-8.8)+q)-((-p)*(-p)-p-q/4.0)+p)-((p/(-6.0)*(-1.0)*(-2.0)))*(p*q-p-q/((-3.2)*q)/(-3.6)-(-8.0))+p)
        z2 <== ((((-x)/4.7*(-8.8)+y)-((-x)*(-x)-x-y/4.0)+x)-((x/(-6.0)*(-1.0)*(-2.0)))*(x*y-x-y/((-3.2)*y)/(-3.6)-(-8.0))+x)
        print.cccc (I 4407) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4408
        !"test4408"
        z1 <== ((-q)/6.3/(-0.4)+(-q)+((-3.6)+(-q)+5.3-p))
        z2 <== ((-y)/6.3/(-0.4)+(-y)+((-3.6)+(-y)+5.3-x))
        print.cccc (I 4408) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4409
        !"test4409"
        z1 <== (-2.0)
        z2 <== (-2.0)
        print.cccc (I 4409) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4410
        !"test4410"
        z1 <== (q/q/p-(7.0-(-7.0)/p+(-8.5)*p-(-q)*(7.2*(-q)*(-q)-(-q)-(-q)))-(6.6+(-7.8)/2.7-1.6))
        z2 <== (y/y/x-(7.0-(-7.0)/x+(-8.5)*x-(-y)*(7.2*(-y)*(-y)-(-y)-(-y)))-(6.6+(-7.8)/2.7-1.6))
        print.cccc (I 4410) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4411
        !"test4411"
        z1 <== (((-4.8)*((-3.7)-q+(-8.0)*0.2-8.4))*p-4.2/((-5.0)/0.4/(-p)*(-p))+(-p)+3.1/p)
        z2 <== (((-4.8)*((-3.7)-y+(-8.0)*0.2-8.4))*x-4.2/((-5.0)/0.4/(-x)*(-x))+(-x)+3.1/x)
        print.cccc (I 4411) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4412
        !"test4412"
        z1 <== ((-p)/q+(((-0.4)*4.2)/0.7*q))
        z2 <== ((-x)/y+(((-0.4)*4.2)/0.7*y))
        print.cccc (I 4412) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4413
        !"test4413"
        z1 <== p
        z2 <== x
        print.cccc (I 4413) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4414
        !"test4414"
        z1 <== q
        z2 <== y
        print.cccc (I 4414) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4415
        !"test4415"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4415) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4416
        !"test4416"
        z1 <== ((-q)+5.4)
        z2 <== ((-y)+5.4)
        print.cccc (I 4416) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4417
        !"test4417"
        z1 <== (((8.4+q)/((-5.0)/2.0*(-6.3)/(-5.0))-(-q)*p)+(((-8.2)/p*6.5)/(-p)*1.0))
        z2 <== (((8.4+y)/((-5.0)/2.0*(-6.3)/(-5.0))-(-y)*x)+(((-8.2)/x*6.5)/(-x)*1.0))
        print.cccc (I 4417) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4418
        !"test4418"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 4418) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4419
        !"test4419"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 4419) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4420
        !"test4420"
        z1 <== (((q-(-2.3))-(-1.4))*(-p)*(p+7.6)-(-q)+(6.6/(-5.7)+p/(-6.0))+((-4.8)+(-1.0))/(-p)-(8.2-((-1.3)/0.2/(-p)/p/(-p))*((-7.8)-3.7*4.5)+((-7.0)*q)))
        z2 <== (((y-(-2.3))-(-1.4))*(-x)*(x+7.6)-(-y)+(6.6/(-5.7)+x/(-6.0))+((-4.8)+(-1.0))/(-x)-(8.2-((-1.3)/0.2/(-x)/x/(-x))*((-7.8)-3.7*4.5)+((-7.0)*y)))
        print.cccc (I 4420) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4421
        !"test4421"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4421) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4422
        !"test4422"
        z1 <== (q+(q-q-(-1.8)+(-p))-0.5*(-7.0)/8.3)
        z2 <== (y+(y-y-(-1.8)+(-x))-0.5*(-7.0)/8.3)
        print.cccc (I 4422) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4423
        !"test4423"
        z1 <== (-0.0)
        z2 <== (-0.0)
        print.cccc (I 4423) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4424
        !"test4424"
        z1 <== (5.5)
        z2 <== (5.5)
        print.cccc (I 4424) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4425
        !"test4425"
        z1 <== ((-p)-(((-2.4)+(-0.2)-p)*0.1+((-7.0))/8.6/(-0.4))*(-0.1))
        z2 <== ((-x)-(((-2.4)+(-0.2)-x)*0.1+((-7.0))/8.6/(-0.4))*(-0.1))
        print.cccc (I 4425) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4426
        !"test4426"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4426) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4427
        !"test4427"
        z1 <== ((-8.0)+(((-8.0)*(-5.8)))*(6.1*((-4.1))-(-p)*(-7.6)/(3.3+(-8.0)+(-q)))+((p)/4.2/(-p)*(5.0-5.7/(-7.3)+(-1.1)-(-5.2))*q)-q)
        z2 <== ((-8.0)+(((-8.0)*(-5.8)))*(6.1*((-4.1))-(-x)*(-7.6)/(3.3+(-8.0)+(-y)))+((x)/4.2/(-x)*(5.0-5.7/(-7.3)+(-1.1)-(-5.2))*y)-y)
        print.cccc (I 4427) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4428
        !"test4428"
        z1 <== (((0.8*6.7*(-4.3))-(-p)+(-p)))
        z2 <== (((0.8*6.7*(-4.3))-(-x)+(-x)))
        print.cccc (I 4428) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4429
        !"test4429"
        z1 <== p
        z2 <== x
        print.cccc (I 4429) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4430
        !"test4430"
        z1 <== ((-p)+(-p)+(-p)/p-4.1*(((-6.5))))
        z2 <== ((-x)+(-x)+(-x)/x-4.1*(((-6.5))))
        print.cccc (I 4430) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4431
        !"test4431"
        z1 <== p
        z2 <== x
        print.cccc (I 4431) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4432
        !"test4432"
        z1 <== (q*p)
        z2 <== (y*x)
        print.cccc (I 4432) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4433
        !"test4433"
        z1 <== ((-q)-(1.3))
        z2 <== ((-y)-(1.3))
        print.cccc (I 4433) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4434
        !"test4434"
        z1 <== (-2.4)
        z2 <== (-2.4)
        print.cccc (I 4434) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4435
        !"test4435"
        z1 <== 0.6
        z2 <== 0.6
        print.cccc (I 4435) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4436
        !"test4436"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4436) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4437
        !"test4437"
        z1 <== (((-p)/p*q+(-6.6))+((-6.5)+(-5.4)/(-4.1)-(-6.4))-0.1-(-4.7))
        z2 <== (((-x)/x*y+(-6.6))+((-6.5)+(-5.4)/(-4.1)-(-6.4))-0.1-(-4.7))
        print.cccc (I 4437) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4438
        !"test4438"
        z1 <== ((((-p)+(-q)-7.3))-(-5.3)*(p*p/(q)/(0.3-(-q)))+((p)+((-0.4)+(-4.1)-6.0)+(0.6-q*(-q)))-((p*4.3)))
        z2 <== ((((-x)+(-y)-7.3))-(-5.3)*(x*x/(y)/(0.3-(-y)))+((x)+((-0.4)+(-4.1)-6.0)+(0.6-y*(-y)))-((x*4.3)))
        print.cccc (I 4438) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4439
        !"test4439"
        z1 <== (6.8-(-6.4)-((-2.4)-((-1.7))+(-p)*p+(7.6-(-8.3)*7.5-p))+(-q))
        z2 <== (6.8-(-6.4)-((-2.4)-((-1.7))+(-x)*x+(7.6-(-8.3)*7.5-x))+(-y))
        print.cccc (I 4439) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4440
        !"test4440"
        z1 <== ((-q)-(-7.7)+((-7.6)))
        z2 <== ((-y)-(-7.7)+((-7.6)))
        print.cccc (I 4440) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4441
        !"test4441"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 4441) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4442
        !"test4442"
        z1 <== ((6.0*(-3.0)-((-8.6))*((-1.0)/p)+(p-q*q+p/(-q)))+0.8-p+p)
        z2 <== ((6.0*(-3.0)-((-8.6))*((-1.0)/x)+(x-y*y+x/(-y)))+0.8-x+x)
        print.cccc (I 4442) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4443
        !"test4443"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4443) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4444
        !"test4444"
        z1 <== (8.7+(-p))
        z2 <== (8.7+(-x))
        print.cccc (I 4444) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4445
        !"test4445"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 4445) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4446
        !"test4446"
        z1 <== (((0.1+8.6)/(3.7/p-q)-(-p)+(8.4+(-7.4)*q/(-q)))*(-6.6)*((p+6.2/(-0.6)-(-q)/(-p))/(3.2-4.0/q)*(8.2*p))/(((-1.1)-(-q)/6.6-8.8*(-4.4)))-(-6.4))
        z2 <== (((0.1+8.6)/(3.7/x-y)-(-x)+(8.4+(-7.4)*y/(-y)))*(-6.6)*((x+6.2/(-0.6)-(-y)/(-x))/(3.2-4.0/y)*(8.2*x))/(((-1.1)-(-y)/6.6-8.8*(-4.4)))-(-6.4))
        print.cccc (I 4446) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4447
        !"test4447"
        z1 <== 0.7
        z2 <== 0.7
        print.cccc (I 4447) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4448
        !"test4448"
        z1 <== (-3.2)
        z2 <== (-3.2)
        print.cccc (I 4448) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4449
        !"test4449"
        z1 <== (p-1.3)
        z2 <== (x-1.3)
        print.cccc (I 4449) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4450
        !"test4450"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 4450) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4451
        !"test4451"
        z1 <== (-7.0)
        z2 <== (-7.0)
        print.cccc (I 4451) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4452
        !"test4452"
        z1 <== p
        z2 <== x
        print.cccc (I 4452) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4453
        !"test4453"
        z1 <== ((-6.5)/(-p)/(q)/(0.4/(-3.4))-q)
        z2 <== ((-6.5)/(-x)/(y)/(0.4/(-3.4))-y)
        print.cccc (I 4453) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4454
        !"test4454"
        z1 <== (q+(-q)-(p))
        z2 <== (y+(-y)-(x))
        print.cccc (I 4454) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4455
        !"test4455"
        z1 <== 5.4
        z2 <== 5.4
        print.cccc (I 4455) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4456
        !"test4456"
        z1 <== ((0.0*(6.3+q+1.6*0.2)/(-8.0)/(-p))+p)
        z2 <== ((0.0*(6.3+y+1.6*0.2)/(-8.0)/(-x))+x)
        print.cccc (I 4456) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4457
        !"test4457"
        z1 <== (p-(-p)+(-p)/(8.0-q+(-p)*(-q)*(-0.5)+((-p)+1.4/1.7+(-q)+(-8.3))/p)*7.5)
        z2 <== (x-(-x)+(-x)/(8.0-y+(-x)*(-y)*(-0.5)+((-x)+1.4/1.7+(-y)+(-8.3))/x)*7.5)
        print.cccc (I 4457) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4458
        !"test4458"
        z1 <== p
        z2 <== x
        print.cccc (I 4458) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4459
        !"test4459"
        z1 <== p
        z2 <== x
        print.cccc (I 4459) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4460
        !"test4460"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4460) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4461
        !"test4461"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4461) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4462
        !"test4462"
        z1 <== q
        z2 <== y
        print.cccc (I 4462) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4463
        !"test4463"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 4463) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4464
        !"test4464"
        z1 <== (((-q)*q*(-p)+(-p)*(7.3*(-5.1)*3.4))-(-2.8)*(1.3+(q*q)/q)-q-(-p)*(-6.4)*q/q/0.0+6.2-(-7.5)-0.4*p)
        z2 <== (((-y)*y*(-x)+(-x)*(7.3*(-5.1)*3.4))-(-2.8)*(1.3+(y*y)/y)-y-(-x)*(-6.4)*y/y/0.0+6.2-(-7.5)-0.4*x)
        print.cccc (I 4464) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4465
        !"test4465"
        z1 <== ((((-2.4)/(-q)+6.0*(-4.5)))*q/(-5.5)/q)
        z2 <== ((((-2.4)/(-y)+6.0*(-4.5)))*y/(-5.5)/y)
        print.cccc (I 4465) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4466
        !"test4466"
        z1 <== q*(-7.6)/(((-p))-(p+q*p-(-0.0)+p))
        z2 <== y*(-7.6)/(((-x))-(x+y*x-(-0.0)+x))
        print.cccc (I 4466) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4467
        !"test4467"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 4467) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4468
        !"test4468"
        z1 <== q
        z2 <== y
        print.cccc (I 4468) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4469
        !"test4469"
        z1 <== p
        z2 <== x
        print.cccc (I 4469) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4470
        !"test4470"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4470) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4471
        !"test4471"
        z1 <== 2.1+((1.2-6.2-(-4.6)+4.3*6.6))+1.7*q
        z2 <== 2.1+((1.2-6.2-(-4.6)+4.3*6.6))+1.7*y
        print.cccc (I 4471) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4472
        !"test4472"
        z1 <== (((-q)+q-4.0*8.7/(-p)*8.3)*((q-(-p)+3.8)/7.6-((-8.6)+(-q)*(-q))*(-p))-q+2.8+(3.4)*8.6+8.4*(-p)/((-q)+(-q)+(-8.7))/(-8.4))
        z2 <== (((-y)+y-4.0*8.7/(-x)*8.3)*((y-(-x)+3.8)/7.6-((-8.6)+(-y)*(-y))*(-x))-y+2.8+(3.4)*8.6+8.4*(-x)/((-y)+(-y)+(-8.7))/(-8.4))
        print.cccc (I 4472) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4473
        !"test4473"
        z1 <== ((((-p)*p*(-p))/7.5-((-q)/4.4-1.5/(-q)))/2.6-(0.6*(-q)*1.4))
        z2 <== ((((-x)*x*(-x))/7.5-((-y)/4.4-1.5/(-y)))/2.6-(0.6*(-y)*1.4))
        print.cccc (I 4473) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4474
        !"test4474"
        z1 <== 6.3
        z2 <== 6.3
        print.cccc (I 4474) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4475
        !"test4475"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4475) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4476
        !"test4476"
        z1 <== ((-p)-(-p)-(-5.4))
        z2 <== ((-x)-(-x)-(-5.4))
        print.cccc (I 4476) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4477
        !"test4477"
        z1 <== (-1.6)
        z2 <== (-1.6)
        print.cccc (I 4477) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4478
        !"test4478"
        z1 <== p
        z2 <== x
        print.cccc (I 4478) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4479
        !"test4479"
        z1 <== (1.7+8.7+6.8*(1.0+(-q)-p+(-q)-((-q)*3.3-1.4/(-p))*q/p)*(p+((-p)/(-q)*(-q)-(-p)-(-p))/((-q)+(-7.6)+(-p)+p)/p))
        z2 <== (1.7+8.7+6.8*(1.0+(-y)-x+(-y)-((-y)*3.3-1.4/(-x))*y/x)*(x+((-x)/(-y)*(-y)-(-x)-(-x))/((-y)+(-7.6)+(-x)+x)/x))
        print.cccc (I 4479) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4480
        !"test4480"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 4480) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4481
        !"test4481"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 4481) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4482
        !"test4482"
        z1 <== p
        z2 <== x
        print.cccc (I 4482) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4483
        !"test4483"
        z1 <== p
        z2 <== x
        print.cccc (I 4483) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4484
        !"test4484"
        z1 <== q
        z2 <== y
        print.cccc (I 4484) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4485
        !"test4485"
        z1 <== 3.3
        z2 <== 3.3
        print.cccc (I 4485) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4486
        !"test4486"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4486) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4487
        !"test4487"
        z1 <== (((q+(-q)))+(-q)-(-3.6)/q)
        z2 <== (((y+(-y)))+(-y)-(-3.6)/y)
        print.cccc (I 4487) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4488
        !"test4488"
        z1 <== ((p/(-q)+(-p)+(-8.2)*6.7*8.4/(-4.8)+(-q)+((-4.8)*0.6/(-q)+(-3.5))*((-8.6)+q+(-p)-(-p)))+(-5.2)*(-q))
        z2 <== ((x/(-y)+(-x)+(-8.2)*6.7*8.4/(-4.8)+(-y)+((-4.8)*0.6/(-y)+(-3.5))*((-8.6)+y+(-x)-(-x)))+(-5.2)*(-y))
        print.cccc (I 4488) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4489
        !"test4489"
        z1 <== q
        z2 <== y
        print.cccc (I 4489) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4490
        !"test4490"
        z1 <== ((-1.3)/(p))
        z2 <== ((-1.3)/(x))
        print.cccc (I 4490) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4491
        !"test4491"
        z1 <== 1.4
        z2 <== 1.4
        print.cccc (I 4491) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4492
        !"test4492"
        z1 <== (-1.2)
        z2 <== (-1.2)
        print.cccc (I 4492) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4493
        !"test4493"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4493) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4494
        !"test4494"
        z1 <== ((-7.1)+(-2.3)/6.8*(8.8*0.0*(-1.1)))
        z2 <== ((-7.1)+(-2.3)/6.8*(8.8*0.0*(-1.1)))
        print.cccc (I 4494) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4495
        !"test4495"
        z1 <== p
        z2 <== x
        print.cccc (I 4495) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4496
        !"test4496"
        z1 <== ((p+(p+(-q)*(-p)*(-q))/((-p)*(-q)+(-8.0))/7.2))
        z2 <== ((x+(x+(-y)*(-x)*(-y))/((-x)*(-y)+(-8.0))/7.2))
        print.cccc (I 4496) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4497
        !"test4497"
        z1 <== (((-2.5)-4.0)+((-q)))/(-8.5)+((-5.2)/6.1+((-p)/(-p))*q)
        z2 <== (((-2.5)-4.0)+((-y)))/(-8.5)+((-5.2)/6.1+((-x)/(-x))*y)
        print.cccc (I 4497) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4498
        !"test4498"
        z1 <== (((-p)-(-7.1)))
        z2 <== (((-x)-(-7.1)))
        print.cccc (I 4498) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4499
        !"test4499"
        z1 <== q-(((-0.1)*(-p)/(-0.8)+(-0.0)+2.1)+(q/p*6.5)*(q*(-p)-(-p)/q))-((-1.0)-q+5.2*(-p)*p*8.4)+(((-p)*p)/((-p)/q/p+(-q)/5.3))
        z2 <== y-(((-0.1)*(-x)/(-0.8)+(-0.0)+2.1)+(y/x*6.5)*(y*(-x)-(-x)/y))-((-1.0)-y+5.2*(-x)*x*8.4)+(((-x)*x)/((-x)/y/x+(-y)/5.3))
        print.cccc (I 4499) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4500
        !"test4500"
        z1 <== (p*((-0.1))+(-p)-(-8.3)+(-5.3)*q/(-6.8)+((-8.4)))+q*(-4.7)*(-p)-p*1.3*q+q/(q-((-q)*p-q+(-p))*5.8/0.5-(-q)-(-p)/q)/(-0.8)
        z2 <== (x*((-0.1))+(-x)-(-8.3)+(-5.3)*y/(-6.8)+((-8.4)))+y*(-4.7)*(-x)-x*1.3*y+y/(y-((-y)*x-y+(-x))*5.8/0.5-(-y)-(-x)/y)/(-0.8)
        print.cccc (I 4500) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4501
        !"test4501"
        z1 <== ((5.4*0.8-(1.5*(-q)))*3.1)
        z2 <== ((5.4*0.8-(1.5*(-y)))*3.1)
        print.cccc (I 4501) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4502
        !"test4502"
        z1 <== 8.7
        z2 <== 8.7
        print.cccc (I 4502) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4503
        !"test4503"
        z1 <== ((-6.0)+(((-3.5)+(-3.0)*(-7.6)-q+q)+((-q)))-((-q))+2.7*(-4.4))
        z2 <== ((-6.0)+(((-3.5)+(-3.0)*(-7.6)-y+y)+((-y)))-((-y))+2.7*(-4.4))
        print.cccc (I 4503) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4504
        !"test4504"
        z1 <== ((-3.6)+(-8.3)-((-q)*0.2-(-p)/6.1+(-6.0)*(-1.3)/7.0)+(3.3+q*p+(p)*(-8.5)))
        z2 <== ((-3.6)+(-8.3)-((-y)*0.2-(-x)/6.1+(-6.0)*(-1.3)/7.0)+(3.3+y*x+(x)*(-8.5)))
        print.cccc (I 4504) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4505
        !"test4505"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4505) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4506
        !"test4506"
        z1 <== (5.2*(-4.7)/(-2.1)/((-q)*(-2.2)+(-q)-q+q+(6.5/(-q)-p/(-p))-(-p)))
        z2 <== (5.2*(-4.7)/(-2.1)/((-y)*(-2.2)+(-y)-y+y+(6.5/(-y)-x/(-x))-(-x)))
        print.cccc (I 4506) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4507
        !"test4507"
        z1 <== ((q/(-2.1)+(-p))-((-q)*q+(-p)-p))
        z2 <== ((y/(-2.1)+(-x))-((-y)*y+(-x)-x))
        print.cccc (I 4507) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4508
        !"test4508"
        z1 <== (q+((-p)/1.5-2.6+3.6-(-q))*3.5)
        z2 <== (y+((-x)/1.5-2.6+3.6-(-y))*3.5)
        print.cccc (I 4508) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4509
        !"test4509"
        z1 <== ((q-(5.7/p*(-p)-(-3.0)-q)-(p)*(-3.5))+((p-p-q/1.0+(-8.7))*q)*((-5.2)/(-p))/q*((-2.3)-q*(-q)/(2.3/8.4+0.1/(-p)-(-6.5))*(-7.7)))
        z2 <== ((y-(5.7/x*(-x)-(-3.0)-y)-(x)*(-3.5))+((x-x-y/1.0+(-8.7))*y)*((-5.2)/(-x))/y*((-2.3)-y*(-y)/(2.3/8.4+0.1/(-x)-(-6.5))*(-7.7)))
        print.cccc (I 4509) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4510
        !"test4510"
        z1 <== 3.7
        z2 <== 3.7
        print.cccc (I 4510) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4511
        !"test4511"
        z1 <== 5.0
        z2 <== 5.0
        print.cccc (I 4511) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4512
        !"test4512"
        z1 <== p
        z2 <== x
        print.cccc (I 4512) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4513
        !"test4513"
        z1 <== p
        z2 <== x
        print.cccc (I 4513) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4514
        !"test4514"
        z1 <== ((-q)-2.7+q*q-6.5-((-0.0)/q*(-4.6))/(-5.6)+q+2.0)
        z2 <== ((-y)-2.7+y*y-6.5-((-0.0)/y*(-4.6))/(-5.6)+y+2.0)
        print.cccc (I 4514) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4515
        !"test4515"
        z1 <== q
        z2 <== y
        print.cccc (I 4515) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4516
        !"test4516"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 4516) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4517
        !"test4517"
        z1 <== p
        z2 <== x
        print.cccc (I 4517) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4518
        !"test4518"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 4518) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4519
        !"test4519"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 4519) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4520
        !"test4520"
        z1 <== (((6.3/1.1*q)/((-7.2)*(-q)*(-0.3)-(-6.7)*p)-p))
        z2 <== (((6.3/1.1*y)/((-7.2)*(-y)*(-0.3)-(-6.7)*x)-x))
        print.cccc (I 4520) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4521
        !"test4521"
        z1 <== (-7.6)-((-p)-q+(-q)+(-7.0)+q)-(p+p/p*p+p)*(-3.4)/(-p)-(-6.1)-p
        z2 <== (-7.6)-((-x)-y+(-y)+(-7.0)+y)-(x+x/x*x+x)*(-3.4)/(-x)-(-6.1)-x
        print.cccc (I 4521) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4522
        !"test4522"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 4522) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4523
        !"test4523"
        z1 <== ((p+q)-((q)/(-p)*(-q)+1.8+8.4))
        z2 <== ((x+y)-((y)/(-x)*(-y)+1.8+8.4))
        print.cccc (I 4523) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4524
        !"test4524"
        z1 <== q
        z2 <== y
        print.cccc (I 4524) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4525
        !"test4525"
        z1 <== ((-p)-p+2.4-((-6.7)-6.8/p)/q/p/(-3.0))
        z2 <== ((-x)-x+2.4-((-6.7)-6.8/x)/y/x/(-3.0))
        print.cccc (I 4525) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4526
        !"test4526"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4526) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4527
        !"test4527"
        z1 <== ((0.2+5.3-((-0.1)+6.2/4.0)/q+(-q)-4.0-0.3/(-5.6))/(-4.6))
        z2 <== ((0.2+5.3-((-0.1)+6.2/4.0)/y+(-y)-4.0-0.3/(-5.6))/(-4.6))
        print.cccc (I 4527) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4528
        !"test4528"
        z1 <== ((((-6.3))/(2.6+6.6+1.4)-((-4.1)*6.8)*(-q))/(-8.7))
        z2 <== ((((-6.3))/(2.6+6.6+1.4)-((-4.1)*6.8)*(-y))/(-8.7))
        print.cccc (I 4528) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4529
        !"test4529"
        z1 <== q
        z2 <== y
        print.cccc (I 4529) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4530
        !"test4530"
        z1 <== ((((-6.8)*(-6.2))+(-2.6)))
        z2 <== ((((-6.8)*(-6.2))+(-2.6)))
        print.cccc (I 4530) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4531
        !"test4531"
        z1 <== (-0.8)
        z2 <== (-0.8)
        print.cccc (I 4531) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4532
        !"test4532"
        z1 <== q
        z2 <== y
        print.cccc (I 4532) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4533
        !"test4533"
        z1 <== ((-6.6)*(6.2*(-1.1)/(-q))-(q))/(-2.0)/(((-7.3)*p-(-3.6)+5.5))+((1.6-1.6)/p/((-p)/p))-(((-3.0))+4.7-(p*(-p)*q/q/1.5)-((-6.7)+(-q)/0.7))
        z2 <== ((-6.6)*(6.2*(-1.1)/(-y))-(y))/(-2.0)/(((-7.3)*x-(-3.6)+5.5))+((1.6-1.6)/x/((-x)/x))-(((-3.0))+4.7-(x*(-x)*y/y/1.5)-((-6.7)+(-y)/0.7))
        print.cccc (I 4533) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4534
        !"test4534"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4534) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4535
        !"test4535"
        z1 <== ((-0.4)-(-p)-(((-p)/(-5.4))*(-p)-((-8.5)))+(-4.6))
        z2 <== ((-0.4)-(-x)-(((-x)/(-5.4))*(-x)-((-8.5)))+(-4.6))
        print.cccc (I 4535) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4536
        !"test4536"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4536) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4537
        !"test4537"
        z1 <== q
        z2 <== y
        print.cccc (I 4537) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4538
        !"test4538"
        z1 <== (0.4/0.5+((-q)-(-p))+p/(-q))
        z2 <== (0.4/0.5+((-y)-(-x))+x/(-y))
        print.cccc (I 4538) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4539
        !"test4539"
        z1 <== (((-5.4)+(-q)/p+(-p)*q*(-2.0)-((-q)-(-3.8)/2.7)-(-q)+p-q)-4.8+(((-p)-(-p)*(-q)+(-p))-((-6.2)-(-q)/2.0)+q)/(-6.8))
        z2 <== (((-5.4)+(-y)/x+(-x)*y*(-2.0)-((-y)-(-3.8)/2.7)-(-y)+x-y)-4.8+(((-x)-(-x)*(-y)+(-x))-((-6.2)-(-y)/2.0)+y)/(-6.8))
        print.cccc (I 4539) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4540
        !"test4540"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4540) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4541
        !"test4541"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 4541) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4542
        !"test4542"
        z1 <== (-0.5)
        z2 <== (-0.5)
        print.cccc (I 4542) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4543
        !"test4543"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4543) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4544
        !"test4544"
        z1 <== 5.3
        z2 <== 5.3
        print.cccc (I 4544) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4545
        !"test4545"
        z1 <== (-6.0)
        z2 <== (-6.0)
        print.cccc (I 4545) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4546
        !"test4546"
        z1 <== (q-(-q))
        z2 <== (y-(-y))
        print.cccc (I 4546) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4547
        !"test4547"
        z1 <== q
        z2 <== y
        print.cccc (I 4547) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4548
        !"test4548"
        z1 <== (6.0*3.5+((q-8.8/5.5)*q)+q)
        z2 <== (6.0*3.5+((y-8.8/5.5)*y)+y)
        print.cccc (I 4548) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4549
        !"test4549"
        z1 <== (-q)-3.5+((-p)/(-p)-((-q)-(-p)/(-q)))
        z2 <== (-y)-3.5+((-x)/(-x)-((-y)-(-x)/(-y)))
        print.cccc (I 4549) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4550
        !"test4550"
        z1 <== q
        z2 <== y
        print.cccc (I 4550) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4551
        !"test4551"
        z1 <== p
        z2 <== x
        print.cccc (I 4551) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4552
        !"test4552"
        z1 <== 2.4
        z2 <== 2.4
        print.cccc (I 4552) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4553
        !"test4553"
        z1 <== (7.5+((3.3*q+5.8+8.6)-p+7.4+(7.2+(-7.5))+p)*7.7+(-2.8)-q)
        z2 <== (7.5+((3.3*y+5.8+8.6)-x+7.4+(7.2+(-7.5))+x)*7.7+(-2.8)-y)
        print.cccc (I 4553) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4554
        !"test4554"
        z1 <== (((-p)*(-1.3)/((-q))+(-5.2))/(-p)+(8.8-((-3.4))+q))
        z2 <== (((-x)*(-1.3)/((-y))+(-5.2))/(-x)+(8.8-((-3.4))+y))
        print.cccc (I 4554) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4555
        !"test4555"
        z1 <== ((-q)/((-p)+(-q)*(-1.5)-q)/(q*(-p))+0.5+(-7.7))*q/(4.6)/(((-q)-0.5+q/(-5.6)/q)*(-q)*(5.8+q+(-p)+p)*(-5.3)+p)
        z2 <== ((-y)/((-x)+(-y)*(-1.5)-y)/(y*(-x))+0.5+(-7.7))*y/(4.6)/(((-y)-0.5+y/(-5.6)/y)*(-y)*(5.8+y+(-x)+x)*(-5.3)+x)
        print.cccc (I 4555) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4556
        !"test4556"
        z1 <== 7.7
        z2 <== 7.7
        print.cccc (I 4556) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4557
        !"test4557"
        z1 <== (p*(-q)*(-q)-(q-2.7*q+q/(-4.5))+q+(-3.0)/3.6)
        z2 <== (x*(-y)*(-y)-(y-2.7*y+y/(-4.5))+y+(-3.0)/3.6)
        print.cccc (I 4557) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4558
        !"test4558"
        z1 <== p
        z2 <== x
        print.cccc (I 4558) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4559
        !"test4559"
        z1 <== (-p)-(-q)/(((-p)))/(7.7-(-p)+(-q)/(-q))*(-0.5)
        z2 <== (-x)-(-y)/(((-x)))/(7.7-(-x)+(-y)/(-y))*(-0.5)
        print.cccc (I 4559) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4560
        !"test4560"
        z1 <== (0.8)
        z2 <== (0.8)
        print.cccc (I 4560) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4561
        !"test4561"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4561) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4562
        !"test4562"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4562) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4563
        !"test4563"
        z1 <== (-1.5)
        z2 <== (-1.5)
        print.cccc (I 4563) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4564
        !"test4564"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 4564) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4565
        !"test4565"
        z1 <== (((-p)/0.0-(-7.8)+(3.5*(-p)/(-q)))-2.2/((-0.4)*q+(-2.1)/7.2-(-3.0))-(p*(-q)-(-p)/8.8)/(p/0.0-0.7*(-7.7)-(-q)*(-7.1))*1.6)
        z2 <== (((-x)/0.0-(-7.8)+(3.5*(-x)/(-y)))-2.2/((-0.4)*y+(-2.1)/7.2-(-3.0))-(x*(-y)-(-x)/8.8)/(x/0.0-0.7*(-7.7)-(-y)*(-7.1))*1.6)
        print.cccc (I 4565) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4566
        !"test4566"
        z1 <== p-3.8-p*((7.6/(-p)-8.5-(-0.5))*p-((-q)+q))-8.5
        z2 <== x-3.8-x*((7.6/(-x)-8.5-(-0.5))*x-((-y)+y))-8.5
        print.cccc (I 4566) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4567
        !"test4567"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 4567) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4568
        !"test4568"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 4568) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4569
        !"test4569"
        z1 <== 1.0
        z2 <== 1.0
        print.cccc (I 4569) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4570
        !"test4570"
        z1 <== p
        z2 <== x
        print.cccc (I 4570) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4571
        !"test4571"
        z1 <== (-3.2)
        z2 <== (-3.2)
        print.cccc (I 4571) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4572
        !"test4572"
        z1 <== p
        z2 <== x
        print.cccc (I 4572) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4573
        !"test4573"
        z1 <== q
        z2 <== y
        print.cccc (I 4573) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4574
        !"test4574"
        z1 <== 8.3
        z2 <== 8.3
        print.cccc (I 4574) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4575
        !"test4575"
        z1 <== (-8.4)
        z2 <== (-8.4)
        print.cccc (I 4575) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4576
        !"test4576"
        z1 <== p
        z2 <== x
        print.cccc (I 4576) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4577
        !"test4577"
        z1 <== ((4.7+4.8-p))
        z2 <== ((4.7+4.8-x))
        print.cccc (I 4577) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4578
        !"test4578"
        z1 <== p
        z2 <== x
        print.cccc (I 4578) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4579
        !"test4579"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 4579) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4580
        !"test4580"
        z1 <== ((((-q)-p))/p+(-4.8))
        z2 <== ((((-y)-x))/x+(-4.8))
        print.cccc (I 4580) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4581
        !"test4581"
        z1 <== (q+((-8.0))-(-1.7)-q*((6.6-q/(-7.0)-(-p)*(-p))/1.5/(-p)*6.7*(-2.5)+(-7.5)+(-q)-((-8.1)/q*5.0*p-3.6)*(-6.2))-2.8)
        z2 <== (y+((-8.0))-(-1.7)-y*((6.6-y/(-7.0)-(-x)*(-x))/1.5/(-x)*6.7*(-2.5)+(-7.5)+(-y)-((-8.1)/y*5.0*x-3.6)*(-6.2))-2.8)
        print.cccc (I 4581) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4582
        !"test4582"
        z1 <== (((-q)/4.2-7.8*(-4.2)+(-q)+q*p+(-p)*(-q)-(-4.8)+((-7.1)/(-0.5)+p+(-q)*(-q))+(-q))*p/p)
        z2 <== (((-y)/4.2-7.8*(-4.2)+(-y)+y*x+(-x)*(-y)-(-4.8)+((-7.1)/(-0.5)+x+(-y)*(-y))+(-y))*x/x)
        print.cccc (I 4582) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4583
        !"test4583"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4583) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4584
        !"test4584"
        z1 <== (-2.2)+(-p)-(0.5+8.4/(-q)/p*(-q)-(q)/(q*(-p)*1.1))
        z2 <== (-2.2)+(-x)-(0.5+8.4/(-y)/x*(-y)-(y)/(y*(-x)*1.1))
        print.cccc (I 4584) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4585
        !"test4585"
        z1 <== (-5.5)
        z2 <== (-5.5)
        print.cccc (I 4585) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4586
        !"test4586"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 4586) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4587
        !"test4587"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 4587) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4588
        !"test4588"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 4588) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4589
        !"test4589"
        z1 <== (-p)+(q/7.5-4.3-(-q)-(-q))*(-8.6)*(-4.2)-p-(p+(2.5))
        z2 <== (-x)+(y/7.5-4.3-(-y)-(-y))*(-8.6)*(-4.2)-x-(x+(2.5))
        print.cccc (I 4589) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4590
        !"test4590"
        z1 <== p*((1.4)-(p-q+(-p)*p-7.7)*(-q)+p)-(q)
        z2 <== x*((1.4)-(x-y+(-x)*x-7.7)*(-y)+x)-(y)
        print.cccc (I 4590) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4591
        !"test4591"
        z1 <== ((1.7)-((-q)-0.8-q)-(1.5*(-4.1)*2.8)*(-p))
        z2 <== ((1.7)-((-y)-0.8-y)-(1.5*(-4.1)*2.8)*(-x))
        print.cccc (I 4591) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4592
        !"test4592"
        z1 <== ((-4.8)-p*(((-p)+(-p)/q/(-6.7)/0.7)*(-4.3)-(q*7.4)*(4.8*(-q)*p*(-3.2)/p))/((-4.4)/(-p)/8.7)-(q*((-0.0)*(-p))/((-p))))
        z2 <== ((-4.8)-x*(((-x)+(-x)/y/(-6.7)/0.7)*(-4.3)-(y*7.4)*(4.8*(-y)*x*(-3.2)/x))/((-4.4)/(-x)/8.7)-(y*((-0.0)*(-x))/((-x))))
        print.cccc (I 4592) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4593
        !"test4593"
        z1 <== (-7.2)
        z2 <== (-7.2)
        print.cccc (I 4593) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4594
        !"test4594"
        z1 <== p
        z2 <== x
        print.cccc (I 4594) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4595
        !"test4595"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4595) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4596
        !"test4596"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4596) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4597
        !"test4597"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4597) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4598
        !"test4598"
        z1 <== (((-8.1)/p*q+1.2+(-q))/(8.2-(-p)))*((-q)/(p-(-5.0)/q+8.4+q)*((-0.1)))-q-(q/(-q)+2.5)/3.8
        z2 <== (((-8.1)/x*y+1.2+(-y))/(8.2-(-x)))*((-y)/(x-(-5.0)/y+8.4+y)*((-0.1)))-y-(y/(-y)+2.5)/3.8
        print.cccc (I 4598) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4599
        !"test4599"
        z1 <== p*4.3-(p)*(-8.1)
        z2 <== x*4.3-(x)*(-8.1)
        print.cccc (I 4599) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4600
        !"test4600"
        z1 <== 4.1
        z2 <== 4.1
        print.cccc (I 4600) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4601
        !"test4601"
        z1 <== q
        z2 <== y
        print.cccc (I 4601) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4602
        !"test4602"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4602) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4603
        !"test4603"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4603) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4604
        !"test4604"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4604) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4605
        !"test4605"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4605) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4606
        !"test4606"
        z1 <== (-0.4)
        z2 <== (-0.4)
        print.cccc (I 4606) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4607
        !"test4607"
        z1 <== ((((-2.7)*2.4)-(-q)+1.0*(-p))*((-p)-((-2.6)+(-q))-(-p)*3.7)*((-8.6)+(-6.0)+(-p)*p)+p+(-p))
        z2 <== ((((-2.7)*2.4)-(-y)+1.0*(-x))*((-x)-((-2.6)+(-y))-(-x)*3.7)*((-8.6)+(-6.0)+(-x)*x)+x+(-x))
        print.cccc (I 4607) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4608
        !"test4608"
        z1 <== p
        z2 <== x
        print.cccc (I 4608) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4609
        !"test4609"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4609) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4610
        !"test4610"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4610) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4611
        !"test4611"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4611) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4612
        !"test4612"
        z1 <== (q+3.0-(-1.8)+((-2.5)/((-3.3)+1.6+(-p))+(4.0*(-q)+(-2.4)+7.8+q)+(q)))
        z2 <== (y+3.0-(-1.8)+((-2.5)/((-3.3)+1.6+(-x))+(4.0*(-y)+(-2.4)+7.8+y)+(y)))
        print.cccc (I 4612) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4613
        !"test4613"
        z1 <== (4.6-(-7.6)*((-3.7)+(-p)-0.8)/(p/(-q)+(-7.7)+6.5*q)/5.5)
        z2 <== (4.6-(-7.6)*((-3.7)+(-x)-0.8)/(x/(-y)+(-7.7)+6.5*y)/5.5)
        print.cccc (I 4613) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4614
        !"test4614"
        z1 <== (2.7-(-2.6)*8.2)
        z2 <== (2.7-(-2.6)*8.2)
        print.cccc (I 4614) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4615
        !"test4615"
        z1 <== q
        z2 <== y
        print.cccc (I 4615) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4616
        !"test4616"
        z1 <== (-8.5)
        z2 <== (-8.5)
        print.cccc (I 4616) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4617
        !"test4617"
        z1 <== 6.5-(((-q)-(-q)+(-p))-p/(-1.1)*(q*(-p))-8.4)-((-q)*(2.0*(-q)*3.2)+2.1/(-2.2))
        z2 <== 6.5-(((-y)-(-y)+(-x))-x/(-1.1)*(y*(-x))-8.4)-((-y)*(2.0*(-y)*3.2)+2.1/(-2.2))
        print.cccc (I 4617) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4618
        !"test4618"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4618) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4619
        !"test4619"
        z1 <== (1.7+p+(p*((-5.1)/q*6.7-(-1.4))/(-0.5))/((-2.8)))
        z2 <== (1.7+x+(x*((-5.1)/y*6.7-(-1.4))/(-0.5))/((-2.8)))
        print.cccc (I 4619) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4620
        !"test4620"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4620) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4621
        !"test4621"
        z1 <== (7.2)
        z2 <== (7.2)
        print.cccc (I 4621) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4622
        !"test4622"
        z1 <== (2.6-(3.8-(-5.7)*p)-((-q)/(-7.1)/(-p))+(-q)+(-q)*(-4.1)+8.7-q/(-1.1)-(-q))
        z2 <== (2.6-(3.8-(-5.7)*x)-((-y)/(-7.1)/(-x))+(-y)+(-y)*(-4.1)+8.7-y/(-1.1)-(-y))
        print.cccc (I 4622) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4623
        !"test4623"
        z1 <== p
        z2 <== x
        print.cccc (I 4623) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4624
        !"test4624"
        z1 <== ((-5.8)/5.6/(q/(3.2-8.2/(-3.8))+(-0.1)/(-4.0)+((-1.3)/(-5.1)+q)))
        z2 <== ((-5.8)/5.6/(y/(3.2-8.2/(-3.8))+(-0.1)/(-4.0)+((-1.3)/(-5.1)+y)))
        print.cccc (I 4624) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4625
        !"test4625"
        z1 <== ((-p)*((-q)/(-1.7)))
        z2 <== ((-x)*((-y)/(-1.7)))
        print.cccc (I 4625) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4626
        !"test4626"
        z1 <== ((-6.3)/(8.2*q-q)/q*p-((-4.8)*p-(-q)*4.1*(-2.0))-(p-1.7)*(-3.5)-p/(-0.7)*(((-5.7)/(-5.6)*5.1/p)+(-p)/(-p)/(-p)*6.6-3.5))
        z2 <== ((-6.3)/(8.2*y-y)/y*x-((-4.8)*x-(-y)*4.1*(-2.0))-(x-1.7)*(-3.5)-x/(-0.7)*(((-5.7)/(-5.6)*5.1/x)+(-x)/(-x)/(-x)*6.6-3.5))
        print.cccc (I 4626) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4627
        !"test4627"
        z1 <== q
        z2 <== y
        print.cccc (I 4627) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4628
        !"test4628"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 4628) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4629
        !"test4629"
        z1 <== ((8.6-p/2.8*((-q)*q+(-7.0)-p*1.7)*4.4)+(8.8*(-q)/(-q)+(-q)/(7.4-5.8+p/q)))
        z2 <== ((8.6-x/2.8*((-y)*y+(-7.0)-x*1.7)*4.4)+(8.8*(-y)/(-y)+(-y)/(7.4-5.8+x/y)))
        print.cccc (I 4629) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4630
        !"test4630"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4630) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4631
        !"test4631"
        z1 <== (-1.7)
        z2 <== (-1.7)
        print.cccc (I 4631) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4632
        !"test4632"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4632) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4633
        !"test4633"
        z1 <== p
        z2 <== x
        print.cccc (I 4633) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4634
        !"test4634"
        z1 <== ((-6.0)/0.7+2.7)/(3.0/(-q)+(-p)-5.4-p)
        z2 <== ((-6.0)/0.7+2.7)/(3.0/(-y)+(-x)-5.4-x)
        print.cccc (I 4634) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4635
        !"test4635"
        z1 <== p
        z2 <== x
        print.cccc (I 4635) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4636
        !"test4636"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4636) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4637
        !"test4637"
        z1 <== ((q/(-7.2)*(-0.3))/4.2/((-8.4))*(7.0+q)-q+(-3.5)-q/p*(-3.4)+(-p)-((5.5-p/(-7.6))-(-6.5))/(2.8*(-2.6)-(6.0-q/(-p)-(-q)/q)*8.5+q)/(-q))
        z2 <== ((y/(-7.2)*(-0.3))/4.2/((-8.4))*(7.0+y)-y+(-3.5)-y/x*(-3.4)+(-x)-((5.5-x/(-7.6))-(-6.5))/(2.8*(-2.6)-(6.0-y/(-x)-(-y)/y)*8.5+y)/(-y))
        print.cccc (I 4637) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4638
        !"test4638"
        z1 <== (((q-p+p)/0.3-6.7+q+(-5.6)+(-8.5)/q)/p+2.1/(p*(-0.3)*q*(-q)))
        z2 <== (((y-x+x)/0.3-6.7+y+(-5.6)+(-8.5)/y)/x+2.1/(x*(-0.3)*y*(-y)))
        print.cccc (I 4638) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4639
        !"test4639"
        z1 <== (-6.6)
        z2 <== (-6.6)
        print.cccc (I 4639) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4640
        !"test4640"
        z1 <== p
        z2 <== x
        print.cccc (I 4640) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4641
        !"test4641"
        z1 <== ((((-2.1)*7.7/q-(-p))/(3.6*(-q)-(-p)*(-q)/q)+(-p)/3.7-q/(q+(-1.4)+q-(-6.0)))+(1.0/(8.2))-(p*(-p)*2.1*p)+(p/(-1.4)+5.0/(-8.8))+1.5-4.2/q/(1.3-(1.7/6.4)*(-q)))
        z2 <== ((((-2.1)*7.7/y-(-x))/(3.6*(-y)-(-x)*(-y)/y)+(-x)/3.7-y/(y+(-1.4)+y-(-6.0)))+(1.0/(8.2))-(x*(-x)*2.1*x)+(x/(-1.4)+5.0/(-8.8))+1.5-4.2/y/(1.3-(1.7/6.4)*(-y)))
        print.cccc (I 4641) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4642
        !"test4642"
        z1 <== p
        z2 <== x
        print.cccc (I 4642) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4643
        !"test4643"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4643) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4644
        !"test4644"
        z1 <== (((-p)*((-2.7)+p+(-q)-p)+(-7.4)+(-p)/((-5.7)))+(0.7*(q+(-q))-(-8.4)+p)-3.5-((-2.5)+1.6)*(5.7/7.6*(6.0*6.2/(-q)*(-q)*(-p))+((-1.0)*(-4.5)-1.8*p)))
        z2 <== (((-x)*((-2.7)+x+(-y)-x)+(-7.4)+(-x)/((-5.7)))+(0.7*(y+(-y))-(-8.4)+x)-3.5-((-2.5)+1.6)*(5.7/7.6*(6.0*6.2/(-y)*(-y)*(-x))+((-1.0)*(-4.5)-1.8*x)))
        print.cccc (I 4644) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4645
        !"test4645"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4645) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4646
        !"test4646"
        z1 <== (-8.2)
        z2 <== (-8.2)
        print.cccc (I 4646) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4647
        !"test4647"
        z1 <== 3.0-4.2*q-((0.2-(-q)-(-q))+((-p))-(-p)*(p))-(-2.8)+(-q)/q*p
        z2 <== 3.0-4.2*y-((0.2-(-y)-(-y))+((-x))-(-x)*(x))-(-2.8)+(-y)/y*x
        print.cccc (I 4647) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4648
        !"test4648"
        z1 <== ((p*(-4.0)*3.1)/(((-p))/(4.6)-(-4.6)-((-p)+(-q))-((-q)/(-p)))/q*(p/(-2.6)-(-q)+(-q))+(-q))
        z2 <== ((x*(-4.0)*3.1)/(((-x))/(4.6)-(-4.6)-((-x)+(-y))-((-y)/(-x)))/y*(x/(-2.6)-(-y)+(-y))+(-y))
        print.cccc (I 4648) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4649
        !"test4649"
        z1 <== 1.6
        z2 <== 1.6
        print.cccc (I 4649) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4650
        !"test4650"
        z1 <== (q-(-1.5)/(((-7.0)*(-q))+7.5-(-p)-3.5*3.7-p+3.2/(-q)))
        z2 <== (y-(-1.5)/(((-7.0)*(-y))+7.5-(-x)-3.5*3.7-x+3.2/(-y)))
        print.cccc (I 4650) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4651
        !"test4651"
        z1 <== (-6.4)
        z2 <== (-6.4)
        print.cccc (I 4651) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4652
        !"test4652"
        z1 <== (5.3)
        z2 <== (5.3)
        print.cccc (I 4652) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4653
        !"test4653"
        z1 <== (6.0/p*((-q)+(-3.5)+(-5.5)-(-q)+(-2.5))-(p+(-2.0)-p*(-q))+2.2-3.7*2.5)
        z2 <== (6.0/x*((-y)+(-3.5)+(-5.5)-(-y)+(-2.5))-(x+(-2.0)-x*(-y))+2.2-3.7*2.5)
        print.cccc (I 4653) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4654
        !"test4654"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4654) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4655
        !"test4655"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 4655) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4656
        !"test4656"
        z1 <== (2.5-8.6*(-0.6)-(-7.8))
        z2 <== (2.5-8.6*(-0.6)-(-7.8))
        print.cccc (I 4656) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4657
        !"test4657"
        z1 <== (6.1/p-(-q)-(-1.6)-(-p)*(-p)*((-5.3)-(-p)*(-3.5)/q)*(p+q)+6.5*(p/p+(-q)/(-q))+((-7.2)/(-8.6)-8.1)/q-(-p)/2.7-(0.1/(-p))+((-6.1)-p/(-p))*(q+(-5.5)/0.0+(-2.4)/p)/(-1.4))
        z2 <== (6.1/x-(-y)-(-1.6)-(-x)*(-x)*((-5.3)-(-x)*(-3.5)/y)*(x+y)+6.5*(x/x+(-y)/(-y))+((-7.2)/(-8.6)-8.1)/y-(-x)/2.7-(0.1/(-x))+((-6.1)-x/(-x))*(y+(-5.5)/0.0+(-2.4)/x)/(-1.4))
        print.cccc (I 4657) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4658
        !"test4658"
        z1 <== (-7.4)
        z2 <== (-7.4)
        print.cccc (I 4658) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4659
        !"test4659"
        z1 <== (((-0.7))/(-q)+((-p)/(-p)*(-7.1)/(-q))+(-p))
        z2 <== (((-0.7))/(-y)+((-x)/(-x)*(-7.1)/(-y))+(-x))
        print.cccc (I 4659) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4660
        !"test4660"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4660) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4661
        !"test4661"
        z1 <== q
        z2 <== y
        print.cccc (I 4661) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4662
        !"test4662"
        z1 <== 0.2
        z2 <== 0.2
        print.cccc (I 4662) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4663
        !"test4663"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4663) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4664
        !"test4664"
        z1 <== (-7.2)-(-2.8)
        z2 <== (-7.2)-(-2.8)
        print.cccc (I 4664) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4665
        !"test4665"
        z1 <== 7.4
        z2 <== 7.4
        print.cccc (I 4665) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4666
        !"test4666"
        z1 <== (-8.1)-p
        z2 <== (-8.1)-x
        print.cccc (I 4666) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4667
        !"test4667"
        z1 <== (p/(q+2.5/q-q*(-p)*(-q)-((-p)*(-5.0))/(-5.6)/q-7.5-(-3.7))/(-4.4)/((-q)*1.0-((-5.0)/q*(-q)/(-6.2))/((-p))))
        z2 <== (x/(y+2.5/y-y*(-x)*(-y)-((-x)*(-5.0))/(-5.6)/y-7.5-(-3.7))/(-4.4)/((-y)*1.0-((-5.0)/y*(-y)/(-6.2))/((-x))))
        print.cccc (I 4667) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4668
        !"test4668"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 4668) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4669
        !"test4669"
        z1 <== (((-p)/p*(-p)*p*(-8.0)+(3.3*(-0.6)-(-q))/4.0*((-0.8)/p-(-p)*p-4.1)-((-4.8)*(-8.2)))-5.2/p)
        z2 <== (((-x)/x*(-x)*x*(-8.0)+(3.3*(-0.6)-(-y))/4.0*((-0.8)/x-(-x)*x-4.1)-((-4.8)*(-8.2)))-5.2/x)
        print.cccc (I 4669) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4670
        !"test4670"
        z1 <== ((-q)*8.0)
        z2 <== ((-y)*8.0)
        print.cccc (I 4670) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4671
        !"test4671"
        z1 <== (q/((1.2)*3.2)+(((-8.4)-0.0)/(q+(-5.3)/(-q))+((-p)+(-q)*(-p)/p-0.6)/((-6.5)))/4.5)
        z2 <== (y/((1.2)*3.2)+(((-8.4)-0.0)/(y+(-5.3)/(-y))+((-x)+(-y)*(-x)/x-0.6)/((-6.5)))/4.5)
        print.cccc (I 4671) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4672
        !"test4672"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 4672) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4673
        !"test4673"
        z1 <== ((6.5)+(-p)/(-p))
        z2 <== ((6.5)+(-x)/(-x))
        print.cccc (I 4673) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4674
        !"test4674"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 4674) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4675
        !"test4675"
        z1 <== 8.8
        z2 <== 8.8
        print.cccc (I 4675) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4676
        !"test4676"
        z1 <== (-1.3)
        z2 <== (-1.3)
        print.cccc (I 4676) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4677
        !"test4677"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 4677) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4678
        !"test4678"
        z1 <== (((p+q/6.7)*q+q+((-1.7)+(-6.1)-q)*q)-8.6)
        z2 <== (((x+y/6.7)*y+y+((-1.7)+(-6.1)-y)*y)-8.6)
        print.cccc (I 4678) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4679
        !"test4679"
        z1 <== ((((-q))-7.1-((-0.5))*(-q)*(6.3*2.0/8.3*p+(-1.8)))+1.4+(2.6-(-q)*(-6.3)+(-2.1))-(-3.1)-q/((7.0)+(-q)))
        z2 <== ((((-y))-7.1-((-0.5))*(-y)*(6.3*2.0/8.3*x+(-1.8)))+1.4+(2.6-(-y)*(-6.3)+(-2.1))-(-3.1)-y/((7.0)+(-y)))
        print.cccc (I 4679) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4680
        !"test4680"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4680) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4681
        !"test4681"
        z1 <== p
        z2 <== x
        print.cccc (I 4681) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4682
        !"test4682"
        z1 <== (((-p))+((3.3)/((-p)*(-4.6)+(-4.6)))+(1.1/p*(-8.1)*((-p)+p)))
        z2 <== (((-x))+((3.3)/((-x)*(-4.6)+(-4.6)))+(1.1/x*(-8.1)*((-x)+x)))
        print.cccc (I 4682) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4683
        !"test4683"
        z1 <== q
        z2 <== y
        print.cccc (I 4683) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4684
        !"test4684"
        z1 <== q
        z2 <== y
        print.cccc (I 4684) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4685
        !"test4685"
        z1 <== q
        z2 <== y
        print.cccc (I 4685) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4686
        !"test4686"
        z1 <== 7.2
        z2 <== 7.2
        print.cccc (I 4686) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4687
        !"test4687"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4687) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4688
        !"test4688"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4688) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4689
        !"test4689"
        z1 <== (-3.0)
        z2 <== (-3.0)
        print.cccc (I 4689) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4690
        !"test4690"
        z1 <== p
        z2 <== x
        print.cccc (I 4690) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4691
        !"test4691"
        z1 <== (p+(q+(-q))+(-p)/(q/(-2.2)-(-5.3)+(-p)/q)/(-p)+(-0.1)*((-p)+(4.8))-(-p))
        z2 <== (x+(y+(-y))+(-x)/(y/(-2.2)-(-5.3)+(-x)/y)/(-x)+(-0.1)*((-x)+(4.8))-(-x))
        print.cccc (I 4691) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4692
        !"test4692"
        z1 <== (q*((-p)-(-8.0)*((-4.1)+(-p)*(-7.8)*6.4)+p*(-0.1)))
        z2 <== (y*((-x)-(-8.0)*((-4.1)+(-x)*(-7.8)*6.4)+x*(-0.1)))
        print.cccc (I 4692) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4693
        !"test4693"
        z1 <== (((-5.6)-(-p)-q-q/((-3.7)+(-2.1)-q*q*8.7)))
        z2 <== (((-5.6)-(-x)-y-y/((-3.7)+(-2.1)-y*y*8.7)))
        print.cccc (I 4693) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4694
        !"test4694"
        z1 <== (-4.8)
        z2 <== (-4.8)
        print.cccc (I 4694) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4695
        !"test4695"
        z1 <== p
        z2 <== x
        print.cccc (I 4695) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4696
        !"test4696"
        z1 <== (((1.1/(-1.2)))+((-p)/7.2/(2.3+5.8-(-q)/(-7.5)))*(-0.2))
        z2 <== (((1.1/(-1.2)))+((-x)/7.2/(2.3+5.8-(-y)/(-7.5)))*(-0.2))
        print.cccc (I 4696) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4697
        !"test4697"
        z1 <== (p/p-(-8.6)/(-q)-(6.3))
        z2 <== (x/x-(-8.6)/(-y)-(6.3))
        print.cccc (I 4697) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4698
        !"test4698"
        z1 <== ((((-8.5)*q)-((-2.6))-(-q))*(-4.5)+((p-(-p)-(-2.1)-(-0.6)*p)*8.0+(-p)+(-p)-(-0.2)-7.6+(-5.2)-2.7-1.0/(-5.5)+q/7.7)-(((-p)/(-6.4)/(-p)+(-q)/(-0.4))*((-p)/5.8-p-5.4)-(-0.4)+3.0*q+(-p)*(-p)-(-q)-(q+(-q)))/(-q))
        z2 <== ((((-8.5)*y)-((-2.6))-(-y))*(-4.5)+((x-(-x)-(-2.1)-(-0.6)*x)*8.0+(-x)+(-x)-(-0.2)-7.6+(-5.2)-2.7-1.0/(-5.5)+y/7.7)-(((-x)/(-6.4)/(-x)+(-y)/(-0.4))*((-x)/5.8-x-5.4)-(-0.4)+3.0*y+(-x)*(-x)-(-y)-(y+(-y)))/(-y))
        print.cccc (I 4698) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4699
        !"test4699"
        z1 <== 8.2
        z2 <== 8.2
        print.cccc (I 4699) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4700
        !"test4700"
        z1 <== ((((-p)+1.7+(-8.7))/(8.3+(-3.2))*(1.3/(-0.1)-(-q)*3.0)))
        z2 <== ((((-x)+1.7+(-8.7))/(8.3+(-3.2))*(1.3/(-0.1)-(-y)*3.0)))
        print.cccc (I 4700) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4701
        !"test4701"
        z1 <== 4.1-p*(-p)/((-p)+(-p))+(8.6/q)*(-q)
        z2 <== 4.1-x*(-x)/((-x)+(-x))+(8.6/y)*(-y)
        print.cccc (I 4701) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4702
        !"test4702"
        z1 <== (p/(((-3.5)-3.0)*((-q)/p-q-3.0))/3.5-(-q))
        z2 <== (x/(((-3.5)-3.0)*((-y)/x-y-3.0))/3.5-(-y))
        print.cccc (I 4702) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4703
        !"test4703"
        z1 <== (-4.3)
        z2 <== (-4.3)
        print.cccc (I 4703) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4704
        !"test4704"
        z1 <== ((-5.5)-(-p))
        z2 <== ((-5.5)-(-x))
        print.cccc (I 4704) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4705
        !"test4705"
        z1 <== ((((-1.7)/(-7.3))/((-q)/(-q)/p))-q)
        z2 <== ((((-1.7)/(-7.3))/((-y)/(-y)/x))-y)
        print.cccc (I 4705) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4706
        !"test4706"
        z1 <== (-q)/(3.3/(-p)-6.3+6.1-((-q)/(-p)*0.6)+(-7.6)/(-1.5)/((-2.4)))
        z2 <== (-y)/(3.3/(-x)-6.3+6.1-((-y)/(-x)*0.6)+(-7.6)/(-1.5)/((-2.4)))
        print.cccc (I 4706) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4707
        !"test4707"
        z1 <== 4.3
        z2 <== 4.3
        print.cccc (I 4707) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4708
        !"test4708"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4708) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4709
        !"test4709"
        z1 <== 1.3
        z2 <== 1.3
        print.cccc (I 4709) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4710
        !"test4710"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 4710) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4711
        !"test4711"
        z1 <== (((p)/p)*((-1.3)*((-q)-(-p))-(6.3/1.0+2.0-5.7))+(-q)*3.5)
        z2 <== (((x)/x)*((-1.3)*((-y)-(-x))-(6.3/1.0+2.0-5.7))+(-y)*3.5)
        print.cccc (I 4711) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4712
        !"test4712"
        z1 <== ((3.3)/(-p)*(-0.0)-(8.6*5.3*(-2.6)*((-q)+q*(-p)/(-4.2))))
        z2 <== ((3.3)/(-x)*(-0.0)-(8.6*5.3*(-2.6)*((-y)+y*(-x)/(-4.2))))
        print.cccc (I 4712) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4713
        !"test4713"
        z1 <== (((-p)*p/(-3.6)*(-q)/(6.6)/(-q)/(-p)/(5.7*q/3.7/(-1.0)))+(7.7))
        z2 <== (((-x)*x/(-3.6)*(-y)/(6.6)/(-y)/(-x)/(5.7*y/3.7/(-1.0)))+(7.7))
        print.cccc (I 4713) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4714
        !"test4714"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4714) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4715
        !"test4715"
        z1 <== (q)
        z2 <== (y)
        print.cccc (I 4715) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4716
        !"test4716"
        z1 <== ((p+q)*p+q)
        z2 <== ((x+y)*x+y)
        print.cccc (I 4716) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4717
        !"test4717"
        z1 <== (q/(3.6/(-8.0)/(-p)+p+(-q)/(-p)/0.2*(0.4*(-q)+3.7*(-q)))/(q/(-q)+(-2.2))+((-6.4)/(-6.3)+(-4.6))-(-q)/4.5-((-p))-(-q)*(-1.6)+(-p)-(-q)*(-5.3)-(0.4+(-1.2)/p*(-0.1)-5.7)*p)
        z2 <== (y/(3.6/(-8.0)/(-x)+x+(-y)/(-x)/0.2*(0.4*(-y)+3.7*(-y)))/(y/(-y)+(-2.2))+((-6.4)/(-6.3)+(-4.6))-(-y)/4.5-((-x))-(-y)*(-1.6)+(-x)-(-y)*(-5.3)-(0.4+(-1.2)/x*(-0.1)-5.7)*x)
        print.cccc (I 4717) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4718
        !"test4718"
        z1 <== (8.6/q*((5.4-p*(-6.0)-(-4.2)-q))/(q*((-3.0)/q/(-6.0))))
        z2 <== (8.6/y*((5.4-x*(-6.0)-(-4.2)-y))/(y*((-3.0)/y/(-6.0))))
        print.cccc (I 4718) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4719
        !"test4719"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 4719) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4720
        !"test4720"
        z1 <== ((((-p)+(-8.3)+6.2/p+8.1)+(-8.8)*(-q))-(q*((-1.4)))+(-2.8))
        z2 <== ((((-x)+(-8.3)+6.2/x+8.1)+(-8.8)*(-y))-(y*((-1.4)))+(-2.8))
        print.cccc (I 4720) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4721
        !"test4721"
        z1 <== ((-1.2)+(q-p/6.4*q/(-0.8))-7.3/((-q))*(-p)*(p*(-5.5))*((p/1.1)+(q-(-2.6))+(1.0+(-7.4)+(-p)/(-4.8)-q))-(q/2.5*8.2)+(-7.7))
        z2 <== ((-1.2)+(y-x/6.4*y/(-0.8))-7.3/((-y))*(-x)*(x*(-5.5))*((x/1.1)+(y-(-2.6))+(1.0+(-7.4)+(-x)/(-4.8)-y))-(y/2.5*8.2)+(-7.7))
        print.cccc (I 4721) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4722
        !"test4722"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4722) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4723
        !"test4723"
        z1 <== 7.1
        z2 <== 7.1
        print.cccc (I 4723) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4724
        !"test4724"
        z1 <== p
        z2 <== x
        print.cccc (I 4724) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4725
        !"test4725"
        z1 <== ((-p)*4.6-(((-q)-(-6.8))-p)/p/p)
        z2 <== ((-x)*4.6-(((-y)-(-6.8))-x)/x/x)
        print.cccc (I 4725) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4726
        !"test4726"
        z1 <== ((-q)*(p/(-2.6)*(p-(-2.2)-1.5+(-1.0))/(-0.2)*p)+(-2.4))
        z2 <== ((-y)*(x/(-2.6)*(x-(-2.2)-1.5+(-1.0))/(-0.2)*x)+(-2.4))
        print.cccc (I 4726) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4727
        !"test4727"
        z1 <== (((3.4-p+6.6*0.0/(-7.1))-p*(-p))/5.4/(2.0*(-p)/((-8.4)-(-3.0)*4.6))-5.0*8.3)
        z2 <== (((3.4-x+6.6*0.0/(-7.1))-x*(-x))/5.4/(2.0*(-x)/((-8.4)-(-3.0)*4.6))-5.0*8.3)
        print.cccc (I 4727) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4728
        !"test4728"
        z1 <== 4.8
        z2 <== 4.8
        print.cccc (I 4728) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4729
        !"test4729"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4729) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4730
        !"test4730"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4730) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4731
        !"test4731"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 4731) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4732
        !"test4732"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4732) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4733
        !"test4733"
        z1 <== (-7.3)+(-5.0)
        z2 <== (-7.3)+(-5.0)
        print.cccc (I 4733) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4734
        !"test4734"
        z1 <== (((-p)+(-p)-0.7+2.4+5.2))
        z2 <== (((-x)+(-x)-0.7+2.4+5.2))
        print.cccc (I 4734) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4735
        !"test4735"
        z1 <== ((-q)/((-q)*1.6*1.3+(-4.3)*q-(-p)-7.0)*((q/q/(-p))*q-q*((-q)/4.6))*((-p)/((-p)/(-3.2)/q)))
        z2 <== ((-y)/((-y)*1.6*1.3+(-4.3)*y-(-x)-7.0)*((y/y/(-x))*y-y*((-y)/4.6))*((-x)/((-x)/(-3.2)/y)))
        print.cccc (I 4735) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4736
        !"test4736"
        z1 <== (((-6.7)/p*p/q*((-6.0)/(-q)+q/(-1.6)/p)))
        z2 <== (((-6.7)/x*x/y*((-6.0)/(-y)+y/(-1.6)/x)))
        print.cccc (I 4736) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4737
        !"test4737"
        z1 <== (p-(8.7/(-q)+(-q))+((-q))/((-3.0)-2.6-(-p)/(-q)*0.1))
        z2 <== (x-(8.7/(-y)+(-y))+((-y))/((-3.0)-2.6-(-x)/(-y)*0.1))
        print.cccc (I 4737) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4738
        !"test4738"
        z1 <== ((-q)*(-q)-p*((-q))+(-p)*q-((-7.6)-8.6-1.4)*q)
        z2 <== ((-y)*(-y)-x*((-y))+(-x)*y-((-7.6)-8.6-1.4)*y)
        print.cccc (I 4738) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4739
        !"test4739"
        z1 <== (q*7.2*(-3.2))
        z2 <== (y*7.2*(-3.2))
        print.cccc (I 4739) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4740
        !"test4740"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4740) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4741
        !"test4741"
        z1 <== (q/(q-((-8.7)/(-1.7)))/0.7+6.2)
        z2 <== (y/(y-((-8.7)/(-1.7)))/0.7+6.2)
        print.cccc (I 4741) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4742
        !"test4742"
        z1 <== (-0.8)
        z2 <== (-0.8)
        print.cccc (I 4742) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4743
        !"test4743"
        z1 <== p
        z2 <== x
        print.cccc (I 4743) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4744
        !"test4744"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 4744) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4745
        !"test4745"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 4745) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4746
        !"test4746"
        z1 <== (((-p))-((p+q)*(-8.5)-7.7)-4.7)
        z2 <== (((-x))-((x+y)*(-8.5)-7.7)-4.7)
        print.cccc (I 4746) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4747
        !"test4747"
        z1 <== (((q*1.6*8.1*q-8.7)-p)*(-3.2)/(-3.1)+p-(((-p))+(-5.0)))
        z2 <== (((y*1.6*8.1*y-8.7)-x)*(-3.2)/(-3.1)+x-(((-x))+(-5.0)))
        print.cccc (I 4747) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4748
        !"test4748"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4748) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4749
        !"test4749"
        z1 <== ((-q)/p)
        z2 <== ((-y)/x)
        print.cccc (I 4749) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4750
        !"test4750"
        z1 <== (-4.5)
        z2 <== (-4.5)
        print.cccc (I 4750) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4751
        !"test4751"
        z1 <== ((((-q)+(-p)+3.5/(-0.8))-((-p)/p*(-0.7)+p)*((-p)-1.4+(-3.5))/4.4/(-q))/(-1.5)/(-p)-(-2.8)+(q/3.1/(-p)))
        z2 <== ((((-y)+(-x)+3.5/(-0.8))-((-x)/x*(-0.7)+x)*((-x)-1.4+(-3.5))/4.4/(-y))/(-1.5)/(-x)-(-2.8)+(y/3.1/(-x)))
        print.cccc (I 4751) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4752
        !"test4752"
        z1 <== 3.6/(-7.1)-(-6.0)
        z2 <== 3.6/(-7.1)-(-6.0)
        print.cccc (I 4752) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4753
        !"test4753"
        z1 <== (q+(p*(-p))-((-1.1)+(-3.0))-q*(-2.5)+q+p*(-q))
        z2 <== (y+(x*(-x))-((-1.1)+(-3.0))-y*(-2.5)+y+x*(-y))
        print.cccc (I 4753) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4754
        !"test4754"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4754) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4755
        !"test4755"
        z1 <== ((-6.8)*((0.0*p+(-q)/(-6.8))+0.3+(-p)*(-7.2)-1.8*q+(-q))*p+(-p)*q*(-p)/(-6.8)-(0.7*0.1-(-p)*8.2)+q-(-4.2)/8.4*((-p))/(-p))
        z2 <== ((-6.8)*((0.0*x+(-y)/(-6.8))+0.3+(-x)*(-7.2)-1.8*y+(-y))*x+(-x)*y*(-x)/(-6.8)-(0.7*0.1-(-x)*8.2)+y-(-4.2)/8.4*((-x))/(-x))
        print.cccc (I 4755) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4756
        !"test4756"
        z1 <== (q-((q+(-q))*((-2.0)-q/4.1/q))*((-p)/(-p))/(0.5*(-6.0)/(-5.5)-(-3.2)))
        z2 <== (y-((y+(-y))*((-2.0)-y/4.1/y))*((-x)/(-x))/(0.5*(-6.0)/(-5.5)-(-3.2)))
        print.cccc (I 4756) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4757
        !"test4757"
        z1 <== (((8.4*4.0-(-p))-(-q)+0.1+(-3.1)/(-p)))
        z2 <== (((8.4*4.0-(-x))-(-y)+0.1+(-3.1)/(-x)))
        print.cccc (I 4757) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4758
        !"test4758"
        z1 <== (((-8.4)-(-q))*(-8.3)/(-q)+(q/(-p)+p-(-7.8)-(-q))*7.5*6.7-q*(-q)+q+p+(p*q+q/(-q)+q)-0.2)
        z2 <== (((-8.4)-(-y))*(-8.3)/(-y)+(y/(-x)+x-(-7.8)-(-y))*7.5*6.7-y*(-y)+y+x+(x*y+y/(-y)+y)-0.2)
        print.cccc (I 4758) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4759
        !"test4759"
        z1 <== (-1.4)
        z2 <== (-1.4)
        print.cccc (I 4759) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4760
        !"test4760"
        z1 <== (-3.6)
        z2 <== (-3.6)
        print.cccc (I 4760) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4761
        !"test4761"
        z1 <== 3.3
        z2 <== 3.3
        print.cccc (I 4761) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4762
        !"test4762"
        z1 <== (-7.5)
        z2 <== (-7.5)
        print.cccc (I 4762) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4763
        !"test4763"
        z1 <== 8.6*((-p)-(-0.1))+((-p))*(p+((-0.4)/p*(-p)/p*(-3.0))/(p-q-q-1.3*4.5))*4.6/p-(-q)*(-7.5)/(q)
        z2 <== 8.6*((-x)-(-0.1))+((-x))*(x+((-0.4)/x*(-x)/x*(-3.0))/(x-y-y-1.3*4.5))*4.6/x-(-y)*(-7.5)/(y)
        print.cccc (I 4763) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4764
        !"test4764"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 4764) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4765
        !"test4765"
        z1 <== p
        z2 <== x
        print.cccc (I 4765) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4766
        !"test4766"
        z1 <== (-2.5)
        z2 <== (-2.5)
        print.cccc (I 4766) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4767
        !"test4767"
        z1 <== (((-5.4)/6.2)+((4.2/(-4.2)/p*6.3))*q+(q+(-8.6)+q*(-5.0)+(-q)-4.0/p)/(-4.4))
        z2 <== (((-5.4)/6.2)+((4.2/(-4.2)/x*6.3))*y+(y+(-8.6)+y*(-5.0)+(-y)-4.0/x)/(-4.4))
        print.cccc (I 4767) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4768
        !"test4768"
        z1 <== (-4.2)
        z2 <== (-4.2)
        print.cccc (I 4768) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4769
        !"test4769"
        z1 <== 6.4
        z2 <== 6.4
        print.cccc (I 4769) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4770
        !"test4770"
        z1 <== (-0.7)-0.1
        z2 <== (-0.7)-0.1
        print.cccc (I 4770) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4771
        !"test4771"
        z1 <== (((-2.0))*(q*6.1+(-q)/(-1.3)+6.2)/((p)/(-p)+(-p)*5.7*7.4*q)/(-q))
        z2 <== (((-2.0))*(y*6.1+(-y)/(-1.3)+6.2)/((x)/(-x)+(-x)*5.7*7.4*y)/(-y))
        print.cccc (I 4771) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4772
        !"test4772"
        z1 <== (((-6.2)*1.5-(-8.3)+(-5.5))*(8.6/(-2.8)))
        z2 <== (((-6.2)*1.5-(-8.3)+(-5.5))*(8.6/(-2.8)))
        print.cccc (I 4772) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4773
        !"test4773"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 4773) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4774
        !"test4774"
        z1 <== p
        z2 <== x
        print.cccc (I 4774) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4775
        !"test4775"
        z1 <== ((-p)-(-p))
        z2 <== ((-x)-(-x))
        print.cccc (I 4775) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4776
        !"test4776"
        z1 <== ((-4.1)-1.7*3.5/(-6.6)*q*4.3/p-((-8.3)/p*q*q))
        z2 <== ((-4.1)-1.7*3.5/(-6.6)*y*4.3/x-((-8.3)/x*y*y))
        print.cccc (I 4776) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4777
        !"test4777"
        z1 <== (1.4-q+(-p)/((-q)-(-6.2)-(-5.3))-(p*(3.5*q-p/p/(-p))-((-2.4)/8.6-5.4)*p/(-p)/((-6.4)-q)))
        z2 <== (1.4-y+(-x)/((-y)-(-6.2)-(-5.3))-(x*(3.5*y-x/x/(-x))-((-2.4)/8.6-5.4)*x/(-x)/((-6.4)-y)))
        print.cccc (I 4777) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4778
        !"test4778"
        z1 <== (-6.1)
        z2 <== (-6.1)
        print.cccc (I 4778) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4779
        !"test4779"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4779) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4780
        !"test4780"
        z1 <== ((-p)*4.1/(q*(-q)-(-5.1)*(-p)*8.7+p+4.0+(-q)-(-1.4)))
        z2 <== ((-x)*4.1/(y*(-y)-(-5.1)*(-x)*8.7+x+4.0+(-y)-(-1.4)))
        print.cccc (I 4780) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4781
        !"test4781"
        z1 <== (-6.3)
        z2 <== (-6.3)
        print.cccc (I 4781) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4782
        !"test4782"
        z1 <== (6.4)
        z2 <== (6.4)
        print.cccc (I 4782) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4783
        !"test4783"
        z1 <== (((5.2+(-3.1)*6.7)-(-q))/((-2.7)+7.5+(-q)*3.3*(-q)/(-q)+(8.4+p)*(q)/((-5.6)))*(((-6.0))+(q+(-0.4)+6.4+7.1)/(p)*(-6.4)-(-7.7))*3.8*(8.6))
        z2 <== (((5.2+(-3.1)*6.7)-(-y))/((-2.7)+7.5+(-y)*3.3*(-y)/(-y)+(8.4+x)*(y)/((-5.6)))*(((-6.0))+(y+(-0.4)+6.4+7.1)/(x)*(-6.4)-(-7.7))*3.8*(8.6))
        print.cccc (I 4783) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4784
        !"test4784"
        z1 <== p
        z2 <== x
        print.cccc (I 4784) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4785
        !"test4785"
        z1 <== q-((-2.7)*p)+((p*p*(-p))*(0.5+p+(-1.7))*8.8)-8.4-(-q)*q-((-3.4)+(-p)*q*(-6.2)/(-p))+(2.2/1.3-(-2.7)/(-5.8))*7.4
        z2 <== y-((-2.7)*x)+((x*x*(-x))*(0.5+x+(-1.7))*8.8)-8.4-(-y)*y-((-3.4)+(-x)*y*(-6.2)/(-x))+(2.2/1.3-(-2.7)/(-5.8))*7.4
        print.cccc (I 4785) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4786
        !"test4786"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4786) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4787
        !"test4787"
        z1 <== p
        z2 <== x
        print.cccc (I 4787) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4788
        !"test4788"
        z1 <== ((-p)-q+(-8.0)*p)
        z2 <== ((-x)-y+(-8.0)*x)
        print.cccc (I 4788) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4789
        !"test4789"
        z1 <== ((0.5-(-p)+(-6.6)+(-5.3))*(-0.3)*((-q)*(-q))-(p*(-7.2)/q/7.2-p))+(-q)-(-p)+q
        z2 <== ((0.5-(-x)+(-6.6)+(-5.3))*(-0.3)*((-y)*(-y))-(x*(-7.2)/y/7.2-x))+(-y)-(-x)+y
        print.cccc (I 4789) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4790
        !"test4790"
        z1 <== ((-5.1)*(-q)*((-p)*(q*q+(-0.0))-p)*0.6)
        z2 <== ((-5.1)*(-y)*((-x)*(y*y+(-0.0))-x)*0.6)
        print.cccc (I 4790) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4791
        !"test4791"
        z1 <== q
        z2 <== y
        print.cccc (I 4791) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4792
        !"test4792"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4792) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4793
        !"test4793"
        z1 <== (((-q)*((-p)+0.7+(-p)-q*(-7.3))+((-3.6)))/(-p))
        z2 <== (((-y)*((-x)+0.7+(-x)-y*(-7.3))+((-3.6)))/(-x))
        print.cccc (I 4793) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4794
        !"test4794"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 4794) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4795
        !"test4795"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4795) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4796
        !"test4796"
        z1 <== (-8.6)
        z2 <== (-8.6)
        print.cccc (I 4796) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4797
        !"test4797"
        z1 <== ((1.6)/(-0.8)-(((-5.4)+(-8.0))+((-q)*q-(-p)-(-4.6)+q))-(-6.5))
        z2 <== ((1.6)/(-0.8)-(((-5.4)+(-8.0))+((-y)*y-(-x)-(-4.6)+y))-(-6.5))
        print.cccc (I 4797) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4798
        !"test4798"
        z1 <== ((-5.1))
        z2 <== ((-5.1))
        print.cccc (I 4798) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4799
        !"test4799"
        z1 <== p
        z2 <== x
        print.cccc (I 4799) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4800
        !"test4800"
        z1 <== (((-5.2)*q*(-5.8)-(-1.5))/(1.6-((-q)-q-(-q)))-(-p))
        z2 <== (((-5.2)*y*(-5.8)-(-1.5))/(1.6-((-y)-y-(-y)))-(-x))
        print.cccc (I 4800) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4801
        !"test4801"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4801) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4802
        !"test4802"
        z1 <== ((3.8-((-2.0))/((-4.0)+(-q))+(q/q+q)-q))
        z2 <== ((3.8-((-2.0))/((-4.0)+(-y))+(y/y+y)-y))
        print.cccc (I 4802) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4803
        !"test4803"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4803) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4804
        !"test4804"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4804) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4805
        !"test4805"
        z1 <== 8.6
        z2 <== 8.6
        print.cccc (I 4805) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4806
        !"test4806"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4806) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4807
        !"test4807"
        z1 <== p
        z2 <== x
        print.cccc (I 4807) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4808
        !"test4808"
        z1 <== (-5.2)
        z2 <== (-5.2)
        print.cccc (I 4808) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4809
        !"test4809"
        z1 <== (-p)*p+(p-(-q)*(p+(-q)/(-q)*q/(-q))*(p-p*(-6.1)*(-6.0)+(-3.0)))
        z2 <== (-x)*x+(x-(-y)*(x+(-y)/(-y)*y/(-y))*(x-x*(-6.1)*(-6.0)+(-3.0)))
        print.cccc (I 4809) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4810
        !"test4810"
        z1 <== ((((-1.1)+0.6+(-8.3)*(-5.3)-(-q))*((-p)*2.8)+(-q))+(-p)-(((-4.2)-8.7))+p)
        z2 <== ((((-1.1)+0.6+(-8.3)*(-5.3)-(-y))*((-x)*2.8)+(-y))+(-x)-(((-4.2)-8.7))+x)
        print.cccc (I 4810) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4811
        !"test4811"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4811) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4812
        !"test4812"
        z1 <== (((-3.1)+((-6.6)/(-p)+3.4+(-q)*4.7))+q)
        z2 <== (((-3.1)+((-6.6)/(-x)+3.4+(-y)*4.7))+y)
        print.cccc (I 4812) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4813
        !"test4813"
        z1 <== p
        z2 <== x
        print.cccc (I 4813) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4814
        !"test4814"
        z1 <== ((-p)/(-p)*(-4.1)-((-p)-q)+(-q))
        z2 <== ((-x)/(-x)*(-4.1)-((-x)-y)+(-y))
        print.cccc (I 4814) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4815
        !"test4815"
        z1 <== ((5.4)/4.7+6.6/q*(0.4*((-0.7)*(-p)-(-p)+(-4.8))/q))
        z2 <== ((5.4)/4.7+6.6/y*(0.4*((-0.7)*(-x)-(-x)+(-4.8))/y))
        print.cccc (I 4815) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4816
        !"test4816"
        z1 <== q
        z2 <== y
        print.cccc (I 4816) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4817
        !"test4817"
        z1 <== (-8.0)
        z2 <== (-8.0)
        print.cccc (I 4817) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4818
        !"test4818"
        z1 <== 2.8
        z2 <== 2.8
        print.cccc (I 4818) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4819
        !"test4819"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 4819) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4820
        !"test4820"
        z1 <== (-2.2)
        z2 <== (-2.2)
        print.cccc (I 4820) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4821
        !"test4821"
        z1 <== (((-4.0))/p)
        z2 <== (((-4.0))/x)
        print.cccc (I 4821) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4822
        !"test4822"
        z1 <== (7.0*(-q)/p-0.1)
        z2 <== (7.0*(-y)/x-0.1)
        print.cccc (I 4822) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4823
        !"test4823"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4823) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4824
        !"test4824"
        z1 <== (((-3.7)))
        z2 <== (((-3.7)))
        print.cccc (I 4824) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4825
        !"test4825"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4825) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4826
        !"test4826"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4826) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4827
        !"test4827"
        z1 <== (7.6/(-q)/q/(-4.6)-(-p))+(-1.8)*(3.5)-6.0
        z2 <== (7.6/(-y)/y/(-4.6)-(-x))+(-1.8)*(3.5)-6.0
        print.cccc (I 4827) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4828
        !"test4828"
        z1 <== ((-8.2))
        z2 <== ((-8.2))
        print.cccc (I 4828) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4829
        !"test4829"
        z1 <== (p*(3.5*(-6.5)+p/(-7.6)/(-4.4))-(-5.8)*5.5/((p/(-6.1)/q)/(5.7+(-2.4)-p-p*3.6)/q-q/((-6.8)))/(-q))
        z2 <== (x*(3.5*(-6.5)+x/(-7.6)/(-4.4))-(-5.8)*5.5/((x/(-6.1)/y)/(5.7+(-2.4)-x-x*3.6)/y-y/((-6.8)))/(-y))
        print.cccc (I 4829) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4830
        !"test4830"
        z1 <== (((1.4+q*8.5*1.3))/(-p)/(-q)-(p/(p*(-5.4)+(-p))-((-q))))
        z2 <== (((1.4+y*8.5*1.3))/(-x)/(-y)-(x/(x*(-5.4)+(-x))-((-y))))
        print.cccc (I 4830) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4831
        !"test4831"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 4831) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4832
        !"test4832"
        z1 <== (6.5)
        z2 <== (6.5)
        print.cccc (I 4832) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4833
        !"test4833"
        z1 <== p
        z2 <== x
        print.cccc (I 4833) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4834
        !"test4834"
        z1 <== 6.6
        z2 <== 6.6
        print.cccc (I 4834) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4835
        !"test4835"
        z1 <== (-5.0)
        z2 <== (-5.0)
        print.cccc (I 4835) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4836
        !"test4836"
        z1 <== 3.5
        z2 <== 3.5
        print.cccc (I 4836) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4837
        !"test4837"
        z1 <== 3.6
        z2 <== 3.6
        print.cccc (I 4837) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4838
        !"test4838"
        z1 <== (-2.7)
        z2 <== (-2.7)
        print.cccc (I 4838) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4839
        !"test4839"
        z1 <== (6.5/(((-8.5)+q/q-(-q)))/q*(-7.6)*((-0.4)/(-3.4)+((-1.8)*7.3-1.3)+(-q)-(-3.6)+1.6+2.7+p))
        z2 <== (6.5/(((-8.5)+y/y-(-y)))/y*(-7.6)*((-0.4)/(-3.4)+((-1.8)*7.3-1.3)+(-y)-(-3.6)+1.6+2.7+x))
        print.cccc (I 4839) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4840
        !"test4840"
        z1 <== p
        z2 <== x
        print.cccc (I 4840) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4841
        !"test4841"
        z1 <== (5.0*((-6.0)+(p+(-2.8)+(-q))/p-(4.1+(-q)+6.3)-0.6/p+2.3)+1.4-(-5.5)+((-7.3)-(p+(-5.7))+((-0.0)-(-p))*(-p)*(p-(-q)-p)))
        z2 <== (5.0*((-6.0)+(x+(-2.8)+(-y))/x-(4.1+(-y)+6.3)-0.6/x+2.3)+1.4-(-5.5)+((-7.3)-(x+(-5.7))+((-0.0)-(-x))*(-x)*(x-(-y)-x)))
        print.cccc (I 4841) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4842
        !"test4842"
        z1 <== (2.1)
        z2 <== (2.1)
        print.cccc (I 4842) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4843
        !"test4843"
        z1 <== 6.2
        z2 <== 6.2
        print.cccc (I 4843) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4844
        !"test4844"
        z1 <== 6.0
        z2 <== 6.0
        print.cccc (I 4844) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4845
        !"test4845"
        z1 <== (((q/5.3-q/2.1)/(1.1*p))/(4.7+(0.8/p*(-q)+5.4)/(0.7+(-5.8)-(-7.7)))/(p+(-0.0))*p+(p-1.5*p/(-q)))
        z2 <== (((y/5.3-y/2.1)/(1.1*x))/(4.7+(0.8/x*(-y)+5.4)/(0.7+(-5.8)-(-7.7)))/(x+(-0.0))*x+(x-1.5*x/(-y)))
        print.cccc (I 4845) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4846
        !"test4846"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4846) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4847
        !"test4847"
        z1 <== (((-q)+((-p)/(-p)*(-q)-4.8)-p/q/((-q)+(-q))))
        z2 <== (((-y)+((-x)/(-x)*(-y)-4.8)-x/y/((-y)+(-y))))
        print.cccc (I 4847) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4848
        !"test4848"
        z1 <== (0.0+p-p-q)
        z2 <== (0.0+x-x-y)
        print.cccc (I 4848) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4849
        !"test4849"
        z1 <== q
        z2 <== y
        print.cccc (I 4849) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4850
        !"test4850"
        z1 <== ((-q))
        z2 <== ((-y))
        print.cccc (I 4850) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4851
        !"test4851"
        z1 <== (8.4/((-p)/(-p)/(p/(-5.3))+(-q)))
        z2 <== (8.4/((-x)/(-x)/(x/(-5.3))+(-y)))
        print.cccc (I 4851) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4852
        !"test4852"
        z1 <== (p/6.0/(-4.6))
        z2 <== (x/6.0/(-4.6))
        print.cccc (I 4852) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4853
        !"test4853"
        z1 <== 4.2
        z2 <== 4.2
        print.cccc (I 4853) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4854
        !"test4854"
        z1 <== q/q
        z2 <== y/y
        print.cccc (I 4854) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4855
        !"test4855"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4855) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4856
        !"test4856"
        z1 <== 3.0
        z2 <== 3.0
        print.cccc (I 4856) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4857
        !"test4857"
        z1 <== ((-p)*(p+5.2*1.8*((-p)/(-p)-8.3))/(-3.4))
        z2 <== ((-x)*(x+5.2*1.8*((-x)/(-x)-8.3))/(-3.4))
        print.cccc (I 4857) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4858
        !"test4858"
        z1 <== ((-q)/1.5/((-q)-q/p+(-4.8)+(-p))*(-q)*(-6.1))
        z2 <== ((-y)/1.5/((-y)-y/x+(-4.8)+(-x))*(-y)*(-6.1))
        print.cccc (I 4858) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4859
        !"test4859"
        z1 <== ((q-(-p)/((-p)-(-p)/6.3)))
        z2 <== ((y-(-x)/((-x)-(-x)/6.3)))
        print.cccc (I 4859) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4860
        !"test4860"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4860) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4861
        !"test4861"
        z1 <== (q*((-p)-8.0)-(5.6-(-p)+1.3*p)+((-4.0)/(-q)*(-q)-4.4+(-1.7)))
        z2 <== (y*((-x)-8.0)-(5.6-(-x)+1.3*x)+((-4.0)/(-y)*(-y)-4.4+(-1.7)))
        print.cccc (I 4861) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4862
        !"test4862"
        z1 <== q
        z2 <== y
        print.cccc (I 4862) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4863
        !"test4863"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4863) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4864
        !"test4864"
        z1 <== (((-p)/0.4+(-q)-1.6+(-q))/5.5+(-8.2)/6.5+((-7.4)*q*p/(-1.2))-((-q)/(-p)*p))-(4.8/((-p)*p-(-3.1)-(-p)))+(((-p)))+(p*(-q)*p+p*(-q))+((-p)/q+p-(-7.3)-(-p))+4.0+q/(-2.7)
        z2 <== (((-x)/0.4+(-y)-1.6+(-y))/5.5+(-8.2)/6.5+((-7.4)*y*x/(-1.2))-((-y)/(-x)*x))-(4.8/((-x)*x-(-3.1)-(-x)))+(((-x)))+(x*(-y)*x+x*(-y))+((-x)/y+x-(-7.3)-(-x))+4.0+y/(-2.7)
        print.cccc (I 4864) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4865
        !"test4865"
        z1 <== (0.0)*7.1/(-q)/5.7+(-7.4)
        z2 <== (0.0)*7.1/(-y)/5.7+(-7.4)
        print.cccc (I 4865) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4866
        !"test4866"
        z1 <== (p/(-q)-(((-0.5))-p/(q+p/p)/(-q)/0.1+3.0)/0.6)
        z2 <== (x/(-y)-(((-0.5))-x/(y+x/x)/(-y)/0.1+3.0)/0.6)
        print.cccc (I 4866) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4867
        !"test4867"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4867) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4868
        !"test4868"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4868) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4869
        !"test4869"
        z1 <== (-5.1)
        z2 <== (-5.1)
        print.cccc (I 4869) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4870
        !"test4870"
        z1 <== 0.1
        z2 <== 0.1
        print.cccc (I 4870) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4871
        !"test4871"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4871) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4872
        !"test4872"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4872) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4873
        !"test4873"
        z1 <== (5.3-(-8.4)/q/7.2-((-1.0)-q*p*q*p)+(p-(-p)*q-5.4/2.6)+p)*1.8+(-p)/7.6-q/((-7.4)-0.4+(-3.6))*(p*(-q)/(-0.3)-(-p))/2.2*q/(-q)
        z2 <== (5.3-(-8.4)/y/7.2-((-1.0)-y*x*y*x)+(x-(-x)*y-5.4/2.6)+x)*1.8+(-x)/7.6-y/((-7.4)-0.4+(-3.6))*(x*(-y)/(-0.3)-(-x))/2.2*y/(-y)
        print.cccc (I 4873) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4874
        !"test4874"
        z1 <== 5.2
        z2 <== 5.2
        print.cccc (I 4874) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4875
        !"test4875"
        z1 <== ((p*(-7.8)*p+8.8-(-q)+(-q)-4.5)-(((-8.1))*((-p)*2.8+4.7-4.7)-(-p)*((-q)/6.4-7.1)-((-p)*(-p)*(-q)))-(-0.5)*(-7.3)+(-5.7))
        z2 <== ((x*(-7.8)*x+8.8-(-y)+(-y)-4.5)-(((-8.1))*((-x)*2.8+4.7-4.7)-(-x)*((-y)/6.4-7.1)-((-x)*(-x)*(-y)))-(-0.5)*(-7.3)+(-5.7))
        print.cccc (I 4875) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4876
        !"test4876"
        z1 <== ((-q)+(0.3-(-0.3)/p)*p+(((-q)/(-1.2))/4.7*p/(-p)-p)-6.2)
        z2 <== ((-y)+(0.3-(-0.3)/x)*x+(((-y)/(-1.2))/4.7*x/(-x)-x)-6.2)
        print.cccc (I 4876) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4877
        !"test4877"
        z1 <== ((-q)/((-p)+q)+3.2)
        z2 <== ((-y)/((-x)+y)+3.2)
        print.cccc (I 4877) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4878
        !"test4878"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 4878) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4879
        !"test4879"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4879) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4880
        !"test4880"
        z1 <== ((7.6-4.4+1.2)+(2.2/(-p)+q-(-8.8))/(-p)/(-p)-q/1.7-(-7.8)+(-1.0)*7.0-(-p))
        z2 <== ((7.6-4.4+1.2)+(2.2/(-x)+y-(-8.8))/(-x)/(-x)-y/1.7-(-7.8)+(-1.0)*7.0-(-x))
        print.cccc (I 4880) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4881
        !"test4881"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4881) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4882
        !"test4882"
        z1 <== (((-p)/((-q)/0.0*(-1.1)+5.3)*(-1.6)*(-4.8)/7.0)*(q))
        z2 <== (((-x)/((-y)/0.0*(-1.1)+5.3)*(-1.6)*(-4.8)/7.0)*(y))
        print.cccc (I 4882) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4883
        !"test4883"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4883) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4884
        !"test4884"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 4884) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4885
        !"test4885"
        z1 <== 0.0
        z2 <== 0.0
        print.cccc (I 4885) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4886
        !"test4886"
        z1 <== 5.6
        z2 <== 5.6
        print.cccc (I 4886) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4887
        !"test4887"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 4887) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4888
        !"test4888"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4888) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4889
        !"test4889"
        z1 <== q
        z2 <== y
        print.cccc (I 4889) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4890
        !"test4890"
        z1 <== 5.2/(q-(-p)/(-q)/(-3.2)/(-p)/(-6.7)/(-q)/((-0.6)-p-(-p)*(-8.0)))+0.7+(7.7)
        z2 <== 5.2/(y-(-x)/(-y)/(-3.2)/(-x)/(-6.7)/(-y)/((-0.6)-x-(-x)*(-8.0)))+0.7+(7.7)
        print.cccc (I 4890) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4891
        !"test4891"
        z1 <== (-5.6)
        z2 <== (-5.6)
        print.cccc (I 4891) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4892
        !"test4892"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 4892) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4893
        !"test4893"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4893) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4894
        !"test4894"
        z1 <== ((((-1.1)*(-p)*q)/((-8.0)/4.4+p)*(-p)-(0.4+(-0.8)))/((2.6/q/1.3*p-8.5)/4.2-((-1.4))/3.7+(-5.1))/p-1.7)
        z2 <== ((((-1.1)*(-x)*y)/((-8.0)/4.4+x)*(-x)-(0.4+(-0.8)))/((2.6/y/1.3*x-8.5)/4.2-((-1.4))/3.7+(-5.1))/x-1.7)
        print.cccc (I 4894) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4895
        !"test4895"
        z1 <== ((6.7*q+(-7.0))*(3.0-(-p)+(-p)+(5.4-(-q)/5.5/p)-(-6.1))*(-4.8)-8.4-7.0*6.1/p+q/(((-6.0)*2.8-q*(-2.0))*(-p)-((-q))+(-q)-(-q)))
        z2 <== ((6.7*y+(-7.0))*(3.0-(-x)+(-x)+(5.4-(-y)/5.5/x)-(-6.1))*(-4.8)-8.4-7.0*6.1/x+y/(((-6.0)*2.8-y*(-2.0))*(-x)-((-y))+(-y)-(-y)))
        print.cccc (I 4895) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4896
        !"test4896"
        z1 <== ((q))
        z2 <== ((y))
        print.cccc (I 4896) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4897
        !"test4897"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 4897) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4898
        !"test4898"
        z1 <== ((7.6)*(-8.2)+1.6/1.5+1.1+5.7)/(-q)
        z2 <== ((7.6)*(-8.2)+1.6/1.5+1.1+5.7)/(-y)
        print.cccc (I 4898) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4899
        !"test4899"
        z1 <== q
        z2 <== y
        print.cccc (I 4899) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4900
        !"test4900"
        z1 <== 1.5
        z2 <== 1.5
        print.cccc (I 4900) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4901
        !"test4901"
        z1 <== (1.4-(-7.7)/(-7.3)-q-q-(-q)-(-6.7))+((-p))*q+(((-7.6)*q)-(q/q*3.0))
        z2 <== (1.4-(-7.7)/(-7.3)-y-y-(-y)-(-6.7))+((-x))*y+(((-7.6)*y)-(y/y*3.0))
        print.cccc (I 4901) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4902
        !"test4902"
        z1 <== p
        z2 <== x
        print.cccc (I 4902) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4903
        !"test4903"
        z1 <== p
        z2 <== x
        print.cccc (I 4903) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4904
        !"test4904"
        z1 <== 8.4
        z2 <== 8.4
        print.cccc (I 4904) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4905
        !"test4905"
        z1 <== (q/(-p)+(4.8)*(-q))
        z2 <== (y/(-x)+(4.8)*(-y))
        print.cccc (I 4905) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4906
        !"test4906"
        z1 <== (q-(-8.2)-((-q)+(4.4/6.6-p*(-5.8)/0.6))-(-p)+(-q)+(-q)*q*(-0.2)+(-p))
        z2 <== (y-(-8.2)-((-y)+(4.4/6.6-x*(-5.8)/0.6))-(-x)+(-y)+(-y)*y*(-0.2)+(-x))
        print.cccc (I 4906) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4907
        !"test4907"
        z1 <== (q+p*(((-p)*(-4.3))-(-q)-(p)*((-p)/(-q))+((-3.0)-(-q)*5.8/p)))
        z2 <== (y+x*(((-x)*(-4.3))-(-y)-(x)*((-x)/(-y))+((-3.0)-(-y)*5.8/x)))
        print.cccc (I 4907) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4908
        !"test4908"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4908) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4909
        !"test4909"
        z1 <== ((-q)*(5.2/p/(-q))*((q*(-7.1)+(-q)-p)*2.5+(p)+((-p)))*((-8.1))-((-3.7)-q+(-q)))
        z2 <== ((-y)*(5.2/x/(-y))*((y*(-7.1)+(-y)-x)*2.5+(x)+((-x)))*((-8.1))-((-3.7)-y+(-y)))
        print.cccc (I 4909) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4910
        !"test4910"
        z1 <== (-4.4)
        z2 <== (-4.4)
        print.cccc (I 4910) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4911
        !"test4911"
        z1 <== p
        z2 <== x
        print.cccc (I 4911) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4912
        !"test4912"
        z1 <== (-6.2)
        z2 <== (-6.2)
        print.cccc (I 4912) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4913
        !"test4913"
        z1 <== ((-6.5)-8.4/(p*3.1-q/6.8)+(-7.3)-(-1.2)+(8.8*(-p)+(-5.5)+(-0.1))-(q+8.4*((-q))*(q/(-3.2))))
        z2 <== ((-6.5)-8.4/(x*3.1-y/6.8)+(-7.3)-(-1.2)+(8.8*(-x)+(-5.5)+(-0.1))-(y+8.4*((-y))*(y/(-3.2))))
        print.cccc (I 4913) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4914
        !"test4914"
        z1 <== 2.5
        z2 <== 2.5
        print.cccc (I 4914) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4915
        !"test4915"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4915) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4916
        !"test4916"
        z1 <== (-3.1)
        z2 <== (-3.1)
        print.cccc (I 4916) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4917
        !"test4917"
        z1 <== (-7.6)
        z2 <== (-7.6)
        print.cccc (I 4917) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4918
        !"test4918"
        z1 <== p
        z2 <== x
        print.cccc (I 4918) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4919
        !"test4919"
        z1 <== p
        z2 <== x
        print.cccc (I 4919) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4920
        !"test4920"
        z1 <== (((7.7/(-1.0)-1.7+q-(-5.2))*5.3*(-p)*(-p))/(-5.5))
        z2 <== (((7.7/(-1.0)-1.7+y-(-5.2))*5.3*(-x)*(-x))/(-5.5))
        print.cccc (I 4920) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4921
        !"test4921"
        z1 <== (((8.4/(-q)-(-q)*q)/q-0.2+(-5.4)-(q-2.7-7.1)))
        z2 <== (((8.4/(-y)-(-y)*y)/y-0.2+(-5.4)-(y-2.7-7.1)))
        print.cccc (I 4921) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4922
        !"test4922"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4922) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4923
        !"test4923"
        z1 <== p
        z2 <== x
        print.cccc (I 4923) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4924
        !"test4924"
        z1 <== (((-1.1)+5.1+2.0/(-q)+(-p)-(-4.7))*((-q))*p/((-p)*(-5.4))/(q+(-1.4))+(-p)/p)
        z2 <== (((-1.1)+5.1+2.0/(-y)+(-x)-(-4.7))*((-y))*x/((-x)*(-5.4))/(y+(-1.4))+(-x)/x)
        print.cccc (I 4924) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4925
        !"test4925"
        z1 <== (-3.2)
        z2 <== (-3.2)
        print.cccc (I 4925) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4926
        !"test4926"
        z1 <== 5.1
        z2 <== 5.1
        print.cccc (I 4926) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4927
        !"test4927"
        z1 <== ((-p)/(-3.0)/(-p)-p/6.4*p+(0.4*(-q)+p*p-(-q))-((-p)*(-5.7)/q*8.3+q*(-4.8)*(-p)))
        z2 <== ((-x)/(-3.0)/(-x)-x/6.4*x+(0.4*(-y)+x*x-(-y))-((-x)*(-5.7)/y*8.3+y*(-4.8)*(-x)))
        print.cccc (I 4927) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4928
        !"test4928"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4928) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4929
        !"test4929"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 4929) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4930
        !"test4930"
        z1 <== (8.4-(((-1.1))-(-5.6)*q)/6.5/(6.5+(-0.7)/(-q)*6.2-3.8))
        z2 <== (8.4-(((-1.1))-(-5.6)*y)/6.5/(6.5+(-0.7)/(-y)*6.2-3.8))
        print.cccc (I 4930) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4931
        !"test4931"
        z1 <== (-3.5)
        z2 <== (-3.5)
        print.cccc (I 4931) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4932
        !"test4932"
        z1 <== ((((-2.2)+(-6.1)+8.3)-((-1.0)/(-8.7)/(-p)+(-p))/(-5.3)*(-q)/(-0.8)-2.6)-(((-3.6)*p+(-q))*q)/q+((-q)*p+(-p)-(-q))-5.4-p*(6.4*(-q)+7.1*2.3*6.8)/p-(-p))
        z2 <== ((((-2.2)+(-6.1)+8.3)-((-1.0)/(-8.7)/(-x)+(-x))/(-5.3)*(-y)/(-0.8)-2.6)-(((-3.6)*x+(-y))*y)/y+((-y)*x+(-x)-(-y))-5.4-x*(6.4*(-y)+7.1*2.3*6.8)/x-(-x))
        print.cccc (I 4932) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4933
        !"test4933"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4933) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4934
        !"test4934"
        z1 <== ((-q)*p)
        z2 <== ((-y)*x)
        print.cccc (I 4934) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4935
        !"test4935"
        z1 <== p
        z2 <== x
        print.cccc (I 4935) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4936
        !"test4936"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4936) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4937
        !"test4937"
        z1 <== q
        z2 <== y
        print.cccc (I 4937) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4938
        !"test4938"
        z1 <== (((-5.8)-6.5+2.2*(-0.5)+(p/(-q)-4.6))*(((-8.6)/(-q)/(-p))-(p-(-p)/p+5.5)*1.6-(-q)/(-1.2)+(-q)+(-p)-(-q)+3.2/1.3-q-p/(-6.4)/(-2.2))/((p/5.5*(-q))/(p/(-q)-(-p))+((-7.2)/(-0.0))+(-0.3)/q))
        z2 <== (((-5.8)-6.5+2.2*(-0.5)+(x/(-y)-4.6))*(((-8.6)/(-y)/(-x))-(x-(-x)/x+5.5)*1.6-(-y)/(-1.2)+(-y)+(-x)-(-y)+3.2/1.3-y-x/(-6.4)/(-2.2))/((x/5.5*(-y))/(x/(-y)-(-x))+((-7.2)/(-0.0))+(-0.3)/y))
        print.cccc (I 4938) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4939
        !"test4939"
        z1 <== p
        z2 <== x
        print.cccc (I 4939) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4940
        !"test4940"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4940) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4941
        !"test4941"
        z1 <== (((q+q)/(4.6+(-1.1)-1.3)/(-3.6)-7.2+4.8-p+(-4.3)-(-q)-(-q)))
        z2 <== (((y+y)/(4.6+(-1.1)-1.3)/(-3.6)-7.2+4.8-x+(-4.3)-(-y)-(-y)))
        print.cccc (I 4941) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4942
        !"test4942"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4942) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4943
        !"test4943"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4943) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4944
        !"test4944"
        z1 <== ((7.2)+7.5-8.4/q*(-2.1)-4.8*q+(-4.3))
        z2 <== ((7.2)+7.5-8.4/y*(-2.1)-4.8*y+(-4.3))
        print.cccc (I 4944) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4945
        !"test4945"
        z1 <== (p+(q-q+8.5+(-0.0))-(-5.8)/(((-8.5)-(-p)*q/(-p)*q)-((-q)+p*(-p)+(-1.5))+4.4))
        z2 <== (x+(y-y+8.5+(-0.0))-(-5.8)/(((-8.5)-(-x)*y/(-x)*y)-((-y)+x*(-x)+(-1.5))+4.4))
        print.cccc (I 4945) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4946
        !"test4946"
        z1 <== (((4.6)+((-p)*3.7)-((-3.4)))-(-3.0))
        z2 <== (((4.6)+((-x)*3.7)-((-3.4)))-(-3.0))
        print.cccc (I 4946) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4947
        !"test4947"
        z1 <== ((-8.4)+(-p))
        z2 <== ((-8.4)+(-x))
        print.cccc (I 4947) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4948
        !"test4948"
        z1 <== 5.7
        z2 <== 5.7
        print.cccc (I 4948) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4949
        !"test4949"
        z1 <== (p)
        z2 <== (x)
        print.cccc (I 4949) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4950
        !"test4950"
        z1 <== 6.5
        z2 <== 6.5
        print.cccc (I 4950) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4951
        !"test4951"
        z1 <== (((-q)*(0.2*(-q)-p/7.0-(-5.2))+((-0.1)-p+(-8.2)-p)+(-p)/5.5)*((-p)/q-(-2.7))+(-0.5))
        z2 <== (((-y)*(0.2*(-y)-x/7.0-(-5.2))+((-0.1)-x+(-8.2)-x)+(-x)/5.5)*((-x)/y-(-2.7))+(-0.5))
        print.cccc (I 4951) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4952
        !"test4952"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4952) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4953
        !"test4953"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4953) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4954
        !"test4954"
        z1 <== 5.8
        z2 <== 5.8
        print.cccc (I 4954) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4955
        !"test4955"
        z1 <== ((-4.6)+p+3.3)
        z2 <== ((-4.6)+x+3.3)
        print.cccc (I 4955) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4956
        !"test4956"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4956) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4957
        !"test4957"
        z1 <== (p*(((-q)+4.0+5.5-p)+p+((-3.0)+3.3/q-q+(-4.2))/((-p)*q*(-7.7)-(-7.8)*4.8))-((-5.3)/((-p)/q/2.6-q))-((1.3+q+0.3)-(-1.6)+((-4.5)-(-0.2))-q))
        z2 <== (x*(((-y)+4.0+5.5-x)+x+((-3.0)+3.3/y-y+(-4.2))/((-x)*y*(-7.7)-(-7.8)*4.8))-((-5.3)/((-x)/y/2.6-y))-((1.3+y+0.3)-(-1.6)+((-4.5)-(-0.2))-y))
        print.cccc (I 4957) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4958
        !"test4958"
        z1 <== (4.5-((4.1*1.8)*(-q)+p/(p-(-7.7)+q))/(-p)-(-4.6)-((-p))/p-((-5.2)/3.2/(-1.2)-(-6.8)/(-3.1))-q)
        z2 <== (4.5-((4.1*1.8)*(-y)+x/(x-(-7.7)+y))/(-x)-(-4.6)-((-x))/x-((-5.2)/3.2/(-1.2)-(-6.8)/(-3.1))-y)
        print.cccc (I 4958) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4959
        !"test4959"
        z1 <== ((-2.1)+((-q)+(-8.3)/(-q))-(-q)-(0.3/(-p)/(-p))+((-2.5)/(-q)*8.6+(-q))+(-3.4)*4.0)
        z2 <== ((-2.1)+((-y)+(-8.3)/(-y))-(-y)-(0.3/(-x)/(-x))+((-2.5)/(-y)*8.6+(-y))+(-3.4)*4.0)
        print.cccc (I 4959) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4960
        !"test4960"
        z1 <== ((4.5+(8.8+(-p)))/(-5.0)-(-p)/(-8.8))
        z2 <== ((4.5+(8.8+(-x)))/(-5.0)-(-x)/(-8.8))
        print.cccc (I 4960) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4961
        !"test4961"
        z1 <== ((5.3/(-q)+p+q*1.2)*(-p)/((q))-(-p)/(-5.6))
        z2 <== ((5.3/(-y)+x+y*1.2)*(-x)/((y))-(-x)/(-5.6))
        print.cccc (I 4961) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4962
        !"test4962"
        z1 <== ((5.7)-8.7/(-2.7)-(-8.6)+p)
        z2 <== ((5.7)-8.7/(-2.7)-(-8.6)+x)
        print.cccc (I 4962) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4963
        !"test4963"
        z1 <== ((-p)+(-q)/6.7/q*(-1.4)/(-2.3)+(-5.8)*((-4.7)/(-8.3))+q-0.3-7.7/p-(-4.1)*(3.1-(1.4-(-6.3)+1.6/p)*(p+(-q)/(-7.3))+p)+6.7)
        z2 <== ((-x)+(-y)/6.7/y*(-1.4)/(-2.3)+(-5.8)*((-4.7)/(-8.3))+y-0.3-7.7/x-(-4.1)*(3.1-(1.4-(-6.3)+1.6/x)*(x+(-y)/(-7.3))+x)+6.7)
        print.cccc (I 4963) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4964
        !"test4964"
        z1 <== p
        z2 <== x
        print.cccc (I 4964) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4965
        !"test4965"
        z1 <== (-4.1)
        z2 <== (-4.1)
        print.cccc (I 4965) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4966
        !"test4966"
        z1 <== (-1.1)
        z2 <== (-1.1)
        print.cccc (I 4966) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4967
        !"test4967"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4967) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4968
        !"test4968"
        z1 <== 0.5
        z2 <== 0.5
        print.cccc (I 4968) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4969
        !"test4969"
        z1 <== ((-q)/(((-2.3))/q+((-0.6)+(-p)-(-7.5)+(-q)))-p-((-1.1)+(-p)*4.5)*q-p/(-1.3)+0.4-(-q)+((-p)/p)-((-q)))
        z2 <== ((-y)/(((-2.3))/y+((-0.6)+(-x)-(-7.5)+(-y)))-x-((-1.1)+(-x)*4.5)*y-x/(-1.3)+0.4-(-y)+((-x)/x)-((-y)))
        print.cccc (I 4969) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4970
        !"test4970"
        z1 <== p
        z2 <== x
        print.cccc (I 4970) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4971
        !"test4971"
        z1 <== (1.1+(-q)/(-p))
        z2 <== (1.1+(-y)/(-x))
        print.cccc (I 4971) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4972
        !"test4972"
        z1 <== q
        z2 <== y
        print.cccc (I 4972) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4973
        !"test4973"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4973) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4974
        !"test4974"
        z1 <== (-8.8)
        z2 <== (-8.8)
        print.cccc (I 4974) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4975
        !"test4975"
        z1 <== 1.8
        z2 <== 1.8
        print.cccc (I 4975) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4976
        !"test4976"
        z1 <== ((-p))
        z2 <== ((-x))
        print.cccc (I 4976) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4977
        !"test4977"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4977) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4978
        !"test4978"
        z1 <== (-3.5)-p-(-q)-(-4.1)
        z2 <== (-3.5)-x-(-y)-(-4.1)
        print.cccc (I 4978) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4979
        !"test4979"
        z1 <== p-q*(((-q)/8.5)+(-q)/((-8.8))+((-p)*q-(-4.2)*3.4+(-0.7))/4.5)+((-q))-p
        z2 <== x-y*(((-y)/8.5)+(-y)/((-8.8))+((-x)*y-(-4.2)*3.4+(-0.7))/4.5)+((-y))-x
        print.cccc (I 4979) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4980
        !"test4980"
        z1 <== ((-p)+(((-0.1)*5.4)-4.8+2.3)*(((-2.8)-(-p))))
        z2 <== ((-x)+(((-0.1)*5.4)-4.8+2.3)*(((-2.8)-(-x))))
        print.cccc (I 4980) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4981
        !"test4981"
        z1 <== (((-p)-(-q)/(p+(-2.0)+p-(-5.3))-(-p)+7.7)+5.2/((3.4/3.1+q-q)+8.4*q)/((-7.5)+(-q))*(-5.2)/((-3.2)-(-q)/(-p)-8.3)-((-1.6)*q)+q)
        z2 <== (((-x)-(-y)/(x+(-2.0)+x-(-5.3))-(-x)+7.7)+5.2/((3.4/3.1+y-y)+8.4*y)/((-7.5)+(-y))*(-5.2)/((-3.2)-(-y)/(-x)-8.3)-((-1.6)*y)+y)
        print.cccc (I 4981) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4982
        !"test4982"
        z1 <== ((5.8)+8.7/((-p)-(-p)/q-(-7.5))/(-3.4)*5.7)-((-0.2)+(q-(-p)-7.4/8.2)*p/(-0.1)-q)+(0.0/8.0/q*(-q))*q-8.8/((-8.8)-(-q)+(-5.2))+(-q)-1.2
        z2 <== ((5.8)+8.7/((-x)-(-x)/y-(-7.5))/(-3.4)*5.7)-((-0.2)+(y-(-x)-7.4/8.2)*x/(-0.1)-y)+(0.0/8.0/y*(-y))*y-8.8/((-8.8)-(-y)+(-5.2))+(-y)-1.2
        print.cccc (I 4982) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4983
        !"test4983"
        z1 <== 8.5
        z2 <== 8.5
        print.cccc (I 4983) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4984
        !"test4984"
        z1 <== (-7.1)
        z2 <== (-7.1)
        print.cccc (I 4984) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4985
        !"test4985"
        z1 <== ((3.8/5.4*p-p-p)/(-2.6)+((p)))
        z2 <== ((3.8/5.4*x-x-x)/(-2.6)+((x)))
        print.cccc (I 4985) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4986
        !"test4986"
        z1 <== q
        z2 <== y
        print.cccc (I 4986) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4987
        !"test4987"
        z1 <== ((1.3/(-q)*p+6.7*q)*((-q)+p)*((-p)-(-q)/(-p))/(p+(-2.2)/p/(-7.5)*(-2.5))+(q+p-p)*(-q)-p)
        z2 <== ((1.3/(-y)*x+6.7*y)*((-y)+x)*((-x)-(-y)/(-x))/(x+(-2.2)/x/(-7.5)*(-2.5))+(y+x-x)*(-y)-x)
        print.cccc (I 4987) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4988
        !"test4988"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4988) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4989
        !"test4989"
        z1 <== (-p)
        z2 <== (-x)
        print.cccc (I 4989) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4990
        !"test4990"
        z1 <== q
        z2 <== y
        print.cccc (I 4990) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4991
        !"test4991"
        z1 <== ((-5.5)*(-q)*((-q)/3.4-p-(-q)))
        z2 <== ((-5.5)*(-y)*((-y)/3.4-x-(-y)))
        print.cccc (I 4991) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4992
        !"test4992"
        z1 <== (-q)
        z2 <== (-y)
        print.cccc (I 4992) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4993
        !"test4993"
        z1 <== q
        z2 <== y
        print.cccc (I 4993) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4994
        !"test4994"
        z1 <== (-7.2)-((-2.5)-(-p)*(-q))-(-3.1)-(-2.8)+(-8.0)-2.2/(-p)+((-p)-(0.1)+(-3.6))-((-p)-p*1.5*(-p)/q)/(-0.1)/((-p)*q/q-(-7.6)+8.5)/(-p)+(-2.7)
        z2 <== (-7.2)-((-2.5)-(-x)*(-y))-(-3.1)-(-2.8)+(-8.0)-2.2/(-x)+((-x)-(0.1)+(-3.6))-((-x)-x*1.5*(-x)/y)/(-0.1)/((-x)*y/y-(-7.6)+8.5)/(-x)+(-2.7)
        print.cccc (I 4994) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4995
        !"test4995"
        z1 <== (-6.3)
        z2 <== (-6.3)
        print.cccc (I 4995) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4996
        !"test4996"
        z1 <== (3.3-(6.2+4.7*8.5/4.5*7.5)-(-q)/p-(4.3-3.1-(-p)/1.3)/(5.5)+((-q)-(-0.5))-p)
        z2 <== (3.3-(6.2+4.7*8.5/4.5*7.5)-(-y)/x-(4.3-3.1-(-x)/1.3)/(5.5)+((-y)-(-0.5))-x)
        print.cccc (I 4996) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4997
        !"test4997"
        z1 <== p
        z2 <== x
        print.cccc (I 4997) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4998
        !"test4998"
        z1 <== ((6.6+3.1+p))
        z2 <== ((6.6+3.1+x))
        print.cccc (I 4998) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 4999
        !"test4999"
        z1 <== (-5.7)
        z2 <== (-5.7)
        print.cccc (I 4999) z1 z2 (asm.abs(z1-z2))
        printfn "%d" 5000
        !"test5000"
        z1 <== ((((-1.8)+3.7*(-3.6)*(-q))/(-8.1)+(-3.7)*p/q+(p+(-p)))/(((-0.8))))
        z2 <== ((((-1.8)+3.7*(-3.6)*(-y))/(-8.1)+(-3.7)*x/y+(x+(-x)))/(((-0.8))))
        print.cccc (I 5000) z1 z2 (asm.abs(z1-z2))
