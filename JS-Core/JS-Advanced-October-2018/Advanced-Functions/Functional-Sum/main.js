;function solve(num) {
  if (solve.sum) {
    solve.sum += num;
    return solve;
  }
  solve.sum = num;
  solve.toString = function() {
    return solve.sum;
  };
  return solve;
}
