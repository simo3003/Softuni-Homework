function setValuesToIndexesInArray(arr) {
    let arrSize = Number(arr[0]);
    let newArr = new Array(arrSize).fill(0);

    for (let i = 1; i < arr.length; i++) {
        let splitInput = arr[i].split(' - ');
        let index = Number(splitInput[0]);
        let value = Number(splitInput[1]);
        newArr[index] = value;
    }

    for (const element of newArr) {
        console.log(element);
    }
}
