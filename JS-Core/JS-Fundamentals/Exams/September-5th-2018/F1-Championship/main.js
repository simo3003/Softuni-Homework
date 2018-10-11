function solve(arr) {
    let results = {};

    for (let item of arr) {
        let [team, pilot, points] = item.split(' -> ');
        if (!(team && pilot && points)) {
            continue;
        }

        if (results.hasOwnProperty(team)) {
            if (results[team].pilots.hasOwnProperty(pilot)) {
                results[team].pilots[pilot] += +points;
                results[team].score += +points;
            } else {
                results[team].pilots[pilot] = +points;
                results[team].score += +points;
            }
        } else {
            results[team] = {
                pilots: {
                    [pilot]: +points
                },
                score: +points
            }
        }
    }

    let sortedTeams = [];

    for (let key in results) {
        sortedTeams.push([key, results[key]]);
    }

    sortedTeams.sort((a, b) => {
        return b[1].score - a[1].score;
    });

    let counter = 0;
    for (let item of sortedTeams) {
        if (counter == 3) {
            break;
        }
        console.log(`${item[0]}: ${item[1].score}`);
        let pilots = item[1].pilots;
        let sortedPilots = [];

        for (let key in pilots) {
            sortedPilots.push([key, pilots[key]]);
        }

        sortedPilots.sort((a, b) => {
            return b[1] - a[1];
        });

        for (let pilot of sortedPilots) {
            console.log(`-- ${pilot[0]} -> ${pilot[1]}`);
        }

        counter++;
    }
}

solve(["Ferrari -> Kimi Raikonnen -> 25",
    "Ferrari -> Sebastian Vettel -> 18",
    "Mercedes -> Lewis Hamilton -> 10",
    "Mercedes -> Valteri Bottas -> 8",
    "Red Bull -> Max Verstapen -> 6",
    "Red Bull -> Daniel Ricciardo -> 4"])
