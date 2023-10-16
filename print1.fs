﻿(*
Copyright (c) 2022 Jun-ichiro Sugisaka

This software is released under the MIT License.
http://opensource.org/licenses/mit-license.php
*)
namespace Aqualis
    
    open System
    open System.IO
    open System.Text
    open Aqualis_base

    ///<summary>画面表示</summary>
    type print () =
        ///<summary>変数リストを画面表示</summary>
        static member s (lst:num0 list)  = 
            match p.lang with
            |F ->
                let p = p.param
                let clist = 
                    [for q in lst do
                        match q.etype,q.expr with
                        |St,Str_c(s) ->
                            yield ("\""+s+"\"")
                        |Zt,_ ->
                            yield q.re.code
                            yield q.im.code
                        |_ ->
                            yield q.code ]
                let code = List.fold (fun acc i -> acc + (if i=0 then "" else ",") + clist[i]) "" [0..clist.Length-1] 
                p.codewrite("print *, "+code+"\n")
            |C ->
                let p = p.param
                let int0string_format_C =
                    "%"+p.int_string_format.ToString()+"d"
                let double0string_format_C = 
                    let (a,b)=p.double_string_format
                    "%"+a.ToString()+"."+b.ToString()+"e"
                let format = 
                    (List.fold (fun acc (q:num0) ->
                                  match q.expr with
                                  |Str_c s -> acc+s
                                  |_ ->
                                      match q.etype with
                                      |It _ ->
                                          acc+int0string_format_C
                                      |Dt ->
                                          acc+double0string_format_C
                                      |Zt ->
                                          acc+double0string_format_C+double0string_format_C
                                      |_ ->
                                          acc) "" lst)+"\\n"
                let code   = 
                    List.fold (fun acc (q:num0) -> 
                                 match q.etype with
                                 |St -> ""
                                 |Zt -> acc+","+q.re.code+","+q.im.code
                                 |_  -> acc+","+q.code) "" lst
                p.codewrite("printf(\""+format+"\""+code+");\n")
            |T ->
                let p = p.param
                let code = 
                  (fun (s:string) -> s.Replace("#,","")) 
                    (List.fold (fun acc (q:num0) -> 
                        acc+","+q.code) "#" lst)
                p.codewrite("print, "+code+"\n")
            |H ->
                let p = p.param
                let code =  
                    (List.fold (fun acc (i:int) -> 
                        let q = lst.[i]
                        if i=lst.Length-1 then
                            acc+q.code
                        else
                            acc+q.code+"<mo>,</mo><mspace width=\"0.5em\" />"
                    ) "" [0..lst.Length-1])
                p.codewrite("<math><mi>print</mi><mo>[</mo>"+code+"<mo>]</mo></math>\n")
                p.codewrite("<br/>\n")
        ///<summary>文字列を画面表示</summary>
        static member t (str:string) = print.s[!.str]
        ///<summary>1個の項目を画面表示</summary>
        static member c (ss:num0) = print.s[ss]
        ///<summary>2個の項目を画面表示</summary>
        static member cc (s1:num0) (s2:num0) = print.s[s1;s2]
        ///<summary>3個の項目を画面表示</summary>
        static member ccc (s1:num0) (s2:num0) (s3:num0) = print.s[s1;s2;s3]
        ///<summary>4個の項目を画面表示</summary>
        static member cccc (s1:num0) (s2:num0) (s3:num0) (s4:num0) = print.s[s1;s2;s3;s4]
        ///<summary>1個の項目をラベル付きで画面表示</summary>
        static member tc (tag:string) (s:num0) = print.s[!.tag;s]
        ///<summary>2個の項目をラベル付きで画面表示</summary>
        static member tcc (tag:string) (s1:num0) (s2:num0) = print.s[!.tag;s1;s2]
        ///<summary>3個の項目をラベル付きで画面表示</summary>
        static member tccc (tag:string) (s1:num0) (s2:num0) (s3:num0) = print.s[!.tag;s1;s2;s3]
        ///<summary>4個の項目をラベル付きで画面表示</summary>
        static member tcccc (tag:string) (s1:num0) (s2:num0) (s3:num0) (s4:num0) = print.s[!.tag;s1;s2;s3;s4]
        