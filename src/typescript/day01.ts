import * as fs from 'fs';

const calculateFuel = (mass: number): number => {
    const divider = 3;
    const substractor = 2;

    return Math.trunc((mass / divider)) - substractor;
}

const sumOfMassRequirements = (totalFuel: number): number => {
    let fuelLeft: number = totalFuel;
    let sum: number = 0;

    while (fuelLeft > 0) {
        fuelLeft = calculateFuel(fuelLeft);

        if (fuelLeft <= 0 ) 
            break; 

        sum += fuelLeft;
    }

    return sum;
}

const readDataFromFile = (path: string): string => fs.readFileSync(path, 'utf8');

const data = readDataFromFile("../data/day01.txt");
const dataList = data
    .split('\n')
    .map(x => Number(x));

// puzzle 1: 3233481
const totalMass = dataList.map(x => calculateFuel(x)).reduce((x, y) => x + y);

// puzzle 2: 4847351
const sumFuel = dataList.map(x => sumOfMassRequirements(x)).reduce((x, y) => x + y);