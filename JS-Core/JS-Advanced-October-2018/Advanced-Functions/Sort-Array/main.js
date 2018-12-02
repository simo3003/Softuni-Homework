function solve(arr, type) {
    if (type == "asc") {
       return arr.sort((a,b) => a - b);
    } else if (type == "desc") {
       return arr.sort((a,b) => b - a); 
    }
}
