function solve(arr) {
    let racers = arr[0].split(/\s+/);
    arr.shift();

    for (let item of arr) {
        let [action, racer] = item.split(/\s+/);
        switch (action) {
            case 'Pit':
                if (racers.includes(racer)) {
                    let index = racers.indexOf(racer);
                    if (index != 0) {
                        racers.splice(index + 1, 0, racers.splice(index, 1)[0]);
                    }
                }
                break;
            case 'Overtake':
                if (racers.includes(racer)) {
                    let index = racers.indexOf(racer);
                    if (index != 0) {
                        racers.splice(index - 1, 0, racers.splice(index, 1)[0]);
                    }
                }
                break;
            case 'Crash':
                if (racers.includes(racer)) {
                    let index = racers.indexOf(racer);
                    racers.splice(index, 1)
                }
                break;
            case 'Join':
                if (!racers.includes(racer)) {
                    racers.push(racer);
                }
                break;
            default:
                break;
        }
    }

    console.log(racers.join(' ~ '));

}
