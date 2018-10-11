function solve(arr) {
    let pattern = /^(([!@#$?]*[a-z]*[!@#$?]*)+)=(\d+)--(\d+)<<(\w+)$/;

    let organisms = {};

    for (let item of arr) {
        if (item === 'Stop!') {
            break;
        }

        let match = item.match(pattern);
        if (match === null) {
            continue;
        }

        let name = match[1].replace(/[!@#$?]*/g, '');
        let length = Number(match[3]);
        let genomes = Number(match[4]);
        let organism = match[5];

        if (name.length != length) {
            continue;
        }

        if (organisms.hasOwnProperty(organism)) {
            organisms[organism] += genomes;
        } else {
            organisms[organism] = genomes;
        }
    }

    let sortedOrganisms = [];

    for (let key in organisms) {
        sortedOrganisms.push([key, organisms[key]]);
    }

    sortedOrganisms.sort((a, b) => {
        return b[1] - a[1];
    });

    for (let item of sortedOrganisms) {
        console.log(`${item[0]} has genome size of ${item[1]}`);
    }

}

solve([
    '!@ab?si?di!a@=7--152<<human',
    'b!etu?la@=6--321<<dog',
    '!curtob@acter##ium$=14--230<<dog',
    '!some@thin@g##=9<<human',
    'Stop!'])

// solve([
//     '=12<<cat',
//     '!vi@rus?=2--142',
//     '?!cur##viba@cter!!=11--800<<cat',
//     '!fre?esia#=7--450<<mouse',
//     '@pa!rcuba@cteria$=13--351<<mouse',
//     '!richel#ia??=8--900<<human',
//     'Stop!'
// ])

// solve([
//     '!@ру?би#=4--57<<polecat',
//     '?do?@#ri#=4--89<<polecat',
//     '=12<<cat',
//     '!vi@rus?=2--142',
//     '@pa!rcu>ba@cteria$=13--234<<mouse',
//     '?!cur##viba@cter!!=11--680<<cat',
//     'Stop!'
// ])