function solve() {
  let types = {};

  for (let arg of arguments) {
    let type = typeof arg;
    console.log(`${type}: ${arg}`);
    if (types[type]) {
      types[type]++;
    } else {
      types[type] = 1;
    }
  }

  let sortedTypes = [];

  for (let type in types) {
    sortedTypes.push([type, types[type]]);
  }

  sortedTypes.sort((a, b) => b[1] - a[1]);

  for (let type of sortedTypes) {
    console.log(`${type[0]} = ${type[1]}`);
  }
}
