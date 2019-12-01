"use strict";
exports.__esModule = true;
var fs = require("fs");
var calculateFuel = function (mass) {
    var divider = 3;
    var substractor = 2;
    return Math.trunc((mass / divider)) - substractor;
};
var sumOfMassRequirements = function (totalFuel) {
    var fuelLeft = totalFuel;
    var sum = 0;
    while (fuelLeft > 0) {
        fuelLeft = calculateFuel(fuelLeft);
        if (fuelLeft <= 0)
            break;
        sum += fuelLeft;
    }
    return sum;
};
var readDataFromFile = function (path) { return fs.readFileSync(path, 'utf8'); };
var data = readDataFromFile("../data/day01.txt");
var dataList = data
    .split('\n')
    .map(function (x) { return Number(x); });
// puzzle 1: 3233481
var totalMass = dataList.map(function (x) { return calculateFuel(x); }).reduce(function (x, y) { return x + y; });
var sumFuel = dataList.map(function (x) { return sumOfMassRequirements(x); }).reduce(function (x, y) { return x + y; });
console.log(sumFuel);
