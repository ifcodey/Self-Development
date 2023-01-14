package Abstraction;

public class SUV extends Car {
    @Override
    void autopilot() {
        System.out.println("SUV autopilot");
    }

    @Override
    void StreamingService() {
        System.out.println("SUV StreamingService");
    }

    @Override
    void parkingSebsors() {
        System.out.println("SUV parkingSebsors");
    }
}
