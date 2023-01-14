package Abstraction;

public class Hatchback extends Car {

    @Override
    void autopilot() {
        System.out.println("Hatchback autopilot");
    }

    @Override
    void StreamingService() {
        System.out.println("Hatchback StreamingService");
    }

    @Override
    void parkingSebsors() {
        System.out.println("Hatchback parkingSebsors");
    }
}
