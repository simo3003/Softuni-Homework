function storeStudents(arr) {
    let students = [];

    for (const line of arr) {
        let splitLine = line.split(' -> ');
        let name = splitLine[0];
        let age = splitLine[1];
        let grade = splitLine[2];
        students.push({
            name,
            age,
            grade
        });
    }

    for (const student of students) {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade}`);
    }
}