function solve(arr) {
    let kompotFruits = {
        peach: 0,
        plum: 0,
        cherry: 0,
    };

    let bucket = 0;

    for (let item of arr) {
        let [fruit, kilos] = item.split(/\s+/);

        if (kompotFruits.hasOwnProperty(fruit)) {
            kompotFruits[fruit] += +kilos;
        } else {
            bucket += +kilos;
        }
    }

    let peachCount = kompotFruits.peach * 1000 / 140;
    let plumCount = kompotFruits.plum * 1000 / 20;
    let cherryCount = kompotFruits.cherry * 1000 / 9;

    let peachKompot = Math.floor(peachCount / 2.5);
    let plumKompot = Math.floor(plumCount / 10);
    let cherryKompot = Math.floor(cherryCount / 25);

    let rakiq = bucket * 0.200;

    console.log(`Cherry kompots: ${cherryKompot}\nPeach kompots: ${peachKompot}\nPlum kompots: ${plumKompot}\nRakiya liters: ${rakiq.toFixed(2)}`);
}

