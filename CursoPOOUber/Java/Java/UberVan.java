package Java;

import java.util.ArrayList;
import java.util.Map;

class UberVan extends Car
{
    Map<String, Map<String,Integer>> typeCarAccepted; 
    ArrayList<String> seatsMaterial;
    private Integer passenger;
  
    public UberVan( String license, Account driver, String brand, String model,Map<String, Map<String,Integer>> typeCarAccepted,ArrayList<String> seatsMaterial)
    {
        super(license,driver); // Referencia a la clase padre.
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;        
    }

    @Override
    public void serPassenger(Integer numPassengers) {    
        if(numPassengers == 6)
        {
          this.passenger = numPassengers; 
        }
        else{
            System.out.println("Número de pasajeros no es valido para una van.");
        }
    }
}