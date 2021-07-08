package Java;

class Main
{
    public static void main(String[] args) {
        System.out.println("Hola Mundo");
        Car car = new Car("ABC123", new Account("July","1545","54@hd.com"));
        car.printCarInformation();   
        
        UberX uberX = new UberX("ABC1234", new Account("July","1545","54@hd.com"),"Chevrolet","Aveo");         
        uberX.serPassenger(4);
        uberX.getPassenger();
        uberX.printCarInformation(); 
    }
}