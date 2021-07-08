from car import Car
from account import Account

if __name__ == "__main__":
    print("Hola Mundo")
    car = Car("PDJ59E",Account("July", "237817"))
    car.license = "ABC123"
    car.driver = "DriverTest"
    print(vars(car))