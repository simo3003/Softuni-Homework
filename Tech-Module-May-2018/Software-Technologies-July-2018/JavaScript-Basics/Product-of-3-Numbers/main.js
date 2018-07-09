function isProductOf3NumsNegOrPos(arr) {
    let amountOfNegNum = arr.filter(num => num < 0).length;
    if (amountOfNegNum % 2 == 0) {
        return 'Positive';
    } else {
        return 'Negative';
    }
}