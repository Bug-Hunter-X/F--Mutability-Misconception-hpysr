let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printfn "%d" z

x <- 100
y <- 200

// To update z, the add function needs to be called again with the new values
let z2 = add x y
printfn "%d" z2