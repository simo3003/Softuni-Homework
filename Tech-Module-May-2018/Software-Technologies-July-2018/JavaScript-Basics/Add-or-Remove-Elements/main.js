function addOrRemoveElements(arr) {
    let newArr = [];

    for (const command of arr) {
        let splitCommand = command.split(' ');

        if(splitCommand[0] === 'add') {
            newArr.push(Number(splitCommand[1]));
        }

        else {
            let index = Number(splitCommand[1]);
            if(index >= 0 && index < newArr.length) {
                newArr.splice(index, 1);
            }
        }
    }

    for (const element of newArr) {
        console.log(element);
    }
}