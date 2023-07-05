using Lab3;

IGeneratorSpeed generatorSpeed = new GeneratorSpeed();
IVehicleGenerator vehicleGenerator = new VehicleGenerator(generatorSpeed);
ITheftRegistrationSystem theftRegistrationSystem = new TheftRegSystemSimulator();
ISpeedRegistrationSystem speedRegistrationSystem = new SpeedRegSystemSimulator();
CheckPoint checkPoint = new CheckPoint(theftRegistrationSystem, speedRegistrationSystem);


CheckPointSimulator.startSimulation(vehicleGenerator, checkPoint, speedRegistrationSystem, theftRegistrationSystem);