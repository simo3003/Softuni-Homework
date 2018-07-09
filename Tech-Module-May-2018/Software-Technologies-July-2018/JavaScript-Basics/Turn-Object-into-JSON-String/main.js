function turnObjectIntoJSON(arr) {
    let person = {};
    for (const line of arr) {
        let splitLine = line.split(' -> ');
        let key = splitLine[0];
        let value = splitLine[1];
        if(!isNaN(value)) { 
            value = Number(value);
        }
        person[key] = value;
    }
    return JSON.stringify(person);
}