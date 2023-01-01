public class DaliyEmployee extends Employee {

    private float workDayPrice;
    private int dailyRate;

    public DaliyEmployee(String name, String email, String phone, String department, String address, int salary, float workDayPrice, int dailyRate) {
        super(name, email, phone, department, address, salary);
        this.workDayPrice = workDayPrice;
        this.dailyRate = dailyRate;
    }

    public float getWorkDayPrice() {
        return workDayPrice;
    }

    public void setWorkDayPrice(float workDayPrice) {
        this.workDayPrice = workDayPrice;
    }

    public int getDailyRate() {
        return dailyRate;
    }

    public void setDailyRate(int dailyRate) {
        this.dailyRate = dailyRate;
    }

    //    ----------------- [ Overriding ]------------------
    @Override
    public float getSalary() {
        return workDayPrice * dailyRate;
    }

    //    ----------------- [ Overloaded ]------------------

    public float getSalary(int more_lessHourWorkPrice) {
        return workDayPrice * dailyRate + more_lessHourWorkPrice;
    }
}
