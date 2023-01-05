import java.util.*;

public class HourlyEmployee extends Employee {
    private float workOurPrice;
    private int hourRate;

    public HourlyEmployee(String name, String email, String phone, String department, String address, int salary,
            float workOurPrice, int hourRate) {
        super(name, email, phone, department, address, salary);
        this.workOurPrice = workOurPrice;
        this.hourRate = hourRate;
    }

    public float getWorkOurPrice() {
        return workOurPrice;
    }

    public void setWorkOurPrice(float workOurPrice) {
        this.workOurPrice = workOurPrice;
    }

    public int getHourRate() {
        return hourRate;
    }

    public void setHourRate(int hourRate) {
        this.hourRate = hourRate;
    }

    // ----------------- [ Overriding ]------------------

    public float getSalary() {
        return workOurPrice * hourRate;
    }

    // ----------------- [ Overloaded ]------------------

    public float getSalary(int more_lessHourWorkPrice) {
        return workOurPrice * hourRate + more_lessHourWorkPrice;
    }

}