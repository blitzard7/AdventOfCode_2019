
DIVIDER = 3
SUBSTRACTOR = 2

def calculateFuel(mass):
    return (int)((mass / DIVIDER) - SUBSTRACTOR)

def readDataFromFile(path):
    return [line for line in open(path, 'r')]

def sumOfMassRequirements(totalFuel):
    fuelLeft = totalFuel
    sumFuel = 0
    while(fuelLeft > 0):
        fuelLeft = calculateFuel(fuelLeft)

        if (fuelLeft <= 0):
            break

        sumFuel += fuelLeft
    
    return sumFuel


data = readDataFromFile('../data/day01.txt')
data = [int(i) for i in data] 

# puzzle 1: 3233481
result = sum([calculateFuel(i) for i in data])

# puzzle 2: 4847351
sumFuel = sum([sumOfMassRequirements(i) for i in data])
