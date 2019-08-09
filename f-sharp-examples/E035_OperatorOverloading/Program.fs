type Vector2D(x: float, y: float) =
    member this.x = x
    member this.y = y
    
    static member(+)(this: Vector2D, rhs: Vector2D) =
        Vector2D(this.x + rhs.x, this.y + rhs.y)
        
    override this.ToString() =
        "(" + this.x.ToString() + ", " + this.y.ToString() + ")"


let main args =
    let v1 = Vector2D(3.0, 5.0)
    let v2 = Vector2D(6.0, 8.0)
    let v3 = v1 + v2
    
    printfn "%s" (v1.ToString())
    printfn "%s" (v2.ToString())
    printfn "%s" (v3.ToString())
    
    0
    
main() |> ignore