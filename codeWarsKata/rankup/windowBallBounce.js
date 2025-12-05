function bouncingBall(h, bounce, window) {
  // your code here
  if (h > 0 && bounce > 0 && bounce < 1 && window < h) {
    let count = 0;
    if (h > window) {
      count = 1;
    }
    while (h > window) {
      if (h * bounce > window) {
        h = h * bounce;
        count += 2;
      } else {
        return count;
      }
    }
  } else {
    return -1;
  }
}

console.log(bouncingBall(30.0, 0.66, 1.5)); //15
