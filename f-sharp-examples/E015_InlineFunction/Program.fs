type MathUtil() =
    class
        member inline this.ReturnSquare(a: int) = a * a
 end


let mathUtil = new MathUtil()
let result = mathUtil.ReturnSquare 3
printfn "%d"result