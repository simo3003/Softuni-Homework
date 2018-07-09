function multipleValuesForAKey(arr) {
    let object = {};
    
    for (const element of arr) {
        let splitElement = element.split(' ');
        if(splitElement.length < 2) {
            let key = splitElement[0];
            if(object.hasOwnProperty(key)) {
                for (const value of object[key]) {
                    console.log(value);
                }
            } else {
                console.log('None');
            }
        } else {
            let key = splitElement[0];
            let value = splitElement[1];
            if(object.hasOwnProperty(key)) {
                object[key].push(value);
            } else {
                object[key] = [value];
            }
        }
    }
}