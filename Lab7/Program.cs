using Lab7;

IGeneratorSpeed generatorSpeed = new GeneratorSpeed();
IVehicleGenerator vehicleGenerator = new VehicleGenerator(generatorSpeed);
ITheftRegistrationSystem theftRegistrationSystem = new TheftRegSystemSimulator();
ISpeedRegistrationSystem speedRegistrationSystem = new SpeedRegSystemSimulator();
CheckPoint checkPoint = new CheckPoint(theftRegistrationSystem, speedRegistrationSystem);


CheckPointSimulator.StartSimulation(vehicleGenerator, checkPoint, speedRegistrationSystem, theftRegistrationSystem);