    const lunches = [];
function addLunchToEnd(lunches, lunch){
  lunches.push(lunch);
  console.log(lunch + " added to the end of the lunch menu.");
  return lunches;
}
function addLunchToStart(lunches, lunch){
  lunches.unshift(lunch);
  console.log(lunch + " added to the start of the lunch menu.");
  return lunches;
}
function removeLastLunch(lunches){
  let last;
  if(lunches.length >= 1){
    last = lunches.pop();
    console.log(last + " removed from the end of the lunch menu.");
  } else {
    console.log("No lunches to remove.");
  }
  return lunches;
}

function removeFirstLunch(lunches){
  if(lunches.length >= 1){
    let first = lunches.shift();
    console.log(first + " removed from the start of the lunch menu.");
  } else {
    console.log("No lunches to remove.");
  }
  return lunches;
}

function getRandomLunch(lunchesArray){
  if(lunchesArray.length >= 1){
    let random = Math.floor(Math.random() * (lunchesArray.length));
    console.log("Randomly selected lunch: " + lunchesArray[random]);
  } else {
    console.log("No lunches available.");
  }
}

function showLunchMenu(lunches){
  if(lunches.length >= 1){
    console.log("Menu items: " + [...lunches].join(", "));
  } else {
    console.log("The menu is empty.");
  }
}
addLunchToEnd(lunches, "sandwhich");
addLunchToEnd(lunches, "french fries");
getRandomLunch(lunches);
showLunchMenu(["Greens", "Corns", "Beans"]);