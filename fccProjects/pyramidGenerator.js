function pyramid(char, rows, isDown){
  if(char.length > 1){
    return "NO";
  }
  let returnStr = "\n";
  let rowCharCount;
  if(!isDown){
    rowCharCount = 1;
    for(let i = 0; i < rows; i++){
      returnStr += " ".repeat((rows - 1) - i);
      returnStr += char.repeat(rowCharCount);
      rowCharCount += 2;
      returnStr += "\n";
    }
    return returnStr;
  } else {
    console.log("test");
    rowCharCount = rows * 2 - 1;
    let spaceCount = 0;
    console.log(rowCharCount);
    while(rowCharCount >= 1){
      returnStr += " ".repeat(spaceCount);
      spaceCount++;
      returnStr += char.repeat(rowCharCount);
      returnStr += "\n";
      rowCharCount -= 2;
    }
    return returnStr;
  }
}

let downPyramid = pyramid("p", 5, true); 
let upPyramid = pyramid("o", 20, false);

console.log("The great up pyramid of dog");
console.log(upPyramid);

console.log("The amazing down pyramid of bear");
console.log(downPyramid);