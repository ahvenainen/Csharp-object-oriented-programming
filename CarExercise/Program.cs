// See https://aka.ms/new-console-template for more information
using CarExercise;

Car car = new Car();
car.askData();
car.Accelerate(10);
car.ShowCarInfo();
car.Brake(0.9);
car.ShowCarInfo();

Car secondCar = new Car();
secondCar.askData();
secondCar.Accelerate(100);
secondCar.Brake(0.9);
secondCar.ShowCarInfo();