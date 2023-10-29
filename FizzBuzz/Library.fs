namespace FizzBuzz


type FizzBuzzType = 
    | Number of int
    | String of string

module FizzBuzz =
    let FizzBuzz number: FizzBuzzType = 
        match number with
            | 3 -> String "Fizz"
            | 5 -> String "Buzz"
            | _ -> Number number
