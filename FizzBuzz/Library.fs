namespace FizzBuzz


type FizzBuzzType = 
    | Number of int
    | Fizz 
    | Buzz 
    | FizzBuzz 

    


module FizzBuzz =
    let FizzBuzz number: FizzBuzzType = 
        if number % 3 = 0 && number % 5 = 0 then FizzBuzz
        elif number % 3 = 0 then Fizz
        elif number % 5 = 0 then Buzz
        else Number number




