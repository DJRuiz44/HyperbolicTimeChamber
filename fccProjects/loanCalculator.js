const minIncomeForDuplex = 60000;
const minCreditScoreForDuplex = 700;

const minIncomeForCondo = 45000;
const minCreditScoreForCondo = 680;

const minIncomeForCar = 30000;
const minCreditScoreForCar = 650;

function getLoanMessage(annualIncome, creditScore) {
  if (
    creditScore >= minCreditScoreForDuplex &&
    annualIncome >= minIncomeForDuplex
  ) {
    return "You qualify for a duplex, condo, and car loan.";
  } else if (
    annualIncome >= minIncomeForCondo &&
    creditScore >= minCreditScoreForCondo
  ) {
    return "You qualify for a condo and car loan.";
  } else if (
    annualIncome >= minIncomeForCar &&
    creditScore >= minCreditScoreForCar
  ) {
    return "You qualify for a car loan.";
  } else {
    return "You don't qualify for any loans.";
  }
}
let duplexMsg = getLoanMessage(85000, 850);
let condoMsg = getLoanMessage(65000, 690);
let carMsg = getLoanMessage(45000, 660);
let noLoanMsg = getLoanMessage(25000, 550);

console.log(duplexMsg);
console.log(condoMsg);
console.log(carMsg);
console.log(noLoanMsg);
