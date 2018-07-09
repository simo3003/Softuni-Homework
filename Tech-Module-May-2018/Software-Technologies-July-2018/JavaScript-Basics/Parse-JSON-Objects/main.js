function parseJSON(arr) {
    let objects = [];
    for (const object of arr) {
        let parsedObject = JSON.parse(object);
        objects.push(parsedObject);
    }
    
    for (const object of objects) {
        console.log(`Name: ${object.name}`);
        console.log(`Age: ${object.age}`);
        console.log(`Date: ${object.date}`);
    }
}