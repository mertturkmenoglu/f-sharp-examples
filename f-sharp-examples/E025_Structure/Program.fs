type Student =
    struct
        val id: int
        val name: string
        val age: int
        
        // Constructor        
        new (id, name, age) =
            { id = id; name = name; age = age; }
end

let std = new Student(42, "Emily", 21)
printfn "id: %d\nname: %s\nage: %d" std.id std.name std.age