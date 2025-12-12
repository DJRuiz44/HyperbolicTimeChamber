let num = 10;

function factorialCalculator(number){
  let result = 1;
  // while(number != 0){
  //   result *= number;
  //   number--;
  // }
  for(let i = 1; i < number + 1; i++){
    result *= i;
  }
  return result;
}

let factorial = factorialCalculator(num);
let resultMsg = `Factorial of ${num} is ${factorial}`;
console.log(resultMsg);