namespace FizzBuzz

type FizzBuzzType =
    | Number of int
    | Fizz
    | Buzz
    | FizzBuzz

module FizzBuzz =
    let IsDivisibleBy div number = number % div = 0
    let IsDivisibleByThree = IsDivisibleBy 3
    let IsDivisibleByFive = IsDivisibleBy 5
    let IsDivisibleByThreeAndFive number = IsDivisibleByThree number && IsDivisibleByFive number

    let FizzBuzz number : FizzBuzzType =
        if IsDivisibleByThreeAndFive number then FizzBuzz
        elif IsDivisibleByThree number then Fizz
        elif IsDivisibleByFive number then Buzz
        else Number number