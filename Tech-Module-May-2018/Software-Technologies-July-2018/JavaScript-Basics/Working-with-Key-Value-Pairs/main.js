function workingWithKvP(arr) {
    let object = {};
    
    for (const element of arr) {
        let splitElement = element.split(' ');
        if(splitElement.length < 2) {
            let key = splitElement[0];
            if(object.hasOwnProperty(key)) {
                console.log(object[key]);
            } else {
                console.log('None');
            }
        } else {
            let key = splitElement[0];
            let value = splitElement[1];
            object[key] = value;
        }
    }
}