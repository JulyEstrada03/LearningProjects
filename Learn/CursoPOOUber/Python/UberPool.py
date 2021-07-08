from car import Car

class UberPool(Car):
    brand = str
    model = str

    def __init__(self, license, driver, brand, model):
        super(license, driver).__init__()
        self.brand = brand
        self.model = model