function printLines(lines) {
    for (const line of lines) {
        if (line == 'Stop') {
            break;
        }
        else {
            console.log(line);
        }
    }
}