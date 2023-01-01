public class SalariedEmployee extends Employee {

    float bouns;


    //    ----------------- [ Overriding ]------------------
    @Override
    public float getSalary() {
        return super.getSalary() + bouns;
    }

    //    ----------------- [ Overloaded ]------------------
    public float getSalary(int more_lessHourWorkPrice) {
        return super.getSalary() + bouns + more_lessHourWorkPrice;
    }

    public SalariedEmployee(String name, String email, String phone, String department, String address, int salary, float bouns) {
        super(name, email, phone, department, address, salary);
        this.bouns = bouns;
    }

    public float getBouns() {
        return bouns;
    }

    public void setBouns(float bouns) {
        this.bouns = bouns;
    }

    public static void printWithStatic() {
        System.out.println("Sub-Class");
    }

    public void printWithoutStatic() {
        System.out.println("Sub-Class");
    }
}
