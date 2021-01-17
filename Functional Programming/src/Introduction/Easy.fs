namespace FunctionalProgramming.Introduction

open System

module Easy =
    // Hello World 
    // Source: https://www.hackerrank.com/challenges/fp-hello-world/problem
    let helloWorld = "Hello World"

    // Hello World N Times
    // Source: https://www.hackerrank.com/challenges/fp-hello-world-n-times/problem
    let nHelloWorld n = [ for i in [ 1 .. n ] do helloWorld ]  
            
    // List Replication
    // Source: https://www.hackerrank.com/challenges/fp-list-replication/problem
    let replicateListElements times list = [ for element in list do (for i in [ 1..times ] do element) ]

    // let repeat times list = 
    //     for element in list do print times element

    // let 


    replicateListElements 3 [1;2;3]

        
    