const questions = [];
questions.push({category: "Science", question: "einstein said what?", choices: ["A", "B", "C"], answer: "A"});
questions.push({category: "Science", question: "einstein said who?", choices: ["A", "B", "C"], answer: "B"});
questions.push({category: "Science", question: "einstein said why?", choices: ["A", "B", "C"], answer: "C"});
questions.push({category: "Science", question: "einstein said why?", choices: ["A", "B", "C"], answer: "B"});
questions.push({category: "Science", question: "einstein said why?", choices: ["A", "B", "C"], answer: "A"});

function getRandomQuestion(questions){
  return questions[Math.floor(Math.random() * questions.length)];
}

console.log(getRandomQuestion(questions));

function getRandomComputerChoice(choices){
  return choices[Math.floor(Math.random() * choices.length)]
}

console.log(getRandomComputerChoice(questions[0].choices));

function getResults(question, computerChoice){
  if(computerChoice == question.answer){
    return "The computer's choice is correct!";
  } else {
    return "The computer's choice is wrong. The correct answer is: " + question.answer;
  }
}

console.log(getResults(questions[0], getRandomComputerChoice(questions[0])));